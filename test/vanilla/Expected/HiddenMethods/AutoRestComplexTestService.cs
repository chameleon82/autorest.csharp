// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.HiddenMethods
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial class AutoRestComplexTestService : ServiceClient<AutoRestComplexTestService>, IAutoRestComplexTestService
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// API ID.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets the IBasicOperations.
        /// </summary>
        public virtual IBasicOperations Basic { get; private set; }

        /// <summary>
        /// Gets the IPrimitive.
        /// </summary>
        public virtual IPrimitive Primitive { get; private set; }

        /// <summary>
        /// Gets the IArray.
        /// </summary>
        public virtual IArray Array { get; private set; }

        /// <summary>
        /// Gets the IDictionary.
        /// </summary>
        public virtual IDictionary Dictionary { get; private set; }

        /// <summary>
        /// Gets the IInheritance.
        /// </summary>
        public virtual IInheritance Inheritance { get; private set; }

        /// <summary>
        /// Gets the IPolymorphism.
        /// </summary>
        public virtual IPolymorphism Polymorphism { get; private set; }

        /// <summary>
        /// Gets the IPolymorphicrecursive.
        /// </summary>
        public virtual IPolymorphicrecursive Polymorphicrecursive { get; private set; }

        /// <summary>
        /// Gets the IReadonlyproperty.
        /// </summary>
        public virtual IReadonlyproperty Readonlyproperty { get; private set; }

        /// <summary>
        /// Gets the IFlattencomplex.
        /// </summary>
        public virtual IFlattencomplex Flattencomplex { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AutoRestComplexTestService class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling AutoRestComplexTestService.Dispose(). False: will not dispose provided httpClient</param>
        public AutoRestComplexTestService(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestComplexTestService class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestComplexTestService(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestComplexTestService class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestComplexTestService(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestComplexTestService class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutoRestComplexTestService(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestComplexTestService class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public AutoRestComplexTestService(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Basic = new BasicOperations(this);
            Primitive = new Primitive(this);
            Array = new Array(this);
            Dictionary = new Dictionary(this);
            Inheritance = new Inheritance(this);
            Polymorphism = new Polymorphism(this);
            Polymorphicrecursive = new Polymorphicrecursive(this);
            Readonlyproperty = new Readonlyproperty(this);
            Flattencomplex = new Flattencomplex(this);
            BaseUri = new System.Uri("http://localhost:3000");
            ApiVersion = "2014-04-01-preview";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<Fish>("fishtype"));
            DeserializationSettings.Converters.Add(new  PolymorphicDeserializeJsonConverter<Fish>("fishtype"));
            SerializationSettings.Converters.Add(new PolymorphicSerializeJsonConverter<MyBaseType>("kind"));
            DeserializationSettings.Converters.Add(new  PolymorphicDeserializeJsonConverter<MyBaseType>("kind"));
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
        }
    }
}
