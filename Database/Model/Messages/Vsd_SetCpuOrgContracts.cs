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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_SetCPUOrgContracts")]
	public partial class Vsd_SetCpuOrgContractsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string BusinessBcEId = "BusinessBcEId";
			public const string UserBcEId = "UserBcEId";
			public const string Organization = "Organization";
			public const string StaffCollection = "StaffCollection";
			public const string ContactCollection = "ContactCollection";
			public const string ContractCollection = "ContractCollection";
			public const string ProgramCollection = "ProgramCollection";
			public const string ScheduleCollection = "ScheduleCollection";
			public const string TaskCollection = "TaskCollection";
			public const string ScheduleGcOlLection = "ScheduleGcOlLection";
			public const string ScheduleGLineItemCollection = "ScheduleGLineItemCollection";
			public const string SurplusPlanCollection = "SurplusPlanCollection";
			public const string SurplusPlanLineItemCollection = "SurplusPlanLineItemCollection";
			public const string AddProgramContactCollection = "AddProgramContactCollection";
			public const string RemoveProgramContactCollection = "RemoveProgramContactCollection";
			public const string AddProgramSubcontractorCollection = "AddProgramSubcontractorCollection";
			public const string RemoveProgramSubcontractorCollection = "RemoveProgramSubcontractorCollection";
			public const string ProgramExpenseCollection = "ProgramExpenseCollection";
			public const string ProgramRevenueSourceCollection = "ProgramRevenueSourceCollection";
			public const string NewContact = "NewContact";
			public const string NewServiceProvider = "NewServiceProvider";
		}
		
		public const string ActionLogicalName = "vsd_SetCPUOrgContracts";
		
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
		
		public Microsoft.Xrm.Sdk.Entity Organization
		{
			get
			{
				if (this.Parameters.Contains("Organization"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Parameters["Organization"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Parameters["Organization"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection StaffCollection
		{
			get
			{
				if (this.Parameters.Contains("StaffCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["StaffCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["StaffCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ContactCollection
		{
			get
			{
				if (this.Parameters.Contains("ContactCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ContactCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ContactCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ContractCollection
		{
			get
			{
				if (this.Parameters.Contains("ContractCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ContractCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ContractCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ProgramCollection
		{
			get
			{
				if (this.Parameters.Contains("ProgramCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ProgramCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ProgramCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ScheduleCollection
		{
			get
			{
				if (this.Parameters.Contains("ScheduleCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ScheduleCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ScheduleCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection TaskCollection
		{
			get
			{
				if (this.Parameters.Contains("TaskCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["TaskCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["TaskCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ScheduleGcOlLection
		{
			get
			{
				if (this.Parameters.Contains("ScheduleGCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ScheduleGCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ScheduleGCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ScheduleGLineItemCollection
		{
			get
			{
				if (this.Parameters.Contains("ScheduleGLineItemCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ScheduleGLineItemCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ScheduleGLineItemCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection SurplusPlanCollection
		{
			get
			{
				if (this.Parameters.Contains("SurplusPlanCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["SurplusPlanCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["SurplusPlanCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection SurplusPlanLineItemCollection
		{
			get
			{
				if (this.Parameters.Contains("SurplusPlanLineItemCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["SurplusPlanLineItemCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["SurplusPlanLineItemCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection AddProgramContactCollection
		{
			get
			{
				if (this.Parameters.Contains("AddProgramContactCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["AddProgramContactCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["AddProgramContactCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection RemoveProgramContactCollection
		{
			get
			{
				if (this.Parameters.Contains("RemoveProgramContactCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["RemoveProgramContactCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["RemoveProgramContactCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection AddProgramSubcontractorCollection
		{
			get
			{
				if (this.Parameters.Contains("AddProgramSubContractorCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["AddProgramSubContractorCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["AddProgramSubContractorCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection RemoveProgramSubcontractorCollection
		{
			get
			{
				if (this.Parameters.Contains("RemoveProgramSubContractorCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["RemoveProgramSubContractorCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["RemoveProgramSubContractorCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ProgramExpenseCollection
		{
			get
			{
				if (this.Parameters.Contains("ProgramExpenseCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ProgramExpenseCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ProgramExpenseCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityCollection ProgramRevenueSourceCollection
		{
			get
			{
				if (this.Parameters.Contains("ProgramRevenueSourceCollection"))
				{
					return ((Microsoft.Xrm.Sdk.EntityCollection)(this.Parameters["ProgramRevenueSourceCollection"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityCollection);
				}
			}
			set
			{
				this.Parameters["ProgramRevenueSourceCollection"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity NewContact
		{
			get
			{
				if (this.Parameters.Contains("NewContact"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Parameters["NewContact"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Parameters["NewContact"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity NewServiceProvider
		{
			get
			{
				if (this.Parameters.Contains("NewServiceProvider"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Parameters["NewServiceProvider"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
			set
			{
				this.Parameters["NewServiceProvider"] = value;
			}
		}
		
		public Vsd_SetCpuOrgContractsRequest()
		{
			this.RequestName = "vsd_SetCPUOrgContracts";
			this.BusinessBcEId = default(string);
			this.UserBcEId = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_SetCPUOrgContracts")]
	public partial class Vsd_SetCpuOrgContractsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string IsSuccess = "IsSuccess";
			public const string Result = "Result";
		}
		
		public const string ActionLogicalName = "vsd_SetCPUOrgContracts";
		
		public Vsd_SetCpuOrgContractsResponse()
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
