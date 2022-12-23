namespace ExerciciosPraticos2
{
    internal class Ex1
    {
        static void Main(string[] args)
        {

            int num1=0,num2=0;
            bool estado;


            Console.WriteLine("Algoritmo de Euclides");
            Console.WriteLine("Por favor insira o primeiro número");
            estado= int.TryParse(Console.ReadLine(), out int result);
            
            if(estado) {
                num1 = result;
            }

            Console.WriteLine("Por favor insira o segundo número");
            estado = int.TryParse(Console.ReadLine(), out int result1);
            
            if(estado)
            {
                num2 = result1;
            }


            Console.WriteLine("O máximo divisor comum dos dois números inteiros introduzidos é "  + MDC(num1, num2));
        }



        static int MDC (int A, int B)
        {
            if (B != 0)
            {
                int R = B;
                B = A % B;
                A = R;
                return B;
            }
            else
            {
                return A;
            }
        }
    }
}