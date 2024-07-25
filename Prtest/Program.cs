using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prtest
{
    public class Prtest
    {

        // 클래스 마다 역할이 나뉘어져 있어 가독성이 좋다
        // 농장 클래스를 생성

        public class Farm
        {
            //접근 제한자를 활용해 접근 제한
            private int id;
            public string name;
            protected int time;
            protected int seed;
            protected int todayWater;

            public Farm(int id)
            {
                this.id = id;
                this.name = "기본 작물";
                this.time = 72;
                this.seed = 1;
                this.todayWater = 100;
            }
        }

        //농장 클래스를 상속받아 재사용
        public class Apple : Farm
        {
            public Apple(int id) : base(id)
            {
                name = "사과";
                time = 72;
                seed = 5;
                todayWater = 30;

                Console.Write($"{id}번째 작물의 이름은 {name}이고 성장까지 걸리는 시간은 {time},");
                Console.WriteLine($" 수확 후 씨앗의 흭득 수량은 {seed}, 하루에 필요한 물의 양은 {todayWater}L입니다.");
            }
        }

        public class Grape : Farm
        {
            public Grape(int id) : base(id)
            {
                name = "포도";

                time = 85;
                todayWater = 20;
                seed = 15;
                Console.Write($"{id}번째 작물의 이름은 {name}이고 성장까지 걸리는 시간은 {time},");
                Console.WriteLine($" 수확 후 씨앗의 흭득 수량은 {seed}, 하루에 필요한 물의 양은 {todayWater}L입니다.");
            }
        }

        public class Carrot : Farm
        {
            public Carrot(int id) : base(id)
            {
                name = "당근";
                time = 90;
                todayWater = 35;
                seed = 0;
                Console.Write($"{id}번째 작물의 이름은 {name}이고 성장까지 걸리는 시간은 {time},");
                Console.WriteLine($" 수확 후 씨앗의 흭득 수량은 {seed}, 하루에 필요한 물의 양은 {todayWater}L입니다.");
            }

            // 새로운 장비 클래스가 필요할 경우 기존 코드를 수정하지 않고 새로운 클래스를 만들어 확장 가능

            public class Orange : Farm
            {
                public Orange(int id) : base(id)
                {
                    name = "오렌지";
                    time = 85;
                    todayWater = 20;
                    seed = 2;
                    Console.Write($"{id}번째 작물의 이름은 {name}이고 성장까지 걸리는 시간은 {time},");
                    Console.WriteLine($" 수확 후 씨앗의 흭득 수량은 {seed}, 하루에 필요한 물의 양은 {todayWater}L입니다.");
                }
            }
        }






        public static void Main()
        {
            Apple apple = new Apple(1);
            Grape grape = new Grape(2);
            Carrot carrot = new Carrot(3);
        }
    }
}