namespace cs_form_1102_1
{
    // 文化の日 クラス
    internal class Bunka
    {
        private bool rootFlg = false;

        public Bunka()
        {
            this.rootFlg = true;
        }

        public Bunka(string Date)
        {
            this.Date = Date;
        }


        // 単純プロパティ
        public string Date { get; set; }

        private string myVar;
        public string Yotei
        {
            get {
                string work = myVar;
                work = $"{this.Date} : {work}";
                return work;
            }
            set {
                 myVar = value;
            }
        }

        // クラス用のスタティックメソッド
        internal static void Message(string v)
        {
            MessageBox.Show($"Bunka : {v}");
        }

        // インスタンス用のメソッド
        internal void StartMessage(string v)
        {
            MessageBox.Show($"string value : {v}");
        }

        internal void StartMessage(int v)
        {
            MessageBox.Show($"int value : {v}");
        }

    }
}