using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiamondLands
{
    public class CanvasPanel : Panel
    {
        public Bitmap bitmap = null;
        bool _lockbitmap = false;
        private RGB[] buffer;
        struct RGB
        {
            public byte a, r, g, b;
        }

        public CanvasPanel()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }

        public Bitmap RefreshMap(DiamondSquare diamond, int min, int max)
        {
            if (bitmap != null)
                bitmap.Dispose();

            int size = diamond.M.GetLength(0);

            Graphics g = Graphics.FromHwnd(Handle);
            bitmap = new Bitmap(size, size, g);

            Width = size;
            Height = size;

            buffer = new RGB[size * size];

            PrintMap(diamond, min, max);
            VisualizeBuffer();

            return bitmap;
        }

        private void PrintMap(DiamondSquare diamond, float min, float max)
        {
            int ydx, idx;
            int w = bitmap.Width;
            int h = bitmap.Height;
            for (int y = 0; y < h; y++)
            {
                ydx = y * w;
                for (int x = 0; x < w; x++)
                {
                    float cf = (diamond.M[y, x] - min) / (max - min);
                    byte c = (byte)(255.0f * cf);
                    idx = ydx + x;
                    buffer[idx].a = 0xFF;

                    // deep blue
                    if (c < 70)
                        buffer[idx].b = 200;

                    // sea
                    if (c < 90 && c >= 70)
                        buffer[idx].b = 255;

                    // beach sands
                    if (c < 100 && c >= 90)
                    {
                        buffer[idx].r = 255;
                        buffer[idx].g = 255;
                    }

                    // grass
                    if (c < 130 && c >= 100)
                        buffer[idx].g = 255;

                    // jungle
                    if (c < 170 && c >= 120)
                        buffer[idx].g = 200;

                    // trees
                    if (c >= 170 && c < 200)
                    {
                        buffer[idx].r = (byte)(c * 0.8);
                        buffer[idx].g = 255;
                        buffer[idx].b = (byte)(c * 0.8);
                    }

                    // rocks
                    if (c <= 255 && c >= 200)
                    {
                        if(c <= 255 && c >= 240)
                        {
                            buffer[idx].r = 200;
                            buffer[idx].g = 200;
                            buffer[idx].b = 200;
                        }
                        else
                        { // snow
                            buffer[idx].r = 255;
                            buffer[idx].g = 255;
                            buffer[idx].b = 255;
                        }
                    }

                } // for x
            } // for y
        } // PrintMap

        private void VisualizeBuffer()
        {
            int w = bitmap.Width;
            int h = bitmap.Height;

            int bitLen = bitmap.PixelFormat == PixelFormat.Format24bppRgb ? 3 : 4;

            _lockbitmap = true;
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.WriteOnly,
                bitmap.PixelFormat);
            byte[] bitmapBuffer = new byte[bitmapData.Stride * bitmapData.Height];
            Marshal.Copy(bitmapData.Scan0, bitmapBuffer, 0, bitmapBuffer.Length);

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    bitmapBuffer[bitmapData.Stride * y + x * bitLen + 0] = buffer[x + y * w].b;
                    bitmapBuffer[bitmapData.Stride * y + x * bitLen + 1] = buffer[x + y * w].g;
                    bitmapBuffer[bitmapData.Stride * y + x * bitLen + 2] = buffer[x + y * w].r;
                    if (bitLen == 4)
                        bitmapBuffer[bitmapData.Stride * y + x * bitLen + 3] = buffer[x + y * w].a;
                } // for x
            } // for y

            Marshal.Copy(bitmapBuffer, 0, bitmapData.Scan0, bitmapData.Stride * bitmapData.Height);
            bitmap.UnlockBits(bitmapData);
            _lockbitmap = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bitmap != null && !_lockbitmap)
                e.Graphics.DrawImageUnscaled(bitmap, 0, 0);
        }
    } // class
}
