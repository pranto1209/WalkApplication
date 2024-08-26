# Walk Application


### Update Database

Add-Migration -Context WalkApplicationDbContext WalkApplicationMigration

Add-Migration -Context AuthDbContext AuthMigration

Update-Database -Context WalkApplicationDbContext

Update-Database -Context AuthDbContext