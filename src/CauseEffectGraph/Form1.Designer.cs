
namespace CauseEffectGraph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button17 = new System.Windows.Forms.Button();
            this.buttonDrop = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button19 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(23, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Location = new System.Drawing.Point(23, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Effect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button20);
            this.panel1.Location = new System.Drawing.Point(353, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 436);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button20
            // 
            this.button20.AllowDrop = true;
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackColor = System.Drawing.Color.Snow;
            this.button20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button20.Location = new System.Drawing.Point(766, 410);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(74, 27);
            this.button20.TabIndex = 20;
            this.button20.Text = "Reset";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(312, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nodes";
            // 
            // button18
            // 
            this.button18.AllowDrop = true;
            this.button18.Location = new System.Drawing.Point(23, 82);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 28);
            this.button18.TabIndex = 4;
            this.button18.Text = "Intermediate";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button18_MouseDown);
            // 
            // button14
            // 
            this.button14.AllowDrop = true;
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Location = new System.Drawing.Point(186, 77);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(71, 25);
            this.button14.TabIndex = 3;
            this.button14.Text = "Delete";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(139, 20);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(168, 40);
            this.checkedListBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.checkedListBox2);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(3, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(312, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logical relations";
            // 
            // button15
            // 
            this.button15.AllowDrop = true;
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(186, 100);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(81, 25);
            this.button15.TabIndex = 5;
            this.button15.Text = "Delete";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button8
            // 
            this.button8.AllowDrop = true;
            this.button8.Location = new System.Drawing.Point(72, 84);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "NOR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.HorizontalScrollbar = true;
            this.checkedListBox2.Location = new System.Drawing.Point(139, 20);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.ScrollAlwaysVisible = true;
            this.checkedListBox2.Size = new System.Drawing.Size(168, 40);
            this.checkedListBox2.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.Location = new System.Drawing.Point(5, 84);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "NAND";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.Location = new System.Drawing.Point(5, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "DIR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AllowDrop = true;
            this.button5.Location = new System.Drawing.Point(72, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "NOT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AllowDrop = true;
            this.button4.Location = new System.Drawing.Point(72, 52);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "OR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AllowDrop = true;
            this.button3.Location = new System.Drawing.Point(5, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "AND";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkedListBox3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(3, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(312, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Constraints";
            // 
            // button16
            // 
            this.button16.AllowDrop = true;
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(186, 102);
            this.button16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(81, 25);
            this.button16.TabIndex = 9;
            this.button16.Text = "Delete";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.checkBox1.Location = new System.Drawing.Point(233, 12);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.MinimumSize = new System.Drawing.Size(52, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 26);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Yes";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.HorizontalScrollbar = true;
            this.checkedListBox3.Location = new System.Drawing.Point(139, 43);
            this.checkedListBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.ScrollAlwaysVisible = true;
            this.checkedListBox3.Size = new System.Drawing.Size(168, 40);
            this.checkedListBox3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Show constraints";
            // 
            // button13
            // 
            this.button13.AllowDrop = true;
            this.button13.Location = new System.Drawing.Point(5, 102);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(121, 28);
            this.button13.TabIndex = 12;
            this.button13.Text = "EXC Δ INC";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.AllowDrop = true;
            this.button12.Location = new System.Drawing.Point(72, 70);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 28);
            this.button12.TabIndex = 11;
            this.button12.Text = "MSK";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.AllowDrop = true;
            this.button11.Location = new System.Drawing.Point(5, 70);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 28);
            this.button11.TabIndex = 10;
            this.button11.Text = "REQ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.AllowDrop = true;
            this.button10.Location = new System.Drawing.Point(72, 38);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 28);
            this.button10.TabIndex = 9;
            this.button10.Text = "INC";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.AllowDrop = true;
            this.button9.Location = new System.Drawing.Point(5, 38);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = "EXC";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.AllowDrop = true;
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFinish.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonFinish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFinish.Location = new System.Drawing.Point(16, 413);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(74, 27);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = false;
            this.buttonFinish.Visible = false;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1199, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 21);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSplitButton1.Size = new System.Drawing.Size(118, 24);
            this.toolStripSplitButton1.Text = "Import/Export";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem1.Text = "Import";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "Export";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 398);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1149, 1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button17
            // 
            this.button17.AllowDrop = true;
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button17.Location = new System.Drawing.Point(211, 416);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(121, 28);
            this.button17.TabIndex = 15;
            this.button17.Text = "Create table";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttonDrop
            // 
            this.buttonDrop.AllowDrop = true;
            this.buttonDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDrop.BackColor = System.Drawing.Color.Coral;
            this.buttonDrop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDrop.Location = new System.Drawing.Point(16, 438);
            this.buttonDrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDrop.Name = "buttonDrop";
            this.buttonDrop.Size = new System.Drawing.Size(74, 27);
            this.buttonDrop.TabIndex = 19;
            this.buttonDrop.Text = "Drop";
            this.buttonDrop.UseVisualStyleBackColor = false;
            this.buttonDrop.Visible = false;
            this.buttonDrop.Click += new System.EventHandler(this.buttonDrop_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(218, 443);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 19);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Export test cases";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button19
            // 
            this.button19.AllowDrop = true;
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button19.Location = new System.Drawing.Point(96, 416);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(109, 46);
            this.button19.TabIndex = 21;
            this.button19.Text = "Feasibility\r\ncheck";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 490);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.buttonDrop);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Cause-effect graph specification module";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonDrop;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button19;
    }
}

