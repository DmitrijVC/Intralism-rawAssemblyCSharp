using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

// Token: 0x02000284 RID: 644
public class ScrollingCalendar : MonoBehaviour
{
	// Token: 0x06009BD1 RID: 39889 RVA: 0x003870E2 File Offset: 0x003852E2
	public void LHIBCDLJNBG()
	{
		this.EOICNJIGBKD.BOBALPEINEB();
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x003870F0 File Offset: 0x003852F0
	private void EACLJDHBPAD()
	{
		int[] array = new int[111];
		this.EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.daysButtonPrefab, new Vector3(698f, (float)(i * 86), 1788f), Quaternion.Euler(new Vector3(973f, 155f, 1222f)));
			gameObject.transform.SetParent(this.daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(852f, 1300f, 411f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value3" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EEMJGFOOGKP[i] = gameObject;
		}
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x003871DB File Offset: 0x003853DB
	public void GOAKIFEMHEE()
	{
		this.PIEGNIJFHHN.BOBALPEINEB();
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x003871E8 File Offset: 0x003853E8
	public void PHECBKLKNOI()
	{
		this.EOICNJIGBKD.ScrollUp();
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x003871F8 File Offset: 0x003853F8
	private void NFEFDCAPHHG()
	{
		int num = int.Parse(DateTime.Now.ToString("_TimeX"));
		int[] array = new int[num + 1 - 70];
		this.DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = 148 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.yearsButtonPrefab, new Vector3(1913f, (float)(i * -43), 1150f), Quaternion.Euler(new Vector3(1671f, 1115f, 1124f)));
			gameObject.transform.SetParent(this.yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1728f, 86f, 1077f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#,0.00" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.DEELAEOEEGB[i] = gameObject;
		}
	}

	// Token: 0x06009BD6 RID: 39894 RVA: 0x00387310 File Offset: 0x00385510
	public void JPJNECPABBG()
	{
		this.MDPIBJJLLCI();
		this.KIHIANNCBCE();
		this.KCPPGDJLMHK();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.KIMMMCJFMAB();
		this.PIEGNIJFHHN.KIMMMCJFMAB();
		this.LKGNMCKJEIL.NBGIMIDICKE();
	}

	// Token: 0x06009BD7 RID: 39895 RVA: 0x003873A7 File Offset: 0x003855A7
	public void BEIMJHCKIML()
	{
		this.PIEGNIJFHHN.BNNCONEBKNC();
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x003873B4 File Offset: 0x003855B4
	public void EBNOLAPAKKF()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 0;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 1;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - 141;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.OEJEKPAOHKP(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.OEJEKPAOHKP(this.BPLBGOLDNCN);
	}

	// Token: 0x06009BD9 RID: 39897 RVA: 0x00387440 File Offset: 0x00385640
	private void APBIGIPCJOM()
	{
		int[] array = new int[109];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(323f, (float)(i * -100), 112f), Quaternion.Euler(new Vector3(455f, 1996f, 1007f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(434f, 18f, 1756f);
			switch (i)
			{
			case 0:
				text = "0,1,true,0";
				break;
			case 1:
				text = "_NeighbourMaxTex";
				break;
			case 2:
				text = "\\\"";
				break;
			case 3:
				text = "_Value4";
				break;
			case 4:
				text = "_FixDistance";
				break;
			case 5:
				text = "_NoOuterClip";
				break;
			case 6:
				text = "_ScreenResolution";
				break;
			case 7:
				text = "Joystick1Button5";
				break;
			case 8:
				text = "player.blackcat";
				break;
			case 9:
				text = "Subscribed cells:\n";
				break;
			case 10:
				text = "masterSteamID";
				break;
			case 11:
				text = "public";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "masterSteamID" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x003875DD File Offset: 0x003857DD
	public void CGFHHDMEAKH()
	{
		this.PIEGNIJFHHN.ScrollDown();
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x003875EC File Offset: 0x003857EC
	public void JEEINPBLBDI()
	{
		this.NFEFDCAPHHG();
		this.AKKGPGEBFDC();
		this.LAECMIJGBNO();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.Start();
		this.PIEGNIJFHHN.Start();
		this.LKGNMCKJEIL.KIMMMCJFMAB();
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x00387683 File Offset: 0x00385883
	public void NBNJJBJCICN()
	{
		this.PIEGNIJFHHN.ScrollUp();
	}

	// Token: 0x06009BDD RID: 39901 RVA: 0x00387690 File Offset: 0x00385890
	public void SetDate()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 1;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 1;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - 1900;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.SnapToElement(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.SnapToElement(this.BPLBGOLDNCN);
	}

	// Token: 0x06009BDE RID: 39902 RVA: 0x0038771C File Offset: 0x0038591C
	private void MDPIBJJLLCI()
	{
		int num = int.Parse(DateTime.Now.ToString("yyyy"));
		int[] array = new int[num + 1 - 1900];
		this.DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 1900 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.yearsButtonPrefab, new Vector3(0f, (float)(i * 80), 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(this.yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Year_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.DEELAEOEEGB[i] = gameObject;
		}
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x00387834 File Offset: 0x00385A34
	private void KCPPGDJLMHK()
	{
		int[] array = new int[31];
		this.EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.daysButtonPrefab, new Vector3(0f, (float)(i * 80), 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(this.daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "Day_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EEMJGFOOGKP[i] = gameObject;
		}
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x00387920 File Offset: 0x00385B20
	public void MADENBGHKDD()
	{
		this.BNGGHDJFHAP();
		this.APBIGIPCJOM();
		this.KCPPGDJLMHK();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.Start();
		this.PIEGNIJFHHN.Start();
		this.LKGNMCKJEIL.KIMMMCJFMAB();
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x003870E2 File Offset: 0x003852E2
	public void LDLCJEELGCF()
	{
		this.EOICNJIGBKD.BOBALPEINEB();
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x003879B8 File Offset: 0x00385BB8
	private void OJLEBPNCCOC()
	{
		int[] array = new int[-29];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(1350f, (float)(i * -74), 1329f), Quaternion.Euler(new Vector3(51f, 222f, 1328f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1536f, 1139f, 345f);
			switch (i)
			{
			case 0:
				text = "maps.";
				break;
			case 1:
				text = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
				break;
			case 2:
				text = ".lastCheckpoint.perfectHits";
				break;
			case 3:
				text = "Set camera (or player) distance. Base player distance - 14";
				break;
			case 4:
				text = "LoadMapCanvas";
				break;
			case 5:
				text = "menu.selectedplaymode";
				break;
			case 6:
				text = "EventSystem";
				break;
			case 7:
				text = "_Offsets";
				break;
			case 8:
				text = "win";
				break;
			case 9:
				text = "/";
				break;
			case 10:
				text = "CameraFilterPack/NightVision_4";
				break;
			case 11:
				text = " Owner called.";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = " in SaveLoadMenu.prefabDictionary!" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009BE3 RID: 39907 RVA: 0x00387B58 File Offset: 0x00385D58
	private void LAECMIJGBNO()
	{
		int[] array = new int[80];
		this.EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.daysButtonPrefab, new Vector3(1901f, (float)(i * -22), 1717f), Quaternion.Euler(new Vector3(1683f, 677f, 946f)));
			gameObject.transform.SetParent(this.daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1787f, 462f, 365f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "#C8C8C8FF" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EEMJGFOOGKP[i] = gameObject;
		}
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x00387C44 File Offset: 0x00385E44
	private void Update()
	{
		this.EOICNJIGBKD.Update();
		this.PIEGNIJFHHN.Update();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.GetResults();
		string results = this.EOICNJIGBKD.GetResults();
		string results2 = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("1") && text != "11")
		{
			text += "st";
		}
		else if (text.EndsWith("2") && text != "12")
		{
			text += "nd";
		}
		else if (text.EndsWith("3") && text != "13")
		{
			text += "rd";
		}
		else
		{
			text += "th";
		}
		this.dateText.text = string.Concat(new string[]
		{
			results,
			" ",
			text,
			" ",
			results2
		});
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x003871E8 File Offset: 0x003853E8
	public void MonthsScrollUp()
	{
		this.EOICNJIGBKD.ScrollUp();
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x00387D67 File Offset: 0x00385F67
	public void DaysScrollUp()
	{
		this.LKGNMCKJEIL.ScrollUp();
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x00387D74 File Offset: 0x00385F74
	private void NGOCBEDJHMD()
	{
		int[] array = new int[88];
		this.EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = i + 1;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.daysButtonPrefab, new Vector3(682f, (float)(i * -73), 528f), Quaternion.Euler(new Vector3(89f, 1103f, 535f)));
			gameObject.transform.SetParent(this.daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(62f, 966f, 225f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "GameMessagesDurationSlider" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EEMJGFOOGKP[i] = gameObject;
		}
	}

	// Token: 0x06009BE8 RID: 39912 RVA: 0x003875DD File Offset: 0x003857DD
	public void YearsScrollDown()
	{
		this.PIEGNIJFHHN.ScrollDown();
	}

	// Token: 0x06009BE9 RID: 39913 RVA: 0x00387E60 File Offset: 0x00386060
	private void CCKIHJDLABK()
	{
		int num = int.Parse(DateTime.Now.ToString(": "));
		int[] array = new int[num + 1 - 64];
		this.DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = -127 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.yearsButtonPrefab, new Vector3(1388f, (float)(i * 90), 1878f), Quaternion.Euler(new Vector3(718f, 1088f, 803f)));
			gameObject.transform.SetParent(this.yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(481f, 1065f, 1584f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value2" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.DEELAEOEEGB[i] = gameObject;
		}
	}

	// Token: 0x06009BEA RID: 39914 RVA: 0x00387F78 File Offset: 0x00386178
	public void Awake()
	{
		this.MDPIBJJLLCI();
		this.AKKGPGEBFDC();
		this.KCPPGDJLMHK();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.Start();
		this.PIEGNIJFHHN.Start();
		this.LKGNMCKJEIL.Start();
	}

	// Token: 0x06009BEB RID: 39915 RVA: 0x00388010 File Offset: 0x00386210
	private void GHILDCBCDJI()
	{
		this.EOICNJIGBKD.NKLIHNJCHOG();
		this.PIEGNIJFHHN.Update();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.GetResults();
		string text2 = this.EOICNJIGBKD.EEOPGLMHLLK();
		string results = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("<b>") && text != "maps.")
		{
			text += "Item ";
		}
		else if (text.EndsWith("CameraFilterPack/3D_Computer") && text != "other.dust2")
		{
			text += "SetParticlesCountPerBeat";
		}
		else if (text.EndsWith("BitsData") && text != "ChangeSelectedLevel")
		{
			text += "_ScreenResolution";
		}
		else
		{
			text += "GlassDistortion";
		}
		Text text3 = this.dateText;
		string[] array = new string[3];
		array[1] = text2;
		array[1] = "\t";
		array[7] = text;
		array[0] = "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)";
		array[8] = results;
		text3.text = string.Concat(array);
	}

	// Token: 0x06009BEC RID: 39916 RVA: 0x00388134 File Offset: 0x00386334
	public void FNNGOIEOCCH()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 0;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 1;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - -129;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.DNDJKEDIKLD(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.SnapToElement(this.BPLBGOLDNCN);
	}

	// Token: 0x06009BED RID: 39917 RVA: 0x003881C0 File Offset: 0x003863C0
	private void AKKGPGEBFDC()
	{
		int[] array = new int[12];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(0f, (float)(i * 80), 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			switch (i)
			{
			case 0:
				text = "Jan";
				break;
			case 1:
				text = "Feb";
				break;
			case 2:
				text = "Mar";
				break;
			case 3:
				text = "Apr";
				break;
			case 4:
				text = "May";
				break;
			case 5:
				text = "Jun";
				break;
			case 6:
				text = "Jul";
				break;
			case 7:
				text = "Aug";
				break;
			case 8:
				text = "Sep";
				break;
			case 9:
				text = "Oct";
				break;
			case 10:
				text = "Nov";
				break;
			case 11:
				text = "Dec";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Month_" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009BEE RID: 39918 RVA: 0x00388360 File Offset: 0x00386560
	public void KKHOLABOGGI()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 1;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 1;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - 185;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.DNDJKEDIKLD(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.SnapToElement(this.BPLBGOLDNCN);
	}

	// Token: 0x06009BEF RID: 39919 RVA: 0x003883EC File Offset: 0x003865EC
	public void DaysScrollDown()
	{
		this.LKGNMCKJEIL.ScrollDown();
	}

	// Token: 0x06009BF0 RID: 39920 RVA: 0x003883FC File Offset: 0x003865FC
	public void LOMHIIKFFEP()
	{
		this.PGKLGKFHAGE();
		this.AHLDDGKBPMC();
		this.EACLJDHBPAD();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.KIMMMCJFMAB();
		this.PIEGNIJFHHN.KIMMMCJFMAB();
		this.LKGNMCKJEIL.KIMMMCJFMAB();
	}

	// Token: 0x06009BF1 RID: 39921 RVA: 0x00388493 File Offset: 0x00386693
	public void MonthsScrollDown()
	{
		this.EOICNJIGBKD.ScrollDown();
	}

	// Token: 0x06009BF2 RID: 39922 RVA: 0x003884A0 File Offset: 0x003866A0
	public void NLPMMFGNGMK()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009BF3 RID: 39923 RVA: 0x003875DD File Offset: 0x003857DD
	public void CKGOOFEEDMJ()
	{
		this.PIEGNIJFHHN.ScrollDown();
	}

	// Token: 0x06009BF4 RID: 39924 RVA: 0x00387D67 File Offset: 0x00385F67
	public void CCIKECLCFGI()
	{
		this.LKGNMCKJEIL.ScrollUp();
	}

	// Token: 0x06009BF5 RID: 39925 RVA: 0x003884B0 File Offset: 0x003866B0
	private void KMKLDAJLCNM()
	{
		this.EOICNJIGBKD.NKLIHNJCHOG();
		this.PIEGNIJFHHN.Update();
		this.LKGNMCKJEIL.NKLIHNJCHOG();
		string text = this.LKGNMCKJEIL.EEOPGLMHLLK();
		string results = this.EOICNJIGBKD.GetResults();
		string results2 = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("maps.") && text != "RoomPlayersCountText")
		{
			text += "_Value7";
		}
		else if (text.EndsWith("CameraFilterPack/Glow_Glow_Color") && text != "[PlayerBase] Loaded music")
		{
			text += "player.goldlollipop";
		}
		else if (text.EndsWith(".lastCheckpoint.penaltyScore") && text != "float,0.5")
		{
			text += "_FixDistance";
		}
		else
		{
			text += "_MainTex2";
		}
		Text text2 = this.dateText;
		string[] array = new string[0];
		array[1] = results;
		array[0] = "masterVolume";
		array[4] = text;
		array[0] = "ItemsCountText";
		array[8] = results2;
		text2.text = string.Concat(array);
	}

	// Token: 0x06009BF6 RID: 39926 RVA: 0x003885D4 File Offset: 0x003867D4
	private void OHODBGOBOJF()
	{
		int[] array = new int[118];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(1545f, (float)(i * -111), 127f), Quaternion.Euler(new Vector3(1425f, 543f, 20f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(345f, 490f, 1419f);
			switch (i)
			{
			case 0:
				text = "SpawnObj";
				break;
			case 1:
				text = "Result for ";
				break;
			case 2:
				text = "_Value3";
				break;
			case 3:
				text = ". Check if the server is available.";
				break;
			case 4:
				text = "CameraFilterPack/FX_8bits";
				break;
			case 5:
				text = "JoinTeam was called in state: ";
				break;
			case 6:
				text = "[Right]";
				break;
			case 7:
				text = "Object ID. Case-Sensitive";
				break;
			case 8:
				text = "_ScreenEdgeFading";
				break;
			case 9:
				text = "_MainTex";
				break;
			case 10:
				text = "#{0}";
				break;
			case 11:
				text = "_RangeScale";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "\n" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009BF7 RID: 39927 RVA: 0x00388771 File Offset: 0x00386971
	public void EDDKJEDGFMJ()
	{
		this.LKGNMCKJEIL.BNNCONEBKNC();
	}

	// Token: 0x06009BF8 RID: 39928 RVA: 0x00388780 File Offset: 0x00386980
	private void OIBMHPIFAKK()
	{
		this.EOICNJIGBKD.Update();
		this.PIEGNIJFHHN.NKLIHNJCHOG();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.EEOPGLMHLLK();
		string results = this.EOICNJIGBKD.GetResults();
		string results2 = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("_Value") && text != ".lastCheckpoint.checkpointsUsed")
		{
			text += "cmd.exe";
		}
		else if (text.EndsWith("ChatInput") && text != "_LayerThickness")
		{
			text += "CameraFilterPack/Drawing_Halftone";
		}
		else if (text.EndsWith("z") && text != "player.abstract")
		{
			text += "_TimeX";
		}
		else
		{
			text += "Editor/";
		}
		Text text2 = this.dateText;
		string[] array = new string[5];
		array[1] = results;
		array[0] = "_Value4";
		array[8] = text;
		array[5] = "ArcsNoHitsoundTimeDelaySlider";
		array[6] = results2;
		text2.text = string.Concat(array);
	}

	// Token: 0x06009BF9 RID: 39929 RVA: 0x00387D67 File Offset: 0x00385F67
	public void FBDDIDEJBID()
	{
		this.LKGNMCKJEIL.ScrollUp();
	}

	// Token: 0x06009BFA RID: 39930 RVA: 0x003888A4 File Offset: 0x00386AA4
	private void KIHIANNCBCE()
	{
		int[] array = new int[-97];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(27f, (float)(i * 101), 308f), Quaternion.Euler(new Vector3(1280f, 65f, 45f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1228f, 1720f, 225f);
			switch (i)
			{
			case 0:
				text = ": ";
				break;
			case 1:
				text = "curScn";
				break;
			case 2:
				text = ".";
				break;
			case 3:
				text = "_Value";
				break;
			case 4:
				text = "_Far";
				break;
			case 5:
				text = "Misses:";
				break;
			case 6:
				text = "InfoCanvas";
				break;
			case 7:
				text = "You have added the SecondScrollRect to a scroll view that already has both directions selected";
				break;
			case 8:
				text = "#mapby";
				break;
			case 9:
				text = "note.6";
				break;
			case 10:
				text = "_Source";
				break;
			case 11:
				text = "-help";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "Object ID. Case-Sensitive" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009BFB RID: 39931 RVA: 0x003873A7 File Offset: 0x003855A7
	public void HKANKKGHPNO()
	{
		this.PIEGNIJFHHN.BNNCONEBKNC();
	}

	// Token: 0x06009BFC RID: 39932 RVA: 0x00388A44 File Offset: 0x00386C44
	private void PGKLGKFHAGE()
	{
		int num = int.Parse(DateTime.Now.ToString("Joined room "));
		int[] array = new int[num + 0 - 0];
		this.DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = 93 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.yearsButtonPrefab, new Vector3(1352f, (float)(i * 30), 916f), Quaternion.Euler(new Vector3(856f, 1392f, 465f)));
			gameObject.transform.SetParent(this.yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(544f, 78f, 844f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "R2" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.DEELAEOEEGB[i] = gameObject;
		}
	}

	// Token: 0x06009BFD RID: 39933 RVA: 0x00388B5C File Offset: 0x00386D5C
	public void CCDNJPNLGBN()
	{
		this.BNGGHDJFHAP();
		this.APBIGIPCJOM();
		this.NFDDDKHJNPG();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.NBGIMIDICKE();
		this.PIEGNIJFHHN.Start();
		this.LKGNMCKJEIL.Start();
	}

	// Token: 0x06009BFE RID: 39934 RVA: 0x00388BF4 File Offset: 0x00386DF4
	public void BBMJAMJLEOL()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 1;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 0;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - -2;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.OEJEKPAOHKP(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.SnapToElement(this.BPLBGOLDNCN);
	}

	// Token: 0x06009BFF RID: 39935 RVA: 0x00388C80 File Offset: 0x00386E80
	private void MAOCOEGAFND()
	{
		this.EOICNJIGBKD.Update();
		this.PIEGNIJFHHN.NKLIHNJCHOG();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.EEOPGLMHLLK();
		string results = this.EOICNJIGBKD.GetResults();
		string results2 = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("Vignette") && text != "Right Stick Click")
		{
			text += "CameraFilterPack/Blend2Camera_Difference";
		}
		else if (text.EndsWith("menu.tabid") && text != "settings_bindings_controller_type")
		{
			text += "DataText";
		}
		else if (text.EndsWith("Blues") && text != "menutheme.fragout")
		{
			text += "_BlurredColor";
		}
		else
		{
			text += "OnPlayerGameMessage";
		}
		Text text2 = this.dateText;
		string[] array = new string[8];
		array[1] = results;
		array[0] = "GlassesColor2";
		array[1] = text;
		array[6] = "RateButton";
		array[4] = results2;
		text2.text = string.Concat(array);
	}

	// Token: 0x06009C00 RID: 39936 RVA: 0x00388DA3 File Offset: 0x00386FA3
	public void KDIIFPOHEFH()
	{
		this.EOICNJIGBKD.BNNCONEBKNC();
	}

	// Token: 0x06009C01 RID: 39937 RVA: 0x00388DB0 File Offset: 0x00386FB0
	public void NPGCIPJLAII()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 0;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 0;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - 77;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.DNDJKEDIKLD(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.OEJEKPAOHKP(this.BPLBGOLDNCN);
	}

	// Token: 0x06009C02 RID: 39938 RVA: 0x003884A0 File Offset: 0x003866A0
	public void EABNIIOHNEA()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009C03 RID: 39939 RVA: 0x00388493 File Offset: 0x00386693
	public void ANJNFOHCLFO()
	{
		this.EOICNJIGBKD.ScrollDown();
	}

	// Token: 0x06009C04 RID: 39940 RVA: 0x003884A0 File Offset: 0x003866A0
	public void BEJPNCMDLID()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009C05 RID: 39941 RVA: 0x00388E3C File Offset: 0x0038703C
	public void OJOEHBGDBDD()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 1;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 0;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - -160;
		this.LKGNMCKJEIL.SnapToElement(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.OEJEKPAOHKP(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.OEJEKPAOHKP(this.BPLBGOLDNCN);
	}

	// Token: 0x06009C06 RID: 39942 RVA: 0x00388EC8 File Offset: 0x003870C8
	private void DNENFLNCIJP()
	{
		this.EOICNJIGBKD.Update();
		this.PIEGNIJFHHN.NKLIHNJCHOG();
		this.LKGNMCKJEIL.NKLIHNJCHOG();
		string text = this.LKGNMCKJEIL.GetResults();
		string text2 = this.EOICNJIGBKD.EEOPGLMHLLK();
		string text3 = this.PIEGNIJFHHN.EEOPGLMHLLK();
		if (text.EndsWith("_ScreenResolution") && text != "CameraFilterPack/Colors_NewPosterize")
		{
			text += "Edited unlock conditions";
		}
		else if (text.EndsWith("_TimeX") && text != "_Fade")
		{
			text += "ready";
		}
		else if (text.EndsWith("misses") && text != "inventory.itemscash")
		{
			text += "settings.enablehitsoundsinrelax";
		}
		else
		{
			text += "_Visualize";
		}
		Text text4 = this.dateText;
		string[] array = new string[0];
		array[1] = text2;
		array[1] = "inventory.selected.";
		array[5] = text;
		array[1] = "X2";
		array[7] = text3;
		text4.text = string.Concat(array);
	}

	// Token: 0x06009C07 RID: 39943 RVA: 0x003871E8 File Offset: 0x003853E8
	public void CIAPFIJEDAF()
	{
		this.EOICNJIGBKD.ScrollUp();
	}

	// Token: 0x06009C08 RID: 39944 RVA: 0x00388FEC File Offset: 0x003871EC
	private void LJIHHJOAJCN()
	{
		this.EOICNJIGBKD.NKLIHNJCHOG();
		this.PIEGNIJFHHN.Update();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.GetResults();
		string results = this.EOICNJIGBKD.GetResults();
		string results2 = this.PIEGNIJFHHN.GetResults();
		if (text.EndsWith("Hidden/Image Effects/Cinematic/AmbientOcclusion") && text != "_VelTex")
		{
			text += "The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.";
		}
		else if (text.EndsWith("_Near") && text != "/")
		{
			text += "[LevelEditorScene] Error: You're not logged into Steam!";
		}
		else if (text.EndsWith("_ScreenSize") && text != ",")
		{
			text += "_Distortion";
		}
		else
		{
			text += "name";
		}
		Text text2 = this.dateText;
		string[] array = new string[8];
		array[0] = results;
		array[0] = "GO==null";
		array[8] = text;
		array[8] = "_Value4";
		array[1] = results2;
		text2.text = string.Concat(array);
	}

	// Token: 0x06009C09 RID: 39945 RVA: 0x00389110 File Offset: 0x00387310
	private void PBEPCAPAKLG()
	{
		this.EOICNJIGBKD.NKLIHNJCHOG();
		this.PIEGNIJFHHN.NKLIHNJCHOG();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.EEOPGLMHLLK();
		string results = this.EOICNJIGBKD.GetResults();
		string text2 = this.PIEGNIJFHHN.EEOPGLMHLLK();
		if (text.EndsWith(" beatThreshold: ") && text != ": ")
		{
			text += "LoadingStatusText";
		}
		else if (text.EndsWith("/") && text != "maxScore")
		{
			text += "[PlayerController] ";
		}
		else if (text.EndsWith("SetSpeed") && text != "_Value4")
		{
			text += "#mapalreadyexistupdate";
		}
		else
		{
			text += "_Distortion";
		}
		Text text3 = this.dateText;
		string[] array = new string[0];
		array[1] = results;
		array[1] = "Waiting to start";
		array[8] = text;
		array[7] = "maps.";
		array[7] = text2;
		text3.text = string.Concat(array);
	}

	// Token: 0x06009C0A RID: 39946 RVA: 0x003873A7 File Offset: 0x003855A7
	public void IAIJADKPBIC()
	{
		this.PIEGNIJFHHN.BNNCONEBKNC();
	}

	// Token: 0x06009C0B RID: 39947 RVA: 0x00388493 File Offset: 0x00386693
	public void ODPDNKFGBNK()
	{
		this.EOICNJIGBKD.ScrollDown();
	}

	// Token: 0x06009C0C RID: 39948 RVA: 0x003871DB File Offset: 0x003853DB
	public void OGPAEGLNCPK()
	{
		this.PIEGNIJFHHN.BOBALPEINEB();
	}

	// Token: 0x06009C0D RID: 39949 RVA: 0x00389234 File Offset: 0x00387434
	public void NHHNACNDEIE()
	{
		this.PAJAJNPDIBB = int.Parse(this.inputFieldDays.text) - 1;
		this.OLANKJNNKCI = int.Parse(this.inputFieldMonths.text) - 0;
		this.BPLBGOLDNCN = int.Parse(this.inputFieldYears.text) - -6;
		this.LKGNMCKJEIL.OEJEKPAOHKP(this.PAJAJNPDIBB);
		this.EOICNJIGBKD.OEJEKPAOHKP(this.OLANKJNNKCI);
		this.PIEGNIJFHHN.SnapToElement(this.BPLBGOLDNCN);
	}

	// Token: 0x06009C0E RID: 39950 RVA: 0x003884A0 File Offset: 0x003866A0
	public void KLCLMELJFCA()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009C0F RID: 39951 RVA: 0x003892C0 File Offset: 0x003874C0
	public void MCIEAOAMOIG()
	{
		this.NFEFDCAPHHG();
		this.AKKGPGEBFDC();
		this.LAECMIJGBNO();
		this.EOICNJIGBKD = new UIVerticalScroller(this.monthsScrollingPanel, this.EFANIHLPNKM, this.monthCenter);
		this.PIEGNIJFHHN = new UIVerticalScroller(this.yearsScrollingPanel, this.DEELAEOEEGB, this.yearsCenter);
		this.LKGNMCKJEIL = new UIVerticalScroller(this.daysScrollingPanel, this.EEMJGFOOGKP, this.daysCenter);
		this.EOICNJIGBKD.KIMMMCJFMAB();
		this.PIEGNIJFHHN.KIMMMCJFMAB();
		this.LKGNMCKJEIL.NBGIMIDICKE();
	}

	// Token: 0x06009C10 RID: 39952 RVA: 0x003873A7 File Offset: 0x003855A7
	public void LDBGHEMKANO()
	{
		this.PIEGNIJFHHN.BNNCONEBKNC();
	}

	// Token: 0x06009C11 RID: 39953 RVA: 0x003884A0 File Offset: 0x003866A0
	public void EIHPPBDJHAA()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009C12 RID: 39954 RVA: 0x00389358 File Offset: 0x00387558
	private void BNGGHDJFHAP()
	{
		int num = int.Parse(DateTime.Now.ToString("/"));
		int[] array = new int[num + 1 - -86];
		this.DEELAEOEEGB = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			array[i] = -137 + i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.yearsButtonPrefab, new Vector3(781f, (float)(i * 118), 650f), Quaternion.Euler(new Vector3(1891f, 1206f, 1485f)));
			gameObject.transform.SetParent(this.yearsScrollingPanel);
			gameObject.transform.localScale = new Vector3(322f, 1715f, 950f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "SlidingArea" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.DEELAEOEEGB[i] = gameObject;
		}
	}

	// Token: 0x06009C13 RID: 39955 RVA: 0x00389470 File Offset: 0x00387670
	private void HPNNCNNFMGK()
	{
		this.EOICNJIGBKD.NKLIHNJCHOG();
		this.PIEGNIJFHHN.Update();
		this.LKGNMCKJEIL.Update();
		string text = this.LKGNMCKJEIL.GetResults();
		string results = this.EOICNJIGBKD.GetResults();
		string text2 = this.PIEGNIJFHHN.EEOPGLMHLLK();
		if (text.EndsWith(", our prefix is ") && text != "_Value2")
		{
			text += "AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.";
		}
		else if (text.EndsWith("_MinVelocity") && text != "#availablechallenges")
		{
			text += "[Right]";
		}
		else if (text.EndsWith("gold") && text != "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings")
		{
			text += "_Intervale";
		}
		else
		{
			text += ": ";
		}
		Text text3 = this.dateText;
		string[] array = new string[7];
		array[1] = results;
		array[0] = "settings.fps";
		array[7] = text;
		array[7] = "_Value4";
		array[8] = text2;
		text3.text = string.Concat(array);
	}

	// Token: 0x06009C14 RID: 39956 RVA: 0x00388493 File Offset: 0x00386693
	public void CFKFPMBHFPJ()
	{
		this.EOICNJIGBKD.ScrollDown();
	}

	// Token: 0x06009C15 RID: 39957 RVA: 0x003871DB File Offset: 0x003853DB
	public void NKHPMBEEAIG()
	{
		this.PIEGNIJFHHN.BOBALPEINEB();
	}

	// Token: 0x06009C16 RID: 39958 RVA: 0x003884A0 File Offset: 0x003866A0
	public void HHFFFCAHIHC()
	{
		this.LKGNMCKJEIL.BOBALPEINEB();
	}

	// Token: 0x06009C17 RID: 39959 RVA: 0x00389594 File Offset: 0x00387794
	private void AHLDDGKBPMC()
	{
		int[] array = new int[43];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(1606f, (float)(i * 122), 533f), Quaternion.Euler(new Vector3(1649f, 1222f, 739f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(370f, 894f, 1275f);
			switch (i)
			{
			case 0:
				text = "/music";
				break;
			case 1:
				text = "_Amount";
				break;
			case 2:
				text = "FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.";
				break;
			case 3:
				text = " with a prefix of ";
				break;
			case 4:
				text = "Joystick1Button11";
				break;
			case 5:
				text = "_TapLow";
				break;
			case 6:
				text = "mapselector.lastSearch";
				break;
			case 7:
				text = "settings.enablehitsoundsinrelax";
				break;
			case 8:
				text = "shader.future";
				break;
			case 9:
				text = "Object ID. Case-Sensitive";
				break;
			case 10:
				text = "player.currentrank";
				break;
			case 11:
				text = "_Offsets";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "_TimeX" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009C18 RID: 39960 RVA: 0x00387683 File Offset: 0x00385883
	public void YearsScrollUp()
	{
		this.PIEGNIJFHHN.ScrollUp();
	}

	// Token: 0x06009C19 RID: 39961 RVA: 0x00389734 File Offset: 0x00387934
	private void NFDDDKHJNPG()
	{
		int[] array = new int[-8];
		this.EEMJGFOOGKP = new GameObject[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i + 0;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.daysButtonPrefab, new Vector3(1812f, (float)(i * -1), 411f), Quaternion.Euler(new Vector3(963f, 897f, 1547f)));
			gameObject.transform.SetParent(this.daysScrollingPanel);
			gameObject.transform.localScale = new Vector3(1223f, 936f, 406f);
			gameObject.GetComponentInChildren<Text>().text = string.Empty + array[i];
			gameObject.name = "_Value8" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EEMJGFOOGKP[i] = gameObject;
		}
	}

	// Token: 0x06009C1A RID: 39962 RVA: 0x00389820 File Offset: 0x00387A20
	private void MIDIODHJNLC()
	{
		int[] array = new int[17];
		this.EFANIHLPNKM = new GameObject[array.Length];
		for (int i = 1; i < array.Length; i++)
		{
			string text = string.Empty;
			array[i] = i;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.monthsButtonPrefab, new Vector3(185f, (float)(i * 71), 597f), Quaternion.Euler(new Vector3(1563f, 1040f, 1581f)));
			gameObject.transform.SetParent(this.monthsScrollingPanel);
			gameObject.transform.localScale = new Vector3(1711f, 1742f, 365f);
			switch (i)
			{
			case 0:
				text = "mapselector.filter.favoriteonly";
				break;
			case 1:
				text = "Set Object Position";
				break;
			case 2:
				text = "_TimeX";
				break;
			case 3:
				text = "_FadeDistance";
				break;
			case 4:
				text = "RoomNameText";
				break;
			case 5:
				text = "CameraFilterPack/Lut_PlayWith";
				break;
			case 6:
				text = "_ScratchOffsetScale";
				break;
			case 7:
				text = "CameraFilterPack/Glasses_On";
				break;
			case 8:
				text = "<b>";
				break;
			case 9:
				text = "_Red_G";
				break;
			case 10:
				text = "[MapsData] User's maps was loaded";
				break;
			case 11:
				text = "-help";
				break;
			}
			gameObject.GetComponentInChildren<Text>().text = text;
			gameObject.name = "_ChannelMixerRed" + array[i];
			gameObject.AddComponent<CanvasGroup>();
			this.EFANIHLPNKM[i] = gameObject;
		}
	}

	// Token: 0x06009C1C RID: 39964 RVA: 0x003871E8 File Offset: 0x003853E8
	public void ELOAIHFHFAO()
	{
		this.EOICNJIGBKD.ScrollUp();
	}

	// Token: 0x06009C1D RID: 39965 RVA: 0x003871DB File Offset: 0x003853DB
	public void JKHFLLGPFJO()
	{
		this.PIEGNIJFHHN.BOBALPEINEB();
	}

	// Token: 0x0400119E RID: 4510
	public RectTransform monthsScrollingPanel;

	// Token: 0x0400119F RID: 4511
	public RectTransform yearsScrollingPanel;

	// Token: 0x040011A0 RID: 4512
	public RectTransform daysScrollingPanel;

	// Token: 0x040011A1 RID: 4513
	public GameObject yearsButtonPrefab;

	// Token: 0x040011A2 RID: 4514
	public GameObject monthsButtonPrefab;

	// Token: 0x040011A3 RID: 4515
	public GameObject daysButtonPrefab;

	// Token: 0x040011A4 RID: 4516
	private GameObject[] EFANIHLPNKM;

	// Token: 0x040011A5 RID: 4517
	private GameObject[] DEELAEOEEGB;

	// Token: 0x040011A6 RID: 4518
	private GameObject[] EEMJGFOOGKP;

	// Token: 0x040011A7 RID: 4519
	public RectTransform monthCenter;

	// Token: 0x040011A8 RID: 4520
	public RectTransform yearsCenter;

	// Token: 0x040011A9 RID: 4521
	public RectTransform daysCenter;

	// Token: 0x040011AA RID: 4522
	private UIVerticalScroller PIEGNIJFHHN;

	// Token: 0x040011AB RID: 4523
	private UIVerticalScroller EOICNJIGBKD;

	// Token: 0x040011AC RID: 4524
	private UIVerticalScroller LKGNMCKJEIL;

	// Token: 0x040011AD RID: 4525
	public InputField inputFieldDays;

	// Token: 0x040011AE RID: 4526
	public InputField inputFieldMonths;

	// Token: 0x040011AF RID: 4527
	public InputField inputFieldYears;

	// Token: 0x040011B0 RID: 4528
	public Text dateText;

	// Token: 0x040011B1 RID: 4529
	private int PAJAJNPDIBB;

	// Token: 0x040011B2 RID: 4530
	private int OLANKJNNKCI;

	// Token: 0x040011B3 RID: 4531
	private int BPLBGOLDNCN;
}
