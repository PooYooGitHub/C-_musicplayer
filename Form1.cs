using AxWMPLib;
using NAudio.Wave;
using NAudio;
using System.IO;
using System;
using System.Windows.Forms;
using NAudio.Wave;

using NVorbis;
using NAudio.Vorbis;

namespace sound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private List<String> localmusiclist = new List<String>();
        private void button1_Click(object sender, EventArgs e)
        {
            String[] files = null;

            //添加过滤器
            openFileDialog1.Filter = "选择影评|*.mp3;*.flac;*.wav";

            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                localmusiclist.Clear();
                if (files != null)
                {
                    Array.Clear(files, 0, files.Length);
                }

                files = openFileDialog1.FileNames;
                String[] array = files;
                foreach (String file in array)
                {
                    listBox1.Items.Add(file);
                    localmusiclist.Add(file);
                }
            }
        }

        private void musicPlay(String URL)
        {
            String extention = Path.GetExtension(URL);
            if (extention == ".ogg")
            {
                Console.WriteLine("这是一个ogg文件");
            }
            else
                axWindowsMediaPlayer1.Ctlcontrols.play();

            label1.Text = Path.GetFileNameWithoutExtension(URL);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (localmusiclist.Count > 0)
            {
                axWindowsMediaPlayer1.URL = localmusiclist[listBox1.SelectedIndex];
                musicPlay(axWindowsMediaPlayer1.URL);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void trackBar1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex + 1;
            if (index >= localmusiclist.Count)
            {
                index = 0;
            }
            axWindowsMediaPlayer1.URL = localmusiclist[index];
            musicPlay(axWindowsMediaPlayer1.URL);
            listBox1.SelectedIndex = index;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "打开音频|*.ogg";
            String oggPath = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK) { 
                oggPath = openFileDialog.FileName;
            }

            using (var vorbisWaveReader = new VorbisWaveReader(oggPath))
            {
                using (var waveOut = new WaveOutEvent())
                {
                    waveOut.Init(vorbisWaveReader);
                    waveOut.Play();
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
        }
    }
}
