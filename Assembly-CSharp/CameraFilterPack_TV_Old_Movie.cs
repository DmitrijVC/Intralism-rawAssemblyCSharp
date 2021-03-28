using System;
using UnityEngine;

// Token: 0x0200011D RID: 285
[AddComponentMenu("Camera Filter Pack/Old Film/Old_Movie")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Old_Movie : MonoBehaviour
{
	// Token: 0x06005955 RID: 22869 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06005956 RID: 22870 RVA: 0x001BAC64 File Offset: 0x001B8E64
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("Authentication failed: '{0}' Code: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005957 RID: 22871 RVA: 0x001BAC88 File Offset: 0x001B8E88
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 1859f;
			}
			this.DEFBJOCJJKF().SetFloat(" (", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Indie", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005958 RID: 22872 RVA: 0x001BAD18 File Offset: 0x001B8F18
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005959 RID: 22873 RVA: 0x001BAD3C File Offset: 0x001B8F3C
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 65f;
			}
			this.CFCPHFMKHII().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("MenuScene", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600595A RID: 22874 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x0600595B RID: 22875 RVA: 0x001BADCC File Offset: 0x001B8FCC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 824f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			this.DKNJGHFLAIF().SetFloat("SaveButton", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("x", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600595C RID: 22876 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600595D RID: 22877 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x0600595E RID: 22878 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600595F RID: 22879 RVA: 0x001BAE79 File Offset: 0x001B9079
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005960 RID: 22880 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005961 RID: 22881 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005962 RID: 22882 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06005963 RID: 22883 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005964 RID: 22884 RVA: 0x001BAEA0 File Offset: 0x001B90A0
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 1168f;
			}
			this.EMDFHOKEGNG().SetFloat("Send", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("ArcsDestroyDelaySlider", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06005965 RID: 22885 RVA: 0x001BAF30 File Offset: 0x001B9130
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

	// Token: 0x06005966 RID: 22886 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005967 RID: 22887 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06005968 RID: 22888 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06005969 RID: 22889 RVA: 0x001BAF67 File Offset: 0x001B9167
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600596A RID: 22890 RVA: 0x001BAF9E File Offset: 0x001B919E
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600596B RID: 22891 RVA: 0x001BAFC2 File Offset: 0x001B91C2
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600596C RID: 22892 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600596D RID: 22893 RVA: 0x001BAFE6 File Offset: 0x001B91E6
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600596E RID: 22894 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x0600596F RID: 22895 RVA: 0x001BB00A File Offset: 0x001B920A
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005970 RID: 22896 RVA: 0x001BB02E File Offset: 0x001B922E
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005971 RID: 22897 RVA: 0x001BB065 File Offset: 0x001B9265
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005972 RID: 22898 RVA: 0x001BB09C File Offset: 0x001B929C
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005973 RID: 22899 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005974 RID: 22900 RVA: 0x001BB0C0 File Offset: 0x001B92C0
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005975 RID: 22901 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005976 RID: 22902 RVA: 0x001BB0F7 File Offset: 0x001B92F7
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005977 RID: 22903 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06005978 RID: 22904 RVA: 0x001BB130 File Offset: 0x001B9330
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1237f)
			{
				this.HBJJOCHGOPH = 1593f;
			}
			this.CFCPHFMKHII().SetFloat("roomDescription", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_Value5", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005979 RID: 22905 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600597A RID: 22906 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x0600597B RID: 22907 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x0600597C RID: 22908 RVA: 0x001BB1C0 File Offset: 0x001B93C0
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600597D RID: 22909 RVA: 0x001BB1E4 File Offset: 0x001B93E4
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 215f)
			{
				this.HBJJOCHGOPH = 1998f;
			}
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("Bad parameters for setint! Use <key> <value>", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600597E RID: 22910 RVA: 0x001BB274 File Offset: 0x001B9474
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600597F RID: 22911 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06005980 RID: 22912 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005981 RID: 22913 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06005982 RID: 22914 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06005983 RID: 22915 RVA: 0x001BB2AB File Offset: 0x001B94AB
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005984 RID: 22916 RVA: 0x001BB2E4 File Offset: 0x001B94E4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 390f)
			{
				this.HBJJOCHGOPH = 1319f;
			}
			this.FGENHBKMPDA().SetFloat(" ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("[SERVER] Player ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005985 RID: 22917 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06005986 RID: 22918 RVA: 0x001BB374 File Offset: 0x001B9574
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005987 RID: 22919 RVA: 0x001BB398 File Offset: 0x001B9598
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 250f)
			{
				this.HBJJOCHGOPH = 537f;
			}
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_RampTex", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005988 RID: 22920 RVA: 0x001BB428 File Offset: 0x001B9628
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("score:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005989 RID: 22921 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600598A RID: 22922 RVA: 0x001BB44C File Offset: 0x001B964C
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600598B RID: 22923 RVA: 0x001BB484 File Offset: 0x001B9684
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1339f)
			{
				this.HBJJOCHGOPH = 315f;
			}
			this.FHFLKLMFHOI().SetFloat(">", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_Value2", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600598C RID: 22924 RVA: 0x001BB514 File Offset: 0x001B9714
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600598D RID: 22925 RVA: 0x001BB54C File Offset: 0x001B974C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 674f)
			{
				this.HBJJOCHGOPH = 1036f;
			}
			this.PHGCJOPFDOG().SetFloat(" x ", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_DotSize", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600598E RID: 22926 RVA: 0x001BB5DC File Offset: 0x001B97DC
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 340f;
			}
			this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_Value3", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600598F RID: 22927 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06005990 RID: 22928 RVA: 0x001BB66C File Offset: 0x001B986C
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005991 RID: 22929 RVA: 0x001BB690 File Offset: 0x001B9890
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005992 RID: 22930 RVA: 0x001BB6C7 File Offset: 0x001B98C7
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005993 RID: 22931 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06005994 RID: 22932 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005995 RID: 22933 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005996 RID: 22934 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005997 RID: 22935 RVA: 0x001BB6FE File Offset: 0x001B98FE
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005998 RID: 22936 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005999 RID: 22937 RVA: 0x001BB735 File Offset: 0x001B9935
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600599A RID: 22938 RVA: 0x001BB76C File Offset: 0x001B996C
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_copy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600599B RID: 22939 RVA: 0x001BB790 File Offset: 0x001B9990
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 473f)
			{
				this.HBJJOCHGOPH = 1237f;
			}
			this.AELJLBOJAIL().SetFloat("_Value", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Set camera background color", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600599C RID: 22940 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x0600599D RID: 22941 RVA: 0x001BB820 File Offset: 0x001B9A20
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600599E RID: 22942 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600599F RID: 22943 RVA: 0x001BB857 File Offset: 0x001B9A57
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("float,10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060059A0 RID: 22944 RVA: 0x001BB0F7 File Offset: 0x001B92F7
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059A1 RID: 22945 RVA: 0x001BB87B File Offset: 0x001B9A7B
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059A2 RID: 22946 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060059A3 RID: 22947 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059A4 RID: 22948 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059A5 RID: 22949 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060059A9 RID: 22953 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060059AA RID: 22954 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060059AB RID: 22955 RVA: 0x001BB8B2 File Offset: 0x001B9AB2
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x001BB8D8 File Offset: 0x001B9AD8
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1680f)
			{
				this.HBJJOCHGOPH = 1714f;
			}
			this.LMLENGFLEBD().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat(".played", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059AE RID: 22958 RVA: 0x001BB968 File Offset: 0x001B9B68
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1726f)
			{
				this.HBJJOCHGOPH = 1989f;
			}
			this.GJHPODJOBHL().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("score", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059AF RID: 22959 RVA: 0x001BB9F8 File Offset: 0x001B9BF8
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059B0 RID: 22960 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059B1 RID: 22961 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059B2 RID: 22962 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060059B3 RID: 22963 RVA: 0x001BBA30 File Offset: 0x001B9C30
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1674f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.JIBOKBCPDLC().SetFloat("settings.volume.sfx", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_Level", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059B4 RID: 22964 RVA: 0x001BBAC0 File Offset: 0x001B9CC0
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059B5 RID: 22965 RVA: 0x001BBAF8 File Offset: 0x001B9CF8
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059B6 RID: 22966 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059B7 RID: 22967 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059B8 RID: 22968 RVA: 0x001BBB88 File Offset: 0x001B9D88
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 416f)
			{
				this.HBJJOCHGOPH = 132f;
			}
			this.DKNJGHFLAIF().SetFloat(",", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("SfxVolumeSlider", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059B9 RID: 22969 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060059BA RID: 22970 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059BB RID: 22971 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060059BC RID: 22972 RVA: 0x001BBC18 File Offset: 0x001B9E18
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060059BE RID: 22974 RVA: 0x001BBC70 File Offset: 0x001B9E70
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1450f)
			{
				this.HBJJOCHGOPH = 747f;
			}
			this.HHLFDHNEIAH().SetFloat("_Far", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("[ItemsHandler] Found ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x001BBD00 File Offset: 0x001B9F00
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Old_Movie");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060059C2 RID: 22978 RVA: 0x001BAFC2 File Offset: 0x001B91C2
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060059C3 RID: 22979 RVA: 0x001BBD24 File Offset: 0x001B9F24
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 324f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("UI/Particles/Hidden", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059C4 RID: 22980 RVA: 0x001BBDB4 File Offset: 0x001B9FB4
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060059C5 RID: 22981 RVA: 0x001BBDD8 File Offset: 0x001B9FD8
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 871f)
			{
				this.HBJJOCHGOPH = 438f;
			}
			this.NBPKMLMCHFN.SetFloat("null", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("BlockSize", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059C6 RID: 22982 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x060059C7 RID: 22983 RVA: 0x001BBE68 File Offset: 0x001BA068
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060059C8 RID: 22984 RVA: 0x001BBE8C File Offset: 0x001BA08C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 831f)
			{
				this.HBJJOCHGOPH = 1320f;
			}
			this.HHLFDHNEIAH().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat(".", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059C9 RID: 22985 RVA: 0x001BAE5C File Offset: 0x001B905C
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060059CA RID: 22986 RVA: 0x001BBF1C File Offset: 0x001BA11C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 520f)
			{
				this.HBJJOCHGOPH = 829f;
			}
			this.JIBOKBCPDLC().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("SetPlayerDistance", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060059CB RID: 22987 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x04000931 RID: 2353
	public Shader SCShader;

	// Token: 0x04000932 RID: 2354
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000933 RID: 2355
	[Range(1f, 10f)]
	public float Distortion = 1f;

	// Token: 0x04000934 RID: 2356
	private Material BJFKDHHMLJH;
}
