using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CCTV_CameraCapture
{
    public partial class CameraForm : Form
    {
        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;
        private int counter;


        public CameraForm()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            _frame = new Mat();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                ib_Frame.Image = _frame;
                long dateTimeUtc = (long)DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                if (counter % 1000 == 0)
                {
                    //For test
                    _frame.Save($"C:\\Users\\VDA\\VDA_DATA\\Programming\\Saved_Img\\CameraCapture_Img_{dateTimeUtc}.jpg");

                    SendToFTP(_frame, dateTimeUtc);
                }
                counter += 10;
            }
        }
       
        private void Btn_StartStop_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                { 
                    btn_StartStop.Text = "Start";
                    _capture.Pause();

                }
                else
                {
                    btn_StartStop.Text = "Stop";
                    _capture.Start();
                }
                _captureInProgress = !_captureInProgress;
            }
        }

        public static void SendToFTP(Mat _frame, long dateTimeUtc)
        {
            Bitmap img = _frame.Bitmap;
            //Work IP
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://10.210.17.235/CameraCapture_Img_{dateTimeUtc}.jpg");
            //Home IP
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://ftp://192.168.1.4//CameraCapture_Img_{dateTimeUtc}.jpg");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("v.dovnich@gmail.com", "masikas290");
            byte[] fileContents = ImageToByte(img);
            request.ContentLength = fileContents.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }
    }
}
