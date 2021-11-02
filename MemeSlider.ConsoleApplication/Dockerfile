#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY [ "MemeSlider.ConsoleApplication/MemeSlider.ConsoleApplication.csproj", "src/"]
RUN dotnet restore "src/"

COPY . .
WORKDIR "/src/MemeSlider.ConsoleApplication"
#RUN dotnet build "MemeSlider.ConsoleApplication.csproj" -c Release -o /app/build
RUN dotnet build -c Release -o /app/build

FROM build AS publish
#RUN dotnet publish "MemeSlider.ConsoleApplication.csproj" -c Release -o /app/publish
RUN dotnet publish -c release -o /app/publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemeSlider.ConsoleApplication.dll"]