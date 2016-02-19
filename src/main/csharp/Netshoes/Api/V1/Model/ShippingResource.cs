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
  public class ShippingResource {
    
    
    [DataMember(Name="shippingCode", EmitDefaultValue=false)]
    public long? ShippingCode { get; set; }

    
    
    [DataMember(Name="shippingEstimate", EmitDefaultValue=false)]
    public DateTime? ShippingEstimate { get; set; }

    
    
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    
    [DataMember(Name="deliveryTime", EmitDefaultValue=false)]
    public int? DeliveryTime { get; set; }

    
    
    [DataMember(Name="issuer", EmitDefaultValue=false)]
    public IssuerResource Issuer { get; set; }

    
    
    [DataMember(Name="customer", EmitDefaultValue=false)]
    public CustomerResource Customer { get; set; }

    
    
    [DataMember(Name="customerAddress", EmitDefaultValue=false)]
    public CustomerAddressResource CustomerAddress { get; set; }

    
    
    [DataMember(Name="items", EmitDefaultValue=false)]
    public List<OrderItemResource> Items { get; set; }

    
    
    [DataMember(Name="devolutionItems", EmitDefaultValue=false)]
    public List<DevolutionItemResource> DevolutionItems { get; set; }

    
    
    [DataMember(Name="exchangeOrders", EmitDefaultValue=false)]
    public List<string> ExchangeOrders { get; set; }

    
    
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    public InvoiceResource Invoice { get; set; }

    
    
    [DataMember(Name="country", EmitDefaultValue=false)]
    public string Country { get; set; }

    
    
    [DataMember(Name="cancellationReason", EmitDefaultValue=false)]
    public string CancellationReason { get; set; }

    
    
    [DataMember(Name="transport", EmitDefaultValue=false)]
    public TransportResource Transport { get; set; }

    
    
    [DataMember(Name="freightAmount", EmitDefaultValue=false)]
    public double? FreightAmount { get; set; }

    
    
    [DataMember(Name="links", EmitDefaultValue=false)]
    public List<Link> Links { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingResource {\n");
      
      sb.Append("  ShippingCode: ").Append(ShippingCode).Append("\n");
      
      sb.Append("  ShippingEstimate: ").Append(ShippingEstimate).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  DeliveryTime: ").Append(DeliveryTime).Append("\n");
      
      sb.Append("  Issuer: ").Append(Issuer).Append("\n");
      
      sb.Append("  Customer: ").Append(Customer).Append("\n");
      
      sb.Append("  CustomerAddress: ").Append(CustomerAddress).Append("\n");
      
      sb.Append("  Items: ").Append(Items).Append("\n");
      
      sb.Append("  DevolutionItems: ").Append(DevolutionItems).Append("\n");
      
      sb.Append("  ExchangeOrders: ").Append(ExchangeOrders).Append("\n");
      
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      
      sb.Append("  Country: ").Append(Country).Append("\n");
      
      sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
      
      sb.Append("  Transport: ").Append(Transport).Append("\n");
      
      sb.Append("  FreightAmount: ").Append(FreightAmount).Append("\n");
      
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
