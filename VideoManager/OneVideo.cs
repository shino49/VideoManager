using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VideoManager
{
    class OneVideo
    {
        private string Name;
        public string VideoName
        {
            get
            {
                return this.Name;
            }
        }

        private bool isLocal;
        private string LocalPath;
        private string RemoteUrl;

        public List<string> actors = new List<string>();

        public List<Comment> comments = new List<Comment>();
        public List<OneDanmmu> danmus = new List<OneDanmmu>();

        public OneVideo(string name)
        {
            this.Name = name;
        }

        public OneVideo(string name,string path)
        {
            this.Name = name;
            this.LocalPath = path;
            this.isLocal = true;
        }

        public void LoadPath(string path)
        {
            this.LocalPath = path;
        }

        public bool LoadComment(Comment comt)
        {
            if(comt.user != "" && comt.isShow)
            {
                this.comments.Add(comt);
                return true;
            }
            return false;
        }



        public bool LoadDanmu(OneDanmmu danmu)
        {
            if (danmu.isShow)
            {
                this.danmus.Add(danmu);
                return true;
            }
            return false;
        }
       
    }





    struct Comment
    {
        public string user;
        public string content;
        public DateTime CommTime;
        public bool isShow;
        public Comment(string user,string cont,DateTime commt,bool show)
        {
            this.user = user;
            this.content = cont;
            this.CommTime = commt;
            this.isShow = show;
        }
    }

    struct OneDanmmu
    {
        public string user;
        public string content;
        public int VideoTime;
        public string color;
        public int speed;
        public bool isShow;
    }
}
