using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiMachine.Entities;

namespace ApiMachine.Models
{
    public class ResponseDrinksInMachine
    {
        public ResponseDrinksInMachine(Напиток_из_торгового_автомата напиток_Из_Торгового_Автомата)
        {
            this.id = напиток_Из_Торгового_Автомата.id;
            this.Id_торговый_автомат = напиток_Из_Торгового_Автомата.Id_торговый_автомат;
            this.Id_напиток = напиток_Из_Торгового_Автомата.Id_напиток;
            this.Количество = напиток_Из_Торгового_Автомата.Количество;
            
        }
        public int id { get; set; }
        public Nullable<int> Id_торговый_автомат { get; set; }
        public Nullable<int> Id_напиток { get; set; }
        public Nullable<int> Количество { get; set; }
    }
}