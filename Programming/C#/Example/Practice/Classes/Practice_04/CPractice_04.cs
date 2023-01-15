#define P04_01
#define P04_02
#define P04_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Classes.Practice_04 {
	internal class CPractice_04 {
#if P04_01

#elif P04_02

#elif P04_03

#endif // #elif P04_01

		/** 초기화 */
		public static void Start(string[] args) {
#if P04_01
			/*
			 * 과제 4 - 1
			 * - 정수를 입력받아 해당 정수의 비트를 교환한다
			 * - 비트의 위치는 가장 오른쪽 비트부터 왼쪽 순으로 차례대로 0, 1, 2, ... 순으로 증가한다
			 * - 단, 비트를 교환하는 과정에서 다른 자료형 사용 불가 (즉, 정수만 사용 가능)
			 * 
			 * Ex)
			 * 정수 입력 : 15
			 * 
			 * =====> 교환 전 <=====
			 * 00000000 00000000 00000000 00001111
			 * 
			 * 비트 교환 위치 입력 : 0 8
			 * 
			 * =====> 교환 후 <=====
			 * 00000000 00000000 00000001 00001110
			 */
#elif P04_02
			/*
			 * 과제 4 - 2
			 * - 길이가 10 인 배열을 선언 후 0 ~ 13 사이의 값으로 랜덤하게 초기화한다
			 * - 인덱스 번호를 입력 받은 후 해당 인덱스 번호에 해당하는 요소가 1 자릿수 일 경우 -1 로 치환한다
			 * - 치환 과정은 인접한 요소가 2 자릿수가 아닐 때까지 반복한다
			 * 
			 * Ex)
			 * =====> 배열 요소 - 치환 전 <=====
			 * 0, 2, 10, 1, 3, 5, 8, 15, 10, 1
			 * 
			 * 치환 시작 위치 입력 : 4
			 * 
			 * =====> 배열 요소 - 치환 후 <=====
			 * 0, 2, 10, -1, -1, -1, -1, 15, 10, 1
			 */
#elif P04_03
			/*
			 * 과제 4 - 3
			 * - 길이가 100 인 배열을 선언 후 0 ~ 9 사이의 값으로 랜덤하게 초기화한다
			 * - 각 숫자의 개수를 출력한다
			 * 
			 * Ex)
			 * =====> 배열 요소 <=====
			 * 9, 1, 2, 0, 9, 0, 7, 5, 9, 3
			 * 
			 * =====> 결과 <=====
			 * [0] : 2 개
			 * [1] : 1 개
			 * [2] : 1 개
			 * 
			 * ... 이하 생략
			 */
#endif // #elif P04_01
		}
	}
}
