namespace GoFSample.GoF.AbstractFactory
{
    public class Main
    {
        public Main()
        {
        }

        public string Execute()
        {
            Factory factory = Factory.GetFactory<ListFactory>();

            Link qiita = factory.CreateLink("Qiita", "https://qiita.com//");
            Link dot = factory.CreateLink("ドットインストール", "https://dotinstall.com/");

            Link yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            Link excite = factory.CreateLink("Excite", "http://www.excite.com/");
            Link google = factory.CreateLink("Google", "http://www.google.com/");

            Tray pgTray = factory.CreateTray("プログラミング");
            pgTray.Add(qiita);
            pgTray.Add(dot);

            Tray searchTray = factory.CreateTray("検索サイト");
            searchTray.Add(yahoo);
            searchTray.Add(excite);
            searchTray.Add(google);

            Page page = factory.CreatePage("お気に入り");
            page.Add(pgTray);
            page.Add(searchTray);
            page.Output();

            return page.path + "を作成しました。";
        }
    }
}