﻿using System;

namespace SEGate.Logic.LLAPI.Abstractions
{
	public interface IServerboundPacketMapping
	{
		public int PacketIdFromType<T>() => PacketIdFromType(typeof(T));
		public int PacketIdFromType(Type packet);
	}
}
