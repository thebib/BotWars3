using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace BotWars_Battleships
{
    public class GameManager
    {
        public IGame ActiveGame;
        public List<IPlayers> AvailablePlayers;
        public HttpListener PlayerRegistrationListener;
        public GameOptions options;
        
        public GameManager()
        {
            PlayerRegistrationListener = new HttpListener();
            PlayerRegistrationListener.Prefixes.Add("http://localhost:7000/register/");
            PlayerRegistrationListener.Start();
        }

        public async Task Communications()
        {
            while (true)
            {    
                var context = await PlayerRegistrationListener.GetContextAsync();
                ProcessIncomingMessage(context);
            }
        }

        private void ProcessIncomingMessage(HttpListenerContext context)
        {
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();
        }
    }
}