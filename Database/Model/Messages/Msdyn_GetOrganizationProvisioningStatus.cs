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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_GetOrganizationProvisioningStatus")]
	public partial class Msdyn_GetOrganizationProvisioningStatusRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public const string ActionLogicalName = "msdyn_GetOrganizationProvisioningStatus";
		
		public Msdyn_GetOrganizationProvisioningStatusRequest()
		{
			this.RequestName = "msdyn_GetOrganizationProvisioningStatus";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_GetOrganizationProvisioningStatus")]
	public partial class Msdyn_GetOrganizationProvisioningStatusResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string OrgProvisioningStatus = "OrgProvisioningStatus";
		}
		
		public const string ActionLogicalName = "msdyn_GetOrganizationProvisioningStatus";
		
		public Msdyn_GetOrganizationProvisioningStatusResponse()
		{
		}
		
		public string OrgProvisioningStatus
		{
			get
			{
				if (this.Results.Contains("OrgProvisioningStatus"))
				{
					return ((string)(this.Results["OrgProvisioningStatus"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["OrgProvisioningStatus"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
