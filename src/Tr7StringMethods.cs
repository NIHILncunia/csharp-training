using System;

namespace src {
  public class Tr7StringMethods {
    public void Training() {
      // 스트링 관련 메소드
      string word = "Nihil";
      string phoneNumber = "010-1234-5678";

      Console.WriteLine($"{word}의 길이: {word.Length}");
      // 문자열의 길이를 보여준다.
      Console.WriteLine($"{word}를 대문자로 만들기: {word.ToUpper()}");
      // 문자열을 대문자로 바꾼다.
      Console.WriteLine($"{word}를 소문자로 만들기: {word.ToLower()}");
      // 문자열을 소문자로 만든다.
      Console.WriteLine($"{phoneNumber} 에서 '-' 없애기: {phoneNumber.Replace("-", "")}");
      // 문자열에서 특정 값을 바꾼다.
      Console.WriteLine($"{word}의 앞에 글자를 우겨넣기: {word.Insert(0, "@")}");
      // 원하는 인덱스에 값을 추가한다.
      Console.WriteLine($"{phoneNumber}의 가운데 번호 가져오기: {phoneNumber.Substring(4, 4)}");
      // 문자열에서 원하는 부분을 가져올 수 있다. 시작할 지점과 그 지점으로부터 몇글자를 가져올 것인지를 정할 수 있다.
    }
  }
}
