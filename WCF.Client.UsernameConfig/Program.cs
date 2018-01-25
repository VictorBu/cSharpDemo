using System;
using System.ServiceModel.Security;
using WCF.Client.UsernameConfig.CustomValidatorService;

namespace WCF.Client.UsernameConfig
{
    /// <summary>
    /// 
    /// 把用户名和密码写入配置文件, 不需要每次手动调用
    /// https://stackoverflow.com/questions/3725294/set-wcf-clientcredentials-in-app-config
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (CustomValidatorServiceClient clientCustomValidatorService = new CustomValidatorServiceClient())
            {
                try
                {
                    //UserNamePasswordClientCredential credential = clientCustomValidatorService.ClientCredentials.UserName;
                    //credential.UserName = "test1";
                    //credential.Password = "1tset";

                    Console.WriteLine(clientCustomValidatorService.Hello());
                    clientCustomValidatorService.Close();
                }
                catch (Exception exception)
                {
                    clientCustomValidatorService.Abort();
                    Console.WriteLine(exception.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
