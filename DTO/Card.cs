using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class Card
    {
        [DataMember]
        public int CardId { get; set; }
        [DataMember]
        public int Quota { get; set; }
        [DataMember]
        public string Username { get; set; }
    }
}
