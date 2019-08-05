using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_FUNCTIONALITIES.Metadata))]
	public partial class SYSTEM_FUNCTIONALITIES
	{
		sealed class Metadata
		{
			[Display(Name ="FUNCTIONALITY_ID")]
			public int FUNCTIONALITY_ID { get; set; }
			[Display(Name ="FUNCTIONALITY_NAME")]
			public string FUNCTIONALITY_NAME { get; set; }
			[Display(Name ="GROUP_FUNCTIONALITY_ID")]
			public Nullable<int> GROUP_FUNCTIONALITY_ID { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="FUNCTIONALITY_STATUS")]
			public Nullable<byte> FUNCTIONALITY_STATUS { get; set; }
			[Display(Name ="FUNCTIONALITY_ISDELETE")]
			public Nullable<bool> FUNCTIONALITY_ISDELETE { get; set; }
			
			
		}
	}
}
