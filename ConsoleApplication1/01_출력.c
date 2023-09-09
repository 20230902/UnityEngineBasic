﻿



	//여러줄 주석 단축키


	//# <- 연산자 중 하나
	//include - 포함하다
	//stdio.h - c언어 표준 입출력 관련 헤더 파일
#include<stdio.h>


//main 이라는 이름의 함수를 정의
//main - 특별한 역할을 하는 예약된 명령어
//main은 프로그램의 진입점을 의미 (엔트리 포인트)
//main은 프로그램에 단 하나만 존재해야 함
// 프로그램의 시작지점을 main이라는 키워드로 설정하게끔 지정되어 있다


//void - 파란색상 -> 이미 만들어진 데이터 타입  의미 ( 공허한 , 비어있는)

//void <- 함수가 반환할 데이터의 타입    ----- 소수점, 문자 ,숫자의 데이터 타입을 반환할 수 있고 그 데이터 타입을 정할 수 있다.
// 즉 ()는 반환할 데이터 타입이 없다. 라는 뜻
//main <- 함수이름 (식별자)
// ()의 의미 - 수학에서 f(x)에서 ()는 변수를 대입하는 곳.
// f()의 함수에서는 모든 숫자를 대입할 수 있다. 즉 main()은 어떠한 외부 데이터를 받을지 정의하는 부분  *파라미터 라고 한다.
void main(){
	//printf 콘솔 출력 기능을 담당하는 함수
	//()안에 출력하고자 하는 문자열 작성
	// 대부분의 언어에서 문자열 데이터를 표현할 때 -> ""를 사용
	//;<- 세미클론 해당 라인의 코드가 끝났다는 것을 알리는 문법적 요소
	printf("Hello C world");
}

//코드를 프로그램으로 만드는 과정 -> 빌드
// 빌드과정 -> 컴파일, 링크 
// 컴파일이 끝나면 .obj라는 확장자가 만들어진다