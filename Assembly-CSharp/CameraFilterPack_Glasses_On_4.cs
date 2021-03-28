using System;
using UnityEngine;

// Token: 0x020000DB RID: 219
[AddComponentMenu("Camera Filter Pack/Glasses/Futuristic Desert")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On_4 : MonoBehaviour
{
	// Token: 0x06004310 RID: 17168 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004311 RID: 17169 RVA: 0x00149D6C File Offset: 0x00147F6C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1596f)
			{
				this.HBJJOCHGOPH = 154f;
			}
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack_VHS1", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.UseFinalGlassColor);
			this.ECCPAOBFDKP().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", this.Fade);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.VisionBlur);
			this.HKGAONMOBMH().SetFloat("StartTime already set: ", this.GlassDistortion);
			this.FLOHGDECHHH().SetFloat("Object ID. Case-Sensitive", this.GlassAberration);
			this.ADBKPGFMNKO().SetColor("_Max", this.GlassesColor);
			this.KBOPGONOCNP().SetColor("#savemapbeforeuploading", this.GlassesColor2);
			this.EPCGJFCCAFH().SetColor("_Value3", this.GlassColor);
			this.FLOHGDECHHH().SetFloat("#forever", this.UseScanLineSize);
			this.OIBHFCLJKDB().SetFloat("PAUSE [SPACE]", this.UseScanLine);
			this.KBOPGONOCNP().SetTexture("BadgeImage", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x00149ED8 File Offset: 0x001480D8
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 876f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.EPCGJFCCAFH().SetFloat("icon", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_TimeX", this.UseFinalGlassColor);
			this.ECCPAOBFDKP().SetFloat("nd", this.Fade);
			this.NFMGLIKNOOC().SetFloat("Scenes List:", this.VisionBlur);
			this.PGPEMMBJOOG().SetFloat("ChallengesButton", this.GlassDistortion);
			this.PGPEMMBJOOG().SetFloat("RateButton", this.GlassAberration);
			this.KBOPGONOCNP().SetColor("_Value", this.GlassesColor);
			this.KDMBOKLMADJ().SetColor("[ReplayScene] Loading replay: ", this.GlassesColor2);
			this.IIJMIPBMMBF().SetColor("[PlayerBase] Loaded custom model: ", this.GlassColor);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this.UseScanLineSize);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("USE_UV_BASED_REPROJECTION", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x0014A044 File Offset: 0x00148244
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("uploads/Intralism/mods_terms.pdf") as Texture2D);
		this.SCShader = Shader.Find("_MaxRayTraceDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x0014A07D File Offset: 0x0014827D
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004318 RID: 17176 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x0014A0B4 File Offset: 0x001482B4
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("shader.pixel") as Texture2D);
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600431A RID: 17178 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600431B RID: 17179 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600431C RID: 17180 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x0014A0ED File Offset: 0x001482ED
	private void HIPEHGNBJMN()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex") as Texture2D);
		this.SCShader = Shader.Find("0.00/0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06004321 RID: 17185 RVA: 0x0014A128 File Offset: 0x00148328
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1284f)
			{
				this.HBJJOCHGOPH = 439f;
			}
			this.KDMBOKLMADJ().SetFloat("No info", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Value3", this.UseFinalGlassColor);
			this.ABHDNGIHBKE().SetFloat("#accuracy", this.Fade);
			this.HKGAONMOBMH().SetFloat("Error: Timeout :S", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this.GlassDistortion);
			this.EPCGJFCCAFH().SetFloat("OpSetPropertiesOfActor()", this.GlassAberration);
			this.LONNIJMNKFB().SetColor("plainText", this.GlassesColor);
			this.NDMPCDHADMJ().SetColor("st", this.GlassesColor2);
			this.LONNIJMNKFB().SetColor("#currentbpm: ", this.GlassColor);
			this.KDMBOKLMADJ().SetFloat("_AdaptTex", this.UseScanLineSize);
			this.GKILCDHJFEG().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", this.UseScanLine);
			this.ABHDNGIHBKE().SetTexture("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004322 RID: 17186 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06004323 RID: 17187 RVA: 0x0014A294 File Offset: 0x00148494
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1160f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.ADBKPGFMNKO().SetFloat("maps.", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Noise_TV_2", this.UseFinalGlassColor);
			this.HKGAONMOBMH().SetFloat("Move environment object to the position", this.Fade);
			this.HKGAONMOBMH().SetFloat("No valid adaptive tonemapper type found!", this.VisionBlur);
			this.KOHGPKOFEJO().SetFloat(").png", this.GlassDistortion);
			this.NFMGLIKNOOC().SetFloat("_Value5", this.GlassAberration);
			this.NDMPCDHADMJ().SetColor("Editor/", this.GlassesColor);
			this.FLOHGDECHHH().SetColor("[DiscordController] Join ({0})", this.GlassesColor2);
			this.MNLKBFFKHIE().SetColor("CameraFilterPack_OldFilm2", this.GlassColor);
			this.ECCPAOBFDKP().SetFloat("player.gamecompleted", this.UseScanLineSize);
			this.IIJMIPBMMBF().SetFloat("_Green_G", this.UseScanLine);
			this.KBOPGONOCNP().SetTexture("float,0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004326 RID: 17190 RVA: 0x0014A400 File Offset: 0x00148600
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("_WhiteBalance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004327 RID: 17191 RVA: 0x0014A439 File Offset: 0x00148639
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004328 RID: 17192 RVA: 0x0014A470 File Offset: 0x00148670
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004329 RID: 17193 RVA: 0x0014A4A7 File Offset: 0x001486A7
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600432A RID: 17194 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x0600432B RID: 17195 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x0014A4E0 File Offset: 0x001486E0
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1630f)
			{
				this.HBJJOCHGOPH = 261f;
			}
			this.MNLKBFFKHIE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("_Value2", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("Error: I/O Failure", this.Fade);
			this.HKGAONMOBMH().SetFloat("settings.volume.menu", this.VisionBlur);
			this.JCPDCGIJKJD().SetFloat("VHS", this.GlassDistortion);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack_Paper1", this.GlassAberration);
			this.ABHDNGIHBKE().SetColor("colorA", this.GlassesColor);
			this.ECCPAOBFDKP().SetColor("CameraFilterPack/FX_DigitalMatrix", this.GlassesColor2);
			this.HKGAONMOBMH().SetColor("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.GlassColor);
			this.MNLKBFFKHIE().SetFloat("CameraFilterPack/Blend2Camera_Divide", this.UseScanLineSize);
			this.GKILCDHJFEG().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.UseScanLine);
			this.KOHGPKOFEJO().SetTexture("DPADVER", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x0014A64C File Offset: 0x0014884C
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("STOP [R]") as Texture2D);
		this.SCShader = Shader.Find("_MatrixSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600432F RID: 17199 RVA: 0x0014A685 File Offset: 0x00148885
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004330 RID: 17200 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x0014A779 File Offset: 0x00148979
	private void EGEPLFGKGLI()
	{
		this.FPHEBLMINDA = (Resources.Load("[DiscordController] Responding yes to Ask to Join request") as Texture2D);
		this.SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004333 RID: 17203 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004334 RID: 17204 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x0014A7B2 File Offset: 0x001489B2
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004337 RID: 17207 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06004338 RID: 17208 RVA: 0x0014A7EC File Offset: 0x001489EC
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 583f)
			{
				this.HBJJOCHGOPH = 249f;
			}
			this.MNLKBFFKHIE().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_LowRez", this.UseFinalGlassColor);
			this.GKILCDHJFEG().SetFloat("ShineEffect", this.Fade);
			this.JCPDCGIJKJD().SetFloat("Working commands:\nreset <challengeid>\nresetall", this.VisionBlur);
			this.NFMGLIKNOOC().SetFloat("_History4LumaTex", this.GlassDistortion);
			this.KDMBOKLMADJ().SetFloat("MenuRecordButton", this.GlassAberration);
			this.NFMGLIKNOOC().SetColor("_Value6", this.GlassesColor);
			this.NDMPCDHADMJ().SetColor("Fade", this.GlassesColor2);
			this.ECCPAOBFDKP().SetColor("_Value2", this.GlassColor);
			this.LDNADDJMIPK().SetFloat("{0:0} day{1}, ", this.UseScanLineSize);
			this.LONNIJMNKFB().SetFloat("settings.disablestoryboard", this.UseScanLine);
			this.MNLKBFFKHIE().SetTexture(" room(s)", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004339 RID: 17209 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600433A RID: 17210 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600433B RID: 17211 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600433C RID: 17212 RVA: 0x0014A958 File Offset: 0x00148B58
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600433D RID: 17213 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600433E RID: 17214 RVA: 0x0014A990 File Offset: 0x00148B90
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1228f)
			{
				this.HBJJOCHGOPH = 1624f;
			}
			this.LONNIJMNKFB().SetFloat("FToA", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.UseFinalGlassColor);
			this.MNLKBFFKHIE().SetFloat("_Value7", this.Fade);
			this.EPCGJFCCAFH().SetFloat("float,1.5", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("#yes", this.GlassDistortion);
			this.ADBKPGFMNKO().SetFloat("_Value6", this.GlassAberration);
			this.KOHGPKOFEJO().SetColor("_ScreenResolution", this.GlassesColor);
			this.KDMBOKLMADJ().SetColor("Data/Skins/", this.GlassesColor2);
			this.NDMPCDHADMJ().SetColor(" not exist", this.GlassColor);
			this.EPCGJFCCAFH().SetFloat("_ScreenResolution", this.UseScanLineSize);
			this.GKILCDHJFEG().SetFloat(" to: ", this.UseScanLine);
			this.JCPDCGIJKJD().SetTexture("\\\\", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600433F RID: 17215 RVA: 0x0014AAFC File Offset: 0x00148CFC
	private void JDKHBGDEONK()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack_TV_BrokenGlass1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004340 RID: 17216 RVA: 0x0014AB35 File Offset: 0x00148D35
	private void COOHIILCOCO()
	{
		this.FPHEBLMINDA = (Resources.Load("MouseY") as Texture2D);
		this.SCShader = Shader.Find("_Green_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004341 RID: 17217 RVA: 0x0014AB6E File Offset: 0x00148D6E
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004342 RID: 17218 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004343 RID: 17219 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004344 RID: 17220 RVA: 0x0014ABA5 File Offset: 0x00148DA5
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004345 RID: 17221 RVA: 0x0014ABDC File Offset: 0x00148DDC
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("#reward: ") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004346 RID: 17222 RVA: 0x0014AC18 File Offset: 0x00148E18
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 312f;
			}
			this.ABHDNGIHBKE().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("[EMPTY]", this.UseFinalGlassColor);
			this.EPCGJFCCAFH().SetFloat("_ColoredChange", this.Fade);
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.VisionBlur);
			this.LDNADDJMIPK().SetFloat("TotalHitsScoreText", this.GlassDistortion);
			this.HKGAONMOBMH().SetFloat("float,0", this.GlassAberration);
			this.ECCPAOBFDKP().SetColor(".lastCheckpoint.checkpointsUsed", this.GlassesColor);
			this.ABHDNGIHBKE().SetColor("Needs to be attached to the Event System component in the scene", this.GlassesColor2);
			this.MNLKBFFKHIE().SetColor("_Visualize", this.GlassColor);
			this.FLOHGDECHHH().SetFloat("EventMenu", this.UseScanLineSize);
			this.OIBHFCLJKDB().SetFloat("0.00", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("SUBMIT", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004347 RID: 17223 RVA: 0x0014AD84 File Offset: 0x00148F84
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("_TexelOffsetScale") as Texture2D);
		this.SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004348 RID: 17224 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004349 RID: 17225 RVA: 0x0014ADC0 File Offset: 0x00148FC0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1704f)
			{
				this.HBJJOCHGOPH = 913f;
			}
			this.LDNADDJMIPK().SetFloat("_Threshhold", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat(". Not connectedAndReady.", this.UseFinalGlassColor);
			this.ADBKPGFMNKO().SetFloat("Middle Click", this.Fade);
			this.LONNIJMNKFB().SetFloat("Health Stats", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("Crosshair", this.GlassDistortion);
			this.NDMPCDHADMJ().SetFloat("resource id", this.GlassAberration);
			this.ADBKPGFMNKO().SetColor("Object ID. Case-Sensitive", this.GlassesColor);
			this.KDMBOKLMADJ().SetColor("_InvRenderTargetSize", this.GlassesColor2);
			this.JCPDCGIJKJD().SetColor("_Value", this.GlassColor);
			this.KOHGPKOFEJO().SetFloat("_Threshhold", this.UseScanLineSize);
			this.LONNIJMNKFB().SetFloat("history", this.UseScanLine);
			this.LONNIJMNKFB().SetTexture(".lastCheckpoint.perfectHits", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600434A RID: 17226 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600434B RID: 17227 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600434C RID: 17228 RVA: 0x0014AF2C File Offset: 0x0014912C
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600434D RID: 17229 RVA: 0x0014AF63 File Offset: 0x00149163
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600434E RID: 17230 RVA: 0x0014AF9A File Offset: 0x0014919A
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor") as Texture2D);
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600434F RID: 17231 RVA: 0x0014AFD4 File Offset: 0x001491D4
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1651f)
			{
				this.HBJJOCHGOPH = 681f;
			}
			this.EPCGJFCCAFH().SetFloat("_Far", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("VHS2", this.UseFinalGlassColor);
			this.OIBHFCLJKDB().SetFloat("_CurTex", this.Fade);
			this.IIJMIPBMMBF().SetFloat("Item ", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("UseScanLineSize", this.GlassDistortion);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.GlassAberration);
			this.OIBHFCLJKDB().SetColor("]", this.GlassesColor);
			this.FLOHGDECHHH().SetColor(".", this.GlassesColor2);
			this.ECCPAOBFDKP().SetColor("_EmissionColor", this.GlassColor);
			this.KBOPGONOCNP().SetFloat("_AdaptionSpeed", this.UseScanLineSize);
			this.MNLKBFFKHIE().SetFloat("_Threshold", this.UseScanLine);
			this.ECCPAOBFDKP().SetTexture("SaveButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004350 RID: 17232 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06004351 RID: 17233 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004352 RID: 17234 RVA: 0x0014B140 File Offset: 0x00149340
	private void DOKAKEMDALN()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("RecordButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004353 RID: 17235 RVA: 0x0014B179 File Offset: 0x00149379
	private void BOPKKCAFODF()
	{
		this.FPHEBLMINDA = (Resources.Load("_EmissionColor") as Texture2D);
		this.SCShader = Shader.Find("menu.tabid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004354 RID: 17236 RVA: 0x0014B1B4 File Offset: 0x001493B4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 846f)
			{
				this.HBJJOCHGOPH = 602f;
			}
			this.NFMGLIKNOOC().SetFloat("0", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Curve", this.UseFinalGlassColor);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.Fade);
			this.LONNIJMNKFB().SetFloat("settings.selectormapsperpage", this.VisionBlur);
			this.PGPEMMBJOOG().SetFloat("Joystick", this.GlassDistortion);
			this.LDNADDJMIPK().SetFloat("[MapsData] Key ", this.GlassAberration);
			this.JCPDCGIJKJD().SetColor("x", this.GlassesColor);
			this.NFMGLIKNOOC().SetColor("_Blue_G", this.GlassesColor2);
			this.ABHDNGIHBKE().SetColor("shader.none", this.GlassColor);
			this.LONNIJMNKFB().SetFloat("_Red_C", this.UseScanLineSize);
			this.NFMGLIKNOOC().SetFloat("_AlphaHexa", this.UseScanLine);
			this.ABHDNGIHBKE().SetTexture("ResourceIDInputField", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004355 RID: 17237 RVA: 0x0014B320 File Offset: 0x00149520
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 705f)
			{
				this.HBJJOCHGOPH = 1613f;
			}
			this.JCPDCGIJKJD().SetFloat("maps.", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", this.UseFinalGlassColor);
			this.NFMGLIKNOOC().SetFloat("Error: You're not logged into Steam!", this.Fade);
			this.LONNIJMNKFB().SetFloat("Offline or in OfflineMode. No VitalStats available.", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat(".lastCheckpoint.penaltyScore", this.GlassDistortion);
			this.IIJMIPBMMBF().SetFloat("GlassAberration", this.GlassAberration);
			this.MNLKBFFKHIE().SetColor("_Value2", this.GlassesColor);
			this.KOHGPKOFEJO().SetColor("_ForceYSwap", this.GlassesColor2);
			this.KDMBOKLMADJ().SetColor("_Distortion", this.GlassColor);
			this.EPCGJFCCAFH().SetFloat("_FrustumCornersWS", this.UseScanLineSize);
			this.PGPEMMBJOOG().SetFloat("_Distortion", this.UseScanLine);
			this.ADBKPGFMNKO().SetTexture("Gameplay/Base", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004356 RID: 17238 RVA: 0x0014B48C File Offset: 0x0014968C
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004357 RID: 17239 RVA: 0x0014B4C4 File Offset: 0x001496C4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 734f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.FLOHGDECHHH().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("float,1.5", this.UseFinalGlassColor);
			this.FLOHGDECHHH().SetFloat("ConnectToRegion: ", this.Fade);
			this.MNLKBFFKHIE().SetFloat("_Value3", this.VisionBlur);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Film_ColorPerfection", this.GlassDistortion);
			this.NDMPCDHADMJ().SetFloat("Inside cells:\n", this.GlassAberration);
			this.NFMGLIKNOOC().SetColor("Turn", this.GlassesColor);
			this.FLOHGDECHHH().SetColor("Tab1Content", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("Value", this.GlassColor);
			this.GKILCDHJFEG().SetFloat("_NoiseAmount", this.UseScanLineSize);
			this.EPCGJFCCAFH().SetFloat("_Distance", this.UseScanLine);
			this.JCPDCGIJKJD().SetTexture("GUICamera", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004358 RID: 17240 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004359 RID: 17241 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x0600435A RID: 17242 RVA: 0x0014B630 File Offset: 0x00149830
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Glasses_On5") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600435B RID: 17243 RVA: 0x0014B66C File Offset: 0x0014986C
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 186f)
			{
				this.HBJJOCHGOPH = 1387f;
			}
			this.OIBHFCLJKDB().SetFloat("No problem found, so far", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("CameraFilterPack/Blur_GaussianBlur", this.UseFinalGlassColor);
			this.LDNADDJMIPK().SetFloat("mapselector.orderby", this.Fade);
			this.ECCPAOBFDKP().SetFloat("': ", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("_CenterY", this.GlassDistortion);
			this.LDNADDJMIPK().SetFloat("http", this.GlassAberration);
			this.KBOPGONOCNP().SetColor("_FadeFromBinary", this.GlassesColor);
			this.ECCPAOBFDKP().SetColor("_FgOverlap", this.GlassesColor2);
			this.EPCGJFCCAFH().SetColor(". Client should be in a room. Current connectionStateDetailed: ", this.GlassColor);
			this.IIJMIPBMMBF().SetFloat("[LocalizationService] All languages: ", this.UseScanLineSize);
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.UseScanLine);
			this.PGPEMMBJOOG().SetTexture("[Right-Down]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600435C RID: 17244 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600435D RID: 17245 RVA: 0x0014B7D8 File Offset: 0x001499D8
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor/") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600435E RID: 17246 RVA: 0x0014B811 File Offset: 0x00149A11
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("\n\n#") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600435F RID: 17247 RVA: 0x0014B84A File Offset: 0x00149A4A
	private void DFFKKLAPHCC()
	{
		this.FPHEBLMINDA = (Resources.Load("_Intensity") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004360 RID: 17248 RVA: 0x0014B883 File Offset: 0x00149A83
	private void PKLOBJHKFEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_Distance") as Texture2D);
		this.SCShader = Shader.Find("note.0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004361 RID: 17249 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004362 RID: 17250 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004363 RID: 17251 RVA: 0x0014B8BC File Offset: 0x00149ABC
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button8") as Texture2D);
		this.SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004364 RID: 17252 RVA: 0x0014B8F8 File Offset: 0x00149AF8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1429f)
			{
				this.HBJJOCHGOPH = 1188f;
			}
			this.FLOHGDECHHH().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("LoadMapCanvas", this.UseFinalGlassColor);
			this.ADBKPGFMNKO().SetFloat("Hidden/Image Effects/Cinematic/Bloom", this.Fade);
			this.FLOHGDECHHH().SetFloat("arc", this.VisionBlur);
			this.GKILCDHJFEG().SetFloat("f", this.GlassDistortion);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Vision_Blood", this.GlassAberration);
			this.HKGAONMOBMH().SetColor("x", this.GlassesColor);
			this.MNLKBFFKHIE().SetColor("Health Stats", this.GlassesColor2);
			this.NDMPCDHADMJ().SetColor("_TimeX", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("(?<=#)\\w+", this.UseScanLineSize);
			this.KOHGPKOFEJO().SetFloat("_Value3", this.UseScanLine);
			this.NFMGLIKNOOC().SetTexture("_MatrixColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004365 RID: 17253 RVA: 0x0014BA64 File Offset: 0x00149C64
	private void FMFNILJIEIA()
	{
		this.FPHEBLMINDA = (Resources.Load("Registered PhotonView: ") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004366 RID: 17254 RVA: 0x0014BA9D File Offset: 0x00149C9D
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004367 RID: 17255 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004368 RID: 17256 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06004369 RID: 17257 RVA: 0x0014BAD4 File Offset: 0x00149CD4
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

	// Token: 0x0600436A RID: 17258 RVA: 0x0014BB0B File Offset: 0x00149D0B
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600436B RID: 17259 RVA: 0x0014BB44 File Offset: 0x00149D44
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1292f)
			{
				this.HBJJOCHGOPH = 147f;
			}
			this.LDNADDJMIPK().SetFloat("received</b>\n#reason: ", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Deleted event", this.UseFinalGlassColor);
			this.KDMBOKLMADJ().SetFloat("nogamesfound", this.Fade);
			this.ABHDNGIHBKE().SetFloat("ReJoinRoom failed due to offline mode.", this.VisionBlur);
			this.GKILCDHJFEG().SetFloat("mapselector.filter.rateduponly", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.GlassAberration);
			this.EPCGJFCCAFH().SetColor("/", this.GlassesColor);
			this.KBOPGONOCNP().SetColor("x", this.GlassesColor2);
			this.EPCGJFCCAFH().SetColor(". Prefab must have a PhotonView component.", this.GlassColor);
			this.KBOPGONOCNP().SetFloat("_Value4", this.UseScanLineSize);
			this.FLOHGDECHHH().SetFloat("EndlessLoopsScoreText", this.UseScanLine);
			this.ABHDNGIHBKE().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600436C RID: 17260 RVA: 0x0014BCB0 File Offset: 0x00149EB0
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 969f)
			{
				this.HBJJOCHGOPH = 1452f;
			}
			this.NDMPCDHADMJ().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat(",", this.UseFinalGlassColor);
			this.EPCGJFCCAFH().SetFloat("player.xp", this.Fade);
			this.OIBHFCLJKDB().SetFloat("Set Trail Zoom Speed", this.VisionBlur);
			this.HKGAONMOBMH().SetFloat("[UI] Unknows button action: ", this.GlassDistortion);
			this.FLOHGDECHHH().SetFloat("_Value3", this.GlassAberration);
			this.FLOHGDECHHH().SetColor(".lastCheckpoint.playerdistance", this.GlassesColor);
			this.OIBHFCLJKDB().SetColor("CameraFilterPack/Blur_Radial", this.GlassesColor2);
			this.ADBKPGFMNKO().SetColor("Anomaly_Near", this.GlassColor);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.UseScanLineSize);
			this.PGPEMMBJOOG().SetFloat("ColorBlood", this.UseScanLine);
			this.ADBKPGFMNKO().SetTexture("ScoreText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600436D RID: 17261 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600436E RID: 17262 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x0014BE1C File Offset: 0x0014A01C
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 714f)
			{
				this.HBJJOCHGOPH = 1621f;
			}
			this.HKGAONMOBMH().SetFloat("StartRound", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_RangeScale", this.UseFinalGlassColor);
			this.KBOPGONOCNP().SetFloat("maps.", this.Fade);
			this.JCPDCGIJKJD().SetFloat("DPADVER", this.VisionBlur);
			this.FLOHGDECHHH().SetFloat("[PlayerBase] Delete checkpoint data", this.GlassDistortion);
			this.JCPDCGIJKJD().SetFloat("SpawnObj", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("Left Stick Click", this.GlassesColor);
			this.HKGAONMOBMH().SetColor("_ScreenResolution", this.GlassesColor2);
			this.NDMPCDHADMJ().SetColor("<b>Intralism Items Uploader</b> by Oxy949", this.GlassColor);
			this.MNLKBFFKHIE().SetFloat(".workshop", this.UseScanLineSize);
			this.NFMGLIKNOOC().SetFloat("_ScreenEdgeFading", this.UseScanLine);
			this.ABHDNGIHBKE().SetTexture("value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06004371 RID: 17265 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004372 RID: 17266 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06004373 RID: 17267 RVA: 0x0014BF88 File Offset: 0x0014A188
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004374 RID: 17268 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06004375 RID: 17269 RVA: 0x0014BFBF File Offset: 0x0014A1BF
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x0014BFF8 File Offset: 0x0014A1F8
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1434f)
			{
				this.HBJJOCHGOPH = 1051f;
			}
			this.ECCPAOBFDKP().SetFloat(".GoalProgress", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("--------------------------------", this.UseFinalGlassColor);
			this.NFMGLIKNOOC().SetFloat("76561198041679481", this.Fade);
			this.KOHGPKOFEJO().SetFloat("LivesSlider", this.VisionBlur);
			this.ECCPAOBFDKP().SetFloat("RecieveChatActionMessage", this.GlassDistortion);
			this.GKILCDHJFEG().SetFloat("_Value", this.GlassAberration);
			this.FLOHGDECHHH().SetColor("76561198041679481", this.GlassesColor);
			this.MNLKBFFKHIE().SetColor("_FixDistance", this.GlassesColor2);
			this.ADBKPGFMNKO().SetColor("\t", this.GlassColor);
			this.NFMGLIKNOOC().SetFloat("[MapEditor] Loading music...", this.UseScanLineSize);
			this.JCPDCGIJKJD().SetFloat("AccuracyScoreText", this.UseScanLine);
			this.IIJMIPBMMBF().SetTexture("<size=24>", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004377 RID: 17271 RVA: 0x0014C164 File Offset: 0x0014A364
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
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.UseFinalGlassColor);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("VisionBlur", this.VisionBlur);
			this.NBPKMLMCHFN.SetFloat("GlassDistortion", this.GlassDistortion);
			this.NBPKMLMCHFN.SetFloat("GlassAberration", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("GlassesColor", this.GlassesColor);
			this.NBPKMLMCHFN.SetColor("GlassesColor2", this.GlassesColor2);
			this.NBPKMLMCHFN.SetColor("GlassColor", this.GlassColor);
			this.NBPKMLMCHFN.SetFloat("UseScanLineSize", this.UseScanLineSize);
			this.NBPKMLMCHFN.SetFloat("UseScanLine", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004378 RID: 17272 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004379 RID: 17273 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600437A RID: 17274 RVA: 0x0014C2D0 File Offset: 0x0014A4D0
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600437B RID: 17275 RVA: 0x0014C307 File Offset: 0x0014A507
	private void FEKECCBFGMI()
	{
		this.FPHEBLMINDA = (Resources.Load("3d text") as Texture2D);
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x0014C340 File Offset: 0x0014A540
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x0014C378 File Offset: 0x0014A578
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1451f)
			{
				this.HBJJOCHGOPH = 143f;
			}
			this.ECCPAOBFDKP().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_Value", this.UseFinalGlassColor);
			this.ADBKPGFMNKO().SetFloat("[MenuScene] Error: ", this.Fade);
			this.NBPKMLMCHFN.SetFloat(" not exist", this.VisionBlur);
			this.JCPDCGIJKJD().SetFloat("_EmissionGain", this.GlassDistortion);
			this.JCPDCGIJKJD().SetFloat("{", this.GlassAberration);
			this.NDMPCDHADMJ().SetColor("settings.cameramovements", this.GlassesColor);
			this.ABHDNGIHBKE().SetColor("#mapalreadyexistupdate", this.GlassesColor2);
			this.ECCPAOBFDKP().SetColor("offsets", this.GlassColor);
			this.MNLKBFFKHIE().SetFloat("Set Trail Zoom Speed", this.UseScanLineSize);
			this.ADBKPGFMNKO().SetFloat("Set satellite trail width", this.UseScanLine);
			this.NBPKMLMCHFN.SetTexture("type", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x0014C4E4 File Offset: 0x0014A6E4
	private void HDMDKOKOOJC()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button10") as Texture2D);
		this.SCShader = Shader.Find("Drop_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x0014C51D File Offset: 0x0014A71D
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x0014C554 File Offset: 0x0014A754
	private void AEMGPJDJGBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("kick") as Texture2D);
		this.SCShader = Shader.Find("init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004384 RID: 17284 RVA: 0x0014C590 File Offset: 0x0014A790
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1937f)
			{
				this.HBJJOCHGOPH = 97f;
			}
			this.OIBHFCLJKDB().SetFloat("Apr", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("CheckCombo", this.UseFinalGlassColor);
			this.GKILCDHJFEG().SetFloat("mapselector.filter.favoriteonly", this.Fade);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this.VisionBlur);
			this.IIJMIPBMMBF().SetFloat("id", this.GlassDistortion);
			this.ADBKPGFMNKO().SetFloat("file://", this.GlassAberration);
			this.JCPDCGIJKJD().SetColor("[ItemsHandler] Item not found:", this.GlassesColor);
			this.ECCPAOBFDKP().SetColor("BitsData", this.GlassesColor2);
			this.LONNIJMNKFB().SetColor("_BlurParams", this.GlassColor);
			this.ECCPAOBFDKP().SetFloat("bool", this.UseScanLineSize);
			this.KBOPGONOCNP().SetFloat("#yes", this.UseScanLine);
			this.KOHGPKOFEJO().SetTexture("GraphicsQualitySlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004385 RID: 17285 RVA: 0x0014C6FC File Offset: 0x0014A8FC
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 78f)
			{
				this.HBJJOCHGOPH = 778f;
			}
			this.IIJMIPBMMBF().SetFloat("player.neon", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("_Params1", this.UseFinalGlassColor);
			this.ECCPAOBFDKP().SetFloat("_Value4", this.Fade);
			this.EPCGJFCCAFH().SetFloat("maps.", this.VisionBlur);
			this.ECCPAOBFDKP().SetFloat("_Red_B", this.GlassDistortion);
			this.OIBHFCLJKDB().SetFloat("_TimeX", this.GlassAberration);
			this.NBPKMLMCHFN.SetColor("_BlurSize", this.GlassesColor);
			this.OIBHFCLJKDB().SetColor("_Distortion", this.GlassesColor2);
			this.FLOHGDECHHH().SetColor("#restart", this.GlassColor);
			this.KOHGPKOFEJO().SetFloat(" cannot be used as a 3D LUT.", this.UseScanLineSize);
			this.LONNIJMNKFB().SetFloat("color", this.UseScanLine);
			this.NFMGLIKNOOC().SetTexture("OK", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004386 RID: 17286 RVA: 0x0014C868 File Offset: 0x0014AA68
	private void GLEJGFLCLPJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("_MidGrey");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004387 RID: 17287 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004388 RID: 17288 RVA: 0x0014C8A4 File Offset: 0x0014AAA4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1953f)
			{
				this.HBJJOCHGOPH = 368f;
			}
			this.KBOPGONOCNP().SetFloat("}", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("VoteDownToggle", this.UseFinalGlassColor);
			this.HKGAONMOBMH().SetFloat("player.quantum", this.Fade);
			this.ABHDNGIHBKE().SetFloat("Messages (shift+tab)", this.VisionBlur);
			this.ECCPAOBFDKP().SetFloat("OpSetPropertiesOfRoom()", this.GlassDistortion);
			this.MNLKBFFKHIE().SetFloat("ShowSprite", this.GlassAberration);
			this.KBOPGONOCNP().SetColor("_SizeX", this.GlassesColor);
			this.NDMPCDHADMJ().SetColor("_BlurRadius4", this.GlassesColor2);
			this.KDMBOKLMADJ().SetColor(" GO:", this.GlassColor);
			this.HKGAONMOBMH().SetFloat("1332644700", this.UseScanLineSize);
			this.NDMPCDHADMJ().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", this.UseScanLine);
			this.EPCGJFCCAFH().SetTexture("Case-Sensitive", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004389 RID: 17289 RVA: 0x0014CA10 File Offset: 0x0014AC10
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("_BlurredColor") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600438A RID: 17290 RVA: 0x0014CA49 File Offset: 0x0014AC49
	private void MKOMIDCPCDC()
	{
		this.FPHEBLMINDA = (Resources.Load("UseScanLine") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600438B RID: 17291 RVA: 0x0014CA82 File Offset: 0x0014AC82
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Blend2Camera_ColorKey") as Texture2D);
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600438C RID: 17292 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600438D RID: 17293 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x0600438E RID: 17294 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x0600438F RID: 17295 RVA: 0x00149D4C File Offset: 0x00147F4C
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400071C RID: 1820
	public Shader SCShader;

	// Token: 0x0400071D RID: 1821
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400071E RID: 1822
	[Range(0f, 1f)]
	public float Fade = 0.2f;

	// Token: 0x0400071F RID: 1823
	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	// Token: 0x04000720 RID: 1824
	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	// Token: 0x04000721 RID: 1825
	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	// Token: 0x04000722 RID: 1826
	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	// Token: 0x04000723 RID: 1827
	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	// Token: 0x04000724 RID: 1828
	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	// Token: 0x04000725 RID: 1829
	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	// Token: 0x04000726 RID: 1830
	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	// Token: 0x04000727 RID: 1831
	public Color GlassColor = new Color(1f, 0.4f, 0f, 1f);

	// Token: 0x04000728 RID: 1832
	private Material BJFKDHHMLJH;

	// Token: 0x04000729 RID: 1833
	private Texture2D FPHEBLMINDA;
}
