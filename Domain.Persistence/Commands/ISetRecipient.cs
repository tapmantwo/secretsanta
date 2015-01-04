using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence.Commands
{
    public interface ISetRecipient
    {
        Participant Execute(int participantId, int recipientId);
    }
}
