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
    /// ApprovedDifferenceListExportResponse
    /// </summary>
    [DataContract]
    public partial class ApprovedDifferenceListExportResponse :  IEquatable<ApprovedDifferenceListExportResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ExportStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportStatusEnum
        {
            
            /// <summary>
            /// Enum NOTEXPORTED for "NOT_EXPORTED"
            /// </summary>
            [EnumMember(Value = "NOT_EXPORTED")]
            NOTEXPORTED,
            
            /// <summary>
            /// Enum EXPORTED for "EXPORTED"
            /// </summary>
            [EnumMember(Value = "EXPORTED")]
            EXPORTED,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR
        }

        /// <summary>
        /// Gets or Sets ExportStatus
        /// </summary>
        [DataMember(Name="export_status", EmitDefaultValue=false)]
        public ExportStatusEnum? ExportStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovedDifferenceListExportResponse" /> class.
        /// </summary>
        /// <param name="Location">Location.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Gtins">Gtins.</param>
        /// <param name="Articles">Articles.</param>
        /// <param name="ApprovedOn">ApprovedOn.</param>
        /// <param name="ApprovedBy">ApprovedBy.</param>
        /// <param name="ErpStockId">ErpStockId.</param>
        /// <param name="ErpStockTime">ErpStockTime.</param>
        /// <param name="ErpQuantity">ErpQuantity.</param>
        /// <param name="ErpGtinQuantity">ErpGtinQuantity.</param>
        /// <param name="RfidStockTime">RfidStockTime.</param>
        /// <param name="RfidQuantity">RfidQuantity.</param>
        /// <param name="RfidGtinQuantity">RfidGtinQuantity.</param>
        /// <param name="AbsoluteDifference">AbsoluteDifference.</param>
        /// <param name="PlusDifference">PlusDifference.</param>
        /// <param name="MinusDifference">MinusDifference.</param>
        /// <param name="ExportStatus">ExportStatus.</param>
        /// <param name="ExportTime">ExportTime.</param>
        /// <param name="ExternRef">ExternRef.</param>
        /// <param name="Accuracy">Accuracy.</param>
        /// <param name="ApprovedQuantity">ApprovedQuantity.</param>
        public ApprovedDifferenceListExportResponse(string Location = default(string), Guid? Id = default(Guid?), List<string> Gtins = default(List<string>), List<Article> Articles = default(List<Article>), DateTime? ApprovedOn = default(DateTime?), string ApprovedBy = default(string), string ErpStockId = default(string), DateTime? ErpStockTime = default(DateTime?), int? ErpQuantity = default(int?), int? ErpGtinQuantity = default(int?), DateTime? RfidStockTime = default(DateTime?), int? RfidQuantity = default(int?), int? RfidGtinQuantity = default(int?), int? AbsoluteDifference = default(int?), int? PlusDifference = default(int?), int? MinusDifference = default(int?), ExportStatusEnum? ExportStatus = default(ExportStatusEnum?), DateTime? ExportTime = default(DateTime?), string ExternRef = default(string), double? Accuracy = default(double?), List<int?> ApprovedQuantity = default(List<int?>))
        {
            this.Location = Location;
            this.Id = Id;
            this.Gtins = Gtins;
            this.Articles = Articles;
            this.ApprovedOn = ApprovedOn;
            this.ApprovedBy = ApprovedBy;
            this.ErpStockId = ErpStockId;
            this.ErpStockTime = ErpStockTime;
            this.ErpQuantity = ErpQuantity;
            this.ErpGtinQuantity = ErpGtinQuantity;
            this.RfidStockTime = RfidStockTime;
            this.RfidQuantity = RfidQuantity;
            this.RfidGtinQuantity = RfidGtinQuantity;
            this.AbsoluteDifference = AbsoluteDifference;
            this.PlusDifference = PlusDifference;
            this.MinusDifference = MinusDifference;
            this.ExportStatus = ExportStatus;
            this.ExportTime = ExportTime;
            this.ExternRef = ExternRef;
            this.Accuracy = Accuracy;
            this.ApprovedQuantity = ApprovedQuantity;
        }
        
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets Gtins
        /// </summary>
        [DataMember(Name="gtins", EmitDefaultValue=false)]
        public List<string> Gtins { get; set; }
        /// <summary>
        /// Gets or Sets Articles
        /// </summary>
        [DataMember(Name="articles", EmitDefaultValue=false)]
        public List<Article> Articles { get; set; }
        /// <summary>
        /// Gets or Sets ApprovedOn
        /// </summary>
        [DataMember(Name="approved_on", EmitDefaultValue=false)]
        public DateTime? ApprovedOn { get; set; }
        /// <summary>
        /// Gets or Sets ApprovedBy
        /// </summary>
        [DataMember(Name="approved_by", EmitDefaultValue=false)]
        public string ApprovedBy { get; set; }
        /// <summary>
        /// Gets or Sets ErpStockId
        /// </summary>
        [DataMember(Name="erp_stock_id", EmitDefaultValue=false)]
        public string ErpStockId { get; set; }
        /// <summary>
        /// Gets or Sets ErpStockTime
        /// </summary>
        [DataMember(Name="erp_stock_time", EmitDefaultValue=false)]
        public DateTime? ErpStockTime { get; set; }
        /// <summary>
        /// Gets or Sets ErpQuantity
        /// </summary>
        [DataMember(Name="erp_quantity", EmitDefaultValue=false)]
        public int? ErpQuantity { get; set; }
        /// <summary>
        /// Gets or Sets ErpGtinQuantity
        /// </summary>
        [DataMember(Name="erp_gtin_quantity", EmitDefaultValue=false)]
        public int? ErpGtinQuantity { get; set; }
        /// <summary>
        /// Gets or Sets RfidStockTime
        /// </summary>
        [DataMember(Name="rfid_stock_time", EmitDefaultValue=false)]
        public DateTime? RfidStockTime { get; set; }
        /// <summary>
        /// Gets or Sets RfidQuantity
        /// </summary>
        [DataMember(Name="rfid_quantity", EmitDefaultValue=false)]
        public int? RfidQuantity { get; set; }
        /// <summary>
        /// Gets or Sets RfidGtinQuantity
        /// </summary>
        [DataMember(Name="rfid_gtin_quantity", EmitDefaultValue=false)]
        public int? RfidGtinQuantity { get; set; }
        /// <summary>
        /// Gets or Sets AbsoluteDifference
        /// </summary>
        [DataMember(Name="absolute_difference", EmitDefaultValue=false)]
        public int? AbsoluteDifference { get; set; }
        /// <summary>
        /// Gets or Sets PlusDifference
        /// </summary>
        [DataMember(Name="plus_difference", EmitDefaultValue=false)]
        public int? PlusDifference { get; set; }
        /// <summary>
        /// Gets or Sets MinusDifference
        /// </summary>
        [DataMember(Name="minus_difference", EmitDefaultValue=false)]
        public int? MinusDifference { get; set; }
        /// <summary>
        /// Gets or Sets ExportTime
        /// </summary>
        [DataMember(Name="export_time", EmitDefaultValue=false)]
        public DateTime? ExportTime { get; set; }
        /// <summary>
        /// Gets or Sets ExternRef
        /// </summary>
        [DataMember(Name="extern_ref", EmitDefaultValue=false)]
        public string ExternRef { get; set; }
        /// <summary>
        /// Gets or Sets Accuracy
        /// </summary>
        [DataMember(Name="accuracy", EmitDefaultValue=false)]
        public double? Accuracy { get; set; }
        /// <summary>
        /// Gets or Sets ApprovedQuantity
        /// </summary>
        [DataMember(Name="approved_quantity", EmitDefaultValue=false)]
        public List<int?> ApprovedQuantity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApprovedDifferenceListExportResponse {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Gtins: ").Append(Gtins).Append("\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  ApprovedOn: ").Append(ApprovedOn).Append("\n");
            sb.Append("  ApprovedBy: ").Append(ApprovedBy).Append("\n");
            sb.Append("  ErpStockId: ").Append(ErpStockId).Append("\n");
            sb.Append("  ErpStockTime: ").Append(ErpStockTime).Append("\n");
            sb.Append("  ErpQuantity: ").Append(ErpQuantity).Append("\n");
            sb.Append("  ErpGtinQuantity: ").Append(ErpGtinQuantity).Append("\n");
            sb.Append("  RfidStockTime: ").Append(RfidStockTime).Append("\n");
            sb.Append("  RfidQuantity: ").Append(RfidQuantity).Append("\n");
            sb.Append("  RfidGtinQuantity: ").Append(RfidGtinQuantity).Append("\n");
            sb.Append("  AbsoluteDifference: ").Append(AbsoluteDifference).Append("\n");
            sb.Append("  PlusDifference: ").Append(PlusDifference).Append("\n");
            sb.Append("  MinusDifference: ").Append(MinusDifference).Append("\n");
            sb.Append("  ExportStatus: ").Append(ExportStatus).Append("\n");
            sb.Append("  ExportTime: ").Append(ExportTime).Append("\n");
            sb.Append("  ExternRef: ").Append(ExternRef).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
            sb.Append("  ApprovedQuantity: ").Append(ApprovedQuantity).Append("\n");
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
            return this.Equals(obj as ApprovedDifferenceListExportResponse);
        }

        /// <summary>
        /// Returns true if ApprovedDifferenceListExportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ApprovedDifferenceListExportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApprovedDifferenceListExportResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Gtins == other.Gtins ||
                    this.Gtins != null &&
                    this.Gtins.SequenceEqual(other.Gtins)
                ) && 
                (
                    this.Articles == other.Articles ||
                    this.Articles != null &&
                    this.Articles.SequenceEqual(other.Articles)
                ) && 
                (
                    this.ApprovedOn == other.ApprovedOn ||
                    this.ApprovedOn != null &&
                    this.ApprovedOn.Equals(other.ApprovedOn)
                ) && 
                (
                    this.ApprovedBy == other.ApprovedBy ||
                    this.ApprovedBy != null &&
                    this.ApprovedBy.Equals(other.ApprovedBy)
                ) && 
                (
                    this.ErpStockId == other.ErpStockId ||
                    this.ErpStockId != null &&
                    this.ErpStockId.Equals(other.ErpStockId)
                ) && 
                (
                    this.ErpStockTime == other.ErpStockTime ||
                    this.ErpStockTime != null &&
                    this.ErpStockTime.Equals(other.ErpStockTime)
                ) && 
                (
                    this.ErpQuantity == other.ErpQuantity ||
                    this.ErpQuantity != null &&
                    this.ErpQuantity.Equals(other.ErpQuantity)
                ) && 
                (
                    this.ErpGtinQuantity == other.ErpGtinQuantity ||
                    this.ErpGtinQuantity != null &&
                    this.ErpGtinQuantity.Equals(other.ErpGtinQuantity)
                ) && 
                (
                    this.RfidStockTime == other.RfidStockTime ||
                    this.RfidStockTime != null &&
                    this.RfidStockTime.Equals(other.RfidStockTime)
                ) && 
                (
                    this.RfidQuantity == other.RfidQuantity ||
                    this.RfidQuantity != null &&
                    this.RfidQuantity.Equals(other.RfidQuantity)
                ) && 
                (
                    this.RfidGtinQuantity == other.RfidGtinQuantity ||
                    this.RfidGtinQuantity != null &&
                    this.RfidGtinQuantity.Equals(other.RfidGtinQuantity)
                ) && 
                (
                    this.AbsoluteDifference == other.AbsoluteDifference ||
                    this.AbsoluteDifference != null &&
                    this.AbsoluteDifference.Equals(other.AbsoluteDifference)
                ) && 
                (
                    this.PlusDifference == other.PlusDifference ||
                    this.PlusDifference != null &&
                    this.PlusDifference.Equals(other.PlusDifference)
                ) && 
                (
                    this.MinusDifference == other.MinusDifference ||
                    this.MinusDifference != null &&
                    this.MinusDifference.Equals(other.MinusDifference)
                ) && 
                (
                    this.ExportStatus == other.ExportStatus ||
                    this.ExportStatus != null &&
                    this.ExportStatus.Equals(other.ExportStatus)
                ) && 
                (
                    this.ExportTime == other.ExportTime ||
                    this.ExportTime != null &&
                    this.ExportTime.Equals(other.ExportTime)
                ) && 
                (
                    this.ExternRef == other.ExternRef ||
                    this.ExternRef != null &&
                    this.ExternRef.Equals(other.ExternRef)
                ) && 
                (
                    this.Accuracy == other.Accuracy ||
                    this.Accuracy != null &&
                    this.Accuracy.Equals(other.Accuracy)
                ) && 
                (
                    this.ApprovedQuantity == other.ApprovedQuantity ||
                    this.ApprovedQuantity != null &&
                    this.ApprovedQuantity.SequenceEqual(other.ApprovedQuantity)
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
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Gtins != null)
                    hash = hash * 59 + this.Gtins.GetHashCode();
                if (this.Articles != null)
                    hash = hash * 59 + this.Articles.GetHashCode();
                if (this.ApprovedOn != null)
                    hash = hash * 59 + this.ApprovedOn.GetHashCode();
                if (this.ApprovedBy != null)
                    hash = hash * 59 + this.ApprovedBy.GetHashCode();
                if (this.ErpStockId != null)
                    hash = hash * 59 + this.ErpStockId.GetHashCode();
                if (this.ErpStockTime != null)
                    hash = hash * 59 + this.ErpStockTime.GetHashCode();
                if (this.ErpQuantity != null)
                    hash = hash * 59 + this.ErpQuantity.GetHashCode();
                if (this.ErpGtinQuantity != null)
                    hash = hash * 59 + this.ErpGtinQuantity.GetHashCode();
                if (this.RfidStockTime != null)
                    hash = hash * 59 + this.RfidStockTime.GetHashCode();
                if (this.RfidQuantity != null)
                    hash = hash * 59 + this.RfidQuantity.GetHashCode();
                if (this.RfidGtinQuantity != null)
                    hash = hash * 59 + this.RfidGtinQuantity.GetHashCode();
                if (this.AbsoluteDifference != null)
                    hash = hash * 59 + this.AbsoluteDifference.GetHashCode();
                if (this.PlusDifference != null)
                    hash = hash * 59 + this.PlusDifference.GetHashCode();
                if (this.MinusDifference != null)
                    hash = hash * 59 + this.MinusDifference.GetHashCode();
                if (this.ExportStatus != null)
                    hash = hash * 59 + this.ExportStatus.GetHashCode();
                if (this.ExportTime != null)
                    hash = hash * 59 + this.ExportTime.GetHashCode();
                if (this.ExternRef != null)
                    hash = hash * 59 + this.ExternRef.GetHashCode();
                if (this.Accuracy != null)
                    hash = hash * 59 + this.Accuracy.GetHashCode();
                if (this.ApprovedQuantity != null)
                    hash = hash * 59 + this.ApprovedQuantity.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
