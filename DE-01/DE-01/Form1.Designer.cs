namespace DE_01
{
    partial class frmSV
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
            this.cboLOP = new System.Windows.Forms.ComboBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKhongLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLOP);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTenSV);
            this.groupBox1.Controls.Add(this.txtMASV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(87, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(639, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach";
            // 
            // cboLOP
            // 
            this.cboLOP.FormattingEnabled = true;
            this.cboLOP.Location = new System.Drawing.Point(465, 70);
            this.cboLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLOP.Name = "cboLOP";
            this.cboLOP.Size = new System.Drawing.Size(161, 24);
            this.cboLOP.TabIndex = 4;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(114, 77);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(251, 22);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(465, 22);
            this.txtHoTenSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(161, 22);
            this.txtHoTenSV.TabIndex = 2;
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(135, 26);
            this.txtMASV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(200, 22);
            this.txtMASV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ho Ten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lop Hoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngay Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma Sinh Vien";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(133, 205);
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(106, 41);
            this.txtTim.TabIndex = 10;
            this.txtTim.Text = "Tim";
            this.txtTim.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(245, 220);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(67, 26);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "THEM";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(416, 220);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(67, 26);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "XOA";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(322, 220);
            this.btSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(76, 26);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "SUA";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(489, 220);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(69, 26);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "LUU";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btKhongLuu
            // 
            this.btKhongLuu.Location = new System.Drawing.Point(575, 220);
            this.btKhongLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btKhongLuu.Name = "btKhongLuu";
            this.btKhongLuu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btKhongLuu.Size = new System.Drawing.Size(84, 26);
            this.btKhongLuu.TabIndex = 15;
            this.btKhongLuu.Text = "KO LUU";
            this.btKhongLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(695, 220);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(93, 26);
            this.btThoat.TabIndex = 16;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 271);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(771, 156);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên SV";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // frmSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKhongLuu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSV_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLOP;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtTim;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKhongLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

