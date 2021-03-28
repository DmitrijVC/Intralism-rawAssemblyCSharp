using System;
using UnityEngine;

// Token: 0x02000042 RID: 66
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Divide")]
public class CameraFilterPack_Blend2Camera_Divide : MonoBehaviour
{
	// Token: 0x06001203 RID: 4611 RVA: 0x0007A05C File Offset: 0x0007825C
	private void PDHKMDBNGGN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x0007A0C5 File Offset: 0x000782C5
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0007A100 File Offset: 0x00078300
	private void IHPLMLBJELK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x0007A164 File Offset: 0x00078364
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x0007A19F File Offset: 0x0007839F
	private void NAOLAJPDGIC()
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

	// Token: 0x06001209 RID: 4617 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x0007A1D9 File Offset: 0x000783D9
	private void KKGMKGHFELO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 73);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x0007A214 File Offset: 0x00078414
	private void PCGODOELOHG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x0007A24F File Offset: 0x0007844F
	private void OEAMLMGNFFC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x0007A19F File Offset: 0x0007839F
	private void BOLBPPHJBMI()
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

	// Token: 0x0600120E RID: 4622 RVA: 0x0007A28C File Offset: 0x0007848C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 802f)
			{
				this.HBJJOCHGOPH = 660f;
			}
			if (this.Camera2 != null)
			{
				this.LONNIJMNKFB().SetTexture("float,1.5", this.JDMCFBKJHDD);
			}
			this.EJDPNJAEAKJ().SetFloat("RemoveEnvironmentObject", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("couldn't be found!", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("#ok", this.SwitchCameraToCamera2);
			this.KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 751f, 993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x0007A386 File Offset: 0x00078586
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x0007A3C4 File Offset: 0x000785C4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 930f)
			{
				this.HBJJOCHGOPH = 915f;
			}
			if (this.Camera2 != null)
			{
				this.FAIFBBGFAIB().SetTexture("value", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Set Sun Sensitivity", this.BlendFX);
			this.PLBEJJIHFPB().SetFloat("PLAY [SPACE]", this.SwitchCameraToCamera2);
			this.OGMEGHKECAH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 783f, 526f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x0007A4BE File Offset: 0x000786BE
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x0007A4F5 File Offset: 0x000786F5
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x0007A52C File Offset: 0x0007872C
	private void AENGMPAMCFL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x0007A568 File Offset: 0x00078768
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1459f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			if (this.Camera2 != null)
			{
				this.ADGHJOHKEHG().SetTexture("other", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Aspiration", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat(" or ", this.BlendFX);
			this.FAIFBBGFAIB().SetFloat("Current xp: ", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("_Red_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 616f, 989f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x0007A664 File Offset: 0x00078864
	private void FHGKIOOMMOH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x0007A19F File Offset: 0x0007839F
	private void ALMGMOOHLMA()
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

	// Token: 0x06001218 RID: 4632 RVA: 0x0007A6CD File Offset: 0x000788CD
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x0007A19F File Offset: 0x0007839F
	private void CNDACAHCCOI()
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

	// Token: 0x0600121A RID: 4634 RVA: 0x0007A704 File Offset: 0x00078904
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

	// Token: 0x0600121B RID: 4635 RVA: 0x0007A770 File Offset: 0x00078970
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 1121f;
			}
			if (this.Camera2 != null)
			{
				this.NDMPCDHADMJ().SetTexture("[Up-Right-Down]", this.JDMCFBKJHDD);
			}
			this.LONNIJMNKFB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_VignetteSettings", this.BlendFX);
			this.IGKFMCPDNOI().SetFloat("checkpoint", this.SwitchCameraToCamera2);
			this.MCDGIILBNIF().SetVector("value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1413f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x0007A86A File Offset: 0x00078A6A
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x0007A8A5 File Offset: 0x00078AA5
	private void DCGFEIBKOBB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x0007A8E0 File Offset: 0x00078AE0
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x0007A918 File Offset: 0x00078B18
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1363f)
			{
				this.HBJJOCHGOPH = 378f;
			}
			if (this.Camera2 != null)
			{
				this.LONNIJMNKFB().SetTexture("BitsData", this.JDMCFBKJHDD);
			}
			this.NDMPCDHADMJ().SetFloat("COMPLETED", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Tab1Content", this.BlendFX);
			this.KBOPGONOCNP().SetFloat("No Name", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 889f, 1538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x0007AA12 File Offset: 0x00078C12
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0007AA50 File Offset: 0x00078C50
	private void GPNAOAKCMHC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0007AAB9 File Offset: 0x00078CB9
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x0007A19F File Offset: 0x0007839F
	private void CPAJLKHMOJB()
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

	// Token: 0x06001224 RID: 4644 RVA: 0x0007AAF0 File Offset: 0x00078CF0
	private void HIFPDKKBDHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x0007AB2B File Offset: 0x00078D2B
	private void HJDPEBAPBPN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x0007AB66 File Offset: 0x00078D66
	private void HOLDCFBBHHP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x0007ABA1 File Offset: 0x00078DA1
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x0007ABD8 File Offset: 0x00078DD8
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x0007A19F File Offset: 0x0007839F
	private void HONBLGFDMLL()
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

	// Token: 0x0600122A RID: 4650 RVA: 0x0007AC10 File Offset: 0x00078E10
	private void FNCDAPDOBBI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x0007A0C5 File Offset: 0x000782C5
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x0007AC7C File Offset: 0x00078E7C
	private void KCCIEMBMOBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x0007ACE5 File Offset: 0x00078EE5
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x0007AD1C File Offset: 0x00078F1C
	private void EMAMCDFBGOA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x0007AD58 File Offset: 0x00078F58
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x0007ADC1 File Offset: 0x00078FC1
	private void JBAPHFIBANG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x0007A19F File Offset: 0x0007839F
	private void EJJEDJIOFAB()
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

	// Token: 0x06001233 RID: 4659 RVA: 0x0007ADFC File Offset: 0x00078FFC
	private void FINDGJLEHOL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x0007AE37 File Offset: 0x00079037
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x0007AE70 File Offset: 0x00079070
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

	// Token: 0x06001236 RID: 4662 RVA: 0x0007AF6A File Offset: 0x0007916A
	private void FCKIJIKNMCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x0007AFA5 File Offset: 0x000791A5
	private void PPFGHAKKLMN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x0007AFE0 File Offset: 0x000791E0
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001239 RID: 4665 RVA: 0x0007B017 File Offset: 0x00079217
	private void HHODKHPIBLG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600123A RID: 4666 RVA: 0x0007B052 File Offset: 0x00079252
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600123B RID: 4667 RVA: 0x0007B089 File Offset: 0x00079289
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x0007A19F File Offset: 0x0007839F
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

	// Token: 0x0600123D RID: 4669 RVA: 0x0007B0C0 File Offset: 0x000792C0
	private void MNBPNHNAEBK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x0007B129 File Offset: 0x00079329
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x0600123F RID: 4671 RVA: 0x0007B164 File Offset: 0x00079364
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

	// Token: 0x06001240 RID: 4672 RVA: 0x0007B19B File Offset: 0x0007939B
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x0007B1D4 File Offset: 0x000793D4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1591f)
			{
				this.HBJJOCHGOPH = 311f;
			}
			if (this.Camera2 != null)
			{
				this.PLBEJJIHFPB().SetTexture("CameraFilterPack/Blend2Camera_Hue", this.JDMCFBKJHDD);
			}
			this.KBOPGONOCNP().SetFloat("finished", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("MouseX", this.BlendFX);
			this.NDMPCDHADMJ().SetFloat("&search=", this.SwitchCameraToCamera2);
			this.IGKFMCPDNOI().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 93f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x0007B2CE File Offset: 0x000794CE
	private void OOBIMFILNED()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x0007B309 File Offset: 0x00079509
	private void DBIBFOINCKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x0007B344 File Offset: 0x00079544
	private void COIJKMKIEAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x0007B3B0 File Offset: 0x000795B0
	private void MKIMDFLBFOM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x0007B419 File Offset: 0x00079619
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x0007B450 File Offset: 0x00079650
	private void ANKALNDLHEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x0007B48C File Offset: 0x0007968C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1622f)
			{
				this.HBJJOCHGOPH = 819f;
			}
			if (this.Camera2 != null)
			{
				this.ADGHJOHKEHG().SetTexture("Gameplay/Base", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_FinalReflectionTexture", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_Visualize", this.BlendFX);
			this.NDMPCDHADMJ().SetFloat(" / Sample Count: ", this.SwitchCameraToCamera2);
			this.OGMEGHKECAH().SetVector("settings.arcsnohitsoundtimedelay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 897f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000292 RID: 658
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Divide";

	// Token: 0x04000293 RID: 659
	public Shader SCShader;

	// Token: 0x04000294 RID: 660
	public Camera Camera2;

	// Token: 0x04000295 RID: 661
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000296 RID: 662
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000297 RID: 663
	private Material BJFKDHHMLJH;

	// Token: 0x04000298 RID: 664
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000299 RID: 665
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400029A RID: 666
	private RenderTexture JDMCFBKJHDD;
}
