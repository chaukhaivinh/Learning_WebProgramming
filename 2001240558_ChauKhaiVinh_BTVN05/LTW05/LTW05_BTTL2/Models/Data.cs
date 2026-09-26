using LTW05_BTTL2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LTW_BTTL2.Models
{
    public class Data
    {
        static string strcon = "Data Source=DESKTOP-I4MVS04;database=QL_PhongBan;Integrated Security=True";
        SqlConnection con=new SqlConnection(strcon);
        public List<Department> DS_PhongBan= new List<Department>();
        public Data()
        {
            
            ThietLap_DSPB();
        }
        public void ThietLap_DSPB()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PhongBan", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var p = new Department();
                p.ID = int.Parse(dr["ID"].ToString());
                p.RoomName = dr["DisplayName"].ToString();
                DS_PhongBan.Add(p);
            }
        }
        public Department GetDepartmentByID (int ID)
        {
            Department dept=DS_PhongBan.FirstOrDefault(p => p.ID == ID);
            if (dept != null)
            {
                ThietLap_DSNV(ID);
            }
            return dept;
        }
        public List<Employee> ThietLap_DSNV(int ID)
        {
            List<Employee> DS_NV = new List<Employee>();
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where DeptId=@ID", con);
            da.SelectCommand.Parameters.AddWithValue("@ID", ID);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                var nv = new Employee();
                nv.ID = int.Parse(dr["ID"].ToString());
                nv.DisplayName = dr["Name"].ToString();
                nv.Gender = dr["Gender"].ToString();
                nv.City = dr["City"].ToString();
                nv.DepartmentID = int.Parse(dr["DeptId"].ToString());
                DS_NV.Add(nv);

            }
            var dept = DS_PhongBan.FirstOrDefault(p => p.ID == ID);
            if (dept != null)
            {
                dept.EmployeeCount = dt.Rows.Count;
            }
            return DS_NV;
        }
    }
}