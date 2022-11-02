using System.Diagnostics;

namespace cs_form_1102_1;

public partial class Form1 : Form
{
    private MyClass myClass;

    public Form1()
    {
        InitializeComponent();
    }

    private void action_Click(object sender, EventArgs e)
    {
        Debug.WriteLine("DBG:こんにちは世界");
        System.Console.WriteLine("CON:こんにちは世界");

        myClass = new MyClass();
        myClass.Title = "こんにちは";
        myClass.Name = "山田 太郎";

        Debug.WriteLine($"DBG:{myClass.Title}");
        Debug.WriteLine($"DBG:{myClass.Name}");

    }


}
