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

    public partial class CreditLineDetails
    {
        public int ID { get; set; }
        public System.DateTime DatePay { get; set; }
        public decimal Amount { get; set; }
        public int CreditLinesID { get; set; }
        public Nullable<int> Type { get; set; }
        public int UsersID { get; set; }
    
        public virtual CreditLines CreditLines { get; set; }
    }
}