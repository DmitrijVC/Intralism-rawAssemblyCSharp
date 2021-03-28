using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x020004D4 RID: 1236
public class SaveSystem : Singleton<SaveSystem>
{
	// Token: 0x06011DFE RID: 73214 RVA: 0x00628639 File Offset: 0x00626839
	public string FBCCDONJALF()
	{
		return new FileInfo(Helpers.GetDirectory(" GameServer:") + "Hidden/Image Effects/Cinematic/AmbientOcclusion" + this.GetCurrentSaveFileName() + ",").FullName;
	}

	// Token: 0x06011DFF RID: 73215 RVA: 0x00628664 File Offset: 0x00626864
	public string GetCurrentSaveFileFullPath()
	{
		return new FileInfo(Helpers.GetDirectory("Save") + "/" + this.GetCurrentSaveFileName() + ".save").FullName;
	}

	// Token: 0x06011E00 RID: 73216 RVA: 0x00628690 File Offset: 0x00626890
	public void CIDNCCOIEJJ()
	{
		if (this.OONKHMECOCF)
		{
			this.GPJGHDBMDGN = this.LAAAPBGKNGH(null);
			string contents = (!this.HCHMCODLILK) ? this.GPJGHDBMDGN : GameManager.Encrypt(this.GPJGHDBMDGN);
			Helpers.CheckDirectory("PLEASE WAIT");
			File.Create(this.IGCGEJDMGAB()).Dispose();
			File.WriteAllText(this.GetCurrentSaveFileFullPath(), contents);
			this.GPJGHDBMDGN = string.Empty;
		}
	}

	// Token: 0x06011E01 RID: 73217 RVA: 0x00628708 File Offset: 0x00626908
	public void HEIIMOJGGEB(bool CKALCHJAFBE)
	{
		this.HCHMCODLILK = CKALCHJAFBE;
	}

	// Token: 0x06011E02 RID: 73218 RVA: 0x00628711 File Offset: 0x00626911
	public string KKAJOOJKBDJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E03 RID: 73219 RVA: 0x0062873B File Offset: 0x0062693B
	public int JPEEFKKPFIL(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E04 RID: 73220 RVA: 0x00628779 File Offset: 0x00626979
	public bool LCHPECEJMPE(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E05 RID: 73221 RVA: 0x006287B7 File Offset: 0x006269B7
	public void KOMAMFOPJID(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E06 RID: 73222 RVA: 0x006287EF File Offset: 0x006269EF
	public string AFJEOAONPJD()
	{
		return new FileInfo(Helpers.GetDirectory("challenges/") + "CameraFilterPack/Lut_TestMode" + this.CBOCAHLJCGP() + "_MainTex2").FullName;
	}

	// Token: 0x06011E07 RID: 73223 RVA: 0x0062881C File Offset: 0x00626A1C
	private Hashtable EFCAPLBAPLL(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[1];
		array[1] = "_MainTex2";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string text = array3[i];
			string text2 = text;
			string[] array4 = new string[1];
			array4[1] = "SpawnObj";
			string[] array5 = text2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
			hashtable.Add(this.OIIGCJPDLGC(array5[0], SaveSystem.NHICDOHIKAL), this.EICOHFGICAK(array5[0], this.DeEscapeNonSeperators(array5[1], SaveSystem.NHICDOHIKAL)));
			if (array5.Length > 4)
			{
				Debug.LogWarning("settings.volume.sfx" + array5.Length + "AddEnvironmentObject");
			}
		}
		return hashtable;
	}

	// Token: 0x06011E08 RID: 73224 RVA: 0x006288D4 File Offset: 0x00626AD4
	public void HIDBNDKJHAA(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E09 RID: 73225 RVA: 0x00628924 File Offset: 0x00626B24
	public string OOLELLHJHAC(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("inventory.selected.", "EventMenu");
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], ".lastCheckpoint.checkpointsUsed" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	// Token: 0x06011E0A RID: 73226 RVA: 0x00628970 File Offset: 0x00626B70
	public void LJHCGFGJPCK()
	{
		if (this.OONKHMECOCF)
		{
			this.GPJGHDBMDGN = this.MFIGIBCOEKN(null);
			string contents = (!this.HCHMCODLILK) ? this.GPJGHDBMDGN : GameManager.HGIFJHHKABG(this.GPJGHDBMDGN);
			Helpers.CheckDirectory("_MaxRadiusOrKInPaper");
			File.Create(this.OBHPKLFMFOO()).Dispose();
			File.WriteAllText(this.DMHMPFGBLFB(), contents);
			this.GPJGHDBMDGN = string.Empty;
		}
	}

	// Token: 0x06011E0B RID: 73227 RVA: 0x0062873B File Offset: 0x0062693B
	public int AFCPNFKIKKJ(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E0C RID: 73228 RVA: 0x006289E8 File Offset: 0x00626BE8
	public int CEKEOJDAEOD(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E0D RID: 73229 RVA: 0x00628A26 File Offset: 0x00626C26
	public string CEDJCDAPIAH(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E0E RID: 73230 RVA: 0x00628A5F File Offset: 0x00626C5F
	public string OJLJAANBMBH()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	// Token: 0x06011E0F RID: 73231 RVA: 0x00628A6B File Offset: 0x00626C6B
	public bool GetBool(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) && (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E10 RID: 73232 RVA: 0x00628A98 File Offset: 0x00626C98
	public void CONNMLDKBOF(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E11 RID: 73233 RVA: 0x00628AE5 File Offset: 0x00626CE5
	public void DeleteAll(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	// Token: 0x06011E12 RID: 73234 RVA: 0x00628779 File Offset: 0x00626979
	public bool OLJGEIBGDHL(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E13 RID: 73235 RVA: 0x006287B7 File Offset: 0x006269B7
	public void LIFMHPJPNEP(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E14 RID: 73236 RVA: 0x00628AFB File Offset: 0x00626CFB
	public string LKOCCMCDDKG(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E15 RID: 73237 RVA: 0x00628AE5 File Offset: 0x00626CE5
	public void HIJFMGEOLOA(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	// Token: 0x06011E16 RID: 73238 RVA: 0x00628B34 File Offset: 0x00626D34
	public void SetInt(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E17 RID: 73239 RVA: 0x00628B81 File Offset: 0x00626D81
	public void DAGHAOBCIFL(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E18 RID: 73240 RVA: 0x00628BBC File Offset: 0x00626DBC
	public void DOIAJINPMOG(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E19 RID: 73241 RVA: 0x00628C09 File Offset: 0x00626E09
	public long OHILDJCAJDN(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E1A RID: 73242 RVA: 0x00628C34 File Offset: 0x00626E34
	public long PADBLFLKGPC(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E1B RID: 73243 RVA: 0x00628708 File Offset: 0x00626908
	public void EnableEncryption(bool CKALCHJAFBE)
	{
		this.HCHMCODLILK = CKALCHJAFBE;
	}

	// Token: 0x06011E1C RID: 73244 RVA: 0x00628C72 File Offset: 0x00626E72
	public string IGCGEJDMGAB()
	{
		return new FileInfo(Helpers.GetDirectory("SetPlayerDistance") + "maps." + this.CBOCAHLJCGP() + "d264dbba9c2410771b4ad918903b3f4cd9e276a9").FullName;
	}

	// Token: 0x06011E1D RID: 73245 RVA: 0x00628CA0 File Offset: 0x00626EA0
	private Hashtable BIGOMICKFNL(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = MKNDAKMBCLN.Split(new string[]
		{
			" ; "
		}, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			string[] array3 = text.Split(new string[]
			{
				" : "
			}, StringSplitOptions.None);
			hashtable.Add(this.DeEscapeNonSeperators(array3[0], SaveSystem.NHICDOHIKAL), this.KKIHHNFJFHJ(array3[2], this.DeEscapeNonSeperators(array3[1], SaveSystem.NHICDOHIKAL)));
			if (array3.Length > 3)
			{
				Debug.LogWarning("PlayerPrefs::Deserialize() parameterContent has " + array3.Length + " elements");
			}
		}
		return hashtable;
	}

	// Token: 0x06011E1E RID: 73246 RVA: 0x00628D55 File Offset: 0x00626F55
	public float OJHPDDLNAGH(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E1F RID: 73247 RVA: 0x00628D93 File Offset: 0x00626F93
	public float DHFOFEJPGPP(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E20 RID: 73248 RVA: 0x00628DD1 File Offset: 0x00626FD1
	public bool CLPNPGCOPIH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return !LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) || (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E21 RID: 73249 RVA: 0x00628DFB File Offset: 0x00626FFB
	public float KIKJOOJFIJK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 880f;
	}

	// Token: 0x06011E22 RID: 73250 RVA: 0x00628E29 File Offset: 0x00627029
	public float GLDCKMNIIDE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1327f;
	}

	// Token: 0x06011E23 RID: 73251 RVA: 0x00628AFB File Offset: 0x00626CFB
	public string FDPKMMIOGOE(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E24 RID: 73252 RVA: 0x00628E58 File Offset: 0x00627058
	public void JBHLCJOEOGL(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E25 RID: 73253 RVA: 0x00628EA8 File Offset: 0x006270A8
	private object LKOKIIMLHIP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "Texture2")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "Object ID. Case-Sensitive")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "settings_bindings_")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "Added GameObject to prefabDictionary: ")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "_Value6")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("_Value6" + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E26 RID: 73254 RVA: 0x00628A26 File Offset: 0x00626C26
	public string JLBFLBAHGIP(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E27 RID: 73255 RVA: 0x00628F4D File Offset: 0x0062714D
	public float BKPEOCMBKBI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1803f;
	}

	// Token: 0x06011E28 RID: 73256 RVA: 0x00628A5F File Offset: 0x00626C5F
	public string CBOCAHLJCGP()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	// Token: 0x06011E29 RID: 73257 RVA: 0x00628F7B File Offset: 0x0062717B
	public bool GIHOKCMHMCP(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E2A RID: 73258 RVA: 0x00628D93 File Offset: 0x00626F93
	public float OLHIEOKMOAK(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E2B RID: 73259 RVA: 0x00628FBC File Offset: 0x006271BC
	public void NHONGIGFHJB(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E2C RID: 73260 RVA: 0x0062900C File Offset: 0x0062720C
	public void IKOAFMHIJLE(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E2D RID: 73261 RVA: 0x006287B7 File Offset: 0x006269B7
	public void NOEIPDOLJFA(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E2E RID: 73262 RVA: 0x0062905C File Offset: 0x0062725C
	public string KMMDJEPFGGL(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("LevelNameInputField", "SetPlayerDistance");
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "_Value3" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	// Token: 0x06011E2F RID: 73263 RVA: 0x0062873B File Offset: 0x0062693B
	public int ANECPPFPKAP(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E30 RID: 73264 RVA: 0x006290A8 File Offset: 0x006272A8
	public float DHAINALDNBG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 35f;
	}

	// Token: 0x06011E31 RID: 73265 RVA: 0x006290D6 File Offset: 0x006272D6
	public float GetFloat(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0f;
	}

	// Token: 0x06011E32 RID: 73266 RVA: 0x00628779 File Offset: 0x00626979
	public bool AANPGELPGPN(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E33 RID: 73267 RVA: 0x00628C34 File Offset: 0x00626E34
	public long LJBIIPPHGEJ(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E34 RID: 73268 RVA: 0x00629104 File Offset: 0x00627304
	public void EIAJOEAPEJO(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E35 RID: 73269 RVA: 0x00629154 File Offset: 0x00627354
	private object FALCJKHIFCO(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "_History1Weight")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "_CurveTex")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "(\\[ *quote *\\])")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "/")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "SetSpeed")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("In Main Menu" + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E36 RID: 73270 RVA: 0x006291F9 File Offset: 0x006273F9
	public void PGGNGAMLGAJ()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().CIHBPOBKGNP("_LrDepthTex", new DebugCommands.DebugCommand(this.IBNNPGBPBIL), "_ReflectionTexture3", "SetSunDirectionVector", false);
	}

	// Token: 0x06011E37 RID: 73271 RVA: 0x00629228 File Offset: 0x00627428
	public string DeEscapeNonSeperators(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("\\" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("\\\\", "\\");
		return MIECKJBDFLA;
	}

	// Token: 0x06011E38 RID: 73272 RVA: 0x00628C09 File Offset: 0x00626E09
	public long OIJNFPAJNEB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E39 RID: 73273 RVA: 0x00629274 File Offset: 0x00627474
	public bool KPLBEJCGOMO(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	// Token: 0x06011E3A RID: 73274 RVA: 0x00628C34 File Offset: 0x00626E34
	public long LNKGJIHLLGH(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E3B RID: 73275 RVA: 0x00629274 File Offset: 0x00627474
	public bool PMDOJPLDDKP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	// Token: 0x06011E3C RID: 73276 RVA: 0x0062928C File Offset: 0x0062748C
	public void SetLong(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E3D RID: 73277 RVA: 0x006292DC File Offset: 0x006274DC
	public void MMMIEPDLMNM()
	{
		if (this.OONKHMECOCF)
		{
			this.GPJGHDBMDGN = this.LAAAPBGKNGH(null);
			string contents = (!this.HCHMCODLILK) ? this.GPJGHDBMDGN : GameManager.OLLCLOPGHGI(this.GPJGHDBMDGN);
			Helpers.CheckDirectory("SupportLogger ");
			File.Create(this.FBCCDONJALF()).Dispose();
			File.WriteAllText(this.OBHPKLFMFOO(), contents);
			this.GPJGHDBMDGN = string.Empty;
		}
	}

	// Token: 0x06011E3E RID: 73278 RVA: 0x00628C09 File Offset: 0x00626E09
	public long AHGPHDDBFBE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E3F RID: 73279 RVA: 0x00629354 File Offset: 0x00627554
	public string OBHPKLFMFOO()
	{
		return new FileInfo(Helpers.GetDirectory("SetParticlesInput") + ". Verify the Prefab is in a Resources folder (and not in a subfolder)" + this.LHLGBIMNCCI() + "PLEASE WAIT").FullName;
	}

	// Token: 0x06011E40 RID: 73280 RVA: 0x00629380 File Offset: 0x00627580
	private string HPKGPKEFBFH(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(";");
				stringBuilder.Append(" ");
			}
			stringBuilder.Append(this.EscapeNonSeperators(enumerator.Key.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append(" ");
			stringBuilder.Append(":");
			stringBuilder.Append(" ");
			stringBuilder.Append(this.EscapeNonSeperators(enumerator.Value.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append(" ");
			stringBuilder.Append(":");
			stringBuilder.Append(" ");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011E41 RID: 73281 RVA: 0x00628711 File Offset: 0x00626911
	public string ELHODPGACDI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E42 RID: 73282 RVA: 0x00629488 File Offset: 0x00627688
	public long EHHEFEMJDIC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1L;
	}

	// Token: 0x06011E43 RID: 73283 RVA: 0x00628C34 File Offset: 0x00626E34
	public long GetLong(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E44 RID: 73284 RVA: 0x006294B4 File Offset: 0x006276B4
	public void SetBool(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E45 RID: 73285 RVA: 0x00629504 File Offset: 0x00627704
	public void Flush()
	{
		if (this.OONKHMECOCF)
		{
			this.GPJGHDBMDGN = this.HPKGPKEFBFH(null);
			string contents = (!this.HCHMCODLILK) ? this.GPJGHDBMDGN : GameManager.Encrypt(this.GPJGHDBMDGN);
			Helpers.CheckDirectory("Save");
			File.Create(this.GetCurrentSaveFileFullPath()).Dispose();
			File.WriteAllText(this.GetCurrentSaveFileFullPath(), contents);
			this.GPJGHDBMDGN = string.Empty;
		}
	}

	// Token: 0x06011E46 RID: 73286 RVA: 0x0062957C File Offset: 0x0062777C
	private Hashtable NGDPMOOODLJ(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[0] = "\\n";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i++)
		{
			string text = array3[i];
			string text2 = text;
			string[] array4 = new string[0];
			array4[1] = "inventory.selected.";
			string[] array5 = text2.Split(array4, StringSplitOptions.None);
			hashtable.Add(this.JGBGEJEBLOO(array5[1], SaveSystem.NHICDOHIKAL), this.BPIEDCMEDFP(array5[2], this.OIIGCJPDLGC(array5[1], SaveSystem.NHICDOHIKAL)));
			if (array5.Length > 3)
			{
				Debug.LogWarning("Trackpad" + array5.Length + "gamemode");
			}
		}
		return hashtable;
	}

	// Token: 0x06011E47 RID: 73287 RVA: 0x00629631 File Offset: 0x00627831
	public void HHNNLOEGDEF()
	{
		base.Awake();
		DebugCommands.IGMKHPPPLDD().EHJBOAOCFNP("maps.", new DebugCommands.DebugCommand(this.FBHNGMCCLIH), "Joystick1Button11", "#failed: ", true);
	}

	// Token: 0x06011E48 RID: 73288 RVA: 0x00629488 File Offset: 0x00627688
	public long AKLKJFPNEAC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1L;
	}

	// Token: 0x06011E49 RID: 73289 RVA: 0x00629660 File Offset: 0x00627860
	public void KOKDPAEJECC(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = true;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("settings.volume.editor" + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.GetCurrentSaveFileFullPath()))
		{
			try
			{
				this.isSaveLoaded = true;
				streamReader = new StreamReader(this.OBHPKLFMFOO());
				this.DCAAJFIBFHO = false;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("Init");
				streamReader.Dispose();
				File.Delete(this.OBHPKLFMFOO());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 0] == -21)
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 1);
				if (this.MKNDAKMBCLN.Length > 1 && this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 0] == '3')
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(0, this.MKNDAKMBCLN.Length - 0);
				}
			}
			this.LPFHGFAOHDB = this.BIGOMICKFNL(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011E4A RID: 73290 RVA: 0x00628F7B File Offset: 0x0062717B
	public bool IOLBIFOIHML(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E4B RID: 73291 RVA: 0x0062980C File Offset: 0x00627A0C
	public string FNOFGNOLHFM()
	{
		return new FileInfo(Helpers.GetDirectory("CameraFilterPack/Blur_Radial_Fast") + "CameraFilterPack/Glasses_On" + this.GetCurrentSaveFileName() + "FinalScoreText").FullName;
	}

	// Token: 0x06011E4C RID: 73292 RVA: 0x00628DD1 File Offset: 0x00626FD1
	public bool LEAKKIIPIFL(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return !LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) || (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E4D RID: 73293 RVA: 0x00628A5F File Offset: 0x00626C5F
	public string LHLGBIMNCCI()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	// Token: 0x06011E4E RID: 73294 RVA: 0x00629838 File Offset: 0x00627A38
	public void SetFloat(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E4F RID: 73295 RVA: 0x00628D93 File Offset: 0x00626F93
	public float GetFloat(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E50 RID: 73296 RVA: 0x00629888 File Offset: 0x00627A88
	private object FMNNNAFKCHF(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "offsets")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "SpawnObj")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "_Near")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == " cannot be used as a 3D LUT.")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "CameraFilterPack/Blend2Camera_VividLight")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("ENABLE_DITHERING" + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E51 RID: 73297 RVA: 0x00628C09 File Offset: 0x00626E09
	public long GetLong(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E52 RID: 73298 RVA: 0x00629930 File Offset: 0x00627B30
	public void GAACBNCIFLG(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E53 RID: 73299 RVA: 0x0062997D File Offset: 0x00627B7D
	public int PPBFNLHCKCP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x06011E54 RID: 73300 RVA: 0x00628AFB File Offset: 0x00626CFB
	public string GetString(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E55 RID: 73301 RVA: 0x00629274 File Offset: 0x00627474
	public bool HasKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	// Token: 0x06011E56 RID: 73302 RVA: 0x00628711 File Offset: 0x00626911
	public string IPEDKOMAKPP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E57 RID: 73303 RVA: 0x006299A7 File Offset: 0x00627BA7
	public void DeleteKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	// Token: 0x06011E58 RID: 73304 RVA: 0x006299C0 File Offset: 0x00627BC0
	public string EscapeNonSeperators(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("\\", "\\\\");
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "\\" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	// Token: 0x06011E59 RID: 73305 RVA: 0x00629A0C File Offset: 0x00627C0C
	private string MFIGIBCOEKN(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("NetworkCanvas");
				stringBuilder.Append("Tab2Content");
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(this.KMMDJEPFGGL(enumerator.Key.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append("_Blue_C");
			stringBuilder.Append("_Value6");
			stringBuilder.Append("{0:0} second{1}");
			stringBuilder.Append(this.OHHMNLEFOOK(enumerator.Value.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append(" registered.");
			stringBuilder.Append("_Fade");
			stringBuilder.Append("ws://");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011E5A RID: 73306 RVA: 0x00629B14 File Offset: 0x00627D14
	public float EJEGKIDILDJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1812f;
	}

	// Token: 0x06011E5B RID: 73307 RVA: 0x00628711 File Offset: 0x00626911
	public string NBMEANCMGEH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E5C RID: 73308 RVA: 0x00629B44 File Offset: 0x00627D44
	public void ALGKENJGNLL(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = true;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join." + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.FNOFGNOLHFM()))
		{
			try
			{
				this.isSaveLoaded = false;
				streamReader = new StreamReader(this.GetCurrentSaveFileFullPath());
				this.DCAAJFIBFHO = false;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("menu.selectedlevelid");
				streamReader.Dispose();
				File.Delete(this.OBHPKLFMFOO());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 0] == -72)
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 1);
				if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == -45)
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 0);
				}
			}
			this.LPFHGFAOHDB = this.BIGOMICKFNL(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011E5D RID: 73309 RVA: 0x00629CF0 File Offset: 0x00627EF0
	public string PLIPJHNEGCH(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 1; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("_Intensity" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace(" user's map(s)", "MessageText");
		return MIECKJBDFLA;
	}

	// Token: 0x06011E5E RID: 73310 RVA: 0x006299A7 File Offset: 0x00627BA7
	public void KOKOJGKDLMP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	// Token: 0x06011E5F RID: 73311 RVA: 0x00629D3C File Offset: 0x00627F3C
	private object KKIHHNFJFHJ(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "System.String")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "System.Int32")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "System.Boolean")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "System.Single")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "System.Int64")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("Unsupported type: " + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E60 RID: 73312 RVA: 0x00629DE4 File Offset: 0x00627FE4
	private void CNGKFIDOMNJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("EventConfigButton");
		}
		else if (BDGDDFKKGGA.Length == 3)
		{
			if (BDGDDFKKGGA[0] == "_ScreenResolution")
			{
				this.CAJFKNFJEKC(null);
			}
		}
		else
		{
			if (BDGDDFKKGGA[0] == "_SphereSize")
			{
				if (BDGDDFKKGGA.Length != 0)
				{
					Debug.LogError("_MainTex2");
				}
				else
				{
					this.BEMECPDKOCA(BDGDDFKKGGA[0]);
				}
			}
			if (BDGDDFKKGGA[0] == "CameraFilterPack/Blend2Camera_LinearDodge")
			{
				if (BDGDDFKKGGA.Length != 4)
				{
					Debug.LogError("_ScreenResolution");
				}
				else
				{
					Singleton<SaveSystem>.Instance.HBIGPMNAPHA(BDGDDFKKGGA[0], int.Parse(BDGDDFKKGGA[2], NumberStyles.AllowTrailingWhite), null);
					Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
				}
			}
			if (BDGDDFKKGGA[1] == "EventConfigButton")
			{
				if (BDGDDFKKGGA.Length != 5)
				{
					Debug.LogError("CameraFilterPack/Film_ColorPerfection");
				}
				else
				{
					object[] array = new object[0];
					array[0] = "Destroy all spawned environment objects";
					array[0] = BDGDDFKKGGA[3];
					array[6] = "CameraFilterPack/Distortion_Wave_Horizontal";
					array[3] = Singleton<SaveSystem>.Instance.JLPLKBDBIJC(BDGDDFKKGGA[4], null);
					Debug.Log(string.Concat(array));
				}
			}
			if (BDGDDFKKGGA[1] == "settings.arcshitsoundtimedelay")
			{
				if (BDGDDFKKGGA.Length != 1)
				{
					Debug.LogError("Connecting");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[0], BDGDDFKKGGA[5], null);
					Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
				}
			}
			if (BDGDDFKKGGA[1] == "_Value3")
			{
				if (BDGDDFKKGGA.Length != 7)
				{
					Debug.LogError("_EdgeSize");
				}
				else
				{
					Debug.Log("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + BDGDDFKKGGA[1] + "[DiscordController] Connected to {0}#{1}: {2}" + Singleton<SaveSystem>.Instance.ELHODPGACDI(BDGDDFKKGGA[3], null));
				}
			}
			if (BDGDDFKKGGA[0] == "Bad parameters for set! Use <language>")
			{
				if (BDGDDFKKGGA.Length != 2)
				{
					Debug.LogError("GenerationMenu");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetBool(BDGDDFKKGGA[0], bool.Parse(BDGDDFKKGGA[5]), null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "value")
			{
				if (BDGDDFKKGGA.Length != 7)
				{
					Debug.LogError("catched: ");
				}
				else
				{
					object[] array2 = new object[]
					{
						null,
						"arcs"
					};
					array2[1] = BDGDDFKKGGA[1];
					array2[6] = "CameraFilterPack/FX_Plasma";
					array2[8] = Singleton<SaveSystem>.Instance.IAABFJBOGGO(BDGDDFKKGGA[1], null);
					Debug.Log(string.Concat(array2));
				}
			}
			if (BDGDDFKKGGA[0] == "maps.")
			{
				if (BDGDDFKKGGA.Length != 1)
				{
					Debug.LogError("shader.frost");
				}
				else
				{
					Singleton<SaveSystem>.Instance.JBHLCJOEOGL(BDGDDFKKGGA[1], float.Parse(BDGDDFKKGGA[8], NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "_Axis")
			{
				if (BDGDDFKKGGA.Length != 6)
				{
					Debug.LogError("CameraFilterPack/Vision_Hell_Blood");
				}
				else
				{
					object[] array3 = new object[0];
					array3[0] = "_Speed";
					array3[1] = BDGDDFKKGGA[3];
					array3[8] = "error";
					array3[7] = Singleton<SaveSystem>.Instance.KIKJOOJFIJK(BDGDDFKKGGA[8], null);
					Debug.Log(string.Concat(array3));
				}
			}
			if (BDGDDFKKGGA[1] == "1234332714")
			{
				if (BDGDDFKKGGA.Length != 6)
				{
					Debug.LogError("rarity");
				}
				else
				{
					Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(BDGDDFKKGGA[0], null);
				}
			}
			if (BDGDDFKKGGA[1] == "ComboText")
			{
				Singleton<SaveSystem>.Instance.HIJFMGEOLOA(null);
			}
			if (BDGDDFKKGGA[1] == "#updateoutdatedmap")
			{
				Debug.Log("_Bullet_1" + Singleton<SaveSystem>.Instance.GetCurrentSaveFileFullPath());
			}
		}
	}

	// Token: 0x06011E61 RID: 73313 RVA: 0x0062A18D File Offset: 0x0062838D
	public long CFJNHGCJDBD(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E62 RID: 73314 RVA: 0x0062A1CC File Offset: 0x006283CC
	public string OHHMNLEFOOK(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("value", "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
		for (int i = 0; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "_SunThreshold" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	// Token: 0x06011E63 RID: 73315 RVA: 0x0062997D File Offset: 0x00627B7D
	public int PKIEJKHMECB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x06011E64 RID: 73316 RVA: 0x00628779 File Offset: 0x00626979
	public bool ONOENJPEFDD(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E65 RID: 73317 RVA: 0x0062A218 File Offset: 0x00628418
	public void CBIEBMGENJH(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E66 RID: 73318 RVA: 0x0062997D File Offset: 0x00627B7D
	public int JLPLKBDBIJC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x06011E67 RID: 73319 RVA: 0x00628C09 File Offset: 0x00626E09
	public long KOEFDCEBMJL(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E68 RID: 73320 RVA: 0x0062A268 File Offset: 0x00628468
	private object EICOHFGICAK(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "x")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "CameraFilterPack/Blur_Movie")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "ComboScoreText")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "_TimeX")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "maps.")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("Ev DestroyAll! By PlayerId: " + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E69 RID: 73321 RVA: 0x00628708 File Offset: 0x00626908
	public void JBGEBCHJPCG(bool CKALCHJAFBE)
	{
		this.HCHMCODLILK = CKALCHJAFBE;
	}

	// Token: 0x06011E6A RID: 73322 RVA: 0x0062A310 File Offset: 0x00628510
	public void OIJPCPGCGEN(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E6B RID: 73323 RVA: 0x0062A35D File Offset: 0x0062855D
	public int GetInt(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0;
	}

	// Token: 0x06011E6C RID: 73324 RVA: 0x00629488 File Offset: 0x00627688
	public long DPHBBBHMGEH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1L;
	}

	// Token: 0x06011E6D RID: 73325 RVA: 0x0062997D File Offset: 0x00627B7D
	public int DNBCCNHDJDK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1;
	}

	// Token: 0x06011E6E RID: 73326 RVA: 0x0062A388 File Offset: 0x00628588
	public string EMLLHLAIAAA(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("SaveButton", "name");
		for (int i = 1; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "roomDescription" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	// Token: 0x06011E6F RID: 73327 RVA: 0x00628AFB File Offset: 0x00626CFB
	public string LFFECBOPPHA(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E70 RID: 73328 RVA: 0x0062A3D4 File Offset: 0x006285D4
	private object BBACCHJAFHK(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "_Value2")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "saveGameName ")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "_InvScreenSize")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "Text")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "CONTRAST")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("mapselector.filter.favoriteonly" + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E71 RID: 73329 RVA: 0x00628D55 File Offset: 0x00626F55
	public float AKHCHNPPNIB(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E72 RID: 73330 RVA: 0x0062A479 File Offset: 0x00628679
	public float HLPKNPJIHKM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1070f;
	}

	// Token: 0x06011E73 RID: 73331 RVA: 0x006289E8 File Offset: 0x00626BE8
	public int CMAFBKOEPLP(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E74 RID: 73332 RVA: 0x0062A4A8 File Offset: 0x006286A8
	private object BPIEDCMEDFP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "settings.gamemessagesduration")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "OK")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "value")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "Scrollbar")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "Tab2Content")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("maps." + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E75 RID: 73333 RVA: 0x0062A550 File Offset: 0x00628750
	private void IBNNPGBPBIL(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("_BlurRadius4");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[0] == "https://store.steampowered.com/recommended/recommendgame/")
			{
				this.Init(null);
			}
		}
		else
		{
			if (BDGDDFKKGGA[0] == " is muted")
			{
				if (BDGDDFKKGGA.Length != 1)
				{
					Debug.LogError("LevelConfigButton");
				}
				else
				{
					this.BEMECPDKOCA(BDGDDFKKGGA[0]);
				}
			}
			if (BDGDDFKKGGA[0] == "player.xp")
			{
				if (BDGDDFKKGGA.Length != 1)
				{
					Debug.LogError("shader.sunny");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[1], int.Parse(BDGDDFKKGGA[1], NumberStyles.AllowLeadingSign), null);
					Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
				}
			}
			if (BDGDDFKKGGA[1] == "#md5submitionfailed: ")
			{
				if (BDGDDFKKGGA.Length != 7)
				{
					Debug.LogError("menu.hardcoreinfo");
				}
				else
				{
					object[] array = new object[0];
					array[1] = "_Value";
					array[1] = BDGDDFKKGGA[1];
					array[2] = "\"\"";
					array[4] = Singleton<SaveSystem>.Instance.PPBFNLHCKCP(BDGDDFKKGGA[1], null);
					Debug.Log(string.Concat(array));
				}
			}
			if (BDGDDFKKGGA[1] == "New SaveGame")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("BadgeImage");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[4], BDGDDFKKGGA[4], null);
					Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
				}
			}
			if (BDGDDFKKGGA[0] == "sounds/no_hit")
			{
				if (BDGDDFKKGGA.Length != 0)
				{
					Debug.LogError("_TimeX");
				}
				else
				{
					Debug.Log("Joystick1Button4" + BDGDDFKKGGA[2] + "b" + Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(BDGDDFKKGGA[6], null));
				}
			}
			if (BDGDDFKKGGA[0] == "_RampTex")
			{
				if (BDGDDFKKGGA.Length != 7)
				{
					Debug.LogError("https://discord.gg/intralism");
				}
				else
				{
					Singleton<SaveSystem>.Instance.CMLFCHINKCH(BDGDDFKKGGA[0], bool.Parse(BDGDDFKKGGA[4]), null);
					Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
				}
			}
			if (BDGDDFKKGGA[0] == "Image effects aren't supported on this device ({0})")
			{
				if (BDGDDFKKGGA.Length != 0)
				{
					Debug.LogError("1");
				}
				else
				{
					object[] array2 = new object[0];
					array2[0] = "settings.enablerankingnotifications";
					array2[1] = BDGDDFKKGGA[6];
					array2[4] = "_MainTex2";
					array2[1] = Singleton<SaveSystem>.Instance.CHBOJJOHCEB(BDGDDFKKGGA[0], null);
					Debug.Log(string.Concat(array2));
				}
			}
			if (BDGDDFKKGGA[1] == "ItemNameBGImage")
			{
				if (BDGDDFKKGGA.Length != 7)
				{
					Debug.LogError("skin.");
				}
				else
				{
					Singleton<SaveSystem>.Instance.JBHLCJOEOGL(BDGDDFKKGGA[3], float.Parse(BDGDDFKKGGA[3], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands), null);
					Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
				}
			}
			if (BDGDDFKKGGA[0] == " (inactive)")
			{
				if (BDGDDFKKGGA.Length != 8)
				{
					Debug.LogError("_ScreenResolution");
				}
				else
				{
					object[] array3 = new object[4];
					array3[1] = "[LevelEditorScene] Item creation successful! Published Item ID: ";
					array3[1] = BDGDDFKKGGA[8];
					array3[4] = "CameraFilterPack/Film_ColorPerfection";
					array3[6] = Singleton<SaveSystem>.Instance.BKPEOCMBKBI(BDGDDFKKGGA[5], null);
					Debug.Log(string.Concat(array3));
				}
			}
			if (BDGDDFKKGGA[0] == "_MainTex2")
			{
				if (BDGDDFKKGGA.Length != 6)
				{
					Debug.LogError("Image effects aren't supported on this device ({0})");
				}
				else
				{
					Singleton<SaveSystem>.Instance.IPCGLFKIANM(BDGDDFKKGGA[6], null);
				}
			}
			if (BDGDDFKKGGA[0] == "<b>#")
			{
				Singleton<SaveSystem>.Instance.NIPDJGJCPLK(null);
			}
			if (BDGDDFKKGGA[1] == ";")
			{
				Debug.Log("_Skybox" + Singleton<SaveSystem>.Instance.FNOFGNOLHFM());
			}
		}
	}

	// Token: 0x06011E76 RID: 73334 RVA: 0x00628A6B File Offset: 0x00626C6B
	public bool IAABFJBOGGO(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) && (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E77 RID: 73335 RVA: 0x0062A8F9 File Offset: 0x00628AF9
	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("data", new DebugCommands.DebugCommand(this.FBHNGMCCLIH), "Run a command for data system", "<command>", true);
	}

	// Token: 0x06011E78 RID: 73336 RVA: 0x006299A7 File Offset: 0x00627BA7
	public void KNFHMLMGKCJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	// Token: 0x06011E79 RID: 73337 RVA: 0x00628AE5 File Offset: 0x00626CE5
	public void NIPDJGJCPLK(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	// Token: 0x06011E7A RID: 73338 RVA: 0x00628D93 File Offset: 0x00626F93
	public float NPNOOLFEDKN(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E7B RID: 73339 RVA: 0x00628AE5 File Offset: 0x00626CE5
	public void CBPMAEIODNN(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	// Token: 0x06011E7C RID: 73340 RVA: 0x0062A927 File Offset: 0x00628B27
	public void IKGFIOIADLN()
	{
		base.Awake();
		DebugCommands.Instance.CEBBJICIFGO("Joystick1Button8", new DebugCommands.DebugCommand(this.IBNNPGBPBIL), "MapperNameText", "GlassesColor", true);
	}

	// Token: 0x06011E7D RID: 73341 RVA: 0x00628779 File Offset: 0x00626979
	public bool EBEAKNGJCDC(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E7E RID: 73342 RVA: 0x00628DD1 File Offset: 0x00626FD1
	public bool CHBOJJOHCEB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return !LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) || (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E7F RID: 73343 RVA: 0x0062A958 File Offset: 0x00628B58
	private object GCGBMNFMIEP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		if (ICMAOHOIGFA == "Horizontal")
		{
			return DPNHODJHGJL.ToString();
		}
		if (ICMAOHOIGFA == "_TimeX")
		{
			return Convert.ToInt32(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "offsets")
		{
			return Convert.ToBoolean(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == "Did not read byte array properly")
		{
			return Convert.ToSingle(DPNHODJHGJL);
		}
		if (ICMAOHOIGFA == " not exist")
		{
			return Convert.ToInt64(DPNHODJHGJL);
		}
		Debug.LogError("/" + ICMAOHOIGFA);
		return null;
	}

	// Token: 0x06011E80 RID: 73344 RVA: 0x0062AA00 File Offset: 0x00628C00
	public void Init(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = false;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("[SaveSystem] Init from " + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.GetCurrentSaveFileFullPath()))
		{
			try
			{
				this.isSaveLoaded = true;
				streamReader = new StreamReader(this.GetCurrentSaveFileFullPath());
				this.DCAAJFIBFHO = true;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.Decrypt(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("[SaveSystem] Outdated savefile found");
				streamReader.Dispose();
				File.Delete(this.GetCurrentSaveFileFullPath());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 0 && this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == '\n')
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(0, this.MKNDAKMBCLN.Length - 1);
				if (this.MKNDAKMBCLN.Length > 0 && this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == '\r')
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(0, this.MKNDAKMBCLN.Length - 1);
				}
			}
			this.LPFHGFAOHDB = this.BIGOMICKFNL(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011E81 RID: 73345 RVA: 0x00629488 File Offset: 0x00627688
	public long OPJHKEDENOM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1L;
	}

	// Token: 0x06011E82 RID: 73346 RVA: 0x0062ABAC File Offset: 0x00628DAC
	public bool FOOKGGNJIOO()
	{
		return this.DCAAJFIBFHO;
	}

	// Token: 0x06011E83 RID: 73347 RVA: 0x00628711 File Offset: 0x00626911
	public string CFLCJCJHNKD(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E84 RID: 73348 RVA: 0x0062ABB4 File Offset: 0x00628DB4
	public void KACPCCMPAHA()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().PNEHIPCCEKG("settings.shaders.bloomintencity", new DebugCommands.DebugCommand(this.FBHNGMCCLIH), "Call ConnectToNameServer to ping available regions.", "[ItemsHandler] Found ", true);
	}

	// Token: 0x06011E85 RID: 73349 RVA: 0x00628AFB File Offset: 0x00626CFB
	public string CKJPNOHLJJO(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E86 RID: 73350 RVA: 0x0062ABE2 File Offset: 0x00628DE2
	public string DMHMPFGBLFB()
	{
		return new FileInfo(Helpers.GetDirectory("Anomaly_Far") + "CameraFilterPack/AAA_Blood_Plus" + this.CBOCAHLJCGP() + "Menu").FullName;
	}

	// Token: 0x06011E87 RID: 73351 RVA: 0x0062AC10 File Offset: 0x00628E10
	private Hashtable HBODFCNABOJ(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[1] = "_TimeX";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array2)
		{
			string[] array4 = text.Split(new string[]
			{
				"SpawnObj"
			}, StringSplitOptions.None);
			hashtable.Add(this.OIIGCJPDLGC(array4[1], SaveSystem.NHICDOHIKAL), this.BBACCHJAFHK(array4[4], this.DeEscapeNonSeperators(array4[1], SaveSystem.NHICDOHIKAL)));
			if (array4.Length > 7)
			{
				Debug.LogWarning(". ActorNr: " + array4.Length + "_DiffuseColor");
			}
		}
		return hashtable;
	}

	// Token: 0x06011E88 RID: 73352 RVA: 0x0062ACC8 File Offset: 0x00628EC8
	public string JGBGEJEBLOO(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i += 0)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("Tab2Content" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("_Value", "Set environment sprite color and alpha.");
		return MIECKJBDFLA;
	}

	// Token: 0x06011E89 RID: 73353 RVA: 0x006287B7 File Offset: 0x006269B7
	public void SetString(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E8A RID: 73354 RVA: 0x0062AD14 File Offset: 0x00628F14
	public void BEMECPDKOCA(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = true;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("_ScreenResolution" + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.DMHMPFGBLFB()))
		{
			try
			{
				this.isSaveLoaded = true;
				streamReader = new StreamReader(this.DMHMPFGBLFB());
				this.DCAAJFIBFHO = false;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.JNPEKFHDAIG(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("MapFolderInputField");
				streamReader.Dispose();
				File.Delete(this.DMHMPFGBLFB());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 0 && this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == '\u0004')
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(0, this.MKNDAKMBCLN.Length - 0);
				if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 0] == -107)
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 0);
				}
			}
			this.LPFHGFAOHDB = this.MFDHLPDDJJF(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011E8B RID: 73355 RVA: 0x0062AEC0 File Offset: 0x006290C0
	public void LCKKDMKJJEF(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = true;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("_MainTex" + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.LDHKINFNJCH()))
		{
			try
			{
				this.isSaveLoaded = true;
				streamReader = new StreamReader(this.OBHPKLFMFOO());
				this.DCAAJFIBFHO = true;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("_ScreenResolution");
				streamReader.Dispose();
				File.Delete(this.LDHKINFNJCH());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 0 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == -102)
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 1);
				if (this.MKNDAKMBCLN.Length > 0 && this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == 'R')
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 1);
				}
			}
			this.LPFHGFAOHDB = this.EFCAPLBAPLL(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011E8C RID: 73356 RVA: 0x0062ABAC File Offset: 0x00628DAC
	public bool WasReadPlayerPrefsFileEncrypted()
	{
		return this.DCAAJFIBFHO;
	}

	// Token: 0x06011E8D RID: 73357 RVA: 0x0062B06C File Offset: 0x0062926C
	public void NCNNFONPMLD(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E8E RID: 73358 RVA: 0x0062873B File Offset: 0x0062693B
	public int GetInt(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E8F RID: 73359 RVA: 0x00628711 File Offset: 0x00626911
	public string GetString(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	// Token: 0x06011E90 RID: 73360 RVA: 0x00628779 File Offset: 0x00626979
	public bool GetBool(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E91 RID: 73361 RVA: 0x0062B0BC File Offset: 0x006292BC
	private void FBHNGMCCLIH(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[1] == "init")
			{
				this.Init(null);
			}
		}
		else
		{
			if (BDGDDFKKGGA[1] == "init")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("Bad parameters for init! Use \"init\" or \"init <savename>\"");
				}
				else
				{
					this.Init(BDGDDFKKGGA[2]);
				}
			}
			if (BDGDDFKKGGA[1] == "setint")
			{
				if (BDGDDFKKGGA.Length != 4)
				{
					Debug.LogError("Bad parameters for setint! Use <key> <value>");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[2], int.Parse(BDGDDFKKGGA[3], NumberStyles.Integer), null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "getint")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("Bad parameters for getint! Use <key> <value>");
				}
				else
				{
					Debug.Log(string.Concat(new object[]
					{
						"Result for ",
						BDGDDFKKGGA[2],
						" : ",
						Singleton<SaveSystem>.Instance.GetInt(BDGDDFKKGGA[2], null)
					}));
				}
			}
			if (BDGDDFKKGGA[1] == "setstring")
			{
				if (BDGDDFKKGGA.Length != 4)
				{
					Debug.LogError("Bad parameters for setstring! Use <key> <value>");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[2], BDGDDFKKGGA[3], null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "getstring")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("Bad parameters for getstring! Use <key> <value>");
				}
				else
				{
					Debug.Log("Result for " + BDGDDFKKGGA[2] + " : " + Singleton<SaveSystem>.Instance.GetString(BDGDDFKKGGA[2], null));
				}
			}
			if (BDGDDFKKGGA[1] == "setbool")
			{
				if (BDGDDFKKGGA.Length != 4)
				{
					Debug.LogError("Bad parameters for setbool! Use <key> <value>");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetBool(BDGDDFKKGGA[2], bool.Parse(BDGDDFKKGGA[3]), null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "getbool")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("Bad parameters for getbool! Use <key> <value>");
				}
				else
				{
					Debug.Log(string.Concat(new object[]
					{
						"Result for ",
						BDGDDFKKGGA[2],
						" : ",
						Singleton<SaveSystem>.Instance.GetBool(BDGDDFKKGGA[2], null)
					}));
				}
			}
			if (BDGDDFKKGGA[1] == "setfloat")
			{
				if (BDGDDFKKGGA.Length != 4)
				{
					Debug.LogError("Bad parameters for setbool! Use <key> <value>");
				}
				else
				{
					Singleton<SaveSystem>.Instance.SetFloat(BDGDDFKKGGA[2], float.Parse(BDGDDFKKGGA[3], NumberStyles.Float), null);
					Singleton<SaveSystem>.Instance.Flush();
				}
			}
			if (BDGDDFKKGGA[1] == "getfloat")
			{
				if (BDGDDFKKGGA.Length != 3)
				{
					Debug.LogError("Bad parameters for getbool! Use <key> <value>");
				}
				else
				{
					Debug.Log(string.Concat(new object[]
					{
						"Result for ",
						BDGDDFKKGGA[2],
						" : ",
						Singleton<SaveSystem>.Instance.GetFloat(BDGDDFKKGGA[2], null)
					}));
				}
			}
			if (BDGDDFKKGGA[1] == "delete")
			{
				if (BDGDDFKKGGA.Length != 2)
				{
					Debug.LogError("Bad parameters for delete! Use <key>");
				}
				else
				{
					Singleton<SaveSystem>.Instance.DeleteKey(BDGDDFKKGGA[2], null);
				}
			}
			if (BDGDDFKKGGA[1] == "deleteall")
			{
				Singleton<SaveSystem>.Instance.DeleteAll(null);
			}
			if (BDGDDFKKGGA[1] == "path")
			{
				Debug.Log("Save Path: " + Singleton<SaveSystem>.Instance.GetCurrentSaveFileFullPath());
			}
		}
	}

	// Token: 0x06011E92 RID: 73362 RVA: 0x00628D55 File Offset: 0x00626F55
	public float MFNCMBBPJPA(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011E93 RID: 73363 RVA: 0x00628A5F File Offset: 0x00626C5F
	public string GetCurrentSaveFileName()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	// Token: 0x06011E94 RID: 73364 RVA: 0x0062ABAC File Offset: 0x00628DAC
	public bool CLFHNNGOLLE()
	{
		return this.DCAAJFIBFHO;
	}

	// Token: 0x06011E96 RID: 73366 RVA: 0x00628C09 File Offset: 0x00626E09
	public long BGPHABHGHOG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011E97 RID: 73367 RVA: 0x00628A6B File Offset: 0x00626C6B
	public bool FMEACBHGAMN(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) && (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011E98 RID: 73368 RVA: 0x0062B484 File Offset: 0x00629684
	public void LBFFJLFBOAM(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011E99 RID: 73369 RVA: 0x00628708 File Offset: 0x00626908
	public void KEFLOGFADKN(bool CKALCHJAFBE)
	{
		this.HCHMCODLILK = CKALCHJAFBE;
	}

	// Token: 0x06011E9A RID: 73370 RVA: 0x0062B4D1 File Offset: 0x006296D1
	public new void NLNAJMCBNDC()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().PNEHIPCCEKG("_TimeX", new DebugCommands.DebugCommand(this.CNGKFIDOMNJ), "_RangeScale", "LoadMapCanvas", true);
	}

	// Token: 0x06011E9C RID: 73372 RVA: 0x0062B53C File Offset: 0x0062973C
	public void OJNNEODGPAB(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E9D RID: 73373 RVA: 0x0062B58C File Offset: 0x0062978C
	public void IJOPEHKBHHH(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011E9E RID: 73374 RVA: 0x006299A7 File Offset: 0x00627BA7
	public void IPCGLFKIANM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	// Token: 0x06011E9F RID: 73375 RVA: 0x0062B5DC File Offset: 0x006297DC
	public void CAJFKNFJEKC(string NKAFFBEECFN = null)
	{
		this.OONKHMECOCF = false;
		this.GPJGHDBMDGN = string.Empty;
		this.MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			this.currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("curScn" + this.currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(this.LDHKINFNJCH()))
		{
			try
			{
				this.isSaveLoaded = true;
				streamReader = new StreamReader(this.OBHPKLFMFOO());
				this.DCAAJFIBFHO = false;
				this.MKNDAKMBCLN = ((!this.HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.JJNLMGPCNAA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("/");
				streamReader.Dispose();
				File.Delete(this.DMHMPFGBLFB());
			}
		}
		this.LPFHGFAOHDB.Clear();
		if (!string.IsNullOrEmpty(this.MKNDAKMBCLN))
		{
			if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 0] == -96)
			{
				this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(1, this.MKNDAKMBCLN.Length - 1);
				if (this.MKNDAKMBCLN.Length > 1 && (int)this.MKNDAKMBCLN[this.MKNDAKMBCLN.Length - 1] == -116)
				{
					this.MKNDAKMBCLN = this.MKNDAKMBCLN.Substring(0, this.MKNDAKMBCLN.Length - 0);
				}
			}
			this.LPFHGFAOHDB = this.NGDPMOOODLJ(this.MKNDAKMBCLN);
		}
	}

	// Token: 0x06011EA0 RID: 73376 RVA: 0x00628A6B File Offset: 0x00626C6B
	public bool NCJHMLPICPD(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK) && (bool)LPFHGFAOHDB[HFEFHOPOLIK];
	}

	// Token: 0x06011EA1 RID: 73377 RVA: 0x0062B788 File Offset: 0x00629988
	public string OIIGCJPDLGC(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("Value" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace(" SphereWaveform.cs", "_Value2");
		return MIECKJBDFLA;
	}

	// Token: 0x06011EA2 RID: 73378 RVA: 0x0062B7D4 File Offset: 0x006299D4
	public void GFDEHODEHFF(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011EA3 RID: 73379 RVA: 0x0062B824 File Offset: 0x00629A24
	private Hashtable MFDHLPDDJJF(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[1] = "_FarCorner";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 0; i < array3.Length; i += 0)
		{
			string text = array3[i];
			string text2 = text;
			string[] array4 = new string[0];
			array4[1] = " Remote called.";
			string[] array5 = text2.Split(array4, StringSplitOptions.RemoveEmptyEntries);
			hashtable.Add(this.DeEscapeNonSeperators(array5[1], SaveSystem.NHICDOHIKAL), this.BPIEDCMEDFP(array5[1], this.JGBGEJEBLOO(array5[0], SaveSystem.NHICDOHIKAL)));
			if (array5.Length > 5)
			{
				Debug.LogWarning("_Value" + array5.Length + "Down");
			}
		}
		return hashtable;
	}

	// Token: 0x06011EA4 RID: 73380 RVA: 0x0062B8DC File Offset: 0x00629ADC
	public void HBIGPMNAPHA(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011EA5 RID: 73381 RVA: 0x00628F7B File Offset: 0x0062717B
	public bool JJKIDIIMABB(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011EA6 RID: 73382 RVA: 0x00628C09 File Offset: 0x00626E09
	public long GMBPBPENDKK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	// Token: 0x06011EA7 RID: 73383 RVA: 0x0062B92C File Offset: 0x00629B2C
	private string LAAAPBGKNGH(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("13");
				stringBuilder.Append("OnEvent: {0}");
				stringBuilder.Append("Can't set Room.MaxPlayers to: ");
			}
			stringBuilder.Append(this.OHHMNLEFOOK(enumerator.Key.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append("_ScreenResolution");
			stringBuilder.Append("\n");
			stringBuilder.Append("[Up]");
			stringBuilder.Append(this.OOLELLHJHAC(enumerator.Value.ToString(), SaveSystem.NHICDOHIKAL));
			stringBuilder.Append("GlassesColor2");
			stringBuilder.Append("_Alpha");
			stringBuilder.Append("LevelEditor/patterns");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06011EA8 RID: 73384 RVA: 0x0062BA34 File Offset: 0x00629C34
	public void NHOJIMDBIHI(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = false;
	}

	// Token: 0x06011EA9 RID: 73385 RVA: 0x00628F7B File Offset: 0x0062717B
	public bool ADKHKNJOJEH(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		this.OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	// Token: 0x06011EAA RID: 73386 RVA: 0x0062BA81 File Offset: 0x00629C81
	public float PEBDFGFNFBE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 371f;
	}

	// Token: 0x06011EAB RID: 73387 RVA: 0x00628708 File Offset: 0x00626908
	public void CONNKAEAOIM(bool CKALCHJAFBE)
	{
		this.HCHMCODLILK = CKALCHJAFBE;
	}

	// Token: 0x06011EAC RID: 73388 RVA: 0x0062BAB0 File Offset: 0x00629CB0
	public void CMLFCHINKCH(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		this.OONKHMECOCF = true;
	}

	// Token: 0x06011EAD RID: 73389 RVA: 0x0062BAFD File Offset: 0x00629CFD
	public string LDHKINFNJCH()
	{
		return new FileInfo(Helpers.GetDirectory("_Value2") + "-1" + this.OJLJAANBMBH() + "_Intensity").FullName;
	}

	// Token: 0x06011EAE RID: 73390 RVA: 0x006299A7 File Offset: 0x00627BA7
	public void BPBJMCANMOP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	// Token: 0x04001F84 RID: 8068
	public string folder;

	// Token: 0x04001F85 RID: 8069
	public string currentSaveFileName = "???";

	// Token: 0x04001F86 RID: 8070
	private Hashtable LPFHGFAOHDB = new Hashtable();

	// Token: 0x04001F87 RID: 8071
	private bool OONKHMECOCF;

	// Token: 0x04001F88 RID: 8072
	private string GPJGHDBMDGN = string.Empty;

	// Token: 0x04001F89 RID: 8073
	private string MKNDAKMBCLN = string.Empty;

	// Token: 0x04001F8A RID: 8074
	private const string IFBBHFHOHIH = ";";

	// Token: 0x04001F8B RID: 8075
	private const string GODIINNKFGL = ":";

	// Token: 0x04001F8C RID: 8076
	private static string[] NHICDOHIKAL = new string[]
	{
		";",
		":"
	};

	// Token: 0x04001F8D RID: 8077
	private bool DCAAJFIBFHO;

	// Token: 0x04001F8E RID: 8078
	private bool HCHMCODLILK = true;

	// Token: 0x04001F8F RID: 8079
	[HideInInspector]
	public bool isSaveLoaded;
}
