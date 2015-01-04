using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Participant
    {
        public Participant(int id, string email, string firstname, string lastname, string letterToSanta, int recipientId)
        {
            Id = id;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
            LetterToSanta = letterToSanta;
            RecipientId = recipientId;
        }

        public Participant(string email, string firstname, string lastname, string letterToSanta, int recipientId)
            :this(0,email,firstname,lastname,letterToSanta, recipientId)
        {
        }

        public int Id { get; private set; }

        public string Email { get; private set; }

        public string Firstname { get; private set; }

        public string Lastname { get; private set; }

        public string LetterToSanta { get; private set; }

        public int RecipientId { get; private set; }

        public Participant SetId(int id)
        {
            return new Participant(id, Email, Firstname, Lastname, LetterToSanta, RecipientId);
        }

        public Participant SetRecipient(int recipientId)
        {
            return new Participant(Id, Email, Firstname, Lastname, LetterToSanta, recipientId);
        }
    }
}
