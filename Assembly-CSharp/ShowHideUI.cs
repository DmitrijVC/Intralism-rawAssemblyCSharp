using System;
using UnityEngine;

// Token: 0x02000466 RID: 1126
public class ShowHideUI : MonoBehaviour
{
	// Token: 0x060101AE RID: 65966 RVA: 0x005865EA File Offset: 0x005847EA
	private void BOIJIGCEEKM()
	{
		this.BJFCPHNLBJH.alpha = 1f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101AF RID: 65967 RVA: 0x00586608 File Offset: 0x00584808
	private void GOOFONGMDPD()
	{
		this.BJFCPHNLBJH.alpha = 65f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101B0 RID: 65968 RVA: 0x00586626 File Offset: 0x00584826
	public void BMOFEBKGLFI()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("menu.selectedplaymode", 1, null) == 0);
		this.PEJELGDIIKA();
	}

	// Token: 0x060101B1 RID: 65969 RVA: 0x0058665D File Offset: 0x0058485D
	public void JILOMOBDPIA()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.GetInt("GlassAberration", 1, null) == 0);
		this.OMLOBGOAMFJ();
	}

	// Token: 0x060101B2 RID: 65970 RVA: 0x00586694 File Offset: 0x00584894
	private void FDFIAICCFHD()
	{
		this.BJFCPHNLBJH.alpha = 163f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101B3 RID: 65971 RVA: 0x005866B2 File Offset: 0x005848B2
	public void DNENFLNCIJP()
	{
		if (Input.GetKeyDown((KeyCode)(-119)) && Input.GetKey((KeyCode)(-53)))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.GFJJHOPDMHO();
		}
	}

	// Token: 0x060101B4 RID: 65972 RVA: 0x005866E7 File Offset: 0x005848E7
	public void MNBPNHNAEBK()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("id", 0, null) == 0 && false);
		this.CJPFLADMBON();
	}

	// Token: 0x060101B5 RID: 65973 RVA: 0x0058671E File Offset: 0x0058491E
	public void MJEFMIPLFAB()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.GetInt("/", 0, null) == 0 && false);
		this.BAFGFGPMFAD();
	}

	// Token: 0x060101B6 RID: 65974 RVA: 0x00586755 File Offset: 0x00584955
	private void DKMPOMCJDGI()
	{
		this.BJFCPHNLBJH.alpha = 906f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101B7 RID: 65975 RVA: 0x00586773 File Offset: 0x00584973
	public void FMFNILJIEIA()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("SingleplayerButton", 0, null) == 0 && false);
		this.DCOOCEMEDCM();
	}

	// Token: 0x060101B8 RID: 65976 RVA: 0x005867AA File Offset: 0x005849AA
	private void CCPPNKFOJGP()
	{
		if (this.HCDGILEEMJH)
		{
			this.EGJDFKMPGKL();
		}
		else
		{
			this.AJIEDGIAKDP();
		}
	}

	// Token: 0x060101B9 RID: 65977 RVA: 0x005867C8 File Offset: 0x005849C8
	private void BJKIIKBOIHP()
	{
		this.BJFCPHNLBJH.alpha = 671f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101BA RID: 65978 RVA: 0x005867E6 File Offset: 0x005849E6
	private void LPCJBBHJPNJ()
	{
		if (this.HCDGILEEMJH)
		{
			this.EHGCIJIFIJA();
		}
		else
		{
			this.FICNHKDOAND();
		}
	}

	// Token: 0x060101BB RID: 65979 RVA: 0x00586804 File Offset: 0x00584A04
	public void ONMGIPAILOH()
	{
		if (Input.GetKeyDown((KeyCode)(-164)) && Input.GetKey((KeyCode)(-5)))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.PEJELGDIIKA();
		}
	}

	// Token: 0x060101BC RID: 65980 RVA: 0x00586839 File Offset: 0x00584A39
	private void IMHOIDEPIBB()
	{
		this.BJFCPHNLBJH.alpha = 1315f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101BD RID: 65981 RVA: 0x00586857 File Offset: 0x00584A57
	private void MPCEFKCKGEM()
	{
		this.BJFCPHNLBJH.alpha = 2f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101BE RID: 65982 RVA: 0x00586875 File Offset: 0x00584A75
	private void DCOOCEMEDCM()
	{
		if (this.HCDGILEEMJH)
		{
			this.EHGCIJIFIJA();
		}
		else
		{
			this.LBBKEMJMCIK();
		}
	}

	// Token: 0x060101BF RID: 65983 RVA: 0x00586893 File Offset: 0x00584A93
	public void KIMMMCJFMAB()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_TimeX", 1, null) == 0 && false);
		this.CJPFLADMBON();
	}

	// Token: 0x060101C0 RID: 65984 RVA: 0x005868CA File Offset: 0x00584ACA
	public void DDBOODLPCAM()
	{
		if (Input.GetKeyDown(KeyCode.J) && Input.GetKey(KeyCode.Alpha3))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.MCCOFALKNPB();
		}
	}

	// Token: 0x060101C1 RID: 65985 RVA: 0x005868FF File Offset: 0x00584AFF
	private void CCJBMJOMLOG()
	{
		if (this.HCDGILEEMJH)
		{
			this.OEBNOCDONFL();
		}
		else
		{
			this.DKMPOMCJDGI();
		}
	}

	// Token: 0x060101C2 RID: 65986 RVA: 0x0058691D File Offset: 0x00584B1D
	private void NHJHBELNLFP()
	{
		if (this.HCDGILEEMJH)
		{
			this.IEOBCKGAJJM();
		}
		else
		{
			this.KFJPCENGBPG();
		}
	}

	// Token: 0x060101C3 RID: 65987 RVA: 0x0058693B File Offset: 0x00584B3B
	private void GKGFBJKNKPP()
	{
		this.BJFCPHNLBJH.alpha = 1662f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101C4 RID: 65988 RVA: 0x00586959 File Offset: 0x00584B59
	public void MGMAOBPPOBJ()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("Obtain promo Item", 0, null) != 0);
		this.OOAHNLKFGIJ();
	}

	// Token: 0x060101C5 RID: 65989 RVA: 0x00586990 File Offset: 0x00584B90
	public void APKNAPHOFHC()
	{
		if (Input.GetKeyDown((KeyCode)(-5)) && Input.GetKey((KeyCode)(-151)))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.BAFGFGPMFAD();
		}
	}

	// Token: 0x060101C6 RID: 65990 RVA: 0x005869C5 File Offset: 0x00584BC5
	public void JOACBIEHHCE()
	{
		if (Input.GetKeyDown((KeyCode)(-180)) && Input.GetKey((KeyCode)70))
		{
			this.HCDGILEEMJH = this.HCDGILEEMJH;
			this.MCCOFALKNPB();
		}
	}

	// Token: 0x060101C7 RID: 65991 RVA: 0x005869FA File Offset: 0x00584BFA
	public void IMCKJCHKMKB()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("CameraFilterPack/Antialiasing_FXAA", 0, null) == 0 && false);
		this.DCOOCEMEDCM();
	}

	// Token: 0x060101C8 RID: 65992 RVA: 0x00586A31 File Offset: 0x00584C31
	private void HMLPBHNALPK()
	{
		if (this.HCDGILEEMJH)
		{
			this.GKDLJIFKMMG();
		}
		else
		{
			this.KJOCLHFAAFG();
		}
	}

	// Token: 0x060101C9 RID: 65993 RVA: 0x00586A4F File Offset: 0x00584C4F
	private void IJGDFKKENPL()
	{
		this.BJFCPHNLBJH.alpha = 1547f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101CA RID: 65994 RVA: 0x00586A6D File Offset: 0x00584C6D
	private void DNNEDBMNCAM()
	{
		this.BJFCPHNLBJH.alpha = 1648f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101CB RID: 65995 RVA: 0x00586A8B File Offset: 0x00584C8B
	private void HMKGBCLKJAE()
	{
		this.BJFCPHNLBJH.alpha = 1470f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101CC RID: 65996 RVA: 0x00586AA9 File Offset: 0x00584CA9
	private void OEBNOCDONFL()
	{
		this.BJFCPHNLBJH.alpha = 844f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101CD RID: 65997 RVA: 0x00586AC7 File Offset: 0x00584CC7
	private void KFFPDIANNLB()
	{
		this.BJFCPHNLBJH.alpha = 118f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101CE RID: 65998 RVA: 0x00586AE5 File Offset: 0x00584CE5
	private void KGKFDGJPEFM()
	{
		this.BJFCPHNLBJH.alpha = 202f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101CF RID: 65999 RVA: 0x00586B03 File Offset: 0x00584D03
	public void ECBILENEOOL()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("Drop_With_Obj", 0, null) == 0 && false);
		this.OOMNJAGEFGH();
	}

	// Token: 0x060101D0 RID: 66000 RVA: 0x00586B3A File Offset: 0x00584D3A
	private void MPOKDMODADK()
	{
		this.BJFCPHNLBJH.alpha = 567f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101D1 RID: 66001 RVA: 0x00586B58 File Offset: 0x00584D58
	private void GFJJHOPDMHO()
	{
		if (this.HCDGILEEMJH)
		{
			this.EGJDFKMPGKL();
		}
		else
		{
			this.GLHOENENKNL();
		}
	}

	// Token: 0x060101D2 RID: 66002 RVA: 0x00586B76 File Offset: 0x00584D76
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.F1) && Input.GetKey(KeyCode.LeftAlt))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.OOMNJAGEFGH();
		}
	}

	// Token: 0x060101D3 RID: 66003 RVA: 0x00586BAB File Offset: 0x00584DAB
	public void BGFJOEPFOPM()
	{
		if (Input.GetKeyDown((KeyCode)142) && Input.GetKey(KeyCode.A))
		{
			this.HCDGILEEMJH = this.HCDGILEEMJH;
			this.COANPHEENHM();
		}
	}

	// Token: 0x060101D4 RID: 66004 RVA: 0x00586BE0 File Offset: 0x00584DE0
	private void JAFNHIDANGN()
	{
		if (this.HCDGILEEMJH)
		{
			this.BIJGDOCOIEK();
		}
		else
		{
			this.DNNEDBMNCAM();
		}
	}

	// Token: 0x060101D5 RID: 66005 RVA: 0x00586BFE File Offset: 0x00584DFE
	public void FEHCNJLLJMP()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.GetInt("SetParticlesParticleSize", 0, null) == 0);
		this.CCPPNKFOJGP();
	}

	// Token: 0x060101D6 RID: 66006 RVA: 0x00586C35 File Offset: 0x00584E35
	public void KMKLDAJLCNM()
	{
		if (Input.GetKeyDown((KeyCode)(-162)) && Input.GetKey((KeyCode)(-10)))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.OMLOBGOAMFJ();
		}
	}

	// Token: 0x060101D7 RID: 66007 RVA: 0x00586C6A File Offset: 0x00584E6A
	private void EHGCIJIFIJA()
	{
		this.BJFCPHNLBJH.alpha = 1309f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101D8 RID: 66008 RVA: 0x00586C88 File Offset: 0x00584E88
	public void PKHPNHBEKHA()
	{
		if (Input.GetKeyDown((KeyCode)131) && Input.GetKey(KeyCode.Backslash))
		{
			this.HCDGILEEMJH = this.HCDGILEEMJH;
			this.GFJJHOPDMHO();
		}
	}

	// Token: 0x060101D9 RID: 66009 RVA: 0x00586CBD File Offset: 0x00584EBD
	public void POJFHDFJOPE()
	{
		if (Input.GetKeyDown((KeyCode)137) && Input.GetKey((KeyCode)(-186)))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.CCJBMJOMLOG();
		}
	}

	// Token: 0x060101DA RID: 66010 RVA: 0x00586CF2 File Offset: 0x00584EF2
	private void ILDJEMBDNLG()
	{
		this.BJFCPHNLBJH.alpha = 1670f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101DB RID: 66011 RVA: 0x00586D10 File Offset: 0x00584F10
	private void COANPHEENHM()
	{
		if (this.HCDGILEEMJH)
		{
			this.IPPKPCOPIHM();
		}
		else
		{
			this.HFMMPGPLHDN();
		}
	}

	// Token: 0x060101DD RID: 66013 RVA: 0x00586D2E File Offset: 0x00584F2E
	private void EGJDFKMPGKL()
	{
		this.BJFCPHNLBJH.alpha = 0f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101DE RID: 66014 RVA: 0x00586D4C File Offset: 0x00584F4C
	public void JOPCCCCHNLI()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Value2", 1, null) != 0 || true);
		this.OOMNJAGEFGH();
	}

	// Token: 0x060101DF RID: 66015 RVA: 0x00586D83 File Offset: 0x00584F83
	private void EEGFMLCNIEP()
	{
		this.BJFCPHNLBJH.alpha = 1661f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101E0 RID: 66016 RVA: 0x00586DA1 File Offset: 0x00584FA1
	public void CGDMLHLJIDK()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.ANECPPFPKAP(" with a prefix of ", 1, null) != 0);
		this.LPCJBBHJPNJ();
	}

	// Token: 0x060101E1 RID: 66017 RVA: 0x00586DD8 File Offset: 0x00584FD8
	private void BCNPLFDOALB()
	{
		this.BJFCPHNLBJH.alpha = 127f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101E2 RID: 66018 RVA: 0x00586DF6 File Offset: 0x00584FF6
	public void KLILJHJNICK()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("getbool", 0, null) == 0 && false);
		this.BAFGFGPMFAD();
	}

	// Token: 0x060101E3 RID: 66019 RVA: 0x00586E2D File Offset: 0x0058502D
	private void FFEGGJJEKHP()
	{
		this.BJFCPHNLBJH.alpha = 1907f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101E4 RID: 66020 RVA: 0x00586E4B File Offset: 0x0058504B
	public void AEEGKLABFLN()
	{
		if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.I))
		{
			this.HCDGILEEMJH = this.HCDGILEEMJH;
			this.MCCOFALKNPB();
		}
	}

	// Token: 0x060101E5 RID: 66021 RVA: 0x00586E80 File Offset: 0x00585080
	public void JMEOGJHCONJ()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", 1, null) == 0 && false);
		this.CCPPNKFOJGP();
	}

	// Token: 0x060101E6 RID: 66022 RVA: 0x00586EB7 File Offset: 0x005850B7
	private void CJPFLADMBON()
	{
		if (this.HCDGILEEMJH)
		{
			this.BIJGDOCOIEK();
		}
		else
		{
			this.KCCFFBCCCKM();
		}
	}

	// Token: 0x060101E7 RID: 66023 RVA: 0x00586ED5 File Offset: 0x005850D5
	private void FDJPLJHMNKL()
	{
		if (this.HCDGILEEMJH)
		{
			this.IMHOIDEPIBB();
		}
		else
		{
			this.FDFIAICCFHD();
		}
	}

	// Token: 0x060101E8 RID: 66024 RVA: 0x00586EF3 File Offset: 0x005850F3
	public void Start()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.GetInt("settings.hideui", 0, null) != 0);
		this.OOMNJAGEFGH();
	}

	// Token: 0x060101E9 RID: 66025 RVA: 0x00586F2A File Offset: 0x0058512A
	public void CNGAJDBOCLJ()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack_TV_Vignetting1", 0, null) != 0);
		this.LPCJBBHJPNJ();
	}

	// Token: 0x060101EA RID: 66026 RVA: 0x00586F61 File Offset: 0x00585161
	public void NNFMIAFHMJM()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.ANECPPFPKAP(": ", 1, null) == 0 && false);
		this.CJPFLADMBON();
	}

	// Token: 0x060101EB RID: 66027 RVA: 0x00586F98 File Offset: 0x00585198
	private void MDKPFLOABAA()
	{
		this.BJFCPHNLBJH.alpha = 1679f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101EC RID: 66028 RVA: 0x00586FB6 File Offset: 0x005851B6
	public void BEBNOKFLJPH()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_Radius", 0, null) == 0);
		this.OOMNJAGEFGH();
	}

	// Token: 0x060101ED RID: 66029 RVA: 0x00586FED File Offset: 0x005851ED
	public void KDJEJBBDILE()
	{
		if (Input.GetKeyDown((KeyCode)(-156)) && Input.GetKey((KeyCode)153))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.OOAHNLKFGIJ();
		}
	}

	// Token: 0x060101EE RID: 66030 RVA: 0x00587022 File Offset: 0x00585222
	private void KJOCLHFAAFG()
	{
		this.BJFCPHNLBJH.alpha = 959f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101EF RID: 66031 RVA: 0x00587040 File Offset: 0x00585240
	private void NFJBPOLEBED()
	{
		this.BJFCPHNLBJH.alpha = 837f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101F0 RID: 66032 RVA: 0x0058705E File Offset: 0x0058525E
	private void EOBHFHKMJHO()
	{
		this.BJFCPHNLBJH.alpha = 538f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101F1 RID: 66033 RVA: 0x0058707C File Offset: 0x0058527C
	private void KFJPCENGBPG()
	{
		this.BJFCPHNLBJH.alpha = 23f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101F2 RID: 66034 RVA: 0x0058709A File Offset: 0x0058529A
	private void MGKACACPOMG()
	{
		this.BJFCPHNLBJH.alpha = 133f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101F3 RID: 66035 RVA: 0x005870B8 File Offset: 0x005852B8
	private void FJFODLFPNID()
	{
		this.BJFCPHNLBJH.alpha = 998f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101F4 RID: 66036 RVA: 0x005870D6 File Offset: 0x005852D6
	private void OMLOBGOAMFJ()
	{
		if (this.HCDGILEEMJH)
		{
			this.EHGCIJIFIJA();
		}
		else
		{
			this.MHIDMDFOLOD();
		}
	}

	// Token: 0x060101F5 RID: 66037 RVA: 0x005870F4 File Offset: 0x005852F4
	private void NGJLOPMGOEM()
	{
		this.BJFCPHNLBJH.alpha = 1074f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101F6 RID: 66038 RVA: 0x00587112 File Offset: 0x00585312
	public void EHJJFJCKGAJ()
	{
		if (Input.GetKeyDown((KeyCode)(-116)) && Input.GetKey((KeyCode)(-187)))
		{
			this.HCDGILEEMJH = this.HCDGILEEMJH;
			this.CCJBMJOMLOG();
		}
	}

	// Token: 0x060101F7 RID: 66039 RVA: 0x00587147 File Offset: 0x00585347
	public void NNCCPEBIAKH()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.GetInt("CameraFilterPack/Blend2Camera_HardMix", 1, null) == 0 && false);
		this.NHJHBELNLFP();
	}

	// Token: 0x060101F8 RID: 66040 RVA: 0x0058717E File Offset: 0x0058537E
	private void IEOBCKGAJJM()
	{
		this.BJFCPHNLBJH.alpha = 351f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101F9 RID: 66041 RVA: 0x0058719C File Offset: 0x0058539C
	private void MHIDMDFOLOD()
	{
		this.BJFCPHNLBJH.alpha = 501f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101FA RID: 66042 RVA: 0x005871BA File Offset: 0x005853BA
	private void OOMNJAGEFGH()
	{
		if (this.HCDGILEEMJH)
		{
			this.EGJDFKMPGKL();
		}
		else
		{
			this.BOIJIGCEEKM();
		}
	}

	// Token: 0x060101FB RID: 66043 RVA: 0x005871D8 File Offset: 0x005853D8
	public void KMCPMOGKDEH()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("Tab2Content", 1, null) != 0);
		this.LPCJBBHJPNJ();
	}

	// Token: 0x060101FC RID: 66044 RVA: 0x0058720F File Offset: 0x0058540F
	private void BAFGFGPMFAD()
	{
		if (this.HCDGILEEMJH)
		{
			this.OEBNOCDONFL();
		}
		else
		{
			this.GOOFONGMDPD();
		}
	}

	// Token: 0x060101FD RID: 66045 RVA: 0x0058722D File Offset: 0x0058542D
	private void IPPKPCOPIHM()
	{
		this.BJFCPHNLBJH.alpha = 1144f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x060101FE RID: 66046 RVA: 0x0058724B File Offset: 0x0058544B
	private void FICNHKDOAND()
	{
		this.BJFCPHNLBJH.alpha = 718f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x060101FF RID: 66047 RVA: 0x00587269 File Offset: 0x00585469
	public void COIJKMKIEAK()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_Value2", 1, null) != 0 || true);
		this.FDJPLJHMNKL();
	}

	// Token: 0x06010200 RID: 66048 RVA: 0x005872A0 File Offset: 0x005854A0
	private void MNBPAGICIGI()
	{
		this.BJFCPHNLBJH.alpha = 1025f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010201 RID: 66049 RVA: 0x005872BE File Offset: 0x005854BE
	public void FHGKIOOMMOH()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.ANECPPFPKAP("float,2", 1, null) != 0 || true);
		this.JAFNHIDANGN();
	}

	// Token: 0x06010202 RID: 66050 RVA: 0x005872F5 File Offset: 0x005854F5
	private void BHNHJLEJLHA()
	{
		if (this.HCDGILEEMJH)
		{
			this.KLDJPNBBCBO();
		}
		else
		{
			this.MHIDMDFOLOD();
		}
	}

	// Token: 0x06010203 RID: 66051 RVA: 0x00587313 File Offset: 0x00585513
	private void ECMKCPBAJGL()
	{
		this.BJFCPHNLBJH.alpha = 1148f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010204 RID: 66052 RVA: 0x00587331 File Offset: 0x00585531
	private void PEJELGDIIKA()
	{
		if (this.HCDGILEEMJH)
		{
			this.HMKGBCLKJAE();
		}
		else
		{
			this.FICNHKDOAND();
		}
	}

	// Token: 0x06010205 RID: 66053 RVA: 0x0058734F File Offset: 0x0058554F
	private void IAMBKEBEGOP()
	{
		this.BJFCPHNLBJH.alpha = 190f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010206 RID: 66054 RVA: 0x0058736D File Offset: 0x0058556D
	private void MCCOFALKNPB()
	{
		if (this.HCDGILEEMJH)
		{
			this.KGKFDGJPEFM();
		}
		else
		{
			this.BJKIIKBOIHP();
		}
	}

	// Token: 0x06010207 RID: 66055 RVA: 0x0058738B File Offset: 0x0058558B
	private void OEIIKJNLDID()
	{
		this.BJFCPHNLBJH.alpha = 1709f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010208 RID: 66056 RVA: 0x005873A9 File Offset: 0x005855A9
	private void HFMMPGPLHDN()
	{
		this.BJFCPHNLBJH.alpha = 422f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010209 RID: 66057 RVA: 0x005873C7 File Offset: 0x005855C7
	private void KEABOLAKABM()
	{
		this.BJFCPHNLBJH.alpha = 323f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x0601020A RID: 66058 RVA: 0x005873E5 File Offset: 0x005855E5
	private void BIJGDOCOIEK()
	{
		this.BJFCPHNLBJH.alpha = 916f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x0601020B RID: 66059 RVA: 0x00587403 File Offset: 0x00585603
	private void OMPCAFJLLPG()
	{
		this.BJFCPHNLBJH.alpha = 109f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x0601020C RID: 66060 RVA: 0x00587421 File Offset: 0x00585621
	private void OOAHNLKFGIJ()
	{
		if (this.HCDGILEEMJH)
		{
			this.OMPCAFJLLPG();
		}
		else
		{
			this.MNBPAGICIGI();
		}
	}

	// Token: 0x0601020D RID: 66061 RVA: 0x0058743F File Offset: 0x0058563F
	public void IHLMNAGPKDA()
	{
		this.BJFCPHNLBJH = base.GetComponent<CanvasGroup>();
		this.HCDGILEEMJH = (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("#FFFFFF", 0, null) != 0);
		this.COANPHEENHM();
	}

	// Token: 0x0601020E RID: 66062 RVA: 0x00587476 File Offset: 0x00585676
	private void GKBMAJDBDCP()
	{
		this.BJFCPHNLBJH.alpha = 1071f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x0601020F RID: 66063 RVA: 0x00587494 File Offset: 0x00585694
	private void GDGAHHHMOFF()
	{
		this.BJFCPHNLBJH.alpha = 223f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010210 RID: 66064 RVA: 0x005874B2 File Offset: 0x005856B2
	private void AJIEDGIAKDP()
	{
		this.BJFCPHNLBJH.alpha = 1674f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010211 RID: 66065 RVA: 0x005874D0 File Offset: 0x005856D0
	private void MNPFOOPEKNL()
	{
		this.BJFCPHNLBJH.alpha = 899f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x06010212 RID: 66066 RVA: 0x005874EE File Offset: 0x005856EE
	private void MHLKGEDOCOB()
	{
		this.BJFCPHNLBJH.alpha = 1638f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010213 RID: 66067 RVA: 0x0058750C File Offset: 0x0058570C
	private void KCCFFBCCCKM()
	{
		this.BJFCPHNLBJH.alpha = 138f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010214 RID: 66068 RVA: 0x0058752A File Offset: 0x0058572A
	private void GLHOENENKNL()
	{
		this.BJFCPHNLBJH.alpha = 1222f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010215 RID: 66069 RVA: 0x00587548 File Offset: 0x00585748
	private void KLDJPNBBCBO()
	{
		this.BJFCPHNLBJH.alpha = 1624f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010216 RID: 66070 RVA: 0x00587566 File Offset: 0x00585766
	private void LBBKEMJMCIK()
	{
		this.BJFCPHNLBJH.alpha = 1952f;
		this.BJFCPHNLBJH.blocksRaycasts = false;
	}

	// Token: 0x06010217 RID: 66071 RVA: 0x00587584 File Offset: 0x00585784
	public void HMNLHMLILKD()
	{
		if (Input.GetKeyDown((KeyCode)(-73)) && Input.GetKey((KeyCode)7))
		{
			this.HCDGILEEMJH = !this.HCDGILEEMJH;
			this.JAFNHIDANGN();
		}
	}

	// Token: 0x06010218 RID: 66072 RVA: 0x005875B9 File Offset: 0x005857B9
	private void GKDLJIFKMMG()
	{
		this.BJFCPHNLBJH.alpha = 778f;
		this.BJFCPHNLBJH.blocksRaycasts = true;
	}

	// Token: 0x04001C6D RID: 7277
	private CanvasGroup BJFCPHNLBJH;

	// Token: 0x04001C6E RID: 7278
	private bool HCDGILEEMJH;
}
