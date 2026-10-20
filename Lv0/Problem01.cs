using System;

// 작성자 : 양사무엘
// 작성일자 : 2026-10-20
// 해결 문제 이름 : a와 b 출력하기
// 문제 링크(Ctrl + 좌클릭) : https://school.programmers.co.kr/learn/courses/30/lessons/181951

class Problem01
{
    static void Main()
    {
        String[] s;
        s = Console.ReadLine()!.Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}

// [문제]
// 정수 a와 b가 주어집니다. 각 수를 입력받아 입출력 예와 같은 형식으로 출력하는 코드를 작성해 보세요.

// [문제 해결 과정]
// ※ 문제를 해결하는데 어떤 사고 과정을 거쳤는지, 어떤 자료구조 알고리즘을 왜 선택했는지 등 구체적인 근거를 설명할 수 있어야 함
// 1. 입력을 읽어서 공백으로 구분한 문자열 배열로 저장
// 2. 파싱으로 문자열 배열의 값을 a와 b에 할당
// 3. 형식에 맞게 각각 출력

// [후기]
// 특별한 어려움은 없었다. 읽은 string배열을 바로 int배열로 Array.ConvertAll을 통해 바꾸고 그 값을 바로 출력으로 이을 수도 있었겠다.
// 두가지 방식을 비교해서 어떤 것이 더 성능이 좋은지는 두가지 방식을 공부해보고 그 작동원리를 파악해 보아야 할 것이다.
// C#을 공부할 때 같이 알아보자. 
// 가독성은 지금 버전이 훨 좋은 것 같다.