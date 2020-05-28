/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 09-04-2020
 * Time: 10:03
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using System.Diagnostics;
namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of LoadConfig.
	/// </summary>
	public class LoadConfig
	{
		public void LoadConfiguration()
		{
			ConfigFileReader obj = new ConfigFileReader();
            string config = obj.ConfigFileReaderGeneric();
          	new LaunchAndCloseApp().OpenApp(obj.appName);
          	
          	LoadConfiguration myRepo1 = new LoadConfiguration();
          	TempusSimulatorDemoTest1.LoadConfiguration myrepo1 = new LoadConfiguration();
			myrepo1.LoadConfigWebElements.TempusProConfigurationUtility.File1.Click();
			myrepo1.LoadConfigWebElements.TempusProConfigurationUtility1.Load.Click();
			myrepo1.LoadConfigWebElements.BrowseForFolder.TreeItem601033TempusProConfig.Click();
			myrepo1.LoadConfigWebElements.BrowseForFolder.ButtonOK.Click();
			Report.Log(ReportLevel.Success,"Configuration is loaded");
			
			
		}
	}
}
