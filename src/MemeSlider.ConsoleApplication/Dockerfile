# ��������� ��������� ���� � Runtime ������ ����������
FROM mcr.microsoft.com/dotnet/runtime:3.1 AS ReleaseLayer

# �������� ���������� �� ����� �� � ����� �� ����������� ������
COPY bin/Release/netcoreapp3.1/publish /Release
# ����� ������� � ����� � �����������, ����� ��������� ���������, ��� �������� ������
WORKDIR /Release

# ������ ����������� � ������ ������, ��� ����������� � �������
ENV DOTNET_EnableDiagnostics=0

# ������������� ����� ����� � ����������
ENTRYPOINT ["dotnet", "MemeSlider.ConsoleApplication.dll"]