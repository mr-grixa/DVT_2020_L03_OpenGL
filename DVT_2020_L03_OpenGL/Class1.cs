using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT_2020_L03_OpenGL
{
    internal class Point3D
    {
        public double x;
        public double y;
        public double z;
        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;          
        }

        public double[] xyz()
        {
            double [] XYZ = new double[3] { x, y, z};
            return XYZ;
        }
    }

    internal static class Draw
    {
        public static void Cube(OpenGL gl,double x, double y, double z, double size)
        {
            double halfSize = size / 2;

            gl.Begin(OpenGL.GL_QUADS);

            //front face
            gl.Vertex(x - halfSize, y - halfSize, z + halfSize);
            gl.Vertex(x + halfSize, y - halfSize, z + halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z + halfSize);
            gl.Vertex(x - halfSize, y + halfSize, z + halfSize);

            //back face
            gl.Vertex(x - halfSize, y - halfSize, z - halfSize);
            gl.Vertex(x - halfSize, y + halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y - halfSize, z - halfSize);

            //top face
            gl.Vertex(x - halfSize, y + halfSize, z - halfSize);
            gl.Vertex(x - halfSize, y + halfSize, z + halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z + halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z - halfSize);

            //bottom face
            gl.Vertex(x - halfSize, y - halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y - halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y - halfSize, z + halfSize);
            gl.Vertex(x - halfSize, y - halfSize, z + halfSize);

            //left face
            gl.Vertex(x - halfSize, y - halfSize, z - halfSize);
            gl.Vertex(x - halfSize, y + halfSize, z - halfSize);
            gl.Vertex(x - halfSize, y + halfSize, z + halfSize);
            gl.Vertex(x - halfSize, y - halfSize, z + halfSize);

            //right face
            gl.Vertex(x + halfSize, y - halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z - halfSize);
            gl.Vertex(x + halfSize, y + halfSize, z + halfSize);
            gl.Vertex(x + halfSize, y - halfSize, z + halfSize);

            gl.End();
        }

        public static void Voxel(OpenGL gl, int[,,] voxels)
        {
            IEnumerable<int> colNumbs = voxels.Cast<int>();
            double max = colNumbs.Max();
            for (int x = 0; x<10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        gl.Color((double)x / 10, (double)y / 10, (double)z / 10);

                        Cube(gl, ((double)x - 4.5) / 5,
                            ((double)y - 4.5) / 5,
                            ((double)z - 4.5) / 5,
                            (((double)voxels[x,y,z]/ max) * 0.2f));
                    }
                }
            }
        }

        public static void Histogram(OpenGL gl, int[,] histogramXY)
        {
            IEnumerable<int> colNumbs = histogramXY.Cast<int>();
            double max = colNumbs.Max();
            gl.Begin(OpenGL.GL_QUADS);
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    gl.Color((double)histogramXY[x, y] / max, 1 - (double)histogramXY[x, y] / max, 0.5);
                    gl.Vertex(((double)x - 4.5) / 5,
                        ((double)y - 4.5) / 5,
                        ((double)histogramXY[x, y] / max) + 0.5);
                    gl.Color((double)histogramXY[x+1, y] / max, 1 - (double)histogramXY[x+1, y ] / max, 0.5);
                    gl.Vertex(((double)x - 3.5) / 5,
                        ((double)y - 4.5) / 5,
                        ((double)histogramXY[x+1, y] / max) + 0.5);
                    gl.Color((double)histogramXY[x+1, y + 1] / max, 1 - (double)histogramXY[x+1, y + 1] / max, 0.5);
                    gl.Vertex(((double)x - 3.5) / 5,
                        ((double)y - 3.5) / 5,
                        ((double)histogramXY[x + 1, y + 1] / max) + 0.5);
                    gl.Color((double)histogramXY[x, y + 1] / max, 1- (double)histogramXY[x, y + 1] / max, 0.5);
                    gl.Vertex(((double)x - 4.5) / 5,
                        ((double)y - 3.5) / 5,
                        ((double)histogramXY[x, y + 1] / max)+0.5);
                }
            }
            gl.End();
        }

    }

    internal static class Generate
    {
        public static Point3D[] DotPoints(int numPoints)
        {
            Point3D[] points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                points[i] = new Point3D(0,0,0);
            }
            return points;
        }
        public static Point3D[] RandomPoints(int numPoints)
        {
            Random random = new Random();
            Point3D[] points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                double x = random.NextDouble() * 2 - 1;
                double y = random.NextDouble() * 2 - 1;
                double z = random.NextDouble() * 2 - 1;
                points[i] = new Point3D(x, y, z);
            }
            return points;
        }

        public static Point3D[] SpinPoints(int numPoints)
        {
            Random random = new Random();
            Point3D[] points = new Point3D[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                double x = 0.7 * Math.Cos(6 * Math.PI * ((double)i / (double)numPoints));
                double y = 0.6 * Math.Sin(4 * Math.PI * ((double)i / (double)numPoints));
                double z = -1 + 2 * ((double)i / (double)numPoints);
                points[i] = new Point3D(x, y, z);
            }
            return points;
        }

        public static Point3D[] RandomaisePoints(Point3D[] points, double stdDev)
        {           
            Random rand = new Random();
            foreach (Point3D point3D in points)
            {
                point3D.x += RandomNormal(0, stdDev, rand);
                point3D.y += RandomNormal(0, stdDev, rand);
                point3D.z += RandomNormal(0, stdDev, rand);
            }
            return points;
        }
        public static double RandomNormal(double mean, double stdDev, Random rand)
        {
            double u1 = 1.0 - rand.NextDouble(); // случайное число от 0 до 1
            double u2 = 1.0 - rand.NextDouble(); // случайное число от 0 до 1
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                Math.Sin(2.0 * Math.PI * u2); // применяем формулу Бокса-Мюллера
            double randNormal = mean + stdDev * randStdNormal;
            return randNormal;
        }
    }
}
