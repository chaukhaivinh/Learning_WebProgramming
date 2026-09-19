using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace LTW05_BTM1.Models
{
    public class Data
    {
        static string strcon = "Data Source=A204PC31\\CSSQL08;database=QL_NhanVien;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);
        public List<Employee> DS_NhanVien = new List<Employee>();
        public Data()
        {
            ThietLap_DSNV();
        }
        public void ThietLap_DSNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Emloyee", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var nv = new Employee();
                nv.ID = int.Parse(dr["ID"].ToString());
                nv.Name = dr["DisplayName"].ToString();
                nv.Gender = dr["Gender"].ToString();
                nv.City = dr["City"].ToString();
                nv.ID = int.Parse(dr["DepID"].ToString());
                DS_NhanVien.Add(nv);
            }
        }
    }
}