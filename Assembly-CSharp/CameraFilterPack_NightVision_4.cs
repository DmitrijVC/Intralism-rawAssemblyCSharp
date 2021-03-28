using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000F4 RID: 244
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 4")]
public class CameraFilterPack_NightVision_4 : MonoBehaviour
{
	// Token: 0x06004B9A RID: 19354 RVA: 0x001746DC File Offset: 0x001728DC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 185f)
			{
				this.HBJJOCHGOPH = 1114f;
			}
			this.LPDOGGFOBDH().SetFloat("PointsScoreText", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_NoiseTex", this.PLKFKNHPEHE[0] / 942f);
			this.OIBHFCLJKDB().SetFloat("Bad modpack name: {0}", this.PLKFKNHPEHE[1] / 1819f);
			this.MMOODGIODPC().SetFloat("_threshold", this.PLKFKNHPEHE[6] / 1683f);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.PLKFKNHPEHE[5] / 85f);
			this.OIBHFCLJKDB().SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 428f);
			this.ECCPAOBFDKP().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", this.PLKFKNHPEHE[6] / 1291f);
			this.JFDGLLEOPGB().SetFloat("music", this.PLKFKNHPEHE[6] / 566f);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.PLKFKNHPEHE[4] / 1506f);
			this.CIAFLBFJLEJ().SetFloat("Set satellite audio input", this.PLKFKNHPEHE[6] / 172f);
			this.PLBEJJIHFPB().SetFloat("LivesSlider", this.PLKFKNHPEHE[-112] / 1842f);
			this.OJMHIMIPKME().SetFloat("Set particles count per one beat", this.PLKFKNHPEHE[-86] / 1438f);
			this.BLMPMOIDGMG().SetFloat("_LensDirtIntensity", this.PLKFKNHPEHE[-111] / 1500f);
			this.JFDGLLEOPGB().SetFloat("_Value", this.FadeFX);
			this.JFDGLLEOPGB().SetVector("CameraFilterPack/Color_RGB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 189f, 859f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x00174904 File Offset: 0x00172B04
	private void CJPHFMAAIDC()
	{
		float[] array = new float[89];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x0017491E File Offset: 0x00172B1E
	private void JFJLGJEPEAA()
	{
		this.FMEFPOILMDI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x00174949 File Offset: 0x00172B49
	private void DBLILJGKGHJ()
	{
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x00174974 File Offset: 0x00172B74
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1527f)
			{
				this.HBJJOCHGOPH = 1517f;
			}
			this.HNFFHCLNBDN().SetFloat(":</b> ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("AvatarImage", this.PLKFKNHPEHE[1] / 1618f);
			this.NBPKMLMCHFN.SetFloat("_Value", this.PLKFKNHPEHE[1] / 1876f);
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[3] / 169f);
			this.ECCPAOBFDKP().SetFloat("Joystick1Button2", this.PLKFKNHPEHE[8] / 1532f);
			this.DKKBFFHBHJE().SetFloat("workshop.", this.PLKFKNHPEHE[5] / 1705f);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 1113f);
			this.HILDKDFEBPF().SetFloat("masterVolume", this.PLKFKNHPEHE[5] / 1525f);
			this.HNFFHCLNBDN().SetFloat("[", this.PLKFKNHPEHE[0] / 1672f);
			this.MMOODGIODPC().SetFloat("[ReplayScene] Loading replay: ", this.PLKFKNHPEHE[2] / 518f);
			this.BAGICADFBAB().SetFloat("maps.", this.PLKFKNHPEHE[-48] / 563f);
			this.FEAEGGCNIAA().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", this.PLKFKNHPEHE[-93] / 1625f);
			this.HNFFHCLNBDN().SetFloat("_ReflectionTexture4", this.PLKFKNHPEHE[30] / 352f);
			this.OIBHFCLJKDB().SetFloat("_BlurPass", this.FadeFX);
			this.DKKBFFHBHJE().SetVector("Music End", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 537f, 57f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x00174949 File Offset: 0x00172B49
	private void MJEFMIPLFAB()
	{
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x00174B9C File Offset: 0x00172D9C
	private void FALHNNJBOEM()
	{
		float[] array = new float[30];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x00174BB8 File Offset: 0x00172DB8
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 921f)
			{
				this.HBJJOCHGOPH = 1783f;
			}
			this.ENKPNJMPDEB().SetFloat("UseScanLine", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("GenerationMenu", this.PLKFKNHPEHE[1] / 1140f);
			this.DKKBFFHBHJE().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.PLKFKNHPEHE[1] / 229f);
			this.ENKPNJMPDEB().SetFloat("offsets", this.PLKFKNHPEHE[2] / 265f);
			this.CIAFLBFJLEJ().SetFloat("offsets", this.PLKFKNHPEHE[5] / 1917f);
			this.DKKBFFHBHJE().SetFloat(".lastCheckpoint.perfectHits", this.PLKFKNHPEHE[5] / 1753f);
			this.OIBHFCLJKDB().SetFloat("\n", this.PLKFKNHPEHE[2] / 908f);
			this.MMOODGIODPC().SetFloat("#tryagain", this.PLKFKNHPEHE[1] / 1396f);
			this.PLBEJJIHFPB().SetFloat("_BlurParams", this.PLKFKNHPEHE[1] / 396f);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.PLKFKNHPEHE[2] / 105f);
			this.HILDKDFEBPF().SetFloat("isVisible", this.PLKFKNHPEHE[31] / 101f);
			this.LPDOGGFOBDH().SetFloat("menu.playedpage", this.PLKFKNHPEHE[67] / 1459f);
			this.NBPKMLMCHFN.SetFloat("BadgeText", this.PLKFKNHPEHE[65] / 1539f);
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.FadeFX);
			this.LEIAFCPJMDP().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 939f, 1028f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x00174DE0 File Offset: 0x00172FE0
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 13f)
			{
				this.HBJJOCHGOPH = 1119f;
			}
			this.JFDGLLEOPGB().SetFloat("PenaltyScoreText", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_Color2", this.PLKFKNHPEHE[0] / 1256f);
			this.OIBHFCLJKDB().SetFloat(". Using max value: 255.", this.PLKFKNHPEHE[0] / 895f);
			this.NBPKMLMCHFN.SetFloat("y", this.PLKFKNHPEHE[7] / 575f);
			this.LPDOGGFOBDH().SetFloat("float,0", this.PLKFKNHPEHE[4] / 1090f);
			this.DKKBFFHBHJE().SetFloat("SteamManager", this.PLKFKNHPEHE[7] / 1089f);
			this.BLMPMOIDGMG().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[6] / 1991f);
			this.PLBEJJIHFPB().SetFloat("_Value4", this.PLKFKNHPEHE[2] / 1155f);
			this.NBPKMLMCHFN.SetFloat("settings_bindings_sec_", this.PLKFKNHPEHE[2] / 1433f);
			this.PLBEJJIHFPB().SetFloat("settings.enableranking", this.PLKFKNHPEHE[5] / 470f);
			this.HILDKDFEBPF().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[20] / 925f);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[5] / 1786f);
			this.BAGICADFBAB().SetFloat("settings.shaders", this.PLKFKNHPEHE[124] / 1058f);
			this.ENKPNJMPDEB().SetFloat("_TimeX", this.FadeFX);
			this.FEAEGGCNIAA().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 900f, 1559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x00175008 File Offset: 0x00173208
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 1271f;
			}
			this.FEAEGGCNIAA().SetFloat("Hidden/ScreenSpaceReflection", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.PLKFKNHPEHE[0] / 1727f);
			this.OJMHIMIPKME().SetFloat(".", this.PLKFKNHPEHE[0] / 1899f);
			this.LEIAFCPJMDP().SetFloat("_Offsets", this.PLKFKNHPEHE[4] / 779f);
			this.HNFFHCLNBDN().SetFloat(" not found", this.PLKFKNHPEHE[4] / 1983f);
			this.CIAFLBFJLEJ().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", this.PLKFKNHPEHE[3] / 304f);
			this.CIAFLBFJLEJ().SetFloat("Done!", this.PLKFKNHPEHE[4] / 1236f);
			this.OIBHFCLJKDB().SetFloat("0.00", this.PLKFKNHPEHE[4] / 1332f);
			this.OIBHFCLJKDB().SetFloat(".played", this.PLKFKNHPEHE[6] / 717f);
			this.LEIAFCPJMDP().SetFloat("Created", this.PLKFKNHPEHE[8] / 1160f);
			this.ECCPAOBFDKP().SetFloat("player.goldlollipop", this.PLKFKNHPEHE[-31] / 1598f);
			this.DKKBFFHBHJE().SetFloat("_FixDistance", this.PLKFKNHPEHE[-66] / 768f);
			this.LEIAFCPJMDP().SetFloat("_Value2", this.PLKFKNHPEHE[-68] / 1709f);
			this.NBPKMLMCHFN.SetFloat("A", this.FadeFX);
			this.CIAFLBFJLEJ().SetVector("float,2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1801f, 1505f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x00175230 File Offset: 0x00173430
	private void PHINJDJEFLI()
	{
		float[] array = new float[33];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BA5 RID: 19365 RVA: 0x0017524C File Offset: 0x0017344C
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 413f)
			{
				this.HBJJOCHGOPH = 1507f;
			}
			this.MMOODGIODPC().SetFloat("Netw. Sim.", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("#timeuntilend: ", this.PLKFKNHPEHE[0] / 691f);
			this.HILDKDFEBPF().SetFloat("CameraFilterPack/3D_Distortion", this.PLKFKNHPEHE[0] / 64f);
			this.HNFFHCLNBDN().SetFloat("_Blue_B", this.PLKFKNHPEHE[3] / 1520f);
			this.LEIAFCPJMDP().SetFloat("PunRespawn", this.PLKFKNHPEHE[0] / 115f);
			this.HNFFHCLNBDN().SetFloat("_PColor2", this.PLKFKNHPEHE[1] / 1278f);
			this.HILDKDFEBPF().SetFloat("Joystick1Button2", this.PLKFKNHPEHE[6] / 830f);
			this.DKKBFFHBHJE().SetFloat("_Value2", this.PLKFKNHPEHE[3] / 991f);
			this.LPDOGGFOBDH().SetFloat("InfoCanvas", this.PLKFKNHPEHE[6] / 864f);
			this.FEAEGGCNIAA().SetFloat("player.goldwatermelon", this.PLKFKNHPEHE[6] / 1725f);
			this.FEAEGGCNIAA().SetFloat("maps.", this.PLKFKNHPEHE[88] / 1607f);
			this.BLMPMOIDGMG().SetFloat("_Green_G", this.PLKFKNHPEHE[-115] / 1398f);
			this.LEIAFCPJMDP().SetFloat("maps.", this.PLKFKNHPEHE[-4] / 131f);
			this.DKKBFFHBHJE().SetFloat("challenges/", this.FadeFX);
			this.LEIAFCPJMDP().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 384f, 1628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x00175474 File Offset: 0x00173674
	private void GPJHPNGNEBP()
	{
		this.FCDODOIJIIB();
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x0017547C File Offset: 0x0017367C
	private void OLGKEEPPPKG()
	{
		float[] array = new float[127];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x00175496 File Offset: 0x00173696
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x001754B3 File Offset: 0x001736B3
	private void ACBAHLCGNDD()
	{
		this.JBBKKKJOJMJ();
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x001754BB File Offset: 0x001736BB
	private void MMMDPANNAIO()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x001754E6 File Offset: 0x001736E6
	private void LGHCJCFHEMF()
	{
		this.FJNEBMBJPLK();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x00175511 File Offset: 0x00173711
	private void NFMCBMDELNK()
	{
		float[] array = new float[-101];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x00175496 File Offset: 0x00173696
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x00175496 File Offset: 0x00173696
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x0017552B File Offset: 0x0017372B
	private void DJGJOMFJPEF()
	{
		float[] array = new float[-50];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BB1 RID: 19377 RVA: 0x00175496 File Offset: 0x00173696
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BB2 RID: 19378 RVA: 0x00175496 File Offset: 0x00173696
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BB3 RID: 19379 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06004BB4 RID: 19380 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06004BB5 RID: 19381 RVA: 0x00175545 File Offset: 0x00173745
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BB6 RID: 19382 RVA: 0x0017557C File Offset: 0x0017377C
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BB7 RID: 19383 RVA: 0x00175496 File Offset: 0x00173696
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BB8 RID: 19384 RVA: 0x001755B3 File Offset: 0x001737B3
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BB9 RID: 19385 RVA: 0x001755EC File Offset: 0x001737EC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1653f)
			{
				this.HBJJOCHGOPH = 928f;
			}
			this.BLMPMOIDGMG().SetFloat("rarity", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("checkpoint", this.PLKFKNHPEHE[0] / 1154f);
			this.OIBHFCLJKDB().SetFloat("OnMastedChangeScene", this.PLKFKNHPEHE[0] / 1652f);
			this.PLBEJJIHFPB().SetFloat("maps.", this.PLKFKNHPEHE[4] / 243f);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/FX_8bits_gb", this.PLKFKNHPEHE[2] / 1684f);
			this.ECCPAOBFDKP().SetFloat("PlayButton", this.PLKFKNHPEHE[1] / 428f);
			this.BLMPMOIDGMG().SetFloat("#close", this.PLKFKNHPEHE[0] / 318f);
			this.ECCPAOBFDKP().SetFloat("a", this.PLKFKNHPEHE[1] / 1676f);
			this.JFDGLLEOPGB().SetFloat("#ok", this.PLKFKNHPEHE[7] / 1878f);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Tiles", this.PLKFKNHPEHE[8] / 1221f);
			this.ENKPNJMPDEB().SetFloat("_Value9", this.PLKFKNHPEHE[113] / 1009f);
			this.CIAFLBFJLEJ().SetFloat("\\\"", this.PLKFKNHPEHE[-74] / 877f);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PLKFKNHPEHE[-60] / 240f);
			this.LPDOGGFOBDH().SetFloat("NetworkCanvas", this.FadeFX);
			this.DKKBFFHBHJE().SetVector("[Up-Right]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 881f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BBA RID: 19386 RVA: 0x00175496 File Offset: 0x00173696
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BBB RID: 19387 RVA: 0x00175814 File Offset: 0x00173A14
	private void KKDDHFJOAAD()
	{
		this.JKCPPCDFLBL();
	}

	// Token: 0x06004BBC RID: 19388 RVA: 0x0017581C File Offset: 0x00173A1C
	private void MGGFMCIGOAF()
	{
		float[] array = new float[92];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BBD RID: 19389 RVA: 0x00175836 File Offset: 0x00173A36
	private void COIJKMKIEAK()
	{
		this.PHINJDJEFLI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BBE RID: 19390 RVA: 0x00175861 File Offset: 0x00173A61
	private void KOFAMEKHHGD()
	{
		this.NDAIGNNKOAC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BBF RID: 19391 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06004BC0 RID: 19392 RVA: 0x0017588C File Offset: 0x00173A8C
	private void EIMNPCMHJLJ()
	{
		this.NDAIGNNKOAC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BC1 RID: 19393 RVA: 0x001758B7 File Offset: 0x00173AB7
	private void IDJKNBDKHBD()
	{
		this.CJPHFMAAIDC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BC2 RID: 19394 RVA: 0x001758E4 File Offset: 0x00173AE4
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1583f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.OJMHIMIPKME().SetFloat("In Map Editor", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("IconFileSelector", this.PLKFKNHPEHE[1] / 92f);
			this.LEIAFCPJMDP().SetFloat("GameScene", this.PLKFKNHPEHE[0] / 1399f);
			this.HILDKDFEBPF().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[5] / 1310f);
			this.JFDGLLEOPGB().SetFloat("^", this.PLKFKNHPEHE[4] / 673f);
			this.ECCPAOBFDKP().SetFloat("_BlurredColor", this.PLKFKNHPEHE[6] / 656f);
			this.PLBEJJIHFPB().SetFloat("y", this.PLKFKNHPEHE[0] / 1393f);
			this.CIAFLBFJLEJ().SetFloat("SelectorMapsCountSlider", this.PLKFKNHPEHE[0] / 1103f);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.PLKFKNHPEHE[3] / 1311f);
			this.LEIAFCPJMDP().SetFloat("QuickSave", this.PLKFKNHPEHE[6] / 709f);
			this.HNFFHCLNBDN().SetFloat("Object ID", this.PLKFKNHPEHE[-17] / 127f);
			this.MMOODGIODPC().SetFloat("Set sun audio input", this.PLKFKNHPEHE[-11] / 1080f);
			this.LEIAFCPJMDP().SetFloat("_Value", this.PLKFKNHPEHE[-30] / 415f);
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this.FadeFX);
			this.OJMHIMIPKME().SetVector("Malformed RPC; this should never occur. Content: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1769f, 609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BC3 RID: 19395 RVA: 0x00175B0C File Offset: 0x00173D0C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 47f)
			{
				this.HBJJOCHGOPH = 307f;
			}
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("_Value2", this.PLKFKNHPEHE[1] / 1636f);
			this.FEAEGGCNIAA().SetFloat("/", this.PLKFKNHPEHE[1] / 1462f);
			this.BLMPMOIDGMG().SetFloat("/", this.PLKFKNHPEHE[4] / 1459f);
			this.HILDKDFEBPF().SetFloat("Received event Leave for unknown player ID: {0}", this.PLKFKNHPEHE[6] / 198f);
			this.JFDGLLEOPGB().SetFloat("_FarCamera", this.PLKFKNHPEHE[5] / 189f);
			this.ENKPNJMPDEB().SetFloat("mapselector.filter.subscribedonly", this.PLKFKNHPEHE[5] / 1215f);
			this.FEAEGGCNIAA().SetFloat("{0} seconds ago", this.PLKFKNHPEHE[7] / 168f);
			this.ENKPNJMPDEB().SetFloat(" ", this.PLKFKNHPEHE[5] / 1080f);
			this.BLMPMOIDGMG().SetFloat("Object ID", this.PLKFKNHPEHE[7] / 562f);
			this.LEIAFCPJMDP().SetFloat("CameraFilterPack/FX_InverChromiLum", this.PLKFKNHPEHE[-49] / 624f);
			this.FEAEGGCNIAA().SetFloat("BitsData", this.PLKFKNHPEHE[-7] / 1600f);
			this.BAGICADFBAB().SetFloat("Did not read byte array properly", this.PLKFKNHPEHE[0] / 628f);
			this.ENKPNJMPDEB().SetFloat("isVisible", this.FadeFX);
			this.LPDOGGFOBDH().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1708f, 1803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BC4 RID: 19396 RVA: 0x00175D34 File Offset: 0x00173F34
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 836f)
			{
				this.HBJJOCHGOPH = 982f;
			}
			this.CIAFLBFJLEJ().SetFloat("OnStatusChanged: {0} current State: {1}", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("1,30,true,0", this.PLKFKNHPEHE[1] / 206f);
			this.DKKBFFHBHJE().SetFloat("failed", this.PLKFKNHPEHE[0] / 1201f);
			this.NBPKMLMCHFN.SetFloat(": ", this.PLKFKNHPEHE[3] / 33f);
			this.BAGICADFBAB().SetFloat("Start", this.PLKFKNHPEHE[3] / 972f);
			this.LEIAFCPJMDP().SetFloat("_CutOff", this.PLKFKNHPEHE[6] / 193f);
			this.DKKBFFHBHJE().SetFloat("_Offsets", this.PLKFKNHPEHE[0] / 1946f);
			this.HNFFHCLNBDN().SetFloat("#ok", this.PLKFKNHPEHE[3] / 1927f);
			this.CIAFLBFJLEJ().SetFloat("EnvironmentSlider", this.PLKFKNHPEHE[0] / 503f);
			this.JFDGLLEOPGB().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", this.PLKFKNHPEHE[1] / 1084f);
			this.BLMPMOIDGMG().SetFloat("GlassesColor2", this.PLKFKNHPEHE[-8] / 306f);
			this.BAGICADFBAB().SetFloat("Source: ", this.PLKFKNHPEHE[-71] / 678f);
			this.LPDOGGFOBDH().SetFloat("plainText", this.PLKFKNHPEHE[84] / 658f);
			this.LPDOGGFOBDH().SetFloat("_Value2", this.FadeFX);
			this.BAGICADFBAB().SetVector("_History1Weight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 39f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BC5 RID: 19397 RVA: 0x00175F5C File Offset: 0x0017415C
	private void OEAMLMGNFFC()
	{
		this.DJGJOMFJPEF();
	}

	// Token: 0x06004BC6 RID: 19398 RVA: 0x00175496 File Offset: 0x00173696
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BC7 RID: 19399 RVA: 0x00175F64 File Offset: 0x00174164
	private void DOMPMIAIDIL()
	{
		float[] array = new float[-18];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BC8 RID: 19400 RVA: 0x00175F7E File Offset: 0x0017417E
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BC9 RID: 19401 RVA: 0x00175FB5 File Offset: 0x001741B5
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BCA RID: 19402 RVA: 0x00175FEC File Offset: 0x001741EC
	private void NBMEBBHCNMH()
	{
		float[] array = new float[114];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BCB RID: 19403 RVA: 0x00176006 File Offset: 0x00174206
	private void IHAGANPOFDP()
	{
		this.FMEFPOILMDI();
	}

	// Token: 0x06004BCC RID: 19404 RVA: 0x00175496 File Offset: 0x00173696
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BCD RID: 19405 RVA: 0x0017600E File Offset: 0x0017420E
	private void MBFNACDMEEK()
	{
		this.PHINJDJEFLI();
	}

	// Token: 0x06004BCE RID: 19406 RVA: 0x00176018 File Offset: 0x00174218
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 902f;
			}
			this.OJMHIMIPKME().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("MessageText", this.PLKFKNHPEHE[1] / 403f);
			this.LEIAFCPJMDP().SetFloat("_History3ChromaTex", this.PLKFKNHPEHE[0] / 318f);
			this.HNFFHCLNBDN().SetFloat(" AuthMode ", this.PLKFKNHPEHE[4] / 329f);
			this.CIAFLBFJLEJ().SetFloat("_BlurTexture", this.PLKFKNHPEHE[7] / 119f);
			this.ECCPAOBFDKP().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[5] / 1938f);
			this.BLMPMOIDGMG().SetFloat("Populate Mesh Data", this.PLKFKNHPEHE[6] / 1746f);
			this.ECCPAOBFDKP().SetFloat("Object ID. Case-Sensitive", this.PLKFKNHPEHE[7] / 34f);
			this.LEIAFCPJMDP().SetFloat("Subscribe: ", this.PLKFKNHPEHE[0] / 213f);
			this.OIBHFCLJKDB().SetFloat("[PlayerBase] Delete checkpoint data", this.PLKFKNHPEHE[5] / 1600f);
			this.DKKBFFHBHJE().SetFloat("Tab2Content", this.PLKFKNHPEHE[-78] / 986f);
			this.ENKPNJMPDEB().SetFloat("_Offsets", this.PLKFKNHPEHE[93] / 1784f);
			this.ECCPAOBFDKP().SetFloat("</i>", this.PLKFKNHPEHE[-85] / 1634f);
			this.FEAEGGCNIAA().SetFloat("_Value3", this.FadeFX);
			this.HILDKDFEBPF().SetVector("_Axis", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 106f, 1655f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BCF RID: 19407 RVA: 0x00175496 File Offset: 0x00173696
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BD0 RID: 19408 RVA: 0x00176240 File Offset: 0x00174440
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BD1 RID: 19409 RVA: 0x00176277 File Offset: 0x00174477
	private void FBIHCGOKELF()
	{
		float[] array = new float[119];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x00176291 File Offset: 0x00174491
	private void POIFMMFPELA()
	{
		this.NDAIGNNKOAC();
	}

	// Token: 0x06004BD4 RID: 19412 RVA: 0x00176299 File Offset: 0x00174499
	private void FMFNILJIEIA()
	{
		this.IKDGKCLIJBL();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x001762C4 File Offset: 0x001744C4
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

	// Token: 0x06004BD6 RID: 19414 RVA: 0x001762FB File Offset: 0x001744FB
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BD7 RID: 19415 RVA: 0x00176332 File Offset: 0x00174532
	private void FJNEBMBJPLK()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BD8 RID: 19416 RVA: 0x0017634C File Offset: 0x0017454C
	private void JPBEEFIPDOL()
	{
		float[] array = new float[-56];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BD9 RID: 19417 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06004BDA RID: 19418 RVA: 0x00176368 File Offset: 0x00174568
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 64f)
			{
				this.HBJJOCHGOPH = 1872f;
			}
			this.DKKBFFHBHJE().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("settings.shaders", this.PLKFKNHPEHE[1] / 946f);
			this.LPDOGGFOBDH().SetFloat("Mouse Y", this.PLKFKNHPEHE[1] / 563f);
			this.BAGICADFBAB().SetFloat("no lives color", this.PLKFKNHPEHE[7] / 752f);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/Glitch_Mozaic", this.PLKFKNHPEHE[5] / 951f);
			this.OJMHIMIPKME().SetFloat("{0} seconds ago", this.PLKFKNHPEHE[8] / 1180f);
			this.HILDKDFEBPF().SetFloat("_Amount", this.PLKFKNHPEHE[2] / 1890f);
			this.LPDOGGFOBDH().SetFloat("_FgOverlap", this.PLKFKNHPEHE[7] / 418f);
			this.MMOODGIODPC().SetFloat("#close", this.PLKFKNHPEHE[6] / 613f);
			this.LPDOGGFOBDH().SetFloat("Search: ", this.PLKFKNHPEHE[8] / 13f);
			this.PLBEJJIHFPB().SetFloat("Tab2Content", this.PLKFKNHPEHE[-92] / 1070f);
			this.OIBHFCLJKDB().SetFloat("CameraFilterPack/Blur_Movie", this.PLKFKNHPEHE[-66] / 165f);
			this.BLMPMOIDGMG().SetFloat("settings_bindings_sec_", this.PLKFKNHPEHE[-67] / 162f);
			this.ENKPNJMPDEB().SetFloat("_ScreenResolution", this.FadeFX);
			this.HNFFHCLNBDN().SetVector("_Far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 183f, 1529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BDB RID: 19419 RVA: 0x00176590 File Offset: 0x00174790
	private void DLBODOFAJGM()
	{
		this.JPBEEFIPDOL();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BDC RID: 19420 RVA: 0x001765BB File Offset: 0x001747BB
	private void FCDODOIJIIB()
	{
		float[] array = new float[66];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BDD RID: 19421 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004BDE RID: 19422 RVA: 0x001765D5 File Offset: 0x001747D5
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BDF RID: 19423 RVA: 0x00175496 File Offset: 0x00173696
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BE0 RID: 19424 RVA: 0x0017660C File Offset: 0x0017480C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 512f)
			{
				this.HBJJOCHGOPH = 995f;
			}
			this.FEAEGGCNIAA().SetFloat("_MidGrey", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 92f);
			this.HNFFHCLNBDN().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 410f);
			this.HNFFHCLNBDN().SetFloat("maps.", this.PLKFKNHPEHE[4] / 1781f);
			this.ECCPAOBFDKP().SetFloat("_Intensity", this.PLKFKNHPEHE[2] / 1065f);
			this.CIAFLBFJLEJ().SetFloat("image", this.PLKFKNHPEHE[1] / 132f);
			this.FEAEGGCNIAA().SetFloat("powerup.0", this.PLKFKNHPEHE[0] / 1348f);
			this.PLBEJJIHFPB().SetFloat("NameInfoText", this.PLKFKNHPEHE[5] / 1307f);
			this.LPDOGGFOBDH().SetFloat("Hidden/DepthOfField/MedianFilter", this.PLKFKNHPEHE[8] / 547f);
			this.LPDOGGFOBDH().SetFloat("Tab2Content", this.PLKFKNHPEHE[4] / 309f);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/Colors_HUE_Rotate", this.PLKFKNHPEHE[-67] / 344f);
			this.HILDKDFEBPF().SetFloat("Edited unlock conditions", this.PLKFKNHPEHE[46] / 1329f);
			this.OIBHFCLJKDB().SetFloat("{0}", this.PLKFKNHPEHE[-111] / 687f);
			this.PLBEJJIHFPB().SetFloat("_MainTex2", this.FadeFX);
			this.ENKPNJMPDEB().SetVector("\t", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1740f, 991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BE1 RID: 19425 RVA: 0x00176834 File Offset: 0x00174A34
	private void OnValidate()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x06004BE2 RID: 19426 RVA: 0x0017683C File Offset: 0x00174A3C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 958f)
			{
				this.HBJJOCHGOPH = 1700f;
			}
			this.NBPKMLMCHFN.SetFloat("Joined Room. isMasterClient: ", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("[LevelEditorScene] Reloaded config for \"", this.PLKFKNHPEHE[0] / 1819f);
			this.MMOODGIODPC().SetFloat("UI Extensions/SoftMaskShaderText", this.PLKFKNHPEHE[1] / 59f);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[4] / 602f);
			this.PLBEJJIHFPB().SetFloat("_BlurPass", this.PLKFKNHPEHE[1] / 1040f);
			this.ECCPAOBFDKP().SetFloat("OxOD.lastPath", this.PLKFKNHPEHE[0] / 0f);
			this.OIBHFCLJKDB().SetFloat("settings.cameramovements", this.PLKFKNHPEHE[1] / 1801f);
			this.OJMHIMIPKME().SetFloat("_MainTex2", this.PLKFKNHPEHE[8] / 783f);
			this.ECCPAOBFDKP().SetFloat("Fade", this.PLKFKNHPEHE[3] / 1124f);
			this.HILDKDFEBPF().SetFloat("note.5", this.PLKFKNHPEHE[1] / 497f);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.PLKFKNHPEHE[-30] / 1496f);
			this.HNFFHCLNBDN().SetFloat("InventoryGrid", this.PLKFKNHPEHE[-126] / 1595f);
			this.PLBEJJIHFPB().SetFloat("_ColorR", this.PLKFKNHPEHE[-68] / 518f);
			this.OJMHIMIPKME().SetFloat("Joystick1Button12", this.FadeFX);
			this.ENKPNJMPDEB().SetVector("CameraFilterPack/Edge_Neon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 53f, 981f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BE3 RID: 19427 RVA: 0x00176A64 File Offset: 0x00174C64
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 527f)
			{
				this.HBJJOCHGOPH = 346f;
			}
			this.LPDOGGFOBDH().SetFloat("<color=#", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_Size", this.PLKFKNHPEHE[1] / 102f);
			this.ECCPAOBFDKP().SetFloat("EventTimeInputField", this.PLKFKNHPEHE[0] / 1765f);
			this.HILDKDFEBPF().SetFloat("Init", this.PLKFKNHPEHE[1] / 711f);
			this.ECCPAOBFDKP().SetFloat("...", this.PLKFKNHPEHE[3] / 1282f);
			this.BAGICADFBAB().SetFloat("_Value7", this.PLKFKNHPEHE[8] / 180f);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[2] / 804f);
			this.MMOODGIODPC().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.PLKFKNHPEHE[5] / 484f);
			this.HNFFHCLNBDN().SetFloat("Tab1Content", this.PLKFKNHPEHE[0] / 1996f);
			this.HNFFHCLNBDN().SetFloat("resource", this.PLKFKNHPEHE[4] / 801f);
			this.BLMPMOIDGMG().SetFloat("================================", this.PLKFKNHPEHE[-26] / 1367f);
			this.ECCPAOBFDKP().SetFloat("menu.enableselectormusic", this.PLKFKNHPEHE[67] / 1811f);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.PLKFKNHPEHE[-78] / 781f);
			this.PLBEJJIHFPB().SetFloat("#score", this.FadeFX);
			this.OIBHFCLJKDB().SetVector(".completedMaps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 950f, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BE4 RID: 19428 RVA: 0x00176C8C File Offset: 0x00174E8C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1624f)
			{
				this.HBJJOCHGOPH = 970f;
			}
			this.LPDOGGFOBDH().SetFloat("CameraFilterPack/TV_Chromatical2", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Crosshair", this.PLKFKNHPEHE[0] / 246f);
			this.ENKPNJMPDEB().SetFloat("replayData", this.PLKFKNHPEHE[1] / 815f);
			this.OJMHIMIPKME().SetFloat("inventory.selected.", this.PLKFKNHPEHE[3] / 682f);
			this.LPDOGGFOBDH().SetFloat("_MidGrey", this.PLKFKNHPEHE[7] / 713f);
			this.CIAFLBFJLEJ().SetFloat("LastNewsButton", this.PLKFKNHPEHE[4] / 477f);
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/FX_superDot", this.PLKFKNHPEHE[6] / 754f);
			this.BAGICADFBAB().SetFloat("MapEnd", this.PLKFKNHPEHE[8] / 136f);
			this.DKKBFFHBHJE().SetFloat("#orderby:", this.PLKFKNHPEHE[7] / 440f);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this.PLKFKNHPEHE[4] / 1794f);
			this.BLMPMOIDGMG().SetFloat("Object ID. Case-Sensitive", this.PLKFKNHPEHE[12] / 1885f);
			this.OJMHIMIPKME().SetFloat("Joystick1Button11", this.PLKFKNHPEHE[-42] / 242f);
			this.HILDKDFEBPF().SetFloat("CameraFilterPack/AAA_Super_Hexagon", this.PLKFKNHPEHE[-45] / 1716f);
			this.BLMPMOIDGMG().SetFloat("<color=#", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("#no", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1519f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BE5 RID: 19429 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004BE6 RID: 19430 RVA: 0x00175496 File Offset: 0x00173696
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004BE7 RID: 19431 RVA: 0x00176590 File Offset: 0x00174790
	private void PKLOBJHKFEO()
	{
		this.JPBEEFIPDOL();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BE8 RID: 19432 RVA: 0x00176EB4 File Offset: 0x001750B4
	private void CGDMLHLJIDK()
	{
		this.FBIHCGOKELF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BE9 RID: 19433 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06004BEA RID: 19434 RVA: 0x00176EDF File Offset: 0x001750DF
	private void ADPLHDFJFID()
	{
		this.JKCPPCDFLBL();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BEB RID: 19435 RVA: 0x00176F0C File Offset: 0x0017510C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 684f)
			{
				this.HBJJOCHGOPH = 47f;
			}
			this.NBPKMLMCHFN.SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("_ConsoleSettings", this.PLKFKNHPEHE[1] / 717f);
			this.HNFFHCLNBDN().SetFloat("Fade", this.PLKFKNHPEHE[1] / 1508f);
			this.NBPKMLMCHFN.SetFloat("OnPickedUp", this.PLKFKNHPEHE[4] / 1252f);
			this.MMOODGIODPC().SetFloat("[Up-Left]", this.PLKFKNHPEHE[5] / 1273f);
			this.JFDGLLEOPGB().SetFloat("#tryagain", this.PLKFKNHPEHE[5] / 1454f);
			this.OIBHFCLJKDB().SetFloat(" with a prefix of ", this.PLKFKNHPEHE[2] / 1736f);
			this.ECCPAOBFDKP().SetFloat("checkpoint", this.PLKFKNHPEHE[7] / 181f);
			this.PLBEJJIHFPB().SetFloat("OpAuthenticate()", this.PLKFKNHPEHE[4] / 1705f);
			this.LEIAFCPJMDP().SetFloat(":", this.PLKFKNHPEHE[7] / 0f);
			this.ENKPNJMPDEB().SetFloat("Set camera background color", this.PLKFKNHPEHE[119] / 1652f);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Gradients_Ansi", this.PLKFKNHPEHE[96] / 345f);
			this.OJMHIMIPKME().SetFloat("_AdaptParams", this.PLKFKNHPEHE[39] / 1494f);
			this.FEAEGGCNIAA().SetFloat(". Going to authenticate anyways.", this.FadeFX);
			this.HILDKDFEBPF().SetVector("Left", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 255f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BEC RID: 19436 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06004BED RID: 19437 RVA: 0x00177134 File Offset: 0x00175334
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BEE RID: 19438 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004BEF RID: 19439 RVA: 0x0017716B File Offset: 0x0017536B
	private void MIPGPMKJELI()
	{
		this.PLKFKNHPEHE = new float[]
		{
			200f,
			-200f,
			-200f,
			195f,
			4f,
			-160f,
			200f,
			-200f,
			-200f,
			-200f,
			10f,
			-200f
		};
	}

	// Token: 0x06004BF0 RID: 19440 RVA: 0x00177185 File Offset: 0x00175385
	private void NDAIGNNKOAC()
	{
		float[] array = new float[83];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BF1 RID: 19441 RVA: 0x001754BB File Offset: 0x001736BB
	private void Start()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BF2 RID: 19442 RVA: 0x001771A0 File Offset: 0x001753A0
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1106f)
			{
				this.HBJJOCHGOPH = 191f;
			}
			this.HNFFHCLNBDN().SetFloat("ItemsStoreButton", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat(").", this.PLKFKNHPEHE[1] / 1662f);
			this.BAGICADFBAB().SetFloat("Connection error: ", this.PLKFKNHPEHE[0] / 176f);
			this.HILDKDFEBPF().SetFloat("player.crystal", this.PLKFKNHPEHE[5] / 1674f);
			this.FEAEGGCNIAA().SetFloat("workshop.", this.PLKFKNHPEHE[1] / 302f);
			this.HNFFHCLNBDN().SetFloat("back", this.PLKFKNHPEHE[7] / 1540f);
			this.BAGICADFBAB().SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 670f);
			this.HILDKDFEBPF().SetFloat("MaxLivesSlider", this.PLKFKNHPEHE[5] / 1887f);
			this.ENKPNJMPDEB().SetFloat("_SpotSize", this.PLKFKNHPEHE[7] / 1210f);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.PLKFKNHPEHE[8] / 1224f);
			this.LEIAFCPJMDP().SetFloat("_VignetteBlur", this.PLKFKNHPEHE[-82] / 934f);
			this.ENKPNJMPDEB().SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", this.PLKFKNHPEHE[-109] / 1037f);
			this.MMOODGIODPC().SetFloat("_FgOverlap", this.PLKFKNHPEHE[126] / 1971f);
			this.PLBEJJIHFPB().SetFloat("_ColorBuffer", this.FadeFX);
			this.ENKPNJMPDEB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 157f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BF3 RID: 19443 RVA: 0x001773C8 File Offset: 0x001755C8
	private void MEBPBNLBECA()
	{
		this.FJNEBMBJPLK();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BF4 RID: 19444 RVA: 0x001773F3 File Offset: 0x001755F3
	private void DBIBFOINCKM()
	{
		this.JPBEEFIPDOL();
	}

	// Token: 0x06004BF5 RID: 19445 RVA: 0x001773FB File Offset: 0x001755FB
	private void FMEFPOILMDI()
	{
		float[] array = new float[-68];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BF6 RID: 19446 RVA: 0x00177415 File Offset: 0x00175615
	private void IKDGKCLIJBL()
	{
		float[] array = new float[-31];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BF7 RID: 19447 RVA: 0x0017742F File Offset: 0x0017562F
	private void JIGIHDNCJHE()
	{
		float[] array = new float[-90];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BF8 RID: 19448 RVA: 0x00177449 File Offset: 0x00175649
	private void AKHCOBHHGJP()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004BF9 RID: 19449 RVA: 0x00177474 File Offset: 0x00175674
	private void GHMDNIFLGOB()
	{
		this.OBAAOMIIMHO();
	}

	// Token: 0x06004BFA RID: 19450 RVA: 0x0017747C File Offset: 0x0017567C
	private void ALJEJJCIMJN()
	{
		this.MGGFMCIGOAF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004BFB RID: 19451 RVA: 0x001774A7 File Offset: 0x001756A7
	private void EBBMDDEFNKL()
	{
		this.MGGFMCIGOAF();
	}

	// Token: 0x06004BFC RID: 19452 RVA: 0x001774AF File Offset: 0x001756AF
	private void PHOIJLHHAJJ()
	{
		float[] array = new float[-122];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004BFD RID: 19453 RVA: 0x001774CC File Offset: 0x001756CC
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 954f)
			{
				this.HBJJOCHGOPH = 1437f;
			}
			this.OJMHIMIPKME().SetFloat("default", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("[NetworkMenu] Joining ", this.PLKFKNHPEHE[0] / 1291f);
			this.ENKPNJMPDEB().SetFloat("offsets", this.PLKFKNHPEHE[1] / 1139f);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 43f);
			this.ECCPAOBFDKP().SetFloat("PowerUp", this.PLKFKNHPEHE[8] / 1428f);
			this.ENKPNJMPDEB().SetFloat("yesterday", this.PLKFKNHPEHE[7] / 1272f);
			this.BLMPMOIDGMG().SetFloat("_Value4", this.PLKFKNHPEHE[6] / 1675f);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.PLKFKNHPEHE[7] / 1945f);
			this.MMOODGIODPC().SetFloat(" respawn: ", this.PLKFKNHPEHE[1] / 451f);
			this.BLMPMOIDGMG().SetFloat("_InvScreenSize", this.PLKFKNHPEHE[7] / 1880f);
			this.LEIAFCPJMDP().SetFloat("MAPS NOT FOUND", this.PLKFKNHPEHE[63] / 505f);
			this.OIBHFCLJKDB().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.PLKFKNHPEHE[65] / 776f);
			this.CIAFLBFJLEJ().SetFloat("settings.enableranking", this.PLKFKNHPEHE[-59] / 1378f);
			this.FEAEGGCNIAA().SetFloat("_Near", this.FadeFX);
			this.HILDKDFEBPF().SetVector("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 784f, 381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004BFE RID: 19454 RVA: 0x001776F4 File Offset: 0x001758F4
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004BFF RID: 19455 RVA: 0x0017772B File Offset: 0x0017592B
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C00 RID: 19456 RVA: 0x00175496 File Offset: 0x00173696
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C01 RID: 19457 RVA: 0x00177762 File Offset: 0x00175962
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C02 RID: 19458 RVA: 0x00177799 File Offset: 0x00175999
	private void JBBKKKJOJMJ()
	{
		float[] array = new float[-40];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C03 RID: 19459 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06004C04 RID: 19460 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004C05 RID: 19461 RVA: 0x001777B3 File Offset: 0x001759B3
	private void KLILJHJNICK()
	{
		this.CJPHFMAAIDC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C06 RID: 19462 RVA: 0x001754BB File Offset: 0x001736BB
	private void NNFMIAFHMJM()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C07 RID: 19463 RVA: 0x001777E0 File Offset: 0x001759E0
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
			this.NBPKMLMCHFN.SetFloat("_Red_R", this.PLKFKNHPEHE[0] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.PLKFKNHPEHE[1] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_B", this.PLKFKNHPEHE[2] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.PLKFKNHPEHE[3] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.PLKFKNHPEHE[4] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_B", this.PLKFKNHPEHE[5] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_R", this.PLKFKNHPEHE[6] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.PLKFKNHPEHE[7] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.PLKFKNHPEHE[8] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.PLKFKNHPEHE[9] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_C", this.PLKFKNHPEHE[10] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_C", this.PLKFKNHPEHE[11] / 100f);
			this.NBPKMLMCHFN.SetFloat("_FadeFX", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C08 RID: 19464 RVA: 0x00177A08 File Offset: 0x00175C08
	private void JKCPPCDFLBL()
	{
		float[] array = new float[120];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C09 RID: 19465 RVA: 0x00177A22 File Offset: 0x00175C22
	private void HAIAHJPCPAG()
	{
		this.DOMPMIAIDIL();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C0A RID: 19466 RVA: 0x00176006 File Offset: 0x00174206
	private void LFINMLHAMFN()
	{
		this.FMEFPOILMDI();
	}

	// Token: 0x06004C0B RID: 19467 RVA: 0x00177A4D File Offset: 0x00175C4D
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C0C RID: 19468 RVA: 0x00177A84 File Offset: 0x00175C84
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C0D RID: 19469 RVA: 0x00177ABC File Offset: 0x00175CBC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 273f)
			{
				this.HBJJOCHGOPH = 991f;
			}
			this.BLMPMOIDGMG().SetFloat("#ok", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_Value4", this.PLKFKNHPEHE[1] / 1957f);
			this.HNFFHCLNBDN().SetFloat("Tab1Content", this.PLKFKNHPEHE[1] / 960f);
			this.BLMPMOIDGMG().SetFloat("Mouse Y", this.PLKFKNHPEHE[8] / 180f);
			this.JFDGLLEOPGB().SetFloat("_Green_R", this.PLKFKNHPEHE[1] / 919f);
			this.HNFFHCLNBDN().SetFloat("???", this.PLKFKNHPEHE[2] / 786f);
			this.ECCPAOBFDKP().SetFloat("_Value2", this.PLKFKNHPEHE[6] / 1657f);
			this.HILDKDFEBPF().SetFloat("_Bullet_6", this.PLKFKNHPEHE[1] / 1884f);
			this.MMOODGIODPC().SetFloat("_Value4", this.PLKFKNHPEHE[2] / 659f);
			this.ENKPNJMPDEB().SetFloat("float,0", this.PLKFKNHPEHE[5] / 658f);
			this.DKKBFFHBHJE().SetFloat("%", this.PLKFKNHPEHE[118] / 1339f);
			this.LEIAFCPJMDP().SetFloat("\r", this.PLKFKNHPEHE[39] / 1071f);
			this.HILDKDFEBPF().SetFloat("Added event", this.PLKFKNHPEHE[2] / 1450f);
			this.BAGICADFBAB().SetFloat("Set the end of the map. Use this if you want to cut the long music.", this.FadeFX);
			this.NBPKMLMCHFN.SetVector("_Saturation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1478f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C0E RID: 19470 RVA: 0x00176834 File Offset: 0x00174A34
	private void HPOHJDJIADD()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x06004C0F RID: 19471 RVA: 0x00175496 File Offset: 0x00173696
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C10 RID: 19472 RVA: 0x00177CE4 File Offset: 0x00175EE4
	private void OBAAOMIIMHO()
	{
		float[] array = new float[107];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C11 RID: 19473 RVA: 0x00175F5C File Offset: 0x0017415C
	private void IMBPAMHLBOO()
	{
		this.DJGJOMFJPEF();
	}

	// Token: 0x06004C12 RID: 19474 RVA: 0x001773F3 File Offset: 0x001755F3
	private void BNIIBNCLHFA()
	{
		this.JPBEEFIPDOL();
	}

	// Token: 0x06004C13 RID: 19475 RVA: 0x00177CFE File Offset: 0x00175EFE
	private void BKDIBLNOONA()
	{
		float[] array = new float[-71];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C14 RID: 19476 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06004C15 RID: 19477 RVA: 0x00177D18 File Offset: 0x00175F18
	private void MENBDLDBIHO()
	{
		float[] array = new float[-128];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C16 RID: 19478 RVA: 0x00177D32 File Offset: 0x00175F32
	private void DBEMDAJDDDA()
	{
		this.KFKCGDNCONG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C17 RID: 19479 RVA: 0x00177D5D File Offset: 0x00175F5D
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C18 RID: 19480 RVA: 0x00177D94 File Offset: 0x00175F94
	private void KFKCGDNCONG()
	{
		float[] array = new float[26];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C1A RID: 19482 RVA: 0x00176EB4 File Offset: 0x001750B4
	private void JKFDDNMPOJH()
	{
		this.FBIHCGOKELF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C1B RID: 19483 RVA: 0x00177DD8 File Offset: 0x00175FD8
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 842f)
			{
				this.HBJJOCHGOPH = 1031f;
			}
			this.PLBEJJIHFPB().SetFloat("NetworkCanvas", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 1564f);
			this.BLMPMOIDGMG().SetFloat("SettingsCanvas", this.PLKFKNHPEHE[0] / 854f);
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 1579f);
			this.LEIAFCPJMDP().SetFloat("MenuPlayButton", this.PLKFKNHPEHE[4] / 1537f);
			this.ECCPAOBFDKP().SetFloat("GlassAberration", this.PLKFKNHPEHE[2] / 1428f);
			this.FEAEGGCNIAA().SetFloat("_SpotSize", this.PLKFKNHPEHE[4] / 1621f);
			this.ECCPAOBFDKP().SetFloat("_Noise", this.PLKFKNHPEHE[7] / 1993f);
			this.OIBHFCLJKDB().SetFloat("MenuPlayButton", this.PLKFKNHPEHE[5] / 268f);
			this.OIBHFCLJKDB().SetFloat("[ImageLoader] Loaded image from ", this.PLKFKNHPEHE[3] / 237f);
			this.ENKPNJMPDEB().SetFloat("_TimeX", this.PLKFKNHPEHE[-6] / 1929f);
			this.MMOODGIODPC().SetFloat("_Distortion", this.PLKFKNHPEHE[-56] / 1544f);
			this.CIAFLBFJLEJ().SetFloat("SetEnvSpriteImage", this.PLKFKNHPEHE[16] / 959f);
			this.OIBHFCLJKDB().SetFloat("#score", this.FadeFX);
			this.MMOODGIODPC().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 67f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C1C RID: 19484 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06004C1D RID: 19485 RVA: 0x00178000 File Offset: 0x00176200
	private void FEHCNJLLJMP()
	{
		this.PHOIJLHHAJJ();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C1E RID: 19486 RVA: 0x0017802B File Offset: 0x0017622B
	private void LBEHKFNPKMC()
	{
		float[] array = new float[90];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004C1F RID: 19487 RVA: 0x00175496 File Offset: 0x00173696
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C20 RID: 19488 RVA: 0x00178048 File Offset: 0x00176248
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1973f)
			{
				this.HBJJOCHGOPH = 1926f;
			}
			this.HNFFHCLNBDN().SetFloat("g", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_Value4", this.PLKFKNHPEHE[0] / 1171f);
			this.LEIAFCPJMDP().SetFloat("Solo", this.PLKFKNHPEHE[0] / 1670f);
			this.BAGICADFBAB().SetFloat("Mouse Wheel Up", this.PLKFKNHPEHE[3] / 1886f);
			this.NBPKMLMCHFN.SetFloat("#getrewardfailed: ", this.PLKFKNHPEHE[6] / 7f);
			this.BLMPMOIDGMG().SetFloat("_SizeX", this.PLKFKNHPEHE[0] / 839f);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.PLKFKNHPEHE[4] / 1915f);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 809f);
			this.BLMPMOIDGMG().SetFloat("#random #rare #item", this.PLKFKNHPEHE[7] / 1489f);
			this.ECCPAOBFDKP().SetFloat("menu.relaxinfo", this.PLKFKNHPEHE[2] / 1004f);
			this.BAGICADFBAB().SetFloat(".lastCheckpoint.lives", this.PLKFKNHPEHE[41] / 684f);
			this.ECCPAOBFDKP().SetFloat(". Check if the server is available.", this.PLKFKNHPEHE[39] / 1960f);
			this.BAGICADFBAB().SetFloat("_TimeX", this.PLKFKNHPEHE[-36] / 674f);
			this.CIAFLBFJLEJ().SetFloat("_TargetScale", this.FadeFX);
			this.ECCPAOBFDKP().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1518f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C21 RID: 19489 RVA: 0x00178270 File Offset: 0x00176470
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040007EF RID: 2031
	private string ELOFMLPCCEA = "CameraFilterPack/NightVision_4";

	// Token: 0x040007F0 RID: 2032
	public Shader SCShader;

	// Token: 0x040007F1 RID: 2033
	[Range(0f, 1f)]
	public float FadeFX = 1f;

	// Token: 0x040007F2 RID: 2034
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007F3 RID: 2035
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007F4 RID: 2036
	private Material BJFKDHHMLJH;

	// Token: 0x040007F5 RID: 2037
	private float[] PLKFKNHPEHE;
}
