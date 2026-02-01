namespace QuanLyTienGui
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
            panel1 = new Panel();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            txtLoaiTien = new ComboBox();
            txtSoTien = new TextBox();
            txtSDTKH = new TextBox();
            txtCCCD = new TextBox();
            txtTenKH = new TextBox();
            btnThoat = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            cboKyHan = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cboKyHan);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLoaiTien);
            panel1.Controls.Add(txtSoTien);
            panel1.Controls.Add(txtSDTKH);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 283);
            panel1.TabIndex = 0;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(745, 93);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(61, 29);
            rdNu.TabIndex = 14;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(650, 93);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(75, 29);
            rdNam.TabIndex = 13;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 93);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 12;
            label2.Text = "CMDD/CCCD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 11;
            label1.Text = "Tên khách hàng";
            // 
            // txtLoaiTien
            // 
            txtLoaiTien.FormattingEnabled = true;
            txtLoaiTien.Location = new Point(304, 165);
            txtLoaiTien.Name = "txtLoaiTien";
            txtLoaiTien.Size = new Size(131, 33);
            txtLoaiTien.TabIndex = 9;
            txtLoaiTien.Text = "Loại tiền";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(148, 165);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(150, 31);
            txtSoTien.TabIndex = 8;
            txtSoTien.Text = "Nhập số tiền";
            // 
            // txtSDTKH
            // 
            txtSDTKH.Location = new Point(970, 89);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.Size = new Size(150, 31);
            txtSDTKH.TabIndex = 7;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(458, 91);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(186, 31);
            txtCCCD.TabIndex = 6;
            txtCCCD.Text = "Nhập CMDD/CCCD";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(148, 89);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(150, 31);
            txtTenKH.TabIndex = 5;
            txtTenKH.Text = "Nhập tên";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(949, 228);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(131, 49);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(133, 228);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(131, 49);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 270);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1186, 270);
            dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(827, 93);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 18;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 168);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 19;
            label4.Text = "Số tiền";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(340, 228);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(131, 49);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(547, 228);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(131, 49);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(745, 228);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(131, 49);
            btnLuu.TabIndex = 22;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(576, 168);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 31);
            dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 168);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 24;
            label5.Text = "Ngày Gửi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(774, 168);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 25;
            label6.Text = "Kỳ Hạn";
            // 
            // cboKyHan
            // 
            cboKyHan.FormattingEnabled = true;
            cboKyHan.Location = new Point(864, 168);
            cboKyHan.Name = "cboKyHan";
            cboKyHan.Size = new Size(131, 33);
            cboKyHan.TabIndex = 26;
            cboKyHan.Text = "Kỳ Hạn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private Button btnThem;
        private Panel panel2;
        private DataGridView dataGridView1;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Label label2;
        private Label label1;
        private ComboBox txtLoaiTien;
        private TextBox txtSoTien;
        private TextBox txtSDTKH;
        private TextBox txtCCCD;
        private TextBox txtTenKH;
        private Label label3;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Label label4;
        private ComboBox cboKyHan;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}
