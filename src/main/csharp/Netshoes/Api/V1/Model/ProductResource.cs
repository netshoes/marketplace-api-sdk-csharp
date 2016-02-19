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
  public class ProductResource {
    
    
    [DataMember(Name="productId", EmitDefaultValue=false)]
    public string ProductId { get; set; }

    
    
    [DataMember(Name="skus", EmitDefaultValue=false)]
    public List<SkuResource> Skus { get; set; }

    
    
    [DataMember(Name="department", EmitDefaultValue=false)]
    public string Department { get; set; }

    
    
    [DataMember(Name="productType", EmitDefaultValue=false)]
    public string ProductType { get; set; }

    
    
    [DataMember(Name="brand", EmitDefaultValue=false)]
    public string Brand { get; set; }

    
    
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    public List<AttributeResource> Attributes { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductResource {\n");
      
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      
      sb.Append("  Skus: ").Append(Skus).Append("\n");
      
      sb.Append("  Department: ").Append(Department).Append("\n");
      
      sb.Append("  ProductType: ").Append(ProductType).Append("\n");
      
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      
      sb.Append("  Links: ").Append(Links).Append("\n");
      
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
