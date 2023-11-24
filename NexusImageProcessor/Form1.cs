using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;
using HNUDIP;
using AForge.Video;
using AForge.Video.DirectShow;

namespace NexusImageProcessor
{
    public partial class Form1 : Form
    {
        Bitmap loadImage, resultImage, imageA, imageB, colorgreen, virtualBackground;
        //private Device currentDevice;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private int frameCounter = 0;
        private const int FramesToSkip = 5;
        private bool on = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)       // scans through the entire photo per pixel
                for(int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, pixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;   // get average for gray neutralization 
                    resultImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey)); // neutralize pixel colors to gray
                }
            pictureBox2.Image = resultImage;
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, Color.FromArgb(255-pixel.R, 255-pixel.G, 255-pixel.B)); // subtracts color from light (upsidedown)
                }
            pictureBox2.Image = resultImage;
        }

        private void loadImageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
        }

        private void loadBackgorundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(imageA.Width, imageA.Height);

            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageB.Width; x++)
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);

                    if (subtractvalue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            pictureBox2.Image = resultImage;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Problem Encountered: Camera is found but only displays black screen in picturebox.!
            /*Device[] devices = DeviceManager.GetAllDevices();

            if (devices.Length > 0)
            {
                currentDevice = devices[0]; // Select the first device

                currentDevice.ShowWindow(pictureBox1);
            }
            else
            {
                MessageBox.Show("No camera devices found.");
            }*/
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!on)
            {
                pictureBox1.Image = (System.Drawing.Image)eventArgs.Frame.Clone();
            }
            else
            {
                frameCounter++;

                if (frameCounter % FramesToSkip == 0)
                {

                    Bitmap currentFrame = (Bitmap)eventArgs.Frame.Clone();
                    Bitmap resultFrame = new Bitmap(virtualBackground.Width, virtualBackground.Height);

                    Color mygreen = Color.FromArgb(0, 0, 255);
                    int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
                    int threshold = 75;

                    for (int x = 0; x < currentFrame.Width; x++)
                    {
                        for (int y = 0; y < currentFrame.Height; y++)
                        {
                            Color pixel = ImageProcess.GetPixel(currentFrame, x, y);
                            Color backpixel = ImageProcess.GetPixel(virtualBackground, x, y);

                            int grey = (pixel.R + pixel.G + pixel.B) / 3;
                            int subtractvalue = Math.Abs(grey - greygreen);

                            if (subtractvalue > threshold)
                                resultFrame.SetPixel(x, y, backpixel);
                            else
                                resultFrame.SetPixel(x, y, pixel);
                        }
                    }
                    pictureBox1.Image = resultFrame;
                }
                    if (frameCounter == int.MaxValue)
                    {
                        frameCounter = 0;
                    }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoSource.SignalToStop();
            videoSource.WaitForStop();
            pictureBox1.Image = null;
            on = false;
        }

        private void virtualBackgroudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog4.FileName;
            virtualBackground = new Bitmap(filePath);

            if (videoSource != null && videoSource.VideoCapabilities != null && videoSource.VideoCapabilities.Length > 0)
            {
                if (virtualBackground.Width != videoSource.VideoCapabilities[0].FrameSize.Width ||
                    virtualBackground.Height != videoSource.VideoCapabilities[0].FrameSize.Height)
                {
                    virtualBackground = ScaleImage(virtualBackground, videoSource.VideoCapabilities[0].FrameSize.Width, videoSource.VideoCapabilities[0].FrameSize.Height);
                }
            }
            else
            {
                MessageBox.Show("Video source is not initialized or does not have available resolutions.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }

        private void applyVirtualBackgroudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(virtualBackground != null)
            {
                on = true;
            } 
            else
            {
                MessageBox.Show("Need to select a virtual background.");
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;   
                    resultImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey)); 
                }

            // plot values into the histdata array(tally)
            Color sample;
            int[] histdata = new int[256];
            for (int x = 0; x < loadImage.Width; x++)
                for (int y = 0; y < loadImage.Height; y++)
                {
                    sample = resultImage.GetPixel(x, y);
                    histdata[sample.R]++;
                }

            // make background color to white
            Bitmap Gdata = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
                for (int y = 0; y < 800; y++)
                {
                    Gdata.SetPixel(x, y, Color.White);
                }

            // plot histadata for visualization
            for (int x = 0; x < 256; x++)
                for (int y = 0; y < Math.Min(histdata[x]/5, 800); y++)
                {
                    Gdata.SetPixel(x, 799-y, Color.Black);
                }

            pictureBox2.Image = Gdata;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);

            for (int x = 0; x < loadImage.Width; x++)      
                for (int y = 0; y < loadImage.Height; y++)
                {
                    Color pixel = loadImage.GetPixel(x, y);

                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);
        
                    resultImage.SetPixel(x, y, Color.FromArgb(Math.Min(tr,255), Math.Min(tg, 255), Math.Min(tb,255)));
                }

            pictureBox2.Image = resultImage;
        }

        public static Bitmap ScaleImage(Image originalImage, int newWidth, int newHeight)
        {
            // Create a new bitmap with the desired dimensions
            Bitmap scaledImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                // Maintain the aspect ratio while scaling
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return scaledImage;
        }

        private void loadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
