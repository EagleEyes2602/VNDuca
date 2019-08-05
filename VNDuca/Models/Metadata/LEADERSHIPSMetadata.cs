using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(LEADERSHIPS.Metadata))]
	public partial class LEADERSHIPS
	{
		sealed class Metadata
		{
			[Display(Name ="LEADERSHIP_ID")]
			public int LEADERSHIP_ID { get; set; }
			[Display(Name ="LEADERSHIP_CATEGORY_ID")]
			public Nullable<int> LEADERSHIP_CATEGORY_ID { get; set; }
			[Display(Name ="LEADERSHIP_NAME")]
			public string LEADERSHIP_NAME { get; set; }
			[Display(Name ="LEADERSHIP_IMAGE")]
			public string LEADERSHIP_IMAGE { get; set; }
			[Display(Name ="LEADERSHIP_DESCRIPTION")]
			public string LEADERSHIP_DESCRIPTION { get; set; }
			[Display(Name ="LEADERSHIP_ORDER")]
			public Nullable<int> LEADERSHIP_ORDER { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="LEADERSHIP_NOTES")]
			public string LEADERSHIP_NOTES { get; set; }
			[Display(Name ="LEADERSHIP_STATUS")]
			public Nullable<byte> LEADERSHIP_STATUS { get; set; }
			[Display(Name ="LEADERSHIP_ISDELETE")]
			public Nullable<bool> LEADERSHIP_ISDELETE { get; set; }
			
			
		}
	}
}
