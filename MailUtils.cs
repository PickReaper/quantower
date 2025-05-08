using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public class MailUtils : ICustomizable
{
	[CompilerGenerated]
	private sealed class 녴
	{
		public MailUtils 놵놌;

		public EmailParameters 놵놕;

		internal void 녴()
		{
			try
			{
				놵놌.녴(놵놕);
			}
			catch (Exception error)
			{
				if (놵놕.callBack != null)
				{
					EmailSendCompletedResult emailSendCompletedResult = new EmailSendCompletedResult();
					emailSendCompletedResult.SetError(error);
					놵놕.callBack(emailSendCompletedResult);
				}
			}
		}
	}

	[CompilerGenerated]
	private bool 녲놳;

	[CompilerGenerated]
	private string 녲놺;

	[CompilerGenerated]
	private string 녲놅;

	[CompilerGenerated]
	private int 녲녜;

	[CompilerGenerated]
	private string 녲뇃;

	[CompilerGenerated]
	private int 녲녯;

	public bool MailUseSSLConnection
	{
		[CompilerGenerated]
		get
		{
			return 녲놳;
		}
		[CompilerGenerated]
		private set
		{
			녲놳 = value;
		}
	}

	public string MailLogin
	{
		[CompilerGenerated]
		get
		{
			return 녲놺;
		}
		[CompilerGenerated]
		private set
		{
			녲놺 = value;
		}
	}

	public string MailPassword
	{
		[CompilerGenerated]
		get
		{
			return 녲놅;
		}
		[CompilerGenerated]
		private set
		{
			녲놅 = value;
		}
	}

	public int MailSMTPServerTimeout
	{
		[CompilerGenerated]
		get
		{
			return 녲녜;
		}
		[CompilerGenerated]
		private set
		{
			녲녜 = value;
		}
	}

	public string MailSMTPServer
	{
		[CompilerGenerated]
		get
		{
			return 녲뇃;
		}
		[CompilerGenerated]
		private set
		{
			녲뇃 = value;
		}
	}

	public int MailSMTPPort
	{
		[CompilerGenerated]
		get
		{
			return 녲녯;
		}
		[CompilerGenerated]
		private set
		{
			녲녯 = value;
		}
	}

	public IList<SettingItem> Settings
	{
		get
		{
			List<SettingItem> list = new List<SettingItem>();
			list.Add(new SettingItemBoolean(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녪(), MailUseSSLConnection)
			{
				Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녶(),
				SortIndex = 10
			});
			if (MailLogin != null)
			{
				list.Add(new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녵(), MailLogin)
				{
					Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놭(),
					SortIndex = 30
				});
			}
			if (MailPassword != null)
			{
				list.Add(new SettingItemPassword(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녲(), new PasswordHolder(MailPassword, SavePassword: true, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놇()))
				{
					Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲뇋(),
					SortIndex = 40
				});
			}
			list.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놸(), MailSMTPServerTimeout)
			{
				Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놿(),
				SortIndex = 50,
				Minimum = 0,
				Maximum = int.MaxValue,
				Increment = 1
			});
			if (MailSMTPServer != null)
			{
				list.Add(new SettingItemString(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놄(), MailSMTPServer)
				{
					Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놰(),
					SortIndex = 70
				});
			}
			list.Add(new SettingItemInteger(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놓(), MailSMTPPort)
			{
				Text = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놇(),
				SortIndex = 80,
				Minimum = 0,
				Maximum = int.MaxValue,
				Increment = 1
			});
			return list;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			foreach (SettingItem value2 in new SettingsHolder(value).Values)
			{
				string name = value2.Name;
				if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녪()))
				{
					if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녵()))
					{
						if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녲()))
						{
							if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놸()))
							{
								if (!(name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놄()))
								{
									if (name == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놓())
									{
										MailSMTPPort = (int)value2.Value;
									}
								}
								else
								{
									MailSMTPServer = (string)value2.Value;
								}
							}
							else
							{
								MailSMTPServerTimeout = (int)value2.Value;
							}
						}
						else
						{
							MailPassword = (value2.Value as PasswordHolder).Password;
						}
					}
					else
					{
						MailLogin = (string)value2.Value;
					}
				}
				else
				{
					MailUseSSLConnection = (bool)value2.Value;
				}
			}
		}
	}

	private void 녴(EmailParameters P_0)
	{
		EmailSendCompletedResult emailSendCompletedResult = new EmailSendCompletedResult();
		MailMessage mailMessage = new MailMessage();
		SmtpClient smtpClient = null;
		try
		{
			if (string.IsNullOrEmpty(MailLogin))
			{
				throw new ArgumentException(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녒());
			}
			mailMessage.From = new MailAddress(MailLogin);
			mailMessage.Subject = P_0.subject;
			if (P_0.address != null)
			{
				string[] address = P_0.address;
				foreach (string addresses in address)
				{
					mailMessage.To.Add(addresses);
				}
			}
			AlternateView item = AlternateView.CreateAlternateViewFromString(P_0.text, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녕());
			string text = P_0.text;
			if (text != null)
			{
				text = text.Replace(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂뇍(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녖());
				text = text.Replace(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녴(), _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놭녖());
			}
			if (P_0.fileNames != null)
			{
				if (!P_0.asFile)
				{
					text += _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놴();
					for (int j = 0; j < P_0.fileNames.Length; j++)
					{
						text = text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놂() + j + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놎();
					}
					AlternateView alternateView = AlternateView.CreateAlternateViewFromString(text, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녞());
					for (int k = 0; k < P_0.fileNames.Length; k++)
					{
						if (P_0.fileNames[k] != null)
						{
							LinkedResource linkedResource = new LinkedResource(P_0.fileNames[k]);
							linkedResource.ContentId = _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲놫() + k;
							alternateView.LinkedResources.Add(linkedResource);
						}
					}
					mailMessage.AlternateViews.Add(item);
					mailMessage.AlternateViews.Add(alternateView);
				}
				else
				{
					mailMessage.AlternateViews.Add(item);
					string[] address = P_0.fileNames;
					foreach (string fileName in address)
					{
						mailMessage.Attachments.Add(new Attachment(fileName));
					}
				}
			}
			else
			{
				AlternateView item2 = AlternateView.CreateAlternateViewFromString(text, null, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녲녞());
				mailMessage.AlternateViews.Add(item);
				mailMessage.AlternateViews.Add(item2);
			}
			smtpClient = new SmtpClient(MailSMTPServer)
			{
				Credentials = new NetworkCredential(mailMessage.From.Address, MailPassword),
				EnableSsl = MailUseSSLConnection,
				Port = MailSMTPPort,
				Timeout = MailSMTPServerTimeout
			};
			smtpClient.Send(mailMessage);
			emailSendCompletedResult.Status = EmailSendCompletedStatus.Success;
		}
		catch (Exception error)
		{
			emailSendCompletedResult.SetError(error);
		}
		finally
		{
			mailMessage?.Dispose();
			smtpClient?.Dispose();
			P_0.callBack?.Invoke(emailSendCompletedResult);
		}
	}

	/// <summary>
	/// Отправит сообщение по E-mail
	/// </summary>
	public void SendAsync(EmailParameters parameters)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				녴(parameters);
			}
			catch (Exception error)
			{
				if (parameters.callBack != null)
				{
					EmailSendCompletedResult emailSendCompletedResult = new EmailSendCompletedResult();
					emailSendCompletedResult.SetError(error);
					parameters.callBack(emailSendCompletedResult);
				}
			}
		});
	}

	internal void 녴()
	{
	}
}
