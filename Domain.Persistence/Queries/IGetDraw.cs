using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Queries
{
    public interface IGetDraw
    {
        Draw Execute(int id);

        Draw Execute(Guid id);
    }
}
