#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["src/payphone.challenge.restapi.BusWorker/payphone.challenge.restapi.BusWorker.csproj", "src/payphone.challenge.restapi.BusWorker/"]
COPY ["src/payphone.challenge.restapi.Infrastructure/payphone.challenge.restapi.Infrastructure.csproj", "src/payphone.challenge.restapi.Infrastructure/"]
COPY ["src/payphone.challenge.restapi.Application/payphone.challenge.restapi.Application.csproj", "src/payphone.challenge.restapi.Application/"]
COPY ["src/payphone.challenge.restapi.Domain/payphone.challenge.restapi.Domain.csproj", "src/payphone.challenge.restapi.Domain/"]
COPY ["src/payphone.challenge.restapi.Shared/payphone.challenge.restapi.Shared.csproj", "src/payphone.challenge.restapi.Shared/"]
COPY ["src/payphone.challenge.restapi.Shared.Particular/payphone.challenge.restapi.Shared.Particular.csproj", "src/payphone.challenge.restapi.Shared.Particular/"]
RUN dotnet restore "src/payphone.challenge.restapi.BusWorker/payphone.challenge.restapi.BusWorker.csproj"
COPY . .
WORKDIR "/src/src/payphone.challenge.restapi.BusWorker"
RUN dotnet build "payphone.challenge.restapi.BusWorker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "payphone.challenge.restapi.BusWorker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "payphone.challenge.restapi.BusWorker.dll"]