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
    /// Single object instance, and associated details, detected in an image
    /// </summary>
    [DataContract]
    public partial class DetectedObject :  IEquatable<DetectedObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedObject" /> class.
        /// </summary>
        /// <param name="ObjectClassName">Class of the object.  Example values are \&quot;person\&quot;, \&quot;car\&quot;, \&quot;dining table\&quot;, etc..</param>
        /// <param name="Height">Height, in pixels, of the object.</param>
        /// <param name="Width">Width, in pixels, of the object.</param>
        /// <param name="Score">Confidence score of detected object; possible values are between 0.0 and 1.0; values closer to 1.0 are higher confidence.</param>
        /// <param name="X">X location, in pixels, of the left side location of the object, with the right side being X + Width.</param>
        /// <param name="Y">Y location, in pixels, of the top side location of the object, with the bottom side being Y + Height.</param>
        public DetectedObject(string ObjectClassName = default(string), int? Height = default(int?), int? Width = default(int?), double? Score = default(double?), int? X = default(int?), int? Y = default(int?))
        {
            this.ObjectClassName = ObjectClassName;
            this.Height = Height;
            this.Width = Width;
            this.Score = Score;
            this.X = X;
            this.Y = Y;
        }
        
        /// <summary>
        /// Class of the object.  Example values are \&quot;person\&quot;, \&quot;car\&quot;, \&quot;dining table\&quot;, etc.
        /// </summary>
        /// <value>Class of the object.  Example values are \&quot;person\&quot;, \&quot;car\&quot;, \&quot;dining table\&quot;, etc.</value>
        [DataMember(Name="ObjectClassName", EmitDefaultValue=false)]
        public string ObjectClassName { get; set; }

        /// <summary>
        /// Height, in pixels, of the object
        /// </summary>
        /// <value>Height, in pixels, of the object</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// Width, in pixels, of the object
        /// </summary>
        /// <value>Width, in pixels, of the object</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Confidence score of detected object; possible values are between 0.0 and 1.0; values closer to 1.0 are higher confidence
        /// </summary>
        /// <value>Confidence score of detected object; possible values are between 0.0 and 1.0; values closer to 1.0 are higher confidence</value>
        [DataMember(Name="Score", EmitDefaultValue=false)]
        public double? Score { get; set; }

        /// <summary>
        /// X location, in pixels, of the left side location of the object, with the right side being X + Width
        /// </summary>
        /// <value>X location, in pixels, of the left side location of the object, with the right side being X + Width</value>
        [DataMember(Name="X", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Y location, in pixels, of the top side location of the object, with the bottom side being Y + Height
        /// </summary>
        /// <value>Y location, in pixels, of the top side location of the object, with the bottom side being Y + Height</value>
        [DataMember(Name="Y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectedObject {\n");
            sb.Append("  ObjectClassName: ").Append(ObjectClassName).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as DetectedObject);
        }

        /// <summary>
        /// Returns true if DetectedObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DetectedObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetectedObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectClassName == input.ObjectClassName ||
                    (this.ObjectClassName != null &&
                    this.ObjectClassName.Equals(input.ObjectClassName))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
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
                if (this.ObjectClassName != null)
                    hashCode = hashCode * 59 + this.ObjectClassName.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
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
