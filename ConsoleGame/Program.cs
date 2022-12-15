using System;
using System.Text;

namespace ConsoleGame
{
    class Unit
    {
        private int data; // <- data 어디에서나 접근이 가능하겠죠?   
    
        public int Data
        {
            set
            {   // data <- (value)Data 프로퍼티에서 받은 값
                if (value > 18)
                {
                    Console.WriteLine("Erorr Value");
                    return;
                }

                data = value;
            }
            get
            {
                return data;
            }
        }

        // 자동구현 프로퍼티
        // 자동 구현 프로퍼티는 선언을 했을 때 컴파일러가 자동으로
        // private 필드를 생성합니다.
        public int Health
        {
            set;
            get;
        } = 200;

        // 프로퍼티는 get만 사용해서 선언할 수 있습니다.
        public int Attack
        {
            get;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 프로퍼티
            /*
            Unit factory = new Unit();

            factory.Data = 100;

            Console.WriteLine("Unit의 Health 값 : " + factory.Health);
            Console.WriteLine("Unit의 data 값 : " + factory.Data);
            */
            #endregion

            // StringBuilder
            StringBuilder score = new StringBuilder("100");

            Console.WriteLine("score 변수의 값 : " + score);

            // Replace
            // 첫번째 매개변수에 있는 문자열을 두번째 매개변수에 있는
            // 문자열로 변경하는 메소드입니다.
            score.Replace("100", "200");

            Console.WriteLine("score 변수의 값 : " + score);

            // Append
            score.Append("의 값을 가지고 있습니다.");

            Console.WriteLine("score 변수의 값 : " + score);
            
            // 가변 -> 객체가 인스턴스된 후에 변할 수 있는 객체
            // 불변 -> 객체가 인스턴스된 후에 변할 수 없는 객체

            string name = "KIM";
            name = "LEE";


        }
    }
}
