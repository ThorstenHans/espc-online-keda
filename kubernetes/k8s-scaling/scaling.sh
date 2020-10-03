#!/bin/bash

# Manual scaling via Kubectl
kubectl scale deploy sample-app -n k8s-scaling --replicas 10
kubectl scale deploy sample-app -n k8s-scaling --replicas 2

# Horizontal Pod Autoscaling (HPA)
kubectl autoscale deploy sample-app -n k8s-scaling --cpu-percent=65 --min=2 --max=12
