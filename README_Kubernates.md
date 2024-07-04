### Kubernetes Deployment for Microservices (.Net C#) with Ingress, Prometheus, and Grafana

This repository contains Kubernetes YAML files to deploy a set of microservices along with Prometheus, Grafana, and an Ingress controller for routing.

#### Prerequisites

- [Minikube](https://minikube.sigs.k8s.io/docs/start/) or a Kubernetes cluster configured
- [kubectl](https://kubernetes.io/docs/tasks/tools/install-kubectl/) command-line tool installed

#### Kubernetes Configuration

##### 1. Deploy Services

Deploy the microservices and necessary components using the following commands:

```bash
kubectl apply -f kubernetes/claims-service.yml
kubectl apply -f kubernetes/documents-service.yml
kubectl apply -f kubernetes/reports-service.yml
kubectl apply -f kubernetes/alerts-service.yml
kubectl apply -f kubernetes/prometheus.yml
kubectl apply -f kubernetes/grafana.yml
kubectl apply -f kubernetes/ingress.yml
```

##### 2. Verify Deployment

After deployment, verify the status:

```bash
kubectl get pods
kubectl get services
kubectl get ingress
```

##### 3. Access Services

Once deployed, access the services using the Ingress controller:

- **Claims Service:** Replace \`claims-service\` with your actual service name: \`http://<minikube-ip>/claims-service\`
- **Documents Service:** Replace \`documents-service\` with your actual service name: \`http://<minikube-ip>/documents-service\`
- **Reports Service:** Replace \`reports-service\` with your actual service name: \`http://<minikube-ip>/reports-service\`
- **Alerts Service:** Replace \`alerts-service\` with your actual service name: \`http://<minikube-ip>/alerts-service\`
- **SQL Server:** Use appropriate tools to connect to the SQL Server instance within Kubernetes.
- **Prometheus:** Access Prometheus for monitoring at \`http://<minikube-ip>/prometheus\`
- **Grafana:** Access Grafana for visualization at \`http://<minikube-ip>/grafana\` (default credentials: admin/admin).

##### 4. Cleanup

To delete the deployed resources:

```bash
kubectl delete -f kubernetes/claims-service.yml
kubectl delete -f kubernetes/documents-service.yml
kubectl delete -f kubernetes/reports-service.yml
kubectl delete -f kubernetes/alerts-service.yml
kubectl delete -f kubernetes/prometheus.yml
kubectl delete -f kubernetes/grafana.yml
kubectl delete -f kubernetes/ingress.yml
```

##### 5. Monitoring and Visualization

To monitor and visualize your services:

- **Prometheus:** Configure Prometheus to scrape metrics from your services.
- **Grafana:** Connect Grafana to Prometheus as a data source for visualization and monitoring.

#### Additional Notes

- Adjust service names, paths, and configurations in YAML files (\`kubernetes/*.yml\`) as per your setup.
- Ensure Minikube or your Kubernetes cluster is properly configured with adequate resources.
