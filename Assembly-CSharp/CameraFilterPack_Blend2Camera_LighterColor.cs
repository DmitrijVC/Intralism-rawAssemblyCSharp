using System;
using UnityEngine;

// Token: 0x02000049 RID: 73
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LighterColor")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LighterColor : MonoBehaviour
{
	// Token: 0x0600143F RID: 5183 RVA: 0x00085709 File Offset: 0x00083909
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00085743 File Offset: 0x00083943
	private void IFBKMAEMKNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00085709 File Offset: 0x00083909
	private void NAOLAJPDGIC()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001442 RID: 5186 RVA: 0x0008577E File Offset: 0x0008397E
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001443 RID: 5187 RVA: 0x000857B8 File Offset: 0x000839B8
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00085821 File Offset: 0x00083A21
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00085709 File Offset: 0x00083909
	private void EDBEHEKMGFH()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x0008585C File Offset: 0x00083A5C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1226f)
			{
				this.HBJJOCHGOPH = 559f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("Connection failed: ", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("[GameScene] Submiting rank", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 227f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00085958 File Offset: 0x00083B58
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 51);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x000859C4 File Offset: 0x00083BC4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 169f)
			{
				this.HBJJOCHGOPH = 1296f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("0,1,false", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat(".a", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("speed", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("ls", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1665f, 1023f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x00085ABE File Offset: 0x00083CBE
	private void GBFPAEDPOPP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00085AFC File Offset: 0x00083CFC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 946f)
			{
				this.HBJJOCHGOPH = 581f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("menu.tabid", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("[BuildInfo] Error: ", this.SwitchCameraToCamera2);
			this.GCDFNHMJMIP().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1828f, 515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x00085709 File Offset: 0x00083909
	private void PHJLHCMCCKE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x00085BF6 File Offset: 0x00083DF6
	private void EJNKBOLGHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00085709 File Offset: 0x00083909
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00085C34 File Offset: 0x00083E34
	private void KMCPMOGKDEH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00085CA0 File Offset: 0x00083EA0
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x00085D0C File Offset: 0x00083F0C
	private void FIKFJDFELIP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 123);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00085D78 File Offset: 0x00083F78
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 364f)
			{
				this.HBJJOCHGOPH = 250f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("challenges.", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Color_Noise", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Identity LUT", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("EnvironmentSlider", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 685f, 1207f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00085821 File Offset: 0x00083A21
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00085709 File Offset: 0x00083909
	private void DOEPOGLEGLE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06001455 RID: 5205 RVA: 0x00085E72 File Offset: 0x00084072
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

	// Token: 0x06001456 RID: 5206 RVA: 0x00085EA9 File Offset: 0x000840A9
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x00085EE4 File Offset: 0x000840E4
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001458 RID: 5208 RVA: 0x00085FDE File Offset: 0x000841DE
	private void GLKJFIOCPLF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001459 RID: 5209 RVA: 0x00085709 File Offset: 0x00083909
	private void GPHPJIDGEPI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600145A RID: 5210 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600145B RID: 5211 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600145C RID: 5212 RVA: 0x00086019 File Offset: 0x00084219
	private void BMHFAMJELFH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600145D RID: 5213 RVA: 0x00086054 File Offset: 0x00084254
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600145E RID: 5214 RVA: 0x0008608C File Offset: 0x0008428C
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600145F RID: 5215 RVA: 0x000860F8 File Offset: 0x000842F8
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040002D6 RID: 726
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LighterColor";

	// Token: 0x040002D7 RID: 727
	public Shader SCShader;

	// Token: 0x040002D8 RID: 728
	public Camera Camera2;

	// Token: 0x040002D9 RID: 729
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002DA RID: 730
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002DB RID: 731
	private Material BJFKDHHMLJH;

	// Token: 0x040002DC RID: 732
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002DD RID: 733
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002DE RID: 734
	private RenderTexture JDMCFBKJHDD;
}
