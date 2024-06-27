# MQTT Server

Dockerized MQTT server using the [eclipse-mosquitto](https://hub.docker.com/_/eclipse-mosquitto) image.

### Features

The MQTT server is configured to:

- Use the default port `1883`
- Use port `9001` for WebSockets
- Allow anonymous connections

### Prerequisites

- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)

### Usage

To start the server, run the following command:

```bash
docker-compose up -d
```

