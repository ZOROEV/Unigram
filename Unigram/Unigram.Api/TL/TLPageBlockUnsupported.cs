// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockUnsupported : TLPageBlockBase 
	{
		public TLPageBlockUnsupported() { }
		public TLPageBlockUnsupported(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockUnsupported; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x13567E8A);
			if (cache) WriteToCache(to);
		}
	}
}