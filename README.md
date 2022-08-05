# How to check on your CI/CD pipeline if your application has a NuGet package with a security vulnerability

This repository contains a couple of examples about how you can check on your CI/CD pipeline if your application has a NuGet package with a security vulnerability.

To check if a NuGet package contains a security vulnerability we're using the ``dotnet list package –vulnerable`` command, this command uses the Github Adivsory Database to identify vulnerabilities in nuget packages.

You can check the ``azure-pipelines.yml`` file to view an example of how to use the ``dotnet list package –vulnerable`` command inside an Azure CI/CD Pipeline.

Also, you can check the ``.github/workflows/dotnet.yml`` file to view an example of how to use the ``dotnet list package –vulnerable`` command inside a GitHub Action.

