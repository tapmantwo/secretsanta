using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Draw
    {
        public Draw(int id, int drawMasterId, Guid guid, DateTime? drawDate, string information)
        {
            Id = id;
            Guid = guid;
            DrawDate = drawDate;
            Information = information;
            DrawMasterId = drawMasterId;
        }

        public Draw(int drawMasterId, Guid guid, DateTime? drawDate, string information)
            :this(0, drawMasterId, guid, drawDate, information)
        {
        }

        public int Id { get; private set; }

        public Guid Guid { get; private set; }

        public DateTime? DrawDate { get; private set; }

        public string Information { get; private set; }

        public int DrawMasterId { get; set; }

        public Draw SetId(int id)
        {
            return new Draw(id, DrawMasterId, Guid, DrawDate, Information);
        }

        public Draw SetDrawDate(DateTime? drawDate)
        {
            return new Draw(Id, DrawMasterId, Guid, drawDate, Information);
        }
    }
}
