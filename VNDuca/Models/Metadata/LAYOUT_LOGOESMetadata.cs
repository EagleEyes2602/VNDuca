using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(LAYOUT_LOGOES.Metadata))]
	public partial class LAYOUT_LOGOES
	{
		sealed class Metadata
		{
			[Display(Name ="LOGO_ID")]
			public int LOGO_ID { get; set; }
			[Display(Name ="LOGO_IMAGE")]
			public string LOGO_IMAGE { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="LOGO_NOTES")]
			public string LOGO_NOTES { get; set; }
			[Display(Name ="LOGO_STATUS")]
			public Nullable<byte> LOGO_STATUS { get; set; }
			[Display(Name ="LOGO_ISDELETE")]
			public Nullable<bool> LOGO_ISDELETE { get; set; }
			
			
		}
	}
}
