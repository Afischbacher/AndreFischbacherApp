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

variable "ARM_SUBSCRIPTION_ID" {
  type        = string
  description = "The subscription id for the Azure resources"
}