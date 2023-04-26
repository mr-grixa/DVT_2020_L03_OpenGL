using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SharpGL;
using SharpGL.Enumerations;

namespace DVT_2020_L03_OpenGL
{
    public partial class Form1 : Form
    {
        Point3D[] points;
        int[,,] voxels;
        int[,] histogramXY;
        public Form1()
        {
            InitializeComponent();
            radioButtonCube.Checked = true;
        }
        OpenGL gl;
        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args) 
        {
            // Создаем экземпляр
            gl = this.openGLControl1.OpenGL;

            // Очистка экрана и буфера глубин
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            // Сбрасываем модельно-видовую матрицу
            gl.MatrixMode(MatrixMode.Projection);
            gl.LoadIdentity();


            gl.Perspective((double)numericUpDown_Fov.Value, (double)openGLControl1.Width / (double)openGLControl1.Height, 0.01, 100);

            // Двигаем перо вглубь экрана
            double camX = (double)numericUpDownX.Value;
            double camY = (double)numericUpDownY.Value;
            double camZ = (double)numericUpDownZ.Value;
            gl.Translate(camX, camY, -camZ);
            // Вращаем точки 
            double angleX = (double)numericUpDownRX.Value /** Math.PI / 180.0f*/;
            double angleY = (double)numericUpDownRY.Value /** Math.PI / 180.0f*/;
            double angleZ = (double)numericUpDownRZ.Value /** Math.PI / 180.0f*/;
            gl.Rotate(angleX, 1.0f, 0.0f, 0.0f);
            gl.Rotate(angleY, 0.0f, 1.0f, 0.0f);
            gl.Rotate(angleZ, 0.0f, 0.0f, 1.0f);


            // включаем режим смешивания
            gl.Enable(OpenGL.GL_BLEND);

            if (checkBox_plane.Checked && histogramXY != null)
            {
                Draw.Histogram(gl, histogramXY);
            }
            if (checkBox_voxel.Checked && voxels != null)
            {          
                Draw.Voxel(gl, voxels);
            }
            if (checkBox_dot.Checked)
            {
                gl.Begin(OpenGL.GL_POINTS);
                if (points != null)
                {
                    foreach (Point3D point in points)
                    {
                        gl.Color(1 - point.x, 1 - point.y, 1 - point.z);
                        gl.Vertex(point.x, point.y, point.z);
                    }
                }
            }

            
            // Завершаем работу
            gl.End();
            
        }

        
        public void Voxel()
        {
            voxels = new int[10,10,10];
            foreach (Point3D point in points)
            {
                int x = (int)((point.x + 1) * 5);
                int y = (int)((point.y + 1) * 5);
                int z = (int)((point.z + 1) * 5);
                if (x<10&&x>=0&&
                    y < 10 && y >= 0 &&
                    z < 10 && z >= 0)
                {
                    voxels[x, y, z]++;
                }          
            }
        }

        public void Histogram()
        {
            histogramXY = new int[10, 10];
            foreach (Point3D point in points)
            {
                int x = (int)((point.x + 1) * 5);
                int y = (int)((point.y + 1) * 5);
                if (x < 10 && x >= 0 &&
                    y < 10 && y >= 0)
                {
                    histogramXY[x, y]++;
                }
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Point3D> pointsL = new List<Point3D>();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(';');
                        double x = double.Parse(values[0]);
                        double y = double.Parse(values[1]);
                        double z = double.Parse(values[2]);
                        pointsL.Add(new Point3D(x, y, z));
                    }
                }
                points = pointsL.ToArray();
                Voxel();
                Histogram();
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "data";
            saveFileDialog.Filter = "Табличные данные (*.CSV)|*.CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (points != null)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Point3D point in points)
                        {
                            writer.WriteLine($"{point.x};{point.y};{point.z}");
                        }
                    }
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (radioButtonCube.Checked)
            {
                points = Generate.RandomPoints((int)UpDownCout.Value);
            }
            else if (radioButtonSpin.Checked)
            {
                points = Generate.SpinPoints((int)UpDownCout.Value);
            }
            else if (radioButton_Dot.Checked)
            {
                points = Generate.DotPoints((int)UpDownCout.Value);
            }
            points = Generate.RandomaisePoints(points, (double)trackBar1.Value / 100);
            Voxel();
            Histogram();
        }
        private Point startPoint;
        private decimal RX;
        private decimal RY;
        private void openGLControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                RX = numericUpDownRX.Value;
                RY = numericUpDownRY.Value;
            }
        }

        private void openGLControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                numericUpDownRY.Value += ((decimal)(startPoint.X - e.X) * (decimal)0.1);
                numericUpDownRX.Value += ((decimal)(startPoint.Y - e.Y) * (decimal)0.1);
                startPoint = e.Location;
            }
        }

        private void openGLControl1_MouseUp(object sender, MouseEventArgs e)
        {
            startPoint = Point.Empty;
            RX = 0;
            RY = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_track.Text = ((double)trackBar1.Value / 100).ToString();
        }

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {          
            if (gl != null)
            {
                // создаем новый объект Bitmap с размерами окна
                Bitmap bmp = new Bitmap(openGLControl1.Width, openGLControl1.Height);
                gl.ReadPixels(0, 0, bmp.Width, bmp.Height, OpenGL.GL_BGRA, OpenGL.GL_UNSIGNED_BYTE, bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb).Scan0);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG файлы (*.png)|*.png";
                saveFileDialog.FileName = "img";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

    }
}
