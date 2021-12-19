using System;

namespace src {
  public class Tr8IfStatement {
    public void Training() {
      // 조건문
      // 조건문은 아는 내용이기 때문에 그닥 얻을 것은 없다.

      Console.Write("숫자를 입력하세요: ");
      int number = Convert.ToInt32(Console.ReadLine());

      if (number < 11) {
        // 입력한 숫자가 11보다 작으면 이 부분이 출력된다.
        Console.WriteLine($"당신이 입력한 숫자는 {number}입니다. {number}는 11보다 작습니다.");
      } else {
        // 입력한 숫자가 11 이상이면 이 부분이 출력된다.
        Console.WriteLine($"당신이 입력한 숫자는 {number}입니다. {number}는 11 이상의 값입니다.");
      }
      // 조건문은 프로그램의 흐름을 결정하는 중요한 요소중의 하나이다.
      // 조건문은 다른 형태가 하나 더 있다.

      switch (number < 11) {
        // 여기에는 불리언 값을 뱉는 식을 넣어도 된다.
        // 불리언 값도 결국엔 분기가 가능하기 때문이다.
        case true:
          Console.WriteLine($"당신이 입력한 숫자는 {number}입니다. {number}는 11보다 작습니다.");
          break;
        default:
          Console.WriteLine($"당신이 입력한 숫자는 {number}입니다. {number}는 11 이상의 값입니다.");
          break;
      }
      // 스위치문은 불리언보다는 데이터에 따라 다른 케이스를 만들기 위해 존재한다.

      if (number < 5 && number > 2) {
        // number가 2보다 크고, 5보다는 작을 때 실행된다.
        Console.WriteLine($"{number}는 2보다 크고 5보다 작습니다.");
      } else if (number > 30 || number > 70) {
        Console.WriteLine($"{number}는 30보다 크거나 70보다 큽니다.");
      } else {
        Console.WriteLine("그 어디에도 해당되지 않습니다.");
      }
    }
  }
}
