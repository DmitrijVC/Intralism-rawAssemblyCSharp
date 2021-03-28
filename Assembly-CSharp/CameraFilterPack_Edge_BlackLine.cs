using System;
using UnityEngine;

// Token: 0x020000AF RID: 175
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Edge/BlackLine")]
public class CameraFilterPack_Edge_BlackLine : MonoBehaviour
{
	// Token: 0x0600353C RID: 13628 RVA: 0x0011470D File Offset: 0x0011290D
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600353D RID: 13629 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x0600353E RID: 13630 RVA: 0x0011472C File Offset: 0x0011292C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 682f)
			{
				this.HBJJOCHGOPH = 1250f;
			}
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/Gradients_Hue", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetVector("ready", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600353F RID: 13631 RVA: 0x0011470D File Offset: 0x0011290D
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003540 RID: 13632 RVA: 0x001147CC File Offset: 0x001129CC
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003541 RID: 13633 RVA: 0x0011470D File Offset: 0x0011290D
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003542 RID: 13634 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x00114803 File Offset: 0x00112A03
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Forward");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003545 RID: 13637 RVA: 0x00114827 File Offset: 0x00112A27
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003546 RID: 13638 RVA: 0x0011484B File Offset: 0x00112A4B
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003547 RID: 13639 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003548 RID: 13640 RVA: 0x00114882 File Offset: 0x00112A82
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003549 RID: 13641 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600354A RID: 13642 RVA: 0x001148B9 File Offset: 0x00112AB9
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600354B RID: 13643 RVA: 0x001148F0 File Offset: 0x00112AF0
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

	// Token: 0x0600354C RID: 13644 RVA: 0x00114927 File Offset: 0x00112B27
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x0011495E File Offset: 0x00112B5E
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600354F RID: 13647 RVA: 0x00114982 File Offset: 0x00112B82
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003550 RID: 13648 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003551 RID: 13649 RVA: 0x001149BC File Offset: 0x00112BBC
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1531f)
			{
				this.HBJJOCHGOPH = 356f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetVector("[Down]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003552 RID: 13650 RVA: 0x00114A5C File Offset: 0x00112C5C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1410f)
			{
				this.HBJJOCHGOPH = 1085f;
			}
			this.ACHNOHCLGOO().SetFloat("tintColor", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("_GlowColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003553 RID: 13651 RVA: 0x00114AFC File Offset: 0x00112CFC
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003554 RID: 13652 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003555 RID: 13653 RVA: 0x00114B20 File Offset: 0x00112D20
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 347f)
			{
				this.HBJJOCHGOPH = 1845f;
			}
			this.NFMGLIKNOOC().SetFloat("#exit", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("MascotChallenge2019", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003556 RID: 13654 RVA: 0x0011470D File Offset: 0x0011290D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003557 RID: 13655 RVA: 0x00114BC0 File Offset: 0x00112DC0
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003558 RID: 13656 RVA: 0x00114C60 File Offset: 0x00112E60
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003559 RID: 13657 RVA: 0x00114C84 File Offset: 0x00112E84
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600355A RID: 13658 RVA: 0x00114CBB File Offset: 0x00112EBB
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600355B RID: 13659 RVA: 0x00114CF4 File Offset: 0x00112EF4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1948f)
			{
				this.HBJJOCHGOPH = 1813f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Saturation", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Contrast", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600355C RID: 13660 RVA: 0x00114D94 File Offset: 0x00112F94
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("GlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600355D RID: 13661 RVA: 0x00114DB8 File Offset: 0x00112FB8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1832f)
			{
				this.HBJJOCHGOPH = 165f;
			}
			this.NFMGLIKNOOC().SetFloat(" / ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("colorB", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600355E RID: 13662 RVA: 0x00114E58 File Offset: 0x00113058
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1165f)
			{
				this.HBJJOCHGOPH = 1937f;
			}
			this.JIBOKBCPDLC().SetFloat("_Near", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("_Amount", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600355F RID: 13663 RVA: 0x00114EF8 File Offset: 0x001130F8
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 940f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.LNLKMDPHDCC().SetFloat("file://", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector(" GO:", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003560 RID: 13664 RVA: 0x00114F98 File Offset: 0x00113198
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003561 RID: 13665 RVA: 0x00114FD0 File Offset: 0x001131D0
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 539f)
			{
				this.HBJJOCHGOPH = 565f;
			}
			this.KAFBNOBOIAJ().SetFloat("Folk", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetVector("speed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003562 RID: 13666 RVA: 0x0011470D File Offset: 0x0011290D
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003563 RID: 13667 RVA: 0x00115070 File Offset: 0x00113270
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003564 RID: 13668 RVA: 0x00115094 File Offset: 0x00113294
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1958f)
			{
				this.HBJJOCHGOPH = 1425f;
			}
			this.HHIFMIPPMPF().SetFloat("_LowRez", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("_MainTex2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003566 RID: 13670 RVA: 0x00115148 File Offset: 0x00113348
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1345f)
			{
				this.HBJJOCHGOPH = 560f;
			}
			this.JIBOKBCPDLC().SetFloat(" cannot be used as a 3D LUT.", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetVector("SpawnObj", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003567 RID: 13671 RVA: 0x001151E8 File Offset: 0x001133E8
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003568 RID: 13672 RVA: 0x0011520C File Offset: 0x0011340C
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003569 RID: 13673 RVA: 0x00115230 File Offset: 0x00113430
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 359f)
			{
				this.HBJJOCHGOPH = 104f;
			}
			this.EOCCJGIGEGJ().SetFloat("EventTimeInputField", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600356A RID: 13674 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600356B RID: 13675 RVA: 0x001152D0 File Offset: 0x001134D0
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_BlackLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600356C RID: 13676 RVA: 0x001152F4 File Offset: 0x001134F4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 88f;
			}
			this.NBPKMLMCHFN.SetFloat("Scrollbar", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetVector(".icon", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600356D RID: 13677 RVA: 0x00115394 File Offset: 0x00113594
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("element");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600356E RID: 13678 RVA: 0x001153B8 File Offset: 0x001135B8
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600356F RID: 13679 RVA: 0x001153DC File Offset: 0x001135DC
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1338f)
			{
				this.HBJJOCHGOPH = 1885f;
			}
			this.EOCCJGIGEGJ().SetFloat("PLAY [SPACE]", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetVector(".lastCheckpoint.powerupsScore", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003570 RID: 13680 RVA: 0x0011470D File Offset: 0x0011290D
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003571 RID: 13681 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x040005EE RID: 1518
	public Shader SCShader;

	// Token: 0x040005EF RID: 1519
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005F0 RID: 1520
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040005F1 RID: 1521
	private Material BJFKDHHMLJH;
}
