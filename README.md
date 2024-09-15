
# Clickable Game Backend

This project is a backend for the Clickable Game, built using .NET Core and set up to run in a Docker environment.

## Prerequisites

Before running the project, make sure you have the following installed on your machine:

- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)
- [.NET Core SDK](https://dotnet.microsoft.com/download)

## Getting Started

Follow these steps to set up and run the project locally.

### 1. Clone the repository

If you haven't cloned the repository yet, clone it using the following command:

```bash
git clone https://github.com/peroz4747/ClickableGameBackend.git
```

Navigate into the project directory:

```bash
cd ClickableGameBackend
```

### 2. Build and Run the Docker Containers

To build and start the application containers, use the following command:

```bash
docker-compose up --build -d
```

This will build the Docker containers and run them in detached mode.

### 3. Update the Database

Once the containers are running, you need to apply the database migrations. Run the following command:

```bash
dotnet ef database update
```

This will ensure that the database schema is up to date.

### 4. Access the APIs through Swagger

The application should now be running, and you can access it at:

```
http://localhost:8080/swagger/index.html
```

Make sure to check the `docker-compose.yml` file to confirm the port configuration.

To simply find local IP on which app is running run: `docker inspect -f '{{range .NetworkSettings.Networks}}{{.IPAddress}}{{end}}' clickablegamebackend-app-1`

## Configuration

You can customize environment variables and other settings by modifying the `docker-compose.yml` or `appsettings.json` files, depending on your requirements. (check `docker-compose.yml.example` and `appsettings.json.example`)

## Additional Commands

- To stop the containers, run:

```bash
docker-compose down --volumes --remove-orphans
```

- To rebuild and restart without using the cache:

```bash
docker-compose up --build --force-recreate
```

## Troubleshooting

If you encounter any issues, please check the Docker logs for detailed error messages:

```bash
docker-compose logs <container_name_or_id>
```