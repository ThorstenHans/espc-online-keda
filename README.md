# ESPC 2020 Online - Serverless Workloads in Azure Kubernetes with KEDA

This repository contains the sample application shown as part of my remote talk for European SharePoint and Azure Conference 2020.

## Requirements

Verify you have installed and configured the following software on your system

- [git](https://git-scm.com)
- [docker](https://docker.com)
- [helm](https://helm.sh)
- [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli)

## Sample Sources

The sample application consists of three major components.  

The [Message Producer](src/MessageProducer), which is responsible to publish messages to the Azure Storage Account Queue. 

The [Message Transformer](src/MessageTransformer) , which is responsible to transform messages from the inbound Azure Storage Account Queue, and publish messages of a different format to another Azure Storage Account Queue.

The [Message Dispatcher](src/MessageDispatcher), which creates and publishes a blob to Azure Storage Account blob storage based on messages created from the _Message Transformer_.

## Presentation

The slides I use during my talk will be published on [my SpeakerDeck profile](https://thns.io/slides), once ESPC 2020 took place.

## Questions & Feedback

If you have questions or feedback, create an issue or submit a pull request.
