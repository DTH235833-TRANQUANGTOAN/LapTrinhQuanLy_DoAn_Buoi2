namespace QuanLyTienGui
{
    partial class frmMain
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
            label3 = new Label();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtLogin = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 140);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 191);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 80);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 2;
            label3.Text = "Quản lý gửi tiền";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtLogin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(560, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 355);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(244, 239);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(142, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(214, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(141, 194);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(245, 31);
            txtPass.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(141, 140);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(245, 31);
            txtLogin.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 553);
            Controls.Add(groupBox1);
            Name = "frmMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtLogin;
    }
}
