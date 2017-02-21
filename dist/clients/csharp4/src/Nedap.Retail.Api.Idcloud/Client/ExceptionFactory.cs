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
using RestSharp;

namespace Nedap.Retail.Api.Idcloud.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
