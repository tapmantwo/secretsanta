using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Commands
{
    public interface IAddDraw
    {
        Draw Execute(Draw source);
    }
}
