using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
[AddComponentMenu("Camera Filter Pack/AAA/Blood On Screen")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_BloodOnScreen : MonoBehaviour
{
	// Token: 0x06000B8B RID: 2955 RVA: 0x000567C1 File Offset: 0x000549C1
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor") as Texture2D);
		this.SCShader = Shader.Find("_BlurParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x000567FA File Offset: 0x000549FA
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x00056817 File Offset: 0x00054A17
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x0005684E File Offset: 0x00054A4E
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x00056887 File Offset: 0x00054A87
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x000568BE File Offset: 0x00054ABE
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("0,7,true,0") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x000567FA File Offset: 0x000549FA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x000568F8 File Offset: 0x00054AF8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1792f)
			{
				this.HBJJOCHGOPH = 474f;
			}
			this.ADBKPGFMNKO().SetFloat("TwoHands", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("May", Mathf.Clamp(this.Blood_On_Screen, 1000f, 1844f));
			this.LONNIJMNKFB().SetFloat("#tryagain", Mathf.Clamp(this.Blood_Intensify, 1796f, 201f));
			this.LONNIJMNKFB().SetFloat("_EdgeThresholdMin", Mathf.Clamp(this.Blood_Darkness, 4f, 1773f));
			this.LONNIJMNKFB().SetFloat("note.6", Mathf.Clamp(this.Blood_Fade, 114f, 1077f));
			this.PLBEJJIHFPB().SetFloat("SetSunColors", Mathf.Clamp(this.Blood_Distortion_Speed, 1580f, 1245f));
			this.LONNIJMNKFB().SetColor("EventTimeInputField", this.Blood_Color);
			this.ADBKPGFMNKO().SetTexture("CameraFilterPack/Edge_BlackLine", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00056A57 File Offset: 0x00054C57
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_AAA_BloodOnScreen1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/AAA_BloodOnScreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x00056A90 File Offset: 0x00054C90
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00056AC7 File Offset: 0x00054CC7
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

	// Token: 0x06000B98 RID: 2968 RVA: 0x000567FA File Offset: 0x000549FA
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00056B60 File Offset: 0x00054D60
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("player.licenceaccepted") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00056B99 File Offset: 0x00054D99
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x000567FA File Offset: 0x000549FA
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00056BD0 File Offset: 0x00054DD0
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load(" Maybe GO was destroyed but RPC not cleaned up.") as Texture2D);
		this.SCShader = Shader.Find("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x000567FA File Offset: 0x000549FA
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00056C09 File Offset: 0x00054E09
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00056C40 File Offset: 0x00054E40
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
			this.NBPKMLMCHFN.SetFloat("_Value", Mathf.Clamp(this.Blood_On_Screen, 0.02f, 1.6f));
			this.NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(this.Blood_Intensify, 0f, 2f));
			this.NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(this.Blood_Darkness, 0f, 2f));
			this.NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(this.Blood_Fade, 0f, 1f));
			this.NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(this.Blood_Distortion_Speed, 0f, 2f));
			this.NBPKMLMCHFN.SetColor("_Color2", this.Blood_Color);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x000567FA File Offset: 0x000549FA
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001B8 RID: 440
	public Shader SCShader;

	// Token: 0x040001B9 RID: 441
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001BA RID: 442
	[Range(0.02f, 1.6f)]
	public float Blood_On_Screen = 1f;

	// Token: 0x040001BB RID: 443
	public Color Blood_Color = Color.red;

	// Token: 0x040001BC RID: 444
	[Range(0f, 2f)]
	public float Blood_Intensify = 0.7f;

	// Token: 0x040001BD RID: 445
	[Range(0f, 2f)]
	public float Blood_Darkness = 0.5f;

	// Token: 0x040001BE RID: 446
	[Range(0f, 1f)]
	public float Blood_Distortion_Speed = 0.25f;

	// Token: 0x040001BF RID: 447
	[Range(0f, 1f)]
	public float Blood_Fade = 1f;

	// Token: 0x040001C0 RID: 448
	private Material BJFKDHHMLJH;

	// Token: 0x040001C1 RID: 449
	private Texture2D FPHEBLMINDA;
}
