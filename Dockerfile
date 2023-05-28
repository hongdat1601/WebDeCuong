#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app/api
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src/api
COPY ["WebDeCuong.Api/WebDeCuong.Api.csproj", "WebDeCuong.Api/"]
COPY ["WebDeCuong.Data/WebDeCuong.Data.csproj", "WebDeCuong.Data/"]
RUN dotnet restore "WebDeCuong.Api/WebDeCuong.Api.csproj"
COPY . .
WORKDIR "/src/api/WebDeCuong.Api"
RUN dotnet build "WebDeCuong.Api.csproj" -c Release -o /app/api/build

FROM build AS publish
RUN dotnet publish "WebDeCuong.Api.csproj" -c Release -o /app/api/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app/api
COPY --from=publish /app/api/publish .
ENTRYPOINT ["dotnet", "WebDeCuong.Api.dll"]