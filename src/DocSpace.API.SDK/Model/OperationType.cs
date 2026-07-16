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
    /// [0 - Unknown, 1 - ServicePayment, 2 - PackagePayment, 3 - AiServicePayment, 4 - Deposit, 5 - ReceiveProviderInvoice, 6 - ProcessProviderInvoice, 7 - WriteOffServiceProfit, 8 - Profit, 9 - PartnerAccrual, 10 - ProviderPayment, 11 - PartnerPayment, 12 - Refund, 13 - BankDeposit, 14 - BankWithdrawal, 15 - GoodwillCredit, 16 - WriteOffProfit, 17 - WriteOffDifferenceCurrency, 18 - AiDebit, 19 - AiCredit]
    /// </summary>
    /// <value>[0 - Unknown, 1 - ServicePayment, 2 - PackagePayment, 3 - AiServicePayment, 4 - Deposit, 5 - ReceiveProviderInvoice, 6 - ProcessProviderInvoice, 7 - WriteOffServiceProfit, 8 - Profit, 9 - PartnerAccrual, 10 - ProviderPayment, 11 - PartnerPayment, 12 - Refund, 13 - BankDeposit, 14 - BankWithdrawal, 15 - GoodwillCredit, 16 - WriteOffProfit, 17 - WriteOffDifferenceCurrency, 18 - AiDebit, 19 - AiCredit]</value>
    public enum OperationType
    {
        /// <summary>
        /// Enum Unknown for value: 0
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Enum ServicePayment for value: 1
        /// </summary>
        ServicePayment = 1,

        /// <summary>
        /// Enum PackagePayment for value: 2
        /// </summary>
        PackagePayment = 2,

        /// <summary>
        /// Enum AiServicePayment for value: 3
        /// </summary>
        AiServicePayment = 3,

        /// <summary>
        /// Enum Deposit for value: 4
        /// </summary>
        Deposit = 4,

        /// <summary>
        /// Enum ReceiveProviderInvoice for value: 5
        /// </summary>
        ReceiveProviderInvoice = 5,

        /// <summary>
        /// Enum ProcessProviderInvoice for value: 6
        /// </summary>
        ProcessProviderInvoice = 6,

        /// <summary>
        /// Enum WriteOffServiceProfit for value: 7
        /// </summary>
        WriteOffServiceProfit = 7,

        /// <summary>
        /// Enum Profit for value: 8
        /// </summary>
        Profit = 8,

        /// <summary>
        /// Enum PartnerAccrual for value: 9
        /// </summary>
        PartnerAccrual = 9,

        /// <summary>
        /// Enum ProviderPayment for value: 10
        /// </summary>
        ProviderPayment = 10,

        /// <summary>
        /// Enum PartnerPayment for value: 11
        /// </summary>
        PartnerPayment = 11,

        /// <summary>
        /// Enum Refund for value: 12
        /// </summary>
        Refund = 12,

        /// <summary>
        /// Enum BankDeposit for value: 13
        /// </summary>
        BankDeposit = 13,

        /// <summary>
        /// Enum BankWithdrawal for value: 14
        /// </summary>
        BankWithdrawal = 14,

        /// <summary>
        /// Enum GoodwillCredit for value: 15
        /// </summary>
        GoodwillCredit = 15,

        /// <summary>
        /// Enum WriteOffProfit for value: 16
        /// </summary>
        WriteOffProfit = 16,

        /// <summary>
        /// Enum WriteOffDifferenceCurrency for value: 17
        /// </summary>
        WriteOffDifferenceCurrency = 17,

        /// <summary>
        /// Enum AiDebit for value: 18
        /// </summary>
        AiDebit = 18,

        /// <summary>
        /// Enum AiCredit for value: 19
        /// </summary>
        AiCredit = 19
    }

}
