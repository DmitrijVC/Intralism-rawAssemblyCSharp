using System;
using System.Globalization;
using UnityEngine.UI;

// Token: 0x0200039E RID: 926
public class CustomEventEditorHandler_Slider : CustomEventEditorHandler
{
	// Token: 0x0600CF08 RID: 53000 RVA: 0x004A4E85 File Offset: 0x004A3085
	public virtual string MBGCIIMEKLF()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF09 RID: 53001 RVA: 0x004A4EA4 File Offset: 0x004A30A4
	public virtual void PFMJPIJONIP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NDEDAEFLELO(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 52f;
		float maxValue = 814f;
		bool wholeNumbers = true;
		string cutFormat = "_SampleScale";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[4], out wholeNumbers);
		if (this.advParametrs.Count > 5)
		{
			cutFormat = this.advParametrs[1];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 646f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF0A RID: 53002 RVA: 0x004A4F9C File Offset: 0x004A319C
	public virtual void NFKDBPGHHIJ(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1648f;
		float maxValue = 86f;
		bool wholeNumbers = false;
		string cutFormat = "_SubsampleIndices";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[4], out wholeNumbers);
		if (this.advParametrs.Count > 2)
		{
			cutFormat = this.advParametrs[5];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 273f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF0B RID: 53003 RVA: 0x004A4E85 File Offset: 0x004A3085
	public virtual string HJAAJGAPBPJ()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF0C RID: 53004 RVA: 0x004A4E85 File Offset: 0x004A3085
	public virtual string IJADNOMAEHD()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF0D RID: 53005 RVA: 0x004A5094 File Offset: 0x004A3294
	public override void FEJAAGGMBOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 81f;
		float maxValue = 751f;
		bool wholeNumbers = false;
		string cutFormat = " evLeave: ";
		float.TryParse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[1], out wholeNumbers);
		if (this.advParametrs.Count > 2)
		{
			cutFormat = this.advParametrs[0];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 809f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF0E RID: 53006 RVA: 0x004A518C File Offset: 0x004A338C
	public virtual void KDJHONILJGK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 529f;
		float maxValue = 339f;
		bool wholeNumbers = false;
		string cutFormat = "UseScanLineSize";
		float.TryParse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[0], out wholeNumbers);
		if (this.advParametrs.Count > 3)
		{
			cutFormat = this.advParametrs[4];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1966f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF0F RID: 53007 RVA: 0x004A5284 File Offset: 0x004A3484
	public virtual void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.OPOOIKOKCGN(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1979f;
		float maxValue = 562f;
		bool wholeNumbers = true;
		string cutFormat = "FavoriteButton";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[8], out wholeNumbers);
		if (this.advParametrs.Count > 8)
		{
			cutFormat = this.advParametrs[2];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 216f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF10 RID: 53008 RVA: 0x004A4E85 File Offset: 0x004A3085
	public override string EKPAILIFEJK()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF11 RID: 53009 RVA: 0x004A537C File Offset: 0x004A357C
	public virtual void FECMEIJGLJI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 892f;
		float maxValue = 1081f;
		bool wholeNumbers = true;
		string cutFormat = "MapConfig";
		float.TryParse(this.advParametrs[0], (NumberStyles)(-1), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[4], out wholeNumbers);
		if (this.advParametrs.Count > 8)
		{
			cutFormat = this.advParametrs[6];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 267f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF12 RID: 53010 RVA: 0x004A5474 File Offset: 0x004A3674
	public virtual void ALKBNPMCEOM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 424f;
		float maxValue = 861f;
		bool wholeNumbers = false;
		string cutFormat = "_TimeX";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[7], out wholeNumbers);
		if (this.advParametrs.Count > 1)
		{
			cutFormat = this.advParametrs[0];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 154f;
		float.TryParse(NOJGGCLPPAM, ~NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF13 RID: 53011 RVA: 0x004A556C File Offset: 0x004A376C
	public override void JJFLHFCBENC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1017f;
		float maxValue = 1277f;
		bool wholeNumbers = true;
		string cutFormat = "???";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[4], out wholeNumbers);
		if (this.advParametrs.Count > 3)
		{
			cutFormat = this.advParametrs[8];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 88f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF14 RID: 53012 RVA: 0x004A4E85 File Offset: 0x004A3085
	public override string NPJNDLHDDJE()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF15 RID: 53013 RVA: 0x004A5664 File Offset: 0x004A3864
	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 0f;
		float maxValue = 1f;
		bool wholeNumbers = false;
		string cutFormat = "0.00";
		float.TryParse(this.advParametrs[0], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[2], out wholeNumbers);
		if (this.advParametrs.Count > 3)
		{
			cutFormat = this.advParametrs[3];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 0f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF16 RID: 53014 RVA: 0x004A575C File Offset: 0x004A395C
	public virtual void LILOGPDPFDA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LCGMHCBNCDM(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 400f;
		float maxValue = 854f;
		bool wholeNumbers = false;
		string cutFormat = "LoadMapCanvas";
		float.TryParse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[3], out wholeNumbers);
		if (this.advParametrs.Count > 8)
		{
			cutFormat = this.advParametrs[5];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1508f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF17 RID: 53015 RVA: 0x004A4E85 File Offset: 0x004A3085
	public override string HBPJJBALHDO()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF18 RID: 53016 RVA: 0x004A5854 File Offset: 0x004A3A54
	public virtual void CMFBCPNHGOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 730f;
		float maxValue = 1982f;
		bool wholeNumbers = true;
		string cutFormat = "A";
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[7], out wholeNumbers);
		if (this.advParametrs.Count > 2)
		{
			cutFormat = this.advParametrs[0];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1740f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF19 RID: 53017 RVA: 0x004A594C File Offset: 0x004A3B4C
	public virtual void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AEIMOFGABJG(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1207f;
		float maxValue = 1867f;
		bool wholeNumbers = true;
		string cutFormat = ">";
		float.TryParse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[1], out wholeNumbers);
		if (this.advParametrs.Count > 4)
		{
			cutFormat = this.advParametrs[4];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1166f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF1A RID: 53018 RVA: 0x004A4E85 File Offset: 0x004A3085
	public virtual string ILJFLOAAJDJ()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF1B RID: 53019 RVA: 0x004A4E85 File Offset: 0x004A3085
	public override string GetEditedData()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF1D RID: 53021 RVA: 0x004A5A44 File Offset: 0x004A3C44
	public virtual void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PIEPPKMBJHI(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1387f;
		float maxValue = 130f;
		bool wholeNumbers = false;
		string cutFormat = "SetSunLerpSpeed";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[6], out wholeNumbers);
		if (this.advParametrs.Count > 4)
		{
			cutFormat = this.advParametrs[1];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 788f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF1E RID: 53022 RVA: 0x004A5B3C File Offset: 0x004A3D3C
	public virtual void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IMJLEAJNBAF(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1129f;
		float maxValue = 731f;
		bool wholeNumbers = true;
		string cutFormat = "mapselector.filter.rateduponly";
		float.TryParse(this.advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[4], out wholeNumbers);
		if (this.advParametrs.Count > 6)
		{
			cutFormat = this.advParametrs[0];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 292f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF1F RID: 53023 RVA: 0x004A5C34 File Offset: 0x004A3E34
	public virtual void KJBJBNGJDAD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1991f;
		float maxValue = 97f;
		bool wholeNumbers = false;
		string cutFormat = "PUN-instantiated '";
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[6], out wholeNumbers);
		if (this.advParametrs.Count > 0)
		{
			cutFormat = this.advParametrs[3];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1439f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF20 RID: 53024 RVA: 0x004A5D2C File Offset: 0x004A3F2C
	public virtual void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 343f;
		float maxValue = 1663f;
		bool wholeNumbers = false;
		string cutFormat = "_HalfResolution";
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[7], out wholeNumbers);
		if (this.advParametrs.Count > 1)
		{
			cutFormat = this.advParametrs[5];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1702f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF21 RID: 53025 RVA: 0x004A5E24 File Offset: 0x004A4024
	public override void PJILLPKFCPO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1415f;
		float maxValue = 1529f;
		bool wholeNumbers = true;
		string cutFormat = "_BlurParams";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[2], out wholeNumbers);
		if (this.advParametrs.Count > 7)
		{
			cutFormat = this.advParametrs[1];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1201f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF22 RID: 53026 RVA: 0x004A5F1C File Offset: 0x004A411C
	public virtual void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1245f;
		float maxValue = 607f;
		bool wholeNumbers = true;
		string cutFormat = "_MainTex2";
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.Number, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[3], out wholeNumbers);
		if (this.advParametrs.Count > 2)
		{
			cutFormat = this.advParametrs[4];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1839f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF23 RID: 53027 RVA: 0x004A6014 File Offset: 0x004A4214
	public virtual void NBIEIGBAKND(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IFINBHBFCBB(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1523f;
		float maxValue = 236f;
		bool wholeNumbers = false;
		string cutFormat = "CameraFilterPack/Noise_TV_2";
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[0], out wholeNumbers);
		if (this.advParametrs.Count > 1)
		{
			cutFormat = this.advParametrs[5];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1127f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF24 RID: 53028 RVA: 0x004A610C File Offset: 0x004A430C
	public virtual void GGHCMPKGNGE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.ALGKENJGNLL(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 400f;
		float maxValue = 1791f;
		bool wholeNumbers = true;
		string cutFormat = "Joystick1Button9";
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[0], out wholeNumbers);
		if (this.advParametrs.Count > 1)
		{
			cutFormat = this.advParametrs[1];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 1242f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF25 RID: 53029 RVA: 0x004A6204 File Offset: 0x004A4404
	public virtual void MIAIEKCLEAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 378f;
		float maxValue = 527f;
		bool wholeNumbers = false;
		string cutFormat = "_TimeX";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[1], out wholeNumbers);
		if (this.advParametrs.Count > 1)
		{
			cutFormat = this.advParametrs[3];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 704f;
		float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF26 RID: 53030 RVA: 0x004A4E85 File Offset: 0x004A3085
	public override string FAFMEBBDEHC()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x0600CF27 RID: 53031 RVA: 0x004A62FC File Offset: 0x004A44FC
	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LCGMHCBNCDM(NOJGGCLPPAM, BNPGLCAHPDL);
		float minValue = 1429f;
		float maxValue = 1123f;
		bool wholeNumbers = true;
		string cutFormat = "ConnectToRegion: ";
		float.TryParse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out minValue);
		float.TryParse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out maxValue);
		bool.TryParse(this.advParametrs[2], out wholeNumbers);
		if (this.advParametrs.Count > 6)
		{
			cutFormat = this.advParametrs[4];
		}
		this.input.minValue = minValue;
		this.input.maxValue = maxValue;
		this.input.wholeNumbers = wholeNumbers;
		this.input.transform.GetComponentInChildren<SliderValueLabel>().cutFormat = cutFormat;
		float value = 507f;
		float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out value);
		this.input.value = value;
	}

	// Token: 0x0600CF28 RID: 53032 RVA: 0x004A4E85 File Offset: 0x004A3085
	public virtual string DONGDGHKCKK()
	{
		return string.Empty + this.input.value;
	}

	// Token: 0x040017EC RID: 6124
	public Slider input;
}
