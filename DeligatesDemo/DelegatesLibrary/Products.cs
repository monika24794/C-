using System.Xml.Linq;

namespace DelegatesLibrary
{
    public  delegate int ProductIdGenrationdelegate();
    public delegate void WorkingWithProductDatadelegate();
    public delegate void ProductDeleteFindDelegate(String name);
    public delegate void ProductUpdateFindDelegate(int id, Products p);
    public delegate void ProductAddfindDelegate(Products p);
  


    public class Products
    {
        public int ProductId {  get; set; }
        public string ProductName { get; set; }
        public int  Price { get; set; }
        public int categeryId { get; set; }

        static List<Products> productslist = new List<Products>()
        {
            new Products{ProductId=1, Price=100,ProductName="tea",categeryId=1},
            new Products{ProductId=2, Price=140,ProductName="Coffee",categeryId=1},
            new Products{ProductId=3, Price=96,ProductName="bornavita",categeryId=1},
            new Products{ProductId=4, Price=85,ProductName="boost",categeryId=1},
            new Products{ProductId=5, Price=150,ProductName="lemon juice",categeryId=1},
            new Products{ProductId=6,Price=50,ProductName="lays",categeryId=2}
        };

        static int cnt = 0;
        public int GenrateId()
        { 
        
        return ++cnt;
        }
        public void AddProduct(Products p)
        {
            Console.WriteLine ("product Add called");
            productslist.Add(p);
        }
        public void UpdateProduct(int id, Products p)
        {

          Products FoundProduct=  productslist.Find(p =>p.ProductId == id);
            if(FoundProduct!=null)
            {
                FoundProduct.ProductName=p.ProductName;
                FoundProduct.ProductId=p.ProductId;
                FoundProduct.Price=p.Price;
            }
            else { Console.WriteLine("product id not found"); }
        }
        public void DeleteProduct(String name)
            {
            Console.WriteLine("delete product called");
            Products FoundProduct = productslist.Find(p=>p.ProductName==name);
            Console.WriteLine("found the follwing productsdetails.conform is delete or not");
            Console.WriteLine(FoundProduct.ProductName);
            Console.WriteLine(FoundProduct.ProductId);
            Console.WriteLine(FoundProduct.Price);
            Console.WriteLine("press  ' y'if you want to delete  ");
            char useans= Convert.ToChar(Console.ReadLine());
            if(useans=='y')
            {
                productslist.Remove(FoundProduct);
                Console.WriteLine( "product is successfully deletad");
            }
        }
            public Products findProductByName(String name)
           {
         
            Console.WriteLine("find product callead");
            Products FoundProduct = productslist.Find(p => p.ProductName == name);
 
            return FoundProduct; 
                
            
     
           }
        public List<Products> findProductByCategeryId(int categeryId)
        {//p scope variable

          List<Products>allproductInCategery = 
           productslist.FindAll(p => p.categeryId == categeryId);
     
            return allproductInCategery;
        }
       


    }
}
