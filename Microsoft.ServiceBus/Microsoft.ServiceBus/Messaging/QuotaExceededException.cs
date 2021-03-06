using Microsoft.ServiceBus.Tracing;
using System;
using System.Runtime.Serialization;

namespace Microsoft.ServiceBus.Messaging
{
	[Serializable]
	public class QuotaExceededException : MessagingException
	{
		public QuotaExceededException(string message) : base(message)
		{
			base.IsTransient = false;
		}

		public QuotaExceededException(string message, Exception innerException) : base(message, innerException)
		{
			base.IsTransient = false;
		}

		internal QuotaExceededException(MessagingExceptionDetail detail, TrackingContext trackingContext) : base(detail, trackingContext)
		{
			base.IsTransient = false;
		}

		internal QuotaExceededException(MessagingExceptionDetail detail, TrackingContext trackingContext, Exception innerException) : base(detail, trackingContext, innerException)
		{
			base.IsTransient = false;
		}

		protected QuotaExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			base.IsTransient = false;
		}
	}
}