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
  public class OrderResource {
    
    
    [DataMember(Name="agreedDate", EmitDefaultValue=false)]
    public DateTime? AgreedDate { get; set; }

    
    
    [DataMember(Name="paymentData", EmitDefaultValue=false)]
    public DateTime? PaymentData { get; set; }

    
    
    [DataMember(Name="orderDate", EmitDefaultValue=false)]
    public DateTime? OrderDate { get; set; }

    
    
    [DataMember(Name="number", EmitDefaultValue=false)]
    public string Number { get; set; }

    
    
    [DataMember(Name="originNumber", EmitDefaultValue=false)]
    public string OriginNumber { get; set; }

    
    
    [DataMember(Name="totalQuantity", EmitDefaultValue=false)]
    public int? TotalQuantity { get; set; }

    
    
    [DataMember(Name="originSite", EmitDefaultValue=false)]
    public string OriginSite { get; set; }

    
    
    [DataMember(Name="businessUnit", EmitDefaultValue=false)]
    public string BusinessUnit { get; set; }

    
    
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    
    [DataMember(Name="orderType", EmitDefaultValue=false)]
    public string OrderType { get; set; }

    
    
    [DataMember(Name="devolutionRequested", EmitDefaultValue=false)]
    public bool? DevolutionRequested { get; set; }

    
    
    [DataMember(Name="exchangeRequested", EmitDefaultValue=false)]
    public bool? ExchangeRequested { get; set; }

    
    
    [DataMember(Name="totalGross", EmitDefaultValue=false)]
    public double? TotalGross { get; set; }

    
    
    [DataMember(Name="totalCommission", EmitDefaultValue=false)]
    public double? TotalCommission { get; set; }

    
    
    [DataMember(Name="totalDiscount", EmitDefaultValue=false)]
    public double? TotalDiscount { get; set; }

    
    
    [DataMember(Name="totalFreight", EmitDefaultValue=false)]
    public double? TotalFreight { get; set; }

    
    
    [DataMember(Name="totalNet", EmitDefaultValue=false)]
    public double? TotalNet { get; set; }

    
    
    [DataMember(Name="shippings", EmitDefaultValue=false)]
    public List<ShippingResource> Shippings { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderResource {\n");
      
      sb.Append("  AgreedDate: ").Append(AgreedDate).Append("\n");
      
      sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
      
      sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
      
      sb.Append("  Number: ").Append(Number).Append("\n");
      
      sb.Append("  OriginNumber: ").Append(OriginNumber).Append("\n");
      
      sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
      
      sb.Append("  OriginSite: ").Append(OriginSite).Append("\n");
      
      sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  OrderType: ").Append(OrderType).Append("\n");
      
      sb.Append("  DevolutionRequested: ").Append(DevolutionRequested).Append("\n");
      
      sb.Append("  ExchangeRequested: ").Append(ExchangeRequested).Append("\n");
      
      sb.Append("  TotalGross: ").Append(TotalGross).Append("\n");
      
      sb.Append("  TotalCommission: ").Append(TotalCommission).Append("\n");
      
      sb.Append("  TotalDiscount: ").Append(TotalDiscount).Append("\n");
      
      sb.Append("  TotalFreight: ").Append(TotalFreight).Append("\n");
      
      sb.Append("  TotalNet: ").Append(TotalNet).Append("\n");
      
      sb.Append("  Shippings: ").Append(Shippings).Append("\n");
      
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
