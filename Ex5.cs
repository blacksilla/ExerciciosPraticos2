namespace ExerciciosPraticos2
{
    internal class Ex5
    {
        static void Main(string[] args)
        {
            string ints = string.Empty;
            

            Console.WriteLine("Introduza 10 números separados por vírgulas");

            ints = Console.ReadLine();
            string[] stringSplit = ints.Split(",");

            retornaMaxEMin(stringSplit);

        }


        static void retornaMaxEMin(string[] inteiros)
        {
            int[] convert = new int[inteiros.Length];
            int val = 0;
            // converter de string a inteiros

            for (int i=0; i<inteiros.Length; i++) {

                if (int.TryParse(inteiros[i], out val)) {
                    convert[i] = val;
                }

                

            }
            Console.WriteLine($"O número mínimo é {convert.Min()} e o número máximo é {convert.Max()}.");
            
        }
    }
}