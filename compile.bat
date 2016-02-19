SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
%CSCPATH%\csc /reference:bin/Newtonsoft.Json.dll;bin/RestSharp.dll /target:library /out:bin/Netshoes.Api.V1.Client.dll /recurse:src\*.cs /doc:bin/Netshoes.Api.V1.Client.xml

