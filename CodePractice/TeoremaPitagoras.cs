namespace CodePractice
{
    public class TeoremaPitagoras
    {
        public double CalcularHipotenusa(double catetoA, double catetoB)
        {
            return Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
        }

        public double CalcularCateto(double hipotenusa, double cateto)
        {
            return Math.Sqrt(hipotenusa * hipotenusa - cateto * cateto);
        }

        public bool VerificarTrianguloRetangulo(double ladoA, double ladoB, double ladoC)
        {
            double[] lados = new double[] { ladoA, ladoB, ladoC };
            Array.Sort(lados);
            return Math.Abs((lados[0] * lados[0] + lados[1] * lados[1]) - (lados[2] * lados[2])) < 1e-10;
        }

        public double CalcularArea(double catetoA, double catetoB)
        {
            return (catetoA * catetoB) / 2;
        }

        public double CalcularPerimetro(double catetoA, double catetoB)
        {
            double hipotenusa = CalcularHipotenusa(catetoA, catetoB);
            return catetoA + catetoB + hipotenusa;
        }

        public double CalcularAltura(double catetoA, double catetoB)
        {
            double hipotenusa = CalcularHipotenusa(catetoA, catetoB);
            return (catetoA * catetoB) / hipotenusa;
        }

        public double CalcularAnguloA(double catetoA, double catetoB)
        {
            double hipotenusa = CalcularHipotenusa(catetoA, catetoB);
            return Math.Asin(catetoA / hipotenusa) * (180.0 / Math.PI);
        }

        public double CalcularAnguloB(double catetoA, double catetoB)
        {
            double hipotenusa = CalcularHipotenusa(catetoA, catetoB);
            return Math.Asin(catetoB / hipotenusa) * (180.0 / Math.PI);
        }

    }
}
