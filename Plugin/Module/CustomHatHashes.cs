﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//TOR形式にするかなぁ
namespace TheSpaceRoles
{
    public class CustomHatHashes
    {
        [JsonPropertyName("reshasha")] public string ResHashA { get; set; }

        [JsonPropertyName("reshashb")] public string ResHashB { get; set; }

        [JsonPropertyName("reshashbf")] public string ResHashBf { get; set; }

        [JsonPropertyName("reshashc")] public string ResHashC { get; set; }

        [JsonPropertyName("reshashf")] public string ResHashF { get; set; }
    }
}
