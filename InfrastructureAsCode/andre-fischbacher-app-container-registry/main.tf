resource "azurerm_resource_group" "afapp" {
  name     = "andrefischbacherapp-rg"
  location = "Canada Central"
}

resource "azurerm_container_registry" "acr" {
  name                = "andrefischbacherappacr"
  resource_group_name = azurerm_resource_group.afapp.name
  location            = azurerm_resource_group.afapp.location
  sku                 = "Basic"
  admin_enabled       = true
  tags = {
    Environment = "Production"
    CreatedBy   = "Terraform"
    Criticality = "High"
  }
}