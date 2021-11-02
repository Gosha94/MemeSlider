#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source
COPY ["src/MemeSlider.ConsoleApplication/MemeSlider.ConsoleApplication.csproj", "source/MemeSlider.ConsoleApplication/"]
RUN dotnet restore "source/MemeSlider.ConsoleApplication/MemeSlider.ConsoleApplication.csproj"
COPY . .
WORKDIR "/source/src/MemeSlider.ConsoleApplication"
RUN dotnet build "MemeSlider.ConsoleApplication.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MemeSlider.ConsoleApplication.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemeSlider.ConsoleApplication.dll"]
CMD ["argument"]