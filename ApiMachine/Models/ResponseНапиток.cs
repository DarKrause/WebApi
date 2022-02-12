using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiMachine.Entities;

namespace ApiMachine.Models
{
    public class ResponseНапиток
    {
        public ResponseНапиток(Напиток напиток)
        {
            this.id = напиток.id;
            this.Название = напиток.Название;
            this.Фото = напиток.Фото;
            this.Стоимость = напиток.Стоимость;
        }
        public int id { get; set; }
        public string Название { get; set; }
        public byte[] Фото { get; set; }
        public Nullable<decimal> Стоимость { get; set; }
    }
}