using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IT_Encode.Interface;

namespace IT_Encode
{
    public class Application : IMain
    {
        private readonly IEncode _Encode;

        public Application(IEncode encode)
        {
            _Encode = encode;
        }
        public void Run()
        {
            Console.WriteLine("請輸入你的密碼:");
            string? InputStr = Console.ReadLine();
            if (string.IsNullOrEmpty(InputStr))
            {
                Console.WriteLine("輸入的字串為空");
                Console.WriteLine($"--------------------{Environment.NewLine}");
                Console.WriteLine("按任意鍵結束");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"--------------------{Environment.NewLine}");
            string EncodeStr = _Encode.GetMd5Hash(InputStr);
            Console.WriteLine($"加密後的字串:{Environment.NewLine}{EncodeStr}{Environment.NewLine}");
            Console.WriteLine("--------------------");
            Console.WriteLine("按任意鍵結束");
            Console.ReadKey();
        }
    }
}