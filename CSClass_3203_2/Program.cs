using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3203_2
{
    internal class Program
    {

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
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

            // 구조체
            Point point;
            point.x = 10;
            point.y = 10;
            point = new Point(); // 기본 생성자가 만들어진다..
            point = new Point(100, 200); // new 키워드 : 생성자 호출 의미 (객체 생성이 아님)
            Console.WriteLine(point.x + "/" + point.y + "\n");

            // 구조체와 클래스의 차이점
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;
            pcB.x = 100;
            pcB.y = 200;
            Console.WriteLine(pcA.x + "/" + pcA.y);
            Console.WriteLine(pcB.x + "/" + pcB.y + "\n");

            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;
            psB.x = 100;
            psB.y = 200;
            Console.WriteLine(psA.x + "/" + psA.y);
            Console.WriteLine(psB.x + "/" + psB.y + "\n");

        }
        struct Point
        {
            public int x;
            public int y;
            public string testA; // 생성과 동시에 초기화 불가능
            public string testB;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "testA";
                this.testB = "testB";
            }

            public Point(int x, int y, string s)
            {
                this.x = x;
                this.y = y;
                this.testA = s;
                this.testB = s;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;

            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

        }
  
    }
}
