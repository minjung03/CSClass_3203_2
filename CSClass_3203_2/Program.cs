﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3203_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 제너릭
            Wanted<string> wantedString = new Wanted<string>("String");
            Wanted<int> wantedInt = new Wanted<int>(533);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);

            // 인덱서
            Products p = new Products();
            Console.WriteLine("\n오늘의 점심 메뉴는 " + p[2] + "입니다.");
            p[2] = "단무지";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.\n");

            // out 키워드
            Console.Write("숫자 입력 : ");
            bool result = int.TryParse(Console.ReadLine(), out int output);
            if (result)
            {
                Console.WriteLine("입력한 숫자 : " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }
            Console.WriteLine();

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표 ("+x+","+y+")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표 (" + x + "," + y + ")\n");
        }
        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
    }
}
