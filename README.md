# Docker Exercises
This repository contains Docker setup examples for projects in Go, Python, and .NET.

You must install [Docker](https://www.docker.com/) before using. Usage examples are below:

## Python

Go to the _python_ directory and build the image:

```bash
docker build -t python-application .
```

Run the container:

```bash
docker run -p 5000:5000 python-application
```

The app is running on [http://localhost:5000](http://localhost:5000).

- [Dockerfile](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/python/Dockerfile)
- [.dockerignore](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/python/.dockerignore)

## Golang

Go to the _golang_ directory and build the image:

```bash
docker build -t golang-application .
```

Run the container:

```bash
docker run -p 8080:8080 golang-application
```

The app is running on [http://localhost:8080](http://localhost:8080).

- [Dockerfile](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/golang/Dockerfile)
- [.dockerignore](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/golang/.dockerignore)

## .NET

Go to the _dotnet_ directory and build the image:

```bash
docker build -t dotnet-application .
```

Run the container:

```bash
docker run dotnet-application
```

The app is running on your terminal.

- [Dockerfile](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/dotnet/Dockerfile)
- [.dockerignore](https://github.com/HlibPavlyk/docker-exercises/blob/1e22e06aa9df1658522da8a9c2065de272285b79/dotnet/.dockerignore)
