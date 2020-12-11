namespace doancosonganh
{
    partial class baocaothongke
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxbaocao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnxembaocao = new System.Windows.Forms.Button();
            this.tbxsanpham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerngayden = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerngaytu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridViewnhapkho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbxbaocao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnxembaocao);
            this.groupBox1.Controls.Add(this.tbxsanpham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxloai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerngayden);
            this.groupBox1.Controls.Add(this.dateTimePickerngaytu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1204, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ lọc";
            // 
            // cbxbaocao
            // 
            this.cbxbaocao.FormattingEnabled = true;
            this.cbxbaocao.Items.AddRange(new object[] {
            "--Chọn báo cáo--",
            "Báo cáo nhập kho",
            "Báo cáo hàng bán chạy",
            "Báo cáo doanh thu"});
            this.cbxbaocao.Location = new System.Drawing.Point(645, 107);
            this.cbxbaocao.Name = "cbxbaocao";
            this.cbxbaocao.Size = new System.Drawing.Size(193, 27);
            this.cbxbaocao.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Báo cáo";
            // 
            // btnxembaocao
            // 
            this.btnxembaocao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnxembaocao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxembaocao.Location = new System.Drawing.Point(874, 107);
            this.btnxembaocao.Name = "btnxembaocao";
            this.btnxembaocao.Size = new System.Drawing.Size(140, 37);
            this.btnxembaocao.TabIndex = 11;
            this.btnxembaocao.Text = "Xem báo cáo";
            this.btnxembaocao.UseVisualStyleBackColor = false;
            this.btnxembaocao.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxsanpham
            // 
            this.tbxsanpham.Location = new System.Drawing.Point(984, 26);
            this.tbxsanpham.Name = "tbxsanpham";
            this.tbxsanpham.Size = new System.Drawing.Size(203, 27);
            this.tbxsanpham.TabIndex = 10;
            this.tbxsanpham.Text = "Nhập mã, tên";
            this.tbxsanpham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxsanpham_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(892, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sản phẩm";
            // 
            // cbxloai
            // 
            this.cbxloai.FormattingEnabled = true;
            this.cbxloai.Items.AddRange(new object[] {
            "--Chọn tất cả--"});
            this.cbxloai.Location = new System.Drawing.Point(645, 23);
            this.cbxloai.Name = "cbxloai";
            this.cbxloai.Size = new System.Drawing.Size(193, 27);
            this.cbxloai.TabIndex = 8;
            this.cbxloai.SelectedIndexChanged += new System.EventHandler(this.cbxloai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại";
            // 
            // dateTimePickerngayden
            // 
            this.dateTimePickerngayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerngayden.Location = new System.Drawing.Point(300, 54);
            this.dateTimePickerngayden.Name = "dateTimePickerngayden";
            this.dateTimePickerngayden.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerngayden.TabIndex = 6;
            this.dateTimePickerngayden.Value = new System.DateTime(2020, 11, 30, 0, 0, 0, 0);
            // 
            // dateTimePickerngaytu
            // 
            this.dateTimePickerngaytu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerngaytu.Location = new System.Drawing.Point(50, 53);
            this.dateTimePickerngaytu.Name = "dateTimePickerngaytu";
            this.dateTimePickerngaytu.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerngaytu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "đến ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.dataGridViewnhapkho);
            this.groupBox2.Location = new System.Drawing.Point(13, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1204, 434);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(6, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // dataGridViewnhapkho
            // 
            this.dataGridViewnhapkho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewnhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnhapkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column5});
            this.dataGridViewnhapkho.Location = new System.Drawing.Point(1009, 0);
            this.dataGridViewnhapkho.Name = "dataGridViewnhapkho";
            this.dataGridViewnhapkho.RowTemplate.Height = 24;
            this.dataGridViewnhapkho.Size = new System.Drawing.Size(203, 80);
            this.dataGridViewnhapkho.TabIndex = 0;
            this.dataGridViewnhapkho.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewnhapkho_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MASANPHAM";
            this.Column3.HeaderText = "Mã sản phẩm ";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSANPHAM";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LOAISANPHAM";
            this.Column4.HeaderText = "Loại";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SOLUONG";
            this.Column7.HeaderText = "Số lượng nhập";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIA";
            this.Column5.HeaderText = "Thành tiền";
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi tiết";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1032, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "In báo cáo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // baocaothongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1229, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "baocaothongke";
            this.Text = "baocaothongke";
            this.Load += new System.EventHandler(this.baocaothongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhapkho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewnhapkho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxbaocao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnxembaocao;
        private System.Windows.Forms.TextBox tbxsanpham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerngayden;
        private System.Windows.Forms.DateTimePicker dateTimePickerngaytu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
    }
}