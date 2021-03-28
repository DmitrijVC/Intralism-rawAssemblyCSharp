using System;
using AudioVisualizer;
using UnityEngine;

// Token: 0x020003AF RID: 943
public class DynamicScale : MonoBehaviour
{
	// Token: 0x0600D3CC RID: 54220 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void FIKFJDFELIP()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3CD RID: 54221 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void NBGIMIDICKE()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3CE RID: 54222 RVA: 0x004BACDC File Offset: 0x004B8EDC
	public void IJHGPCAHDEH()
	{
		this.AKNOHGIMKGG = 1862f;
		this.sensitivity = 322f;
		this.lerpSpeed = 137f;
		this.baseScale = new Vector3(1539f, 1958f, 798f);
		this.minSize = new Vector3(1703f, 1238f, 595f);
		this.maxSize = new Vector3(491f, 641f, 1485f);
		this.frequencyRange = FrequencyRange.Midrange;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3CF RID: 54223 RVA: 0x004BADB0 File Offset: 0x004B8FB0
	public void OGKGIAAACAD()
	{
		this.AKNOHGIMKGG = 923f;
		this.sensitivity = 357f;
		this.lerpSpeed = 597f;
		this.baseScale = new Vector3(621f, 1028f, 1748f);
		this.minSize = new Vector3(614f, 371f, 1360f);
		this.maxSize = new Vector3(211f, 1286f, 1736f);
		this.frequencyRange = (FrequencyRange)8;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3D0 RID: 54224 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void IMCKJCHKMKB()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3D1 RID: 54225 RVA: 0x004BAE84 File Offset: 0x004B9084
	private void MMBPLGGLPDB()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * num, 1719f, 1808f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1505f;
		float num3 = 395f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.DDBIHOGBDKM(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D2 RID: 54226 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void DNNFHBOOPIN()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3D3 RID: 54227 RVA: 0x004BB034 File Offset: 0x004B9234
	private void ONMGIPAILOH()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * num, 763f, 1383f), Time.deltaTime * this.lerpSpeed);
		float num2 = 107f;
		float num3 = 1778f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.SetScale(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D4 RID: 54228 RVA: 0x004BB1E4 File Offset: 0x004B93E4
	private void MFMIODIAKNI()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * num, 1408f, 506f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1560f;
		float num3 = 314f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.JDLABNJGJIB(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D5 RID: 54229 RVA: 0x004BB394 File Offset: 0x004B9594
	private void OCMKCBBCEFG()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * num, 1499f, 902f), Time.deltaTime * this.lerpSpeed);
		float num2 = 703f;
		float num3 = 629f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.EOEOCMANAMH(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D6 RID: 54230 RVA: 0x004BB544 File Offset: 0x004B9744
	private void GHILDCBCDJI()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * num, 161f, 1358f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1799f;
		float num3 = 1169f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.EOEOCMANAMH(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D7 RID: 54231 RVA: 0x004BB6F4 File Offset: 0x004B98F4
	private void AIJGAJIOJDJ()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * num, 136f, 245f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1349f;
		float num3 = 818f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.JDLABNJGJIB(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3D8 RID: 54232 RVA: 0x004BB8A4 File Offset: 0x004B9AA4
	public void IDOFOCOFEIE()
	{
		this.AKNOHGIMKGG = 694f;
		this.sensitivity = 240f;
		this.lerpSpeed = 1021f;
		this.baseScale = new Vector3(896f, 1746f, 91f);
		this.minSize = new Vector3(584f, 1574f, 1538f);
		this.maxSize = new Vector3(1275f, 1697f, 1146f);
		this.frequencyRange = FrequencyRange.LowMidrange;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3D9 RID: 54233 RVA: 0x004BB978 File Offset: 0x004B9B78
	public void BJIKAHNJNEB()
	{
		this.AKNOHGIMKGG = 767f;
		this.sensitivity = 1021f;
		this.lerpSpeed = 863f;
		this.baseScale = new Vector3(424f, 1022f, 1101f);
		this.minSize = new Vector3(357f, 253f, 1636f);
		this.maxSize = new Vector3(1362f, 463f, 1227f);
		this.frequencyRange = FrequencyRange.High;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3DA RID: 54234 RVA: 0x004BBA4C File Offset: 0x004B9C4C
	private void NKLIHNJCHOG()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * num, 832f, 81f), Time.deltaTime * this.lerpSpeed);
		float num2 = 210f;
		float num3 = 1590f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.JDLABNJGJIB(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3DB RID: 54235 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void Start()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3DC RID: 54236 RVA: 0x004BBBFC File Offset: 0x004B9DFC
	public void MANOCIJICLG()
	{
		this.AKNOHGIMKGG = 1460f;
		this.sensitivity = 1522f;
		this.lerpSpeed = 1755f;
		this.baseScale = new Vector3(948f, 465f, 358f);
		this.minSize = new Vector3(17f, 1760f, 599f);
		this.maxSize = new Vector3(1551f, 1524f, 230f);
		this.frequencyRange = FrequencyRange.Midrange;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3DE RID: 54238 RVA: 0x004BBD60 File Offset: 0x004B9F60
	private void Update()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * num, 0f, 2.2f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1f;
		float num3 = 0.2f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.SetScale(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3DF RID: 54239 RVA: 0x004BBF10 File Offset: 0x004BA110
	public void LDGJGONCEND()
	{
		this.AKNOHGIMKGG = 676f;
		this.sensitivity = 1523f;
		this.lerpSpeed = 991f;
		this.baseScale = new Vector3(1612f, 1343f, 215f);
		this.minSize = new Vector3(1430f, 1804f, 657f);
		this.maxSize = new Vector3(121f, 801f, 441f);
		this.frequencyRange = FrequencyRange.Bass;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E0 RID: 54240 RVA: 0x004BACC3 File Offset: 0x004B8EC3
	private void KIMMMCJFMAB()
	{
		base.gameObject.transform.localScale = this.minSize;
	}

	// Token: 0x0600D3E1 RID: 54241 RVA: 0x004BBFE4 File Offset: 0x004BA1E4
	public void JEKEBJCHOHO()
	{
		this.AKNOHGIMKGG = 737f;
		this.sensitivity = 296f;
		this.lerpSpeed = 191f;
		this.baseScale = new Vector3(241f, 1812f, 565f);
		this.minSize = new Vector3(1278f, 934f, 854f);
		this.maxSize = new Vector3(1522f, 720f, 1204f);
		this.frequencyRange = FrequencyRange.High;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E2 RID: 54242 RVA: 0x004BC0B8 File Offset: 0x004BA2B8
	public void Reset()
	{
		this.AKNOHGIMKGG = 0f;
		this.sensitivity = 50f;
		this.lerpSpeed = 1f;
		this.baseScale = new Vector3(1f, 1f, 1f);
		this.minSize = new Vector3(0f, 0f, 0f);
		this.maxSize = new Vector3(1.5f, 1.5f, 1.5f);
		this.frequencyRange = FrequencyRange.LowMidrange;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E3 RID: 54243 RVA: 0x004BC18C File Offset: 0x004BA38C
	public void ABDHDGNIHHI()
	{
		this.AKNOHGIMKGG = 882f;
		this.sensitivity = 745f;
		this.lerpSpeed = 39f;
		this.baseScale = new Vector3(1986f, 219f, 906f);
		this.minSize = new Vector3(801f, 1765f, 1079f);
		this.maxSize = new Vector3(139f, 12f, 1509f);
		this.frequencyRange = FrequencyRange.Midrange;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E4 RID: 54244 RVA: 0x004BC260 File Offset: 0x004BA460
	public void LOKKIADJAFE()
	{
		this.AKNOHGIMKGG = 924f;
		this.sensitivity = 1881f;
		this.lerpSpeed = 1202f;
		this.baseScale = new Vector3(655f, 209f, 2f);
		this.minSize = new Vector3(411f, 117f, 802f);
		this.maxSize = new Vector3(1165f, 1590f, 1399f);
		this.frequencyRange = FrequencyRange.Bass;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E5 RID: 54245 RVA: 0x004BC334 File Offset: 0x004BA534
	private void KCDOMIJBFLL()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * num, 1956f, 1750f), Time.deltaTime * this.lerpSpeed);
		float num2 = 1268f;
		float num3 = 812f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.PLPOEHKKKJH(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0600D3E6 RID: 54246 RVA: 0x004BC4E4 File Offset: 0x004BA6E4
	public void FPKJJBAENGF()
	{
		this.AKNOHGIMKGG = 1535f;
		this.sensitivity = 501f;
		this.lerpSpeed = 298f;
		this.baseScale = new Vector3(386f, 78f, 1752f);
		this.minSize = new Vector3(1942f, 197f, 80f);
		this.maxSize = new Vector3(1600f, 144f, 1597f);
		this.frequencyRange = FrequencyRange.High;
		if (base.GetComponent<SunController>())
		{
			this.JLPCIFJANPB = base.GetComponent<SunController>();
		}
		else
		{
			this.JLPCIFJANPB = null;
		}
		if (base.GetComponentInParent<PlayerBase>())
		{
			this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
		}
		else
		{
			this.JFCPJAELJOE = null;
		}
	}

	// Token: 0x0600D3E7 RID: 54247 RVA: 0x004BC5B8 File Offset: 0x004BA7B8
	private void IDIIELPAMCJ()
	{
		float num = this.sensitivity;
		if (this.JFCPJAELJOE != null)
		{
			num = this.sensitivity * this.JFCPJAELJOE.GetLifesProgrees();
		}
		this.AKNOHGIMKGG = Mathf.Lerp(this.AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * num, 1590f, 681f), Time.deltaTime * this.lerpSpeed);
		float num2 = 825f;
		float num3 = 1259f;
		this.FEKLHOPGFNC.x = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.x * this.AKNOHGIMKGG, this.minSize.x, this.maxSize.x * num2);
		this.FEKLHOPGFNC.y = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.y * this.AKNOHGIMKGG, this.minSize.y, this.maxSize.y * num2);
		this.FEKLHOPGFNC.z = Mathf.Clamp(this.currentOverflow * num3 + this.baseScale.z * this.AKNOHGIMKGG, this.minSize.z, this.maxSize.z * num2);
		if (this.JFCPJAELJOE != null)
		{
			this.currentOverflow = this.JFCPJAELJOE.comboTimer;
		}
		if (this.JLPCIFJANPB != null)
		{
			this.JLPCIFJANPB.EOEOCMANAMH(this.FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = this.FEKLHOPGFNC;
		}
	}

	// Token: 0x0400182E RID: 6190
	public Vector3 maxSize = new Vector3(1.5f, 1.5f, 1.5f);

	// Token: 0x0400182F RID: 6191
	public Vector3 minSize = new Vector3(0f, 0f, 0f);

	// Token: 0x04001830 RID: 6192
	public int audioSource;

	// Token: 0x04001831 RID: 6193
	public FrequencyRange frequencyRange = FrequencyRange.LowMidrange;

	// Token: 0x04001832 RID: 6194
	public float sensitivity = 50f;

	// Token: 0x04001833 RID: 6195
	public float lerpSpeed = 1f;

	// Token: 0x04001834 RID: 6196
	public Vector3 baseScale = new Vector3(1f, 1f, 1f);

	// Token: 0x04001835 RID: 6197
	[HideInInspector]
	public float currentOverflow;

	// Token: 0x04001836 RID: 6198
	private float AKNOHGIMKGG;

	// Token: 0x04001837 RID: 6199
	private SunController JLPCIFJANPB;

	// Token: 0x04001838 RID: 6200
	private PlayerBase JFCPJAELJOE;

	// Token: 0x04001839 RID: 6201
	private Vector3 FEKLHOPGFNC = default(Vector3);
}
