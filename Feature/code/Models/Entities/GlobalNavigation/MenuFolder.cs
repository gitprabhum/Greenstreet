namespace Greenstreet.Feature.Navigation.Models.Entities.GlobalNavigation
{
    using System.Collections.Generic;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using GreenStreet.Feature.Navigation.ContentTypes;

    public partial class MenuFolder
    {
        public const string MenuGroupQuery = "./*[@@templateid='{" + IMenuGroupConstants.TemplateIdString + "}']";

        [SitecoreQuery(MenuGroupQuery, IsRelative = true)]
        public virtual IEnumerable<MenuGroup> MenuGroups { get; set; }
    }
}
