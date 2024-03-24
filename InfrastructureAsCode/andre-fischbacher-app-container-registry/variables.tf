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
  default     = "1ecfcae9-7a0a-485b-87e7-0aae535c42cd"
}