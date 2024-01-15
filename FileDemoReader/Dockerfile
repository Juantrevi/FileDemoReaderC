FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FileDemo/FileDemo.csproj", "FileDemo/"]
RUN dotnet restore "FileDemo/FileDemo.csproj"
COPY . .
WORKDIR "/src/FileDemo"
RUN dotnet build "FileDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FileDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FileDemo.dll"]
