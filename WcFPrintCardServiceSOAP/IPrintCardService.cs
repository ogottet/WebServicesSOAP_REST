using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcFPrintCardServiceSOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPrintCardService
    {

        [OperationContract]
        int RechargeByUserId(int userId, double amount);

        [OperationContract]
        int RechargeByUserName(string username, double amount);

        [OperationContract]
        int RechargePrinterQuota(int cardId, double amount);
    }
}
