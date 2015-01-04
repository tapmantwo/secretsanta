using Domain;
using Domain.Persistence.Commands;
using Domain.Persistence.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class ParticipantController : Controller
    {
        private IAddParticipant addParticipantCommand;
        private IUpdateParticipant updateParticipantCommand;
        private ISetRecipient setRecipientCommand;
        private IListParticipants listRecipientQuery;
        private IGetParticipant getRecipientQuery;

        public ParticipantController(
            IAddParticipant addParticipantCommand, 
            IUpdateParticipant updateParticipantCommand, 
            ISetRecipient setRecipientCommand,
            IListParticipants listRecipientQuery,
            IGetParticipant getRecipientQuery)
        {
            this.addParticipantCommand = addParticipantCommand;
            this.updateParticipantCommand = updateParticipantCommand;
            this.setRecipientCommand = setRecipientCommand;
            this.listRecipientQuery = listRecipientQuery;
            this.getRecipientQuery = getRecipientQuery;
        }

        // GET: List participants for a draw
        public IEnumerable<Participant> List(int drawId)
        {
            return this.listRecipientQuery.Execute(drawId);
        }

        // GET: A particular participant
        public Participant Index(int participantId)
        {
            return this.getRecipientQuery.Execute(participantId);
        }

        // POST: Add a new participant to a draw
        public Participant Create(int drawId, string email, string firstname, string lastname, string letterToSanta)
        {
            return this.addParticipantCommand.Execute(drawId, email, firstname, lastname, letterToSanta);
        }

        // PUT: Update a participant
        public Participant Update(int participantId, string email, string firstname, string lastname, string letterToSanta)
        {
            return this.updateParticipantCommand.Execute(participantId, email, firstname, lastname, letterToSanta);
        }

        // PATCH: Set the recipient
        public Participant Picked(int participantId, int pickedId)
        {
            return this.setRecipientCommand.Execute(participantId, pickedId);
        }
    }
}