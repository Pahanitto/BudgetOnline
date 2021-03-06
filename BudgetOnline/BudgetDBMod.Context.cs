﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BudgetEntities : DbContext
    {
        public BudgetEntities()
            : base("name=BudgetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<CreditLineDetails> CreditLineDetails { get; set; }
        public virtual DbSet<CreditLines> CreditLines { get; set; }
        public virtual DbSet<MoveFundDetails> MoveFundDetails { get; set; }
        public virtual DbSet<MoveFunds> MoveFunds { get; set; }
        public virtual DbSet<ReasonGroups> ReasonGroups { get; set; }
        public virtual DbSet<Reasons> Reasons { get; set; }
        public virtual DbSet<ReasonSynonyms> ReasonSynonyms { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Towns> Towns { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<СontractorGroups> СontractorGroups { get; set; }
        public virtual DbSet<Сontractors> Сontractors { get; set; }
        public virtual DbSet<СontractorTypes> СontractorTypes { get; set; }
    
        [DbFunction("BudgetEntities", "udf_Accounts")]
        public virtual IQueryable<udf_Accounts_Result> udf_Accounts(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Accounts_Result>("[BudgetEntities].[udf_Accounts](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_CreditLineDetails")]
        public virtual IQueryable<udf_CreditLineDetails_Result> udf_CreditLineDetails(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_CreditLineDetails_Result>("[BudgetEntities].[udf_CreditLineDetails](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_CreditLines")]
        public virtual IQueryable<udf_CreditLines_Result> udf_CreditLines(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_CreditLines_Result>("[BudgetEntities].[udf_CreditLines](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_MoveFundDetails")]
        public virtual IQueryable<udf_MoveFundDetails_Result> udf_MoveFundDetails(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_MoveFundDetails_Result>("[BudgetEntities].[udf_MoveFundDetails](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_MoveFunds")]
        public virtual IQueryable<udf_MoveFunds_Result> udf_MoveFunds(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_MoveFunds_Result>("[BudgetEntities].[udf_MoveFunds](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_ReasonGroups")]
        public virtual IQueryable<udf_ReasonGroups_Result> udf_ReasonGroups(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_ReasonGroups_Result>("[BudgetEntities].[udf_ReasonGroups](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_Reasons")]
        public virtual IQueryable<udf_Reasons_Result> udf_Reasons(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Reasons_Result>("[BudgetEntities].[udf_Reasons](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_ReasonSynonyms")]
        public virtual IQueryable<udf_ReasonSynonyms_Result> udf_ReasonSynonyms(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_ReasonSynonyms_Result>("[BudgetEntities].[udf_ReasonSynonyms](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_Towns")]
        public virtual IQueryable<udf_Towns_Result> udf_Towns(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Towns_Result>("[BudgetEntities].[udf_Towns](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_Units")]
        public virtual IQueryable<udf_Units_Result> udf_Units(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Units_Result>("[BudgetEntities].[udf_Units](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_СontractorGroups")]
        public virtual IQueryable<udf_СontractorGroups_Result> udf_СontractorGroups(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_СontractorGroups_Result>("[BudgetEntities].[udf_СontractorGroups](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_Сontractors")]
        public virtual IQueryable<udf_Сontractors_Result> udf_Сontractors(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_Сontractors_Result>("[BudgetEntities].[udf_Сontractors](@Userid)", useridParameter);
        }
    
        [DbFunction("BudgetEntities", "udf_СontractorTypes")]
        public virtual IQueryable<udf_СontractorTypes_Result> udf_СontractorTypes(Nullable<int> userid)
        {
            var useridParameter = userid.HasValue ?
                new ObjectParameter("Userid", userid) :
                new ObjectParameter("Userid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<udf_СontractorTypes_Result>("[BudgetEntities].[udf_СontractorTypes](@Userid)", useridParameter);
        }
    }
}
