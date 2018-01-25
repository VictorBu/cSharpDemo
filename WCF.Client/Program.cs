using System;
using System.ServiceModel.Security;
using WCF.Client.CSharpDemoService;
using WCF.Client.CustomValidatorService;
using WCF.Client.GithubService;

namespace WCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (GithubServiceClient clientGithub = new GithubServiceClient())
            {
                try
                {
                    Console.WriteLine(clientGithub.Hello());
                    clientGithub.Close();
                }
                catch (Exception exception)
                {
                    clientGithub.Abort();
                    Console.WriteLine(exception.Message);
                }
            }

            using(CSharpDemoServiceClient clientCSharpDemo = new CSharpDemoServiceClient())
            {
                try
                {
                    Console.WriteLine(clientCSharpDemo.Hello());
                    clientCSharpDemo.Close();
                }
                catch (Exception exception)
                {
                    clientCSharpDemo.Abort();
                    Console.WriteLine(exception.Message);
                }
            }

            using (CustomValidatorServiceClient clientCustomValidatorService = new CustomValidatorServiceClient())
            {
                try
                {
                    UserNamePasswordClientCredential credential = clientCustomValidatorService.ClientCredentials.UserName;
                    credential.UserName = "test1";//用户名
                    credential.Password = "1tset";//密码
                    Console.WriteLine(clientCustomValidatorService.Hello());
                    clientCustomValidatorService.Close();
                }
                catch (Exception exception)
                {
                    clientCustomValidatorService.Abort();
                    Console.WriteLine(exception.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
