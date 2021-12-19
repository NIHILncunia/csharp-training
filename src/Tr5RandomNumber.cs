using System;

namespace src {
  public class Tr5RandomNumber {
    public void Training() {
      // 랜덤 숫자
      Random random = new Random();
      // 랜덤을 사용하려면 인스턴스를 만들어야한다.

      Console.Write("1부터 10까지의 랜덤: ");
      Console.WriteLine(random.Next(0, 10) + 1);
      // 0부터 10 이전까지의 숫자를 랜덤하게 보여준다. 거기에 1을 더하면 1에서 10까지가 된다.

      Console.Write("랜덤한 실수: ");
      Console.WriteLine(random.NextDouble());
      // 이번에는 실수를 보여준다. 이를 이용해서 랜덤한 주사위 프로그램을 만들 수도 있겠다.
    }
  }
}
