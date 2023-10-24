using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauseEffectGraph
{
    public partial class Form2 : Form
    {
        #region Attributes

        // attributes received from form 1
        List<Node> causes;
        List<Node> effects;
        List<Node> intermediates;
        List<Relation> logicalRelations = new List<Relation>();
        List<Relation> dependencyRelations = new List<Relation>();

        Table table;
        bool minimalSign = false, inactiveSign = false;
        int minimizationAlgorithm = 1;

        #endregion

        #region Constructor

        public Form2(ref List<Node> c, ref List<Node> e, ref List<Node> i, ref List<Relation> r, bool exportTestCases)
        {
            InitializeComponent();

            // automatically set the window icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // receive attributes from the previous form
            causes = c;
            effects = e;
            intermediates = i;

            // for easier handling, split relations into two lists
            List<string> logical = new List<string>()
            { "DIR", "NOT", "AND", "OR", "NAND", "NOR" };

            foreach (var relation in r)
            {
                if (logical.Contains(relation.Type))
                    logicalRelations.Add(relation);
                else
                    dependencyRelations.Add(relation);
            }

            // create test case table
            table = new Table(ref causes, ref effects, ref intermediates, ref logicalRelations, ref dependencyRelations);

            // export test cases to file for easier readability
            if (exportTestCases)
                ExportTestCases();

            // insert test case values into the dataGridView control
            FillTheTable();

            // set label values
            label2.Text = (table.NoOfCauses + table.NoOfEffects).ToString();
            label4.Text = Math.Pow(2, table.NoOfCauses).ToString();
            label6.Text = table.FeasibleTestCases.Count.ToString();
            label8.Text = table.MinimumCases.Count.ToString();
            label9.Text = table.FeasibleTestCases.FindAll(c => !c.GetRange(table.NoOfCauses, table.NoOfEffects).Contains("1")).Count.ToString();
            label12.Text = table.Elapsed.ToString() + " ms";
        }

        #endregion

        #region Draw test case suite

        /// <summary>
        /// Refresh the table contents
        /// </summary>
        void FillTheTable()
        {
            label8.Text = table.MinimumCases.Count.ToString();

            List<List<string>> listForDrawing;

            listForDrawing = table.FeasibleTestCases;
            table.CreateHeader();

            // refresh the datagrid
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            
            // setup the columns
            for (int i = 0; i < table.HeaderRow.Count; i++)
            {
                // add the column named T1, T2, ...
                try
                {
                    dataGridView1.Columns.Add(table.HeaderRow[i], table.HeaderRow[i]);
                }
                catch (Exception)
                {
                    MessageBox.Show("The number of test cases is too big and they cannot be shown! Try again in fast mode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.Columns[i].HeaderCell.Style.BackColor = Color.LightSteelBlue;
                //dataGridView1.Columns[i].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 14F);

                // if minimum combinations need to be colored, change the color of that column to green
                if (minimalSign && table.MinimumCasesIndexes.Contains(i))
                {
                    dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.Green;
                }

                // if combinations without active effects need to be colored, change the color of that column to red
                else if (inactiveSign && !listForDrawing[i].GetRange(table.NoOfCauses, table.NoOfEffects).Contains("1"))
                {
                    dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.Red;
                }

                // not minimum - white color
                else
                {
                    dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.White;
                }
            }

            // transpose the test case combination list
            listForDrawing = Transpose(listForDrawing);
            
            // setup rows
            for (int i = 0; i < listForDrawing.Count; i++)
            {
                // add all combinations to the table
                dataGridView1.Rows.Add(listForDrawing[i].ToArray());

                // add the name to the row header
                dataGridView1.Rows[i].HeaderCell.Value = table.HeaderColumn[i];

                // color the header
                dataGridView1.Rows[i].HeaderCell.Style.BackColor = Color.LightSteelBlue;
                //dataGridView1.Rows[i].HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 14F);

            }

            // change the appearance of the top left corner cell
            dataGridView1.TopLeftHeaderCell.Style.BackColor = Color.LightSteelBlue;
            //dataGridView1.TopLeftHeaderCell.Style.Font = new Font("Microsoft Sans Serif", 14F);

            // deselect the first cell (selected by default)
            dataGridView1.ClearSelection();

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Cells[0].Selected = false;
        }

        /// <summary>
        /// Show/hide minimum test cases (color them in green) and change minimization algorithm to unoptimized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            minimalSign = checkBox1.Checked || checkBox3.Checked;

            if (checkBox1.Checked)
            {
                if (checkBox3.Checked)
                    checkBox3.Checked = false;

                minimizationAlgorithm = 1;
                table.ChangeMinimizationAlgorithm(minimizationAlgorithm);
            }

            FillTheTable();
        }

        /// <summary>
        /// Show/hide minimum test cases (color them in green) and change minimization algorithm to optimized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            minimalSign = checkBox1.Checked || checkBox3.Checked;

            if (checkBox3.Checked)
            {
                if (checkBox1.Checked)
                    checkBox1.Checked = false;

                minimizationAlgorithm = 2;
                table.ChangeMinimizationAlgorithm(minimizationAlgorithm);
            }

            FillTheTable();
        }

        /// <summary>
        /// Show/hide test cases without active effects (color them in red)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            inactiveSign = checkBox2.Checked;

            FillTheTable();
        }

        /// <summary>
        /// Helper method for transposing the table
        /// since the table needs to be drawn in such a way
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lists"></param>
        /// <returns></returns>
        public static List<List<T>> Transpose<T>(List<List<T>> lists)
        {
            var longest = lists.Any() ? lists.Max(l => l.Count) : 0;
            List<List<T>> outer = new List<List<T>>(longest);
            for (int i = 0; i < longest; i++)
                outer.Add(new List<T>(lists.Count));
            for (int j = 0; j < lists.Count; j++)
                for (int i = 0; i < longest; i++)
                    outer[i].Add(lists[j].Count > i ? lists[j][i] : default(T));
            return outer;
        }

        #endregion

        #region Metrics calculation

        /// <summary>
        /// Enter form for showing metrics values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4(table);
            f.Show();
        }

        #endregion

        #region Export test cases

        /// <summary>
        /// Export all test cases to TXT
        /// </summary>
        public void ExportTestCases()
        {
            try
            {
                string EXPORT = "\t";

                // only feasible test cases will be exported
                var listForDrawing = table.FeasibleTestCases;
                table.CreateHeader();

                foreach (var columnName in table.HeaderColumn)
                    EXPORT += columnName + "\t";

                EXPORT += "\n";

                for (int i = 0; i < listForDrawing.Count; i++)
                {
                    EXPORT += table.HeaderRow[i] + "\t";
                    foreach (var element in listForDrawing[i])
                        EXPORT += element + "\t";
                    EXPORT += "\n";
                }

                // creating a new file
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        File.WriteAllText(fbd.SelectedPath + "\\testCases.txt", EXPORT);
                        MessageBox.Show(this, "Export succeffully completed. File path: " + fbd.SelectedPath + "\\testCases.txt!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("The export could not be completed successfully. Error message: " + exception.Message, "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion
    }
}
