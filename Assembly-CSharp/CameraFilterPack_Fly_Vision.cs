using System;
using UnityEngine;

// Token: 0x020000BC RID: 188
[AddComponentMenu("Camera Filter Pack/Vision/Fly_Vision")]
[ExecuteInEditMode]
public class CameraFilterPack_Fly_Vision : MonoBehaviour
{
	// Token: 0x0600395F RID: 14687 RVA: 0x00122D68 File Offset: 0x00120F68
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("Item ") as Texture2D);
		this.SCShader = Shader.Find("Skipping packet for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003961 RID: 14689 RVA: 0x00122DA4 File Offset: 0x00120FA4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1848f)
			{
				this.HBJJOCHGOPH = 745f;
			}
			this.LONNIJMNKFB().SetFloat("TRACKING", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("0,2,true,0", this.Zoom);
			this.LONNIJMNKFB().SetFloat(".lastCheckpoint.powerupsScore", this.Distortion);
			this.LONNIJMNKFB().SetFloat("SaveButton", this.Fade);
			this.LONNIJMNKFB().SetFloat("SetSatelliteSensitivity", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Testing, the group has toggled [", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1870f, 1994f));
			this.JIBOKBCPDLC().SetTexture("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003962 RID: 14690 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003963 RID: 14691 RVA: 0x00122EBC File Offset: 0x001210BC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Zoom);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003964 RID: 14692 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003965 RID: 14693 RVA: 0x00122FEE File Offset: 0x001211EE
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("_ChangeGreen") as Texture2D);
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003966 RID: 14694 RVA: 0x00123027 File Offset: 0x00121227
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("EventMenu") as Texture2D);
		this.SCShader = Shader.Find("https://vk.com/khb.soft");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003967 RID: 14695 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003968 RID: 14696 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003969 RID: 14697 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600396A RID: 14698 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600396B RID: 14699 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600396D RID: 14701 RVA: 0x00123060 File Offset: 0x00121260
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600396E RID: 14702 RVA: 0x00123097 File Offset: 0x00121297
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find(".GoalProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600396F RID: 14703 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06003970 RID: 14704 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003971 RID: 14705 RVA: 0x001230D0 File Offset: 0x001212D0
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003972 RID: 14706 RVA: 0x00123107 File Offset: 0x00121307
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("_FixDistance") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06003973 RID: 14707 RVA: 0x00123140 File Offset: 0x00121340
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

	// Token: 0x06003974 RID: 14708 RVA: 0x00123177 File Offset: 0x00121377
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Fly_VisionFX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Fly_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003975 RID: 14709 RVA: 0x001231B0 File Offset: 0x001213B0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 1160f;
			}
			this.JIBOKBCPDLC().SetFloat("FPSToggle", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Copy from ", this.Zoom);
			this.NBPKMLMCHFN.SetFloat("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", this.Distortion);
			this.JIBOKBCPDLC().SetFloat("ERROR You should never change PhotonPlayer IDs!", this.Fade);
			this.NBPKMLMCHFN.SetFloat(",", this.CCIENBFIKKH);
			this.LONNIJMNKFB().SetVector("CameraFilterPack/Real_VHS", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 828f));
			this.JIBOKBCPDLC().SetTexture("Joystick1Button9", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003977 RID: 14711 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003978 RID: 14712 RVA: 0x00123304 File Offset: 0x00121504
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 800f)
			{
				this.HBJJOCHGOPH = 1739f;
			}
			this.JIBOKBCPDLC().SetFloat(": ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Zoom);
			this.LONNIJMNKFB().SetFloat("VisionBlur", this.Distortion);
			this.JIBOKBCPDLC().SetFloat("_Value", this.Fade);
			this.LONNIJMNKFB().SetFloat("_Value6", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Greenness", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1361f, 794f));
			this.NBPKMLMCHFN.SetTexture("menu.enableselectormusic", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003979 RID: 14713 RVA: 0x00122FD1 File Offset: 0x001211D1
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600397A RID: 14714 RVA: 0x0012341C File Offset: 0x0012161C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 43f)
			{
				this.HBJJOCHGOPH = 639f;
			}
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Hidden/Fast Approximate Anti-aliasing", this.Zoom);
			this.LONNIJMNKFB().SetFloat("_Value", this.Distortion);
			this.JIBOKBCPDLC().SetFloat("_ScreenResolution", this.Fade);
			this.JIBOKBCPDLC().SetFloat(".lastCheckpoint.checkpointsUsed", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1837f, 372f));
			this.JIBOKBCPDLC().SetTexture("LevelURLInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600397B RID: 14715 RVA: 0x00123531 File Offset: 0x00121731
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("MainCamera") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000640 RID: 1600
	public Shader SCShader;

	// Token: 0x04000641 RID: 1601
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000642 RID: 1602
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000643 RID: 1603
	private Material BJFKDHHMLJH;

	// Token: 0x04000644 RID: 1604
	[Range(0.04f, 1.5f)]
	public float Zoom = 0.25f;

	// Token: 0x04000645 RID: 1605
	[Range(0f, 1f)]
	public float Distortion = 0.4f;

	// Token: 0x04000646 RID: 1606
	[Range(0f, 1f)]
	public float Fade = 0.4f;

	// Token: 0x04000647 RID: 1607
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	// Token: 0x04000648 RID: 1608
	private Texture2D FPHEBLMINDA;
}
