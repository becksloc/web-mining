using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Threading;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Knn
{
	namespace My
	{
		
		[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(), global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
			{
				
			
			private static Settings defaultInstance = (My.Settings) (global::System.Configuration.ApplicationSettingsBase.Synchronized(new My.Settings()));
			
			#region My.Settings Auto-Save Functionality
			#if _MyType
			private static bool addedHandler;
			
			private static object addedHandlerLockObject = new object();
			
			[global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]private static void AutoSaveSettings(global::System.Object sender, global::System.EventArgs e)
				{
				if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).SaveMySettingsOnExit)
				{
					My.Settings.Default.Save();
				}
			}
			#endif
			#endregion
			
			public static Settings @Default
			{
				get
				{
					
					#if _MyType
					if (! addedHandler)
					{
						lock(addedHandlerLockObject)
						{
							if (! addedHandler)
							{
								(new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase).Shutdown += new Microsoft.VisualBasic.ApplicationServices.ShutdownEventHandler(AutoSaveSettings);
								addedHandler = true;
							}
						}
					}
					#endif
					return defaultInstance;
				}
			}
		}
	}
	
	namespace My
	{
		
		[global::Microsoft.VisualBasic.HideModuleNameAttribute(), global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]internal sealed class MySettingsProperty
			{
			
			[global::System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")]internal static global::Knn.My.Settings Settings
				{
				get
				{
					return global::Knn.My.Settings.Default;
				}
			}
		}
	}
	
}
