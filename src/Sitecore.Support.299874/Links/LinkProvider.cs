using Sitecore.Data.Items;
using Sitecore.Links;

namespace Sitecore.Support.Links
{
    public class LinkProvider : Sitecore.Links.LinkProvider
    {
        public override string GetItemUrl(Item item, UrlOptions options)
        {
            string itemUrl;
            options.SiteResolving = Sitecore.Configuration.Settings.Rendering.SiteResolving;
            itemUrl = base.GetItemUrl(item, options);
            return itemUrl;
        }
    }
}