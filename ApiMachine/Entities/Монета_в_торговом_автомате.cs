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
    
    public partial class Монета_в_торговом_автомате
    {
        public int id { get; set; }
        public Nullable<int> Id_торговый_автомат { get; set; }
        public Nullable<int> Id_монета { get; set; }
        public Nullable<int> Количество { get; set; }
        public Nullable<int> Активный { get; set; }
    
        public virtual Монета Монета { get; set; }
        public virtual Торговый_автомат Торговый_автомат { get; set; }
    }
}
