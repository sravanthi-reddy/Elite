IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211027233608_Migrations')
BEGIN
    CREATE TABLE [Student] (
        [ID] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [ProgramCode] nvarchar(max) NULL,
        [MobileNo] int NOT NULL,
        [EmailID] nvarchar(max) NULL,
        [PostalCode] nvarchar(max) NULL,
        [CurrentSemester] nvarchar(max) NULL,
        CONSTRAINT [PK_Student] PRIMARY KEY ([ID])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211027233608_Migrations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211027233608_Migrations', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028004306_AddedDataAnnotationToStudentModel')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'LastName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Student] ALTER COLUMN [LastName] nvarchar(50) NOT NULL;
    ALTER TABLE [Student] ADD DEFAULT N'' FOR [LastName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028004306_AddedDataAnnotationToStudentModel')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'FirstName');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Student] ALTER COLUMN [FirstName] nvarchar(50) NOT NULL;
    ALTER TABLE [Student] ADD DEFAULT N'' FOR [FirstName];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028004306_AddedDataAnnotationToStudentModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028004306_AddedDataAnnotationToStudentModel', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028010910_AddedDataAnnotationForMobileNo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028010910_AddedDataAnnotationForMobileNo', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028193757_ChangedStudentFields')
BEGIN
    EXEC sp_rename N'[Student].[ProgramCode]', N'Skills', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028193757_ChangedStudentFields')
BEGIN
    EXEC sp_rename N'[Student].[CurrentSemester]', N'CurrentProgram', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028193757_ChangedStudentFields')
BEGIN
    ALTER TABLE [Student] ADD [DateJoinedCollege] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028193757_ChangedStudentFields')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028193757_ChangedStudentFields', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028194710_AddedDate')
BEGIN
    EXEC sp_rename N'[Student].[DateJoinedCollege]', N'DateEnrolled', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028194710_AddedDate')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'MobileNo');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Student] ALTER COLUMN [MobileNo] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028194710_AddedDate')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'EmailID');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Student] ALTER COLUMN [EmailID] nvarchar(max) NOT NULL;
    ALTER TABLE [Student] ADD DEFAULT N'' FOR [EmailID];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028194710_AddedDate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028194710_AddedDate', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028195244_ChangedStudentFieldss')
BEGIN
    ALTER TABLE [Student] ADD [IndustryExperience] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028195244_ChangedStudentFieldss')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028195244_ChangedStudentFieldss', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028195731_ChangedFields')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028195731_ChangedFields', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028201448_ChangedFieldss')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Student]') AND [c].[name] = N'MobileNo');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Student] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Student] ALTER COLUMN [MobileNo] nvarchar(max) NOT NULL;
    ALTER TABLE [Student] ADD DEFAULT N'' FOR [MobileNo];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028201448_ChangedFieldss')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028201448_ChangedFieldss', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211028225808_ChangedFieldssss')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211028225808_ChangedFieldssss', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029004546_newchanges')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211029004546_newchanges', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029023223_finalChanges')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211029023223_finalChanges', N'5.0.11');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029045113_finalChangess')
BEGIN
    ALTER TABLE [Student] ADD [GitHubUrl] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029045113_finalChangess')
BEGIN
    ALTER TABLE [Student] ADD [LinkedInProfile] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029045113_finalChangess')
BEGIN
    ALTER TABLE [Student] ADD [StackOverflowUrl] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211029045113_finalChangess')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211029045113_finalChangess', N'5.0.11');
END;
GO

COMMIT;
GO

