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
  public class DepartmentResource {
    
    
    [DataMember(Name="code", EmitDefaultValue=false)]
    public int? Code { get; set; }

    
    
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DepartmentResource {\n");
      
      sb.Append("  Code: ").Append(Code).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
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
