#!/bin/bash
set -e

if psql -h simpldb --username postgres -lqt | cut -d \| -f 1 | grep -qw SecretTarot; then
    echo "SecretTarot database existed"
else
    echo "create new database SecretTarot"
	psql -h simpldb --username postgres -c "CREATE DATABASE SecretTarot WITH ENCODING 'UTF8'"
	psql -h simpldb --username postgres -d SecretTarot -a -f /app/dbscript.sql
fi

cd /app && dotnet SecretTarot.WebHost.dll 
