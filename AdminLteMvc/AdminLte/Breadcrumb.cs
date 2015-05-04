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
    /// <summary>
    /// Default constructor that makes an empty crumb element
    /// </summary>
    public Crumb() { }

    /// <summary>
    /// Constructor that makes a crumb element with the given text as title
    /// </summary>
    /// <param name="text"></param>
    public Crumb(string text)
    {
        Text = text;
    }

    /// <summary>
    /// Constructor that makes a crumb element with the given text as title and other text as link
    /// </summary>
    /// <param name="text"></param>
    /// <param name="link"></param>
    public Crumb(string text, string link)
        : this(text)
    {
        this.Link = link;
    }
    
    /// <summary>
    /// Constructor that builds a crumb element with title, link, and icon class values
    /// </summary>
    /// <param name="text"></param>
    /// <param name="link"></param>
    /// <param name="icon"></param>
    public Crumb(string text, string link, string icon)
        : this(text)
    {
        this.Link = link;
        this.Icon = icon;
    }

    /// <summary>
    /// Gets or sets the Text displayed as the value of this crumb
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets true if the Text property has anything in it; otherwise, returns false
    /// </summary>
    public bool HasText { get { return !string.IsNullOrEmpty(Text); } }

    /// <summary>
    /// Gets or sets the Link value for this crumb element
    /// This is usually a value from Url.Action for the crumb's action
    /// </summary>
    public string Link { get; set; }

    /// <summary>
    /// Gets true if the link text has a value; otherwise, returns false
    /// </summary>
    public bool HasLink { get { return !string.IsNullOrEmpty(Link); } }

    /// <summary>
    /// Gets or sets the icon class for this crumb element
    /// This is usually a font awesome class like "fa-check"
    /// </summary>
    public string Icon { get; set; }

    /// <summary>
    /// Gets true if there icon property has a value in it; otherwise, returns false
    /// </summary>
    public bool HasIcon { get { return !string.IsNullOrEmpty(Icon); } }
}

/// <summary>
/// A full breadcrumb is just a list of crumbs that can then be translated into an AdminLTE breadcrumb using cshtml
/// </summary>
public class Breadcrumb : List<Crumb>
{
    /// <summary>
    /// Constructor that creates a new Breadcrumb collection for the given enumerable of crumbs
    /// </summary>
    /// <param name="crumbs"></param>
    public Breadcrumb(IEnumerable<Crumb> crumbs) : base(crumbs) { }
}