using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_HISTORY.Metadata))]
	public partial class SYSTEM_HISTORY
	{
		sealed class Metadata
		{
			[Display(Name ="HISTORY_ID")]
			public int HISTORY_ID { get; set; }
			[Display(Name ="HISTORY_SESSIONID")]
			public string HISTORY_SESSIONID { get; set; }
			[Display(Name ="HISTORY_GROUP_FUNCTIONALITY")]
			public string HISTORY_GROUP_FUNCTIONALITY { get; set; }
			[Display(Name ="HISTORY_FUNCTIONALITY")]
			public string HISTORY_FUNCTIONALITY { get; set; }
			[Display(Name ="HISTORY_CONTENT")]
			public string HISTORY_CONTENT { get; set; }
			[Display(Name ="HISTORY_ERROR")]
			public string HISTORY_ERROR { get; set; }
			[Display(Name ="HISTORY_NOTES")]
			public string HISTORY_NOTES { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="ADMIN_ID")]
			public Nullable<int> ADMIN_ID { get; set; }
			
			
		}
	}
}
