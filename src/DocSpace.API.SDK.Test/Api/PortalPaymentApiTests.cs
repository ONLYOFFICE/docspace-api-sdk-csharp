// (c) Copyright Ascensio System SIA 2025
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing PortalPaymentApi
    /// </summary>
    public class PortalPaymentApiTests : IDisposable
    {
        private PortalPaymentApi instance;

        public PortalPaymentApiTests()
        {
            instance = new PortalPaymentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PortalPaymentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PortalPaymentApi
            //Assert.IsType<PortalPaymentApi>(instance);
        }

        /// <summary>
        /// Test CalculateWalletPayment
        /// </summary>
        [Fact]
        public void CalculateWalletPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletQuantityRequestDto? walletQuantityRequestDto = null;
            //var response = instance.CalculateWalletPayment(walletQuantityRequestDto);
            //Assert.IsType<PaymentCalculationWrapper>(response);
        }

        /// <summary>
        /// Test CreateCustomerOperationsReport
        /// </summary>
        [Fact]
        public void CreateCustomerOperationsReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomerOperationsReportRequestDto? customerOperationsReportRequestDto = null;
            //var response = instance.CreateCustomerOperationsReport(customerOperationsReportRequestDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetCheckoutSetupUrl
        /// </summary>
        [Fact]
        public void GetCheckoutSetupUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? backUrl = null;
            //var response = instance.GetCheckoutSetupUrl(backUrl);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetCustomerBalance
        /// </summary>
        [Fact]
        public void GetCustomerBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //var response = instance.GetCustomerBalance(refresh);
            //Assert.IsType<BalanceWrapper>(response);
        }

        /// <summary>
        /// Test GetCustomerInfo
        /// </summary>
        [Fact]
        public void GetCustomerInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //var response = instance.GetCustomerInfo(refresh);
            //Assert.IsType<CustomerInfoWrapper>(response);
        }

        /// <summary>
        /// Test GetCustomerOperations
        /// </summary>
        [Fact]
        public void GetCustomerOperationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //bool? credit = null;
            //bool? withdrawal = null;
            //int? offset = null;
            //int? limit = null;
            //var response = instance.GetCustomerOperations(startDate, endDate, credit, withdrawal, offset, limit);
            //Assert.IsType<ReportWrapper>(response);
        }

        /// <summary>
        /// Test GetPaymentAccount
        /// </summary>
        [Fact]
        public void GetPaymentAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? backUrl = null;
            //var response = instance.GetPaymentAccount(backUrl);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetPaymentCurrencies
        /// </summary>
        [Fact]
        public void GetPaymentCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPaymentCurrencies();
            //Assert.IsType<CurrenciesArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetPaymentQuotas
        /// </summary>
        [Fact]
        public void GetPaymentQuotasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? wallet = null;
            //var response = instance.GetPaymentQuotas(wallet);
            //Assert.IsType<QuotaArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetPaymentUrl
        /// </summary>
        [Fact]
        public void GetPaymentUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaymentUrlRequestsDto? paymentUrlRequestsDto = null;
            //var response = instance.GetPaymentUrl(paymentUrlRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalPrices
        /// </summary>
        [Fact]
        public void GetPortalPricesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalPrices();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetQuotaPaymentInformation
        /// </summary>
        [Fact]
        public void GetQuotaPaymentInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? refresh = null;
            //var response = instance.GetQuotaPaymentInformation(refresh);
            //Assert.IsType<QuotaWrapper>(response);
        }

        /// <summary>
        /// Test GetTenantWalletSettings
        /// </summary>
        [Fact]
        public void GetTenantWalletSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTenantWalletSettings();
            //Assert.IsType<TenantWalletSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SendPaymentRequest
        /// </summary>
        [Fact]
        public void SendPaymentRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SalesRequestsDto? salesRequestsDto = null;
            //instance.SendPaymentRequest(salesRequestsDto);
        }

        /// <summary>
        /// Test SetTenantWalletSettings
        /// </summary>
        [Fact]
        public void SetTenantWalletSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantWalletSettingsWrapper? tenantWalletSettingsWrapper = null;
            //var response = instance.SetTenantWalletSettings(tenantWalletSettingsWrapper);
            //Assert.IsType<TenantWalletSettingsWrapper>(response);
        }

        /// <summary>
        /// Test TopUpDeposit
        /// </summary>
        [Fact]
        public void TopUpDepositTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TopUpDepositRequestDto? topUpDepositRequestDto = null;
            //var response = instance.TopUpDeposit(topUpDepositRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UpdatePayment
        /// </summary>
        [Fact]
        public void UpdatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //QuantityRequestDto? quantityRequestDto = null;
            //var response = instance.UpdatePayment(quantityRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test UpdateWalletPayment
        /// </summary>
        [Fact]
        public void UpdateWalletPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletQuantityRequestDto? walletQuantityRequestDto = null;
            //var response = instance.UpdateWalletPayment(walletQuantityRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }
    }
}
