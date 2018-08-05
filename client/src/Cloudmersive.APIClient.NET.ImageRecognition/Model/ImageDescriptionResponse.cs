/* 
 * imageapi
 *
 * Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.
 *
 * OpenAPI spec version: v1
 * 
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.ImageRecognition.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.ImageRecognition.Model
{
    /// <summary>
    /// Result of recognizing an image
    /// </summary>
    [DataContract]
    public partial class ImageDescriptionResponse :  IEquatable<ImageDescriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDescriptionResponse" /> class.
        /// </summary>
        /// <param name="Successful">Was the image processed successfully?.</param>
        /// <param name="Highconfidence">Is the resulting best outcome recognition a high confidence outcome?.</param>
        /// <param name="BestOutcome">The best Machine Learning outcome.</param>
        /// <param name="RunnerUpOutcome">Best backup (\&quot;runner up\&quot;) Machine Learning outcome.</param>
        public ImageDescriptionResponse(bool? Successful = default(bool?), bool? Highconfidence = default(bool?), RecognitionOutcome BestOutcome = default(RecognitionOutcome), RecognitionOutcome RunnerUpOutcome = default(RecognitionOutcome))
        {
            this.Successful = Successful;
            this.Highconfidence = Highconfidence;
            this.BestOutcome = BestOutcome;
            this.RunnerUpOutcome = RunnerUpOutcome;
        }
        
        /// <summary>
        /// Was the image processed successfully?
        /// </summary>
        /// <value>Was the image processed successfully?</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Is the resulting best outcome recognition a high confidence outcome?
        /// </summary>
        /// <value>Is the resulting best outcome recognition a high confidence outcome?</value>
        [DataMember(Name="Highconfidence", EmitDefaultValue=false)]
        public bool? Highconfidence { get; set; }

        /// <summary>
        /// The best Machine Learning outcome
        /// </summary>
        /// <value>The best Machine Learning outcome</value>
        [DataMember(Name="BestOutcome", EmitDefaultValue=false)]
        public RecognitionOutcome BestOutcome { get; set; }

        /// <summary>
        /// Best backup (\&quot;runner up\&quot;) Machine Learning outcome
        /// </summary>
        /// <value>Best backup (\&quot;runner up\&quot;) Machine Learning outcome</value>
        [DataMember(Name="RunnerUpOutcome", EmitDefaultValue=false)]
        public RecognitionOutcome RunnerUpOutcome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDescriptionResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Highconfidence: ").Append(Highconfidence).Append("\n");
            sb.Append("  BestOutcome: ").Append(BestOutcome).Append("\n");
            sb.Append("  RunnerUpOutcome: ").Append(RunnerUpOutcome).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDescriptionResponse);
        }

        /// <summary>
        /// Returns true if ImageDescriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageDescriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageDescriptionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.Highconfidence == input.Highconfidence ||
                    (this.Highconfidence != null &&
                    this.Highconfidence.Equals(input.Highconfidence))
                ) && 
                (
                    this.BestOutcome == input.BestOutcome ||
                    (this.BestOutcome != null &&
                    this.BestOutcome.Equals(input.BestOutcome))
                ) && 
                (
                    this.RunnerUpOutcome == input.RunnerUpOutcome ||
                    (this.RunnerUpOutcome != null &&
                    this.RunnerUpOutcome.Equals(input.RunnerUpOutcome))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.Highconfidence != null)
                    hashCode = hashCode * 59 + this.Highconfidence.GetHashCode();
                if (this.BestOutcome != null)
                    hashCode = hashCode * 59 + this.BestOutcome.GetHashCode();
                if (this.RunnerUpOutcome != null)
                    hashCode = hashCode * 59 + this.RunnerUpOutcome.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
