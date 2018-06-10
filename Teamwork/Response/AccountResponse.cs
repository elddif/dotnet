﻿using Newtonsoft.Json;
using Teamwork;

namespace Teamwork.Response
{
  public class AccountResponse
  {

    [JsonProperty("STATUS")]
    public string Status { get; set; }

    [JsonProperty("account")]
    public Account Account { get; set; }
  }
}