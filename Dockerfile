# Use the official .NET 8.0 SDK image as a build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /src

# Copy the csproj file and restore any dependencies
COPY app/ClickableGameBackend.csproj ./
RUN dotnet restore "./ClickableGameBackend.csproj"

# Copy the remaining source code
COPY app/ ./

# Build the project
RUN dotnet build "./ClickableGameBackend.csproj" -c Debug -o /app/build

# Use the same SDK image for the runtime to ensure the SDK is available
FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app

# Copy build artifacts
COPY --from=build-env /app/build .
COPY --from=build-env /root/.dotnet /root/.dotnet
COPY --from=build-env /root/.nuget /root/.nuget

# Install dotnet-ef tool
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"
ENV ASPNETCORE_ENVIRONMENT=Development

RUN apt-get update \
    && apt-get install -y unzip curl \
    && curl -sSL https://aka.ms/getvsdbgsh | /bin/sh /dev/stdin -v latest -l /vsdbg

# Expose port 8080
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "ClickableGameBackend.dll"]
