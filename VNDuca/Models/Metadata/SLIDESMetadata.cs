using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SLIDES.Metadata))]
	public partial class SLIDES
	{
		sealed class Metadata
		{
			[Display(Name ="SLIDE_ID")]
			public int SLIDE_ID { get; set; }
			[Display(Name ="SLIDE_IMAGE")]
			public string SLIDE_IMAGE { get; set; }
			[Display(Name ="SLIDE_TITLE")]
			public string SLIDE_TITLE { get; set; }
			[Display(Name ="SLIDE_SUB_TITLE")]
			public string SLIDE_SUB_TITLE { get; set; }
			[Display(Name ="SLIDE_ORDER")]
			public int SLIDE_ORDER { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="SLIDE_NOTES")]
			public string SLIDE_NOTES { get; set; }
			[Display(Name ="SLIDE_STATUS")]
			public Nullable<byte> SLIDE_STATUS { get; set; }
			[Display(Name ="SLIDE_ISDELETE")]
			public Nullable<bool> SLIDE_ISDELETE { get; set; }
			
			
		}
	}
}
