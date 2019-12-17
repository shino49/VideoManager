using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace VideoMng_Wpf
{

    public class TextBlockBarrage : TextBlock
    {
        TranslateTransform TranslateTransformClass;
        /// <summary>
        /// 获取或设置控件动画执行时长 秒
        /// </summary>
        public double FromSeconds { get; set; }
        /// <summary>
        /// 加载时间
        /// </summary>
        public DateTime LoadingTime { get; set; }
        /// <summary>
        /// 运行完毕离左边的距离
        /// </summary>
        public double Translation_Left { get; set; }
        /// <summary>
        /// 运行完毕离右边边的距离
        /// </summary>
        public double Translation_Right { get; set; }

        public bool Enabled { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        public TextBlockBarrage()
            : base()
        {

            LoadingTime = DateTime.Now;
            TranslateTransformClass = new TranslateTransform();
            this.RenderTransform = TranslateTransformClass;
            this.Loaded += new RoutedEventHandler(TextBlockBarrage_Loaded);
        }



        /// <summary>
        /// 加载触发时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         void TextBlockBarrage_Loaded(object sender, RoutedEventArgs e)
        {
            if (TranslateTransformClass == null)
                return;
            if (!Enabled)
            {
                return;
            }
            else
            {
                Enabled = false;
            }
            //执行时间
            Duration duration = new Duration(TimeSpan.FromSeconds(FromSeconds));
            DoubleAnimation da = new DoubleAnimation(Translation_Left, Translation_Right, duration);
            da.AutoReverse = false;
            da.FillBehavior = FillBehavior.HoldEnd;

            TranslateTransformClass.BeginAnimation(TranslateTransform.XProperty, da);
            this.Loaded -= new RoutedEventHandler(TextBlockBarrage_Loaded);
        }


    }

    /// <summary>
    /// 纯图片弹幕控件
    /// </summary>
    public class ImageBarrage : Image
    {
        TranslateTransform TranslateTransformClass;
        /// <summary>
        /// 获取或设置控件动画执行时长 秒
        /// </summary>
        public double FromSeconds { get; set; }
        /// <summary>
        /// 加载时间
        /// </summary>
        public DateTime LoadingTime { get; set; }
        /// <summary>
        /// 运行完毕离左边的距离
        /// </summary>
        public double Translation_Left { get; set; }
        /// <summary>
        /// 运行完毕离右边边的距离
        /// </summary>
        public double Translation_Right { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        public ImageBarrage()
            : base()
        {
            LoadingTime = DateTime.Now;
            TranslateTransformClass = new TranslateTransform();
            this.RenderTransform = TranslateTransformClass;
            this.Loaded += new RoutedEventHandler(ImageBarrage_Loaded);
        }
        /// <summary>
        /// 加载触发时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageBarrage_Loaded(object sender, RoutedEventArgs e)
        {
            if (TranslateTransformClass == null)
                return;

            //执行时间
            Duration duration = new Duration(TimeSpan.FromSeconds(FromSeconds));
            DoubleAnimation da = new DoubleAnimation(Translation_Left, Translation_Right, duration);
            da.AutoReverse = false;
            da.FillBehavior = FillBehavior.HoldEnd;
            TranslateTransformClass.BeginAnimation(TranslateTransform.XProperty, da);
            this.Loaded -= new RoutedEventHandler(ImageBarrage_Loaded);

        }

    }

    /// <summary>
    /// 可编辑弹幕控件（高级功能）
    /// </summary>
    public class SeniorBarrageGrid : Grid
    {
        TranslateTransform TranslateTransformClass;
        /// <summary>
        /// 获取或设置控件动画执行时长 秒
        /// </summary>
        public double FromSeconds { get; set; }
        /// <summary>
        /// 加载时间
        /// </summary>
        public DateTime LoadingTime { get; set; }
        /// <summary>
        /// 运行完毕离左边的距离
        /// </summary>
        public double Translation_Left { get; set; }
        /// <summary>
        /// 运行完毕离右边边的距离
        /// </summary>
        public double Translation_Right { get; set; }

        public bool Enabled { get; set; }
        /// <summary>
        /// 初始化
        /// </summary>
        public SeniorBarrageGrid()
            : base()
        {

            LoadingTime = DateTime.Now;
            TranslateTransformClass = new TranslateTransform();
            this.RenderTransform = TranslateTransformClass;
            this.Loaded += new RoutedEventHandler(SeniorBarrageGrid_Loaded);
        }



        /// <summary>
        /// 加载触发时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SeniorBarrageGrid_Loaded(object sender, RoutedEventArgs e)
        {
            if (TranslateTransformClass == null)
                return;
            if (!Enabled)
            {
                return;
            }
            else
            {
                Enabled = false;
            }

            Translation_Right = Translation_Right > 0 ? Translation_Right * -1 : Translation_Right;
            //执行时间
            Duration duration = new Duration(TimeSpan.FromSeconds(FromSeconds));
            DoubleAnimation da = new DoubleAnimation(Translation_Left, Translation_Right, duration);
            da.AutoReverse = false;
            da.FillBehavior = FillBehavior.HoldEnd;

            TranslateTransformClass.BeginAnimation(TranslateTransform.XProperty, da);
            this.Loaded -= new RoutedEventHandler(SeniorBarrageGrid_Loaded);
        }
    }
}

