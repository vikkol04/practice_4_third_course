namespace ConsoleApp1
{
    internal class Kolokolnikov_var_4
    {
        static void Main (string[] args)
        {
        
            // first function
            double f1(double x) { return (Math.Log(x - 3) + 4) / (x*x + 12); }

            // second function
            double f2(double y, double a, double b) 
            {
                double k = Math.Cbrt(y + 7);
                return (k + a) / (Math.Sin(b) + k);
            }

            double y = f1(4.7);
            Console.WriteLine($"y = {y}");
            
            double z = f2(y, 7.6, 8.1);
            Console.WriteLine($"z = {z}");
        }
    }
}
