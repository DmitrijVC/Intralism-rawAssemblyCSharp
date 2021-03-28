using System;
using UnityEngine;

// Token: 0x020000C5 RID: 197
[AddComponentMenu("Camera Filter Pack/FX/Drunk2")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Drunk2 : MonoBehaviour
{
	// Token: 0x06003B50 RID: 15184 RVA: 0x0012BB98 File Offset: 0x00129D98
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Noise_TV_3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x0012BBD9 File Offset: 0x00129DD9
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("View ({3}){0} on {1} {2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B54 RID: 15188 RVA: 0x0012BBFD File Offset: 0x00129DFD
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B55 RID: 15189 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06003B58 RID: 15192 RVA: 0x0012BC21 File Offset: 0x00129E21
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("[PowerUp]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B59 RID: 15193 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B5A RID: 15194 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B5B RID: 15195 RVA: 0x0012BC45 File Offset: 0x00129E45
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B5C RID: 15196 RVA: 0x0012BC7C File Offset: 0x00129E7C
	private void HPPMAKHOPBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 177f)
			{
				this.HBJJOCHGOPH = 1015f;
			}
			this.GCDFNHMJMIP().SetFloat(": ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("steamid", this.ADPHJHEFAON);
			this.EMDFHOKEGNG().SetFloat("_ForceYSwap", this.EOKMJCIDCDB);
			this.EGOGECOEONM().SetFloat("cipherText", this.ILHJFHFPGBB);
			this.LMLENGFLEBD().SetFloat("menutheme.27thfloor", this.CCIENBFIKKH);
			this.PGFDGPABBMJ().SetVector("runas", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 1377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B5D RID: 15197 RVA: 0x0012BD7B File Offset: 0x00129F7B
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B5E RID: 15198 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B5F RID: 15199 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B60 RID: 15200 RVA: 0x0012BDB4 File Offset: 0x00129FB4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1076f)
			{
				this.HBJJOCHGOPH = 1645f;
			}
			this.GCDFNHMJMIP().SetFloat("Scene", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("ItemNameText", this.ADPHJHEFAON);
			this.KJMECMIGJJA().SetFloat("SetSatelliteTrailWidth", this.EOKMJCIDCDB);
			this.KJMECMIGJJA().SetFloat("[Up]", this.ILHJFHFPGBB);
			this.KDMBOKLMADJ().SetFloat("_EmissionGain", this.CCIENBFIKKH);
			this.EMDFHOKEGNG().SetVector("_Offset", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 963f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x0012BEB3 File Offset: 0x0012A0B3
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("GhostFade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B63 RID: 15203 RVA: 0x0012BED7 File Offset: 0x0012A0D7
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B64 RID: 15204 RVA: 0x0012BEFB File Offset: 0x0012A0FB
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B65 RID: 15205 RVA: 0x0012BF1F File Offset: 0x0012A11F
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x0012BF43 File Offset: 0x0012A143
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x0012BF7A File Offset: 0x0012A17A
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("PickupItemInit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x0012BFA0 File Offset: 0x0012A1A0
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 137f)
			{
				this.HBJJOCHGOPH = 573f;
			}
			this.ALABBJPHCNG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("VoteDownToggle", this.ADPHJHEFAON);
			this.KDMBOKLMADJ().SetFloat("[EditorEvent] Exception: ", this.EOKMJCIDCDB);
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.OHKGGPFGLFD().SetFloat("settings_bindings_", this.CCIENBFIKKH);
			this.KGOLDDBHIFN().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 324f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06003B6B RID: 15211 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x06003B6C RID: 15212 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B6D RID: 15213 RVA: 0x0012C0A0 File Offset: 0x0012A2A0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1211f)
			{
				this.HBJJOCHGOPH = 585f;
			}
			this.HKHBBBFLGJH().SetFloat("/../", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("<b>HP</b>:", this.ADPHJHEFAON);
			this.DIOAAHJDMLK().SetFloat("_Value2", this.EOKMJCIDCDB);
			this.ALABBJPHCNG().SetFloat("NewMusicFileSelector", this.ILHJFHFPGBB);
			this.OCMBHMLNCEK().SetFloat("menu.playedsolo", this.CCIENBFIKKH);
			this.IKBJACCLPCL().SetVector(" By: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 966f, 269f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGFDGPABBMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x0012C19F File Offset: 0x0012A39F
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B6F RID: 15215 RVA: 0x0012C1D6 File Offset: 0x0012A3D6
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B70 RID: 15216 RVA: 0x0012C210 File Offset: 0x0012A410
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1860f)
			{
				this.HBJJOCHGOPH = 1708f;
			}
			this.EMDFHOKEGNG().SetFloat("#forever", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_PixelsPerMeterAtOneMeter", this.ADPHJHEFAON);
			this.KGOLDDBHIFN().SetFloat("[PlayerController] ", this.EOKMJCIDCDB);
			this.INOBFNCKFGK().SetFloat("_FlipAlphaMask", this.ILHJFHFPGBB);
			this.LMLENGFLEBD().SetFloat(".", this.CCIENBFIKKH);
			this.MJJIEHANFJA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1028f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B71 RID: 15217 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B72 RID: 15218 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06003B73 RID: 15219 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B74 RID: 15220 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B75 RID: 15221 RVA: 0x0012C310 File Offset: 0x0012A510
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1631f)
			{
				this.HBJJOCHGOPH = 1098f;
			}
			this.INOBFNCKFGK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("MapCreationCanvas", this.ADPHJHEFAON);
			this.MCDGIILBNIF().SetFloat("maps.", this.EOKMJCIDCDB);
			this.PHGCJOPFDOG().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.NMDBCDFPGOK().SetFloat("settings_bindings_", this.CCIENBFIKKH);
			this.OHKGGPFGLFD().SetVector("_Bloom0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 32f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B76 RID: 15222 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x0012C410 File Offset: 0x0012A610
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1513f)
			{
				this.HBJJOCHGOPH = 1323f;
			}
			this.KGOLDDBHIFN().SetFloat("_Size", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("[PlayerBase] Config error: musicTime <= 0", this.ADPHJHEFAON);
			this.INOBFNCKFGK().SetFloat("CameraFilterPack_Glasses_On7", this.EOKMJCIDCDB);
			this.LMLENGFLEBD().SetFloat("EventTimeInputField", this.ILHJFHFPGBB);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.CCIENBFIKKH);
			this.LMLENGFLEBD().SetVector("&map=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 261f, 1255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B78 RID: 15224 RVA: 0x0012C50F File Offset: 0x0012A70F
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B79 RID: 15225 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x0012C546 File Offset: 0x0012A746
	private void PCHCFIOHIKK()
	{
		this.SCShader = Shader.Find("Warning: Unhandled event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B7C RID: 15228 RVA: 0x0002523B File Offset: 0x0002343B
	private void MOMHHBKAGKG()
	{
	}

	// Token: 0x06003B7D RID: 15229 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B7E RID: 15230 RVA: 0x0012C56C File Offset: 0x0012A76C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 554f)
			{
				this.HBJJOCHGOPH = 1118f;
			}
			this.DIOAAHJDMLK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.ADPHJHEFAON);
			this.OHKGGPFGLFD().SetFloat("ViewMenu", this.EOKMJCIDCDB);
			this.MCDGIILBNIF().SetFloat("_Colorisation", this.ILHJFHFPGBB);
			this.ALABBJPHCNG().SetFloat("player.gamecompleted", this.CCIENBFIKKH);
			this.OCMBHMLNCEK().SetVector("_Far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1559f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x0012BED7 File Offset: 0x0012A0D7
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B80 RID: 15232 RVA: 0x0012C66B File Offset: 0x0012A86B
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B81 RID: 15233 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x0012C6A2 File Offset: 0x0012A8A2
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x0012C6C6 File Offset: 0x0012A8C6
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06003B87 RID: 15239 RVA: 0x0012C6EA File Offset: 0x0012A8EA
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

	// Token: 0x06003B88 RID: 15240 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B89 RID: 15241 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x0012C724 File Offset: 0x0012A924
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 336f)
			{
				this.HBJJOCHGOPH = 1166f;
			}
			this.IKBJACCLPCL().SetFloat("AvatarImage", this.HBJJOCHGOPH);
			this.EGOGECOEONM().SetFloat("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", this.ADPHJHEFAON);
			this.INOBFNCKFGK().SetFloat("Remove Environment Object", this.EOKMJCIDCDB);
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.ALABBJPHCNG().SetFloat("Most likely the game became empty during the switch to GameServer.", this.CCIENBFIKKH);
			this.IFMAPIDFNLI().SetVector("[GameScene] Checkpoints count: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 271f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B8B RID: 15243 RVA: 0x0012C823 File Offset: 0x0012AA23
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("SetParticlesParticleSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003B8C RID: 15244 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B8D RID: 15245 RVA: 0x0012C848 File Offset: 0x0012AA48
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 736f;
			}
			this.INOBFNCKFGK().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("StartButton", this.ADPHJHEFAON);
			this.MJJIEHANFJA().SetFloat("ItemsCountText", this.EOKMJCIDCDB);
			this.ALABBJPHCNG().SetFloat("masterSteamID", this.ILHJFHFPGBB);
			this.NMDBCDFPGOK().SetFloat("SetParticlesGravity", this.CCIENBFIKKH);
			this.EHDJJANLINB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1149f, 325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B8E RID: 15246 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B8F RID: 15247 RVA: 0x0012C948 File Offset: 0x0012AB48
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 554f)
			{
				this.HBJJOCHGOPH = 177f;
			}
			this.PGFDGPABBMJ().SetFloat("mapselector.filter.officialsortmode", this.HBJJOCHGOPH);
			this.PGFDGPABBMJ().SetFloat("_MainTex2", this.ADPHJHEFAON);
			this.PHGCJOPFDOG().SetFloat("ready", this.EOKMJCIDCDB);
			this.PGFDGPABBMJ().SetFloat("Object ID. Case-Sensitive", this.ILHJFHFPGBB);
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack_Broken_Screen1", this.CCIENBFIKKH);
			this.ALABBJPHCNG().SetVector("[PlayerBase] Checkpoint error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 322f, 1628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B90 RID: 15248 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06003B91 RID: 15249 RVA: 0x0012CA48 File Offset: 0x0012AC48
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 264f)
			{
				this.HBJJOCHGOPH = 953f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_MainTex2", this.ADPHJHEFAON);
			this.KDMBOKLMADJ().SetFloat("_Near", this.EOKMJCIDCDB);
			this.INOBFNCKFGK().SetFloat("NO", this.ILHJFHFPGBB);
			this.PHGCJOPFDOG().SetFloat("PlayersScrollRectContent", this.CCIENBFIKKH);
			this.LMLENGFLEBD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1733f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B92 RID: 15250 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003B93 RID: 15251 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06003B94 RID: 15252 RVA: 0x0012CB48 File Offset: 0x0012AD48
	private void MKFFLJGJMLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 456f)
			{
				this.HBJJOCHGOPH = 1195f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value6", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_NoiseTex", this.ADPHJHEFAON);
			this.IFMAPIDFNLI().SetFloat("Search: ", this.EOKMJCIDCDB);
			this.EHDJJANLINB().SetFloat("_Amount", this.ILHJFHFPGBB);
			this.BLMPMOIDGMG().SetFloat("http", this.CCIENBFIKKH);
			this.ALABBJPHCNG().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1940f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B95 RID: 15253 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06003B97 RID: 15255 RVA: 0x0012CC88 File Offset: 0x0012AE88
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 926f)
			{
				this.HBJJOCHGOPH = 563f;
			}
			this.IKBJACCLPCL().SetFloat("--------------------------------", this.HBJJOCHGOPH);
			this.EGOGECOEONM().SetFloat("skin.hit_wrong", this.ADPHJHEFAON);
			this.EMDFHOKEGNG().SetFloat(": ", this.EOKMJCIDCDB);
			this.MJJIEHANFJA().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.INOBFNCKFGK().SetFloat("The given 2D texture ", this.CCIENBFIKKH);
			this.OHKGGPFGLFD().SetVector("CameraFilterPack/OldFilm_Cutting1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 259f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B98 RID: 15256 RVA: 0x0012CD88 File Offset: 0x0012AF88
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1390f)
			{
				this.HBJJOCHGOPH = 561f;
			}
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_HeightParams", this.ADPHJHEFAON);
			this.KDMBOKLMADJ().SetFloat("_Value3", this.EOKMJCIDCDB);
			this.LMLENGFLEBD().SetFloat("Oct", this.ILHJFHFPGBB);
			this.ALABBJPHCNG().SetFloat("[PlayerController] ", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 927f, 164f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B99 RID: 15257 RVA: 0x0012CE88 File Offset: 0x0012B088
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 299f)
			{
				this.HBJJOCHGOPH = 1552f;
			}
			this.EHDJJANLINB().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("#finished", this.ADPHJHEFAON);
			this.OCMBHMLNCEK().SetFloat("Scene", this.EOKMJCIDCDB);
			this.EHDJJANLINB().SetFloat("#ok", this.ILHJFHFPGBB);
			this.INOBFNCKFGK().SetFloat("_Value2", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 642f, 1562f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B9A RID: 15258 RVA: 0x0012CF87 File Offset: 0x0012B187
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B9B RID: 15259 RVA: 0x0012CFC0 File Offset: 0x0012B1C0
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1644f)
			{
				this.HBJJOCHGOPH = 1437f;
			}
			this.DOMEEFLPEPJ().SetFloat("curScn", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("Object ID. Case-Sensitive", this.ADPHJHEFAON);
			this.MCDGIILBNIF().SetFloat("float,50", this.EOKMJCIDCDB);
			this.EMDFHOKEGNG().SetFloat("Joystick1Button5", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("[MapsData] Workshop maps was loaded", this.CCIENBFIKKH);
			this.IKBJACCLPCL().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1066f, 53f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003B9C RID: 15260 RVA: 0x0012D0BF File Offset: 0x0012B2BF
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003B9D RID: 15261 RVA: 0x0012D0E3 File Offset: 0x0012B2E3
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B9E RID: 15262 RVA: 0x0012D11A File Offset: 0x0012B31A
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003B9F RID: 15263 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06003BA0 RID: 15264 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06003BA1 RID: 15265 RVA: 0x0012D154 File Offset: 0x0012B354
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 471f)
			{
				this.HBJJOCHGOPH = 280f;
			}
			this.INOBFNCKFGK().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_Value4", this.ADPHJHEFAON);
			this.KGOLDDBHIFN().SetFloat("_Value", this.EOKMJCIDCDB);
			this.IKBJACCLPCL().SetFloat("_EmissionColor", this.ILHJFHFPGBB);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.IFMAPIDFNLI().SetVector("Vertical", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 825f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BA2 RID: 15266 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003BA3 RID: 15267 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06003BA4 RID: 15268 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06003BA5 RID: 15269 RVA: 0x0012D254 File Offset: 0x0012B454
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 752f)
			{
				this.HBJJOCHGOPH = 810f;
			}
			this.EHDJJANLINB().SetFloat("/../", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("_Value", this.ADPHJHEFAON);
			this.DIOAAHJDMLK().SetFloat("SpectateButton", this.EOKMJCIDCDB);
			this.INOBFNCKFGK().SetFloat("_Value4", this.ILHJFHFPGBB);
			this.KJMECMIGJJA().SetFloat("_Value2", this.CCIENBFIKKH);
			this.ALABBJPHCNG().SetVector("Preparing content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1689f, 1903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BA6 RID: 15270 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003BA7 RID: 15271 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06003BA8 RID: 15272 RVA: 0x0012D353 File Offset: 0x0012B553
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BA9 RID: 15273 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BAA RID: 15274 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BAB RID: 15275 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x06003BAC RID: 15276 RVA: 0x0012D377 File Offset: 0x0012B577
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find(" url: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BAD RID: 15277 RVA: 0x0012D39B File Offset: 0x0012B59B
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BAE RID: 15278 RVA: 0x0012D3BF File Offset: 0x0012B5BF
	private Material IKBJACCLPCL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BAF RID: 15279 RVA: 0x0012D3F8 File Offset: 0x0012B5F8
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 270f)
			{
				this.HBJJOCHGOPH = 953f;
			}
			this.PGFDGPABBMJ().SetFloat("_Val", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("[ItemsHandler] Item not found:", this.ADPHJHEFAON);
			this.DIOAAHJDMLK().SetFloat("_ScreenResolution", this.EOKMJCIDCDB);
			this.OHKGGPFGLFD().SetFloat("_MainTex2", this.ILHJFHFPGBB);
			this.PHGCJOPFDOG().SetFloat("_Value2", this.CCIENBFIKKH);
			this.NMDBCDFPGOK().SetVector(".lastCheckpoint.playerdistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1126f, 261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BB0 RID: 15280 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BB1 RID: 15281 RVA: 0x0012D4F7 File Offset: 0x0012B6F7
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BB2 RID: 15282 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BB4 RID: 15284 RVA: 0x0012D52E File Offset: 0x0012B72E
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BB5 RID: 15285 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06003BB6 RID: 15286 RVA: 0x0012D565 File Offset: 0x0012B765
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BB7 RID: 15287 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPNKCNJBMKB()
	{
	}

	// Token: 0x06003BB8 RID: 15288 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06003BB9 RID: 15289 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06003BBA RID: 15290 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06003BBB RID: 15291 RVA: 0x0012D59C File Offset: 0x0012B79C
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BBC RID: 15292 RVA: 0x0012D5D3 File Offset: 0x0012B7D3
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWaveManual");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BBD RID: 15293 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BBE RID: 15294 RVA: 0x0012D5F7 File Offset: 0x0012B7F7
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("PhotonMono");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BBF RID: 15295 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BC0 RID: 15296 RVA: 0x0012D61B File Offset: 0x0012B81B
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BC1 RID: 15297 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BC2 RID: 15298 RVA: 0x0012D63F File Offset: 0x0012B83F
	private Material PGFDGPABBMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BC3 RID: 15299 RVA: 0x0012D676 File Offset: 0x0012B876
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BC4 RID: 15300 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06003BC5 RID: 15301 RVA: 0x0012D6AD File Offset: 0x0012B8AD
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Drunk2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BC6 RID: 15302 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06003BC7 RID: 15303 RVA: 0x0012D6D1 File Offset: 0x0012B8D1
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_LowRez");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BC8 RID: 15304 RVA: 0x0012D6F8 File Offset: 0x0012B8F8
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 601f)
			{
				this.HBJJOCHGOPH = 274f;
			}
			this.GCDFNHMJMIP().SetFloat("PhotonView with ID ", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat(".lastCheckpoint.bgcolor", this.ADPHJHEFAON);
			this.INOBFNCKFGK().SetFloat("itemdefid[0]", this.EOKMJCIDCDB);
			this.OHKGGPFGLFD().SetFloat("_Exposure", this.ILHJFHFPGBB);
			this.PHGCJOPFDOG().SetFloat("maps.", this.CCIENBFIKKH);
			this.MICHFGAOPKM().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 498f, 506f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BC9 RID: 15305 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BCB RID: 15307 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BCC RID: 15308 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x0012D7F7 File Offset: 0x0012B9F7
	private void BJNKKNAEGIK()
	{
		this.SCShader = Shader.Find("hidden");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BCE RID: 15310 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06003BCF RID: 15311 RVA: 0x0012D81C File Offset: 0x0012BA1C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1145f)
			{
				this.HBJJOCHGOPH = 976f;
			}
			this.NMDBCDFPGOK().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("maps.", this.ADPHJHEFAON);
			this.PGFDGPABBMJ().SetFloat("_WhiteBalance", this.EOKMJCIDCDB);
			this.IKBJACCLPCL().SetFloat("ViewMenu", this.ILHJFHFPGBB);
			this.KGOLDDBHIFN().SetFloat("[Down]", this.CCIENBFIKKH);
			this.BLMPMOIDGMG().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 319f, 400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BD0 RID: 15312 RVA: 0x0012D91B File Offset: 0x0012BB1B
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BD1 RID: 15313 RVA: 0x0012D954 File Offset: 0x0012BB54
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.ADPHJHEFAON);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BD2 RID: 15314 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BD3 RID: 15315 RVA: 0x0012DA53 File Offset: 0x0012BC53
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("Loading...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BD4 RID: 15316 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x0012DA77 File Offset: 0x0012BC77
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x0012DAB0 File Offset: 0x0012BCB0
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1350f)
			{
				this.HBJJOCHGOPH = 967f;
			}
			this.KJMECMIGJJA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("File not found: {0}", this.ADPHJHEFAON);
			this.IFMAPIDFNLI().SetFloat("_MainTex2", this.EOKMJCIDCDB);
			this.DOMEEFLPEPJ().SetFloat("_Value", this.ILHJFHFPGBB);
			this.JIBOKBCPDLC().SetFloat("z", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector(".sawoutdatedmessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 895f, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BD8 RID: 15320 RVA: 0x0012DBAF File Offset: 0x0012BDAF
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BD9 RID: 15321 RVA: 0x0012DBE6 File Offset: 0x0012BDE6
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BDA RID: 15322 RVA: 0x0012DC1D File Offset: 0x0012BE1D
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BDB RID: 15323 RVA: 0x0012DC54 File Offset: 0x0012BE54
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BDC RID: 15324 RVA: 0x0012BBBC File Offset: 0x00129DBC
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BDD RID: 15325 RVA: 0x0012DC8C File Offset: 0x0012BE8C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 525f)
			{
				this.HBJJOCHGOPH = 408f;
			}
			this.NBPKMLMCHFN.SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_ColorRGB", this.ADPHJHEFAON);
			this.NBPKMLMCHFN.SetFloat("<b>", this.EOKMJCIDCDB);
			this.IKBJACCLPCL().SetFloat("player.licenceaccepted", this.ILHJFHFPGBB);
			this.MCDGIILBNIF().SetFloat("restrictions", this.CCIENBFIKKH);
			this.MCDGIILBNIF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 176f, 1971f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EGOGECOEONM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x0012DD8C File Offset: 0x0012BF8C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 534f)
			{
				this.HBJJOCHGOPH = 1681f;
			}
			this.DIOAAHJDMLK().SetFloat("...", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("Set sun beat detection sensitivity", this.ADPHJHEFAON);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", this.EOKMJCIDCDB);
			this.LMLENGFLEBD().SetFloat("Tab2Content", this.ILHJFHFPGBB);
			this.EHDJJANLINB().SetFloat("PLEASE WAIT", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("Reconnect() disabled the offline mode. No longer offline.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1544f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BDF RID: 15327 RVA: 0x0012DE8C File Offset: 0x0012C08C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1361f)
			{
				this.HBJJOCHGOPH = 1103f;
			}
			this.EGOGECOEONM().SetFloat("_Value", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat(":", this.ADPHJHEFAON);
			this.KGOLDDBHIFN().SetFloat("Tab2Content", this.EOKMJCIDCDB);
			this.LMLENGFLEBD().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.BLMPMOIDGMG().SetFloat("inventory.selected.", this.CCIENBFIKKH);
			this.INOBFNCKFGK().SetVector("shader.none", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1392f, 1436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BE0 RID: 15328 RVA: 0x0012DF8C File Offset: 0x0012C18C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1861f)
			{
				this.HBJJOCHGOPH = 1317f;
			}
			this.HKHBBBFLGJH().SetFloat("SubmitUserVote:", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_CurrentMipLevel", this.ADPHJHEFAON);
			this.PGFDGPABBMJ().SetFloat("win", this.EOKMJCIDCDB);
			this.NMDBCDFPGOK().SetFloat("BloodAlternative2", this.ILHJFHFPGBB);
			this.PGFDGPABBMJ().SetFloat("DPADVER", this.CCIENBFIKKH);
			this.MICHFGAOPKM().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 782f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BE1 RID: 15329 RVA: 0x0012E08C File Offset: 0x0012C28C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 165f)
			{
				this.HBJJOCHGOPH = 1495f;
			}
			this.LMLENGFLEBD().SetFloat("SetTrailZoomSpeed", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("SetSunColors", this.ADPHJHEFAON);
			this.IKBJACCLPCL().SetFloat("mapselector.filter.subscribedonly", this.EOKMJCIDCDB);
			this.ALABBJPHCNG().SetFloat("_Value2", this.ILHJFHFPGBB);
			this.PHGCJOPFDOG().SetFloat("Set Particles Speed", this.CCIENBFIKKH);
			this.PGFDGPABBMJ().SetVector("Hidden/DepthOfField/DepthOfField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1566f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EGOGECOEONM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x0012E18C File Offset: 0x0012C38C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 783f)
			{
				this.HBJJOCHGOPH = 481f;
			}
			this.PGFDGPABBMJ().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("inventory.selected.", this.ADPHJHEFAON);
			this.NMDBCDFPGOK().SetFloat("settings.showHP", this.EOKMJCIDCDB);
			this.IKBJACCLPCL().SetFloat("inventory.selected.", this.ILHJFHFPGBB);
			this.LMLENGFLEBD().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", this.CCIENBFIKKH);
			this.PHGCJOPFDOG().SetVector("#failed: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1082f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x0012E28B File Offset: 0x0012C48B
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BE4 RID: 15332 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJLAAKJHBIM()
	{
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06003BE6 RID: 15334 RVA: 0x0012E2C2 File Offset: 0x0012C4C2
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find(".jpg");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BE7 RID: 15335 RVA: 0x0012E2E6 File Offset: 0x0012C4E6
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_Red_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003BE8 RID: 15336 RVA: 0x0012E30A File Offset: 0x0012C50A
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BE9 RID: 15337 RVA: 0x0012E341 File Offset: 0x0012C541
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BEA RID: 15338 RVA: 0x0012E368 File Offset: 0x0012C568
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 217f)
			{
				this.HBJJOCHGOPH = 188f;
			}
			this.IKBJACCLPCL().SetFloat("init", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_ForegroundBlurExtrude", this.ADPHJHEFAON);
			this.JIBOKBCPDLC().SetFloat("_Saturation", this.EOKMJCIDCDB);
			this.KGOLDDBHIFN().SetFloat("hardcoreinfo", this.ILHJFHFPGBB);
			this.DIOAAHJDMLK().SetFloat("_Value3", this.CCIENBFIKKH);
			this.EGOGECOEONM().SetVector("Default UI Material", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 472f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BEB RID: 15339 RVA: 0x0012E468 File Offset: 0x0012C668
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 920f)
			{
				this.HBJJOCHGOPH = 655f;
			}
			this.KGOLDDBHIFN().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_Red_B", this.ADPHJHEFAON);
			this.MCDGIILBNIF().SetFloat("_Blue_G", this.EOKMJCIDCDB);
			this.EHDJJANLINB().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.LMLENGFLEBD().SetFloat("_Value10", this.CCIENBFIKKH);
			this.EHDJJANLINB().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 354f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000687 RID: 1671
	public Shader SCShader;

	// Token: 0x04000688 RID: 1672
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000689 RID: 1673
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400068A RID: 1674
	private Material BJFKDHHMLJH;

	// Token: 0x0400068B RID: 1675
	[Range(0f, 10f)]
	private float ADPHJHEFAON = 1f;

	// Token: 0x0400068C RID: 1676
	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	// Token: 0x0400068D RID: 1677
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x0400068E RID: 1678
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
