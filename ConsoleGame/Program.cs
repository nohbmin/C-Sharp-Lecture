using System;

namespace ConsoleGame
{
    class Monster
    {
        // 기본 접근 지정자
        // 필드에서 private로 설정됩니다.
        public int attack;
        public string name;

        public void Defense()
        {
            Console.WriteLine("방어");
        }
    }
    
    internal class Program
    {
        // static void Main(string[ ] args)
        // 프로그램 실행되는 진입점
        // Main() 함수 안에서 실행해야 프로그램이 실행됩니다.
        static void Main(string[] args)
        {
            // 값 타입
            // 변수의 선언과 동시에 값을 할당할 수 있으며,
            // 스택 메모리에 생성됩니다.

            // 참조 타입
            // new 키워드를 사용해서 객체를 초기화한 후 
            // 힙에 할당된 메모리를 스택에서 참조하여 사용하는 타입입니다.

            int value = 10;
            value = 20;

            string name = "kimgeumsoo";
            int [] array = new int[5];

            name = "kang";

            Monster monster = new Monster();
            monster.attack = 10;
            monster.name = "Goblin";
            monster.Defense();


            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40; 
            array[4] = 50;

            Console.WriteLine(name);
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
        }
    }
}
