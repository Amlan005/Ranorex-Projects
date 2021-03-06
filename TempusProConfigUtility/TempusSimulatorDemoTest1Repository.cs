﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TempusSimulatorDemoTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TempusSimulatorDemoTest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a08f7145-99ac-4cce-902d-5abcde8e54ae")]
    public partial class TempusSimulatorDemoTest1Repository : RepoGenBaseFolder
    {
        static TempusSimulatorDemoTest1Repository instance = new TempusSimulatorDemoTest1Repository();
        TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtilityAppFolder _tempusproconfigurationutility;
        TempusSimulatorDemoTest1RepositoryFolders.BrowseForFolderAppFolder _browseforfolder;
        TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtility1AppFolder _tempusproconfigurationutility1;

        /// <summary>
        /// Gets the singleton class instance representing the TempusSimulatorDemoTest1Repository element repository.
        /// </summary>
        [RepositoryFolder("a08f7145-99ac-4cce-902d-5abcde8e54ae")]
        public static TempusSimulatorDemoTest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TempusSimulatorDemoTest1Repository() 
            : base("TempusSimulatorDemoTest1Repository", "/", null, 0, false, "a08f7145-99ac-4cce-902d-5abcde8e54ae", ".\\RepositoryImages\\TempusSimulatorDemoTest1Repositorya08f7145.rximgres")
        {
            _tempusproconfigurationutility = new TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtilityAppFolder(this);
            _browseforfolder = new TempusSimulatorDemoTest1RepositoryFolders.BrowseForFolderAppFolder(this);
            _tempusproconfigurationutility1 = new TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtility1AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a08f7145-99ac-4cce-902d-5abcde8e54ae")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TempusProConfigurationUtility folder.
        /// </summary>
        [RepositoryFolder("9029c026-ef66-42a8-adb8-85d8bc579c2a")]
        public virtual TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtilityAppFolder TempusProConfigurationUtility
        {
            get { return _tempusproconfigurationutility; }
        }

        /// <summary>
        /// The BrowseForFolder folder.
        /// </summary>
        [RepositoryFolder("faece108-3c19-420f-86b5-f692f5e19fdf")]
        public virtual TempusSimulatorDemoTest1RepositoryFolders.BrowseForFolderAppFolder BrowseForFolder
        {
            get { return _browseforfolder; }
        }

        /// <summary>
        /// The TempusProConfigurationUtility1 folder.
        /// </summary>
        [RepositoryFolder("5332693f-734e-4e9a-97ae-38cd925fa83d")]
        public virtual TempusSimulatorDemoTest1RepositoryFolders.TempusProConfigurationUtility1AppFolder TempusProConfigurationUtility1
        {
            get { return _tempusproconfigurationutility1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class TempusSimulatorDemoTest1RepositoryFolders
    {
        /// <summary>
        /// The TempusProConfigurationUtilityAppFolder folder.
        /// </summary>
        [RepositoryFolder("9029c026-ef66-42a8-adb8-85d8bc579c2a")]
        public partial class TempusProConfigurationUtilityAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fileInfo;
            RepoItemInfo _togglebuttonInfo;
            RepoItemInfo _settingsInfo;

            /// <summary>
            /// Creates a new TempusProConfigurationUtility  folder.
            /// </summary>
            public TempusProConfigurationUtilityAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TempusProConfigurationUtility", "/form[@title>'Tempus Pro Configuration']", parentFolder, 30000, null, true, "9029c026-ef66-42a8-adb8-85d8bc579c2a", "")
            {
                _fileInfo = new RepoItemInfo(this, "File", "?/?/menuitem[@text='File']/text[@caption='File']", 30000, null, "9b117907-483f-4ddf-a9b1-45f03db6cc2e");
                _togglebuttonInfo = new RepoItemInfo(this, "ToggleButton", "?/?/tabpagelist[@automationid='mainTab']//combobox[@automationid='cmbReportType']/button[@automationid='toggleButton']", 30000, null, "678fb00f-498b-47c1-9493-ecf18e2a61fb");
                _settingsInfo = new RepoItemInfo(this, "Settings", "?/?/menuitem[@text='Settings']/text[@caption='Settings']", 30000, null, "530db903-4f84-437b-bd08-32b3e9254503");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9029c026-ef66-42a8-adb8-85d8bc579c2a")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9029c026-ef66-42a8-adb8-85d8bc579c2a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The File item.
            /// </summary>
            [RepositoryItem("9b117907-483f-4ddf-a9b1-45f03db6cc2e")]
            public virtual Ranorex.Text File
            {
                get
                {
                    return _fileInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The File item info.
            /// </summary>
            [RepositoryItemInfo("9b117907-483f-4ddf-a9b1-45f03db6cc2e")]
            public virtual RepoItemInfo FileInfo
            {
                get
                {
                    return _fileInfo;
                }
            }

            /// <summary>
            /// The ToggleButton item.
            /// </summary>
            [RepositoryItem("678fb00f-498b-47c1-9493-ecf18e2a61fb")]
            public virtual Ranorex.Button ToggleButton
            {
                get
                {
                    return _togglebuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ToggleButton item info.
            /// </summary>
            [RepositoryItemInfo("678fb00f-498b-47c1-9493-ecf18e2a61fb")]
            public virtual RepoItemInfo ToggleButtonInfo
            {
                get
                {
                    return _togglebuttonInfo;
                }
            }

            /// <summary>
            /// The Settings item.
            /// </summary>
            [RepositoryItem("530db903-4f84-437b-bd08-32b3e9254503")]
            public virtual Ranorex.Text Settings
            {
                get
                {
                    return _settingsInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Settings item info.
            /// </summary>
            [RepositoryItemInfo("530db903-4f84-437b-bd08-32b3e9254503")]
            public virtual RepoItemInfo SettingsInfo
            {
                get
                {
                    return _settingsInfo;
                }
            }
        }

        /// <summary>
        /// The BrowseForFolderAppFolder folder.
        /// </summary>
        [RepositoryFolder("faece108-3c19-420f-86b5-f692f5e19fdf")]
        public partial class BrowseForFolderAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _treeitem601033tempusproconfigInfo;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new BrowseForFolder  folder.
            /// </summary>
            public BrowseForFolderAppFolder(RepoGenBaseFolder parentFolder) :
                    base("BrowseForFolder", "/form[@title='Browse For Folder']", parentFolder, 30000, null, true, "faece108-3c19-420f-86b5-f692f5e19fdf", "")
            {
                _treeitem601033tempusproconfigInfo = new RepoItemInfo(this, "TreeItem601033TempusProConfig", "element[@class='SHBrowseForFolder ShellNameSpace Control']/tree[@controlid='100']//treeitem[@text='Amlan']/?/?/treeitem[@text='601033-TempusProConfig']", 30000, null, "2699ae52-9b31-46a5-a1cb-c96faad9c99d");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='OK']", 30000, null, "05f0de6b-8ab2-4b89-abcf-6484d942d33e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("faece108-3c19-420f-86b5-f692f5e19fdf")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("faece108-3c19-420f-86b5-f692f5e19fdf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TreeItem601033TempusProConfig item.
            /// </summary>
            [RepositoryItem("2699ae52-9b31-46a5-a1cb-c96faad9c99d")]
            public virtual Ranorex.TreeItem TreeItem601033TempusProConfig
            {
                get
                {
                    return _treeitem601033tempusproconfigInfo.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The TreeItem601033TempusProConfig item info.
            /// </summary>
            [RepositoryItemInfo("2699ae52-9b31-46a5-a1cb-c96faad9c99d")]
            public virtual RepoItemInfo TreeItem601033TempusProConfigInfo
            {
                get
                {
                    return _treeitem601033tempusproconfigInfo;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("05f0de6b-8ab2-4b89-abcf-6484d942d33e")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("05f0de6b-8ab2-4b89-abcf-6484d942d33e")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

        /// <summary>
        /// The TempusProConfigurationUtility1AppFolder folder.
        /// </summary>
        [RepositoryFolder("5332693f-734e-4e9a-97ae-38cd925fa83d")]
        public partial class TempusProConfigurationUtility1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _listitemtc3Info;
            RepoItemInfo _highlighttc3linkedeventsInfo;

            /// <summary>
            /// Creates a new TempusProConfigurationUtility1  folder.
            /// </summary>
            public TempusProConfigurationUtility1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("TempusProConfigurationUtility1", "/contextmenu[@processname='Tempus Pro Configuration Utility']", parentFolder, 30000, null, false, "5332693f-734e-4e9a-97ae-38cd925fa83d", "")
            {
                _listitemtc3Info = new RepoItemInfo(this, "ListItemTC3", "?/?/listitem[@text='TC3']", 30000, null, "c1f53139-7caf-48c9-9180-8d499fe4feac");
                _highlighttc3linkedeventsInfo = new RepoItemInfo(this, "HighlightTC3LinkedEvents", "?/?/text[@caption>'Highlight TC3 linked even']", 30000, null, "24c34580-94e3-4725-9352-5a8e125bf30e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5332693f-734e-4e9a-97ae-38cd925fa83d")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5332693f-734e-4e9a-97ae-38cd925fa83d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ListItemTC3 item.
            /// </summary>
            [RepositoryItem("c1f53139-7caf-48c9-9180-8d499fe4feac")]
            public virtual Ranorex.ListItem ListItemTC3
            {
                get
                {
                    return _listitemtc3Info.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItemTC3 item info.
            /// </summary>
            [RepositoryItemInfo("c1f53139-7caf-48c9-9180-8d499fe4feac")]
            public virtual RepoItemInfo ListItemTC3Info
            {
                get
                {
                    return _listitemtc3Info;
                }
            }

            /// <summary>
            /// The HighlightTC3LinkedEvents item.
            /// </summary>
            [RepositoryItem("24c34580-94e3-4725-9352-5a8e125bf30e")]
            public virtual Ranorex.Text HighlightTC3LinkedEvents
            {
                get
                {
                    return _highlighttc3linkedeventsInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The HighlightTC3LinkedEvents item info.
            /// </summary>
            [RepositoryItemInfo("24c34580-94e3-4725-9352-5a8e125bf30e")]
            public virtual RepoItemInfo HighlightTC3LinkedEventsInfo
            {
                get
                {
                    return _highlighttc3linkedeventsInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
