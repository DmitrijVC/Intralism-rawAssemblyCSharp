using System;
using UnityEngine;

// Token: 0x0200016F RID: 367
public class SENBDLMainCube : MonoBehaviour
{
	// Token: 0x06006BB5 RID: 27573 RVA: 0x00211CA4 File Offset: 0x0020FEA4
	private void POIMNOBDBBN()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.NEHDLDOIFNO();
		this.HGCOBCIFNMC();
		float d = 350f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 339f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.BIBHPMGILBO();
		this.FNAKKDEKGOA();
		this.CECCDGEMHDN();
		this.FBJGHDLGLGA();
	}

	// Token: 0x06006BB6 RID: 27574 RVA: 0x00211D39 File Offset: 0x0020FF39
	private void ELCBKHDDHBH()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1637f / this.JAJEIIFPFBC, 998f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BB7 RID: 27575 RVA: 0x00211D64 File Offset: 0x0020FF64
	private void FBJGHDLGLGA()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1617f / this.JAJEIIFPFBC, 1465f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BB8 RID: 27576 RVA: 0x00211D8F File Offset: 0x0020FF8F
	private void OCEJDJPHIDO()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1281f / this.JAJEIIFPFBC, 1707f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BB9 RID: 27577 RVA: 0x0002523B File Offset: 0x0002343B
	private void JLJHPNKKJPJ()
	{
	}

	// Token: 0x06006BBA RID: 27578 RVA: 0x00211DBC File Offset: 0x0020FFBC
	private void FDJIKIBBOOA()
	{
		if (this.ILFPMAGAMLE >= 232f)
		{
			this.ILFPMAGAMLE = 1252f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 1) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 979f * 1509f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 47f + 206f, 763f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_AlphaUV", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 1991f - this.glowColor.r,
			g = 292f - this.glowColor.g,
			b = 1271f - this.glowColor.b
		}, Color.white, 1501f);
		this.particles.GetComponent<Renderer>().material.SetColor("[PlayerController] ", value);
	}

	// Token: 0x06006BBB RID: 27579 RVA: 0x00211F22 File Offset: 0x00210122
	private void PKJMDNMMOHN()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BBC RID: 27580 RVA: 0x00211F38 File Offset: 0x00210138
	private void GMHACAAGEHM()
	{
		if (this.ILFPMAGAMLE >= 1403f)
		{
			this.ILFPMAGAMLE = 326f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 1) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 1303f * 839f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 750f + 1937f, 1233f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_Green_R", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 1543f - this.glowColor.r,
			g = 1776f - this.glowColor.g,
			b = 177f - this.glowColor.b
		}, Color.white, 623f);
		this.particles.GetComponent<Renderer>().material.SetColor("/music", value);
	}

	// Token: 0x06006BBD RID: 27581 RVA: 0x0021209E File Offset: 0x0021029E
	private void MNMJAGGKLBH()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1249f);
	}

	// Token: 0x06006BBE RID: 27582 RVA: 0x002120C3 File Offset: 0x002102C3
	private void APKDMFHIGHM()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1367f);
	}

	// Token: 0x06006BBF RID: 27583 RVA: 0x002120E8 File Offset: 0x002102E8
	private void IKIDIJLIGOH()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.GMHACAAGEHM();
		this.MNMJAGGKLBH();
		float d = 1995f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 1327f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.CKMLCCFDJEM();
		this.FNAKKDEKGOA();
		this.KJLJIDKONLD();
		this.OCEJDJPHIDO();
	}

	// Token: 0x06006BC0 RID: 27584 RVA: 0x0021217D File Offset: 0x0021037D
	private void CLFADLEBMDF()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BC1 RID: 27585 RVA: 0x002121A4 File Offset: 0x002103A4
	private void INHJINCNLMK()
	{
		if (Input.GetKey((KeyCode)(-70)))
		{
			this.HJGGEKOKHEM += 349f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)155))
		{
			this.HJGGEKOKHEM -= 213f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
			this.IHLNKOMCHKI += 609f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-184)))
		{
			this.IHLNKOMCHKI -= 1124f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-46)))
		{
			Time.timeScale += 492f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)86))
		{
			Time.timeScale -= 656f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 498f, 1151f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 965f, 511f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1935f, 1487f);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.HJGGEKOKHEM = 985f;
			this.IHLNKOMCHKI = 1303f;
			Time.timeScale = 386f;
		}
	}

	// Token: 0x06006BC2 RID: 27586 RVA: 0x00212314 File Offset: 0x00210514
	private void NEHDLDOIFNO()
	{
		if (this.ILFPMAGAMLE >= 8f)
		{
			this.ILFPMAGAMLE = 0f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 1) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 8f * 5f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 0.48f + 0.52f, 4f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("_EmissionColor", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 1f - this.glowColor.r,
			g = 1f - this.glowColor.g,
			b = 1f - this.glowColor.b
		}, Color.white, 0.1f);
		this.particles.GetComponent<Renderer>().material.SetColor("_TintColor", value);
	}

	// Token: 0x06006BC3 RID: 27587 RVA: 0x00211F22 File Offset: 0x00210122
	private void EOGEFHIDAMC()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BC4 RID: 27588 RVA: 0x0021247C File Offset: 0x0021067C
	private void HMEGLDEHHAE()
	{
		if (this.ILFPMAGAMLE >= 799f)
		{
			this.ILFPMAGAMLE = 272f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 0) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 522f * 743f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 644f + 503f, 1746f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("accuracy", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 1287f - this.glowColor.r,
			g = 659f - this.glowColor.g,
			b = 110f - this.glowColor.b
		}, Color.white, 1715f);
		this.particles.GetComponent<Renderer>().material.SetColor("Object ID. Case-Sensitive", value);
	}

	// Token: 0x06006BC5 RID: 27589 RVA: 0x0021217D File Offset: 0x0021037D
	private void JMANGPIOJHA()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BC6 RID: 27590 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGJKHODKNOC()
	{
	}

	// Token: 0x06006BC7 RID: 27591 RVA: 0x002125E4 File Offset: 0x002107E4
	private void AONGGIKHJNG()
	{
		if (this.ILFPMAGAMLE >= 709f)
		{
			this.ILFPMAGAMLE = 1027f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 0) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 303f * 1860f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 1669f + 1303f, 670f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("custom", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 980f - this.glowColor.r,
			g = 188f - this.glowColor.g,
			b = 871f - this.glowColor.b
		}, Color.white, 1355f);
		this.particles.GetComponent<Renderer>().material.SetColor("Event Received", value);
	}

	// Token: 0x06006BC8 RID: 27592 RVA: 0x00211F22 File Offset: 0x00210122
	private void LLMMEABEGFH()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BC9 RID: 27593 RVA: 0x0021274C File Offset: 0x0021094C
	private void KDLJAJLCABM()
	{
		if (Input.GetKey((KeyCode)190))
		{
			this.HJGGEKOKHEM += 1311f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)140))
		{
			this.HJGGEKOKHEM -= 1443f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.T))
		{
			this.IHLNKOMCHKI += 736f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-62)))
		{
			this.IHLNKOMCHKI -= 323f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Greater))
		{
			Time.timeScale += 1959f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)70))
		{
			Time.timeScale -= 638f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 148f, 1895f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1617f, 226f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1576f, 1400f);
		if (Input.GetKeyDown((KeyCode)(-59)))
		{
			this.HJGGEKOKHEM = 1674f;
			this.IHLNKOMCHKI = 228f;
			Time.timeScale = 1664f;
		}
	}

	// Token: 0x06006BCA RID: 27594 RVA: 0x0021217D File Offset: 0x0021037D
	private void FLLEJFACIHE()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BCB RID: 27595 RVA: 0x002128BA File Offset: 0x00210ABA
	private void ADDKKPOIHOM()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 211f / this.JAJEIIFPFBC, 1178f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BCC RID: 27596 RVA: 0x002128E8 File Offset: 0x00210AE8
	private void KDMANOEMOCA()
	{
		this.KJCHBLHFDJJ[0] = new Color(1378f, 1336f, 449f);
		this.KJCHBLHFDJJ[7] = new Color(1363f, 506f, 1479f);
		this.KJCHBLHFDJJ[1] = new Color(1923f, 1595f, 1793f);
		this.KJCHBLHFDJJ[5] = new Color(172f, 1452f, 1036f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -143; i += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < 41; j += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(759f, 383f, 1118f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006BCD RID: 27597 RVA: 0x00212A33 File Offset: 0x00210C33
	private void IHEEJFCAJJM()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1092f / this.JAJEIIFPFBC, 1213f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BCE RID: 27598 RVA: 0x00212A60 File Offset: 0x00210C60
	private void NIAFGFEMLCN()
	{
		if (Input.GetKey(KeyCode.Colon))
		{
			this.HJGGEKOKHEM += 1655f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-148)))
		{
			this.HJGGEKOKHEM -= 1913f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)190))
		{
			this.IHLNKOMCHKI += 1959f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha6))
		{
			this.IHLNKOMCHKI -= 962f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha5))
		{
			Time.timeScale += 1213f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-47)))
		{
			Time.timeScale -= 1550f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 1294f, 436f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 560f, 1574f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 152f, 466f);
		if (Input.GetKeyDown((KeyCode)(-88)))
		{
			this.HJGGEKOKHEM = 537f;
			this.IHLNKOMCHKI = 1729f;
			Time.timeScale = 1576f;
		}
	}

	// Token: 0x06006BCF RID: 27599 RVA: 0x0021217D File Offset: 0x0021037D
	private void DPLAEBBNCII()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BD0 RID: 27600 RVA: 0x00211F22 File Offset: 0x00210122
	private void LFIGMNAOPJF()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BD1 RID: 27601 RVA: 0x00211F22 File Offset: 0x00210122
	private void PDPDOBKJKEA()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BD2 RID: 27602 RVA: 0x00212BD0 File Offset: 0x00210DD0
	private void INACGJLKMEB()
	{
		if (this.ILFPMAGAMLE >= 1012f)
		{
			this.ILFPMAGAMLE = 1083f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 0) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 904f * 1890f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 711f + 1081f, 1376f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("CameraFilterPack/Blend2Camera_Lighten", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 816f - this.glowColor.r,
			g = 1002f - this.glowColor.g,
			b = 224f - this.glowColor.b
		}, Color.white, 181f);
		this.particles.GetComponent<Renderer>().material.SetColor("_TimeX", value);
	}

	// Token: 0x06006BD3 RID: 27603 RVA: 0x0002523B File Offset: 0x0002343B
	private void BCODHAOJLJL()
	{
	}

	// Token: 0x06006BD4 RID: 27604 RVA: 0x00211F22 File Offset: 0x00210122
	private void FODMLBEOLNF()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BD5 RID: 27605 RVA: 0x00212D38 File Offset: 0x00210F38
	private void MFLGLMFFIKA()
	{
		if (Input.GetKey((KeyCode)(-96)))
		{
			this.HJGGEKOKHEM += 1329f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-43)))
		{
			this.HJGGEKOKHEM -= 391f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)5))
		{
			this.IHLNKOMCHKI += 1772f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)128))
		{
			this.IHLNKOMCHKI -= 320f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Pipe))
		{
			Time.timeScale += 511f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-46)))
		{
			Time.timeScale -= 1180f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 131f, 257f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1916f, 203f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1813f, 417f);
		if (Input.GetKeyDown((KeyCode)90))
		{
			this.HJGGEKOKHEM = 1364f;
			this.IHLNKOMCHKI = 221f;
			Time.timeScale = 1678f;
		}
	}

	// Token: 0x06006BD6 RID: 27606 RVA: 0x0002523B File Offset: 0x0002343B
	private void NGGLCOLOLHF()
	{
	}

	// Token: 0x06006BD7 RID: 27607 RVA: 0x00212EA6 File Offset: 0x002110A6
	private void GGLBOMDPAJI()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1710f);
	}

	// Token: 0x06006BD8 RID: 27608 RVA: 0x00212ECB File Offset: 0x002110CB
	private void FEFGFIBCMNB()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1810f / this.JAJEIIFPFBC, 1468f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BD9 RID: 27609 RVA: 0x00212EF8 File Offset: 0x002110F8
	private void BDAAOKOIGML()
	{
		if (Input.GetKey((KeyCode)(-155)))
		{
			this.HJGGEKOKHEM += 574f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-191)))
		{
			this.HJGGEKOKHEM -= 342f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-181)))
		{
			this.IHLNKOMCHKI += 1215f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-44)))
		{
			this.IHLNKOMCHKI -= 831f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-20)))
		{
			Time.timeScale += 1148f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)87))
		{
			Time.timeScale -= 158f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 195f, 1219f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1064f, 602f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1293f, 901f);
		if (Input.GetKeyDown((KeyCode)66))
		{
			this.HJGGEKOKHEM = 1499f;
			this.IHLNKOMCHKI = 1796f;
			Time.timeScale = 1941f;
		}
	}

	// Token: 0x06006BDA RID: 27610 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKLFMPFABEG()
	{
	}

	// Token: 0x06006BDB RID: 27611 RVA: 0x00213066 File Offset: 0x00211266
	private void IFEIFGEHHOG()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 40f / this.JAJEIIFPFBC, 1076f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BDC RID: 27612 RVA: 0x0021217D File Offset: 0x0021037D
	private void PBBKNFMGJBI()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BDD RID: 27613 RVA: 0x00213094 File Offset: 0x00211294
	private void Update()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.NEHDLDOIFNO();
		this.HGCOBCIFNMC();
		float d = 40f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 0.5f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.FODMLBEOLNF();
		this.DGDKJNBEPGE();
		this.CLFADLEBMDF();
		this.DNJMMFOCAEK();
	}

	// Token: 0x06006BDE RID: 27614 RVA: 0x0021312C File Offset: 0x0021132C
	private void FABKIGNFECE()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.NEHDLDOIFNO();
		this.GGLBOMDPAJI();
		float d = 163f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 957f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.LLMMEABEGFH();
		this.NIAFGFEMLCN();
		this.KJLJIDKONLD();
		this.FEFGFIBCMNB();
	}

	// Token: 0x06006BDF RID: 27615 RVA: 0x002131C4 File Offset: 0x002113C4
	private void ADBAPMLPHIE()
	{
		if (Input.GetKey((KeyCode)(-64)))
		{
			this.HJGGEKOKHEM += 1094f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-195)))
		{
			this.HJGGEKOKHEM -= 1926f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)141))
		{
			this.IHLNKOMCHKI += 812f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Dollar))
		{
			this.IHLNKOMCHKI -= 577f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-64)))
		{
			Time.timeScale += 340f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-12)))
		{
			Time.timeScale -= 995f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 778f, 779f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1106f, 892f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 934f, 1762f);
		if (Input.GetKeyDown((KeyCode)(-110)))
		{
			this.HJGGEKOKHEM = 514f;
			this.IHLNKOMCHKI = 1639f;
			Time.timeScale = 953f;
		}
	}

	// Token: 0x06006BE0 RID: 27616 RVA: 0x00213332 File Offset: 0x00211532
	private void JGMKAPELGCK()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 1355f);
	}

	// Token: 0x06006BE1 RID: 27617 RVA: 0x00213358 File Offset: 0x00211558
	private void EABLJCHHCBE()
	{
		if (Input.GetKey((KeyCode)(-12)))
		{
			this.HJGGEKOKHEM += 681f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Alpha7))
		{
			this.HJGGEKOKHEM -= 1895f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)184))
		{
			this.IHLNKOMCHKI += 368f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)142))
		{
			this.IHLNKOMCHKI -= 410f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Less))
		{
			Time.timeScale += 225f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)15))
		{
			Time.timeScale -= 856f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 563f, 95f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 300f, 1462f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1857f, 1148f);
		if (Input.GetKeyDown((KeyCode)(-125)))
		{
			this.HJGGEKOKHEM = 152f;
			this.IHLNKOMCHKI = 0f;
			Time.timeScale = 106f;
		}
	}

	// Token: 0x06006BE2 RID: 27618 RVA: 0x002134C8 File Offset: 0x002116C8
	private void DGDKJNBEPGE()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.HJGGEKOKHEM += 0.2f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.HJGGEKOKHEM -= 0.2f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.IHLNKOMCHKI += 0.4f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.IHLNKOMCHKI -= 0.4f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Period))
		{
			Time.timeScale += 0.5f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Comma))
		{
			Time.timeScale -= 0.5f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 0f, 0.4f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 0f, 0.95f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 0.1f, 1f);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			this.HJGGEKOKHEM = 0.05f;
			this.IHLNKOMCHKI = 0.1f;
			Time.timeScale = 1f;
		}
	}

	// Token: 0x06006BE3 RID: 27619 RVA: 0x00213636 File Offset: 0x00211836
	private void ADIGEGAOKAN()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 71f / this.JAJEIIFPFBC, 1361f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BE4 RID: 27620 RVA: 0x00213664 File Offset: 0x00211864
	private void ECNCMFPFACF()
	{
		if (Input.GetKey((KeyCode)(-27)))
		{
			this.HJGGEKOKHEM += 387f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-192)))
		{
			this.HJGGEKOKHEM -= 790f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-167)))
		{
			this.IHLNKOMCHKI += 257f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-120)))
		{
			this.IHLNKOMCHKI -= 142f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-126)))
		{
			Time.timeScale += 1597f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-88)))
		{
			Time.timeScale -= 1468f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 1557f, 110f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 135f, 559f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1449f, 1229f);
		if (Input.GetKeyDown(KeyCode.Semicolon))
		{
			this.HJGGEKOKHEM = 1532f;
			this.IHLNKOMCHKI = 1571f;
			Time.timeScale = 467f;
		}
	}

	// Token: 0x06006BE5 RID: 27621 RVA: 0x00211F22 File Offset: 0x00210122
	private void MNIOFKKGDIG()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BE6 RID: 27622 RVA: 0x002137D4 File Offset: 0x002119D4
	private void DGCGGKMNPLD()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.INACGJLKMEB();
		this.FLDLPPGMFPM();
		float d = 219f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 1656f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.FODMLBEOLNF();
		this.MFLGLMFFIKA();
		this.DPLAEBBNCII();
		this.FEFGFIBCMNB();
	}

	// Token: 0x06006BE7 RID: 27623 RVA: 0x0021386C File Offset: 0x00211A6C
	private void BOOJHDBJLPE()
	{
		if (Input.GetKey((KeyCode)(-183)))
		{
			this.HJGGEKOKHEM += 217f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)70))
		{
			this.HJGGEKOKHEM -= 13f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-65)))
		{
			this.IHLNKOMCHKI += 701f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-55)))
		{
			this.IHLNKOMCHKI -= 1318f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)78))
		{
			Time.timeScale += 697f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-63)))
		{
			Time.timeScale -= 1807f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 1572f, 1701f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 566f, 768f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1784f, 1170f);
		if (Input.GetKeyDown(KeyCode.Slash))
		{
			this.HJGGEKOKHEM = 1038f;
			this.IHLNKOMCHKI = 1539f;
			Time.timeScale = 876f;
		}
	}

	// Token: 0x06006BE8 RID: 27624 RVA: 0x002139DC File Offset: 0x00211BDC
	private void MNBPNHNAEBK()
	{
		this.KJCHBLHFDJJ[1] = new Color(555f, 2f, 303f);
		this.KJCHBLHFDJJ[7] = new Color(794f, 1527f, 1849f);
		this.KJCHBLHFDJJ[0] = new Color(732f, 1399f, 701f);
		this.KJCHBLHFDJJ[4] = new Color(1258f, 1145f, 581f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 169; i++)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -75; j++)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(872f, 167f, 944f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006BE9 RID: 27625 RVA: 0x00211F22 File Offset: 0x00210122
	private void BIBHPMGILBO()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BEA RID: 27626 RVA: 0x00213B28 File Offset: 0x00211D28
	private void GCHBGCGBMCK()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.HMEGLDEHHAE();
		this.LJCJDDHHBHE();
		float d = 1096f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 1106f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.PDPDOBKJKEA();
		this.BOOJHDBJLPE();
		this.CECCDGEMHDN();
		this.FBJGHDLGLGA();
	}

	// Token: 0x06006BEC RID: 27628 RVA: 0x00213BE7 File Offset: 0x00211DE7
	private void LJCJDDHHBHE()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 84f);
	}

	// Token: 0x06006BED RID: 27629 RVA: 0x00211F22 File Offset: 0x00210122
	private void MCAMKNHEOLJ()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x00211F22 File Offset: 0x00210122
	private void OEOCCHGGIBH()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x00213C0C File Offset: 0x00211E0C
	private void FLDLPPGMFPM()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 231f);
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x00211F22 File Offset: 0x00210122
	private void ELFCDOPMMNK()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x0021217D File Offset: 0x0021037D
	private void DNPMOIPKPFC()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x00213C34 File Offset: 0x00211E34
	private void JHPOIOELNCG()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.AONGGIKHJNG();
		this.GGLBOMDPAJI();
		float d = 428f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 23f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.EOGEFHIDAMC();
		this.EABLJCHHCBE();
		this.KJLJIDKONLD();
		this.DNJMMFOCAEK();
	}

	// Token: 0x06006BF3 RID: 27635 RVA: 0x00213CCC File Offset: 0x00211ECC
	private void KMEONPMCNJG()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.FDJIKIBBOOA();
		this.LJCJDDHHBHE();
		float d = 318f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 1575f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.HPFJBKCIDHP();
		this.ADBAPMLPHIE();
		this.JMANGPIOJHA();
		this.DNJMMFOCAEK();
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x00213D61 File Offset: 0x00211F61
	private void DNJMMFOCAEK()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1f / this.JAJEIIFPFBC, 5f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x0021217D File Offset: 0x0021037D
	private void NACHHLNBOBK()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x0002523B File Offset: 0x0002343B
	private void PCCEPADONHK()
	{
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x00213D8C File Offset: 0x00211F8C
	private void CNGAJDBOCLJ()
	{
		this.KJCHBLHFDJJ[1] = new Color(1913f, 878f, 799f);
		this.KJCHBLHFDJJ[6] = new Color(497f, 1356f, 1118f);
		this.KJCHBLHFDJJ[0] = new Color(1328f, 1363f, 1329f);
		this.KJCHBLHFDJJ[8] = new Color(1966f, 389f, 1140f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 130; i += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 1; j < -22; j += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(776f, 343f, 710f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x00213ED8 File Offset: 0x002120D8
	private void IMCKJCHKMKB()
	{
		this.KJCHBLHFDJJ[0] = new Color(1346f, 1965f, 857f);
		this.KJCHBLHFDJJ[8] = new Color(1983f, 43f, 794f);
		this.KJCHBLHFDJJ[1] = new Color(1450f, 553f, 1519f);
		this.KJCHBLHFDJJ[2] = new Color(960f, 178f, 580f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -81; i += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -116; j += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1819f, 1402f, 15f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x00214024 File Offset: 0x00212224
	private void OMCLOFCJMPG()
	{
		this.JAJEIIFPFBC = Time.deltaTime / Time.timeScale;
		this.CHDNGFLDGNI();
		this.APKDMFHIGHM();
		float d = 432f;
		Vector3 vector = Vector3.up * d;
		vector = Quaternion.Euler(Vector3.right * Time.time * d * 1023f) * vector;
		base.transform.Rotate(vector * Time.deltaTime);
		this.MNIOFKKGDIG();
		this.INHJINCNLMK();
		this.CECCDGEMHDN();
		this.ELCBKHDDHBH();
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDFOMFBPFFB()
	{
	}

	// Token: 0x06006BFB RID: 27643 RVA: 0x0021217D File Offset: 0x0021037D
	private void GJAIKDNLOCH()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x0002523B File Offset: 0x0002343B
	private void NMHIDAOMOGO()
	{
	}

	// Token: 0x06006BFD RID: 27645 RVA: 0x002140BC File Offset: 0x002122BC
	private void EKFCKGFMNOJ()
	{
		if (Input.GetKey((KeyCode)(-137)))
		{
			this.HJGGEKOKHEM += 377f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-187)))
		{
			this.HJGGEKOKHEM -= 1471f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.Dollar))
		{
			this.IHLNKOMCHKI += 703f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-60)))
		{
			this.IHLNKOMCHKI -= 1915f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey(KeyCode.J))
		{
			Time.timeScale += 502f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-99)))
		{
			Time.timeScale -= 758f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 756f, 211f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1453f, 630f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 1568f, 378f);
		if (Input.GetKeyDown((KeyCode)(-93)))
		{
			this.HJGGEKOKHEM = 1413f;
			this.IHLNKOMCHKI = 1551f;
			Time.timeScale = 1903f;
		}
	}

	// Token: 0x06006BFE RID: 27646 RVA: 0x00211F22 File Offset: 0x00210122
	private void HPFJBKCIDHP()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006BFF RID: 27647 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnGUI()
	{
	}

	// Token: 0x06006C00 RID: 27648 RVA: 0x0021422C File Offset: 0x0021242C
	private void Start()
	{
		this.KJCHBLHFDJJ[0] = new Color(1f, 0.470588237f, 0.0509803928f);
		this.KJCHBLHFDJJ[2] = new Color(0.329411775f, 0.6392157f, 1f);
		this.KJCHBLHFDJJ[1] = new Color(0.607843161f, 1f, 0.117647059f);
		this.KJCHBLHFDJJ[3] = new Color(1f, 0.184313729f, 0f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[0];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < 150; i++)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < 19; j++)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(0.08f, 0.08f, 0.08f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006C01 RID: 27649 RVA: 0x00211F22 File Offset: 0x00210122
	private void DDFJNEPBNLO()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x00214378 File Offset: 0x00212578
	private void FNAKKDEKGOA()
	{
		if (Input.GetKey((KeyCode)88))
		{
			this.HJGGEKOKHEM += 876f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-181)))
		{
			this.HJGGEKOKHEM -= 686f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)146))
		{
			this.IHLNKOMCHKI += 1073f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)(-140)))
		{
			this.IHLNKOMCHKI -= 1668f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)72))
		{
			Time.timeScale += 688f * this.JAJEIIFPFBC;
		}
		if (Input.GetKey((KeyCode)87))
		{
			Time.timeScale -= 922f * this.JAJEIIFPFBC;
		}
		this.HJGGEKOKHEM = Mathf.Clamp(this.HJGGEKOKHEM, 115f, 1405f);
		this.IHLNKOMCHKI = Mathf.Clamp(this.IHLNKOMCHKI, 1250f, 1113f);
		Time.timeScale = Mathf.Clamp(Time.timeScale, 479f, 299f);
		if (Input.GetKeyDown((KeyCode)(-114)))
		{
			this.HJGGEKOKHEM = 1880f;
			this.IHLNKOMCHKI = 1563f;
			Time.timeScale = 512f;
		}
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x002144E8 File Offset: 0x002126E8
	private void JILOMOBDPIA()
	{
		this.KJCHBLHFDJJ[1] = new Color(1749f, 660f, 1958f);
		this.KJCHBLHFDJJ[7] = new Color(1266f, 596f, 1780f);
		this.KJCHBLHFDJJ[1] = new Color(1743f, 567f, 1763f);
		this.KJCHBLHFDJJ[2] = new Color(1242f, 1135f, 611f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -20; i += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < -26; j += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1892f, 593f, 1713f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x00214633 File Offset: 0x00212833
	private void HHKAHAGOPMB()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1686f / this.JAJEIIFPFBC, 1358f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x0021217D File Offset: 0x0021037D
	private void CECCDGEMHDN()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x00214660 File Offset: 0x00212860
	private void DBEMDAJDDDA()
	{
		this.KJCHBLHFDJJ[0] = new Color(1035f, 1282f, 1168f);
		this.KJCHBLHFDJJ[7] = new Color(1571f, 622f, 1292f);
		this.KJCHBLHFDJJ[0] = new Color(1169f, 1399f, 921f);
		this.KJCHBLHFDJJ[3] = new Color(703f, 1205f, 402f);
		this.AGDIGEMCIJE = this.KJCHBLHFDJJ[1];
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.identity;
		for (int i = 0; i < -161; i += 0)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.orbitingCube, Vector3.zero, Quaternion.identity);
		}
		for (int j = 0; j < 34; j++)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.glowingOrbitingCube, Vector3.zero, Quaternion.identity);
		}
		Camera.main.backgroundColor = new Color(1001f, 721f, 1476f);
		SENBDLGlobal.mainCube = this;
		this.DCDKPOOLJNC = Camera.main.GetComponent<SENaturalBloomAndDirtyLens>();
	}

	// Token: 0x06006C07 RID: 27655 RVA: 0x002147AB File Offset: 0x002129AB
	private void EEOCMJOLALG()
	{
		this.GLNIHJKBEIK = Mathf.Lerp(this.GLNIHJKBEIK, 1072f / this.JAJEIIFPFBC, 1473f * this.JAJEIIFPFBC);
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x002147D8 File Offset: 0x002129D8
	private void CHDNGFLDGNI()
	{
		if (this.ILFPMAGAMLE >= 1046f)
		{
			this.ILFPMAGAMLE = 1406f;
			this.MMCGDPKAHFG = (this.MMCGDPKAHFG + 0) % this.KJCHBLHFDJJ.Length;
			this.MKPEALIKJBL = this.AGDIGEMCIJE;
			this.AGDIGEMCIJE = this.KJCHBLHFDJJ[this.MMCGDPKAHFG];
		}
		float t = Mathf.Clamp01(this.ILFPMAGAMLE / 411f * 475f);
		this.glowColor = Color.Lerp(this.MKPEALIKJBL, this.AGDIGEMCIJE, t);
		Color color = this.glowColor * Mathf.Pow(Mathf.Sin(Time.time) * 1586f + 155f, 1614f);
		this.cubeEmissivePart.GetComponent<Renderer>().material.SetColor("VisionBlur", color);
		base.GetComponent<Light>().color = color;
		Color value = Color.Lerp(new Color
		{
			r = 917f - this.glowColor.r,
			g = 802f - this.glowColor.g,
			b = 652f - this.glowColor.b
		}, Color.white, 787f);
		this.particles.GetComponent<Renderer>().material.SetColor(":", value);
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x0021493E File Offset: 0x00212B3E
	private void HGCOBCIFNMC()
	{
		SENBDLGlobal.sphereOfCubesRotation = Quaternion.Euler(Vector3.up * Time.time * 20f);
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x00211F22 File Offset: 0x00210122
	private void CKMLCCFDJEM()
	{
		this.ILFPMAGAMLE += Time.deltaTime;
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x0021217D File Offset: 0x0021037D
	private void KJLJIDKONLD()
	{
		this.DCDKPOOLJNC.bloomIntensity = this.HJGGEKOKHEM;
		this.DCDKPOOLJNC.lensDirtIntensity = this.IHLNKOMCHKI;
	}

	// Token: 0x04000B04 RID: 2820
	private Color[] KJCHBLHFDJJ = new Color[4];

	// Token: 0x04000B05 RID: 2821
	public GameObject orbitingCube;

	// Token: 0x04000B06 RID: 2822
	public GameObject glowingOrbitingCube;

	// Token: 0x04000B07 RID: 2823
	public GameObject cubeEmissivePart;

	// Token: 0x04000B08 RID: 2824
	public GameObject particles;

	// Token: 0x04000B09 RID: 2825
	private const float INMKGOCKHGA = 8f;

	// Token: 0x04000B0A RID: 2826
	private float ILFPMAGAMLE;

	// Token: 0x04000B0B RID: 2827
	private Color AGDIGEMCIJE;

	// Token: 0x04000B0C RID: 2828
	private Color MKPEALIKJBL;

	// Token: 0x04000B0D RID: 2829
	[HideInInspector]
	public Color glowColor;

	// Token: 0x04000B0E RID: 2830
	private int MMCGDPKAHFG;

	// Token: 0x04000B0F RID: 2831
	private float HJGGEKOKHEM = 0.04f;

	// Token: 0x04000B10 RID: 2832
	private float IHLNKOMCHKI = 0.3f;

	// Token: 0x04000B11 RID: 2833
	private float GLNIHJKBEIK;

	// Token: 0x04000B12 RID: 2834
	private float JAJEIIFPFBC;

	// Token: 0x04000B13 RID: 2835
	private SENaturalBloomAndDirtyLens DCDKPOOLJNC;
}
