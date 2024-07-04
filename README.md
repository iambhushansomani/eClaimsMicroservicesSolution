## Docker Compose Setup for Microservices with Prometheus and Grafana

This Docker Compose setup includes multiple microservices along with Prometheus and Grafana for monitoring purposes.

### Services

#### 1. Claims Service

- **Image:** `claims-service`
- **Build Context:** `./ClaimsService`
- **Exposed Port:** `8001` (mapped to `8080` inside the container)
- **Network:** `mynetwork`

#### 2. Documents Service

- **Image:** `documents-service`
- **Build Context:** `./DocumentsService`
- **Exposed Port:** `8002` (mapped to `8080` inside the container)
- **Network:** `mynetwork`

#### 3. Reports Service

- **Image:** `reports-service`
- **Build Context:** `./ReportsService`
- **Exposed Port:** `8003` (mapped to `8080` inside the container)
- **Network:** `mynetwork`

#### 4. Alerts Service

- **Image:** `alerts-service`
- **Build Context:** `./AlertsService`
- **Exposed Port:** `8004` (mapped to `8080` inside the container)
- **Network:** `mynetwork`

#### 5. SQL Server

- **Image:** `mcr.microsoft.com/mssql/server:2019-latest`
- **Environment Variables:**
  - `SA_PASSWORD`: YourStrong@Password (example)
  - `ACCEPT_EULA`: Y
- **Exposed Port:** `1433` (mapped to `1433` inside the container)
- **Network:** `mynetwork`

#### 6. Prometheus

- **Image:** `prom/prometheus`
- **Exposed Port:** `9090` (mapped to `9090` inside the container)
- **Network:** `mynetwork`
- **Volumes:** `./prometheus:/etc/prometheus`
- **Command:** `--config.file=/etc/prometheus/prometheus.yml`

#### 7. Grafana

- **Image:** `grafana/grafana`
- **Exposed Port:** `3000` (mapped to `3000` inside the container)
- **Network:** `mynetwork`

### Networks

- **Name:** `mynetwork`
- **Driver:** `bridge`

### Usage

1. **Clone the Repository:**
   ```bash
   git clone <repository-url>
   cd <repository-directory>
2. **Start Docker Compose:**
    ```bash
    docker-compose up -d

### Access Service 

- **Claims Service:** [http://localhost:8001](http://localhost:8001)
- **Documents Service:** [http://localhost:8002](http://localhost:8002)
- **Reports Service:** [http://localhost:8003](http://localhost:8003)
- **Alerts Service:** [http://localhost:8004](http://localhost:8004)
- **SQL Server:** Use SQL Server management tools, connect to [localhost:1433](http://localhost:1433)
- **Prometheus:** [http://localhost:9090](http://localhost:9090)
- **Grafana:** [http://localhost:3000](http://localhost:3000) (default credentials: admin/admin)



