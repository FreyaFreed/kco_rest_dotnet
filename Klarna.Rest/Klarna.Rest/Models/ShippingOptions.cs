#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="ShippingOptions.cs" company="Klarna AB">
//     Copyright 2014 Klarna AB
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------
#endregion
namespace Klarna.Rest.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The shipping options for the order
    /// </summary>
    public class ShippingOptions : Model
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the promotion name. To be used if this shipping option is promotional
        /// </summary>
        [JsonProperty("promo")]
        public string Promo { get; set; }

        /// <summary>
        /// Gets or sets the price including tax
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the tax amount
        /// </summary>
        [JsonProperty("tax_amount")]
        public int TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets the tax rate. Non-negative. In percent, two implicit decimals. I.e 2500 = 25%.
        /// </summary>
        [JsonProperty("tax_rate")]
        public int TaxRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this option will be preselected when checkout loads. Default: false
        /// </summary>
        [JsonProperty("preselected")]
        public bool Preselected { get; set; }

        /// <summary>
        /// Gets or sets the Shipping Method
        /// </summary>
        [JsonProperty("shipping_method"), JsonConverter(typeof(StringEnumConverter))]
        public ShippingMethod ShippingMethod { get; set; }
    }
}