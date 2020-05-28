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
            Report.Log(ReportLevel.Info, "Total test cases: " + TotalCases);
            Report.Log(ReportLevel.Info, "Total test cases executed: " + TotalTestCasesExecuted);
            Report.Log(ReportLevel.Info, "Total test cases passed: " + TotalTestCasesPassed);
            
            new Reports().MailReport();
        }

    }

}
