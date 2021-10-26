namespace Greenstreet.Foundation.Framework
{
    using Glass.Mapper.Configuration.Attributes;
    using System.Reflection;

    public static class GlassMapperConfiguration
    {
        public static AttributeConfigurationLoader GetConfigurationLoader()
        {
            return new AttributeConfigurationLoader(Assembly.GetExecutingAssembly().GetName().Name);
        }
    }
}