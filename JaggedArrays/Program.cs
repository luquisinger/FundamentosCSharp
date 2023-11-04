namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //família 1: Família Flinstones
            //família 2: Família Simpsons
            //família 3: Família Dona Florinda

            string[] familias = new string[]
            {
                  "Fred", "Wilma", "Pedrita",
                  "Homer", "Marge", "Lisa", "Bart", "Maggie",
                  "Florinda", "Kiko"
            };
            foreach(var pessoa in familias)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}