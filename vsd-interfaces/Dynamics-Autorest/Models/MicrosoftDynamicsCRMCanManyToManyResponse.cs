// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CanManyToManyResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCanManyToManyResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanManyToManyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanManyToManyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCanManyToManyResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCanManyToManyResponse(bool? canManyToMany = default(bool?))
        {
            CanManyToMany = canManyToMany;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanManyToMany")]
        public bool? CanManyToMany { get; set; }

    }
}
