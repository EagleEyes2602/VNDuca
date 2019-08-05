using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(INVESTMENTS.Metadata))]
	public partial class INVESTMENTS
	{
		sealed class Metadata
		{
			[Display(Name ="INVESTMENT_ID")]
			public int INVESTMENT_ID { get; set; }
			[Display(Name ="INVESTMENT_TITLE")]
			public string INVESTMENT_TITLE { get; set; }
			[Display(Name ="INVESTMENT_CONTENT")]
			public string INVESTMENT_CONTENT { get; set; }
			[Display(Name ="INVESTMENT_IMAGE")]
			public string INVESTMENT_IMAGE { get; set; }
			[Display(Name ="INVESTMENT_ORDER")]
			public int INVESTMENT_ORDER { get; set; }
			[Display(Name ="INVESTMENT_META_KEYWORD")]
			public string INVESTMENT_META_KEYWORD { get; set; }
			[Display(Name ="INVESTMENT_META_DESCRIPTION")]
			public string INVESTMENT_META_DESCRIPTION { get; set; }
			[Display(Name ="INVESTMENT_SLUG")]
			public string INVESTMENT_SLUG { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="INVESTMENT_NOTES")]
			public string INVESTMENT_NOTES { get; set; }
			[Display(Name ="INVESTMENT_STATUS")]
			public Nullable<byte> INVESTMENT_STATUS { get; set; }
			[Display(Name ="INVESTMENT_ISDELETE")]
			public Nullable<bool> INVESTMENT_ISDELETE { get; set; }
			
			
		}
	}
}
