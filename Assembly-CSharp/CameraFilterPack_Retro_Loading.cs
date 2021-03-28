using System;
using UnityEngine;

// Token: 0x02000109 RID: 265
[AddComponentMenu("Camera Filter Pack/Retro/Loading")]
[ExecuteInEditMode]
public class CameraFilterPack_Retro_Loading : MonoBehaviour
{
	// Token: 0x06005297 RID: 21143 RVA: 0x0019B6C6 File Offset: 0x001998C6
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005298 RID: 21144 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005299 RID: 21145 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600529A RID: 21146 RVA: 0x0019B707 File Offset: 0x00199907
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600529B RID: 21147 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600529C RID: 21148 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600529D RID: 21149 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600529E RID: 21150 RVA: 0x0019B73E File Offset: 0x0019993E
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_PinLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600529F RID: 21151 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060052A0 RID: 21152 RVA: 0x0019B762 File Offset: 0x00199962
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Set particles count per one beat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052A1 RID: 21153 RVA: 0x0019B788 File Offset: 0x00199988
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1941f)
			{
				this.HBJJOCHGOPH = 1473f;
			}
			this.ABHDNGIHBKE().SetFloat("[MapsSystem] Unloading maps resources...", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("SetupEncryption() got called. ", this.Speed);
			this.KBOPGONOCNP().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 244f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052A3 RID: 21155 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060052A4 RID: 21156 RVA: 0x0019B863 File Offset: 0x00199A63
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052A5 RID: 21157 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060052A6 RID: 21158 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052A7 RID: 21159 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052A8 RID: 21160 RVA: 0x0019B89A File Offset: 0x00199A9A
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Linecount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052A9 RID: 21161 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052AA RID: 21162 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060052AB RID: 21163 RVA: 0x0019B8BE File Offset: 0x00199ABE
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052AC RID: 21164 RVA: 0x0019B8F5 File Offset: 0x00199AF5
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052AD RID: 21165 RVA: 0x0019B92C File Offset: 0x00199B2C
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1813f)
			{
				this.HBJJOCHGOPH = 127f;
			}
			this.KBOPGONOCNP().SetFloat("Editor", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("ControllerLeftY", this.Speed);
			this.KAFBNOBOIAJ().SetVector("s", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 451f, 1203f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052AE RID: 21166 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060052AF RID: 21167 RVA: 0x0019B9E9 File Offset: 0x00199BE9
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052B0 RID: 21168 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052B1 RID: 21169 RVA: 0x0019BA20 File Offset: 0x00199C20
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052B2 RID: 21170 RVA: 0x0019BA58 File Offset: 0x00199C58
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1138f)
			{
				this.HBJJOCHGOPH = 1347f;
			}
			this.LPMLLJKMAMP().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this.Speed);
			this.ADGHJOHKEHG().SetVector("UseFinalGlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 267f, 1048f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052B3 RID: 21171 RVA: 0x0019BB15 File Offset: 0x00199D15
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052B4 RID: 21172 RVA: 0x0019BB4C File Offset: 0x00199D4C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 962f)
			{
				this.HBJJOCHGOPH = 1750f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("GlassDistortion", this.Speed);
			this.HHIFMIPPMPF().SetVector(". Set PhotonNetwork.OnEventCall.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1940f, 1559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052B5 RID: 21173 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060052B6 RID: 21174 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x060052B7 RID: 21175 RVA: 0x0019BC09 File Offset: 0x00199E09
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052B8 RID: 21176 RVA: 0x0019BC2D File Offset: 0x00199E2D
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052B9 RID: 21177 RVA: 0x0019BC51 File Offset: 0x00199E51
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052BA RID: 21178 RVA: 0x0019BC88 File Offset: 0x00199E88
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052BB RID: 21179 RVA: 0x0019BCAC File Offset: 0x00199EAC
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052BC RID: 21180 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060052BD RID: 21181 RVA: 0x0019BCD0 File Offset: 0x00199ED0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1596f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.KBOPGONOCNP().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_Convolved_TexelSize", this.Speed);
			this.GJHLADDCMFF().SetVector("mapselector.filter.subscribedonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 868f, 1253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052BE RID: 21182 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052BF RID: 21183 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060052C0 RID: 21184 RVA: 0x0019BD8D File Offset: 0x00199F8D
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052C1 RID: 21185 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052C2 RID: 21186 RVA: 0x0019BDC4 File Offset: 0x00199FC4
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052C3 RID: 21187 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060052C4 RID: 21188 RVA: 0x0019B6EA File Offset: 0x001998EA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052C5 RID: 21189 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060052C6 RID: 21190 RVA: 0x0019BDFC File Offset: 0x00199FFC
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1561f)
			{
				this.HBJJOCHGOPH = 177f;
			}
			this.ABHDNGIHBKE().SetFloat("UI Extensions/UILinearDodge", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("achievements.21.progress", this.Speed);
			this.LPMLLJKMAMP().SetVector("D-Pad Down", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 242f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052C7 RID: 21191 RVA: 0x0019BEBC File Offset: 0x0019A0BC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 919f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("/icon", this.Speed);
			this.MFHPKGICPIO().SetVector("_History1ChromaTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1189f, 803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060052C8 RID: 21192 RVA: 0x0019BF79 File Offset: 0x0019A179
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

	// Token: 0x060052C9 RID: 21193 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x0019BFB0 File Offset: 0x0019A1B0
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenVertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x0019BFD4 File Offset: 0x0019A1D4
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1409f)
			{
				this.HBJJOCHGOPH = 185f;
			}
			this.ADGHJOHKEHG().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Toggle {0} is not part of ToggleGroup {1}", this.Speed);
			this.FEAEGGCNIAA().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1379f, 1090f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052CC RID: 21196 RVA: 0x0019C094 File Offset: 0x0019A294
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 631f)
			{
				this.HBJJOCHGOPH = 1596f;
			}
			this.HHIFMIPPMPF().SetFloat("_Green_B", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("SelectorMusicToggle", this.Speed);
			this.GJHLADDCMFF().SetVector("CameraFilterPack/Blend2Camera_Divide", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1393f, 1356f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x0019C151 File Offset: 0x0019A351
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052CE RID: 21198 RVA: 0x0019C178 File Offset: 0x0019A378
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 737f)
			{
				this.HBJJOCHGOPH = 1361f;
			}
			this.KBOPGONOCNP().SetFloat(".", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("ACCEPT", this.Speed);
			this.HKGAONMOBMH().SetVector("/../", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 595f, 1805f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x0019C235 File Offset: 0x0019A435
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052D0 RID: 21200 RVA: 0x0019C26C File Offset: 0x0019A46C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1073f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.MFHPKGICPIO().SetFloat(" beatThreshold: ", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Speed);
			this.OKJOKHGJHGF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 994f, 217f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x0019C329 File Offset: 0x0019A529
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("hand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052D2 RID: 21202 RVA: 0x0019C350 File Offset: 0x0019A550
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1325f)
			{
				this.HBJJOCHGOPH = 1396f;
			}
			this.OKJOKHGJHGF().SetFloat("SetSunEmission", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.Speed);
			this.LPMLLJKMAMP().SetVector("CameraFilterPack/TV_Posterize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1968f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052D3 RID: 21203 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x0019B8F5 File Offset: 0x00199AF5
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x0019C40D File Offset: 0x0019A60D
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x0019C444 File Offset: 0x0019A644
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("Hidden/TonemappingColorGrading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052D7 RID: 21207 RVA: 0x0019C468 File Offset: 0x0019A668
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x0019C48C File Offset: 0x0019A68C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Retro_Loading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052D9 RID: 21209 RVA: 0x0019B863 File Offset: 0x00199A63
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052DA RID: 21210 RVA: 0x0019C4B0 File Offset: 0x0019A6B0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052DB RID: 21211 RVA: 0x0019C570 File Offset: 0x0019A770
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1810f)
			{
				this.HBJJOCHGOPH = 883f;
			}
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.bgcolor", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("mapselector.filter.favoriteonly", this.Speed);
			this.KEMJNOMIPHN().SetVector("CameraFilterPack/Color_Chromatic_Aberration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 667f, 1000f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052DC RID: 21212 RVA: 0x0019C62D File Offset: 0x0019A82D
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("PointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052DD RID: 21213 RVA: 0x0019C651 File Offset: 0x0019A851
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052DE RID: 21214 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x0019C688 File Offset: 0x0019A888
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040008A8 RID: 2216
	public Shader SCShader;

	// Token: 0x040008A9 RID: 2217
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008AA RID: 2218
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008AB RID: 2219
	private Material BJFKDHHMLJH;

	// Token: 0x040008AC RID: 2220
	[Range(0.1f, 10f)]
	public float Speed = 1f;
}
