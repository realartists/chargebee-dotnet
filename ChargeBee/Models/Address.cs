namespace ChargeBee.Models {
  using System.Net.Http;
  using ChargeBee.Api;
  using ChargeBee.Internal;
  using ChargeBee.Models.Enums;

  public class Address : Resource {
    public static RetrieveRequest Retrieve() {
      string url = ApiUtil.BuildUrl("addresses");
      return new RetrieveRequest(url, HttpMethod.Get);
    }
    public static UpdateRequest Update() {
      string url = ApiUtil.BuildUrl("addresses");
      return new UpdateRequest(url, HttpMethod.Post);
    }

    public string Label {
      get { return GetValue<string>("label", true); }
    }
    public string FirstName {
      get { return GetValue<string>("first_name", false); }
    }
    public string LastName {
      get { return GetValue<string>("last_name", false); }
    }
    public string Email {
      get { return GetValue<string>("email", false); }
    }
    public string Company {
      get { return GetValue<string>("company", false); }
    }
    public string Phone {
      get { return GetValue<string>("phone", false); }
    }
    public string Addr {
      get { return GetValue<string>("addr", false); }
    }
    public string ExtendedAddr {
      get { return GetValue<string>("extended_addr", false); }
    }
    public string ExtendedAddr2 {
      get { return GetValue<string>("extended_addr2", false); }
    }
    public string City {
      get { return GetValue<string>("city", false); }
    }
    public string StateCode {
      get { return GetValue<string>("state_code", false); }
    }
    public string State {
      get { return GetValue<string>("state", false); }
    }
    public string Country {
      get { return GetValue<string>("country", false); }
    }
    public string Zip {
      get { return GetValue<string>("zip", false); }
    }
    public ValidationStatusEnum? ValidationStatus {
      get { return GetEnum<ValidationStatusEnum>("validation_status", false); }
    }
    public string SubscriptionId {
      get { return GetValue<string>("subscription_id", true); }
    }

    public class RetrieveRequest : EntityRequest<RetrieveRequest> {
      public RetrieveRequest(string url, HttpMethod method)
              : base(url, method) {
      }

      public RetrieveRequest SubscriptionId(string subscriptionId) {
        _params.Add("subscription_id", subscriptionId);
        return this;
      }
      public RetrieveRequest Label(string label) {
        _params.Add("label", label);
        return this;
      }
    }

    public class UpdateRequest : EntityRequest<UpdateRequest> {
      public UpdateRequest(string url, HttpMethod method)
              : base(url, method) {
      }

      public UpdateRequest SubscriptionId(string subscriptionId) {
        _params.Add("subscription_id", subscriptionId);
        return this;
      }
      public UpdateRequest Label(string label) {
        _params.Add("label", label);
        return this;
      }
      public UpdateRequest FirstName(string firstName) {
        _params.AddOpt("first_name", firstName);
        return this;
      }
      public UpdateRequest LastName(string lastName) {
        _params.AddOpt("last_name", lastName);
        return this;
      }
      public UpdateRequest Email(string email) {
        _params.AddOpt("email", email);
        return this;
      }
      public UpdateRequest Company(string company) {
        _params.AddOpt("company", company);
        return this;
      }
      public UpdateRequest Phone(string phone) {
        _params.AddOpt("phone", phone);
        return this;
      }
      public UpdateRequest Addr(string addr) {
        _params.AddOpt("addr", addr);
        return this;
      }
      public UpdateRequest ExtendedAddr(string extendedAddr) {
        _params.AddOpt("extended_addr", extendedAddr);
        return this;
      }
      public UpdateRequest ExtendedAddr2(string extendedAddr2) {
        _params.AddOpt("extended_addr2", extendedAddr2);
        return this;
      }
      public UpdateRequest City(string city) {
        _params.AddOpt("city", city);
        return this;
      }
      public UpdateRequest StateCode(string stateCode) {
        _params.AddOpt("state_code", stateCode);
        return this;
      }
      public UpdateRequest State(string state) {
        _params.AddOpt("state", state);
        return this;
      }
      public UpdateRequest Zip(string zip) {
        _params.AddOpt("zip", zip);
        return this;
      }
      public UpdateRequest Country(string country) {
        _params.AddOpt("country", country);
        return this;
      }
      public UpdateRequest ValidationStatus(ValidationStatusEnum validationStatus) {
        _params.AddOpt("validation_status", validationStatus);
        return this;
      }
    }
  }
}
