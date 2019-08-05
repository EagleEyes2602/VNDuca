using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(LAYOUT_CONTACTS.Metadata))]
	public partial class LAYOUT_CONTACTS
	{
		sealed class Metadata
		{
			[Display(Name ="CONTACT_ID")]
			public int CONTACT_ID { get; set; }
			[Display(Name ="CONTACT_LOCATION")]
			public string CONTACT_LOCATION { get; set; }
			[Display(Name ="CONTACT_ADDRESS")]
			public string CONTACT_ADDRESS { get; set; }
			[Display(Name ="CONTACT_PHONE")]
			public string CONTACT_PHONE { get; set; }
			[Display(Name ="CONTACT_EMAIL")]
			public string CONTACT_EMAIL { get; set; }
			[Display(Name ="CREATED_DATE")]
			public Nullable<DateTime> CREATED_DATE { get; set; }
			[Display(Name ="UPDATED_DATE")]
			public Nullable<DateTime> UPDATED_DATE { get; set; }
			[Display(Name ="ADMIN_CREATED")]
			public string ADMIN_CREATED { get; set; }
			[Display(Name ="ADMIN_UPDATED")]
			public string ADMIN_UPDATED { get; set; }
			[Display(Name ="CONTACT_NOTES")]
			public string CONTACT_NOTES { get; set; }
			[Display(Name ="CONTACT_STATUS")]
			public Nullable<byte> CONTACT_STATUS { get; set; }
			[Display(Name ="CONTACT_ISDELETE")]
			public Nullable<bool> CONTACT_ISDELETE { get; set; }
			
			
		}
	}
}
