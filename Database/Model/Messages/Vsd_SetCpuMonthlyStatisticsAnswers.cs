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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_SetCPUMonthlyStatisticsAnswers")]
	public partial class Vsd_SetCpuMonthlyStatisticsAnswersRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string BusinessBcEId = "BusinessBcEId";
			public const string UserBcEId = "UserBcEId";
			public const string AnswerCollection = "AnswerCollection";
			public const string Target = "Target";
		}
		
		public const string ActionLogicalName = "vsd_SetCPUMonthlyStatisticsAnswers";
		
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
		
		public Microsoft.Xrm.Sdk.EntityCollection AnswerCollection
		{
			get
			{
				if (this.Parameters.Contains("AnswerCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["AnswerCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["AnswerCollection"] = value;
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
		
		public Vsd_SetCpuMonthlyStatisticsAnswersRequest()
		{
			this.RequestName = "vsd_SetCPUMonthlyStatisticsAnswers";
			this.BusinessBcEId = default(string);
			this.UserBcEId = default(string);
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_SetCPUMonthlyStatisticsAnswers")]
	public partial class Vsd_SetCpuMonthlyStatisticsAnswersResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string IsSuccess = "IsSuccess";
			public const string Result = "Result";
		}
		
		public const string ActionLogicalName = "vsd_SetCPUMonthlyStatisticsAnswers";
		
		public Vsd_SetCpuMonthlyStatisticsAnswersResponse()
		{
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
	}
}
#pragma warning restore CS1591
