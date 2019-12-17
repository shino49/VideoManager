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
    public partial class Comment_window : Form
    {
        private List<CommentControl> commenypool = new List<CommentControl>();
        public Comment_window()
        {
            InitializeComponent();
        }

        private void Comment_window_Load(object sender, EventArgs e)
        {
            InitComment();
        }

        private void InitComment()
        {
            
        }
    }
}
