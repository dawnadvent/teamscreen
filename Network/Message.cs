﻿using System;
using LiteNetLib.Utils;

namespace Network
{
	public abstract class Message
	{
		public ushort MessageType { get; private set; }

		protected Message(ushort messageType)
		{
			MessageType = messageType;
		}

		public virtual void WritePayload(NetDataWriter message)
		{
			message.Put(MessageType);
		}

		public virtual void ReadPayload(NetDataReader message)
		{
		}
	}
}