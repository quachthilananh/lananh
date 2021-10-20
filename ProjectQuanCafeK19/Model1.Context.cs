﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectQuanCafeK19
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanCafeK19Entities : DbContext
    {
        public QuanCafeK19Entities()
            : base("name=QuanCafeK19Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BILLINFO> BILLINFOes { get; set; }
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<FOODCATEGORY> FOODCATEGORies { get; set; }
        public virtual DbSet<TABLEFOOD> TABLEFOODs { get; set; }
    
        public virtual int DeleteAccount(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAccount", usernameParameter);
        }
    
        public virtual int DeleteBill(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBill", idParameter);
        }
    
        public virtual int DeleteBillInfo(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBillInfo", idParameter);
        }
    
        public virtual int DeleteFood(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFood", idParameter);
        }
    
        public virtual int DeleteFoodCategory(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteFoodCategory", idParameter);
        }
    
        public virtual int DeleteTableFood(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTableFood", idParameter);
        }
    
        public virtual ObjectResult<GetBillInfoForBill_Result> GetBillInfoForBill(Nullable<int> idBill)
        {
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBillInfoForBill_Result>("GetBillInfoForBill", idBillParameter);
        }
    
        public virtual ObjectResult<GetBillInfoForTableFood_Result> GetBillInfoForTableFood(Nullable<int> idTableFood)
        {
            var idTableFoodParameter = idTableFood.HasValue ?
                new ObjectParameter("idTableFood", idTableFood) :
                new ObjectParameter("idTableFood", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetBillInfoForTableFood_Result>("GetBillInfoForTableFood", idTableFoodParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIDBillByIDBillInfo(Nullable<int> idBillInfo)
        {
            var idBillInfoParameter = idBillInfo.HasValue ?
                new ObjectParameter("idBillInfo", idBillInfo) :
                new ObjectParameter("idBillInfo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIDBillByIDBillInfo", idBillInfoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetIDBillLatest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetIDBillLatest");
        }
    
        public virtual ObjectResult<GetListAccount_Result> GetListAccount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListAccount_Result>("GetListAccount");
        }
    
        public virtual ObjectResult<GetListBill_Result> GetListBill()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListBill_Result>("GetListBill");
        }
    
        public virtual ObjectResult<GetListBillInfo_Result> GetListBillInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListBillInfo_Result>("GetListBillInfo");
        }
    
        public virtual ObjectResult<GetListFood_Result> GetListFood()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListFood_Result>("GetListFood");
        }
    
        public virtual ObjectResult<GetListFoodByIDFoodCategory_Result> GetListFoodByIDFoodCategory(Nullable<int> idFoodCategory)
        {
            var idFoodCategoryParameter = idFoodCategory.HasValue ?
                new ObjectParameter("idFoodCategory", idFoodCategory) :
                new ObjectParameter("idFoodCategory", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListFoodByIDFoodCategory_Result>("GetListFoodByIDFoodCategory", idFoodCategoryParameter);
        }
    
        public virtual ObjectResult<GetListFoodCategory_Result> GetListFoodCategory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListFoodCategory_Result>("GetListFoodCategory");
        }
    
        public virtual ObjectResult<GetListTableFood_Result> GetListTableFood()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListTableFood_Result>("GetListTableFood");
        }
    
        public virtual ObjectResult<Nullable<int>> GetTotalPriceByIDBill(Nullable<int> idBill)
        {
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetTotalPriceByIDBill", idBillParameter);
        }
    
        public virtual int InsertAccount(string username, string password, string displayName, Nullable<int> typeAccount, byte[] avatar)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            var typeAccountParameter = typeAccount.HasValue ?
                new ObjectParameter("typeAccount", typeAccount) :
                new ObjectParameter("typeAccount", typeof(int));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertAccount", usernameParameter, passwordParameter, displayNameParameter, typeAccountParameter, avatarParameter);
        }
    
        public virtual int InsertBill(Nullable<int> idTableFood)
        {
            var idTableFoodParameter = idTableFood.HasValue ?
                new ObjectParameter("idTableFood", idTableFood) :
                new ObjectParameter("idTableFood", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBill", idTableFoodParameter);
        }
    
        public virtual int InsertBillInfo(Nullable<int> idBill, Nullable<int> idFood, Nullable<int> count)
        {
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            var idFoodParameter = idFood.HasValue ?
                new ObjectParameter("idFood", idFood) :
                new ObjectParameter("idFood", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBillInfo", idBillParameter, idFoodParameter, countParameter);
        }
    
        public virtual int InsertFood(string name, Nullable<int> idCategory, Nullable<int> cost, Nullable<int> price, Nullable<int> count, byte[] avatar)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var idCategoryParameter = idCategory.HasValue ?
                new ObjectParameter("idCategory", idCategory) :
                new ObjectParameter("idCategory", typeof(int));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("cost", cost) :
                new ObjectParameter("cost", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertFood", nameParameter, idCategoryParameter, costParameter, priceParameter, countParameter, avatarParameter);
        }
    
        public virtual int InsertFoodCategory(string name, byte[] avatar)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertFoodCategory", nameParameter, avatarParameter);
        }
    
        public virtual int InsertTableFood(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertTableFood", nameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> LoginAccount(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LoginAccount", usernameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Report_Result> Report()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Report_Result>("Report");
        }
    
        public virtual ObjectResult<SearchAccountByDisplayName_Result> SearchAccountByDisplayName(string displayName)
        {
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchAccountByDisplayName_Result>("SearchAccountByDisplayName", displayNameParameter);
        }
    
        public virtual ObjectResult<SearchAccountByUsername_Result> SearchAccountByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchAccountByUsername_Result>("SearchAccountByUsername", usernameParameter);
        }
    
        public virtual ObjectResult<SearchBillByDate_Result> SearchBillByDate(Nullable<System.DateTime> dateCheckIn, Nullable<System.DateTime> dateCheckOut)
        {
            var dateCheckInParameter = dateCheckIn.HasValue ?
                new ObjectParameter("dateCheckIn", dateCheckIn) :
                new ObjectParameter("dateCheckIn", typeof(System.DateTime));
    
            var dateCheckOutParameter = dateCheckOut.HasValue ?
                new ObjectParameter("dateCheckOut", dateCheckOut) :
                new ObjectParameter("dateCheckOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchBillByDate_Result>("SearchBillByDate", dateCheckInParameter, dateCheckOutParameter);
        }
    
        public virtual ObjectResult<SearchFoodByName_Result> SearchFoodByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchFoodByName_Result>("SearchFoodByName", nameParameter);
        }
    
        public virtual ObjectResult<SearchFoodCategoryByName_Result> SearchFoodCategoryByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchFoodCategoryByName_Result>("SearchFoodCategoryByName", nameParameter);
        }
    
        public virtual ObjectResult<SearchTableFoodByName_Result> SearchTableFoodByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchTableFoodByName_Result>("SearchTableFoodByName", nameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> TotalBill()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalBill");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalCategory()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalCategory");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalCost()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalCost");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalFood()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalFood");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalPrice()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalPrice");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalProductSold()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalProductSold");
        }
    
        public virtual ObjectResult<Nullable<int>> TotalStaff()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TotalStaff");
        }
    
        public virtual int UpdateAccount(string username, string password, string displayName, Nullable<int> typeAccount, byte[] avatar)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var displayNameParameter = displayName != null ?
                new ObjectParameter("displayName", displayName) :
                new ObjectParameter("displayName", typeof(string));
    
            var typeAccountParameter = typeAccount.HasValue ?
                new ObjectParameter("typeAccount", typeAccount) :
                new ObjectParameter("typeAccount", typeof(int));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAccount", usernameParameter, passwordParameter, displayNameParameter, typeAccountParameter, avatarParameter);
        }
    
        public virtual int UpdateBill(Nullable<int> id, Nullable<int> status, Nullable<int> discount, Nullable<int> totalPrice)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var discountParameter = discount.HasValue ?
                new ObjectParameter("discount", discount) :
                new ObjectParameter("discount", typeof(int));
    
            var totalPriceParameter = totalPrice.HasValue ?
                new ObjectParameter("totalPrice", totalPrice) :
                new ObjectParameter("totalPrice", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBill", idParameter, statusParameter, discountParameter, totalPriceParameter);
        }
    
        public virtual int UpdateBillInfo(Nullable<int> id, Nullable<int> idBill, Nullable<int> idFood, Nullable<int> count)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var idBillParameter = idBill.HasValue ?
                new ObjectParameter("idBill", idBill) :
                new ObjectParameter("idBill", typeof(int));
    
            var idFoodParameter = idFood.HasValue ?
                new ObjectParameter("idFood", idFood) :
                new ObjectParameter("idFood", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBillInfo", idParameter, idBillParameter, idFoodParameter, countParameter);
        }
    
        public virtual int UpdateCountBillInfo(Nullable<int> id, Nullable<int> count)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCountBillInfo", idParameter, countParameter);
        }
    
        public virtual int UpdateFood(Nullable<int> id, string name, Nullable<int> idCategory, Nullable<int> cost, Nullable<int> price, Nullable<int> count, byte[] avatar)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var idCategoryParameter = idCategory.HasValue ?
                new ObjectParameter("idCategory", idCategory) :
                new ObjectParameter("idCategory", typeof(int));
    
            var costParameter = cost.HasValue ?
                new ObjectParameter("cost", cost) :
                new ObjectParameter("cost", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var countParameter = count.HasValue ?
                new ObjectParameter("count", count) :
                new ObjectParameter("count", typeof(int));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateFood", idParameter, nameParameter, idCategoryParameter, costParameter, priceParameter, countParameter, avatarParameter);
        }
    
        public virtual int UpdateFoodCategory(Nullable<int> id, string name, byte[] avatar)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateFoodCategory", idParameter, nameParameter, avatarParameter);
        }
    
        public virtual int UpdateNameTableFood(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateNameTableFood", idParameter, nameParameter);
        }
    
        public virtual int UpdateStatusTableFood(Nullable<int> id, Nullable<int> status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStatusTableFood", idParameter, statusParameter);
        }
    }
}