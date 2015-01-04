using Domain;
using Domain.Persistence.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.UnitTests.Fakes
{
    class GetDrawQuery : IGetDraw
    {
        private IEnumerable<Draw> draws;

        public GetDrawQuery(IEnumerable<Draw> draws)
        {
            this.draws = draws;
        }

        public Draw Execute(int id)
        {
            return this.draws.FirstOrDefault(d => d.Id == id);
        }

        public Draw Execute(Guid guid)
        {
            return this.draws.FirstOrDefault(d => d.Guid == guid);
        }
    }
}
