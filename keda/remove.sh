#!/bin/bash

# This script uses Helm3 check https://helm.sh if you have no local installation of Helm CLI

helm uninstall keda --namespace keda

# remove CRDs
kubectl delete -f https://raw.githubusercontent.com/kedacore/keda/master/deploy/crds/keda.k8s.io_scaledobjects_crd.yaml
kubectl delete -f https://raw.githubusercontent.com/kedacore/keda/master/deploy/crds/keda.k8s.io_triggerauthentications_crd.yaml

kubectl delete namespace keda
