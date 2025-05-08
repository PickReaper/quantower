using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

[Published]
public class ClosePositionRequestParameters : TradingRequestParameters, ILoggable
{
	[CompilerGenerated]
	private Position 놵뇂;

	[CompilerGenerated]
	private double 놵놩;

	public override RequestType Type => RequestType.ClosePosition;

	public Position Position
	{
		[CompilerGenerated]
		get
		{
			return 놵뇂;
		}
		[CompilerGenerated]
		set
		{
			놵뇂 = value;
		}
	}

	public double CloseQuantity
	{
		[CompilerGenerated]
		get
		{
			return 놵놩;
		}
		[CompilerGenerated]
		set
		{
			놵놩 = value;
		}
	}

	public override string ConnectionId => Position?.Symbol?.ConnectionId;

	public override string Event => _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녲();

	public override string Message
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder3 = stringBuilder2;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(14, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿노());
			handler.AppendFormatted(Position.Connection.Name);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder3.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놸녞());
			handler.AppendFormatted(Position.Symbol.Name);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder4.Append(ref handler);
			string text = Core.Instance.CustomAccountPropertiesProvider.GetProperty(Position.Account, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놛()) as string;
			string value = (string.IsNullOrEmpty(text) ? Position.Account.Name : (Position.Account.Name + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녙() + text + _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놢()));
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder5 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녒());
			handler.AppendFormatted(value);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder5.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder6 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(12, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿녕());
			handler.AppendFormatted(Position.Symbol.FormatQuantity(Position.Quantity));
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder6.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder7 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(15, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄뇋());
			handler.AppendFormatted(Position.Id);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder7.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder8 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녴());
			handler.AppendFormatted(Position.Side);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder8.Append(ref handler);
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder9 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놼());
			handler.AppendFormatted(Position.Symbol.FormatPrice(Position.CurrentPrice));
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder9.Append(ref handler);
			Order stopLoss = Position.StopLoss;
			if (stopLoss != null)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder10 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녞());
				handler.AppendFormatted((stopLoss.OrderTypeId == _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녵뇊()) ? Position.Symbol.FormatOffset(stopLoss.TrailOffset, _26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놎놊()) : Position.Symbol.FormatPrice(stopLoss.Price));
				stringBuilder10.Append(ref handler);
			}
			Order takeProfit = Position.TakeProfit;
			if (takeProfit != null)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder11 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놫());
				handler.AppendFormatted(Position.Symbol.FormatPrice(takeProfit.Price));
				stringBuilder11.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder12 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녪());
			handler.AppendFormatted(Core.Instance.TimeUtils.DateTimeUtcNow.ToString());
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder12.Append(ref handler);
			if (!string.IsNullOrEmpty(base.SendingSource))
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder13 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(8, 1, stringBuilder2);
				handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녶());
				handler.AppendFormatted(base.SendingSource);
				stringBuilder13.Append(ref handler);
			}
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder14 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄녵());
			handler.AppendFormatted(base.RequestId);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놴());
			stringBuilder14.Append(ref handler);
			return stringBuilder.ToString();
		}
	}

	public ClosePositionRequestParameters()
	{
	}

	public ClosePositionRequestParameters(ClosePositionRequestParameters origin)
		: base(origin)
	{
		Position = origin.Position;
		CloseQuantity = origin.CloseQuantity;
	}

	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 3);
		defaultInterpolatedStringHandler.AppendFormatted(base.ToString());
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놄놭());
		defaultInterpolatedStringHandler.AppendFormatted(CloseQuantity);
		defaultInterpolatedStringHandler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂놀());
		defaultInterpolatedStringHandler.AppendFormatted(Position);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	protected override Account GetAccount()
	{
		return Position?.Account;
	}
}
