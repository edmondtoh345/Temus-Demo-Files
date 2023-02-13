FROM mcr.microsoft.com/dotnet/sdk:6.0 as buildStage
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /deploy
COPY --from=buildStage /app/out .
ENTRYPOINT ["dotnet", "LayeredAppDemo.dll"]