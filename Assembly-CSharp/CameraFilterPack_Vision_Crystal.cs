using System;
using UnityEngine;

// Token: 0x02000133 RID: 307
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Crystal")]
public class CameraFilterPack_Vision_Crystal : MonoBehaviour
{
	// Token: 0x0600612A RID: 24874 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKIMDFLBFOM()
	{
	}

	// Token: 0x0600612B RID: 24875 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600612C RID: 24876 RVA: 0x001D8C8C File Offset: 0x001D6E8C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 641f)
			{
				this.HBJJOCHGOPH = 49f;
			}
			this.NBPKMLMCHFN.SetFloat("HitInRelaxMusicToggle", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("menu.enableselectormusic", this.Value);
			this.KBOPGONOCNP().SetFloat("Scene", this.X);
			this.IIBLJCKLGFG().SetFloat("source", this.Y);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 943f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600612D RID: 24877 RVA: 0x001D8D8C File Offset: 0x001D6F8C
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1975f)
			{
				this.HBJJOCHGOPH = 389f;
			}
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Gradients_Tech", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("</size>", this.Value);
			this.MICHFGAOPKM().SetFloat("Joystick1Button5", this.X);
			this.KBOPGONOCNP().SetFloat("[LevelEditorScene] Error: Timeout :S", this.Y);
			this.IIBLJCKLGFG().SetFloat("BadgeText", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 891f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600612E RID: 24878 RVA: 0x001D8E8B File Offset: 0x001D708B
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600612F RID: 24879 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEPLFGKGLI()
	{
	}

	// Token: 0x06006130 RID: 24880 RVA: 0x001D8EC2 File Offset: 0x001D70C2
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006131 RID: 24881 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006132 RID: 24882 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06006133 RID: 24883 RVA: 0x001D8EF9 File Offset: 0x001D70F9
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

	// Token: 0x06006134 RID: 24884 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06006135 RID: 24885 RVA: 0x001D8F30 File Offset: 0x001D7130
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 627f)
			{
				this.HBJJOCHGOPH = 1763f;
			}
			this.DEFBJOCJJKF().SetFloat("NO", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("stretchWidth", this.Value);
			this.OIMMPLPBLBK().SetFloat("Run a command for data system", this.X);
			this.IIBLJCKLGFG().SetFloat("Tab1Content", this.Y);
			this.KBOPGONOCNP().SetFloat("Failed to InstantiateSceneObject prefab: ", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("CameraFilterPack/Blur_Steam", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 704f, 392f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006136 RID: 24886 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006137 RID: 24887 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMPGIFBJFIK()
	{
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x001D9030 File Offset: 0x001D7230
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 942f;
			}
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Ascii", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat(" base map(s)", this.Value);
			this.OIMMPLPBLBK().SetFloat("#91CCFF", this.X);
			this.KBOPGONOCNP().SetFloat("_Value2", this.Y);
			this.KBOPGONOCNP().SetFloat(" while connecting to: ", this.CCIENBFIKKH);
			this.MICHFGAOPKM().SetVector("fade out duration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 416f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600613B RID: 24891 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600613C RID: 24892 RVA: 0x001D912F File Offset: 0x001D732F
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600613D RID: 24893 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x001D9168 File Offset: 0x001D7368
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 247f)
			{
				this.HBJJOCHGOPH = 1919f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value7", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("maps.", this.Value);
			this.IIBLJCKLGFG().SetFloat("MapEditorScene", this.X);
			this.MICHFGAOPKM().SetFloat(" = ", this.Y);
			this.OIMMPLPBLBK().SetFloat("IconImage", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1865f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006140 RID: 24896 RVA: 0x001D9268 File Offset: 0x001D7468
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 728f)
			{
				this.HBJJOCHGOPH = 2f;
			}
			this.IIBLJCKLGFG().SetFloat("achievements.21.progress", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this.Value);
			this.NBPKMLMCHFN.SetFloat(".sav", this.X);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/TV_Vignetting", this.Y);
			this.OIMMPLPBLBK().SetFloat("cipherText", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector(" SecondsBeforeRespawn: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 3f, 1843f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006141 RID: 24897 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006142 RID: 24898 RVA: 0x0002523B File Offset: 0x0002343B
	private void DIPDEHOOBPG()
	{
	}

	// Token: 0x06006143 RID: 24899 RVA: 0x001D9367 File Offset: 0x001D7567
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006144 RID: 24900 RVA: 0x001D93A0 File Offset: 0x001D75A0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 856f)
			{
				this.HBJJOCHGOPH = 278f;
			}
			this.MICHFGAOPKM().SetFloat("Image effects aren't supported on this device ({0})", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat(" ", this.Value);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.X);
			this.IIBLJCKLGFG().SetFloat("[PlayerBase] Reset", this.Y);
			this.OIMMPLPBLBK().SetFloat("PointsScoreText", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("restrictions\n\n#until: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 15f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006145 RID: 24901 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCCIEMBMOBA()
	{
	}

	// Token: 0x06006146 RID: 24902 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06006147 RID: 24903 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006148 RID: 24904 RVA: 0x001D94A0 File Offset: 0x001D76A0
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 265f)
			{
				this.HBJJOCHGOPH = 1322f;
			}
			this.OIMMPLPBLBK().SetFloat("/Segment-[Down]", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("MenuRecordButton", this.Value);
			this.IIBLJCKLGFG().SetFloat("_Value5", this.X);
			this.DEFBJOCJJKF().SetFloat(".completed", this.Y);
			this.DEFBJOCJJKF().SetFloat("_EmissionColor", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1843f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006149 RID: 24905 RVA: 0x001D95A0 File Offset: 0x001D77A0
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1413f)
			{
				this.HBJJOCHGOPH = 878f;
			}
			this.NBPKMLMCHFN.SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Value6", this.Value);
			this.NBPKMLMCHFN.SetFloat("PopulateMapsList", this.X);
			this.KBOPGONOCNP().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.Y);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack_Glasses_On4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1381f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600614A RID: 24906 RVA: 0x0002523B File Offset: 0x0002343B
	private void NPLCENPNJBM()
	{
	}

	// Token: 0x0600614B RID: 24907 RVA: 0x0002523B File Offset: 0x0002343B
	private void PMPKMGKAAJH()
	{
	}

	// Token: 0x0600614C RID: 24908 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600614D RID: 24909 RVA: 0x001D96A0 File Offset: 0x001D78A0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.X);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Y);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600614E RID: 24910 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600614F RID: 24911 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006150 RID: 24912 RVA: 0x001D97A0 File Offset: 0x001D79A0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1702f)
			{
				this.HBJJOCHGOPH = 1544f;
			}
			this.IIBLJCKLGFG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_History4LumaTex", this.Value);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.X);
			this.NBPKMLMCHFN.SetFloat(".sav", this.Y);
			this.OIMMPLPBLBK().SetFloat("RemoveEnvironmentObject", this.CCIENBFIKKH);
			this.IIBLJCKLGFG().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 376f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006151 RID: 24913 RVA: 0x001D989F File Offset: 0x001D7A9F
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006152 RID: 24914 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06006153 RID: 24915 RVA: 0x0002523B File Offset: 0x0002343B
	private void FHPFJBFCOOF()
	{
	}

	// Token: 0x06006154 RID: 24916 RVA: 0x0002523B File Offset: 0x0002343B
	private void IMCKJCHKMKB()
	{
	}

	// Token: 0x06006155 RID: 24917 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06006156 RID: 24918 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06006157 RID: 24919 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006158 RID: 24920 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06006159 RID: 24921 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600615A RID: 24922 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600615B RID: 24923 RVA: 0x001D98D8 File Offset: 0x001D7AD8
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 1239f;
			}
			this.KBOPGONOCNP().SetFloat("\" for viewID ", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("offsets", this.Value);
			this.DEFBJOCJJKF().SetFloat("_Value", this.X);
			this.DEFBJOCJJKF().SetFloat("settings.arcsnohitsoundtimedelay", this.Y);
			this.IIBLJCKLGFG().SetFloat("tagElement", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("Items/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1682f, 721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600615C RID: 24924 RVA: 0x001D99D8 File Offset: 0x001D7BD8
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1368f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_Blue_B", this.Value);
			this.KBOPGONOCNP().SetFloat("Vignette", this.X);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Y);
			this.KBOPGONOCNP().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("settings.hideui", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1731f, 156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600615D RID: 24925 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600615E RID: 24926 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDMANOEMOCA()
	{
	}

	// Token: 0x0600615F RID: 24927 RVA: 0x001D8C6F File Offset: 0x001D6E6F
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006160 RID: 24928 RVA: 0x0002523B File Offset: 0x0002343B
	private void JKFDDNMPOJH()
	{
	}

	// Token: 0x06006161 RID: 24929 RVA: 0x001D9AD8 File Offset: 0x001D7CD8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1528f)
			{
				this.HBJJOCHGOPH = 1919f;
			}
			this.IIBLJCKLGFG().SetFloat("BadgeText", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Distortion", this.Value);
			this.MICHFGAOPKM().SetFloat("<b>", this.X);
			this.OIMMPLPBLBK().SetFloat("[EMPTY]", this.Y);
			this.NBPKMLMCHFN.SetFloat("menu.selectedplaymode", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Colors_HUE_Rotate", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1285f, 1783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040009C5 RID: 2501
	public Shader SCShader;

	// Token: 0x040009C6 RID: 2502
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009C7 RID: 2503
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009C8 RID: 2504
	private Material BJFKDHHMLJH;

	// Token: 0x040009C9 RID: 2505
	[Range(-10f, 10f)]
	public float Value = 1f;

	// Token: 0x040009CA RID: 2506
	[Range(-1f, 1f)]
	public float X = 1f;

	// Token: 0x040009CB RID: 2507
	[Range(-1f, 1f)]
	public float Y = 1f;

	// Token: 0x040009CC RID: 2508
	[Range(-1f, 1f)]
	private float CCIENBFIKKH = 1f;
}
