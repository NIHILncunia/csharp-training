using System;

namespace src {
  public class Tr1Variable {
    public void Training() {
      // 변수에 대하여

      string var1 = "Nihil";
      // 문자열을 저장한다.

      char var6 = 'N';
      // 문자 하나를 저장한다.

      sbyte var9 = 127; // -128 ~ 127
      byte var10 = 255; // 0 ~ 255
      short var8 = 32767; // –32,768 ~ 32,767
      ushort var11 = 65535; // 0 ~ 65,535
      int var2 = 2147483647; // –2,147,483,648 ~ 2,147,483,647
      uint var12 = 4294967295; // 0 ~ 4,294,967,295
      long var7 = 9223372036854775807; // –9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
      ulong var13 = 18446744073709551615; // 0 ~ 18,446,744,073,709,551,615

      // 정수를 저장한다.
      // 순서대로 큰 수를 저장할 수 있다.

      Console.WriteLine("int의 최소값: {0} / 최대값: {1}", int.MinValue, int.MaxValue);
      // 정수, 실수 타입의 데이터의 최소값과 최대값을 알 수 있다.

      bool var3 = false;
      // 불리언 값을 저장한다.

      float var5 = 3.14F; // -3.4028235E+38 ~ 3.4028235E+38
      double var4 = 3.14; // -1.7976931348623157E+308 ~ 1.7976931348623157E+308
      decimal var15 = 3.14M; // -79228162514264337593543950335 ~ 79228162514264337593543950335
      // 실수를 저장한다.
      // float 타입은 똑같이 실수를 저장하지만 F를 붙여야한다.
      // demical 타입은 뒤에 M을 붙여야한다.

      Console.WriteLine(var1);
      Console.WriteLine(var6);

      Console.WriteLine(var9);
      Console.WriteLine(var10);
      Console.WriteLine(var8);
      Console.WriteLine(var11);
      Console.WriteLine(var2);
      Console.WriteLine(var12);
      Console.WriteLine(var7);
      Console.WriteLine(var13);

      Console.WriteLine(var3);

      Console.WriteLine(var5);
      Console.WriteLine(var4);
      Console.WriteLine(var15);

      // 데이터 타입 중 기본적으로 제공하는 타입은 프리미티브 타입이라고 한다.
      // 그렇지 않은 타입은 사용자 정의 타입이라고 한다.

      Console.WriteLine("string >> {0}", typeof(string).IsPrimitive);
      // 스트링은 프리미티브가 아니다!

      Console.WriteLine("int >> {0}", typeof(int).IsPrimitive);
      Console.WriteLine("bool >> {0}", typeof(bool).IsPrimitive);
      Console.WriteLine("double >> {0}", typeof(double).IsPrimitive);
      Console.WriteLine("float >> {0}", typeof(float).IsPrimitive);
      Console.WriteLine("long >> {0}", typeof(long).IsPrimitive);
      Console.WriteLine("short >> {0}", typeof(short).IsPrimitive);
      // 스트링을 제외하곤 다 프리미티브인 모양이다.

      const string var14 = "Don't change";
      // const를 붙이면 다시 바꿀 수 없는 상수가 된다.
      Console.WriteLine(var14);

      int? var16 = null;
      // int var17 = null;
      // 전자처럼 정수나 실수 타입에 ?를 붙이면 null을 넣을 수 있다.
      // 후자처럼 일반적인 형태에선 넣지 못한다.

      Console.WriteLine(var16);
      // 값이 null이기 때문에 아무것도 보이지 않는다.
    }
  }
}
