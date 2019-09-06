FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Imdb-Api/Imdb-Api.csproj", "Imdb-Api/"]
RUN dotnet restore "Imdb-Api/Imdb-Api.csproj"
COPY . .
WORKDIR "/src/Imdb-Api"
RUN dotnet build "Imdb-Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Imdb-Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Imdb-Api.dll"]