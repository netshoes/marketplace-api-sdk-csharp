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
  public class SkuResource {
    
    
    [DataMember(Name="sku", EmitDefaultValue=false)]
    public string Sku { get; set; }

    
    
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    
    [DataMember(Name="description", EmitDefaultValue=false)]
    public string Description { get; set; }

    
    
    [DataMember(Name="color", EmitDefaultValue=false)]
    public string Color { get; set; }

    
    
    [DataMember(Name="flavor", EmitDefaultValue=false)]
    public string Flavor { get; set; }

    
    
    [DataMember(Name="size", EmitDefaultValue=false)]
    public string Size { get; set; }

    
    
    [DataMember(Name="gender", EmitDefaultValue=false)]
    public string Gender { get; set; }

    
    
    [DataMember(Name="eanIsbn", EmitDefaultValue=false)]
    public string EanIsbn { get; set; }

    
    
    [DataMember(Name="images", EmitDefaultValue=false)]
    public List<ImageResource> Images { get; set; }

    
    
    [DataMember(Name="video", EmitDefaultValue=false)]
    public string Video { get; set; }

    
    
    [DataMember(Name="height", EmitDefaultValue=false)]
    public double? Height { get; set; }

    
    
    [DataMember(Name="width", EmitDefaultValue=false)]
    public double? Width { get; set; }

    
    
    [DataMember(Name="depth", EmitDefaultValue=false)]
    public double? Depth { get; set; }

    
    
    [DataMember(Name="weight", EmitDefaultValue=false)]
    public double? Weight { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SkuResource {\n");
      
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Description: ").Append(Description).Append("\n");
      
      sb.Append("  Color: ").Append(Color).Append("\n");
      
      sb.Append("  Flavor: ").Append(Flavor).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      
      sb.Append("  EanIsbn: ").Append(EanIsbn).Append("\n");
      
      sb.Append("  Images: ").Append(Images).Append("\n");
      
      sb.Append("  Video: ").Append(Video).Append("\n");
      
      sb.Append("  Height: ").Append(Height).Append("\n");
      
      sb.Append("  Width: ").Append(Width).Append("\n");
      
      sb.Append("  Depth: ").Append(Depth).Append("\n");
      
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      
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
