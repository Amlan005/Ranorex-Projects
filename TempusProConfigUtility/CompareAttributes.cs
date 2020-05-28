/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 18-03-2020
 * Time: 12:00
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of CompareAttributes.
	/// </summary>
	public class CompareAttributes
	{
		public bool CompareValidation(string v1,string v2)
		{ 
			bool return_value = false;		
		    return_value = string.Equals(v1,v2);
		   /* if (return_value == true)
			  System.Diagnostics.Debug.WriteLine(v1 + " is clicked");*/
		    return return_value;
				
		
			
		}
	}
}
