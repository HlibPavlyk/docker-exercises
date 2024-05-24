FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY src/. .

RUN dotnet restore && \
	dotnet publish -c Release -o out

ENTRYPOINT ["dotnet", "out/dotnet.dll"]