﻿using System;
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
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using Microsoft.Win32;

namespace VideoMng_Wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

		private bool mediaPlayerIsPlaying = false;
		private bool userIsDraggingSlider = false;
		private List<TextBlockBarrage> BarragePool;

		public MainWindow()
		{
			InitializeComponent();
			BarragePool = new List<TextBlockBarrage>();
			
			//BarragePool.Add(exba);
			//BarragePanrl.
			//mePlayer.
			DispatcherTimer timer = new DispatcherTimer();
			timer.Interval = TimeSpan.FromSeconds(1);
			timer.Tick += timer_Tick;
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if ((mePlayer.Source != null) && (mePlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
			{
				sliProgress.Minimum = 0;
				sliProgress.Maximum = mePlayer.NaturalDuration.TimeSpan.TotalSeconds;
				sliProgress.Value = mePlayer.Position.TotalSeconds;

				TextBlockBarrage exba = new TextBlockBarrage();
				exba.Text = "test";
				exba.Translation_Left = 0;
				exba.Translation_Right = this.mePlayer.ActualWidth;
				exba.Enabled = true;
				//exba.Margin.Top = 0.5 * this.mePlayer.ActualHeight;
				this.BigGrid.Children.Add(exba);
				
			}
		}

		private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}

		private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == true)
				mePlayer.Source = new Uri(openFileDialog.FileName);
		}

		private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (mePlayer != null) && (mePlayer.Source != null);
		}

		private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			mePlayer.Play();
			mediaPlayerIsPlaying = true;
		}

		private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = mediaPlayerIsPlaying;
		}

		private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			mePlayer.Pause();
		}

		private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = mediaPlayerIsPlaying;
		}

		private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			mePlayer.Stop();
			mediaPlayerIsPlaying = false;
		}

		private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
		{
			userIsDraggingSlider = true;
		}

		private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
		{
			userIsDraggingSlider = false;
			mePlayer.Position = TimeSpan.FromSeconds(sliProgress.Value);
		}

		private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			lblProgressStatus.Text = TimeSpan.FromSeconds(sliProgress.Value).ToString(@"hh\:mm\:ss");
		}

		private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
		{
			mePlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
		}
	}
}
