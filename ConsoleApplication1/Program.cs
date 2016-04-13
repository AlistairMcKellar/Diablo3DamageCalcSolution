using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diablo3DataAccessor;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerProfile = Diablo3ApiCalls.GetPlayerProfile();
            Console.ReadLine();

        }
    }
}
