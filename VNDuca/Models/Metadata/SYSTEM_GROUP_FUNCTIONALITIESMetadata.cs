using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_GROUP_FUNCTIONALITIES.Metadata))]
	public partial class SYSTEM_GROUP_FUNCTIONALITIES
	{
		sealed class Metadata
		{
			[Display(Name ="GROUP_FUNCTIONALITY_ID")]
			public int GROUP_FUNCTIONALITY_ID { get; set; }
			[Display(Name ="GROUP_FUNCTIONALITY_NAME")]
			public string GROUP_FUNCTIONALITY_NAME { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="GROUP_FUNCTIONALITY_STATUS")]
			public Nullable<byte> GROUP_FUNCTIONALITY_STATUS { get; set; }
			[Display(Name ="GROUP_FUNCTIONALITY_ISDELETE")]
			public Nullable<bool> GROUP_FUNCTIONALITY_ISDELETE { get; set; }
			
			
		}
	}
}
