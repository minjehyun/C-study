using System;
using static System.Console;

namespace _01_Hello
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("사용법: Hello.exe <이름>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
/** 디버깅 하는 방법
 * cmd에서 해당 프로젝트 경로의 bin > Debug디렉토리로 간다.
 * > net프레임워크 디렉토리의 namespace를 실행하여 디버깅
 * ex) 
    01_Hello.exe
    01_Hello 제현
    ...
 **/