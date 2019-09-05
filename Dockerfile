FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

COPY WebApp/*.csproj ./
COPY . ./
RUN dotnet restore 

FROM build-env AS publish
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app
LABEL Author="Venky Venkataraman"
LABEL Maintainer="venkydockerazuretest"
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApp.dll"]
