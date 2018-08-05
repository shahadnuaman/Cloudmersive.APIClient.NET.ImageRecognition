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
    /// Request to draw one or more pieces of text onto an image
    /// </summary>
    [DataContract]
    public partial class DrawTextRequest :  IEquatable<DrawTextRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawTextRequest" /> class.
        /// </summary>
        /// <param name="BaseImageBytes">Image to draw text on, in bytes.  You can also use the BaseImageUrl instead to supply image input as a URL.</param>
        /// <param name="BaseImageUrl">Image to draw text on, as an HTTP or HTTPS fully-qualified URL.</param>
        /// <param name="TextToDraw">One or more pieces of text to draw onto the image.</param>
        public DrawTextRequest(byte[] BaseImageBytes = default(byte[]), string BaseImageUrl = default(string), List<DrawTextInstance> TextToDraw = default(List<DrawTextInstance>))
        {
            this.BaseImageBytes = BaseImageBytes;
            this.BaseImageUrl = BaseImageUrl;
            this.TextToDraw = TextToDraw;
        }
        
        /// <summary>
        /// Image to draw text on, in bytes.  You can also use the BaseImageUrl instead to supply image input as a URL
        /// </summary>
        /// <value>Image to draw text on, in bytes.  You can also use the BaseImageUrl instead to supply image input as a URL</value>
        [DataMember(Name="BaseImageBytes", EmitDefaultValue=false)]
        public byte[] BaseImageBytes { get; set; }

        /// <summary>
        /// Image to draw text on, as an HTTP or HTTPS fully-qualified URL
        /// </summary>
        /// <value>Image to draw text on, as an HTTP or HTTPS fully-qualified URL</value>
        [DataMember(Name="BaseImageUrl", EmitDefaultValue=false)]
        public string BaseImageUrl { get; set; }

        /// <summary>
        /// One or more pieces of text to draw onto the image
        /// </summary>
        /// <value>One or more pieces of text to draw onto the image</value>
        [DataMember(Name="TextToDraw", EmitDefaultValue=false)]
        public List<DrawTextInstance> TextToDraw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawTextRequest {\n");
            sb.Append("  BaseImageBytes: ").Append(BaseImageBytes).Append("\n");
            sb.Append("  BaseImageUrl: ").Append(BaseImageUrl).Append("\n");
            sb.Append("  TextToDraw: ").Append(TextToDraw).Append("\n");
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
            return this.Equals(input as DrawTextRequest);
        }

        /// <summary>
        /// Returns true if DrawTextRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DrawTextRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrawTextRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseImageBytes == input.BaseImageBytes ||
                    (this.BaseImageBytes != null &&
                    this.BaseImageBytes.Equals(input.BaseImageBytes))
                ) && 
                (
                    this.BaseImageUrl == input.BaseImageUrl ||
                    (this.BaseImageUrl != null &&
                    this.BaseImageUrl.Equals(input.BaseImageUrl))
                ) && 
                (
                    this.TextToDraw == input.TextToDraw ||
                    this.TextToDraw != null &&
                    this.TextToDraw.SequenceEqual(input.TextToDraw)
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
                if (this.BaseImageBytes != null)
                    hashCode = hashCode * 59 + this.BaseImageBytes.GetHashCode();
                if (this.BaseImageUrl != null)
                    hashCode = hashCode * 59 + this.BaseImageUrl.GetHashCode();
                if (this.TextToDraw != null)
                    hashCode = hashCode * 59 + this.TextToDraw.GetHashCode();
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