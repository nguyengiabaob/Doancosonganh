namespace doancosonganh
{
    partial class Formnhapkho
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
            this.dataGridViewnhapkho = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxnguyenlieu = new System.Windows.Forms.ComboBox();
            this.textBoxtenhang = new System.Windows.Forms.TextBox();
            this.cbxthang = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhapkho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridViewnhapkho
            // 
            this.dataGridViewnhapkho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewnhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewnhapkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridViewnhapkho.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewnhapkho.Name = "dataGridViewnhapkho";
            this.dataGridViewnhapkho.RowTemplate.Height = 24;
            this.dataGridViewnhapkho.Size = new System.Drawing.Size(1400, 533);
            this.dataGridViewnhapkho.TabIndex = 10;
            this.dataGridViewnhapkho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewnhapkho_CellContentClick);
            this.dataGridViewnhapkho.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewnhapkho_DataBindingComplete);
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
            // Column5
            // 
            this.Column5.DataPropertyName = "LOAISANPHAM";
            this.Column5.HeaderText = "Nhóm nguyên liệu";
            this.Column5.Items.AddRange(new object[] {
            "Thịt",
            "Rau củ",
            "Hộp/Chai/lọ/Lon"});
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số lượng nhập";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIA";
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Xóa";
            this.Column6.Name = "Column6";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.cbxnguyenlieu);
            this.panel1.Controls.Add(this.textBoxtenhang);
            this.panel1.Controls.Add(this.cbxthang);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 62);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhóm nguyên liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên hàng";
            // 
            // cbxnguyenlieu
            // 
            this.cbxnguyenlieu.FormattingEnabled = true;
            this.cbxnguyenlieu.Items.AddRange(new object[] {
            "--Tất cả--",
            "Thịt",
            "Rau củ",
            "Hộp/chai/lọ/lon"});
            this.cbxnguyenlieu.Location = new System.Drawing.Point(377, 11);
            this.cbxnguyenlieu.Name = "cbxnguyenlieu";
            this.cbxnguyenlieu.Size = new System.Drawing.Size(181, 24);
            this.cbxnguyenlieu.TabIndex = 2;
            this.cbxnguyenlieu.Text = "--Tất cả--";
            this.cbxnguyenlieu.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxtenhang
            // 
            this.textBoxtenhang.Location = new System.Drawing.Point(707, 5);
            this.textBoxtenhang.Multiline = true;
            this.textBoxtenhang.Name = "textBoxtenhang";
            this.textBoxtenhang.Size = new System.Drawing.Size(381, 34);
            this.textBoxtenhang.TabIndex = 1;
            this.textBoxtenhang.Text = "Nhập tên hàng cần tìm...";
            this.textBoxtenhang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxthang
            // 
            this.cbxthang.FormattingEnabled = true;
            this.cbxthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxthang.Location = new System.Drawing.Point(12, 14);
            this.cbxthang.Name = "cbxthang";
            this.cbxthang.Size = new System.Drawing.Size(150, 24);
            this.cbxthang.TabIndex = 0;
            this.cbxthang.Text = "Tháng ";
            this.cbxthang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::doancosonganh.Properties.Resources.search_engine;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1094, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tìm kiếm";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::doancosonganh.Properties.Resources.refresh1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1081, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Làm mới";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::doancosonganh.Properties.Resources.add_to_the_basket;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1238, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm vào kho";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formnhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1417, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewnhapkho);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Formnhapkho";
            this.Text = "Formnhapkho";
            this.Load += new System.EventHandler(this.Formnhapkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewnhapkho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewnhapkho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbxnguyenlieu;
        private System.Windows.Forms.TextBox textBoxtenhang;
        private System.Windows.Forms.ComboBox cbxthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}