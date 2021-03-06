﻿namespace MVCClient
{
    public class AppSettings
    {
        public string ApiUrl { get; set; }
        public string IdentityUrl { get; set; }
        public string ExternalCatalogBaseUrl { get; set; }
        public ClientCredentials ClientCredentials { get; set; }
    }

    public class ClientCredentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Scope { get; set; }
    }
}
