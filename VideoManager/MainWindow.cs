using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoManager
{
    public enum claims
    {
        guest,
        user,
        admin
    };
    public struct account
    {
        public bool isLogin;
        public string username;
        public Byte[] avater;
        public int userid;
        public claims claim;
        public account(bool isLogin)
        {
            this.isLogin = isLogin;
            this.username = null;
            this.avater = null;
            this.userid = -1;
            this.claim = claims.guest;
        }
    };

    public partial class MainWindow : Form
    {
        public static SqlConnection mycon;
        public MediaCargo videocargo;
        public static account myaccount;

        static MainWindow()
        {
            string constr = @"Data Source = DESKTOP-PF69SJV\SQLEXPRESS; Initial Catalog = video_manager; Integrated Security = True";
            mycon = new SqlConnection(constr);
            myaccount = new account(false);
        }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!myaccount.isLogin)
            {
                (new loginorsign()).ShowDialog();
                if (myaccount.isLogin)
                {
                    this.label1.Text = "ID: " + myaccount.userid;
                    this.label2.Text = "用户名: " + myaccount.username;
                    if (myaccount.avater != null)
                    {
                        System.IO.MemoryStream ims = new System.IO.MemoryStream(myaccount.avater);
                        this.pictureBox1.BackgroundImage = Image.FromStream(ims);
                    }
                }
                return;
            }
            else
            {

            }

        }
    }
}
