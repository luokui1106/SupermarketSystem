namespace SupermarketSystem
{
    partial class FrmSupermarketList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("正价商品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("特价商品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("所有商品", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupermarketList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.tvSort = new System.Windows.Forms.TreeView();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.gbShow = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.CommodityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommodityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommoditySortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialOffer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NewPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShuaXin = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSort.SuspendLayout();
            this.gbShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSort);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbShow);
            this.splitContainer1.Size = new System.Drawing.Size(870, 503);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.tvSort);
            this.gbSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSort.Font = new System.Drawing.Font("宋体", 10F);
            this.gbSort.Location = new System.Drawing.Point(0, 0);
            this.gbSort.Name = "gbSort";
            this.gbSort.Size = new System.Drawing.Size(170, 503);
            this.gbSort.TabIndex = 0;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "商品分类";
            // 
            // tvSort
            // 
            this.tvSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSort.ImageIndex = 0;
            this.tvSort.ImageList = this.ilIcons;
            this.tvSort.Location = new System.Drawing.Point(3, 19);
            this.tvSort.Name = "tvSort";
            treeNode1.Name = "zhengjia";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "正价商品";
            treeNode2.Name = "tejia";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "特价商品";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "all";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "所有商品";
            this.tvSort.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvSort.SelectedImageIndex = 0;
            this.tvSort.Size = new System.Drawing.Size(164, 481);
            this.tvSort.TabIndex = 0;
            this.tvSort.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSort_AfterSelect);
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "1.gif");
            this.ilIcons.Images.SetKeyName(1, "2.gif");
            // 
            // gbShow
            // 
            this.gbShow.Controls.Add(this.dgvList);
            this.gbShow.Controls.Add(this.tsMenu);
            this.gbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShow.Font = new System.Drawing.Font("宋体", 10F);
            this.gbShow.Location = new System.Drawing.Point(0, 0);
            this.gbShow.Name = "gbShow";
            this.gbShow.Size = new System.Drawing.Size(696, 503);
            this.gbShow.TabIndex = 0;
            this.gbShow.TabStop = false;
            this.gbShow.Text = "商品显示";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommodityId,
            this.CommodityName,
            this.CommoditySortName,
            this.Price,
            this.SpecialOffer,
            this.NewPrice});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 93);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(690, 407);
            this.dgvList.TabIndex = 1;
            // 
            // CommodityId
            // 
            this.CommodityId.DataPropertyName = "CommodityId";
            this.CommodityId.HeaderText = "商品编号";
            this.CommodityId.Name = "CommodityId";
            this.CommodityId.ReadOnly = true;
            // 
            // CommodityName
            // 
            this.CommodityName.DataPropertyName = "CommodityName";
            this.CommodityName.HeaderText = "商品名称";
            this.CommodityName.Name = "CommodityName";
            this.CommodityName.ReadOnly = true;
            // 
            // CommoditySortName
            // 
            this.CommoditySortName.DataPropertyName = "CommoditySortName";
            this.CommoditySortName.HeaderText = "类别名称";
            this.CommoditySortName.Name = "CommoditySortName";
            this.CommoditySortName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "商品价格";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // SpecialOffer
            // 
            this.SpecialOffer.DataPropertyName = "SpecialOffer";
            this.SpecialOffer.HeaderText = "是否特价";
            this.SpecialOffer.Name = "SpecialOffer";
            this.SpecialOffer.ReadOnly = true;
            // 
            // NewPrice
            // 
            this.NewPrice.DataPropertyName = "NewPrice";
            this.NewPrice.HeaderText = "打折后价格";
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.ReadOnly = true;
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInsert,
            this.tsbtnUpdate,
            this.tsbtnDelete,
            this.tsbtnShuaXin,
            this.tsBtnExit});
            this.tsMenu.Location = new System.Drawing.Point(3, 19);
            this.tsMenu.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(690, 74);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbtnInsert
            // 
            this.tsbtnInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsert.Image")));
            this.tsbtnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInsert.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsbtnInsert.Name = "tsbtnInsert";
            this.tsbtnInsert.Size = new System.Drawing.Size(54, 71);
            this.tsbtnInsert.Text = "新增";
            this.tsbtnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnInsert.Click += new System.EventHandler(this.tsbtnInsert_Click);
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdate.Image")));
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(54, 71);
            this.tsbtnUpdate.Text = "修改";
            this.tsbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(54, 71);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // tsbtnShuaXin
            // 
            this.tsbtnShuaXin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShuaXin.Image")));
            this.tsbtnShuaXin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShuaXin.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsbtnShuaXin.Name = "tsbtnShuaXin";
            this.tsbtnShuaXin.Size = new System.Drawing.Size(54, 71);
            this.tsbtnShuaXin.Text = "刷新";
            this.tsbtnShuaXin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnShuaXin.Click += new System.EventHandler(this.tsbtnShuaXin_Click);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExit.Image")));
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(54, 71);
            this.tsBtnExit.Text = "退出";
            this.tsBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnExit.Click += new System.EventHandler(this.tsBtnExit_Click);
            // 
            // FrmSupermarketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 503);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSupermarketList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品列表";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSort.ResumeLayout(false);
            this.gbShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.GroupBox gbShow;
        private System.Windows.Forms.TreeView tvSort;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnInsert;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommodityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommoditySortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SpecialOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewPrice;
        private System.Windows.Forms.ToolStripButton tsbtnShuaXin;

    }
}