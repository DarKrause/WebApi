//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiMachine.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Напиток_из_торгового_автомата
    {
        public int id { get; set; }
        public Nullable<int> Id_торговый_автомат { get; set; }
        public Nullable<int> Id_напиток { get; set; }
        public Nullable<int> Количество { get; set; }
    
        public virtual Напиток Напиток { get; set; }
        public virtual Торговый_автомат Торговый_автомат { get; set; }
    }
}
