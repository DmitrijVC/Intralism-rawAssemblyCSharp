using System;
using UnityEngine;

// Token: 0x0200006B RID: 107
[AddComponentMenu("Camera Filter Pack/Broken/Broken_Screen")]
[ExecuteInEditMode]
public class CameraFilterPack_Broken_Screen : MonoBehaviour
{
	// Token: 0x06001DE0 RID: 7648 RVA: 0x000B4F48 File Offset: 0x000B3148
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Shadow", this.Shadow);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DE1 RID: 7649 RVA: 0x000B5004 File Offset: 0x000B3204
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DE2 RID: 7650 RVA: 0x000B5004 File Offset: 0x000B3204
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DE3 RID: 7651 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06001DE4 RID: 7652 RVA: 0x000B5021 File Offset: 0x000B3221
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("ResetButton") as Texture2D);
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DE5 RID: 7653 RVA: 0x000B5004 File Offset: 0x000B3204
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x000B505A File Offset: 0x000B325A
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x000B5094 File Offset: 0x000B3294
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 907f)
			{
				this.HBJJOCHGOPH = 641f;
			}
			this.ACHNOHCLGOO().SetFloat("z", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.Fade);
			this.ACHNOHCLGOO().SetFloat("EnableRankedNotificationsToggle", this.Shadow);
			this.ACHNOHCLGOO().SetTexture("_Red_C", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x000B5150 File Offset: 0x000B3350
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x000B51B0 File Offset: 0x000B33B0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 672f;
			}
			this.LONNIJMNKFB().SetFloat("PunPickup", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Near", this.Fade);
			this.IONHGBPGCHK().SetFloat("Load Game", this.Shadow);
			this.NBPKMLMCHFN.SetTexture("ready", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x000B526C File Offset: 0x000B346C
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("#forever") as Texture2D);
		this.SCShader = Shader.Find("_History3ChromaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000B52A5 File Offset: 0x000B34A5
	private void KDMANOEMOCA()
	{
		this.FPHEBLMINDA = (Resources.Load("The other scroll rect doesnt support scrolling horizontally") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06001DEF RID: 7663 RVA: 0x000B52DE File Offset: 0x000B34DE
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

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000B5004 File Offset: 0x000B3204
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x000B5315 File Offset: 0x000B3515
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Broken_Screen1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Broken_Screen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000B5004 File Offset: 0x000B3204
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x000B5004 File Offset: 0x000B3204
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x000B5004 File Offset: 0x000B3204
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000B5004 File Offset: 0x000B3204
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000B5004 File Offset: 0x000B3204
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x000B5350 File Offset: 0x000B3550
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 514f)
			{
				this.HBJJOCHGOPH = 1745f;
			}
			this.LONNIJMNKFB().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("[MapData] Map timing update from: ", this.Fade);
			this.ACHNOHCLGOO().SetFloat("_FarCamera", this.Shadow);
			this.ACHNOHCLGOO().SetTexture("Stream did not contain properly formatted byte array", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000B540C File Offset: 0x000B360C
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("float,1.5") as Texture2D);
		this.SCShader = Shader.Find("] to be droppable");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x000B5445 File Offset: 0x000B3645
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("Change Note:") as Texture2D);
		this.SCShader = Shader.Find("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x000B547E File Offset: 0x000B367E
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_Lighten") as Texture2D);
		this.SCShader = Shader.Find("Skipping EstablishEncryption. Protocol is secure.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x000B5004 File Offset: 0x000B3204
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x000B54B7 File Offset: 0x000B36B7
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x000B54EE File Offset: 0x000B36EE
	private void EPEGAEGDJAM()
	{
		this.FPHEBLMINDA = (Resources.Load("_FgOverlap") as Texture2D);
		this.SCShader = Shader.Find("_Parasite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000B5528 File Offset: 0x000B3728
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1986f)
			{
				this.HBJJOCHGOPH = 1537f;
			}
			this.NBPKMLMCHFN.SetFloat("ItemNameBGImage", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("Case-Sensitive", this.Fade);
			this.ACHNOHCLGOO().SetFloat("_HrDepthTex", this.Shadow);
			this.LONNIJMNKFB().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001E02 RID: 7682 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001E03 RID: 7683 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0400040B RID: 1035
	public Shader SCShader;

	// Token: 0x0400040C RID: 1036
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400040D RID: 1037
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400040E RID: 1038
	[Range(-1f, 1f)]
	public float Shadow = 1f;

	// Token: 0x0400040F RID: 1039
	private Material BJFKDHHMLJH;

	// Token: 0x04000410 RID: 1040
	private Texture2D FPHEBLMINDA;
}
