using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This class represents an individual piece of the breadcrumb at the top of the main content area of the page
/// Instances of this object must carry a text value and may optionally also carry a link and icon class
/// If the text value or icon are null or empty, then they are ignored
/// Instances of this class should be captured in the Breadcrumb collection class
/// </summary>
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

/// <summary>
/// A full breadcrumb is just a list of crumbs that can then be translated into an AdminLTE breadcrumb using cshtml
/// </summary>
public class Breadcrumb : List<Crumb>
{
    public Breadcrumb(IEnumerable<Crumb> crumbs) : base(crumbs) { }
}