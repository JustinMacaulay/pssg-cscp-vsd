#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database.Model
{
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetLegalAcceptanceStatus")]
	public partial class Msdyn_GetLegalAcceptanceStatusRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public const string ActionLogicalName = "msdyn_GetLegalAcceptanceStatus";
		
		public Msdyn_GetLegalAcceptanceStatusRequest()
		{
			this.RequestName = "msdyn_GetLegalAcceptanceStatus";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetLegalAcceptanceStatus")]
	public partial class Msdyn_GetLegalAcceptanceStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string Status = "Status";
		}
		
		public const string ActionLogicalName = "msdyn_GetLegalAcceptanceStatus";
		
		public Msdyn_GetLegalAcceptanceStatusResponse()
		{
		}
		
		public bool Status
		{
			get
			{
				if (this.Results.Contains("Status"))
				{
					return ((bool)(this.Results["Status"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["Status"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
