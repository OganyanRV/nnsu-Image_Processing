using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Оганян_tomogram_visualizer
{
    public partial class Form1 : Form
    {
        private Bin bin;
        private View view;
        private int currentLayer;
        private bool loaded;
        private bool needReload = true;
        private DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        private int FrameCount;
        private int currentmin = 0;
        private int currentwidthTF = 2000;
        private int mode;
        public Form1()
        {
            InitializeComponent();
            bin = new Bin();
            view = new View();
            currentLayer = 0;
            loaded = false;
            mode = 1;

        }

        void displayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer" +
                                          " (fps={0})", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }
       


        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files|*.bin|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                int last = str.Length;
                if (str[last - 1] != 'n' || str[last - 2] != 'i' || str[last - 3] != 'b')
                {
                    MessageBox.Show("Wrong format of the tomogram \n Please enter the '.bin' file", "Error");
                    return;
                }
                bin.readBIN(str);
                trackBar1.Maximum = bin.GetZ() - 1;
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded= true;
                glControl1.Invalidate();
            }

            return;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (needReload)
                {
                    if (mode == 1)
                    {
                        view.DrawQuads(currentLayer, currentmin, currentwidthTF);
                        needReload = false;
                        glControl1.SwapBuffers();
                    }
                    else if (mode == 2)
                    {
                        view.generateTextureImage(currentLayer, currentmin, currentwidthTF);
                        view.Load2DTexture();
                        view.DrawTexture();
                        glControl1.SwapBuffers();
                        needReload = false;

                    }

                    else if (mode == 3)
                    {
                        view.DrawQuadsStrip(currentLayer, currentmin, currentwidthTF);
                        needReload = false;
                        glControl1.SwapBuffers();
                    }
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            needReload = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            currentmin = trackBar3.Value;
            needReload = true;

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            currentwidthTF = trackBar2.Value;
            needReload = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
            needReload = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3;
            needReload = true;
        }
    }
}
