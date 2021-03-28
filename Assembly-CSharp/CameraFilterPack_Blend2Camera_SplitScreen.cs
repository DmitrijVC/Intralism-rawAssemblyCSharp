using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
[AddComponentMenu("Camera Filter Pack/Split Screen/SideBySide")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_SplitScreen : MonoBehaviour
{
	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06001806 RID: 6150 RVA: 0x0009ABAA File Offset: 0x00098DAA
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

	// Token: 0x06001807 RID: 6151 RVA: 0x0009ABE4 File Offset: 0x00098DE4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 548f)
			{
				this.HBJJOCHGOPH = 589f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("_Value4", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_BlackHole", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat(" timeUntilRespawn: ", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("GlassAberration", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_Glitch3", this.SplitX);
			this.ACHNOHCLGOO().SetFloat("max. lives color", this.SplitY);
			this.ACHNOHCLGOO().SetFloat("_MainTex2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("0.00", this.Rotation);
			this.LDNADDJMIPK().SetInt("_TimeX", (!this.CONEELGCALI) ? 1 : 1);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x0009AD2B File Offset: 0x00098F2B
	private void EMAMCDFBGOA()
	{
		this.Start();
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void Update()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x0009AD57 File Offset: 0x00098F57
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x0009AD90 File Offset: 0x00098F90
	private void BGDPIHMAACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x0009AE07 File Offset: 0x00099007
	private void EJJEDJIOFAB()
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

	// Token: 0x0600180D RID: 6157 RVA: 0x0009AE07 File Offset: 0x00099007
	private void LADCJEIALMH()
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

	// Token: 0x0600180E RID: 6158 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void FABMDEHEDNO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x0009AE07 File Offset: 0x00099007
	private void JHJGJJKELJM()
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

	// Token: 0x06001810 RID: 6160 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void LHBDPDOBNAK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x0009AE44 File Offset: 0x00099044
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 984f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.ACHNOHCLGOO().SetFloat("shader.future", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("a minute ago", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("_Value4", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetFloat("/", this.SplitX);
			this.ACHNOHCLGOO().SetFloat("GhostFade2", this.SplitY);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.Smooth);
			this.ACHNOHCLGOO().SetFloat("skin.", this.Rotation);
			this.LDNADDJMIPK().SetInt("#activechallenges", (!this.CONEELGCALI) ? 0 : 1);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void KCDOMIJBFLL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x0009AF8C File Offset: 0x0009918C
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1724f)
			{
				this.HBJJOCHGOPH = 1106f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("RarityImage", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("colorA", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("config.txt", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetFloat("SelectorMapsCountSlider", this.SplitX);
			this.LDNADDJMIPK().SetFloat("_EmissionGain", this.SplitY);
			this.ACHNOHCLGOO().SetFloat("_U", this.Smooth);
			this.LDNADDJMIPK().SetFloat("Case-Sensitive", this.Rotation);
			this.NBPKMLMCHFN.SetInt("_TimeX", (!this.CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x0009AE07 File Offset: 0x00099007
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

	// Token: 0x06001815 RID: 6165 RVA: 0x0009B0D4 File Offset: 0x000992D4
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -11);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001816 RID: 6166 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void ECKEBMIMIGK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001817 RID: 6167 RVA: 0x0009B14C File Offset: 0x0009934C
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x0009B1C3 File Offset: 0x000993C3
	private void LIFBFDKFMMH()
	{
		this.BGDPIHMAACO();
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void NEKCPLGFOFD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x0009B22C File Offset: 0x0009942C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1207f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("UsernameText", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("InfoCanvas", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("finished", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("ok", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetFloat("musicVolume", this.SplitX);
			this.NBPKMLMCHFN.SetFloat("Error: Someone else(", this.SplitY);
			this.NBPKMLMCHFN.SetFloat(" isOwnerActive: ", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("[MapsEditor] Creating new item...", this.Rotation);
			this.LDNADDJMIPK().SetInt("Right", (!this.CONEELGCALI) ? 0 : 1);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x0009B373 File Offset: 0x00099573
	private void HGIMCCHIPCP()
	{
		this.JKFDDNMPOJH();
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x0009B37C File Offset: 0x0009957C
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600181E RID: 6174 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void OnValidate()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x0009B3F3 File Offset: 0x000995F3
	private void MBNMADBPDLL()
	{
		this.NNCCPEBIAKH();
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x0009AD2B File Offset: 0x00098F2B
	private void OnEnable()
	{
		this.Start();
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x0009AE07 File Offset: 0x00099007
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

	// Token: 0x06001822 RID: 6178 RVA: 0x0009AE07 File Offset: 0x00099007
	private void DHENLPJJOEN()
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

	// Token: 0x06001823 RID: 6179 RVA: 0x0009AE07 File Offset: 0x00099007
	private void ICDBMJKMIKC()
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

	// Token: 0x06001824 RID: 6180 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void OFBLDOCCBBN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x0009B1C3 File Offset: 0x000993C3
	private void MHGPANIBBCM()
	{
		this.BGDPIHMAACO();
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x0009B3FC File Offset: 0x000995FC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1330f)
			{
				this.HBJJOCHGOPH = 1335f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("SpectateButton", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_ToneCurve", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", this.SplitX);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", this.SplitY);
			this.LDNADDJMIPK().SetFloat("Paste events", this.Smooth);
			this.LDNADDJMIPK().SetFloat("player.xp", this.Rotation);
			this.LDNADDJMIPK().SetInt("\n", (!this.CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void JHPOIOELNCG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x0009B1C3 File Offset: 0x000993C3
	private void INGOODALACO()
	{
		this.BGDPIHMAACO();
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x0009B373 File Offset: 0x00099573
	private void GBFPAEDPOPP()
	{
		this.JKFDDNMPOJH();
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x0009B544 File Offset: 0x00099744
	private void JKFDDNMPOJH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x0009AD33 File Offset: 0x00098F33
	private void FBIIBKKCOKO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x0009B5BC File Offset: 0x000997BC
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
			this.NBPKMLMCHFN.SetFloat("_Value3", this.SplitX);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.SplitY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Rotation);
			this.NBPKMLMCHFN.SetInt("_ForceYSwap", (!this.CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600182D RID: 6189 RVA: 0x0009B703 File Offset: 0x00099903
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600182E RID: 6190 RVA: 0x0009AD2B File Offset: 0x00098F2B
	private void OKHGJFFIIBA()
	{
		this.Start();
	}

	// Token: 0x0600182F RID: 6191 RVA: 0x0009AE07 File Offset: 0x00099007
	private void PLIKADJCEPO()
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

	// Token: 0x0400035E RID: 862
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SplitScreen";

	// Token: 0x0400035F RID: 863
	public Shader SCShader;

	// Token: 0x04000360 RID: 864
	public Camera Camera2;

	// Token: 0x04000361 RID: 865
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000362 RID: 866
	private Material BJFKDHHMLJH;

	// Token: 0x04000363 RID: 867
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000364 RID: 868
	[Range(0f, 1f)]
	public float BlendFX = 1f;

	// Token: 0x04000365 RID: 869
	[Range(-3f, 3f)]
	public float SplitX = 0.5f;

	// Token: 0x04000366 RID: 870
	[Range(-3f, 3f)]
	public float SplitY = 0.5f;

	// Token: 0x04000367 RID: 871
	[Range(0f, 2f)]
	public float Smooth = 0.1f;

	// Token: 0x04000368 RID: 872
	[Range(-3.14f, 3.14f)]
	public float Rotation = 3.14f;

	// Token: 0x04000369 RID: 873
	private bool CONEELGCALI;

	// Token: 0x0400036A RID: 874
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x0400036B RID: 875
	private Vector2 FPEMMGKMJGA;
}
