namespace doancosonganh
{
    partial class tinhluong
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxmanhanvien = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Danhsachnhanvien = new System.Windows.Forms.ListBox();
            this.numericUpDownsogio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxchucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxluong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxtongluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lưu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xóa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsogio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lương mặc định";
            // 
            // tbxmanhanvien
            // 
            this.tbxmanhanvien.Location = new System.Drawing.Point(144, 45);
            this.tbxmanhanvien.Name = "tbxmanhanvien";
            this.tbxmanhanvien.Size = new System.Drawing.Size(148, 27);
            this.tbxmanhanvien.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Danhsachnhanvien);
            this.groupBox1.Controls.Add(this.numericUpDownsogio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxchucvu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxluong);
            this.groupBox1.Controls.Add(this.tbxmanhanvien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 238);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tính lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(716, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // Danhsachnhanvien
            // 
            this.Danhsachnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Danhsachnhanvien.FormattingEnabled = true;
            this.Danhsachnhanvien.ItemHeight = 18;
            this.Danhsachnhanvien.Location = new System.Drawing.Point(719, 57);
            this.Danhsachnhanvien.Name = "Danhsachnhanvien";
            this.Danhsachnhanvien.Size = new System.Drawing.Size(309, 148);
            this.Danhsachnhanvien.TabIndex = 9;
            this.Danhsachnhanvien.SelectedIndexChanged += new System.EventHandler(this.Danhsachnhanvien_SelectedIndexChanged);
            // 
            // numericUpDownsogio
            // 
            this.numericUpDownsogio.Location = new System.Drawing.Point(460, 145);
            this.numericUpDownsogio.Name = "numericUpDownsogio";
            this.numericUpDownsogio.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownsogio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(342, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số giờ";
            // 
            // tbxchucvu
            // 
            this.tbxchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxchucvu.Location = new System.Drawing.Point(144, 142);
            this.tbxchucvu.Name = "tbxchucvu";
            this.tbxchucvu.Size = new System.Drawing.Size(148, 24);
            this.tbxchucvu.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chức vụ";
            // 
            // tbxluong
            // 
            this.tbxluong.Location = new System.Drawing.Point(460, 45);
            this.tbxluong.Name = "tbxluong";
            this.tbxluong.Size = new System.Drawing.Size(148, 27);
            this.tbxluong.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxtongluong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(23, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 73);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng lương";
            // 
            // tbxtongluong
            // 
            this.tbxtongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtongluong.Location = new System.Drawing.Point(188, 32);
            this.tbxtongluong.Name = "tbxtongluong";
            this.tbxtongluong.ReadOnly = true;
            this.tbxtongluong.Size = new System.Drawing.Size(368, 24);
            this.tbxtongluong.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(30, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.lưu,
            this.Xóa});
            this.dataGridView1.Location = new System.Drawing.Point(23, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 180);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENNHANVIEN";
            this.Column3.HeaderText = "Tên nhân viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIOITINH";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LUONG";
            this.Column5.HeaderText = "Lương";
            this.Column5.Name = "Column5";
            // 
            // lưu
            // 
            this.lưu.HeaderText = "Lưu";
            this.lưu.Name = "lưu";
            this.lưu.Text = "Lưu";
            this.lưu.UseColumnTextForButtonValue = true;
            this.lưu.Visible = false;
            // 
            // Xóa
            // 
            this.Xóa.HeaderText = "Xóa";
            this.Xóa.Name = "Xóa";
            this.Xóa.Text = "Xoá";
            this.Xóa.UseColumnTextForButtonValue = true;
            this.Xóa.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(20, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chi tiết tính lương";
            // 
            // button3
            // 
            this.button3.Image = global::doancosonganh.Properties.Resources.exit__1_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(897, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thoát";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::doancosonganh.Properties.Resources.wallet;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(742, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tính lương";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tinhluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 674);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "tinhluong";
            this.Text = "tinhluong";
            this.Load += new System.EventHandler(this.tinhluong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsogio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxmanhanvien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Danhsachnhanvien;
        private System.Windows.Forms.NumericUpDown numericUpDownsogio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxluong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxtongluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn lưu;
        private System.Windows.Forms.DataGridViewButtonColumn Xóa;
    }
}