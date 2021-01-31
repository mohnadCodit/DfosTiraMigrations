namespace DfosTiraMigration.Models.GoMakeModels
{
    using System.Linq;
    using System.Data.Entity;
    using DfosTiraMigration.Models.GoMakeModels.Products;
    using System.Collections.Generic;
    using DfosTiraMigration.Models.GoMakeModels.BoardModels;
    using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
    using System.ComponentModel.DataAnnotations.Schema;
    using DfosTiraMigration.Models.GoMakeModels.PriceLists;
    using DfosTiraMigration.Models.GoMakeModels.Tracking;
    using DfosTiraMigration.Models.GoMakeModels.Logs;
    using System.Web;
    using System.Data;
    using DfosTiraMigration.Models.GoMakeModels.Gomake_API;

    public partial class GoMakeDbContext : DbContext
    {
      
        public GoMakeDbContext()
            : base("name=GoMakeDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        // ----------- Price Lists -----------
        public virtual DbSet<Cover> Covers { get; set; }
        public virtual DbSet<Paper> Papers { get; set; }
        public virtual DbSet<Scodix> Scodixes { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<SheetsType> SheetsTypes { get; set; }
        public virtual DbSet<IntireColumn> IntireColumns { get; set; }
        public virtual DbSet<BidItemValue> BidItemValues { get; set; }
        public virtual DbSet<MinimumProfit> MinimumProfits { get; set; }
        public virtual DbSet<IgnoredPricing> IgnoredPricing { get; set; }
        public virtual DbSet<BidMissionNote> BidMissionNotes { get; set; }
        public virtual DbSet<BooksItemValue> BooksItemValues { get; set; }
        public virtual DbSet<OOMinimumProfit> OOMinimumProfits { get; set; }
        public virtual DbSet<PriceListsPaper> PriceListsPapers { get; set; }
        public virtual DbSet<ScodixItemValue> ScodixItemValues { get; set; }
        public virtual DbSet<CuttingItemValue> CuttingItemValues { get; set; }
        public virtual DbSet<PercentageProfit> PercentageProfits { get; set; }
        public virtual DbSet<NotepadItemValue> NotepadItemValues { get; set; }
        public virtual DbSet<PrintingItemWork> PrintingItemWorks { get; set; }
        public virtual DbSet<ItemSpecialColor> ItemSpecialColors { get; set; }
        public virtual DbSet<DigitalItemValue> DigitalItemValues { get; set; }
        public virtual DbSet<GlassesItemValue> GlassesItemValues { get; set; }
        public virtual DbSet<PrintingItemValue> PrintingItemValues { get; set; }
        public virtual DbSet<MachineSheetsCost> MachineSheetsCosts { get; set; }
        public virtual DbSet<PriceListsMachine> PriceListsMachines { get; set; }
        public virtual DbSet<ProductsItemValue> ProductsItemValues { get; set; }
        public virtual DbSet<OOPercentageProfit> OOPercentageProfits { get; set; }
        public virtual DbSet<EnvelopesItemValue> EnvelopesItemValues { get; set; }
        public virtual DbSet<PriceListParameter> PriceListParameters { get; set; }
        public virtual DbSet<MinimumProfitsGroup> MinimumProfitsGroups { get; set; }
        public virtual DbSet<OOMinimumProfitsGroup> OOMinimumProfitsGroups { get; set; }
        public virtual DbSet<ShelfProductsItemValue> ShelfProductsItemValues { get; set; }
        public virtual DbSet<PriceListsPapersDetail> PriceListsPapersDetails { get; set; }
        public virtual DbSet<PercentageProfitsGroup> PercentageProfitsGroups { get; set; }
        public virtual DbSet<OOPercentageProfitsGroup> OOPercentageProfitsGroups { get; set; }
        public virtual DbSet<PriceListParametersBoard> PriceListParametersBoards { get; set; }
        public virtual DbSet<OrderItemParametersStatus> OrderItemParametersStatuses { get; set; }
        public virtual DbSet<QuoteItemParametersStatuses> QuoteItemParametersStatuses { get; set; }
        public virtual DbSet<PriceListsPaperDetailsMachine> PriceListsPaperDetailsMachines { get; set; }


        // ----------- Products -----------
        public virtual DbSet<SubProduct> SubProducts { get; set; }
        public virtual DbSet<MainProduct> MainProducts { get; set; }
        public virtual DbSet<ProductsPrice> ProductsPrices { get; set; }
        public virtual DbSet<ProductsGroup> ProductsGroups { get; set; }
        public virtual DbSet<ProductsParameter> ProductsParameters { get; set; }
        public virtual DbSet<SubProductSupplier> SubProductSuppliers { get; set; }
        public virtual DbSet<MainProductSupplier> MainProductSuppliers { get; set; }
        public virtual DbSet<SubProductParameter> SubProductParameters { get; set; }
        public virtual DbSet<ProductsGroupsRelation> ProductsGroupsRelations { get; set; }

        // ----------- Orders & Quotes -----------
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<QuoteItem> QuoteItems { get; set; }
        public virtual DbSet<OrderFile> OrderFiles { get; set; }
        public virtual DbSet<OrderItemFile> OrderItemFiles { get; set; }
        public virtual DbSet<QuoteItemFile> QuoteItemFiles { get; set; }
        public virtual DbSet<OrderItemFileImage> OrderItemFileImages { get; set; }
        public virtual DbSet<OrdersTracking> OrdersTracking { get; set; }
        public virtual DbSet<OrdersTrackingPayment> OrdersTrackingPayments { get; set; }

        // ----------- Reports -----------
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportsRelation> ReportsRelations { get; set; }

        // ----------- Boards -----------
        public virtual DbSet<Boards> Boards { get; set; }
        public virtual DbSet<BoardRows> BoardRows { get; set; }
        public virtual DbSet<BoardUsers> BoardUsers { get; set; }
        public virtual DbSet<BoardColumns> BoardColumns { get; set; }
        public virtual DbSet<BoardMissions> BoardMissions { get; set; }
        public virtual DbSet<BoardUserPermission> BoardUserPermissions { get; set; }

        // ----------- Logs -----------
        public virtual DbSet<OrdersLog> OrderLogs { get; set; }
        public virtual DbSet<BoardMissionsLog> BoardMissionsLogs { get; set; }
        public virtual DbSet<QuotesLog> QuotesLogs { get; set; }
        public virtual DbSet<GeneralUsersLog> GeneralUsersLogs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<ForgotPassword> ForgotPasswords { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Artworks> Artworks { get; set; }
        public virtual DbSet<Shtansim> Shtansims { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Analytic> Analyitics { get; set; }
        public virtual DbSet<AllowedIP> AllowedIPs { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<RelatedFile> RelatedFiles { get; set; }
        public virtual DbSet<Instruction> Instructions { get; set; }
        public virtual DbSet<SMSTemplate> SMSTemplates { get; set; }
        public virtual DbSet<GroupArtworks> GroupArtworks { get; set; }
        public virtual DbSet<InstructionsGroup> InstructionsGroups { get; set; }
        public virtual DbSet<WorkDirectoryGroup> WorkDirectoryGroups { get; set; }
        public virtual DbSet<BidItemValueShtansim> BidItemValueShtansim { get; set; }
        public virtual DbSet<ArtWorksResponseImage> ArtWorksResponseImages { get; set; }
        public virtual DbSet<ScriptFileLastAccess> ScriptFileLastAccesses { get; set; }
        public virtual DbSet<RolesPermissionsRelationship> RolesPermissionsRelationships { get; set; }
        public virtual DbSet<WorkDirectory> WorkDirectories { get; set; }
        public virtual DbSet<MailProvider> MailProviders { get; set; }
        public virtual DbSet<LoginSession> LoginSessions { get; set; }
        public virtual DbSet<ForceLoginRequest> ForceLoginRequests { get; set; }
        public virtual DbSet<PrintHouseFeatures> PrintHouseFeatures { get; set; }//PermissionsGroups
        public virtual DbSet<PermissionsGroup> PermissionsGroups { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            /*modelBuilder.Entity<Client>()
                .HasMany(e => e.MainProductSuppliers)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.ClientId)
              
                .WillCascadeOnDelete(false);
         

            modelBuilder.Entity<Client>()
                .HasMany(e => e.SubProductSuppliers)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
                .HasMany(e => e.PriceListParameters)
                .WithRequired(e => e.PriceList)
                .HasForeignKey(e => e.PriceListId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupArtworks>()
                .HasMany(e => e.Artworks)
                .WithOptional(e => e.GroupArtworks)
                .HasForeignKey(e => e.GroupArtworksKey);

            modelBuilder.Entity<Boards>()
                .HasMany(e => e.BoardColumns)
                .WithRequired(e => e.Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Boards>()
                .HasMany(e => e.BoardRows)
                .WithRequired(e => e.Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientType>()
                .HasMany(e => e.PercentageProfitsGroups)
                .WithRequired(e => e.ClientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PercentageProfitsGroup>()
               .HasMany(e => e.PercentageProfits)
               .WithRequired(e => e.PercentageProfitsGroup)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientType>()
              .HasMany(e => e.OOPercentageProfitsGroups)
              .WithRequired(e => e.ClientType)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<OOPercentageProfitsGroup>()
               .HasMany(e => e.OOPercentageProfits)
               .WithRequired(e => e.OOPercentageProfitsGroup)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<OOMinimumProfitsGroup>()
                .HasMany(e => e.OOMinimumProfits)
                .WithRequired(e => e.OOMinimumProfitsGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
               .HasMany(e => e.PercentageProfitsGroups)
               .WithOptional(e => e.PriceList)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<MainProduct>()
               .HasMany(e => e.PercentageProfitsGroups)
               .WithOptional(e => e.MainProduct)
               .HasForeignKey(e => e.MainProductId);

            modelBuilder.Entity<Boards>()
                .HasMany(e => e.BoardMissions)
                .WithRequired(e => e.Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoardMissions>()
                .HasMany(e => e.BoardMissionsLogs)
                .WithRequired(e => e.BoardMission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MinimumProfitsGroup>()
                .HasMany(e => e.MinimumProfits)
                .WithRequired(e => e.MinimumProfitsGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Boards>()
                .HasMany(e => e.BoardUsers)
                .WithRequired(e => e.Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
               .HasMany(e => e.Clients)
               .WithOptional(e => e.Agent)
               .HasForeignKey(e => e.AgentId);

            modelBuilder.Entity<Artworks>()
                .HasMany(e => e.ArtWorksResponseImages)
                .WithRequired(e => e.Artworks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Paper>()
               .HasMany(e => e.PriceListsPapers)
               .WithRequired(e => e.Paper)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
               .HasMany(e => e.PriceListsPapers)
               .WithRequired(e => e.PriceList)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
               .HasMany(e => e.Orders)
               .WithOptional(e => e.Agent)
               .HasForeignKey(e => e.AgentId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Quotes)
                .WithOptional(e => e.Agent)
                .HasForeignKey(e => e.AgentId);

            modelBuilder.Entity<PriceListsPaper>()
                .HasMany(e => e.PriceListsPapersDetails)
                .WithRequired(e => e.PriceListsPaper)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListsMachine>()
               .HasMany(e => e.PriceListsPaperDetailsMachines)
               .WithRequired(e => e.PriceListsMachine)
               .HasForeignKey(e => e.PriceListMachineId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListsPapersDetail>()
              .HasMany(e => e.PriceListsPaperDetailsMachines)
              .WithRequired(e => e.PriceListsPapersDetail)
              .HasForeignKey(e => e.PriceListsPapersDetailsId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
             .HasMany(e => e.OrderItemParametersStatuses)
             .WithOptional(e => e.Supplier)
             .HasForeignKey(e => e.SupplierId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
             .HasMany(e => e.QuoteItemParametersStatuses)
             .WithOptional(e => e.Supplier)
             .HasForeignKey(e => e.SupplierId)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Machine>()
               .HasMany(e => e.PriceListsMachines)
               .WithRequired(e => e.Machine)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceList>()
               .HasMany(e => e.PriceListsMachines)
               .WithRequired(e => e.PriceList)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListsMachine>()
                .HasMany(e => e.MachineSheetsCosts)
                .WithRequired(e => e.PriceListsMachine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SheetsType>()
               .HasMany(e => e.MachineSheetsCosts)
               .WithRequired(e => e.SheetsType)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Reports)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InstructionsGroup>()
               .HasMany(e => e.Instructions)
               .WithRequired(e => e.InstructionsGroup)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkDirectoryGroup>()
               .HasMany(e => e.WorkDirectories)
               .WithRequired(e => e.WorkDirectoryGroup)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Image)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdersTracking>()
                .HasMany(e => e.OrdersTrackingPayments)
                .WithRequired(e => e.OrdersTracking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListParameter>()
               .HasMany(e => e.SubProductParameters)
               .WithRequired(e => e.PriceListParameter)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Boards>()
                .HasMany(e => e.PriceListParametersBoards)
                .WithRequired(e => e.Board)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductsGroup>()
               .HasMany(e => e.ProductsGroupsRelations)
               .WithRequired(e => e.ProductsGroup)
               .HasForeignKey(e => e.GroupID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubProduct>()
               .HasMany(e => e.OrderItems)
               .WithRequired(e => e.SubProduct)
               .HasForeignKey(e => e.ProductID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubProduct>()
               .HasMany(e => e.PriceListItems)
               .WithRequired(e => e.SubProduct)
               .HasForeignKey(e => e.ProductID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
               .HasMany(e => e.GeneralUsersLogs)
               .WithRequired(e => e.User)
               .HasForeignKey(e => e.UserId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
              .HasMany(e => e.BoardMissionsLogs)
              .WithRequired(e => e.User)
              .HasForeignKey(e => e.UserId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
              .HasMany(e => e.OrdersLogs)
              .WithRequired(e => e.User)
              .HasForeignKey(e => e.UserId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
              .HasMany(e => e.QuotesLogs)
              .WithRequired(e => e.User)
              .HasForeignKey(e => e.UserId)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubProduct>()
                .HasMany(e => e.ProductsGroupsRelations)
                .WithRequired(e => e.SubProduct)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubProduct>()
                .HasMany(e => e.ProductsPrices)
                .WithRequired(e => e.SubProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permission>()
                .HasMany(e => e.RolesPermissionsRelationships)
                .WithRequired(e => e.Permission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoardRows>()
               .HasMany(e => e.BoardMissions)
               .WithRequired(e => e.BoardRow)
               .HasForeignKey(e => e.RowID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoardColumns>()
                .HasMany(e => e.BoardMissions)
                .WithRequired(e => e.BoardColumn)
                .HasForeignKey(e => e.ColumnID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItem>()
                .HasMany(e => e.OrderItemFiles)
                .WithRequired(e => e.OrderItem)
                .HasForeignKey(e => e.OrderItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BooksItemValue>()
                .HasMany(e => e.Covers)
                .WithRequired(e => e.BooksItemValue)
                .HasForeignKey(e => e.BooksPriceListID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BooksItemValue>()
                .HasMany(e => e.IntireColumns)
                .WithRequired(e => e.BooksItemValue)
                .HasForeignKey(e => e.BooksPriceListID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListParameter>()
               .HasMany(e => e.OrderItemParametersStatuses)
               .WithRequired(e => e.PriceListParameter)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListParameter>()
          .HasMany(e => e.QuoteItemParametersStatuses)
          .WithRequired(e => e.PriceListParameter)
          .WillCascadeOnDelete(false);

            modelBuilder.Entity<Boards>()
               .HasMany(e => e.PriceListParametersBoards)
               .WithRequired(e => e.Board)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListParameter>()
                .HasMany(e => e.OrderItemParametersStatuses)
                .WithRequired(e => e.PriceListParameter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PriceListParameter>()
                .HasMany(e => e.QuoteItemParametersStatuses)
                .WithRequired(e => e.PriceListParameter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BidItemValueShtansim>()
                .HasMany(e => e.BidItemValues)
                .WithOptional(e => e.BidItemValueShtansim)
                .HasForeignKey(e => e.ShtansID);

            modelBuilder.Entity<Client>()
               .Property(e => e.ClientType)
               .IsFixedLength()
               .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Contacts)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AllowedIPs)
                .WithOptional(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DigitalItemValue>()
                .HasMany(e => e.ItemSpecialColors)
                .WithOptional(e => e.DigitalItemValue)
                .HasForeignKey(e => e.DigitalPriceListID);*/

          
            //
        }

       

        public bool HaveToHide()
        {
            var isHideClients = Settings.FirstOrDefault(x => x.Name.Equals("isHideClients"));
            return isHideClients != null && isHideClients.Value == 1;
        }
    }
}
