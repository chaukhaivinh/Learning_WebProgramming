using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LTW05_BTTL3.Models
{
    public class Data
    {
        static string strcon = "Data Source=DESKTOP-I4MVS04;database=QL_DTDD1;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);
        public List<ProductType> GetDSLoai()
        {
            List<ProductType> DS_Loai=new List<ProductType>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Loai", con);
            DataTable dt= new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                var l = new ProductType();
                l.ID = int.Parse(dr["ID"].ToString());
                l.DisplayName = dr["DisplayName"].ToString();
                DS_Loai.Add(l);
            }
            return DS_Loai;
        }
        public List<Product> GetDSSanPham(int _TypeID)
        {
            List<Product> DS_SP = new List<Product>();
            string sql = "SELECT * FROM SanPham";
            if (_TypeID > 0)
            {
                sql += " WHERE TypeID=@_TypeID";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            if (_TypeID > 0)
            {
                da.SelectCommand.Parameters.AddWithValue("@_TypeID", _TypeID);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var sp = new Product();
                sp.ID = int.Parse(dr["ID"].ToString());
                sp.DisplayName = dr["DisplayName"].ToString();
                sp.Link = dr["Link"].ToString();
                sp.Price = double.Parse(dr["Price"].ToString());
                sp.Describe = dr["Describe"].ToString();
                sp.TypeID = int.Parse(dr["TypeID"].ToString());
                DS_SP.Add(sp);
            }
            return DS_SP;
        }
        public List<Product> TimKiemTheoTen(string kw)
        {
            List<Product> DS_SPTK=new List<Product>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham WHERE DisplayName LIKE @kw", con);
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + kw + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var sp = new Product();
                sp.ID = int.Parse(dr["ID"].ToString());
                sp.DisplayName = dr["DisplayName"].ToString();
                sp.Link = dr["Link"].ToString();
                sp.Price = double.Parse(dr["Price"].ToString());
                sp.Describe = dr["Describe"].ToString();
                sp.TypeID = int.Parse(dr["TypeID"].ToString());
                DS_SPTK.Add(sp);
            }
            return DS_SPTK;
        }
    }
}