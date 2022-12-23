namespace ExerciciosPraticos2
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            int ano;
            bool estado;

            Console.WriteLine("Por favor insira um ano");
            estado = int.TryParse(Console.ReadLine(), out int result);

            if (estado)
            {
                ano = result;
                Console.WriteLine($"O ano introduzido {verificaANO(ano)}.");
            }

        }


        static string verificaANO(int ano)
        {
            if (ano%400==0 || ( ano%4==0 && ano % 100 != 0))
            {
                return "é bissexto";
            } else
            {
                return "não é bissexto";

            }

                
           
        }
    }
}