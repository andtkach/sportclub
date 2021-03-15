0. Create databses for users: DemoIdentityDb and for data: DemoAppDb
1. Provide connection strings in appsettings file

2. Add-Migration InitialMigration -Context IdentityDbContext
3. Update-Database -Context IdentityDbContext

2. Add-Migration InitialMigration -Context AppDbContext
3. Update-Database -Context AppDbContext
