using System.Collections.Generic;

namespace GoFSample.GoF.AbstractFactory
{
    /// <summary>
    /// 抽象的な部品：LinkやTrayを集めたクラス
    /// </summary>
    public abstract class Tray : Item
    {
        protected List<Item> tray = new List<Item>();

        public Tray(string caption) : base(caption)
        {
        }

        public void Add(Item item)
        {
            tray.Add(item);
        }
    }
}