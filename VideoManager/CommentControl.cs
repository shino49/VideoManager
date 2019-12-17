using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoManager
{
    public partial class CommentControl : UserControl
    {
        public CommentControl(string username, System.IO.Stream userpic, DateTime time,string commcont)
        {
            InitializeComponent();
            this.label1.Text = username;
            this.label2.Text = time.ToString();
            this.textBox1.Text = commcont;
            this.pictureBox1.BackgroundImage = Image.FromStream(userpic);
        }
    }
}
