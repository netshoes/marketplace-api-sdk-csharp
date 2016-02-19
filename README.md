#SDK C Sharp - Marketplace Grupo Netshoes

Utilizando a SDK C Sharp, � poss�vel realizar as integra��es necess�rias com o marketplace do Grupo Netshoes de forma �gil e simples.

##Download e Compila��o

Para utiliza��o da SDK, fa�a o clone do projeto, utilizando o seguinte comando:

git clone https://github.com/netshoes/marketplace-api-sdk-csharp.git

... ou o download do arquivo zipado:

https://github.com/netshoes/marketplace-api-sdk-csharp/archive/master.zip

Em seguinda, fa�a a execu��o do arquivo _**<pasta_projeto>/compile.bat**_
Os arquivos DLL para importa��o em seu projeto de integra��o estar�o disponiveis em _**<pasta_projeto>/bin**_

##Configura��o das Informa��es de Acesso.

Antes de utilizar os recursos da API, � necess�rio realizar as configura��es de base path e tamb�m as credenciais para acesso.
Abaixo segue o c�digo de exemplo:

```csharp
Configuration.apiKey.Add("client_id", "Xd2UvK0niRme");
Configuration.apiKey.Add("access_token", "Kv6INdp01EvQ");
						 
ApiClient apiClient = new ApiClient("http://api-sandbox.netshoes.com.br/api/v1");
```

##Tratamento de Erro

Tratamento de estruturas de erros recebidas nas chamadas a API:

```csharp
private static ErrorResource DeserializeError(String errorJson, ApiClient apiClient) {

	ErrorResource error = null;
	try {

		error = (ErrorResource) apiClient.Deserialize(errorJson, typeof(ErrorResource));

	} catch (ApiException e) {
		Console.Write("Doesn't contains errors structure.");
	}

	return error;

}
```

##Recursos Dispon�veis

A seguir, ser� apresentada a API e exemplos com as as principais opera��es do Marketplace do Grupo Netshoes.

###Product Template API

Cont�m os recursos utilizados para aux�lio na configura��o dos produtos que ser�o enviados ao marketplace.

####Lista de Departamentos
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	DepartmentListResource departmentListResource = productsTemplatesApi.ListDepartments("NS");
	Console.Write(departmentListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}	
```

####Lista de Tipos de Produtos
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	ProductTypeListResource productTypeListResource = productsTemplatesApi.ListProductTypes(10);
	Console.Write(productTypeListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Lista de Marcas
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	BrandListResource brandListResource = productsTemplatesApi.ListBrands();
	Console.Write(brandListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Lista de Tamanhos
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	SizeListResource sizeListResource = productsTemplatesApi.ListSizes();
	Console.Write(sizeListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Lista de Sabores
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	FlavorListResource flavorListResource = productsTemplatesApi.ListFlavors();
	Console.Write(flavorListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Lista de Cores
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	ColorListResource colorListResource = productsTemplatesApi.ListColors();
	Console.Write(colorListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Lista de Templates
```csharp
ProductsTemplatesApi productsTemplatesApi = new ProductsTemplatesApi(apiClient);

try {
	TemplateListResource templateListResource = productsTemplatesApi.ListTemplates(10, 4);
	Console.Write(templateListResource.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

###Products API

Cont�m os recursos utilizados para cria��o e altera��o de produtos enviados ao marketplace.

#### Cria��o de Novos Produtos

```csharp
ProductResource productResource = new ProductResource();
productResource.ProductId = "12345";
productResource.Department = "Futebol";
productResource.ProductType = "Agasalhos";
productResource.Brand = "Penalty";

AttributeResource attributeResource;

attributeResource = new AttributeResource();
attributeResource.Name = "SEXO";
attributeResource.Value = "M";
	
productResource.Attributes = new List<AttributeResource>();
productResource.Attributes.Add(attributeResource);

ImageResource imageResource;
SkuResource skuResource;

productResource.Skus = new List<SkuResource>();

skuResource = new SkuResource();
skuResource.Sku = "111-0457-289-52";
skuResource.Name = "Agasalho Teste 01 Penalty";
skuResource.Description = "Agasalho, Branco, Penalty";
skuResource.Color = "Branco";
skuResource.Gender = "Homem";
skuResource.Size = "G";
skuResource.EanIsbn = "16598198";

imageResource = new ImageResource();
imageResource.Url = "http://7-themes.com/data_images/out/42/6914793-tropical-beach-images.jpg";
skuResource.Images = new List<ImageResource>();
skuResource.Images.Add(imageResource);

skuResource.Video = "http://video/video1";
skuResource.Height = 20.0;
skuResource.Width = 10.0;
skuResource.Depth = 44.0;
skuResource.Weight = 65.0;

productResource.Skus.Add(skuResource);

skuResource = new SkuResource();
skuResource.Sku = "111-0457-289-53";
skuResource.Name = "Agasalho Teste 01 Penalty";
skuResource.Description = "Agasalho, Branco, Penalty";
skuResource.Color = "Branco";
skuResource.Gender = "Homem";
skuResource.Size = "M";
skuResource.EanIsbn = "16598198";

imageResource = new ImageResource();
imageResource.Url = "http://7-themes.com/data_images/out/42/6914793-tropical-beach-images.jpg";
skuResource.Images = new List<ImageResource>();
skuResource.Images.Add(imageResource);

skuResource.Video = "http://video/video1";
skuResource.Height = 20.0;
skuResource.Width = 10.0;
skuResource.Depth = 44.0;
skuResource.Weight = 65.0;

productResource.Skus.Add(skuResource);


ProductsApi productsApi = new ProductsApi(apiClient);

try {
	ProductResource productResponse = productsApi.SaveProduct(productResource);
	Console.Write(productResponse.ToJson());
} catch (ApiException e) {
	ErrorResource errorResource = DeserializeError(e.ErrorContent, apiClient);
	if (errorResource == null) {
		Console.Write(e.StackTrace);
	} else {
		Console.Write(errorResource.ToJson());
	}
}
```

###SKUs API

Cont�m os recursos utilizados para checagem de SKUs relacionados aos produtos enviados ao marketplace.

####Verifica��o do Status de Sincroniza��o Com o Marketplace

Ap�s fazer o envio dos seus produtos no exemplo anterior, voc� poder� fazer a verifica��o de sincroniza��o com o marketplace:

```csharp
SkusApi skusApi = new SkusApi(apiClient);

try {
	BusinessUnitResponse businessUnitResponse = skusApi.GetStatus("111-0457-289-52", "NS");
	Console.Write(businessUnitResponse.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

Isso indica que seus produtos j� podem ser comercializados nos portais de venda.
Mas antes, � necess�rio realizar os procedimentos de atualiza��o de estoque, pre�o e status, conforme exibido nos exemplos abaixo:

####Configura��o de Estoque

```csharp
SkusApi skusApi = new SkusApi(apiClient);

StockResource stockResource = new StockResource();
stockResource.Available = 20L;
stockResource.Country = "BR";

try {
	StockResponse stockResponse = skusApi.UpdateStock("111-0457-289-52", stockResource);
	Console.Write(stockResponse.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Configura��o de Pre�o

```csharp
SkusApi skusApi = new SkusApi(apiClient);

PriceResource priceResource = new PriceResource();
priceResource.Price = 100.0;

try {
	PriceResource priceResponse = skusApi.UpdatePrice("111-0457-289-52", priceResource);
	Console.Write(priceResponse.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

####Ativa��o do Produto para Venda

```csharp
SkusApi skusApi = new SkusApi(apiClient);

BusinessUnitResource businessUnitResource = new BusinessUnitResource();
businessUnitResource.Active = true;

try {
	BusinessUnitResource businessUnitResponse = 
		skusApi.UpdateStatus("111-0457-289-52", "NS", businessUnitResource);
	Console.Write(businessUnitResponse.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

###Orders API

Agora que os produtos j� est�o dispon�veis para venda, � poss�vel fazer a consulta de ordens geradas nos portais de venda Netshoes e Zattini.

```csharp
OrdersApi ordersApi = new OrdersApi(apiClient);

try {

	OrderListResource orderListResource = 
		ordersApi.ListOrders(0, 20, null, 
							 DateTime.Now.AddDays(-1), DateTime.Now,
							 "Faturado", "Venda");

	Console.Write(orderListResource.ToJson());

} catch (ApiException e) {
	ErrorResource errorResource = DeserializeError(e.ErrorContent, apiClient);
	if (errorResource == null) {
		Console.Write(e.StackTrace);
	} else {
		Console.Write(errorResource.ToJson());
	}
}
```
