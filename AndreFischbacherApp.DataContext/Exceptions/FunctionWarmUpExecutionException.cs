using System;
using System.Collections.Generic;
using System.Text;

namespace AndreFischbacherApp.DataContext.Exceptions
{
	public class FunctionWarmUpExecutionException : Exception
	{
		public FunctionWarmUpExecutionException(string message, Exception exception = null) : base(message, exception)
		{

		}
	}
}
