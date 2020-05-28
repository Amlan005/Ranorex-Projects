/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 27-04-2020
 * Time: 12:54
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using MyExcel = Microsoft.Office.Interop.Excel;
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

//using ClosedXML.Excel;












namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class TestDataFile
	{
		public String NewEventCode;
		public String NewEventName;
		public String EditedEventName;
		public void TestDataFileReader()
		{
			
			String filepath = @"C:\Users\Renorex.Kolkata\Documents\Ranorex\RanorexStudio Projects\TempusProConfigUtility\TempusProConfigUtility\TempusProConfigUtility\RunManager.xls";
			IWorkbook workbook =null;
			ISheet sheet=null;
			
			using(FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				
			
				workbook = new HSSFWorkbook(fs);
				sheet =workbook.GetSheet("Sheet1");
							
				NewEventCode = sheet.GetRow(7).GetCell(3).StringCellValue;
				NewEventName = sheet.GetRow(7).GetCell(4).StringCellValue;
				EditedEventName = sheet.GetRow(10).GetCell(5).StringCellValue;
			
			}
			
			
		}
	}
}
