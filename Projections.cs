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

        public static int PerspectiveAngle = 2;


        /// <summary>
        /// Отрисовка координатных осей и проекции
        /// </summary>
        /// <param name="g"></param>
        /// <param name="dots"></param>
        /// <param name="lines"></param>
        /// <param name="RotateFunc"></param>
        public static void DrawLines(Graphics g, double[,] dots, int[,] lines, Func<double[],double[]> RotateFunc)
        {
            //находим центр поля
            int[] center = { (int)(g.VisibleClipBounds.Width / 2), (int)(g.VisibleClipBounds.Height / 2) };

            //задаем положение осей
            double[,] axis = { { 300, 0, 0 }, { 0, 300, 0 }, { 0, 0, 300 } };

            //отрисовываем оси
            for (int i = 0; i < axis.GetLength(1); i++)
            {
                double[] dot = { axis[i, 0], axis[i, 1], axis[i, 2] };
                //поворот осей в нужную проекцию
                dot = RotateFunc(dot);
                //отрисовка
                g.DrawLine(Pens.Blue, center[0], center[1], (int)dot[0] + center[0], (int)dot[1] + center[1]);

                //отрисовка названия оси
                string s = "X";
                if (i == 1) s = "Y";
                else if (i == 2) s = "Z";

                g.DrawString(s, SystemFonts.DefaultFont, Brushes.Green, (int)dot[0] + center[0], (int)dot[1] + center[1]);
            }

            //отрисовка отрезков
            for (int i = 0; i < lines.GetLength(0); i++)
            {
                //получение концов отрезков
                double[] dot1 = { dots[lines[i, 0], 0], dots[lines[i, 0], 1], dots[lines[i, 0], 2] };
                double[] dot2 = { dots[lines[i, 1], 0], dots[lines[i, 1], 1], dots[lines[i, 1], 2] };

                //поворот в нужную проекцию
                dot1 = RotateFunc(dot1);
                dot2 = RotateFunc(dot2);

                //отрисовка
                g.DrawLine(new Pen(Color.Black, 2), (int)dot1[0] + center[0], (int)dot1[1] + center[1], (int)dot2[0] + center[0], (int)dot2[1] + center[1]);
            }
        }

        /// <summary>
        /// Прямоугольная изометрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] RectangularIsometry(double[] dot)
        {
            double[] zoomCoefs = { 0.82, 0.82, 0.82 };

            dot = ZoomDot(dot, zoomCoefs);

            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);

            dot = RotateDotOY(dot, -45);
            dot = RotateDotOX(dot, 35.264);


            return dot;
        }

        /// <summary>
        /// Прямоугольная диметрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] RectangularDimetry(double[] dot)
        {
            double[] zoomCoefs = { 0.77, 1.6, 1.1 };

            dot = ZoomDot(dot, zoomCoefs);

            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);

            dot = RotateDotOY(dot, -20);
            dot = RotateDotOX(dot, 45);


            zoomCoefs = new double[] { 1.034, 0.47, 0.94 };
            dot = ZoomDot(dot, zoomCoefs);

            return dot;
        }

        /// <summary>
        /// Горизонтальная косоугольная изометрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] HorisontalIsometry(double[] dot)
        {
            double[] zoomCoefs = { 0.8, 1, 4.5 };
            dot = ZoomDot(dot, zoomCoefs);

            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);

            dot = RotateDotOY(dot, -60);
            dot = RotateDotOX(dot, 80);

            return dot;
        }


        /// <summary>
        /// Фронтальная косоугольная изометрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] FrontalIsometry(double[] dot)
        {
            double[] zoomCoefs = new double[] { 0.47, 0.5, 1.8 };
            dot = ZoomDot(dot, zoomCoefs);

            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);

            dot = RotateDotOY(dot, -45);
            dot = RotateDotOX(dot, 45);

            dot[0] = dot[0] * 2;

            dot = RotateDotOY(dot, 10.5);
            dot = RotateDotOX(dot, 20);

            dot[0] = dot[0] * 1.1;

            dot = RotateDotOZ(dot, 18.6);

            return dot;
        }

        /// <summary>
        /// Фронтальная косоугольная диметрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] FrontalDimetry(double[] dot)
        {
            double[] zoomCoefs = new double[] { 0.47, 0.25, 1.8 };
            dot = ZoomDot(dot, zoomCoefs);

            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);

            dot = RotateDotOY(dot, -45);
            dot = RotateDotOX(dot, 45);

            dot[0] = dot[0] * 2;

            dot = RotateDotOY(dot, 10.5);
            dot = RotateDotOX(dot, 20);

            dot[0] = dot[0] * 1.1;

            dot = RotateDotOZ(dot, 18.6);

            return dot;
        }


        /// <summary>
        /// Прямоугольная диметрия
        /// </summary>
        /// <param name="dot"></param>
        /// <returns></returns>
        public static double[] Perspective(double[] dot)
        {
            double[] zoomCoefs = { 0.7, 0.7, 0.7 };

            dot = ZoomDot(dot, zoomCoefs);


            dot = RotateDotOX(dot, 90);
            dot = RotateDotOY(dot, 180);


            dot[0] = dot[0] * (1 - dot[2] / 200);
            dot[1] = dot[1] * (1 - dot[2] / 200);
            dot[2] = dot[2] * (1 - dot[2] / 200);

 
            dot = RotateDotOY(dot, PerspectiveAngle);
            dot = RotateDotOX(dot, 15);


            return dot;
        }


        #region RotateZoom
        /// <summary>
        /// Поворот точки по ОХ
        /// </summary>
        /// <param name="dot"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        static double[] RotateDotOX(double[] dot, double angle)
        {
            double rads = angle / 180d * Math.PI;

            double[] result = new double[3];
            result[0] = dot[0];
            result[1] = Math.Cos(rads) * dot[1] - Math.Sin(rads) * dot[2];
            result[2] = Math.Cos(rads) * dot[2] + Math.Sin(rads) * dot[1];

            return result;
        }

        /// <summary>
        /// Поворот точки по ОУ
        /// </summary>
        /// <param name="dot"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        static double[] RotateDotOY(double[] dot, double angle)
        {
            double rads = angle / 180d * Math.PI;

            double[] result = new double[3];
            result[0] = Math.Cos(rads) * dot[0] + Math.Sin(rads) * dot[2];
            result[1] = dot[1];
            result[2] = Math.Cos(rads) * dot[2] - Math.Sin(rads) * dot[0];

            return result;
        }


        /// <summary>
        /// Поворот точки по ОZ
        /// </summary>
        /// <param name="dot"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        static double[] RotateDotOZ(double[] dot, double angle)
        {
            double rads = angle / 180d * Math.PI;

            double[] result = new double[3];
            result[0] = Math.Cos(rads) * dot[0] - Math.Sin(rads) * dot[1];
            result[1] = Math.Cos(rads) * dot[1] + Math.Sin(rads) * dot[0];
            result[2] = dot[2];

            return result;
        }

        /// <summary>
        /// Масштабирование точки
        /// </summary>
        /// <param name="dot"></param>
        /// <param name="coefs"></param>
        /// <returns></returns>
        static double[] ZoomDot(double[] dot, double[] coefs)
        {
            double[] result = new double[3];
            result[0] = dot[0] * coefs[0];
            result[1] = dot[1] * coefs[1];
            result[2] = dot[2] * coefs[2];

            return result;
        } 
        #endregion


    }
}
