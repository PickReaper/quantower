using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;

namespace TradingPlatform.BusinessLayer;

public static class ExceptionExtensions
{
	[CompilerGenerated]
	private sealed class 녴 : IEnumerable<Exception>, IEnumerable, IEnumerator<Exception>, IEnumerator, IDisposable
	{
		private int 놭놆;

		private Exception 놭뇎;

		private int 놭놷;

		private Exception 놭녗;

		public Exception 놭놜;

		private Exception 놭놨;

		Exception IEnumerator<Exception>.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇎;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return 놭뇎;
			}
		}

		[DebuggerHidden]
		public 녴(int P_0)
		{
			놭놆 = P_0;
			놭놷 = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void 녴()
		{
			놭놨 = null;
			놭놆 = -2;
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 녴
			this.녴();
		}

		private bool MoveNext()
		{
			switch (놭놆)
			{
			default:
				return false;
			case 0:
				놭놆 = -1;
				놭놨 = 놭녗;
				break;
			case 1:
				놭놆 = -1;
				놭놨 = 놭놨.InnerException;
				break;
			}
			if (놭놨 != null)
			{
				놭뇎 = 놭놨;
				놭놆 = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private void 놴()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놴
			this.놴();
		}

		[DebuggerHidden]
		private IEnumerator<Exception> 놂()
		{
			녴 녴;
			if (놭놆 == -2 && 놭놷 == Environment.CurrentManagedThreadId)
			{
				놭놆 = 0;
				녴 = this;
			}
			else
			{
				녴 = new 녴(0);
			}
			녴.놭녗 = 놭놜;
			return 녴;
		}

		IEnumerator<Exception> IEnumerable<Exception>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놂
			return this.놂();
		}

		[DebuggerHidden]
		private IEnumerator 놎()
		{
			return 놂();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 놎
			return this.놎();
		}
	}

	public static string GetMessageRecursive(this Exception exception)
	{
		return exception?.InnerException?.GetMessageRecursive() ?? exception?.Message ?? string.Empty;
	}

	public static string GetFullMessageRecursive(this Exception exception)
	{
		StringBuilder stringBuilder = new StringBuilder(exception.Message);
		if (exception.InnerException != null)
		{
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(18, 1, stringBuilder2);
			handler.AppendLiteral(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놂녿());
			handler.AppendFormatted(exception.InnerException.GetFullMessageRecursive());
			stringBuilder2.Append(ref handler);
		}
		return stringBuilder.ToString();
	}

	[IteratorStateMachine(typeof(녴))]
	public static IEnumerable<Exception> GetInnerExceptionsRecursive(this Exception exception)
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new 녴(-2)
		{
			놭놜 = exception
		};
	}
}
