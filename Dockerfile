FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["my-aspnet-portfolio.csproj", "./"]
RUN dotnet restore "my-aspnet-portfolio.csproj"

COPY . .
RUN dotnet publish "my-aspnet-portfolio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "my-aspnet-portfolio.dll"]