using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Queries
{
    public interface IGetParticipant
    {
        Participant Execute(int id);
    }
}
