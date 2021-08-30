#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Micro.Service.PaymentAPI/Micro.Service.PaymentAPI.csproj", "Micro.Service.PaymentAPI/"]
RUN dotnet restore "Micro.Service.ProductAPI/Micro.Service.PaymentAPI.csproj"
COPY . .
WORKDIR "/src/Micro.Service.PaymentAPI"
RUN dotnet build "Micro.Service.PaymentAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Micro.Service.PaymentAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Micro.Service.PaymentAPI.dll"]