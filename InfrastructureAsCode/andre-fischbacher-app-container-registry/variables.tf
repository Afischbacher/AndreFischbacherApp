variable "app_name" {
  type        = string
  description = "name of the app"
  default     = "andre-fischbacher-app-api"
}

variable "location" {
  type        = string
  description = "Location of Resources"
  default     = "canadacentral"
}

variable "container-app-sku" {
  type        = string
  description = "Location of Resources"
  default     = "canadacentral"
}

variable "azure-subscription-id" {
  type        = string
  description = "The subscription id for the Azure resources"
  default     = "ded32006-1443-4a0d-b1ff-a35afbf641c8"
}