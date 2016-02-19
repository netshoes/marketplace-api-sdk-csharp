using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Netshoes.Api.V1.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IssuerResource {
    
    
    [DataMember(Name="supplierCnpj", EmitDefaultValue=false)]
    public string SupplierCnpj { get; set; }

    
    
    [DataMember(Name="sellerCode", EmitDefaultValue=false)]
    public long? SellerCode { get; set; }

    
    
    [DataMember(Name="sellerName", EmitDefaultValue=false)]
    public string SellerName { get; set; }

    
    
    [DataMember(Name="supplierName", EmitDefaultValue=false)]
    public string SupplierName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssuerResource {\n");
      
      sb.Append("  SupplierCnpj: ").Append(SupplierCnpj).Append("\n");
      
      sb.Append("  SellerCode: ").Append(SellerCode).Append("\n");
      
      sb.Append("  SellerName: ").Append(SellerName).Append("\n");
      
      sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
  
  
}
