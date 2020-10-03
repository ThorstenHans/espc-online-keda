#!/bin/bash

# Variables
RG_NAME=espc-online

echo 'Removing Azure Resource Group ' $RG_NAME
az group delete -n $RG_NAME --no-wait --yes

echo 'Removal is async....'
echo 'Please check succesful removal later using (az group list)'
