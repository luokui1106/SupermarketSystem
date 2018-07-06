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
    public partial class FrmUpdatePwd : Form
    {
        /// <summary>
        /// 修改密码窗体
        /// </summary>
        public FrmUpdatePwd()
        {
            InitializeComponent();
        }

        DBOpration db = new DBOpration();

        public string name;     //存储用户名
        public string pwd;      //存储密码

        //单击 “修改”事件
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckUserPwd())     //调用检查密码方法
            {
                string newpwd = this.txtNewPwd.Text.Trim();     //获取新密码
                string confirmPwd = this.txtConfirmPwd.Text.Trim();     //获取确认密码
                //判断两次密码一致
                if (newpwd.Equals(confirmPwd))
                {
                    bool logic = db.UpdateUserPwd(name, newpwd);
                    if (logic)
                    {
                        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtUsedPwd.Text = "";
                        this.txtNewPwd.Text = "";
                        this.txtConfirmPwd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("检查两次输入的密码不一致！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.txtConfirmPwd.Focus();
                }
            }
        }

        //单击“返回”事件
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 检查用户输入的密码
        /// <summary>
        /// 检查用户输入的密码
        /// </summary>
        /// <returns></returns>
        public bool CheckUserPwd()
        {
            bool logic = true;
            //判断原密码为空
            if (this.txtUsedPwd.Text.Trim().Equals(string.Empty))
            {
                logic = false;
                MessageBox.Show("请输入原密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUsedPwd.Focus();
            }
            else
            {
                //判断输入的原密码与登录密码一致
                if (this.txtUsedPwd.Text.Trim().Equals(pwd))
                {
                    //判断输入的新密码为空
                    if (this.txtNewPwd.Text.Trim().Equals(string.Empty))
                    {
                        logic = false;
                        MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtNewPwd.Focus();
                    }
                    else
                    {
                        //判断确认新密码为空
                        if (this.txtConfirmPwd.Text.Trim().Equals(string.Empty))
                        {
                            logic = false;
                            MessageBox.Show("请确认新密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtConfirmPwd.Focus();
                        }
                    }
                }
                else
                {
                    logic = false;
                    MessageBox.Show("原密码有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUsedPwd.Focus();
                }
            }
            return logic;
        }
        #endregion

    }
}
