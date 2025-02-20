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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("vsd_CreateCORNETNotifications")]
	public partial class Vsd_CreateCornetNotificationsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string EventId = "EventId";
			public const string EventType = "EventType";
			public const string EventDate = "EventDate";
			public const string DataElement1 = "DataElement1";
			public const string DataValue1 = "DataValue1";
			public const string DataElement2 = "DataElement2";
			public const string DataValue2 = "DataValue2";
			public const string DataElement3 = "DataElement3";
			public const string DataValue3 = "DataValue3";
			public const string DataElement4 = "DataElement4";
			public const string DataValue4 = "DataValue4";
			public const string OrgJSon = "OrgJSon";
		}
		
		public const string ActionLogicalName = "vsd_CreateCORNETNotifications";
		
		public int EventId
		{
			get
			{
				if (this.Parameters.Contains("EventId"))
				{
					return ((int)(this.Parameters["EventId"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["EventId"] = value;
			}
		}
		
		public string EventType
		{
			get
			{
				if (this.Parameters.Contains("EventType"))
				{
					return ((string)(this.Parameters["EventType"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["EventType"] = value;
			}
		}
		
		public System.DateTime EventDate
		{
			get
			{
				if (this.Parameters.Contains("EventDate"))
				{
					return ((System.DateTime)(this.Parameters["EventDate"]));
				}
				else
				{
					return default(System.DateTime);
				}
			}
			set
			{
				this.Parameters["EventDate"] = value;
			}
		}
		
		public string DataElement1
		{
			get
			{
				if (this.Parameters.Contains("DataElement1"))
				{
					return ((string)(this.Parameters["DataElement1"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataElement1"] = value;
			}
		}
		
		public string DataValue1
		{
			get
			{
				if (this.Parameters.Contains("DataValue1"))
				{
					return ((string)(this.Parameters["DataValue1"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataValue1"] = value;
			}
		}
		
		public string DataElement2
		{
			get
			{
				if (this.Parameters.Contains("DataElement2"))
				{
					return ((string)(this.Parameters["DataElement2"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataElement2"] = value;
			}
		}
		
		public string DataValue2
		{
			get
			{
				if (this.Parameters.Contains("DataValue2"))
				{
					return ((string)(this.Parameters["DataValue2"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataValue2"] = value;
			}
		}
		
		public string DataElement3
		{
			get
			{
				if (this.Parameters.Contains("DataElement3"))
				{
					return ((string)(this.Parameters["DataElement3"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataElement3"] = value;
			}
		}
		
		public string DataValue3
		{
			get
			{
				if (this.Parameters.Contains("DataValue3"))
				{
					return ((string)(this.Parameters["DataValue3"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataValue3"] = value;
			}
		}
		
		public string DataElement4
		{
			get
			{
				if (this.Parameters.Contains("DataElement4"))
				{
					return ((string)(this.Parameters["DataElement4"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataElement4"] = value;
			}
		}
		
		public string DataValue4
		{
			get
			{
				if (this.Parameters.Contains("DataValue4"))
				{
					return ((string)(this.Parameters["DataValue4"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataValue4"] = value;
			}
		}
		
		public string OrgJSon
		{
			get
			{
				if (this.Parameters.Contains("OrgJSON"))
				{
					return ((string)(this.Parameters["OrgJSON"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["OrgJSON"] = value;
			}
		}
		
		public Vsd_CreateCornetNotificationsRequest()
		{
			this.RequestName = "vsd_CreateCORNETNotifications";
			this.EventId = default(int);
			this.EventType = default(string);
			this.EventDate = default(System.DateTime);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/vsd/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("vsd_CreateCORNETNotifications")]
	public partial class Vsd_CreateCornetNotificationsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string IsSuccess = "IsSuccess";
			public const string Result = "Result";
		}
		
		public const string ActionLogicalName = "vsd_CreateCORNETNotifications";
		
		public Vsd_CreateCornetNotificationsResponse()
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
