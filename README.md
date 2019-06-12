# DOM.NET

[![Build Status](https://dev.azure.com/domdotnet/DOM.NET/_apis/build/status/drmathias.DOM.NET?branchName=master)](https://dev.azure.com/domdotnet/DOM.NET/_build/latest?definitionId=1&branchName=master) ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/DOM.NET.svg?label=NuGet&logo=nuget)

## Overview
This is an API wrapper to interact with the DOM via JSInterop, currently in pre-release. It supports .NET Standard 2.0 and is currently compatible only with client-side Blazor, though could probably be modified to work with server-side Blazor too.

## Usage
DOM.NET is not intended to be used primarly for updating the UI. Instead DOM.NET is meant to be used to fill in the gaps for DOM manipulation which Blazor does not support. The goal of this project is to create a library that is able to access the entire DOM, where you can pick and choose which interfaces you want to include in your project.

To use DOM.NET in your project, install the package from NuGet.org and copy the js files for the interfaces you want to access into your wwwroot, referencing them in your index.html file. 
