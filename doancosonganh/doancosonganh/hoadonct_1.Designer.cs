namespace doancosonganh
{
    partial class hoadonct_1
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
            this.dataGridViewhoadonct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxmahoadon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxsotienconlai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxthanhtoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxtongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhoadonct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewhoadonct
            // 
            this.dataGridViewhoadonct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewhoadonct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewhoadonct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewhoadonct.Location = new System.Drawing.Point(1, 171);
            this.dataGridViewhoadonct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewhoadonct.Name = "dataGridViewhoadonct";
            this.dataGridViewhoadonct.RowTemplate.Height = 24;
            this.dataGridViewhoadonct.Size = new System.Drawing.Size(1316, 414);
            this.dataGridViewhoadonct.TabIndex = 0;
            this.dataGridViewhoadonct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewhoadonct_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSANPHAM";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIA";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // tbxmahoadon
            // 
            this.tbxmahoadon.Location = new System.Drawing.Point(134, 129);
            this.tbxmahoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxmahoadon.Name = "tbxmahoadon";
            this.tbxmahoadon.Size = new System.Drawing.Size(213, 27);
            this.tbxmahoadon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 1);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "HÓA ĐƠN CHI TIẾT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.tbxsotienconlai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxthanhtoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxtongtien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 592);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 191);
            this.panel1.TabIndex = 5;
            // 
            // tbxsotienconlai
            // 
            this.tbxsotienconlai.Location = new System.Drawing.Point(187, 150);
            this.tbxsotienconlai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxsotienconlai.Name = "tbxsotienconlai";
            this.tbxsotienconlai.Size = new System.Drawing.Size(407, 27);
            this.tbxsotienconlai.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(17, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số tiền còn lại";
            // 
            // tbxthanhtoan
            // 
            this.tbxthanhtoan.Location = new System.Drawing.Point(187, 89);
            this.tbxthanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxthanhtoan.Name = "tbxthanhtoan";
            this.tbxthanhtoan.Size = new System.Drawing.Size(407, 27);
            this.tbxthanhtoan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thanh toán";
            // 
            // tbxtongtien
            // 
            this.tbxtongtien.Location = new System.Drawing.Point(187, 24);
            this.tbxtongtien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxtongtien.Name = "tbxtongtien";
            this.tbxtongtien.Size = new System.Drawing.Size(407, 27);
            this.tbxtongtien.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên nhân viên";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(134, 75);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 27);
            this.textBox4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(643, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 185);
            this.panel2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 27);
            this.comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Khuyến mãi";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(509, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "In hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(325, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tính tiền";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hoadonct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxmahoadon);
            this.Controls.Add(this.dataGridViewhoadonct);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "hoadonct";
            this.Text = "hoadonct";
            this.Load += new System.EventHandler(this.hoadonct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewhoadonct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewhoadonct;
        private System.Windows.Forms.TextBox tbxmahoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxsotienconlai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxthanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxtongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}