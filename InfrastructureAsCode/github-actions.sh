echo "GitHub secrets:"
echo credentials.json
echo ARM_CLIENT_ID = `cat credentials.json | python -c 'import json,sys;obj=json.load(sys.stdin);print(obj["appId"])'`
echo ARM_CLIENT_SECRET = `cat credentials.json | python -c 'import json,sys;obj=json.load(sys.stdin);print(obj["password"])'`
echo ARM_TENANT_ID = `cat credentials.json | python -c 'import json,sys;obj=json.load(sys.stdin);print(obj["tenant"])'`
echo ARM_SUBSCRIPTION_ID = `az account show --query id -o tsv`
read -p "Press any key to continue... " -n1 -s