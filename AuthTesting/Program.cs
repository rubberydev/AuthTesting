

namespace AuthTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public double MakeOperation(MathOperation op, double numero1, double numero2)
        {
            switch (op)
            {
                case MathOperation.Suma:
                    return numero1 + numero2;
                case MathOperation.Resta:
                    return numero1 - numero2;
                case MathOperation.Multiplicacion:
                    return numero1 * numero2;
                case MathOperation.Division:
                    if (numero2 == 0)
                    {
                        throw new DivideByZeroException("No se puede dividir por cero.");
                    }
                    return numero1 / numero2;
                default:
                    throw new InvalidOperationException("Operación desconocida.");
            }
        }
    }
}