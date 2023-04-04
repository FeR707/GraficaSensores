using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficaSensores.Clases
{
    internal class FuncionPertenencia
    {
        public int alpha;
        public int beta;
        public int gamma;

        public FuncionPertenencia(int alpha, int beta, int gamma)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.gamma = gamma;
        }

        public FuncionPertenencia(int alpha, int beta)
        {
            this.alpha = alpha;
            this.beta = beta;
        }

        public double funcionTriangular(double x)
        {
            double y = 0;

            if (alpha <= x && x <= beta)
            {
                y = (x - alpha) / (beta - alpha);
            }
            else if (beta < x && x <= gamma)
            {
                y = (gamma - x) / (gamma - beta);
            }
            else
            {
                y = 0;
            }
            return y;
        }

        public double funcionHombro(double x)
        {
            double y = 0;

            if (x <= alpha)
            {
                y = 1;
            }
            if (alpha < x && x <= beta)
            {
                y = (x - beta) / (alpha - beta);
            }
            if (x > beta)
            {
                y = 0;
            }
            return y;
        }

        public double funcionSaturacion(double x)
        {
            double y = 0;

            if (x <= alpha)
            {
                y = 0;
            }
            if (alpha < x && x <= beta)
            {
                y = (x - alpha) / (beta - alpha);
            }
            if (x > beta)
            {
                y = 1;
            }
            return y;
        }
    }
}
