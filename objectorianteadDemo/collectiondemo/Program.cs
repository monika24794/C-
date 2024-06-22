using System.Collections;
using SchoolManagementLib;
namespace collectiondemo
{
    internal class Program
    {
       private  static void Main(string[] args)
        {
            Console.WriteLine("enter choice");
            int choice = 3;
            switch (choice)
            {
                case 1:
                    phoneBookUsingHashtable p = new phoneBookUsingHashtable();
                    p.populataeEntries();
                    Console.WriteLine("enter the number to find");
                    int k = Convert.ToInt32(Console.ReadLine());
                    string name = p.Findname(k);
                    Console.WriteLine(name);
                    Console.WriteLine("=============");
                    p.AddData(69325, "gita");
                    Console.WriteLine("--------------");
                    p.Display();
                    break;
                case 2:
                    StudentSorteadlist student = new StudentSorteadlist();
                    student.display();
                    Console.WriteLine("===============");
                    student.AddStudent(3, "mira");
                    Console.WriteLine("=================");
                    student.display();
                    break;
                case 3:
                    ArrayListdemo demo1=new ArrayListdemo();
                    ArrayList list=demo1.GettheArrayList();
                  
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                    demo1.AddElement(4000);
                    Console.WriteLine("------------------");
                    list = demo1.GettheArrayList();
                    foreach(var item in list)

                    { Console.WriteLine(item); }
                    break;

                    default: Console.WriteLine();
                    break;

            }


        }
    }
}
