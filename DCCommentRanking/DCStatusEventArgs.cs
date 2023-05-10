using System;

namespace DCCommentRanking
{
		public class DCStatusEventArgs : EventArgs
	{
				public DCStatusEventArgs(int totalCount, int currentCount)
		{
			this.v.tc = totalCount;
			this.v.cc = currentCount;
		}

				// (get) Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		public DCStatusEventArgs.Values DCStatus
		{
			get
			{
				return this.v;
			}
		}

				private readonly DCStatusEventArgs.Values v;

				public struct Values
		{
						public int tc;

						public int cc;
		}
	}
}
