using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrintCardServiceREST.Controllers
{
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("usernames")]
        public IEnumerable<string> GetUsernames()
        {
            List<User> users = UserManager.GetAllUsers();
            List<string> usernames = new List<string>();

            foreach (User u in users)
            {
                usernames.Add(u.Username);
            }

            return usernames;
        }

        [HttpGet]
        [Route("userids")]
        public IEnumerable<int> GetUserIds()
        {
            List<User> users = UserManager.GetAllUsers();
            List<int> userids = new List<int>();

            foreach (User u in users)
            {
                userids.Add(u.Id);
            }

            return userids;
        }

        [HttpGet]
        [Route("cardids")]
        public IEnumerable<int> GetCardIds()
        {
            List<Card> cards = CardManager.GetAllCards();
            List<int> cardids = new List<int>();

            foreach (Card c in cards)
            {
                cardids.Add(c.CardId);
            }

            return cardids;
        }

        [HttpGet]
        [Route("userstable")]
        public IEnumerable<Dictionary<string, object>> GetUsersTable()
        {
            return UserManager.GetUsersTable();
        }

        [HttpGet]
        [Route("cardstable")]
        public IEnumerable<Dictionary<string, object>> GetCardsTable()
        {
            return CardManager.GetCardsTable();
        }
    }
}