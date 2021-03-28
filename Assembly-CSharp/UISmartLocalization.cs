using System;
using System.Collections;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200016A RID: 362
public class UISmartLocalization : MonoBehaviour
{
	// Token: 0x06006A51 RID: 27217 RVA: 0x0020BF58 File Offset: 0x0020A158
	private IEnumerator AOHNELGHACA()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006A52 RID: 27218 RVA: 0x0020BF73 File Offset: 0x0020A173
	private void NEEPEGIEHPF()
	{
		this.CBEDHJJKLFF(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A53 RID: 27219 RVA: 0x0020BF8B File Offset: 0x0020A18B
	private void NFADGEDMNMF()
	{
		this.MNHCBCCOOMJ();
	}

	// Token: 0x06006A54 RID: 27220 RVA: 0x0020BF93 File Offset: 0x0020A193
	private void GOCDFEABHHB()
	{
		this.GEAIBNOIDMP();
	}

	// Token: 0x06006A55 RID: 27221 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool IENKONGFMIC()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A56 RID: 27222 RVA: 0x0020BFBA File Offset: 0x0020A1BA
	private string IHOAIDIJPNA(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_SecondTex", Environment.NewLine);
	}

	// Token: 0x06006A57 RID: 27223 RVA: 0x0020BFDD File Offset: 0x0020A1DD
	private void JHANGPCOCIG()
	{
		base.StartCoroutine(this.OGJGNCKCLAE());
	}

	// Token: 0x06006A58 RID: 27224 RVA: 0x0020BFEC File Offset: 0x0020A1EC
	private void MNHCBCCOOMJ()
	{
		this.GHJJDAJIOPM(LocalizationService.Instance.GetLocalizatedText(this._string));
	}

	// Token: 0x06006A59 RID: 27225 RVA: 0x0020C004 File Offset: 0x0020A204
	private void IFPOBIMHJEK()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.GGHCKMDEIPH));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.GOCDFEABHHB();
	}

	// Token: 0x06006A5A RID: 27226 RVA: 0x0020C044 File Offset: 0x0020A244
	private void FPFMKNFJCGG(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.AHCEFNLDNGG(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "_Offsets" || EAFAMAMDNEG == string.Format("Gameplay/Base", this._string))
		{
		}
	}

	// Token: 0x06006A5B RID: 27227 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool NENJGDNMNIO()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A5C RID: 27228 RVA: 0x0020C0B8 File Offset: 0x0020A2B8
	private void NBBCPAFKLPK()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.DAOJOFAOPEC));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.CBMBHICHMGI();
	}

	// Token: 0x06006A5D RID: 27229 RVA: 0x0020C0F7 File Offset: 0x0020A2F7
	private void CHOPDIGHJNH()
	{
		base.StartCoroutine(this.GNHBLNKLCBG());
	}

	// Token: 0x06006A5E RID: 27230 RVA: 0x0020C106 File Offset: 0x0020A306
	private void PCKABALNDAC()
	{
		this.NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A5F RID: 27231 RVA: 0x0020C120 File Offset: 0x0020A320
	private IEnumerator AFJIAEEHHDJ()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006A60 RID: 27232 RVA: 0x0020C13B File Offset: 0x0020A33B
	private void GNPPHNFEIJG()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.JKMPONNDNDF();
	}

	// Token: 0x06006A61 RID: 27233 RVA: 0x0020C17A File Offset: 0x0020A37A
	private string AHCEFNLDNGG(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("move", Environment.NewLine);
	}

	// Token: 0x06006A62 RID: 27234 RVA: 0x0020C19D File Offset: 0x0020A39D
	private void BBJDNFFDKBN()
	{
		this.PMLLOEGKPGG();
	}

	// Token: 0x06006A63 RID: 27235 RVA: 0x0020B28F File Offset: 0x0020948F
	private string ELHHIIPGOGM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("\\n", Environment.NewLine);
	}

	// Token: 0x06006A64 RID: 27236 RVA: 0x0020C1A5 File Offset: 0x0020A3A5
	private string DFEBNJNDPHO(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Value2", Environment.NewLine);
	}

	// Token: 0x06006A65 RID: 27237 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool JDEFKMGGCOP()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A66 RID: 27238 RVA: 0x0020C1C8 File Offset: 0x0020A3C8
	private void KKFMEHJPPAD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFGBFPOBEBE));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.JAFENCCFFML();
	}

	// Token: 0x06006A67 RID: 27239 RVA: 0x0020C106 File Offset: 0x0020A306
	private void GEAIBNOIDMP()
	{
		this.NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A68 RID: 27240 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool ICFFHKAPJGP()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A69 RID: 27241 RVA: 0x0020C207 File Offset: 0x0020A407
	private void FHANAANLEGL()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.ECHCAAJIOFB));
	}

	// Token: 0x06006A6A RID: 27242 RVA: 0x0020C22F File Offset: 0x0020A42F
	private void FIMBCPOBFFA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.CBMBHICHMGI));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.CIJHMEKMMNL();
	}

	// Token: 0x06006A6B RID: 27243 RVA: 0x0020C26E File Offset: 0x0020A46E
	private void CCLDIMFBONJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.CBMBHICHMGI));
	}

	// Token: 0x06006A6C RID: 27244 RVA: 0x0020C296 File Offset: 0x0020A496
	private string CDCMECNNCAG(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("setAF", Environment.NewLine);
	}

	// Token: 0x06006A6D RID: 27245 RVA: 0x0020C2B9 File Offset: 0x0020A4B9
	private void KHBLMEGPPLJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.MINBMBHOGFD));
	}

	// Token: 0x06006A6E RID: 27246 RVA: 0x0020C2E4 File Offset: 0x0020A4E4
	private void HOOPHJCBJAN(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.COMHNBJCPHM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "_TimeX" || EAFAMAMDNEG == string.Format("_ColorR", this._string))
		{
		}
	}

	// Token: 0x06006A6F RID: 27247 RVA: 0x0020C358 File Offset: 0x0020A558
	private void JDCBHJOLOCJ(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.IHOAIDIJPNA(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "Object ID. Case-Sensitive" || EAFAMAMDNEG == string.Format("ns", this._string))
		{
		}
	}

	// Token: 0x06006A70 RID: 27248 RVA: 0x0020C3CC File Offset: 0x0020A5CC
	private string LEKLFDIODEK(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("settings.gamemessagesduration", Environment.NewLine);
	}

	// Token: 0x06006A71 RID: 27249 RVA: 0x0020C3EF File Offset: 0x0020A5EF
	private void GIAIENDLHPO()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.JKMPONNDNDF));
	}

	// Token: 0x06006A72 RID: 27250 RVA: 0x0020BF73 File Offset: 0x0020A173
	private void IKNJFKIBCMG()
	{
		this.CBEDHJJKLFF(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A73 RID: 27251 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool MIKMFCFCHPP()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A74 RID: 27252 RVA: 0x0020C417 File Offset: 0x0020A617
	private void DAOJOFAOPEC()
	{
		this.PCKABALNDAC();
	}

	// Token: 0x06006A75 RID: 27253 RVA: 0x0020BFDD File Offset: 0x0020A1DD
	private void GLEJGFLCLPJ()
	{
		base.StartCoroutine(this.OGJGNCKCLAE());
	}

	// Token: 0x06006A76 RID: 27254 RVA: 0x0020C41F File Offset: 0x0020A61F
	private void HECGJGAEOID()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
	}

	// Token: 0x06006A77 RID: 27255 RVA: 0x0020C3EF File Offset: 0x0020A5EF
	private void OJIHBHNJFBB()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.JKMPONNDNDF));
	}

	// Token: 0x06006A78 RID: 27256 RVA: 0x0020C447 File Offset: 0x0020A647
	private string LFBMPDPAOFH(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_ScreenResolution", Environment.NewLine);
	}

	// Token: 0x06006A79 RID: 27257 RVA: 0x0020C46A File Offset: 0x0020A66A
	private void BPNDDNKKFDD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.GGHCKMDEIPH));
	}

	// Token: 0x06006A7A RID: 27258 RVA: 0x0020C492 File Offset: 0x0020A692
	private void JKBMKPDGCHG()
	{
		base.StartCoroutine(this.FNEIHKJEPBD());
	}

	// Token: 0x06006A7B RID: 27259 RVA: 0x0020C4A1 File Offset: 0x0020A6A1
	private void JIBIMBGEBAP()
	{
		this.BMDOMKKNHAA(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A7C RID: 27260 RVA: 0x0020C4BC File Offset: 0x0020A6BC
	private IEnumerator POCPKICJPFE()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006A7D RID: 27261 RVA: 0x0020C4D7 File Offset: 0x0020A6D7
	private void LDLPCEKMKOA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.ECHCAAJIOFB));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.GGHCKMDEIPH();
	}

	// Token: 0x06006A7E RID: 27262 RVA: 0x0020C518 File Offset: 0x0020A718
	private void NILPHJIMCOJ(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.NKFDJOKNHKM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "#mapby" || EAFAMAMDNEG == string.Format(".icon", this._string))
		{
		}
	}

	// Token: 0x06006A7F RID: 27263 RVA: 0x0020C58C File Offset: 0x0020A78C
	private IEnumerator GNHBLNKLCBG()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006A80 RID: 27264 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool ANFOPKCKCBL()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A81 RID: 27265 RVA: 0x0020C5A8 File Offset: 0x0020A7A8
	private void LGAJFNNKGGL(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.DEBMGGDPDIE(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "Despawn environment object by id" || EAFAMAMDNEG == string.Format("Brightness", this._string))
		{
		}
	}

	// Token: 0x06006A82 RID: 27266 RVA: 0x0020C106 File Offset: 0x0020A306
	private void AIFOJKKGPAE()
	{
		this.NILPHJIMCOJ(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A83 RID: 27267 RVA: 0x0020C61C File Offset: 0x0020A81C
	private void GJJKCBMHBKF(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.IHOAIDIJPNA(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "#close" || EAFAMAMDNEG == string.Format("[PlayerController] ", this._string))
		{
		}
	}

	// Token: 0x06006A84 RID: 27268 RVA: 0x0020C690 File Offset: 0x0020A890
	private string LHALNEMEPJK(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Skybox", Environment.NewLine);
	}

	// Token: 0x06006A85 RID: 27269 RVA: 0x0020C6B3 File Offset: 0x0020A8B3
	private void PMLLOEGKPGG()
	{
		this.DFHLFHPPPOD(LocalizationService.Instance.GetLocalizatedText(this._string));
	}

	// Token: 0x06006A86 RID: 27270 RVA: 0x0020C6CB File Offset: 0x0020A8CB
	private void EGIBNPNGOIK()
	{
		this.GHJJDAJIOPM(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A87 RID: 27271 RVA: 0x0020C6E3 File Offset: 0x0020A8E3
	private void HAIAHJPCPAG()
	{
		base.StartCoroutine(this.POCPKICJPFE());
	}

	// Token: 0x06006A88 RID: 27272 RVA: 0x0020C6E3 File Offset: 0x0020A8E3
	private void Start()
	{
		base.StartCoroutine(this.POCPKICJPFE());
	}

	// Token: 0x06006A89 RID: 27273 RVA: 0x0020C6F4 File Offset: 0x0020A8F4
	private void NMILFNBCAMH(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.DBKPOMBOILM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "_BlurParams" || EAFAMAMDNEG == string.Format("Items/", this._string))
		{
		}
	}

	// Token: 0x06006A8A RID: 27274 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool BMAHPFENAHP()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A8B RID: 27275 RVA: 0x0020C768 File Offset: 0x0020A968
	private string JLOIEAKHCNO(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace(" or player:", Environment.NewLine);
	}

	// Token: 0x06006A8C RID: 27276 RVA: 0x0020C78B File Offset: 0x0020A98B
	private void AAPKEGAJABJ()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.AACHLFMEPIA));
	}

	// Token: 0x06006A8D RID: 27277 RVA: 0x0020C7B3 File Offset: 0x0020A9B3
	private string DLAMDOADKLD(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("intensity", Environment.NewLine);
	}

	// Token: 0x06006A8E RID: 27278 RVA: 0x0020C7D6 File Offset: 0x0020A9D6
	private void MINBMBHOGFD()
	{
		this.BJEKNHKJHPD();
	}

	// Token: 0x06006A8F RID: 27279 RVA: 0x0020C7DE File Offset: 0x0020A9DE
	private void NNFMIAFHMJM()
	{
		base.StartCoroutine(this.AOHNELGHACA());
	}

	// Token: 0x06006A90 RID: 27280 RVA: 0x0020C7F0 File Offset: 0x0020A9F0
	private IEnumerator CCOHFBLMOJK()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006A91 RID: 27281 RVA: 0x0020C417 File Offset: 0x0020A617
	private void JKMPONNDNDF()
	{
		this.PCKABALNDAC();
	}

	// Token: 0x06006A92 RID: 27282 RVA: 0x0020AFAB File Offset: 0x002091AB
	private string DBKPOMBOILM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_TimeX", Environment.NewLine);
	}

	// Token: 0x06006A93 RID: 27283 RVA: 0x0020C80B File Offset: 0x0020AA0B
	private void DJOOKCAPEHA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.MINBMBHOGFD));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.CIJHMEKMMNL();
	}

	// Token: 0x06006A94 RID: 27284 RVA: 0x0020C84A File Offset: 0x0020AA4A
	private void CPDIKGMOAMF()
	{
		this.DFHLFHPPPOD(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006A95 RID: 27285 RVA: 0x0020C862 File Offset: 0x0020AA62
	private void EHMGKLLKINB()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.BBJDNFFDKBN));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.DAOJOFAOPEC();
	}

	// Token: 0x06006A96 RID: 27286 RVA: 0x0020C8A1 File Offset: 0x0020AAA1
	private void IFJGGEAMFON()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.AACHLFMEPIA));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.CBMBHICHMGI();
	}

	// Token: 0x06006A97 RID: 27287 RVA: 0x0020C8E0 File Offset: 0x0020AAE0
	private void JAKIEPHKMMG(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.COMHNBJCPHM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "_TimeX" || EAFAMAMDNEG == string.Format("_FixDistance", this._string))
		{
		}
	}

	// Token: 0x06006A98 RID: 27288 RVA: 0x0020C417 File Offset: 0x0020A617
	private void JAFENCCFFML()
	{
		this.PCKABALNDAC();
	}

	// Token: 0x06006A99 RID: 27289 RVA: 0x0020C954 File Offset: 0x0020AB54
	private void GHJJDAJIOPM(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.ELHHIIPGOGM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "[EMPTY]" || EAFAMAMDNEG == string.Format("[ERROR KEY {0}]", this._string))
		{
		}
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool OGDDBFIGOJE()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006A9B RID: 27291 RVA: 0x0020C41F File Offset: 0x0020A61F
	private void MLAKNIGKOHO()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
	}

	// Token: 0x06006A9C RID: 27292 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
	private void KFDFBMFKHDA()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.GOCDFEABHHB));
	}

	// Token: 0x06006A9D RID: 27293 RVA: 0x0020C9F0 File Offset: 0x0020ABF0
	private void CAPPPBJAEEE(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.CDCMECNNCAG(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "CameraFilterPack_TV_Arcade1" || EAFAMAMDNEG == string.Format("checkpoint", this._string))
		{
		}
	}

	// Token: 0x06006A9E RID: 27294 RVA: 0x0020C7DE File Offset: 0x0020A9DE
	private void LFAFJKJAEEL()
	{
		base.StartCoroutine(this.AOHNELGHACA());
	}

	// Token: 0x06006A9F RID: 27295 RVA: 0x0020CA64 File Offset: 0x0020AC64
	private void CBEDHJJKLFF(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.JLOIEAKHCNO(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "_Saturation" || EAFAMAMDNEG == string.Format("[Up]", this._string))
		{
		}
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x0020CAD8 File Offset: 0x0020ACD8
	private IEnumerator LKAGNCOCHEI()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AA1 RID: 27297 RVA: 0x0020BF8B File Offset: 0x0020A18B
	private void CIJHMEKMMNL()
	{
		this.MNHCBCCOOMJ();
	}

	// Token: 0x06006AA2 RID: 27298 RVA: 0x0020CAF4 File Offset: 0x0020ACF4
	private IEnumerator KILFEEMMFKJ()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AA3 RID: 27299 RVA: 0x0020CB10 File Offset: 0x0020AD10
	private IEnumerator FHGJNKHGPGC()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AA4 RID: 27300 RVA: 0x0020CB2C File Offset: 0x0020AD2C
	private IEnumerator OGJGNCKCLAE()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AA5 RID: 27301 RVA: 0x0020C417 File Offset: 0x0020A617
	private void AACHLFMEPIA()
	{
		this.PCKABALNDAC();
	}

	// Token: 0x06006AA6 RID: 27302 RVA: 0x0020C9C8 File Offset: 0x0020ABC8
	private void FJGNDJGLBEN()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.GOCDFEABHHB));
	}

	// Token: 0x06006AA7 RID: 27303 RVA: 0x0020C0F7 File Offset: 0x0020A2F7
	private void AKHCOBHHGJP()
	{
		base.StartCoroutine(this.GNHBLNKLCBG());
	}

	// Token: 0x06006AA8 RID: 27304 RVA: 0x0020CB47 File Offset: 0x0020AD47
	private void ELJLABPNDOE()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.NFGBFPOBEBE));
	}

	// Token: 0x06006AA9 RID: 27305 RVA: 0x0020CB6F File Offset: 0x0020AD6F
	private void ECHCAAJIOFB()
	{
		this.AIFOJKKGPAE();
	}

	// Token: 0x06006AAA RID: 27306 RVA: 0x0020CB77 File Offset: 0x0020AD77
	private void CBMBHICHMGI()
	{
		this.NEEPEGIEHPF();
	}

	// Token: 0x06006AAB RID: 27307 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool CJDAEBMOAJK()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006AAC RID: 27308 RVA: 0x0020CB7F File Offset: 0x0020AD7F
	private void CHCKAEFABJA()
	{
		this.HLFHPKHKEFD(LocalizationService.Instance.HOPMEAJKPHL(this._string));
	}

	// Token: 0x06006AAD RID: 27309 RVA: 0x0020CB98 File Offset: 0x0020AD98
	private void DFHLFHPPPOD(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.NKFDJOKNHKM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "{0:0} day{1}, " || EAFAMAMDNEG == string.Format("_PColor", this._string))
		{
		}
	}

	// Token: 0x06006AAE RID: 27310 RVA: 0x0020CC0C File Offset: 0x0020AE0C
	private void CHDGEHMPCMH()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.BBJDNFFDKBN));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.JKMPONNDNDF();
	}

	// Token: 0x06006AAF RID: 27311 RVA: 0x0020CC4B File Offset: 0x0020AE4B
	private void DDEKPGECKCD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.NFADGEDMNMF();
	}

	// Token: 0x06006AB0 RID: 27312 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool DGCKNEBDDBB()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006AB1 RID: 27313 RVA: 0x0020CC8A File Offset: 0x0020AE8A
	private string PEEMCNMCGBP(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("DPADHOR", Environment.NewLine);
	}

	// Token: 0x06006AB2 RID: 27314 RVA: 0x0020C1A5 File Offset: 0x0020A3A5
	private string COMHNBJCPHM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_Value2", Environment.NewLine);
	}

	// Token: 0x06006AB3 RID: 27315 RVA: 0x0020CCAD File Offset: 0x0020AEAD
	private void CIEPPCBBLIF()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.GGHCKMDEIPH));
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		this.CBMBHICHMGI();
	}

	// Token: 0x06006AB4 RID: 27316 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool EGHOAOGAHMA()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006AB5 RID: 27317 RVA: 0x0020CCEC File Offset: 0x0020AEEC
	private string HHHPAKCIMPA(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("{0} minutes ago", Environment.NewLine);
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x0020C492 File Offset: 0x0020A692
	private void JKFDDNMPOJH()
	{
		base.StartCoroutine(this.FNEIHKJEPBD());
	}

	// Token: 0x06006AB7 RID: 27319 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool AFILHMMDKAD()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006AB8 RID: 27320 RVA: 0x0020C41F File Offset: 0x0020A61F
	private void OnDestroy()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
	}

	// Token: 0x06006AB9 RID: 27321 RVA: 0x0020C492 File Offset: 0x0020A692
	private void AEDDNDHCLNN()
	{
		base.StartCoroutine(this.FNEIHKJEPBD());
	}

	// Token: 0x06006ABA RID: 27322 RVA: 0x0020C26E File Offset: 0x0020A46E
	private void JCHLGFDAAGC()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.CBMBHICHMGI));
	}

	// Token: 0x06006ABB RID: 27323 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool MFMEDAFHAAO()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006ABC RID: 27324 RVA: 0x0020C447 File Offset: 0x0020A647
	private string NKFDJOKNHKM(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("_ScreenResolution", Environment.NewLine);
	}

	// Token: 0x06006ABD RID: 27325 RVA: 0x0020C3EF File Offset: 0x0020A5EF
	private void JJJABCLKCOD()
	{
		LocalizationService instance = LocalizationService.Instance;
		instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.JKMPONNDNDF));
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool IsHasOutputHelper()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006ABF RID: 27327 RVA: 0x0020C6B3 File Offset: 0x0020A8B3
	private void OLPCDNOICOM()
	{
		this.DFHLFHPPPOD(LocalizationService.Instance.GetLocalizatedText(this._string));
	}

	// Token: 0x06006AC0 RID: 27328 RVA: 0x0020BF9B File Offset: 0x0020A19B
	public bool KPOPMDOINLB()
	{
		this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
		return this.OCAMCGEINLB != null;
	}

	// Token: 0x06006AC1 RID: 27329 RVA: 0x0020CD10 File Offset: 0x0020AF10
	private void BMDOMKKNHAA(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.NKFDJOKNHKM(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "MusicFileSelector" || EAFAMAMDNEG == string.Format("_Value", this._string))
		{
		}
	}

	// Token: 0x06006AC2 RID: 27330 RVA: 0x0020CD84 File Offset: 0x0020AF84
	private void GGHCKMDEIPH()
	{
		this.CPDIKGMOAMF();
	}

	// Token: 0x06006AC3 RID: 27331 RVA: 0x0020BFDD File Offset: 0x0020A1DD
	private void LGHCJCFHEMF()
	{
		base.StartCoroutine(this.OGJGNCKCLAE());
	}

	// Token: 0x06006AC4 RID: 27332 RVA: 0x0020CD8C File Offset: 0x0020AF8C
	private IEnumerator FNEIHKJEPBD()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AC6 RID: 27334 RVA: 0x0020CDB6 File Offset: 0x0020AFB6
	private string DEBMGGDPDIE(string EAFAMAMDNEG)
	{
		if (string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			return string.Empty;
		}
		return EAFAMAMDNEG.Replace("Protocol switch from: ", Environment.NewLine);
	}

	// Token: 0x06006AC7 RID: 27335 RVA: 0x0020CDD9 File Offset: 0x0020AFD9
	private void BJEKNHKJHPD()
	{
		this.BMDOMKKNHAA(LocalizationService.Instance.GetLocalizatedText(this._string));
	}

	// Token: 0x06006AC8 RID: 27336 RVA: 0x0020CDF4 File Offset: 0x0020AFF4
	private IEnumerator IJEFOOHFHJD()
	{
		if (UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME == null)
		{
			UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME = new Func<bool>(UISmartLocalization.LJCOEAFBBAG.GBKBDKHPLKG);
		}
		yield return new WaitWhile(UISmartLocalization.LJCOEAFBBAG.LNIJKGECNME);
		this.DDEKPGECKCD();
		yield break;
	}

	// Token: 0x06006AC9 RID: 27337 RVA: 0x0020CB6F File Offset: 0x0020AD6F
	private void NFGBFPOBEBE()
	{
		this.AIFOJKKGPAE();
	}

	// Token: 0x06006ACA RID: 27338 RVA: 0x0020CE10 File Offset: 0x0020B010
	private void HLFHPKHKEFD(string EAFAMAMDNEG)
	{
		EAFAMAMDNEG = this.LFBMPDPAOFH(EAFAMAMDNEG);
		if (this.OCAMCGEINLB != null)
		{
			this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
		}
		if (EAFAMAMDNEG == "curScn" || EAFAMAMDNEG == string.Format("1159514800", this._string))
		{
		}
	}

	// Token: 0x04000AF5 RID: 2805
	public bool useCaps = true;

	// Token: 0x04000AF6 RID: 2806
	public string _string;

	// Token: 0x04000AF7 RID: 2807
	private Text OCAMCGEINLB;
}
