using System;

namespace DCCommentRanking
{
		public class DCEventArgs : EventArgs
	{
				public DCEventArgs(string text)
		{
			this.text = text;
		}

				// (get) Token: 0x06000004 RID: 4 RVA: 0x00002087 File Offset: 0x00000287
		public string DCLogger
		{
			get
			{
				return this.text;
			}
		}

				private readonly string text;
	}
}
