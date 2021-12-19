using System;

namespace src {
  public class Tr10NumberGame {
    // 사용자 입력 숫자
    public void Training() {
      Random random = new Random();
      int randomNumber; // 답이 될 숫자
      int playerNumber = 0; // 플레이어가 입력할 값
      bool playAgain = true; // 게임 반복을 위한 변수
      int tries; // 도전횟수
      string answer; // 다시 플레이할 것인가를 정하는 변수

      while (playAgain) {
        // 맞추기 전까지는 게임이 계속해서 반복된다.
        randomNumber = random.Next(1, 101);
        tries = 0;

        while (playerNumber != randomNumber) {
          Console.Write("숫자를 맞춰보세요! (1 ~ 100) => ");
          playerNumber = Convert.ToInt32(Console.ReadLine());
          // 사용자 입력 숫자를 입력한다.

          if (playerNumber > randomNumber) {
            tries += 1;
            Console.WriteLine($"정답은 {playerNumber}보다 작습니다. [시도 횟수 => {tries}]\n");
          } else if (playerNumber < randomNumber) {
            tries += 1;
            Console.WriteLine($"정답은 {playerNumber}보다 큽니다. [시도 횟수 => {tries}]\n");
          }
        }

        tries += 1;
        Console.WriteLine($"숫자를 맞췄습니다! 정답: {randomNumber} [시도 횟수 => {tries}]\n");
        Console.Write("새로운 게임을 시작할까요? (Y/N) => ");
        answer = Console.ReadLine();

        if (answer == "Y") {
          playAgain = true;
          Console.WriteLine("새로운 게임이 시작되었습니다!\n");
        } else {
          playAgain = false;
          Console.WriteLine("게임이 종료되었습니다!\n");
        }
      }
    }
  }
}
