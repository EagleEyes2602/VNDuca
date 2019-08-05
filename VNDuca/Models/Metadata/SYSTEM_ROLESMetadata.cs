using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_ROLES.Metadata))]
	public partial class SYSTEM_ROLES
	{
		sealed class Metadata
		{
			[Display(Name ="ROLE_ID")]
			public int ROLE_ID { get; set; }
			[Display(Name ="ROLE_NAME")]
			public string ROLE_NAME { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="ROLE_NOTES")]
			public string ROLE_NOTES { get; set; }
			[Display(Name ="ROLE_STATUS")]
			public Nullable<byte> ROLE_STATUS { get; set; }
			[Display(Name ="ROLE_ISDELETE")]
			public Nullable<bool> ROLE_ISDELETE { get; set; }
			
			
		}
	}
}
