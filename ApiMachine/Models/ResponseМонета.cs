using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiMachine.Entities;

namespace ApiMachine.Models
{
    public class ResponseМонета
    {
        public ResponseМонета(Монета монета)
        {
            this.id = монета.id;
            this.Номинал = монета.Номинал;
        }
        public int id { get; set; }
        public Nullable<int> Номинал { get; set; }
    }
    
}