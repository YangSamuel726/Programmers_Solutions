---
categories:
- "`조건`"
date: 2026-10-30
---

해결 문제 이름 : flag에 따라 다른 값 반환하기<br>
[[문제 보러가기]](https://school.programmers.co.kr/learn/courses/30/lessons/181933)

## [문제]

두 정수 a, b와 boolean 변수 flag가 매개변수로 주어질 때, flag가 true면 a + b를 false면 a - b를 return 하는 solution 함수를 작성해 주세요.

## [해결 코드]

```csharp
public int solution(int a, int b, bool flag)
{
    return flag == true ? a + b : a - b;
}
```

## [문제 해결 과정]

※ 문제를 해결하는데 어떤 사고 과정을 거쳤는지, 어떤 자료구조 알고리즘을 왜 선택했는지 등 구체적인 근거를 설명할 수 있어야 함

삼항 연산자로 flag를 확인하고 조건상태에 따라 다른 값을 반환하도록 하였다.

## [후기]

풀이시간 : 1분 5초
