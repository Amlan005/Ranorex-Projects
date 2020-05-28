/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 18-03-2020
 * Time: 10:18
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using System.Threading;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class TabClicks
	{
		public int ClickOnTabs()
		{
			LaunchAppPage myRepo = new LaunchAppPage();
			bool returned_value;
			//LaunchAppPage myRepo = LaunchAppPage.Instance;
			//myRepo.TempusSimulatorDemoTest1.LaunchAppPageElements.Events.click();
			//TempusSimulatorDemoTest1.LaunchAppPage myrepo = new LaunchAppPage();
			TempusSimulatorDemoTest1.LaunchAppPage myrepo = LaunchAppPage.Instance;
			
			ConfigFileReader obj = new ConfigFileReader();
            string config = obj.ConfigFileReaderGeneric();
          	new LaunchAndCloseApp().OpenApp(obj.appName);
          	
          	
			myRepo.LaunchAppPageElements.New_Patient_Defaults.Click();
			string elementStringVal1 = myrepo.LaunchAppPageElements.New_Patient_Defaults.Title.ToString();		
			returned_value = new CompareAttributes().CompareValidation(elementStringVal1,"New patient defaults");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"Clicked on New patient defaults Tab");
		

			myRepo.LaunchAppPageElements.Events.Click();
			string elementStringVal2 = myrepo.LaunchAppPageElements.Events.Title.ToString();
			returned_value = new CompareAttributes().CompareValidation(elementStringVal2,"Events");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"Clicked on Events Tab");
			
			myRepo.LaunchAppPageElements.Communications.Click();
			string elementStringVal3 = myrepo.LaunchAppPageElements.Communications.Caption.ToString();
			returned_value = new CompareAttributes().CompareValidation(elementStringVal3,"Communications");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"Clicked on Communications Tab");
			
			myRepo.LaunchAppPageElements.Codes_Other.Click();
			string elementStringVal4 = myrepo.LaunchAppPageElements.Codes_Other.Caption.ToString();
			returned_value = new CompareAttributes().CompareValidation(elementStringVal4,"Codes / Other");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"Clicked on Codes / Other Tab");
			Thread.Sleep(10000);
			
			int i = new LaunchAndCloseApp().CloseApp();
			return i;
		}
	}
}
