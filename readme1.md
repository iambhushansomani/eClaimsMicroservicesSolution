### Kubernetes Deployment for Microservices(.Net C) with Ingress, Prometheus, and Grafana

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

##### 2. Verify Deployment

##### 3. Deploy Services
