
namespace CauseEffectGraph
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(17, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(785, 229);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listbox1_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make sure to correct all relations marked as infeasible by the feasibility predic" +
    "tion module. Otherwise, the test suite derivation might fail.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(837, 328);
            this.MinimumSize = new System.Drawing.Size(837, 328);
            this.Name = "Form3";
            this.Text = "Feasibility analysis module";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}