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
  public class DevolutionItemResource {
    
    
    [DataMember(Name="itemId", EmitDefaultValue=false)]
    public long? ItemId { get; set; }

    
    
    [DataMember(Name="manufacturerCode", EmitDefaultValue=false)]
    public string ManufacturerCode { get; set; }

    
    
    [DataMember(Name="ean", EmitDefaultValue=false)]
    public string Ean { get; set; }

    
    
    [DataMember(Name="brand", EmitDefaultValue=false)]
    public string Brand { get; set; }

    
    
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    public int? Quantity { get; set; }

    
    
    [DataMember(Name="sku", EmitDefaultValue=false)]
    public string Sku { get; set; }

    
    
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    
    [DataMember(Name="departmentName", EmitDefaultValue=false)]
    public string DepartmentName { get; set; }

    
    
    [DataMember(Name="departmentCode", EmitDefaultValue=false)]
    public int? DepartmentCode { get; set; }

    
    
    [DataMember(Name="exchangeProcessCode", EmitDefaultValue=false)]
    public int? ExchangeProcessCode { get; set; }

    
    
    [DataMember(Name="checkinData", EmitDefaultValue=false)]
    public DateTime? CheckinData { get; set; }

    
    
    [DataMember(Name="devolutionData", EmitDefaultValue=false)]
    public DateTime? DevolutionData { get; set; }

    
    
    [DataMember(Name="totalGross", EmitDefaultValue=false)]
    public double? TotalGross { get; set; }

    
    
    [DataMember(Name="color", EmitDefaultValue=false)]
    public string Color { get; set; }

    
    
    [DataMember(Name="flavor", EmitDefaultValue=false)]
    public string Flavor { get; set; }

    
    
    [DataMember(Name="size", EmitDefaultValue=false)]
    public string Size { get; set; }

    
    
    [DataMember(Name="devolutionExchangeStatus", EmitDefaultValue=false)]
    public string DevolutionExchangeStatus { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DevolutionItemResource {\n");
      
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      
      sb.Append("  ManufacturerCode: ").Append(ManufacturerCode).Append("\n");
      
      sb.Append("  Ean: ").Append(Ean).Append("\n");
      
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
      
      sb.Append("  DepartmentCode: ").Append(DepartmentCode).Append("\n");
      
      sb.Append("  ExchangeProcessCode: ").Append(ExchangeProcessCode).Append("\n");
      
      sb.Append("  CheckinData: ").Append(CheckinData).Append("\n");
      
      sb.Append("  DevolutionData: ").Append(DevolutionData).Append("\n");
      
      sb.Append("  TotalGross: ").Append(TotalGross).Append("\n");
      
      sb.Append("  Color: ").Append(Color).Append("\n");
      
      sb.Append("  Flavor: ").Append(Flavor).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
      sb.Append("  DevolutionExchangeStatus: ").Append(DevolutionExchangeStatus).Append("\n");
      
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
