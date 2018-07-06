namespace SupermarketSystem
{
    partial class FrmInsert
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
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.gbQiTaInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.chkYorNTeJia = new System.Windows.Forms.CheckBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.nudNewPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbBasicInfo.SuspendLayout();
            this.gbQiTaInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.nudPrice);
            this.gbBasicInfo.Controls.Add(this.cmbSort);
            this.gbBasicInfo.Controls.Add(this.txtName);
            this.gbBasicInfo.Controls.Add(this.lblPrice);
            this.gbBasicInfo.Controls.Add(this.lblSort);
            this.gbBasicInfo.Controls.Add(this.lblName);
            this.gbBasicInfo.Font = new System.Drawing.Font("宋体", 10F);
            this.gbBasicInfo.Location = new System.Drawing.Point(13, 13);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(346, 164);
            this.gbBasicInfo.TabIndex = 0;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "基本信息";
            // 
            // gbQiTaInfo
            // 
            this.gbQiTaInfo.Controls.Add(this.nudNewPrice);
            this.gbQiTaInfo.Controls.Add(this.chkYorNTeJia);
            this.gbQiTaInfo.Controls.Add(this.lblNewPrice);
            this.gbQiTaInfo.Font = new System.Drawing.Font("宋体", 10F);
            this.gbQiTaInfo.Location = new System.Drawing.Point(13, 196);
            this.gbQiTaInfo.Name = "gbQiTaInfo";
            this.gbQiTaInfo.Size = new System.Drawing.Size(346, 90);
            this.gbQiTaInfo.TabIndex = 0;
            this.gbQiTaInfo.TabStop = false;
            this.gbQiTaInfo.Text = "其他信息";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "商品名称：";
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(32, 79);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(77, 14);
            this.lblSort.TabIndex = 0;
            this.lblSort.Text = "商品类别：";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(32, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 14);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "预售价格：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 23);
            this.txtName.TabIndex = 1;
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(115, 76);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(191, 21);
            this.cmbSort.TabIndex = 2;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Location = new System.Drawing.Point(115, 120);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(191, 23);
            this.nudPrice.TabIndex = 3;
            // 
            // chkYorNTeJia
            // 
            this.chkYorNTeJia.AutoSize = true;
            this.chkYorNTeJia.Location = new System.Drawing.Point(115, 22);
            this.chkYorNTeJia.Name = "chkYorNTeJia";
            this.chkYorNTeJia.Size = new System.Drawing.Size(96, 18);
            this.chkYorNTeJia.TabIndex = 0;
            this.chkYorNTeJia.Text = "是否为特价";
            this.chkYorNTeJia.UseVisualStyleBackColor = true;
            this.chkYorNTeJia.CheckedChanged += new System.EventHandler(this.chkYorNTeJia_CheckedChanged);
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(32, 53);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(77, 14);
            this.lblNewPrice.TabIndex = 0;
            this.lblNewPrice.Text = "特价价格：";
            // 
            // nudNewPrice
            // 
            this.nudNewPrice.DecimalPlaces = 2;
            this.nudNewPrice.Enabled = false;
            this.nudNewPrice.Location = new System.Drawing.Point(115, 49);
            this.nudNewPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNewPrice.Name = "nudNewPrice";
            this.nudNewPrice.Size = new System.Drawing.Size(191, 23);
            this.nudNewPrice.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSearch.Location = new System.Drawing.Point(192, 303);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "保存(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("宋体", 10F);
            this.btnReturn.Location = new System.Drawing.Point(284, 303);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "取消(&C)";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 341);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbQiTaInfo);
            this.Controls.Add(this.gbBasicInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑商品信息";
            this.Load += new System.EventHandler(this.FrmInsert_Load);
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.gbQiTaInfo.ResumeLayout(false);
            this.gbQiTaInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbQiTaInfo;
        private System.Windows.Forms.NumericUpDown nudNewPrice;
        private System.Windows.Forms.CheckBox chkYorNTeJia;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReturn;
    }
}