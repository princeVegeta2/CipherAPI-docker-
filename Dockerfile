# Use the official .NET 6 base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CipherAPI/CipherAPI.csproj", "CipherAPI/"]
RUN dotnet restore "CipherAPI/CipherAPI.csproj"
COPY . .
WORKDIR "/src/CipherAPI"
RUN dotnet build "CipherAPI.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "CipherAPI.csproj" -c Release -o /app/publish

# Copy the published app to the base image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CipherAPI.dll"]
