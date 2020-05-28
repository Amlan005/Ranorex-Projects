/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 18-05-2020
 * Time: 11:03
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web;
using System.Drawing;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of ReportPieChart.
	/// </summary>
	public class ReportPieChart
	{
			public Chart ReportPieChartGeneration()
		{
			
			 
     		Chart chart = new Chart();
     		
     		Series series = new Series("Default");
    		series.ChartType = SeriesChartType.Pie; //series["PieLabelStyle"] = "Disabled";
    		chart.Series.Add(series);
    		
    		
    		ChartArea chartArea = new ChartArea();
    		chart.ChartAreas.Add(chartArea);
			ChartArea3DStyle areaStyle = new ChartArea3DStyle(chartArea);
			areaStyle.Rotation = 0;   
			Axis yAxis = new Axis(chartArea, AxisName.Y);
			Axis xAxis = new Axis(chartArea, AxisName.X); 
			
			return chart;
			
		}
	
		
	}
}
