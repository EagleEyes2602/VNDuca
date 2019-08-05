using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(TAGS.Metadata))]
	public partial class TAGS
	{
		sealed class Metadata
		{
			[Display(Name ="TAGID")]
			public int TAGID { get; set; }
			[Display(Name ="TAGNAME")]
			public string TAGNAME { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="TAG_NOTES")]
			public string TAG_NOTES { get; set; }
			[Display(Name ="TAG_STATUS")]
			public Nullable<byte> TAG_STATUS { get; set; }
			[Display(Name ="TAG_ISDELETE")]
			public Nullable<bool> TAG_ISDELETE { get; set; }
			
			
		}
	}
}
