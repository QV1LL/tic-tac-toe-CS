using System;

namespace Practice
{
	class ClosedMethodException : Exception
	{
		public ClosedMethodException(string message)
		: base(message)
		{
		}

		public ClosedMethodException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
