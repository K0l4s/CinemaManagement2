using Cinema2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema2._0.Event
{
    
    public class Event_USPhim
    {
        CinemaDBContext db = new CinemaDBContext();
        public Phim LayPhim(string maPhim)
        {
            return db.Phims.Find(maPhim);
        }
        public List<Phim> layDSPhim()
        {
            return db.Phims.ToList();
        }
    }
}
