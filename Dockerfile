# Use the official .NET Core SDK as a parent image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy the project file and restore any dependencies (use .csproj for the project name)
COPY *.sln .
COPY ./src/domain/expenses.domain/expenses.domain.csproj ./src/domain/expenses.domain/
COPY ./src/webapi/expenses.webapi/expenses.webapi.csproj ./src/webapi/expenses.webapi/
RUN dotnet restore

# Copy the rest of the application code
COPY . ./

# Publish the application
WORKDIR /app/src/webapi/expenses.webapi
RUN dotnet publish -c Release -o publish

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/src/webapi/expenses.webapi/publish ./

EXPOSE 80

# Start the application
ENTRYPOINT ["dotnet", "expenses.webapi.dll"]