/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 17-03-2020
 * Time: 15:47
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using System.IO;
//using DocumentFormat.OpenXml.Drawing.Charts;
using System.Windows.Forms;
//using System.Windows.Forms;
//using Infragistics.UltraChart.Data.Series;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web;
using System.Drawing;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of BaseClass.
	/// </summary>
	 class BaseClass
    {        
	 	
       public static void Main(string[] args)
        {
        	            
            RunManager run = new RunManager();
            run.TCRunner();
            int TotalCases = run.r;
            int TotalTestCasesExecuted = run.TotalTestCasesExecuted;
            int TotalTestCasesPassed = run.TotalTestCasesPassed;
            int TotalTestCasesFailed = TotalTestCasesExecuted - TotalTestCasesPassed;
            Report.Log(ReportLevel.Info, "Total test cases: " + TotalCases);
            Report.Log(ReportLevel.Info, "Total test cases executed: " + TotalTestCasesExecuted);
            Report.Log(ReportLevel.Info, "Total test cases passed: " + TotalTestCasesPassed);
          	Report.Log(ReportLevel.Info, "Total test cases failed: " + TotalTestCasesFailed);
			 // The data for the pie chart
			 int[] data = {TotalTestCasesExecuted,TotalTestCasesPassed,TotalTestCasesFailed};

            // The labels for the pie chart
            string[] labels = {"Total test cases executed","Total test cases passed","Total test cases failed:"};

			ReportPieChart report = new ReportPieChart();
			Chart chart = report.ReportPieChartGeneration();
			chart.Series["Default"].Points.DataBindXY(labels,data);
			
			chart.SetBounds(30,50,500,600);
			//chart.Width =  300;
		
			//chart.Height = 200;
           
			
			Color[] PieColors = { Color.Purple, Color.Green, Color.Red };
			chart.Series[0].Points[0].Color = PieColors[0];
			chart.Series[0].Points[1].Color = PieColors[1];
			chart.Series[0].Points[2].Color = PieColors[2];
			
			string route= "C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\ReportPieChart.png";
            chart.SaveImage(route, ChartImageFormat.Png);
			
			
			Report.LogData(ReportLevel.Info, "Execution Status", Ranorex.Imaging.Load("C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\ReportPieChart.png"));  
    		
     
         
           
            new Reports().MailReport();
        }

    }

}
