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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("PvaCreateContentSnapshot")]
	public partial class PVaCreateContentSnapshotRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "PvaCreateContentSnapshot";
		
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
		
		public PVaCreateContentSnapshotRequest()
		{
			this.RequestName = "PvaCreateContentSnapshot";
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("PvaCreateContentSnapshot")]
	public partial class PVaCreateContentSnapshotResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string SnapshotId = "SnapshotId";
		}
		
		public const string ActionLogicalName = "PvaCreateContentSnapshot";
		
		public PVaCreateContentSnapshotResponse()
		{
		}
		
		public string SnapshotId
		{
			get
			{
				if (this.Results.Contains("SnapshotId"))
				{
					return ((string)(this.Results["SnapshotId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["SnapshotId"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
