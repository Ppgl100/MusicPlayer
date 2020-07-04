using MusicPlayer.Properties;
using NAudio.Wave;
using Plugin.SimpleAudioPlayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public string myPath="";
        public SoundPlayer player = new SoundPlayer();
        public int playCounter = 0;
        public List<String> myTrackList = new List<string>();
        public int trackListCounter = 0;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.trackTitle.Text = " NO TITLE LOADED";
            this.FormClosing += Form1_Close;
        }

        private void Form1_Close(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void loadPath_Click(object sender, EventArgs e)
        {
            myTrackList.Clear();
            trackListCounter = 0;
            FolderBrowserDialog browser = new FolderBrowserDialog();
            myPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                myPath = browser.SelectedPath;
            }
            else
            {
                return;
            }

            string[] fileEntries = Directory.GetFiles(myPath);
            foreach (string fileName in fileEntries)
            {         
                if (fileName.ToLower().EndsWith(".mp3") || fileName.ToLower().EndsWith(".wav"))
                {
                    myTrackList.Add(fileName);
                    createNewTrackEntry(fileName);
                }
            }
        }

        private void createNewTrackEntry(string filePath)
        {
            Panel myDynamicPanel = new Panel();
            myDynamicPanel.Size = new Size(790,100);
            myDynamicPanel.BackColor = Color.FromArgb(237, 62, 117);

            Label myDynamicLabel = new Label();
            myDynamicLabel.Dock = DockStyle.Fill;
            myDynamicLabel.BackColor = Color.FromArgb(237, 62, 117);
            myDynamicLabel.ForeColor = Color.FromArgb(56,56,56);
            myDynamicLabel.Font = new Font("Microsoft Sans Serif", 18);
            myDynamicLabel.Text = Path.GetFileName(filePath);
            myDynamicLabel.Tag = filePath;
            myDynamicLabel.TextAlign = ContentAlignment.MiddleCenter;
            myDynamicLabel.Click += musicClick;

            myDynamicPanel.Controls.Add(myDynamicLabel);
            myLayout.Controls.Add(myDynamicPanel);

        }

        Stream GetStreamFromFile(string filename)
        {
            //var assembly = typeof(string).GetTypeInfo().Assembly;
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(filename);
            return stream;
        }

        private void musicClick(object sender, EventArgs e)
        {
            
         

            Label myLabel = (Label)sender;

            WaveFileReader wf = new WaveFileReader(myLabel.Tag.ToString());

            player.SoundLocation = myLabel.Tag.ToString();
            player.Play();

            double duration = Math.Round(double.Parse(""+wf.TotalTime.TotalSeconds), 0);
            this.musicTime.Value = 0;
            this.musicTime.Maximum = (int)duration;
            play.BackgroundImage = Resources.pauseButton;
            playCounter = 0;
            this.trackTitle.Text = myLabel.Text;

            new Thread(() =>
            {
                while (true)
                {
                        this.Invoke(new MethodInvoker(delegate
                        {
                            if (this.musicTime.Value < this.musicTime.Maximum)
                            {
                                this.musicTime.Value = this.musicTime.Value + 1;
                            }
                        }));
                        Thread.Sleep(1000);                 
                }
            }).Start();



        }

        private void play_Click(object sender, EventArgs e)
        {

            if (playCounter == 0)
            {
                this.musicTime.Value = 0;
                player.Play();
                play.BackgroundImage = Resources.pauseButton;
                playCounter = 1;
            }
            else
            {
                player.Stop();
                play.BackgroundImage = Resources.playButton;
                playCounter = 0;
            }
        }

        private void myLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void findTrack(int trackNr)
        {
            int counter = 0;
            foreach (Control c in myLayout.Controls)
            {
                foreach(Control c2 in c.Controls)
                {
                    if(counter == trackNr)
                    {
                        player.SoundLocation = c2.Tag.ToString();
                        player.Play();

                        WaveFileReader wf = new WaveFileReader(c2.Tag.ToString());
                        double duration = Math.Round(double.Parse("" + wf.TotalTime.TotalSeconds), 0);
                        this.musicTime.Value = 0;
                        this.musicTime.Maximum = (int)duration;
                        play.BackgroundImage = Resources.pauseButton;
                        playCounter = 0;
                        this.trackTitle.Text = c2.Text;
                        break;
                    }
                }
                counter++;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (trackListCounter < myTrackList.Count-1)
            {
                trackListCounter++;
            }
            else
            {
                trackListCounter = 0;
            }

            findTrack(trackListCounter);
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (trackListCounter >0)
            {
                trackListCounter--;
            }
            else
            {
                trackListCounter = myTrackList.Count-1;
            }

            findTrack(trackListCounter);

        }
    }
}
