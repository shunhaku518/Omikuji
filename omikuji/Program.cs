//おみくじ
string[] omikuji = new string[5];
omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3凶";
omikuji[4] = "4大凶";


//この書き方でもOK
//string[] omikuji = { "0大吉", "1中吉", "2吉", "3凶", "4大凶" };

//各おみくじを何回ひいたかを格納する配列
int[] count = new int[5];

//Randomクラスを実体化して変数randが機能を参照できる
Random rand = new Random();

//for (int i = 0; i < 100; i++)
//{
//    int result = rand.Next(0, 5); //0以上5未満のランダムを取得して変数resultに代入

//    //result番目の値を配列からひっぱってきてコンソールに出す
//    Console.WriteLine(omikuji[result]);

//    count[result]++; //resultで引いた結果の番号をカウント
//}

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine("今" + i + "回目の繰り返しです");
//}

//大吉をひくまで繰り返すループ
bool end = false; //終わりフラグ
while (!end) //endはfalseであるかどうか　→　成立していれば繰り返し
{
    int result = rand.Next(0, 5);//0以上5未満のランダムを取得して変数resultに代入
    //result番目の値を配列からひっぱってきてコンソールに出す
    Console.WriteLine(omikuji[result]);
    count[result]++;//resultで引いた結果の番号をカウント

    //もし大吉を引いていたら変数endはtrue
    if (result == 0)
    {
        end = true;
    }
}


//配列countの結果を順番に発表
for (int i = 0; i < count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回ひきました");
}


////論理型
//bool end = false; //終わりフラグ

////いつ終わりがくるかわからないループ
//while (end == false) //終わりのフラグがこない間は繰り返す
//{
//    int dice = rand.Next(1, 7); //1～6のランダム
//    if(dice == 1)
//    {
//        end = true;
//    }
//    Console.WriteLine("つづく");
//}


