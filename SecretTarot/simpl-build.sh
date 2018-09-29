#!/bin/bash
set -e

sed -i'' -e 's|<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.1.3" />|<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="2.1.2" />|' src/SecretTarot.WebHost/SecretTarot.WebHost.csproj
sed -i'' -e 's/UseSqlServer/UseNpgsql/' src/SecretTarot.WebHost/Program.cs
sed -i'' -e 's/UseSqlServer/UseNpgsql/' src/SecretTarot.WebHost/Extensions/ServiceCollectionExtensions.cs

rm -rf src/SecretTarot.WebHost/Migrations/*

dotnet restore && dotnet build

cd src/SecretTarot.WebHost \
	&& dotnet ef migrations add initialSchema \
	&& dotnet ef database update
	
echo "The database schema has been created. Please execute the src/Database/StaticData_Postgres.sql to insert static data."
echo "Then type 'dotnet run' in src/SecretTarot.WebHost to start the app."
