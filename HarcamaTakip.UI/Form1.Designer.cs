namespace HarcamaTakip.UI
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
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            btnSave = new Button();
            dgvExpenses = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 34);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(62, 17);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 31);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 25);
            txtDescription.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 79);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(41, 17);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Tutar:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(110, 76);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 25);
            txtAmount.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 125);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 17);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Kategori:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(110, 121);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 25);
            txtCategory.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(110, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Harcamayı Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(280, 31);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.Size = new Size(450, 283);
            dgvExpenses.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(110, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnDelete);
            Controls.Add(dgvExpenses);
            Controls.Add(btnSave);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kişisel Harcama Takip Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblCategory;
        private TextBox txtCategory;
        private Button btnSave;
        private DataGridView dgvExpenses;
        private Button btnDelete;
    }
}
