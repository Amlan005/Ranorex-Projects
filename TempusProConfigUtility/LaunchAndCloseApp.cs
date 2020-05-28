/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 17-03-2020
 * Time: 15:26
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Diagnostics;
using TempusSimulatorDemoTest1;
using Ranorex;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class LaunchAndCloseApp  
	{
		public static Process MyProcess;
		public int TCPassCriterion= 0;
		public void OpenApp(string AppLauncher)

          //  public void OpenApp()
            {
			 
			//Console.WriteLine(AppLauncher);
			MyProcess = Process.Start(AppLauncher);
			
			Report.Log(ReportLevel.Success,"Launched Configuration Utility");
			//Process.Start("Tempus Pro Configuration Utility.exe");
			Thread.Sleep(5000);
						
			
			
			
		}
		
		public int CloseApp()
		{
			//Application.Exit("Tempus Pro Configuration Utility.exe");
			//Environment.Exit(0);
			//Host.Local.CloseApplciation("Tempus Pro Configuration Utility.exe");
			//MyProcess.Close();
			
			Process process = Process.GetProcessesByName("Tempus Pro Configuration Utility").FirstOrDefault();
          
			if (process != null)
               {
                  process.CloseMainWindow();
                  if (process.CloseMainWindow()==true)
                  {
                  	TCPassCriterion = 1;
                  }
               }
			/*TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			if(myrepo2.TempusProConfigurationUtility.ExitButton.Visible)
			{
				
			    myrepo2.TempusProConfigurationUtility.ExitButton.Click();
			}*/
			 return	TCPassCriterion;			
		}
			
		public int CloseAppWithoutSaving()
		{
			
			//Application.Exit("Tempus Pro Configuration Utility.exe");
			//Environment.Exit(0);
			//Host.Local.CloseApplciation("Tempus Pro Configuration Utility.exe");
			//MyProcess.Close();
			Process process = Process.GetProcessesByName("Tempus Pro Configuration Utility").FirstOrDefault();
          
			if (process != null)
               {
                  process.CloseMainWindow();
               }
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			if(myrepo2.TempusProConfigurationUtility.YesButtonForMultipleFunctions.Visible)
			{
				TCPassCriterion++;
				myrepo2.TempusProConfigurationUtility.YesButtonForMultipleFunctions.Click();
				
			    	
			}
			
			
			 return	TCPassCriterion;			
				
		}

       
	}
}
