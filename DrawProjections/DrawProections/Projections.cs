using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawProections
{
    static class Projections
    {


        public static void RectangularIsometry(Graphics g, double[,] dots, int[,] lines)
        {
            int[] center = { (int)g.VisibleClipBounds.Width / 2, (int)g.VisibleClipBounds.Height / 2 };

            double[] rotCoefs = { Math.Asin(Math.Tan(30f/180f)), -45f / 180f };
            double[] zoomCoefs = { 0.82f, 0.82f, 0.82f };

            double[,] axis = { { 100, 0, 0 }, { 0, -100, 0}, { 0,0,100} };


            for (int i = 0; i < axis.GetLength(1); i++)
            {
                double[] dot = { axis[i, 0], axis[i, 1], axis[i, 2] };

                
                dot = RotateDotOY(dot, rotCoefs[1]);
                dot = RotateDotOX(dot, rotCoefs[0]);
                dot = ZoomDot(dot, zoomCoefs);

                g.DrawLine(Pens.Gray, 0 + center[0], 0 + center[1], (int)dot[0] + center[0], (int)dot[1] + center[1]);
            }
        }


        static double[] RotateDotOX(double[] dot, double coef)
        {
            double[] result = new double[3];
            result[0] = dot[0];
            result[1] = (Math.Cos(coef) * dot[1] + Math.Sin(coef) * dot[2]);
            result[2] = (Math.Cos(coef) * dot[2] + Math.Sin(coef) * dot[1]);

            return result;
        }

        static double[] RotateDotOY(double[] dot, double coef)
        {
            double[] result = new double[3];
            result[0] = Math.Cos(coef)*dot[0] + Math.Sin(coef)*dot[2];
            result[1] = dot[1];
            result[2] = Math.Cos(coef) * dot[2] + Math.Sin(coef) * dot[0];

            return result;
        }

        static double[] ZoomDot(double[] dot, double[] coefs)
        {
            double[] result = new double[3];
            result[0] = dot[0] * coefs[0];
            result[1] = dot[1] * coefs[1];
            result[2] = dot[2] * coefs[2];

            return result;
        }
    }
}
