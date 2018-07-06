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
    public partial class FrmAdmin : Form
    {
        /// <summary>
        /// 管理窗体
        /// </summary>
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public string name; //存储用户名
        public string pwd;  //存储密码

        //窗体加载事件
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.lblShowUser.Text += name;
        }

        //单击“商品管理”图片事件
        private void pbCommodity_Click(object sender, EventArgs e)
        {
            FrmSupermarketList list = new FrmSupermarketList();
            list.ShowDialog();
        }

        //单击“修改密码”事件
        private void tsmUpdatePwd_Click(object sender, EventArgs e)
        {
            FrmUpdatePwd updatePwd = new FrmUpdatePwd();
            updatePwd.name = name;
            updatePwd.pwd = pwd;
            updatePwd.ShowDialog();
        }

        //单击“退出”事件
        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("确定退出系统吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //单击“关于”事件
        private void tsmGuanYu_Click(object sender, EventArgs e)
        {
            FrmGuanYu guanYu = new FrmGuanYu();
            guanYu.ShowDialog();
        }

    }
}
