using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiMachine.Entities;

namespace ApiMachine.Models
{
    public class ResponseCoinsInMachine
    {
        public ResponseCoinsInMachine (Монета_в_торговом_автомате монета_В_Торговом_Автомате)
        {
            this.id = монета_В_Торговом_Автомате.id;
            this.Id_торговый_автомат = монета_В_Торговом_Автомате.Id_торговый_автомат;
            this.Id_монета = монета_В_Торговом_Автомате.Id_монета;
            this.Количество = монета_В_Торговом_Автомате.Количество;
            this.Активный = монета_В_Торговом_Автомате.Активный;
        }
        public int id { get; set; }
        public Nullable<int> Id_торговый_автомат { get; set; }
        public Nullable<int> Id_монета { get; set; }
        public Nullable<int> Количество { get; set; }
        public Nullable<int> Активный { get; set; }
    }
}