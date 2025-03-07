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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_GetActiveQueueItem")]
	public partial class Vsd_GetActiveQueueItemRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string CaseId = "CaseId";
			public const string InvoiceId = "InvoiceId";
			public const string EmailId = "EmailId";
			public const string PhoneCallId = "PhoneCallId";
			public const string TaskId = "TaskId";
			public const string AppointmentId = "AppointmentId";
			public const string ServiceActivityId = "ServiceActivityId";
			public const string LetterId = "LetterId";
			public const string FaxId = "FaxId";
			public const string QueueItemId = "QueueItemId";
		}
		
		public const string ActionLogicalName = "vsd_GetActiveQueueItem";
		
		public Microsoft.Xrm.Sdk.EntityReference CaseId
		{
			get
			{
				if (this.Parameters.Contains("CaseId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["CaseId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["CaseId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference InvoiceId
		{
			get
			{
				if (this.Parameters.Contains("InvoiceId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["InvoiceId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["InvoiceId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference EmailId
		{
			get
			{
				if (this.Parameters.Contains("EmailId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["EmailId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["EmailId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference PhoneCallId
		{
			get
			{
				if (this.Parameters.Contains("PhoneCallId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["PhoneCallId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["PhoneCallId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference TaskId
		{
			get
			{
				if (this.Parameters.Contains("TaskId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["TaskId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["TaskId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference AppointmentId
		{
			get
			{
				if (this.Parameters.Contains("AppointmentId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["AppointmentId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["AppointmentId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference ServiceActivityId
		{
			get
			{
				if (this.Parameters.Contains("ServiceActivityId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["ServiceActivityId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["ServiceActivityId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference LetterId
		{
			get
			{
				if (this.Parameters.Contains("LetterId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["LetterId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["LetterId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference FaxId
		{
			get
			{
				if (this.Parameters.Contains("FaxId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["FaxId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["FaxId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference QueueItemId
		{
			get
			{
				if (this.Parameters.Contains("QueueItemId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["QueueItemId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["QueueItemId"] = value;
			}
		}
		
		public Vsd_GetActiveQueueItemRequest()
		{
			this.RequestName = "vsd_GetActiveQueueItem";
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_GetActiveQueueItem")]
	public partial class Vsd_GetActiveQueueItemResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string ActivityActiveQueueItem = "ActivityActiveQueueItem";
			public const string CaseActiveQueueItem = "CaseActiveQueueItem";
			public const string CaseLookup = "CaseLookup";
			public const string ClientLookup = "ClientLookup";
			public const string InvoiceActiveQueueItem = "InvoiceActiveQueueItem";
			public const string InvoiceLookup = "InvoiceLookup";
			public const string IsActivityQueueItemFound = "IsActivityQueueItemFound";
			public const string IsCaseQueueItemFound = "IsCaseQueueItemFound";
			public const string IsInvoiceQueueItemFound = "IsInvoiceQueueItemFound";
		}
		
		public const string ActionLogicalName = "vsd_GetActiveQueueItem";
		
		public Vsd_GetActiveQueueItemResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.EntityReference ActivityActiveQueueItem
		{
			get
			{
				if (this.Results.Contains("ActivityActiveQueueItem"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["ActivityActiveQueueItem"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["ActivityActiveQueueItem"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference CaseActiveQueueItem
		{
			get
			{
				if (this.Results.Contains("CaseActiveQueueItem"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["CaseActiveQueueItem"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["CaseActiveQueueItem"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference CaseLookup
		{
			get
			{
				if (this.Results.Contains("CaseLookup"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["CaseLookup"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["CaseLookup"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference ClientLookup
		{
			get
			{
				if (this.Results.Contains("ClientLookup"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["ClientLookup"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["ClientLookup"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference InvoiceActiveQueueItem
		{
			get
			{
				if (this.Results.Contains("InvoiceActiveQueueItem"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["InvoiceActiveQueueItem"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["InvoiceActiveQueueItem"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference InvoiceLookup
		{
			get
			{
				if (this.Results.Contains("InvoiceLookup"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Results["InvoiceLookup"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Results["InvoiceLookup"] = value;
			}
		}
		
		public bool IsActivityQueueItemFound
		{
			get
			{
				if (this.Results.Contains("IsActivityQueueItemFound"))
				{
					return ((bool)(this.Results["IsActivityQueueItemFound"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["IsActivityQueueItemFound"] = value;
			}
		}
		
		public bool IsCaseQueueItemFound
		{
			get
			{
				if (this.Results.Contains("IsCaseQueueItemFound"))
				{
					return ((bool)(this.Results["IsCaseQueueItemFound"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["IsCaseQueueItemFound"] = value;
			}
		}
		
		public bool IsInvoiceQueueItemFound
		{
			get
			{
				if (this.Results.Contains("IsInvoiceQueueItemFound"))
				{
					return ((bool)(this.Results["IsInvoiceQueueItemFound"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Results["IsInvoiceQueueItemFound"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
