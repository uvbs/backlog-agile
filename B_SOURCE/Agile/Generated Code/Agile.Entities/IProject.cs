﻿using System;
using System.ComponentModel;

namespace Agile.Entities
{
	/// <summary>
	///		The data structure representation of the 'tblProject' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IProject 
	{
		/// <summary>			
		/// ProjectID : 
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "tblProject"</remarks>
		System.Int32 ProjectId { get; set; }
				
		
		
		/// <summary>
		/// ProjectName : 
		/// </summary>
		System.String  ProjectName  { get; set; }
		
		/// <summary>
		/// StartDate : 
		/// </summary>
		System.DateTime  StartDate  { get; set; }
		
		/// <summary>
		/// Deadline : 
		/// </summary>
		System.DateTime  Deadline  { get; set; }
		
		/// <summary>
		/// Description : 
		/// </summary>
		System.String  Description  { get; set; }
		
		/// <summary>
		/// Active : 
		/// </summary>
		System.Boolean?  Active  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _dieRequestProjectId
		/// </summary>	
		TList<DieRequest> DieRequestCollection {  get;  set;}	

		#endregion Data Properties

	}
}

