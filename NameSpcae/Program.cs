﻿namespace NameSpcae
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 반복문
            /*
            // foreach

            int[] item = new int[5];

            // for
            for(int i = 0; i < 5; i++)
            {
                item[i] = i;
            }

            // 배열, 리스트 
            // 고객 정보를 그대로 읽어올 때 사용하면 됩니다.
            foreach(int element in item)
            {
                // foreach문 내부에서는 
                // 값을 변경할 수 없습니다.
                // element = 100;

                Console.WriteLine(element);
            }
            */
            #endregion

            #region 이름 공간(name space)
            /*
            // 내부 식별자에 범위를 제공해주는 선언적인
            // 영역입니다.

            Data data = new Data();
            data.value = 100;

            Console.WriteLine("OtherGame의 value : " + data.value);
            // 같은 이름의 변수를 동시에 선언했기
            // 때문에 컴파일 에러가 발생합니다.
            int value = 10;
            Console.WriteLine("ConsoleGame의 value : " + value);
            */
            #endregion
        }
    }
}