using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Gun
    {
        private bool needToReload;
        private string timer = "321";
        private int NumberOfBullets = 0;
        private const int MaxNumOfBullets = 6;
        public Gun()
        {
           // needToReload = false;//конструктор класу читається першим, можна присвоювати значення тут щоб не ритись в коді
        }
        private void MessageForReload()
        {
            Console.WriteLine("You are to reload your gun!!!");
            needToReload = true;
        }
        private void StartReloading()
        {
            if (needToReload == true)
            {
                Console.WriteLine("\nClick 'Enter' to reload: ");
                ConsoleKey key1 = Console.ReadKey().Key;
                if (key1 == ConsoleKey.Enter)
                {
                    Console.WriteLine("Wait till Gun will reload");
                    foreach (char timer in timer)
                    {
                        Console.Write($"{timer}...");
                        for (int i = 0; i < 2; i++)
                        {
                            NumberOfBullets++;
                        }
                        Thread.Sleep(1000);  
                    }
                    Console.WriteLine($"\n\nYour Gun is ready to shoot, you have {NumberOfBullets} bullets");
                    needToReload = false;
                    ReadyToShoot();
                }
               
                if (key1 != ConsoleKey.Enter)
                {
                    Console.WriteLine("\n!!!!!You can click only 'Enter'!!!!!\n");
                    StartReloading();
                }
            }
            else if (needToReload == false)
            {
                ReadyToShoot();
            }
        }
        private void ReadyToShoot()
        {
                if (needToReload == false)
                {
                    Console.WriteLine("\nClick 'Space' to shoot");

                    for (int i = 0; i < MaxNumOfBullets; i++)
                    {
                        ConsoleKey key2 = Console.ReadKey().Key;
                        if (key2 == ConsoleKey.Spacebar)
                        {
                            NumberOfBullets--;
                            Console.WriteLine($"Bang!!! \n\n{NumberOfBullets} bullets remains");
                        }
                        if (key2 != ConsoleKey.Spacebar)
                        {
                             Console.WriteLine("\n!!!!You can click only 'Space'!!!!\n");
                             ReadyToShoot();
                        }
                    }
                    needToReload = true;
                    if (needToReload == true)
                    {
                        MessageForReload();
                        StartReloading();
                    }
                }
        }
        public void Shoot()
        {
            MessageForReload();
            StartReloading();
            ReadyToShoot();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gun = new Gun();
            gun.Shoot();
        }
    }
}
