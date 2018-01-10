using GarupaCard.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarupaCard.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo.Instance.Init();
            System.Console.WriteLine(UserInfo.Instance.AllCards.Count);
        }
    }
}
