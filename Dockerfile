FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY ./src ./src

WORKDIR /src

RUN dotnet build

CMD dotnet test