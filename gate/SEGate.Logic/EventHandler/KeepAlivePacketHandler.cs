﻿using SEGate.Logic.Abstractions;
using SEGate.Logic.LLAPI.Play.Shared;

namespace SEGate.Logic.EventHandler
{
	public class KeepAlivePacketHandler : IEventHandler<KeepAlivePacket>
	{
		public void Consume(IAgentConnection agentConnection, KeepAlivePacket packetData)
		{
			agentConnection.Send(packetData);
		}
	}
}
