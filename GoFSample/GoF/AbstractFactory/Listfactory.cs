namespace GoFSample.GoF.AbstractFactory
{
    public class ListFactory : Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Page CreatePage(string title)
        {
            return new ListPage(title);
        }

        public override Tray CreateTray(string caption)
        {
            return new ListTray(caption);
        }
    }
}