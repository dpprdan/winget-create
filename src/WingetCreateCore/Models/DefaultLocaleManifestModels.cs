//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace Microsoft.WingetCreateCore.Models.DefaultLocale
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Agreement
    {
        /// <summary>
        /// The label of the Agreement. i.e. EULA, AgeRating, etc. This field should be localized. Either Agreement or AgreementUrl is required. When we show the agreements, we would Bold the AgreementLabel
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgreementLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string AgreementLabel { get; set; }

        /// <summary>
        /// The agreement text content.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Agreement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 1)]
        public string Agreement1 { get; set; }

        /// <summary>
        /// The agreement URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgreementUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string AgreementUrl { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Documentation
    {
        /// <summary>
        /// The label of the documentation for providing software guides such as manuals and troubleshooting URLs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DocumentLabel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100, MinimumLength = 1)]
        public string DocumentLabel { get; set; }

        /// <summary>
        /// The documentation URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DocumentUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string DocumentUrl { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Icon
    {
        /// <summary>
        /// The url of the hosted icon file
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IconUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string IconUrl { get; set; }

        /// <summary>
        /// The icon file type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IconFileType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IconFileType IconFileType { get; set; }

        /// <summary>
        /// Optional icon resolution
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IconResolution", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IconResolution? IconResolution { get; set; }

        /// <summary>
        /// Optional icon theme
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IconTheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IconTheme? IconTheme { get; set; }

        /// <summary>
        /// Optional Sha256 of the icon file
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IconSha256", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[A-Fa-f0-9]{64}$")]
        public string IconSha256 { get; set; }



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// A representation of a multiple-file manifest representing a default app metadata in the OWC. v1.9.0
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class DefaultLocaleManifest
    {
        /// <summary>
        /// The package unique identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PackageIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}(\.[^\.\s\\/:\*\?""<>\|\x01-\x1f]{1,32}){1,7}$")]
        public string PackageIdentifier { get; set; }

        /// <summary>
        /// The package version
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PackageVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^[^\\/:\*\?""<>\|\x01-\x1f]+$")]
        public string PackageVersion { get; set; }

        /// <summary>
        /// The package meta-data locale
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PackageLocale", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([a-zA-Z]{2,3}|[iI]-[a-zA-Z]+|[xX]-[a-zA-Z]{1,8})(-[a-zA-Z]{1,8})*$")]
        public string PackageLocale { get; set; } = "en-US";

        /// <summary>
        /// The publisher name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Publisher", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Publisher { get; set; }

        /// <summary>
        /// The publisher home page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublisherUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherUrl { get; set; }

        /// <summary>
        /// The publisher support page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PublisherSupportUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PublisherSupportUrl { get; set; }

        /// <summary>
        /// The publisher privacy page or the package privacy page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PrivacyUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PrivacyUrl { get; set; }

        /// <summary>
        /// The package author
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Author", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string Author { get; set; }

        /// <summary>
        /// The package name
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PackageName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 2)]
        public string PackageName { get; set; }

        /// <summary>
        /// The package home page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PackageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// The package license
        /// </summary>
        [Newtonsoft.Json.JsonProperty("License", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string License { get; set; }

        /// <summary>
        /// The license page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LicenseUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// The package copyright
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Copyright", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(512, MinimumLength = 3)]
        public string Copyright { get; set; }

        /// <summary>
        /// The package copyright page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CopyrightUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string CopyrightUrl { get; set; }

        /// <summary>
        /// The short package description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ShortDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 3)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The full package description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 3)]
        public string Description { get; set; }

        /// <summary>
        /// The most common package term
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Moniker", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(40, MinimumLength = 1)]
        public string Moniker { get; set; }

        /// <summary>
        /// List of additional package search terms
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Tags", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(16)]
        public System.Collections.Generic.List<string> Tags { get; set; }

        [Newtonsoft.Json.JsonProperty("Agreements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(128)]
        public System.Collections.Generic.List<Agreement> Agreements { get; set; }

        /// <summary>
        /// The package release notes
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ReleaseNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 1)]
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// The package release notes url
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ReleaseNotesUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string ReleaseNotesUrl { get; set; }

        /// <summary>
        /// The purchase url for acquiring entitlement for the package.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PurchaseUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2048)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^([Hh][Tt][Tt][Pp][Ss]?)://.+$")]
        public string PurchaseUrl { get; set; }

        /// <summary>
        /// The notes displayed to the user upon completion of a package installation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("InstallationNotes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10000, MinimumLength = 1)]
        public string InstallationNotes { get; set; }

        [Newtonsoft.Json.JsonProperty("Documentations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(256)]
        public System.Collections.Generic.List<Documentation> Documentations { get; set; }

        [Newtonsoft.Json.JsonProperty("Icons", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MaxLength(1024)]
        public System.Collections.Generic.List<Icon> Icons { get; set; }

        /// <summary>
        /// The manifest type
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ManifestType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ManifestType { get; set; } = "defaultLocale";

        /// <summary>
        /// The manifest syntax version
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ManifestVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(\.(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])){2}$")]
        public string ManifestVersion { get; set; } = "1.9.0";



        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
            set { _additionalProperties = value; }
        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum IconFileType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"png")]
        Png = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"jpeg")]
        Jpeg = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"ico")]
        Ico = 2,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum IconResolution
    {

        [System.Runtime.Serialization.EnumMember(Value = @"custom")]
        Custom = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"16x16")]
        _16x16 = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"20x20")]
        _20x20 = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"24x24")]
        _24x24 = 3,


        [System.Runtime.Serialization.EnumMember(Value = @"30x30")]
        _30x30 = 4,


        [System.Runtime.Serialization.EnumMember(Value = @"32x32")]
        _32x32 = 5,


        [System.Runtime.Serialization.EnumMember(Value = @"36x36")]
        _36x36 = 6,


        [System.Runtime.Serialization.EnumMember(Value = @"40x40")]
        _40x40 = 7,


        [System.Runtime.Serialization.EnumMember(Value = @"48x48")]
        _48x48 = 8,


        [System.Runtime.Serialization.EnumMember(Value = @"60x60")]
        _60x60 = 9,


        [System.Runtime.Serialization.EnumMember(Value = @"64x64")]
        _64x64 = 10,


        [System.Runtime.Serialization.EnumMember(Value = @"72x72")]
        _72x72 = 11,


        [System.Runtime.Serialization.EnumMember(Value = @"80x80")]
        _80x80 = 12,


        [System.Runtime.Serialization.EnumMember(Value = @"96x96")]
        _96x96 = 13,


        [System.Runtime.Serialization.EnumMember(Value = @"256x256")]
        _256x256 = 14,


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "11.0.0.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum IconTheme
    {

        [System.Runtime.Serialization.EnumMember(Value = @"default")]
        Default = 0,


        [System.Runtime.Serialization.EnumMember(Value = @"light")]
        Light = 1,


        [System.Runtime.Serialization.EnumMember(Value = @"dark")]
        Dark = 2,


        [System.Runtime.Serialization.EnumMember(Value = @"highContrast")]
        HighContrast = 3,


    }
}