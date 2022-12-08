using System;

namespace ConsoleGame
{
    internal class Program
    {
        // static void Main(string[ ] args)
        // 프로그램 실행되는 진입점
        // Main() 함수 안에서 실행해야 프로그램이 실행됩니다.
        static void Main(string[] args)
        {

            // Console.WriteLine(); <- 문자열을 출력하는 함수
            // Console.WriteLine에서 문자열을 연결하려면 +로 연결하면 됩니다.
            Console.WriteLine("안녕하세요." + " 김금수입니다.");
            Console.WriteLine("유니티를 배우고 싶습니다.");

            // Consile.Write() 함수는 개행을 하지않고, 출력하는 함수

            bool check = true;   // 1 byte
            byte bit = 250;      // 1 byte
            char alphabet = 'A'; // 1 byte 
            short data = 32767;  // 2 byte 
            ushort uData = 22;   // 2 byte 양수값만 표현할 수 있는 자료형
            int integer = 300;   // 4 byte
            uint uInteger = 200; // 4 byte 양수값만 표현할 수 있는 자료형
            long signal = 15;    // 4 byte

            float sign = 16.5f;  // 4 byte
            double count = 176.8;// 8 byte
            decimal value = 3058;// 16 byte  

            Console.Write("안녕하세요.");
            Console.Write(100);

        }
    }
}
