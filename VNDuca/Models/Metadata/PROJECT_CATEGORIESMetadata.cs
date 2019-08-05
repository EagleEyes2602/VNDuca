using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(PROJECT_CATEGORIES.Metadata))]
	public partial class PROJECT_CATEGORIES
	{
		sealed class Metadata
		{
			[Display(Name ="PROJECT_CATEGORY_ID")]
			public int PROJECT_CATEGORY_ID { get; set; }
			[Display(Name ="PROJECT_CATEGORY_TITLE")]
			public string PROJECT_CATEGORY_TITLE { get; set; }
			[Display(Name ="PROJECT_CATEGORY_META_KEYWORD")]
			public string PROJECT_CATEGORY_META_KEYWORD { get; set; }
			[Display(Name ="PROJECT_CATEGORY_META_DESCRIPTION")]
			public string PROJECT_CATEGORY_META_DESCRIPTION { get; set; }
			[Display(Name ="PROJECT_CATEGORY_SLUG")]
			public string PROJECT_CATEGORY_SLUG { get; set; }
			[Display(Name ="PROJECT_CATEGORY_ORDER")]
			public Nullable<int> PROJECT_CATEGORY_ORDER { get; set; }
			[Display(Name ="PROJECT_CATEGORY_PARENTID")]
			public int PROJECT_CATEGORY_PARENTID { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="PROJECT_CATEGORY_NOTES")]
			public string PROJECT_CATEGORY_NOTES { get; set; }
			[Display(Name ="PROJECT_CATEGORY_STATUS")]
			public Nullable<byte> PROJECT_CATEGORY_STATUS { get; set; }
			[Display(Name ="PROJECT_ISDELETE")]
			public Nullable<bool> PROJECT_ISDELETE { get; set; }
			
			
		}
	}
}
