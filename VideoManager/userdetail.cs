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
    public partial class userdetail : Form
    {
        string uploadimg_sql = "update  appuser set avator=@avatordata where userid=@name;";
        public userdetail()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlParameter userid = new SqlParameter("@name", SqlDbType.VarChar, 40);
            userid.Value = MainWindow.myaccount.userid;
            SqlCommand mycom = new SqlCommand(uploadimg_sql, MainWindow.mycon);
            mycom.Parameters.Add(userid);

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "*.jpg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                Byte[] mybyte = new byte[fs.Length];
                fs.Read(mybyte, 0, mybyte.Length);
                fs.Close();
                SqlParameter prm = new SqlParameter("@avatordata", SqlDbType.Image, mybyte.Length);
            }
        }
    }
}
