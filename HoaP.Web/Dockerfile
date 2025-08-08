FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["HoaP.Web/HoaP.Web.csproj", "HoaP.Web/"]
COPY ["HoaP.Infrastructure/HoaP.Infrastructure.csproj", "HoaP.Infrastructure/"]
COPY ["HoaP.Application/HoaP.Application.csproj", "HoaP.Application/"]
COPY ["HoaP.Domain/HoaP.Domain.csproj", "HoaP.Domain/"]
RUN dotnet restore "HoaP.Web/HoaP.Web.csproj"
COPY . .
WORKDIR "/src/HoaP.Web"
RUN dotnet build "HoaP.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "HoaP.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HoaP.Web.dll"]
