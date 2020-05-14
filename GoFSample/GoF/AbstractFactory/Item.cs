namespace GoFSample.GoF.AbstractFactory
{
    /// <summary>
    /// LinkとTrayを統一的に扱うクラス
    /// </summary>
    public abstract class Item
    {
        protected string caption;

        public Item(string caption)
        {
            this.caption = caption;
        }

        public abstract string MakeHTML();
    }
}