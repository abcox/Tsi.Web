/* 
 * Tigerpaw API Method Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 18.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Tsi.Web.Api;
using Tsi.Web.Model;
using Tsi.Web.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Tsi.Web.Test
{
    /// <summary>
    ///  Class for testing TsiWebPayMethod
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestClass]
    public class TsiWebPayMethodTests
    {
        // TODO uncomment below to declare an instance variable for TsiWebPayMethod
        //private TsiWebPayMethod instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // TODO uncomment below to create an instance of TsiWebPayMethod
            //instance = new TsiWebPayMethod();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TsiWebPayMethod
        /// </summary>
        [TestMethod]
        public void TsiWebPayMethodInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TsiWebPayMethod
            //Assert.IsInstanceOfType<TsiWebPayMethod> (instance, "variable 'instance' is a TsiWebPayMethod");
        }


        /// <summary>
        /// Test the property 'PayMethodId'
        /// </summary>
        [TestMethod]
        public void PayMethodIdTest()
        {
            // TODO unit test for the property 'PayMethodId'
        }
        /// <summary>
        /// Test the property 'PayMethodTypeId'
        /// </summary>
        [TestMethod]
        public void PayMethodTypeIdTest()
        {
            // TODO unit test for the property 'PayMethodTypeId'
        }
        /// <summary>
        /// Test the property 'PayMethodType'
        /// </summary>
        [TestMethod]
        public void PayMethodTypeTest()
        {
            // TODO unit test for the property 'PayMethodType'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [TestMethod]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'CreditCardType'
        /// </summary>
        [TestMethod]
        public void CreditCardTypeTest()
        {
            // TODO unit test for the property 'CreditCardType'
        }
        /// <summary>
        /// Test the property 'CreditCardName'
        /// </summary>
        [TestMethod]
        public void CreditCardNameTest()
        {
            // TODO unit test for the property 'CreditCardName'
        }
        /// <summary>
        /// Test the property 'ACHAccountHolderName'
        /// </summary>
        [TestMethod]
        public void ACHAccountHolderNameTest()
        {
            // TODO unit test for the property 'ACHAccountHolderName'
        }
        /// <summary>
        /// Test the property 'ACHAccountHolderType'
        /// </summary>
        [TestMethod]
        public void ACHAccountHolderTypeTest()
        {
            // TODO unit test for the property 'ACHAccountHolderType'
        }
        /// <summary>
        /// Test the property 'ACHAccountType'
        /// </summary>
        [TestMethod]
        public void ACHAccountTypeTest()
        {
            // TODO unit test for the property 'ACHAccountType'
        }
        /// <summary>
        /// Test the property 'ACHBankName'
        /// </summary>
        [TestMethod]
        public void ACHBankNameTest()
        {
            // TODO unit test for the property 'ACHBankName'
        }
        /// <summary>
        /// Test the property 'GLAccount'
        /// </summary>
        [TestMethod]
        public void GLAccountTest()
        {
            // TODO unit test for the property 'GLAccount'
        }
        /// <summary>
        /// Test the property 'GLDepartment'
        /// </summary>
        [TestMethod]
        public void GLDepartmentTest()
        {
            // TODO unit test for the property 'GLDepartment'
        }
        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [TestMethod]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }
        /// <summary>
        /// Test the property 'MaskedCreditCardNumber'
        /// </summary>
        [TestMethod]
        public void MaskedCreditCardNumberTest()
        {
            // TODO unit test for the property 'MaskedCreditCardNumber'
        }
        /// <summary>
        /// Test the property 'Address1'
        /// </summary>
        [TestMethod]
        public void Address1Test()
        {
            // TODO unit test for the property 'Address1'
        }
        /// <summary>
        /// Test the property 'Address2'
        /// </summary>
        [TestMethod]
        public void Address2Test()
        {
            // TODO unit test for the property 'Address2'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [TestMethod]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [TestMethod]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [TestMethod]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [TestMethod]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'CreditCardExpirationMonth'
        /// </summary>
        [TestMethod]
        public void CreditCardExpirationMonthTest()
        {
            // TODO unit test for the property 'CreditCardExpirationMonth'
        }
        /// <summary>
        /// Test the property 'CreditCardExpirationYear'
        /// </summary>
        [TestMethod]
        public void CreditCardExpirationYearTest()
        {
            // TODO unit test for the property 'CreditCardExpirationYear'
        }
        /// <summary>
        /// Test the property 'ContactNumber'
        /// </summary>
        [TestMethod]
        public void ContactNumberTest()
        {
            // TODO unit test for the property 'ContactNumber'
        }
        /// <summary>
        /// Test the property 'ContactName'
        /// </summary>
        [TestMethod]
        public void ContactNameTest()
        {
            // TODO unit test for the property 'ContactName'
        }
        /// <summary>
        /// Test the property 'Inactive'
        /// </summary>
        [TestMethod]
        public void InactiveTest()
        {
            // TODO unit test for the property 'Inactive'
        }
        /// <summary>
        /// Test the property 'Converted'
        /// </summary>
        [TestMethod]
        public void ConvertedTest()
        {
            // TODO unit test for the property 'Converted'
        }
        /// <summary>
        /// Test the property 'IsDefault'
        /// </summary>
        [TestMethod]
        public void IsDefaultTest()
        {
            // TODO unit test for the property 'IsDefault'
        }
        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [TestMethod]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }

    }

}
