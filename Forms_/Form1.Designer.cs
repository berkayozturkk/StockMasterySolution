namespace Forms_
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
            btnGetData = new Button();
            txtStartDate = new Label();
            label2 = new Label();
            label3 = new Label();
            btnStartDate = new TextBox();
            btnEndDate = new TextBox();
            btnProductCode = new TextBox();
            btnExport = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetData
            // 
            btnGetData.Location = new Point(14, 159);
            btnGetData.Name = "btnGetData";
            btnGetData.Size = new Size(206, 32);
            btnGetData.TabIndex = 0;
            btnGetData.Text = "LİSTELE";
            btnGetData.UseVisualStyleBackColor = true;
            btnGetData.Click += btnGetData_Click;
            // 
            // txtStartDate
            // 
            txtStartDate.AutoSize = true;
            txtStartDate.Location = new Point(14, 36);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(100, 19);
            txtStartDate.TabIndex = 1;
            txtStartDate.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 77);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 2;
            label2.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 3;
            label3.Text = "Ürün Kodu";
            // 
            // btnStartDate
            // 
            btnStartDate.Location = new Point(120, 29);
            btnStartDate.Name = "btnStartDate";
            btnStartDate.Size = new Size(100, 26);
            btnStartDate.TabIndex = 4;
            // 
            // btnEndDate
            // 
            btnEndDate.Location = new Point(120, 74);
            btnEndDate.Name = "btnEndDate";
            btnEndDate.Size = new Size(100, 26);
            btnEndDate.TabIndex = 5;
            // 
            // btnProductCode
            // 
            btnProductCode.Location = new Point(120, 119);
            btnProductCode.Name = "btnProductCode";
            btnProductCode.Size = new Size(100, 26);
            btnProductCode.TabIndex = 6;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(703, 12);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(85, 23);
            btnExport.TabIndex = 7;
            btnExport.Text = "Dışa Aktar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(521, 397);
            dataGridView1.TabIndex = 8;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExport);
            Controls.Add(btnProductCode);
            Controls.Add(btnEndDate);
            Controls.Add(btnStartDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStartDate);
            Controls.Add(btnGetData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetData;
        private Label txtStartDate;
        private Label label2;
        private Label label3;
        private TextBox btnStartDate;
        private TextBox btnEndDate;
        private TextBox btnProductCode;
        private Button btnExport;
        private DataGridView dataGridView1;
    }
}