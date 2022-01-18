# dotnet-catalog-api

This project provides a simple demonstration of how to create a Web API using DotNet 5.0.

Useful hints:

- Create a REST API with .NET 5 and C#: https://www.freecodecamp.org/news/create-a-rest-api-with-dot-net-5-and-c-sharp/

- Trust HTTPS certificate on Linux using Edge or Chrome: https://aka.ms/dev-certs-trust

- Add MongoDB package by Nuget: dotnet add package MongoDB.Driver

- Install MongoDB using Docker: docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo

- Install MongoDB using Docker with credentials access enabled: docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db -e MONGO_INITDB_ROOT_USERNAME=useradmin -e MONGO_INITDB_ROOT_PASSWORD=password123

- Add a secret store (.NET Secret Manager) to the project: dotnet user-secrets init

- Save a password in the secret store: dotnet user-secrets set MongoDbConfiguration:Password password123

