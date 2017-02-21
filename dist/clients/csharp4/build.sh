#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

frameworkVersion=net45
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Download nuget and packages"
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install src/Nedap.Retail.Api.Idcloud/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.8.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net45/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Nedap.Retail.Api.Idcloud.dll"
mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Nedap.Retail.Api.Idcloud.dll \
-recurse:'src/Nedap.Retail.Api.Idcloud/*.cs' \
-doc:bin/Nedap.Retail.Api.Idcloud.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Nedap.Retail.Api.Idcloud.dll was created successfully"
fi
