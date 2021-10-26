#region GlassMapperScCustom generated code

namespace GE.Foundation.Framework.App_Start
{
    using Glass.Mapper.Configuration;
    using Glass.Mapper.IoC;
    using Glass.Mapper.Maps;
    using Glass.Mapper.Sc;
    using Glass.Mapper.Sc.DataMappers;
    using Glass.Mapper.Sc.IoC;
    using Greenstreet.Foundation.Framework;
    using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

    public static class GlassMapperScCustom
    {
        public static IDependencyResolver CreateResolver()
        {
            var config = new Config();

            var dependencyResolver = new DependencyResolver(config);
            //ExtendedSitecoreFieldTypeMapper is created to avoid NullrefernceException if some ecommerce item, that is referred, doesn't exist yet
            //class registration is the same as for basic Glass classes
            
            return dependencyResolver;
        }

        public static IConfigurationLoader[] GlassLoaders()
        {
            /* USE THIS AREA TO ADD FLUENT CONFIGURATION LOADERS
                         * 
                         * If you are using Attribute Configuration or automapping/on-demand mapping you don't need to do anything!
                         * 
                         */

            var loader = GlassMapperConfiguration.GetConfigurationLoader();
            return new IConfigurationLoader[] { loader };
        }

        public static void PostLoad()
        {
            //Remove the comments to activate CodeFist
            /* CODE FIRST START
            var dbs = Sitecore.Configuration.Factory.GetDatabases();
            foreach (var db in dbs)
            {
                var provider = db.GetDataProviders().FirstOrDefault(x => x is GlassDataProvider) as GlassDataProvider;
                if (provider != null)
                {
                    using (new SecurityDisabler())
                    {
                        provider.Initialise(db);
                    }
                }
            }
             * CODE FIRST END
             */
        }

        public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
            // Add maps here
            // mapsConfigFactory.Add(() => new SeoMap());
        }
    }
}

#endregion