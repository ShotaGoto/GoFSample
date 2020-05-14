using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoFSample.GoF.AbstractFactory
{
    public abstract class Page
    {
        protected string title;
        protected List<Item> content = new List<Item>();
        public readonly string path;

        public Page(string title)
        {
            this.title = title;
            path = Path.Combine(Directory.GetCurrentDirectory(), title + ".html");
        }

    public void Add(Item item)
        {
            content.Add(item);
        }

        public void Output()
        {
            using (var sw = new StreamWriter(path, false, Encoding.GetEncoding("shift-jis")))
            {
                sw.Write(this.MakeHtml());
                sw.Close();
            }
        }

        public abstract string MakeHtml();
    }
}