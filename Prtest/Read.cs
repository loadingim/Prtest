
안녕하세요 10조 객체지향 프로그래밍의 설명 발표를 맡게 된 ㅇㅇㅇ 입니다.

우선 객체지향 프로그래밍 기법이란
객체를 기반으로 프로그램을 설계하는 기법이고, 객체란 속성과 기능을 가지는 프로그램 단위입니다.
객체지향 프로그래밍 기법의 목적은 코드의 재사용성과 유지보수성을 높이는 것입니다.

객체지향에는 추상화 상속 다형성 캡슐화 대표적인 4가지의 개념이 있습니다
이번 발표에 다루어볼 개념은 상속과 코드의 재사용성 그리고 유지보수입니다.

이해를 돕기 위해 작성한 농장 작물 관리 코드를 보여드리겠습니다.
//        public class Farm
//        {
//
//            public string name;
//            protected int time;
//            protected int seed;
//            protected int todayWater;
//
//            public Farm()
//            {
//                this.name = "정체불명의 작물";
//                this.time = 72;
//                this.seed = 1;
//                this.todayWater = 100;
//            }
//        }
Farm클래스는 기본 작물의 속성을 생성합니다.
이 클래스는 작물의 이름, 재배 시간, 씨앗의 수, 하루 물 소비량을 속성으로 가지게됩니다.


//        //농장 클래스를 상속받아 재사용 << - 재사용성에 관련
//        public class Grapeple : Farm
//        {
//            public Grapeple()
//            {
//                name = "사과";
//                time = 72;
//                seed = 5;
//                todayWater = 30;
//            }
//        }
//
//        public class Grape : Farm
//        {
//            public Grape()
//            {
//                name = "포도";
//
//                time = 85;
//                todayWater = 20;
//                seed = 15;
//            }
//        }
//
//        public class Carrot : Farm
//        {
//            public Carrot()
//            {
//                name = "당근";
//                time = 90;
//                todayWater = 35;
//                seed = 0;
//            }
//        }

Apple, Grape, Carrot 클래스는 Farm클래스를 상속받고 자신의 값을 입력합니다.
이로써 중복 코드를 줄이고 클래스를 재사용 할 수 있습니다.

//
//        // 새로운 장비 클래스가 필요할 경우 기존 코드를 수정하지 않고 새로운 클래스를 만들어 확장 가능 << - 유지보수 관련