using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentInfo
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Привет, мир!");
            Console.WriteLine($"Компьютер: {Environment.MachineName}, версия ОС: {Environment.OSVersion}");

            Console.WriteLine($"{(new DriveInfo("c:").TotalFreeSpace) / 1024 / 1024:n0} МБайт");
            Console.Write("\n\n\t");
        }
    }
}
