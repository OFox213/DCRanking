using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DCCommentRanking.Properties
{
		[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
				// (get) Token: 0x0600003D RID: 61 RVA: 0x00006A15 File Offset: 0x00004C15
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

				// (get) Token: 0x0600003E RID: 62 RVA: 0x00006A1C File Offset: 0x00004C1C
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00006A2E File Offset: 0x00004C2E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool DebugComment
		{
			get
			{
				return (bool)this["DebugComment"];
			}
			set
			{
				this["DebugComment"] = value;
			}
		}

				// (get) Token: 0x06000040 RID: 64 RVA: 0x00006A41 File Offset: 0x00004C41
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00006A53 File Offset: 0x00004C53
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DebugCommentUserName
		{
			get
			{
				return (string)this["DebugCommentUserName"];
			}
			set
			{
				this["DebugCommentUserName"] = value;
			}
		}

				private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
