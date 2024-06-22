using System.IO;

using System.Security.AccessControl;
using ExceptionProjectLibrary;
namespace FileHandlingDemo
{
    internal class Program
    {
       private  static void Main(string[] args)
        {
            //WorkingWithFilesAndDirectives();
            // WorkingWithFileAndDirInfo();

            string date=DateTime.Now.ToString("yyyy/MM/dd/HH/mm/ss");
            string filename = string.Concat("customerlog.txt", date);
            string path = @"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\" +filename;
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {

                Customer customer = new Customer();
                Console.WriteLine("enter customer id");
                customer.CustId=Convert.ToInt32(Console.ReadLine());
                string pathf = @"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\p1.txt";
               fs = new FileStream(pathf, FileMode.CreateNew, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine("this is the demo file using filestream");
                sw.WriteLine("some more text............!!!!!!!!!!");
                sw.WriteLine("i defently achive my goal........... ");
            }
            catch (CustomerNotFoundException ex)
            {
                
                fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(ex.Message);
            }
            finally
            {
                sw.Flush();
                sw.Close();
                fs.Close();
                fs.Dispose();
            }
            
        }

        private static void WorkingWithFileAndDirInfo()
        {
            FileInfo fi = new FileInfo(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\dir1\file2.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastWriteTime);
            Console.WriteLine(fi.CreationTime.ToString());
            Console.WriteLine(fi.LinkTarget);
            Console.WriteLine(fi.DirectoryName);
            FileSecurity fs = fi.GetAccessControl();
            Console.WriteLine(fs.AuditRuleType);


            Console.WriteLine("____________________________________________________________________");

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\CDAC\Desktop\MonikaDotnet\DemoFile\dir1");
            Console.WriteLine(di.FullName);
            Console.WriteLine(di.Extension);
            Console.WriteLine(di.CreationTime);
            Console.WriteLine(di.LastWriteTime);
            Console.WriteLine(di.CreationTime.ToString());
            Console.WriteLine(di.LinkTarget);
            Console.WriteLine(di.Root);
        }

        private static void WorkingWithFilesAndDirectives()
        {
            String path = @"C:/Users/CDAC/Desktop/MonikaDotnet/DemoFile/";
              Directory.CreateDirectory(path+"dir1\\");
            Console.WriteLine(File.ReadAllText(path + "file2.txt"));
            File.Move(path+"file2.txt",path +"dir1\\file2.txt");

            String[] files = Directory.GetFiles(path + "dir1\\");
            foreach (String file in files)
            {
                Console.WriteLine(file);
            }
            string fullpath = @"C:\Users\CDAC\Desktop\MonikaDotnet\FileHAndlingDemo\FileHAndlingDemo\";

            IEnumerable<string> dirs = Directory.GetDirectories(fullpath);
            foreach (String dir in dirs)
            {
                Console.WriteLine(dir);
            }

            bool isfound = Directory.Exists(fullpath);
            Console.WriteLine(isfound);
            //or
            //   String path= " @C: \Users\CDAC\Desktop\MonikaDotnet\DemoFile"
            //   String path= " C: /Users/CDAC/Desktop/MonikaDotnet/DemoFile"
            File.Create(path + "file1.txt");
            File.AppendAllText(path + "file1.txt", "this is a file demo  devlopead by monika");
            string dest = string.Concat(path + "file2.txt");
            File.Copy(path + "file1.txt", dest);
            File.Delete(dest);
            Console.WriteLine("file deletead");
            string contents=File.ReadAllText(path + "file1.txt");
            Console.WriteLine(contents);
            string movepath = "C:\\Users\\CDAC\\Desktop\\MonikaDotnet\\DemoFile\\newfiles\\newfile\\";
            File.Move(path + "file1.txt", movepath );
        }
    }
}
