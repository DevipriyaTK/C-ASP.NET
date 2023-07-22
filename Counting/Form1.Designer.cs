namespace Counting
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
            label1 = new Label();
            label2 = new Label();
            txtStartFrom = new TextBox();
            txtTo = new TextBox();
            btnCount = new Button();
            btnExit = new Button();
            lblDivisibleTerm = new Label();
            cmbDivisibleTerm = new ComboBox();
            txtDivisibleNumbers = new TextBox();
            gbSelectColour = new GroupBox();
            rbGreen = new RadioButton();
            rbBlue = new RadioButton();
            rbRed = new RadioButton();
            rbBlack = new RadioButton();
            chBold = new CheckBox();
            chItalic = new CheckBox();
            gbSelectColour.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Start From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(260, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(30, 19);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // txtStartFrom
            // 
            txtStartFrom.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartFrom.Location = new Point(107, 21);
            txtStartFrom.Margin = new Padding(4);
            txtStartFrom.Name = "txtStartFrom";
            txtStartFrom.Size = new Size(141, 26);
            txtStartFrom.TabIndex = 2;
            txtStartFrom.KeyPress += txtStartFrom_KeyPress;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTo.Location = new Point(296, 21);
            txtTo.Margin = new Padding(4);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(141, 26);
            txtTo.TabIndex = 3;
            txtTo.KeyPress += txtTo_KeyPress;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCount.Location = new Point(19, 118);
            btnCount.Margin = new Padding(4);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(114, 42);
            btnCount.TabIndex = 4;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(168, 118);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(114, 42);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDivisibleTerm
            // 
            lblDivisibleTerm.AutoSize = true;
            lblDivisibleTerm.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDivisibleTerm.Location = new Point(19, 72);
            lblDivisibleTerm.Margin = new Padding(4, 0, 4, 0);
            lblDivisibleTerm.Name = "lblDivisibleTerm";
            lblDivisibleTerm.Size = new Size(151, 19);
            lblDivisibleTerm.TabIndex = 6;
            lblDivisibleTerm.Text = "Divisible Number";
            // 
            // cmbDivisibleTerm
            // 
            cmbDivisibleTerm.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDivisibleTerm.FormattingEnabled = true;
            cmbDivisibleTerm.Location = new Point(221, 69);
            cmbDivisibleTerm.Margin = new Padding(4);
            cmbDivisibleTerm.Name = "cmbDivisibleTerm";
            cmbDivisibleTerm.Size = new Size(171, 27);
            cmbDivisibleTerm.TabIndex = 7;
            cmbDivisibleTerm.SelectedIndexChanged += cmbDivisibleTerm_SelectedIndexChanged;
            // 
            // txtDivisibleNumbers
            // 
            txtDivisibleNumbers.Dock = DockStyle.Bottom;
            txtDivisibleNumbers.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDivisibleNumbers.Location = new Point(0, 183);
            txtDivisibleNumbers.Margin = new Padding(4);
            txtDivisibleNumbers.Multiline = true;
            txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            txtDivisibleNumbers.Size = new Size(644, 163);
            txtDivisibleNumbers.TabIndex = 8;
            // 
            // gbSelectColour
            // 
            gbSelectColour.Controls.Add(rbGreen);
            gbSelectColour.Controls.Add(rbBlue);
            gbSelectColour.Controls.Add(rbRed);
            gbSelectColour.Controls.Add(rbBlack);
            gbSelectColour.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbSelectColour.Location = new Point(444, 12);
            gbSelectColour.Name = "gbSelectColour";
            gbSelectColour.Size = new Size(200, 167);
            gbSelectColour.TabIndex = 9;
            gbSelectColour.TabStop = false;
            gbSelectColour.Text = "Select Colour";
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(7, 116);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(76, 23);
            rbGreen.TabIndex = 3;
            rbGreen.Text = "Green";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // rbBlue
            // 
            rbBlue.AutoSize = true;
            rbBlue.Location = new Point(7, 89);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(64, 23);
            rbBlue.TabIndex = 2;
            rbBlue.Text = "Blue";
            rbBlue.UseVisualStyleBackColor = true;
            rbBlue.CheckedChanged += rbBlue_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(7, 62);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(59, 23);
            rbRed.TabIndex = 1;
            rbRed.Text = "Red";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // rbBlack
            // 
            rbBlack.AutoSize = true;
            rbBlack.Checked = true;
            rbBlack.Location = new Point(7, 37);
            rbBlack.Name = "rbBlack";
            rbBlack.Size = new Size(73, 23);
            rbBlack.TabIndex = 0;
            rbBlack.TabStop = true;
            rbBlack.Text = "Black";
            rbBlack.UseVisualStyleBackColor = true;
            rbBlack.CheckedChanged += rbBlack_CheckedChanged;
            // 
            // chBold
            // 
            chBold.AutoSize = true;
            chBold.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chBold.Location = new Point(310, 118);
            chBold.Name = "chBold";
            chBold.Size = new Size(65, 23);
            chBold.TabIndex = 10;
            chBold.Text = "Bold";
            chBold.UseVisualStyleBackColor = true;
            chBold.CheckedChanged += chBold_CheckedChanged;
            // 
            // chItalic
            // 
            chItalic.AutoSize = true;
            chItalic.Font = new Font("Bookman Old Style", 12F, FontStyle.Italic, GraphicsUnit.Point);
            chItalic.Location = new Point(310, 148);
            chItalic.Name = "chItalic";
            chItalic.Size = new Size(64, 22);
            chItalic.TabIndex = 11;
            chItalic.Text = "Italic";
            chItalic.UseVisualStyleBackColor = true;
            chItalic.CheckedChanged += chItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 346);
            Controls.Add(chItalic);
            Controls.Add(chBold);
            Controls.Add(gbSelectColour);
            Controls.Add(txtDivisibleNumbers);
            Controls.Add(cmbDivisibleTerm);
            Controls.Add(lblDivisibleTerm);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(txtTo);
            Controls.Add(txtStartFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Counting Numbers";
            Load += Form1_Load;
            gbSelectColour.ResumeLayout(false);
            gbSelectColour.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStartFrom;
        private TextBox txtTo;
        private Button btnCount;
        private Button btnExit;
        private Label lblDivisibleTerm;
        private ComboBox cmbDivisibleTerm;
        private TextBox txtDivisibleNumbers;
        private GroupBox gbSelectColour;
        private RadioButton rbGreen;
        private RadioButton rbBlue;
        private RadioButton rbRed;
        private RadioButton rbBlack;
        private CheckBox chBold;
        private CheckBox chItalic;
    }
}