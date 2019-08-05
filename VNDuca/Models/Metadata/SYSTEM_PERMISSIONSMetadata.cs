using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_PERMISSIONS.Metadata))]
	public partial class SYSTEM_PERMISSIONS
	{
		sealed class Metadata
		{
			[Display(Name ="PERMISSION_ID")]
			public int PERMISSION_ID { get; set; }
			[Display(Name ="FUNCTIONALITY_ID")]
			public Nullable<int> FUNCTIONALITY_ID { get; set; }
			[Display(Name ="ROLE_ID")]
			public Nullable<int> ROLE_ID { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="PERMISSION_STATUS")]
			public Nullable<byte> PERMISSION_STATUS { get; set; }
			[Display(Name ="PERMISSION_ISDELETE")]
			public Nullable<bool> PERMISSION_ISDELETE { get; set; }
			
			
		}
	}
}
