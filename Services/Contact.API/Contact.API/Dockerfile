#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Services/Contact.API/Contact.API/Contact.API.csproj", "Services/Contact.API/Contact.API/"]
COPY ["Services/Contact.API/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "Services/Contact.API/Contact.API.Infrastructure/"]
COPY ["Services/Contact.API/Contact.API.Models/Contact.API.Models.csproj", "Services/Contact.API/Contact.API.Models/"]
COPY ["Services/Contact.API/Contact.API.Service/Contact.API.Service.csproj", "Services/Contact.API/Contact.API.Service/"]
RUN dotnet restore "Services/Contact.API/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/Contact.API/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]