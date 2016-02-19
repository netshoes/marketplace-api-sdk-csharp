using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Netshoes.Api.V1.Client;
using Netshoes.Api.V1.Model;

namespace Netshoes.Api.V1 {
  

  public interface IOrdersApi {
    
    /// <summary>
    /// Get a list of Orders. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>/// <param name="OrderStartDate"></param>/// <param name="OrderEndDate"></param>/// <param name="OrderStatus"></param>/// <param name="OrderType"></param>
    /// <returns>OrderListResource</returns>
    OrderListResource ListOrders (int? Page, int? Size, string Expand, DateTime? OrderStartDate, DateTime? OrderEndDate, string OrderStatus, string OrderType);

    /// <summary>
    /// Get a list of Orders. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>/// <param name="OrderStartDate"></param>/// <param name="OrderEndDate"></param>/// <param name="OrderStatus"></param>/// <param name="OrderType"></param>
    /// <returns>OrderListResource</returns>
    Task<OrderListResource> ListOrdersAsync (int? Page, int? Size, string Expand, DateTime? OrderStartDate, DateTime? OrderEndDate, string OrderStatus, string OrderType);
    
    /// <summary>
    ///  
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>OrderResource</returns>
    OrderResource SaveOrder (OrderResource Body);

    /// <summary>
    ///  
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>OrderResource</returns>
    Task<OrderResource> SaveOrderAsync (OrderResource Body);
    
    /// <summary>
    /// Get a order based on order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>OrderResource</returns>
    OrderResource GetOrder (string OrderNumber, string Expand);

    /// <summary>
    /// Get a order based on order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>OrderResource</returns>
    Task<OrderResource> GetOrderAsync (string OrderNumber, string Expand);
    
    /// <summary>
    /// Get a list of shippings by order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>ShippingListResource</returns>
    ShippingListResource ListOrderShippings (string OrderNumber, string Expand);

    /// <summary>
    /// Get a list of shippings by order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>ShippingListResource</returns>
    Task<ShippingListResource> ListOrderShippingsAsync (string OrderNumber, string Expand);
    
    /// <summary>
    /// Get a shipping based on order number and shipping code. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Expand"></param>
    /// <returns>ShippingResource</returns>
    ShippingResource GetOrderShipping (string OrderNumber, long? ShippingCode, string Expand);

    /// <summary>
    /// Get a shipping based on order number and shipping code. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Expand"></param>
    /// <returns>ShippingResource</returns>
    Task<ShippingResource> GetOrderShippingAsync (string OrderNumber, long? ShippingCode, string Expand);
    
    /// <summary>
    /// Update status of item. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="IdItem"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    StatusResource UpdateShippingItemStatus (string OrderNumber, long? ShippingCode, long? IdItem, StatusResource Body);

    /// <summary>
    /// Update status of item. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="IdItem"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    Task<StatusResource> UpdateShippingItemStatusAsync (string OrderNumber, long? ShippingCode, long? IdItem, StatusResource Body);
    
    /// <summary>
    /// Update status of shipping. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    StatusResource UpdateShippingStatus (string OrderNumber, long? ShippingCode, StatusResource Body);

    /// <summary>
    /// Update status of shipping. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    Task<StatusResource> UpdateShippingStatusAsync (string OrderNumber, long? ShippingCode, StatusResource Body);
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class OrdersApi : IOrdersApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public OrdersApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrdersApi"/> class.
    /// </summary>
    /// <returns></returns>
    public OrdersApi(String basePath)
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
    /// Get a list of Orders. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>/// <param name="OrderStartDate"></param>/// <param name="OrderEndDate"></param>/// <param name="OrderStatus"></param>/// <param name="OrderType"></param>
    /// <returns>OrderListResource</returns>
    public OrderListResource ListOrders (int? Page, int? Size, string Expand, DateTime? OrderStartDate, DateTime? OrderEndDate, string OrderStatus, string OrderType) {

      

      var path = "/orders";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
       if (Size != null) queryParams.Add("size", apiClient.ParameterToString(Size)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (OrderStartDate != null) queryParams.Add("orderStartDate", apiClient.ParameterToString(OrderStartDate)); // query parameter
       if (OrderEndDate != null) queryParams.Add("orderEndDate", apiClient.ParameterToString(OrderEndDate)); // query parameter
       if (OrderStatus != null) queryParams.Add("orderStatus", apiClient.ParameterToString(OrderStatus)); // query parameter
       if (OrderType != null) queryParams.Add("orderType", apiClient.ParameterToString(OrderType)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) apiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListOrders: " + response.Content, response.Content);
      }
      return (OrderListResource) apiClient.Deserialize(response.Content, typeof(OrderListResource));
    }
	
	 /// <summary>
    /// Get a list of Orders. 
    /// </summary>
    /// <param name="Page"></param>/// <param name="Size"></param>/// <param name="Expand"></param>/// <param name="OrderStartDate"></param>/// <param name="OrderEndDate"></param>/// <param name="OrderStatus"></param>/// <param name="OrderType"></param>
    /// <returns>OrderListResource</returns>
    public async Task<OrderListResource> ListOrdersAsync (int? Page, int? Size, string Expand, DateTime? OrderStartDate, DateTime? OrderEndDate, string OrderStatus, string OrderType) {

      

      var path = "/orders";
      path = path.Replace("{format}", "json");
      

      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, String>();
      var fileParams = new Dictionary<String, String>();
      String postBody = null;

       if (Page != null) queryParams.Add("page", apiClient.ParameterToString(Page)); // query parameter
       if (Size != null) queryParams.Add("size", apiClient.ParameterToString(Size)); // query parameter
       if (Expand != null) queryParams.Add("expand", apiClient.ParameterToString(Expand)); // query parameter
       if (OrderStartDate != null) queryParams.Add("orderStartDate", apiClient.ParameterToString(OrderStartDate)); // query parameter
       if (OrderEndDate != null) queryParams.Add("orderEndDate", apiClient.ParameterToString(OrderEndDate)); // query parameter
       if (OrderStatus != null) queryParams.Add("orderStatus", apiClient.ParameterToString(OrderStatus)); // query parameter
       if (OrderType != null) queryParams.Add("orderType", apiClient.ParameterToString(OrderType)); // query parameter
      
      
      
      

      // authentication setting, if any
      String[] authSettings = new String[] { "client_id", "access_token" };

      // make the HTTP request
      IRestResponse response = (IRestResponse) await apiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
      if (((int)response.StatusCode) >= 400) {
        throw new ApiException ((int)response.StatusCode, "Error calling ListOrders: " + response.Content, response.Content);
      }
      return (OrderListResource) apiClient.Deserialize(response.Content, typeof(OrderListResource));
    }
    
    /// <summary>
    ///  
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>OrderResource</returns>
    public OrderResource SaveOrder (OrderResource Body) {

      

      var path = "/orders";
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
        throw new ApiException ((int)response.StatusCode, "Error calling SaveOrder: " + response.Content, response.Content);
      }
      return (OrderResource) apiClient.Deserialize(response.Content, typeof(OrderResource));
    }
	
	 /// <summary>
    ///  
    /// </summary>
    /// <param name="Body"></param>
    /// <returns>OrderResource</returns>
    public async Task<OrderResource> SaveOrderAsync (OrderResource Body) {

      

      var path = "/orders";
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
        throw new ApiException ((int)response.StatusCode, "Error calling SaveOrder: " + response.Content, response.Content);
      }
      return (OrderResource) apiClient.Deserialize(response.Content, typeof(OrderResource));
    }
    
    /// <summary>
    /// Get a order based on order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>OrderResource</returns>
    public OrderResource GetOrder (string OrderNumber, string Expand) {

      
      // verify the required parameter 'OrderNumber' is set
      if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling GetOrder");
      

      var path = "/orders/{orderNumber}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetOrder: " + response.Content, response.Content);
      }
      return (OrderResource) apiClient.Deserialize(response.Content, typeof(OrderResource));
    }
	
	 /// <summary>
    /// Get a order based on order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>OrderResource</returns>
    public async Task<OrderResource> GetOrderAsync (string OrderNumber, string Expand) {

      
          // verify the required parameter 'OrderNumber' is set
          if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling GetOrder");
      

      var path = "/orders/{orderNumber}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetOrder: " + response.Content, response.Content);
      }
      return (OrderResource) apiClient.Deserialize(response.Content, typeof(OrderResource));
    }
    
    /// <summary>
    /// Get a list of shippings by order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>ShippingListResource</returns>
    public ShippingListResource ListOrderShippings (string OrderNumber, string Expand) {

      
      // verify the required parameter 'OrderNumber' is set
      if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling ListOrderShippings");
      

      var path = "/orders/{orderNumber}/shippings";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListOrderShippings: " + response.Content, response.Content);
      }
      return (ShippingListResource) apiClient.Deserialize(response.Content, typeof(ShippingListResource));
    }
	
	 /// <summary>
    /// Get a list of shippings by order number. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="Expand"></param>
    /// <returns>ShippingListResource</returns>
    public async Task<ShippingListResource> ListOrderShippingsAsync (string OrderNumber, string Expand) {

      
          // verify the required parameter 'OrderNumber' is set
          if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling ListOrderShippings");
      

      var path = "/orders/{orderNumber}/shippings";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListOrderShippings: " + response.Content, response.Content);
      }
      return (ShippingListResource) apiClient.Deserialize(response.Content, typeof(ShippingListResource));
    }
    
    /// <summary>
    /// Get a shipping based on order number and shipping code. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Expand"></param>
    /// <returns>ShippingResource</returns>
    public ShippingResource GetOrderShipping (string OrderNumber, long? ShippingCode, string Expand) {

      
      // verify the required parameter 'OrderNumber' is set
      if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling GetOrderShipping");
      
      // verify the required parameter 'ShippingCode' is set
      if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling GetOrderShipping");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetOrderShipping: " + response.Content, response.Content);
      }
      return (ShippingResource) apiClient.Deserialize(response.Content, typeof(ShippingResource));
    }
	
	 /// <summary>
    /// Get a shipping based on order number and shipping code. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Expand"></param>
    /// <returns>ShippingResource</returns>
    public async Task<ShippingResource> GetOrderShippingAsync (string OrderNumber, long? ShippingCode, string Expand) {

      
          // verify the required parameter 'OrderNumber' is set
          if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling GetOrderShipping");
      
          // verify the required parameter 'ShippingCode' is set
          if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling GetOrderShipping");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling GetOrderShipping: " + response.Content, response.Content);
      }
      return (ShippingResource) apiClient.Deserialize(response.Content, typeof(ShippingResource));
    }
    
    /// <summary>
    /// Update status of item. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="IdItem"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    public StatusResource UpdateShippingItemStatus (string OrderNumber, long? ShippingCode, long? IdItem, StatusResource Body) {

      
      // verify the required parameter 'OrderNumber' is set
      if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling UpdateShippingItemStatus");
      
      // verify the required parameter 'ShippingCode' is set
      if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling UpdateShippingItemStatus");
      
      // verify the required parameter 'IdItem' is set
      if (IdItem == null) throw new ApiException(400, "Missing required parameter 'IdItem' when calling UpdateShippingItemStatus");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}/item/{idItem}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      path = path.Replace("{" + "idItem" + "}", apiClient.ParameterToString(IdItem));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingItemStatus: " + response.Content, response.Content);
      }
      return (StatusResource) apiClient.Deserialize(response.Content, typeof(StatusResource));
    }
	
	 /// <summary>
    /// Update status of item. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="IdItem"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    public async Task<StatusResource> UpdateShippingItemStatusAsync (string OrderNumber, long? ShippingCode, long? IdItem, StatusResource Body) {

      
          // verify the required parameter 'OrderNumber' is set
          if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling UpdateShippingItemStatus");
      
          // verify the required parameter 'ShippingCode' is set
          if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling UpdateShippingItemStatus");
      
          // verify the required parameter 'IdItem' is set
          if (IdItem == null) throw new ApiException(400, "Missing required parameter 'IdItem' when calling UpdateShippingItemStatus");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}/item/{idItem}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      path = path.Replace("{" + "idItem" + "}", apiClient.ParameterToString(IdItem));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingItemStatus: " + response.Content, response.Content);
      }
      return (StatusResource) apiClient.Deserialize(response.Content, typeof(StatusResource));
    }
    
    /// <summary>
    /// Update status of shipping. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    public StatusResource UpdateShippingStatus (string OrderNumber, long? ShippingCode, StatusResource Body) {

      
      // verify the required parameter 'OrderNumber' is set
      if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling UpdateShippingStatus");
      
      // verify the required parameter 'ShippingCode' is set
      if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling UpdateShippingStatus");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingStatus: " + response.Content, response.Content);
      }
      return (StatusResource) apiClient.Deserialize(response.Content, typeof(StatusResource));
    }
	
	 /// <summary>
    /// Update status of shipping. 
    /// </summary>
    /// <param name="OrderNumber"></param>/// <param name="ShippingCode"></param>/// <param name="Body"></param>
    /// <returns>StatusResource</returns>
    public async Task<StatusResource> UpdateShippingStatusAsync (string OrderNumber, long? ShippingCode, StatusResource Body) {

      
          // verify the required parameter 'OrderNumber' is set
          if (OrderNumber == null) throw new ApiException(400, "Missing required parameter 'OrderNumber' when calling UpdateShippingStatus");
      
          // verify the required parameter 'ShippingCode' is set
          if (ShippingCode == null) throw new ApiException(400, "Missing required parameter 'ShippingCode' when calling UpdateShippingStatus");
      

      var path = "/orders/{orderNumber}/shippings/{shippingCode}/status";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "orderNumber" + "}", apiClient.ParameterToString(OrderNumber));
      path = path.Replace("{" + "shippingCode" + "}", apiClient.ParameterToString(ShippingCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingStatus: " + response.Content, response.Content);
      }
      return (StatusResource) apiClient.Deserialize(response.Content, typeof(StatusResource));
    }
    
  }  
  
}
