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
        public HttpListener listener;
        
        public GameManager()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:7000/");
            listener.Start();
        }

        public async Task Communications()
        {
            while (true)
            {    
                var context = await listener.GetContextAsync();
                ProcessIncomingMessage(context);
            }
        }

        private void ProcessIncomingMessage(HttpListenerContext context)
        {
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();
        }
    }
}