using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CrmApi.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CRM")
        {
        }

        public virtual DbSet<BaseAddress> BaseAddresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyBranch> CompanyBranches { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractCondition> ContractConditions { get; set; }
        public virtual DbSet<ContractFileData> ContractFileDatas { get; set; }
        public virtual DbSet<ContractService> ContractServices { get; set; }
        public virtual DbSet<CounteryCodePhone> CounteryCodePhones { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DashboardData> DashboardDatas { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Facebook> Facebooks { get; set; }
        public virtual DbSet<Fax> Faxes { get; set; }
        public virtual DbSet<FileData> FileDatas { get; set; }
        public virtual DbSet<FixedPhone> FixedPhones { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<GroupsOfItem> GroupsOfItems { get; set; }
        public virtual DbSet<HCategory> HCategories { get; set; }
        public virtual DbSet<ManPower> ManPowers { get; set; }
        public virtual DbSet<MaterialStore> MaterialStores { get; set; }
        public virtual DbSet<Mobile> Mobiles { get; set; }
        public virtual DbSet<ModelDifference> ModelDifferences { get; set; }
        public virtual DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
        public virtual DbSet<OrganizationStructure> OrganizationStructures { get; set; }
        public virtual DbSet<Penalty> Penalties { get; set; }
        public virtual DbSet<PermissionPolicyActionPermissionObject> PermissionPolicyActionPermissionObjects { get; set; }
        public virtual DbSet<PermissionPolicyMemberPermissionsObject> PermissionPolicyMemberPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyNavigationPermissionsObject> PermissionPolicyNavigationPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyObjectPermissionsObject> PermissionPolicyObjectPermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyRole> PermissionPolicyRoles { get; set; }
        public virtual DbSet<PermissionPolicyTypePermissionsObject> PermissionPolicyTypePermissionsObjects { get; set; }
        public virtual DbSet<PermissionPolicyUser> PermissionPolicyUsers { get; set; }
        public virtual DbSet<PermissionPolicyUserUsers_PermissionPolicyRoleRoles> PermissionPolicyUserUsers_PermissionPolicyRoleRoles { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<QualificationFileData> QualificationFileDatas { get; set; }
        public virtual DbSet<QualificationList> QualificationLists { get; set; }
        public virtual DbSet<ReportDataV2> ReportDataV2 { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestFileData> RequestFileDatas { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceResources_EventEvents> ResourceResources_EventEvents { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<SNSparPart> SNSparParts { get; set; }
        public virtual DbSet<SNToolsStore> SNToolsStores { get; set; }
        public virtual DbSet<SparPart> SparParts { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreType> StoreTypes { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskTasks_ManPowerManPowers> TaskTasks_ManPowerManPowers { get; set; }
        public virtual DbSet<ToolStore> ToolStores { get; set; }
        public virtual DbSet<Trade> Trades { get; set; }
        public virtual DbSet<TypeOfService> TypeOfServices { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Whatsapp> Whatsapps { get; set; }
        public virtual DbSet<WorkArea> WorkAreas { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<WorkOrderScheduler> WorkOrderSchedulers { get; set; }
        public virtual DbSet<XPObjectType> XPObjectTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasMany(e => e.CompanyBranches)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<City>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyBranches)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Contracts)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.WorkAreas)
                .WithOptional(e => e.Company1)
                .HasForeignKey(e => e.Company);

            modelBuilder.Entity<CompanyBranch>()
                .HasMany(e => e.BaseAddresses)
                .WithOptional(e => e.CompanyBranch1)
                .HasForeignKey(e => e.CompanyBranch);

            modelBuilder.Entity<CompanyBranch>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.CompanyBranch)
                .HasForeignKey(e => e.Branch);

            modelBuilder.Entity<CompanyBranch>()
                .HasMany(e => e.WorkAreas)
                .WithOptional(e => e.CompanyBranch1)
                .HasForeignKey(e => e.CompanyBranch);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.ContractConditions)
                .WithOptional(e => e.Contract1)
                .HasForeignKey(e => e.Contract);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.ContractFileDatas)
                .WithOptional(e => e.Contract)
                .HasForeignKey(e => e.ContractFile);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.ContractServices)
                .WithOptional(e => e.Contract1)
                .HasForeignKey(e => e.Contract);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.Penalties)
                .WithOptional(e => e.Contract1)
                .HasForeignKey(e => e.Contract);

            modelBuilder.Entity<CounteryCodePhone>()
                .HasMany(e => e.Faxes)
                .WithOptional(e => e.CounteryCodePhone)
                .HasForeignKey(e => e.Key);

            modelBuilder.Entity<CounteryCodePhone>()
                .HasMany(e => e.FixedPhones)
                .WithOptional(e => e.CounteryCodePhone)
                .HasForeignKey(e => e.Key);

            modelBuilder.Entity<CounteryCodePhone>()
                .HasMany(e => e.Mobiles)
                .WithOptional(e => e.CounteryCodePhone)
                .HasForeignKey(e => e.Key);

            modelBuilder.Entity<CounteryCodePhone>()
                .HasMany(e => e.Whatsapps)
                .WithOptional(e => e.CounteryCodePhone)
                .HasForeignKey(e => e.Key);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.CompanyBranches)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Emails)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Facebooks)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customers);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Faxes)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.FixedPhones)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Mobiles)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.CreatedByCustomer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Requests1)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.RequestedByCustomer);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Whatsapps)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Customers);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.WorkOrders)
                .WithOptional(e => e.Customer1)
                .HasForeignKey(e => e.Customer);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Event1)
                .WithOptional(e => e.Event2)
                .HasForeignKey(e => e.RecurrencePattern);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.ResourceResources_EventEvents)
                .WithOptional(e => e.Event)
                .HasForeignKey(e => e.Events);

            modelBuilder.Entity<Event>()
                .HasOptional(e => e.WorkOrderScheduler)
                .WithRequired(e => e.Event);

            modelBuilder.Entity<FileData>()
                .HasMany(e => e.ContractFileDatas)
                .WithOptional(e => e.FileData)
                .HasForeignKey(e => e.File);

            modelBuilder.Entity<FileData>()
                .HasMany(e => e.QualificationFileDatas)
                .WithOptional(e => e.FileData)
                .HasForeignKey(e => e.File);

            modelBuilder.Entity<FileData>()
                .HasMany(e => e.RequestFileDatas)
                .WithOptional(e => e.FileData)
                .HasForeignKey(e => e.File);

            modelBuilder.Entity<Grade>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.Grade1)
                .HasForeignKey(e => e.Grade);

            modelBuilder.Entity<GroupsOfItem>()
                .HasMany(e => e.MaterialStores)
                .WithOptional(e => e.GroupsOfItem1)
                .HasForeignKey(e => e.GroupsOfItem);

            modelBuilder.Entity<HCategory>()
                .HasMany(e => e.HCategory1)
                .WithOptional(e => e.HCategory2)
                .HasForeignKey(e => e.Parent);

            modelBuilder.Entity<HCategory>()
                .HasOptional(e => e.OrganizationStructure)
                .WithRequired(e => e.HCategory);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.BaseAddresses)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.Emails)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.FixedPhones)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.Mobiles)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.OrganizationStructures)
                .WithOptional(e => e.ManPower)
                .HasForeignKey(e => e.Responsible);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.QualificationLists)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.TaskTasks_ManPowerManPowers)
                .WithOptional(e => e.ManPower)
                .HasForeignKey(e => e.ManPowers);

            modelBuilder.Entity<ManPower>()
                .HasMany(e => e.WorkAreas)
                .WithOptional(e => e.ManPower1)
                .HasForeignKey(e => e.ManPower);

            modelBuilder.Entity<ModelDifference>()
                .HasMany(e => e.ModelDifferenceAspects)
                .WithOptional(e => e.ModelDifference)
                .HasForeignKey(e => e.Owner);

            modelBuilder.Entity<OrganizationStructure>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.OrganizationStructure)
                .HasForeignKey(e => e.Position);

            modelBuilder.Entity<PermissionPolicyRole>()
                .HasMany(e => e.PermissionPolicyActionPermissionObjects)
                .WithOptional(e => e.PermissionPolicyRole)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<PermissionPolicyRole>()
                .HasMany(e => e.PermissionPolicyNavigationPermissionsObjects)
                .WithOptional(e => e.PermissionPolicyRole)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<PermissionPolicyRole>()
                .HasMany(e => e.PermissionPolicyTypePermissionsObjects)
                .WithOptional(e => e.PermissionPolicyRole)
                .HasForeignKey(e => e.Role);

            modelBuilder.Entity<PermissionPolicyRole>()
                .HasMany(e => e.PermissionPolicyUserUsers_PermissionPolicyRoleRoles)
                .WithOptional(e => e.PermissionPolicyRole)
                .HasForeignKey(e => e.Roles);

            modelBuilder.Entity<PermissionPolicyTypePermissionsObject>()
                .HasMany(e => e.PermissionPolicyMemberPermissionsObjects)
                .WithOptional(e => e.PermissionPolicyTypePermissionsObject)
                .HasForeignKey(e => e.TypePermissionObject);

            modelBuilder.Entity<PermissionPolicyTypePermissionsObject>()
                .HasMany(e => e.PermissionPolicyObjectPermissionsObjects)
                .WithOptional(e => e.PermissionPolicyTypePermissionsObject)
                .HasForeignKey(e => e.TypePermissionObject);

            modelBuilder.Entity<PermissionPolicyUser>()
                .HasOptional(e => e.Customer)
                .WithRequired(e => e.PermissionPolicyUser);

            modelBuilder.Entity<PermissionPolicyUser>()
                .HasOptional(e => e.ManPower)
                .WithRequired(e => e.PermissionPolicyUser);

            modelBuilder.Entity<PermissionPolicyUser>()
                .HasMany(e => e.PermissionPolicyUserUsers_PermissionPolicyRoleRoles)
                .WithOptional(e => e.PermissionPolicyUser)
                .HasForeignKey(e => e.Users);

            modelBuilder.Entity<Qualification>()
                .HasMany(e => e.QualificationLists)
                .WithOptional(e => e.Qualification1)
                .HasForeignKey(e => e.Qualification);

            modelBuilder.Entity<QualificationList>()
                .HasMany(e => e.QualificationFileDatas)
                .WithOptional(e => e.QualificationList1)
                .HasForeignKey(e => e.QualificationList);

            modelBuilder.Entity<Request>()
                .HasMany(e => e.RequestFileDatas)
                .WithOptional(e => e.Request)
                .HasForeignKey(e => e.RequestFile);

            modelBuilder.Entity<Request>()
                .HasMany(e => e.WorkOrders)
                .WithOptional(e => e.Request1)
                .HasForeignKey(e => e.Request);

            modelBuilder.Entity<Resource>()
                .HasMany(e => e.ResourceResources_EventEvents)
                .WithOptional(e => e.Resource)
                .HasForeignKey(e => e.Resources);

            modelBuilder.Entity<Shift>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.Shift1)
                .HasForeignKey(e => e.Shift);

            modelBuilder.Entity<SparPart>()
                .HasMany(e => e.SNSparParts)
                .WithOptional(e => e.SparPart1)
                .HasForeignKey(e => e.SparPart);

            modelBuilder.Entity<Specialization>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.Specialization1)
                .HasForeignKey(e => e.Specialization);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.MaterialStores)
                .WithOptional(e => e.Store1)
                .HasForeignKey(e => e.Store);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.SNSparParts)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreName);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.SparParts)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreName);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.ToolStores)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.StoreName);

            modelBuilder.Entity<StoreType>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.StoreType1)
                .HasForeignKey(e => e.StoreType);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskTasks_ManPowerManPowers)
                .WithOptional(e => e.Task)
                .HasForeignKey(e => e.Tasks);

            modelBuilder.Entity<ToolStore>()
                .HasMany(e => e.SNToolsStores)
                .WithOptional(e => e.ToolStore)
                .HasForeignKey(e => e.ToolsStore);

            modelBuilder.Entity<Trade>()
                .HasMany(e => e.ManPowers)
                .WithOptional(e => e.Trade1)
                .HasForeignKey(e => e.Trade);

            modelBuilder.Entity<TypeOfService>()
                .HasMany(e => e.ContractServices)
                .WithOptional(e => e.TypeOfService1)
                .HasForeignKey(e => e.TypeOfService);

            modelBuilder.Entity<TypeOfService>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.TypeOfService1)
                .HasForeignKey(e => e.TypeOfService);

            modelBuilder.Entity<TypeOfService>()
                .HasMany(e => e.WorkOrders)
                .WithOptional(e => e.TypeOfService1)
                .HasForeignKey(e => e.TypeOfService);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.MaterialStores)
                .WithOptional(e => e.Unit1)
                .HasForeignKey(e => e.Unit);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.Requests)
                .WithOptional(e => e.WorkOrder1)
                .HasForeignKey(e => e.WorkOrder);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.WorkOrder1)
                .HasForeignKey(e => e.WorkOrder);

            modelBuilder.Entity<WorkOrder>()
                .HasMany(e => e.WorkOrderSchedulers)
                .WithOptional(e => e.WorkOrder1)
                .HasForeignKey(e => e.WorkOrder);

            modelBuilder.Entity<WorkOrderScheduler>()
                .HasMany(e => e.WorkOrders)
                .WithOptional(e => e.WorkOrderScheduler)
                .HasForeignKey(e => e.Scheduler);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.Events)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.HCategories)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.PermissionPolicyRoles)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);

            modelBuilder.Entity<XPObjectType>()
                .HasMany(e => e.PermissionPolicyUsers)
                .WithOptional(e => e.XPObjectType)
                .HasForeignKey(e => e.ObjectType);
        }
    }
}
