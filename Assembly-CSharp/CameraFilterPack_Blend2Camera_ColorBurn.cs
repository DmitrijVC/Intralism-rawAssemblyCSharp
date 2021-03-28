using System;
using UnityEngine;

// Token: 0x0200003C RID: 60
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/ColorBurn")]
public class CameraFilterPack_Blend2Camera_ColorBurn : MonoBehaviour
{
	// Token: 0x06001047 RID: 4167 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00070634 File Offset: 0x0006E834
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1554f)
			{
				this.HBJJOCHGOPH = 107f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("OnRelease", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("_Fade", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Blur_Bloom", this.BlendFX);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.IGIAPKPKGPK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1566f, 852f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x0007072E File Offset: 0x0006E92E
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

	// Token: 0x0600104A RID: 4170 RVA: 0x00070768 File Offset: 0x0006E968
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x000707A4 File Offset: 0x0006E9A4
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 912f)
			{
				this.HBJJOCHGOPH = 1137f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("[MapEditor] Created new map: ", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.BlendFX);
			this.IIBLJCKLGFG().SetFloat("settings.arcsdestroydelay", this.SwitchCameraToCamera2);
			this.HEHKGPKLAKK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1115f, 1618f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x000708A0 File Offset: 0x0006EAA0
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 894f)
			{
				this.HBJJOCHGOPH = 709f;
			}
			if (this.Camera2 != null)
			{
				this.HCGJCMDJPGD().SetTexture("OK", this.JDMCFBKJHDD);
			}
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("/icon", this.BlendFX);
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_VHS", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector(" PhotonView: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1441f, 823f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x0007099A File Offset: 0x0006EB9A
	private void OEAMLMGNFFC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x000709D8 File Offset: 0x0006EBD8
	private void FBPHNEJBDJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -94);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x0007072E File Offset: 0x0006E92E
	private void FGOPJMGNHGO()
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

	// Token: 0x06001051 RID: 4177 RVA: 0x00070A41 File Offset: 0x0006EC41
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00070A78 File Offset: 0x0006EC78
	private void IFBKMAEMKNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00070AB4 File Offset: 0x0006ECB4
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

	// Token: 0x06001054 RID: 4180 RVA: 0x00070B20 File Offset: 0x0006ED20
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00070B8C File Offset: 0x0006ED8C
	private void EPEGAEGDJAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00070BF8 File Offset: 0x0006EDF8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1607f)
			{
				this.HBJJOCHGOPH = 126f;
			}
			if (this.Camera2 != null)
			{
				this.IGKFMCPDNOI().SetTexture("[ResourcesManager] Load image error: ", this.JDMCFBKJHDD);
			}
			this.IGKFMCPDNOI().SetFloat("ControllerLeftX", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("CompletedLevel", this.BlendFX);
			this.HEHKGPKLAKK().SetFloat("resource id", this.SwitchCameraToCamera2);
			this.JFDGLLEOPGB().SetVector("Edited hands count", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1444f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00070CF4 File Offset: 0x0006EEF4
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

	// Token: 0x06001058 RID: 4184 RVA: 0x00070DEE File Offset: 0x0006EFEE
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x00070E25 File Offset: 0x0006F025
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00070E5C File Offset: 0x0006F05C
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00070E94 File Offset: 0x0006F094
	private void CGDMLHLJIDK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -128);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600105D RID: 4189 RVA: 0x00070EFD File Offset: 0x0006F0FD
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

	// Token: 0x0600105E RID: 4190 RVA: 0x00070F34 File Offset: 0x0006F134
	private void CMBGFMAOEPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x0007072E File Offset: 0x0006E92E
	private void OFPPIKHNJOD()
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

	// Token: 0x06001061 RID: 4193 RVA: 0x00070F70 File Offset: 0x0006F170
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00070FD9 File Offset: 0x0006F1D9
	private void LHBDPDOBNAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x0007072E File Offset: 0x0006E92E
	private void DPFOEBCADNP()
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

	// Token: 0x06001064 RID: 4196 RVA: 0x00071014 File Offset: 0x0006F214
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x0007104B File Offset: 0x0006F24B
	private void NMNAEPIDENM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -22);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x0007072E File Offset: 0x0006E92E
	private void FKEJGBFDCAH()
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

	// Token: 0x06001068 RID: 4200 RVA: 0x000710AF File Offset: 0x0006F2AF
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001069 RID: 4201 RVA: 0x000710E8 File Offset: 0x0006F2E8
	private void FANADGBGCPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600106A RID: 4202 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x0600106B RID: 4203 RVA: 0x00071154 File Offset: 0x0006F354
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 342f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			if (this.Camera2 != null)
			{
				this.IGKFMCPDNOI().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.EMDFHOKEGNG().SetFloat("#orderby:", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this.BlendFX);
			this.DOHGBNPMBKG().SetFloat("Uploading content", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetVector("_FresnelFadePower", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 464f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600106C RID: 4204 RVA: 0x0007124E File Offset: 0x0006F44E
	private void MLLPGPANCHI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600106D RID: 4205 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0007128C File Offset: 0x0006F48C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1238f)
			{
				this.HBJJOCHGOPH = 1796f;
			}
			if (this.Camera2 != null)
			{
				this.DOHGBNPMBKG().SetTexture("Texture2", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_Offsets", this.BlendFX);
			this.DOHGBNPMBKG().SetFloat("maps.", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 127f, 859f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00071386 File Offset: 0x0006F586
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x000713BD File Offset: 0x0006F5BD
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x000713F4 File Offset: 0x0006F5F4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 31f)
			{
				this.HBJJOCHGOPH = 443f;
			}
			if (this.Camera2 != null)
			{
				this.JFDGLLEOPGB().SetTexture("GameObject ", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("float,0", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("System.Boolean", this.BlendFX);
			this.HCGJCMDJPGD().SetFloat("#E14FFF", this.SwitchCameraToCamera2);
			this.JFDGLLEOPGB().SetVector(" is muted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1124f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x000714F0 File Offset: 0x0006F6F0
	private void EGEPLFGKGLI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x0007155C File Offset: 0x0006F75C
	private void NCNPAKFAFOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x0007072E File Offset: 0x0006E92E
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

	// Token: 0x06001075 RID: 4213 RVA: 0x000715C5 File Offset: 0x0006F7C5
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x0007072E File Offset: 0x0006E92E
	private void BFEILOMHNPC()
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

	// Token: 0x06001077 RID: 4215 RVA: 0x00071600 File Offset: 0x0006F800
	private void GFOOJOMCCBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -94);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x0007163C File Offset: 0x0006F83C
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x000716A8 File Offset: 0x0006F8A8
	private void KIMMMCJFMAB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 22);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x00071711 File Offset: 0x0006F911
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x0007174C File Offset: 0x0006F94C
	private void INGOODALACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x00071787 File Offset: 0x0006F987
	private void KHDANGFKIGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x000717C2 File Offset: 0x0006F9C2
	private void OKHGJFFIIBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 0);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x000717FD File Offset: 0x0006F9FD
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00071834 File Offset: 0x0006FA34
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00070768 File Offset: 0x0006E968
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x04000256 RID: 598
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorBurn";

	// Token: 0x04000257 RID: 599
	public Shader SCShader;

	// Token: 0x04000258 RID: 600
	public Camera Camera2;

	// Token: 0x04000259 RID: 601
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400025A RID: 602
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400025B RID: 603
	private Material BJFKDHHMLJH;

	// Token: 0x0400025C RID: 604
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400025D RID: 605
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400025E RID: 606
	private RenderTexture JDMCFBKJHDD;
}
