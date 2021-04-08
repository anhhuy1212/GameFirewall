using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DTOProject.DTO
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TcpClient client { get; set; }
        public Player()
        {

        }
    }
}
