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
  public class CustomerAddressResource {
    
    
    [DataMember(Name="neighborhood", EmitDefaultValue=false)]
    public string Neighborhood { get; set; }

    
    
    [DataMember(Name="postalCode", EmitDefaultValue=false)]
    public string PostalCode { get; set; }

    
    
    [DataMember(Name="city", EmitDefaultValue=false)]
    public string City { get; set; }

    
    
    [DataMember(Name="complement", EmitDefaultValue=false)]
    public string Complement { get; set; }

    
    
    [DataMember(Name="state", EmitDefaultValue=false)]
    public string State { get; set; }

    
    
    [DataMember(Name="street", EmitDefaultValue=false)]
    public string Street { get; set; }

    
    
    [DataMember(Name="number", EmitDefaultValue=false)]
    public string Number { get; set; }

    
    
    [DataMember(Name="reference", EmitDefaultValue=false)]
    public string Reference { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerAddressResource {\n");
      
      sb.Append("  Neighborhood: ").Append(Neighborhood).Append("\n");
      
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      
      sb.Append("  City: ").Append(City).Append("\n");
      
      sb.Append("  Complement: ").Append(Complement).Append("\n");
      
      sb.Append("  State: ").Append(State).Append("\n");
      
      sb.Append("  Street: ").Append(Street).Append("\n");
      
      sb.Append("  Number: ").Append(Number).Append("\n");
      
      sb.Append("  Reference: ").Append(Reference).Append("\n");
      
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
