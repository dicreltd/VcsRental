# レンタルショップ料金
ファイルに以下の形でレンタルした商品の種類とタイトルが保存されている。

Book,ONE PIECE
CD,LET IT GO
DVD,STAR WARSE
Book,Bible

画面にはレンタル日数入力ボタンがあり、これを押すと上記ファイルを読み込み、合計料金が表示される。

料金は以下の通り。

本：１日５０円
CD：１日３００円。２日目以降１００円。
DVD：７日まで300円。以降は１日１００円

以下のクラスを作成する。
## Itemクラス（抽象クラス）
属性：タイトル、種別（Book または CD または DVD）
コンストラクタ（タイトル、種別）
抽象メソッド　int GetPrice(int days)　日数に応じた料金を返す。

## Bookクラス（Itemを継承）
## CDクラス（Itemを継承）
## DVDクラス（Itemを継承）
## RentalFileクラス
static List<string> Read() データファイルを全行読み込み返す
## RentalListクラス
属性：ItemのList items
コンストラクタ：itemsをnewする
操作：
void Load() RentalFileクラスを使い、データをitemsに格納
int getTotal(int days) 料金の合計を返す。
