using System;
using System.Globalization;
using UnityEngine.UI;

// Token: 0x0200039D RID: 925
public class CustomEventEditorHandler_InputField : CustomEventEditorHandler
{
	// Token: 0x0600CEB1 RID: 52913 RVA: 0x004A303C File Offset: 0x004A123C
	public override void LCGMHCBNCDM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IILBHOFEMOE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("UNDISTORT"))
		{
			this.input.contentType = InputField.ContentType.Name;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEB2 RID: 52914 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string CDDLMMAOLPM()
	{
		return this.input.text;
	}

	// Token: 0x0600CEB3 RID: 52915 RVA: 0x004A30F8 File Offset: 0x004A12F8
	public virtual void GDJMBJEAPHM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_Value6"))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEB4 RID: 52916 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string KPIMHLOCOHD()
	{
		return this.input.text;
	}

	// Token: 0x0600CEB5 RID: 52917 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string PHKMIPMABOA()
	{
		return this.input.text;
	}

	// Token: 0x0600CEB6 RID: 52918 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string EPKBPPPMMGA()
	{
		return this.input.text;
	}

	// Token: 0x0600CEB7 RID: 52919 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string EAKMDIFDOIK()
	{
		return this.input.text;
	}

	// Token: 0x0600CEB8 RID: 52920 RVA: 0x004A31A8 File Offset: 0x004A13A8
	public virtual void KDJHONILJGK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(" respawn: "))
		{
			this.input.contentType = InputField.ContentType.Alphanumeric;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEB9 RID: 52921 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string LKPFPOKDMHE()
	{
		return this.input.text;
	}

	// Token: 0x0600CEBA RID: 52922 RVA: 0x004A3258 File Offset: 0x004A1458
	public override void FCKLLMEPONC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_Visualize"))
		{
			this.input.contentType = InputField.ContentType.Name;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEBB RID: 52923 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string HJAAJGAPBPJ()
	{
		return this.input.text;
	}

	// Token: 0x0600CEBC RID: 52924 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string FAFMEBBDEHC()
	{
		return this.input.text;
	}

	// Token: 0x0600CEBD RID: 52925 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string GNGBEIGIOKI()
	{
		return this.input.text;
	}

	// Token: 0x0600CEBE RID: 52926 RVA: 0x004A3308 File Offset: 0x004A1508
	public virtual void EEKAJCCELHK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("#ok"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEBF RID: 52927 RVA: 0x004A33B8 File Offset: 0x004A15B8
	public virtual void LILOGPDPFDA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("settings.gamemessagesduration"))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC0 RID: 52928 RVA: 0x004A3468 File Offset: 0x004A1668
	public virtual void AOEEOKNJDCK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("true"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC1 RID: 52929 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string HDGHDBKDGIB()
	{
		return this.input.text;
	}

	// Token: 0x0600CEC2 RID: 52930 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string EGFKNGIBFFD()
	{
		return this.input.text;
	}

	// Token: 0x0600CEC3 RID: 52931 RVA: 0x004A3518 File Offset: 0x004A1718
	public virtual void IFGOHEOEGKH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_DistortionLevel"))
		{
			this.input.contentType = InputField.ContentType.Alphanumeric;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC4 RID: 52932 RVA: 0x004A35C8 File Offset: 0x004A17C8
	public virtual void EJLKPLOEEEP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PMAGMPCMGPB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("NEW_ACHIEVEMENT_1_"))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC5 RID: 52933 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string HAAMIOGFPGI()
	{
		return this.input.text;
	}

	// Token: 0x0600CEC6 RID: 52934 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string OGMDNAALGKK()
	{
		return this.input.text;
	}

	// Token: 0x0600CEC7 RID: 52935 RVA: 0x004A3678 File Offset: 0x004A1878
	public virtual void BKEFJPOHKDE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("VisionBlur"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC8 RID: 52936 RVA: 0x004A3728 File Offset: 0x004A1928
	public virtual void DPOELEBIAOE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EFEONCCCKNP(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("MouseX"))
		{
			this.input.contentType = InputField.ContentType.Autocorrected;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, (NumberStyles)(-1), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEC9 RID: 52937 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string LJPBCJOKGJL()
	{
		return this.input.text;
	}

	// Token: 0x0600CECA RID: 52938 RVA: 0x004A37D8 File Offset: 0x004A19D8
	public virtual void LBICLFNOLAK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BECBCECGHPA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("maps."))
		{
			this.input.contentType = InputField.ContentType.EmailAddress;
			float num = float.Parse(this.advParametrs[0], NumberStyles.None, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CECB RID: 52939 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string IJADNOMAEHD()
	{
		return this.input.text;
	}

	// Token: 0x0600CECC RID: 52940 RVA: 0x004A3888 File Offset: 0x004A1A88
	public virtual void EIPPDLDJJGO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(" isOwnerActive: "))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CECD RID: 52941 RVA: 0x004A3938 File Offset: 0x004A1B38
	public override void IKLAFGHCELK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.JJFLHFCBENC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory."))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CECE RID: 52942 RVA: 0x004A39E8 File Offset: 0x004A1BE8
	public override void PJILLPKFCPO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("#yes"))
		{
			this.input.contentType = InputField.ContentType.Autocorrected;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CECF RID: 52943 RVA: 0x004A3A98 File Offset: 0x004A1C98
	public override void LMHFEBCKPDI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LMHFEBCKPDI(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_TimeX"))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CED0 RID: 52944 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string KDDBDAAEALD()
	{
		return this.input.text;
	}

	// Token: 0x0600CED1 RID: 52945 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string MFDFEBJDFBI()
	{
		return this.input.text;
	}

	// Token: 0x0600CED2 RID: 52946 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string MMNKKFCFDPI()
	{
		return this.input.text;
	}

	// Token: 0x0600CED3 RID: 52947 RVA: 0x004A3B48 File Offset: 0x004A1D48
	public virtual void LLAHPNGMEOO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(". We have no such PhotonView! Ignored this if you're leaving a room. State: "))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CED4 RID: 52948 RVA: 0x004A3BF8 File Offset: 0x004A1DF8
	public virtual void GCNKIJDNPMD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("MapConfig"))
		{
			this.input.contentType = InputField.ContentType.Password;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CED5 RID: 52949 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string MHGPJEGKLGF()
	{
		return this.input.text;
	}

	// Token: 0x0600CED6 RID: 52950 RVA: 0x004A3CA8 File Offset: 0x004A1EA8
	public virtual void DDKHMCOOCPA(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.BFMEBNFGCEA(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("help"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CED7 RID: 52951 RVA: 0x004A3D58 File Offset: 0x004A1F58
	public virtual void MIAIEKCLEAO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PIEPPKMBJHI(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("Ignored PU RPC, cause item is inactive. "))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CED8 RID: 52952 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string HHEGFIMAGLG()
	{
		return this.input.text;
	}

	// Token: 0x0600CED9 RID: 52953 RVA: 0x004A3E08 File Offset: 0x004A2008
	public override void IFINBHBFCBB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.OCCJCGEDNEH(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("Joystick1Button10"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEDA RID: 52954 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string KNFDHLOFAFI()
	{
		return this.input.text;
	}

	// Token: 0x0600CEDB RID: 52955 RVA: 0x004A3EB8 File Offset: 0x004A20B8
	public virtual void KJBJBNGJDAD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PGKFCCIKFPK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("LostLive"))
		{
			this.input.contentType = InputField.ContentType.Password;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEDC RID: 52956 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string KCJBOIGBADB()
	{
		return this.input.text;
	}

	// Token: 0x0600CEDD RID: 52957 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string NHIMLBNJMOO()
	{
		return this.input.text;
	}

	// Token: 0x0600CEDE RID: 52958 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string GNPEIEBDFPB()
	{
		return this.input.text;
	}

	// Token: 0x0600CEDF RID: 52959 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string ILJFLOAAJDJ()
	{
		return this.input.text;
	}

	// Token: 0x0600CEE0 RID: 52960 RVA: 0x004A3F68 File Offset: 0x004A2168
	public virtual void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_PrefilterOffs"))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE1 RID: 52961 RVA: 0x004A4018 File Offset: 0x004A2218
	public virtual void NNFJJJLBPKE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EBMNMBNJDMK(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_ScreenResolution"))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE2 RID: 52962 RVA: 0x004A40C8 File Offset: 0x004A22C8
	public virtual void LHIEKHPLMFI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AKMLEJJBBNG(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(" argument(s): "))
		{
			this.input.contentType = InputField.ContentType.Alphanumeric;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE3 RID: 52963 RVA: 0x004A4178 File Offset: 0x004A2378
	public override void POGJLIDHDIH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.GCGIMJEIKHM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(": "))
		{
			this.input.contentType = InputField.ContentType.Autocorrected;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE4 RID: 52964 RVA: 0x004A4228 File Offset: 0x004A2428
	public override void LHAENMGOBMM(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NKLCNJEIAFB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_Green_R"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE5 RID: 52965 RVA: 0x004A42D8 File Offset: 0x004A24D8
	public virtual void CAJFKNFJEKC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("settings.cameramovements"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE6 RID: 52966 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string NPJNDLHDDJE()
	{
		return this.input.text;
	}

	// Token: 0x0600CEE7 RID: 52967 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string NCKBLEFJJGL()
	{
		return this.input.text;
	}

	// Token: 0x0600CEE8 RID: 52968 RVA: 0x004A4388 File Offset: 0x004A2588
	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.Init(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("float"))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[1], NumberStyles.Float, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEE9 RID: 52969 RVA: 0x004A4438 File Offset: 0x004A2638
	public virtual void FECMEIJGLJI(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.IFINBHBFCBB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("skin.hit_perfect"))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEEA RID: 52970 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string OOEGMHJAGFI()
	{
		return this.input.text;
	}

	// Token: 0x0600CEEB RID: 52971 RVA: 0x004A44E8 File Offset: 0x004A26E8
	public override void PMAGMPCMGPB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FEJAAGGMBOE(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("InputField"))
		{
			this.input.contentType = InputField.ContentType.EmailAddress;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEEC RID: 52972 RVA: 0x004A4598 File Offset: 0x004A2798
	public virtual void NBIEIGBAKND(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.PJILLPKFCPO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("Texture2"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEED RID: 52973 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string IBAOBHIBDPF()
	{
		return this.input.text;
	}

	// Token: 0x0600CEEE RID: 52974 RVA: 0x004A4648 File Offset: 0x004A2848
	public virtual void CMFBCPNHGOF(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains(","))
		{
			this.input.contentType = InputField.ContentType.EmailAddress;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEEF RID: 52975 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string AMFEJANGGIN()
	{
		return this.input.text;
	}

	// Token: 0x0600CEF0 RID: 52976 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string GetEditedData()
	{
		return this.input.text;
	}

	// Token: 0x0600CEF1 RID: 52977 RVA: 0x004A46F8 File Offset: 0x004A28F8
	public virtual void OCHADIJNDJK(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.NDEDAEFLELO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("settings.volume.menu"))
		{
			this.input.contentType = InputField.ContentType.IntegerNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEF2 RID: 52978 RVA: 0x004A47A8 File Offset: 0x004A29A8
	public virtual void CPJHNDOBFOD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FCKLLMEPONC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("curScn"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEF4 RID: 52980 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string OFJEIDELJJH()
	{
		return this.input.text;
	}

	// Token: 0x0600CEF5 RID: 52981 RVA: 0x004A4858 File Offset: 0x004A2A58
	public virtual void LKEPIEEIMAE(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.ALGKENJGNLL(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("Clear Environment"))
		{
			this.input.contentType = InputField.ContentType.Name;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEF6 RID: 52982 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string IGDMJNHEMKN()
	{
		return this.input.text;
	}

	// Token: 0x0600CEF7 RID: 52983 RVA: 0x004A4908 File Offset: 0x004A2B08
	public override void JJFLHFCBENC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FCKLLMEPONC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("y"))
		{
			this.input.contentType = InputField.ContentType.Name;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEF8 RID: 52984 RVA: 0x004A49B8 File Offset: 0x004A2BB8
	public override void OCCJCGEDNEH(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("EventMenu"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEF9 RID: 52985 RVA: 0x004A4A68 File Offset: 0x004A2C68
	public virtual void KOKDPAEJECC(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("CameraFilterPack/Blend2Camera_Darken"))
		{
			this.input.contentType = InputField.ContentType.Pin;
			float num = float.Parse(this.advParametrs[0], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEFA RID: 52986 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string DONGDGHKCKK()
	{
		return this.input.text;
	}

	// Token: 0x0600CEFB RID: 52987 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string BKNPEBIOFOE()
	{
		return this.input.text;
	}

	// Token: 0x0600CEFC RID: 52988 RVA: 0x004A4B18 File Offset: 0x004A2D18
	public virtual void JLMPMMFKJID(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.AAPGPJCNIAO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("SetSunEmission"))
		{
			this.input.contentType = InputField.ContentType.Password;
			float num = float.Parse(this.advParametrs[1], NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEFD RID: 52989 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string MBGCIIMEKLF()
	{
		return this.input.text;
	}

	// Token: 0x0600CEFE RID: 52990 RVA: 0x004A4BC8 File Offset: 0x004A2DC8
	public virtual void BKLCHHKOMLD(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.EGDGHGOGEHB(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("time"))
		{
			this.input.contentType = InputField.ContentType.DecimalNumber;
			float num = float.Parse(this.advParametrs[0], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent, NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CEFF RID: 52991 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string ICEKNBOAIOL()
	{
		return this.input.text;
	}

	// Token: 0x0600CF00 RID: 52992 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string FIDINOJKJLH()
	{
		return this.input.text;
	}

	// Token: 0x0600CF01 RID: 52993 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public override string ADONGBFFCPP()
	{
		return this.input.text;
	}

	// Token: 0x0600CF02 RID: 52994 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string HDAECKJBNCG()
	{
		return this.input.text;
	}

	// Token: 0x0600CF03 RID: 52995 RVA: 0x004A4C78 File Offset: 0x004A2E78
	public override void FFBDGOBNNCO(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.FFBDGOBNNCO(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("] "))
		{
			this.input.contentType = InputField.ContentType.Name;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CF04 RID: 52996 RVA: 0x004A4D28 File Offset: 0x004A2F28
	public override void NKLCNJEIAFB(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.MHPFCAFDMLC(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("w"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CF05 RID: 52997 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string OLBAGEGOEKF()
	{
		return this.input.text;
	}

	// Token: 0x0600CF06 RID: 52998 RVA: 0x004A4DD8 File Offset: 0x004A2FD8
	public virtual void CFNDDGFGKKG(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		base.LHAENMGOBMM(NOJGGCLPPAM, BNPGLCAHPDL);
		if (this.advParametrs.Contains("_MatrixSize"))
		{
			this.input.contentType = InputField.ContentType.Standard;
			float num = float.Parse(this.advParametrs[1], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), NumberFormatInfo.InvariantInfo);
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				float.TryParse(NOJGGCLPPAM, ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint), NumberFormatInfo.InvariantInfo, out num);
			}
			this.input.text = string.Empty + num;
		}
		else
		{
			this.input.text = ((!string.IsNullOrEmpty(NOJGGCLPPAM)) ? NOJGGCLPPAM : BNPGLCAHPDL);
		}
	}

	// Token: 0x0600CF07 RID: 52999 RVA: 0x004A30E9 File Offset: 0x004A12E9
	public virtual string INHOEPEBFNM()
	{
		return this.input.text;
	}

	// Token: 0x040017EB RID: 6123
	public InputField input;
}
