#SDK C Sharp - Marketplace Grupo Netshoes

Utilizando a SDK C Sharp, é possível realizar as integrações necessárias com o marketplace do Grupo Netshoes de forma ágil e simples.

##Download e Compilação

Para utilização da SDK, faça o clone do projeto, utilizando o seguinte comando:

git clone https://github.com/netshoes/marketplace-api-sdk-csharp.git

... ou o download do arquivo zipado:

https://github.com/netshoes/marketplace-api-sdk-csharp/archive/master.zip

Em seguinda, faça a execução do arquivo _**<pasta_projeto>/compile.bat**_
Os arquivos DLL para importação em seu projeto de integração estarão disponiveis em _**<pasta_projeto>/bin**_

##Configuração das Informações de Acesso.

Antes de utilizar os recursos da API, é necessário realizar as configurações de base path e também as credenciais para acesso.
Abaixo segue o código de exemplo:

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

##Recursos Disponíveis

A seguir, será apresentada a API e exemplos com as as principais operações do Marketplace do Grupo Netshoes.

###Product Template API

Contém os recursos utilizados para auxílio na configuração dos produtos que serão enviados ao marketplace.

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

Contém os recursos utilizados para criação e alteração de produtos enviados ao marketplace.

#### Criação de Novos Produtos

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

Contém os recursos utilizados para checagem de SKUs relacionados aos produtos enviados ao marketplace.

####Verificação do Status de Sincronização Com o Marketplace

Após fazer o envio dos seus produtos no exemplo anterior, você poderá fazer a verificação de sincronização com o marketplace:

```csharp
SkusApi skusApi = new SkusApi(apiClient);

try {
	BusinessUnitResponse businessUnitResponse = skusApi.GetStatus("111-0457-289-52", "NS");
	Console.Write(businessUnitResponse.ToJson());
} catch (ApiException e) {
	Console.Write(e.StackTrace);
}
```

Isso indica que seus produtos já podem ser comercializados nos portais de venda.
Mas antes, é necessário realizar os procedimentos de atualização de estoque, preço e status, conforme exibido nos exemplos abaixo:

####Configuração de Estoque

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

####Configuração de Preço

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

####Ativação do Produto para Venda

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

Agora que os produtos já estão disponíveis para venda, é possível fazer a consulta de ordens geradas nos portais de venda Netshoes e Zattini.

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
