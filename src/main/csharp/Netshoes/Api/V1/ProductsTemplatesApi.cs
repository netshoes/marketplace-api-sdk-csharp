using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Netshoes.Api.V1.Client;
using Netshoes.Api.V1.Model;

namespace Netshoes.Api.V1 {
  

  public interface IProductsTemplatesApi {
    
    /// <summary>
    /// Get the list of brands. 
    /// </summary>
    
    /// <returns>BrandListResource</returns>
    BrandListResource ListBrands ();

    /// <summary>
    /// Get the list of brands. 
    /// </summary>
    
    /// <returns>BrandListResource</returns>
    Task<BrandListResource> ListBrandsAsync ();
    
    /// <summary>
    /// Get the list of departments. 
    /// </summary>
    /// <param name="BuId"></param>
    /// <returns>DepartmentListResource</returns>
    DepartmentListResource ListDepartments (string BuId);

    /// <summary>
    /// Get the list of departments. 
    /// </summary>
    /// <param name="BuId"></param>
    /// <returns>DepartmentListResource</returns>
    Task<DepartmentListResource> ListDepartmentsAsync (string BuId);
    
    /// <summary>
    /// Get the list of colors. 
    /// </summary>
    
    /// <returns>ColorListResource</returns>
    ColorListResource ListColors ();

    /// <summary>
    /// Get the list of colors. 
    /// </summary>
    
    /// <returns>ColorListResource</returns>
    Task<ColorListResource> ListColorsAsync ();
    
    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>
    /// <returns>ProductTypeListResource</returns>
    ProductTypeListResource ListProductTypes (int? DepartmentCode);

    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>
    /// <returns>ProductTypeListResource</returns>
    Task<ProductTypeListResource> ListProductTypesAsync (int? DepartmentCode);
    
    /// <summary>
    /// Get the list of attributes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>/// <param name="ProductTypeCode"></param>
    /// <returns>TemplateListResource</returns>
    TemplateListResource ListTemplates (int? DepartmentCode, int? ProductTypeCode);

    /// <summary>
    /// Get the list of attributes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>/// <param name="ProductTypeCode"></param>
    /// <returns>TemplateListResource</returns>
    Task<TemplateListResource> ListTemplatesAsync (int? DepartmentCode, int? ProductTypeCode);
    
    /// <summary>
    /// Get the list of flavors. 
    /// </summary>
    
    /// <returns>FlavorListResource</returns>
    FlavorListResource ListFlavors ();

    /// <summary>
    /// Get the list of flavors. 
    /// </summary>
    
    /// <returns>FlavorListResource</returns>
    Task<FlavorListResource> ListFlavorsAsync ();
    
    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    
    /// <returns>SizeListResource</returns>
    SizeListResource ListSizes ();

    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    
    /// <returns>SizeListResource</returns>
    Task<SizeListResource> ListSizesAsync ();
    
  }

  /// <summary>
  /// Represents a collection of functions to interact with the API endpoints
  /// </summary>
  public class ProductsTemplatesApi : IProductsTemplatesApi {

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsTemplatesApi"/> class.
    /// </summary>
    /// <param name="apiClient"> an instance of ApiClient (optional)
    /// <returns></returns>
    public ProductsTemplatesApi(ApiClient apiClient = null) {
      if (apiClient == null) { // use the default one in Configuration
        this.apiClient = Configuration.apiClient; 
      } else {
        this.apiClient = apiClient;
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ProductsTemplatesApi"/> class.
    /// </summary>
    /// <returns></returns>
    public ProductsTemplatesApi(String basePath)
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
    /// Get the list of brands. 
    /// </summary>
    
    /// <returns>BrandListResource</returns>
    public BrandListResource ListBrands () {

      

      var path = "/brands";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListBrands: " + response.Content, response.Content);
      }
      return (BrandListResource) apiClient.Deserialize(response.Content, typeof(BrandListResource));
    }
	
	 /// <summary>
    /// Get the list of brands. 
    /// </summary>
    
    /// <returns>BrandListResource</returns>
    public async Task<BrandListResource> ListBrandsAsync () {

      

      var path = "/brands";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListBrands: " + response.Content, response.Content);
      }
      return (BrandListResource) apiClient.Deserialize(response.Content, typeof(BrandListResource));
    }
    
    /// <summary>
    /// Get the list of departments. 
    /// </summary>
    /// <param name="BuId"></param>
    /// <returns>DepartmentListResource</returns>
    public DepartmentListResource ListDepartments (string BuId) {

      
      // verify the required parameter 'BuId' is set
      if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling ListDepartments");
      

      var path = "/bus/{buId}/departments";
      path = path.Replace("{format}", "json");
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
        throw new ApiException ((int)response.StatusCode, "Error calling ListDepartments: " + response.Content, response.Content);
      }
      return (DepartmentListResource) apiClient.Deserialize(response.Content, typeof(DepartmentListResource));
    }
	
	 /// <summary>
    /// Get the list of departments. 
    /// </summary>
    /// <param name="BuId"></param>
    /// <returns>DepartmentListResource</returns>
    public async Task<DepartmentListResource> ListDepartmentsAsync (string BuId) {

      
          // verify the required parameter 'BuId' is set
          if (BuId == null) throw new ApiException(400, "Missing required parameter 'BuId' when calling ListDepartments");
      

      var path = "/bus/{buId}/departments";
      path = path.Replace("{format}", "json");
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
        throw new ApiException ((int)response.StatusCode, "Error calling ListDepartments: " + response.Content, response.Content);
      }
      return (DepartmentListResource) apiClient.Deserialize(response.Content, typeof(DepartmentListResource));
    }
    
    /// <summary>
    /// Get the list of colors. 
    /// </summary>
    
    /// <returns>ColorListResource</returns>
    public ColorListResource ListColors () {

      

      var path = "/colors";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListColors: " + response.Content, response.Content);
      }
      return (ColorListResource) apiClient.Deserialize(response.Content, typeof(ColorListResource));
    }
	
	 /// <summary>
    /// Get the list of colors. 
    /// </summary>
    
    /// <returns>ColorListResource</returns>
    public async Task<ColorListResource> ListColorsAsync () {

      

      var path = "/colors";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListColors: " + response.Content, response.Content);
      }
      return (ColorListResource) apiClient.Deserialize(response.Content, typeof(ColorListResource));
    }
    
    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>
    /// <returns>ProductTypeListResource</returns>
    public ProductTypeListResource ListProductTypes (int? DepartmentCode) {

      
      // verify the required parameter 'DepartmentCode' is set
      if (DepartmentCode == null) throw new ApiException(400, "Missing required parameter 'DepartmentCode' when calling ListProductTypes");
      

      var path = "/department/{departmentCode}/productType";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "departmentCode" + "}", apiClient.ParameterToString(DepartmentCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductTypes: " + response.Content, response.Content);
      }
      return (ProductTypeListResource) apiClient.Deserialize(response.Content, typeof(ProductTypeListResource));
    }
	
	 /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>
    /// <returns>ProductTypeListResource</returns>
    public async Task<ProductTypeListResource> ListProductTypesAsync (int? DepartmentCode) {

      
          // verify the required parameter 'DepartmentCode' is set
          if (DepartmentCode == null) throw new ApiException(400, "Missing required parameter 'DepartmentCode' when calling ListProductTypes");
      

      var path = "/department/{departmentCode}/productType";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "departmentCode" + "}", apiClient.ParameterToString(DepartmentCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListProductTypes: " + response.Content, response.Content);
      }
      return (ProductTypeListResource) apiClient.Deserialize(response.Content, typeof(ProductTypeListResource));
    }
    
    /// <summary>
    /// Get the list of attributes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>/// <param name="ProductTypeCode"></param>
    /// <returns>TemplateListResource</returns>
    public TemplateListResource ListTemplates (int? DepartmentCode, int? ProductTypeCode) {

      
      // verify the required parameter 'DepartmentCode' is set
      if (DepartmentCode == null) throw new ApiException(400, "Missing required parameter 'DepartmentCode' when calling ListTemplates");
      
      // verify the required parameter 'ProductTypeCode' is set
      if (ProductTypeCode == null) throw new ApiException(400, "Missing required parameter 'ProductTypeCode' when calling ListTemplates");
      

      var path = "/department/{departmentCode}/productType/{productTypeCode}/templates";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "departmentCode" + "}", apiClient.ParameterToString(DepartmentCode));
      path = path.Replace("{" + "productTypeCode" + "}", apiClient.ParameterToString(ProductTypeCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListTemplates: " + response.Content, response.Content);
      }
      return (TemplateListResource) apiClient.Deserialize(response.Content, typeof(TemplateListResource));
    }
	
	 /// <summary>
    /// Get the list of attributes. 
    /// </summary>
    /// <param name="DepartmentCode"></param>/// <param name="ProductTypeCode"></param>
    /// <returns>TemplateListResource</returns>
    public async Task<TemplateListResource> ListTemplatesAsync (int? DepartmentCode, int? ProductTypeCode) {

      
          // verify the required parameter 'DepartmentCode' is set
          if (DepartmentCode == null) throw new ApiException(400, "Missing required parameter 'DepartmentCode' when calling ListTemplates");
      
          // verify the required parameter 'ProductTypeCode' is set
          if (ProductTypeCode == null) throw new ApiException(400, "Missing required parameter 'ProductTypeCode' when calling ListTemplates");
      

      var path = "/department/{departmentCode}/productType/{productTypeCode}/templates";
      path = path.Replace("{format}", "json");
      path = path.Replace("{" + "departmentCode" + "}", apiClient.ParameterToString(DepartmentCode));
      path = path.Replace("{" + "productTypeCode" + "}", apiClient.ParameterToString(ProductTypeCode));
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListTemplates: " + response.Content, response.Content);
      }
      return (TemplateListResource) apiClient.Deserialize(response.Content, typeof(TemplateListResource));
    }
    
    /// <summary>
    /// Get the list of flavors. 
    /// </summary>
    
    /// <returns>FlavorListResource</returns>
    public FlavorListResource ListFlavors () {

      

      var path = "/flavors";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListFlavors: " + response.Content, response.Content);
      }
      return (FlavorListResource) apiClient.Deserialize(response.Content, typeof(FlavorListResource));
    }
	
	 /// <summary>
    /// Get the list of flavors. 
    /// </summary>
    
    /// <returns>FlavorListResource</returns>
    public async Task<FlavorListResource> ListFlavorsAsync () {

      

      var path = "/flavors";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListFlavors: " + response.Content, response.Content);
      }
      return (FlavorListResource) apiClient.Deserialize(response.Content, typeof(FlavorListResource));
    }
    
    /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    
    /// <returns>SizeListResource</returns>
    public SizeListResource ListSizes () {

      

      var path = "/sizes";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSizes: " + response.Content, response.Content);
      }
      return (SizeListResource) apiClient.Deserialize(response.Content, typeof(SizeListResource));
    }
	
	 /// <summary>
    /// Get the list of sizes. 
    /// </summary>
    
    /// <returns>SizeListResource</returns>
    public async Task<SizeListResource> ListSizesAsync () {

      

      var path = "/sizes";
      path = path.Replace("{format}", "json");
      

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
        throw new ApiException ((int)response.StatusCode, "Error calling ListSizes: " + response.Content, response.Content);
      }
      return (SizeListResource) apiClient.Deserialize(response.Content, typeof(SizeListResource));
    }
    
  }  
  
}
