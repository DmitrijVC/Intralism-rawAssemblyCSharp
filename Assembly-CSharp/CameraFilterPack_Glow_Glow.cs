using System;
using UnityEngine;

// Token: 0x020000DF RID: 223
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glow/Glow")]
public class CameraFilterPack_Glow_Glow : MonoBehaviour
{
	// Token: 0x06004459 RID: 17497 RVA: 0x00151B57 File Offset: 0x0014FD57
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600445A RID: 17498 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600445B RID: 17499 RVA: 0x00151B98 File Offset: 0x0014FD98
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600445C RID: 17500 RVA: 0x00151BBC File Offset: 0x0014FDBC
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1937f)
			{
				this.HBJJOCHGOPH = 1121f;
			}
			this.GKILCDHJFEG().SetFloat("SpectatingUserInfo", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("[LocalizationService] All keys for ", this.Amount);
			this.NBMPPNFKFLB().SetFloat("Save the map before exiting?", this.Threshold);
			this.DEFBJOCJJKF().SetFloat("Done!", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("_HalfResolution", this.Precision);
			this.KAFBNOBOIAJ().SetVector("file://", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.GKILCDHJFEG(), 5);
				Graphics.Blit(temporary, temporary2, this.GKILCDHJFEG(), 8);
				Graphics.Blit(temporary2, temporary, this.DEFBJOCJJKF(), 1);
				this.GKILCDHJFEG().SetFloat("_SoftZDistance", this.Amount * 188f);
				Graphics.Blit(temporary, temporary2, this.GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, this.HKGAONMOBMH(), 1);
				this.IGIAPKPKGPK().SetTexture(" - PUBLISHED #", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x00151D8F File Offset: 0x0014FF8F
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x00151DC8 File Offset: 0x0014FFC8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1564f)
			{
				this.HBJJOCHGOPH = 647f;
			}
			this.GKILCDHJFEG().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("FPSToggle", this.Amount);
			this.NBMPPNFKFLB().SetFloat("shader.invert", this.Threshold);
			this.IGIAPKPKGPK().SetFloat("_CurrentMipLevel", this.Intensity);
			this.NBMPPNFKFLB().SetFloat("/", this.Precision);
			this.DEFBJOCJJKF().SetVector(" respawn in future: ", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary, temporary2, this.IGIAPKPKGPK(), 4);
				Graphics.Blit(temporary2, temporary, this.DEFBJOCJJKF(), 0);
				this.PGPEMMBJOOG().SetFloat("#availablechallenges", this.Amount * 29f);
				Graphics.Blit(temporary, temporary2, this.GKILCDHJFEG(), 5);
				Graphics.Blit(temporary2, temporary, this.IGIAPKPKGPK(), 1);
				this.NBPKMLMCHFN.SetTexture("CameraFilterPack_Glasses_On7", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x00151F9C File Offset: 0x0015019C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 794f)
			{
				this.HBJJOCHGOPH = 1255f;
			}
			this.PGPEMMBJOOG().SetFloat("D-Pad Up", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("SetSpeed", this.Amount);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("\\n", this.Intensity);
			this.FLOHGDECHHH().SetFloat("Joystick1Button", this.Precision);
			this.KAFBNOBOIAJ().SetVector("Lag ", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, this.PGPEMMBJOOG(), 0);
				Graphics.Blit(temporary, temporary2, this.HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary2, temporary, this.HEHKGPKLAKK(), 1);
				this.NBPKMLMCHFN.SetFloat("_Value5", this.Amount * 928f);
				Graphics.Blit(temporary, temporary2, this.IGIAPKPKGPK(), 2);
				Graphics.Blit(temporary2, temporary, this.FLOHGDECHHH(), 1);
				this.PGPEMMBJOOG().SetTexture("settings.hitvariation", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004460 RID: 17504 RVA: 0x00152170 File Offset: 0x00150370
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1429f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.IGIAPKPKGPK().SetFloat("LevelNameInputField", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("Xbox Home", this.Amount);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Lut_PlayWith", this.Threshold);
			this.PGPEMMBJOOG().SetFloat("SetRoomStartTimestamp", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(" not exist", this.Precision);
			this.GKILCDHJFEG().SetVector("DPADHOR", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, this.KAFBNOBOIAJ(), 8);
				Graphics.Blit(temporary, temporary2, this.NBMPPNFKFLB(), 5);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.IGIAPKPKGPK().SetFloat("_Size", this.Amount * 469f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 8);
				Graphics.Blit(temporary2, temporary, this.FLOHGDECHHH(), 1);
				this.NBMPPNFKFLB().SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004461 RID: 17505 RVA: 0x00152344 File Offset: 0x00150544
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 636f)
			{
				this.HBJJOCHGOPH = 801f;
			}
			this.PGPEMMBJOOG().SetFloat("[MapsStats] Map ID: ", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("_Offsets", this.Amount);
			this.PGPEMMBJOOG().SetFloat(",0", this.Threshold);
			this.PGPEMMBJOOG().SetFloat("masterSteamID", this.Intensity);
			this.GKILCDHJFEG().SetFloat("Yes", this.Precision);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.FLOHGDECHHH(), 5);
				Graphics.Blit(temporary, temporary2, this.DEFBJOCJJKF(), 2);
				Graphics.Blit(temporary2, temporary, this.FLOHGDECHHH(), 0);
				this.IGIAPKPKGPK().SetFloat("OK", this.Amount * 1894f);
				Graphics.Blit(temporary, temporary2, this.NBMPPNFKFLB(), 1);
				Graphics.Blit(temporary2, temporary, this.FLOHGDECHHH(), 0);
				this.DEFBJOCJJKF().SetTexture("\n\n#", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x00152517 File Offset: 0x00150717
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_NoiseTilingPerChannel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x0015253C File Offset: 0x0015073C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1387f)
			{
				this.HBJJOCHGOPH = 692f;
			}
			this.DEFBJOCJJKF().SetFloat("[PlayerBase] Loaded custom model: ", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Trackpad", this.Amount);
			this.PGPEMMBJOOG().SetFloat("[MenuScene] Error: ", this.Threshold);
			this.GKILCDHJFEG().SetFloat("settings.enableselectormusic", this.Intensity);
			this.NBMPPNFKFLB().SetFloat("Reload Maps", this.Precision);
			this.HKGAONMOBMH().SetVector("Done!", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.NBMPPNFKFLB(), 1);
				Graphics.Blit(temporary, temporary2, this.HEHKGPKLAKK(), 5);
				Graphics.Blit(temporary2, temporary, this.NBMPPNFKFLB(), 1);
				this.NBMPPNFKFLB().SetFloat("_Value", this.Amount * 208f);
				Graphics.Blit(temporary, temporary2, this.IGIAPKPKGPK(), 1);
				Graphics.Blit(temporary2, temporary, this.HEHKGPKLAKK(), 0);
				this.PGPEMMBJOOG().SetTexture("_ScreenResolution", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004465 RID: 17509 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x00152710 File Offset: 0x00150910
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1275f)
			{
				this.HBJJOCHGOPH = 1888f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("key", this.Amount);
			this.FLOHGDECHHH().SetFloat("{0}_{1}", this.Threshold);
			this.GKILCDHJFEG().SetFloat("GameScene", this.Intensity);
			this.IGIAPKPKGPK().SetFloat("Scene", this.Precision);
			this.DEFBJOCJJKF().SetVector("player.linea", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.NBMPPNFKFLB(), 7);
				Graphics.Blit(temporary, temporary2, this.IGIAPKPKGPK(), 6);
				Graphics.Blit(temporary2, temporary, this.DEFBJOCJJKF(), 1);
				this.PGPEMMBJOOG().SetFloat("_Red_C", this.Amount * 1527f);
				Graphics.Blit(temporary, temporary2, this.NBMPPNFKFLB(), 6);
				Graphics.Blit(temporary2, temporary, this.IGIAPKPKGPK(), 1);
				this.PGPEMMBJOOG().SetTexture("CameraFilterPack/Real_VHS", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x001528E4 File Offset: 0x00150AE4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.GKILCDHJFEG().SetFloat("_Red_R", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("MultiplayerButton", this.Amount);
			this.DEFBJOCJJKF().SetFloat("#forever", this.Threshold);
			this.PGPEMMBJOOG().SetFloat("0,1,false", this.Intensity);
			this.GKILCDHJFEG().SetFloat("\n\n#", this.Precision);
			this.FLOHGDECHHH().SetVector("End Value should be greater than the start value, values not changed", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.IGIAPKPKGPK(), 7);
				Graphics.Blit(temporary, temporary2, this.PGPEMMBJOOG(), 8);
				Graphics.Blit(temporary2, temporary, this.DEFBJOCJJKF(), 0);
				this.GKILCDHJFEG().SetFloat("_Radius", this.Amount * 1459f);
				Graphics.Blit(temporary, temporary2, this.GKILCDHJFEG(), 1);
				Graphics.Blit(temporary2, temporary, this.KAFBNOBOIAJ(), 0);
				this.DEFBJOCJJKF().SetTexture("Case-Sensitive", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x00152AB8 File Offset: 0x00150CB8
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1801f)
			{
				this.HBJJOCHGOPH = 776f;
			}
			this.NBPKMLMCHFN.SetFloat("/Segment-[Right]", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("RoomDescriptionText", this.Amount);
			this.NBMPPNFKFLB().SetFloat("menu.selectedplaymode", this.Threshold);
			this.KAFBNOBOIAJ().SetFloat("\\\\", this.Intensity);
			this.IGIAPKPKGPK().SetFloat("CameraFilterPack/AAA_Blood", this.Precision);
			this.FLOHGDECHHH().SetVector("_Blend", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.PGPEMMBJOOG(), 2);
				Graphics.Blit(temporary, temporary2, this.KAFBNOBOIAJ(), 0);
				Graphics.Blit(temporary2, temporary, this.HKGAONMOBMH(), 0);
				this.KAFBNOBOIAJ().SetFloat("bpmgrid", this.Amount * 1792f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, this.HEHKGPKLAKK(), 1);
				this.DEFBJOCJJKF().SetTexture("st", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x00152C8C File Offset: 0x00150E8C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1258f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.DEFBJOCJJKF().SetFloat("_Params1", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_Parameter", this.Amount);
			this.HEHKGPKLAKK().SetFloat("NewMusicFileSelector", this.Threshold);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.Intensity);
			this.PGPEMMBJOOG().SetFloat("_Value5", this.Precision);
			this.NBMPPNFKFLB().SetVector("CameraFilterPack/Drawing_Manga_FlashWhite", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.NBMPPNFKFLB(), 2);
				Graphics.Blit(temporary, temporary2, this.HEHKGPKLAKK(), 7);
				Graphics.Blit(temporary2, temporary, this.GKILCDHJFEG(), 0);
				this.KAFBNOBOIAJ().SetFloat("Change Note:", this.Amount * 279f);
				Graphics.Blit(temporary, temporary2, this.IGIAPKPKGPK(), 5);
				Graphics.Blit(temporary2, temporary, this.GKILCDHJFEG(), 1);
				this.PGPEMMBJOOG().SetTexture("/", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x00152E60 File Offset: 0x00151060
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 683f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			this.HEHKGPKLAKK().SetFloat("View ({3}){0} on {1} {2}", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("YES", this.Amount);
			this.NBMPPNFKFLB().SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", this.Threshold);
			this.HKGAONMOBMH().SetFloat("value", this.Intensity);
			this.HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", this.Precision);
			this.FLOHGDECHHH().SetVector("_FarCamera", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, this.KAFBNOBOIAJ(), 4);
				Graphics.Blit(temporary, temporary2, this.PGPEMMBJOOG(), 5);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 1);
				this.NBMPPNFKFLB().SetFloat("</color>", this.Amount * 1637f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.FLOHGDECHHH().SetTexture("Write me to get one for testing :)", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x00153033 File Offset: 0x00151233
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Glow_Glow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x00153057 File Offset: 0x00151257
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x0015308E File Offset: 0x0015128E
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("DifficultyBG");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004471 RID: 17521 RVA: 0x00153105 File Offset: 0x00151305
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x0015313C File Offset: 0x0015133C
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004474 RID: 17524 RVA: 0x00153173 File Offset: 0x00151373
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x00153198 File Offset: 0x00151398
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 812f)
			{
				this.HBJJOCHGOPH = 269f;
			}
			this.NBMPPNFKFLB().SetFloat("_U", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("SaveButton", this.Amount);
			this.FLOHGDECHHH().SetFloat("MessageText", this.Threshold);
			this.PGPEMMBJOOG().SetFloat("_Offsets", this.Intensity);
			this.HKGAONMOBMH().SetFloat("workshop.", this.Precision);
			this.NBPKMLMCHFN.SetVector("_Value", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.IGIAPKPKGPK(), 1);
				Graphics.Blit(temporary, temporary2, this.HKGAONMOBMH(), 3);
				Graphics.Blit(temporary2, temporary, this.KAFBNOBOIAJ(), 0);
				this.NBPKMLMCHFN.SetFloat("_DotSize", this.Amount * 1494f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, this.GKILCDHJFEG(), 0);
				this.PGPEMMBJOOG().SetTexture(".mp3", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x0015336B File Offset: 0x0015156B
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004479 RID: 17529 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600447A RID: 17530 RVA: 0x00153390 File Offset: 0x00151590
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Precision);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 3);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount * 2f);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetTexture("_MainTex2", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600447C RID: 17532 RVA: 0x00153563 File Offset: 0x00151763
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600447D RID: 17533 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600447E RID: 17534 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004480 RID: 17536 RVA: 0x0015359A File Offset: 0x0015179A
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004481 RID: 17537 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06004482 RID: 17538 RVA: 0x001535D1 File Offset: 0x001517D1
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

	// Token: 0x06004483 RID: 17539 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004484 RID: 17540 RVA: 0x00153608 File Offset: 0x00151808
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1735f)
			{
				this.HBJJOCHGOPH = 658f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("_Far", this.Amount);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Color_Sepia", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("Classical", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("music.ogg", this.Precision);
			this.DEFBJOCJJKF().SetVector("_TimeX", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.IGIAPKPKGPK(), 6);
				Graphics.Blit(temporary, temporary2, this.GKILCDHJFEG(), 2);
				Graphics.Blit(temporary2, temporary, this.NBMPPNFKFLB(), 0);
				this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Vision_Plasma", this.Amount * 617f);
				Graphics.Blit(temporary, temporary2, this.HKGAONMOBMH(), 7);
				Graphics.Blit(temporary2, temporary, this.GKILCDHJFEG(), 0);
				this.KAFBNOBOIAJ().SetTexture("_Bloom", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004485 RID: 17541 RVA: 0x001537DB File Offset: 0x001519DB
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004486 RID: 17542 RVA: 0x001537FF File Offset: 0x001519FF
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004487 RID: 17543 RVA: 0x00153836 File Offset: 0x00151A36
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004488 RID: 17544 RVA: 0x0015385A File Offset: 0x00151A5A
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004489 RID: 17545 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600448A RID: 17546 RVA: 0x0015387E File Offset: 0x00151A7E
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600448B RID: 17547 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600448D RID: 17549 RVA: 0x00151B7B File Offset: 0x0014FD7B
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600448E RID: 17550 RVA: 0x001538A4 File Offset: 0x00151AA4
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1384f)
			{
				this.HBJJOCHGOPH = 476f;
			}
			this.PGPEMMBJOOG().SetFloat("_ChangeBlue", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Sending RPC \"", this.Amount);
			this.GKILCDHJFEG().SetFloat("_Value2", this.Threshold);
			this.FLOHGDECHHH().SetFloat("_Cible", this.Intensity);
			this.IGIAPKPKGPK().SetFloat("AvatarImage", this.Precision);
			this.PGPEMMBJOOG().SetVector("CameraFilterPack/FX_Dot_Circle", new Vector2((float)(Screen.width / fastFilter), (float)(Screen.height / fastFilter)));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.GKILCDHJFEG(), 6);
				Graphics.Blit(temporary, temporary2, this.DEFBJOCJJKF(), 4);
				Graphics.Blit(temporary2, temporary, this.IGIAPKPKGPK(), 1);
				this.FLOHGDECHHH().SetFloat("_TimeX", this.Amount * 1004f);
				Graphics.Blit(temporary, temporary2, this.FLOHGDECHHH(), 1);
				Graphics.Blit(temporary2, temporary, this.HKGAONMOBMH(), 0);
				this.HEHKGPKLAKK().SetTexture("CameraFilterPack/Gradients_Rainbow", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600448F RID: 17551 RVA: 0x00153A77 File Offset: 0x00151C77
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x00153AAE File Offset: 0x00151CAE
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x00153AE5 File Offset: 0x00151CE5
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_InvViewProj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004492 RID: 17554 RVA: 0x00153B09 File Offset: 0x00151D09
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("hand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004493 RID: 17555 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0400074E RID: 1870
	public Shader SCShader;

	// Token: 0x0400074F RID: 1871
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000750 RID: 1872
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000751 RID: 1873
	private Material BJFKDHHMLJH;

	// Token: 0x04000752 RID: 1874
	[Range(0f, 20f)]
	public float Amount = 4f;

	// Token: 0x04000753 RID: 1875
	[Range(2f, 16f)]
	public int FastFilter = 4;

	// Token: 0x04000754 RID: 1876
	[Range(0f, 1f)]
	public float Threshold = 0.5f;

	// Token: 0x04000755 RID: 1877
	[Range(0f, 1f)]
	public float Intensity = 0.75f;

	// Token: 0x04000756 RID: 1878
	[Range(-1f, 1f)]
	public float Precision = 0.56f;
}
