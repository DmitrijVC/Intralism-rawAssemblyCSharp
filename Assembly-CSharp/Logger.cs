using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000487 RID: 1159
public class Logger : MonoBehaviour
{
	// Token: 0x060109D8 RID: 68056 RVA: 0x005A1B3D File Offset: 0x0059FD3D
	private void HIFPDKKBDHJ()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.EBLJADHOKJM));
	}

	// Token: 0x060109D9 RID: 68057 RVA: 0x005A1B50 File Offset: 0x0059FD50
	private void JCDPMLPNOOC()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LELHKMNAOFJ));
	}

	// Token: 0x060109DA RID: 68058 RVA: 0x005A1B64 File Offset: 0x0059FD64
	private void OGBJNAAAEGI()
	{
		GUILayout.BeginArea(new Rect(1798f, (float)(Screen.height - -125), (float)Screen.width, 223f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109DB RID: 68059 RVA: 0x005A1BF0 File Offset: 0x0059FDF0
	private void MINMKOCOLEP()
	{
		GUILayout.BeginArea(new Rect(194f, (float)(Screen.height - 110), (float)Screen.width, 87f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109DC RID: 68060 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void PKBENONAOOL()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109DD RID: 68061 RVA: 0x005A1C84 File Offset: 0x0059FE84
	private void OBMOJJOCAPP(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "EventTimeInputField" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109DE RID: 68062 RVA: 0x005A1CC0 File Offset: 0x0059FEC0
	private void HHODKHPIBLG()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.MPAENEEBCKH));
	}

	// Token: 0x060109DF RID: 68063 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void NJHJHBOJKIC()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109E0 RID: 68064 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void FKEJGBFDCAH()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109E1 RID: 68065 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void PHJLHCMCCKE()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109E2 RID: 68066 RVA: 0x005A1CD3 File Offset: 0x0059FED3
	private void LOLHKNKBNPF()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.OBMOJJOCAPP));
	}

	// Token: 0x060109E3 RID: 68067 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void BFEILOMHNPC()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109E4 RID: 68068 RVA: 0x005A1CE6 File Offset: 0x0059FEE6
	private void EHKDADOGHFN(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "#" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 8)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109E5 RID: 68069 RVA: 0x005A1D24 File Offset: 0x0059FF24
	private void GAMPNFOIFHF()
	{
		GUILayout.BeginArea(new Rect(825f, (float)(Screen.height - -32), (float)Screen.width, 1340f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109E6 RID: 68070 RVA: 0x005A1DB0 File Offset: 0x0059FFB0
	private void DLLHJCMGHBH(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "_MainTex2" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109E7 RID: 68071 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void BNEJMABFKJE()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109E8 RID: 68072 RVA: 0x005A1DEC File Offset: 0x0059FFEC
	private void EDENDHOGJKD(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "player.arrow" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 1)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109E9 RID: 68073 RVA: 0x005A1E28 File Offset: 0x005A0028
	private void EFKEIPHOGEK(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "_Value" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109EA RID: 68074 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void GJAJBMGGPFB()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109EB RID: 68075 RVA: 0x005A1E64 File Offset: 0x005A0064
	private void GBLCBDLMOFF(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "CameraFilterPack_3D_Matrix1" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 6)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109EC RID: 68076 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void JLNNHKPHMAB()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109ED RID: 68077 RVA: 0x005A1EA0 File Offset: 0x005A00A0
	private void PNEKMLABFCE()
	{
		GUILayout.BeginArea(new Rect(804f, (float)(Screen.height - -168), (float)Screen.width, 1425f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109EE RID: 68078 RVA: 0x005A1F2C File Offset: 0x005A012C
	private void OGAIIBPLJBB()
	{
		GUILayout.BeginArea(new Rect(69f, (float)(Screen.height - -176), (float)Screen.width, 1938f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109EF RID: 68079 RVA: 0x005A1FB8 File Offset: 0x005A01B8
	private void PCABPJAANFH()
	{
		GUILayout.BeginArea(new Rect(1803f, (float)(Screen.height - 87), (float)Screen.width, 872f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109F0 RID: 68080 RVA: 0x005A2044 File Offset: 0x005A0244
	private void MLFACDCDMAL()
	{
		GUILayout.BeginArea(new Rect(515f, (float)(Screen.height - -115), (float)Screen.width, 1580f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109F1 RID: 68081 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void FGBDGGCBFLP()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109F2 RID: 68082 RVA: 0x005A20D0 File Offset: 0x005A02D0
	private void FFJMMBGFDMD()
	{
		GUILayout.BeginArea(new Rect(103f, (float)(Screen.height - 29), (float)Screen.width, 532f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x060109F3 RID: 68083 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void KKEOHFGKCIK()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109F4 RID: 68084 RVA: 0x005A215C File Offset: 0x005A035C
	private void MNNOAGMLLKC(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "Vertical" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 3)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109F5 RID: 68085 RVA: 0x005A2198 File Offset: 0x005A0398
	private void EOLODLFCNIK(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "Set sun audio input" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109F6 RID: 68086 RVA: 0x005A1B3D File Offset: 0x0059FD3D
	private void MHGPANIBBCM()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.EBLJADHOKJM));
	}

	// Token: 0x060109F7 RID: 68087 RVA: 0x005A21D4 File Offset: 0x005A03D4
	private void OOBIMFILNED()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LKODNGNIAMC));
	}

	// Token: 0x060109F8 RID: 68088 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void OnDisable()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109F9 RID: 68089 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void FDPOFMCFBMF()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109FA RID: 68090 RVA: 0x005A21E7 File Offset: 0x005A03E7
	private void LGNOEEIBCHM(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "_Value3" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 0)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109FB RID: 68091 RVA: 0x005A1CD3 File Offset: 0x0059FED3
	private void JPPGIKCKFJL()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.OBMOJJOCAPP));
	}

	// Token: 0x060109FC RID: 68092 RVA: 0x005A2223 File Offset: 0x005A0423
	private void LLAJPKFNDIG()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLLHJCMGHBH));
	}

	// Token: 0x060109FD RID: 68093 RVA: 0x005A2236 File Offset: 0x005A0436
	private void OPFFIDFDNGC(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "#,0" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 5)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x060109FE RID: 68094 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void BKGJOECFMID()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x060109FF RID: 68095 RVA: 0x005A2272 File Offset: 0x005A0472
	private void KCCFBHBFBDF(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "Triangle" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 7)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A00 RID: 68096 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void JOJFHFHOCHO()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A01 RID: 68097 RVA: 0x005A22B0 File Offset: 0x005A04B0
	private void FBDOGLBMDNG()
	{
		GUILayout.BeginArea(new Rect(800f, (float)(Screen.height - 163), (float)Screen.width, 678f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A02 RID: 68098 RVA: 0x005A233C File Offset: 0x005A053C
	private void JOLDLHDBPDP(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 1)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A03 RID: 68099 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void ICDBMJKMIKC()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A04 RID: 68100 RVA: 0x005A2378 File Offset: 0x005A0578
	private void LKODNGNIAMC(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + " - " + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 5)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A05 RID: 68101 RVA: 0x005A23B4 File Offset: 0x005A05B4
	private void LIIEJAHOGFL()
	{
		GUILayout.BeginArea(new Rect(1032f, (float)(Screen.height - -59), (float)Screen.width, 687f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A06 RID: 68102 RVA: 0x005A2440 File Offset: 0x005A0640
	private void EBLJADHOKJM(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "EventMenu" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A07 RID: 68103 RVA: 0x005A2223 File Offset: 0x005A0423
	private void MEJPBKFMAIG()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLLHJCMGHBH));
	}

	// Token: 0x06010A08 RID: 68104 RVA: 0x005A247C File Offset: 0x005A067C
	private void AHNBAOIENOO()
	{
		GUILayout.BeginArea(new Rect(1813f, (float)(Screen.height - 145), (float)Screen.width, 1859f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A09 RID: 68105 RVA: 0x005A1B3D File Offset: 0x0059FD3D
	private void ENDDDMALLBK()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.EBLJADHOKJM));
	}

	// Token: 0x06010A0A RID: 68106 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void ODGMCJILIHF()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A0B RID: 68107 RVA: 0x005A2508 File Offset: 0x005A0708
	private void OLAGABIMGDA()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.OPFFIDFDNGC));
	}

	// Token: 0x06010A0C RID: 68108 RVA: 0x005A21D4 File Offset: 0x005A03D4
	private void OnEnable()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LKODNGNIAMC));
	}

	// Token: 0x06010A0D RID: 68109 RVA: 0x005A251B File Offset: 0x005A071B
	private void LELHKMNAOFJ(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "Joystick1Button2" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 6)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A0E RID: 68110 RVA: 0x005A2557 File Offset: 0x005A0757
	private void DGEPPDJDBLN()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.NFCPBHAIMPI));
	}

	// Token: 0x06010A0F RID: 68111 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void ALMGMOOHLMA()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A10 RID: 68112 RVA: 0x005A256A File Offset: 0x005A076A
	private void LNIOFCGDDKP()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.JOLDLHDBPDP));
	}

	// Token: 0x06010A11 RID: 68113 RVA: 0x005A1B3D File Offset: 0x0059FD3D
	private void EJNKBOLGHJC()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.EBLJADHOKJM));
	}

	// Token: 0x06010A12 RID: 68114 RVA: 0x005A2580 File Offset: 0x005A0780
	private void AHAIBKMLNAP()
	{
		GUILayout.BeginArea(new Rect(874f, (float)(Screen.height - -188), (float)Screen.width, 256f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A13 RID: 68115 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void MFLBEJHMEMO()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A14 RID: 68116 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void NAALCEPIHCH()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A15 RID: 68117 RVA: 0x005A260C File Offset: 0x005A080C
	private void MMMAEAEEJLP(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "_ScreenResolution" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A16 RID: 68118 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void IFJDKDFLGBG()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A17 RID: 68119 RVA: 0x005A2648 File Offset: 0x005A0848
	private void HPGKMAIPDEO()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.MMMAEAEEJLP));
	}

	// Token: 0x06010A19 RID: 68121 RVA: 0x005A2648 File Offset: 0x005A0848
	private void OCHMKJKBAPI()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.MMMAEAEEJLP));
	}

	// Token: 0x06010A1A RID: 68122 RVA: 0x005A265C File Offset: 0x005A085C
	private void OnGUI()
	{
		GUILayout.BeginArea(new Rect(0f, (float)(Screen.height - 140), (float)Screen.width, 140f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A1B RID: 68123 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void MGFFNGEGFDC()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A1C RID: 68124 RVA: 0x005A26E8 File Offset: 0x005A08E8
	private void LGMADMDBKNE()
	{
		GUILayout.BeginArea(new Rect(518f, (float)(Screen.height - -2), (float)Screen.width, 1286f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A1D RID: 68125 RVA: 0x005A2774 File Offset: 0x005A0974
	private void OLFFIKHJIEO()
	{
		GUILayout.BeginArea(new Rect(956f, (float)(Screen.height - 106), (float)Screen.width, 584f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A1E RID: 68126 RVA: 0x005A1C7C File Offset: 0x0059FE7C
	private void IEFMONDKKJN()
	{
		Application.RegisterLogCallback(null);
	}

	// Token: 0x06010A1F RID: 68127 RVA: 0x005A2800 File Offset: 0x005A0A00
	private void NFCPBHAIMPI(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "InventoryGrid" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 2)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A20 RID: 68128 RVA: 0x005A283C File Offset: 0x005A0A3C
	private void MPAENEEBCKH(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "_Intensity" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 7)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A21 RID: 68129 RVA: 0x005A1B50 File Offset: 0x0059FD50
	private void PPFGHAKKLMN()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LELHKMNAOFJ));
	}

	// Token: 0x06010A22 RID: 68130 RVA: 0x005A21D4 File Offset: 0x005A03D4
	private void PAHNKEGFGHB()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.LKODNGNIAMC));
	}

	// Token: 0x06010A23 RID: 68131 RVA: 0x005A2878 File Offset: 0x005A0A78
	private void NGGLCOLOLHF()
	{
		GUILayout.BeginArea(new Rect(1998f, (float)(Screen.height - 38), (float)Screen.width, 1400f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A24 RID: 68132 RVA: 0x005A2904 File Offset: 0x005A0B04
	private void KGNKDPBGJHC()
	{
		GUILayout.BeginArea(new Rect(244f, (float)(Screen.height - -165), (float)Screen.width, 12f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A25 RID: 68133 RVA: 0x005A2990 File Offset: 0x005A0B90
	private void DDOMIEPBBBI()
	{
		GUILayout.BeginArea(new Rect(811f, (float)(Screen.height - 49), (float)Screen.width, 1710f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[0]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A26 RID: 68134 RVA: 0x005A2A1C File Offset: 0x005A0C1C
	private void NEHCNDAFBKE(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "EventMenu" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 5)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A27 RID: 68135 RVA: 0x005A2A58 File Offset: 0x005A0C58
	private void CJFLPGBFBNL()
	{
		GUILayout.BeginArea(new Rect(1776f, (float)(Screen.height - -67), (float)Screen.width, 244f));
		foreach (string text in global::Logger.IBNJECONNLP)
		{
			GUILayout.Label(text, new GUILayoutOption[1]);
		}
		GUILayout.EndArea();
	}

	// Token: 0x06010A28 RID: 68136 RVA: 0x005A2223 File Offset: 0x005A0423
	private void MLLPGPANCHI()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.DLLHJCMGHBH));
	}

	// Token: 0x06010A29 RID: 68137 RVA: 0x005A2AE4 File Offset: 0x005A0CE4
	private void GAKAEDICOHD(string JKPJCEMPAGH, string HAEHALPHBJK, LogType HMGBJCGOLMI)
	{
		global::Logger.IBNJECONNLP.Enqueue(Time.time + "Lightning" + JKPJCEMPAGH);
		if (global::Logger.IBNJECONNLP.Count > 8)
		{
			global::Logger.IBNJECONNLP.Dequeue();
		}
	}

	// Token: 0x06010A2A RID: 68138 RVA: 0x005A2B20 File Offset: 0x005A0D20
	private void LLDBPKHDPKI()
	{
		Application.RegisterLogCallback(new Application.LogCallback(this.EFKEIPHOGEK));
	}

	// Token: 0x04001D28 RID: 7464
	private static Queue<string> IBNJECONNLP = new Queue<string>(6);
}
