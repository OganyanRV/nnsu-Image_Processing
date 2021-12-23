using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image= new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
           /* Bitmap resultImage = filter.processImage(image);
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
            */
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters) e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                image = newImage;
            }
        }

        //меняет цвет полосы
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage; 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрГауссаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void оттенокСерогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void увеличениеЯркостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрСоболяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void фильтрРезкостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Filters filter = new MedianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void выделениеГраницToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgesFilter();
            kostil(sender,e);
        }

        private void kostil(object sender, EventArgs e)
        {

            Filters filter2 = new EdgesFilter2();
            backgroundWorker1.RunWorkerAsync(filter2);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WavesFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void стеклоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void волны2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WavesFilter2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        
        private void линейноеРастяжениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new LinearFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayWorldFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }
        

     

        private void поворотНа45ГрадусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new RotationFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private bool[,] ConvertToBool(Bitmap sourceImage)
        {
            bool[,] mask = new bool[sourceImage.Width, sourceImage.Height];
            for (int i = 0; i < sourceImage.Width; i++)
            for (int j = 0; j < sourceImage.Height; j++)
            {
                Color color = sourceImage.GetPixel(i, j);
                if (color.ToArgb() == Color.Black.ToArgb())
                    mask[i, j] = false;
                else
                    mask[i, j] = true;
            }
            return mask;
        } 
        private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dialog.FileName);
                if (sourceImage.Width != sourceImage.Height)
                {
                    MessageBox.Show("Wrong format of the matrix \n Please enter the square matrix", "Error");
                    return;
                }
            }
            else
            {
                return;
            }
            DilationFilter filter = new DilationFilter(ConvertToBool(sourceImage));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void открытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dialog.FileName);
                if (sourceImage.Width != sourceImage.Height)
                {
                    MessageBox.Show("Wrong format of the matrix \n Please enter the square matrix", "Error");
                    return;
                }
            }
            else
            {
                return;
            }
            OpeningFilter filter = new OpeningFilter(ConvertToBool(sourceImage));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void закртыиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dialog.FileName);
                if (sourceImage.Width != sourceImage.Height)
                {
                    MessageBox.Show("Wrong format of the matrix \n Please enter the square matrix", "Error");
                    return;
                }
            }
            else
            {
                return;
            }
            ClosingFilter filter = new ClosingFilter(ConvertToBool(sourceImage));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dialog.FileName);
                if (sourceImage.Width != sourceImage.Height)
                {
                    MessageBox.Show("Wrong format of the matrix \n Please enter the square matrix", "Error");
                    return;
                }
            }
            else
            {
                return;
            }

            TopHatFilter filter = new TopHatFilter(ConvertToBool(sourceImage));
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void сужениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap sourceImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.jpg;*.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceImage = new Bitmap(dialog.FileName);
                if (sourceImage.Width != sourceImage.Height)
                {
                    MessageBox.Show("Wrong format of the matrix \n Please enter the square matrix", "Error");
                    return;
                }
            }
            else
            {
                return;
            }
            ErosionFilter filter = new ErosionFilter(ConvertToBool(sourceImage));
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = " JPEG|*.jpeg| PNG| *.png| BMP *.bmp|";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FileName != "")
                {

                    System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                    switch (dialog.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 3:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }

                    fs.Close();
                }
            }
        }
    }
}
