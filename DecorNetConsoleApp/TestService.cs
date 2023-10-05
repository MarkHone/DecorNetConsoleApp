using Decor;

namespace DecorNetConsoleApp
{
    public class TestService : ITestService
    {

        [Decorate(typeof(LoggingDecorator))]
        public void DoWork()
        {
            Console.WriteLine("Working...");
        }

    }

}
