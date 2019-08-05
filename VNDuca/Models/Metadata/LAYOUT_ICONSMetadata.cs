using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(LAYOUT_ICONS.Metadata))]
	public partial class LAYOUT_ICONS
	{
		sealed class Metadata
		{
			[Display(Name ="ICON_ID")]
			public int ICON_ID { get; set; }
			[Display(Name ="ICON_IMAGE")]
			public string ICON_IMAGE { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="ICON_NOTES")]
			public string ICON_NOTES { get; set; }
			[Display(Name ="ICON_STATUS")]
			public Nullable<byte> ICON_STATUS { get; set; }
			[Display(Name ="ICON_ISDELETE")]
			public Nullable<bool> ICON_ISDELETE { get; set; }
			
			
		}
	}
}
