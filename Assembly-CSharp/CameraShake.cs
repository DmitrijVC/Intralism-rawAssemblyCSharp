using System;
using UnityEngine;

// Token: 0x0200040B RID: 1035
public class CameraShake : MonoBehaviour
{
	// Token: 0x0600ED56 RID: 60758 RVA: 0x005366D1 File Offset: 0x005348D1
	private void KNBJBNDGCIJ()
	{
		this.AJPABMEPCDO = 1967f;
		this.Shaking = false;
	}

	// Token: 0x0600ED57 RID: 60759 RVA: 0x005366E5 File Offset: 0x005348E5
	private void Start()
	{
		this.AJPABMEPCDO = 1f;
		this.Shaking = false;
	}

	// Token: 0x0600ED58 RID: 60760 RVA: 0x005366F9 File Offset: 0x005348F9
	private void CNGAJDBOCLJ()
	{
		this.AJPABMEPCDO = 1697f;
		this.Shaking = true;
	}

	// Token: 0x0600ED59 RID: 60761 RVA: 0x0053670D File Offset: 0x0053490D
	public void ECECLAODKDH()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1459f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 750f;
		this.Shaking = false;
	}

	// Token: 0x0600ED5A RID: 60762 RVA: 0x0053673F File Offset: 0x0053493F
	public void MAMEGGAMLHE()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1607f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 718f;
		this.Shaking = true;
	}

	// Token: 0x0600ED5B RID: 60763 RVA: 0x00536771 File Offset: 0x00534971
	public void JNIMLCFKEKO()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 52f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1465f;
		this.Shaking = false;
	}

	// Token: 0x0600ED5C RID: 60764 RVA: 0x005367A3 File Offset: 0x005349A3
	public void GDNOHEFHGLM()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1865f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 545f;
		this.Shaking = false;
	}

	// Token: 0x0600ED5D RID: 60765 RVA: 0x005367D8 File Offset: 0x005349D8
	private void OEENOOGEEHD()
	{
		if (this.CCBCCEGBOJP > 888f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED5E RID: 60766 RVA: 0x00536888 File Offset: 0x00534A88
	public void DoShake()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 0.1f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 0.01f;
		this.Shaking = true;
	}

	// Token: 0x0600ED5F RID: 60767 RVA: 0x005368BC File Offset: 0x00534ABC
	private void LMBDNPLDGIJ()
	{
		if (this.CCBCCEGBOJP > 1256f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED60 RID: 60768 RVA: 0x0053696C File Offset: 0x00534B6C
	public void JNJHIEGEOOO()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 809f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 852f;
		this.Shaking = false;
	}

	// Token: 0x0600ED61 RID: 60769 RVA: 0x0053699E File Offset: 0x00534B9E
	public void FAGLLNKBPEC()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 892f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 185f;
		this.Shaking = false;
	}

	// Token: 0x0600ED62 RID: 60770 RVA: 0x005369D0 File Offset: 0x00534BD0
	private void MMMDPANNAIO()
	{
		this.AJPABMEPCDO = 580f;
		this.Shaking = false;
	}

	// Token: 0x0600ED63 RID: 60771 RVA: 0x005369E4 File Offset: 0x00534BE4
	public void ALNOMJIJCKH()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 233f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1653f;
		this.Shaking = false;
	}

	// Token: 0x0600ED64 RID: 60772 RVA: 0x00536A18 File Offset: 0x00534C18
	private void Update()
	{
		if (this.CCBCCEGBOJP > 0f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED65 RID: 60773 RVA: 0x00536AC8 File Offset: 0x00534CC8
	public void HPJLIGJEDCN()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 37f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1736f;
		this.Shaking = true;
	}

	// Token: 0x0600ED66 RID: 60774 RVA: 0x00536AFA File Offset: 0x00534CFA
	public void KCNFNGGNLOH()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 450f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 225f;
		this.Shaking = false;
	}

	// Token: 0x0600ED67 RID: 60775 RVA: 0x00536B2C File Offset: 0x00534D2C
	private void KIMMMCJFMAB()
	{
		this.AJPABMEPCDO = 764f;
		this.Shaking = true;
	}

	// Token: 0x0600ED68 RID: 60776 RVA: 0x00536B40 File Offset: 0x00534D40
	private void OCMKCBBCEFG()
	{
		if (this.CCBCCEGBOJP > 235f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED69 RID: 60777 RVA: 0x00536BF0 File Offset: 0x00534DF0
	public void IENDDEJLNMJ()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 120f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 701f;
		this.Shaking = false;
	}

	// Token: 0x0600ED6A RID: 60778 RVA: 0x00536C24 File Offset: 0x00534E24
	private void FJHFOBHJEHL()
	{
		if (this.CCBCCEGBOJP > 1476f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED6B RID: 60779 RVA: 0x00536CD4 File Offset: 0x00534ED4
	public void NLKNJIOIEGF()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1731f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 25f;
		this.Shaking = false;
	}

	// Token: 0x0600ED6C RID: 60780 RVA: 0x00536D06 File Offset: 0x00534F06
	private void COIJKMKIEAK()
	{
		this.AJPABMEPCDO = 170f;
		this.Shaking = false;
	}

	// Token: 0x0600ED6D RID: 60781 RVA: 0x00536D1C File Offset: 0x00534F1C
	private void DPIPGGDNGHN()
	{
		if (this.CCBCCEGBOJP > 1962f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED6E RID: 60782 RVA: 0x00536DCC File Offset: 0x00534FCC
	private void JKFDDNMPOJH()
	{
		this.AJPABMEPCDO = 243f;
		this.Shaking = false;
	}

	// Token: 0x0600ED6F RID: 60783 RVA: 0x00536DE0 File Offset: 0x00534FE0
	private void HDDECCMEJKA()
	{
		if (this.CCBCCEGBOJP > 1245f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED70 RID: 60784 RVA: 0x00536E90 File Offset: 0x00535090
	public void ECMEEEHCMPN()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1442f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 86f;
		this.Shaking = true;
	}

	// Token: 0x0600ED71 RID: 60785 RVA: 0x00536EC4 File Offset: 0x005350C4
	private void AIJGAJIOJDJ()
	{
		if (this.CCBCCEGBOJP > 1974f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED72 RID: 60786 RVA: 0x00536F74 File Offset: 0x00535174
	private void OMCLOFCJMPG()
	{
		if (this.CCBCCEGBOJP > 899f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED73 RID: 60787 RVA: 0x00537024 File Offset: 0x00535224
	public void BPJFPCKBBBI()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 415f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1735f;
		this.Shaking = true;
	}

	// Token: 0x0600ED74 RID: 60788 RVA: 0x00537058 File Offset: 0x00535258
	private void JBNPEHMDCMI()
	{
		if (this.CCBCCEGBOJP > 388f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED75 RID: 60789 RVA: 0x00537108 File Offset: 0x00535308
	public void LGMMEJIIMFB()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 208f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 298f;
		this.Shaking = false;
	}

	// Token: 0x0600ED76 RID: 60790 RVA: 0x0053713A File Offset: 0x0053533A
	public void CHDKKNAGGBN()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1305f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 356f;
		this.Shaking = false;
	}

	// Token: 0x0600ED77 RID: 60791 RVA: 0x0053716C File Offset: 0x0053536C
	private void EHCGBJDFMHG()
	{
		if (this.CCBCCEGBOJP > 53f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED78 RID: 60792 RVA: 0x0053721C File Offset: 0x0053541C
	private void JBCNIPJDPJB()
	{
		if (this.CCBCCEGBOJP > 261f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED79 RID: 60793 RVA: 0x005372CC File Offset: 0x005354CC
	private void BGDPIHMAACO()
	{
		this.AJPABMEPCDO = 489f;
		this.Shaking = false;
	}

	// Token: 0x0600ED7A RID: 60794 RVA: 0x005372E0 File Offset: 0x005354E0
	private void MMBPLGGLPDB()
	{
		if (this.CCBCCEGBOJP > 1406f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED7B RID: 60795 RVA: 0x00537390 File Offset: 0x00535590
	private void KMCPMOGKDEH()
	{
		this.AJPABMEPCDO = 1337f;
		this.Shaking = false;
	}

	// Token: 0x0600ED7C RID: 60796 RVA: 0x005373A4 File Offset: 0x005355A4
	private void HLDFOJMHKNL()
	{
		if (this.CCBCCEGBOJP > 1377f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED7D RID: 60797 RVA: 0x00537454 File Offset: 0x00535654
	public void EGFJOEHKFJF()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 467f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1207f;
		this.Shaking = false;
	}

	// Token: 0x0600ED7E RID: 60798 RVA: 0x00537486 File Offset: 0x00535686
	public void FNCDDBKLOFN()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1234f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1393f;
		this.Shaking = false;
	}

	// Token: 0x0600ED7F RID: 60799 RVA: 0x005374B8 File Offset: 0x005356B8
	private void EFJDNLGNACH()
	{
		this.AJPABMEPCDO = 230f;
		this.Shaking = false;
	}

	// Token: 0x0600ED80 RID: 60800 RVA: 0x005374CC File Offset: 0x005356CC
	private void AGMJDGHLBMN()
	{
		if (this.CCBCCEGBOJP > 1500f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED81 RID: 60801 RVA: 0x0053757C File Offset: 0x0053577C
	private void FBMDHDBELEK()
	{
		if (this.CCBCCEGBOJP > 719f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED82 RID: 60802 RVA: 0x0053762C File Offset: 0x0053582C
	private void PDHKMDBNGGN()
	{
		this.AJPABMEPCDO = 514f;
		this.Shaking = true;
	}

	// Token: 0x0600ED83 RID: 60803 RVA: 0x00537640 File Offset: 0x00535840
	private void JOACBIEHHCE()
	{
		if (this.CCBCCEGBOJP > 1477f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED84 RID: 60804 RVA: 0x005376F0 File Offset: 0x005358F0
	public void INMLGEJKIEA()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 71f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 902f;
		this.Shaking = true;
	}

	// Token: 0x0600ED85 RID: 60805 RVA: 0x00537722 File Offset: 0x00535922
	private void HMPGIFBJFIK()
	{
		this.AJPABMEPCDO = 452f;
		this.Shaking = false;
	}

	// Token: 0x0600ED86 RID: 60806 RVA: 0x00537736 File Offset: 0x00535936
	public void LFBGEGONCFB()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 10f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 633f;
		this.Shaking = true;
	}

	// Token: 0x0600ED87 RID: 60807 RVA: 0x00537768 File Offset: 0x00535968
	private void KMKLDAJLCNM()
	{
		if (this.CCBCCEGBOJP > 177f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED88 RID: 60808 RVA: 0x00537818 File Offset: 0x00535A18
	public void EKHPBHLPCIJ()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 140f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1503f;
		this.Shaking = false;
	}

	// Token: 0x0600ED89 RID: 60809 RVA: 0x0053784C File Offset: 0x00535A4C
	private void JHPOIOELNCG()
	{
		if (this.CCBCCEGBOJP > 479f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED8A RID: 60810 RVA: 0x005378FC File Offset: 0x00535AFC
	private void JDGFCEPDKAJ()
	{
		if (this.CCBCCEGBOJP > 1480f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED8B RID: 60811 RVA: 0x005379AC File Offset: 0x00535BAC
	public void MOBKOGEAHAD()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1590f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 54f;
		this.Shaking = false;
	}

	// Token: 0x0600ED8C RID: 60812 RVA: 0x005379E0 File Offset: 0x00535BE0
	private void NEKCPLGFOFD()
	{
		if (this.CCBCCEGBOJP > 1666f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED8D RID: 60813 RVA: 0x00537A90 File Offset: 0x00535C90
	private void FABMDEHEDNO()
	{
		if (this.CCBCCEGBOJP > 188f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = true;
		}
	}

	// Token: 0x0600ED8E RID: 60814 RVA: 0x00537B40 File Offset: 0x00535D40
	private void LCJHDLKJEOM()
	{
		if (this.CCBCCEGBOJP > 943f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED8F RID: 60815 RVA: 0x00537BF0 File Offset: 0x00535DF0
	private void EGEGNHLODAA()
	{
		if (this.CCBCCEGBOJP > 1579f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED90 RID: 60816 RVA: 0x00537CA0 File Offset: 0x00535EA0
	public void BJGIECMBDBG()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 412f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1024f;
		this.Shaking = true;
	}

	// Token: 0x0600ED91 RID: 60817 RVA: 0x00537CD2 File Offset: 0x00535ED2
	private void MKIMDFLBFOM()
	{
		this.AJPABMEPCDO = 984f;
		this.Shaking = true;
	}

	// Token: 0x0600ED92 RID: 60818 RVA: 0x00537CE6 File Offset: 0x00535EE6
	public void IOAFNIKIDIJ()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 1495f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 1342f;
		this.Shaking = false;
	}

	// Token: 0x0600ED93 RID: 60819 RVA: 0x00537D18 File Offset: 0x00535F18
	private void FOMNCPKKCFN()
	{
		if (this.CCBCCEGBOJP > 1259f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED94 RID: 60820 RVA: 0x00537DC8 File Offset: 0x00535FC8
	private void DIPDEHOOBPG()
	{
		this.AJPABMEPCDO = 1082f;
		this.Shaking = false;
	}

	// Token: 0x0600ED95 RID: 60821 RVA: 0x00537DDC File Offset: 0x00535FDC
	private void LCHBFNIPBHB()
	{
		if (this.CCBCCEGBOJP > 735f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED96 RID: 60822 RVA: 0x00537E8C File Offset: 0x0053608C
	public void EFAHBIHGFBJ()
	{
		this.KCCFEAIFEHC = this.basePoition;
		this.CCBCCEGBOJP = 998f * this.AJPABMEPCDO;
		this.NGGFNGMNGAC = 807f;
		this.Shaking = false;
	}

	// Token: 0x0600ED97 RID: 60823 RVA: 0x00537EC0 File Offset: 0x005360C0
	private void MFMIODIAKNI()
	{
		if (this.CCBCCEGBOJP > 146f)
		{
			base.transform.localPosition = new Vector3((this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).x, (this.KCCFEAIFEHC + UnityEngine.Random.insideUnitSphere * this.CCBCCEGBOJP).y, base.transform.localPosition.z);
			this.CCBCCEGBOJP -= this.NGGFNGMNGAC;
		}
		else if (this.Shaking)
		{
			this.Shaking = false;
		}
	}

	// Token: 0x0600ED98 RID: 60824 RVA: 0x00537F70 File Offset: 0x00536170
	private void JHANGPCOCIG()
	{
		this.AJPABMEPCDO = 1705f;
		this.Shaking = false;
	}

	// Token: 0x0600ED99 RID: 60825 RVA: 0x00537F84 File Offset: 0x00536184
	private void FBPHNEJBDJN()
	{
		this.AJPABMEPCDO = 15f;
		this.Shaking = true;
	}

	// Token: 0x04001A96 RID: 6806
	public bool Shaking;

	// Token: 0x04001A97 RID: 6807
	private float NGGFNGMNGAC;

	// Token: 0x04001A98 RID: 6808
	private float CCBCCEGBOJP;

	// Token: 0x04001A99 RID: 6809
	private float AJPABMEPCDO = 1f;

	// Token: 0x04001A9A RID: 6810
	private Vector3 KCCFEAIFEHC;

	// Token: 0x04001A9B RID: 6811
	public Vector3 basePoition = new Vector3(0f, 0f, 0f);
}
