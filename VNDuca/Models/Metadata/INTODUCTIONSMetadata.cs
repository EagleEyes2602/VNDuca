using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(INTODUCTIONS.Metadata))]
	public partial class INTODUCTIONS
	{
		sealed class Metadata
		{
			[Display(Name ="INTODUCTION_ID")]
			public int INTODUCTION_ID { get; set; }
			[Display(Name ="INTODUCTION_CATEGORY_ID")]
			public Nullable<int> INTODUCTION_CATEGORY_ID { get; set; }
			[Display(Name ="INTODUCTION_NAME")]
			public string INTODUCTION_NAME { get; set; }
			[Display(Name ="INTODUCTION_IMAGE")]
			public string INTODUCTION_IMAGE { get; set; }
			[Display(Name ="INTODUCTION_ORDER")]
			public Nullable<int> INTODUCTION_ORDER { get; set; }
			[Display(Name ="INTODUCTION_DESCRIPTION")]
			public string INTODUCTION_DESCRIPTION { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="INTODUCTION_NOTES")]
			public string INTODUCTION_NOTES { get; set; }
			[Display(Name ="INTODUCTION_STATUS")]
			public Nullable<byte> INTODUCTION_STATUS { get; set; }
			[Display(Name ="INTODUCTION_ISDELETE")]
			public Nullable<bool> INTODUCTION_ISDELETE { get; set; }
			
			
		}
	}
}
