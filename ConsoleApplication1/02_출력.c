#include <stdio.h>

void main()
{
	//printf 함수에 제어 문자(이스케이프 시퀀스)를 사용할 수 있습니다.
	//제어 문자란?
	//출력의 제어 용도로 사용하기 위한 문자들을 의미

    //\n - 개행문자 (줄바꿈)
	printf("안녕\n하세요");
    //\t - 키보드에서 쓰이는 tab의 역할을 한다. 즉 출력 위치를 다음 탭으로 옮긴다.
	printf("\n안녕\t하세요\n");
	//\r - 캐리지 리턴 문자, 출력 커서 위치를 현재 라인의 시작 위치로 옮긴다.
	printf("Hello World\r안녕\n");
	//b - 백스페이스 문자, 출력 커서 위치를 현재 위치에서 한 칸 앞으로 옮긴다.
	printf("Hello World\bAA\n");
	//\a - 얼럿 문자 (시스템 환경음)
	printf("\a");

	//문자열 \를 출력하고 싶을 때
	// \\  <- \문자 출력됨
	// 그외
	// \" <- "문자출력
	// \'<- 문자 출력
	// %% <- 문자 출력
	printf("\\\n");
	printf("\"\n");
	printf("\'\n");
	printf("%%\n");

	
}