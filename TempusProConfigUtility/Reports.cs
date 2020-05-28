/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 19-03-2020
 * Time: 16:36
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */

using System;
using System.IO;
using System.Xml.Xsl;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Reporting;



namespace TempusSimulatorDemoTest1
{

public class Reports
{

	
//public void MailReport(string mailfrom1,string mailto1,string mailsubject1,string mailbody1)
public void MailReport()
{
	//ConfigFileReader obj = new ConfigFileReader();
            	                	
	try
		   {
		        ConfigFileReader mailReader = new ConfigFileReader();
		        string c = mailReader.ConfigFileReaderGeneric();
				MailMessage mail = new MailMessage();
				
				//mail.From = new MailAddress("amlan.biswas@mindteck.com");
				//MailAddress address = new MailAddress("amlan.biswas@mindteck.com");
				
				MailAddress address = new MailAddress(mailReader.mailFrom);
				mail.From = address;
				
				mail.To.Add(mailReader.mailTo);
				mail.CC.Add(mailReader.mailToCC);
				//mail.Bcc.Add(mailReader.mailToBCC);
				mail.Subject = mailReader.mailSubject;
				mail.Body = mailReader.mailBody;
				
				SmtpClient SmtpServer = new SmtpClient("mail.mindteck.com");
				//SmtpClient SmtpServer = new SmtpClient();
				//SmtpServer.Host = "mail.mindteck.com";
				SmtpServer.Port = 587;
				SmtpServer.UseDefaultCredentials = false;
				SmtpServer.Credentials = new System.Net.NetworkCredential("amlan.biswas@mindteck.com", "6Gby0R");
				SmtpServer.EnableSsl = true;
				SmtpServer.Timeout = 100000;
				
				//String zipFilePath = Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportZipFilePath;
				String FilePath = Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportFileDirectory;
				System.Diagnostics.Debug.WriteLine(FilePath);
				String zipFileName = Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportName;
				System.Diagnostics.Debug.WriteLine(zipFileName);
				
				while(!System.IO.File.Exists(zipFileName+".rxlog"))
					{
						Thread.Sleep(50000);
					}
				
				
				
				if (System.IO.File.Exists(zipFileName+".rxlog"))
				{
					               
					Thread.Sleep(100000);
					
					
					string FileToCopy = null;
                    string NewCopy = null;
                    string DataFileToCopy = null;
                    string NewDataFile = null;

                    FileToCopy = FilePath+"\\"+zipFileName+".rxlog";
                    NewCopy = FilePath+"\\"+zipFileName+".html";
					DataFileToCopy ="C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\"+zipFileName+".rxlog.data";
					NewDataFile = 	"C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\"+zipFileName+".html.data";
					Thread.Sleep(5000);
                 	
     				
					
					
	                       System.IO.File.Copy(FileToCopy, NewCopy);
                           Thread.Sleep(10000);
                           System.IO.File.Copy(DataFileToCopy, NewDataFile);
                           Thread.Sleep(10000);
                           Report.Log(ReportLevel.Always,"FileCopied");
						   System.Diagnostics.Debug.WriteLine("FileCopied");
						   Thread.Sleep(5000);
                

                    

					
                     System.Net.Mail.Attachment MyReport = new System.Net.Mail.Attachment(FilePath+"\\"+zipFileName+".html","text/plain");
                     System.Net.Mail.Attachment ReportDataFile = new System.Net.Mail.Attachment("C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\"+zipFileName+".html.data","text/plain");
					 System.Net.Mail.Attachment ReportXLSFile = new System.Net.Mail.Attachment("C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\RanorexReport.xsl");
                     System.Net.Mail.Attachment ReportPNGFile = new System.Net.Mail.Attachment("C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\RanorexReport.png");
                     System.Net.Mail.Attachment ReportCSSFile = new System.Net.Mail.Attachment("C:\\Users\\Renorex.Kolkata\\Documents\\Ranorex\\RanorexStudio Projects\\TempusProConfigUtility\\TempusProConfigUtility\\TempusProConfigUtility\\bin\\Debug\\RanorexReport.css");
                     
					 //System.Net.Mail.Attachment MyReport = new System.Net.Mail.Attachment(zipFileName);
					mail.Attachments.Add (MyReport);
					mail.Attachments.Add (ReportDataFile);
					mail.Attachments.Add (ReportXLSFile);
					mail.Attachments.Add (ReportPNGFile);
					mail.Attachments.Add (ReportCSSFile);
					System.Diagnostics.Debug.WriteLine("Test");
					SmtpServer.Send(mail);
					Report.Info("Email sent");
				}
				
				//SmtpServer.Send(mail);     
                //SmtpServer.SendAsync(mail, mail);                                                         . 
                //SmtpServer.SendMailAsync(mail);
                
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				Report.Error(ex.StackTrace);
				
			}
}

}

}
