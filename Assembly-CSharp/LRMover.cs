using System;
using UnityEngine;

// Token: 0x020003CC RID: 972
public class LRMover : MonoBehaviour
{
	// Token: 0x0600DBCB RID: 56267 RVA: 0x004DBE74 File Offset: 0x004DA074
	private void DKOPKPBLDHH()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(582f, 1929f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1569f, 1340f) >= 703f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBCC RID: 56268 RVA: 0x004DBEF4 File Offset: 0x004DA0F4
	private void BEBNOKFLJPH()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(268f, 1991f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(909f, 1361f) >= 286f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBCD RID: 56269 RVA: 0x004DBF74 File Offset: 0x004DA174
	private void JBNPEHMDCMI()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			char c = array[i];
			if (c == '\u000f')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(876f, 671f, 1327f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 336f, 1828f), Time.deltaTime);
				return;
			}
			if (c == '*')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(960f, 909f, 45f) * this.mspeed + new Vector3(1396f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1861f), Time.deltaTime);
				return;
			}
			if ((int)c == -67)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1357f)
		{
			this.IACGDFHKCAE = 924f;
		}
	}

	// Token: 0x0600DBCE RID: 56270 RVA: 0x004DC154 File Offset: 0x004DA354
	private void IHLMNAGPKDA()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1846f, 1186f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(835f, 1151f) >= 582f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBCF RID: 56271 RVA: 0x004DC1D4 File Offset: 0x004DA3D4
	private void MKIMDFLBFOM()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(484f, 482f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1629f, 631f) >= 146f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD0 RID: 56272 RVA: 0x004DC254 File Offset: 0x004DA454
	private void DPIPGGDNGHN()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if ((int)c == -72)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1360f, 551f, 981f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1433f, 1617f), Time.deltaTime);
				return;
			}
			if ((int)c == -14)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(846f, 1012f, 1571f) * this.mspeed + new Vector3(1689f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 939f), Time.deltaTime);
				return;
			}
			if (c == '\u001b')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 806f)
		{
			this.IACGDFHKCAE = 438f;
		}
	}

	// Token: 0x0600DBD1 RID: 56273 RVA: 0x004DC434 File Offset: 0x004DA634
	private void CIPKEPDELJB()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(927f, 1728f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1007f, 120f) >= 628f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD2 RID: 56274 RVA: 0x004DC4B4 File Offset: 0x004DA6B4
	private void BMIOFJFMCBG()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(534f, 773f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(774f, 1821f) >= 1294f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD3 RID: 56275 RVA: 0x004DC534 File Offset: 0x004DA734
	private void GPNAOAKCMHC()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(329f, 1003f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(106f, 786f) >= 44f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD4 RID: 56276 RVA: 0x004DC5B4 File Offset: 0x004DA7B4
	private void KLILJHJNICK()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(680f, 464f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(481f, 1992f) >= 74f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD5 RID: 56277 RVA: 0x004DC634 File Offset: 0x004DA834
	private void IMCKJCHKMKB()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(521f, 1489f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1512f, 1119f) >= 1241f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD6 RID: 56278 RVA: 0x004DC6B4 File Offset: 0x004DA8B4
	private void Update()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if (c == 'X')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 0f, 0f), Time.deltaTime);
				return;
			}
			if (c == 'Y')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(0f, 0f, -1f) * this.mspeed + new Vector3(0f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 0f), Time.deltaTime);
				return;
			}
			if (c == 'Z')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 6.28318548f)
		{
			this.IACGDFHKCAE = 0f;
		}
	}

	// Token: 0x0600DBD7 RID: 56279 RVA: 0x004DC894 File Offset: 0x004DAA94
	private void FOMNCPKKCFN()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -16)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1695f, 1612f, 599f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1167f, 1174f), Time.deltaTime);
				return;
			}
			if (c == 'e')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1036f, 1885f, 1839f) * this.mspeed + new Vector3(1478f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1536f), Time.deltaTime);
				return;
			}
			if ((int)c == -79)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 179f)
		{
			this.IACGDFHKCAE = 1899f;
		}
	}

	// Token: 0x0600DBD8 RID: 56280 RVA: 0x004DCA74 File Offset: 0x004DAC74
	private void HMPGIFBJFIK()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1915f, 104f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(926f, 1267f) >= 524f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBD9 RID: 56281 RVA: 0x004DCAF4 File Offset: 0x004DACF4
	private void IIFCIDDJHPM()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if ((int)c == -81)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1267f, 806f, 1765f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1413f, 332f), Time.deltaTime);
				return;
			}
			if ((int)c == -2)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(23f, 454f, 990f) * this.mspeed + new Vector3(967f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 871f), Time.deltaTime);
				return;
			}
			if ((int)c == -106)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1494f)
		{
			this.IACGDFHKCAE = 1412f;
		}
	}

	// Token: 0x0600DBDA RID: 56282 RVA: 0x004DCCD4 File Offset: 0x004DAED4
	private void KMCPMOGKDEH()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1921f, 975f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(113f, 1340f) >= 1738f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBDB RID: 56283 RVA: 0x004DCD54 File Offset: 0x004DAF54
	private void JHPOIOELNCG()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -72)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1501f, 1234f, 1001f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1558f, 785f), Time.deltaTime);
				return;
			}
			if (c == '^')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(103f, 523f, 1020f) * this.mspeed + new Vector3(1085f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 530f), Time.deltaTime);
				return;
			}
			if ((int)c == -25)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1678f)
		{
			this.IACGDFHKCAE = 979f;
		}
	}

	// Token: 0x0600DBDC RID: 56284 RVA: 0x004DCF34 File Offset: 0x004DB134
	private void NEKCPLGFOFD()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -106)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(131f, 597f, 1232f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 471f, 1290f), Time.deltaTime);
				return;
			}
			if (c == 'b')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(903f, 1866f, 1909f) * this.mspeed + new Vector3(541f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 225f), Time.deltaTime);
				return;
			}
			if (c == '\u001e')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 839f)
		{
			this.IACGDFHKCAE = 262f;
		}
	}

	// Token: 0x0600DBDD RID: 56285 RVA: 0x004DD114 File Offset: 0x004DB314
	private void BMODOIJGIOO()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if (c == 'Z')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1336f, 306f, 1950f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 447f, 1394f), Time.deltaTime);
				return;
			}
			if (c == 'Z')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(424f, 937f, 1322f) * this.mspeed + new Vector3(287f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 505f), Time.deltaTime);
				return;
			}
			if (c == 'g')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 762f)
		{
			this.IACGDFHKCAE = 511f;
		}
	}

	// Token: 0x0600DBDE RID: 56286 RVA: 0x004DD2F4 File Offset: 0x004DB4F4
	private void MAOCOEGAFND()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if ((int)c == -120)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(664f, 1862f, 1551f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 744f, 211f), Time.deltaTime);
				return;
			}
			if (c == '\u001b')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(402f, 181f, 1597f) * this.mspeed + new Vector3(209f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1658f), Time.deltaTime);
				return;
			}
			if (c == ';')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1947f)
		{
			this.IACGDFHKCAE = 570f;
		}
	}

	// Token: 0x0600DBDF RID: 56287 RVA: 0x004DD4D4 File Offset: 0x004DB6D4
	private void EFJDNLGNACH()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(586f, 555f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1898f, 670f) >= 1824f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBE0 RID: 56288 RVA: 0x004DD554 File Offset: 0x004DB754
	private void EGEPLFGKGLI()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1346f, 550f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1192f, 329f) >= 1345f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBE1 RID: 56289 RVA: 0x004DD5D4 File Offset: 0x004DB7D4
	private void OMCLOFCJMPG()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if (c == '_')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(755f, 531f, 1721f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 807f, 147f), Time.deltaTime);
				return;
			}
			if ((int)c == -106)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(451f, 1218f, 730f) * this.mspeed + new Vector3(291f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 800f), Time.deltaTime);
				return;
			}
			if (c == 's')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1884f)
		{
			this.IACGDFHKCAE = 239f;
		}
	}

	// Token: 0x0600DBE2 RID: 56290 RVA: 0x004DD7B4 File Offset: 0x004DB9B4
	private void AIJGAJIOJDJ()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -27)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(284f, 1426f, 1495f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1963f, 1414f), Time.deltaTime);
				return;
			}
			if (c == '&')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1141f, 1041f, 1184f) * this.mspeed + new Vector3(1783f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1908f), Time.deltaTime);
				return;
			}
			if ((int)c == -2)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1697f)
		{
			this.IACGDFHKCAE = 914f;
		}
	}

	// Token: 0x0600DBE3 RID: 56291 RVA: 0x004DD994 File Offset: 0x004DBB94
	private void FABKIGNFECE()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if ((int)c == -60)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1101f, 584f, 962f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 714f, 659f), Time.deltaTime);
				return;
			}
			if ((int)c == -29)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1060f, 1586f, 1736f) * this.mspeed + new Vector3(634f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1958f), Time.deltaTime);
				return;
			}
			if (c == '.')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 971f)
		{
			this.IACGDFHKCAE = 299f;
		}
	}

	// Token: 0x0600DBE4 RID: 56292 RVA: 0x004DDB74 File Offset: 0x004DBD74
	private void CCLNNLCOPBL()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(429f, 649f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(167f, 1787f) >= 191f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBE5 RID: 56293 RVA: 0x004DDBF4 File Offset: 0x004DBDF4
	private void ONMGIPAILOH()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if (c == '\0')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(453f, 228f, 1771f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1490f, 1450f), Time.deltaTime);
				return;
			}
			if (c == ':')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1453f, 1618f, 855f) * this.mspeed + new Vector3(148f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 33f), Time.deltaTime);
				return;
			}
			if (c == 'w')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1116f)
		{
			this.IACGDFHKCAE = 1013f;
		}
	}

	// Token: 0x0600DBE6 RID: 56294 RVA: 0x004DDDD4 File Offset: 0x004DBFD4
	private void MMBPLGGLPDB()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -16)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(254f, 528f, 952f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1857f, 1948f), Time.deltaTime);
				return;
			}
			if ((int)c == -120)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1043f, 888f, 1672f) * this.mspeed + new Vector3(1724f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1777f), Time.deltaTime);
				return;
			}
			if (c == '\u0019')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1324f)
		{
			this.IACGDFHKCAE = 1479f;
		}
	}

	// Token: 0x0600DBE7 RID: 56295 RVA: 0x004DDFB4 File Offset: 0x004DC1B4
	private void FBMDHDBELEK()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if (c == '7')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1529f, 1277f, 503f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 926f, 1229f), Time.deltaTime);
				return;
			}
			if (c == '/')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(327f, 691f, 1729f) * this.mspeed + new Vector3(183f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1907f), Time.deltaTime);
				return;
			}
			if (c == ' ')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1655f)
		{
			this.IACGDFHKCAE = 123f;
		}
	}

	// Token: 0x0600DBE8 RID: 56296 RVA: 0x004DE194 File Offset: 0x004DC394
	private void LPMINJJPDCH()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if (c == '\u0014')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1920f, 1520f, 977f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 809f, 1665f), Time.deltaTime);
				return;
			}
			if (c == 'U')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(377f, 715f, 415f) * this.mspeed + new Vector3(338f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1218f), Time.deltaTime);
				return;
			}
			if (c == '\b')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 289f)
		{
			this.IACGDFHKCAE = 940f;
		}
	}

	// Token: 0x0600DBE9 RID: 56297 RVA: 0x004DE374 File Offset: 0x004DC574
	private void OCMKCBBCEFG()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if (c == 'c')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(938f, 1643f, 776f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1021f, 590f), Time.deltaTime);
				return;
			}
			if (c == '#')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(533f, 1422f, 1981f) * this.mspeed + new Vector3(387f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 278f), Time.deltaTime);
				return;
			}
			if (c == '\u000e')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1219f)
		{
			this.IACGDFHKCAE = 1929f;
		}
	}

	// Token: 0x0600DBEA RID: 56298 RVA: 0x004DE554 File Offset: 0x004DC754
	private void BGDONBMDPGM()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 0; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -102)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1930f, 217f, 348f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 86f, 1379f), Time.deltaTime);
				return;
			}
			if ((int)c == -78)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(349f, 883f, 1971f) * this.mspeed + new Vector3(1552f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1068f), Time.deltaTime);
				return;
			}
			if (c == '\u000f')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1006f)
		{
			this.IACGDFHKCAE = 728f;
		}
	}

	// Token: 0x0600DBEB RID: 56299 RVA: 0x004DE734 File Offset: 0x004DC934
	private void KCCIEMBMOBA()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1873f, 113f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1140f, 808f) >= 26f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBEC RID: 56300 RVA: 0x004DE7B4 File Offset: 0x004DC9B4
	private void DNNFHBOOPIN()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1209f, 1930f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(98f, 654f) >= 18f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBED RID: 56301 RVA: 0x004DE834 File Offset: 0x004DCA34
	private void NPLCENPNJBM()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1243f, 1587f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(586f, 1759f) >= 1017f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBEE RID: 56302 RVA: 0x004DE8B4 File Offset: 0x004DCAB4
	private void DIPDEHOOBPG()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(336f, 1661f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(563f, 884f) >= 659f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBEF RID: 56303 RVA: 0x004DE934 File Offset: 0x004DCB34
	private void JKFDDNMPOJH()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1208f, 693f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(394f, 256f) >= 414f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBF0 RID: 56304 RVA: 0x004DE9B4 File Offset: 0x004DCBB4
	private void LJIHHJOAJCN()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if ((int)c == -94)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(855f, 916f, 1559f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 5f, 1457f), Time.deltaTime);
				return;
			}
			if (c == 'e')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1868f, 1635f, 419f) * this.mspeed + new Vector3(921f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 520f), Time.deltaTime);
				return;
			}
			if (c == '9')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1506f)
		{
			this.IACGDFHKCAE = 76f;
		}
	}

	// Token: 0x0600DBF1 RID: 56305 RVA: 0x004DEB94 File Offset: 0x004DCD94
	private void Start()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(0.1f, 5f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(0f, 1f) >= 0.5f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBF2 RID: 56306 RVA: 0x004DEC14 File Offset: 0x004DCE14
	private void AEIJFLJEABG()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if ((int)c == -6)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1833f, 1823f, 80f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 35f, 1485f), Time.deltaTime);
				return;
			}
			if (c == '\u0015')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(331f, 368f, 1857f) * this.mspeed + new Vector3(1553f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 726f), Time.deltaTime);
				return;
			}
			if (c == 'B')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1905f)
		{
			this.IACGDFHKCAE = 848f;
		}
	}

	// Token: 0x0600DBF4 RID: 56308 RVA: 0x004DEE28 File Offset: 0x004DD028
	private void IDIIELPAMCJ()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i += 0)
		{
			char c = array[i];
			if (c == 'o')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(335f, 539f, 572f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1092f, 479f), Time.deltaTime);
				return;
			}
			if (c == '\u0013')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(115f, 1722f, 1847f) * this.mspeed + new Vector3(1505f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1959f), Time.deltaTime);
				return;
			}
			if ((int)c == -60)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1871f)
		{
			this.IACGDFHKCAE = 1162f;
		}
	}

	// Token: 0x0600DBF5 RID: 56309 RVA: 0x004DF008 File Offset: 0x004DD208
	private void HLDFOJMHKNL()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		char[] array = this.axis.ToCharArray();
		for (int i = 1; i < array.Length; i++)
		{
			char c = array[i];
			if ((int)c == -36)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(192f, 565f, 1462f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1466f, 292f), Time.deltaTime);
				return;
			}
			if (c == 'o')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(990f, 654f, 1270f) * this.mspeed + new Vector3(1372f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 384f), Time.deltaTime);
				return;
			}
			if (c == '\u0005')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 1617f)
		{
			this.IACGDFHKCAE = 1120f;
		}
	}

	// Token: 0x0600DBF6 RID: 56310 RVA: 0x004DF1E8 File Offset: 0x004DD3E8
	private void JNBPKNNBMDI()
	{
		this.IACGDFHKCAE += Time.deltaTime * this.lrspeed;
		foreach (char c in this.axis.ToCharArray())
		{
			if (c == '$')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1091f, 666f, 1748f) * this.mspeed + new Vector3(this.FDANOJICIBP.x + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 857f, 1183f), Time.deltaTime);
				return;
			}
			if (c == 'u')
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, base.transform.localPosition + new Vector3(1153f, 871f, 668f) * this.mspeed + new Vector3(222f, this.FDANOJICIBP.y + Mathf.Cos(this.IACGDFHKCAE) * this.multiply, 1755f), Time.deltaTime);
				return;
			}
			if ((int)c == -9)
			{
				base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.FDANOJICIBP.x, this.FDANOJICIBP.y, this.FDANOJICIBP.z + Mathf.Sin(this.IACGDFHKCAE) * this.multiply), Time.deltaTime);
				return;
			}
		}
		if (this.IACGDFHKCAE >= 984f)
		{
			this.IACGDFHKCAE = 1011f;
		}
	}

	// Token: 0x0600DBF7 RID: 56311 RVA: 0x004DF3C8 File Offset: 0x004DD5C8
	private void CNGAJDBOCLJ()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(1838f, 1233f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(716f, 88f) >= 352f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBF8 RID: 56312 RVA: 0x004DF448 File Offset: 0x004DD648
	private void DLBODOFAJGM()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(872f, 607f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(463f, 789f) >= 767f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x0600DBF9 RID: 56313 RVA: 0x004DF4C8 File Offset: 0x004DD6C8
	private void FIKFJDFELIP()
	{
		this.FDANOJICIBP = base.transform.localPosition;
		this.axis = this.axis.ToUpper();
		if (this.useRandomSpeed)
		{
			this.lrspeed = UnityEngine.Random.Range(98f, 303f);
		}
		if (this.useRandomDirection && UnityEngine.Random.Range(1690f, 160f) >= 851f)
		{
			this.lrspeed = -this.lrspeed;
		}
	}

	// Token: 0x040018C1 RID: 6337
	private float IACGDFHKCAE;

	// Token: 0x040018C2 RID: 6338
	public float multiply = 3f;

	// Token: 0x040018C3 RID: 6339
	public float mspeed = 50f;

	// Token: 0x040018C4 RID: 6340
	public float lrspeed = 1f;

	// Token: 0x040018C5 RID: 6341
	public bool useRandomDirection;

	// Token: 0x040018C6 RID: 6342
	public bool useRandomSpeed;

	// Token: 0x040018C7 RID: 6343
	public string axis = "X";

	// Token: 0x040018C8 RID: 6344
	private Vector3 FDANOJICIBP;
}
