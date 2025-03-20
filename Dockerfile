# Use Windows-based .NET 9.0 images
FROM mcr.microsoft.com/dotnet/aspnet:9.0-windowsservercore-ltsc2022 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Use SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:9.0-windowsservercore-ltsc2022 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy project file and restore dependencies
COPY ["Peach_Clone.csproj", "."]
RUN dotnet restore "./Peach_Clone.csproj"

# Copy everything and build
COPY . .
WORKDIR "/src/."
RUN dotnet build "./Peach_Clone.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Peach_Clone.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final image setup
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Peach_Clone.dll"]
