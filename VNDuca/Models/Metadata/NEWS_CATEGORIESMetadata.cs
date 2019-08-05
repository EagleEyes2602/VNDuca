using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(NEWS_CATEGORIES.Metadata))]
	public partial class NEWS_CATEGORIES
	{
		sealed class Metadata
		{
			[Display(Name ="NEWS_CATEGORY_ID")]
			public int NEWS_CATEGORY_ID { get; set; }
			[Display(Name ="NEWS_CATEGORY_TITLE")]
			public string NEWS_CATEGORY_TITLE { get; set; }
			[Display(Name ="NEWS_CATEGORY_META_KEYWORD")]
			public string NEWS_CATEGORY_META_KEYWORD { get; set; }
			[Display(Name ="NEWS_CATEGORY_META_DESCRIPTION")]
			public string NEWS_CATEGORY_META_DESCRIPTION { get; set; }
			[Display(Name ="NEWS_CATEGORY_SLUG")]
			public string NEWS_CATEGORY_SLUG { get; set; }
			[Display(Name ="NEWS_CATEGORY_ORDER")]
			public Nullable<int> NEWS_CATEGORY_ORDER { get; set; }
			[Display(Name ="NEWS_CATEGORY_PARENTID")]
			public int NEWS_CATEGORY_PARENTID { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="NEWS_CATEGORY_NOTES")]
			public string NEWS_CATEGORY_NOTES { get; set; }
			[Display(Name ="NEWS_CATEGORY_STATUS")]
			public Nullable<byte> NEWS_CATEGORY_STATUS { get; set; }
			[Display(Name ="NEWS_ISDELETE")]
			public Nullable<bool> NEWS_ISDELETE { get; set; }
			
			
		}
	}
}
