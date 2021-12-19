using System;

namespace src {
  public class Tr9LoopStatement {
    public void Training() {
      // 반복문 반복문에는 크게 두가지가 있다.

      int i = 1;
      // 1. 변수를 하나 만들어준다.
      while (i <= 5) {
        // 2. 반복의 조건을 설정한다.
        // 4. 다시 반복 조건을 살피고 false가 되면 반복을 멈춘다.
        Console.WriteLine($"while 반복문: {i}번째 반복");
        i++;
        // 3. 반복이 끝날 때 변수에 값을 더한다.
      }

      for (int j = 1; j <= 5; j++) {
        // while 반복문의 축약형이다. 이게 더 많이 사용된다.
        Console.WriteLine($"for 반복문: {j}번째 반복");
      }

      // 간단한 구구단 반복문을 만들어보자.
      for (int first = 1; first <= 9; first++) {
        // 반복문 안에 반복문 하나를 더 만든다.
        for (int second = 1; second <= 9; second++) {
          string result = Convert.ToString(first * second);
          // 결과를 문자열로 만들어두고,

          if (result.Length == 1) {
            result = " " + result;
            // 결과가 한글자일 때에는 앞에 공백을 넣어 가독성을 좋게 만든다.
          }

          Console.Write($"{second} × {first} = {result}   ");
          // 구구단을 나타낼 수 있도록 수식을 적어준다.
          // 줄바꿈이 안되게 하는 이유는 보기 좋게 만들기 위함이다.
        }
        Console.WriteLine("");
        // 각 루프의 마지막에는 첫번째 반복문이 실행되기 때문에 줄바꿈이 된다.
        // 이렇게 하면 총 9줄의 구구단이 탄생한다.
      }
    }
  }
}
