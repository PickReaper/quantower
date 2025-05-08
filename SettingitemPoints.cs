using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using _003CPrivateImplementationDetails_003E_007B32439FAB_002DE055_002D4B6F_002D932A_002DAD6005671EA2_007D;
using TradingPlatform.BusinessLayer.Serialization;

namespace TradingPlatform.BusinessLayer;

public class SettingitemPoints : SettingItem
{
	[CompilerGenerated]
	private int 놃뇏;

	[CompilerGenerated]
	private Func<double, VariableTick> 놃녻;

	[CompilerGenerated]
	private bool 놃녙;

	public override SettingItemType Type => SettingItemType.DrawingPoints;

	public int PointsInitialized
	{
		[CompilerGenerated]
		get
		{
			return 놃뇏;
		}
		[CompilerGenerated]
		set
		{
			놃뇏 = value;
		}
	}

	public Func<double, VariableTick> FindVariableTick
	{
		[CompilerGenerated]
		get
		{
			return 놃녻;
		}
		[CompilerGenerated]
		set
		{
			놃녻 = value;
		}
	}

	public bool EnablePriceSelection
	{
		[CompilerGenerated]
		get
		{
			return 놃녙;
		}
		[CompilerGenerated]
		set
		{
			놃녙 = value;
		}
	}

	public SettingitemPoints()
	{
	}

	public SettingitemPoints(string name, double[][] Points, int sortIndex = 0)
		: base(name, Points, sortIndex)
	{
		EnablePriceSelection = true;
		Value = 녴(Points);
	}

	private SettingitemPoints(SettingitemPoints P_0)
	{
		EnablePriceSelection = P_0.EnablePriceSelection;
		Value = 녴((double[][])P_0.value);
	}

	public override SettingItem GetCopy()
	{
		return new SettingitemPoints(this);
	}

	protected override bool IsValueTypeValid(object value)
	{
		return value is double[][];
	}

	protected override XElement ValueToXElement()
	{
		double[][] array = (double[][])Value;
		XElement xElement = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녓());
		xElement.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놰(), array.Length));
		XElement xElement2 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녛());
		double[][] array2 = array;
		foreach (double[] array3 in array2)
		{
			XElement xElement3 = new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녽());
			xElement3.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇈(), array3[0]));
			xElement3.Add(new XElement(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰(), array3[1]));
			xElement2.Add(xElement3);
		}
		xElement.Add(xElement2);
		return xElement;
	}

	protected override void ValueFromXElement(XElement element, DeserializationInfo deserializationInfo)
	{
		XElement? xElement = element.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녓());
		int level = xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놿놰()).ToInt();
		double[][] array = InitPoints(level);
		int num = 0;
		foreach (XElement item in xElement.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.놰녛()).Elements())
		{
			array[num][0] = item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶뇈()).ToDouble();
			array[num][1] = item.Element(_26195AC7_002DD65B_002D4910_002DB963_002D637D18805E71.녶녰()).ToDouble();
			num++;
		}
		value = array;
	}

	protected double[][] InitPoints(int level)
	{
		double[][] array = new double[level][];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new double[2];
		}
		return array;
	}

	private double[][] 녴(double[][] P_0)
	{
		double[][] array = InitPoints(P_0.Length);
		for (int i = 0; i < P_0.GetLength(0); i++)
		{
			double[] array2 = P_0[i];
			for (int j = 0; j < array2.Length; j++)
			{
				array[i][j] = array2[j];
			}
		}
		return array;
	}
}
