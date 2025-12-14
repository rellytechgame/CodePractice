
using CodePractice;

namespace RetosCode
{
    class Program
    {
        static void Main(string[] args)
        {

            TeoremaPitagoras tp = new TeoremaPitagoras();

            Console.WriteLine("Ingrese el valor del cateto A: ");
            double catetoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cateto B: ");
            double catetoB = Convert.ToDouble(Console.ReadLine());

            double area = tp.CalcularArea(catetoA, catetoB);

            Console.WriteLine("El área del triángulo rectángulo es: {0} \n\n\n", area);


            Console.WriteLine("Calculando la hipotenusa");

            Console.WriteLine("Ingrese el valor del cateto A: ");
            catetoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto B: ");
            catetoB = Convert.ToDouble(Console.ReadLine());

            double hipotenusa = tp.CalcularHipotenusa(catetoA, catetoB);

            Console.WriteLine("La hipotenusa del triángulo rectángulo es: {0} \n\n\n", hipotenusa);

        }
    }
}
