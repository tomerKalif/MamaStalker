﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAbstractions
{
    interface IServer
    {
        public Task StartServer();

        public Task ListenToClients();
    }
}
