using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DCCommentRanking.Properties
{
		[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
				internal Resources()
		{
		}

				// (get) Token: 0x0600003A RID: 58 RVA: 0x000069DA File Offset: 0x00004BDA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("DCCommentRanking.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

				// (get) Token: 0x0600003B RID: 59 RVA: 0x00006A06 File Offset: 0x00004C06
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00006A0D File Offset: 0x00004C0D
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

				private static ResourceManager resourceMan;

				private static CultureInfo resourceCulture;
	}
}
