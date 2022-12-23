namespace ExerciciosPraticos2
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int num1;
            bool estado;

            Console.WriteLine("Por favor insira um número inteiro");
            estado = int.TryParse(Console.ReadLine(), out int result);

            if (estado)
            {
                num1 = result;
                Console.WriteLine($"O número introduzido {verificaPar(num1)}.");
            }
        }


        static string verificaPar(int num)


        {
            if(num%2 == 0)
            {
                return "é par";
            } else
            {
                return "é ímpar";
            }
            
        }
    }
}
