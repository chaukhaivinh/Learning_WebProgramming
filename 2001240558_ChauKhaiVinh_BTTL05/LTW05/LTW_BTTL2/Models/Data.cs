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
        static string strcon = "Data Source=A204PC31\\CSSQL08;database=QL_PhongBan;Integranted Security=True";
        SqlConnection con=new SqlConnection(strcon);
        public List<PhongBan> DS_PhongBan= new List<PhongBan>();
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
                var p = new PhongBan();
                p.ID = int.Parse(dr["ID"].ToString());
                p.RoomName = dr["DisplayName"].ToString();
                DS_PhongBan.Add(p);
            }
        }
    }
}