//
// Class	:	ADGroupRoleBase.cs
// Author	:  	Ignyte Software © 2011 (DLG 2.0.9.0)
// Date		:	3/7/2015 2:37:00 PM
//
using System;
using System.Runtime.Serialization;
using POS.DataLayer;

namespace POS.BusinessLayer
{
	/// <summary>
	/// Class for the properties of the object
	/// </summary>
	[DataContract(Namespace = "POS.BusinessLayer")]
	public class ADGroupRoleBase
	{

		#region Data Contract (Business Object Interface To Service)

		
		[DataMember]
		public int? GroupRoleID {get;set;}

		[DataMember]
		public int? GroupID {get;set;}

		[DataMember]
		public int? RoleID {get;set;}

		
		#endregion
	}
}
			
