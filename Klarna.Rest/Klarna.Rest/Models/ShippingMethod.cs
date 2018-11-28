#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="ShippingMethod.cs" company="Klarna AB">
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
    /// <summary>
    /// The shipping method that the order will be shipped with
    /// </summary>
    public enum ShippingMethod
    {
        /// <summary>
        /// Pick up from a store
        /// </summary>
        PickUpStore,

        /// <summary>
        /// Delivery at home
        /// </summary>
        Home,

        /// <summary>
        /// Box Registered
        /// </summary>
        BoxReg,

        /// <summary>
        /// Box Unregistered
        /// </summary>
        BoxUnReg,

        /// <summary>
        /// A pickup point
        /// </summary>
        PickUpPoint,

        /// <summary>
        ///  Own delivery method.
        /// </summary>
        Own,

        /// <summary>
        /// Postal delivery
        /// </summary>
        Postal
    }
}