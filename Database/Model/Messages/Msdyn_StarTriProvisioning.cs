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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_StartRIProvisioning")]
	public partial class Msdyn_StarTriProvisioningRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string HubName = "HubName";
			public const string PrimaryKey = "PrimaryKey";
		}
		
		public const string ActionLogicalName = "msdyn_StartRIProvisioning";
		
		public string HubName
		{
			get
			{
				if (this.Parameters.Contains("HubName"))
				{
					return ((string)(this.Parameters["HubName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["HubName"] = value;
			}
		}
		
		public string PrimaryKey
		{
			get
			{
				if (this.Parameters.Contains("PrimaryKey"))
				{
					return ((string)(this.Parameters["PrimaryKey"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["PrimaryKey"] = value;
			}
		}
		
		public Msdyn_StarTriProvisioningRequest()
		{
			this.RequestName = "msdyn_StartRIProvisioning";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_StartRIProvisioning")]
	public partial class Msdyn_StarTriProvisioningResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public const string ActionLogicalName = "msdyn_StartRIProvisioning";
		
		public Msdyn_StarTriProvisioningResponse()
		{
		}
	}
}
#pragma warning restore CS1591
