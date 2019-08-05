using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(PROJECTS.Metadata))]
	public partial class PROJECTS
	{
		sealed class Metadata
		{
			[Display(Name ="PROJECT_ID")]
			public int PROJECT_ID { get; set; }
			[Display(Name ="PROJECT_CATEGORY_ID")]
			public Nullable<int> PROJECT_CATEGORY_ID { get; set; }
			[Display(Name ="PROJECT_TITLE")]
			public string PROJECT_TITLE { get; set; }
			[Display(Name ="PROJECT_CONTENT")]
			public string PROJECT_CONTENT { get; set; }
			[Display(Name ="PROJECT_IMAGE")]
			public string PROJECT_IMAGE { get; set; }
			[Display(Name ="PROJECT_META_KEYWORD")]
			public string PROJECT_META_KEYWORD { get; set; }
			[Display(Name ="PROJECT_META_DESCRIPTION")]
			public string PROJECT_META_DESCRIPTION { get; set; }
			[Display(Name ="PROJECT_SLUG")]
			public string PROJECT_SLUG { get; set; }
			[Display(Name ="PROJECT_VIEW_COUNT")]
			public Nullable<int> PROJECT_VIEW_COUNT { get; set; }
			[Display(Name ="PROJECT_LIKE_COUNT")]
			public Nullable<int> PROJECT_LIKE_COUNT { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="PROJECT_NOTES")]
			public string PROJECT_NOTES { get; set; }
			[Display(Name ="PROJECT_STATUS")]
			public Nullable<byte> PROJECT_STATUS { get; set; }
			[Display(Name ="PROJECT_ISDELETE")]
			public Nullable<bool> PROJECT_ISDELETE { get; set; }
			
			
		}
	}
}
