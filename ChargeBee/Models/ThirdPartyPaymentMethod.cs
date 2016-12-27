namespace ChargeBee.Models {
  using ChargeBee.Internal;
  using ChargeBee.Models.Enums;

  public class ThirdPartyPaymentMethod : Resource {
    public TypeEnum ThirdPartyPaymentMethodType {
      get { return GetEnum<TypeEnum>("type", true); }
    }
    public GatewayEnum Gateway {
      get { return GetEnum<GatewayEnum>("gateway", true); }
    }
    public string ReferenceId {
      get { return GetValue<string>("reference_id", false); }
    }
  }
}
