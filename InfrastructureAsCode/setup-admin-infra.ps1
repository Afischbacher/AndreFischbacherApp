$SUBSCRIPTION_ID=$(az account show --query id -o tsv)
$SERVICE_PRINCIPAL_NAME="MainInfra"

az ad sp create-for-rbac --name $SERVICE_PRINCIPAL_NAME --role "Owner" --scopes "/subscriptions/$SUBSCRIPTION_ID" > credentials.json