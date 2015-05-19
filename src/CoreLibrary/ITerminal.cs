using System;

namespace SoftCircuitLibrary.Core
{
	public interface ITerminal
	{
		event CoreDelegates.CurrentDetectionHandler CurrentDetection;
		
		bool ConnectToNode(ICircuitNode circuitNode);
		
		bool ConnectToGround();				
		
		bool IsGrounded { get; }
		
		bool ConnectToSupplyVoltage(ISupplyVoltageDC supplyVoltage);
		
		CircuitNodes ConnectedNodes { get; }
	}
}

