﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampusFleaMarket.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CampusFleaMarketDBEntities : DbContext
    {
        public CampusFleaMarketDBEntities()
            : base("name=CampusFleaMarketDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CategoryOfGoods> CategoryOfGoods { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<GoodsComments> GoodsComments { get; set; }
        public DbSet<MessageComments> MessageComments { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<ShopRecords> ShopRecords { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
