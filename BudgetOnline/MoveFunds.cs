//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetOnline
{
    using System;
    using System.Collections.Generic;
    
    public partial class MoveFunds
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MoveFunds()
        {
            this.MoveFundDetails = new HashSet<MoveFundDetails>();
        }
    
        public int ID { get; set; }
        public int FromAccountsID { get; set; }
        public int ToAccountsID { get; set; }
        public Nullable<System.DateTime> DateTimeMove { get; set; }
        public string Description { get; set; }
        public int UsersID { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual Accounts Accounts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MoveFundDetails> MoveFundDetails { get; set; }
    }
}
