using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Netshoes.Api.V1.Client;
using Netshoes.Api.V1.Model;

namespace Netshoes.Api.V1 {
  

  public interface IProductsApi {
    
    /// <summary>
    /// Get the list of products. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>ProductListResource</returns>
    ProductListResource ListProducts (int? Page, int? Size, string Expand);

    /// <summary>
    /// Get the list of products. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>ProductListResource</returns>
    Task<ProductListResource> ListProductsAsync (int? Page, int? Size, string Expand);
    
    /// <summary>
    /// Create a new product. 
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    ProductResource SaveProduct (ProductResource Body);

    /// <summary>
    /// Create a new product. 
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    Task<ProductResource> SaveProductAsync (ProductResource Body);
    
    /// <summary>
    /// Get the product by product id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Expand"></param>
    /// <returns>ProductResource</returns>
    ProductResource GetProduct (string ProductId, string Expand);

    /// <summary>
    /// Get the product by product id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Expand"></param>
    /// <returns>ProductResource</returns>
    Task<ProductResource> GetProductAsync (string ProductId, string Expand);
    
    /// <summary>
    /// Update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    ProductResource UpdateProduct (string ProductId, ProductResource Body);

    /// <summary>
    /// Update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    Task<ProductResource> UpdateProductAsync (string ProductId, ProductResource Body);
    
    /// <summary>
    /// Partialy update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    ProductResource PatchProduct (string ProductId, ProductResource Body);

    /// <summary>
    /// Partialy update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    Task<ProductResource> PatchProductAsync (string ProductId, ProductResource Body);
    
    /// <summary>
    /// Get the list of product attributes. 
    /// </summary>
    /// <param name="ProductId"></param>
    /// <returns>AttributeListResource</returns>
    AttributeListResource ListProductAttributes (string ProductId);

    /// <summary>
    /// Get the list of product attributes. 
    /// </summary>
    /// <param name="ProductId"></param>
    /// <returns>AttributeListResource</returns>
    Task<AttributeListResource> ListProductAttributesAsync (string ProductId);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ProductsApi : IProductsApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ProductsApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ProductsApi(String basePath)
    {
      this.apiClient = new ApiClient(basePath);
    }

    /// <summary>
    /// Sets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public void SetBasePath(String basePath) {
      this.apiClient.basePath = basePath;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public String GetBasePath(String basePath) {
      return this.apiClient.basePath;
    }

    /// <summary>
    /// Gets or sets the API client.
    /// </summary>
    /// <value>The API client</value>
    public ApiClient apiClient {get; set;}


    
    /// <summary>
    /// Get the list of products. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>ProductListResource</returns>
    public ProductListResource ListProducts (int? Page, int? Size, string Expand) {

      

      var path = "/products";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
       if (Size != null) queryParams.Add("size", apiClient.ParameterToString(Size)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListProducts: " + response.Content, response.Content);
      }
      return (ProductListResource) apiClient.Deserialize(response.Content, typeof(ProductListResource));
    }
	
	 /// <summary>
    /// Get the list of products. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>ProductListResource</returns>
    public async Task<ProductListResource> ListProductsAsync (int? Page, int? Size, string Expand) {

      

      var path = "/products";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
       if (Size != null) queryParams.Add("size", apiClient.ParameterToString(Size)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListProducts: " + response.Content, response.Content);
      }
      return (ProductListResource) apiClient.Deserialize(response.Content, typeof(ProductListResource));
    }
    
    /// <summary>
    /// Create a new product. 
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public ProductResource SaveProduct (ProductResource Body) {

      

      var path = "/products";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaveProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
	
	 /// <summary>
    /// Create a new product. 
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public async Task<ProductResource> SaveProductAsync (ProductResource Body) {

      

      var path = "/products";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaveProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
    
    /// <summary>
    /// Get the product by product id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Expand"></param>
    /// <returns>ProductResource</returns>
    public ProductResource GetProduct (string ProductId, string Expand) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling GetProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
	
	 /// <summary>
    /// Get the product by product id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Expand"></param>
    /// <returns>ProductResource</returns>
    public async Task<ProductResource> GetProductAsync (string ProductId, string Expand) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling GetProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling GetProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
    
    /// <summary>
    /// Update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public ProductResource UpdateProduct (string ProductId, ProductResource Body) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling UpdateProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
	
	 /// <summary>
    /// Update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public async Task<ProductResource> UpdateProductAsync (string ProductId, ProductResource Body) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling UpdateProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
    
    /// <summary>
    /// Partialy update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public ProductResource PatchProduct (string ProductId, ProductResource Body) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling PatchProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PatchProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
	
	 /// <summary>
    /// Partialy update the product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>ProductResource</returns>
    public async Task<ProductResource> PatchProductAsync (string ProductId, ProductResource Body) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling PatchProduct");
      

      var path = "/products/{productId}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      postBody = apiClient.Serialize(Body); // http body (model) parameter
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling PatchProduct: " + response.Content, response.Content);
      }
      return (ProductResource) apiClient.Deserialize(response.Content, typeof(ProductResource));
    }
    
    /// <summary>
    /// Get the list of product attributes. 
    /// </summary>
    /// <param name="ProductId"></param>
    /// <returns>AttributeListResource</returns>
    public AttributeListResource ListProductAttributes (string ProductId) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListProductAttributes");
      

      var path = "/products/{productId}/attributes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductAttributes: " + response.Content, response.Content);
      }
      return (AttributeListResource) apiClient.Deserialize(response.Content, typeof(AttributeListResource));
    }
	
	 /// <summary>
    /// Get the list of product attributes. 
    /// </summary>
    /// <param name="ProductId"></param>
    /// <returns>AttributeListResource</returns>
    public async Task<AttributeListResource> ListProductAttributesAsync (string ProductId) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListProductAttributes");
      

      var path = "/products/{productId}/attributes";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductAttributes: " + response.Content, response.Content);
      }
      return (AttributeListResource) apiClient.Deserialize(response.Content, typeof(AttributeListResource));
    }
    
  }  
  
}
