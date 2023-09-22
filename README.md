# Sparta_Bank 김 주형
## 기능 소개
### 입금 화면
- 원하는 금액 버튼 클릭해서 입금
- 원하는 금액 숫자 입력하고 버튼 클릭해서 입금
- 현금 잔액 부족 시 UI 팝업
- 뒤로 가기 버튼 클릭해서 입금 취소
### 출금 화면
- 원하는 금액 버튼 클릭해서 출금
- 원하는 금액 숫자 입력하고 버튼 클릭해서 출금
- 계좌 잔액 부족 시 UI 팝업
- 뒤로 가기 버튼 클릭해서 출금 취소
### 선택요구사항
- 통화 단위 적용
- 금액 입력 시 숫자만 입력
---
## 문제점
- ~~음수가 입력되는 문제~~
- 음수 입력 시 활성화되는 Wrong input UI Popup 추가
- ~~잔액이 0일 경우 표시가 안되는 문제~~
- int > string 형변환 방식 stirng format > ToString() 으로 변경

