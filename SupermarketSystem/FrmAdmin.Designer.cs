namespace SupermarketSystem
{
    partial class FrmAdmin
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuanYu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCommodity = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblShowUser = new System.Windows.Forms.Label();
            this.pbCommodity = new System.Windows.Forms.PictureBox();
            this.pbType = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUserAdmin,
            this.tsmHelp});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(729, 25);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmUserAdmin
            // 
            this.tsmUserAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdatePwd,
            this.tsmExit});
            this.tsmUserAdmin.Name = "tsmUserAdmin";
            this.tsmUserAdmin.Size = new System.Drawing.Size(85, 21);
            this.tsmUserAdmin.Text = "用户管理(&U)";
            // 
            // tsmUpdatePwd
            // 
            this.tsmUpdatePwd.Name = "tsmUpdatePwd";
            this.tsmUpdatePwd.Size = new System.Drawing.Size(139, 22);
            this.tsmUpdatePwd.Text = "修改密码(&P)";
            this.tsmUpdatePwd.Click += new System.EventHandler(this.tsmUpdatePwd_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(139, 22);
            this.tsmExit.Text = "退出(&X)";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGuanYu});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmHelp.Text = "帮助(&H)";
            // 
            // tsmGuanYu
            // 
            this.tsmGuanYu.Name = "tsmGuanYu";
            this.tsmGuanYu.Size = new System.Drawing.Size(152, 22);
            this.tsmGuanYu.Text = "关于(&A)";
            this.tsmGuanYu.Click += new System.EventHandler(this.tsmGuanYu_Click);
            // 
            // lblCommodity
            // 
            this.lblCommodity.AutoSize = true;
            this.lblCommodity.BackColor = System.Drawing.Color.Transparent;
            this.lblCommodity.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblCommodity.Location = new System.Drawing.Point(165, 85);
            this.lblCommodity.Name = "lblCommodity";
            this.lblCommodity.Size = new System.Drawing.Size(89, 19);
            this.lblCommodity.TabIndex = 3;
            this.lblCommodity.Text = "商品管理";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(457, 85);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(129, 19);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "商品类别管理";
            // 
            // lblShowUser
            // 
            this.lblShowUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowUser.AutoSize = true;
            this.lblShowUser.BackColor = System.Drawing.Color.Transparent;
            this.lblShowUser.Font = new System.Drawing.Font("宋体", 10F);
            this.lblShowUser.Location = new System.Drawing.Point(632, 414);
            this.lblShowUser.Name = "lblShowUser";
            this.lblShowUser.Size = new System.Drawing.Size(63, 14);
            this.lblShowUser.TabIndex = 3;
            this.lblShowUser.Text = "欢迎您：";
            // 
            // pbCommodity
            // 
            this.pbCommodity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCommodity.Image = global::SupermarketSystem.Properties.Resources._1;
            this.pbCommodity.Location = new System.Drawing.Point(83, 125);
            this.pbCommodity.Name = "pbCommodity";
            this.pbCommodity.Size = new System.Drawing.Size(253, 248);
            this.pbCommodity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCommodity.TabIndex = 2;
            this.pbCommodity.TabStop = false;
            this.pbCommodity.Click += new System.EventHandler(this.pbCommodity_Click);
            // 
            // pbType
            // 
            this.pbType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbType.Image = global::SupermarketSystem.Properties.Resources._3;
            this.pbType.Location = new System.Drawing.Point(391, 125);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(253, 248);
            this.pbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbType.TabIndex = 2;
            this.pbType.TabStop = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 436);
            this.Controls.Add(this.lblShowUser);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCommodity);
            this.Controls.Add(this.pbCommodity);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市商品管理";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmUserAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdatePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmGuanYu;
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.PictureBox pbCommodity;
        private System.Windows.Forms.Label lblCommodity;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblShowUser;
    }
}