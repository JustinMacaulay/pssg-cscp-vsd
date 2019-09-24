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
    /// MissingComponent
    /// </summary>
    public partial class MicrosoftDynamicsCRMMissingComponent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMMissingComponent class.
        /// </summary>
        public MicrosoftDynamicsCRMMissingComponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMMissingComponent class.
        /// </summary>
        public MicrosoftDynamicsCRMMissingComponent(MicrosoftDynamicsCRMComponentDetail requiredComponent = default(MicrosoftDynamicsCRMComponentDetail), MicrosoftDynamicsCRMComponentDetail dependentComponent = default(MicrosoftDynamicsCRMComponentDetail))
        {
            RequiredComponent = requiredComponent;
            DependentComponent = dependentComponent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RequiredComponent")]
        public MicrosoftDynamicsCRMComponentDetail RequiredComponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DependentComponent")]
        public MicrosoftDynamicsCRMComponentDetail DependentComponent { get; set; }

    }
}
