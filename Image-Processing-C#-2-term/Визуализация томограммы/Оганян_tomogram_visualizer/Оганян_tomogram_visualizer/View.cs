using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using OpenTK.Graphics.OpenGL;

namespace Оганян_tomogram_visualizer
{
    // Содержит функции для визуализации топограммы
    class View
    {
        private Bitmap textureImage;
        private int VBOtexture;
        private static int max;
        private static int min = 0;
        private static int widthTF = 2000;

        public void SetupView(int width, int height)
        {
            GL.ShadeModel(ShadingModel.Smooth);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, Bin.X, 0, Bin.Y, -1, 1);
            GL.Viewport(0, 0, width, height);
        }

        public void generateTextureImage(int layerNumber, int min, int widthTF)
        {
            textureImage = new Bitmap(Bin.X, Bin.Y);
            for (int i = 0; i < Bin.X; ++i)
            {
                for (int j = 0; j < Bin.Y; ++j)
                {
                    int pixelNumber = i + j * Bin.X + layerNumber * Bin.X * Bin.Y;
                    textureImage.SetPixel(i,j,transferFunction(Bin.array[pixelNumber],min,View.widthTF));
                }
            }
        }

        public void DrawTexture()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit|ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            GL.Begin(BeginMode.Quads);
            GL.Color3(Color.White);
            GL.TexCoord2(0f,0f);
            GL.Vertex2(0, 0);
            GL.TexCoord2(0f, 1f);
            GL.Vertex2(0, Bin.Y);
            GL.TexCoord2(1f, 1f);
            GL.Vertex2(Bin.X, Bin.Y);
            GL.TexCoord2(1f, 0f);
            GL.Vertex2(Bin.X, 0);
            GL.End();
            GL.Disable(EnableCap.Texture2D);
        }
        public void Load2DTexture()
        {
            GL.BindTexture(TextureTarget.Texture2D, VBOtexture);
            BitmapData data = textureImage. LockBits(
                new System.Drawing.Rectangle(0, 0, textureImage.Width,
                    textureImage.Height), ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width,
                data.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);
            textureImage.UnlockBits(data);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter,
                (int) TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter,
                (int) TextureMagFilter.Linear);
            ErrorCode Er = GL.GetError();
            string str = Er.ToString();
        }

        Color transferFunction(short value, int tmpmin, int tmpwidth)
        {
            max = tmpmin + tmpwidth;
            min = tmpmin;
            int newVal;
            if (max != min)
            {
                 newVal = Clamp((value - min) * 255 / (max - min), 0, 255);
            }
            else {
                 newVal = Clamp((value - min) * 255 / (1), 0, 255);
            }
            return Color.FromArgb(255, newVal, newVal, newVal);
        }

        public int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }

        public void DrawQuadsStrip(int layerNumber, int min, int width)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin((BeginMode.QuadStrip));
            short value=0;
            for (int y_coord = 0; y_coord < Bin.Y - 2; y_coord += 2)
            {

                for (int x_coord = 0; x_coord < Bin.X; ++x_coord)
                {
                    value = Bin.array[x_coord + (y_coord) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value,min,width));
                    GL.Vertex2(x_coord, y_coord);

                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, y_coord + 1);
                }
                for (int x_coord = Bin.X - 1; x_coord >= 0; --x_coord)
                {
                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, y_coord + 1);

                    value = Bin.array[x_coord + (y_coord + 2) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, y_coord + 2);
                }
            }

            if ((Bin.Y - 1) % 2 == 1)
            {
                for (int x_coord = 0; x_coord < Bin.X; ++x_coord)
                {
                    value = Bin.array[x_coord + (Bin.Y - 2) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, Bin.Y - 2);

                    value = Bin.array[x_coord + (Bin.Y - 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, Bin.Y - 1);
                }
            }
            GL.End();
        }

       
        public void DrawQuads(int layerNumber, int min, int width) 
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Begin((BeginMode.Quads));
            for (int x_coord = 0; x_coord < Bin.X - 1; x_coord++)
            {
                for (int y_coord = 0; y_coord < Bin.Y - 1; y_coord++)
                {
                    short value;
                    value = Bin.array[x_coord + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, y_coord);

                    value = Bin.array[x_coord + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord, y_coord + 1);

                    value = Bin.array[x_coord + 1 + (y_coord + 1) * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord + 1, y_coord + 1);

                    value = Bin.array[x_coord + 1 + y_coord * Bin.X + layerNumber * Bin.X * Bin.Y];
                    GL.Color3(transferFunction(value, min, width));
                    GL.Vertex2(x_coord + 1, y_coord);
                }
            }

            GL.End();
        }
    }
}
