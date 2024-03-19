/* 
 * Brevo API
 *
 * Brevo provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/brevo  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@brevo.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = brevo_csharp.Client.SwaggerDateConverter;

namespace brevo_csharp.Model
{
    /// <summary>
    /// CreateWhatsAppCampaign
    /// </summary>
    [DataContract]
    public partial class CreateWhatsAppCampaign :  IEquatable<CreateWhatsAppCampaign>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWhatsAppCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWhatsAppCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWhatsAppCampaign" /> class.
        /// </summary>
        /// <param name="name">Name of the WhatsApp campaign creation (required).</param>
        /// <param name="templateId">Id of the WhatsApp template in **approved** state (required).</param>
        /// <param name="scheduledAt">Sending UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.For example: **2017-06-01T12:30:00+02:00**  (required).</param>
        /// <param name="recipients">recipients (required).</param>
        public CreateWhatsAppCampaign(string name = default(string), int? templateId = default(int?), string scheduledAt = default(string), CreateWhatsAppCampaignRecipients recipients = default(CreateWhatsAppCampaignRecipients))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CreateWhatsAppCampaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "templateId" is required (not null)
            if (templateId == null)
            {
                throw new InvalidDataException("templateId is a required property for CreateWhatsAppCampaign and cannot be null");
            }
            else
            {
                this.TemplateId = templateId;
            }
            // to ensure "scheduledAt" is required (not null)
            if (scheduledAt == null)
            {
                throw new InvalidDataException("scheduledAt is a required property for CreateWhatsAppCampaign and cannot be null");
            }
            else
            {
                this.ScheduledAt = scheduledAt;
            }
            // to ensure "recipients" is required (not null)
            if (recipients == null)
            {
                throw new InvalidDataException("recipients is a required property for CreateWhatsAppCampaign and cannot be null");
            }
            else
            {
                this.Recipients = recipients;
            }
        }
        
        /// <summary>
        /// Name of the WhatsApp campaign creation
        /// </summary>
        /// <value>Name of the WhatsApp campaign creation</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Id of the WhatsApp template in **approved** state
        /// </summary>
        /// <value>Id of the WhatsApp template in **approved** state</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// Sending UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.For example: **2017-06-01T12:30:00+02:00** 
        /// </summary>
        /// <value>Sending UTC date-time (YYYY-MM-DDTHH:mm:ss.SSSZ). **Prefer to pass your timezone in date-time format for accurate result.For example: **2017-06-01T12:30:00+02:00** </value>
        [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
        public string ScheduledAt { get; set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public CreateWhatsAppCampaignRecipients Recipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWhatsAppCampaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
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
            return this.Equals(input as CreateWhatsAppCampaign);
        }

        /// <summary>
        /// Returns true if CreateWhatsAppCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWhatsAppCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWhatsAppCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.ScheduledAt == input.ScheduledAt ||
                    (this.ScheduledAt != null &&
                    this.ScheduledAt.Equals(input.ScheduledAt))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.Equals(input.Recipients))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.ScheduledAt != null)
                    hashCode = hashCode * 59 + this.ScheduledAt.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                return hashCode;
            }
        }
    }

}