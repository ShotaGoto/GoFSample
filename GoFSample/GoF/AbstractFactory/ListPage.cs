using System;
using System.Text;

namespace GoFSample.GoF.AbstractFactory
{
    public class ListPage : Page
    {
        public ListPage(string title) : base(title)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<html><head><title>" + title + "</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append("<h1>" + title + "</h1>\n");
            buffer.Append("<ul>\n");

            foreach (var itItem in content)
            {
                buffer.Append(itItem.MakeHTML());
            }

            buffer.Append("</ul>\n");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}