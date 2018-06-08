using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BLL;
using DTO;

namespace WcFPrintCardServiceSOAP
{
    public class PrintCardService : IPrintCardService
    {
        public int RechargeByUserId(int userId, double amount)
        {
            User user = UserManager.GetUserById(userId);
            return RechargePrinterQuota(user.CardId, amount);
        }

        public int RechargeByUserName(string username, double amount)
        {
            User user = UserManager.GetUserByUsername(username);
            return RechargePrinterQuota(user.CardId, amount);
        }

        public int RechargePrinterQuota(int cardId, double amount)
        {
            return CardManager.AddMoney(cardId, amount);
        }
    }
}
