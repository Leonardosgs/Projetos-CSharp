#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ConsultórioVL/ConsultórioVL.csproj", "ConsultórioVL/"]
RUN dotnet restore "ConsultórioVL/ConsultórioVL.csproj"
COPY . .
WORKDIR "/src/ConsultórioVL"
RUN dotnet build "ConsultórioVL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsultórioVL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsultórioVL.dll"]