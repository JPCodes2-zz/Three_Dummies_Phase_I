FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Dummy1.API/Dummy1.API.csproj", "Dummy1.API/"]
RUN dotnet restore "Dummy1.API/Dummy1.API.csproj"
COPY . .
WORKDIR "/src/Dummy1.API"
RUN dotnet build "Dummy1.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dummy1.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dummy1.API.dll"]
