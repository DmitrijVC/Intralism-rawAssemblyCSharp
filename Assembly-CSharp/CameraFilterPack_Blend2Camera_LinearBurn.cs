using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LinearBurn")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LinearBurn : MonoBehaviour
{
	// Token: 0x06001461 RID: 5217 RVA: 0x0008618A File Offset: 0x0008438A
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x000861C1 File Offset: 0x000843C1
	private void AAPKKMKDOFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 36);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001463 RID: 5219 RVA: 0x000861FC File Offset: 0x000843FC
	private void PKLOBJHKFEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001464 RID: 5220 RVA: 0x00086265 File Offset: 0x00084465
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x000862A0 File Offset: 0x000844A0
	private void BFKANNFLAKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x000862DC File Offset: 0x000844DC
	private void EIMNPCMHJLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001467 RID: 5223 RVA: 0x00086345 File Offset: 0x00084545
	private void JCDPMLPNOOC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001468 RID: 5224 RVA: 0x00086380 File Offset: 0x00084580
	private void FKDKJKCAHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001469 RID: 5225 RVA: 0x000863BC File Offset: 0x000845BC
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 222f)
			{
				this.HBJJOCHGOPH = 127f;
			}
			if (this.Camera2 != null)
			{
				this.ADGHJOHKEHG().SetTexture("_ScreenEdgeFading", this.JDMCFBKJHDD);
			}
			this.HKGAONMOBMH().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Set sun min/max size", this.BlendFX);
			this.PGPEMMBJOOG().SetFloat("_FadeShield", this.SwitchCameraToCamera2);
			this.PGPEMMBJOOG().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 210f, 1109f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x000864B6 File Offset: 0x000846B6
	private void HGJKBDGABKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x0600146C RID: 5228 RVA: 0x000864F1 File Offset: 0x000846F1
	private void DLOAJEFNKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600146D RID: 5229 RVA: 0x0008652C File Offset: 0x0008472C
	private void IHLMNAGPKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600146E RID: 5230 RVA: 0x00086598 File Offset: 0x00084798
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600146F RID: 5231 RVA: 0x00086601 File Offset: 0x00084801
	private void ADPAAANKKBG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001470 RID: 5232 RVA: 0x0008663C File Offset: 0x0008483C
	private void FCGHOKACFHL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 78);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001471 RID: 5233 RVA: 0x00086677 File Offset: 0x00084877
	private void GFBOBIBIOMC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x000866B2 File Offset: 0x000848B2
	private void PDILBLLIPFJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x000866ED File Offset: 0x000848ED
	private void FODKODGPPDA()
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

	// Token: 0x06001475 RID: 5237 RVA: 0x00086727 File Offset: 0x00084927
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x0008675E File Offset: 0x0008495E
	private void KCDAFGECAIH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 73);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00086799 File Offset: 0x00084999
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x000867D4 File Offset: 0x000849D4
	private void MEJPBKFMAIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x0008680F File Offset: 0x00084A0F
	private void LKPBGHGCPKL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0008684C File Offset: 0x00084A4C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 565f)
			{
				this.HBJJOCHGOPH = 1870f;
			}
			if (this.Camera2 != null)
			{
				this.GJHLADDCMFF().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.GJHLADDCMFF().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("LoadingStatusText", this.BlendFX);
			this.NJDIODJNGGA().SetFloat("_Val3", this.SwitchCameraToCamera2);
			this.NFMGLIKNOOC().SetVector("menu.selectedlevelid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1488f, 760f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00086946 File Offset: 0x00084B46
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x0008697D File Offset: 0x00084B7D
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x000869B4 File Offset: 0x00084BB4
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

	// Token: 0x06001481 RID: 5249 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00086A1D File Offset: 0x00084C1D
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00086A54 File Offset: 0x00084C54
	private void OLCOOJIONIL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00086A90 File Offset: 0x00084C90
	private void BEBNOKFLJPH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 31);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00086AF9 File Offset: 0x00084CF9
	private void NCIJDDBMFKK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00086B34 File Offset: 0x00084D34
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00086B6C File Offset: 0x00084D6C
	private void ALNNIDLFILB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00086BD5 File Offset: 0x00084DD5
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00086C0C File Offset: 0x00084E0C
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00086C43 File Offset: 0x00084E43
	private void IGCJMAADPGG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00086C80 File Offset: 0x00084E80
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1077f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			if (this.Camera2 != null)
			{
				this.KAFBNOBOIAJ().SetTexture("D-Pad Down", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("%", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("id", this.BlendFX);
			this.FHFLKLMFHOI().SetFloat("_MainTex2", this.SwitchCameraToCamera2);
			this.NJDIODJNGGA().SetVector("MapperNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1480f, 1719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00086D7A File Offset: 0x00084F7A
	private void BBKMHAFFIMD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00086DB5 File Offset: 0x00084FB5
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x000866ED File Offset: 0x000848ED
	private void DHENLPJJOEN()
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

	// Token: 0x06001492 RID: 5266 RVA: 0x00086265 File Offset: 0x00084465
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00086DEC File Offset: 0x00084FEC
	private void PLNLNCDPPGG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00086E28 File Offset: 0x00085028
	private void FEKECCBFGMI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00086E91 File Offset: 0x00085091
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00086EC8 File Offset: 0x000850C8
	private void LLAJPKFNDIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00086F04 File Offset: 0x00085104
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 1265f;
			}
			if (this.Camera2 != null)
			{
				this.KAFBNOBOIAJ().SetTexture("float,1.5", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("settings.showHP", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("[PlayerController] ", this.BlendFX);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/3D_Binary", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("achievements.21.progress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1060f, 93f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06001499 RID: 5273 RVA: 0x00086FFE File Offset: 0x000851FE
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

	// Token: 0x0600149A RID: 5274 RVA: 0x000866ED File Offset: 0x000848ED
	private void FDPOFMCFBMF()
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

	// Token: 0x0600149B RID: 5275 RVA: 0x00087035 File Offset: 0x00085235
	private void OKHOILMFOEE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00087070 File Offset: 0x00085270
	private void PDHKMDBNGGN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x000870D9 File Offset: 0x000852D9
	private void BNJEFIBPJLO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00087114 File Offset: 0x00085314
	private void EAFFHHCMLCG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x0008714F File Offset: 0x0008534F
	private void ICPOEGIAFBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014A1 RID: 5281 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x060014A2 RID: 5282 RVA: 0x0008718C File Offset: 0x0008538C
	private void LBAJLLFMMMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060014A3 RID: 5283 RVA: 0x000866ED File Offset: 0x000848ED
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

	// Token: 0x060014A4 RID: 5284 RVA: 0x000871F8 File Offset: 0x000853F8
	private void ADPLHDFJFID()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 1);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00087264 File Offset: 0x00085464
	private void JDKHBGDEONK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x000872D0 File Offset: 0x000854D0
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 1391f;
			}
			if (this.Camera2 != null)
			{
				this.HHIFMIPPMPF().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("settings.volume.menu", this.BlendFX);
			this.ADGHJOHKEHG().SetFloat("BitsData", this.SwitchCameraToCamera2);
			this.HHIFMIPPMPF().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1958f, 1389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x000873CC File Offset: 0x000855CC
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x00087435 File Offset: 0x00085635
	private void CACAAKGCPPL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00087470 File Offset: 0x00085670
	private void PAAJFOKEJBN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x000874AB File Offset: 0x000856AB
	private void GNDNNEKPGCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x000874E6 File Offset: 0x000856E6
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00087520 File Offset: 0x00085720
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1192f)
			{
				this.HBJJOCHGOPH = 1199f;
			}
			if (this.Camera2 != null)
			{
				this.INOBFNCKFGK().SetTexture("HPText", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("Set sun audio input", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("/", this.BlendFX);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.NBMPPNFKFLB().SetVector("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1530f, 1323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x000866ED File Offset: 0x000848ED
	private void JHJFBCFBKLD()
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

	// Token: 0x060014AE RID: 5294 RVA: 0x0008761A File Offset: 0x0008581A
	private void AGFGKIBHCBE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x00087655 File Offset: 0x00085855
	private void MLEAHDDGEMJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00087690 File Offset: 0x00085890
	private void BDBKIEIIFPB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x000866ED File Offset: 0x000848ED
	private void AOKOLPEGHDD()
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

	// Token: 0x060014B2 RID: 5298 RVA: 0x000876CB File Offset: 0x000858CB
	private void BNIIBNCLHFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00087708 File Offset: 0x00085908
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			if (this.Camera2 != null)
			{
				this.HKGAONMOBMH().SetTexture("float,1.5", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_DistortionSize", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("_Value3", this.BlendFX);
			this.NJDIODJNGGA().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.MFHPKGICPIO().SetVector("FavoriteButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1017f, 1384f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x0008782C File Offset: 0x00085A2C
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00087895 File Offset: 0x00085A95
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x000878CC File Offset: 0x00085ACC
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 317f;
			}
			if (this.Camera2 != null)
			{
				this.FHFLKLMFHOI().SetTexture("_Extra3", this.JDMCFBKJHDD);
			}
			this.IFMAPIDFNLI().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("return CheckCondition()", this.BlendFX);
			this.HHIFMIPPMPF().SetFloat("Item creation successful! Published Item ID: ", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1965f, 701f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x000866ED File Offset: 0x000848ED
	private void DFENCIHAADO()
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

	// Token: 0x060014BD RID: 5309 RVA: 0x000879C6 File Offset: 0x00085BC6
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x000879FD File Offset: 0x00085BFD
	private void HOLDCFBBHHP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x00087A38 File Offset: 0x00085C38
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_Value2", this.JDMCFBKJHDD);
			}
			this.IFMAPIDFNLI().SetFloat("accuracy", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("_SunThreshold", this.BlendFX);
			this.MICHFGAOPKM().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.PGPEMMBJOOG().SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1330f, 202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060014C1 RID: 5313 RVA: 0x00087B34 File Offset: 0x00085D34
	private void DBEMDAJDDDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014C2 RID: 5314 RVA: 0x00087BA0 File Offset: 0x00085DA0
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1716f)
			{
				this.HBJJOCHGOPH = 883f;
			}
			if (this.Camera2 != null)
			{
				this.HKGAONMOBMH().SetTexture("ArcsHitsoundTimeDelaySlider", this.JDMCFBKJHDD);
			}
			this.NJDIODJNGGA().SetFloat("_NoiseTex", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("]. Please verify you have this gameobject in a Resources folder.", this.BlendFX);
			this.MICHFGAOPKM().SetFloat("[Left]", this.SwitchCameraToCamera2);
			this.PGPEMMBJOOG().SetVector("CameraFilterPack/Color_Chromatic_Aberration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 204f, 68f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014C3 RID: 5315 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060014C4 RID: 5316 RVA: 0x00087C9A File Offset: 0x00085E9A
	private void DPGHJILBPCE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x00087CD5 File Offset: 0x00085ED5
	private void HIAICHPPGBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x000866ED File Offset: 0x000848ED
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

	// Token: 0x060014C7 RID: 5319 RVA: 0x00087D10 File Offset: 0x00085F10
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1833f)
			{
				this.HBJJOCHGOPH = 1510f;
			}
			if (this.Camera2 != null)
			{
				this.HKGAONMOBMH().SetTexture("sfxVolume", this.JDMCFBKJHDD);
			}
			this.IFMAPIDFNLI().SetFloat("_Level", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("maps.", this.BlendFX);
			this.PGPEMMBJOOG().SetFloat("Bass", this.SwitchCameraToCamera2);
			this.INOBFNCKFGK().SetVector("PlayerBase_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1489f, 476f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014C8 RID: 5320 RVA: 0x00087E0A File Offset: 0x0008600A
	private void FCKIJIKNMCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x00087E48 File Offset: 0x00086048
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1511f)
			{
				this.HBJJOCHGOPH = 445f;
			}
			if (this.Camera2 != null)
			{
				this.FHFLKLMFHOI().SetTexture("PointsScoreText", this.JDMCFBKJHDD);
			}
			this.NBMPPNFKFLB().SetFloat("Bad parameters for setint! Use <key> <value>", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_MainTex", this.BlendFX);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.EJDPNJAEAKJ().SetVector("menu.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 584f, 1036f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x000866ED File Offset: 0x000848ED
	private void LOMDIOLNFHI()
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

	// Token: 0x060014CB RID: 5323 RVA: 0x00087F42 File Offset: 0x00086142
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014CC RID: 5324 RVA: 0x00087F79 File Offset: 0x00086179
	private void FGAOGNJOMNI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 4);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014CD RID: 5325 RVA: 0x000866ED File Offset: 0x000848ED
	private void FPHLDMMAOEF()
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

	// Token: 0x060014CE RID: 5326 RVA: 0x000866ED File Offset: 0x000848ED
	private void HGDDCINLDAD()
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

	// Token: 0x060014CF RID: 5327 RVA: 0x00087FB4 File Offset: 0x000861B4
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 400f)
			{
				this.HBJJOCHGOPH = 693f;
			}
			if (this.Camera2 != null)
			{
				this.MFHPKGICPIO().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.NBMPPNFKFLB().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("ViewMenu", this.BlendFX);
			this.FHFLKLMFHOI().SetFloat("Set Crosshair Emission", this.SwitchCameraToCamera2);
			this.HHIFMIPPMPF().SetVector("{STEAM_CLAN_IMAGE}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1246f, 86f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x000880AE File Offset: 0x000862AE
	private void CKMNIPHKPDD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014D1 RID: 5329 RVA: 0x00087C9A File Offset: 0x00085E9A
	private void IDKPHKOCOLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x000880EC File Offset: 0x000862EC
	private void LFBGJIIECLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -66);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014D4 RID: 5332 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x000866ED File Offset: 0x000848ED
	private void DKPBBJINKMG()
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

	// Token: 0x060014D6 RID: 5334 RVA: 0x00088155 File Offset: 0x00086355
	private void JOLKPPEBILA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x00088190 File Offset: 0x00086390
	private void LFAFJKJAEEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x000881F9 File Offset: 0x000863F9
	private void LNIOFCGDDKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 82);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x00088234 File Offset: 0x00086434
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x0008826C File Offset: 0x0008646C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1092f)
			{
				this.HBJJOCHGOPH = 282f;
			}
			if (this.Camera2 != null)
			{
				this.INOBFNCKFGK().SetTexture("_Value4", this.JDMCFBKJHDD);
			}
			this.KAFBNOBOIAJ().SetFloat("ShowSprite", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("id", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_Threshold", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1920f, 356f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x00088366 File Offset: 0x00086566
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x000883A0 File Offset: 0x000865A0
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

	// Token: 0x060014DE RID: 5342 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x0008849A File Offset: 0x0008669A
	private void LFINMLHAMFN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x040002DF RID: 735
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearBurn";

	// Token: 0x040002E0 RID: 736
	public Shader SCShader;

	// Token: 0x040002E1 RID: 737
	public Camera Camera2;

	// Token: 0x040002E2 RID: 738
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002E3 RID: 739
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002E4 RID: 740
	private Material BJFKDHHMLJH;

	// Token: 0x040002E5 RID: 741
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002E6 RID: 742
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002E7 RID: 743
	private RenderTexture JDMCFBKJHDD;
}
