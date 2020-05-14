namespace GoFSample.GoF.AbstractFactory
{
    /// <summary>
    /// 関連する部品を組み合わせて製品を作る
    /// </summary>
    public abstract class Factory
    {
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title);

        public static Factory GetFactory<T>() where T : Factory, new()
        {
            return new T();
        }
    }
}