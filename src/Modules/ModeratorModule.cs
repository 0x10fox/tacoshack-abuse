using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace crackdotnet.Modules
{
    [Name("moderator")]
    [RequireContext(ContextType.Guild)]
    public class ModeratorModule : ModuleBase<SocketCommandContext>
    {
        
    }
}
