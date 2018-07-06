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
    public partial class FrmLogin : Form
    {
        /// <summary>
        /// 登录窗体
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        DBOpration db = new DBOpration();

        //点击“登录”事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckUserInfo())    //验证不为空方法
            {
                string name = this.txtName.Text.Trim();
                string pwd = this.txtPwd.Text.Trim();
                bool logic=db.CheckDBUserInfo(name,pwd);
                if (logic)
                {
                    MessageBox.Show("登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmAdmin admin = new FrmAdmin();
                    admin.name = name;
                    admin.pwd = pwd;
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //点击“取消”事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 检查用户不为空方法
        /// <summary>
        /// 检查用户不为空方法
        /// </summary>
        /// <returns></returns>
        public bool CheckUserInfo()
        {
            bool logic = true;
            if(this.txtName.Text.Trim().Equals(string.Empty))
            {
                logic = false;
                MessageBox.Show("用户名不能为空！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtName.Focus();
            }
            else if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                logic = false;
                MessageBox.Show("密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPwd.Focus();
            }
            return logic;
        }
        #endregion

    }
}
