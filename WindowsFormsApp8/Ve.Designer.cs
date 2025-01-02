namespace WindowsFormsApp8
{
    partial class Ve
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
            this.pnlVe = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblTenghe = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pnlQR = new System.Windows.Forms.Panel();
            this.pnl_Email = new System.Windows.Forms.Panel();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_XN = new System.Windows.Forms.Button();
            this.txt_mailnhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlVe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl_Email.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVe
            // 
            this.pnlVe.Controls.Add(this.groupBox1);
            this.pnlVe.Location = new System.Drawing.Point(0, 28);
            this.pnlVe.Name = "pnlVe";
            this.pnlVe.Size = new System.Drawing.Size(364, 364);
            this.pnlVe.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPhong);
            this.groupBox1.Controls.Add(this.lblTenghe);
            this.groupBox1.Controls.Add(this.lblTenPhim);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Ve";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(32, 49);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(35, 13);
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "label1";
            // 
            // lblTenghe
            // 
            this.lblTenghe.AutoSize = true;
            this.lblTenghe.Location = new System.Drawing.Point(32, 199);
            this.lblTenghe.Name = "lblTenghe";
            this.lblTenghe.Size = new System.Drawing.Size(35, 13);
            this.lblTenghe.TabIndex = 3;
            this.lblTenghe.Text = "label4";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(32, 99);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(35, 13);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "label2";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(32, 149);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolbtnPrint,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(367, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WindowsFormsApp8.Properties.Resources.QR;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolbtnPrint
            // 
            this.toolbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnPrint.Image = global::WindowsFormsApp8.Properties.Resources._in;
            this.toolbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnPrint.Name = "toolbtnPrint";
            this.toolbtnPrint.Size = new System.Drawing.Size(24, 24);
            this.toolbtnPrint.Text = "toolStripButton2";
            this.toolbtnPrint.Click += new System.EventHandler(this.toolbtnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WindowsFormsApp8.Properties.Resources.coupon_code;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WindowsFormsApp8.Properties.Resources.mail;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pnlQR
            // 
            this.pnlQR.Location = new System.Drawing.Point(3, 32);
            this.pnlQR.Name = "pnlQR";
            this.pnlQR.Size = new System.Drawing.Size(364, 364);
            this.pnlQR.TabIndex = 4;
            // 
            // pnl_Email
            // 
            this.pnl_Email.Controls.Add(this.btn_huy);
            this.pnl_Email.Controls.Add(this.btn_XN);
            this.pnl_Email.Controls.Add(this.txt_mailnhan);
            this.pnl_Email.Controls.Add(this.label2);
            this.pnl_Email.Location = new System.Drawing.Point(-2, 28);
            this.pnl_Email.Name = "pnl_Email";
            this.pnl_Email.Size = new System.Drawing.Size(364, 364);
            this.pnl_Email.TabIndex = 7;
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(49, 151);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(118, 23);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Huy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_XN
            // 
            this.btn_XN.Location = new System.Drawing.Point(192, 151);
            this.btn_XN.Name = "btn_XN";
            this.btn_XN.Size = new System.Drawing.Size(118, 23);
            this.btn_XN.TabIndex = 2;
            this.btn_XN.Text = "Xac Nhan";
            this.btn_XN.UseVisualStyleBackColor = true;
            this.btn_XN.Click += new System.EventHandler(this.btn_XN_Click);
            // 
            // txt_mailnhan
            // 
            this.txt_mailnhan.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mailnhan.Location = new System.Drawing.Point(49, 88);
            this.txt_mailnhan.Name = "txt_mailnhan";
            this.txt_mailnhan.Size = new System.Drawing.Size(261, 24);
            this.txt_mailnhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email Nhan Ve";
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 383);
            this.Controls.Add(this.pnl_Email);
            this.Controls.Add(this.pnlQR);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlVe);
            this.IsMdiContainer = true;
            this.Name = "Ve";
            this.Text = "Ve";
            this.Load += new System.EventHandler(this.Ve_Load_1);
            this.pnlVe.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_Email.ResumeLayout(false);
            this.pnl_Email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlVe;
        private System.Windows.Forms.Label lblTenghe;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTenPhim;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolbtnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlQR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel pnl_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mailnhan;
        private System.Windows.Forms.Button btn_XN;
        private System.Windows.Forms.Button btn_huy;
    }
}