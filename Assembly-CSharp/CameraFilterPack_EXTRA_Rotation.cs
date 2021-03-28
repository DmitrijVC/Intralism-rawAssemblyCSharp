using System;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/EXTRA/Rotation")]
public class CameraFilterPack_EXTRA_Rotation : MonoBehaviour
{
	// Token: 0x06003778 RID: 14200 RVA: 0x0011BEC1 File Offset: 0x0011A0C1
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003779 RID: 14201 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600377A RID: 14202 RVA: 0x0011BF15 File Offset: 0x0011A115
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600377B RID: 14203 RVA: 0x0011BF39 File Offset: 0x0011A139
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600377C RID: 14204 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600377D RID: 14205 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600377E RID: 14206 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600377F RID: 14207 RVA: 0x0011BF5D File Offset: 0x0011A15D
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003780 RID: 14208 RVA: 0x0011BF94 File Offset: 0x0011A194
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 219f)
			{
				this.HBJJOCHGOPH = 1980f;
			}
			this.GKILCDHJFEG().SetFloat("#", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_NeutralTonemapperParams1", -this.Rotation);
			this.CFEDGDGBCHE().SetFloat("string", this.PositionX);
			this.DNLMFEGJJDD().SetFloat("0", this.PositionY);
			this.DOHGBNPMBKG().SetFloat("Can't SendMove. Turn is finished by this player.", this.CCIENBFIKKH);
			this.GKILCDHJFEG().SetVector("_DistAmount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 778f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003781 RID: 14209 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003782 RID: 14210 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003783 RID: 14211 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06003784 RID: 14212 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003785 RID: 14213 RVA: 0x0011C094 File Offset: 0x0011A294
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 115f)
			{
				this.HBJJOCHGOPH = 1200f;
			}
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat(".GoalProgress", -this.Rotation);
			this.CFEDGDGBCHE().SetFloat("_Value", this.PositionX);
			this.DOHGBNPMBKG().SetFloat("SUBMIT", this.PositionY);
			this.DNLMFEGJJDD().SetFloat("Editor/", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("_Glow", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 1016f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003786 RID: 14214 RVA: 0x0011C194 File Offset: 0x0011A394
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003787 RID: 14215 RVA: 0x0011C1B8 File Offset: 0x0011A3B8
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_BlurArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003788 RID: 14216 RVA: 0x0011C1DC File Offset: 0x0011A3DC
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1096f)
			{
				this.HBJJOCHGOPH = 1395f;
			}
			this.PLBEJJIHFPB().SetFloat(".icon", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_BlurCoe", -this.Rotation);
			this.CFEDGDGBCHE().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.PositionX);
			this.CFEDGDGBCHE().SetFloat("StartButton", this.PositionY);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.CFEDGDGBCHE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1606f, 658f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003789 RID: 14217 RVA: 0x0011C2DC File Offset: 0x0011A4DC
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600378A RID: 14218 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600378B RID: 14219 RVA: 0x0011C314 File Offset: 0x0011A514
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 437f)
			{
				this.HBJJOCHGOPH = 151f;
			}
			this.KBOPGONOCNP().SetFloat("Up ", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("/icon", -this.Rotation);
			this.PLBEJJIHFPB().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", this.PositionX);
			this.GKILCDHJFEG().SetFloat("MenuScene", this.PositionY);
			this.PDEAHJPOMEF().SetFloat("set", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("FPSToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1459f, 5f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600378C RID: 14220 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600378D RID: 14221 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600378E RID: 14222 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600378F RID: 14223 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003790 RID: 14224 RVA: 0x0011C414 File Offset: 0x0011A614
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003791 RID: 14225 RVA: 0x0011C438 File Offset: 0x0011A638
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/EXTRA_Rotation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003792 RID: 14226 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06003793 RID: 14227 RVA: 0x0011C45C File Offset: 0x0011A65C
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

	// Token: 0x06003794 RID: 14228 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003795 RID: 14229 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003796 RID: 14230 RVA: 0x0011C493 File Offset: 0x0011A693
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003797 RID: 14231 RVA: 0x0011C4B8 File Offset: 0x0011A6B8
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
			this.NBPKMLMCHFN.SetFloat("_Value", -this.Rotation);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PositionY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003798 RID: 14232 RVA: 0x0011C5B8 File Offset: 0x0011A7B8
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 496f;
			}
			this.NBPKMLMCHFN.SetFloat("yes", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("[Up]", -this.Rotation);
			this.NBMPPNFKFLB().SetFloat("UI/Particles/Hidden", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("f", this.PositionY);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 415f, 633f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003799 RID: 14233 RVA: 0x0011C6B8 File Offset: 0x0011A8B8
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 687f)
			{
				this.HBJJOCHGOPH = 653f;
			}
			this.GKILCDHJFEG().SetFloat("L1", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_Bullet_4", -this.Rotation);
			this.GKILCDHJFEG().SetFloat(" ", this.PositionX);
			this.DOHGBNPMBKG().SetFloat("_DiffuseColor", this.PositionY);
			this.CFEDGDGBCHE().SetFloat("Down", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("float,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1269f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600379A RID: 14234 RVA: 0x0011C7B8 File Offset: 0x0011A9B8
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600379B RID: 14235 RVA: 0x0011C7EF File Offset: 0x0011A9EF
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600379C RID: 14236 RVA: 0x0011C826 File Offset: 0x0011AA26
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_OffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600379D RID: 14237 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600379E RID: 14238 RVA: 0x0011C84A File Offset: 0x0011AA4A
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600379F RID: 14239 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060037A1 RID: 14241 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060037A2 RID: 14242 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060037A3 RID: 14243 RVA: 0x0011C8B5 File Offset: 0x0011AAB5
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_Quality");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060037A4 RID: 14244 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060037A5 RID: 14245 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060037A6 RID: 14246 RVA: 0x0011C8DC File Offset: 0x0011AADC
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 120f)
			{
				this.HBJJOCHGOPH = 1930f;
			}
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Protocol switch from: ", -this.Rotation);
			this.GKILCDHJFEG().SetFloat("z", this.PositionX);
			this.GKILCDHJFEG().SetFloat("maps.", this.PositionY);
			this.DNLMFEGJJDD().SetFloat("Jazz", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("OnStatusChanged: {0} current State: {1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 997f, 1941f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060037A7 RID: 14247 RVA: 0x0011C9DC File Offset: 0x0011ABDC
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find(".r");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060037A8 RID: 14248 RVA: 0x0011CA00 File Offset: 0x0011AC00
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060037A9 RID: 14249 RVA: 0x0011CA24 File Offset: 0x0011AC24
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060037AA RID: 14250 RVA: 0x0011CA48 File Offset: 0x0011AC48
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060037AB RID: 14251 RVA: 0x0011CA7F File Offset: 0x0011AC7F
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060037AC RID: 14252 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400060B RID: 1547
	public Shader SCShader;

	// Token: 0x0400060C RID: 1548
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400060D RID: 1549
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400060E RID: 1550
	private Material BJFKDHHMLJH;

	// Token: 0x0400060F RID: 1551
	[Range(-360f, 360f)]
	public float Rotation;

	// Token: 0x04000610 RID: 1552
	[Range(-1f, 2f)]
	public float PositionX = 0.5f;

	// Token: 0x04000611 RID: 1553
	[Range(-1f, 2f)]
	public float PositionY = 0.5f;

	// Token: 0x04000612 RID: 1554
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
