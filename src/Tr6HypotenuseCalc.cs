using System;

namespace src {
  public class Tr6HypotenuseCalc {
    public void Training() {
      Console.WriteLine("변 1 : ");
      double a = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("변 2 : ");
      double b = Convert.ToDouble(Console.ReadLine());

      double c = Math.Sqrt((a * a) + (b * b));

      Console.WriteLine("빗변의 값은: " + c);
      // 간단하게 빗변의 길이를 계산하는 프로그램을 만들었다. 근데 수학은 모르겠다. 그냥 따라한거다.
    }
  }
}
