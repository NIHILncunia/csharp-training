using System;

namespace src {
  public class Tr0ConsoleOutput {
    public void Training() {
      Console.Write("Hey!");
      // 줄바꿈이 안된다.
      Console.WriteLine("Hello World!");
      // 자바스크립트의 콘솔로그 같은 기능.
      // 한 줄이기 때문에 자동으로 줄바꿈이 된다.

      Console.Write("줄\n바꿈\n");
      // 다른 프로그래밍 언어에도 있는 줄바꿈 기능이다.

      string name = "Nihil";
      int age = 29;

      Console.WriteLine("{0}님의 나이는 {1}세 입니다.", name, age);
      // 포맷 스트링이다. 중괄호 안에 숫자에 따라 순서대로 들어가게 된다.
      // 순서가 일치하지 않으면 값이 들어가지 않는다.

      Console.WriteLine(@"
        문자열의 앞에 @를 붙이면
        입력한대로 출력한다.
      ");

      Console.WriteLine($"{name}님의 나이는 {age}세 입니다.");
      // 달러를 붙이면 보간법을 이용할 수 있게 된다. 위와 결과가 같다.

      string message = string.Format("{0}님의 나이는 {1}세 입니다.", name, age);
      Console.WriteLine(message);
      // 포맷 스트링은 이렇게도 사용할 수 있다.

      Console.Write("사용자에게 값 받기: ");
      string input = Console.ReadLine(); // 기다렸다가 값을 입력받는다.
      Console.Write("입력 받은 키 숫자 코드 보여주기: ");
      int key = Console.Read(); // 사용자에게서 입력받은 키의 숫자 코드를 보여준다.
      Console.Write("입력받은 값을 보여주기: ");
      ConsoleKeyInfo keyInfo = Console.ReadKey(); // 사용자에게서 키를 입력받아서 가져온다. 대문자로 표기된다.

      Console.WriteLine("\n" + input);
      Console.WriteLine(key + " / " + Convert.ToChar(key));
      Console.WriteLine(keyInfo.Key);

      Console.Beep();
      // 삐 소리를 낸다.
    }
  }
}
