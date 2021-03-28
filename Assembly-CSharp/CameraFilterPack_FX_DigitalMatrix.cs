using System;
using UnityEngine;

// Token: 0x020000C1 RID: 193
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/DigitalMatrix")]
public class CameraFilterPack_FX_DigitalMatrix : MonoBehaviour
{
	// Token: 0x06003A10 RID: 14864 RVA: 0x00125E3C File Offset: 0x0012403C
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 899f)
			{
				this.HBJJOCHGOPH = 928f;
			}
			this.DKKBFFHBHJE().SetFloat("SetRoomStartTimestamp", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("shader.ghost", this.Size);
			this.NBMPPNFKFLB().SetFloat("Joystick1Button4", this.ColorR);
			this.HCGJCMDJPGD().SetFloat("/?player=", this.ColorG);
			this.EFDEIFCDAFG().SetFloat("{0}", this.ColorB);
			this.PLBEJJIHFPB().SetFloat("End index must in an integer.", this.Speed);
			this.GJHLADDCMFF().SetVector("IconFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 849f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A11 RID: 14865 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06003A12 RID: 14866 RVA: 0x00125F54 File Offset: 0x00124154
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1376f)
			{
				this.HBJJOCHGOPH = 695f;
			}
			this.LPMLLJKMAMP().SetFloat("value", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_TileTexDebug", this.Size);
			this.NBMPPNFKFLB().SetFloat("_Blue_R", this.ColorR);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.ColorG);
			this.EOCCJGIGEGJ().SetFloat("float,0", this.ColorB);
			this.CECJJMKLEAK().SetFloat("_TimeX", this.Speed);
			this.FKEOGPDLBDD().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 47f, 1469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A13 RID: 14867 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x00126069 File Offset: 0x00124269
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x001260A0 File Offset: 0x001242A0
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x001260C4 File Offset: 0x001242C4
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 326f)
			{
				this.HBJJOCHGOPH = 1697f;
			}
			this.LONNIJMNKFB().SetFloat("RecieveChatActionMessage", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("Overlay", this.Size);
			this.LONNIJMNKFB().SetFloat("duration", this.ColorR);
			this.HKGAONMOBMH().SetFloat("_SecondTex", this.ColorG);
			this.OKJOKHGJHGF().SetFloat("Failed to 'GetKeyCode' for key: ", this.ColorB);
			this.EPCGJFCCAFH().SetFloat("_Value3", this.Speed);
			this.FKEOGPDLBDD().SetVector("_SunColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1500f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A17 RID: 14871 RVA: 0x001261D9 File Offset: 0x001243D9
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A18 RID: 14872 RVA: 0x001261D9 File Offset: 0x001243D9
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A19 RID: 14873 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06003A1A RID: 14874 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003A1B RID: 14875 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06003A1C RID: 14876 RVA: 0x001261F6 File Offset: 0x001243F6
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x001261D9 File Offset: 0x001243D9
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A1F RID: 14879 RVA: 0x0012622D File Offset: 0x0012442D
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("SaveButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A20 RID: 14880 RVA: 0x00126251 File Offset: 0x00124451
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A21 RID: 14881 RVA: 0x00126288 File Offset: 0x00124488
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A22 RID: 14882 RVA: 0x001262C0 File Offset: 0x001244C0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1330f)
			{
				this.HBJJOCHGOPH = 245f;
			}
			this.PLBEJJIHFPB().SetFloat(" - PUBLISHED #", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("error", this.Size);
			this.EFDEIFCDAFG().SetFloat("Chat", this.ColorR);
			this.DKKBFFHBHJE().SetFloat("[NetworkManager] Updating current room...", this.ColorG);
			this.NBMPPNFKFLB().SetFloat("Fade", this.ColorB);
			this.OKJOKHGJHGF().SetFloat("_Blue_R", this.Speed);
			this.HNFFHCLNBDN().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1497f, 1527f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A23 RID: 14883 RVA: 0x001263D5 File Offset: 0x001245D5
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x001261D9 File Offset: 0x001243D9
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x0012640C File Offset: 0x0012460C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 478f)
			{
				this.HBJJOCHGOPH = 1098f;
			}
			this.FGENHBKMPDA().SetFloat("/", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("BadgeText", this.Size);
			this.HCGJCMDJPGD().SetFloat("unsubscribemap", this.ColorR);
			this.FKEOGPDLBDD().SetFloat("event", this.ColorG);
			this.CECJJMKLEAK().SetFloat("_", this.ColorB);
			this.HKHBBBFLGJH().SetFloat("_Offsets", this.Speed);
			this.IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1422f, 389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x00126521 File Offset: 0x00124721
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A27 RID: 14887 RVA: 0x00126558 File Offset: 0x00124758
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A28 RID: 14888 RVA: 0x0012658F File Offset: 0x0012478F
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A29 RID: 14889 RVA: 0x001261D9 File Offset: 0x001243D9
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A2A RID: 14890 RVA: 0x001265C8 File Offset: 0x001247C8
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1780f)
			{
				this.HBJJOCHGOPH = 377f;
			}
			this.IONHGBPGCHK().SetFloat("settings.enablehitsoundsinrelax", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("Texture2", this.Size);
			this.CECJJMKLEAK().SetFloat("_TimeX", this.ColorR);
			this.OKJOKHGJHGF().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", this.ColorG);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.ColorB);
			this.FKEOGPDLBDD().SetFloat("Joystick1Button9", this.Speed);
			this.FGENHBKMPDA().SetVector("Anomaly_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 936f, 1801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A2B RID: 14891 RVA: 0x001266E0 File Offset: 0x001248E0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1382f)
			{
				this.HBJJOCHGOPH = 618f;
			}
			this.LONNIJMNKFB().SetFloat("_MatrixSize", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_VignettingDirt", this.Size);
			this.LONNIJMNKFB().SetFloat("effector", this.ColorR);
			this.FKEOGPDLBDD().SetFloat("ResetSpeed", this.ColorG);
			this.CFEDGDGBCHE().SetFloat("_Value2", this.ColorB);
			this.LONNIJMNKFB().SetFloat("_Value2", this.Speed);
			this.IONHGBPGCHK().SetVector("_Tint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1011f, 736f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A2C RID: 14892 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003A2D RID: 14893 RVA: 0x001267F8 File Offset: 0x001249F8
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 626f)
			{
				this.HBJJOCHGOPH = 1849f;
			}
			this.PLBEJJIHFPB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("checkpoint", this.Size);
			this.GJHLADDCMFF().SetFloat(".wav", this.ColorR);
			this.HCGJCMDJPGD().SetFloat("Xbox Home", this.ColorG);
			this.CFEDGDGBCHE().SetFloat("_ProjectToPixelMatrix", this.ColorB);
			this.DKNJGHFLAIF().SetFloat("source", this.Speed);
			this.FGENHBKMPDA().SetVector("#finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 719f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A2E RID: 14894 RVA: 0x0012690D File Offset: 0x00124B0D
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A2F RID: 14895 RVA: 0x00126934 File Offset: 0x00124B34
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1665f)
			{
				this.HBJJOCHGOPH = 403f;
			}
			this.OKJOKHGJHGF().SetFloat("MapperNameText", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_Value5", this.Size);
			this.PLBEJJIHFPB().SetFloat("received</b>\n#reason: ", this.ColorR);
			this.FGENHBKMPDA().SetFloat("Drop_Near", this.ColorG);
			this.CECJJMKLEAK().SetFloat("UI Extensions/UIAdditive", this.ColorB);
			this.HCGJCMDJPGD().SetFloat("Select", this.Speed);
			this.DKNJGHFLAIF().SetVector("Texture2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 686f, 889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A30 RID: 14896 RVA: 0x001261D9 File Offset: 0x001243D9
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A31 RID: 14897 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06003A32 RID: 14898 RVA: 0x00126A49 File Offset: 0x00124C49
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("SetPosition");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A33 RID: 14899 RVA: 0x00126A70 File Offset: 0x00124C70
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 1823f;
			}
			this.GJHLADDCMFF().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Status: ", this.Size);
			this.CECJJMKLEAK().SetFloat("[Right]", this.ColorR);
			this.PLBEJJIHFPB().SetFloat("InventoryContent", this.ColorG);
			this.DKNJGHFLAIF().SetFloat("[PlayerController] ", this.ColorB);
			this.PLBEJJIHFPB().SetFloat("Use \"/help\" for commands list", this.Speed);
			this.HCGJCMDJPGD().SetVector("player.licenceaccepted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 541f, 1541f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A34 RID: 14900 RVA: 0x001261D9 File Offset: 0x001243D9
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A35 RID: 14901 RVA: 0x00126B85 File Offset: 0x00124D85
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A36 RID: 14902 RVA: 0x00126BBC File Offset: 0x00124DBC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 286f)
			{
				this.HBJJOCHGOPH = 777f;
			}
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/TV_BrokenGlass", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("2hands", this.Size);
			this.EOCCJGIGEGJ().SetFloat("note.1", this.ColorR);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Colors_Adjust_ColorRGB", this.ColorG);
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.ColorB);
			this.LPMLLJKMAMP().SetFloat("key", this.Speed);
			this.CFEDGDGBCHE().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1818f, 974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A37 RID: 14903 RVA: 0x001261D9 File Offset: 0x001243D9
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x001261D9 File Offset: 0x001243D9
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x00126CD1 File Offset: 0x00124ED1
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x00126D08 File Offset: 0x00124F08
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A3B RID: 14907 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06003A3C RID: 14908 RVA: 0x00126D3F File Offset: 0x00124F3F
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A3D RID: 14909 RVA: 0x00126D63 File Offset: 0x00124F63
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Warp2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x00126D87 File Offset: 0x00124F87
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x00126DBE File Offset: 0x00124FBE
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003A42 RID: 14914 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x00126DF5 File Offset: 0x00124FF5
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_DigitalMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A44 RID: 14916 RVA: 0x001261D9 File Offset: 0x001243D9
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003A46 RID: 14918 RVA: 0x00126E19 File Offset: 0x00125019
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("In Main Menu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A47 RID: 14919 RVA: 0x00126E3D File Offset: 0x0012503D
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A48 RID: 14920 RVA: 0x00126E64 File Offset: 0x00125064
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.ColorR);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ColorG);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.ColorB);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A49 RID: 14921 RVA: 0x00126F79 File Offset: 0x00125179
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x001261D9 File Offset: 0x001243D9
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x001261D9 File Offset: 0x001243D9
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x00126FB0 File Offset: 0x001251B0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1987f)
			{
				this.HBJJOCHGOPH = 749f;
			}
			this.HKGAONMOBMH().SetFloat("Depth textures aren't supported on this device ({0})", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("No connection to item server!", this.Size);
			this.DKNJGHFLAIF().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.ColorR);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Atmosphere_Rain", this.ColorG);
			this.HNFFHCLNBDN().SetFloat(".icon", this.ColorB);
			this.GJHLADDCMFF().SetFloat("_Near", this.Speed);
			this.NBMPPNFKFLB().SetVector("Joystick1Button4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 371f, 419f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x001270C5 File Offset: 0x001252C5
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x001261D9 File Offset: 0x001243D9
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x00127151 File Offset: 0x00125351
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A52 RID: 14930 RVA: 0x00127178 File Offset: 0x00125378
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1068f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.FKEOGPDLBDD().SetFloat("BloomShaderValueSlider", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("HiddenToggle", this.Size);
			this.DKKBFFHBHJE().SetFloat("22x1", this.ColorR);
			this.HCGJCMDJPGD().SetFloat("settings.customdataskin", this.ColorG);
			this.EPCGJFCCAFH().SetFloat("_MainTex", this.ColorB);
			this.CECJJMKLEAK().SetFloat("DataText", this.Speed);
			this.HNFFHCLNBDN().SetVector("powerup.0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1246f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A53 RID: 14931 RVA: 0x001261D9 File Offset: 0x001243D9
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x001261D9 File Offset: 0x001243D9
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x001261D9 File Offset: 0x001243D9
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A56 RID: 14934 RVA: 0x0012728D File Offset: 0x0012548D
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x001272B4 File Offset: 0x001254B4
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 309f)
			{
				this.HBJJOCHGOPH = 986f;
			}
			this.HCGJCMDJPGD().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("#forever", this.Size);
			this.EPCGJFCCAFH().SetFloat("[SaveSystem] Outdated savefile found", this.ColorR);
			this.NBPKMLMCHFN.SetFloat(",", this.ColorG);
			this.CFEDGDGBCHE().SetFloat("_Green_C", this.ColorB);
			this.NBMPPNFKFLB().SetFloat(" registered.", this.Speed);
			this.CFEDGDGBCHE().SetVector("RPCs can only be sent in rooms. Call of \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x001261D9 File Offset: 0x001243D9
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A59 RID: 14937 RVA: 0x001261D9 File Offset: 0x001243D9
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A5A RID: 14938 RVA: 0x001273C9 File Offset: 0x001255C9
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A5B RID: 14939 RVA: 0x001273ED File Offset: 0x001255ED
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A5C RID: 14940 RVA: 0x00127424 File Offset: 0x00125624
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x0012745B File Offset: 0x0012565B
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003A5E RID: 14942 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x0012747F File Offset: 0x0012567F
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A60 RID: 14944 RVA: 0x001261D9 File Offset: 0x001243D9
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A61 RID: 14945 RVA: 0x001274B6 File Offset: 0x001256B6
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A62 RID: 14946 RVA: 0x001261D9 File Offset: 0x001243D9
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A63 RID: 14947 RVA: 0x001274DA File Offset: 0x001256DA
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A64 RID: 14948 RVA: 0x001261D9 File Offset: 0x001243D9
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x001261D9 File Offset: 0x001243D9
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06003A66 RID: 14950 RVA: 0x00127511 File Offset: 0x00125711
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

	// Token: 0x06003A67 RID: 14951 RVA: 0x00127548 File Offset: 0x00125748
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 298f)
			{
				this.HBJJOCHGOPH = 1160f;
			}
			this.FGENHBKMPDA().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_Level", this.Size);
			this.FGENHBKMPDA().SetFloat("_TimeX", this.ColorR);
			this.CFEDGDGBCHE().SetFloat("Drop_Near", this.ColorG);
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.ColorB);
			this.KGOLDDBHIFN().SetFloat("VIGNETTE_DESAT", this.Speed);
			this.NBPKMLMCHFN.SetVector("Start index must in an integer.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1100f, 606f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x001261D9 File Offset: 0x001243D9
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A6A RID: 14954 RVA: 0x0012765D File Offset: 0x0012585D
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A6B RID: 14955 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06003A6D RID: 14957 RVA: 0x001261D9 File Offset: 0x001243D9
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A6E RID: 14958 RVA: 0x00127681 File Offset: 0x00125881
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A6F RID: 14959 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003A70 RID: 14960 RVA: 0x001276B8 File Offset: 0x001258B8
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A71 RID: 14961 RVA: 0x001261F6 File Offset: 0x001243F6
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003A72 RID: 14962 RVA: 0x001276F0 File Offset: 0x001258F0
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1948f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.HCGJCMDJPGD().SetFloat("_Near", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("USE_DIAG_SEARCH", this.Size);
			this.HNFFHCLNBDN().SetFloat("_Value2", this.ColorR);
			this.NBMPPNFKFLB().SetFloat("_Value", this.ColorG);
			this.CECJJMKLEAK().SetFloat("PublishButton", this.ColorB);
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.Speed);
			this.PLBEJJIHFPB().SetVector("1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 220f, 213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A73 RID: 14963 RVA: 0x001261D9 File Offset: 0x001243D9
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A74 RID: 14964 RVA: 0x00127808 File Offset: 0x00125A08
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1446f)
			{
				this.HBJJOCHGOPH = 1398f;
			}
			this.HCGJCMDJPGD().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.Size);
			this.PLBEJJIHFPB().SetFloat("float,0", this.ColorR);
			this.DKKBFFHBHJE().SetFloat("Preparing content...", this.ColorG);
			this.DKNJGHFLAIF().SetFloat("#FFFFFF", this.ColorB);
			this.FGENHBKMPDA().SetFloat("#FFDA44", this.Speed);
			this.FKEOGPDLBDD().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 710f, 1831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A75 RID: 14965 RVA: 0x001261D9 File Offset: 0x001243D9
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A76 RID: 14966 RVA: 0x0012791D File Offset: 0x00125B1D
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("{0} minutes ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003A77 RID: 14967 RVA: 0x00127944 File Offset: 0x00125B44
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1041f)
			{
				this.HBJJOCHGOPH = 1082f;
			}
			this.CFEDGDGBCHE().SetFloat("USE_UV_BASED_REPROJECTION", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Anomaly_Far", this.Size);
			this.IFMAPIDFNLI().SetFloat("position", this.ColorR);
			this.LONNIJMNKFB().SetFloat("_Value", this.ColorG);
			this.HCGJCMDJPGD().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", this.ColorB);
			this.OKJOKHGJHGF().SetFloat("The observed monobehaviour (", this.Speed);
			this.GJHLADDCMFF().SetVector("reset", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1462f, 1880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A78 RID: 14968 RVA: 0x001261D9 File Offset: 0x001243D9
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x001261D9 File Offset: 0x001243D9
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x001261D9 File Offset: 0x001243D9
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x00127A5C File Offset: 0x00125C5C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1372f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.EOCCJGIGEGJ().SetFloat("\"", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("selector", this.Size);
			this.NBPKMLMCHFN.SetFloat("[MapEditor] Prepairing map editor...", this.ColorR);
			this.HKGAONMOBMH().SetFloat("_MatrixSpeed", this.ColorG);
			this.DKKBFFHBHJE().SetFloat("cameramovements:", this.ColorB);
			this.EFDEIFCDAFG().SetFloat("Data/Maps/", this.Speed);
			this.CECJJMKLEAK().SetVector("EventSystem", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1899f, 493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x00127B71 File Offset: 0x00125D71
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000663 RID: 1635
	public Shader SCShader;

	// Token: 0x04000664 RID: 1636
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000665 RID: 1637
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000666 RID: 1638
	private Material BJFKDHHMLJH;

	// Token: 0x04000667 RID: 1639
	[Range(0.4f, 5f)]
	public float Size = 1f;

	// Token: 0x04000668 RID: 1640
	[Range(-10f, 10f)]
	public float Speed = 1f;

	// Token: 0x04000669 RID: 1641
	[Range(-1f, 1f)]
	public float ColorR = -1f;

	// Token: 0x0400066A RID: 1642
	[Range(-1f, 1f)]
	public float ColorG = 1f;

	// Token: 0x0400066B RID: 1643
	[Range(-1f, 1f)]
	public float ColorB = -1f;
}
