provider "azurerm" {
  skip_provider_registration = true
  features {}
  subscription_id = "ded32006-1443-4a0d-b1ff-a35afbf641c8"
}

terraform {
  required_providers {
    azurerm = {
      source = "hashicorp/azurerm"
    }
  }
  backend "azurerm" {
    subscription_id = var.azure-subscription-id
    resource_group_name  = var.state_resource_group_name
    storage_account_name = var.state_storage_account_name
    container_name       = "tfstate"
    key                  = "terraform-base.tfstate"
  }
}

data "azurerm_client_config" "current" {}