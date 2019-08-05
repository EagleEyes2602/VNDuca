using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(LEADERSHIP_CATEGORIES.Metadata))]
	public partial class LEADERSHIP_CATEGORIES
	{
		sealed class Metadata
		{
			[Display(Name ="LEADERSHIP_CATEGORY_ID")]
			public int LEADERSHIP_CATEGORY_ID { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_NAME")]
			public string LEADERSHIP_CATEGORY_NAME { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_ORDER")]
			public Nullable<int> LEADERSHIP_CATEGORY_ORDER { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_NOTES")]
			public string LEADERSHIP_CATEGORY_NOTES { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_STATUS")]
			public Nullable<byte> LEADERSHIP_CATEGORY_STATUS { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_ISDELETE")]
			public Nullable<bool> LEADERSHIP_CATEGORY_ISDELETE { get; set; }
			
			
		}
	}
}
