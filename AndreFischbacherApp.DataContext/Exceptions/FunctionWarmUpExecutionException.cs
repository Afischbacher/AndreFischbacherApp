using System;
using System.Collections.Generic;
using System.Text;

namespace AndreFischbacherApp.DataContext.Exceptions
{
	public class FunctionWarmUpExecutionException : Exception
	{
		public FunctionWarmUpExecutionException(string message = "Failed to warm up Azure functions") : base(message)
		{

		}
	}
}
