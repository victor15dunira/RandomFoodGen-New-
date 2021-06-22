terraform {
    required_providers {
        azurerm = {
            source  = "hashicorp/azurerm"
            version = "~> 2.46.0"
        }
    }
}

provider "azurerm" {
    features {}
}

resource "azurerm_resource_group" "rg" {
  name     = "Victors-ProjectFinal"
  location = "UK South"
}

resource "azurerm_app_service_plan" "sp" {
  name                = "victors-appserviceplan"
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name

  sku {
    tier = "Basic"
    size = "F1"
  }
}


  module "cuisineapp" {
    source          = "./cuisineapp"
    project_name    = var.project_name
    location = var.location
    app_service_plan_id = azurerm_app_service_plan.sp.id 
}

module "frontendapp" {
    source          = "./frontendapp"
    project_name    = var.project_name
    location = var.location
    app_service_plan_id = azurerm_app_service_plan.sp.id 
}

module "mealsapp" {
    source          = "./mealsapp"
    project_name    = var.project_name
    location = var.location
    app_service_plan_id = azurerm_app_service_plan.sp.id 
}

module "mergeapp" {
    source          = "./mergeapp"
    project_name    = var.project_name
    location = var.location
    app_service_plan_id = azurerm_app_service_plan.sp.id 
}