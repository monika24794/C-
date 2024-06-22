using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using CustomerLibrary;

namespace SerilizationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Binary serilazition \n2.binary deserilization\n3.XML serilization\n4.XMldesrlization" +
                "\n5.Json serilazition \n6.JSon deserilization \n0 exit");
            Console.WriteLine("enter choice");
            int ch =Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    FileStream fs = new 
                        FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custbin.dat", FileMode.CreateNew,FileAccess.Write);
                    Cust cust = new Cust();
                    cust.Custid = 11;
                    cust.CustName = "JACk";
                    cust.Password = "password";
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, cust);
                    fs.Close();
                    fs.Dispose();
                    break;
                    case 2:
                    FileStream fs1 = new
                     FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custbin.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf1 = new BinaryFormatter();
                    Cust c1 = (Cust)bf1.Deserialize(fs1);
                    Console.WriteLine(c1.Custid);
                    Console.WriteLine(c1.CustName);
                    Console.WriteLine(c1.Password);
                    fs1.Close();
                    fs1.Dispose();
                    break;
                case 3:
                    FileStream fsXml = new
                    FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custXml.dat",
                    FileMode.CreateNew, FileAccess.Write);
                    XmlSerializer xmlser = new XmlSerializer(typeof(Cust));
                    Cust cust1 = new Cust();
                    cust1.Custid = 11;
                    cust1.CustName = "JACk";
                    cust1.Password = "password";
                    xmlser.Serialize(fsXml, cust1);
                  fsXml.Close();
                    fsXml.Dispose();

                    break; 
                case 4:
                    FileStream fsXmld = new
                   FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custXml.dat",
                   FileMode.Open, FileAccess.Read);
                    XmlSerializer xmldser = new XmlSerializer(typeof(Cust));
                    Cust c= (Cust)xmldser.Deserialize(fsXmld);
                    Console.WriteLine(c.Custid);
                    Console.WriteLine(c.CustName);
                    Console.WriteLine(c.Password);
                    fsXmld.Close();
                    fsXmld.Dispose();
                    break; 
                    case 5:
                    FileStream fsjson = new
                   FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custjson.dat",
                   FileMode.CreateNew, FileAccess.Write);
                    DataContractJsonSerializer data = new DataContractJsonSerializer(typeof(Cust));
                    Cust cust2 = new Cust();
                    cust2.Custid = 16;
                    cust2.CustName = "reva";
                    cust2.Password = "password";
                 MemoryStream ms= new MemoryStream();
                    data.WriteObject(ms, cust2);
                    fsjson.Write(ms.ToArray());
                    fsjson.Close();
                    ms.Close();
                    fsjson.Dispose();
                    
                        break; 
                    case 6:
                    FileStream fsjsond = new
                   FileStream(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\\custjson.dat",
                   FileMode.Open, FileAccess.Read);
                    DataContractJsonSerializer data1= new DataContractJsonSerializer(typeof(Cust));
                    Cust cust3 = (Cust)data1.ReadObject(fsjsond);
                    //ms = new MemoryStream();
                    //fsjsond.Read(ms.ToArray());
                    fsjsond.Close();
                    //ms.Close();
                    fsjsond.Dispose();
                    Console.WriteLine(cust3.CustName);
                    Console.WriteLine(cust3.Custid);
                   Console.WriteLine(cust3.Password);

                    break; 
                    case 0:
                  Environment.Exit(0);
                    break;
            }
        }
    }
}
