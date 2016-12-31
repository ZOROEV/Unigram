// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockPhoto : TLPageBlockBase, ITLMediaCaption 
	{
		public Int64 PhotoId { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockPhoto() { }
		public TLPageBlockPhoto(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockPhoto; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			PhotoId = from.ReadInt64();
			Caption = TLFactory.Read<TLRichTextBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xE9C69982);
			to.Write(PhotoId);
			to.WriteObject(Caption, cache);
			if (cache) WriteToCache(to);
		}
	}
}