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
    
    public partial class udf_CreditLines_Result
    {
        public int ID { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public Nullable<int> IsClose { get; set; }
        public decimal AllAmount { get; set; }
        public Nullable<decimal> Percent { get; set; }
        public Nullable<int> CountPays { get; set; }
        public Nullable<int> PeriodPaysType { get; set; }
        public int CreditorAccountsID { get; set; }
        public int BorrowerAccountsID { get; set; }
        public string Description { get; set; }
        public Nullable<int> Type { get; set; }
        public int UsersID { get; set; }
    }
}
