using System;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace Lab3_Oganyan
{

    public partial class Form1 : Form
    {
        
        View view = new View();
        private bool needreload = false;
        private int mode = -1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            
            view.InitScreen();
            glControl2.SwapBuffers();
            GL.UseProgram(0);
        }

        private void glControl2_Load(object sender, EventArgs e)
        {
          
            view.Start();
        }

        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            float x1 = (float)trackBar1.Value / 10;
            float x2 = (float)trackBar3.Value / 10;
            float x3 = (float)trackBar2.Value / 10;
            view.SetLightCoefs(x1, x2, x3, 512.0f);
            view.SetReflection((float)trackBar7.Value/10);
            if (needreload = true)
            {
                needreload = false;
                x1 = (float)trackBar4.Value / 10;
                x2 = (float)trackBar5.Value / 10;
                x3 = (float)trackBar6.Value / 10;

                switch (mode)
                {
                    case 0:
                        view.SetUpWallCoefs(x1,x2,x3);
                        break;
                    case 1:
                        view.SetDownWallCoefs(x1,x2,x3);
                        break;
                    case 2:
                        view.SetLeftWallCoefs(x1, x2, x3);
                        break;
                    case 3:
                        view.SetRightWallCoefs(x1, x2, x3);
                        break;
                    case 4:
                        view.SetBackWallCoefs(x1, x2, x3);
                        break;
                    case 5:
                        view.SetBigSphereCoefs(x1, x2, x3);
                        break;
                    case 6:
                        view.SetSmallSphereCoefs(x1, x2, x3);
                        break;


                }
            }
            
            glControl2.Invalidate();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 0;
            trackBar4.Value = (int)(10 * view.UpWallColor.X);
            trackBar5.Value = (int)(10 * view.UpWallColor.Y);
            trackBar6.Value = (int)(10 * view.UpWallColor.Z);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            needreload = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
            trackBar4.Value = (int)(10 * view.DownWallColor.X);
            trackBar5.Value = (int)(10 * view.DownWallColor.Y);
            trackBar6.Value = (int)(10 * view.DownWallColor.Z);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
            trackBar4.Value = (int)(10 * view.LeftWallColor.X);
            trackBar5.Value = (int)(10 * view.LeftWallColor.Y);
            trackBar6.Value = (int)(10 * view.LeftWallColor.Z);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            mode = 3; 
            trackBar4.Value = (int)(10 * view.RightWallColor.X);
            trackBar5.Value = (int)(10 * view.RightWallColor.Y);
            trackBar6.Value = (int)(10 * view.RightWallColor.Z);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            mode = 4;
            trackBar4.Value = (int)(10 * view.BackWallColor.X);
            trackBar5.Value = (int)(10 * view.BackWallColor.Y);
            trackBar6.Value = (int)(10 * view.BackWallColor.Z);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            mode = 5;
            trackBar4.Value = (int)(10 * view.ColorBigSphere.X);
            trackBar5.Value = (int)(10 * view.ColorBigSphere.Y);
            trackBar6.Value = (int)(10 * view.ColorBigSphere.Z);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            mode = 6;
            trackBar4.Value = (int)(10 * view.ColorSmallSphere.X);
            trackBar5.Value = (int)(10 * view.ColorSmallSphere.Y);
            trackBar6.Value = (int)(10 * view.ColorSmallSphere.Z);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            needreload = true;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            needreload = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
