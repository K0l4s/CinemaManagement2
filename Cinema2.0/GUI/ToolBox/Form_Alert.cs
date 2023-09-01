using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema2._0.GUI.ToolBox
{
    public partial class Form_Alert : Form
    {
        string text = null;
        public Form_Alert(string text)
        {
            InitializeComponent();
            this.text = text;
        }

        private void btnClosePannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {
            txt.Text = text;
        }
    }
}
