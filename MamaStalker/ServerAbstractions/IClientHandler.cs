using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAbstractions
{
    public interface IClientHandler
    {
        public Task SendToClient();

        public Task ReciveFromClient();

        public Task RunClient();
    }
}
