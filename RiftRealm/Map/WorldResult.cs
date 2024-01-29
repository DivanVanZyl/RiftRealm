using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiftRealm.Map
{
    public class WorldResult<T>
    {
        public T? Data;
        public string Message = string.Empty;
        public bool Success = true;
    }
}
