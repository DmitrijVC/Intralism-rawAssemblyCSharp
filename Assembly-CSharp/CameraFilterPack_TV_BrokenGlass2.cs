using System;
using UnityEngine;

// Token: 0x02000113 RID: 275
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass2")]
public class CameraFilterPack_TV_BrokenGlass2 : MonoBehaviour
{
	// Token: 0x060055BE RID: 21950 RVA: 0x001A874E File Offset: 0x001A694E
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055BF RID: 21951 RVA: 0x001A8785 File Offset: 0x001A6985
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060055C1 RID: 21953 RVA: 0x001A87A2 File Offset: 0x001A69A2
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("--------------------------------") as Texture2D);
		this.SCShader = Shader.Find("Jazz");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055C2 RID: 21954 RVA: 0x001A87DC File Offset: 0x001A69DC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1463f)
			{
				this.HBJJOCHGOPH = 17f;
			}
			this.DKNJGHFLAIF().SetFloat("\n", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1227f)
			{
				this.Bullet_1 = 1376f;
			}
			if (this.Bullet_2 < 1543f)
			{
				this.Bullet_2 = 318f;
			}
			if (this.Bullet_3 < 691f)
			{
				this.Bullet_3 = 318f;
			}
			if (this.Bullet_4 < 396f)
			{
				this.Bullet_4 = 1111f;
			}
			if (this.Bullet_5 < 698f)
			{
				this.Bullet_5 = 1702f;
			}
			if (this.Bullet_6 < 1823f)
			{
				this.Bullet_6 = 1988f;
			}
			if (this.Bullet_7 < 951f)
			{
				this.Bullet_7 = 595f;
			}
			if (this.Bullet_8 < 1310f)
			{
				this.Bullet_8 = 1780f;
			}
			if (this.Bullet_9 < 1037f)
			{
				this.Bullet_9 = 1560f;
			}
			if (this.Bullet_10 < 1361f)
			{
				this.Bullet_10 = 1909f;
			}
			if (this.Bullet_11 < 976f)
			{
				this.Bullet_11 = 253f;
			}
			if (this.Bullet_12 < 1862f)
			{
				this.Bullet_12 = 1248f;
			}
			if (this.Bullet_1 > 241f)
			{
				this.Bullet_1 = 1328f;
			}
			if (this.Bullet_2 > 1451f)
			{
				this.Bullet_2 = 1212f;
			}
			if (this.Bullet_3 > 404f)
			{
				this.Bullet_3 = 1277f;
			}
			if (this.Bullet_4 > 174f)
			{
				this.Bullet_4 = 952f;
			}
			if (this.Bullet_5 > 628f)
			{
				this.Bullet_5 = 1294f;
			}
			if (this.Bullet_6 > 574f)
			{
				this.Bullet_6 = 421f;
			}
			if (this.Bullet_7 > 1406f)
			{
				this.Bullet_7 = 1838f;
			}
			if (this.Bullet_8 > 1460f)
			{
				this.Bullet_8 = 746f;
			}
			if (this.Bullet_9 > 1927f)
			{
				this.Bullet_9 = 1156f;
			}
			if (this.Bullet_10 > 484f)
			{
				this.Bullet_10 = 527f;
			}
			if (this.Bullet_11 > 1614f)
			{
				this.Bullet_11 = 753f;
			}
			if (this.Bullet_12 > 1018f)
			{
				this.Bullet_12 = 1331f;
			}
			this.HCGJCMDJPGD().SetFloat("settings.arcsnohitsoundtimedelay", this.Bullet_1);
			this.HCGJCMDJPGD().SetFloat("Coroutine container not configured... did you forget to call Init?", this.Bullet_2);
			this.MFHPKGICPIO().SetFloat("_DotSize", this.Bullet_3);
			this.ADBKPGFMNKO().SetFloat("Edited unlock conditions", this.Bullet_4);
			this.NDMPCDHADMJ().SetFloat("RequestForPickupItems", this.Bullet_5);
			this.DKNJGHFLAIF().SetFloat("_NoiseTex", this.Bullet_6);
			this.DKNJGHFLAIF().SetFloat("_MainTex2", this.Bullet_7);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Bullet_8);
			this.IIBLJCKLGFG().SetFloat("selColor", this.Bullet_9);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Bullet_10);
			this.DKNJGHFLAIF().SetFloat("RoomDescriptionText", this.Bullet_11);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.Bullet_12);
			this.OCHJIMJNEMO().SetTexture("z", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055C3 RID: 21955 RVA: 0x001A8BFC File Offset: 0x001A6DFC
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055C4 RID: 21956 RVA: 0x001A8C34 File Offset: 0x001A6E34
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 515f;
			}
			this.HCGJCMDJPGD().SetFloat("mapselector.orderby", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1700f)
			{
				this.Bullet_1 = 1919f;
			}
			if (this.Bullet_2 < 202f)
			{
				this.Bullet_2 = 1725f;
			}
			if (this.Bullet_3 < 1819f)
			{
				this.Bullet_3 = 201f;
			}
			if (this.Bullet_4 < 658f)
			{
				this.Bullet_4 = 1801f;
			}
			if (this.Bullet_5 < 308f)
			{
				this.Bullet_5 = 721f;
			}
			if (this.Bullet_6 < 464f)
			{
				this.Bullet_6 = 28f;
			}
			if (this.Bullet_7 < 1394f)
			{
				this.Bullet_7 = 1215f;
			}
			if (this.Bullet_8 < 891f)
			{
				this.Bullet_8 = 113f;
			}
			if (this.Bullet_9 < 1767f)
			{
				this.Bullet_9 = 1917f;
			}
			if (this.Bullet_10 < 312f)
			{
				this.Bullet_10 = 338f;
			}
			if (this.Bullet_11 < 1468f)
			{
				this.Bullet_11 = 1312f;
			}
			if (this.Bullet_12 < 722f)
			{
				this.Bullet_12 = 86f;
			}
			if (this.Bullet_1 > 944f)
			{
				this.Bullet_1 = 160f;
			}
			if (this.Bullet_2 > 1034f)
			{
				this.Bullet_2 = 1031f;
			}
			if (this.Bullet_3 > 928f)
			{
				this.Bullet_3 = 84f;
			}
			if (this.Bullet_4 > 343f)
			{
				this.Bullet_4 = 908f;
			}
			if (this.Bullet_5 > 1365f)
			{
				this.Bullet_5 = 1466f;
			}
			if (this.Bullet_6 > 162f)
			{
				this.Bullet_6 = 403f;
			}
			if (this.Bullet_7 > 750f)
			{
				this.Bullet_7 = 665f;
			}
			if (this.Bullet_8 > 945f)
			{
				this.Bullet_8 = 639f;
			}
			if (this.Bullet_9 > 1689f)
			{
				this.Bullet_9 = 1707f;
			}
			if (this.Bullet_10 > 785f)
			{
				this.Bullet_10 = 942f;
			}
			if (this.Bullet_11 > 1574f)
			{
				this.Bullet_11 = 1858f;
			}
			if (this.Bullet_12 > 1228f)
			{
				this.Bullet_12 = 156f;
			}
			this.NDMPCDHADMJ().SetFloat("Preparing content", this.Bullet_1);
			this.IIBLJCKLGFG().SetFloat("MissesText", this.Bullet_2);
			this.NDMPCDHADMJ().SetFloat("_Value3", this.Bullet_3);
			this.HCGJCMDJPGD().SetFloat("delete", this.Bullet_4);
			this.NBPKMLMCHFN.SetFloat("default", this.Bullet_5);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/NightVision_4", this.Bullet_6);
			this.MFHPKGICPIO().SetFloat("Arc", this.Bullet_7);
			this.OCHJIMJNEMO().SetFloat("_AOTex", this.Bullet_8);
			this.NDMPCDHADMJ().SetFloat("_Value4", this.Bullet_9);
			this.HCGJCMDJPGD().SetFloat("threshold", this.Bullet_10);
			this.ADBKPGFMNKO().SetFloat("sounds/hit_perfect", this.Bullet_11);
			this.OCHJIMJNEMO().SetFloat("Object ID. Case-Sensitive", this.Bullet_12);
			this.ADBKPGFMNKO().SetTexture("No Description", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055C5 RID: 21957 RVA: 0x001A9054 File Offset: 0x001A7254
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.enableselectormusic") as Texture2D);
		this.SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055C6 RID: 21958 RVA: 0x001A9090 File Offset: 0x001A7290
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 141f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.IIBLJCKLGFG().SetFloat("_History3Weight", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1467f)
			{
				this.Bullet_1 = 87f;
			}
			if (this.Bullet_2 < 1323f)
			{
				this.Bullet_2 = 1195f;
			}
			if (this.Bullet_3 < 1320f)
			{
				this.Bullet_3 = 958f;
			}
			if (this.Bullet_4 < 1188f)
			{
				this.Bullet_4 = 23f;
			}
			if (this.Bullet_5 < 1190f)
			{
				this.Bullet_5 = 1993f;
			}
			if (this.Bullet_6 < 811f)
			{
				this.Bullet_6 = 1565f;
			}
			if (this.Bullet_7 < 1221f)
			{
				this.Bullet_7 = 801f;
			}
			if (this.Bullet_8 < 694f)
			{
				this.Bullet_8 = 410f;
			}
			if (this.Bullet_9 < 1593f)
			{
				this.Bullet_9 = 390f;
			}
			if (this.Bullet_10 < 351f)
			{
				this.Bullet_10 = 251f;
			}
			if (this.Bullet_11 < 346f)
			{
				this.Bullet_11 = 539f;
			}
			if (this.Bullet_12 < 1639f)
			{
				this.Bullet_12 = 1061f;
			}
			if (this.Bullet_1 > 178f)
			{
				this.Bullet_1 = 89f;
			}
			if (this.Bullet_2 > 1126f)
			{
				this.Bullet_2 = 675f;
			}
			if (this.Bullet_3 > 259f)
			{
				this.Bullet_3 = 63f;
			}
			if (this.Bullet_4 > 64f)
			{
				this.Bullet_4 = 11f;
			}
			if (this.Bullet_5 > 462f)
			{
				this.Bullet_5 = 225f;
			}
			if (this.Bullet_6 > 1913f)
			{
				this.Bullet_6 = 277f;
			}
			if (this.Bullet_7 > 1786f)
			{
				this.Bullet_7 = 1237f;
			}
			if (this.Bullet_8 > 1779f)
			{
				this.Bullet_8 = 644f;
			}
			if (this.Bullet_9 > 79f)
			{
				this.Bullet_9 = 1236f;
			}
			if (this.Bullet_10 > 757f)
			{
				this.Bullet_10 = 747f;
			}
			if (this.Bullet_11 > 285f)
			{
				this.Bullet_11 = 1001f;
			}
			if (this.Bullet_12 > 710f)
			{
				this.Bullet_12 = 1674f;
			}
			this.IIBLJCKLGFG().SetFloat("_TimeX", this.Bullet_1);
			this.DBOLLHHMKKN().SetFloat("Joystick1Button5", this.Bullet_2);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.Bullet_3);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.Bullet_4);
			this.DBOLLHHMKKN().SetFloat("LevelNameInputField", this.Bullet_5);
			this.OCHJIMJNEMO().SetFloat("PLEASE WAIT", this.Bullet_6);
			this.DBOLLHHMKKN().SetFloat("offsets", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("shader.none", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("grid", this.Bullet_9);
			this.DBOLLHHMKKN().SetFloat("MenuScene", this.Bullet_10);
			this.DKNJGHFLAIF().SetFloat("#onrankchangeuptext", this.Bullet_11);
			this.OCHJIMJNEMO().SetFloat("The new master starts a new round, cause we didn't start yet.", this.Bullet_12);
			this.OCHJIMJNEMO().SetTexture(".highscore", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055C7 RID: 21959 RVA: 0x001A8785 File Offset: 0x001A6985
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055C8 RID: 21960 RVA: 0x001A8785 File Offset: 0x001A6985
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055C9 RID: 21961 RVA: 0x001A8785 File Offset: 0x001A6985
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055CA RID: 21962 RVA: 0x001A94B0 File Offset: 0x001A76B0
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1099f)
			{
				this.HBJJOCHGOPH = 1991f;
			}
			this.ADBKPGFMNKO().SetFloat(" left", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 394f)
			{
				this.Bullet_1 = 1095f;
			}
			if (this.Bullet_2 < 1289f)
			{
				this.Bullet_2 = 1148f;
			}
			if (this.Bullet_3 < 716f)
			{
				this.Bullet_3 = 1013f;
			}
			if (this.Bullet_4 < 1759f)
			{
				this.Bullet_4 = 621f;
			}
			if (this.Bullet_5 < 535f)
			{
				this.Bullet_5 = 142f;
			}
			if (this.Bullet_6 < 1938f)
			{
				this.Bullet_6 = 968f;
			}
			if (this.Bullet_7 < 419f)
			{
				this.Bullet_7 = 1364f;
			}
			if (this.Bullet_8 < 764f)
			{
				this.Bullet_8 = 1027f;
			}
			if (this.Bullet_9 < 1966f)
			{
				this.Bullet_9 = 458f;
			}
			if (this.Bullet_10 < 1553f)
			{
				this.Bullet_10 = 841f;
			}
			if (this.Bullet_11 < 847f)
			{
				this.Bullet_11 = 454f;
			}
			if (this.Bullet_12 < 1105f)
			{
				this.Bullet_12 = 1807f;
			}
			if (this.Bullet_1 > 1116f)
			{
				this.Bullet_1 = 1613f;
			}
			if (this.Bullet_2 > 1707f)
			{
				this.Bullet_2 = 1716f;
			}
			if (this.Bullet_3 > 405f)
			{
				this.Bullet_3 = 564f;
			}
			if (this.Bullet_4 > 486f)
			{
				this.Bullet_4 = 1897f;
			}
			if (this.Bullet_5 > 641f)
			{
				this.Bullet_5 = 127f;
			}
			if (this.Bullet_6 > 808f)
			{
				this.Bullet_6 = 897f;
			}
			if (this.Bullet_7 > 574f)
			{
				this.Bullet_7 = 1143f;
			}
			if (this.Bullet_8 > 1707f)
			{
				this.Bullet_8 = 603f;
			}
			if (this.Bullet_9 > 816f)
			{
				this.Bullet_9 = 1977f;
			}
			if (this.Bullet_10 > 361f)
			{
				this.Bullet_10 = 1712f;
			}
			if (this.Bullet_11 > 1860f)
			{
				this.Bullet_11 = 1511f;
			}
			if (this.Bullet_12 > 1704f)
			{
				this.Bullet_12 = 1578f;
			}
			this.IIBLJCKLGFG().SetFloat("_TimeX", this.Bullet_1);
			this.ADBKPGFMNKO().SetFloat("_Distortion", this.Bullet_2);
			this.HCGJCMDJPGD().SetFloat("_Value1", this.Bullet_3);
			this.LONNIJMNKFB().SetFloat("Set satellite color", this.Bullet_4);
			this.NDMPCDHADMJ().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Bullet_5);
			this.IIBLJCKLGFG().SetFloat("id", this.Bullet_6);
			this.LONNIJMNKFB().SetFloat(": ", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("_Noise", this.Bullet_8);
			this.DBOLLHHMKKN().SetFloat("_FadeFX", this.Bullet_9);
			this.ADBKPGFMNKO().SetFloat("SetPlayerDistance", this.Bullet_10);
			this.IIBLJCKLGFG().SetFloat("_Value4", this.Bullet_11);
			this.OCHJIMJNEMO().SetFloat("NEW_ACHIEVEMENT_1_26", this.Bullet_12);
			this.IIBLJCKLGFG().SetTexture("_Color_G", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055CB RID: 21963 RVA: 0x001A98D0 File Offset: 0x001A7AD0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 439f)
			{
				this.HBJJOCHGOPH = 1449f;
			}
			this.HCGJCMDJPGD().SetFloat("New SaveGame", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1082f)
			{
				this.Bullet_1 = 950f;
			}
			if (this.Bullet_2 < 1494f)
			{
				this.Bullet_2 = 1570f;
			}
			if (this.Bullet_3 < 1395f)
			{
				this.Bullet_3 = 1983f;
			}
			if (this.Bullet_4 < 877f)
			{
				this.Bullet_4 = 343f;
			}
			if (this.Bullet_5 < 325f)
			{
				this.Bullet_5 = 1096f;
			}
			if (this.Bullet_6 < 835f)
			{
				this.Bullet_6 = 115f;
			}
			if (this.Bullet_7 < 1638f)
			{
				this.Bullet_7 = 1206f;
			}
			if (this.Bullet_8 < 642f)
			{
				this.Bullet_8 = 1288f;
			}
			if (this.Bullet_9 < 1303f)
			{
				this.Bullet_9 = 1314f;
			}
			if (this.Bullet_10 < 1822f)
			{
				this.Bullet_10 = 11f;
			}
			if (this.Bullet_11 < 365f)
			{
				this.Bullet_11 = 1095f;
			}
			if (this.Bullet_12 < 251f)
			{
				this.Bullet_12 = 1597f;
			}
			if (this.Bullet_1 > 1776f)
			{
				this.Bullet_1 = 219f;
			}
			if (this.Bullet_2 > 167f)
			{
				this.Bullet_2 = 1874f;
			}
			if (this.Bullet_3 > 784f)
			{
				this.Bullet_3 = 1370f;
			}
			if (this.Bullet_4 > 1585f)
			{
				this.Bullet_4 = 1802f;
			}
			if (this.Bullet_5 > 597f)
			{
				this.Bullet_5 = 1836f;
			}
			if (this.Bullet_6 > 872f)
			{
				this.Bullet_6 = 48f;
			}
			if (this.Bullet_7 > 649f)
			{
				this.Bullet_7 = 923f;
			}
			if (this.Bullet_8 > 27f)
			{
				this.Bullet_8 = 171f;
			}
			if (this.Bullet_9 > 211f)
			{
				this.Bullet_9 = 1980f;
			}
			if (this.Bullet_10 > 590f)
			{
				this.Bullet_10 = 1288f;
			}
			if (this.Bullet_11 > 860f)
			{
				this.Bullet_11 = 1114f;
			}
			if (this.Bullet_12 > 1271f)
			{
				this.Bullet_12 = 1313f;
			}
			this.DKNJGHFLAIF().SetFloat("_Vignette", this.Bullet_1);
			this.HCGJCMDJPGD().SetFloat(" Also make sure to disable sprite packing for this sprite.", this.Bullet_2);
			this.LONNIJMNKFB().SetFloat(".lastCheckpoint.playerdistance", this.Bullet_3);
			this.NBPKMLMCHFN.SetFloat("_DiffuseColor", this.Bullet_4);
			this.DKNJGHFLAIF().SetFloat("/", this.Bullet_5);
			this.MFHPKGICPIO().SetFloat("_HexaColor", this.Bullet_6);
			this.HCGJCMDJPGD().SetFloat("settings.fps", this.Bullet_7);
			this.IIBLJCKLGFG().SetFloat("bad", this.Bullet_8);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.Bullet_9);
			this.NBPKMLMCHFN.SetFloat("Editor/", this.Bullet_10);
			this.IIBLJCKLGFG().SetFloat("_BlurVector", this.Bullet_11);
			this.DBOLLHHMKKN().SetFloat("[Right-Down-Left]", this.Bullet_12);
			this.NDMPCDHADMJ().SetTexture("s", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x001A9CF0 File Offset: 0x001A7EF0
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 617f)
			{
				this.HBJJOCHGOPH = 665f;
			}
			this.DKNJGHFLAIF().SetFloat("SetSunColors", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 97f)
			{
				this.Bullet_1 = 341f;
			}
			if (this.Bullet_2 < 1226f)
			{
				this.Bullet_2 = 802f;
			}
			if (this.Bullet_3 < 1796f)
			{
				this.Bullet_3 = 387f;
			}
			if (this.Bullet_4 < 230f)
			{
				this.Bullet_4 = 832f;
			}
			if (this.Bullet_5 < 1062f)
			{
				this.Bullet_5 = 709f;
			}
			if (this.Bullet_6 < 1609f)
			{
				this.Bullet_6 = 327f;
			}
			if (this.Bullet_7 < 1847f)
			{
				this.Bullet_7 = 424f;
			}
			if (this.Bullet_8 < 535f)
			{
				this.Bullet_8 = 1318f;
			}
			if (this.Bullet_9 < 1382f)
			{
				this.Bullet_9 = 1161f;
			}
			if (this.Bullet_10 < 735f)
			{
				this.Bullet_10 = 1701f;
			}
			if (this.Bullet_11 < 458f)
			{
				this.Bullet_11 = 1001f;
			}
			if (this.Bullet_12 < 1209f)
			{
				this.Bullet_12 = 748f;
			}
			if (this.Bullet_1 > 965f)
			{
				this.Bullet_1 = 1332f;
			}
			if (this.Bullet_2 > 1388f)
			{
				this.Bullet_2 = 1440f;
			}
			if (this.Bullet_3 > 547f)
			{
				this.Bullet_3 = 377f;
			}
			if (this.Bullet_4 > 852f)
			{
				this.Bullet_4 = 591f;
			}
			if (this.Bullet_5 > 253f)
			{
				this.Bullet_5 = 633f;
			}
			if (this.Bullet_6 > 1534f)
			{
				this.Bullet_6 = 822f;
			}
			if (this.Bullet_7 > 1283f)
			{
				this.Bullet_7 = 1031f;
			}
			if (this.Bullet_8 > 1490f)
			{
				this.Bullet_8 = 273f;
			}
			if (this.Bullet_9 > 990f)
			{
				this.Bullet_9 = 70f;
			}
			if (this.Bullet_10 > 1332f)
			{
				this.Bullet_10 = 1194f;
			}
			if (this.Bullet_11 > 383f)
			{
				this.Bullet_11 = 494f;
			}
			if (this.Bullet_12 > 401f)
			{
				this.Bullet_12 = 1308f;
			}
			this.IIBLJCKLGFG().SetFloat("PlayMusic", this.Bullet_1);
			this.NDMPCDHADMJ().SetFloat("RespawnAfter", this.Bullet_2);
			this.HCGJCMDJPGD().SetFloat("Server: {0}. Region: {1} ", this.Bullet_3);
			this.ADBKPGFMNKO().SetFloat("mapselector.filter.officialsortmode", this.Bullet_4);
			this.NBPKMLMCHFN.SetFloat("_Value13", this.Bullet_5);
			this.HCGJCMDJPGD().SetFloat("_DotSize", this.Bullet_6);
			this.NDMPCDHADMJ().SetFloat("_Value", this.Bullet_7);
			this.MFHPKGICPIO().SetFloat("workshop.", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("_Far", this.Bullet_9);
			this.DKNJGHFLAIF().SetFloat(" - {0}", this.Bullet_10);
			this.IIBLJCKLGFG().SetFloat("settings.enablerankingnotifications", this.Bullet_11);
			this.ADBKPGFMNKO().SetFloat("Unsupported target enum: ", this.Bullet_12);
			this.MFHPKGICPIO().SetTexture("challenges/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x001AA110 File Offset: 0x001A8310
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load(" ") as Texture2D);
		this.SCShader = Shader.Find("#{0:X2}{1:X2}{2:X2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x001AA14C File Offset: 0x001A834C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 677f)
			{
				this.HBJJOCHGOPH = 476f;
			}
			this.ADBKPGFMNKO().SetFloat("LevelInfoInputField", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 62f)
			{
				this.Bullet_1 = 1840f;
			}
			if (this.Bullet_2 < 1992f)
			{
				this.Bullet_2 = 1121f;
			}
			if (this.Bullet_3 < 1037f)
			{
				this.Bullet_3 = 1695f;
			}
			if (this.Bullet_4 < 765f)
			{
				this.Bullet_4 = 1886f;
			}
			if (this.Bullet_5 < 805f)
			{
				this.Bullet_5 = 534f;
			}
			if (this.Bullet_6 < 1172f)
			{
				this.Bullet_6 = 1615f;
			}
			if (this.Bullet_7 < 117f)
			{
				this.Bullet_7 = 307f;
			}
			if (this.Bullet_8 < 1346f)
			{
				this.Bullet_8 = 1460f;
			}
			if (this.Bullet_9 < 460f)
			{
				this.Bullet_9 = 76f;
			}
			if (this.Bullet_10 < 494f)
			{
				this.Bullet_10 = 1897f;
			}
			if (this.Bullet_11 < 1728f)
			{
				this.Bullet_11 = 1252f;
			}
			if (this.Bullet_12 < 1172f)
			{
				this.Bullet_12 = 1291f;
			}
			if (this.Bullet_1 > 1449f)
			{
				this.Bullet_1 = 1199f;
			}
			if (this.Bullet_2 > 358f)
			{
				this.Bullet_2 = 429f;
			}
			if (this.Bullet_3 > 828f)
			{
				this.Bullet_3 = 388f;
			}
			if (this.Bullet_4 > 582f)
			{
				this.Bullet_4 = 1972f;
			}
			if (this.Bullet_5 > 1116f)
			{
				this.Bullet_5 = 253f;
			}
			if (this.Bullet_6 > 1496f)
			{
				this.Bullet_6 = 1567f;
			}
			if (this.Bullet_7 > 535f)
			{
				this.Bullet_7 = 56f;
			}
			if (this.Bullet_8 > 342f)
			{
				this.Bullet_8 = 966f;
			}
			if (this.Bullet_9 > 1841f)
			{
				this.Bullet_9 = 1946f;
			}
			if (this.Bullet_10 > 1054f)
			{
				this.Bullet_10 = 595f;
			}
			if (this.Bullet_11 > 35f)
			{
				this.Bullet_11 = 1616f;
			}
			if (this.Bullet_12 > 625f)
			{
				this.Bullet_12 = 1147f;
			}
			this.ADBKPGFMNKO().SetFloat("Turn", this.Bullet_1);
			this.NDMPCDHADMJ().SetFloat("ConfigVersionSlider", this.Bullet_2);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Hue", this.Bullet_3);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Bullet_4);
			this.LONNIJMNKFB().SetFloat("RecordButton", this.Bullet_5);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Atmosphere_Fog", this.Bullet_6);
			this.LONNIJMNKFB().SetFloat("remaining: {0:0.000}", this.Bullet_7);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Atmosphere_Rain", this.Bullet_8);
			this.NDMPCDHADMJ().SetFloat("_Offsets", this.Bullet_9);
			this.MFHPKGICPIO().SetFloat("updating", this.Bullet_10);
			this.HCGJCMDJPGD().SetFloat("Tab1Content", this.Bullet_11);
			this.LONNIJMNKFB().SetFloat("[ItemsHandler] Found ", this.Bullet_12);
			this.ADBKPGFMNKO().SetTexture("settings.arcsnohitsoundtimedelay", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055CF RID: 21967 RVA: 0x001AA56C File Offset: 0x001A876C
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/OldFilm_Cutting1") as Texture2D);
		this.SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x001AA5A5 File Offset: 0x001A87A5
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("null") as Texture2D);
		this.SCShader = Shader.Find("achievements.21.progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x001AA5DE File Offset: 0x001A87DE
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("true") as Texture2D);
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x001AA618 File Offset: 0x001A8818
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 516f)
			{
				this.HBJJOCHGOPH = 1229f;
			}
			this.OCHJIMJNEMO().SetFloat("inventory.itemscash", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 709f)
			{
				this.Bullet_1 = 1816f;
			}
			if (this.Bullet_2 < 1f)
			{
				this.Bullet_2 = 385f;
			}
			if (this.Bullet_3 < 177f)
			{
				this.Bullet_3 = 810f;
			}
			if (this.Bullet_4 < 1799f)
			{
				this.Bullet_4 = 222f;
			}
			if (this.Bullet_5 < 1889f)
			{
				this.Bullet_5 = 613f;
			}
			if (this.Bullet_6 < 13f)
			{
				this.Bullet_6 = 893f;
			}
			if (this.Bullet_7 < 7f)
			{
				this.Bullet_7 = 692f;
			}
			if (this.Bullet_8 < 1721f)
			{
				this.Bullet_8 = 922f;
			}
			if (this.Bullet_9 < 70f)
			{
				this.Bullet_9 = 1502f;
			}
			if (this.Bullet_10 < 1740f)
			{
				this.Bullet_10 = 1541f;
			}
			if (this.Bullet_11 < 1920f)
			{
				this.Bullet_11 = 1163f;
			}
			if (this.Bullet_12 < 1966f)
			{
				this.Bullet_12 = 1227f;
			}
			if (this.Bullet_1 > 497f)
			{
				this.Bullet_1 = 245f;
			}
			if (this.Bullet_2 > 1666f)
			{
				this.Bullet_2 = 439f;
			}
			if (this.Bullet_3 > 674f)
			{
				this.Bullet_3 = 220f;
			}
			if (this.Bullet_4 > 1433f)
			{
				this.Bullet_4 = 235f;
			}
			if (this.Bullet_5 > 760f)
			{
				this.Bullet_5 = 328f;
			}
			if (this.Bullet_6 > 757f)
			{
				this.Bullet_6 = 1067f;
			}
			if (this.Bullet_7 > 1810f)
			{
				this.Bullet_7 = 1167f;
			}
			if (this.Bullet_8 > 681f)
			{
				this.Bullet_8 = 1540f;
			}
			if (this.Bullet_9 > 1878f)
			{
				this.Bullet_9 = 1646f;
			}
			if (this.Bullet_10 > 177f)
			{
				this.Bullet_10 = 449f;
			}
			if (this.Bullet_11 > 1871f)
			{
				this.Bullet_11 = 1580f;
			}
			if (this.Bullet_12 > 1021f)
			{
				this.Bullet_12 = 1253f;
			}
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/3D_Inverse", this.Bullet_1);
			this.OCHJIMJNEMO().SetFloat("[MapEditor] Updating map assets", this.Bullet_2);
			this.ADBKPGFMNKO().SetFloat("_Value2", this.Bullet_3);
			this.NBPKMLMCHFN.SetFloat("_Offsets", this.Bullet_4);
			this.DKNJGHFLAIF().SetFloat("BitsData", this.Bullet_5);
			this.NDMPCDHADMJ().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this.Bullet_6);
			this.DKNJGHFLAIF().SetFloat("_MatrixSpeed", this.Bullet_7);
			this.OCHJIMJNEMO().SetFloat("_Value", this.Bullet_8);
			this.DBOLLHHMKKN().SetFloat(" TimeOfRespawn: ", this.Bullet_9);
			this.MFHPKGICPIO().SetFloat("[MapEditor] Loading events...", this.Bullet_10);
			this.LONNIJMNKFB().SetFloat("Tab1Content", this.Bullet_11);
			this.NDMPCDHADMJ().SetFloat("bad", this.Bullet_12);
			this.HCGJCMDJPGD().SetTexture("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x001A8785 File Offset: 0x001A6985
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x001AAA38 File Offset: 0x001A8C38
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055D6 RID: 21974 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060055D7 RID: 21975 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x060055D8 RID: 21976 RVA: 0x001AAA6F File Offset: 0x001A8C6F
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load("Using Stopwatch as precision timer for PUN.") as Texture2D);
		this.SCShader = Shader.Find("VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055D9 RID: 21977 RVA: 0x001AAAA8 File Offset: 0x001A8CA8
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055DB RID: 21979 RVA: 0x001AAB00 File Offset: 0x001A8D00
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 854f)
			{
				this.HBJJOCHGOPH = 1525f;
			}
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/FX_EarthQuake", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 345f)
			{
				this.Bullet_1 = 1527f;
			}
			if (this.Bullet_2 < 16f)
			{
				this.Bullet_2 = 1990f;
			}
			if (this.Bullet_3 < 865f)
			{
				this.Bullet_3 = 964f;
			}
			if (this.Bullet_4 < 481f)
			{
				this.Bullet_4 = 1209f;
			}
			if (this.Bullet_5 < 1440f)
			{
				this.Bullet_5 = 172f;
			}
			if (this.Bullet_6 < 288f)
			{
				this.Bullet_6 = 496f;
			}
			if (this.Bullet_7 < 1866f)
			{
				this.Bullet_7 = 509f;
			}
			if (this.Bullet_8 < 1176f)
			{
				this.Bullet_8 = 1438f;
			}
			if (this.Bullet_9 < 36f)
			{
				this.Bullet_9 = 1631f;
			}
			if (this.Bullet_10 < 1486f)
			{
				this.Bullet_10 = 444f;
			}
			if (this.Bullet_11 < 951f)
			{
				this.Bullet_11 = 17f;
			}
			if (this.Bullet_12 < 523f)
			{
				this.Bullet_12 = 299f;
			}
			if (this.Bullet_1 > 577f)
			{
				this.Bullet_1 = 500f;
			}
			if (this.Bullet_2 > 155f)
			{
				this.Bullet_2 = 221f;
			}
			if (this.Bullet_3 > 1115f)
			{
				this.Bullet_3 = 1625f;
			}
			if (this.Bullet_4 > 806f)
			{
				this.Bullet_4 = 1651f;
			}
			if (this.Bullet_5 > 1674f)
			{
				this.Bullet_5 = 1099f;
			}
			if (this.Bullet_6 > 1024f)
			{
				this.Bullet_6 = 1952f;
			}
			if (this.Bullet_7 > 992f)
			{
				this.Bullet_7 = 1020f;
			}
			if (this.Bullet_8 > 1979f)
			{
				this.Bullet_8 = 216f;
			}
			if (this.Bullet_9 > 42f)
			{
				this.Bullet_9 = 1677f;
			}
			if (this.Bullet_10 > 1792f)
			{
				this.Bullet_10 = 1908f;
			}
			if (this.Bullet_11 > 706f)
			{
				this.Bullet_11 = 680f;
			}
			if (this.Bullet_12 > 823f)
			{
				this.Bullet_12 = 1034f;
			}
			this.ADBKPGFMNKO().SetFloat("float,0", this.Bullet_1);
			this.DKNJGHFLAIF().SetFloat("{}", this.Bullet_2);
			this.IIBLJCKLGFG().SetFloat("EventSystem", this.Bullet_3);
			this.IIBLJCKLGFG().SetFloat("DPADVER", this.Bullet_4);
			this.NBPKMLMCHFN.SetFloat("\r", this.Bullet_5);
			this.ADBKPGFMNKO().SetFloat("/", this.Bullet_6);
			this.NDMPCDHADMJ().SetFloat(">", this.Bullet_7);
			this.OCHJIMJNEMO().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.Bullet_9);
			this.IIBLJCKLGFG().SetFloat("OpGetGameList()", this.Bullet_10);
			this.NDMPCDHADMJ().SetFloat("]. Please verify you have this gameobject in a Resources folder.", this.Bullet_11);
			this.DBOLLHHMKKN().SetFloat("ICollection", this.Bullet_12);
			this.ADBKPGFMNKO().SetTexture("menu.selectedplaymode", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055DC RID: 21980 RVA: 0x001AAF20 File Offset: 0x001A9120
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("NewMusicFileSelector") as Texture2D);
		this.SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055DD RID: 21981 RVA: 0x001A8785 File Offset: 0x001A6985
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055DE RID: 21982 RVA: 0x001AAF59 File Offset: 0x001A9159
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_VHS") as Texture2D);
		this.SCShader = Shader.Find("\" that takes ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x060055DF RID: 21983 RVA: 0x001AAF92 File Offset: 0x001A9192
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x060055E0 RID: 21984 RVA: 0x001AAFCC File Offset: 0x001A91CC
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1455f)
			{
				this.HBJJOCHGOPH = 1406f;
			}
			this.OCHJIMJNEMO().SetFloat("GlassDistortion", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 528f)
			{
				this.Bullet_1 = 612f;
			}
			if (this.Bullet_2 < 1980f)
			{
				this.Bullet_2 = 989f;
			}
			if (this.Bullet_3 < 1659f)
			{
				this.Bullet_3 = 892f;
			}
			if (this.Bullet_4 < 1083f)
			{
				this.Bullet_4 = 1003f;
			}
			if (this.Bullet_5 < 1504f)
			{
				this.Bullet_5 = 1932f;
			}
			if (this.Bullet_6 < 772f)
			{
				this.Bullet_6 = 1817f;
			}
			if (this.Bullet_7 < 343f)
			{
				this.Bullet_7 = 868f;
			}
			if (this.Bullet_8 < 373f)
			{
				this.Bullet_8 = 500f;
			}
			if (this.Bullet_9 < 1181f)
			{
				this.Bullet_9 = 1557f;
			}
			if (this.Bullet_10 < 1418f)
			{
				this.Bullet_10 = 877f;
			}
			if (this.Bullet_11 < 423f)
			{
				this.Bullet_11 = 183f;
			}
			if (this.Bullet_12 < 1181f)
			{
				this.Bullet_12 = 1738f;
			}
			if (this.Bullet_1 > 1960f)
			{
				this.Bullet_1 = 1553f;
			}
			if (this.Bullet_2 > 1989f)
			{
				this.Bullet_2 = 1368f;
			}
			if (this.Bullet_3 > 259f)
			{
				this.Bullet_3 = 705f;
			}
			if (this.Bullet_4 > 1167f)
			{
				this.Bullet_4 = 466f;
			}
			if (this.Bullet_5 > 944f)
			{
				this.Bullet_5 = 1156f;
			}
			if (this.Bullet_6 > 138f)
			{
				this.Bullet_6 = 628f;
			}
			if (this.Bullet_7 > 1659f)
			{
				this.Bullet_7 = 625f;
			}
			if (this.Bullet_8 > 352f)
			{
				this.Bullet_8 = 562f;
			}
			if (this.Bullet_9 > 1161f)
			{
				this.Bullet_9 = 811f;
			}
			if (this.Bullet_10 > 1999f)
			{
				this.Bullet_10 = 483f;
			}
			if (this.Bullet_11 > 465f)
			{
				this.Bullet_11 = 1910f;
			}
			if (this.Bullet_12 > 551f)
			{
				this.Bullet_12 = 33f;
			}
			this.DBOLLHHMKKN().SetFloat("EnvironmentSlider", this.Bullet_1);
			this.MFHPKGICPIO().SetFloat("Hex value #RRGGBB", this.Bullet_2);
			this.DKNJGHFLAIF().SetFloat("skin.", this.Bullet_3);
			this.OCHJIMJNEMO().SetFloat("DifficultyBG", this.Bullet_4);
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.penaltyScore", this.Bullet_5);
			this.OCHJIMJNEMO().SetFloat("_TargetScale", this.Bullet_6);
			this.HCGJCMDJPGD().SetFloat("MapEnd", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.Bullet_8);
			this.HCGJCMDJPGD().SetFloat("#yes", this.Bullet_9);
			this.IIBLJCKLGFG().SetFloat("_MaxRayTraceDistance", this.Bullet_10);
			this.IIBLJCKLGFG().SetFloat("InputField", this.Bullet_11);
			this.ADBKPGFMNKO().SetFloat("hidden", this.Bullet_12);
			this.ADBKPGFMNKO().SetTexture(": ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055E1 RID: 21985 RVA: 0x001AB3EC File Offset: 0x001A95EC
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055E2 RID: 21986 RVA: 0x001AB424 File Offset: 0x001A9624
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1217f)
			{
				this.HBJJOCHGOPH = 1483f;
			}
			this.OCHJIMJNEMO().SetFloat("0.00", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1041f)
			{
				this.Bullet_1 = 1423f;
			}
			if (this.Bullet_2 < 121f)
			{
				this.Bullet_2 = 1462f;
			}
			if (this.Bullet_3 < 418f)
			{
				this.Bullet_3 = 401f;
			}
			if (this.Bullet_4 < 199f)
			{
				this.Bullet_4 = 277f;
			}
			if (this.Bullet_5 < 1492f)
			{
				this.Bullet_5 = 1168f;
			}
			if (this.Bullet_6 < 760f)
			{
				this.Bullet_6 = 1407f;
			}
			if (this.Bullet_7 < 1535f)
			{
				this.Bullet_7 = 246f;
			}
			if (this.Bullet_8 < 197f)
			{
				this.Bullet_8 = 271f;
			}
			if (this.Bullet_9 < 1401f)
			{
				this.Bullet_9 = 1946f;
			}
			if (this.Bullet_10 < 552f)
			{
				this.Bullet_10 = 1663f;
			}
			if (this.Bullet_11 < 937f)
			{
				this.Bullet_11 = 243f;
			}
			if (this.Bullet_12 < 1746f)
			{
				this.Bullet_12 = 1620f;
			}
			if (this.Bullet_1 > 1087f)
			{
				this.Bullet_1 = 1188f;
			}
			if (this.Bullet_2 > 582f)
			{
				this.Bullet_2 = 494f;
			}
			if (this.Bullet_3 > 1383f)
			{
				this.Bullet_3 = 94f;
			}
			if (this.Bullet_4 > 414f)
			{
				this.Bullet_4 = 724f;
			}
			if (this.Bullet_5 > 761f)
			{
				this.Bullet_5 = 503f;
			}
			if (this.Bullet_6 > 1685f)
			{
				this.Bullet_6 = 880f;
			}
			if (this.Bullet_7 > 743f)
			{
				this.Bullet_7 = 376f;
			}
			if (this.Bullet_8 > 560f)
			{
				this.Bullet_8 = 1612f;
			}
			if (this.Bullet_9 > 1245f)
			{
				this.Bullet_9 = 1291f;
			}
			if (this.Bullet_10 > 703f)
			{
				this.Bullet_10 = 540f;
			}
			if (this.Bullet_11 > 715f)
			{
				this.Bullet_11 = 1101f;
			}
			if (this.Bullet_12 > 676f)
			{
				this.Bullet_12 = 830f;
			}
			this.IIBLJCKLGFG().SetFloat("LevelInfoInputField", this.Bullet_1);
			this.ADBKPGFMNKO().SetFloat("[PlayerController] ", this.Bullet_2);
			this.NDMPCDHADMJ().SetFloat("ls", this.Bullet_3);
			this.HCGJCMDJPGD().SetFloat("_Value4", this.Bullet_4);
			this.NDMPCDHADMJ().SetFloat("PublishButton", this.Bullet_5);
			this.NDMPCDHADMJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Bullet_6);
			this.DKNJGHFLAIF().SetFloat("maps.", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Bullet_8);
			this.ADBKPGFMNKO().SetFloat("settings_bindings_sec_", this.Bullet_9);
			this.HCGJCMDJPGD().SetFloat("#ok", this.Bullet_10);
			this.HCGJCMDJPGD().SetFloat("Save Path: ", this.Bullet_11);
			this.MFHPKGICPIO().SetFloat("selector", this.Bullet_12);
			this.LONNIJMNKFB().SetTexture("LoadMapCanvas", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x001AB844 File Offset: 0x001A9A44
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 749f)
			{
				this.HBJJOCHGOPH = 1967f;
			}
			this.LONNIJMNKFB().SetFloat("loadscene", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1202f)
			{
				this.Bullet_1 = 1467f;
			}
			if (this.Bullet_2 < 134f)
			{
				this.Bullet_2 = 365f;
			}
			if (this.Bullet_3 < 1616f)
			{
				this.Bullet_3 = 1301f;
			}
			if (this.Bullet_4 < 675f)
			{
				this.Bullet_4 = 1519f;
			}
			if (this.Bullet_5 < 1907f)
			{
				this.Bullet_5 = 917f;
			}
			if (this.Bullet_6 < 982f)
			{
				this.Bullet_6 = 857f;
			}
			if (this.Bullet_7 < 903f)
			{
				this.Bullet_7 = 1985f;
			}
			if (this.Bullet_8 < 221f)
			{
				this.Bullet_8 = 1570f;
			}
			if (this.Bullet_9 < 1971f)
			{
				this.Bullet_9 = 913f;
			}
			if (this.Bullet_10 < 271f)
			{
				this.Bullet_10 = 1559f;
			}
			if (this.Bullet_11 < 1896f)
			{
				this.Bullet_11 = 582f;
			}
			if (this.Bullet_12 < 7f)
			{
				this.Bullet_12 = 267f;
			}
			if (this.Bullet_1 > 1093f)
			{
				this.Bullet_1 = 166f;
			}
			if (this.Bullet_2 > 924f)
			{
				this.Bullet_2 = 374f;
			}
			if (this.Bullet_3 > 883f)
			{
				this.Bullet_3 = 973f;
			}
			if (this.Bullet_4 > 72f)
			{
				this.Bullet_4 = 730f;
			}
			if (this.Bullet_5 > 1837f)
			{
				this.Bullet_5 = 1352f;
			}
			if (this.Bullet_6 > 1929f)
			{
				this.Bullet_6 = 1701f;
			}
			if (this.Bullet_7 > 747f)
			{
				this.Bullet_7 = 1967f;
			}
			if (this.Bullet_8 > 1553f)
			{
				this.Bullet_8 = 1097f;
			}
			if (this.Bullet_9 > 1532f)
			{
				this.Bullet_9 = 1510f;
			}
			if (this.Bullet_10 > 708f)
			{
				this.Bullet_10 = 997f;
			}
			if (this.Bullet_11 > 864f)
			{
				this.Bullet_11 = 1122f;
			}
			if (this.Bullet_12 > 1578f)
			{
				this.Bullet_12 = 245f;
			}
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.Bullet_1);
			this.NBPKMLMCHFN.SetFloat("Gameplay/sun", this.Bullet_2);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.Bullet_3);
			this.DBOLLHHMKKN().SetFloat("_Saturation", this.Bullet_4);
			this.LONNIJMNKFB().SetFloat("[Down]", this.Bullet_5);
			this.HCGJCMDJPGD().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", this.Bullet_6);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/TV_CompressionFX", this.Bullet_7);
			this.MFHPKGICPIO().SetFloat("_Value3", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("HandsCountSlider", this.Bullet_9);
			this.NBPKMLMCHFN.SetFloat("_MainTex", this.Bullet_10);
			this.HCGJCMDJPGD().SetFloat("_OnOff", this.Bullet_11);
			this.DBOLLHHMKKN().SetFloat("ViewMenu", this.Bullet_12);
			this.IIBLJCKLGFG().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055E5 RID: 21989 RVA: 0x001A8785 File Offset: 0x001A6985
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055E6 RID: 21990 RVA: 0x001ABC64 File Offset: 0x001A9E64
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings") as Texture2D);
		this.SCShader = Shader.Find(".sawoutdatedmessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055E7 RID: 21991 RVA: 0x001ABC9D File Offset: 0x001A9E9D
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value10") as Texture2D);
		this.SCShader = Shader.Find(".b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055E8 RID: 21992 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060055E9 RID: 21993 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060055EA RID: 21994 RVA: 0x001ABCD6 File Offset: 0x001A9ED6
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("#TBD") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055EB RID: 21995 RVA: 0x001ABD10 File Offset: 0x001A9F10
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 414f)
			{
				this.HBJJOCHGOPH = 1558f;
			}
			this.MFHPKGICPIO().SetFloat("no lives color", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1734f)
			{
				this.Bullet_1 = 494f;
			}
			if (this.Bullet_2 < 1738f)
			{
				this.Bullet_2 = 1413f;
			}
			if (this.Bullet_3 < 751f)
			{
				this.Bullet_3 = 1998f;
			}
			if (this.Bullet_4 < 1310f)
			{
				this.Bullet_4 = 1258f;
			}
			if (this.Bullet_5 < 1481f)
			{
				this.Bullet_5 = 1383f;
			}
			if (this.Bullet_6 < 1109f)
			{
				this.Bullet_6 = 1783f;
			}
			if (this.Bullet_7 < 1480f)
			{
				this.Bullet_7 = 41f;
			}
			if (this.Bullet_8 < 142f)
			{
				this.Bullet_8 = 990f;
			}
			if (this.Bullet_9 < 1265f)
			{
				this.Bullet_9 = 969f;
			}
			if (this.Bullet_10 < 1807f)
			{
				this.Bullet_10 = 1886f;
			}
			if (this.Bullet_11 < 525f)
			{
				this.Bullet_11 = 1811f;
			}
			if (this.Bullet_12 < 1585f)
			{
				this.Bullet_12 = 497f;
			}
			if (this.Bullet_1 > 356f)
			{
				this.Bullet_1 = 442f;
			}
			if (this.Bullet_2 > 1681f)
			{
				this.Bullet_2 = 35f;
			}
			if (this.Bullet_3 > 1393f)
			{
				this.Bullet_3 = 241f;
			}
			if (this.Bullet_4 > 997f)
			{
				this.Bullet_4 = 774f;
			}
			if (this.Bullet_5 > 315f)
			{
				this.Bullet_5 = 1615f;
			}
			if (this.Bullet_6 > 1629f)
			{
				this.Bullet_6 = 1072f;
			}
			if (this.Bullet_7 > 820f)
			{
				this.Bullet_7 = 116f;
			}
			if (this.Bullet_8 > 112f)
			{
				this.Bullet_8 = 161f;
			}
			if (this.Bullet_9 > 1701f)
			{
				this.Bullet_9 = 1973f;
			}
			if (this.Bullet_10 > 105f)
			{
				this.Bullet_10 = 1067f;
			}
			if (this.Bullet_11 > 839f)
			{
				this.Bullet_11 = 1206f;
			}
			if (this.Bullet_12 > 1723f)
			{
				this.Bullet_12 = 1260f;
			}
			this.DKNJGHFLAIF().SetFloat("Achievement 21 progress reseted", this.Bullet_1);
			this.ADBKPGFMNKO().SetFloat("maps.", this.Bullet_2);
			this.LONNIJMNKFB().SetFloat("_RGB", this.Bullet_3);
			this.MFHPKGICPIO().SetFloat("_AdaptationSpeed", this.Bullet_4);
			this.MFHPKGICPIO().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", this.Bullet_5);
			this.MFHPKGICPIO().SetFloat("#startofflinemessage", this.Bullet_6);
			this.NDMPCDHADMJ().SetFloat("UseScanLine", this.Bullet_7);
			this.ADBKPGFMNKO().SetFloat("Malformed RPC; this should never occur. Content: ", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Blur_Dithering2x2", this.Bullet_9);
			this.OCHJIMJNEMO().SetFloat("_TimeX", this.Bullet_10);
			this.IIBLJCKLGFG().SetFloat("Gameplay/Base", this.Bullet_11);
			this.IIBLJCKLGFG().SetFloat("LoadMapCanvas", this.Bullet_12);
			this.NDMPCDHADMJ().SetTexture("[PlayerBase] Loaded custom model: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055EC RID: 21996 RVA: 0x001AC130 File Offset: 0x001AA330
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load(" url: ") as Texture2D);
		this.SCShader = Shader.Find("Preparing content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055ED RID: 21997 RVA: 0x001AC16C File Offset: 0x001AA36C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 0f)
			{
				this.Bullet_1 = 0f;
			}
			if (this.Bullet_2 < 0f)
			{
				this.Bullet_2 = 0f;
			}
			if (this.Bullet_3 < 0f)
			{
				this.Bullet_3 = 0f;
			}
			if (this.Bullet_4 < 0f)
			{
				this.Bullet_4 = 0f;
			}
			if (this.Bullet_5 < 0f)
			{
				this.Bullet_5 = 0f;
			}
			if (this.Bullet_6 < 0f)
			{
				this.Bullet_6 = 0f;
			}
			if (this.Bullet_7 < 0f)
			{
				this.Bullet_7 = 0f;
			}
			if (this.Bullet_8 < 0f)
			{
				this.Bullet_8 = 0f;
			}
			if (this.Bullet_9 < 0f)
			{
				this.Bullet_9 = 0f;
			}
			if (this.Bullet_10 < 0f)
			{
				this.Bullet_10 = 0f;
			}
			if (this.Bullet_11 < 0f)
			{
				this.Bullet_11 = 0f;
			}
			if (this.Bullet_12 < 0f)
			{
				this.Bullet_12 = 0f;
			}
			if (this.Bullet_1 > 1f)
			{
				this.Bullet_1 = 1f;
			}
			if (this.Bullet_2 > 1f)
			{
				this.Bullet_2 = 1f;
			}
			if (this.Bullet_3 > 1f)
			{
				this.Bullet_3 = 1f;
			}
			if (this.Bullet_4 > 1f)
			{
				this.Bullet_4 = 1f;
			}
			if (this.Bullet_5 > 1f)
			{
				this.Bullet_5 = 1f;
			}
			if (this.Bullet_6 > 1f)
			{
				this.Bullet_6 = 1f;
			}
			if (this.Bullet_7 > 1f)
			{
				this.Bullet_7 = 1f;
			}
			if (this.Bullet_8 > 1f)
			{
				this.Bullet_8 = 1f;
			}
			if (this.Bullet_9 > 1f)
			{
				this.Bullet_9 = 1f;
			}
			if (this.Bullet_10 > 1f)
			{
				this.Bullet_10 = 1f;
			}
			if (this.Bullet_11 > 1f)
			{
				this.Bullet_11 = 1f;
			}
			if (this.Bullet_12 > 1f)
			{
				this.Bullet_12 = 1f;
			}
			this.NBPKMLMCHFN.SetFloat("_Bullet_1", this.Bullet_1);
			this.NBPKMLMCHFN.SetFloat("_Bullet_2", this.Bullet_2);
			this.NBPKMLMCHFN.SetFloat("_Bullet_3", this.Bullet_3);
			this.NBPKMLMCHFN.SetFloat("_Bullet_4", this.Bullet_4);
			this.NBPKMLMCHFN.SetFloat("_Bullet_5", this.Bullet_5);
			this.NBPKMLMCHFN.SetFloat("_Bullet_6", this.Bullet_6);
			this.NBPKMLMCHFN.SetFloat("_Bullet_7", this.Bullet_7);
			this.NBPKMLMCHFN.SetFloat("_Bullet_8", this.Bullet_8);
			this.NBPKMLMCHFN.SetFloat("_Bullet_9", this.Bullet_9);
			this.NBPKMLMCHFN.SetFloat("_Bullet_10", this.Bullet_10);
			this.NBPKMLMCHFN.SetFloat("_Bullet_11", this.Bullet_11);
			this.NBPKMLMCHFN.SetFloat("_Bullet_12", this.Bullet_12);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060055EE RID: 21998 RVA: 0x001AC58C File Offset: 0x001AA78C
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055EF RID: 21999 RVA: 0x001AC5C5 File Offset: 0x001AA7C5
	private void FEHCNJLLJMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055F0 RID: 22000 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060055F1 RID: 22001 RVA: 0x001AC5FE File Offset: 0x001AA7FE
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060055F2 RID: 22002 RVA: 0x001AC635 File Offset: 0x001AA835
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055F3 RID: 22003 RVA: 0x001AC66E File Offset: 0x001AA86E
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Green_R") as Texture2D);
		this.SCShader = Shader.Find("Had to lookup view that wasn't in photonViewList: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055F4 RID: 22004 RVA: 0x001A8785 File Offset: 0x001A6985
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055F5 RID: 22005 RVA: 0x001AC6A7 File Offset: 0x001AA8A7
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("bool") as Texture2D);
		this.SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055F6 RID: 22006 RVA: 0x001AC6E0 File Offset: 0x001AA8E0
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("PunSupportLogger");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055F7 RID: 22007 RVA: 0x001A8785 File Offset: 0x001A6985
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055F8 RID: 22008 RVA: 0x001AC719 File Offset: 0x001AA919
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load(" x ") as Texture2D);
		this.SCShader = Shader.Find("VIGNETTE_CLASSIC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055F9 RID: 22009 RVA: 0x001A8785 File Offset: 0x001A6985
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055FA RID: 22010 RVA: 0x001A8785 File Offset: 0x001A6985
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060055FB RID: 22011 RVA: 0x001AC752 File Offset: 0x001AA952
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060055FC RID: 22012 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060055FD RID: 22013 RVA: 0x001AC78B File Offset: 0x001AA98B
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button8") as Texture2D);
		this.SCShader = Shader.Find("Connected to gameserver.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060055FE RID: 22014 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060055FF RID: 22015 RVA: 0x001AC7C4 File Offset: 0x001AA9C4
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1625f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			this.IIBLJCKLGFG().SetFloat("_Colored", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1262f)
			{
				this.Bullet_1 = 434f;
			}
			if (this.Bullet_2 < 1905f)
			{
				this.Bullet_2 = 1685f;
			}
			if (this.Bullet_3 < 1201f)
			{
				this.Bullet_3 = 618f;
			}
			if (this.Bullet_4 < 1115f)
			{
				this.Bullet_4 = 901f;
			}
			if (this.Bullet_5 < 425f)
			{
				this.Bullet_5 = 799f;
			}
			if (this.Bullet_6 < 1445f)
			{
				this.Bullet_6 = 1357f;
			}
			if (this.Bullet_7 < 30f)
			{
				this.Bullet_7 = 112f;
			}
			if (this.Bullet_8 < 862f)
			{
				this.Bullet_8 = 485f;
			}
			if (this.Bullet_9 < 543f)
			{
				this.Bullet_9 = 559f;
			}
			if (this.Bullet_10 < 973f)
			{
				this.Bullet_10 = 1921f;
			}
			if (this.Bullet_11 < 1762f)
			{
				this.Bullet_11 = 781f;
			}
			if (this.Bullet_12 < 1790f)
			{
				this.Bullet_12 = 220f;
			}
			if (this.Bullet_1 > 347f)
			{
				this.Bullet_1 = 1129f;
			}
			if (this.Bullet_2 > 1576f)
			{
				this.Bullet_2 = 1232f;
			}
			if (this.Bullet_3 > 836f)
			{
				this.Bullet_3 = 1195f;
			}
			if (this.Bullet_4 > 1164f)
			{
				this.Bullet_4 = 609f;
			}
			if (this.Bullet_5 > 70f)
			{
				this.Bullet_5 = 216f;
			}
			if (this.Bullet_6 > 1258f)
			{
				this.Bullet_6 = 899f;
			}
			if (this.Bullet_7 > 595f)
			{
				this.Bullet_7 = 1566f;
			}
			if (this.Bullet_8 > 408f)
			{
				this.Bullet_8 = 662f;
			}
			if (this.Bullet_9 > 1930f)
			{
				this.Bullet_9 = 1648f;
			}
			if (this.Bullet_10 > 918f)
			{
				this.Bullet_10 = 1511f;
			}
			if (this.Bullet_11 > 1039f)
			{
				this.Bullet_11 = 351f;
			}
			if (this.Bullet_12 > 1551f)
			{
				this.Bullet_12 = 1865f;
			}
			this.DBOLLHHMKKN().SetFloat("_SizeY", this.Bullet_1);
			this.MFHPKGICPIO().SetFloat("[PowerUp]", this.Bullet_2);
			this.DBOLLHHMKKN().SetFloat("Edited event", this.Bullet_3);
			this.HCGJCMDJPGD().SetFloat("LevelConfigButton", this.Bullet_4);
			this.NDMPCDHADMJ().SetFloat("_UV_Transform", this.Bullet_5);
			this.LONNIJMNKFB().SetFloat("Bad parameters for set! Use <language>", this.Bullet_6);
			this.DBOLLHHMKKN().SetFloat("[PlayerBase] Saveing checkpoint data", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("Right Stick Click", this.Bullet_8);
			this.ADBKPGFMNKO().SetFloat("_Distortion", this.Bullet_9);
			this.NBPKMLMCHFN.SetFloat("mapselector.orderby", this.Bullet_10);
			this.NBPKMLMCHFN.SetFloat("The given 2D texture ", this.Bullet_11);
			this.IIBLJCKLGFG().SetFloat("_Value2", this.Bullet_12);
			this.OCHJIMJNEMO().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005600 RID: 22016 RVA: 0x001ACBE4 File Offset: 0x001AADE4
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005601 RID: 22017 RVA: 0x001ACC1C File Offset: 0x001AAE1C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1146f)
			{
				this.HBJJOCHGOPH = 1320f;
			}
			this.MFHPKGICPIO().SetFloat(" ", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1136f)
			{
				this.Bullet_1 = 1678f;
			}
			if (this.Bullet_2 < 412f)
			{
				this.Bullet_2 = 1202f;
			}
			if (this.Bullet_3 < 936f)
			{
				this.Bullet_3 = 1267f;
			}
			if (this.Bullet_4 < 5f)
			{
				this.Bullet_4 = 383f;
			}
			if (this.Bullet_5 < 302f)
			{
				this.Bullet_5 = 1376f;
			}
			if (this.Bullet_6 < 1693f)
			{
				this.Bullet_6 = 791f;
			}
			if (this.Bullet_7 < 268f)
			{
				this.Bullet_7 = 110f;
			}
			if (this.Bullet_8 < 1396f)
			{
				this.Bullet_8 = 262f;
			}
			if (this.Bullet_9 < 1558f)
			{
				this.Bullet_9 = 251f;
			}
			if (this.Bullet_10 < 1715f)
			{
				this.Bullet_10 = 1063f;
			}
			if (this.Bullet_11 < 1802f)
			{
				this.Bullet_11 = 1628f;
			}
			if (this.Bullet_12 < 995f)
			{
				this.Bullet_12 = 1932f;
			}
			if (this.Bullet_1 > 493f)
			{
				this.Bullet_1 = 1394f;
			}
			if (this.Bullet_2 > 408f)
			{
				this.Bullet_2 = 913f;
			}
			if (this.Bullet_3 > 1175f)
			{
				this.Bullet_3 = 894f;
			}
			if (this.Bullet_4 > 1696f)
			{
				this.Bullet_4 = 1589f;
			}
			if (this.Bullet_5 > 1803f)
			{
				this.Bullet_5 = 1690f;
			}
			if (this.Bullet_6 > 1145f)
			{
				this.Bullet_6 = 415f;
			}
			if (this.Bullet_7 > 1454f)
			{
				this.Bullet_7 = 1149f;
			}
			if (this.Bullet_8 > 1189f)
			{
				this.Bullet_8 = 1242f;
			}
			if (this.Bullet_9 > 951f)
			{
				this.Bullet_9 = 579f;
			}
			if (this.Bullet_10 > 1305f)
			{
				this.Bullet_10 = 252f;
			}
			if (this.Bullet_11 > 584f)
			{
				this.Bullet_11 = 1331f;
			}
			if (this.Bullet_12 > 1184f)
			{
				this.Bullet_12 = 190f;
			}
			this.NDMPCDHADMJ().SetFloat("note.6", this.Bullet_1);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Drawing_Laplacian", this.Bullet_2);
			this.DKNJGHFLAIF().SetFloat("offsets", this.Bullet_3);
			this.LONNIJMNKFB().SetFloat("_DotSize", this.Bullet_4);
			this.OCHJIMJNEMO().SetFloat("settings.selectormapsperpage", this.Bullet_5);
			this.HCGJCMDJPGD().SetFloat(" cannot be used as a 3D LUT.", this.Bullet_6);
			this.IIBLJCKLGFG().SetFloat("GameScene", this.Bullet_7);
			this.OCHJIMJNEMO().SetFloat(".wav", this.Bullet_8);
			this.NDMPCDHADMJ().SetFloat("Tab2Content", this.Bullet_9);
			this.OCHJIMJNEMO().SetFloat("_SecondTex", this.Bullet_10);
			this.LONNIJMNKFB().SetFloat("_Visualize", this.Bullet_11);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/TV_Posterize", this.Bullet_12);
			this.DKNJGHFLAIF().SetTexture("settings.gamemessagesduration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005602 RID: 22018 RVA: 0x001AD03C File Offset: 0x001AB23C
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005603 RID: 22019 RVA: 0x001AD073 File Offset: 0x001AB273
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_BrokenGlass_2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005604 RID: 22020 RVA: 0x001AD0AC File Offset: 0x001AB2AC
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlendTex") as Texture2D);
		this.SCShader = Shader.Find("bool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x001AD0E8 File Offset: 0x001AB2E8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1668f)
			{
				this.HBJJOCHGOPH = 1032f;
			}
			this.OCHJIMJNEMO().SetFloat("_SpawnHeuristic", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1243f)
			{
				this.Bullet_1 = 451f;
			}
			if (this.Bullet_2 < 1641f)
			{
				this.Bullet_2 = 1033f;
			}
			if (this.Bullet_3 < 884f)
			{
				this.Bullet_3 = 1611f;
			}
			if (this.Bullet_4 < 315f)
			{
				this.Bullet_4 = 559f;
			}
			if (this.Bullet_5 < 1798f)
			{
				this.Bullet_5 = 1692f;
			}
			if (this.Bullet_6 < 1767f)
			{
				this.Bullet_6 = 291f;
			}
			if (this.Bullet_7 < 736f)
			{
				this.Bullet_7 = 152f;
			}
			if (this.Bullet_8 < 1607f)
			{
				this.Bullet_8 = 299f;
			}
			if (this.Bullet_9 < 1468f)
			{
				this.Bullet_9 = 1512f;
			}
			if (this.Bullet_10 < 633f)
			{
				this.Bullet_10 = 351f;
			}
			if (this.Bullet_11 < 53f)
			{
				this.Bullet_11 = 1697f;
			}
			if (this.Bullet_12 < 434f)
			{
				this.Bullet_12 = 1405f;
			}
			if (this.Bullet_1 > 1160f)
			{
				this.Bullet_1 = 298f;
			}
			if (this.Bullet_2 > 1024f)
			{
				this.Bullet_2 = 1912f;
			}
			if (this.Bullet_3 > 1755f)
			{
				this.Bullet_3 = 78f;
			}
			if (this.Bullet_4 > 1391f)
			{
				this.Bullet_4 = 225f;
			}
			if (this.Bullet_5 > 1143f)
			{
				this.Bullet_5 = 1882f;
			}
			if (this.Bullet_6 > 91f)
			{
				this.Bullet_6 = 937f;
			}
			if (this.Bullet_7 > 1419f)
			{
				this.Bullet_7 = 1449f;
			}
			if (this.Bullet_8 > 145f)
			{
				this.Bullet_8 = 240f;
			}
			if (this.Bullet_9 > 308f)
			{
				this.Bullet_9 = 32f;
			}
			if (this.Bullet_10 > 1796f)
			{
				this.Bullet_10 = 998f;
			}
			if (this.Bullet_11 > 738f)
			{
				this.Bullet_11 = 856f;
			}
			if (this.Bullet_12 > 300f)
			{
				this.Bullet_12 = 157f;
			}
			this.HCGJCMDJPGD().SetFloat("_SpherePositionX", this.Bullet_1);
			this.NBPKMLMCHFN.SetFloat("X", this.Bullet_2);
			this.DKNJGHFLAIF().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.Bullet_3);
			this.NDMPCDHADMJ().SetFloat(" AuthMode ", this.Bullet_4);
			this.LONNIJMNKFB().SetFloat("EditMenu", this.Bullet_5);
			this.HCGJCMDJPGD().SetFloat("Malformed RPC; this should never occur. Content: ", this.Bullet_6);
			this.IIBLJCKLGFG().SetFloat("distance", this.Bullet_7);
			this.NBPKMLMCHFN.SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.Bullet_8);
			this.OCHJIMJNEMO().SetFloat("settings.fps", this.Bullet_9);
			this.LONNIJMNKFB().SetFloat("???", this.Bullet_10);
			this.LONNIJMNKFB().SetFloat("Connected to gameserver.", this.Bullet_11);
			this.LONNIJMNKFB().SetFloat("settings.crosshairopacity", this.Bullet_12);
			this.HCGJCMDJPGD().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005606 RID: 22022 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x001A8785 File Offset: 0x001A6985
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x001AD508 File Offset: 0x001AB708
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1312f)
			{
				this.HBJJOCHGOPH = 1008f;
			}
			this.MFHPKGICPIO().SetFloat("Mouse", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1743f)
			{
				this.Bullet_1 = 1223f;
			}
			if (this.Bullet_2 < 1402f)
			{
				this.Bullet_2 = 1084f;
			}
			if (this.Bullet_3 < 247f)
			{
				this.Bullet_3 = 1359f;
			}
			if (this.Bullet_4 < 476f)
			{
				this.Bullet_4 = 618f;
			}
			if (this.Bullet_5 < 803f)
			{
				this.Bullet_5 = 1357f;
			}
			if (this.Bullet_6 < 1228f)
			{
				this.Bullet_6 = 1873f;
			}
			if (this.Bullet_7 < 427f)
			{
				this.Bullet_7 = 1278f;
			}
			if (this.Bullet_8 < 1559f)
			{
				this.Bullet_8 = 271f;
			}
			if (this.Bullet_9 < 1006f)
			{
				this.Bullet_9 = 1013f;
			}
			if (this.Bullet_10 < 1785f)
			{
				this.Bullet_10 = 612f;
			}
			if (this.Bullet_11 < 130f)
			{
				this.Bullet_11 = 528f;
			}
			if (this.Bullet_12 < 938f)
			{
				this.Bullet_12 = 431f;
			}
			if (this.Bullet_1 > 851f)
			{
				this.Bullet_1 = 811f;
			}
			if (this.Bullet_2 > 214f)
			{
				this.Bullet_2 = 1540f;
			}
			if (this.Bullet_3 > 899f)
			{
				this.Bullet_3 = 1708f;
			}
			if (this.Bullet_4 > 1396f)
			{
				this.Bullet_4 = 1534f;
			}
			if (this.Bullet_5 > 1700f)
			{
				this.Bullet_5 = 491f;
			}
			if (this.Bullet_6 > 858f)
			{
				this.Bullet_6 = 1170f;
			}
			if (this.Bullet_7 > 1662f)
			{
				this.Bullet_7 = 1445f;
			}
			if (this.Bullet_8 > 179f)
			{
				this.Bullet_8 = 1354f;
			}
			if (this.Bullet_9 > 463f)
			{
				this.Bullet_9 = 146f;
			}
			if (this.Bullet_10 > 922f)
			{
				this.Bullet_10 = 932f;
			}
			if (this.Bullet_11 > 1707f)
			{
				this.Bullet_11 = 164f;
			}
			if (this.Bullet_12 > 287f)
			{
				this.Bullet_12 = 129f;
			}
			this.LONNIJMNKFB().SetFloat(" key(s)", this.Bullet_1);
			this.NBPKMLMCHFN.SetFloat("player.bat", this.Bullet_2);
			this.HCGJCMDJPGD().SetFloat("LeaderboardsButton", this.Bullet_3);
			this.OCHJIMJNEMO().SetFloat("/", this.Bullet_4);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Gradients_Stripe", this.Bullet_5);
			this.NBPKMLMCHFN.SetFloat(":\n", this.Bullet_6);
			this.IIBLJCKLGFG().SetFloat(" not exist", this.Bullet_7);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Color_GrayScale", this.Bullet_8);
			this.IIBLJCKLGFG().SetFloat("maps.", this.Bullet_9);
			this.DKNJGHFLAIF().SetFloat("z", this.Bullet_10);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.Bullet_11);
			this.DKNJGHFLAIF().SetFloat(" GameServer:", this.Bullet_12);
			this.DKNJGHFLAIF().SetTexture("mapselector.filter.rateduponly", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x001AD928 File Offset: 0x001ABB28
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x001A8785 File Offset: 0x001A6985
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600560D RID: 22029 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600560E RID: 22030 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600560F RID: 22031 RVA: 0x001AD960 File Offset: 0x001ABB60
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1341f)
			{
				this.HBJJOCHGOPH = 789f;
			}
			this.DKNJGHFLAIF().SetFloat("ChatHistoryInputField", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1539f)
			{
				this.Bullet_1 = 995f;
			}
			if (this.Bullet_2 < 653f)
			{
				this.Bullet_2 = 40f;
			}
			if (this.Bullet_3 < 40f)
			{
				this.Bullet_3 = 916f;
			}
			if (this.Bullet_4 < 73f)
			{
				this.Bullet_4 = 1663f;
			}
			if (this.Bullet_5 < 1677f)
			{
				this.Bullet_5 = 626f;
			}
			if (this.Bullet_6 < 773f)
			{
				this.Bullet_6 = 931f;
			}
			if (this.Bullet_7 < 920f)
			{
				this.Bullet_7 = 390f;
			}
			if (this.Bullet_8 < 1458f)
			{
				this.Bullet_8 = 1243f;
			}
			if (this.Bullet_9 < 794f)
			{
				this.Bullet_9 = 173f;
			}
			if (this.Bullet_10 < 1573f)
			{
				this.Bullet_10 = 1273f;
			}
			if (this.Bullet_11 < 1653f)
			{
				this.Bullet_11 = 1249f;
			}
			if (this.Bullet_12 < 1463f)
			{
				this.Bullet_12 = 914f;
			}
			if (this.Bullet_1 > 1995f)
			{
				this.Bullet_1 = 1826f;
			}
			if (this.Bullet_2 > 630f)
			{
				this.Bullet_2 = 990f;
			}
			if (this.Bullet_3 > 1450f)
			{
				this.Bullet_3 = 1356f;
			}
			if (this.Bullet_4 > 916f)
			{
				this.Bullet_4 = 406f;
			}
			if (this.Bullet_5 > 1654f)
			{
				this.Bullet_5 = 567f;
			}
			if (this.Bullet_6 > 1609f)
			{
				this.Bullet_6 = 1563f;
			}
			if (this.Bullet_7 > 1481f)
			{
				this.Bullet_7 = 918f;
			}
			if (this.Bullet_8 > 38f)
			{
				this.Bullet_8 = 1814f;
			}
			if (this.Bullet_9 > 279f)
			{
				this.Bullet_9 = 1511f;
			}
			if (this.Bullet_10 > 496f)
			{
				this.Bullet_10 = 1015f;
			}
			if (this.Bullet_11 > 704f)
			{
				this.Bullet_11 = 257f;
			}
			if (this.Bullet_12 > 625f)
			{
				this.Bullet_12 = 1679f;
			}
			this.NDMPCDHADMJ().SetFloat("steamid", this.Bullet_1);
			this.DKNJGHFLAIF().SetFloat("GameScene", this.Bullet_2);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.Bullet_3);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this.Bullet_4);
			this.LONNIJMNKFB().SetFloat("Edited unlock conditions", this.Bullet_5);
			this.DBOLLHHMKKN().SetFloat("float,0", this.Bullet_6);
			this.OCHJIMJNEMO().SetFloat("_Intensity", this.Bullet_7);
			this.OCHJIMJNEMO().SetFloat("settings.crosshairopacity", this.Bullet_8);
			this.MFHPKGICPIO().SetFloat("Electronic", this.Bullet_9);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Antialiasing_FXAA", this.Bullet_10);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Bullet_11);
			this.HCGJCMDJPGD().SetFloat("_Fade", this.Bullet_12);
			this.DKNJGHFLAIF().SetTexture("float,0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005610 RID: 22032 RVA: 0x001A8785 File Offset: 0x001A6985
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005611 RID: 22033 RVA: 0x001A8785 File Offset: 0x001A6985
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005612 RID: 22034 RVA: 0x001A8785 File Offset: 0x001A6985
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005613 RID: 22035 RVA: 0x001A8785 File Offset: 0x001A6985
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005614 RID: 22036 RVA: 0x001ADD80 File Offset: 0x001ABF80
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ") as Texture2D);
		this.SCShader = Shader.Find("_SphereSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005615 RID: 22037 RVA: 0x001ADDBC File Offset: 0x001ABFBC
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1193f)
			{
				this.HBJJOCHGOPH = 1059f;
			}
			this.LONNIJMNKFB().SetFloat("The given 2D texture ", this.HBJJOCHGOPH);
			if (this.Bullet_1 < 1114f)
			{
				this.Bullet_1 = 1485f;
			}
			if (this.Bullet_2 < 15f)
			{
				this.Bullet_2 = 1526f;
			}
			if (this.Bullet_3 < 64f)
			{
				this.Bullet_3 = 1078f;
			}
			if (this.Bullet_4 < 1368f)
			{
				this.Bullet_4 = 961f;
			}
			if (this.Bullet_5 < 1430f)
			{
				this.Bullet_5 = 294f;
			}
			if (this.Bullet_6 < 1521f)
			{
				this.Bullet_6 = 1657f;
			}
			if (this.Bullet_7 < 569f)
			{
				this.Bullet_7 = 1947f;
			}
			if (this.Bullet_8 < 946f)
			{
				this.Bullet_8 = 1519f;
			}
			if (this.Bullet_9 < 1686f)
			{
				this.Bullet_9 = 857f;
			}
			if (this.Bullet_10 < 654f)
			{
				this.Bullet_10 = 1082f;
			}
			if (this.Bullet_11 < 841f)
			{
				this.Bullet_11 = 395f;
			}
			if (this.Bullet_12 < 743f)
			{
				this.Bullet_12 = 1265f;
			}
			if (this.Bullet_1 > 31f)
			{
				this.Bullet_1 = 929f;
			}
			if (this.Bullet_2 > 1439f)
			{
				this.Bullet_2 = 1623f;
			}
			if (this.Bullet_3 > 1125f)
			{
				this.Bullet_3 = 164f;
			}
			if (this.Bullet_4 > 1583f)
			{
				this.Bullet_4 = 1618f;
			}
			if (this.Bullet_5 > 1874f)
			{
				this.Bullet_5 = 1958f;
			}
			if (this.Bullet_6 > 1063f)
			{
				this.Bullet_6 = 1674f;
			}
			if (this.Bullet_7 > 614f)
			{
				this.Bullet_7 = 243f;
			}
			if (this.Bullet_8 > 343f)
			{
				this.Bullet_8 = 764f;
			}
			if (this.Bullet_9 > 1083f)
			{
				this.Bullet_9 = 1423f;
			}
			if (this.Bullet_10 > 1316f)
			{
				this.Bullet_10 = 1342f;
			}
			if (this.Bullet_11 > 1144f)
			{
				this.Bullet_11 = 1150f;
			}
			if (this.Bullet_12 > 1131f)
			{
				this.Bullet_12 = 1455f;
			}
			this.OCHJIMJNEMO().SetFloat("_LightIntensity", this.Bullet_1);
			this.HCGJCMDJPGD().SetFloat("Uploading preview image...", this.Bullet_2);
			this.ADBKPGFMNKO().SetFloat("UseFinalGlassColor", this.Bullet_3);
			this.MFHPKGICPIO().SetFloat("[PlayerController] ", this.Bullet_4);
			this.IIBLJCKLGFG().SetFloat("_Value6", this.Bullet_5);
			this.OCHJIMJNEMO().SetFloat(".sav", this.Bullet_6);
			this.IIBLJCKLGFG().SetFloat("TestTicket", this.Bullet_7);
			this.HCGJCMDJPGD().SetFloat("skin.", this.Bullet_8);
			this.DKNJGHFLAIF().SetFloat("<b>Time</b>:", this.Bullet_9);
			this.LONNIJMNKFB().SetFloat("Drop_Near", this.Bullet_10);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack_OldFilm1", this.Bullet_11);
			this.DBOLLHHMKKN().SetFloat("GlassesColor", this.Bullet_12);
			this.HCGJCMDJPGD().SetTexture("CameraFilterPack/OldFilm_Cutting1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x001A8785 File Offset: 0x001A6985
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005617 RID: 22039 RVA: 0x001AE1DC File Offset: 0x001AC3DC
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x001A8785 File Offset: 0x001A6985
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040008EC RID: 2284
	public Shader SCShader;

	// Token: 0x040008ED RID: 2285
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008EE RID: 2286
	[Range(0f, 1f)]
	public float Bullet_1;

	// Token: 0x040008EF RID: 2287
	[Range(0f, 1f)]
	public float Bullet_2;

	// Token: 0x040008F0 RID: 2288
	[Range(0f, 1f)]
	public float Bullet_3;

	// Token: 0x040008F1 RID: 2289
	[Range(0f, 1f)]
	public float Bullet_4 = 1f;

	// Token: 0x040008F2 RID: 2290
	[Range(0f, 1f)]
	public float Bullet_5;

	// Token: 0x040008F3 RID: 2291
	[Range(0f, 1f)]
	public float Bullet_6;

	// Token: 0x040008F4 RID: 2292
	[Range(0f, 1f)]
	public float Bullet_7;

	// Token: 0x040008F5 RID: 2293
	[Range(0f, 1f)]
	public float Bullet_8;

	// Token: 0x040008F6 RID: 2294
	[Range(0f, 1f)]
	public float Bullet_9;

	// Token: 0x040008F7 RID: 2295
	[Range(0f, 1f)]
	public float Bullet_10;

	// Token: 0x040008F8 RID: 2296
	[Range(0f, 1f)]
	public float Bullet_11;

	// Token: 0x040008F9 RID: 2297
	[Range(0f, 1f)]
	public float Bullet_12;

	// Token: 0x040008FA RID: 2298
	private Material BJFKDHHMLJH;

	// Token: 0x040008FB RID: 2299
	private Texture2D FPHEBLMINDA;
}
