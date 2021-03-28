using System;
using UnityEngine;

// Token: 0x02000080 RID: 128
[AddComponentMenu("Camera Filter Pack/Colors/NewPosterize")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_NewPosterize : MonoBehaviour
{
	// Token: 0x06002407 RID: 9223 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000CFA5C File Offset: 0x000CDC5C
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1932f)
			{
				this.HBJJOCHGOPH = 1520f;
			}
			this.EHDJJANLINB().SetFloat(" beatThreshold: ", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("maps.", this.Gamma);
			this.NDMPCDHADMJ().SetFloat("HightScoreMaxPointsText", this.Colors);
			this.KAFBNOBOIAJ().SetFloat("VoteDownToggle", this.Green_Mod);
			this.ABHDNGIHBKE().SetFloat("<color=#{0}>{1}</color>", this.CCIENBFIKKH);
			this.EPCGJFCCAFH().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1951f, 1802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000CFB5B File Offset: 0x000CDD5B
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000CFBBE File Offset: 0x000CDDBE
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000CFBE2 File Offset: 0x000CDDE2
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000CFC19 File Offset: 0x000CDE19
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find(" canvas not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000CFC3D File Offset: 0x000CDE3D
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000CFC74 File Offset: 0x000CDE74
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x000CFCAB File Offset: 0x000CDEAB
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000CFCE2 File Offset: 0x000CDEE2
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000CFD19 File Offset: 0x000CDF19
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000CFD50 File Offset: 0x000CDF50
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("mapselector.filter.officialsortmode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000CFD74 File Offset: 0x000CDF74
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x000CFDAB File Offset: 0x000CDFAB
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("Left ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x000CFDCF File Offset: 0x000CDFCF
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x000CFE06 File Offset: 0x000CE006
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000CFE2A File Offset: 0x000CE02A
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("SetRotation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000CFE50 File Offset: 0x000CE050
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1171f;
			}
			this.DOHGBNPMBKG().SetFloat("#accuracy", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("menu.selectedlevelid", this.Gamma);
			this.HNICHJCGJOC().SetFloat("MapEnd", this.Colors);
			this.DKKBFFHBHJE().SetFloat("_ScreenResolution", this.Green_Mod);
			this.HNICHJCGJOC().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", this.CCIENBFIKKH);
			this.KJMECMIGJJA().SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 508f, 1238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000CFF50 File Offset: 0x000CE150
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 391f)
			{
				this.HBJJOCHGOPH = 53f;
			}
			this.DOHGBNPMBKG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Value", this.Gamma);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Colors);
			this.KOHGPKOFEJO().SetFloat("stats on", this.Green_Mod);
			this.HNICHJCGJOC().SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 443f, 1367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000D0050 File Offset: 0x000CE250
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 623f)
			{
				this.HBJJOCHGOPH = 244f;
			}
			this.DKNJGHFLAIF().SetFloat(".completed", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value", this.Gamma);
			this.KJMECMIGJJA().SetFloat(".lastCheckpoint.maxLongestCombo", this.Colors);
			this.EPCGJFCCAFH().SetFloat("PlayMusic", this.Green_Mod);
			this.KOHGPKOFEJO().SetFloat("System.Boolean", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("BadgeText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1348f, 43f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000D0150 File Offset: 0x000CE350
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1893f)
			{
				this.HBJJOCHGOPH = 446f;
			}
			this.HNICHJCGJOC().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("Environment/SunBase_", this.Gamma);
			this.NDMPCDHADMJ().SetFloat("ComboScoreText", this.Colors);
			this.ABHDNGIHBKE().SetFloat("Editor/", this.Green_Mod);
			this.KAFBNOBOIAJ().SetFloat("Rtt:{0,4} +/-{1,3}", this.CCIENBFIKKH);
			this.HNICHJCGJOC().SetVector("Checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1743f, 334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000D0250 File Offset: 0x000CE450
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1925f)
			{
				this.HBJJOCHGOPH = 1743f;
			}
			this.KOHGPKOFEJO().SetFloat("maps.", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this.Gamma);
			this.HNICHJCGJOC().SetFloat("GlassesColor", this.Colors);
			this.MCDGIILBNIF().SetFloat("#pleasewait", this.Green_Mod);
			this.ABHDNGIHBKE().SetFloat("Adreno", this.CCIENBFIKKH);
			this.KJMECMIGJJA().SetVector("Items/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1208f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000D034F File Offset: 0x000CE54F
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000D0386 File Offset: 0x000CE586
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000D03C0 File Offset: 0x000CE5C0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 385f)
			{
				this.HBJJOCHGOPH = 974f;
			}
			this.KAFBNOBOIAJ().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("Could not find RPC with index: ", this.Gamma);
			this.NDMPCDHADMJ().SetFloat("[MapsData] Found ", this.Colors);
			this.EHDJJANLINB().SetFloat("colorD", this.Green_Mod);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.CCIENBFIKKH);
			this.BKKJJJGADLM().SetVector("_EdgeSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 647f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x000D04BF File Offset: 0x000CE6BF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_NewPosterize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x000D04E4 File Offset: 0x000CE6E4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1956f)
			{
				this.HBJJOCHGOPH = 874f;
			}
			this.FAIFBBGFAIB().SetFloat("RootCanvas", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("ConnectionTimeout", this.Gamma);
			this.KJMECMIGJJA().SetFloat("FinalScoreSmallText", this.Colors);
			this.KJMECMIGJJA().SetFloat("file://", this.Green_Mod);
			this.DKKBFFHBHJE().SetFloat(".completed", this.CCIENBFIKKH);
			this.DKKBFFHBHJE().SetVector("</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 634f, 686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x000D05E3 File Offset: 0x000CE7E3
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Error: I/O Failure! :(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000D0607 File Offset: 0x000CE807
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("Set Sun Input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000D062B File Offset: 0x000CE82B
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000D0664 File Offset: 0x000CE864
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1148f)
			{
				this.HBJJOCHGOPH = 1235f;
			}
			this.CFEDGDGBCHE().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", this.Gamma);
			this.BKKJJJGADLM().SetFloat("value", this.Colors);
			this.BKKJJJGADLM().SetFloat("OnPressRight", this.Green_Mod);
			this.FAIFBBGFAIB().SetFloat("x", this.CCIENBFIKKH);
			this.DKKBFFHBHJE().SetVector("Player", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 648f, 1627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x000D0764 File Offset: 0x000CE964
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 113f)
			{
				this.HBJJOCHGOPH = 1489f;
			}
			this.KJMECMIGJJA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Text", this.Gamma);
			this.BKKJJJGADLM().SetFloat("RecieveChatActionMessage", this.Colors);
			this.KAFBNOBOIAJ().SetFloat("_Offsets", this.Green_Mod);
			this.NBPKMLMCHFN.SetFloat("Connection failed: ", this.CCIENBFIKKH);
			this.ADGHJOHKEHG().SetVector("ItemNameBGImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000D0864 File Offset: 0x000CEA64
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1458f)
			{
				this.HBJJOCHGOPH = 368f;
			}
			this.NDMPCDHADMJ().SetFloat(".lastCheckpoint.checkpointsUsed", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("SfxVolumeSlider", this.Gamma);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.Colors);
			this.ADGHJOHKEHG().SetFloat("Drop_With_Obj", this.Green_Mod);
			this.KAFBNOBOIAJ().SetFloat("_Value2", this.CCIENBFIKKH);
			this.ADGHJOHKEHG().SetVector("SaveButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1911f, 114f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000D0964 File Offset: 0x000CEB64
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Gamma);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Colors);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Green_Mod);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000D0A64 File Offset: 0x000CEC64
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1167f)
			{
				this.HBJJOCHGOPH = 1286f;
			}
			this.ABHDNGIHBKE().SetFloat("x", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_Intensity", this.Gamma);
			this.EHDJJANLINB().SetFloat("_TimeX", this.Colors);
			this.FAIFBBGFAIB().SetFloat("maps.", this.Green_Mod);
			this.ABHDNGIHBKE().SetFloat("HightScoreMaxPointsText", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 857f, 1468f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000D0B63 File Offset: 0x000CED63
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000D0B87 File Offset: 0x000CED87
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Editing: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000D0BAC File Offset: 0x000CEDAC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 740f)
			{
				this.HBJJOCHGOPH = 1426f;
			}
			this.DKNJGHFLAIF().SetFloat("<b>Max Score</b>:", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("/", this.Gamma);
			this.CFEDGDGBCHE().SetFloat("z", this.Colors);
			this.KJMECMIGJJA().SetFloat("_ScreenResolution", this.Green_Mod);
			this.KAFBNOBOIAJ().SetFloat(".sav", this.CCIENBFIKKH);
			this.NJDIODJNGGA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1995f, 883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000D0CAB File Offset: 0x000CEEAB
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x000D0CD0 File Offset: 0x000CEED0
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1361f)
			{
				this.HBJJOCHGOPH = 1637f;
			}
			this.KOHGPKOFEJO().SetFloat("_MatrixSpeed", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("note.3", this.Gamma);
			this.ADGHJOHKEHG().SetFloat("[UI] Unknows button action: ", this.Colors);
			this.ADGHJOHKEHG().SetFloat("_DiffuseColor", this.Green_Mod);
			this.BKKJJJGADLM().SetFloat("skin.", this.CCIENBFIKKH);
			this.CFEDGDGBCHE().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 782f, 789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x000D0DCF File Offset: 0x000CEFCF
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000D0DF3 File Offset: 0x000CEFF3
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000D0E18 File Offset: 0x000CF018
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 148f)
			{
				this.HBJJOCHGOPH = 102f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Distance", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.Gamma);
			this.DKKBFFHBHJE().SetFloat("_Value", this.Colors);
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.Green_Mod);
			this.KOHGPKOFEJO().SetFloat("[EMPTY]", this.CCIENBFIKKH);
			this.CFEDGDGBCHE().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1048f, 1212f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000D0F18 File Offset: 0x000CF118
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 610f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.BKKJJJGADLM().SetFloat("set", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TargetScale", this.Gamma);
			this.ADGHJOHKEHG().SetFloat("_Value2", this.Colors);
			this.ADGHJOHKEHG().SetFloat("_Gain", this.Green_Mod);
			this.NJDIODJNGGA().SetFloat("/../", this.CCIENBFIKKH);
			this.KEMAALEODNH().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1695f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x000D0DCF File Offset: 0x000CEFCF
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000D1017 File Offset: 0x000CF217
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000D104E File Offset: 0x000CF24E
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x000D1072 File Offset: 0x000CF272
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x000D10A9 File Offset: 0x000CF2A9
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x000D10E0 File Offset: 0x000CF2E0
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06002453 RID: 9299 RVA: 0x000D1117 File Offset: 0x000CF317
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

	// Token: 0x06002454 RID: 9300 RVA: 0x000D114E File Offset: 0x000CF34E
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_SizeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000D1174 File Offset: 0x000CF374
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1381f)
			{
				this.HBJJOCHGOPH = 528f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.Gamma);
			this.KJMECMIGJJA().SetFloat("_Value10", this.Colors);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Color_RGB", this.Green_Mod);
			this.HNICHJCGJOC().SetFloat("Set Satellite Emission", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1136f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x000D1274 File Offset: 0x000CF474
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 947f)
			{
				this.HBJJOCHGOPH = 1044f;
			}
			this.KOHGPKOFEJO().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Fade", this.Gamma);
			this.NJDIODJNGGA().SetFloat("x", this.Colors);
			this.HNICHJCGJOC().SetFloat("Screen Space Reflections", this.Green_Mod);
			this.ADGHJOHKEHG().SetFloat("float", this.CCIENBFIKKH);
			this.KEMAALEODNH().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 103f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002457 RID: 9303 RVA: 0x000D1373 File Offset: 0x000CF573
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002458 RID: 9304 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002459 RID: 9305 RVA: 0x000D13AC File Offset: 0x000CF5AC
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 164f)
			{
				this.HBJJOCHGOPH = 994f;
			}
			this.EHDJJANLINB().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("EventData0DropDownList", this.Gamma);
			this.NJDIODJNGGA().SetFloat("[NetworkManager] Updating rooms...", this.Colors);
			this.KEMAALEODNH().SetFloat("AvatarImage", this.Green_Mod);
			this.MCDGIILBNIF().SetFloat("/icon", this.CCIENBFIKKH);
			this.KOHGPKOFEJO().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 354f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600245A RID: 9306 RVA: 0x000D14AB File Offset: 0x000CF6AB
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600245B RID: 9307 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x0600245C RID: 9308 RVA: 0x000D14E2 File Offset: 0x000CF6E2
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600245D RID: 9309 RVA: 0x000CFA3E File Offset: 0x000CDC3E
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040004A9 RID: 1193
	public Shader SCShader;

	// Token: 0x040004AA RID: 1194
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004AB RID: 1195
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004AC RID: 1196
	private Material BJFKDHHMLJH;

	// Token: 0x040004AD RID: 1197
	[Range(0f, 2f)]
	public float Gamma = 1f;

	// Token: 0x040004AE RID: 1198
	[Range(0f, 16f)]
	public float Colors = 11f;

	// Token: 0x040004AF RID: 1199
	[Range(-1f, 1f)]
	public float Green_Mod = 1f;

	// Token: 0x040004B0 RID: 1200
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
