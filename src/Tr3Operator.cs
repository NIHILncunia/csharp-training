using System;

namespace src {
  public class Tr3Operator {
    public void Training() {
      // 연산자

      Console.WriteLine(1 + 1);
      Console.WriteLine(2 - 1);
      Console.WriteLine(3 * 5);
      Console.WriteLine(5 / 1);
      Console.WriteLine(5 % 1);
      // 기본적인 사칙연산.
      // 숫자와 문자열을 더하면 문자열이 된다.
      // 이 부분은 다른 언어들이랑 다를 게 없다.

      int number = 0;
      Console.WriteLine("기본값: {0}", number);
      Console.WriteLine("더하고 출력: {0}", ++number);
      Console.WriteLine("출력한 다음에 더하기: {0}", number++);
      Console.WriteLine("최종값: {0}", number);
      // 값을 하나씩 미리 더하거나 호출한 후 더할 수 있다.

      // 논리 연산자
      // && 와 || 로 논리적인 연산을 할 수 있다.
      // &&는 and 이다. ||는 or 이다.
      Console.WriteLine(true || true); // 둘 중에 하나라도 트루라면 트루가 된다.
      Console.WriteLine(false && true); // 둘 중에 하나라도 펄스라면 펄스가 된다. 즉, 둘 다 트루여야 한다.
    }
  }
}
