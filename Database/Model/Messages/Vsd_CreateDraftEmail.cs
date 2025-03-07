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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_CreateDraftEmail")]
	public partial class Vsd_CreateDraftEmailRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Subject = "Subject";
			public const string RegardingObjectTypeName = "RegardingObjectTypeName";
			public const string RegardingObjectId = "RegardingObjectId";
			public const string DocumentIds = "DocumentIds";
		}
		
		public const string ActionLogicalName = "vsd_CreateDraftEmail";
		
		public string Subject
		{
			get
			{
				if (this.Parameters.Contains("Subject"))
				{
					return ((string)(this.Parameters["Subject"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Subject"] = value;
			}
		}
		
		public string RegardingObjectTypeName
		{
			get
			{
				if (this.Parameters.Contains("RegardingObjectTypeName"))
				{
					return ((string)(this.Parameters["RegardingObjectTypeName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["RegardingObjectTypeName"] = value;
			}
		}
		
		public string RegardingObjectId
		{
			get
			{
				if (this.Parameters.Contains("RegardingObjectId"))
				{
					return ((string)(this.Parameters["RegardingObjectId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["RegardingObjectId"] = value;
			}
		}
		
		public string DocumentIds
		{
			get
			{
				if (this.Parameters.Contains("DocumentIds"))
				{
					return ((string)(this.Parameters["DocumentIds"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DocumentIds"] = value;
			}
		}
		
		public Vsd_CreateDraftEmailRequest()
		{
			this.RequestName = "vsd_CreateDraftEmail";
			this.Subject = default(string);
			this.RegardingObjectTypeName = default(string);
			this.RegardingObjectId = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_CreateDraftEmail")]
	public partial class Vsd_CreateDraftEmailResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string EmailId = "EmailId";
			public const string UserMessage = "UserMessage";
		}
		
		public const string ActionLogicalName = "vsd_CreateDraftEmail";
		
		public Vsd_CreateDraftEmailResponse()
		{
		}
		
		public string EmailId
		{
			get
			{
				if (this.Results.Contains("EmailId"))
				{
					return ((string)(this.Results["EmailId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["EmailId"] = value;
			}
		}
		
		public string UserMessage
		{
			get
			{
				if (this.Results.Contains("UserMessage"))
				{
					return ((string)(this.Results["UserMessage"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["UserMessage"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
