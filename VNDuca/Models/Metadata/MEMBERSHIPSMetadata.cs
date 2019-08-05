using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(MEMBERSHIPS.Metadata))]
	public partial class MEMBERSHIPS
	{
		sealed class Metadata
		{
			[Display(Name ="MEMBERSHIP_ID")]
			public int MEMBERSHIP_ID { get; set; }
			[Display(Name ="MEMBERSHIP_NAME")]
			public string MEMBERSHIP_NAME { get; set; }
			[Display(Name ="MEMBERSHIP_BRAND_IMAGE")]
			public string MEMBERSHIP_BRAND_IMAGE { get; set; }
			[Display(Name ="MEMBERSHIP_BACKGROUND_IMAGE")]
			public string MEMBERSHIP_BACKGROUND_IMAGE { get; set; }
			[Display(Name ="MEMBERSHIP_LINK")]
			public string MEMBERSHIP_LINK { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="MEMBERSHIP_NOTES")]
			public string MEMBERSHIP_NOTES { get; set; }
			[Display(Name ="MEMBERSHIP_STATUS")]
			public Nullable<byte> MEMBERSHIP_STATUS { get; set; }
			[Display(Name ="MEMBERSHIP_ISDELETE")]
			public Nullable<bool> MEMBERSHIP_ISDELETE { get; set; }
			
			
		}
	}
}
