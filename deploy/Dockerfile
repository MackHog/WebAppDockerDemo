FROM microsoft/dotnet:2.1-sdk AS build-env
WORKDIR /build
COPY . /build

#Restore
RUN dotnet restore ./WebAppDockerDemo.sln

RUN dotnet publish ./src/WebApp/WebApp.csproj --output /publish --configuration Release

# Build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /publish/ .
ENTRYPOINT ["dotnet", "WebApp.dll"]