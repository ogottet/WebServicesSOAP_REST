﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int CardId { get; set; }
    }
}
