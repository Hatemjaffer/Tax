namespace Grad_Tax
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_colse = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.pic_cover = new DevExpress.XtraEditors.PictureEdit();
            this.edt_pass = new System.Windows.Forms.TextBox();
            this.edt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lp_title_page = new System.Windows.Forms.Label();
            this.btn_showpassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_colse
            // 
            this.btn_colse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_colse.ImageOptions.SvgImage")));
            this.btn_colse.Location = new System.Drawing.Point(424, 6);
            this.btn_colse.Name = "btn_colse";
            this.btn_colse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_colse.Size = new System.Drawing.Size(36, 31);
            this.btn_colse.TabIndex = 17;
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("29LT Bukra Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_add.Location = new System.Drawing.Point(0, 469);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(459, 48);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "تسجيل الدخول";
            // 
            // pic_cover
            // 
            this.pic_cover.EditValue = ((object)(resources.GetObject("pic_cover.EditValue")));
            this.pic_cover.Location = new System.Drawing.Point(130, 104);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pic_cover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_cover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_cover.Size = new System.Drawing.Size(169, 165);
            this.pic_cover.TabIndex = 15;
            // 
            // edt_pass
            // 
            this.edt_pass.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_pass.Location = new System.Drawing.Point(37, 366);
            this.edt_pass.Name = "edt_pass";
            this.edt_pass.Size = new System.Drawing.Size(262, 30);
            this.edt_pass.TabIndex = 13;
            this.edt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edt_name
            // 
            this.edt_name.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Location = new System.Drawing.Point(37, 300);
            this.edt_name.Name = "edt_name";
            this.edt_name.Size = new System.Drawing.Size(262, 30);
            this.edt_name.TabIndex = 14;
            this.edt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("29LT Bukra Regular", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(57, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 59);
            this.label3.TabIndex = 10;
            this.label3.Text = "تسجيل الدخول";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("29LT Bukra Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(334, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "كلمة السر";
            // 
            // lp_title_page
            // 
            this.lp_title_page.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lp_title_page.AutoSize = true;
            this.lp_title_page.Font = new System.Drawing.Font("29LT Bukra Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lp_title_page.ForeColor = System.Drawing.Color.Black;
            this.lp_title_page.Location = new System.Drawing.Point(305, 300);
            this.lp_title_page.Name = "lp_title_page";
            this.lp_title_page.Size = new System.Drawing.Size(155, 24);
            this.lp_title_page.TabIndex = 12;
            this.lp_title_page.Text = "اسم المستحدم";
            // 
            // btn_showpassword
            // 
            this.btn_showpassword.AutoSize = true;
            this.btn_showpassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showpassword.Location = new System.Drawing.Point(284, 412);
            this.btn_showpassword.Name = "btn_showpassword";
            this.btn_showpassword.Size = new System.Drawing.Size(15, 14);
            this.btn_showpassword.TabIndex = 30;
            this.btn_showpassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("29LT Bukra Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "اطهر كلمة السر";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 517);
            this.Controls.Add(this.btn_showpassword);
            this.Controls.Add(this.btn_colse);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.edt_pass);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lp_title_page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_colse;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.PictureEdit pic_cover;
        public System.Windows.Forms.TextBox edt_pass;
        public System.Windows.Forms.TextBox edt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lp_title_page;
        private System.Windows.Forms.CheckBox btn_showpassword;
        private System.Windows.Forms.Label label2;
    }
}

