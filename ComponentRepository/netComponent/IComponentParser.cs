using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netComponent
{
    public interface IComponentParser
    {
        String ParseComponentFile(byte[] file);
    }
}
