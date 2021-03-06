﻿using System;
using System.ComponentModel;

namespace Agile.Entities
{
	/// <summary>
	///		The data structure representation of the 'tblResolutions' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IResolutions 
	{
		/// <summary>			
		/// ResolutionsID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblResolutions"</remarks>
		System.Int32 ResolutionsId { get; set; }
				
		
		
		/// <summary>
		/// ResolutionsName : 
		/// </summary>
		System.String  ResolutionsName  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _dieRequestResolutionsId
		/// </summary>	
		TList<DieRequest> DieRequestCollection {  get;  set;}	

		#endregion Data Properties

	}
}


