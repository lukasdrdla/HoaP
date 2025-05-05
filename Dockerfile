FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY *.sln ./
COPY HoaP.Web/*.csproj HoaP.Web/
COPY HoaP.Application/*.csproj HoaP.Application/
COPY HoaP.Infrastructure/*.csproj HoaP.Infrastructure/
COPY HoaP.Domain/*.csproj HoaP.Domain/
RUN dotnet restore

COPY . .
RUN dotnet publish HoaP.Web/HoaP.Web.csproj -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "HoaP.Web.dll"]
