using Cinema2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Cinema2._0.Event
{
    public class Event_VeXemPhim
    {
        CinemaDBContext db = new CinemaDBContext();
        public double layBangGia(Ghe ghe)
        {
            string maLoaiGhe = db.Ghes.Find(ghe.maGhe).maLoaiGhe;
            string maLoaiRap = db.RapPhims.Find(ghe.maRap).maLoaiRap;
            return db.DonGias.Find(maLoaiGhe,maLoaiRap).donGia1;
        }
        public string layLoaiVe(Ghe ghe)
        {
            string maLoaiGhe = db.Ghes.Find(ghe.maGhe).maLoaiGhe;
            string maLoaiRap = db.RapPhims.Find(ghe.maRap).maLoaiRap;
            return "R "+maLoaiRap +" - G "+maLoaiGhe;
        }
    }
}
