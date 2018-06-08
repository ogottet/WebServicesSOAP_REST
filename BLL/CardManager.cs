using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class CardManager
    {
        public static Card GetCardById( int cardId )
        {
            return CardDB.GetCardById( cardId );
        }

        public static Card GetCardByUsername( string username )
        {
            return CardDB.GetCardByUsername( username );
        }

        // Returns the new quota (-1 if an error occured)
        public static int AddMoney( int cardId, double amount )
        {
            Card c = GetCardById( cardId );
        
            // 0.10 CHF => 1 feuille
            c.Quota = c.Quota + (int) (Math.Round( amount ) * 10);

            int affectedRows = UpdateCardData( c );

            if (affectedRows == -1)
                return -1;
            else
                return c.Quota;
        }

        public static int UpdateCardData( Card c )
        {
            // Returns the number of affected rows (-1 if an error occured)
            return CardDB.UpdateCardData( c );
        }
        public static List<string> GetAllCardIDs( string field )
        {
            // Returns the number of affected rows (-1 if an error occured)
            return CardDB.GetAllCardIDs( field );
        }

        public static List<Card> GetAllCards()
        {
            return CardDB.GetAllCards();
        }

        public static List<Dictionary<string, object>> GetCardsTable()
        {
            return CardDB.GetCardsTable();
        }
    }
}
