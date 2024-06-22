namespace AsyncAndAwaitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            print1to10();
            printHello();
             Task<int> ans=multiplayNo(2, 3);
            Console.WriteLine("ANSWER =  " +ans.Result);
        }
        public static async void print1to10()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Task.Delay(10);
                }
            });
        }
        public static async void printHello()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("HELLO");
                    Task.Delay(10);
                }
            });
        }

        public static async Task<int> multiplayNo(int i,int j)
        {
            int ans = 0;

            await Task.Run(() =>
            {

                for (int j1 = 0; j1 < 10; j1++)
                {
                    ans = i*j * 10;

                }
            });

            return ans;
        }
    }
}

