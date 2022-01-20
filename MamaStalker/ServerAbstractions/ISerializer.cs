using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerAbstractions
{
    public interface ISerializer
    {
        public Task<string> serializeObject();
    }
}
