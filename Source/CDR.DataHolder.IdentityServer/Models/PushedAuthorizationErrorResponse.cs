﻿using System.Text.Json.Serialization;

namespace CDR.DataHolder.IdentityServer.Models
{
    public class PushedAuthorizationErrorResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
