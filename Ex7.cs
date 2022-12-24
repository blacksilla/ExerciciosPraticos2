namespace ExerciciosPraticos2
{
    internal class Ex7
    {
        static void Main(string[] args)
        {
            bool estado = true;
            int counter = 0;
            int result = 0;

            Console.WriteLine("Exercício 7");
            Console.WriteLine();

            while (estado)
            {
                bool trueInput=false;
               
                
                Console.WriteLine("Insira um número");
                trueInput= int.TryParse(Console.ReadLine(), out result);

                if(trueInput && result>=0)
                {
                    counter=counter+result;
                   
                    
                }
                else
                {
                    estado=false;
                }

            }

            Console.WriteLine($"A soma dos números introduzidos é {counter+result}");
            
        }

    }
}