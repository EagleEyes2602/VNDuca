using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_FONT_AWESOME.Metadata))]
	public partial class SYSTEM_FONT_AWESOME
	{
		sealed class Metadata
		{
			[Display(Name ="FONT_AWESOME_ID")]
			public int FONT_AWESOME_ID { get; set; }
			[Display(Name ="FONT_AWESOME_NAME")]
			public string FONT_AWESOME_NAME { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="FONT_AWESOME_NOTES")]
			public string FONT_AWESOME_NOTES { get; set; }
			[Display(Name ="FONT_AWESOME_STATUS")]
			public Nullable<byte> FONT_AWESOME_STATUS { get; set; }
			[Display(Name ="FONT_AWESOME_ISDELETE")]
			public Nullable<bool> FONT_AWESOME_ISDELETE { get; set; }
			
			
		}
	}
}
