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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_SetLegalAcceptanceStatus")]
	public partial class Msdyn_SetLegalAcceptanceStatusRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Status = "Status";
		}
		
		public const string ActionLogicalName = "msdyn_SetLegalAcceptanceStatus";
		
		public bool Status
		{
			get
			{
				if (this.Parameters.Contains("Status"))
				{
					return ((bool)(this.Parameters["Status"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["Status"] = value;
			}
		}
		
		public Msdyn_SetLegalAcceptanceStatusRequest()
		{
			this.RequestName = "msdyn_SetLegalAcceptanceStatus";
			this.Status = default(bool);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_SetLegalAcceptanceStatus")]
	public partial class Msdyn_SetLegalAcceptanceStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public const string ActionLogicalName = "msdyn_SetLegalAcceptanceStatus";
		
		public Msdyn_SetLegalAcceptanceStatusResponse()
		{
		}
	}
}
#pragma warning restore CS1591
