namespace IndexersAndJaggeadArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Products products = new Products();
            //products[0] = "green tea";
            //Console.WriteLine(products[0]);

            ComplexMaths c = new ComplexMaths();
            c[0, false] = 5; 

            c[1,false]=10;
            c[2,true] = 15;
            c[3,false] = 18;
            c[4,true] = 9;
            Console.WriteLine(c[3, false]);
            Console.WriteLine(c[3, true]);
            Console.WriteLine(c[4, true]);
            Console.WriteLine(c[4, false]);
            Console.WriteLine(c[1, true]);
            Console.WriteLine(c[1, false]);
            Console.WriteLine(c[2, true]);
            Console.WriteLine(c[2, false]);

        }
    }
}
