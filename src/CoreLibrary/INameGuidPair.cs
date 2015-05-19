using System;

namespace SoftCircuitLibrary.Core
{
	public interface INameGuidPair
	{
		Guid Id { get; }
		string Name { get; }
	}
}

