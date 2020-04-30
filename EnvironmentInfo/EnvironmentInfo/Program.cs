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
            Console.Title = "пример для работы с git";

            Console.WriteLine("Привет, мир!");
            Console.WriteLine($"Компьютер: {Environment.MachineName}, версия ОС: {Environment.OSVersion}");
            
            Console.WriteLine("Master + Branch 2");

            Console.WriteLine($"{(new DriveInfo("c:").TotalFreeSpace) / 1024 / 1024:n0} МБайт");
            Console.Write("\n\n\t");
        }
    }
}
