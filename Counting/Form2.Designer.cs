namespace Counting
{
    partial class Form2
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
            btnFillList = new Button();
            txtNumberList = new TextBox();
            cmbDaysList = new ComboBox();
            gvDays = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvDays).BeginInit();
            SuspendLayout();
            // 
            // btnFillList
            // 
            btnFillList.Location = new Point(225, 46);
            btnFillList.Name = "btnFillList";
            btnFillList.Size = new Size(97, 39);
            btnFillList.TabIndex = 0;
            btnFillList.Text = "Fill List";
            btnFillList.UseVisualStyleBackColor = true;
            btnFillList.Click += btnFillList_Click;
            // 
            // txtNumberList
            // 
            txtNumberList.Location = new Point(39, 46);
            txtNumberList.Multiline = true;
            txtNumberList.Name = "txtNumberList";
            txtNumberList.Size = new Size(155, 160);
            txtNumberList.TabIndex = 1;
            // 
            // cmbDaysList
            // 
            cmbDaysList.FormattingEnabled = true;
            cmbDaysList.Location = new Point(225, 125);
            cmbDaysList.Name = "cmbDaysList";
            cmbDaysList.Size = new Size(121, 28);
            cmbDaysList.TabIndex = 2;
            cmbDaysList.SelectedIndexChanged += cmbDaysList_SelectedIndexChanged;
            // 
            // gvDays
            // 
            gvDays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDays.Location = new Point(225, 171);
            gvDays.Name = "gvDays";
            gvDays.RowTemplate.Height = 25;
            gvDays.Size = new Size(328, 189);
            gvDays.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 372);
            Controls.Add(gvDays);
            Controls.Add(cmbDaysList);
            Controls.Add(txtNumberList);
            Controls.Add(btnFillList);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)gvDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFillList;
        private TextBox txtNumberList;
        private ComboBox cmbDaysList;
        private DataGridView gvDays;
    }
}