#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://*:8080

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["openshiftapplication/openshiftapplication.csproj", "openshiftapplication/"]
RUN dotnet restore "openshiftapplication/openshiftapplication.csproj"
COPY . .
WORKDIR "/src/openshiftapplication"
RUN dotnet build "openshiftapplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "openshiftapplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "openshiftapplication.dll"]
