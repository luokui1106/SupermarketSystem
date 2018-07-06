using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketSystem
{
    /// <summary>
    /// 数据库操作类
    /// </summary>
    class DBOpration
    {
        static string strConn = "Data Source=.;Initial Catalog=SupermarketSystem;Integrated Security=True";
        SqlConnection conn = new SqlConnection(strConn);
        DataSet ds = new DataSet();
        SqlDataAdapter ada = null;

        #region  检查登录用户信息
        /// <summary>
        /// 检查登录用户信息
        /// </summary>
        public bool CheckDBUserInfo(string name,string pwd)
        {
            bool logic = false;
            try
            {
                conn.Open();
                string sql = string.Format("select COUNT(*) from [User]  where UserName='{0}' and UserPwd='{1}'",name,pwd);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = (int)cmd.ExecuteScalar();
                if (num > 0)
                {
                    logic = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发生异常");
            }
            finally
            {
                conn.Close();
            }
            return logic;
        }
        #endregion

        #region 修改用户密码
        /// <summary>
        /// 修改用户密码
        /// </summary>
        public bool UpdateUserPwd(string name,string newPwd)
        {
            bool logic = false;
            try
            {
                conn.Open();
                string sql = string.Format("update [User] set UserPwd='{0}' where UserName='{1}'",newPwd,name);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    logic =true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发生异常");
            }
            finally
            {
                conn.Close();
            }
            return logic;
        }
        #endregion

        #region 绑定显示商品信息
        /// <summary>
        /// 绑定显示商品信息
        /// </summary>
        public void BindCommodityInfo(TreeView tv, DataGridView dgv)
        {
            if (ds.Tables["Commodity"] != null)
            {
                ds.Tables["Commodity"].Clear();
            }
            try
            {
                string sql = string.Format(@"select C.CommodityId,C.CommodityName,S.CommoditySortName,C.Price,C.SpecialOffer,C.NewPrice from Commodity as C,CommoditySort as S 
                                            where C.CommoditySortId=S.CommoditySortId");
                ada = new SqlDataAdapter(sql, conn);
                ada.Fill(ds, "Commodity");
                DataView dv = new DataView(ds.Tables["Commodity"]);
                if (tv.SelectedNode.Level == 1)
                {
                    if (tv.SelectedNode.Text.Equals("正价商品"))
                    {
                        dv.RowFilter = "SpecialOffer='false'";
                    }
                    else if (tv.SelectedNode.Text.Equals("特价商品"))
                    {
                        dv.RowFilter = "SpecialOffer='true'";
                    }
                }
                dgv.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发生异常");
            }
        }
        #endregion

        #region 绑定商品类别信息
        /// <summary>
        /// 绑定商品类别信息
        /// </summary>
        public void BindSortInfo(ComboBox cmb)
        {
            try
            {
                string sql = string.Format("select * from CommoditySort");
                ada = new SqlDataAdapter(sql,conn);
                ada.Fill(ds,"SortInfo");

                //向商品类别中插入一行数据“请选择”
                DataRow row = ds.Tables["SortInfo"].NewRow();
                row["CommoditySortName"] = "请选择";
                row["CommoditySortId"] = -1;
                ds.Tables["SortInfo"].Rows.InsertAt(row,0);

                cmb.DataSource = ds.Tables["SortInfo"];
                cmb.DisplayMember = "CommoditySortName";
                cmb.ValueMember = "CommoditySortId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发生异常");
            }
        }
        #endregion

        #region “新增/修改”商品信息
        //n用于判断选择的是“新增”还是“修改”窗体
        //1代表新增
        //2代表修改
        public int n;  
        /// <summary>
        /// 新增/修改 商品信息
        /// </summary>
        public bool InsertOrUpdateCommodityInfo(int id,string name,int sort,double price,int YorN,double newPrice)
        {
            bool logic = false;
            try
            {
                conn.Open();
                string sql = "";
                //判断不是特价
                if (newPrice == 0)
                {
                    //执行新增
                    if (n == 1)
                    {
                        sql = string.Format("insert Commodity values({0},'{1}',{2},{3},default)", sort, name, YorN, price);
                    }
                    //执行修改
                    else if (n == 2)
                    {
                        sql = string.Format("update Commodity set CommoditySortId={0},CommodityName='{1}',SpecialOffer={2},Price={3},NewPrice=default where CommodityId={4}", sort, name, YorN, price, id);
                    }
                }
                //否则是特价
                else {
                    //执行新增
                    if (n == 1)
                    {
                        sql = string.Format("insert Commodity values({0},'{1}',{2},{3},{4})", sort, name, YorN, price, newPrice);
                    }
                    //执行修改
                    else if (n == 2)
                    {
                        sql = string.Format("update Commodity set CommoditySortId={0},CommodityName='{1}',SpecialOffer={2},Price={3},NewPrice={4} where CommodityId={5}", sort, name, YorN, price,newPrice,id);
                    }
                }
                SqlCommand cmd = new SqlCommand(sql,conn);
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    logic = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发生异常");
            }
            finally
            {
                conn.Close();
            }
            return logic;
        }
        #endregion

        #region 删除商品信息
        /// <summary>
        /// 删除商品信息
        /// </summary>
        /// <returns></returns>
        public bool DeleteCommodityInfo(int id)
        {
            bool logic = false;
            try
            {
                conn.Open();
                string sql = string.Format("delete Commodity where CommodityId={0}",id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    logic = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"发生异常");
            }
            finally
            {
                conn.Close();
            }
            return logic;
        }
        #endregion
    }
}
