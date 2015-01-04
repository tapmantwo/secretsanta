using Domain.Persistence.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnitTests.Fakes
{
    class AddDrawCommand : IAddDraw
    {
        private int newId;

        public AddDrawCommand(int newId)
        {
            this.newId = newId;
        }

        public Domain.Draw Execute(Domain.Draw source)
        {
            return source.SetId(this.newId);
        }
    }
}
