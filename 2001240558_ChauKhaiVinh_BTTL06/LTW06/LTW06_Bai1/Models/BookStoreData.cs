using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LTW06_Bai1.Models
{
    public class BookStoreData
    {
        static string strcon = "Data Source=A204PC31\\CSSQL22;database=QL_NhaSach;Integrated Security=True";
        SqlConnection con=new SqlConnection(strcon);
        public List<ProductType> GetListType()
        {
            List<ProductType> DS_Loai = new List<ProductType>();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Loai",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var l =new ProductType();
                l.ID = int.Parse(dr["ID"].ToString());
                l.DisplayName = dr["DisplayName"].ToString();
                DS_Loai.Add(l);
            }
            return DS_Loai;
        }
        public List<Product> GetListProduct(int? _TypeID=null) 
        {
            List<Product> DS_SP= new List<Product>();
            string sql = "SELECT * FROM SanPham";
            if (_TypeID.HasValue && _TypeID.Value>0)
            {
                sql += " WHERE TypeID=@_TypeID";
            }
            SqlDataAdapter da= new SqlDataAdapter(sql,con);
            if (_TypeID.HasValue && _TypeID.Value > 0)
            {
                da.SelectCommand.Parameters.AddWithValue("@_TypeID", _TypeID.Value);
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) 
            {
                var sp= new Product();
                sp.ID= int.Parse(dr["ID"].ToString());
                sp.DisplayName = dr["DisplayName"].ToString() ;
                sp.TypeID = int.Parse(dr["TypeID"].ToString());
                sp.ManuID = int.Parse(dr["ManuID"].ToString());
                sp.Price = double.Parse(dr["Price"].ToString()) ;
                sp.Note = dr["Note"].ToString();
                sp.Image = dr["Images"].ToString();
                DS_SP.Add(sp);

            }
            return DS_SP;
        }
        public Product GetProductByID(int _ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham WHERE ID=@_ID",con);
            da.SelectCommand.Parameters.AddWithValue("@_ID", _ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    var sp = new Product();
                    sp.ID = int.Parse(dr["ID"].ToString());
                    sp.DisplayName = dr["DisplayName"].ToString();
                    sp.TypeID = int.Parse(dr["TypeID"].ToString());
                    sp.ManuID = int.Parse(dr["ManuID"].ToString());
                    sp.Price = double.Parse(dr["Price"].ToString());
                    sp.Note = dr["Note"].ToString();
                    sp.Image = dr["Images"].ToString();
                    return sp;

                }
            }
            return null;
        }
        public List<Product> AdvancedSeach(string kw,double? PriceRange1, double? PriceRange2)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM SanPham WHERE 1=1";
            if (!string.IsNullOrEmpty(kw))
            {
                sql += " AND DisplayName LIKE @kw";
            }
            if (PriceRange1.HasValue)
            {
                sql += " AND Price >= @PriceRange1";
            }
            if (PriceRange2.HasValue)
            {
                sql += " AND Price <= @PriceRange2";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            if (!string.IsNullOrEmpty(kw)) da.SelectCommand.Parameters.AddWithValue("@kw", "%" + kw + "%");
            if (PriceRange1.HasValue) da.SelectCommand.Parameters.AddWithValue("@PriceRange1", PriceRange1.Value);
            if (PriceRange2.HasValue) da.SelectCommand.Parameters.AddWithValue("@PriceRange2", PriceRange2.Value);

            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                var sp = new Product();
                sp.ID = int.Parse(dr["ID"].ToString());
                sp.DisplayName = dr["DisplayName"].ToString();
                sp.TypeID = int.Parse(dr["TypeID"].ToString());
                sp.ManuID = int.Parse(dr["ManuID"].ToString());
                sp.Price = double.Parse(dr["Price"].ToString());
                sp.Note = dr["Note"].ToString();
                sp.Image = dr["Images"].ToString();
                list.Add(sp);
            }
            return list;
        }
        public Customer CheckLogin(string _Phone, string _Password)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang WHERE Phone = @_Phone AND Passwword = @_Password", con);
            da.SelectCommand.Parameters.AddWithValue("@_Phone", _Phone);
            da.SelectCommand.Parameters.AddWithValue("@_Password", _Password);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return new Customer
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    DisplayName = dr["DisplayName"].ToString(),
                    Phone = dr["Phone"].ToString(),
                    Password = dr["Passwword"].ToString()
                };
            }
            return null;
        }
    }
}