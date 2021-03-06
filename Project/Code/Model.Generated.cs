

#pragma warning disable 1591
#pragma warning disable 0108

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Glass.Mapper;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Globalization;

namespace Greenstreet.Project.Website.Models
{
	public partial interface IGlassBase
	{	
		Item Parent { get; }

        IEnumerable<Item> Children { get; }
	}

	[ExcludeFromCodeCoverage]
	public abstract partial class GlassBase : IGlassBase
	{
		[SitecoreId]
        public virtual Guid Id { get; private set; }

        [SitecoreParent]
        public virtual Item Parent { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual GlassLazy<Language> LazyLanguage { get; private set; }

        public virtual Language Language { get { return this.LazyLanguage.Value; } }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual GlassLazy<int> LazyVersion { get; private set; }

        public virtual int Version { get { return this.LazyVersion.Value; } }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual GlassLazy<string> LazyUrl { get; private set; }

        public virtual string Url { get { return this.LazyUrl.Value; } }    

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; private set;}

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; private set; }    

        [SitecoreInfo(SitecoreInfoType.Path)]
        public virtual GlassLazy<string> LazyPath { get; private set; }

        public virtual string Path { get { return this.LazyPath.Value; } }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public virtual GlassLazy<string> LazyFullPath { get; private set; }        

        public virtual string FullPath { get { return this.LazyFullPath.Value; } }    

        [SitecoreItem]
        public virtual Item Item { get; private set; }

        [SitecoreChildren]
        public virtual IEnumerable<Item> Children { get; private set; }

        [SitecoreInfo(SitecoreInfoType.BaseTemplateIds)]
        public virtual GlassLazy<IEnumerable<Guid>> LazyBaseTemplateIds { get; private set; }

        public virtual IEnumerable<Guid> BaseTemplateIds { get { return this.LazyBaseTemplateIds.Value; } }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid ItemTemplateId { get; private set; }

        public GlassBase() {}

        public GlassBase(Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Returns a bool indicating if the item inherits the given template
        /// </summary>
        /// <param name="templateGuid">Template Guid</param>
        /// <returns>True if the item is or inherits from a template</returns>
        public bool InheritsTemplate(Guid templateGuid)
        {
            return this.BaseTemplateIds.Contains(templateGuid) || this.ItemTemplateId.Equals(templateGuid);
        }

        /// <summary>
        /// Returns a bool indicating if the item inherits the given template
        /// </summary>
        /// <param name="templateId">Template ID</param>
        /// <returns>True if the item is or inherits from a template</returns>
        public bool InheritsTemplate(ID templateId)
        {
            return this.BaseTemplateIds.Contains(templateId.Guid) || this.ItemTemplateId.Equals(templateId.Guid);
        }
	}

    [SitecoreType(TemplateId = "{962B53C4-F93B-4DF9-9821-415C867B8903}")]
    [ExcludeFromCodeCoverage]
    public class MediaFile : GlassBase 
    {
        [SitecoreInfo(SitecoreInfoType.MediaUrl)]
        public new string Url { get; private set;}
   
        [SitecoreField("Attachment")]
        public virtual Stream File { get; set; }
        
        [SitecoreField("File Path")]
        public virtual string FilePath { get; set; }

        [SitecoreField("Mime Type")]
        public virtual string MimeType { get; set; }

        [SitecoreField("Title")]
        public virtual string Title { get; set; }

        [SitecoreField("Format")]
        public virtual string Format { get; set; }

        [SitecoreField("Description")]
        public virtual string Description { get; set; }
        
        [SitecoreField("Keywords")]
        public virtual string Keywords { get; set; }

        [SitecoreField("Extension")]
        public virtual string Extension { get; set; }
    }
    
    [SitecoreType(TemplateId = "{6D1CD897-1936-4A3A-A511-289A94C2A7B1}")]
    [ExcludeFromCodeCoverage]
    public class DictionaryEntry : GlassBase 
    {
        [SitecoreField("Key")]
        public virtual string Key { get; private set;}
   
        [SitecoreField("Phrase")]
        public virtual string Phrase { get; set; }
    }
}

