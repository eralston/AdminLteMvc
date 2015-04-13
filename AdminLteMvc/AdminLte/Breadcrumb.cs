using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Crumb
{
    public Crumb() { }
    public Crumb(string text)
    {
        Text = text;
    }
    public Crumb(string text, string link)
        : this(text)
    {
        this.Link = link;
    }
    public Crumb(string text, string link, string icon)
        : this(text)
    {
        this.Link = link;
        this.Icon = icon;
    }

    public string Text { get; set; }
    public bool HasText { get { return !string.IsNullOrEmpty(Text); } }

    public string Link { get; set; }
    public bool HasLink { get { return !string.IsNullOrEmpty(Link); } }

    public string Icon { get; set; }
    public bool HasIcon { get { return !string.IsNullOrEmpty(Icon); } }
}

public class Breadcrumb : List<Crumb>
{
    public Breadcrumb(IEnumerable<Crumb> crumbs) : base(crumbs) { }
}