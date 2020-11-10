using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double n1, n2, n3, n4, n5, delta, x1, x2;

            Console.WriteLine("Digite o valor de 'a' (e tecle ENTER):");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'b' (e tecle ENTER):");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de 'c' (e tecle ENTER):");
            c = int.Parse(Console.ReadLine());

            n1 = (-(b));
            
            delta = Math.Pow(b,2) + (-4 * a * c);

            n4 = (2*a);

            Console.WriteLine("x = {0} ± √ - ({1}²) - 4 . {2} . {3}", n1, b, a, c);
            Console.WriteLine("               2.({0})", a);

            Console.WriteLine("{0} ± √{1}", n1, delta);

            Console.WriteLine("  {0}", n4);

            n2 = (int)Math.Sqrt(delta);

            Console.WriteLine("{0} ± {1}", n1, n2);

            Console.WriteLine("  {0}", n4);

            n3 = (n1 + (n2));
            x1 = (n3 / n4);

            n5 = (n1 - (n2));
            x2 = (n5 / n4);

            Console.WriteLine("x¹ = {0} + {1} = {2} = {3}", n1, n2, n3, x1 );
            Console.WriteLine("       {0}     {0}", n4);
            
            
            Console.WriteLine("x² = {0} - {1} = {2} = {3}", n1, n2, n5, x2);
            Console.WriteLine("       {0}     {0}", n4);
            
        }
    }
    
}
