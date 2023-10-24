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
    public partial class Form3 : Form
    {
        #region Constructor

        public Form3(List<string> feasibilities)
        {
            InitializeComponent();

            // automatically set the window icon
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            for (int i = 0; i < feasibilities.Count; i++)
            {
                listBox1.Items.Add(feasibilities[i]);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Draw each list item in green or red color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listbox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            var item = listBox1.Items[e.Index];
            if (item.ToString().Contains("False"))
                e.Graphics.FillRectangle(new SolidBrush(Color.Tomato), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        #endregion
    }
}
