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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("_MoveRoutingRuleItemAt")]
	public partial class @__MoveRoutingRuleItemAtRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string RoutingRuleSetId = "RoutingRuleSetId";
			public const string RoutingRuleItemIdToMove = "RoutingRuleItemIdToMove";
			public const string TargetRoutingRuleItemId = "TargetRoutingRuleItemId";
			public const string IsBefore = "IsBefore";
			public const string Options = "Options";
		}
		
		public const string ActionLogicalName = "_MoveRoutingRuleItemAt";
		
		public Microsoft.Xrm.Sdk.EntityReference RoutingRuleSetId
		{
			get
			{
				if (this.Parameters.Contains("RoutingRuleSetId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["RoutingRuleSetId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["RoutingRuleSetId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference RoutingRuleItemIdToMove
		{
			get
			{
				if (this.Parameters.Contains("RoutingRuleItemIdToMove"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["RoutingRuleItemIdToMove"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["RoutingRuleItemIdToMove"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference TargetRoutingRuleItemId
		{
			get
			{
				if (this.Parameters.Contains("TargetRoutingRuleItemId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["TargetRoutingRuleItemId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["TargetRoutingRuleItemId"] = value;
			}
		}
		
		public bool IsBefore
		{
			get
			{
				if (this.Parameters.Contains("IsBefore"))
				{
					return ((bool)(this.Parameters["IsBefore"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["IsBefore"] = value;
			}
		}
		
		public string Options
		{
			get
			{
				if (this.Parameters.Contains("Options"))
				{
					return ((string)(this.Parameters["Options"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Options"] = value;
			}
		}
		
		public @__MoveRoutingRuleItemAtRequest()
		{
			this.RequestName = "_MoveRoutingRuleItemAt";
			this.RoutingRuleSetId = default(Microsoft.Xrm.Sdk.EntityReference);
			this.RoutingRuleItemIdToMove = default(Microsoft.Xrm.Sdk.EntityReference);
			this.TargetRoutingRuleItemId = default(Microsoft.Xrm.Sdk.EntityReference);
			this.IsBefore = default(bool);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("_MoveRoutingRuleItemAt")]
	public partial class @__MoveRoutingRuleItemAtResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public const string ActionLogicalName = "_MoveRoutingRuleItemAt";
		
		public @__MoveRoutingRuleItemAtResponse()
		{
		}
	}
}
#pragma warning restore CS1591
