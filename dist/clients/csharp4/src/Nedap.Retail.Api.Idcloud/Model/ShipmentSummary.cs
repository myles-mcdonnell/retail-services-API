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
    /// ShipmentSummary
    /// </summary>
    [DataContract]
    public partial class ShipmentSummary :  IEquatable<ShipmentSummary>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum INTRANSIT for "INTRANSIT"
            /// </summary>
            [EnumMember(Value = "INTRANSIT")]
            INTRANSIT,
            
            /// <summary>
            /// Enum RECEIVED for "RECEIVED"
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentSummary" /> class.
        /// </summary>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="ExternRef">ExternRef.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Destination">Destination.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="LastModifiedAt">LastModifiedAt.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SentQuantity">SentQuantity.</param>
        /// <param name="ReceivedQuantity">ReceivedQuantity.</param>
        /// <param name="ReceivedPercentage">ReceivedPercentage.</param>
        public ShipmentSummary(string ParentId = default(string), string ExternRef = default(string), string Source = default(string), string Destination = default(string), DateTime? CreatedAt = default(DateTime?), DateTime? LastModifiedAt = default(DateTime?), StatusEnum? Status = default(StatusEnum?), int? SentQuantity = default(int?), int? ReceivedQuantity = default(int?), float? ReceivedPercentage = default(float?))
        {
            this.ParentId = ParentId;
            this.ExternRef = ExternRef;
            this.Source = Source;
            this.Destination = Destination;
            this.CreatedAt = CreatedAt;
            this.LastModifiedAt = LastModifiedAt;
            this.Status = Status;
            this.SentQuantity = SentQuantity;
            this.ReceivedQuantity = ReceivedQuantity;
            this.ReceivedPercentage = ReceivedPercentage;
        }
        
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public string ParentId { get; set; }
        /// <summary>
        /// Gets or Sets ExternRef
        /// </summary>
        [DataMember(Name="extern_ref", EmitDefaultValue=false)]
        public string ExternRef { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }
        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets LastModifiedAt
        /// </summary>
        [DataMember(Name="last_modified_at", EmitDefaultValue=false)]
        public DateTime? LastModifiedAt { get; set; }
        /// <summary>
        /// Gets or Sets SentQuantity
        /// </summary>
        [DataMember(Name="sent_quantity", EmitDefaultValue=false)]
        public int? SentQuantity { get; set; }
        /// <summary>
        /// Gets or Sets ReceivedQuantity
        /// </summary>
        [DataMember(Name="received_quantity", EmitDefaultValue=false)]
        public int? ReceivedQuantity { get; set; }
        /// <summary>
        /// Gets or Sets ReceivedPercentage
        /// </summary>
        [DataMember(Name="received_percentage", EmitDefaultValue=false)]
        public float? ReceivedPercentage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipmentSummary {\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ExternRef: ").Append(ExternRef).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastModifiedAt: ").Append(LastModifiedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SentQuantity: ").Append(SentQuantity).Append("\n");
            sb.Append("  ReceivedQuantity: ").Append(ReceivedQuantity).Append("\n");
            sb.Append("  ReceivedPercentage: ").Append(ReceivedPercentage).Append("\n");
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
            return this.Equals(obj as ShipmentSummary);
        }

        /// <summary>
        /// Returns true if ShipmentSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipmentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.ExternRef == other.ExternRef ||
                    this.ExternRef != null &&
                    this.ExternRef.Equals(other.ExternRef)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.LastModifiedAt == other.LastModifiedAt ||
                    this.LastModifiedAt != null &&
                    this.LastModifiedAt.Equals(other.LastModifiedAt)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SentQuantity == other.SentQuantity ||
                    this.SentQuantity != null &&
                    this.SentQuantity.Equals(other.SentQuantity)
                ) && 
                (
                    this.ReceivedQuantity == other.ReceivedQuantity ||
                    this.ReceivedQuantity != null &&
                    this.ReceivedQuantity.Equals(other.ReceivedQuantity)
                ) && 
                (
                    this.ReceivedPercentage == other.ReceivedPercentage ||
                    this.ReceivedPercentage != null &&
                    this.ReceivedPercentage.Equals(other.ReceivedPercentage)
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
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.ExternRef != null)
                    hash = hash * 59 + this.ExternRef.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.LastModifiedAt != null)
                    hash = hash * 59 + this.LastModifiedAt.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SentQuantity != null)
                    hash = hash * 59 + this.SentQuantity.GetHashCode();
                if (this.ReceivedQuantity != null)
                    hash = hash * 59 + this.ReceivedQuantity.GetHashCode();
                if (this.ReceivedPercentage != null)
                    hash = hash * 59 + this.ReceivedPercentage.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
