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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Nedap.Retail.Api.Idcloud.Model
{
    /// <summary>
    /// EpcisQueryParameters
    /// </summary>
    [DataContract]
    public partial class EpcisQueryParameters :  IEquatable<EpcisQueryParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EpcisQueryParameters" /> class.
        /// </summary>
        /// <param name="Parameters">Parameters.</param>
        public EpcisQueryParameters(List<ParameterObject> Parameters = default(List<ParameterObject>))
        {
            this.Parameters = Parameters;
        }
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ParameterObject> Parameters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpcisQueryParameters {\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EpcisQueryParameters);
        }

        /// <summary>
        /// Returns true if EpcisQueryParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of EpcisQueryParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EpcisQueryParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
