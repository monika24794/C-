using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DelegatesLibrary;

namespace DeligatesDemo
{
    internal class EventsDemo
    {
       // static event eventhandler/deleigate event name
         static event ProductIdGenrationdelegate ev_AutoGenrateProductId;
         static event MathsOperations ev_DoAddtion;
         static event MathsOperations ev_DoSubstraction;
        static void Main(string[] args)
        {

            Maths m1 = new Maths();
            int choice;
            do {

                //productDelegateMain();
                Console.WriteLine("1.add 2.subtract 0.exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addtion");
                        MathsOperations mo1 = new MathsOperations(m1.Add);
                        ev_DoAddtion += mo1;
                        Console.WriteLine("enter first number");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second number");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        int add = ev_DoAddtion(num1, num2);
                        Console.WriteLine(add);
                       


                        break;
                    case 2:
                        Console.WriteLine("SUBSTRACTION");
                        MathsOperations mo2 = new MathsOperations(m1.Subtract);
                        ev_DoSubstraction += mo2;
                       
                        Console.WriteLine("enter first number");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter second number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        int sub = ev_DoSubstraction(num1, num2);
                        Console.WriteLine(sub);
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }


            }while(choice!=0);
         
            }

        private static void productDelegateMain()
        {
            Products p = new Products();
            ProductIdGenrationdelegate delgen = new ProductIdGenrationdelegate(p.GenrateId);
            ev_AutoGenrateProductId += delgen;
            int proID = ev_AutoGenrateProductId();
            Console.WriteLine(proID);
            Console.WriteLine("_________________________");

            proID = ev_AutoGenrateProductId();
            Console.WriteLine(proID);
        }
    }
}
