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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("_ServiceCalendarAction")]
	public partial class @__ServiceCalendarActionRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string Type = "Type";
			public const string InputParameter = "InputParameter";
		}
		
		public const string ActionLogicalName = "_ServiceCalendarAction";
		
		public int Type
		{
			get
			{
				if (this.Parameters.Contains("Type"))
				{
					return ((int)(this.Parameters["Type"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["Type"] = value;
			}
		}
		
		public string InputParameter
		{
			get
			{
				if (this.Parameters.Contains("InputParameter"))
				{
					return ((string)(this.Parameters["InputParameter"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["InputParameter"] = value;
			}
		}
		
		public @__ServiceCalendarActionRequest()
		{
			this.RequestName = "_ServiceCalendarAction";
			this.Type = default(int);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_ServiceCalendarAction")]
	public partial class @__ServiceCalendarActionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public static class Fields
		{
			public const string OutputParameter = "OutputParameter";
		}
		
		public const string ActionLogicalName = "_ServiceCalendarAction";
		
		public @__ServiceCalendarActionResponse()
		{
		}
		
		public string OutputParameter
		{
			get
			{
				if (this.Results.Contains("OutputParameter"))
				{
					return ((string)(this.Results["OutputParameter"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Results["OutputParameter"] = value;
			}
		}
	}
}
#pragma warning restore CS1591
