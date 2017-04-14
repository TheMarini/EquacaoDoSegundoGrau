using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjClasse
{
    public class segundo_grau
    {
        //Campos
        private double _a;
        private double _b;
        private double _c;

        //Propriedades
        #region Propriedades
        public double a 
        {
            set { _a = value; }
            get { return _a; }
        }
        public double b
        {
            set { _b = value; }
            get { return _b; }
        }
        public double c
        {
            set { _c = value; }
            get { return _c; }
        }

        public double delta
        {
            get { return Math.Pow(_b,2) - (4*_a*_c);}
        }

        public double x1
        {
            get
            {
                if (delta == 0)
                {
                    return (-_b - Math.Sqrt(delta)) / 2 * _a;
                }
                else
                {
                    return (-_b + Math.Sqrt(delta)) / 2 * _a;
                }
            }
        }

        public double x2
        {
            get
            {
                if (delta == 0)
                {
                    return (-_b - Math.Sqrt(delta)) / 2 * _a;
                }
                else
                {
                    return (-_b - Math.Sqrt(delta)) / 2 * _a;
                }
            }
        }
        #endregion

        //Métodos
        #region Métodos
        public void addDados(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        #endregion

        //Construtor
        #region Construtor
        public segundo_grau()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }
        #endregion
    }
}
