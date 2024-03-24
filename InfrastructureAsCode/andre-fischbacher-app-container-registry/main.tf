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