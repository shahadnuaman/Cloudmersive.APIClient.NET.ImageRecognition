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
    /// Result of an NSFW classification
    /// </summary>
    [DataContract]
    public partial class NsfwResult :  IEquatable<NsfwResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NsfwResult" /> class.
        /// </summary>
        /// <param name="successful">True if the classification was successfully run, false otherwise.</param>
        /// <param name="score">Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high probability safe content, while scores 0.8-1.0 represent high probability unsafe content.  Content between 0.2 and 0.8 is of increasing raciness..</param>
        /// <param name="classificationOutcome">Classification result into four categories: SafeContent_HighProbability, UnsafeContent_HighProbability, RacyContent, SafeContent_ModerateProbability.</param>
        public NsfwResult(bool? successful = default(bool?), double? score = default(double?), string classificationOutcome = default(string))
        {
            this.Successful = successful;
            this.Score = score;
            this.ClassificationOutcome = classificationOutcome;
        }
        
        /// <summary>
        /// True if the classification was successfully run, false otherwise
        /// </summary>
        /// <value>True if the classification was successfully run, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high probability safe content, while scores 0.8-1.0 represent high probability unsafe content.  Content between 0.2 and 0.8 is of increasing raciness.
        /// </summary>
        /// <value>Score between 0.0 and 1.0.  Scores of 0.0-0.2 represent high probability safe content, while scores 0.8-1.0 represent high probability unsafe content.  Content between 0.2 and 0.8 is of increasing raciness.</value>
        [DataMember(Name="Score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// Classification result into four categories: SafeContent_HighProbability, UnsafeContent_HighProbability, RacyContent, SafeContent_ModerateProbability
        /// </summary>
        /// <value>Classification result into four categories: SafeContent_HighProbability, UnsafeContent_HighProbability, RacyContent, SafeContent_ModerateProbability</value>
        [DataMember(Name="ClassificationOutcome", EmitDefaultValue=false)]
        public string ClassificationOutcome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NsfwResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ClassificationOutcome: ").Append(ClassificationOutcome).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as NsfwResult);
        }

        /// <summary>
        /// Returns true if NsfwResult instances are equal
        /// </summary>
        /// <param name="input">Instance of NsfwResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NsfwResult input)
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
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.ClassificationOutcome == input.ClassificationOutcome ||
                    (this.ClassificationOutcome != null &&
                    this.ClassificationOutcome.Equals(input.ClassificationOutcome))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.ClassificationOutcome != null)
                    hashCode = hashCode * 59 + this.ClassificationOutcome.GetHashCode();
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
