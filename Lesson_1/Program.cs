using System;
using System.Transactions;

namespace CauTrucLenhCoBan
{
    class Program
    {
        const int CURRENT_YEAR = 2026;
        const float PASSCODE = 5.0f;
        static void Main(string[] args)
        {
            string name;
            int birthYear;
            float diemLT, diemTH;
            Console.Write("Ten cua ban la gi? ");
            name = Console.ReadLine();
            Console.Write("Ban bao nhieu tuoi? ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly thuyet: ");
            diemLT = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thuc hanh: ");
            diemTH = float.Parse(Console.ReadLine());

            int age = CURRENT_YEAR - birthYear;
            float point = 0.3f * diemLT + 0.7f * diemTH;

            bool check = false;
            if(point > PASSCODE && diemTH >= 3.0 && diemTH >= 3.0)
            {
                check = true;
            }
            else
            {
                check = false;
            }

            Console.WriteLine($"Ho va ten: {name}");
            Console.WriteLine($"Tuoi: {age}");
            Console.WriteLine($"Diem tong ket: {point}");
            Console.WriteLine("Ket qua: " + check);
            
        }
    }
}