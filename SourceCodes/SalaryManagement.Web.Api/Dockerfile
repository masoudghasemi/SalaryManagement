#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SourceCodes/SalaryManagement.Web.Api/SalaryManagement.Web.Api.csproj", "SourceCodes/SalaryManagement.Web.Api/"]
COPY ["SourceCodes/SalaryManagement.Core.IOC/SalaryManagement.Core.IOC.csproj", "SourceCodes/SalaryManagement.Core.IOC/"]
COPY ["SourceCodes/SalaryManagement.Core.AppService/SalaryManagement.Core.AppService.csproj", "SourceCodes/SalaryManagement.Core.AppService/"]
COPY ["SourceCodes/Framework/Framework.csproj", "SourceCodes/Framework/"]
COPY ["SourceCodes/SalaryManagement.BusinessLogic.OvertimePolicies/SalaryManagement.BusinessLogic.OvertimePolicies.csproj", "SourceCodes/SalaryManagement.BusinessLogic.OvertimePolicies/"]
COPY ["SourceCodes/SalaryManagement.Core.Infrastructure/SalaryManagement.Core.Infrastructure.csproj", "SourceCodes/SalaryManagement.Core.Infrastructure/"]
COPY ["SourceCodes/SalaryManagement.Core.Domain/SalaryManagement.Core.Domain.csproj", "SourceCodes/SalaryManagement.Core.Domain/"]
RUN dotnet restore "SourceCodes/SalaryManagement.Web.Api/SalaryManagement.Web.Api.csproj"
COPY . .
WORKDIR "/src/SourceCodes/SalaryManagement.Web.Api"
RUN dotnet build "SalaryManagement.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalaryManagement.Web.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalaryManagement.Web.Api.dll"]