# Описываем финальный слой с Runtime средой выполнения
FROM mcr.microsoft.com/dotnet/runtime:3.1 AS ReleaseLayer

# Копируем публикацию из папки ПК в папку на создаваемом образе
COPY bin/Release/netcoreapp3.1/publish /Release
# Сразу заходим в папку с приложением, когда создается контейнер, для удобства работы
WORKDIR /Release

# Запуск контейнеров в режиме чтения, без диагностики и отладки
ENV DOTNET_EnableDiagnostics=0

# Устанавливаем точку входа в библиотеку
ENTRYPOINT ["dotnet", "MemeSlider.ConsoleApplication.dll"]