//
// Class	:	SALSalesHeaderPrimaryKey.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 10:40:25 PM
//
	
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace POS.BusinessLayer
{
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class SALSalesHeaderPrimaryKey
	{
		#region Data Contract (Business Object Interface To Service)
		
			[DataMember]
			public int? SalesHeaderID {get;set;}
			

		#endregion
	}
}

