using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AndreFischbacherApp.Functions.v1.Timer
{
    public class FunctionWarmingTimerTriggerFunction
	{
		[Disable]
		[FunctionName("FunctionWarmingTimerTriggerFunction")]
		public void Run([TimerTrigger("0 */10 * * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
		{
		}
	}
}
