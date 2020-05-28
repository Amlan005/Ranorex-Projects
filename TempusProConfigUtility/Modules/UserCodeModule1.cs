/*
 * Created by Ranorex
 * User: renorex.kolkata
 * Date: 02-04-2020
 * Time: 16:53
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TempusSimulatorDemoTest1.Modules
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("9550F991-F439-4D4E-8A93-19A4DC7603E3", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
        	
        	//RunManager run = new RunManager();
            //run.TCRunner();                  
            Report.Log(ReportLevel.Success,"LaunchConfiguration Utility");
           // new Reports().MailReport();
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
