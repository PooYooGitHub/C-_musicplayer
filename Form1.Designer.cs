namespace sound
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            listBox1 = new ListBox();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
            openFileDialog5 = new OpenFileDialog();
            label1 = new Label();
            trackBar1 = new TrackBar();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(126, 564);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1040, 100);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 57;
            listBox1.Location = new Point(126, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(930, 460);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1064, 166);
            button1.Name = "button1";
            button1.Size = new Size(162, 97);
            button1.TabIndex = 2;
            button1.Text = "选择音频";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // openFileDialog5
            // 
            openFileDialog5.FileName = "openFileDialog5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 17);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1189, 477);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(69, 187);
            trackBar1.TabIndex = 4;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.KeyUp += trackBar1_KeyUp;
            // 
            // button2
            // 
            button2.Location = new Point(1077, 319);
            button2.Name = "button2";
            button2.Size = new Size(149, 87);
            button2.TabIndex = 7;
            button2.Text = "下一曲";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1067, 401);
            button3.Name = "button3";
            button3.Size = new Size(162, 79);
            button3.TabIndex = 8;
            button3.Text = "停止播放";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(1067, 258);
            button4.Name = "button4";
            button4.Size = new Size(159, 64);
            button4.TabIndex = 9;
            button4.Text = "播放ojj文件";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 720);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ListBox listBox1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private OpenFileDialog openFileDialog5;
        private Label label1;
        private TrackBar trackBar1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
