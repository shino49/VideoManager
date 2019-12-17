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
    public partial class Player : Form
    {
        private System.Timers.Timer timer1;
        private bool isPlaying = false;
        public Player()
        {
            InitializeComponent();
            
        }

        private void Timer1_TimesUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            //int sec;
            this.userControl11.Dispatcher.Invoke(new Action(() => { this.trackBar1.Value = (int)this.userControl11.getCurSeconds(); }));
            this.userControl11.Dispatcher.Invoke(new Action(() => { 
                int totalsec = (int)this.userControl11.getCurSeconds();
                var st = new StringBuilder();
                st.Append((int)(totalsec / 3600));
                st.Append(":");
                st.Append((int)((totalsec % 3600) / 60));
                st.Append(":");
                st.Append((int)(totalsec % 60));
                this.time_lable.Text = st.ToString();
            }));
            //this.trackBar1.Value = sec;
        }

        public void LoadVideo(string path)
        {
            
            this.userControl11.LoadVideo(path);
            try
            {
                if (!this.userControl11.PlayVideo())
                {
                    throw new Exception();
                }
                this.play_button.Image = global::VideoManager.Properties.Resources.pause1;
                this.trackBar1.Minimum = 0;
                //this.trackBar1.Maximum = (int)this.userControl11.getTotalSeconds();
                this.trackBar1.Maximum = 100;
                timer1 = new System.Timers.Timer(0.5);
                timer1.Enabled = true;
                timer1.AutoReset = true;
                timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_TimesUp);
                timer1.Start();

            }
            catch(Exception er)
            {
                MessageBox.Show("error open the video\n"+er);
            }
        }


        private void play_button_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                if (!this.userControl11.PlayVideo())
                {
                    return;
                }
                this.play_button.Image = global::VideoManager.Properties.Resources.pause1;
                this.isPlaying = true;
            }
            else
            {
                //MessageBox.Show(isPlaying.ToString());
                this.userControl11.PauseVideo();
                this.play_button.Image = global::VideoManager.Properties.Resources.play;
                this.isPlaying = false;
            }
        }
        private void stop_button_Click(object sender, EventArgs e)
        {
            this.userControl11.StopVideo();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Media files (*.mp4;*.rmvb;*.mkv)|*.mp4;*.rmvb;*.mkv|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.LoadVideo(openFileDialog1.FileName);
            }
                

        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.userControl11.PlayVideo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
