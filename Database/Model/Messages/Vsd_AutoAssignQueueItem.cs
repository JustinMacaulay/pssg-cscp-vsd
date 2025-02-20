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
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_AutoAssignQueueItem")]
	public partial class Vsd_AutoAssignQueueItemRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string UserId = "UserId";
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "vsd_AutoAssignQueueItem";
		
		public Microsoft.Xrm.Sdk.EntityReference UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["UserId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public Vsd_AutoAssignQueueItemRequest()
		{
			this.RequestName = "vsd_AutoAssignQueueItem";
			this.UserId = default(Microsoft.Xrm.Sdk.EntityReference);
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_AutoAssignQueueItem")]
	public partial class Vsd_AutoAssignQueueItemResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string IsAssigned = "IsAssigned";
		}
		
		public const string ActionLogicalName = "vsd_AutoAssignQueueItem";
		
		public Vsd_AutoAssignQueueItemResponse()
		{
		}
		
		public bool IsAssigned
		{
			get
			{
				if (this.Results.Contains("IsAssigned"))
				{
					return ((bool)(this.Results["IsAssigned"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["IsAssigned"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
