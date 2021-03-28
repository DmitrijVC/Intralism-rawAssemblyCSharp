using System;
using UnityEngine;

// Token: 0x0200011B RID: 283
[AddComponentMenu("Camera Filter Pack/TV/Noise")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Noise : MonoBehaviour
{
	// Token: 0x06005900 RID: 22784 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005901 RID: 22785 RVA: 0x001B99AC File Offset: 0x001B7BAC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1873f)
			{
				this.HBJJOCHGOPH = 49f;
			}
			this.FAIFBBGFAIB().SetFloat("return ", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Fade", this.Fade);
			this.DEFBJOCJJKF().SetVector("Right Stick Click", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 766f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x001B9A69 File Offset: 0x001B7C69
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x001B9AA0 File Offset: 0x001B7CA0
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005904 RID: 22788 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005905 RID: 22789 RVA: 0x001B9AD7 File Offset: 0x001B7CD7
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005907 RID: 22791 RVA: 0x001B9B19 File Offset: 0x001B7D19
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005908 RID: 22792 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06005909 RID: 22793 RVA: 0x001B9B3D File Offset: 0x001B7D3D
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

	// Token: 0x0600590A RID: 22794 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600590B RID: 22795 RVA: 0x001B9B74 File Offset: 0x001B7D74
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600590C RID: 22796 RVA: 0x001B9B98 File Offset: 0x001B7D98
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600590D RID: 22797 RVA: 0x001B9BCF File Offset: 0x001B7DCF
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x001B9BF4 File Offset: 0x001B7DF4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 912f)
			{
				this.HBJJOCHGOPH = 643f;
			}
			this.NBPKMLMCHFN.SetFloat("[Down]", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("maps.", this.Fade);
			this.FAIFBBGFAIB().SetVector("StartButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 24f, 50f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x001B9CB4 File Offset: 0x001B7EB4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1161f)
			{
				this.HBJJOCHGOPH = 1563f;
			}
			this.FAIFBBGFAIB().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Send", this.Fade);
			this.KEMAALEODNH().SetVector("CameraFilterPack/FX_Drunk2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1629f, 1433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x001B9D71 File Offset: 0x001B7F71
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x001B9D98 File Offset: 0x001B7F98
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x001B9E58 File Offset: 0x001B8058
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1877f)
			{
				this.HBJJOCHGOPH = 1621f;
			}
			this.PDEAHJPOMEF().SetFloat("\nv.", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this.Fade);
			this.DEFBJOCJJKF().SetVector("CrosshairOpacitySlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 1393f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x001B9F18 File Offset: 0x001B8118
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1203f)
			{
				this.HBJJOCHGOPH = 845f;
			}
			this.FAIFBBGFAIB().SetFloat(" By: ", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("#ok", this.Fade);
			this.FAIFBBGFAIB().SetVector("#accuracy", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1468f, 1532f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x001B9FD5 File Offset: 0x001B81D5
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("Netw. Sim.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x001B9FF9 File Offset: 0x001B81F9
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600591B RID: 22811 RVA: 0x001BA01D File Offset: 0x001B821D
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x001BA054 File Offset: 0x001B8254
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1437f)
			{
				this.HBJJOCHGOPH = 1444f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Fade);
			this.DEFBJOCJJKF().SetVector("_ReflectionBufferSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 926f, 1271f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x001B998D File Offset: 0x001B7B8D
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x001BA111 File Offset: 0x001B8311
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x001BA148 File Offset: 0x001B8348
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Fill");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005921 RID: 22817 RVA: 0x001BA16C File Offset: 0x001B836C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1788f)
			{
				this.HBJJOCHGOPH = 54f;
			}
			this.HHIFMIPPMPF().SetFloat("_FadeFX", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("NO", this.Fade);
			this.PDEAHJPOMEF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1614f, 1903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005922 RID: 22818 RVA: 0x001BA229 File Offset: 0x001B8429
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000928 RID: 2344
	public Shader SCShader;

	// Token: 0x04000929 RID: 2345
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400092A RID: 2346
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400092B RID: 2347
	private Material BJFKDHHMLJH;

	// Token: 0x0400092C RID: 2348
	[Range(0.0001f, 1f)]
	public float Fade = 0.01f;
}
