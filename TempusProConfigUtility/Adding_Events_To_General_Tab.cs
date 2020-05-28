/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 13-04-2020
 * Time: 13:01
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using System.Diagnostics;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Adding__Events_To_General_Tab.
	/// </summary>
	public class Adding_Events_To_General_Tab
	{
		
		public void Adding_Events_To_GeneralTab()
		{
			bool returned_value; 
			
			new LoadConfig().LoadConfiguration();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.MainDG.General_Bleeding.DoubleClick();
			myrepo2.TempusProConfigurationUtility.General.Click();
			myrepo2.TempusProConfigurationUtility.MainDG.GeneralTabScrollDown.Click();
			string EventText = myrepo2.TempusProConfigurationUtility.MainDG.GeneralTabBleeding.ToString();
			//System.Diagnostics.Debug.WriteLine(EventText);
			//Console.WriteLine(EventText);
			returned_value = new CompareAttributes().CompareValidation(EventText,"{Cell:Bleeding}");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"Bleeding is added under General Tab");
			
			
		}
	}
}
