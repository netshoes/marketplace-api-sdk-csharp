using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Netshoes.Api.V1.Client;
using Netshoes.Api.V1.Model;

namespace Netshoes.Api.V1 {
  

  public interface ISkusApi {
    
    /// <summary>
    /// Get the list of product skus. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>SkuListResource</returns>
    SkuListResource ListProductSkus (string ProductId, int? Page, int? Size, string Expand);

    /// <summary>
    /// Get the list of product skus. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>SkuListResource</returns>
    Task<SkuListResource> ListProductSkusAsync (string ProductId, int? Page, int? Size, string Expand);
    
    /// <summary>
    /// Create a new sku for a product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    SkuResource SaveProductSku (string ProductId, SkuResource Body);

    /// <summary>
    /// Create a new sku for a product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    Task<SkuResource> SaveProductSkuAsync (string ProductId, SkuResource Body);
    
    /// <summary>
    /// Get the a sku by product Id and sku Id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Expand"></param>
    /// <returns>SkuResource</returns>
    SkuResource GetProductSku (string ProductId, string Sku, string Expand);

    /// <summary>
    /// Get the a sku by product Id and sku Id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Expand"></param>
    /// <returns>SkuResource</returns>
    Task<SkuResource> GetProductSkuAsync (string ProductId, string Sku, string Expand);
    
    /// <summary>
    /// Update a product based on SKU. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    SkuResource UpdateProductSku (string ProductId, string Sku, SkuResource Body);

    /// <summary>
    /// Update a product based on SKU. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    Task<SkuResource> UpdateProductSkuAsync (string ProductId, string Sku, SkuResource Body);
    
    /// <summary>
    /// Get the list of sku images. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>
    /// <returns>ImageListResource</returns>
    ImageListResource ListSkuImages (string ProductId, string Sku);

    /// <summary>
    /// Get the list of sku images. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>
    /// <returns>ImageListResource</returns>
    Task<ImageListResource> ListSkuImagesAsync (string ProductId, string Sku);
    
    /// <summary>
    /// Get product status. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>
    /// <returns>BusinessUnitResponse</returns>
    BusinessUnitResponse GetStatus (string Sku, string BuId);

    /// <summary>
    /// Get product status. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>
    /// <returns>BusinessUnitResponse</returns>
    Task<BusinessUnitResponse> GetStatusAsync (string Sku, string BuId);
    
    /// <summary>
    /// Enable or disable sku for sale. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>/// <param name="Body"></param>
    /// <returns>BusinessUnitResource</returns>
    BusinessUnitResource UpdateStatus (string Sku, string BuId, BusinessUnitResource Body);

    /// <summary>
    /// Enable or disable sku for sale. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>/// <param name="Body"></param>
    /// <returns>BusinessUnitResource</returns>
    Task<BusinessUnitResource> UpdateStatusAsync (string Sku, string BuId, BusinessUnitResource Body);
    
    /// <summary>
    /// Get a list of price schedules. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceList</returns>
    PriceList ListSchedules (string Sku);

    /// <summary>
    /// Get a list of price schedules. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceList</returns>
    Task<PriceList> ListSchedulesAsync (string Sku);
    
    /// <summary>
    /// Save a price schedule. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceScheduleResource</returns>
    PriceScheduleResource SaveSchedule (string Sku, PriceScheduleResource Body);

    /// <summary>
    /// Save a price schedule. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceScheduleResource</returns>
    Task<PriceScheduleResource> SaveScheduleAsync (string Sku, PriceScheduleResource Body);
    
    /// <summary>
    /// Get a base price. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceResource</returns>
    PriceResource ListPrices (string Sku);

    /// <summary>
    /// Get a base price. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceResource</returns>
    Task<PriceResource> ListPricesAsync (string Sku);
    
    /// <summary>
    /// Save a base price. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceResource</returns>
    PriceResource UpdatePrice (string Sku, PriceResource Body);

    /// <summary>
    /// Save a base price. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceResource</returns>
    Task<PriceResource> UpdatePriceAsync (string Sku, PriceResource Body);
    
    /// <summary>
    /// Get stock info by sku. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>StockResponse</returns>
    StockResponse GetStock (string Sku);

    /// <summary>
    /// Get stock info by sku. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>StockResponse</returns>
    Task<StockResponse> GetStockAsync (string Sku);
    
    /// <summary>
    /// Update stock quantity by sku. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>StockResponse</returns>
    StockResponse UpdateStock (string Sku, StockResource Body);

    /// <summary>
    /// Update stock quantity by sku. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>StockResponse</returns>
    Task<StockResponse> UpdateStockAsync (string Sku, StockResource Body);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class SkusApi : ISkusApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="SkusApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public SkusApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SkusApi"/> class.
    /// </summary>
    /// <returns></returns>
    public SkusApi(String basePath)
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
    /// Get the list of product skus. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>SkuListResource</returns>
    public SkuListResource ListProductSkus (string ProductId, int? Page, int? Size, string Expand) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListProductSkus");
      

      var path = "/products/{productId}/skus";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductSkus: " + response.Content, response.Content);
      }
      return (SkuListResource) apiClient.Deserialize(response.Content, typeof(SkuListResource));
    }
	
	 /// <summary>
    /// Get the list of product skus. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>
    /// <returns>SkuListResource</returns>
    public async Task<SkuListResource> ListProductSkusAsync (string ProductId, int? Page, int? Size, string Expand) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListProductSkus");
      

      var path = "/products/{productId}/skus";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductSkus: " + response.Content, response.Content);
      }
      return (SkuListResource) apiClient.Deserialize(response.Content, typeof(SkuListResource));
    }
    
    /// <summary>
    /// Create a new sku for a product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    public SkuResource SaveProductSku (string ProductId, SkuResource Body) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling SaveProductSku");
      

      var path = "/products/{productId}/skus";
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
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaveProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
	
	 /// <summary>
    /// Create a new sku for a product. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    public async Task<SkuResource> SaveProductSkuAsync (string ProductId, SkuResource Body) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling SaveProductSku");
      

      var path = "/products/{productId}/skus";
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
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling SaveProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
    
    /// <summary>
    /// Get the a sku by product Id and sku Id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Expand"></param>
    /// <returns>SkuResource</returns>
    public SkuResource GetProductSku (string ProductId, string Sku, string Expand) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling GetProductSku");
      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetProductSku");
      

      var path = "/products/{productId}/skus/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
	
	 /// <summary>
    /// Get the a sku by product Id and sku Id. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Expand"></param>
    /// <returns>SkuResource</returns>
    public async Task<SkuResource> GetProductSkuAsync (string ProductId, string Sku, string Expand) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling GetProductSku");
      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetProductSku");
      

      var path = "/products/{productId}/skus/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
    
    /// <summary>
    /// Update a product based on SKU. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    public SkuResource UpdateProductSku (string ProductId, string Sku, SkuResource Body) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling UpdateProductSku");
      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateProductSku");
      

      var path = "/products/{productId}/skus/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
	
	 /// <summary>
    /// Update a product based on SKU. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>SkuResource</returns>
    public async Task<SkuResource> UpdateProductSkuAsync (string ProductId, string Sku, SkuResource Body) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling UpdateProductSku");
      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateProductSku");
      

      var path = "/products/{productId}/skus/{sku}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductSku: " + response.Content, response.Content);
      }
      return (SkuResource) apiClient.Deserialize(response.Content, typeof(SkuResource));
    }
    
    /// <summary>
    /// Get the list of sku images. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>
    /// <returns>ImageListResource</returns>
    public ImageListResource ListSkuImages (string ProductId, string Sku) {

      
      // verify the required parameter 'ProductId' is set
      if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListSkuImages");
      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListSkuImages");
      

      var path = "/products/{productId}/skus/{sku}/images";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSkuImages: " + response.Content, response.Content);
      }
      return (ImageListResource) apiClient.Deserialize(response.Content, typeof(ImageListResource));
    }
	
	 /// <summary>
    /// Get the list of sku images. 
    /// </summary>
    /// <param name="ProductId"></param>/// <param name="Sku"></param>
    /// <returns>ImageListResource</returns>
    public async Task<ImageListResource> ListSkuImagesAsync (string ProductId, string Sku) {

      
          // verify the required parameter 'ProductId' is set
          if (ProductId == null) throw new ApiException(400, "Missing required parameter 'ProductId' when calling ListSkuImages");
      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListSkuImages");
      

      var path = "/products/{productId}/skus/{sku}/images";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "productId" + "}", apiClient.ParameterToString(ProductId));
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSkuImages: " + response.Content, response.Content);
      }
      return (ImageListResource) apiClient.Deserialize(response.Content, typeof(ImageListResource));
    }
    
    /// <summary>
    /// Get product status. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>
    /// <returns>BusinessUnitResponse</returns>
    public BusinessUnitResponse GetStatus (string Sku, string BuId) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetStatus");
      
      // verify the required parameter 'BuId' is set
      if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling GetStatus");
      

      var path = "/skus/{sku}/bus/{buId}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      path = path.Replace("{" + "buId" + "}", apiClient.ParameterToString(BuId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetStatus: " + response.Content, response.Content);
      }
      return (BusinessUnitResponse) apiClient.Deserialize(response.Content, typeof(BusinessUnitResponse));
    }
	
	 /// <summary>
    /// Get product status. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>
    /// <returns>BusinessUnitResponse</returns>
    public async Task<BusinessUnitResponse> GetStatusAsync (string Sku, string BuId) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetStatus");
      
          // verify the required parameter 'BuId' is set
          if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling GetStatus");
      

      var path = "/skus/{sku}/bus/{buId}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      path = path.Replace("{" + "buId" + "}", apiClient.ParameterToString(BuId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetStatus: " + response.Content, response.Content);
      }
      return (BusinessUnitResponse) apiClient.Deserialize(response.Content, typeof(BusinessUnitResponse));
    }
    
    /// <summary>
    /// Enable or disable sku for sale. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>/// <param name="Body"></param>
    /// <returns>BusinessUnitResource</returns>
    public BusinessUnitResource UpdateStatus (string Sku, string BuId, BusinessUnitResource Body) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateStatus");
      
      // verify the required parameter 'BuId' is set
      if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling UpdateStatus");
      

      var path = "/skus/{sku}/bus/{buId}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      path = path.Replace("{" + "buId" + "}", apiClient.ParameterToString(BuId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateStatus: " + response.Content, response.Content);
      }
      return (BusinessUnitResource) apiClient.Deserialize(response.Content, typeof(BusinessUnitResource));
    }
	
	 /// <summary>
    /// Enable or disable sku for sale. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="BuId"></param>/// <param name="Body"></param>
    /// <returns>BusinessUnitResource</returns>
    public async Task<BusinessUnitResource> UpdateStatusAsync (string Sku, string BuId, BusinessUnitResource Body) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateStatus");
      
          // verify the required parameter 'BuId' is set
          if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling UpdateStatus");
      

      var path = "/skus/{sku}/bus/{buId}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      path = path.Replace("{" + "buId" + "}", apiClient.ParameterToString(BuId));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateStatus: " + response.Content, response.Content);
      }
      return (BusinessUnitResource) apiClient.Deserialize(response.Content, typeof(BusinessUnitResource));
    }
    
    /// <summary>
    /// Get a list of price schedules. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceList</returns>
    public PriceList ListSchedules (string Sku) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListSchedules");
      

      var path = "/skus/{sku}/priceSchedules";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSchedules: " + response.Content, response.Content);
      }
      return (PriceList) apiClient.Deserialize(response.Content, typeof(PriceList));
    }
	
	 /// <summary>
    /// Get a list of price schedules. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceList</returns>
    public async Task<PriceList> ListSchedulesAsync (string Sku) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListSchedules");
      

      var path = "/skus/{sku}/priceSchedules";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSchedules: " + response.Content, response.Content);
      }
      return (PriceList) apiClient.Deserialize(response.Content, typeof(PriceList));
    }
    
    /// <summary>
    /// Save a price schedule. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceScheduleResource</returns>
    public PriceScheduleResource SaveSchedule (string Sku, PriceScheduleResource Body) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling SaveSchedule");
      

      var path = "/skus/{sku}/priceSchedules";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling SaveSchedule: " + response.Content, response.Content);
      }
      return (PriceScheduleResource) apiClient.Deserialize(response.Content, typeof(PriceScheduleResource));
    }
	
	 /// <summary>
    /// Save a price schedule. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceScheduleResource</returns>
    public async Task<PriceScheduleResource> SaveScheduleAsync (string Sku, PriceScheduleResource Body) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling SaveSchedule");
      

      var path = "/skus/{sku}/priceSchedules";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling SaveSchedule: " + response.Content, response.Content);
      }
      return (PriceScheduleResource) apiClient.Deserialize(response.Content, typeof(PriceScheduleResource));
    }
    
    /// <summary>
    /// Get a base price. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceResource</returns>
    public PriceResource ListPrices (string Sku) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListPrices");
      

      var path = "/skus/{sku}/prices";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListPrices: " + response.Content, response.Content);
      }
      return (PriceResource) apiClient.Deserialize(response.Content, typeof(PriceResource));
    }
	
	 /// <summary>
    /// Get a base price. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>PriceResource</returns>
    public async Task<PriceResource> ListPricesAsync (string Sku) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling ListPrices");
      

      var path = "/skus/{sku}/prices";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListPrices: " + response.Content, response.Content);
      }
      return (PriceResource) apiClient.Deserialize(response.Content, typeof(PriceResource));
    }
    
    /// <summary>
    /// Save a base price. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceResource</returns>
    public PriceResource UpdatePrice (string Sku, PriceResource Body) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdatePrice");
      

      var path = "/skus/{sku}/prices";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdatePrice: " + response.Content, response.Content);
      }
      return (PriceResource) apiClient.Deserialize(response.Content, typeof(PriceResource));
    }
	
	 /// <summary>
    /// Save a base price. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>PriceResource</returns>
    public async Task<PriceResource> UpdatePriceAsync (string Sku, PriceResource Body) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdatePrice");
      

      var path = "/skus/{sku}/prices";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdatePrice: " + response.Content, response.Content);
      }
      return (PriceResource) apiClient.Deserialize(response.Content, typeof(PriceResource));
    }
    
    /// <summary>
    /// Get stock info by sku. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>StockResponse</returns>
    public StockResponse GetStock (string Sku) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetStock");
      

      var path = "/skus/{sku}/stocks";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetStock: " + response.Content, response.Content);
      }
      return (StockResponse) apiClient.Deserialize(response.Content, typeof(StockResponse));
    }
	
	 /// <summary>
    /// Get stock info by sku. 
    /// </summary>
    /// <param name="Sku"></param>
    /// <returns>StockResponse</returns>
    public async Task<StockResponse> GetStockAsync (string Sku) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling GetStock");
      

      var path = "/skus/{sku}/stocks";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetStock: " + response.Content, response.Content);
      }
      return (StockResponse) apiClient.Deserialize(response.Content, typeof(StockResponse));
    }
    
    /// <summary>
    /// Update stock quantity by sku. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>StockResponse</returns>
    public StockResponse UpdateStock (string Sku, StockResource Body) {

      
      // verify the required parameter 'Sku' is set
      if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateStock");
      

      var path = "/skus/{sku}/stocks";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateStock: " + response.Content, response.Content);
      }
      return (StockResponse) apiClient.Deserialize(response.Content, typeof(StockResponse));
    }
	
	 /// <summary>
    /// Update stock quantity by sku. 
    /// </summary>
    /// <param name="Sku"></param>/// <param name="Body"></param>
    /// <returns>StockResponse</returns>
    public async Task<StockResponse> UpdateStockAsync (string Sku, StockResource Body) {

      
          // verify the required parameter 'Sku' is set
          if (Sku == null) throw new ApiException(400, "Missing required parameter 'Sku' when calling UpdateStock");
      

      var path = "/skus/{sku}/stocks";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "sku" + "}", apiClient.ParameterToString(Sku));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateStock: " + response.Content, response.Content);
      }
      return (StockResponse) apiClient.Deserialize(response.Content, typeof(StockResponse));
    }
    
  }  
  
}
