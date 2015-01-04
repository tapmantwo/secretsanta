using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Domain.Persistence.Commands;
using Domain.Persistence.Queries;

namespace Api.Controllers
{
    public class DrawController : Controller
    {
        private readonly IAddDraw addDrawCommand;

        private readonly IGetDraw getDrawQuery;

        public DrawController(IAddDraw addDrawCommand, IGetDraw getDrawQuery)
        {
            this.addDrawCommand = addDrawCommand;
            this.getDrawQuery = getDrawQuery;
        }

        [HttpGet]
        public Draw Index(int id)
        {
            return this.getDrawQuery.Execute(id);
        }

        [HttpPost]
        public Draw Create(int drawmasterId, string information, DateTime? drawDate)
        {
            var drawGuid = Guid.NewGuid();
            var draw = new Draw(drawmasterId, drawGuid, drawDate, information);
            var saved = this.addDrawCommand.Execute(draw);
            return saved;
        }
    }
}