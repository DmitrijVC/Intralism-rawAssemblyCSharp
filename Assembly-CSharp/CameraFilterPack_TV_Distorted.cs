using System;
using UnityEngine;

// Token: 0x02000117 RID: 279
[AddComponentMenu("Camera Filter Pack/TV/Distorted")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Distorted : MonoBehaviour
{
	// Token: 0x06005754 RID: 22356 RVA: 0x001B2B29 File Offset: 0x001B0D29
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005755 RID: 22357 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005756 RID: 22358 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06005757 RID: 22359 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005758 RID: 22360 RVA: 0x001B2B7D File Offset: 0x001B0D7D
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005759 RID: 22361 RVA: 0x001B2BB4 File Offset: 0x001B0DB4
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600575A RID: 22362 RVA: 0x001B2BD8 File Offset: 0x001B0DD8
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600575B RID: 22363 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600575C RID: 22364 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600575D RID: 22365 RVA: 0x001B2C0F File Offset: 0x001B0E0F
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600575E RID: 22366 RVA: 0x001B2C33 File Offset: 0x001B0E33
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("UpperMid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600575F RID: 22367 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x001B2C58 File Offset: 0x001B0E58
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 1587f;
			}
			this.DOHGBNPMBKG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_TimeX", this.Distortion);
			this.FHFLKLMFHOI().SetFloat("OpJoinLobby()", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005761 RID: 22369 RVA: 0x001B2CFE File Offset: 0x001B0EFE
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005762 RID: 22370 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x001B2D22 File Offset: 0x001B0F22
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06005764 RID: 22372 RVA: 0x001B2D59 File Offset: 0x001B0F59
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

	// Token: 0x06005765 RID: 22373 RVA: 0x001B2D90 File Offset: 0x001B0F90
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005766 RID: 22374 RVA: 0x001B2DC7 File Offset: 0x001B0FC7
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06005768 RID: 22376 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x001B2DFE File Offset: 0x001B0FFE
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("note.0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600576A RID: 22378 RVA: 0x001B2E22 File Offset: 0x001B1022
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x001B2E46 File Offset: 0x001B1046
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Joystick1Button");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600576C RID: 22380 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600576D RID: 22381 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600576E RID: 22382 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600576F RID: 22383 RVA: 0x001B2E6A File Offset: 0x001B106A
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005770 RID: 22384 RVA: 0x001B2EA1 File Offset: 0x001B10A1
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005771 RID: 22385 RVA: 0x001B2EC5 File Offset: 0x001B10C5
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005772 RID: 22386 RVA: 0x001B2EFC File Offset: 0x001B10FC
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005773 RID: 22387 RVA: 0x001B2F33 File Offset: 0x001B1133
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x001B2F6C File Offset: 0x001B116C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 464f)
			{
				this.HBJJOCHGOPH = 599f;
			}
			this.FLGPDBBKAIP().SetFloat("SetRotation", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_MatrixSize", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("\n", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x001B3012 File Offset: 0x001B1212
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x001B304C File Offset: 0x001B124C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1706f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("/", this.Distortion);
			this.DOHGBNPMBKG().SetFloat("#scoresubmitionfailed: ", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005778 RID: 22392 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06005779 RID: 22393 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600577A RID: 22394 RVA: 0x001B2D59 File Offset: 0x001B0F59
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600577B RID: 22395 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600577C RID: 22396 RVA: 0x001B30F4 File Offset: 0x001B12F4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 930f)
			{
				this.HBJJOCHGOPH = 1039f;
			}
			this.HNICHJCGJOC().SetFloat("0.00", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(" By: ", this.Distortion);
			this.HNICHJCGJOC().SetFloat("Set sun directionVector - in which direction sun will grow on beat", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600577D RID: 22397 RVA: 0x001B319C File Offset: 0x001B139C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 394f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/AAA_Super_Computer", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("BadgeText", this.Distortion);
			this.OLHDPICFBOF().SetFloat("UndoButton", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600577E RID: 22398 RVA: 0x001B3242 File Offset: 0x001B1442
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600577F RID: 22399 RVA: 0x001B3266 File Offset: 0x001B1466
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005780 RID: 22400 RVA: 0x001B329D File Offset: 0x001B149D
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005781 RID: 22401 RVA: 0x001B32D4 File Offset: 0x001B14D4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1477f)
			{
				this.HBJJOCHGOPH = 381f;
			}
			this.OCHJIMJNEMO().SetFloat("GlassColor", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this.Distortion);
			this.JLHLHKPHDFO().SetFloat("_MainTex", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005782 RID: 22402 RVA: 0x001B337C File Offset: 0x001B157C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1012f)
			{
				this.HBJJOCHGOPH = 720f;
			}
			this.NBPKMLMCHFN.SetFloat("_BaseTex", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("AVG Misses:", this.Distortion);
			this.FHFLKLMFHOI().SetFloat("_Value2", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x001B3422 File Offset: 0x001B1622
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x001B3446 File Offset: 0x001B1646
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("No peer to communicate with. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005785 RID: 22405 RVA: 0x001B346A File Offset: 0x001B166A
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005786 RID: 22406 RVA: 0x001B34A1 File Offset: 0x001B16A1
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005787 RID: 22407 RVA: 0x001B34C5 File Offset: 0x001B16C5
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005788 RID: 22408 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x001B34FC File Offset: 0x001B16FC
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x001B3533 File Offset: 0x001B1733
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("ControllerRightX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600578C RID: 22412 RVA: 0x001B3557 File Offset: 0x001B1757
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("settings.arcshitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600578D RID: 22413 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x001B357C File Offset: 0x001B177C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 554f;
			}
			this.BFGNMFCNDBC().SetFloat("_BlurTex", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("/Segment-[Up]", this.Distortion);
			this.HEINDEMCGIK().SetFloat("a year ago", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x001B3622 File Offset: 0x001B1822
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x001B365C File Offset: 0x001B185C
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_RGB", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x001B3702 File Offset: 0x001B1902
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Distorted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005796 RID: 22422 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x001B3728 File Offset: 0x001B1928
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1946f)
			{
				this.HBJJOCHGOPH = 929f;
			}
			this.FLGPDBBKAIP().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Axis", this.Distortion);
			this.DOHGBNPMBKG().SetFloat("_TimeX", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x001B37CE File Offset: 0x001B19CE
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600579A RID: 22426 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x001B37F2 File Offset: 0x001B19F2
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x001B3816 File Offset: 0x001B1A16
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("\t");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600579D RID: 22429 RVA: 0x001B383A File Offset: 0x001B1A3A
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600579E RID: 22430 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060057A0 RID: 22432 RVA: 0x001B3871 File Offset: 0x001B1A71
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("Drop_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x001B3895 File Offset: 0x001B1A95
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057A4 RID: 22436 RVA: 0x001B34A1 File Offset: 0x001B16A1
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x001B38B9 File Offset: 0x001B1AB9
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("materialsquantity[");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057A8 RID: 22440 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x001B38DD File Offset: 0x001B1ADD
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057AA RID: 22442 RVA: 0x001B3914 File Offset: 0x001B1B14
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 864f)
			{
				this.HBJJOCHGOPH = 812f;
			}
			this.HEINDEMCGIK().SetFloat("_Radius2", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat(".g", this.Distortion);
			this.MJJIEHANFJA().SetFloat(".lastCheckpoint.checkpointsUsed", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x001B39BA File Offset: 0x001B1BBA
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("NEW_ACHIEVEMENT_1_26");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057AC RID: 22444 RVA: 0x001B39DE File Offset: 0x001B1BDE
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("SetSunLerpSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x001B3A02 File Offset: 0x001B1C02
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("_MaxBlurRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x001B3A28 File Offset: 0x001B1C28
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1289f)
			{
				this.HBJJOCHGOPH = 1094f;
			}
			this.EHDJJANLINB().SetFloat("SendVacantViewIds()", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#close", this.Distortion);
			this.EHDJJANLINB().SetFloat("[MapEditor] Openning ", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057AF RID: 22447 RVA: 0x001B3AD0 File Offset: 0x001B1CD0
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 147f)
			{
				this.HBJJOCHGOPH = 1867f;
			}
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_CurrentMipLevel", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x001B3B76 File Offset: 0x001B1D76
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057B1 RID: 22449 RVA: 0x001B3B9C File Offset: 0x001B1D9C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 420f)
			{
				this.HBJJOCHGOPH = 1403f;
			}
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Pixelisation_Sweater", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("_GreenAmplifier", this.Distortion);
			this.CIAFLBFJLEJ().SetFloat("_MainTex2", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x001B2E22 File Offset: 0x001B1022
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060057B3 RID: 22451 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057B4 RID: 22452 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x001B3C42 File Offset: 0x001B1E42
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x001B3C79 File Offset: 0x001B1E79
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057B8 RID: 22456 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x001B3CB0 File Offset: 0x001B1EB0
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x001B3CD4 File Offset: 0x001B1ED4
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 354f)
			{
				this.HBJJOCHGOPH = 1696f;
			}
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("SetCrosshairColor", this.Distortion);
			this.HHIFMIPPMPF().SetFloat("settings.fps", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x001B3D7C File Offset: 0x001B1F7C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 59f)
			{
				this.HBJJOCHGOPH = 376f;
			}
			this.KEMAALEODNH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("Circle", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("LevelInfoInputField", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057BD RID: 22461 RVA: 0x001B3E24 File Offset: 0x001B2024
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 354f)
			{
				this.HBJJOCHGOPH = 83f;
			}
			this.NBPKMLMCHFN.SetFloat("STOP [R]", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("note.4", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("OperationResponse unhandled: {0}", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057BE RID: 22462 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057BF RID: 22463 RVA: 0x001B3ECA File Offset: 0x001B20CA
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060057C0 RID: 22464 RVA: 0x001B3F04 File Offset: 0x001B2104
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 747f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.LPCHMEKDCHI().SetFloat("float,50", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack/Gradients_Stripe", this.Distortion);
			this.OGMEGHKECAH().SetFloat("SettingsCanvas", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057C1 RID: 22465 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057C2 RID: 22466 RVA: 0x001B3FAA File Offset: 0x001B21AA
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060057C3 RID: 22467 RVA: 0x001B3FD0 File Offset: 0x001B21D0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1587f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.KEMAALEODNH().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("PLAY [SPACE]", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Color_R", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057C4 RID: 22468 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060057C5 RID: 22469 RVA: 0x001B4078 File Offset: 0x001B2278
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 27f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.HNICHJCGJOC().SetFloat("#mapmustbecompletebeforesubmit", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.Distortion);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.RGB);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060057C7 RID: 22471 RVA: 0x001B2B60 File Offset: 0x001B0D60
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000910 RID: 2320
	public Shader SCShader;

	// Token: 0x04000911 RID: 2321
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000912 RID: 2322
	[Range(0f, 10f)]
	public float Distortion = 1f;

	// Token: 0x04000913 RID: 2323
	[Range(-0.01f, 0.01f)]
	public float RGB = 0.002f;

	// Token: 0x04000914 RID: 2324
	private Material BJFKDHHMLJH;
}
