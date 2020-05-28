using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MyExcel = Microsoft.Office.Interop.Excel;
//using ClosedXML.Excel;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using NPOI;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using NPOI.SS.UserModel;
using System.Diagnostics;
using System.Threading;
using Ranorex;

namespace TempusSimulatorDemoTest1
	
{
	public class RunManager
	{
		
		public int r;
		public int TotalTestCasesExecuted = 0;
		public int TotalTestCasesPassed = 0;
		
		public void TCRunner()
		{
			String filepath = @"C:\Users\Renorex.Kolkata\Documents\Ranorex\RanorexStudio Projects\TempusProConfigUtility\TempusProConfigUtility\TempusProConfigUtility\RunManager.xls";
			IWorkbook workbook = null;
			ISheet sheet = null;
			int rowCount=0;
			string Run_Flag;
			using(FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				
				workbook = new HSSFWorkbook(fs);
				sheet =workbook.GetSheet("Sheet1");
				
				
			}
			
			
			
			rowCount = sheet.LastRowNum;
			System.Diagnostics.Debug.WriteLine(rowCount);
			for(r = 2;r<=rowCount;r++)
			{
				String action = sheet.GetRow(r).GetCell(0).StringCellValue;
				
				switch(action)
				{
					case "TC_001":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							ConfigFileReader obj = new ConfigFileReader();
							string config = obj.ConfigFileReaderGeneric();
							new LaunchAndCloseApp().OpenApp(obj.appName);
							int i = new LaunchAndCloseApp().CloseApp();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 001 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
					case "TC_002":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							int i = new TabClicks().ClickOnTabs();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 002 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
					case "TC_003":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new LoadConfig().LoadConfiguration();
							Thread.Sleep(5000);
							int i = new LaunchAndCloseApp().CloseApp();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 003 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
					case "TC_004":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new Event_Operations().AssessmentOption_CheckGroupEnd();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i ==1)
							    {
							    	TotalTestCasesPassed++;
							    	Report.Log(ReportLevel.Info,"TC 004 passed");
							    }
							TotalTestCasesExecuted++;
						}
						break;
						
					case "TC_005":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new Adding_Events_To_General_Tab().Adding_Events_To_GeneralTab();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							
							if (i ==1)
							    {
							    	TotalTestCasesPassed++;
							    	Report.Log(ReportLevel.Info,"TC 005 passed");
							    }
							 TotalTestCasesExecuted++;
							}
						break;
						
					case "TC_006":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new Event_Operations().Add_New_Event();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 006 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
						case "TC_007":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new Event_Operations().Add_LabelAndBlank_Event();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 007 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
						case "TC_008":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							new Event_Operations().Delete_Event();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 008 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
						case "TC_009":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							
							new Event_Operations().Edit_Event();
							int i = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i == 1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 009 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
						
						
						case "TC_010":
						Run_Flag = sheet.GetRow(r).GetCell(2).StringCellValue.ToString();
						if(Run_Flag.Equals("Y"))
						{
							
							int i = new Event_Operations().Clear_All_Standard_Events();
							Thread.Sleep(10000);
							int j = new LaunchAndCloseApp().CloseAppWithoutSaving();
							if (i==1&&j==1)
							{
								TotalTestCasesPassed++;
								Report.Log(ReportLevel.Info,"TC 010 passed");
							}
							TotalTestCasesExecuted++;
						}
						break;
				}
			
						
				
			}
			
			r=r-2;
			
		}
		
	}
}

