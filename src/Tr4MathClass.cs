using System;

namespace src {
  public class Tr4MathClass {
    public void Training() {
      // 수학 관련된 클래스와 메소드
      Console.WriteLine("원주율: {0}", Math.PI); // 원주율을 담은 프로퍼티

      int number = 3;
      int number2 = 2;
      Console.WriteLine("기본 값: {0} / 거듭제곱 횟수: {1} / 제곱한 값: {2}", number, number2, Math.Pow(number, number2));
      // 거듭제곱을 하는 메소드.
      Console.WriteLine("{0}의 제곱근: {1}", number, Math.Sqrt(number));
      // 제곱근을 구하는 메소드이다.

      double number3 = 75.14;
      double number4 = 24.67;
      int number5 = -45;
      double number6 = -12.58;
      int x = 45;
      int y = 24;

      Console.WriteLine("{0}의 절대값: {1}", number5, Math.Abs(number5));
      // 절대값을 구할 수 있다.
      Console.WriteLine("{0}의 소수점 제거: {1}", number3, Math.Floor(number3));
      Console.WriteLine("{0}의 소수점 제거: {1}", number6, Math.Floor(number6));
      // 소수점을 없앤 값을 정수로 뱉는다. 음수의 경우 -1이 더해진다.
      Console.WriteLine("{0}의 소수점 올림: {1}", number4, Math.Ceiling(number4));
      // 소수점을 없애는데, 값을 올린다. 기능은 같은데 자바스크립트와는 메소드 명이 다르다.
      Console.WriteLine("{0}의 반내림: {1}", number3, Math.Truncate(number3));
      Console.WriteLine("{0}의 반올림: {1}", number4, Math.Round(number4));
      // 반내림과 반올림.
      Console.WriteLine("{0}와 {1} 중에서 최대값: {2}", x, y, Math.Max(x, y));
      Console.WriteLine("{0}와 {1} 중에서 최소값: {2}", x, y, Math.Min(x, y));
      // 두가지의 숫자를 비교해서 최대값과 최소값을 구할 수 있다.

      // 이처럼 수학과 관련된 클래스가 바로 Math이다.
    }
  }
}
