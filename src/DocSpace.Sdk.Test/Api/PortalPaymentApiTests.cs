// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
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
        /// Test GetAccountingCurrencies
        /// </summary>
        [Fact]
        public void GetAccountingCurrenciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAccountingCurrencies();
            //Assert.IsType<CurrencyArrayWrapper>(response);
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
        /// Test OpenCustomerSession
        /// </summary>
        [Fact]
        public void OpenCustomerSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OpenCustomerSessionRequestDto? openCustomerSessionRequestDto = null;
            //var response = instance.OpenCustomerSession(openCustomerSessionRequestDto);
            //Assert.IsType<SessionWrapper>(response);
        }

        /// <summary>
        /// Test PerformCustomerOperation
        /// </summary>
        [Fact]
        public void PerformCustomerOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PerformCustomerOperationRequestDto? performCustomerOperationRequestDto = null;
            //var response = instance.PerformCustomerOperation(performCustomerOperationRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
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
