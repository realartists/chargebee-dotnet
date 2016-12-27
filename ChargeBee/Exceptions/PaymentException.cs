﻿namespace ChargeBee.Exceptions {
  using System.Collections.Generic;
  using System.Net;
  using ChargeBee.Api;

  public class PaymentException : ApiException {
    public PaymentException(HttpStatusCode httpStatusCode, Dictionary<string, string> errorJson)
      : base(httpStatusCode, errorJson) {
    }
  }
}
