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
  public class CustomerResource {
    
    
    [DataMember(Name="document", EmitDefaultValue=false)]
    public string Document { get; set; }

    
    
    [DataMember(Name="stateInscription", EmitDefaultValue=false)]
    public string StateInscription { get; set; }

    
    
    [DataMember(Name="customerName", EmitDefaultValue=false)]
    public string CustomerName { get; set; }

    
    
    [DataMember(Name="recipientName", EmitDefaultValue=false)]
    public string RecipientName { get; set; }

    
    
    [DataMember(Name="tradeName", EmitDefaultValue=false)]
    public string TradeName { get; set; }

    
    
    [DataMember(Name="cellPhone", EmitDefaultValue=false)]
    public string CellPhone { get; set; }

    
    
    [DataMember(Name="landline", EmitDefaultValue=false)]
    public string Landline { get; set; }

    
    
    [DataMember(Name="receiverName", EmitDefaultValue=false)]
    public string ReceiverName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomerResource {\n");
      
      sb.Append("  Document: ").Append(Document).Append("\n");
      
      sb.Append("  StateInscription: ").Append(StateInscription).Append("\n");
      
      sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
      
      sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
      
      sb.Append("  TradeName: ").Append(TradeName).Append("\n");
      
      sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
      
      sb.Append("  Landline: ").Append(Landline).Append("\n");
      
      sb.Append("  ReceiverName: ").Append(ReceiverName).Append("\n");
      
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
