using Decor;

namespace DecorNetConsoleApp
{
    public class LoggingDecorator : IDecorator
    {
        public async Task OnInvoke(Call call)
        {
            Console.WriteLine("Will do some work!");
            await call.Next();
            Console.WriteLine("Work is finished!");
        }

    }

}
