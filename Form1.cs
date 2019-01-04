using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Maker_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float iVideo1Duration = 3;
        int a = 0;
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                //saving Video
                axTimelineControl1.SetVideoTrackResolution(720, 480);

                axTimelineControl1.SetVideoTrackFrameRate(25);

                axTimelineControl1.OutputType = 2;

                axTimelineControl1.MP4AspectRatio = 0;

                axTimelineControl1.MP4AudioBitrate = 96000;

                axTimelineControl1.MP4AudioChannels = 2;

                axTimelineControl1.MP4AudioSampleRate = 44100;

                axTimelineControl1.MP4Framerate = 25;

                axTimelineControl1.MP4H264Preset = 0;

                axTimelineControl1.MP4Height = 480;

                axTimelineControl1.MP4Width = 720;

                axTimelineControl1.MP4VideoBitrate = 5000000;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp4|All Files|*.*";
                sf.ShowDialog();
                axTimelineControl1.Save(sf.FileName);

                MessageBox.Show("Saved Successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          

        }

        private void btn_addImages_Click(object sender, EventArgs e)
        {
            //add Images.
            OpenFileDialog op = new OpenFileDialog();

            op.Multiselect = true;
            op.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                        "All files (*.*)|*.*";
            op.ShowDialog();
           


           // string strVideo1 = op.FileName;
            foreach (String path in op.FileNames)
            {
                axTimelineControl1.AddImageClip(axTimelineControl1.GetVideo1TrackIndex(), path, 0, iVideo1Duration);
                a++;
            }
            
           // axTimelineControl1.AddImageClip(axTimelineControl1.GetVideo1TrackIndex(), strVideo1, 0, iVideo1Duration);
           
           
          
       
           
        }

        private void axTimelineControl1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_paly_Click(object sender, EventArgs e)
        {
            try
            {
                //play current clip.
                this.axTimelineControl1.SetPreviewWnd((int)pictureBox1.Handle);
                this.axTimelineControl1.Play();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_addAudio_Click(object sender, EventArgs e)
        {
            //adding audio file.
            OpenFileDialog op = new OpenFileDialog();

            op.Multiselect = true;
            op.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            op.ShowDialog();
            string strVideo1 = op.FileName;
            axTimelineControl1.AddAudioClip(axTimelineControl1.GetAudio1TrackIndex(), strVideo1, 0, iVideo1Duration*a, 0, 1);
            a = 0;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            axTimelineControl1.Clear();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axTimelineControl1.Pause();
        }

      

      
    }
}
