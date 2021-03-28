using System;
using UnityEngine;

// Token: 0x020000B0 RID: 176
[AddComponentMenu("Camera Filter Pack/Edge/Edge_filter")]
[ExecuteInEditMode]
public class CameraFilterPack_Edge_Edge_filter : MonoBehaviour
{
	// Token: 0x06003572 RID: 13682 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003573 RID: 13683 RVA: 0x0011547C File Offset: 0x0011367C
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003574 RID: 13684 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003575 RID: 13685 RVA: 0x0011547C File Offset: 0x0011367C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003576 RID: 13686 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003577 RID: 13687 RVA: 0x00115499 File Offset: 0x00113699
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003578 RID: 13688 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x0011547C File Offset: 0x0011367C
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600357A RID: 13690 RVA: 0x001154D0 File Offset: 0x001136D0
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("player.fire");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600357B RID: 13691 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x0600357C RID: 13692 RVA: 0x0011547C File Offset: 0x0011367C
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600357D RID: 13693 RVA: 0x0011547C File Offset: 0x0011367C
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600357E RID: 13694 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600357F RID: 13695 RVA: 0x001154F4 File Offset: 0x001136F4
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1629f)
			{
				this.HBJJOCHGOPH = 61f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Speed", this.RedAmplifier);
			this.IIJMIPBMMBF().SetFloat("MenuScene", this.GreenAmplifier);
			this.IIJMIPBMMBF().SetFloat("_Linecount", this.BlueAmplifier);
			this.NBMPPNFKFLB().SetVector("ConfigVersionSlider", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003580 RID: 13696 RVA: 0x0011547C File Offset: 0x0011367C
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003581 RID: 13697 RVA: 0x001155D6 File Offset: 0x001137D6
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003582 RID: 13698 RVA: 0x00115610 File Offset: 0x00113810
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1470f)
			{
				this.HBJJOCHGOPH = 1088f;
			}
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_FixDistance", this.RedAmplifier);
			this.LDNADDJMIPK().SetFloat("Mid", this.GreenAmplifier);
			this.KBOPGONOCNP().SetFloat("_Value3", this.BlueAmplifier);
			this.NBMPPNFKFLB().SetVector("MapEnd", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003583 RID: 13699 RVA: 0x001156F2 File Offset: 0x001138F2
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003584 RID: 13700 RVA: 0x0011547C File Offset: 0x0011367C
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003585 RID: 13701 RVA: 0x0011572C File Offset: 0x0011392C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 993f)
			{
				this.HBJJOCHGOPH = 737f;
			}
			this.GKILCDHJFEG().SetFloat(",", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", this.RedAmplifier);
			this.KEMAALEODNH().SetFloat("_TimeX", this.GreenAmplifier);
			this.GKILCDHJFEG().SetFloat("musicVolume", this.BlueAmplifier);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/BlurTiltShift", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003586 RID: 13702 RVA: 0x0011580E File Offset: 0x00113A0E
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003587 RID: 13703 RVA: 0x0011547C File Offset: 0x0011367C
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003588 RID: 13704 RVA: 0x0011547C File Offset: 0x0011367C
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003589 RID: 13705 RVA: 0x00115845 File Offset: 0x00113A45
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600358A RID: 13706 RVA: 0x0011587C File Offset: 0x00113A7C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 22f)
			{
				this.HBJJOCHGOPH = 1137f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Value3", this.RedAmplifier);
			this.EMDFHOKEGNG().SetFloat("/icon", this.GreenAmplifier);
			this.LONNIJMNKFB().SetFloat("[EditorEvent] Exception: ", this.BlueAmplifier);
			this.LDNADDJMIPK().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600358B RID: 13707 RVA: 0x00115960 File Offset: 0x00113B60
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 961f)
			{
				this.HBJJOCHGOPH = 1107f;
			}
			this.NBMPPNFKFLB().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("/theme", this.RedAmplifier);
			this.IIJMIPBMMBF().SetFloat("_SunPosition", this.GreenAmplifier);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", this.BlueAmplifier);
			this.KEMAALEODNH().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600358C RID: 13708 RVA: 0x00115A42 File Offset: 0x00113C42
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x00115A66 File Offset: 0x00113C66
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_FadeDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x00115A8A File Offset: 0x00113C8A
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("-1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600358F RID: 13711 RVA: 0x0011547C File Offset: 0x0011367C
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x00115AAE File Offset: 0x00113CAE
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x00115AE5 File Offset: 0x00113CE5
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x00115B1C File Offset: 0x00113D1C
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x00115B40 File Offset: 0x00113D40
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 123f)
			{
				this.HBJJOCHGOPH = 1565f;
			}
			this.LDNADDJMIPK().SetFloat("points:", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Blend", this.RedAmplifier);
			this.HEHKGPKLAKK().SetFloat(" not exist", this.GreenAmplifier);
			this.NBPKMLMCHFN.SetFloat("speed", this.BlueAmplifier);
			this.KEMAALEODNH().SetVector("BitsData", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06003594 RID: 13716 RVA: 0x00115C22 File Offset: 0x00113E22
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

	// Token: 0x06003595 RID: 13717 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x0011547C File Offset: 0x0011367C
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003598 RID: 13720 RVA: 0x00115C59 File Offset: 0x00113E59
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Edge_filter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003599 RID: 13721 RVA: 0x00115C7D File Offset: 0x00113E7D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600359A RID: 13722 RVA: 0x0011547C File Offset: 0x0011367C
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600359B RID: 13723 RVA: 0x00115CB4 File Offset: 0x00113EB4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1947f)
			{
				this.HBJJOCHGOPH = 1404f;
			}
			this.KEMAALEODNH().SetFloat("PLAY [SPACE]", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_Red_G", this.RedAmplifier);
			this.KEMAALEODNH().SetFloat(": ", this.GreenAmplifier);
			this.NBPKMLMCHFN.SetFloat(".completed", this.BlueAmplifier);
			this.GKILCDHJFEG().SetVector("Sets the boolean value of the Auto Focus Input Field property.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600359C RID: 13724 RVA: 0x00115D98 File Offset: 0x00113F98
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
			this.NBPKMLMCHFN.SetFloat("_RedAmplifier", this.RedAmplifier);
			this.NBPKMLMCHFN.SetFloat("_GreenAmplifier", this.GreenAmplifier);
			this.NBPKMLMCHFN.SetFloat("_BlueAmplifier", this.BlueAmplifier);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x00115E7A File Offset: 0x0011407A
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600359E RID: 13726 RVA: 0x00115E9E File Offset: 0x0011409E
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Changed config");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x0011547C File Offset: 0x0011367C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x00115EC2 File Offset: 0x001140C2
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x00115EE8 File Offset: 0x001140E8
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 1091f;
			}
			this.KBOPGONOCNP().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Object ID. Case-Sensitive", this.RedAmplifier);
			this.KEMAALEODNH().SetFloat("_MatrixSpeed", this.GreenAmplifier);
			this.IIJMIPBMMBF().SetFloat("YES", this.BlueAmplifier);
			this.NBPKMLMCHFN.SetVector("_Intervale", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x00115FCA File Offset: 0x001141CA
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x00116004 File Offset: 0x00114204
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1628f)
			{
				this.HBJJOCHGOPH = 1620f;
			}
			this.HEHKGPKLAKK().SetFloat("player.gamecompleted", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("offline room", this.RedAmplifier);
			this.NBPKMLMCHFN.SetFloat("Mouse Wheel Down", this.GreenAmplifier);
			this.KEMAALEODNH().SetFloat("2hands", this.BlueAmplifier);
			this.HEHKGPKLAKK().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x00116104 File Offset: 0x00114304
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1054f)
			{
				this.HBJJOCHGOPH = 353f;
			}
			this.LDNADDJMIPK().SetFloat("Item invalid. No idea why.", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Unsupported target enum: ", this.RedAmplifier);
			this.EMDFHOKEGNG().SetFloat("checkpoint", this.GreenAmplifier);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.BlueAmplifier);
			this.EMDFHOKEGNG().SetVector("Error: I/O Failure! :(", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x001161E8 File Offset: 0x001143E8
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1009f)
			{
				this.HBJJOCHGOPH = 1427f;
			}
			this.KBOPGONOCNP().SetFloat(". Calling ConnectToRegionMaster() is: ", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("DPADHOR", this.RedAmplifier);
			this.NBMPPNFKFLB().SetFloat("ticket", this.GreenAmplifier);
			this.LDNADDJMIPK().SetFloat("settings.arcshitsoundtimedelay", this.BlueAmplifier);
			this.NBMPPNFKFLB().SetVector("masterSteamID", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040005F2 RID: 1522
	public Shader SCShader;

	// Token: 0x040005F3 RID: 1523
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005F4 RID: 1524
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040005F5 RID: 1525
	private Material BJFKDHHMLJH;

	// Token: 0x040005F6 RID: 1526
	[Range(0f, 10f)]
	public float RedAmplifier;

	// Token: 0x040005F7 RID: 1527
	[Range(0f, 10f)]
	public float GreenAmplifier = 2f;

	// Token: 0x040005F8 RID: 1528
	[Range(0f, 10f)]
	public float BlueAmplifier;
}
