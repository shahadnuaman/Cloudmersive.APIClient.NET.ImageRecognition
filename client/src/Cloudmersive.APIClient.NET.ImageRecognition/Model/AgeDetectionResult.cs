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
    /// Result from classifying the Age of people in an image
    /// </summary>
    [DataContract]
    public partial class AgeDetectionResult :  IEquatable<AgeDetectionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeDetectionResult" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="peopleWithAge">People in the image annotated with age information.</param>
        /// <param name="peopleIdentified">Number of people identified in the image with an age.</param>
        public AgeDetectionResult(bool? successful = default(bool?), List<PersonWithAge> peopleWithAge = default(List<PersonWithAge>), int? peopleIdentified = default(int?))
        {
            this.Successful = successful;
            this.PeopleWithAge = peopleWithAge;
            this.PeopleIdentified = peopleIdentified;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// People in the image annotated with age information
        /// </summary>
        /// <value>People in the image annotated with age information</value>
        [DataMember(Name="PeopleWithAge", EmitDefaultValue=false)]
        public List<PersonWithAge> PeopleWithAge { get; set; }

        /// <summary>
        /// Number of people identified in the image with an age
        /// </summary>
        /// <value>Number of people identified in the image with an age</value>
        [DataMember(Name="PeopleIdentified", EmitDefaultValue=false)]
        public int? PeopleIdentified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgeDetectionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  PeopleWithAge: ").Append(PeopleWithAge).Append("\n");
            sb.Append("  PeopleIdentified: ").Append(PeopleIdentified).Append("\n");
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
            return this.Equals(input as AgeDetectionResult);
        }

        /// <summary>
        /// Returns true if AgeDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AgeDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgeDetectionResult input)
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
                    this.PeopleWithAge == input.PeopleWithAge ||
                    this.PeopleWithAge != null &&
                    this.PeopleWithAge.SequenceEqual(input.PeopleWithAge)
                ) && 
                (
                    this.PeopleIdentified == input.PeopleIdentified ||
                    (this.PeopleIdentified != null &&
                    this.PeopleIdentified.Equals(input.PeopleIdentified))
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
                if (this.PeopleWithAge != null)
                    hashCode = hashCode * 59 + this.PeopleWithAge.GetHashCode();
                if (this.PeopleIdentified != null)
                    hashCode = hashCode * 59 + this.PeopleIdentified.GetHashCode();
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
