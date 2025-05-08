using System;

namespace TradingPlatform.BusinessLayer;

public class EmailSendCompletedResult
{
	public EmailSendCompletedStatus Status;

	public string Message;

	public void SetError(Exception ex)
	{
		Message = ex.Message;
		Status = EmailSendCompletedStatus.Failure;
	}
}
