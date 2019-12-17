namespace VideoManager
{
    partial class Player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.视频选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.循环播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.time_lable = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new VideoPlayer.UserControl1();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 936);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.视频选项ToolStripMenuItem,
            this.播放选项ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 视频选项ToolStripMenuItem
            // 
            this.视频选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem});
            this.视频选项ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.视频选项ToolStripMenuItem.Name = "视频选项ToolStripMenuItem";
            this.视频选项ToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.视频选项ToolStripMenuItem.Text = "视频选项";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 播放选项ToolStripMenuItem
            // 
            this.播放选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.循环播放ToolStripMenuItem});
            this.播放选项ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.播放选项ToolStripMenuItem.Name = "播放选项ToolStripMenuItem";
            this.播放选项ToolStripMenuItem.Size = new System.Drawing.Size(98, 30);
            this.播放选项ToolStripMenuItem.Text = "播放选项";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.暂停ToolStripMenuItem.Text = "暂停";
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.停止ToolStripMenuItem.Text = "停止";
            // 
            // 循环播放ToolStripMenuItem
            // 
            this.循环播放ToolStripMenuItem.Name = "循环播放ToolStripMenuItem";
            this.循环播放ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.循环播放ToolStripMenuItem.Text = "循环播放";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.trackBar2);
            this.panel3.Controls.Add(this.time_lable);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.stop_button);
            this.panel3.Controls.Add(this.play_button);
            this.panel3.Controls.Add(this.splitter2);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 972);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 78);
            this.panel3.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(105, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1583, 78);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(105, 78);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 936);
            this.panel4.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(111, 6);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1384, 69);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // time_lable
            // 
            this.time_lable.AutoSize = true;
            this.time_lable.Location = new System.Drawing.Point(1501, 33);
            this.time_lable.Name = "time_lable";
            this.time_lable.Size = new System.Drawing.Size(161, 18);
            this.time_lable.TabIndex = 6;
            this.time_lable.Text = "00:00:00/00:00:00";
            this.time_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1685, 6);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(174, 69);
            this.trackBar2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1865, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "100%";
            // 
            // stop_button
            // 
            this.stop_button.Image = global::VideoManager.Properties.Resources.stop1;
            this.stop_button.Location = new System.Drawing.Point(57, 18);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(48, 48);
            this.stop_button.TabIndex = 3;
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // play_button
            // 
            this.play_button.Image = global::VideoManager.Properties.Resources.play;
            this.play_button.Location = new System.Drawing.Point(3, 18);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(48, 48);
            this.play_button.TabIndex = 2;
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 763);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(379, 173);
            this.panel5.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 28);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(109, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "评论";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1545, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 936);
            this.panel2.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1545, 936);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player";
            this.Text = "Player";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private VideoPlayer.UserControl1 userControl11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 视频选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 循环播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label time_lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}