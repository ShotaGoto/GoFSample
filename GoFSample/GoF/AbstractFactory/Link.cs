namespace GoFSample.GoF.AbstractFactory
{
    /// <summary>
    /// 抽象的な部品：HTMLリンクを表すクラス
    /// </summary>
    public abstract class Link : Item
    {
        protected string url;

        public Link(string caption, string url) : base(caption)
        {
            this.url = url;
        }
    }
}