using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003BC RID: 956
public class IncreseAlpha : MonoBehaviour
{
	// Token: 0x0600D720 RID: 55072 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void DFDGNOCPJEJ(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D721 RID: 55073 RVA: 0x004CBA5C File Offset: 0x004C9C5C
	private void JBCNIPJDPJB()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1477f)
			{
				num2 = 1365f * base.transform.localPosition.z + 427f;
			}
			else
			{
				num2 = 190f * base.transform.localPosition.z + 1166f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", Mathf.Lerp(material.GetFloat("Set camera background color"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 816f));
				}
				else
				{
					material.SetFloat("masterSteamID", Mathf.Lerp(material.GetFloat("Set sun directionVector - in which direction sun will grow on beat"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 325f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)3)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D722 RID: 55074 RVA: 0x004CBCD8 File Offset: 0x004C9ED8
	public void EMOCEKPLGBK()
	{
		this.time = 946f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("[LevelEditorScene] Error: Timeout :S", this.maxAlpha);
		}
	}

	// Token: 0x0600D723 RID: 55075 RVA: 0x004CBD4C File Offset: 0x004C9F4C
	private void LMBDNPLDGIJ()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1995f)
			{
				num2 = 1968f * base.transform.localPosition.z + 1357f;
			}
			else
			{
				num2 = 691f * base.transform.localPosition.z + 1651f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("Set particles color", Mathf.Lerp(material.GetFloat("Editor/"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 231f));
				}
				else
				{
					material.SetFloat("_Value7", Mathf.Lerp(material.GetFloat("PhotonView with ID "), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 24f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D724 RID: 55076 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void PNDICCKBLCB(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D725 RID: 55077 RVA: 0x004CBFC8 File Offset: 0x004CA1C8
	public void CFKJHLOEDFO()
	{
		this.time = 887f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", this.maxAlpha);
		}
	}

	// Token: 0x0600D726 RID: 55078 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void DDLBJKMHMIH(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D727 RID: 55079 RVA: 0x004CC03C File Offset: 0x004CA23C
	private void BGDONBMDPGM()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 745f)
			{
				num2 = 1641f * base.transform.localPosition.z + 747f;
			}
			else
			{
				num2 = 856f * base.transform.localPosition.z + 617f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("[LevelEditorScene] Reloaded config for \"", Mathf.Lerp(material.GetFloat("Gameplay/LobbyPlayerIconElement"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 1374f));
				}
				else
				{
					material.SetFloat("original.tutorial", Mathf.Lerp(material.GetFloat("score"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 701f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)5)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D728 RID: 55080 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void SetAmplValue(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D729 RID: 55081 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void OFKCJAPIDPJ(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D72A RID: 55082 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void FKCCNAJDJJK(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D72B RID: 55083 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void CGOLDBLKGGB(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D72C RID: 55084 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void DDALBJCCLPB(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D72D RID: 55085 RVA: 0x004CC2C4 File Offset: 0x004CA4C4
	public void EJLKPLOEEEP()
	{
		this.time = 1358f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("failed", this.maxAlpha);
		}
	}

	// Token: 0x0600D72E RID: 55086 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void PMLGEEDJMDO(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D72F RID: 55087 RVA: 0x004CC338 File Offset: 0x004CA538
	public void LCKKDMKJJEF()
	{
		this.time = 733f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("SaveButton", this.maxAlpha);
		}
	}

	// Token: 0x0600D730 RID: 55088 RVA: 0x004CC3AC File Offset: 0x004CA5AC
	private void GHILDCBCDJI()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1271f)
			{
				num2 = 1265f * base.transform.localPosition.z + 677f;
			}
			else
			{
				num2 = 1479f * base.transform.localPosition.z + 669f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("shader.frost", Mathf.Lerp(material.GetFloat("RarityImage"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 273f));
				}
				else
				{
					material.SetFloat(". Using max value: 255.", Mathf.Lerp(material.GetFloat("-1"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1042f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)3)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D731 RID: 55089 RVA: 0x004CC628 File Offset: 0x004CA828
	private void PAKPHKPDKGE()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("Use ticket: "))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D732 RID: 55090 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void JGNOEIINHMF(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D733 RID: 55091 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void MCKADBKLPCB(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D734 RID: 55092 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void JPDDIAHAFKC(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D735 RID: 55093 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void CDKCKJPPIHO(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D736 RID: 55094 RVA: 0x004CC6A8 File Offset: 0x004CA8A8
	private void Update()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 0f)
			{
				num2 = 0.07692308f * base.transform.localPosition.z + 1f;
			}
			else
			{
				num2 = -0.07692308f * base.transform.localPosition.z + 1f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("_EmissionGain", Mathf.Lerp(material.GetFloat("_EmissionGain"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 4f));
				}
				else
				{
					material.SetFloat("_EmissionGain", Mathf.Lerp(material.GetFloat("_EmissionGain"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 4f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == Mode.TextAlpha)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D737 RID: 55095 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void OJLGCMDKELK(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D738 RID: 55096 RVA: 0x004CC924 File Offset: 0x004CAB24
	private void EPEGAEGDJAM()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("EditMenu"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D739 RID: 55097 RVA: 0x004CC9A4 File Offset: 0x004CABA4
	public void CKJCPBPMBFF()
	{
		this.time = 1701f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("&page=", this.maxAlpha);
		}
	}

	// Token: 0x0600D73A RID: 55098 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void HLBCLHNDNKF(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D73B RID: 55099 RVA: 0x004CCA18 File Offset: 0x004CAC18
	private void OCMKCBBCEFG()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1531f)
			{
				num2 = 1244f * base.transform.localPosition.z + 1218f;
			}
			else
			{
				num2 = 1039f * base.transform.localPosition.z + 41f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("^", Mathf.Lerp(material.GetFloat("CameraFilterPack/TV_WideScreenCircle"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 375f));
				}
				else
				{
					material.SetFloat("CameraFilterPack/TV_Chromatical2", Mathf.Lerp(material.GetFloat("maxScore"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 265f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D73C RID: 55100 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void MMFNIDPPELO(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D73D RID: 55101 RVA: 0x004CCC94 File Offset: 0x004CAE94
	public void Init()
	{
		this.time = 5f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("_EmissionGain", this.maxAlpha);
		}
	}

	// Token: 0x0600D73E RID: 55102 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void CBNKLCNADAG(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D73F RID: 55103 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void MPBKLEANBBA(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D740 RID: 55104 RVA: 0x004CCD08 File Offset: 0x004CAF08
	private void CFIAKIJAILI()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 170f)
			{
				num2 = 231f * base.transform.localPosition.z + 732f;
			}
			else
			{
				num2 = 924f * base.transform.localPosition.z + 1943f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("maphash", Mathf.Lerp(material.GetFloat("_MainTex2"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 814f));
				}
				else
				{
					material.SetFloat("id", Mathf.Lerp(material.GetFloat("note.4"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1822f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)5)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D741 RID: 55105 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void MDIFMKCNBBA(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D742 RID: 55106 RVA: 0x004CCF84 File Offset: 0x004CB184
	public void PJILLPKFCPO()
	{
		this.time = 1148f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat(" not exist", this.maxAlpha);
		}
	}

	// Token: 0x0600D743 RID: 55107 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void FMOPCDHGMMK(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D744 RID: 55108 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void MFPOGPELLOB(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D745 RID: 55109 RVA: 0x004CCFF8 File Offset: 0x004CB1F8
	private void NKLIHNJCHOG()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 853f)
			{
				num2 = 1179f * base.transform.localPosition.z + 803f;
			}
			else
			{
				num2 = 1369f * base.transform.localPosition.z + 32f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("_Red_G", Mathf.Lerp(material.GetFloat("_DiffuseColor"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 479f));
				}
				else
				{
					material.SetFloat("mapselector.filter.subscribedonly", Mathf.Lerp(material.GetFloat("<color=#"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1147f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)5)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D746 RID: 55110 RVA: 0x004CD274 File Offset: 0x004CB474
	public void HBKEHHCMMBN()
	{
		this.time = 1178f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("Best region found in PlayerPrefs. Connecting to: ", this.maxAlpha);
		}
	}

	// Token: 0x0600D747 RID: 55111 RVA: 0x004CD2E8 File Offset: 0x004CB4E8
	public void PIEPPKMBJHI()
	{
		this.time = 1724f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("UseScanLineSize", this.maxAlpha);
		}
	}

	// Token: 0x0600D748 RID: 55112 RVA: 0x004CD35C File Offset: 0x004CB55C
	public void EKOAKKNGGGI()
	{
		this.time = 28f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("Object ID. Case-Sensitive", this.maxAlpha);
		}
	}

	// Token: 0x0600D749 RID: 55113 RVA: 0x004CD3D0 File Offset: 0x004CB5D0
	private void FEHCNJLLJMP()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty(":\n"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D74A RID: 55114 RVA: 0x004CD450 File Offset: 0x004CB650
	public void FIMJABKECNG()
	{
		this.time = 1196f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("#onfirstranktext", this.maxAlpha);
		}
	}

	// Token: 0x0600D74B RID: 55115 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void OECCKNFPEJK(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D74C RID: 55116 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void NFKMIOJGFMM(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D74D RID: 55117 RVA: 0x004CD4C4 File Offset: 0x004CB6C4
	private void KFACDBHDAOD()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1368f)
			{
				num2 = 1389f * base.transform.localPosition.z + 943f;
			}
			else
			{
				num2 = 787f * base.transform.localPosition.z + 621f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("maps.", Mathf.Lerp(material.GetFloat("_Value2"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 1248f));
				}
				else
				{
					material.SetFloat("/", Mathf.Lerp(material.GetFloat("_FarCamera"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1197f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)5)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D74E RID: 55118 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void EPAJHKHCMHJ(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D74F RID: 55119 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void GBLLEBPBDIA(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D750 RID: 55120 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void LICADKMAFCD(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D751 RID: 55121 RVA: 0x004CD740 File Offset: 0x004CB940
	private void Start()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			foreach (Material material in renderer.materials)
			{
				if (material.HasProperty("_EmissionGain"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D752 RID: 55122 RVA: 0x004CD7C0 File Offset: 0x004CB9C0
	private void CCLNNLCOPBL()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_TileMaxLoop"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D753 RID: 55123 RVA: 0x004CD840 File Offset: 0x004CBA40
	private void FMNPFCHBLJF()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			foreach (Material material in renderer.materials)
			{
				if (material.HasProperty("CameraFilterPack_Atmosphere_Rain_FX"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D754 RID: 55124 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void AHNBCMOPCBI(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D755 RID: 55125 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void NPLBOOJODHD(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D756 RID: 55126 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void DLAFGJIIKFB(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D757 RID: 55127 RVA: 0x004CD8C0 File Offset: 0x004CBAC0
	private void JNBPKNNBMDI()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 1430f)
			{
				num2 = 766f * base.transform.localPosition.z + 1453f;
			}
			else
			{
				num2 = 630f * base.transform.localPosition.z + 1135f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("stretchWidth", Mathf.Lerp(material.GetFloat("_TimeX"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 1798f));
				}
				else
				{
					material.SetFloat("_TimeX", Mathf.Lerp(material.GetFloat("_Red_C"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1150f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)7)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D758 RID: 55128 RVA: 0x004CDB3C File Offset: 0x004CBD3C
	private void IBHACCEEFFI()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 377f)
			{
				num2 = 192f * base.transform.localPosition.z + 928f;
			}
			else
			{
				num2 = 1284f * base.transform.localPosition.z + 424f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("settings.selectormapsperpage", Mathf.Lerp(material.GetFloat("_PColor"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 1821f));
				}
				else
				{
					material.SetFloat("DPADVER", Mathf.Lerp(material.GetFloat("0.00:0.00"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 215f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)5)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D759 RID: 55129 RVA: 0x004CDDB8 File Offset: 0x004CBFB8
	private void MJEFMIPLFAB()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			foreach (Material material in renderer.materials)
			{
				if (material.HasProperty("_Speed"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D75A RID: 55130 RVA: 0x004CDE38 File Offset: 0x004CC038
	private void GPNAOAKCMHC()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty("warning: Audio Source: "))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D75B RID: 55131 RVA: 0x004CDEB8 File Offset: 0x004CC0B8
	private void DAHFFNNIGML()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("id"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D75C RID: 55132 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void IEAMGJHEGMA(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D75D RID: 55133 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void SetMaxAlpha(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D75E RID: 55134 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void NPIOMADKGPP(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D75F RID: 55135 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void BAAPHBKJKLI(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D760 RID: 55136 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void FKKFMFPBNLC(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D761 RID: 55137 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void BBGLEFNEJEK(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D762 RID: 55138 RVA: 0x004CDF38 File Offset: 0x004CC138
	private void BMODOIJGIOO()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 314f)
			{
				num2 = 153f * base.transform.localPosition.z + 65f;
			}
			else
			{
				num2 = 1594f * base.transform.localPosition.z + 1453f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("_Overlay", Mathf.Lerp(material.GetFloat("_Value4"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 76f));
				}
				else
				{
					material.SetFloat("RedoButton", Mathf.Lerp(material.GetFloat(".played"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 1822f));
				}
			}
		}
		if (this.mode == Mode.Emission)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == Mode.TextAlpha)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D763 RID: 55139 RVA: 0x004CE1B4 File Offset: 0x004CC3B4
	public void CAJFKNFJEKC()
	{
		this.time = 1292f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("RoomDescriptionText", this.maxAlpha);
		}
	}

	// Token: 0x0600D764 RID: 55140 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void KKIEHCHNLDF(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D765 RID: 55141 RVA: 0x004CE228 File Offset: 0x004CC428
	private void MECJHOJPODB()
	{
		if (this.mode == Mode.Emission)
		{
			float num = Mathf.Sqrt(base.transform.localPosition.z * base.transform.localPosition.z);
			float num2;
			if (base.transform.localPosition.z < 305f)
			{
				num2 = 138f * base.transform.localPosition.z + 1058f;
			}
			else
			{
				num2 = 486f * base.transform.localPosition.z + 382f;
			}
			foreach (Material material in this.OEMADMOLHHG)
			{
				if (this.newVersion)
				{
					material.SetFloat("LevelConfigButton", Mathf.Lerp(material.GetFloat("#FFFFFF"), this.maxAlpha + num2 * this.amplValue, Time.deltaTime * this.time * 1397f));
				}
				else
				{
					material.SetFloat("EventMenu", Mathf.Lerp(material.GetFloat("checkpoint"), num2 * (this.maxAlpha + this.amplValue), Time.deltaTime * this.time * 440f));
				}
			}
		}
		if (this.mode == Mode.ImageAlpha)
		{
			base.GetComponent<Image>().color = Color.Lerp(base.GetComponent<Image>().color, new Color(base.GetComponent<Image>().color.r, base.GetComponent<Image>().color.g, base.GetComponent<Image>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
		if (this.mode == (Mode)3)
		{
			base.GetComponent<Text>().color = Color.Lerp(base.GetComponent<Text>().color, new Color(base.GetComponent<Text>().color.r, base.GetComponent<Text>().color.g, base.GetComponent<Text>().color.b, this.maxAlpha), Time.deltaTime * this.time);
		}
	}

	// Token: 0x0600D766 RID: 55142 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void PFNDFPNPBOJ(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D767 RID: 55143 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void FBNGAIJDBNK(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x0600D768 RID: 55144 RVA: 0x004CE4A4 File Offset: 0x004CC6A4
	public void GDJMBJEAPHM()
	{
		this.time = 1237f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("CameraFilterPack/Color_BrightContrastSaturation", this.maxAlpha);
		}
	}

	// Token: 0x0600D769 RID: 55145 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void NANHBKPOAFJ(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D76A RID: 55146 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void GHPKJJKDONI(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D76B RID: 55147 RVA: 0x004CE518 File Offset: 0x004CC718
	public void LCGMHCBNCDM()
	{
		this.time = 327f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("_Value3", this.maxAlpha);
		}
	}

	// Token: 0x0600D76C RID: 55148 RVA: 0x004CE58C File Offset: 0x004CC78C
	public void LILOGPDPFDA()
	{
		this.time = 1679f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("CameraFilterPack/TV_Videoflip", this.maxAlpha);
		}
	}

	// Token: 0x0600D76D RID: 55149 RVA: 0x004CE600 File Offset: 0x004CC800
	private void KDMKDEKCELE()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 0; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("uploads/Intralism/mods_terms.pdf"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D76F RID: 55151 RVA: 0x004CE6B4 File Offset: 0x004CC8B4
	private void HDMDKOKOOJC()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j += 0)
			{
				Material material = materials[j];
				if (material.HasProperty("_SearchTex"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D770 RID: 55152 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void OPKEHMPGGDG(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D771 RID: 55153 RVA: 0x004CE734 File Offset: 0x004CC934
	private void LIBGAKMKHJJ()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			Material[] materials = renderer.materials;
			for (int j = 1; j < materials.Length; j++)
			{
				Material material = materials[j];
				if (material.HasProperty(": "))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D772 RID: 55154 RVA: 0x004CBA50 File Offset: 0x004C9C50
	public void LONEFLJPJKM(float DPNHODJHGJL)
	{
		this.amplValue = DPNHODJHGJL;
	}

	// Token: 0x0600D773 RID: 55155 RVA: 0x004CE7B4 File Offset: 0x004CC9B4
	public void LLAHPNGMEOO()
	{
		this.time = 1553f;
		foreach (Material material in this.OEMADMOLHHG)
		{
			material.SetFloat("UI Extensions/UIMultiply", this.maxAlpha);
		}
	}

	// Token: 0x0600D774 RID: 55156 RVA: 0x004CE828 File Offset: 0x004CCA28
	private void KIMMMCJFMAB()
	{
		Component[] componentsInChildren = base.GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Renderer renderer = componentsInChildren[i] as Renderer;
			foreach (Material material in renderer.materials)
			{
				if (material.HasProperty("_ScreenResolution"))
				{
					this.OEMADMOLHHG.Add(material);
				}
			}
		}
	}

	// Token: 0x0600D775 RID: 55157 RVA: 0x004CC2B8 File Offset: 0x004CA4B8
	public void NJACHGLHMFO(float AAEBFBPJJPK)
	{
		this.maxAlpha = AAEBFBPJJPK;
	}

	// Token: 0x04001869 RID: 6249
	public bool newVersion;

	// Token: 0x0400186A RID: 6250
	public Mode mode;

	// Token: 0x0400186B RID: 6251
	public float time = 0.4f;

	// Token: 0x0400186C RID: 6252
	public float maxAlpha = 1f;

	// Token: 0x0400186D RID: 6253
	public float amplValue = 1.75f;

	// Token: 0x0400186E RID: 6254
	private List<Material> OEMADMOLHHG = new List<Material>();
}
