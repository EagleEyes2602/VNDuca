using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(NEWS.Metadata))]
	public partial class NEWS
	{
		sealed class Metadata
		{
			[Display(Name ="NEWS_ID")]
			public int NEWS_ID { get; set; }
			[Display(Name ="NEWS_CATEGORY_ID")]
			public Nullable<int> NEWS_CATEGORY_ID { get; set; }
			[Display(Name ="NEWS_TITLE")]
			public string NEWS_TITLE { get; set; }
			[Display(Name ="NEWS_CONTENT")]
			public string NEWS_CONTENT { get; set; }
			[Display(Name ="NEWS_IMAGE")]
			public string NEWS_IMAGE { get; set; }
			[Display(Name ="NEWS_META_KEYWORD")]
			public string NEWS_META_KEYWORD { get; set; }
			[Display(Name ="NEWS_META_DESCRIPTION")]
			public string NEWS_META_DESCRIPTION { get; set; }
			[Display(Name ="NEWS_SLUG")]
			public string NEWS_SLUG { get; set; }
			[Display(Name ="NEWS_VIEW_COUNT")]
			public Nullable<int> NEWS_VIEW_COUNT { get; set; }
			[Display(Name ="NEWS_LIKE_COUNT")]
			public Nullable<int> NEWS_LIKE_COUNT { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="NEWS_NOTES")]
			public string NEWS_NOTES { get; set; }
			[Display(Name ="NEWS_STATUS")]
			public Nullable<byte> NEWS_STATUS { get; set; }
			[Display(Name ="NEWS_ISDELETE")]
			public Nullable<bool> NEWS_ISDELETE { get; set; }
			
			
		}
	}
}
