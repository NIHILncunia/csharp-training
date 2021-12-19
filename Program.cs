using System;
using src;

namespace csharp_training {
  class Program {
    static void Main(string[] args) {
      // 스태틱은 인스턴스와 관련이 없다. 클래스 자체에 작용하는 메소드나 변수를 만들어낸다.
      // 스태틱이 아닌 메소드는 스태틱인 메소드에서 호출할 수 없다.
      // 스태틱이 있으면 프로그램 자체의 자원을 이용하는 클래스의 메소드나 변수가 된다.
      // 스태틱이 없는 메소드나 변수는 인스턴스를 통해서 생성해야만 한다.
      // 이는 다른 말로 하면 스태틱이 있으면 인스턴스를 만들 필요가 없다는 의미가 된다.
      Tr10();
    }

    // static void Tr() {
    //   Console.WriteLine("--------------------");
    //   Console.WriteLine("트레이닝 ?: ???");
    //   Console.WriteLine("--------------------");
    // }
    static void Tr10() {
      Tr10NumberGame tr10 = new Tr10NumberGame();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 10: 숫자 맞추기 게임.");
      Console.WriteLine("--------------------");
      tr10.Training();
    }
    static void Tr9() {
      Tr9LoopStatement tr9 = new Tr9LoopStatement();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 9: 반복문");
      Console.WriteLine("--------------------");
      tr9.Training();
    }
    static void Tr8() {
      Tr8IfStatement tr8 = new Tr8IfStatement();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 8: 조건문 알아보기");
      Console.WriteLine("--------------------");
      tr8.Training();
    }
    static void Tr7() {
      Tr7StringMethods tr7 = new Tr7StringMethods();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 7: string 관련 메소드");
      Console.WriteLine("--------------------");
      tr7.Training();
    }
    static void Tr6() {
      Tr6HypotenuseCalc tr6 = new Tr6HypotenuseCalc();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 6: 빗변 값 구하기");
      Console.WriteLine("--------------------");
      tr6.Training();
    }
    static void Tr5() {
      Tr5RandomNumber tr5 = new Tr5RandomNumber();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 5: 랜덤 숫자.");
      Console.WriteLine("--------------------");
      tr5.Training();
    }
    static void Tr4() {
      Tr4MathClass tr4 = new Tr4MathClass();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 4: 수학 관련된 클래스.");
      Console.WriteLine("--------------------");
      tr4.Training();
    }
    static void Tr3() {
      Tr3Operator tr3 = new Tr3Operator();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 3: 연산자.");
      Console.WriteLine("--------------------");
      tr3.Training();
    }
    static void Tr2() {
      Tr2DataCasting tr2 = new Tr2DataCasting();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 2: 타입 변환.");
      Console.WriteLine("--------------------");
      tr2.Training();
    }
    static void Tr1() {
      Tr1Variable tr1 = new Tr1Variable();
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 1: 변수와 데이터 타입.");
      Console.WriteLine("--------------------");
      tr1.Training();
    }
    static void Tr0() {
      Tr0ConsoleOutput tr0 = new Tr0ConsoleOutput();
      // 이 클래스는 스태틱이 아니기 때문에 인스턴스를 통한 호출이 가능하다.
      // 만일 이 클래스를 스태틱 클래스로 만든다면 호출 방법이 달라진다.
      Console.WriteLine("--------------------");
      Console.WriteLine("트레이닝 0: 콘솔 출력 다루기.");
      Console.WriteLine("--------------------");
      tr0.Training();
    }
  }
}
