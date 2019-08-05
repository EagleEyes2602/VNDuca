using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(NEWSTAGS.Metadata))]
	public partial class NEWSTAGS
	{
		sealed class Metadata
		{
			[Display(Name ="NEWSTAGID")]
			public int NEWSTAGID { get; set; }
			[Display(Name ="JOBID")]
			public int JOBID { get; set; }
			[Display(Name ="TAGID")]
			public int TAGID { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="NEWSTAG_NOTES")]
			public string NEWSTAG_NOTES { get; set; }
			[Display(Name ="NEWSTAG_STATUS")]
			public Nullable<byte> NEWSTAG_STATUS { get; set; }
			[Display(Name ="NEWSTAG_ISDELETE")]
			public Nullable<bool> NEWSTAG_ISDELETE { get; set; }
			
			
		}
	}
}
