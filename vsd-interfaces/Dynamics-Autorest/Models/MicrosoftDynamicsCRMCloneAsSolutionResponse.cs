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
    /// CloneAsSolutionResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCloneAsSolutionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloneAsSolutionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCloneAsSolutionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCloneAsSolutionResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCloneAsSolutionResponse(string solutionId = default(string))
        {
            SolutionId = solutionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SolutionId")]
        public string SolutionId { get; set; }

    }
}
