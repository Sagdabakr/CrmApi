namespace CrmApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseAddress",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ArabicAddress = c.String(),
                        EnglishAddress = c.String(),
                        CompanyBranch = c.Guid(),
                        ManPower = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.CompanyBranch", t => t.CompanyBranch)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .Index(t => t.CompanyBranch)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.CompanyBranch",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        BranchCode = c.String(maxLength: 100),
                        Company = c.Guid(),
                        EnglishBranchName = c.String(maxLength: 100),
                        ArabicBranchName = c.String(maxLength: 100),
                        Country = c.Guid(),
                        City = c.Guid(),
                        PostalCode = c.String(maxLength: 100),
                        HeadQuarter = c.Boolean(),
                        MapLatitude = c.String(maxLength: 100),
                        MapLongitude = c.String(maxLength: 100),
                        WorkTimeStart = c.DateTime(),
                        WorkTimeEnd = c.DateTime(),
                        StartWorkDay = c.Int(),
                        EndWorkDay = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.City", t => t.City)
                .ForeignKey("dbo.Country", t => t.Country)
                .ForeignKey("dbo.Company", t => t.Company)
                .Index(t => t.Company)
                .Index(t => t.Country)
                .Index(t => t.City);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CityName = c.String(maxLength: 100),
                        Country = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Country", t => t.Country)
                .Index(t => t.Country);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CountryName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ManPower",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        HasPrimaryMobile = c.Boolean(),
                        HasPrimaryFixedPhone = c.Boolean(),
                        HasPrimaryEmail = c.Boolean(),
                        ManPowerId = c.String(maxLength: 100),
                        ArabicName = c.String(maxLength: 100),
                        EnglishName = c.String(maxLength: 100),
                        Shift = c.Guid(),
                        Trade = c.Guid(),
                        Country = c.Guid(),
                        City = c.Guid(),
                        Grade = c.Guid(),
                        Specialization = c.Guid(),
                        Image = c.Binary(),
                        Position = c.Guid(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.OrganizationStructure", t => t.Position)
                .ForeignKey("dbo.PermissionPolicyUser", t => t.Oid)
                .ForeignKey("dbo.Grade", t => t.Grade)
                .ForeignKey("dbo.Shift", t => t.Shift)
                .ForeignKey("dbo.Specialization", t => t.Specialization)
                .ForeignKey("dbo.Trade", t => t.Trade)
                .ForeignKey("dbo.Country", t => t.Country)
                .ForeignKey("dbo.City", t => t.City)
                .Index(t => t.Oid)
                .Index(t => t.Shift)
                .Index(t => t.Trade)
                .Index(t => t.Country)
                .Index(t => t.City)
                .Index(t => t.Grade)
                .Index(t => t.Specialization)
                .Index(t => t.Position);
            
            CreateTable(
                "dbo.Email",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        EmailAddress = c.String(maxLength: 100),
                        IsPrimary = c.Boolean(),
                        Customer = c.Guid(),
                        ManPower = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Customer", t => t.Customer)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .Index(t => t.Customer)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CodeCustomer = c.String(maxLength: 100),
                        HasPrimaryMobile = c.Boolean(),
                        HasPrimaryEmail = c.Boolean(),
                        HasPrimaryFixedPhone = c.Boolean(),
                        HasPrimaryFax = c.Boolean(),
                        ArabicCustomerName = c.String(maxLength: 100),
                        EnglishCustomerName = c.String(maxLength: 100),
                        Company = c.Guid(),
                        Branch = c.Guid(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyUser", t => t.Oid)
                .ForeignKey("dbo.Company", t => t.Company)
                .ForeignKey("dbo.CompanyBranch", t => t.Branch)
                .Index(t => t.Oid)
                .Index(t => t.Company)
                .Index(t => t.Branch);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CompanyCode = c.String(maxLength: 100),
                        ArabicCompanyName = c.String(maxLength: 100),
                        EnglishCompanyName = c.String(maxLength: 100),
                        Website = c.String(maxLength: 100),
                        Logo = c.Binary(),
                        HasHeadQuarter = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ContractNumber = c.String(maxLength: 100),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Company = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Company", t => t.Company)
                .Index(t => t.Company);
            
            CreateTable(
                "dbo.ContractCondition",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ConditionNo = c.String(maxLength: 100),
                        Condition = c.String(),
                        Contract = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Contract", t => t.Contract)
                .Index(t => t.Contract);
            
            CreateTable(
                "dbo.ContractFileData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        File = c.Guid(),
                        ContractFile = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.FileData", t => t.File)
                .ForeignKey("dbo.Contract", t => t.ContractFile)
                .Index(t => t.File)
                .Index(t => t.ContractFile);
            
            CreateTable(
                "dbo.FileData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        size = c.Int(),
                        FileName = c.String(maxLength: 260),
                        Content = c.Binary(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.QualificationFileData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        File = c.Guid(),
                        QualificationList = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.QualificationList", t => t.QualificationList)
                .ForeignKey("dbo.FileData", t => t.File)
                .Index(t => t.File)
                .Index(t => t.QualificationList);
            
            CreateTable(
                "dbo.QualificationList",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Date = c.DateTime(),
                        EndDate = c.DateTime(),
                        Qualification = c.Guid(),
                        ManPower = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Qualification", t => t.Qualification)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .Index(t => t.Qualification)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.Qualification",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        QualificationId = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.RequestFileData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        File = c.Guid(),
                        RequestFile = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Request", t => t.RequestFile)
                .ForeignKey("dbo.FileData", t => t.File)
                .Index(t => t.File)
                .Index(t => t.RequestFile);
            
            CreateTable(
                "dbo.Request",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        RequestNumber = c.String(maxLength: 100),
                        RequestDateTime = c.DateTime(),
                        RequestedByCustomer = c.Guid(),
                        CreatedByCustomer = c.Guid(),
                        TypeOfService = c.Guid(),
                        LastNumberServices = c.Int(),
                        StatusDateTime = c.DateTime(),
                        PreferredDate = c.DateTime(),
                        PrefferedTime = c.DateTime(),
                        ActualDate = c.DateTime(),
                        ActualTime = c.DateTime(),
                        Description = c.String(),
                        WorkOrder = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.TypeOfService", t => t.TypeOfService)
                .ForeignKey("dbo.WorkOrder", t => t.WorkOrder)
                .ForeignKey("dbo.Customer", t => t.CreatedByCustomer)
                .ForeignKey("dbo.Customer", t => t.RequestedByCustomer)
                .Index(t => t.RequestedByCustomer)
                .Index(t => t.CreatedByCustomer)
                .Index(t => t.TypeOfService)
                .Index(t => t.WorkOrder);
            
            CreateTable(
                "dbo.TypeOfService",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ServiceType = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ContractService",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        TypeOfService = c.Guid(),
                        NumberOfService = c.Int(),
                        Contract = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.TypeOfService", t => t.TypeOfService)
                .ForeignKey("dbo.Contract", t => t.Contract)
                .Index(t => t.TypeOfService)
                .Index(t => t.Contract);
            
            CreateTable(
                "dbo.WorkOrder",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Scheduler = c.Guid(),
                        WorkOrderNumber = c.String(maxLength: 100),
                        WorkOrderDate = c.DateTime(),
                        Customer = c.Guid(),
                        TypeOfService = c.Guid(),
                        PreferredDate = c.DateTime(),
                        PreferredTime = c.DateTime(),
                        Description = c.String(),
                        ActualStartDate = c.DateTime(),
                        ActualEndDate = c.DateTime(),
                        ActualStartTime = c.DateTime(),
                        ActualEndTime = c.DateTime(),
                        Duration = c.String(maxLength: 100),
                        Status = c.Int(),
                        StatusDate = c.DateTime(),
                        Request = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.WorkOrderScheduler", t => t.Scheduler)
                .ForeignKey("dbo.TypeOfService", t => t.TypeOfService)
                .ForeignKey("dbo.Request", t => t.Request)
                .ForeignKey("dbo.Customer", t => t.Customer)
                .Index(t => t.Scheduler)
                .Index(t => t.Customer)
                .Index(t => t.TypeOfService)
                .Index(t => t.Request);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        TaskCode = c.String(maxLength: 100),
                        Status = c.Int(),
                        EstimateDuration = c.String(maxLength: 100),
                        Summary = c.String(maxLength: 100),
                        Description = c.String(),
                        WorkOrder = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.WorkOrder", t => t.WorkOrder)
                .Index(t => t.WorkOrder);
            
            CreateTable(
                "dbo.TaskTasks_ManPowerManPowers",
                c => new
                    {
                        OID = c.Guid(nullable: false),
                        ManPowers = c.Guid(),
                        Tasks = c.Guid(),
                        OptimisticLockField = c.Int(),
                    })
                .PrimaryKey(t => t.OID)
                .ForeignKey("dbo.Task", t => t.Tasks)
                .ForeignKey("dbo.ManPower", t => t.ManPowers)
                .Index(t => t.ManPowers)
                .Index(t => t.Tasks);
            
            CreateTable(
                "dbo.WorkOrderScheduler",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        WorkOrder = c.Guid(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Event", t => t.Oid)
                .ForeignKey("dbo.WorkOrder", t => t.WorkOrder)
                .Index(t => t.Oid)
                .Index(t => t.WorkOrder);
            
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ResourceIds = c.String(),
                        RecurrencePattern = c.Guid(),
                        Subject = c.String(maxLength: 250),
                        Description = c.String(),
                        StartOn = c.DateTime(),
                        EndOn = c.DateTime(),
                        AllDay = c.Boolean(),
                        Location = c.String(maxLength: 100),
                        Label = c.Int(),
                        Status = c.Int(),
                        Type = c.Int(),
                        RemindIn = c.Double(),
                        ReminderInfoXml = c.String(maxLength: 200),
                        AlarmTime = c.DateTime(),
                        IsPostponed = c.Boolean(),
                        RecurrenceInfoXml = c.String(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                        ObjectType = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Event", t => t.RecurrencePattern)
                .ForeignKey("dbo.XPObjectType", t => t.ObjectType)
                .Index(t => t.RecurrencePattern)
                .Index(t => t.ObjectType);
            
            CreateTable(
                "dbo.ResourceResources_EventEvents",
                c => new
                    {
                        OID = c.Guid(nullable: false),
                        Events = c.Guid(),
                        Resources = c.Guid(),
                        OptimisticLockField = c.Int(),
                    })
                .PrimaryKey(t => t.OID)
                .ForeignKey("dbo.Resource", t => t.Resources)
                .ForeignKey("dbo.Event", t => t.Events)
                .Index(t => t.Events)
                .Index(t => t.Resources);
            
            CreateTable(
                "dbo.Resource",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Caption = c.String(maxLength: 100),
                        Color = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.XPObjectType",
                c => new
                    {
                        OID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(maxLength: 254),
                        AssemblyName = c.String(maxLength: 254),
                    })
                .PrimaryKey(t => t.OID);
            
            CreateTable(
                "dbo.HCategory",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Parent = c.Guid(),
                        Name = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                        ObjectType = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.HCategory", t => t.Parent)
                .ForeignKey("dbo.XPObjectType", t => t.ObjectType)
                .Index(t => t.Parent)
                .Index(t => t.ObjectType);
            
            CreateTable(
                "dbo.OrganizationStructure",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        PositionTitle = c.String(maxLength: 100),
                        Responsible = c.Guid(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.HCategory", t => t.Oid)
                .ForeignKey("dbo.ManPower", t => t.Responsible)
                .Index(t => t.Oid)
                .Index(t => t.Responsible);
            
            CreateTable(
                "dbo.PermissionPolicyRole",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                        IsAdministrative = c.Boolean(),
                        CanEditModel = c.Boolean(),
                        PermissionPolicy = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                        ObjectType = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.XPObjectType", t => t.ObjectType)
                .Index(t => t.ObjectType);
            
            CreateTable(
                "dbo.PermissionPolicyActionPermissionObject",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ActionId = c.String(maxLength: 100),
                        Role = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyRole", t => t.Role)
                .Index(t => t.Role);
            
            CreateTable(
                "dbo.PermissionPolicyNavigationPermissionsObject",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ItemPath = c.String(),
                        NavigateState = c.Int(),
                        Role = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyRole", t => t.Role)
                .Index(t => t.Role);
            
            CreateTable(
                "dbo.PermissionPolicyTypePermissionsObject",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Role = c.Guid(),
                        TargetType = c.String(),
                        ReadState = c.Int(),
                        WriteState = c.Int(),
                        CreateState = c.Int(),
                        DeleteState = c.Int(),
                        NavigateState = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyRole", t => t.Role)
                .Index(t => t.Role);
            
            CreateTable(
                "dbo.PermissionPolicyMemberPermissionsObject",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Members = c.String(),
                        ReadState = c.Int(),
                        WriteState = c.Int(),
                        Criteria = c.String(),
                        TypePermissionObject = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyTypePermissionsObject", t => t.TypePermissionObject)
                .Index(t => t.TypePermissionObject);
            
            CreateTable(
                "dbo.PermissionPolicyObjectPermissionsObject",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Criteria = c.String(),
                        ReadState = c.Int(),
                        WriteState = c.Int(),
                        DeleteState = c.Int(),
                        NavigateState = c.Int(),
                        TypePermissionObject = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.PermissionPolicyTypePermissionsObject", t => t.TypePermissionObject)
                .Index(t => t.TypePermissionObject);
            
            CreateTable(
                "dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles",
                c => new
                    {
                        OID = c.Guid(nullable: false),
                        Roles = c.Guid(),
                        Users = c.Guid(),
                        OptimisticLockField = c.Int(),
                    })
                .PrimaryKey(t => t.OID)
                .ForeignKey("dbo.PermissionPolicyUser", t => t.Users)
                .ForeignKey("dbo.PermissionPolicyRole", t => t.Roles)
                .Index(t => t.Roles)
                .Index(t => t.Users);
            
            CreateTable(
                "dbo.PermissionPolicyUser",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        StoredPassword = c.String(),
                        ChangePasswordOnFirstLogon = c.Boolean(),
                        UserName = c.String(maxLength: 100),
                        IsActive = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                        ObjectType = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.XPObjectType", t => t.ObjectType)
                .Index(t => t.ObjectType);
            
            CreateTable(
                "dbo.Penalties",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        PenaltyNO = c.String(maxLength: 100),
                        Penalty = c.String(),
                        Contract = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Contract", t => t.Contract)
                .Index(t => t.Contract);
            
            CreateTable(
                "dbo.WorkArea",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        WorkAreaId = c.String(maxLength: 100),
                        CompanyBranch = c.Guid(),
                        Company = c.Guid(),
                        ManPower = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Company", t => t.Company)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .ForeignKey("dbo.CompanyBranch", t => t.CompanyBranch)
                .Index(t => t.CompanyBranch)
                .Index(t => t.Company)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.Facebook",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        FacebookEmail = c.String(maxLength: 100),
                        Customers = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Customer", t => t.Customers)
                .Index(t => t.Customers);
            
            CreateTable(
                "dbo.Fax",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Key = c.Guid(),
                        PhoneNumber = c.String(maxLength: 100),
                        Customer = c.Guid(),
                        IsPrimary = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.CounteryCodePhone", t => t.Key)
                .ForeignKey("dbo.Customer", t => t.Customer)
                .Index(t => t.Key)
                .Index(t => t.Customer);
            
            CreateTable(
                "dbo.CounteryCodePhone",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ArabicCounteryName = c.String(maxLength: 100),
                        CounteryNumberCode = c.String(maxLength: 100),
                        EnglishCounteryName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.FixedPhone",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Key = c.Guid(),
                        PhoneNumber = c.String(maxLength: 100),
                        Customer = c.Guid(),
                        ManPower = c.Guid(),
                        IsPrimary = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.CounteryCodePhone", t => t.Key)
                .ForeignKey("dbo.Customer", t => t.Customer)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .Index(t => t.Key)
                .Index(t => t.Customer)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.Mobile",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Key = c.Guid(),
                        PhoneNumber = c.String(maxLength: 100),
                        Customer = c.Guid(),
                        ManPower = c.Guid(),
                        IsPrimary = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.CounteryCodePhone", t => t.Key)
                .ForeignKey("dbo.Customer", t => t.Customer)
                .ForeignKey("dbo.ManPower", t => t.ManPower)
                .Index(t => t.Key)
                .Index(t => t.Customer)
                .Index(t => t.ManPower);
            
            CreateTable(
                "dbo.Whatsapp",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Key = c.Guid(),
                        PhoneNumber = c.String(maxLength: 100),
                        Customers = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.CounteryCodePhone", t => t.Key)
                .ForeignKey("dbo.Customer", t => t.Customers)
                .Index(t => t.Key)
                .Index(t => t.Customers);
            
            CreateTable(
                "dbo.Grade",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        GradeID = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ShiftID = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Specialization",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        SpecializationId = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Trade",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        TradeID = c.String(maxLength: 100),
                        Name = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        CodeStore = c.String(maxLength: 100),
                        ArabicStoreName = c.String(maxLength: 100),
                        EnglishStoreName = c.String(maxLength: 100),
                        StoreType = c.Guid(),
                        Country = c.Guid(),
                        City = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.StoreType", t => t.StoreType)
                .ForeignKey("dbo.Country", t => t.Country)
                .ForeignKey("dbo.City", t => t.City)
                .Index(t => t.StoreType)
                .Index(t => t.Country)
                .Index(t => t.City);
            
            CreateTable(
                "dbo.MaterialStores",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ItemCode = c.String(maxLength: 100),
                        Description = c.String(),
                        Quantity = c.Int(),
                        Unit = c.Guid(),
                        GroupsOfItem = c.Guid(),
                        Store = c.Guid(),
                        StanderRate = c.String(maxLength: 100),
                        ItemName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.GroupsOfItems", t => t.GroupsOfItem)
                .ForeignKey("dbo.Units", t => t.Unit)
                .ForeignKey("dbo.Store", t => t.Store)
                .Index(t => t.Unit)
                .Index(t => t.GroupsOfItem)
                .Index(t => t.Store);
            
            CreateTable(
                "dbo.GroupsOfItems",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        GroupsCode = c.String(maxLength: 100),
                        ArabicGroupItemName = c.String(maxLength: 100),
                        EnglishGroupItemName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        UnitCode = c.String(maxLength: 100),
                        EnglishUnitName = c.String(maxLength: 100),
                        ArabicUnitName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.SNSparPart",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ItemCode = c.String(maxLength: 100),
                        SerialNumber = c.String(maxLength: 100),
                        SparPart = c.Guid(),
                        StoreName = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.SparPart", t => t.SparPart)
                .ForeignKey("dbo.Store", t => t.StoreName)
                .Index(t => t.SparPart)
                .Index(t => t.StoreName);
            
            CreateTable(
                "dbo.SparPart",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        PartNumber = c.String(maxLength: 100),
                        Description = c.String(),
                        StoreName = c.Guid(),
                        StandardRate = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Store", t => t.StoreName)
                .Index(t => t.StoreName);
            
            CreateTable(
                "dbo.StoreType",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ArabicStoreTypeName = c.String(maxLength: 100),
                        EnglishStoreTypeName = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ToolStore",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Calibration = c.Boolean(),
                        Description = c.String(),
                        PartNumber = c.String(maxLength: 100),
                        StoreName = c.Guid(),
                        StanderRate = c.String(maxLength: 100),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.Store", t => t.StoreName)
                .Index(t => t.StoreName);
            
            CreateTable(
                "dbo.SNToolsStore",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ItemCode = c.String(maxLength: 100),
                        ToolsStore = c.Guid(),
                        SerialNumber = c.String(maxLength: 100),
                        BinLocation = c.String(maxLength: 100),
                        ServiceableState = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.ToolStore", t => t.ToolsStore)
                .Index(t => t.ToolsStore);
            
            CreateTable(
                "dbo.DashboardData",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Content = c.String(),
                        Title = c.String(maxLength: 100),
                        SynchronizeTitle = c.Boolean(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ModelDifferenceAspect",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                        Xml = c.String(),
                        Owner = c.Guid(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid)
                .ForeignKey("dbo.ModelDifference", t => t.Owner)
                .Index(t => t.Owner);
            
            CreateTable(
                "dbo.ModelDifference",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        UserId = c.String(maxLength: 100),
                        ContextId = c.String(maxLength: 100),
                        Version = c.Int(),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
            CreateTable(
                "dbo.ReportDataV2",
                c => new
                    {
                        Oid = c.Guid(nullable: false),
                        ObjectTypeName = c.String(maxLength: 512),
                        Content = c.Binary(),
                        Name = c.String(maxLength: 100),
                        ParametersObjectTypeName = c.String(maxLength: 512),
                        IsInplaceReport = c.Boolean(),
                        PredefinedReportType = c.String(maxLength: 512),
                        OptimisticLockField = c.Int(),
                        GCRecord = c.Int(),
                    })
                .PrimaryKey(t => t.Oid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ModelDifferenceAspect", "Owner", "dbo.ModelDifference");
            DropForeignKey("dbo.WorkArea", "CompanyBranch", "dbo.CompanyBranch");
            DropForeignKey("dbo.Customer", "Branch", "dbo.CompanyBranch");
            DropForeignKey("dbo.Store", "City", "dbo.City");
            DropForeignKey("dbo.ManPower", "City", "dbo.City");
            DropForeignKey("dbo.Store", "Country", "dbo.Country");
            DropForeignKey("dbo.ToolStore", "StoreName", "dbo.Store");
            DropForeignKey("dbo.SNToolsStore", "ToolsStore", "dbo.ToolStore");
            DropForeignKey("dbo.Store", "StoreType", "dbo.StoreType");
            DropForeignKey("dbo.SparPart", "StoreName", "dbo.Store");
            DropForeignKey("dbo.SNSparPart", "StoreName", "dbo.Store");
            DropForeignKey("dbo.SNSparPart", "SparPart", "dbo.SparPart");
            DropForeignKey("dbo.MaterialStores", "Store", "dbo.Store");
            DropForeignKey("dbo.MaterialStores", "Unit", "dbo.Units");
            DropForeignKey("dbo.MaterialStores", "GroupsOfItem", "dbo.GroupsOfItems");
            DropForeignKey("dbo.ManPower", "Country", "dbo.Country");
            DropForeignKey("dbo.WorkArea", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.ManPower", "Trade", "dbo.Trade");
            DropForeignKey("dbo.TaskTasks_ManPowerManPowers", "ManPowers", "dbo.ManPower");
            DropForeignKey("dbo.ManPower", "Specialization", "dbo.Specialization");
            DropForeignKey("dbo.ManPower", "Shift", "dbo.Shift");
            DropForeignKey("dbo.QualificationList", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.OrganizationStructure", "Responsible", "dbo.ManPower");
            DropForeignKey("dbo.Mobile", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.ManPower", "Grade", "dbo.Grade");
            DropForeignKey("dbo.FixedPhone", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.Email", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.WorkOrder", "Customer", "dbo.Customer");
            DropForeignKey("dbo.Whatsapp", "Customers", "dbo.Customer");
            DropForeignKey("dbo.Request", "RequestedByCustomer", "dbo.Customer");
            DropForeignKey("dbo.Request", "CreatedByCustomer", "dbo.Customer");
            DropForeignKey("dbo.Mobile", "Customer", "dbo.Customer");
            DropForeignKey("dbo.FixedPhone", "Customer", "dbo.Customer");
            DropForeignKey("dbo.Fax", "Customer", "dbo.Customer");
            DropForeignKey("dbo.Whatsapp", "Key", "dbo.CounteryCodePhone");
            DropForeignKey("dbo.Mobile", "Key", "dbo.CounteryCodePhone");
            DropForeignKey("dbo.FixedPhone", "Key", "dbo.CounteryCodePhone");
            DropForeignKey("dbo.Fax", "Key", "dbo.CounteryCodePhone");
            DropForeignKey("dbo.Facebook", "Customers", "dbo.Customer");
            DropForeignKey("dbo.Email", "Customer", "dbo.Customer");
            DropForeignKey("dbo.WorkArea", "Company", "dbo.Company");
            DropForeignKey("dbo.Customer", "Company", "dbo.Company");
            DropForeignKey("dbo.Contract", "Company", "dbo.Company");
            DropForeignKey("dbo.Penalties", "Contract", "dbo.Contract");
            DropForeignKey("dbo.ContractService", "Contract", "dbo.Contract");
            DropForeignKey("dbo.ContractFileData", "ContractFile", "dbo.Contract");
            DropForeignKey("dbo.RequestFileData", "File", "dbo.FileData");
            DropForeignKey("dbo.WorkOrder", "Request", "dbo.Request");
            DropForeignKey("dbo.WorkOrder", "TypeOfService", "dbo.TypeOfService");
            DropForeignKey("dbo.WorkOrderScheduler", "WorkOrder", "dbo.WorkOrder");
            DropForeignKey("dbo.WorkOrder", "Scheduler", "dbo.WorkOrderScheduler");
            DropForeignKey("dbo.PermissionPolicyUser", "ObjectType", "dbo.XPObjectType");
            DropForeignKey("dbo.PermissionPolicyRole", "ObjectType", "dbo.XPObjectType");
            DropForeignKey("dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles", "Roles", "dbo.PermissionPolicyRole");
            DropForeignKey("dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles", "Users", "dbo.PermissionPolicyUser");
            DropForeignKey("dbo.ManPower", "Oid", "dbo.PermissionPolicyUser");
            DropForeignKey("dbo.Customer", "Oid", "dbo.PermissionPolicyUser");
            DropForeignKey("dbo.PermissionPolicyTypePermissionsObject", "Role", "dbo.PermissionPolicyRole");
            DropForeignKey("dbo.PermissionPolicyObjectPermissionsObject", "TypePermissionObject", "dbo.PermissionPolicyTypePermissionsObject");
            DropForeignKey("dbo.PermissionPolicyMemberPermissionsObject", "TypePermissionObject", "dbo.PermissionPolicyTypePermissionsObject");
            DropForeignKey("dbo.PermissionPolicyNavigationPermissionsObject", "Role", "dbo.PermissionPolicyRole");
            DropForeignKey("dbo.PermissionPolicyActionPermissionObject", "Role", "dbo.PermissionPolicyRole");
            DropForeignKey("dbo.HCategory", "ObjectType", "dbo.XPObjectType");
            DropForeignKey("dbo.OrganizationStructure", "Oid", "dbo.HCategory");
            DropForeignKey("dbo.ManPower", "Position", "dbo.OrganizationStructure");
            DropForeignKey("dbo.HCategory", "Parent", "dbo.HCategory");
            DropForeignKey("dbo.Event", "ObjectType", "dbo.XPObjectType");
            DropForeignKey("dbo.WorkOrderScheduler", "Oid", "dbo.Event");
            DropForeignKey("dbo.ResourceResources_EventEvents", "Events", "dbo.Event");
            DropForeignKey("dbo.ResourceResources_EventEvents", "Resources", "dbo.Resource");
            DropForeignKey("dbo.Event", "RecurrencePattern", "dbo.Event");
            DropForeignKey("dbo.Task", "WorkOrder", "dbo.WorkOrder");
            DropForeignKey("dbo.TaskTasks_ManPowerManPowers", "Tasks", "dbo.Task");
            DropForeignKey("dbo.Request", "WorkOrder", "dbo.WorkOrder");
            DropForeignKey("dbo.Request", "TypeOfService", "dbo.TypeOfService");
            DropForeignKey("dbo.ContractService", "TypeOfService", "dbo.TypeOfService");
            DropForeignKey("dbo.RequestFileData", "RequestFile", "dbo.Request");
            DropForeignKey("dbo.QualificationFileData", "File", "dbo.FileData");
            DropForeignKey("dbo.QualificationFileData", "QualificationList", "dbo.QualificationList");
            DropForeignKey("dbo.QualificationList", "Qualification", "dbo.Qualification");
            DropForeignKey("dbo.ContractFileData", "File", "dbo.FileData");
            DropForeignKey("dbo.ContractCondition", "Contract", "dbo.Contract");
            DropForeignKey("dbo.CompanyBranch", "Company", "dbo.Company");
            DropForeignKey("dbo.BaseAddress", "ManPower", "dbo.ManPower");
            DropForeignKey("dbo.CompanyBranch", "Country", "dbo.Country");
            DropForeignKey("dbo.City", "Country", "dbo.Country");
            DropForeignKey("dbo.CompanyBranch", "City", "dbo.City");
            DropForeignKey("dbo.BaseAddress", "CompanyBranch", "dbo.CompanyBranch");
            DropIndex("dbo.ModelDifferenceAspect", new[] { "Owner" });
            DropIndex("dbo.SNToolsStore", new[] { "ToolsStore" });
            DropIndex("dbo.ToolStore", new[] { "StoreName" });
            DropIndex("dbo.SparPart", new[] { "StoreName" });
            DropIndex("dbo.SNSparPart", new[] { "StoreName" });
            DropIndex("dbo.SNSparPart", new[] { "SparPart" });
            DropIndex("dbo.MaterialStores", new[] { "Store" });
            DropIndex("dbo.MaterialStores", new[] { "GroupsOfItem" });
            DropIndex("dbo.MaterialStores", new[] { "Unit" });
            DropIndex("dbo.Store", new[] { "City" });
            DropIndex("dbo.Store", new[] { "Country" });
            DropIndex("dbo.Store", new[] { "StoreType" });
            DropIndex("dbo.Whatsapp", new[] { "Customers" });
            DropIndex("dbo.Whatsapp", new[] { "Key" });
            DropIndex("dbo.Mobile", new[] { "ManPower" });
            DropIndex("dbo.Mobile", new[] { "Customer" });
            DropIndex("dbo.Mobile", new[] { "Key" });
            DropIndex("dbo.FixedPhone", new[] { "ManPower" });
            DropIndex("dbo.FixedPhone", new[] { "Customer" });
            DropIndex("dbo.FixedPhone", new[] { "Key" });
            DropIndex("dbo.Fax", new[] { "Customer" });
            DropIndex("dbo.Fax", new[] { "Key" });
            DropIndex("dbo.Facebook", new[] { "Customers" });
            DropIndex("dbo.WorkArea", new[] { "ManPower" });
            DropIndex("dbo.WorkArea", new[] { "Company" });
            DropIndex("dbo.WorkArea", new[] { "CompanyBranch" });
            DropIndex("dbo.Penalties", new[] { "Contract" });
            DropIndex("dbo.PermissionPolicyUser", new[] { "ObjectType" });
            DropIndex("dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles", new[] { "Users" });
            DropIndex("dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles", new[] { "Roles" });
            DropIndex("dbo.PermissionPolicyObjectPermissionsObject", new[] { "TypePermissionObject" });
            DropIndex("dbo.PermissionPolicyMemberPermissionsObject", new[] { "TypePermissionObject" });
            DropIndex("dbo.PermissionPolicyTypePermissionsObject", new[] { "Role" });
            DropIndex("dbo.PermissionPolicyNavigationPermissionsObject", new[] { "Role" });
            DropIndex("dbo.PermissionPolicyActionPermissionObject", new[] { "Role" });
            DropIndex("dbo.PermissionPolicyRole", new[] { "ObjectType" });
            DropIndex("dbo.OrganizationStructure", new[] { "Responsible" });
            DropIndex("dbo.OrganizationStructure", new[] { "Oid" });
            DropIndex("dbo.HCategory", new[] { "ObjectType" });
            DropIndex("dbo.HCategory", new[] { "Parent" });
            DropIndex("dbo.ResourceResources_EventEvents", new[] { "Resources" });
            DropIndex("dbo.ResourceResources_EventEvents", new[] { "Events" });
            DropIndex("dbo.Event", new[] { "ObjectType" });
            DropIndex("dbo.Event", new[] { "RecurrencePattern" });
            DropIndex("dbo.WorkOrderScheduler", new[] { "WorkOrder" });
            DropIndex("dbo.WorkOrderScheduler", new[] { "Oid" });
            DropIndex("dbo.TaskTasks_ManPowerManPowers", new[] { "Tasks" });
            DropIndex("dbo.TaskTasks_ManPowerManPowers", new[] { "ManPowers" });
            DropIndex("dbo.Task", new[] { "WorkOrder" });
            DropIndex("dbo.WorkOrder", new[] { "Request" });
            DropIndex("dbo.WorkOrder", new[] { "TypeOfService" });
            DropIndex("dbo.WorkOrder", new[] { "Customer" });
            DropIndex("dbo.WorkOrder", new[] { "Scheduler" });
            DropIndex("dbo.ContractService", new[] { "Contract" });
            DropIndex("dbo.ContractService", new[] { "TypeOfService" });
            DropIndex("dbo.Request", new[] { "WorkOrder" });
            DropIndex("dbo.Request", new[] { "TypeOfService" });
            DropIndex("dbo.Request", new[] { "CreatedByCustomer" });
            DropIndex("dbo.Request", new[] { "RequestedByCustomer" });
            DropIndex("dbo.RequestFileData", new[] { "RequestFile" });
            DropIndex("dbo.RequestFileData", new[] { "File" });
            DropIndex("dbo.QualificationList", new[] { "ManPower" });
            DropIndex("dbo.QualificationList", new[] { "Qualification" });
            DropIndex("dbo.QualificationFileData", new[] { "QualificationList" });
            DropIndex("dbo.QualificationFileData", new[] { "File" });
            DropIndex("dbo.ContractFileData", new[] { "ContractFile" });
            DropIndex("dbo.ContractFileData", new[] { "File" });
            DropIndex("dbo.ContractCondition", new[] { "Contract" });
            DropIndex("dbo.Contract", new[] { "Company" });
            DropIndex("dbo.Customer", new[] { "Branch" });
            DropIndex("dbo.Customer", new[] { "Company" });
            DropIndex("dbo.Customer", new[] { "Oid" });
            DropIndex("dbo.Email", new[] { "ManPower" });
            DropIndex("dbo.Email", new[] { "Customer" });
            DropIndex("dbo.ManPower", new[] { "Position" });
            DropIndex("dbo.ManPower", new[] { "Specialization" });
            DropIndex("dbo.ManPower", new[] { "Grade" });
            DropIndex("dbo.ManPower", new[] { "City" });
            DropIndex("dbo.ManPower", new[] { "Country" });
            DropIndex("dbo.ManPower", new[] { "Trade" });
            DropIndex("dbo.ManPower", new[] { "Shift" });
            DropIndex("dbo.ManPower", new[] { "Oid" });
            DropIndex("dbo.City", new[] { "Country" });
            DropIndex("dbo.CompanyBranch", new[] { "City" });
            DropIndex("dbo.CompanyBranch", new[] { "Country" });
            DropIndex("dbo.CompanyBranch", new[] { "Company" });
            DropIndex("dbo.BaseAddress", new[] { "ManPower" });
            DropIndex("dbo.BaseAddress", new[] { "CompanyBranch" });
            DropTable("dbo.ReportDataV2");
            DropTable("dbo.ModelDifference");
            DropTable("dbo.ModelDifferenceAspect");
            DropTable("dbo.DashboardData");
            DropTable("dbo.SNToolsStore");
            DropTable("dbo.ToolStore");
            DropTable("dbo.StoreType");
            DropTable("dbo.SparPart");
            DropTable("dbo.SNSparPart");
            DropTable("dbo.Units");
            DropTable("dbo.GroupsOfItems");
            DropTable("dbo.MaterialStores");
            DropTable("dbo.Store");
            DropTable("dbo.Trade");
            DropTable("dbo.Specialization");
            DropTable("dbo.Shift");
            DropTable("dbo.Grade");
            DropTable("dbo.Whatsapp");
            DropTable("dbo.Mobile");
            DropTable("dbo.FixedPhone");
            DropTable("dbo.CounteryCodePhone");
            DropTable("dbo.Fax");
            DropTable("dbo.Facebook");
            DropTable("dbo.WorkArea");
            DropTable("dbo.Penalties");
            DropTable("dbo.PermissionPolicyUser");
            DropTable("dbo.PermissionPolicyUserUsers_PermissionPolicyRoleRoles");
            DropTable("dbo.PermissionPolicyObjectPermissionsObject");
            DropTable("dbo.PermissionPolicyMemberPermissionsObject");
            DropTable("dbo.PermissionPolicyTypePermissionsObject");
            DropTable("dbo.PermissionPolicyNavigationPermissionsObject");
            DropTable("dbo.PermissionPolicyActionPermissionObject");
            DropTable("dbo.PermissionPolicyRole");
            DropTable("dbo.OrganizationStructure");
            DropTable("dbo.HCategory");
            DropTable("dbo.XPObjectType");
            DropTable("dbo.Resource");
            DropTable("dbo.ResourceResources_EventEvents");
            DropTable("dbo.Event");
            DropTable("dbo.WorkOrderScheduler");
            DropTable("dbo.TaskTasks_ManPowerManPowers");
            DropTable("dbo.Task");
            DropTable("dbo.WorkOrder");
            DropTable("dbo.ContractService");
            DropTable("dbo.TypeOfService");
            DropTable("dbo.Request");
            DropTable("dbo.RequestFileData");
            DropTable("dbo.Qualification");
            DropTable("dbo.QualificationList");
            DropTable("dbo.QualificationFileData");
            DropTable("dbo.FileData");
            DropTable("dbo.ContractFileData");
            DropTable("dbo.ContractCondition");
            DropTable("dbo.Contract");
            DropTable("dbo.Company");
            DropTable("dbo.Customer");
            DropTable("dbo.Email");
            DropTable("dbo.ManPower");
            DropTable("dbo.Country");
            DropTable("dbo.City");
            DropTable("dbo.CompanyBranch");
            DropTable("dbo.BaseAddress");
        }
    }
}
