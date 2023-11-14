using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Ocl;
using Emgu.CV.Structure;
using System.Collections.Generic;
using Emgu.CV.UI;

namespace Lab2
{
    public partial class Lab2Form : Form
    {
        private const int MaxValue = 255;

        private Mat _original;
        private Mat _original2;
        private Mat _processed;

        private Image<Gray, byte> img;
        private Image<Gray, byte> result;
        public Lab2Form()
        {
            InitializeComponent();
            _original = new Mat();
            _processed = new Mat();
            _original2 = new Mat();
            UpdateScreen();
        }


        private void HighPassFilter()
        {
            float[,] matrix = new float[3, 3] {
                      {0, -1,  0},
                      { -1,  5, -1},
                      {0, -1,  0 }
                    };
            _processed = new Mat(_original2.Rows, _original2.Cols, DepthType.Cv8U, _original2.NumberOfChannels);
            CvInvoke.Filter2D(_original2, _processed, new Matrix<float>(matrix), new Point(-1, -1));
            UpdateScreen();
        }


        private void DrawHistogram(float[] values, ref Image<Gray, byte> histImage, Gray color)
        {
            float binWidth = histImage.Width / (float)values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                float binHeight = values[i];
                Rectangle rect = new Rectangle((int)(i * binWidth), (int)(histImage.Height - binHeight), (int)binWidth, (int)binHeight);
                CvInvoke.Rectangle(histImage, rect, color.MCvScalar, -1);
            }
        }

        private void histogramEcv()
        {
            int histWidth = 400;
            int histHeight = 400;
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { new Image<Gray, byte>(_original) }, false, null);
            float[] Values = hist.GetBinValues();


            float maxBinValue = Values.Max();

            for (int i = 0; i < Values.Length; i++)
            {
                Values[i] = (Values[i] / maxBinValue) * histHeight;
            }


            Image<Gray, byte> histImage = new Image<Gray, byte>(histWidth, histHeight, new Gray(100));


            DrawHistogram(Values, ref histImage, new Gray(255));
            Histogram1.Image = histImage.ToBitmap();
            _processed = new Mat(_original.Rows, _original.Cols, DepthType.Cv8U, _original.NumberOfChannels);
            CvInvoke.EqualizeHist(_original2, _processed);

            
            
            UpdateScreen();
        }


        private void OnOpenButtonClicked(object sender, EventArgs e)
        {
            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                var fileName = openPicture.FileName;
                _original = CvInvoke.Imread(fileName);
                _original2 = CvInvoke.Imread(fileName, ImreadModes.Grayscale);

                CvInvoke.Resize(_original, _original, new System.Drawing.Size(Original.Width, Original.Height), 0, 0, Inter.Linear);
                CvInvoke.Resize(_original2, _original2, new System.Drawing.Size(Original.Width, Original.Height), 0, 0, Inter.Linear);
                UpdateScreen();
            }
        }

        private void OnSaveFilteredToolStripMenuItemClicked(object sender, EventArgs e)
        {
            if (savePicture.ShowDialog() == DialogResult.OK)
            {
                var fileName = savePicture.FileName;

                _processed.Save(fileName);
            }
        }

        private void OnFilterTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            int isFilter = FilterType.SelectedIndex;

            if (isFilter == 0)
            {
                histogramEcv();
            }
            else if (isFilter == 1)
            {
                HighPassFilter();
            }else if (isFilter == 2)
            {
                LinearContrast();
            }
        }



        private void UpdateScreen()
        {
            Original.Image = _original2.ToBitmap();
            Processed.Image = _processed.ToBitmap();
        }

        private void UseGlobalThresholding(int value)
        {
            CvInvoke.Threshold(_original, _processed, value, MaxValue, ThresholdType.Binary);
            UpdateScreen();
        }

        // element operations
        private void AddConstant(double constant)
        {
            img = _original.ToImage<Gray, byte>();
            result = img.Add(new Gray(constant));
            _processed = result.Mat;
            UpdateScreen();
        }

        private void Invert()
        {
            img = _original.ToImage<Gray, byte>();
            CvInvoke.BitwiseNot(_original, _processed);
            UpdateScreen();
        }

        private void MultiplyByConstant(double constant)
        {
            img = _original.ToImage<Gray, byte>();
            img._Mul(constant);
            result = img;
            _processed = result.Mat;
            UpdateScreen();
        }

        private void PowImage(double power)
        {
            if (power >= 1) CvInvoke.Pow(_original, power, _processed);
            else
            {
                img = _original.ToImage<Gray, byte>();
                result = new Image<Gray, byte>(img.Size);
                for (int row = 0; row < img.Rows; row++)
                {
                    for (int col = 0; col < img.Cols; col++)
                    {
                        result[row, col] = new Gray(Math.Pow(img[row, col].Intensity, power));
                    }
                }

                _processed = result.Mat;
            }
            UpdateScreen();
        }

        private void LogarithmTransform()
        {
            img = _original.ToImage<Gray, byte>();
            result = new Image<Gray, byte>(img.Size);

            for (int row = 0; row < img.Rows; row++)
            {
                for (int col = 0; col < img.Cols; col++)
                {
                    result[row, col] = new Gray(Math.Log(1 + img[row, col].Intensity));
                }
            }

            _processed = result.Mat;
            UpdateScreen();
        }

        private void LinearContrast()
        {
            double alpha = 1.5; 
            int beta = 50;
            _original2.ConvertTo(_processed, (DepthType)(-1), alpha, beta);
            UpdateScreen();
        }

    }
}