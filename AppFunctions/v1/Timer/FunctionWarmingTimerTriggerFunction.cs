using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AndreFischbacherApp.Functions.v1.Timer
{
    public class FunctionWarmingTimerTriggerFunction
	{
		[FunctionName("FunctionWarmingTimerTriggerFunction")]
		public async Task Run([TimerTrigger("0 */1 * * * *", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
		{
		}
	}
}
