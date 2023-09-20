namespace ConsoleAppTDDFizzBuzz2
{
    public class Program
    {
        const int DIVISEUR_FIZZ = 3;
        const int DIVISEUR_BUZZ = 5;
        const string MESSAGE_FIZZ = "Fizz";
        const string MESSAGE_BUZZ = "Buzz";

        public static string FizzBuzzPourUnNombre(int nombre)
        {
            string result = "";
            if (nombre == 0)
                return nombre.ToString();
            result +=NumberDivisiblePar(nombre, DIVISEUR_FIZZ, MESSAGE_FIZZ);
            result +=NumberDivisiblePar(nombre, DIVISEUR_BUZZ, MESSAGE_BUZZ);
            
            return (result=="") ?nombre.ToString(): result;
        }

        public static bool NumberDivisiblePar(int n, int diviseur) => n % diviseur == 0;

        public static string NumberDivisiblePar(int n, int diviseur, string message) => (NumberDivisiblePar(n, diviseur) ? message : "");


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}