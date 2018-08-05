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
    /// Rectangle instance to draw on an image
    /// </summary>
    [DataContract]
    public partial class DrawRectangleInstance :  IEquatable<DrawRectangleInstance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangleInstance" /> class.
        /// </summary>
        /// <param name="BorderColor">Border Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported..</param>
        /// <param name="BorderWidth">Width in pixels of the border.  Pass in 0 to draw a rectangle with no border.</param>
        /// <param name="FillColor">Fill Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported.  Leave blank to not fill the rectangle..</param>
        /// <param name="X">Pixel location of the left edge of the rectangle location.</param>
        /// <param name="Y">Pixel location of the top edge of the rectangle location.</param>
        /// <param name="Width">Width in pixels of the rectangle.</param>
        /// <param name="Height">Height in pixels of the rectangle.</param>
        public DrawRectangleInstance(string BorderColor = default(string), double? BorderWidth = default(double?), string FillColor = default(string), double? X = default(double?), double? Y = default(double?), double? Width = default(double?), double? Height = default(double?))
        {
            this.BorderColor = BorderColor;
            this.BorderWidth = BorderWidth;
            this.FillColor = FillColor;
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }
        
        /// <summary>
        /// Border Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported.
        /// </summary>
        /// <value>Border Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported.</value>
        [DataMember(Name="BorderColor", EmitDefaultValue=false)]
        public string BorderColor { get; set; }

        /// <summary>
        /// Width in pixels of the border.  Pass in 0 to draw a rectangle with no border
        /// </summary>
        /// <value>Width in pixels of the border.  Pass in 0 to draw a rectangle with no border</value>
        [DataMember(Name="BorderWidth", EmitDefaultValue=false)]
        public double? BorderWidth { get; set; }

        /// <summary>
        /// Fill Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported.  Leave blank to not fill the rectangle.
        /// </summary>
        /// <value>Fill Color to use - can be a hex value (with #) or HTML common color name.  Transparent colors are supported.  Leave blank to not fill the rectangle.</value>
        [DataMember(Name="FillColor", EmitDefaultValue=false)]
        public string FillColor { get; set; }

        /// <summary>
        /// Pixel location of the left edge of the rectangle location
        /// </summary>
        /// <value>Pixel location of the left edge of the rectangle location</value>
        [DataMember(Name="X", EmitDefaultValue=false)]
        public double? X { get; set; }

        /// <summary>
        /// Pixel location of the top edge of the rectangle location
        /// </summary>
        /// <value>Pixel location of the top edge of the rectangle location</value>
        [DataMember(Name="Y", EmitDefaultValue=false)]
        public double? Y { get; set; }

        /// <summary>
        /// Width in pixels of the rectangle
        /// </summary>
        /// <value>Width in pixels of the rectangle</value>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Height in pixels of the rectangle
        /// </summary>
        /// <value>Height in pixels of the rectangle</value>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrawRectangleInstance {\n");
            sb.Append("  BorderColor: ").Append(BorderColor).Append("\n");
            sb.Append("  BorderWidth: ").Append(BorderWidth).Append("\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return this.Equals(input as DrawRectangleInstance);
        }

        /// <summary>
        /// Returns true if DrawRectangleInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of DrawRectangleInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrawRectangleInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BorderColor == input.BorderColor ||
                    (this.BorderColor != null &&
                    this.BorderColor.Equals(input.BorderColor))
                ) && 
                (
                    this.BorderWidth == input.BorderWidth ||
                    (this.BorderWidth != null &&
                    this.BorderWidth.Equals(input.BorderWidth))
                ) && 
                (
                    this.FillColor == input.FillColor ||
                    (this.FillColor != null &&
                    this.FillColor.Equals(input.FillColor))
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
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
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
                if (this.BorderColor != null)
                    hashCode = hashCode * 59 + this.BorderColor.GetHashCode();
                if (this.BorderWidth != null)
                    hashCode = hashCode * 59 + this.BorderWidth.GetHashCode();
                if (this.FillColor != null)
                    hashCode = hashCode * 59 + this.FillColor.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
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
