namespace Singleton
{
    public class MySingleton : Singleton<MySingleton>
    {
        private const string HelloWorldMessage = "Hello World - from MySingleton";

        public string HelloWorld { get; private set; }

        // Note: *** Private Constructor ***
        private MySingleton()
        {
            // Set default message here.
            HelloWorld = HelloWorldMessage;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var mySingleton = MySingleton.Instance;
            Console.WriteLine(mySingleton.HelloWorld);
            Console.ReadKey();
        }
    }
}