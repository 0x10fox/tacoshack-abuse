using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;
//using System.Threading;

namespace crackdotnet.Modules
{
    [Name("tacoshack abuse")]
    [RequireContext(ContextType.Guild)]
    public class AbuseModule : ModuleBase<SocketCommandContext>
    {
        public bool isStarted = false;
        [Command("start")]
        [Summary("begin the shitshow")]
        [Remarks("start")]
        public async Task Command_ShitAsync()
        {
            bool _waitUntilTrue = false;
            bool _waitUntilTrue2 = false;
            bool hasExecuted = false;
            Timer timer = new Timer(600000);
            Timer timer2 = new Timer(4900);

            timer.Elapsed += delegate { _waitUntilTrue = true; };
            timer.AutoReset = true;
            timer2.Elapsed += delegate { _waitUntilTrue2 = true; };
            timer2.AutoReset = false;
            isStarted = true;
            var initial = await ReplyAsync("abuse started").ConfigureAwait(false);
            timer.Start();

            while (isStarted == true)
            {
                hasExecuted = true;
                System.Threading.SpinWait.SpinUntil(() => _waitUntilTrue);
                
                await ReplyAsync("!work");
                //timer.Stop();
            }
            timer.Stop();
        }

        [Command("stop")]
        [Summary("stop this shit")]
        public async Task Command_UnShitAsync()
        {
            isStarted = false;
        }
    }
}

