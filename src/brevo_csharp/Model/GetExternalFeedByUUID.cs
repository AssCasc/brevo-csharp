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
    /// GetExternalFeedByUUID
    /// </summary>
    [DataContract]
    public partial class GetExternalFeedByUUID :  IEquatable<GetExternalFeedByUUID>
    {
        /// <summary>
        /// Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60; 
        /// </summary>
        /// <value>Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            
            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 1,
            
            /// <summary>
            /// Enum Token for value: token
            /// </summary>
            [EnumMember(Value = "token")]
            Token = 2,
            
            /// <summary>
            /// Enum NoAuth for value: noAuth
            /// </summary>
            [EnumMember(Value = "noAuth")]
            NoAuth = 3
        }

        /// <summary>
        /// Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60; 
        /// </summary>
        /// <value>Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60; </value>
        [DataMember(Name="authType", EmitDefaultValue=false)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExternalFeedByUUID" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetExternalFeedByUUID() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetExternalFeedByUUID" /> class.
        /// </summary>
        /// <param name="id">ID of the feed (required).</param>
        /// <param name="name">Name of the feed (required).</param>
        /// <param name="url">URL of the feed (required).</param>
        /// <param name="authType">Auth type of the feed: * &#x60;basic&#x60; * &#x60;token&#x60; * &#x60;noAuth&#x60;  (required).</param>
        /// <param name="username">Username for authType &#x60;basic&#x60;.</param>
        /// <param name="password">Password for authType &#x60;basic&#x60;.</param>
        /// <param name="token">Token for authType &#x60;token&#x60;.</param>
        /// <param name="headers">Custom headers for the feed (required).</param>
        /// <param name="maxRetries">Maximum number of retries on the feed url (required).</param>
        /// <param name="cache">Toggle caching of feed url response (required).</param>
        /// <param name="createdAt">Datetime on which the feed was created (required).</param>
        /// <param name="modifiedAt">Datetime on which the feed was modified (required).</param>
        public GetExternalFeedByUUID(string id = default(string), string name = default(string), string url = default(string), AuthTypeEnum authType = default(AuthTypeEnum), string username = default(string), string password = default(string), string token = default(string), List<GetExternalFeedByUUIDHeaders> headers = default(List<GetExternalFeedByUUIDHeaders>), int? maxRetries = default(int?), bool? cache = default(bool?), DateTime? createdAt = default(DateTime?), DateTime? modifiedAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "authType" is required (not null)
            if (authType == null)
            {
                throw new InvalidDataException("authType is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.AuthType = authType;
            }
            // to ensure "headers" is required (not null)
            if (headers == null)
            {
                throw new InvalidDataException("headers is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.Headers = headers;
            }
            // to ensure "maxRetries" is required (not null)
            if (maxRetries == null)
            {
                throw new InvalidDataException("maxRetries is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.MaxRetries = maxRetries;
            }
            // to ensure "cache" is required (not null)
            if (cache == null)
            {
                throw new InvalidDataException("cache is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.Cache = cache;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "modifiedAt" is required (not null)
            if (modifiedAt == null)
            {
                throw new InvalidDataException("modifiedAt is a required property for GetExternalFeedByUUID and cannot be null");
            }
            else
            {
                this.ModifiedAt = modifiedAt;
            }
            this.Username = username;
            this.Password = password;
            this.Token = token;
        }
        
        /// <summary>
        /// ID of the feed
        /// </summary>
        /// <value>ID of the feed</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the feed
        /// </summary>
        /// <value>Name of the feed</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URL of the feed
        /// </summary>
        /// <value>URL of the feed</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }


        /// <summary>
        /// Username for authType &#x60;basic&#x60;
        /// </summary>
        /// <value>Username for authType &#x60;basic&#x60;</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Password for authType &#x60;basic&#x60;
        /// </summary>
        /// <value>Password for authType &#x60;basic&#x60;</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Token for authType &#x60;token&#x60;
        /// </summary>
        /// <value>Token for authType &#x60;token&#x60;</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Custom headers for the feed
        /// </summary>
        /// <value>Custom headers for the feed</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<GetExternalFeedByUUIDHeaders> Headers { get; set; }

        /// <summary>
        /// Maximum number of retries on the feed url
        /// </summary>
        /// <value>Maximum number of retries on the feed url</value>
        [DataMember(Name="maxRetries", EmitDefaultValue=false)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Toggle caching of feed url response
        /// </summary>
        /// <value>Toggle caching of feed url response</value>
        [DataMember(Name="cache", EmitDefaultValue=false)]
        public bool? Cache { get; set; }

        /// <summary>
        /// Datetime on which the feed was created
        /// </summary>
        /// <value>Datetime on which the feed was created</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Datetime on which the feed was modified
        /// </summary>
        /// <value>Datetime on which the feed was modified</value>
        [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExternalFeedByUUID {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  MaxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  Cache: ").Append(Cache).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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
            return this.Equals(input as GetExternalFeedByUUID);
        }

        /// <summary>
        /// Returns true if GetExternalFeedByUUID instances are equal
        /// </summary>
        /// <param name="input">Instance of GetExternalFeedByUUID to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetExternalFeedByUUID input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    (this.MaxRetries != null &&
                    this.MaxRetries.Equals(input.MaxRetries))
                ) && 
                (
                    this.Cache == input.Cache ||
                    (this.Cache != null &&
                    this.Cache.Equals(input.Cache))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.Cache != null)
                    hashCode = hashCode * 59 + this.Cache.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}