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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_GetCPUScheduleG")]
	public partial class Vsd_GetCpuScheduleGRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string BusinessBcEId = "BusinessBcEId";
			public const string UserBcEId = "UserBcEId";
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "vsd_GetCPUScheduleG";
		
		public string BusinessBcEId
		{
			get
			{
				if (this.Parameters.Contains("BusinessBCeID"))
				{
					return ((string)(this.Parameters["BusinessBCeID"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["BusinessBCeID"] = value;
			}
		}
		
		public string UserBcEId
		{
			get
			{
				if (this.Parameters.Contains("UserBCeID"))
				{
					return ((string)(this.Parameters["UserBCeID"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["UserBCeID"] = value;
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
		
		public Vsd_GetCpuScheduleGRequest()
		{
			this.RequestName = "vsd_GetCPUScheduleG";
			this.BusinessBcEId = default(string);
			this.UserBcEId = default(string);
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_GetCPUScheduleG")]
	public partial class Vsd_GetCpuScheduleGResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string BusinessBcEId = "BusinessBcEId";
			public const string Contract = "Contract";
			public const string IsSuccess = "IsSuccess";
			public const string Organization = "Organization";
			public const string PortalRoles = "PortalRoles";
			public const string Program = "Program";
			public const string Result = "Result";
			public const string ScheduleG = "ScheduleG";
			public const string ScheduleGLineItems = "ScheduleGLineItems";
			public const string UserBcEId = "UserBcEId";
		}
		
		public const string ActionLogicalName = "vsd_GetCPUScheduleG";
		
		public Vsd_GetCpuScheduleGResponse()
		{
		}
		
		public string BusinessBcEId
		{
			get
			{
				if (this.Results.Contains("Businessbceid"))
				{
					return ((string)(this.Results["Businessbceid"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["BusinessBcEId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity Contract
		{
			get
			{
				if (this.Results.Contains("Contract"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["Contract"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Results["Contract"] = value;
			}
		}
		
		public bool IsSuccess
		{
			get
			{
				if (this.Results.Contains("IsSuccess"))
				{
					return ((bool)(this.Results["IsSuccess"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["IsSuccess"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity Organization
		{
			get
			{
				if (this.Results.Contains("Organization"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["Organization"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Results["Organization"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection PortalRoles
		{
			get
			{
				if (this.Results.Contains("PortalRoles"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["PortalRoles"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["PortalRoles"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity Program
		{
			get
			{
				if (this.Results.Contains("Program"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["Program"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Results["Program"] = value;
			}
		}
		
		public string Result
		{
			get
			{
				if (this.Results.Contains("Result"))
				{
					return ((string)(this.Results["Result"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["Result"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity ScheduleG
		{
			get
			{
				if (this.Results.Contains("ScheduleG"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["ScheduleG"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Results["ScheduleG"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ScheduleGLineItems
		{
			get
			{
				if (this.Results.Contains("ScheduleGLineItems"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Results["ScheduleGLineItems"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Results["ScheduleGLineItems"] = value;
			}
		}
		
		public string UserBcEId
		{
			get
			{
				if (this.Results.Contains("Userbceid"))
				{
					return ((string)(this.Results["Userbceid"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["UserBcEId"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
