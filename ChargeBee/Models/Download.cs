namespace ChargeBee.Models {
  using System;
  using ChargeBee.Internal;

  public class Download : Resource {
    public string DownloadUrl {
      get { return GetValue<string>("download_url", true); }
    }
    public DateTime ValidTill {
      get { return (DateTime)GetDateTime("valid_till", true); }
    }
  }
}
