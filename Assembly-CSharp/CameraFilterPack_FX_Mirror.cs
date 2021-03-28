using System;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[AddComponentMenu("Camera Filter Pack/FX/Mirror")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Mirror : MonoBehaviour
{
	// Token: 0x06003EE9 RID: 16105 RVA: 0x0013909A File Offset: 0x0013729A
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x0013909A File Offset: 0x0013729A
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x0013909A File Offset: 0x0013729A
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EEC RID: 16108 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003EED RID: 16109 RVA: 0x001390B8 File Offset: 0x001372B8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1302f)
			{
				this.HBJJOCHGOPH = 339f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetVector("_ForegroundBlurExtrude", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 538f, 883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EEE RID: 16110 RVA: 0x0013909A File Offset: 0x0013729A
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EEF RID: 16111 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06003EF0 RID: 16112 RVA: 0x0013915F File Offset: 0x0013735F
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x00139196 File Offset: 0x00137396
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

	// Token: 0x06003EF2 RID: 16114 RVA: 0x001391D0 File Offset: 0x001373D0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 715f)
			{
				this.HBJJOCHGOPH = 1150f;
			}
			this.FHFLKLMFHOI().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetVector("OxOD.lastPath", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1026f, 542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EF3 RID: 16115 RVA: 0x00139277 File Offset: 0x00137477
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_SplitScreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003EF4 RID: 16116 RVA: 0x0013929C File Offset: 0x0013749C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 62f)
			{
				this.HBJJOCHGOPH = 717f;
			}
			this.ACHNOHCLGOO().SetFloat("G:", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetVector("SetRoomStartTimestamp", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 913f, 31f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EF5 RID: 16117 RVA: 0x00139343 File Offset: 0x00137543
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003EF6 RID: 16118 RVA: 0x0013909A File Offset: 0x0013729A
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EF7 RID: 16119 RVA: 0x00139367 File Offset: 0x00137567
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EF8 RID: 16120 RVA: 0x0013909A File Offset: 0x0013729A
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EF9 RID: 16121 RVA: 0x0013939E File Offset: 0x0013759E
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EFA RID: 16122 RVA: 0x001393C2 File Offset: 0x001375C2
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x0013909A File Offset: 0x0013729A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EFC RID: 16124 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x001393F9 File Offset: 0x001375F9
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EFF RID: 16127 RVA: 0x00139430 File Offset: 0x00137630
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x0013909A File Offset: 0x0013729A
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x00139454 File Offset: 0x00137654
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x00139478 File Offset: 0x00137678
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x0013909A File Offset: 0x0013729A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x001394B0 File Offset: 0x001376B0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1448f)
			{
				this.HBJJOCHGOPH = 554f;
			}
			this.KGOLDDBHIFN().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetVector("#finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1251f, 1600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x0013909A File Offset: 0x0013729A
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06003F0A RID: 16138 RVA: 0x0013909A File Offset: 0x0013729A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F0B RID: 16139 RVA: 0x0013909A File Offset: 0x0013729A
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x0013909A File Offset: 0x0013729A
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x0013956C File Offset: 0x0013776C
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F0E RID: 16142 RVA: 0x0013909A File Offset: 0x0013729A
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x00139613 File Offset: 0x00137813
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F10 RID: 16144 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06003F11 RID: 16145 RVA: 0x00139637 File Offset: 0x00137837
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x0013966E File Offset: 0x0013786E
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("UpdateDownloadingProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x00139694 File Offset: 0x00137894
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 142f)
			{
				this.HBJJOCHGOPH = 1459f;
			}
			this.NDMPCDHADMJ().SetFloat("player.orangelifering", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetVector("\\", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1366f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F15 RID: 16149 RVA: 0x0013909A File Offset: 0x0013729A
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x0013973B File Offset: 0x0013793B
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06003F1B RID: 16155 RVA: 0x0013909A File Offset: 0x0013729A
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x0013975F File Offset: 0x0013795F
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_SizeY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x00139784 File Offset: 0x00137984
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 697f)
			{
				this.HBJJOCHGOPH = 1490f;
			}
			this.FHFLKLMFHOI().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector(".lastCheckpoint.currentCombo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1452f, 114f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x0013982C File Offset: 0x00137A2C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1097f)
			{
				this.HBJJOCHGOPH = 302f;
			}
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetVector("Status: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1094f, 945f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x001398D3 File Offset: 0x00137AD3
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040006C5 RID: 1733
	public Shader SCShader;

	// Token: 0x040006C6 RID: 1734
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006C7 RID: 1735
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006C8 RID: 1736
	private Material BJFKDHHMLJH;
}
