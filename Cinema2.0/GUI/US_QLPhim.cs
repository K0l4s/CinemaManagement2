using Cinema2._0.Event;
using Cinema2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.GUI
{
    public partial class US_QLPhim : UserControl
    {
        Event_USPhim ev = new Event_USPhim();
        public US_QLPhim()
        {
            InitializeComponent();
            List<Phim> dsPhim = ev.layDSPhim();
            if(dsPhim != null ) 
            { 
                foreach(var item in dsPhim)
                {
                    US_Phim phim = new US_Phim();
                    phim.phim = item;
                    flpFilm.Controls.Add(phim);
                }    
            }
            else
            {
                Label text = new Label();
                text.Text = "Không tìm thấy phim trong hệ thống!";
                text.ForeColor = Color.Black;
                flpFilm.Controls.Add(text);
            }    
        }
    }
}
