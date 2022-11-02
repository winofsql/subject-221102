# subject-221102

```cs
using System.Diagnostics;

namespace cs_form_1102_1;

public partial class Form1 : Form
{
    private MyClass myClass;
    private Bunka bunka;

    private InnerClassA ica;
    private InnerClassB icb;

    public Form1()
    {
        InitializeComponent();

        myClass = new MyClass();

        // bunka = new Bunka();
        // bunka.Date = "2022/11/02";

        bunka = new Bunka("2022 年 11 月 02 日 (木)");

        ica = new InnerClassA();
        icb = new InnerClassB();
    }


    // プロパティのテスト
    private void action2_Click(object sender, EventArgs e) {

        bunka.StartMessage("第二ボタン");
        bunka.StartMessage( bunka.Date );

        bunka.Yotei = "C# を勉強する";
        bunka.StartMessage( bunka.Yotei );

    }


    // メソッドのテスト
    private void action_Click(object sender, EventArgs e)
    {
        // MessageBox.Show("こんにちは世界","タイトル");

        // クラス( static ) メソッド
        Bunka.Message("こんにちは");
        // インスタンスメソッド
        bunka.StartMessage("インスタンスメソッド");

        int cnt = 1;

        for (int i = 0; i < 10; i++)
        {
            cnt = cnt + 5;
            cnt = cnt * 2;
        }

        // 整数を文字列に変換
        bunka.StartMessage(cnt + "");
        bunka.StartMessage($"{cnt}");
        bunka.StartMessage(string.Format("{0}", cnt));
        // メソッドをオーバーロードして、整数に対応
        bunka.StartMessage(cnt);

        Debug.WriteLine("DBG:こんにちは世界");
        System.Console.WriteLine("CON:こんにちは世界");

        myClass.Title = "こんにちは";
        myClass.Name = "山田 太郎";

        Debug.WriteLine($"DBG:{myClass.Title}");
        Debug.WriteLine($"DBG:{myClass.Name}");


    }

    private class InnerClassB
    {
        public InnerClassB()
        {
        }
    }
}

internal class InnerClassA
{
    public InnerClassA()
    {
    }
}
```
