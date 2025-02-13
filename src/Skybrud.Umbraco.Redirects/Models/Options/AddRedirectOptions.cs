﻿using Newtonsoft.Json;

namespace Skybrud.Umbraco.Redirects.Models.Options {

    public class AddRedirectOptions {

        #region Properties

        [JsonIgnore]
        public int RootNodeId { get; set; }

        [JsonProperty("originalurl")]
        public string OriginalUrl { get; set; }

        [JsonProperty("destination")]
        public RedirectDestination Destination { get; set; }

        [JsonProperty("permanent")]
        public bool IsPermanent { get; set; }

        [JsonProperty("forward")]
        public bool ForwardQueryString { get; set; }

        [JsonProperty("regex")]
        public bool IsRegex { get; set; }

        #endregion

    }

}