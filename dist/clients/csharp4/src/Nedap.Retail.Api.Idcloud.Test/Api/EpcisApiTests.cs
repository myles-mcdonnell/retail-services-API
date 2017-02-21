/* 
 * !D Cloud API
 *
 * !D Cloud is an RFID integration platform for retail stores. While we                                         provide core functionality for retail companies, a lot of functionality can be                                         added or extended by 3rd party developers. We encourage you to do so!
 *
 * OpenAPI spec version: v1
 * Contact: info@nedap-idcloud.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Nedap.Retail.Api.Idcloud.Client;
using Nedap.Retail.Api.Idcloud.Api;
using Nedap.Retail.Api.Idcloud.Model;

namespace Nedap.Retail.Api.Idcloud.Test
{
    /// <summary>
    ///  Class for testing EpcisApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EpcisApiTests
    {
        private EpcisApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EpcisApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EpcisApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EpcisApi
            //Assert.IsInstanceOfType(typeof(EpcisApi), instance, "instance is a EpcisApi");
        }

        
        /// <summary>
        /// Test Capture
        /// </summary>
        [Test]
        public void CaptureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EpcisEventContainer events = null;
            //instance.Capture(events);
            
        }
        
        /// <summary>
        /// Test Query
        /// </summary>
        [Test]
        public void QueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EpcisQueryParameters parameters = null;
            //var response = instance.Query(parameters);
            //Assert.IsInstanceOf<List<EpcisEvent>> (response, "response is List<EpcisEvent>");
        }
        
    }

}
