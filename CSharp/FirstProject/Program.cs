using System.Data;

namespace FirstProject
{
    // 철수 객체 할당할 때 필요한 메모리 : 4바이트(int age) + 4바이트(int money)
    class ChurSu {
        int age;
        int money;
    }

    // 영희 객체 할당할 때 필요한 메모리 : 4바이트(int) + 4바이트(float) = 8byte
    class YoungHye {
        float tail;

        // 전역변수 : 어느 곳에서도 접근가능한 변수
        // 클래스의 멤버도 전역변수임.
        // 지역변수 : "해당 클래스 내부에서만" 사용할 수 있는 변수
        public int age = 1;    // 변수 선언 부분에 어떤 값을 대입하겠다는 대입연산을 쓰면
                    // 해당 값을 초기 데이터로 쓰겠다는 명시(Data 영역에 할당)

        // 정적 : 동적의 반대 의미. 동적으로 할당할 수 없다 라는 뜻.
        // , 런타임중에 메모리에 추가적인 할당이 불가능하다.

        static char sex = '여';


        // 접근제한자(Access Modifier)
        // 외부에서의 멤버접근 가능여부를 제한하는 키워드
        // private - 이 클래스 말고 다른 클래스는 해당 멤버에 접근할 수 없다.
        // protected - 이 클래스를 상속받는 자식 클래스까지만 해당 멤버에 접근할 수 있다.
        // internal - Assembly(코드조각 exe, dll 등) 단위로만 해당 멤버에 접근할 수 있다.
        // public - 접근제한 없음


        // 클래스는 캡슐화를 컨셉으로 한 사용자정의자료형임
        // -> 접근제한자를 명시하지 않으면 외부 접근을 차단해야하는게 (private) 기본 컨셉


        // 클래스 생성자
        // 힙 영역에 클래스 타입의 객체를 할당
        // 멤버 변수의 초기화
        // 생선된 객체의 주소를 반환
        public YoungHye()
        {
        }

        // 클래스 소멸자
        // 해당 객체가 할당된 메모리영역을 시스템에 반환하는 함수
        // 가비지 컬렉터가 알아서 소멸시킬거기 때문에 직접 호출할 일은 없다
        ~YoungHye() { 
        }

        // void : 반환타입이 정해지지않음 (없음)
        public void SayMyAge() { 
            // todo -> 이름 출력하기
        }

        // 지역변수 : {} 내에서 정의되어 해당 연산 중에만 메모리에 할당되는 변수
        // 파라미터도 지역변수의 일종

        // 인스턴스 멤버 함수는 데이터를 참조할 목표 객체에대한 참조 파라미터가 생략되어있음.
        // -> this 키워드로 해당 목표객체 참조가 가능함
        // public bool addAge(YoungHye 영희객체<- 이게 생략되어있음, int age)
        public bool addAge(int age)
        {
            int expectedAge = this.age + age;
            /*  if 구문 : 
             *  if(논리형의 실행조건) {
             *      실행조건이 "참일 때", 실행될 내용
             *  }
             *  else {
             *      실행조건이 참이 "아닐 때", 실행될 내용
             *  }
            */

            if (expectedAge < 0)
            {
                // 만약 예상나이가 음수면 연산하지 않게함
                return false;
            }
            else
            {
                this.age = expectedAge;
                return true;
            }
        }
    }
    internal class Program
    {
        int a;
        uint b;
        short c;
        ushort d;
        long e;
        ulong f;
        char g;
        float h;
        double i;
        bool j;

        static void Main(string[] args)
        {
            // 문자열형 string은 클래스타입이기 때문에,
            // 힙 영역에 객체를 만들고 해당 참조를 사용한다.
            // 힙 영역에 할당하는 개체의 크기는 문자갯수x2byte + 1byte(null byte) <- 이건 문자열의 끝을 알리기위한 널바이트

            // .는 멤버 접근 연산자
            Console.WriteLine("Hello, World!"); // 문자열 상수 표기는 ""로

            // 값타입 vs 참조타입
            // 값 타입 : 데이터를 직접 메모리에 쓰고 읽는 타입
            // 참조 타입 : 특정 메모리 주소를 통해 간접적으로 해당 메모리에 데이터를 쓰고 읽는 타입
            // 포인터 타입 : 메모리 주소를 쓰고 읽는 타입 (C#에서는 unsafe 코드작성 외에 쓰지않음)
            int a = 1;

            // new : 동적할당키워드 (메모리를 동적으로 할당하겠다고 명시하는 키워드)
            // 객체 주소 참조 변수
            YoungHye younghye1 = new YoungHye(); // YoungHye객체 만들고 YoungHye가 있는 주소를 younghye1 이라는 변수에 저장
            YoungHye younghye2 = new YoungHye();
            Console.WriteLine(younghye1.addAge(1));
            Console.WriteLine(younghye1.age);
            Console.WriteLine(younghye2.age);

            string somethingToPrint = "영희의 나이는" + younghye1.age + "살 입니다.";
            Console.WriteLine(somethingToPrint);
            Console.WriteLine($"영희의 나이는 {younghye1.age}살 입니다.");

            int int1 = 1;
            long long1 = int1; // 암시적 캐스팅
            // 변수의 Promotion(승격)
            // 크기가 더 큰 자료형 레지스터로 작은 데이터를 읽었을 때
            // 읽는 과정에서 해당 데이터의 자료형이 바뀌는 효과

            long logn2 = 1;
            int int2 = (int)logn2; // 명시적 캐스팅(형변환)
        }
    }
}