// (c) Copyright Ascensio System SIA 2026
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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// [0 - Any, 1 - Unknown, 2 - ServicePayment, 4 - PackagePayment, 8 - ServiceUsage, 16 - Deposit, 32 - ReceiveProviderInvoice, 64 - ProcessProviderInvoice, 128 - WriteOffServiceProfit, 256 - Profit, 512 - PartnerAccrual, 1024 - ProviderPayment, 2048 - PartnerPayment, 4096 - Refund, 8192 - BankDeposit, 16384 - BankWithdrawal, 32768 - GoodwillCredit, 65536 - WriteOffProfit, 131072 - WriteOffDifferenceCurrency]
    /// </summary>
    /// <value>[0 - Any, 1 - Unknown, 2 - ServicePayment, 4 - PackagePayment, 8 - ServiceUsage, 16 - Deposit, 32 - ReceiveProviderInvoice, 64 - ProcessProviderInvoice, 128 - WriteOffServiceProfit, 256 - Profit, 512 - PartnerAccrual, 1024 - ProviderPayment, 2048 - PartnerPayment, 4096 - Refund, 8192 - BankDeposit, 16384 - BankWithdrawal, 32768 - GoodwillCredit, 65536 - WriteOffProfit, 131072 - WriteOffDifferenceCurrency]</value>
    public enum OperationType
    {
        /// <summary>
        /// Enum Any for value: 0
        /// </summary>
        Any = 0,

        /// <summary>
        /// Enum Unknown for value: 1
        /// </summary>
        Unknown = 1,

        /// <summary>
        /// Enum ServicePayment for value: 2
        /// </summary>
        ServicePayment = 2,

        /// <summary>
        /// Enum PackagePayment for value: 4
        /// </summary>
        PackagePayment = 4,

        /// <summary>
        /// Enum ServiceUsage for value: 8
        /// </summary>
        ServiceUsage = 8,

        /// <summary>
        /// Enum Deposit for value: 16
        /// </summary>
        Deposit = 16,

        /// <summary>
        /// Enum ReceiveProviderInvoice for value: 32
        /// </summary>
        ReceiveProviderInvoice = 32,

        /// <summary>
        /// Enum ProcessProviderInvoice for value: 64
        /// </summary>
        ProcessProviderInvoice = 64,

        /// <summary>
        /// Enum WriteOffServiceProfit for value: 128
        /// </summary>
        WriteOffServiceProfit = 128,

        /// <summary>
        /// Enum Profit for value: 256
        /// </summary>
        Profit = 256,

        /// <summary>
        /// Enum PartnerAccrual for value: 512
        /// </summary>
        PartnerAccrual = 512,

        /// <summary>
        /// Enum ProviderPayment for value: 1024
        /// </summary>
        ProviderPayment = 1024,

        /// <summary>
        /// Enum PartnerPayment for value: 2048
        /// </summary>
        PartnerPayment = 2048,

        /// <summary>
        /// Enum Refund for value: 4096
        /// </summary>
        Refund = 4096,

        /// <summary>
        /// Enum BankDeposit for value: 8192
        /// </summary>
        BankDeposit = 8192,

        /// <summary>
        /// Enum BankWithdrawal for value: 16384
        /// </summary>
        BankWithdrawal = 16384,

        /// <summary>
        /// Enum GoodwillCredit for value: 32768
        /// </summary>
        GoodwillCredit = 32768,

        /// <summary>
        /// Enum WriteOffProfit for value: 65536
        /// </summary>
        WriteOffProfit = 65536,

        /// <summary>
        /// Enum WriteOffDifferenceCurrency for value: 131072
        /// </summary>
        WriteOffDifferenceCurrency = 131072
    }

}
