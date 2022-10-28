using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barquitos.Clases
{
    public class Sala
    {
        public string HostName { get; set; }
        public string Player2 { get; set; }
        public string Password { get; set; }

        public Sala()
        {
            this.HostName = "player1";
            this.Player2 = "player1";
            this.Password = "";
        }
    }
}
