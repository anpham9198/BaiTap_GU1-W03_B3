using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_GU1_W03_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (true)
            {
               
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Good bye!!");
                    break;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Draw the triangle");
                    Console.Write("Nhap canh cua hinh tam giac: ");
                    int canh;
                    canh = int.Parse(Console.ReadLine());

                    int doDaiCanh = canh;
                    for (int i = 0; i < canh; i++)
                    {
                        for (int j = 0; j < doDaiCanh; j++)
                        {
                            Console.Write("*");
                        }

                        doDaiCanh = doDaiCanh - 1;
                        Console.WriteLine();
                    }

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Draw the square");
                    int canh;
                    Console.Write("Nhap canh cua hinh vuong: ");
                    canh = int.Parse(Console.ReadLine());

                    int chieuDai = canh;
                    int chieuRong = canh;

                    int bienLapCR = 0;
                    
                    while (bienLapCR < chieuRong)
                    {
                        
                        int bienLapCD = 0;
                        while (bienLapCD < chieuDai)
                        {
                            Console.Write("*");
                            bienLapCD++;
                        }
                        Console.WriteLine();
                        bienLapCR++;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Draw the rectangle");

                    int chieuDai = 0;
                    int chieuRong = 0;

                    Console.Write("Nhap chieu dai cua hinh chu nhat: ");
                    chieuDai = int.Parse(Console.ReadLine());

                    Console.Write("Nhap chieu rong cua hinh chu nhat: ");
                    chieuRong = int.Parse(Console.ReadLine());


                    int bienLapCR = 0;
                   
                    while (bienLapCR < chieuRong)
                    {
                        
                        int bienLapCD = 0;
                        while (bienLapCD < chieuDai)
                        {
                            Console.Write("*");
                            bienLapCD++;
                        }
                        Console.WriteLine();
                        bienLapCR++;
                    }
                }
                else
                {
                    Console.WriteLine("Please input again!");
                }

                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
