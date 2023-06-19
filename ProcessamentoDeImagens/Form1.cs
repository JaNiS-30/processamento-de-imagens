using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProcessamentoDeImagens
{
    public partial class Form1 : Form
    {
        private Bitmap img1;
        private byte[,] vImg1Gray;
        private byte[,] vImg1R;
        private byte[,] vImg1G;
        private byte[,] vImg1B;
        private byte[,] vImg1A;

        private Bitmap img2;
        private byte[,] vImg2Gray;
        private byte[,] vImg2R;
        private byte[,] vImg2G;
        private byte[,] vImg2B;
        private byte[,] vImg2A;

        private Bitmap img3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btLoadA_Click(object sender, EventArgs e)
        {
            var filePatch = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|JPEG image (*.jpeg)|*.jpeg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePatch = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img1 = new Bitmap(filePatch);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...");
                    bLoadImgOK = false;
                }

                if (bLoadImgOK)
                {
                    pictureBox1.Image = img1;
                    vImg1Gray = new byte[img1.Width, img1.Height];
                    vImg1R = new byte[img1.Width, img1.Height];
                    vImg1G = new byte[img1.Width, img1.Height];
                    vImg1B = new byte[img1.Width, img1.Height];
                    vImg1A = new byte[img1.Width, img1.Height];

                    for (int i = 0; i < img1.Width; i++)
                    {
                        for (int j = 0; j < img1.Height; j++)
                        {
                            Color pixel = img1.GetPixel(i, j);

                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg1Gray[i, j] = pixelIntensity;

                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg1R[i, j] = R;
                            vImg1G[i, j] = G;
                            vImg1B[i, j] = B;
                            vImg1A[i, j] = A;
                        }
                    }

                }
            }
        }

        private void btLoadB_Click(object sender, EventArgs e)
        {
            var filePatch = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|JPEG image (*.jpeg)|*.jpeg|PNG image (*.png)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePatch = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img2 = new Bitmap(filePatch);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...");
                    bLoadImgOK = false;
                }

                if (bLoadImgOK)
                {
                    pictureBox2.Image = img2;
                    vImg2Gray = new byte[img2.Width, img2.Height];
                    vImg2R = new byte[img2.Width, img2.Height];
                    vImg2G = new byte[img2.Width, img2.Height];
                    vImg2B = new byte[img2.Width, img2.Height];
                    vImg2A = new byte[img2.Width, img2.Height];

                    for (int i = 0; i < img2.Width; i++)
                    {
                        for (int j = 0; j < img2.Height; j++)
                        {
                            Color pixel = img2.GetPixel(i, j);

                            byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);
                            vImg2Gray[i, j] = pixelIntensity;

                            byte R = pixel.R;
                            byte G = pixel.G;
                            byte B = pixel.B;
                            byte A = pixel.A;

                            vImg2R[i, j] = R;
                            vImg2G[i, j] = G;
                            vImg2B[i, j] = B;
                            vImg2A[i, j] = A;
                        }
                    }

                }
            }
        }

        private void btAdc_Click(object sender, EventArgs e)
        {
            if(img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte [,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    if (vImg1Gray[i, j] + vImg2Gray[i, j] > 255) pixel = 255;
                    else pixel = Convert.ToByte(vImg1Gray[i, j] + vImg2Gray[i, j]);

                    imagem3[i, j] = pixel;
                }
            }
         

            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;

        }

        private void btSub_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    if (vImg1Gray[i, j] - vImg2Gray[i, j] < 255) pixel = 0;
                    else pixel = Convert.ToByte(vImg1Gray[i, j] - vImg2Gray[i, j]);

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    if (vImg1Gray[i, j] * vImg2Gray[i, j] > 255) pixel = 255;
                    else pixel = Convert.ToByte(vImg1Gray[i, j] * vImg2Gray[i, j]);

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    if (vImg2Gray[i, j] == 0) pixel = 0;
                    else if (vImg1Gray[i, j] / vImg2Gray[i, j] < 255) pixel = 0;
                    else pixel = Convert.ToByte(vImg1Gray[i, j] / vImg2Gray[i, j]);

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btMed_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    pixel = Convert.ToByte((vImg1Gray[i, j] + vImg2Gray[i, j]) / 2);

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btBlending_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            float C = Convert.ToSingle(txBlending.Text);

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    int Ipixel = (int)(C * vImg1Gray[i, j] + (1 - C) * vImg2Gray[i, j]);
                    byte pixel;

                    if (Ipixel > 255) pixel = 255;
                    else if (Ipixel < 0) pixel = 0;
                    else pixel = (byte)Ipixel;
                    
                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btAND_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    bool pixelImg1;
                    bool pixelImg2;

                    if (vImg1Gray[i, j] >= 128) pixelImg1 = true;
                    else pixelImg1 = false;

                    if (vImg2Gray[i, j] >= 128) pixelImg2 = true;
                    else pixelImg2 = false;

                    if (pixelImg1 && pixelImg2) pixel = 255;
                    else pixel = 0;
           
                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btOR_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    bool pixelImg1;
                    bool pixelImg2;

                    if (vImg1Gray[i, j] >= 128) pixelImg1 = true;
                    else pixelImg1 = false;

                    if (vImg2Gray[i, j] >= 128) pixelImg2 = true;
                    else pixelImg2 = false;

                    if (pixelImg1 || pixelImg2) pixel = 255;
                    else pixel = 0;

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btXOR_Click(object sender, EventArgs e)
        {
            if (img1.Width != img2.Width || img1.Height != img2.Height || img1.PixelFormat != img1.PixelFormat)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho e formato");
                return;
            }

            byte[,] imagem3;

            imagem3 = new byte[img2.Width, img2.Height];

            for (int i = 0; i < img2.Width; i++)
            {
                for (int j = 0; j < img2.Height; j++)
                {
                    byte pixel;

                    bool pixelImg1;
                    bool pixelImg2;

                    if (vImg1Gray[i, j] >= 128) pixelImg1 = true;
                    else pixelImg1 = false;

                    if (vImg2Gray[i, j] >= 128) pixelImg2 = true;
                    else pixelImg2 = false;

                    if (pixelImg1 ^ pixelImg2) pixel = 255;
                    else pixel = 0;

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img2.Width, img2.Height);

            for (int x = 0; x < img2.Width; x++)
            {
                for (int y = 0; y < img2.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btNOT_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;

            imagem3 = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    byte pixel;

                    bool pixelImg1;

                    if (vImg1Gray[i, j] >= 128) pixelImg1 = true;
                    else pixelImg1 = false;

                    if (!pixelImg1) pixel = 255;
                    else pixel = 0;

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btSalvarImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img3.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }


        private void RGBtoOneBit_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;

            imagem3 = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    byte pixel;

                    bool pixelImg1;

                    if (vImg1Gray[i, j] >= 128) pixelImg1 = true;
                    else pixelImg1 = false;

                    if (pixelImg1) pixel = 255;
                    else pixel = 0;

                    imagem3[i, j] = pixel;
                }
            }


            img3 = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void RGBtoEigthBit_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(vImg1Gray[x, y], vImg1Gray[x, y], vImg1Gray[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btEqualHist_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);
            byte[,] img = vImg1Gray;
            int width = img1.Width;
            int height = img1.Height;
            int[] histogramFinalImg = new int[256];

            // Calcula o histograma da imagem
            int[] histogram = new int[256];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    histogram[img[x, y]]++;
                }
            }

            // Calcula a função de distribuição acumulada (CDF) do histograma, normalizada para ter valores entre 0 e 1
            double[] cdf = new double[256];
            int pixelsCount = width * height;
            cdf[0] = histogram[0] / (double)pixelsCount;
            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + histogram[i] / (double)pixelsCount;
            }

            // Mapeia cada valor de pixel para um novo valor com base na CDF, escalonando para o intervalo [0, 255]
            int[,] equalizedImg = new int[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int oldPixelValue = img[x, y];
                    int newPixelValue = (int)Math.Round(cdf[oldPixelValue] * 255.0);
                    equalizedImg[x, y] = newPixelValue;
                }
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    histogramFinalImg[equalizedImg[x, y]]++;
                }
            }


            chart1.Series.Clear();
            chart1.Series.Add("Histograma");
            chart1.Series["Histograma"].ChartType = SeriesChartType.Column;
            chart1.Series["Histograma"].Points.DataBindY(histogram);
            chart1.ChartAreas[0].AxisY.Maximum = histogram.Max() + 10;

            chart2.Series.Clear();
            chart2.Series.Add("ImgResult");
            chart2.Series["ImgResult"].ChartType = SeriesChartType.Column;
            chart2.Series["ImgResult"].Points.DataBindY(histogramFinalImg);
            chart2.ChartAreas[0].AxisY.Maximum = histogramFinalImg.Max() + 10;


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(equalizedImg[x, y], equalizedImg[x, y], equalizedImg[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void ToNeg_Click(object sender, EventArgs e)
        {
            img3 = new Bitmap(img1.Width, img1.Height);

            byte[,] img3R = vImg1R;
            byte[,] img3G = vImg1G;
            byte[,] img3B = vImg1B;

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    img3R[i, j] = (byte)(255 - vImg1R[i, j]);
                    img3G[i, j] = (byte)(255 - vImg1G[i, j]);
                    img3B[i, j] = (byte)(255 - vImg1B[i, j]);
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(img3R[x, y], img3G[x, y], img3B[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }

            pictureBox3.Image = img3;
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        byte max = mask.Max();

                        imagem3[i, j] = Convert.ToByte(max);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        byte max = mask.Max();

                        imagem3[i, j] = Convert.ToByte(max);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];

                        mask = mask7x7(mask, vImg1Gray, i, j);

                        byte max = mask.Max();

                        imagem3[i, j] = Convert.ToByte(max);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        byte min = mask.Min();

                        imagem3[i, j] = Convert.ToByte(min);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        byte min = mask.Min();

                        imagem3[i, j] = Convert.ToByte(min);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];

                        mask = mask7x7(mask, vImg1Gray, i, j);

                        byte min = mask.Min();

                        imagem3[i, j] = Convert.ToByte(min);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];
                        int mean = 0;

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        for (int w = 0; w < mask.Length; w++) mean = mean + mask[w];

                        mean = mean / mask.Length;

                        imagem3[i, j] = Convert.ToByte(mean);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];
                        int mean = 0;

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        for (int w = 0; w < mask.Length; w++) mean = mean + mask[w];

                        mean = mean / mask.Length;

                        imagem3[i, j] = Convert.ToByte(mean);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];
                        int mean = 0;

                        mask = mask7x7(mask, vImg1Gray, i, j);

                        for (int w = 0; w < mask.Length; w++) mean = mean + mask[w];

                        mean = mean / mask.Length;

                        imagem3[i, j] = Convert.ToByte(mean);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btMediana_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];
                        int mediana = 0;

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[4];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];
                        int mediana = 0;

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[12];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];
                        int mediana = 0;

                        mask = mask7x7(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[24];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btOrdem_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];
                        int mediana = 0;

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[(int)numOrdem.Value];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];
                        int mediana = 0;

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[(int)numOrdem.Value];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];
                        int mediana = 0;

                        mask = mask7x7(mask, vImg1Gray, i, j);

                        Array.Sort(mask);

                        mediana = mask[(int)numOrdem.Value];

                        imagem3[i, j] = Convert.ToByte(mediana);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btSuavizacao_Click(object sender, EventArgs e)
        {
            byte[,] imagem3;
            img3 = new Bitmap(img1.Width, img1.Height);

            imagem3 = new byte[img1.Width, img1.Height];

            if (rb3x3.Checked)
            {
                for (int i = 1; i < (img1.Width - 1); i++)
                {
                    for (int j = 1; j < (img1.Height - 1); j++)
                    {
                        byte[] mask = new byte[9];

                        mask = mask3x3(mask, vImg1Gray, i, j);

                        int selected = mask[4];

                        var lista = mask.ToList();
                        lista.RemoveAt(4);
                        mask = lista.ToArray();

                        Array.Sort(mask);

                        int min = mask.Min();
                        int max = mask.Max();


                        if(selected > max) selected = max;
                        else if(selected < min) selected = min;

                        imagem3[i, j] = Convert.ToByte(selected);
                    }
                }
            }
            if (rb5x5.Checked)
            {
                for (int i = 2; i < (img1.Width - 2); i++)
                {
                    for (int j = 2; j < (img1.Height - 2); j++)
                    {
                        byte[] mask = new byte[25];

                        mask = mask5x5(mask, vImg1Gray, i, j);

                        int selected = mask[12];

                        var lista = mask.ToList();
                        lista.RemoveAt(12);
                        mask = lista.ToArray();

                        Array.Sort(mask);

                        int min = mask.Min();
                        int max = mask.Max();


                        if (selected > max) selected = max;
                        else if (selected < min) selected = min;

                        imagem3[i, j] = Convert.ToByte(selected);
                    }
                }
            }

            if (rb7x7.Checked)
            {
                for (int i = 3; i < (img1.Width - 3); i++)
                {
                    for (int j = 3; j < (img1.Height - 3); j++)
                    {
                        byte[] mask = new byte[49];

                        mask = mask7x7(mask, vImg1Gray, i, j);
                        
                        int selected = mask[24];

                        var lista = mask.ToList();
                        lista.RemoveAt(24);
                        mask = lista.ToArray();

                        Array.Sort(mask);

                        int min = mask.Min();
                        int max = mask.Max();


                        if (selected > max) selected = max;
                        else if (selected < min) selected = min;

                        imagem3[i, j] = Convert.ToByte(selected);
                    }
                }
            }


            for (int x = 0; x < img1.Width; x++)
            {
                for (int y = 0; y < img1.Height; y++)
                {
                    Color c = Color.FromArgb(imagem3[x, y], imagem3[x, y], imagem3[x, y]);
                    img3.SetPixel(x, y, c);
                }
            }
            pictureBox3.Image = img3;
        }

        private void btGaussiano_Click(object sender, EventArgs e)
        {
            double desvioPadrao = Convert.ToDouble(txGaussiano.Text);
            int tamanho = 5;
            int raio = tamanho / 2;
            double[,] kernel = new double[tamanho, tamanho];
            double soma = 0;

            // Gerar kernel gaussiano
            for (int x = -raio; x <= raio; x++)
            {
                for (int y = -raio; y <= raio; y++)
                {
                    double valor = Math.Exp(-(x * x + y * y) / (2 * desvioPadrao * desvioPadrao));
                    kernel[x + raio, y + raio] = valor;
                    soma += valor;
                }
            }

            // Normalizar kernel
            for (int x = 0; x < tamanho; x++)
            {
                for (int y = 0; y < tamanho; y++)
                {
                    kernel[x, y] /= soma;
                }
            }

            int width = img1.Width;
            int height = img1.Height;

            Bitmap img3 = new Bitmap(width, height);

            for (int x = raio; x < width - raio; x++)
            {
                for (int y = raio; y < height - raio; y++)
                {
                    double r = 0, g = 0, b = 0;

                    for (int i = -raio; i <= raio; i++)
                    {
                        for (int j = -raio; j <= raio; j++)
                        {
                            Color pixel = img1.GetPixel(x + i, y + j);
                            double peso = kernel[i + raio, j + raio];
                            r += pixel.R * peso;
                            g += pixel.G * peso;
                            b += pixel.B * peso;
                        }
                    }

                    int red = (int)Math.Round(r);
                    int green = (int)Math.Round(g);
                    int blue = (int)Math.Round(b);

                    red = Math.Max(0, Math.Min(255, red));
                    green = Math.Max(0, Math.Min(255, green));
                    blue = Math.Max(0, Math.Min(255, blue));

                    Color newPixel = Color.FromArgb(red, green, blue);
                    img3.SetPixel(x, y, newPixel);
                }
            }

            pictureBox3.Image = img3;
        }

        private byte[] mask7x7(byte[] mask, byte[,]vImgGray, int i, int j)
        {
            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

            mask[0] = (byte)(mask[0] * vImg1Gray[i - 3, j - 3]);
            mask[1] = (byte)(mask[1] * vImg1Gray[i - 3, j - 2]);
            mask[2] = (byte)(mask[2] * vImg1Gray[i - 3, j - 1]);
            mask[3] = (byte)(mask[3] * vImg1Gray[i - 3, j]);
            mask[4] = (byte)(mask[4] * vImg1Gray[i - 3, j + 1]);
            mask[5] = (byte)(mask[5] * vImg1Gray[i - 3, j + 2]);
            mask[6] = (byte)(mask[6] * vImg1Gray[i - 3, j + 3]);

            mask[7] = (byte)(mask[7] * vImg1Gray[i - 2, j - 3]);
            mask[8] = (byte)(mask[8] * vImg1Gray[i - 2, j - 2]);
            mask[9] = (byte)(mask[9] * vImg1Gray[i - 2, j - 1]);
            mask[10] = (byte)(mask[10] * vImg1Gray[i - 2, j]);
            mask[11] = (byte)(mask[11] * vImg1Gray[i - 2, j + 1]);
            mask[12] = (byte)(mask[12] * vImg1Gray[i - 2, j + 2]);
            mask[13] = (byte)(mask[13] * vImg1Gray[i - 2, j + 3]);

            mask[14] = (byte)(mask[14] * vImg1Gray[i - 1, j - 3]);
            mask[15] = (byte)(mask[15] * vImg1Gray[i - 1, j - 2]);
            mask[16] = (byte)(mask[16] * vImg1Gray[i - 1, j - 1]);
            mask[17] = (byte)(mask[17] * vImg1Gray[i - 1, j]);
            mask[18] = (byte)(mask[18] * vImg1Gray[i - 1, j + 1]);
            mask[19] = (byte)(mask[19] * vImg1Gray[i - 1, j + 2]);
            mask[20] = (byte)(mask[20] * vImg1Gray[i - 1, j + 3]);

            mask[21] = (byte)(mask[21] * vImg1Gray[i, j - 3]);
            mask[22] = (byte)(mask[22] * vImg1Gray[i, j - 2]);
            mask[23] = (byte)(mask[23] * vImg1Gray[i, j - 1]);
            mask[24] = (byte)(mask[24] * vImg1Gray[i, j]);
            mask[25] = (byte)(mask[25] * vImg1Gray[i, j + 1]);
            mask[26] = (byte)(mask[26] * vImg1Gray[i, j + 2]);
            mask[27] = (byte)(mask[27] * vImg1Gray[i, j + 3]);

            mask[28] = (byte)(mask[28] * vImg1Gray[i + 1, j - 3]);
            mask[29] = (byte)(mask[29] * vImg1Gray[i + 1, j - 2]);
            mask[30] = (byte)(mask[30] * vImg1Gray[i + 1, j - 1]);
            mask[31] = (byte)(mask[31] * vImg1Gray[i + 1, j]);
            mask[32] = (byte)(mask[32] * vImg1Gray[i + 1, j + 1]);
            mask[33] = (byte)(mask[33] * vImg1Gray[i + 1, j + 2]);
            mask[34] = (byte)(mask[34] * vImg1Gray[i + 1, j + 3]);

            mask[35] = (byte)(mask[35] * vImg1Gray[i + 2, j - 3]);
            mask[36] = (byte)(mask[36] * vImg1Gray[i + 2, j - 2]);
            mask[37] = (byte)(mask[37] * vImg1Gray[i + 2, j - 1]);
            mask[38] = (byte)(mask[38] * vImg1Gray[i + 2, j]);
            mask[39] = (byte)(mask[39] * vImg1Gray[i + 2, j + 1]);
            mask[40] = (byte)(mask[40] * vImg1Gray[i + 2, j + 2]);
            mask[41] = (byte)(mask[41] * vImg1Gray[i + 2, j + 3]);

            mask[42] = (byte)(mask[42] * vImg1Gray[i + 3, j - 3]);
            mask[43] = (byte)(mask[43] * vImg1Gray[i + 3, j - 2]);
            mask[44] = (byte)(mask[44] * vImg1Gray[i + 3, j - 1]);
            mask[45] = (byte)(mask[45] * vImg1Gray[i + 3, j]);
            mask[46] = (byte)(mask[46] * vImg1Gray[i + 3, j + 1]);
            mask[47] = (byte)(mask[47] * vImg1Gray[i + 3, j + 2]);
            mask[48] = (byte)(mask[48] * vImg1Gray[i + 3, j + 3]);

            return mask;
        }

        private byte[] mask5x5(byte[] mask, byte[,] vImgGray, int i, int j)
        {
            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

            mask[0] = (byte)(mask[0] * vImg1Gray[i - 2, j - 2]);
            mask[1] = (byte)(mask[1] * vImg1Gray[i - 2, j - 1]);
            mask[2] = (byte)(mask[2] * vImg1Gray[i - 2, j]);
            mask[3] = (byte)(mask[3] * vImg1Gray[i - 2, j + 1]);
            mask[4] = (byte)(mask[4] * vImg1Gray[i - 2, j + 2]);

            mask[5] = (byte)(mask[5] * vImg1Gray[i - 1, j - 2]);
            mask[6] = (byte)(mask[6] * vImg1Gray[i - 1, j - 1]);
            mask[7] = (byte)(mask[7] * vImg1Gray[i - 1, j]);
            mask[8] = (byte)(mask[8] * vImg1Gray[i - 1, j + 1]);
            mask[9] = (byte)(mask[9] * vImg1Gray[i - 1, j + 2]);

            mask[10] = (byte)(mask[10] * vImg1Gray[i, j - 2]);
            mask[11] = (byte)(mask[11] * vImg1Gray[i, j - 1]);
            mask[12] = (byte)(mask[12] * vImg1Gray[i, j]);
            mask[13] = (byte)(mask[13] * vImg1Gray[i, j + 1]);
            mask[14] = (byte)(mask[14] * vImg1Gray[i, j + 2]);

            mask[15] = (byte)(mask[15] * vImg1Gray[i + 1, j - 2]);
            mask[16] = (byte)(mask[16] * vImg1Gray[i + 1, j - 1]);
            mask[17] = (byte)(mask[17] * vImg1Gray[i + 1, j]);
            mask[18] = (byte)(mask[18] * vImg1Gray[i + 1, j + 1]);
            mask[19] = (byte)(mask[19] * vImg1Gray[i + 1, j + 2]);

            mask[20] = (byte)(mask[20] * vImg1Gray[i + 2, j - 2]);
            mask[21] = (byte)(mask[21] * vImg1Gray[i + 2, j - 1]);
            mask[22] = (byte)(mask[22] * vImg1Gray[i + 2, j]);
            mask[23] = (byte)(mask[23] * vImg1Gray[i + 2, j + 1]);
            mask[24] = (byte)(mask[24] * vImg1Gray[i + 2, j + 2]);

            return mask;
        }

        private byte[] mask3x3(byte[] mask, byte[,] vImgGray, int i, int j)
        {
            for (int w = 0; w < mask.Length; w++) mask[w] = 1;

            mask[0] = (byte)(mask[0] * vImg1Gray[i - 1, j - 1]);
            mask[1] = (byte)(mask[1] * vImg1Gray[i - 1, j]);
            mask[2] = (byte)(mask[2] * vImg1Gray[i - 1, j + 1]);

            mask[3] = (byte)(mask[3] * vImg1Gray[i, j - 1]);
            mask[4] = (byte)(mask[4] * vImg1Gray[i, j]);
            mask[5] = (byte)(mask[5] * vImg1Gray[i, j + 1]);

            mask[6] = (byte)(mask[6] * vImg1Gray[i + 1, j - 1]);
            mask[7] = (byte)(mask[7] * vImg1Gray[i + 1, j]);
            mask[8] = (byte)(mask[8] * vImg1Gray[i + 1, j + 1]);

            return mask;
        }

        
    }

}