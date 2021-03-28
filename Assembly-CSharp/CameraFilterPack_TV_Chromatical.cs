using System;
using UnityEngine;

// Token: 0x02000114 RID: 276
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Chromatical")]
public class CameraFilterPack_TV_Chromatical : MonoBehaviour
{
	// Token: 0x06005619 RID: 22041 RVA: 0x001AE214 File Offset: 0x001AC414
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 993f;
			if (this.HBJJOCHGOPH > 1480f)
			{
				this.HBJJOCHGOPH = 912f;
			}
			this.CEKJODEAMGB().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("Depth textures aren't supported on this device ({0})", this.Fade);
			this.OCHJIMJNEMO().SetFloat("/", this.Intensity);
			this.LDNADDJMIPK().SetFloat("settings.crosshairopacity", this.Speed);
			this.EFDEIFCDAFG().SetVector(" beatThreshold: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x001AE2FC File Offset: 0x001AC4FC
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x001AE334 File Offset: 0x001AC534
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1550f;
			if (this.HBJJOCHGOPH > 999f)
			{
				this.HBJJOCHGOPH = 352f;
			}
			this.IKAIDLJKLFC().SetFloat("player.licenceaccepted", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("R2", this.Fade);
			this.EFMCNLELMDO().SetFloat("Coord", this.Intensity);
			this.EFDEIFCDAFG().SetFloat(" not exist", this.Speed);
			this.CEKJODEAMGB().SetVector("menutheme.coldheat", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600561C RID: 22044 RVA: 0x001AE41C File Offset: 0x001AC61C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1300f;
			if (this.HBJJOCHGOPH > 1162f)
			{
				this.HBJJOCHGOPH = 1189f;
			}
			this.DOHGBNPMBKG().SetFloat("|", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("DifficultyBG", this.Fade);
			this.HKIMAANBGMJ().SetFloat("Fade", this.Intensity);
			this.JCPDCGIJKJD().SetFloat("#roomname", this.Speed);
			this.OCHJIMJNEMO().SetVector(".status", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600561D RID: 22045 RVA: 0x001AE504 File Offset: 0x001AC704
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600561E RID: 22046 RVA: 0x001AE521 File Offset: 0x001AC721
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600561F RID: 22047 RVA: 0x001AE558 File Offset: 0x001AC758
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x001AE57C File Offset: 0x001AC77C
	private Material IKAIDLJKLFC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005623 RID: 22051 RVA: 0x001AE504 File Offset: 0x001AC704
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x001AE504 File Offset: 0x001AC704
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x001AE5B4 File Offset: 0x001AC7B4
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1452f;
			if (this.HBJJOCHGOPH > 1212f)
			{
				this.HBJJOCHGOPH = 1111f;
			}
			this.PHGCJOPFDOG().SetFloat("https://twitch.tv/intralism", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", this.Fade);
			this.HEINDEMCGIK().SetFloat("#ok", this.Intensity);
			this.LPDOGGFOBDH().SetFloat("OK", this.Speed);
			this.LPDOGGFOBDH().SetVector("speed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06005627 RID: 22055 RVA: 0x001AE69C File Offset: 0x001AC89C
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x001AE6D3 File Offset: 0x001AC8D3
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x001AE504 File Offset: 0x001AC704
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x001AE72B File Offset: 0x001AC92B
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600562E RID: 22062 RVA: 0x001AE74F File Offset: 0x001AC94F
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Edge_filter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600562F RID: 22063 RVA: 0x001AE773 File Offset: 0x001AC973
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005630 RID: 22064 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06005631 RID: 22065 RVA: 0x001AE7AC File Offset: 0x001AC9AC
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 377f;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 215f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("Right Click", this.Fade);
			this.CEKJODEAMGB().SetFloat("SetParticlesParticleSize", this.Intensity);
			this.LONNIJMNKFB().SetFloat("D-Pad Right", this.Speed);
			this.LPDOGGFOBDH().SetVector("_FixDistance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005632 RID: 22066 RVA: 0x001AE894 File Offset: 0x001ACA94
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005633 RID: 22067 RVA: 0x001AE8CB File Offset: 0x001ACACB
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("<command>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005634 RID: 22068 RVA: 0x001AE504 File Offset: 0x001AC704
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005635 RID: 22069 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06005636 RID: 22070 RVA: 0x001AE504 File Offset: 0x001AC704
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005637 RID: 22071 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06005638 RID: 22072 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06005639 RID: 22073 RVA: 0x001AE504 File Offset: 0x001AC704
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600563A RID: 22074 RVA: 0x001AE504 File Offset: 0x001AC704
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x001AE504 File Offset: 0x001AC704
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600563D RID: 22077 RVA: 0x001AE8F0 File Offset: 0x001ACAF0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 762f;
			if (this.HBJJOCHGOPH > 465f)
			{
				this.HBJJOCHGOPH = 1754f;
			}
			this.LPPEPKGFOEM().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", this.Fade);
			this.NFMGLIKNOOC().SetFloat("y", this.Intensity);
			this.LONNIJMNKFB().SetFloat("RanksButton", this.Speed);
			this.INOBFNCKFGK().SetVector(".b", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600563E RID: 22078 RVA: 0x001AE9D8 File Offset: 0x001ACBD8
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 528f;
			if (this.HBJJOCHGOPH > 557f)
			{
				this.HBJJOCHGOPH = 781f;
			}
			this.EFDEIFCDAFG().SetFloat("float,10", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("float,1", this.Fade);
			this.DBOLLHHMKKN().SetFloat("OpJoinLobby()", this.Intensity);
			this.DBOLLHHMKKN().SetFloat("_Distortion", this.Speed);
			this.JCPDCGIJKJD().SetVector("CameraFilterPack/FX_Glitch3", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600563F RID: 22079 RVA: 0x001AEAC0 File Offset: 0x001ACCC0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 943f;
			if (this.HBJJOCHGOPH > 1679f)
			{
				this.HBJJOCHGOPH = 792f;
			}
			this.HEHKGPKLAKK().SetFloat("#C8C8C8FF", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("settings.fps", this.Fade);
			this.DBOLLHHMKKN().SetFloat(") but there is no recycle bin setup for it. Falling back to Instantiate", this.Intensity);
			this.HNICHJCGJOC().SetFloat("Show Title", this.Speed);
			this.EOCCJGIGEGJ().SetVector("Lerp speed. Recomended 10", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06005641 RID: 22081 RVA: 0x001AE504 File Offset: 0x001AC704
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005642 RID: 22082 RVA: 0x001AEBA8 File Offset: 0x001ACDA8
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Chromatical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005643 RID: 22083 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x001AEBCC File Offset: 0x001ACDCC
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("Set Particles Emission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005646 RID: 22086 RVA: 0x001AEBF0 File Offset: 0x001ACDF0
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005647 RID: 22087 RVA: 0x001AE504 File Offset: 0x001AC704
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005648 RID: 22088 RVA: 0x001AE504 File Offset: 0x001AC704
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005649 RID: 22089 RVA: 0x001AEC27 File Offset: 0x001ACE27
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600564A RID: 22090 RVA: 0x001AEC5E File Offset: 0x001ACE5E
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x001AE504 File Offset: 0x001AC704
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x001AEC95 File Offset: 0x001ACE95
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x001AE504 File Offset: 0x001AC704
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x001AECCC File Offset: 0x001ACECC
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x001AED03 File Offset: 0x001ACF03
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005652 RID: 22098 RVA: 0x001AED3A File Offset: 0x001ACF3A
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x001AED74 File Offset: 0x001ACF74
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1086f;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			this.OKJOKHGJHGF().SetFloat("RoomPlayersCountText", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("Can't start OFFLINE mode while connected!", this.Fade);
			this.EFMCNLELMDO().SetFloat("_Value5", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("_VignettingDirt", this.Speed);
			this.PHGCJOPFDOG().SetVector("SubBass", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005654 RID: 22100 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x001AEE5C File Offset: 0x001AD05C
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x001AEE80 File Offset: 0x001AD080
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("colorB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005657 RID: 22103 RVA: 0x001AEEA4 File Offset: 0x001AD0A4
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("Loss ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x001AE504 File Offset: 0x001AC704
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x001AEEC8 File Offset: 0x001AD0C8
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1115f;
			if (this.HBJJOCHGOPH > 581f)
			{
				this.HBJJOCHGOPH = 1806f;
			}
			this.HHLFDHNEIAH().SetFloat("Warning: Unhandled event ", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Mouse Y", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("player.arrow", this.Intensity);
			this.GJHLADDCMFF().SetFloat("_AOTex", this.Speed);
			this.HEHKGPKLAKK().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600565A RID: 22106 RVA: 0x001AEFB0 File Offset: 0x001AD1B0
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x001AE504 File Offset: 0x001AC704
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x001AEFE7 File Offset: 0x001AD1E7
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x001AF00B File Offset: 0x001AD20B
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600565E RID: 22110 RVA: 0x001AF042 File Offset: 0x001AD242
	private void GNJDKAECPKA()
	{
		this.SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x001AF068 File Offset: 0x001AD268
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 67f;
			if (this.HBJJOCHGOPH > 1894f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.OLHDPICFBOF().SetFloat("HightScoreMaxPointsText", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("Tab1Content", this.Fade);
			this.ELBMIEOIABA().SetFloat("blue", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("Fill", this.Speed);
			this.LONNIJMNKFB().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005660 RID: 22112 RVA: 0x001AF150 File Offset: 0x001AD350
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005661 RID: 22113 RVA: 0x001AF187 File Offset: 0x001AD387
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06005663 RID: 22115 RVA: 0x001AE504 File Offset: 0x001AC704
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005664 RID: 22116 RVA: 0x001AF1AC File Offset: 0x001AD3AC
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 941f;
			if (this.HBJJOCHGOPH > 885f)
			{
				this.HBJJOCHGOPH = 1753f;
			}
			this.KHCLIAMBBNC().SetFloat("/icon", this.HBJJOCHGOPH);
			this.IKAIDLJKLFC().SetFloat("_Value2", this.Fade);
			this.KHCLIAMBBNC().SetFloat("_EdgeSize", this.Intensity);
			this.OLHDPICFBOF().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.Speed);
			this.LPPEPKGFOEM().SetVector("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005665 RID: 22117 RVA: 0x001AE504 File Offset: 0x001AC704
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005666 RID: 22118 RVA: 0x001AF294 File Offset: 0x001AD494
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005667 RID: 22119 RVA: 0x001AF2B8 File Offset: 0x001AD4B8
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06005668 RID: 22120 RVA: 0x001AF2EF File Offset: 0x001AD4EF
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

	// Token: 0x06005669 RID: 22121 RVA: 0x001AE504 File Offset: 0x001AC704
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600566A RID: 22122 RVA: 0x001AF326 File Offset: 0x001AD526
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600566B RID: 22123 RVA: 0x001AE504 File Offset: 0x001AC704
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600566C RID: 22124 RVA: 0x001AE504 File Offset: 0x001AC704
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600566D RID: 22125 RVA: 0x001AF34C File Offset: 0x001AD54C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 666f;
			if (this.HBJJOCHGOPH > 1358f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.IKAIDLJKLFC().SetFloat("steamid", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("?", this.Fade);
			this.LONNIJMNKFB().SetFloat(" not exist", this.Intensity);
			this.IKAIDLJKLFC().SetFloat("[PlayerController] ", this.Speed);
			this.DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600566E RID: 22126 RVA: 0x001AF434 File Offset: 0x001AD634
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600566F RID: 22127 RVA: 0x001AF46B File Offset: 0x001AD66B
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_ProjectionInv");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005670 RID: 22128 RVA: 0x001AF48F File Offset: 0x001AD68F
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005671 RID: 22129 RVA: 0x001AF4C6 File Offset: 0x001AD6C6
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005672 RID: 22130 RVA: 0x001AF4EA File Offset: 0x001AD6EA
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005673 RID: 22131 RVA: 0x001AF521 File Offset: 0x001AD721
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005674 RID: 22132 RVA: 0x001AF558 File Offset: 0x001AD758
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005675 RID: 22133 RVA: 0x001AE504 File Offset: 0x001AC704
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005676 RID: 22134 RVA: 0x001AF57C File Offset: 0x001AD77C
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005677 RID: 22135 RVA: 0x001AF5A0 File Offset: 0x001AD7A0
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005678 RID: 22136 RVA: 0x001AE504 File Offset: 0x001AC704
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005679 RID: 22137 RVA: 0x001AF5D7 File Offset: 0x001AD7D7
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600567A RID: 22138 RVA: 0x001AF60E File Offset: 0x001AD80E
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600567B RID: 22139 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x0600567C RID: 22140 RVA: 0x001AEE5C File Offset: 0x001AD05C
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600567D RID: 22141 RVA: 0x001AF2EF File Offset: 0x001AD4EF
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600567E RID: 22142 RVA: 0x001AE504 File Offset: 0x001AC704
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600567F RID: 22143 RVA: 0x001AF645 File Offset: 0x001AD845
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005680 RID: 22144 RVA: 0x001AE504 File Offset: 0x001AC704
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005681 RID: 22145 RVA: 0x001AF67C File Offset: 0x001AD87C
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005682 RID: 22146 RVA: 0x001AE504 File Offset: 0x001AC704
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005683 RID: 22147 RVA: 0x001AE504 File Offset: 0x001AC704
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005684 RID: 22148 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06005685 RID: 22149 RVA: 0x001AF6B3 File Offset: 0x001AD8B3
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005686 RID: 22150 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005687 RID: 22151 RVA: 0x001AF6EA File Offset: 0x001AD8EA
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005688 RID: 22152 RVA: 0x001AE504 File Offset: 0x001AC704
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005689 RID: 22153 RVA: 0x001AE504 File Offset: 0x001AC704
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600568A RID: 22154 RVA: 0x001AF721 File Offset: 0x001AD921
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600568B RID: 22155 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600568C RID: 22156 RVA: 0x001AF745 File Offset: 0x001AD945
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600568D RID: 22157 RVA: 0x001AF77C File Offset: 0x001AD97C
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("Exception caught! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600568E RID: 22158 RVA: 0x001AF7A0 File Offset: 0x001AD9A0
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600568F RID: 22159 RVA: 0x001AE504 File Offset: 0x001AC704
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005690 RID: 22160 RVA: 0x001AE504 File Offset: 0x001AC704
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005691 RID: 22161 RVA: 0x001AE504 File Offset: 0x001AC704
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005692 RID: 22162 RVA: 0x001AF7C4 File Offset: 0x001AD9C4
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005693 RID: 22163 RVA: 0x001AF7FC File Offset: 0x001AD9FC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1625f;
			if (this.HBJJOCHGOPH > 1216f)
			{
				this.HBJJOCHGOPH = 916f;
			}
			this.MJJIEHANFJA().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Please specify a map name or buildID", this.Fade);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Intensity);
			this.LONNIJMNKFB().SetFloat("_AreaTex", this.Speed);
			this.FOOCJIDNGBB().SetVector("Preparing content", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005694 RID: 22164 RVA: 0x001AF8E4 File Offset: 0x001ADAE4
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005695 RID: 22165 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06005696 RID: 22166 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005697 RID: 22167 RVA: 0x001AF91C File Offset: 0x001ADB1C
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 552f;
			if (this.HBJJOCHGOPH > 1212f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.IKAIDLJKLFC().SetFloat("stats on", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("SetSunMinSize", this.Fade);
			this.KBOPGONOCNP().SetFloat("_Value", this.Intensity);
			this.INOBFNCKFGK().SetFloat("CameraFilterPack/Blur_Focus", this.Speed);
			this.DBOLLHHMKKN().SetVector("menutheme.hunter", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005698 RID: 22168 RVA: 0x001AFA04 File Offset: 0x001ADC04
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("PunRespawn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005699 RID: 22169 RVA: 0x001AE504 File Offset: 0x001AC704
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600569A RID: 22170 RVA: 0x001AFA28 File Offset: 0x001ADC28
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("PlayButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600569B RID: 22171 RVA: 0x001AFA4C File Offset: 0x001ADC4C
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("[NetworkManager] Updating current room...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600569C RID: 22172 RVA: 0x001AFA70 File Offset: 0x001ADC70
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 2f;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Intensity", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Speed", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600569D RID: 22173 RVA: 0x001AFB58 File Offset: 0x001ADD58
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_BlurPass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600569E RID: 22174 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x0600569F RID: 22175 RVA: 0x001AFB7C File Offset: 0x001ADD7C
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("DifficultyBG");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056A0 RID: 22176 RVA: 0x001AFBA0 File Offset: 0x001ADDA0
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("Joystick1Button2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056A1 RID: 22177 RVA: 0x001AFBC4 File Offset: 0x001ADDC4
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056A2 RID: 22178 RVA: 0x001AE504 File Offset: 0x001AC704
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056A3 RID: 22179 RVA: 0x001AFBFC File Offset: 0x001ADDFC
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * 1765f;
			if (this.HBJJOCHGOPH > 84f)
			{
				this.HBJJOCHGOPH = 1551f;
			}
			this.EFDEIFCDAFG().SetFloat(". This client's player: ", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("_Value4", this.Fade);
			this.EFMCNLELMDO().SetFloat("[MapEditor] Updating map assets", this.Intensity);
			this.EOCCJGIGEGJ().SetFloat("_Red_B", this.Speed);
			this.FOOCJIDNGBB().SetVector("PunRespawn", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040008FC RID: 2300
	public Shader SCShader;

	// Token: 0x040008FD RID: 2301
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008FE RID: 2302
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040008FF RID: 2303
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x04000900 RID: 2304
	[Range(0f, 3f)]
	public float Speed = 1f;

	// Token: 0x04000901 RID: 2305
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000902 RID: 2306
	private Material BJFKDHHMLJH;
}
