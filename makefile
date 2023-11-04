build:
	dotnet build
clean:
	dotnet clean
restore:
	dotnet restore
watch:
	dotnet watch --project src/webapi/expenses.webapi/expenses.webapi.csproj run
start:
	dotnet run --project src/webapi/expenses.webapi/expenses.webapi.csproj