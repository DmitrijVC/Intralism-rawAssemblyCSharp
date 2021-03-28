using System;

// Token: 0x02000320 RID: 800
public class Region
{
	// Token: 0x0600B7AB RID: 47019 RVA: 0x00435524 File Offset: 0x00433724
	public static CloudRegionCode AEPBKPIOJEJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.us;
		}
		int num = EJHKMJOLONP.IndexOf('s');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	// Token: 0x0600B7AC RID: 47020 RVA: 0x00435587 File Offset: 0x00433787
	public override string ToString()
	{
		return string.Format("'{0}' \t{1}ms \t{2}", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7AD RID: 47021 RVA: 0x004355AA File Offset: 0x004337AA
	public virtual string NOOLCGNJDMM()
	{
		return string.Format("_Shadow", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7AE RID: 47022 RVA: 0x004355CD File Offset: 0x004337CD
	public virtual string BIJOMIMBEBL()
	{
		return string.Format("y", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7AF RID: 47023 RVA: 0x004355F0 File Offset: 0x004337F0
	public virtual string KDGLICFNLIE()
	{
		return string.Format("value", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7B0 RID: 47024 RVA: 0x00435614 File Offset: 0x00433814
	public static CloudRegionCode GBBOFINMPDE(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.us;
		}
		int num = EJHKMJOLONP.IndexOf('\u0011');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	// Token: 0x0600B7B1 RID: 47025 RVA: 0x00435678 File Offset: 0x00433878
	internal static CloudRegionFlag OGDFCJCFMHM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7B2 RID: 47026 RVA: 0x004356BC File Offset: 0x004338BC
	internal static CloudRegionFlag GGJHMHOBIDJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7B3 RID: 47027 RVA: 0x00435700 File Offset: 0x00433900
	internal static CloudRegionFlag AJAFBNKKBGK(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7B4 RID: 47028 RVA: 0x00435744 File Offset: 0x00433944
	internal static CloudRegionFlag BGBGOBANBOE(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7B5 RID: 47029 RVA: 0x00435787 File Offset: 0x00433987
	public virtual string AAGGLDPCFPF()
	{
		return string.Format("SpawnObj", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7B6 RID: 47030 RVA: 0x004357AC File Offset: 0x004339AC
	public static CloudRegionCode CJKLKFBMLCO(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('^');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.us;
	}

	// Token: 0x0600B7B7 RID: 47031 RVA: 0x00435810 File Offset: 0x00433A10
	internal static CloudRegionFlag PPJPIOHGDPI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7B8 RID: 47032 RVA: 0x00435861 File Offset: 0x00433A61
	public virtual string NGHDDAPEEHB()
	{
		return string.Format("Hex value #RRGGBB", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7B9 RID: 47033 RVA: 0x00435884 File Offset: 0x00433A84
	public virtual string ONMGBNBKPHD()
	{
		return string.Format("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7BA RID: 47034 RVA: 0x004358A8 File Offset: 0x00433AA8
	public static CloudRegionCode IAPELPAACFI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('s');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	// Token: 0x0600B7BB RID: 47035 RVA: 0x0043590C File Offset: 0x00433B0C
	internal static CloudRegionFlag DLDGELCJECA(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7BC RID: 47036 RVA: 0x00435950 File Offset: 0x00433B50
	public static CloudRegionCode POBAEHEAOPF(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('\u0003');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.us;
	}

	// Token: 0x0600B7BD RID: 47037 RVA: 0x004359B4 File Offset: 0x00433BB4
	public static CloudRegionCode ECEMJOBFMIM(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('8');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	// Token: 0x0600B7BE RID: 47038 RVA: 0x00435A17 File Offset: 0x00433C17
	public virtual string ENEOGOGJDBP()
	{
		return string.Format("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7BF RID: 47039 RVA: 0x00435A3C File Offset: 0x00433C3C
	internal static CloudRegionFlag CJBADGOCCDN(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7C0 RID: 47040 RVA: 0x00435A8D File Offset: 0x00433C8D
	public virtual string PILLKLPMOOH()
	{
		return string.Format("LT", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7C1 RID: 47041 RVA: 0x00435AB0 File Offset: 0x00433CB0
	internal static CloudRegionFlag EIPDMMHKPGO(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7C2 RID: 47042 RVA: 0x00435B04 File Offset: 0x00433D04
	internal static CloudRegionFlag HLNGKPHACHF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7C3 RID: 47043 RVA: 0x00435B55 File Offset: 0x00433D55
	public virtual string BIKPHEFOKOC()
	{
		return string.Format("error", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7C4 RID: 47044 RVA: 0x00435B78 File Offset: 0x00433D78
	public virtual string KAPOJCCKOLH()
	{
		return string.Format("speed", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7C5 RID: 47045 RVA: 0x00435B9C File Offset: 0x00433D9C
	internal static CloudRegionFlag EOLGDGINBNB(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7C6 RID: 47046 RVA: 0x00435BF0 File Offset: 0x00433DF0
	public static CloudRegionCode BGDOOLAGGFP(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf((char)-41);
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	// Token: 0x0600B7C7 RID: 47047 RVA: 0x00435C54 File Offset: 0x00433E54
	public static CloudRegionCode CKDKMICJADC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf((char)-13);
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	// Token: 0x0600B7C8 RID: 47048 RVA: 0x00435CB8 File Offset: 0x00433EB8
	public static CloudRegionCode PABOGEPAPNH(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('\0');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	// Token: 0x0600B7C9 RID: 47049 RVA: 0x00435D1B File Offset: 0x00433F1B
	public virtual string KHOEEKGDNOM()
	{
		return string.Format("_Distortion", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7CA RID: 47050 RVA: 0x00435D3E File Offset: 0x00433F3E
	public virtual string INLHLHDMHNK()
	{
		return string.Format("sounds/hit_wrong", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7CB RID: 47051 RVA: 0x00435D64 File Offset: 0x00433F64
	internal static CloudRegionFlag PEECIJIGOKD(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7CC RID: 47052 RVA: 0x00435DB8 File Offset: 0x00433FB8
	internal static CloudRegionFlag FHNAMHDHMLF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7CD RID: 47053 RVA: 0x00435DFC File Offset: 0x00433FFC
	internal static CloudRegionFlag HNGGFKOKEAM(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7CE RID: 47054 RVA: 0x00435E50 File Offset: 0x00434050
	public static CloudRegionCode EOCMPOLKONB(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf((char)-43);
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	// Token: 0x0600B7CF RID: 47055 RVA: 0x00435EB4 File Offset: 0x004340B4
	internal static CloudRegionFlag HAPCADLMCME(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7D0 RID: 47056 RVA: 0x00435F08 File Offset: 0x00434108
	internal static CloudRegionFlag FIDANGJOCEG(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7D1 RID: 47057 RVA: 0x00435F5C File Offset: 0x0043415C
	internal static CloudRegionFlag ANCLMFHDGMF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7D2 RID: 47058 RVA: 0x00435FA0 File Offset: 0x004341A0
	internal static CloudRegionFlag IKBNKIFACEA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7D3 RID: 47059 RVA: 0x00435FF1 File Offset: 0x004341F1
	public virtual string NBADDMBFLNP()
	{
		return string.Format("action", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7D4 RID: 47060 RVA: 0x00436014 File Offset: 0x00434214
	internal static CloudRegionFlag HFKCAELGDBN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7D5 RID: 47061 RVA: 0x00436058 File Offset: 0x00434258
	[Obsolete]
	internal static CloudRegionFlag JFBLMOGHMPF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7D6 RID: 47062 RVA: 0x0043609C File Offset: 0x0043429C
	public static CloudRegionCode FNBNKIOMNKH(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.usw;
		}
		int num = EJHKMJOLONP.IndexOf('_');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	// Token: 0x0600B7D7 RID: 47063 RVA: 0x004360FF File Offset: 0x004342FF
	public virtual string FLJBCAOHMMN()
	{
		return string.Format("offsets", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7D8 RID: 47064 RVA: 0x00436124 File Offset: 0x00434324
	public static CloudRegionCode PHFOOCOEJEM(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf((char)-32);
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.au;
	}

	// Token: 0x0600B7D9 RID: 47065 RVA: 0x00436187 File Offset: 0x00434387
	public virtual string BANNBMDODBJ()
	{
		return string.Format("settings.enableranking", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7DA RID: 47066 RVA: 0x004361AA File Offset: 0x004343AA
	public virtual string NJFCPBFAKNL()
	{
		return string.Format("EventData0DropDownList", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7DB RID: 47067 RVA: 0x004361CD File Offset: 0x004343CD
	public Region(CloudRegionCode JFNKDGKEAEA)
	{
		this.Code = JFNKDGKEAEA;
		this.Cluster = JFNKDGKEAEA.ToString();
	}

	// Token: 0x0600B7DC RID: 47068 RVA: 0x004361F0 File Offset: 0x004343F0
	internal static CloudRegionFlag JDPKCOCOPIA(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7DD RID: 47069 RVA: 0x00436234 File Offset: 0x00434434
	internal static CloudRegionFlag BOHJEGCDFON(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7DE RID: 47070 RVA: 0x00436277 File Offset: 0x00434477
	public virtual string BEKGOMJHHND()
	{
		return string.Format("CameraFilterPack/Drawing_Manga_Flash", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7DF RID: 47071 RVA: 0x0043629C File Offset: 0x0043449C
	internal static CloudRegionFlag JPIMJHDCFFA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7E0 RID: 47072 RVA: 0x004362F0 File Offset: 0x004344F0
	public static CloudRegionCode NFEHPMKNHOC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf((char)-84);
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.eu;
	}

	// Token: 0x0600B7E1 RID: 47073 RVA: 0x00436354 File Offset: 0x00434554
	internal static CloudRegionFlag INKDIGGLLHP(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7E2 RID: 47074 RVA: 0x00436397 File Offset: 0x00434597
	public virtual string DBGLPGMGMGD()
	{
		return string.Format("/", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7E3 RID: 47075 RVA: 0x004363BC File Offset: 0x004345BC
	internal static CloudRegionFlag KIGKKKAPPIJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7E4 RID: 47076 RVA: 0x00436400 File Offset: 0x00434600
	internal static CloudRegionFlag NELEBCCIBGL(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7E5 RID: 47077 RVA: 0x00436444 File Offset: 0x00434644
	internal static CloudRegionFlag NOFIHOKNHAA(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7E6 RID: 47078 RVA: 0x00436495 File Offset: 0x00434695
	public virtual string CNOHJKCIHHN()
	{
		return string.Format("_Value", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7E7 RID: 47079 RVA: 0x004364B8 File Offset: 0x004346B8
	internal static CloudRegionFlag DDLDHNCMHBL(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7E8 RID: 47080 RVA: 0x0043650C File Offset: 0x0043470C
	internal static CloudRegionFlag IGJJDLMHBPM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7E9 RID: 47081 RVA: 0x00436550 File Offset: 0x00434750
	public static CloudRegionCode Parse(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.none;
		}
		int num = EJHKMJOLONP.IndexOf('/');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.none;
	}

	// Token: 0x0600B7EA RID: 47082 RVA: 0x004365B4 File Offset: 0x004347B4
	internal static CloudRegionFlag GAMALNCEHDP(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7EB RID: 47083 RVA: 0x004365F8 File Offset: 0x004347F8
	internal static CloudRegionFlag FEGLAFNJKON(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7EC RID: 47084 RVA: 0x0043663C File Offset: 0x0043483C
	internal static CloudRegionFlag NACGGIAGBEK(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7ED RID: 47085 RVA: 0x00436690 File Offset: 0x00434890
	internal static CloudRegionFlag OCLAFLBJIEI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7EE RID: 47086 RVA: 0x004366E4 File Offset: 0x004348E4
	internal static CloudRegionFlag HGDKMJEJCIK(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7EF RID: 47087 RVA: 0x00436728 File Offset: 0x00434928
	internal static CloudRegionFlag HBDKAGDMOFO(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7F0 RID: 47088 RVA: 0x0043676C File Offset: 0x0043496C
	internal static CloudRegionFlag AIBFFAAGHDF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7F1 RID: 47089 RVA: 0x004367B0 File Offset: 0x004349B0
	internal static CloudRegionFlag JFBLMOGHMPF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7F2 RID: 47090 RVA: 0x00436804 File Offset: 0x00434A04
	internal static CloudRegionFlag KHONIFNBLDM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7F3 RID: 47091 RVA: 0x00436847 File Offset: 0x00434A47
	public virtual string NMANIPNDOKJ()
	{
		return string.Format("OnMastedChangeScene", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7F4 RID: 47092 RVA: 0x0043686C File Offset: 0x00434A6C
	public static CloudRegionCode EOPNBLBODNP(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.sa;
		}
		int num = EJHKMJOLONP.IndexOf((char)-48);
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.asia;
	}

	// Token: 0x0600B7F5 RID: 47093 RVA: 0x004368D0 File Offset: 0x00434AD0
	internal static CloudRegionFlag JGBOOKILAEJ(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7F6 RID: 47094 RVA: 0x00436924 File Offset: 0x00434B24
	public static CloudRegionCode IBBAAFJKEHC(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.au;
		}
		int num = EJHKMJOLONP.IndexOf((char)-46);
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.jp;
	}

	// Token: 0x0600B7F7 RID: 47095 RVA: 0x00436988 File Offset: 0x00434B88
	internal static CloudRegionFlag LNBMJLKLOJI(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7F8 RID: 47096 RVA: 0x004369CC File Offset: 0x00434BCC
	internal static CloudRegionFlag GDAKNCCMFEI(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7F9 RID: 47097 RVA: 0x00436A20 File Offset: 0x00434C20
	internal static CloudRegionFlag PIEBAKPDPOH(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B7FA RID: 47098 RVA: 0x00436A71 File Offset: 0x00434C71
	public Region(CloudRegionCode JFNKDGKEAEA, string GOLPAHODNFE, string FJPNDMCELJN)
	{
		this.Code = JFNKDGKEAEA;
		this.Cluster = GOLPAHODNFE;
		this.HostAndPort = FJPNDMCELJN;
	}

	// Token: 0x0600B7FB RID: 47099 RVA: 0x00436A90 File Offset: 0x00434C90
	internal static CloudRegionFlag LPEJCCPEOMP(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B7FC RID: 47100 RVA: 0x00436AE4 File Offset: 0x00434CE4
	internal static CloudRegionFlag NKEOPOMIHJN(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B7FD RID: 47101 RVA: 0x00436B28 File Offset: 0x00434D28
	public static CloudRegionCode FKKAHBFFHKN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.cae;
		}
		int num = EJHKMJOLONP.IndexOf('\r');
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	// Token: 0x0600B7FE RID: 47102 RVA: 0x00436B8B File Offset: 0x00434D8B
	public virtual string FFJLDNEABNA()
	{
		return string.Format("_ScreenResolution", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B7FF RID: 47103 RVA: 0x00436BB0 File Offset: 0x00434DB0
	public static CloudRegionCode PKCNBKDDEHF(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.eu;
		}
		int num = EJHKMJOLONP.IndexOf('S');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(0, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	// Token: 0x0600B800 RID: 47104 RVA: 0x00436C14 File Offset: 0x00434E14
	public static CloudRegionCode AGLOFMCGLJI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf((char)-12);
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	// Token: 0x0600B801 RID: 47105 RVA: 0x00436C78 File Offset: 0x00434E78
	internal static CloudRegionFlag HJCPJAGBKHP(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B802 RID: 47106 RVA: 0x00436CCC File Offset: 0x00434ECC
	internal static CloudRegionFlag AFMODNOIAAM(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B803 RID: 47107 RVA: 0x00436D10 File Offset: 0x00434F10
	internal static CloudRegionFlag CCMBPJHCFBE(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return CloudRegionFlag.eu;
	}

	// Token: 0x0600B804 RID: 47108 RVA: 0x00436D64 File Offset: 0x00434F64
	internal static CloudRegionFlag NBIOEICPLDG(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B805 RID: 47109 RVA: 0x00436DB8 File Offset: 0x00434FB8
	internal static CloudRegionFlag HOIFAKMHCGF(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B806 RID: 47110 RVA: 0x00436DFC File Offset: 0x00434FFC
	internal static CloudRegionFlag COLJLHFAJIB(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B807 RID: 47111 RVA: 0x00436E50 File Offset: 0x00435050
	internal static CloudRegionFlag EINCDGAHJMH(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B808 RID: 47112 RVA: 0x00436EA4 File Offset: 0x004350A4
	public static CloudRegionCode HAMMOFBPLBI(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf('\u0006');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	// Token: 0x0600B809 RID: 47113 RVA: 0x00436F07 File Offset: 0x00435107
	public virtual string DEHDEBNAHOO()
	{
		return string.Format(":</b> ", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B80A RID: 47114 RVA: 0x00436F2C File Offset: 0x0043512C
	internal static CloudRegionFlag PCOIOBMPFDF(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B80B RID: 47115 RVA: 0x00436F80 File Offset: 0x00435180
	public static CloudRegionCode OAGCFAEKBCN(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.jp;
		}
		int num = EJHKMJOLONP.IndexOf((char)-77);
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.none;
	}

	// Token: 0x0600B80C RID: 47116 RVA: 0x00436FE4 File Offset: 0x004351E4
	public static CloudRegionCode EBPHPBNDNDJ(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf((char)-63);
		if (num > 1)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.cae;
	}

	// Token: 0x0600B80D RID: 47117 RVA: 0x00437048 File Offset: 0x00435248
	public static CloudRegionCode FMKNGEGHEBL(string EJHKMJOLONP)
	{
		if (EJHKMJOLONP == null)
		{
			return CloudRegionCode.asia;
		}
		int num = EJHKMJOLONP.IndexOf(')');
		if (num > 0)
		{
			EJHKMJOLONP = EJHKMJOLONP.Substring(1, num);
		}
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		if (Enum.IsDefined(typeof(CloudRegionCode), EJHKMJOLONP))
		{
			return (CloudRegionCode)Enum.Parse(typeof(CloudRegionCode), EJHKMJOLONP);
		}
		return CloudRegionCode.usw;
	}

	// Token: 0x0600B80E RID: 47118 RVA: 0x004370AB File Offset: 0x004352AB
	public virtual string JALEHOOBFID()
	{
		return string.Format(",", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B80F RID: 47119 RVA: 0x004370CE File Offset: 0x004352CE
	public virtual string ALNGGCBILAM()
	{
		return string.Format("cmd.exe", this.Cluster, this.Ping, this.HostAndPort);
	}

	// Token: 0x0600B810 RID: 47120 RVA: 0x004370F4 File Offset: 0x004352F4
	internal static CloudRegionFlag BGDIGCILJAJ(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = CloudRegionFlag.eu;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x0600B811 RID: 47121 RVA: 0x00437138 File Offset: 0x00435338
	internal static CloudRegionFlag HONMPIJDGGE(CloudRegionCode LPCNAHJGAFK)
	{
		if (Enum.IsDefined(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString()))
		{
			return (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), LPCNAHJGAFK.ToString());
		}
		return (CloudRegionFlag)0;
	}

	// Token: 0x0600B812 RID: 47122 RVA: 0x0043718C File Offset: 0x0043538C
	internal static CloudRegionFlag LBAHMLKLBDL(string EJHKMJOLONP)
	{
		EJHKMJOLONP = EJHKMJOLONP.ToLower();
		CloudRegionFlag result = (CloudRegionFlag)0;
		if (Enum.IsDefined(typeof(CloudRegionFlag), EJHKMJOLONP))
		{
			result = (CloudRegionFlag)Enum.Parse(typeof(CloudRegionFlag), EJHKMJOLONP);
		}
		return result;
	}

	// Token: 0x04001582 RID: 5506
	public CloudRegionCode Code;

	// Token: 0x04001583 RID: 5507
	public string Cluster;

	// Token: 0x04001584 RID: 5508
	public string HostAndPort;

	// Token: 0x04001585 RID: 5509
	public int Ping;
}
