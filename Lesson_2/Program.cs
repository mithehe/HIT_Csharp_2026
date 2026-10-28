using System;

namespace Lesson_2
{
    class Program
    {
        //ref de truyen tham chieu, de thay doi gia tri currentHP trong ham 
        static int UsehealingPotions(ref int currentHP, int[] potions)
        {
            int count = 0;
            for(int i = 0; i < potions.Length; i++)
            {
                currentHP += potions[i];
                count++;
                if (currentHP >= 100)
                {
                    currentHP = 100;
                    break;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int currentHP;
            Console.Write("Nhap luong mau hien tai cua nhan vat: ");
            currentHP = int.Parse(Console.ReadLine());
            int n;
            Console.Write("Nhap so binh thuoc trong tui: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int result = UsehealingPotions(ref currentHP, arr);
            Console.Write($"So binh thuoc da su dung: {result}");
            Console.WriteLine($"\nLuong mau cuoi cung cua nhan vat: {currentHP}");

        }
    }
}