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
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("_GetServiceTreeData")]
	public partial class @__GetServiceTreedAtaRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ServiceId = "ServiceId";
		}
		
		public const string ActionLogicalName = "_GetServiceTreeData";
		
		public string ServiceId
		{
			get
			{
				if (this.Parameters.Contains("ServiceId"))
				{
					return ((string)(this.Parameters["ServiceId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ServiceId"] = value;
			}
		}
		
		public @__GetServiceTreedAtaRequest()
		{
			this.RequestName = "_GetServiceTreeData";
			this.ServiceId = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_GetServiceTreeData")]
	public partial class @__GetServiceTreedAtaResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string TreeObject = "TreeObject";
		}
		
		public const string ActionLogicalName = "_GetServiceTreeData";
		
		public @__GetServiceTreedAtaResponse()
		{
		}
		
		public string TreeObject
		{
			get
			{
				if (this.Results.Contains("TreeObject"))
				{
					return ((string)(this.Results["TreeObject"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["TreeObject"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
