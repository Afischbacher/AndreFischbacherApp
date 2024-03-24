resource "azurerm_resource_group" "afapp" {
  name     = "AndreFischbacherApp"
  location = "Canada Central"
}

resource "azurerm_container_registry" "acr" {
  name                = "andrefischbacherappacr"
  resource_group_name = azurerm_resource_group.afapp.name
  location            = azurerm_resource_group.afapp.location
  sku                 = "Basic"
  admin_enabled       = true
  georeplications {
    location                = "Canada Central"
    zone_redundancy_enabled = false
    tags = {
      Environment = "Production"
      CreatedBy   = "Terraform"
    }
  }
}

# resource "azurerm_log_analytics_workspace" "af-app-analytics-workspace" {
#   name                = "andre-fischbacher-app-anlwrkspc-01"
#   location            = azurerm_resource_group.afapp.location
#   resource_group_name = azurerm_resource_group.afapp.name
#   sku                 = "Free"
#   retention_in_days   = 14
#   daily_quota_gb = 0.5
#   depends_on = [azurerm_container_registry.acr]
# }

# resource "azurerm_container_app_environment" "af-app-container-app-env" {
#   name                       = "Andre-Fischbacher-App-Container-App-Env"
#   location                   = azurerm_resource_group.example.location
#   resource_group_name        = azurerm_resource_group.example.name
#   log_analytics_workspace_id = azurerm_log_analytics_workspace.example.id
# }

# resource "azurerm_container_app" "example" {
#   name                         = "andre-fischbacher-app-api"
#   container_app_environment_id = azurerm_container_app_environment.example.id
#   resource_group_name          = azurerm_resource_group.example.name
#   revision_mode                = "Single"

#   template {
#     container {
#       name   = "examplecontainerapp"
#       image  = "mcr.microsoft.com/azuredocs/containerapps-helloworld:latest"
#       cpu    = 0.25
#       memory = "0.5Gi"
#     }
#   }
# }