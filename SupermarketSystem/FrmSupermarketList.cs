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
    public partial class FrmSupermarketList : Form
    {
        public FrmSupermarketList()
        {
            InitializeComponent();
        }

        DBOpration db = new DBOpration();

        //树状图 更改选项后发生
        private void tvSort_AfterSelect(object sender, TreeViewEventArgs e)
        {
            db.BindCommodityInfo(this.tvSort, this.dgvList);
        }

        //单击“新增”按钮事件
        private void tsbtnInsert_Click(object sender, EventArgs e)
        {
            FrmInsert insert = new FrmInsert();
            insert.n = 1;
            insert.ShowDialog();
        }
        //单击“修改”按钮事件
        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            FrmInsert insert = new FrmInsert();
            insert.n = 2;
            insert._id =Convert.ToInt32(this.dgvList.SelectedRows[0].Cells["CommodityId"].Value);
            insert._name=this.dgvList.SelectedRows[0].Cells["CommodityName"].Value.ToString();
            insert._sort = this.dgvList.SelectedRows[0].Cells["CommoditySortName"].Value.ToString();
            insert._price = Convert.ToDouble(this.dgvList.SelectedRows[0].Cells["Price"].Value);
            insert._YorN =Convert.ToBoolean(this.dgvList.SelectedRows[0].Cells["SpecialOffer"].Value);
            if (!this.dgvList.SelectedRows[0].Cells["NewPrice"].Value.ToString().Equals(string.Empty))
            {
                insert._newPrice = Convert.ToDouble(this.dgvList.SelectedRows[0].Cells["NewPrice"].Value);
            }
            insert.ShowDialog();
        }

        //单击“删除”按钮事件
        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            //获取商品编号
            int id=Convert.ToInt32(this.dgvList.SelectedRows[0].Cells["CommodityId"].Value);
            //获取商品名称
            string name = this.dgvList.SelectedRows[0].Cells["CommodityName"].Value.ToString();
            DialogResult result=MessageBox.Show("确定要删除商品为 “ "+name+" ” 的数据吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                bool logic = db.DeleteCommodityInfo(id);
                if (logic)
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.BindCommodityInfo(this.tvSort, this.dgvList);
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //单击“刷新”按钮事件
        private void tsbtnShuaXin_Click(object sender, EventArgs e)
        {
            db.BindCommodityInfo(this.tvSort, this.dgvList);
        }

        //单击“修改”按钮事件
        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
