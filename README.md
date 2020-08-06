# SILS (Service of Integrated Library Search)
	SILS는 통합도서관 검색을 위한 프로그램으로 제작되었으며, 
	책의 정보와 보유하고 있는 도서관목록에 대한 확인이 가능하다.

	도서관의 정보와 도서목록은 정보나루(https://www.data4library.kr/)의 
	API와 Excel자료를 기반으로 제작되었다.

	본 프로그램을 통해 정보나루 DB에 잘못 저장된 도서를 찾을 수 있으며,
	또한 오류가 있는 도서의 정보를 확인 할 수 있다.

## 기능
  ### 1. 도서 검색기능 및 상세 검색기능
  
![Search Form](Documents/SearchForm.png)

![Search Detail](Documents/SearchDetail.png)

![Book List](Documents/BookList.png)
  ### 2. 도서를 보유한 도서관 목록 확인기능

![Book Detail Impormation](Documents/BookDetailImpormation.png)
  ### 3. 상세정보를 통한 도서 정보확인 및 보유 도서관 사이트 이동

	



# 사용기술

## 언어

* C#

## FrameWork

* Entity Framework 6.0+
* .Net Framework 4.8
* Winform

## Third-Party Control

* DevExpress Winforms

## DataBase

* MS-SQL Server 2019

## API Development

* Postman

# DataBase Schema

![Data Base Schema](Documents/DataBaseSchema.png)



# Point of Interest

![Post Man](Documents/PostMan.png)
* 정보마루의 공공 API를 이용하여 도서관의 정보를 코드화 하여 DB에 입력하였다.
![A P I도서관코드](Documents/API도서관코드.png)



# Code Review

* 기존 API를 통해 도서 목록을 가져 오려 했으나 두가지 결정적인 문제가 발생 하였다.
  1. 일일 500건의 API 사용제한
  2. 잦은 쿼리사용으로 인한 느린 처리 속도     
  

* CSV파일을 이용하여 대체하려 했으나 파싱과정중 텍스트에 특수기호(,?,!,...)가 포함될 경우 문제가 발생하였다.
이 문제를 해결하고자, 다음과 같은 코드를 작성 하였으나, 잦은 쿼리사용으로 인한 느린 처리 속도가 문제가 되었다. 
![C S V](Documents/CSV.png)  

### 해결방안
 * Excel데이터를 




