# Kubernetes Deployment

## Requirements

- Verify both Docker Images (`functions/transformer` and `functions/dispatcher`) are pushed to your ACR instance in version `0.0.1`
- Verify your local `kubectl` points to the correct cluster (`kubectl config get-contexts`)
- Verify that both deployments [message-dispatcher/deployment.yml](message-dispatcher/deployment.yml) and [message-transformer/deployment.yml](message-transformer/deployment.yml) use proper Docker image name (replace `espc2020.azurecr.io` with your ACR prefix)

## Deployment

- Create Namespace in Kubernetes using `kubectl apply -f ./namespaces.yml`
- Deploy Connection String for Azure Storage Account to Kubernetes using Kubernetes secrets (customize and execute deploy-secrets.sh via `./deploy-secrets.sh`)
- Deploy Message Transformer (`kubectl apply -f ./message-transformer`)
- Deploy Message Dispatcher (`kubectl apply -f ./message-dispatcher`)

## Kubernetes default scaling

I have used the deployments and scripts from within [k8s-scaling](k8s-scaling) during the introduction of my talk. They are in the repository for reference.
