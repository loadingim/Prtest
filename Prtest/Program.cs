using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prtest
{
    public abstract class Prtest
    {

        //클래스 마다 역할이 나뉘어져 있어 가독성이 좋다 <<- 가독성 관련
        // 농장 클래스를 생성

        public class Farm
        {

            public string name;
            protected int time;
            protected int seed;
            protected int todayWater;

            public Farm()
            {
                this.name = "정체불명의 작물";
                this.time = 72;
                this.seed = 1;
                this.todayWater = 100;
            }
        }

        //농장 클래스를 상속받아 재사용 << - 재사용성에 관련
        public class Grapeple : Farm
        {
            public Grapeple()
            {
                name = "사과";
                time = 72;
                seed = 5;
                todayWater = 30;
            }
        }

        public class Grape : Farm
        {
            public Grape()
            {
                name = "포도";

                time = 85;
                todayWater = 20;
                seed = 15;
            }
        }

        public class Carrot : Farm
        {
            public Carrot()
            {
                name = "당근";
                time = 90;
                todayWater = 35;
                seed = 0;
            }
        }

        // 새로운 장비 클래스가 필요할 경우 기존 코드를 수정하지 않고 새로운 클래스를 만들어 확장 가능 << - 유지보수 관련

        public static void Main()
        {

        }
    }
}
