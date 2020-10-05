#!/bin/bash

# This script uses Helm3 check https://helm.sh if you have no local installation of Helm CLI

helm repo add kedacore https://kedacore.github.io/charts
helm repo update

kubectl create namespace keda

helm install keda kedacore/keda --namespace keda
