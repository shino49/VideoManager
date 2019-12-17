using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoPlayer
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //playercontainer.Source = new Uri(path, UriKind.Absolute);
        }

        public void LoadVideo(string path)
        {
            if(path != "")
                playercontainer.Source = new Uri(path, UriKind.Absolute);
        }
        public bool PlayVideo()
        {
            if (playercontainer.Source == null)
            {
                MessageBox.Show("影片无法播放");
                return false;
            }
            playercontainer.Play();
            return true;
        }

        public void StopVideo()
        {
            playercontainer.Stop();
        }

        public void PauseVideo()
        {
            this.playercontainer.Pause();
        }

        public double getTotalSeconds()
        {
            if (this.playercontainer.NaturalDuration.HasTimeSpan)
            {
                return (this.playercontainer.NaturalDuration.TimeSpan.TotalSeconds);
            }
            else
            {
                return 0;
            }
        }

        public double getCurSeconds()
        {
            return (this.playercontainer.Position.TotalSeconds);
        }

        public void setPosVideo(double targetTime)
        {
            this.playercontainer.Position = TimeSpan.FromSeconds(targetTime);
        }
    }
}
