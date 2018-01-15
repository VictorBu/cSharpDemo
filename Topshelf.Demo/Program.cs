
namespace Topshelf.Demo
{
    /// <summary>
    /// 
    /// Install-Package Topshelf -Version 3.3.1
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<ServiceRunner>();

                x.RunAsLocalSystem();

                x.SetDescription("Topshelf Service Demo");
                x.SetDisplayName("Topshelf Service");
                x.SetServiceName("TopshelfService");

                x.EnablePauseAndContinue();
            });
        }
    }
}
