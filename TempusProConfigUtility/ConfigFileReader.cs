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
//using MadMilkman.Ini;
//using IniParser;
//using IniParser.Configuration;
//using IniParser.Exceptions;

namespace TempusSimulatorDemoTest1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	
	public class ConfigFileReader
	 
	{   
		
		
	    public string appName = string.Empty ;
		public string mailTo = string.Empty ;
		public string mailFrom = string.Empty ;
		public string mailSubject = string.Empty ;
		public string mailBody = string.Empty ;
		public string mailToCC = string.Empty;
		public string mailToBCC = string.Empty;
		public ConfigFileReader()
		{
			 this.appName =appName;
			 this.mailTo =mailTo;
			 this.mailFrom =mailFrom;
		     this.mailSubject =mailSubject;
			 this.mailBody =mailBody;

		}
		
		public string ConfigFileReaderGeneric() 
		{
						
			
			
		string path = @"C:\Users\Renorex.Kolkata\Documents\Ranorex\RanorexStudio Projects\TempusProConfigUtility\TempusProConfigUtility\TempusProConfigUtility\config\config.ini";

              
        // This text is always added, making the file longer over time
        // if it is not deleted.
        //string appendText = "This is extra text" + Environment.NewLine;
        string appendText = string.Empty;
        //File.AppendAllText(path, appendText, Encoding.UTF8);
        File.AppendAllText(path, appendText);
        // Open the file to read from.
        //string[] readText = File.ReadAllLines(path, Encoding.UTF8);
        string[] readText = File.ReadAllLines(path);
            
        
        
        foreach (string s in readText)
        {
        	
        	if (s.ToLower().StartsWith("appname"))
       							 {
        							
            						string[] fullName = s.Split('=');
            					    appName = fullName[1];
            						//Console.WriteLine(appName);
            						//System.Diagnostics.Debug.WriteLine(appName); 
            						       						
        						 }
        	
        	if (s.ToLower().StartsWith("to"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailTo = fullName[1];
            						//Console.WriteLine(mailTo);
            						//System.Diagnostics.Debug.WriteLine(mailTo); 
            						
            						
        						 }
        	
        	if (s.ToLower().StartsWith("cc"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailToCC = fullName[1];
            						//Console.WriteLine(mailTo);
            						//System.Diagnostics.Debug.WriteLine(mailTo); 
            						
            						
        						 }
        	/*if (s.ToLower().StartsWith("bcc"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailToBCC = fullName[1];
            						//Console.WriteLine(mailTo);
            						//System.Diagnostics.Debug.WriteLine(mailTo); 
            						
            						
        						 }*/
        	
        	if (s.ToLower().StartsWith("from"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailFrom = fullName[1];
            						//Console.WriteLine(mailFrom);
            						//System.Diagnostics.Debug.WriteLine(mailFrom); 
            						
            						
        						 }
        	
        		if (s.ToLower().StartsWith("subject"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailSubject = fullName[1];
            						//Console.WriteLine(mailSubject);
            						//System.Diagnostics.Debug.WriteLine(mailSubject);
            						
            						
        						 }
        		
        		
        		if (s.ToLower().StartsWith("body"))
       							 {
        	
            						string[] fullName = s.Split('=');
            						mailBody = fullName[1];
            						//Console.WriteLine(mailBody);
            						//System.Diagnostics.Debug.WriteLine(mailBody); 
            						
            						
        						 }
      
           
        }
			
		
		
		return appName;	
					
			
		}
		
		
		
			
	}
}
