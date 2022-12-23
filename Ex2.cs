namespace ExerciciosPraticos2
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            bool estado;
            double TempF;
            
            Console.WriteLine("Graus Fahrenheit");
            Console.WriteLine("Introduza a temperatura");
            estado = double.TryParse(Console.ReadLine(), out TempF);
            Console.WriteLine($"A temperatura {TempF}ºF em Celsius são {Math.Round(ConvertFtoC(TempF),1)}ºC");
        }


        static double ConvertFtoC(double f)
        {
            f = (f - 32) * 5 / 9;
            return f;
        }
    }
}