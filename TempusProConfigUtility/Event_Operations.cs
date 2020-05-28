/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 09-04-2020
 * Time: 12:54
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Windows.Forms;
using ClosedXML;
using Ranorex;
using System.Diagnostics;
using System.Threading;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Event_AssessmentOption.
	/// </summary>
	public class Event_Operations
	{
		//Process MyProcess;
	
		
		public void AssessmentOption_CheckGroupEnd()
		{
			
			new LoadConfig().LoadConfiguration();
			//Events myrepo = new Events();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.Events.Click();
			myrepo2.TempusProConfigurationUtility.Assessment.Click();
			myrepo2.TempusProConfigurationUtility.GroupEnd_Bleeding.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_CardiacArrest.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Chocking.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Confused.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Disoriented.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Fainted.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_LossOfPulse.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Seizure.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_RespiratoryArrest.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_ROSC.DoubleClick();
			myrepo2.TempusProConfigurationUtility.MainDG.GroupEnd_Vomited.DoubleClick();
			
		}
		
		public void Add_New_Event()
		{
			bool returned_value;
			new LoadConfig().LoadConfiguration();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.AddEvent.Click();
			myrepo2.EventEditor.ButtonOK.Click();
			myrepo2.AddEvent.DgName.Code.Click();
			TestDataFile TestDataFileReader = new TestDataFile();
			TestDataFileReader.TestDataFileReader();
			//Ranorex.Keyboard.Press("Test");
			
			Ranorex.Keyboard.Press(TestDataFileReader.NewEventCode);
			
			//SendKeys.Send("NewEventCode");
			myrepo2.AddEvent.DgName.EventName.Click();
			
			Ranorex.Keyboard.Press(TestDataFileReader.NewEventName);
			//Ranorex.Keyboard.Press("NewEvent");
			myrepo2.AddEvent.DgName.OKButton.Click();
			
			string EventName = myrepo2.TempusProConfigurationUtility.MainDG.NewAddedEvent.ToString();
			//System.Diagnostics.Debug.WriteLine(EventText);
			//Console.WriteLine(EventText);
			returned_value = new CompareAttributes().CompareValidation(EventName,"{Cell:NewEvent}");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"New Event is added under Assessment Tab");
			
			//i = new LaunchAndCloseApp().CloseAppWithoutSaving();
			
			//return i;
		}
		
		public void Add_LabelAndBlank_Event()
		{
			
			bool returned_value;
			new LoadConfig().LoadConfiguration();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.AddLabel.Click();
			myrepo2.TempusProConfigurationUtility.AddBlank.Click();
			string LabelName = myrepo2.TempusProConfigurationUtility.MainDG.CODERESERVEDLABEL.ToString();
			string BlankName = myrepo2.TempusProConfigurationUtility.MainDG.CODERESERVEDBLANK.ToString();
			System.Diagnostics.Debug.WriteLine(LabelName);
			System.Diagnostics.Debug.WriteLine(BlankName);
			//Console.WriteLine(EventText);
			
			returned_value = new CompareAttributes().CompareValidation(LabelName,"{Cell:CODE_RESERVED_LABEL}");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"New Label is added under Assessment Tab");
			
			
			returned_value = new CompareAttributes().CompareValidation(BlankName,"{Cell:CODE_RESERVED_BLANK}");
			if(returned_value == true)
			Report.Log(ReportLevel.Success,"New Blank is added under Assessment Tab");
			
		}
		
		public void Delete_Event()
		{
			Add_New_Event();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.DeleteButton.Click();
			Thread.Sleep(5000);
			myrepo2.TempusProConfigurationUtility.YesButtonForMultipleFunctions.Click();
			Report.Log(ReportLevel.Success,"Deleted Event");
			
		}
		
		public void Edit_Event()
		{
			
			Add_New_Event();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.EditButton.Click();
			myrepo2.EditEvent.EditingEventName.Click();
			TestDataFile TestDataFileReader = new TestDataFile();
			TestDataFileReader.TestDataFileReader();
			Ranorex.Keyboard.Press(TestDataFileReader.EditedEventName);
			//Ranorex.Keyboard.Press("Edited");
			myrepo2.EditEvent.OKButton.Click();
			Report.Log(ReportLevel.Success,"Edited Event Name");
			
			
		}
		
		public int Clear_All_Standard_Events()
		{
			int i = 0;
			bool returned_value;
			new LoadConfig().LoadConfiguration();
			TempusSimulatorDemoTest1.Events myrepo2 = new Events();
			myrepo2.TempusProConfigurationUtility.Events.Click();
			myrepo2.TempusProConfigurationUtility.Assessment.Click();
			myrepo2.TempusProConfigurationUtility.ReportTypeDropDown.Click();
			myrepo2.Report_Type.TempusProConfigurationUtility1.TC3_ReportType.Click();
			myrepo2.TempusProConfigurationUtility.Settings.Click();
			myrepo2.Report_Type.TempusProConfigurationUtility1.HighlightTC3LinkedEvents.Click();
			myrepo2.TempusProConfigurationUtility.ClearAllButton.Click();
			myrepo2.TempusProConfigurationUtility.YesButtonForMultipleFunctions.Click();
			
			string EventName = myrepo2.TempusProConfigurationUtility.MainDG.AirwayIntact.ToString();
			returned_value = new CompareAttributes().CompareValidation(EventName,"{Cell:Airway Intact}");
			
			if(returned_value == true)
			    Report.Log(ReportLevel.Success,"TC3 Events are NOT cleared under under Assessment Tab");
			
			if(!myrepo2.TempusProConfigurationUtility.DownButton.Enabled)
			{
				Report.Log(ReportLevel.Success,"All the Standard Events are cleared");
				 i =1;
			}
			
		    return i;
			
			
		}
		
		
	}
}
