namespace RealArtists.ChargeBee.Models {
  using System;
  using System.ComponentModel;
  using RealArtists.ChargeBee.Internal;
  using RealArtists.ChargeBee.Models.Enums;

  public class SubscriptionEstimate : Resource {

    public string Id {
      get { return GetValue<string>("id", false); }
    }
    public string CurrencyCode {
      get { return GetValue<string>("currency_code", true); }
    }
    public StatusEnum? Status {
      get { return GetEnum<StatusEnum>("status", false); }
    }
    public DateTime? NextBillingAt {
      get { return GetDateTime("next_billing_at", false); }
    }
    public SubscriptionEstimateShippingAddress ShippingAddress {
      get { return GetSubResource<SubscriptionEstimateShippingAddress>("shipping_address"); }
    }

    public enum StatusEnum {

      Unknown,
      [Description("future")]
      Future,
      [Description("in_trial")]
      InTrial,
      [Description("active")]
      Active,
      [Description("non_renewing")]
      NonRenewing,
      [Description("cancelled")]
      Cancelled,
    }

    public class SubscriptionEstimateShippingAddress : Resource {

      public string FirstName() {
        return GetValue<string>("first_name", false);
      }

      public string LastName() {
        return GetValue<string>("last_name", false);
      }

      public string Email() {
        return GetValue<string>("email", false);
      }

      public string Company() {
        return GetValue<string>("company", false);
      }

      public string Phone() {
        return GetValue<string>("phone", false);
      }

      public string Line1() {
        return GetValue<string>("line1", false);
      }

      public string Line2() {
        return GetValue<string>("line2", false);
      }

      public string Line3() {
        return GetValue<string>("line3", false);
      }

      public string City() {
        return GetValue<string>("city", false);
      }

      public string StateCode() {
        return GetValue<string>("state_code", false);
      }

      public string State() {
        return GetValue<string>("state", false);
      }

      public string Country() {
        return GetValue<string>("country", false);
      }

      public string Zip() {
        return GetValue<string>("zip", false);
      }

      public ValidationStatusEnum? ValidationStatus() {
        return GetEnum<ValidationStatusEnum>("validation_status", false);
      }

    }

  }
}