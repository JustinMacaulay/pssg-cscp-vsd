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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_MergeCaseAction")]
	public partial class Vsd_MergeCaseActionRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string ParentCaseId = "ParentCaseId";
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "vsd_MergeCaseAction";
		
		public Microsoft.Xrm.Sdk.EntityReference ParentCaseId
		{
			get
			{
				if (this.Parameters.Contains("ParentCaseId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["ParentCaseId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["ParentCaseId"] = value;
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
		
		public Vsd_MergeCaseActionRequest()
		{
			this.RequestName = "vsd_MergeCaseAction";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_MergeCaseAction")]
	public partial class Vsd_MergeCaseActionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public const string ActionLogicalName = "vsd_MergeCaseAction";
		
		public Vsd_MergeCaseActionResponse()
		{
		}
	}
}
#pragma warning restore CS1591
