// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTextStrike : TLRichTextBase 
	{
		public TLRichTextBase Text { get; set; }

		public TLTextStrike() { }
		public TLTextStrike(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.TextStrike; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Text = TLFactory.Read<TLRichTextBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x9BF8BB95);
			to.WriteObject(Text, cache);
			if (cache) WriteToCache(to);
		}
	}
}