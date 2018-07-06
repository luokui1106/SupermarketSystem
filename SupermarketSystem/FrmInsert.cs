using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketSystem
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }
        //用于判断选择的是“新增”还是“修改”窗体
        //1代表新增
        //2代表修改
        public int n;

        public int _id;         //存储商品编号
        public string _name;    //存储商品名称
        public string _sort;    //存储商品类别
        public double _price;   //存储预售价格
        public bool _YorN;      //存储是否特价
        public double _newPrice=0;    //存储特价价格

        //创建数据库操作类对象
        DBOpration db = new DBOpration();

        //当 CheckBox属性值发生改变时 发生事件
        private void chkYorNTeJia_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkYorNTeJia.Checked == true)
            {
                this.nudNewPrice.Enabled = true ;
            }
            else 
            {
                this.nudNewPrice.Value = 0;
                this.nudNewPrice.Enabled = false;
            }
        }

        //“窗体加载”事件
        private void FrmInsert_Load(object sender, EventArgs e)
        {
            //绑定商品类别
            db.BindSortInfo(this.cmbSort);
            //将n的值传递到数据库操作类中
            db.n = n;
            switch(n){
                case 1:
                    break;
                case 2:
                    Update_Load();
                    break;
            }
        }

        //修改窗体 加载时 执行方法
        public void Update_Load()
        {
            this.btnSearch.Text = "修改(&U)";
            this.txtName.Text = _name;
            this.cmbSort.Text = _sort;
            this.nudPrice.Value =(decimal)_price;
            this.chkYorNTeJia.Checked = _YorN;
            this.nudNewPrice.Value = (decimal)_newPrice;
        }


        //单击“取消”按钮事件
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 单击“保存/修改”按钮事件
        //单击“保存/修改”按钮事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (CheckNotNull())     //为空验证方法
            {
                //商品名称
                string name = this.txtName.Text.Trim();
                //商品类别
                int sort = (int)this.cmbSort.SelectedValue;
                //商品预售价格
                double price = Convert.ToDouble(this.nudPrice.Value);
                //利用三元运算符获取 是否特价（1：是 0：否）
                int YorN = this.chkYorNTeJia.Checked ? 1 : 0;
                //商品特价价格
                double newPrice = Convert.ToDouble(this.nudNewPrice.Value);
                bool logic = db.InsertOrUpdateCommodityInfo(_id,name, sort, price, YorN, newPrice);

                switch (n)
                {
                    //新增
                    case 1:
                        if (logic)
                        {
                            MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtName.Text = "";
                            this.cmbSort.SelectedValue = -1;
                            this.nudPrice.Value = 0;
                            this.chkYorNTeJia.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    //修改
                    case 2:
                        if (logic)
                        {
                            MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                }
            }
        }
        #endregion

        #region 新增窗体 点击“保存”按钮执行方法
        //新增窗体 点击“保存”按钮执行方法
        public void btnSearch_Click()
        {
            if (CheckNotNull())     //为空验证方法
            {
                //商品名称
                string name = this.txtName.Text.Trim();
                //商品类别
                int sort = (int)this.cmbSort.SelectedValue;
                //商品预售价格
                double price = Convert.ToDouble(this.nudPrice.Value);
                //利用三元运算符获取 是否特价（1：是 0：否）
                int YorN = this.chkYorNTeJia.Checked ? 1 : 0;
                //商品特价价格
                double newPrice = Convert.ToDouble(this.nudNewPrice.Value);
                bool logic = db.InsertOrUpdateCommodityInfo(_id,name, sort, price, YorN, newPrice);
                if (logic)
                {
                    MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtName.Text = "";
                    this.cmbSort.SelectedValue = -1;
                    this.nudPrice.Value = 0;
                    this.chkYorNTeJia.Checked = false;
                }
                else
                {
                    MessageBox.Show("新增失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 为空验证
        //为空验证
        public bool CheckNotNull()
        {
            bool logic = true;
            //判断商品名称
            if (this.txtName.Text.Trim().Equals(string.Empty))
            {
                logic = false;
                MessageBox.Show("请输入商品名称","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtName.Focus();
            }
            //判断商品类别
            else if((int)this.cmbSort.SelectedValue==-1)
            {
                logic = false;
                MessageBox.Show("请选择商品类别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbSort.Focus();
            }
            //判断预售价格
            else if(this.nudPrice.Value==0)
            {
                logic = false;
                MessageBox.Show("请输入预售价格", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.nudPrice.Focus();
            }
            //判断选择是特价 
            else if (this.chkYorNTeJia.Checked == true)
            {
                //判断特价价格为0
                if (this.nudNewPrice.Value == 0)
                {
                    logic = false;
                    MessageBox.Show("请输入特价价格", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.nudNewPrice.Focus();
                }
                //判断特价价格不为0
                else
                {
                    if (this.nudNewPrice.Value > this.nudPrice.Value)
                    {
                        logic = false;
                        MessageBox.Show("特价金额不能大于或等于预售金额", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nudNewPrice.Focus();
                    }
                }
            }
            return logic;
        }
        #endregion
    }
}
