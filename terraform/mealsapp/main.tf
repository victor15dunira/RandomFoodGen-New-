resource "azurerm_app_service" "mealsapp" {
  name                = "mealsapp-app-service"
  location            = var.location
  resource_group_name = var.project_name
  app_service_plan_id = var.app_service_plan_id 
}