using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SanPhamConnect:DatabaseConnect
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dsSp=new List<SanPham>();
            OpenConnection();
            SqlCommand cm = new SqlCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "Select * from SanPham";
            cm.Connection = conn;
            SqlDataReader rd = cm.ExecuteReader();
            while (rd.Read())
            {
                int ma = rd.GetInt32(0);
                string ten =rd.GetString(1);
                int gia = rd.GetInt32(2);
                int madanhmuc = rd.GetInt32(3);
                
                SanPham sp = new SanPham();
                sp.MaSanPham = ma;
                sp.TenSanPham = ten;
                sp.DonGia = gia;
                sp.MaDM = madanhmuc;
                dsSp.Add(sp);
                
            }
            return.Close();

            return dsSp;
        }
        
    }
}
