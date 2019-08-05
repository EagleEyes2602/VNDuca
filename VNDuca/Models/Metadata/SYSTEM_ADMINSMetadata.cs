using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(SYSTEM_ADMINS.Metadata))]
	public partial class SYSTEM_ADMINS
	{
		sealed class Metadata
		{
			[Display(Name ="ADMIN_ID")]
			public int ADMIN_ID { get; set; }
			[Display(Name ="ROLE_ID")]
			public Nullable<int> ROLE_ID { get; set; }
			[Display(Name ="ADMIN_FULLNAME")]
			public string ADMIN_FULLNAME { get; set; }
			[Display(Name ="ADMIN_EMAIL")]
			public string ADMIN_EMAIL { get; set; }
			[Display(Name ="ADMIN_HASHED_PASSWORD")]
			public string ADMIN_HASHED_PASSWORD { get; set; }
			[Display(Name ="ADMIN_AVATAR")]
			public string ADMIN_AVATAR { get; set; }
			[Display(Name ="ADMIN_BIRTHDAY")]
			public Nullable<DateTime> ADMIN_BIRTHDAY { get; set; }
			[Display(Name ="ADMIN_GENDER")]
			public Nullable<byte> ADMIN_GENDER { get; set; }
			[Display(Name ="ADMIN_PHONE")]
			public string ADMIN_PHONE { get; set; }
			[Display(Name ="ADMIN_ADDRESS")]
			public string ADMIN_ADDRESS { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="ADMIN_NOTES")]
			public string ADMIN_NOTES { get; set; }
			[Display(Name ="ADMIN_STATUS")]
			public Nullable<byte> ADMIN_STATUS { get; set; }
			[Display(Name ="ADMIN_ISDELETE")]
			public Nullable<bool> ADMIN_ISDELETE { get; set; }
			
			
		}
	}
}
