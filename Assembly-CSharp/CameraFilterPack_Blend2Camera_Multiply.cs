using System;
using UnityEngine;

// Token: 0x0200004E RID: 78
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Multiply")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Multiply : MonoBehaviour
{
	// Token: 0x06001617 RID: 5655 RVA: 0x0008E890 File Offset: 0x0008CA90
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 580f)
			{
				this.HBJJOCHGOPH = 874f;
			}
			if (this.Camera2 != null)
			{
				this.OCHJIMJNEMO().SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.FEAEGGCNIAA().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Drawing_Manga3", this.BlendFX);
			this.HKGAONMOBMH().SetFloat("maps.", this.SwitchCameraToCamera2);
			this.FEAEGGCNIAA().SetVector("CameraFilterPack/Light_Rainbow2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1674f, 143f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x0008E98A File Offset: 0x0008CB8A
	private void MEMKLOMFFJO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x0008E9C5 File Offset: 0x0008CBC5
	private void MGMLGCNLMKN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x0008EA00 File Offset: 0x0008CC00
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

	// Token: 0x0600161C RID: 5660 RVA: 0x0008EA3C File Offset: 0x0008CC3C
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x0008EAA8 File Offset: 0x0008CCA8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 640f)
			{
				this.HBJJOCHGOPH = 180f;
			}
			if (this.Camera2 != null)
			{
				this.DNLMFEGJJDD().SetTexture("start", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat(" ", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("id", this.SwitchCameraToCamera2);
			this.HKGAONMOBMH().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 600f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x0008EBA4 File Offset: 0x0008CDA4
	private void KDMKDEKCELE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x0008EC10 File Offset: 0x0008CE10
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1090f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("_Value2", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("fade in duration", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("1.87", this.BlendFX);
			this.PDEAHJPOMEF().SetFloat("0", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 186f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x0008EA00 File Offset: 0x0008CC00
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

	// Token: 0x06001621 RID: 5665 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x0008ED0A File Offset: 0x0008CF0A
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x0008ED45 File Offset: 0x0008CF45
	private void JCDPMLPNOOC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x0008ED80 File Offset: 0x0008CF80
	private void FNCDAPDOBBI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x0008EA00 File Offset: 0x0008CC00
	private void IFJDKDFLGBG()
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

	// Token: 0x06001626 RID: 5670 RVA: 0x0008EDEC File Offset: 0x0008CFEC
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 769f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("_SoftZDistance", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Gradients_Therma", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("settings.crosshairopacity", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.HKGAONMOBMH().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1328f, 510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001627 RID: 5671 RVA: 0x0008EEE6 File Offset: 0x0008D0E6
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x0008EF1D File Offset: 0x0008D11D
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600162A RID: 5674 RVA: 0x0008ED0A File Offset: 0x0008CF0A
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x0008EF54 File Offset: 0x0008D154
	private void CACAAKGCPPL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x0008EF8F File Offset: 0x0008D18F
	private void KHDANGFKIGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0008EFCA File Offset: 0x0008D1CA
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0008F001 File Offset: 0x0008D201
	private void JHBPINEKDPE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -11);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0008F03C File Offset: 0x0008D23C
	private void DBEMDAJDDDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x0008F0A8 File Offset: 0x0008D2A8
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x0008F114 File Offset: 0x0008D314
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 444f)
			{
				this.HBJJOCHGOPH = 673f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("_Value3", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("EventData0DropDownList", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("Clears all text from the debug console", this.BlendFX);
			this.DONENAMLFLF().SetFloat("OnRenderImage in Helper called ...", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("CameraFilterPack/Blend2Camera_Saturation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1587f, 177f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x0008F20E File Offset: 0x0008D40E
	private void MOMGJJDIFFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x0008F24C File Offset: 0x0008D44C
	private void MKIMDFLBFOM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001635 RID: 5685 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
	private void NNFMIAFHMJM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001636 RID: 5686 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06001637 RID: 5687 RVA: 0x0008F324 File Offset: 0x0008D524
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1113f)
			{
				this.HBJJOCHGOPH = 1060f;
			}
			if (this.Camera2 != null)
			{
				this.NDMPCDHADMJ().SetTexture("SaveButton", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("start", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_Value4", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("OK", this.SwitchCameraToCamera2);
			this.HKGAONMOBMH().SetVector("mapselector.filter.subscribedonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 841f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001638 RID: 5688 RVA: 0x0008F41E File Offset: 0x0008D61E
	private void AENIGCONKBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001639 RID: 5689 RVA: 0x0008EA00 File Offset: 0x0008CC00
	private void NAALCEPIHCH()
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

	// Token: 0x0600163A RID: 5690 RVA: 0x0008F459 File Offset: 0x0008D659
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x0008F494 File Offset: 0x0008D694
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 920f)
			{
				this.HBJJOCHGOPH = 531f;
			}
			if (this.Camera2 != null)
			{
				this.DONENAMLFLF().SetTexture("CameraFilterPack/Drawing_Lines", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat(".completedMaps", this.BlendFX);
			this.HKGAONMOBMH().SetFloat("#tryagain", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1194f, 239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0008F58E File Offset: 0x0008D78E
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x0008F5C8 File Offset: 0x0008D7C8
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x0008F634 File Offset: 0x0008D834
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1219f)
			{
				this.HBJJOCHGOPH = 204f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("ItemsCountText", this.JDMCFBKJHDD);
			}
			this.OCHJIMJNEMO().SetFloat("ChatHistoryInputField", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_LutTex", this.BlendFX);
			this.CFEDGDGBCHE().SetFloat(" is muted", this.SwitchCameraToCamera2);
			this.DONENAMLFLF().SetVector("CameraFilterPack/3D_Computer", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 994f, 631f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x0008F72E File Offset: 0x0008D92E
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0008F765 File Offset: 0x0008D965
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0008F79C File Offset: 0x0008D99C
	private void OHFOLGANOLC()
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

	// Token: 0x06001643 RID: 5699 RVA: 0x0008F805 File Offset: 0x0008DA05
	private void LICOLMAOHKI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0008F840 File Offset: 0x0008DA40
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1382f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("UI Extensions/UIAdditive", this.JDMCFBKJHDD);
			}
			this.CFEDGDGBCHE().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("DifficultyBG", this.BlendFX);
			this.HCGJCMDJPGD().SetFloat("#C8C8C8FF", this.SwitchCameraToCamera2);
			this.FEAEGGCNIAA().SetVector("turn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 849f, 491f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0008F93A File Offset: 0x0008DB3A
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x0008F974 File Offset: 0x0008DB74
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 636f)
			{
				this.HBJJOCHGOPH = 960f;
			}
			if (this.Camera2 != null)
			{
				this.MICHFGAOPKM().SetTexture("Vignette", this.JDMCFBKJHDD);
			}
			this.DONENAMLFLF().SetFloat(" is muted", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("appid", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("/", this.SwitchCameraToCamera2);
			this.DNLMFEGJJDD().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1332f, 1318f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x0008EA00 File Offset: 0x0008CC00
	private void GJAJBMGGPFB()
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

	// Token: 0x06001648 RID: 5704 RVA: 0x0008FA70 File Offset: 0x0008DC70
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 347f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("music", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("_ScratchOffsetScale", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("/../", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.SwitchCameraToCamera2);
			this.DONENAMLFLF().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 705f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x0008FB6A File Offset: 0x0008DD6A
	private void EAOKCECGKAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 87);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x0008FBA8 File Offset: 0x0008DDA8
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

	// Token: 0x0600164D RID: 5709 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x0008FCA4 File Offset: 0x0008DEA4
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 14f)
			{
				this.HBJJOCHGOPH = 1658f;
			}
			if (this.Camera2 != null)
			{
				this.MICHFGAOPKM().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.DONENAMLFLF().SetFloat("OpGetGameList()", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("/", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("#news", this.SwitchCameraToCamera2);
			this.DONENAMLFLF().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1208f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06001650 RID: 5712 RVA: 0x0008FD9E File Offset: 0x0008DF9E
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

	// Token: 0x06001651 RID: 5713 RVA: 0x0008EA00 File Offset: 0x0008CC00
	private void CCPEDDLAMIB()
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

	// Token: 0x06001652 RID: 5714 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
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

	// Token: 0x06001653 RID: 5715 RVA: 0x0008FE44 File Offset: 0x0008E044
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001654 RID: 5716 RVA: 0x0008EA00 File Offset: 0x0008CC00
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

	// Token: 0x06001655 RID: 5717 RVA: 0x0008FEAD File Offset: 0x0008E0AD
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001656 RID: 5718 RVA: 0x0008FEE4 File Offset: 0x0008E0E4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1505f)
			{
				this.HBJJOCHGOPH = 698f;
			}
			if (this.Camera2 != null)
			{
				this.LDNADDJMIPK().SetTexture("menu.playedpage", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("OnSerialize", this.BlendFX);
			this.NDMPCDHADMJ().SetFloat("LevelNameText", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("[ItemsHandler] Found ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 722f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001657 RID: 5719 RVA: 0x0008FFDE File Offset: 0x0008E1DE
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -82);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001658 RID: 5720 RVA: 0x0009001C File Offset: 0x0008E21C
	private void KNBJBNDGCIJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001659 RID: 5721 RVA: 0x00090085 File Offset: 0x0008E285
	private void FGIOPGGPLMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600165A RID: 5722 RVA: 0x000900C0 File Offset: 0x0008E2C0
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600165B RID: 5723 RVA: 0x000900F7 File Offset: 0x0008E2F7
	private void CMBGFMAOEPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x0008EA00 File Offset: 0x0008CC00
	private void KLOLKEBAPFO()
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

	// Token: 0x0600165D RID: 5725 RVA: 0x00090132 File Offset: 0x0008E332
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x0009016C File Offset: 0x0008E36C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1158f)
			{
				this.HBJJOCHGOPH = 54f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("CameraFilterPack_AAA_Blood_Hit1", this.JDMCFBKJHDD);
			}
			this.NDMPCDHADMJ().SetFloat("inventory.itemscash", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Netw. Sim.", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.NDMPCDHADMJ().SetVector("_Contrast", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 435f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600165F RID: 5727 RVA: 0x00090268 File Offset: 0x0008E468
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1282f)
			{
				this.HBJJOCHGOPH = 1282f;
			}
			if (this.Camera2 != null)
			{
				this.NDMPCDHADMJ().SetTexture("Joystick1Button6", this.JDMCFBKJHDD);
			}
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_Color", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this.BlendFX);
			this.DONENAMLFLF().SetFloat("#,0", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 486f, 1490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001660 RID: 5728 RVA: 0x00090362 File Offset: 0x0008E562
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001661 RID: 5729 RVA: 0x00090399 File Offset: 0x0008E599
	private void BLDMINMDHPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001662 RID: 5730 RVA: 0x000903D4 File Offset: 0x0008E5D4
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0009040C File Offset: 0x0008E60C
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00090478 File Offset: 0x0008E678
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1125f)
			{
				this.HBJJOCHGOPH = 1645f;
			}
			if (this.Camera2 != null)
			{
				this.HKGAONMOBMH().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("G:", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("{0}_{1}", this.BlendFX);
			this.HCGJCMDJPGD().SetFloat("float,10", this.SwitchCameraToCamera2);
			this.DNLMFEGJJDD().SetVector("_HitPointTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 72f, 891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0008EA00 File Offset: 0x0008CC00
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

	// Token: 0x06001666 RID: 5734 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0008EA00 File Offset: 0x0008CC00
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

	// Token: 0x06001668 RID: 5736 RVA: 0x00090574 File Offset: 0x0008E774
	private void DNNFHBOOPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x00090606 File Offset: 0x0008E806
	private void JJIMCJBMKEF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x04000303 RID: 771
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Multiply";

	// Token: 0x04000304 RID: 772
	public Shader SCShader;

	// Token: 0x04000305 RID: 773
	public Camera Camera2;

	// Token: 0x04000306 RID: 774
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000307 RID: 775
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000308 RID: 776
	private Material BJFKDHHMLJH;

	// Token: 0x04000309 RID: 777
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400030A RID: 778
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400030B RID: 779
	private RenderTexture JDMCFBKJHDD;
}
