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
    /// Request to compute the similarity between two image hashes
    /// </summary>
    [DataContract]
    public partial class ImageSimilarityHashDistanceRequest :  IEquatable<ImageSimilarityHashDistanceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSimilarityHashDistanceRequest" /> class.
        /// </summary>
        /// <param name="imageHash1">Image hash computed using Cloudmersive Image Hashing API.</param>
        /// <param name="imageHash2">Image hash computed using Cloudmersive Image Hashing API.</param>
        public ImageSimilarityHashDistanceRequest(string imageHash1 = default(string), string imageHash2 = default(string))
        {
            this.ImageHash1 = imageHash1;
            this.ImageHash2 = imageHash2;
        }
        
        /// <summary>
        /// Image hash computed using Cloudmersive Image Hashing API
        /// </summary>
        /// <value>Image hash computed using Cloudmersive Image Hashing API</value>
        [DataMember(Name="ImageHash1", EmitDefaultValue=false)]
        public string ImageHash1 { get; set; }

        /// <summary>
        /// Image hash computed using Cloudmersive Image Hashing API
        /// </summary>
        /// <value>Image hash computed using Cloudmersive Image Hashing API</value>
        [DataMember(Name="ImageHash2", EmitDefaultValue=false)]
        public string ImageHash2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSimilarityHashDistanceRequest {\n");
            sb.Append("  ImageHash1: ").Append(ImageHash1).Append("\n");
            sb.Append("  ImageHash2: ").Append(ImageHash2).Append("\n");
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
            return this.Equals(input as ImageSimilarityHashDistanceRequest);
        }

        /// <summary>
        /// Returns true if ImageSimilarityHashDistanceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageSimilarityHashDistanceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSimilarityHashDistanceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageHash1 == input.ImageHash1 ||
                    (this.ImageHash1 != null &&
                    this.ImageHash1.Equals(input.ImageHash1))
                ) && 
                (
                    this.ImageHash2 == input.ImageHash2 ||
                    (this.ImageHash2 != null &&
                    this.ImageHash2.Equals(input.ImageHash2))
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
                if (this.ImageHash1 != null)
                    hashCode = hashCode * 59 + this.ImageHash1.GetHashCode();
                if (this.ImageHash2 != null)
                    hashCode = hashCode * 59 + this.ImageHash2.GetHashCode();
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
