using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Commands
{
    public interface IAddParticipant
    {
        Participant Execute(int drawId, string email, string firstname, string lastname, string letterToSanta);
    }
}
