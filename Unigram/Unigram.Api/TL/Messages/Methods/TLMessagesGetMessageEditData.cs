// <auto-generated/>
using System;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getMessageEditData.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesMessageEditData"/>
	/// </summary>
	public partial class TLMessagesGetMessageEditData : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 Id { get; set; }

		public TLMessagesGetMessageEditData() { }
		public TLMessagesGetMessageEditData(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetMessageEditData; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xFDA68D36);
			to.WriteObject(Peer);
			to.Write(Id);
		}
	}
}