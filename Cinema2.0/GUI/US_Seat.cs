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
    public partial class US_Seat : UserControl
    {
        public VeXemPhim VeXemPhim { get; set; }
        public bool choose { get;set; } //Cờ hiệu đánh dấu được chọn hay không
        public bool flag { get;set; } //Cờ hiệu enable ghế
        public US_Seat()
        {
            InitializeComponent();
            //choose = false; //Xem xét vé có đang được chọn hay không
            
        }
        private void chonGhe()
        {
            if (choose == false)
            {
                choose = true;
                this.BackColor = Color.LightSkyBlue;
            }
            else
            {
                choose = false;
                this.BackColor = Color.White;
            }    
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            chonGhe();
        }

        public void US_Seat_Load(object sender, EventArgs e)
        {
            if (choose)
                this.BackColor = Color.LightSkyBlue;
            else
                this.BackColor = Color.White;
            if (flag)
                this.Enabled = true;
            else
                this.Enabled = false;
            if (VeXemPhim!=null)
            {
                txtMaGhe.Text = VeXemPhim.Ghe.tenGhe;
                if (!String.IsNullOrEmpty(VeXemPhim.maHoaDon))
                {
                    this.Enabled = false;
                    this.BackColor = Color.Red;
                }
                else
                {
                    this.BackColor = Color.White;
                }    
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {
            chonGhe();
        }

        private void txtMaGhe_Click(object sender, EventArgs e)
        {
            chonGhe();
        }
    }
}
