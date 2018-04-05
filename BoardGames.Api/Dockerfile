FROM microsoft/aspnetcore:2.1.0-preview1 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.1.300-preview1 AS build
WORKDIR /src
COPY BoardGames.Api.csproj .
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
RUN dotnet build BoardGames.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish BoardGames.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BoardGames.Api.dll"]
