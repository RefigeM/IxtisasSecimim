# Runtime mühiti
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build mühiti
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Ixtisas_Secimim.csproj", "./"]
RUN dotnet restore "./Ixtisas_Secimim.csproj"
COPY . .
RUN dotnet build "Ixtisas_Secimim.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ixtisas_Secimim.csproj" -c Release -o /app/publish

# Son image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ixtisas_Secimim.dll"]
