using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoManager
{
    public partial class MainWindow : Form
    {
        public MediaCargo videocargo;
        public MainWindow()
        {
            InitializeComponent();
            videocargo = new MediaCargo();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //this.panel2.Width = videocargo.Width;
            //this.panel2.Height = videocargo.Height;
            //p1.LoadVideo();
        }

        private void media_cargo_menu_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(videocargo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否关闭？", "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
                return;
        }
    }
}
