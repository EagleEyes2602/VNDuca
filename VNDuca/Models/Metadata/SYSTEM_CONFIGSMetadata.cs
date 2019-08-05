using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_CONFIGS.Metadata))]
	public partial class SYSTEM_CONFIGS
	{
		sealed class Metadata
		{
			[Display(Name ="CONFIG_ID")]
			public int CONFIG_ID { get; set; }
			[Display(Name ="CONFIG_GROUP")]
			public string CONFIG_GROUP { get; set; }
			[Display(Name ="CONFIG_CODE")]
			public string CONFIG_CODE { get; set; }
			[Display(Name ="CONFIG_NAME")]
			public string CONFIG_NAME { get; set; }
			[Display(Name ="CONFIG_DATA_TYPE")]
			public string CONFIG_DATA_TYPE { get; set; }
			[Display(Name ="CONFIG_VALUE")]
			public string CONFIG_VALUE { get; set; }
			[Display(Name ="CONFIG_UNIT")]
			public string CONFIG_UNIT { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="CONFIG_NOTES")]
			public string CONFIG_NOTES { get; set; }
			[Display(Name ="CONFIG_STATUS")]
			public Nullable<byte> CONFIG_STATUS { get; set; }
			[Display(Name ="CONFIG_ISDELETE")]
			public Nullable<bool> CONFIG_ISDELETE { get; set; }
			
			
		}
	}
}
