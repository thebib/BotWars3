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
        public List<IPlayer> AvailablePlayers;
        public HttpListener listener;
        
        public GameManager()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:7000/playerregistration/");
            listener.Start();
        }

        public async Task PlayerRegisterCommunications()
        {
            while (true)
            {    
                var context = await listener.GetContextAsync();
                ProcessMessage(context);
            }
        }

        private void ProcessMessage(HttpListenerContext context)
        {
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();
        }
    }
}