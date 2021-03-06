using System;
using System.Runtime.Serialization;

namespace Microsoft.ServiceBus.Messaging.Sbmp
{
	[DataContract(Name="TryReceiveResponse", Namespace="http://schemas.microsoft.com/netservices/2011/06/servicebus")]
	internal sealed class PeekResponseCommand : IExtensibleDataObject
	{
		[DataMember(Name="messages", EmitDefaultValue=true, IsRequired=false, Order=65537)]
		private MessageCollection messages;

		private ExtensionDataObject extensionData;

		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionData;
			}
			set
			{
				this.extensionData = value;
			}
		}

		public MessageCollection Messages
		{
			get
			{
				return this.messages;
			}
			set
			{
				this.messages = value;
			}
		}

		public PeekResponseCommand()
		{
		}
	}
}