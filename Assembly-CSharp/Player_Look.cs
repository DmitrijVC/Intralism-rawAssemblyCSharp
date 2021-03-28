using System;
using UnityEngine;

// Token: 0x0200015A RID: 346
[AddComponentMenu("Hard Shell Studios/Examples/Player Look")]
public class Player_Look : MonoBehaviour
{
	// Token: 0x0600676B RID: 26475 RVA: 0x001F0894 File Offset: 0x001EEA94
	private void LEAHIBJDMBI()
	{
		float num = hardInput.GetAxis("BloomShaderValueSlider", 1259f) + hardInput.GMNJKCNIPGD("#newhighscore", 219f);
		float y = hardInput.GMNJKCNIPGD(". Verify the Prefab is in a Resources folder (and not in a subfolder)", 82f) + hardInput.PMJHMIKCPBI("Mouse1", 1215f);
		base.transform.parent.eulerAngles += new Vector3(1712f, y, 649f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 203f, 112f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1588f, 1187f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 607f);
	}

	// Token: 0x0600676D RID: 26477 RVA: 0x001F09AC File Offset: 0x001EEBAC
	private void KMKLDAJLCNM()
	{
		float num = hardInput.GMNJKCNIPGD("_Offsets", 551f) + hardInput.GMNJKCNIPGD("?", 602f);
		float y = hardInput.GMNJKCNIPGD("_MainTex2", 1066f) + hardInput.PMJHMIKCPBI("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", 1676f);
		base.transform.parent.eulerAngles += new Vector3(767f, y, 974f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 983f, 1966f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1719f, 494f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1728f);
	}

	// Token: 0x0600676E RID: 26478 RVA: 0x001F0AC4 File Offset: 0x001EECC4
	private void JAAJECBCCFM()
	{
		float num = hardInput.PMJHMIKCPBI("Failed to Instantiate prefab: ", 1807f) + hardInput.GMNJKCNIPGD("_TimeX", 925f);
		float y = hardInput.PMJHMIKCPBI("\"", 1063f) + hardInput.PMJHMIKCPBI("Mouse X", 969f);
		base.transform.parent.eulerAngles += new Vector3(974f, y, 234f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1370f, 181f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 419f, 1113f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1208f);
	}

	// Token: 0x0600676F RID: 26479 RVA: 0x001F0BDC File Offset: 0x001EEDDC
	private void MAOCOEGAFND()
	{
		float num = hardInput.PMJHMIKCPBI("Exception while connecting to: ", 10f) + hardInput.PMJHMIKCPBI("_MainTex2", 406f);
		float y = hardInput.GetAxis("<b>", 1020f) + hardInput.PMJHMIKCPBI("LevelFolderInputField", 1487f);
		base.transform.parent.eulerAngles += new Vector3(580f, y, 1994f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1395f, 1883f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1942f, 1620f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1880f);
	}

	// Token: 0x06006770 RID: 26480 RVA: 0x001F0CF4 File Offset: 0x001EEEF4
	private void Update()
	{
		float num = hardInput.GetAxis("MouseY", 1f) + hardInput.GetAxis("ControllerRightY", 1f);
		float y = hardInput.GetAxis("MouseX", 1f) + hardInput.GetAxis("ControllerRightX", 1f);
		base.transform.parent.eulerAngles += new Vector3(0f, y, 0f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, -80f, 60f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, -80f, 60f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 0f);
	}

	// Token: 0x06006771 RID: 26481 RVA: 0x001F0E0C File Offset: 0x001EF00C
	private void MMBPLGGLPDB()
	{
		float num = hardInput.GMNJKCNIPGD("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 962f) + hardInput.PMJHMIKCPBI("AudioSampler", 453f);
		float y = hardInput.PMJHMIKCPBI("float,1.5", 1117f) + hardInput.PMJHMIKCPBI("CameraFilterPack/VHS_Tracking", 560f);
		base.transform.parent.eulerAngles += new Vector3(1895f, y, 160f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1537f, 1116f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1558f, 1910f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1594f);
	}

	// Token: 0x06006772 RID: 26482 RVA: 0x001F0F24 File Offset: 0x001EF124
	private void MFMIODIAKNI()
	{
		float num = hardInput.GMNJKCNIPGD("cancel", 1711f) + hardInput.GMNJKCNIPGD("' ping: ", 1363f);
		float y = hardInput.GetAxis("GlassDistortion", 1642f) + hardInput.GMNJKCNIPGD("FavoriteButton", 1629f);
		base.transform.parent.eulerAngles += new Vector3(83f, y, 1560f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 650f, 1660f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 308f, 1474f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1876f);
	}

	// Token: 0x06006773 RID: 26483 RVA: 0x001F103C File Offset: 0x001EF23C
	private void BGFJOEPFOPM()
	{
		float num = hardInput.GMNJKCNIPGD("Parameter levelId must be int or string!", 655f) + hardInput.GetAxis("_Size", 424f);
		float y = hardInput.GetAxis(".", 256f) + hardInput.GMNJKCNIPGD("BadgeText", 815f);
		base.transform.parent.eulerAngles += new Vector3(1052f, y, 1779f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1662f, 523f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 952f, 1556f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1979f);
	}

	// Token: 0x06006774 RID: 26484 RVA: 0x001F1154 File Offset: 0x001EF354
	private void AGMJDGHLBMN()
	{
		float num = hardInput.GMNJKCNIPGD("2hands", 513f) + hardInput.GetAxis("GraphicsQualitySlider", 355f);
		float y = hardInput.GMNJKCNIPGD("settings.customdataskin", 793f) + hardInput.PMJHMIKCPBI("_Offsets", 722f);
		base.transform.parent.eulerAngles += new Vector3(1493f, y, 1027f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1570f, 1030f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 66f, 231f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 494f);
	}

	// Token: 0x06006775 RID: 26485 RVA: 0x001F126C File Offset: 0x001EF46C
	private void OCMKCBBCEFG()
	{
		float num = hardInput.GetAxis("player.egglipszerotwo", 395f) + hardInput.PMJHMIKCPBI(".lastCheckpoint.bgcolor", 452f);
		float y = hardInput.GetAxis("Case-Sensitive", 713f) + hardInput.GMNJKCNIPGD("_Value2", 348f);
		base.transform.parent.eulerAngles += new Vector3(1029f, y, 1724f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 141f, 1499f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1488f, 1645f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1975f);
	}

	// Token: 0x06006776 RID: 26486 RVA: 0x001F1384 File Offset: 0x001EF584
	private void NKLIHNJCHOG()
	{
		float num = hardInput.GMNJKCNIPGD("SteamManager", 1201f) + hardInput.GetAxis("_Value", 1780f);
		float y = hardInput.PMJHMIKCPBI("PLAY [SPACE]", 546f) + hardInput.GMNJKCNIPGD("_Distortion", 919f);
		base.transform.parent.eulerAngles += new Vector3(1738f, y, 88f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1545f, 684f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 910f, 1939f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1234f);
	}

	// Token: 0x06006777 RID: 26487 RVA: 0x001F149C File Offset: 0x001EF69C
	private void JHPOIOELNCG()
	{
		float num = hardInput.GetAxis("Skipping EstablishEncryption. Protocol is secure.", 1615f) + hardInput.GetAxis("_Red_B", 1418f);
		float y = hardInput.GetAxis("set", 323f) + hardInput.PMJHMIKCPBI("_ScreenResolution", 1457f);
		base.transform.parent.eulerAngles += new Vector3(1084f, y, 866f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1404f, 1658f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1672f, 276f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1541f);
	}

	// Token: 0x06006778 RID: 26488 RVA: 0x001F15B4 File Offset: 0x001EF7B4
	private void AEIJFLJEABG()
	{
		float num = hardInput.GetAxis("stretchWidth", 900f) + hardInput.GetAxis("player.xp", 714f);
		float y = hardInput.GMNJKCNIPGD("ItemNameBGImage", 1453f) + hardInput.GMNJKCNIPGD("\n", 1036f);
		base.transform.parent.eulerAngles += new Vector3(338f, y, 774f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1743f, 1339f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 842f, 367f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 978f);
	}

	// Token: 0x06006779 RID: 26489 RVA: 0x001F16CC File Offset: 0x001EF8CC
	private void LLJLDLLNFBH()
	{
		float num = hardInput.GetAxis("No Dispatcher exists in the scene. Actions will not be invoked!", 324f) + hardInput.PMJHMIKCPBI("CameraFilterPack/Distortion_BigFace", 731f);
		float y = hardInput.GetAxis("PhotonMono", 329f) + hardInput.GetAxis(".b", 935f);
		base.transform.parent.eulerAngles += new Vector3(920f, y, 1032f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 739f, 555f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 393f, 440f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1874f);
	}

	// Token: 0x0600677A RID: 26490 RVA: 0x001F17E4 File Offset: 0x001EF9E4
	private void AAPKBNDHBLI()
	{
		float num = hardInput.PMJHMIKCPBI(" registered.", 796f) + hardInput.GetAxis("Current xp: ", 1293f);
		float y = hardInput.GMNJKCNIPGD("ConfigVersionSlider", 1703f) + hardInput.GMNJKCNIPGD("\r", 1047f);
		base.transform.parent.eulerAngles += new Vector3(450f, y, 1937f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 627f, 1174f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1707f, 51f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1727f);
	}

	// Token: 0x0600677B RID: 26491 RVA: 0x001F18FC File Offset: 0x001EFAFC
	private void FBMDHDBELEK()
	{
		float num = hardInput.PMJHMIKCPBI("MainThreadExecuter", 1652f) + hardInput.GMNJKCNIPGD("https://steamcommunity.com/app/513510/workshop/", 729f);
		float y = hardInput.GMNJKCNIPGD("Run a command for data system", 1877f) + hardInput.GetAxis("Save the map before exiting?", 1223f);
		base.transform.parent.eulerAngles += new Vector3(1045f, y, 1746f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 1736f, 887f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 1792f, 228f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 1485f);
	}

	// Token: 0x0600677C RID: 26492 RVA: 0x001F1A14 File Offset: 0x001EFC14
	private void CFIAKIJAILI()
	{
		float num = hardInput.PMJHMIKCPBI("Dec", 1583f) + hardInput.GetAxis("CorrectHitsScoreText", 1726f);
		float y = hardInput.PMJHMIKCPBI("_VignetteDesat", 1068f) + hardInput.GetAxis("/", 503f);
		base.transform.parent.eulerAngles += new Vector3(1157f, y, 1729f) * this.speedX;
		this.EHMFFCEONCO = base.transform.eulerAngles.y;
		if (this.inverted)
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + num * this.speedY, 785f, 632f);
		}
		else
		{
			this.MEPPLCHOHBA = Mathf.Clamp(this.MEPPLCHOHBA + -num * this.speedY, 784f, 531f);
		}
		base.transform.rotation = Quaternion.Euler(this.MEPPLCHOHBA, this.EHMFFCEONCO, 179f);
	}

	// Token: 0x04000A9A RID: 2714
	public bool inverted;

	// Token: 0x04000A9B RID: 2715
	public float speedX;

	// Token: 0x04000A9C RID: 2716
	public float speedY;

	// Token: 0x04000A9D RID: 2717
	private float EHMFFCEONCO;

	// Token: 0x04000A9E RID: 2718
	private float MEPPLCHOHBA;
}
