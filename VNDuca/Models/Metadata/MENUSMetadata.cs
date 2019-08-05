using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VNDuca.Models
{
	[MetadataType(typeof(MENUS.Metadata))]
	public partial class MENUS
	{
		sealed class Metadata
		{
			[Display(Name ="MENU_ID")]
			public int MENU_ID { get; set; }
			[Display(Name ="MENU_TITLE")]
			public string MENU_TITLE { get; set; }
			[Display(Name ="MENU_LINK")]
			public string MENU_LINK { get; set; }
			[Display(Name ="MENU_TARGET")]
			public string MENU_TARGET { get; set; }
			[Display(Name ="MENU_ORDER")]
			public int MENU_ORDER { get; set; }
			[Display(Name ="INVESTMENT_META_KEYWORD")]
			public string INVESTMENT_META_KEYWORD { get; set; }
			[Display(Name ="INVESTMENT_META_DESCRIPTION")]
			public string INVESTMENT_META_DESCRIPTION { get; set; }
			[Display(Name ="PROJECT_CATEGORY_SHOW_ON_HOME")]
			public bool PROJECT_CATEGORY_SHOW_ON_HOME { get; set; }
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
			[Display(Name ="MENU_NOTES")]
			public string MENU_NOTES { get; set; }
			[Display(Name ="MENU_STATUS")]
			public Nullable<byte> MENU_STATUS { get; set; }
			[Display(Name ="MENU_ISDELETE")]
			public Nullable<bool> MENU_ISDELETE { get; set; }
			
			
		}
	}
}
