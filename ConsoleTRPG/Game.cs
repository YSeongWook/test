using System;
using System.Threading.Tasks;

namespace ConsoleTRPG
{
    class Game
    {
        static async Task Main()
        {
            Console.WriteLine("게임 시작");
            Console.WriteLine();

            await PrintTextSmoothly("게임 진행 내용을 부드럽게 출력합니다.");

            Console.WriteLine();
            Console.WriteLine("게임 종료");
            Console.ReadLine(); // 프로그램 종료를 방지하기 위해 대기
        }

        static async Task PrintTextSmoothly(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c); // 한 글자씩 출력
                await Task.Delay(50); // 50밀리초 대기
            }
        }
    }
}