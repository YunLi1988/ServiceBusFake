using System;
using System.Configuration;

namespace Microsoft.ServiceBus.Configuration
{
	public sealed class StsUriElement : ConfigurationElement
	{
		[ConfigurationProperty("value", IsRequired=true, IsKey=true)]
		public Uri Value
		{
			get
			{
				return (Uri)base["value"];
			}
			set
			{
				base["value"] = value;
			}
		}

		public StsUriElement()
		{
		}
	}
}