using System;

namespace src {
  public class Tr2DataCasting {
    public void Training() {
      // 데이터 타입 변환
      string var1 = "1";
      int var2 = Convert.ToInt32(var1);
      // 이렇게 형변환을 할 수 있다.

      double var3 = 3.14;
      string var4 = Convert.ToString(var3);

      Console.WriteLine($"{var1}, {var1.GetType()}");
      Console.WriteLine($"{var2}, {var2.GetType()}");
      Console.WriteLine($"{var3}, {var3.GetType()}");
      Console.WriteLine($"{var4}, {var4.GetType()}");
      // 타입을 확인하는 메소드는 GetType()이다.
    }
  }
}
