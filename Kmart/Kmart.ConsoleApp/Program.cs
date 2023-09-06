
using Kmart.Core.Implementation;
using Kmart.Core.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;


Log.Logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger();

static IHost AppStartup()
{

    var host = Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) => {
            services.AddSingleton<ILongestIncreasingSubsequenceService, LongestIncreasingSubsequenceService>();
            services.AddSingleton(Log.Logger);
        })
        .Build();

    return host;
}


var host = AppStartup();

var inputString = "6 2 4 6 1 5 9 2";

var longestIncreasingSubsequenceService = ActivatorUtilities.CreateInstance<LongestIncreasingSubsequenceService>(host.Services);
var longestIncreasingSubsequence = longestIncreasingSubsequenceService.FindLongestIncreasingSubsequence(
                                                                        longestIncreasingSubsequenceService.CovertStringToList(inputString).ToList());