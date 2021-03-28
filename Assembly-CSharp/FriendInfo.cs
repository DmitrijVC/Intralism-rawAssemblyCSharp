using System;

// Token: 0x020002E3 RID: 739
public class FriendInfo
{
	// Token: 0x0600AC9B RID: 44187 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void KLPLAIJKLNB(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AC9C RID: 44188 RVA: 0x003FB742 File Offset: 0x003F9942
	public string MHDLJEPHOOL()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AC9D RID: 44189 RVA: 0x003FB74A File Offset: 0x003F994A
	public bool HJMLMCJAKEP()
	{
		return this.MNDELAHCIGH() && string.IsNullOrEmpty(this.LNLMOFBNFIA());
	}

	// Token: 0x0600AC9E RID: 44190 RVA: 0x003FB768 File Offset: 0x003F9968
	public bool LKJGINOADCF()
	{
		return this.BBOLFNOHFAP() && !string.IsNullOrEmpty(this.CBHCBPMMMBI());
	}

	// Token: 0x0600AC9F RID: 44191 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void CGPMMFBGOBE(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x003FB742 File Offset: 0x003F9942
	// (set) Token: 0x0600ACC7 RID: 44231 RVA: 0x003FB739 File Offset: 0x003F9939
	public string Name { get; protected internal set; }

	// Token: 0x0600ACA1 RID: 44193 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool IGBNPLMMJBK()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACA2 RID: 44194 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void GGLBIDDJICH(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACA3 RID: 44195 RVA: 0x003FB797 File Offset: 0x003F9997
	public string CBHCBPMMMBI()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACA4 RID: 44196 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool FMIICCKLBIP()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACA5 RID: 44197 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool BBOLFNOHFAP()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACA6 RID: 44198 RVA: 0x003FB79F File Offset: 0x003F999F
	public bool BNGMAPFJBFC()
	{
		return this.FMIICCKLBIP() && !string.IsNullOrEmpty(this.ONDHOBHEKKL());
	}

	// Token: 0x0600ACA7 RID: 44199 RVA: 0x003FB797 File Offset: 0x003F9997
	public string BPDEKAPOFDK()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACA8 RID: 44200 RVA: 0x003FB742 File Offset: 0x003F9942
	public string FOFOBAEFFIG()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACA9 RID: 44201 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void HABFAIANBJL(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACAA RID: 44202 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool HIKEJGFCHJL()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACAB RID: 44203 RVA: 0x003FB7BD File Offset: 0x003F99BD
	public bool EPLPKMONKGJ()
	{
		return this.HIKEJGFCHJL() && string.IsNullOrEmpty(this.IFJIMKLBOAG());
	}

	// Token: 0x0600ACAC RID: 44204 RVA: 0x003FB7DC File Offset: 0x003F99DC
	public virtual string OFMLJFEGKLC()
	{
		return string.Format("SetEnvSpriteColor", this.MHDLJEPHOOL(), this.MNDELAHCIGH() ? ((!this.FFAABKOKFJO()) ? "_Lift" : ".g") : "maps.");
	}

	// Token: 0x0600ACAD RID: 44205 RVA: 0x003FB742 File Offset: 0x003F9942
	public string MFGMEDGLCLD()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACAE RID: 44206 RVA: 0x003FB797 File Offset: 0x003F9997
	public string MPCBDPHHBAL()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACAF RID: 44207 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void GFEAJNPMNJA(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x003FB828 File Offset: 0x003F9A28
	public bool IsInRoom
	{
		get
		{
			return this.IsOnline && !string.IsNullOrEmpty(this.Room);
		}
	}

	// Token: 0x0600ACB1 RID: 44209 RVA: 0x003FB846 File Offset: 0x003F9A46
	public bool GHOLCAKLLIG()
	{
		return this.IIJLBFGNIHF() && !string.IsNullOrEmpty(this.IHHIHGAFMEM());
	}

	// Token: 0x0600ACB2 RID: 44210 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool IIJLBFGNIHF()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACB3 RID: 44211 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void NLLCKMKLBAL(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACB4 RID: 44212 RVA: 0x003FB870 File Offset: 0x003F9A70
	public virtual string CJPIOOPNMKH()
	{
		return string.Format("RespawnAfter", this.AAGICNEELCN(), this.MHCLAKPPPNN() ? ((!this.HKCIMEMKEBA()) ? "colorB" : "_TimeX") : "_MainTex2");
	}

	// Token: 0x0600ACB5 RID: 44213 RVA: 0x003FB797 File Offset: 0x003F9997
	public string AAMFLNGHIFB()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACB6 RID: 44214 RVA: 0x003FB742 File Offset: 0x003F9942
	public string AAGICNEELCN()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACB7 RID: 44215 RVA: 0x003FB8BC File Offset: 0x003F9ABC
	public virtual string BFDPAGJIDAO()
	{
		return string.Format("/", this.HDODGKECAFP(), this.HIKEJGFCHJL() ? ((!this.EPLPKMONKGJ()) ? "_Value2" : "Sent count: ") : "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
	}

	// Token: 0x0600ACB8 RID: 44216 RVA: 0x003FB908 File Offset: 0x003F9B08
	public bool CHMILCJMFOL()
	{
		return this.FLPGFCBEDLH() && !string.IsNullOrEmpty(this.AAMFLNGHIFB());
	}

	// Token: 0x0600ACB9 RID: 44217 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void CCIDBNKIAJF(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACBA RID: 44218 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void NCCPFOFOPEE(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACBB RID: 44219 RVA: 0x003FB926 File Offset: 0x003F9B26
	public bool CEJKCGBBDCP()
	{
		return this.IIJLBFGNIHF() && string.IsNullOrEmpty(this.CBHCBPMMMBI());
	}

	// Token: 0x0600ACBC RID: 44220 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void EMIMPGPBDDD(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACBD RID: 44221 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void CFKIAACIFDJ(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACBE RID: 44222 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void OFDFHAICIFB(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACBF RID: 44223 RVA: 0x003FB944 File Offset: 0x003F9B44
	public bool CNEEKEGNHIK()
	{
		return !this.JNAJFMACOGJ() || !string.IsNullOrEmpty(this.BLKGKPNDBDL());
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x003FB797 File Offset: 0x003F9997
	// (set) Token: 0x0600ACC0 RID: 44224 RVA: 0x003FB864 File Offset: 0x003F9A64
	public string Room { get; protected internal set; }

	// Token: 0x0600ACC1 RID: 44225 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void KEACDHPPPPE(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACC2 RID: 44226 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void CDANICGAPNK(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACC3 RID: 44227 RVA: 0x003FB797 File Offset: 0x003F9997
	public string FBDJDJOIPKE()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACC4 RID: 44228 RVA: 0x003FB964 File Offset: 0x003F9B64
	public virtual string NDHGLMMFIAP()
	{
		return string.Format("_AdaptTex", this.HDODGKECAFP(), this.BBOLFNOHFAP() ? ((!this.HOADIDIPPOB()) ? "_ScreenResolution" : "Updated!") : "_Value5");
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x0600ACC5 RID: 44229 RVA: 0x003FB78F File Offset: 0x003F998F
	// (set) Token: 0x0600AD07 RID: 44295 RVA: 0x003FB786 File Offset: 0x003F9986
	public bool IsOnline { get; protected internal set; }

	// Token: 0x0600ACC6 RID: 44230 RVA: 0x003FB797 File Offset: 0x003F9997
	public string LNLMOFBNFIA()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACC8 RID: 44232 RVA: 0x003FB797 File Offset: 0x003F9997
	public string BLKGKPNDBDL()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACC9 RID: 44233 RVA: 0x003FB9B0 File Offset: 0x003F9BB0
	public bool HOADIDIPPOB()
	{
		return this.BBOLFNOHFAP() && string.IsNullOrEmpty(this.IFJIMKLBOAG());
	}

	// Token: 0x0600ACCA RID: 44234 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void PCGCFHPAMMB(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACCB RID: 44235 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void LABJBMDKMDK(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACCC RID: 44236 RVA: 0x003FB742 File Offset: 0x003F9942
	public string KKLNEKKBBAA()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACCD RID: 44237 RVA: 0x003FB742 File Offset: 0x003F9942
	public string HFIJAGMJNBE()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACCE RID: 44238 RVA: 0x003FB9CE File Offset: 0x003F9BCE
	public bool BPAAKHAPFGH()
	{
		return this.IGBNPLMMJBK() && !string.IsNullOrEmpty(this.LNLMOFBNFIA());
	}

	// Token: 0x0600ACCF RID: 44239 RVA: 0x003FB9EC File Offset: 0x003F9BEC
	public bool OMGKFHPNLMO()
	{
		return !this.LGCMNEAHJMM() || !string.IsNullOrEmpty(this.BLKGKPNDBDL());
	}

	// Token: 0x0600ACD0 RID: 44240 RVA: 0x003FBA0A File Offset: 0x003F9C0A
	public bool HJDLDJFCMFO()
	{
		return this.MNDELAHCIGH() && !string.IsNullOrEmpty(this.AAMFLNGHIFB());
	}

	// Token: 0x0600ACD1 RID: 44241 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void NJINEDKMNPH(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACD2 RID: 44242 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void COEMMKKDIEN(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACD3 RID: 44243 RVA: 0x003FBA28 File Offset: 0x003F9C28
	public bool KECAJOHNIKB()
	{
		return this.IIJLBFGNIHF() && string.IsNullOrEmpty(this.BPDEKAPOFDK());
	}

	// Token: 0x0600ACD4 RID: 44244 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool GFDHPLPDCEM()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACD5 RID: 44245 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void IIHHKNAEJHE(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACD6 RID: 44246 RVA: 0x003FB742 File Offset: 0x003F9942
	public string KGOMDCOINGP()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACD7 RID: 44247 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void LOAHALDAADO(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACD8 RID: 44248 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool PNFELKDNFML()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACD9 RID: 44249 RVA: 0x003FBA48 File Offset: 0x003F9C48
	public virtual string ENEOGOGJDBP()
	{
		return string.Format("mainmenu", this.Name, this.JNAJFMACOGJ() ? ((!this.BPAAKHAPFGH()) ? "Localization Servise\nWorking commands:\nset <language>\nlist\nkeys" : " cannot be used as a 3D LUT.") : "x");
	}

	// Token: 0x0600ACDB RID: 44251 RVA: 0x003FBA94 File Offset: 0x003F9C94
	public bool BCOOLCHCODM()
	{
		return !this.IIJLBFGNIHF() || !string.IsNullOrEmpty(this.MPCBDPHHBAL());
	}

	// Token: 0x0600ACDC RID: 44252 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void INMNDCDFIKB(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACDD RID: 44253 RVA: 0x003FBAB4 File Offset: 0x003F9CB4
	public virtual string EGCPPOHMLNK()
	{
		return string.Format("_ExtraLight", this.Name, this.JNAJFMACOGJ() ? ((!this.BNGMAPFJBFC()) ? "SetEnvSpriteColor" : "_ScreenResolution") : "_TimeX");
	}

	// Token: 0x0600ACDE RID: 44254 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void NBHGPKNCHCN(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACDF RID: 44255 RVA: 0x003FBB00 File Offset: 0x003F9D00
	public bool LBKFLGNCBIL()
	{
		return this.BBOLFNOHFAP() && !string.IsNullOrEmpty(this.MPCBDPHHBAL());
	}

	// Token: 0x0600ACE0 RID: 44256 RVA: 0x003FBB1E File Offset: 0x003F9D1E
	public bool OCGCGKIIJMP()
	{
		return this.MHCLAKPPPNN() && string.IsNullOrEmpty(this.LOIKJBGAELP());
	}

	// Token: 0x0600ACE1 RID: 44257 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void HOCMHFJFGBI(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACE2 RID: 44258 RVA: 0x003FB742 File Offset: 0x003F9942
	public string CANLMKJEKNK()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACE3 RID: 44259 RVA: 0x003FBB3C File Offset: 0x003F9D3C
	public virtual string INLHLHDMHNK()
	{
		return string.Format("maps.", this.FOFOBAEFFIG(), this.BBOLFNOHFAP() ? ((!this.BPAAKHAPFGH()) ? "[MenuScene] Error: " : "[LevelEditorScene] Map submitted!") : ".lastCheckpoint.powerupsScore");
	}

	// Token: 0x0600ACE4 RID: 44260 RVA: 0x003FBB88 File Offset: 0x003F9D88
	public bool MNIIJJPKEJI()
	{
		return !this.PNFELKDNFML() || !string.IsNullOrEmpty(this.LOIKJBGAELP());
	}

	// Token: 0x0600ACE5 RID: 44261 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void FGMJDNNLIOP(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACE6 RID: 44262 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void GNMHPHAKMHL(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACE7 RID: 44263 RVA: 0x003FBBA8 File Offset: 0x003F9DA8
	public virtual string CFBMAFAHNAH()
	{
		return string.Format("BestScoreText", this.KKLNEKKBBAA(), this.IIJLBFGNIHF() ? ((!this.HJMLMCJAKEP()) ? "DPADHOR" : "_BlurRadius4") : "value");
	}

	// Token: 0x0600ACE8 RID: 44264 RVA: 0x003FBBF4 File Offset: 0x003F9DF4
	public virtual string DHPDGMDACIO()
	{
		return string.Format("_BokehParams", this.KKLNEKKBBAA(), this.GFDHPLPDCEM() ? ((!this.LBKFLGNCBIL()) ? "_Value3" : ".lastCheckpoint.penaltyScore") : "id");
	}

	// Token: 0x0600ACE9 RID: 44265 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void PPMAEACLMJD(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACEA RID: 44266 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void NDOMFJBIAIP(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACEB RID: 44267 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool HICNFMKCIAE()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACEC RID: 44268 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool MNDELAHCIGH()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600ACED RID: 44269 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void HMOPLPINOEE(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACEE RID: 44270 RVA: 0x003FB797 File Offset: 0x003F9997
	public string IFJIMKLBOAG()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACEF RID: 44271 RVA: 0x003FB742 File Offset: 0x003F9942
	public string KBGIGDNIHFN()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACF0 RID: 44272 RVA: 0x003FBC40 File Offset: 0x003F9E40
	public virtual string AJLLINNGAHF()
	{
		return string.Format("masterSteamID", this.KGOMDCOINGP(), this.BBOLFNOHFAP() ? ((!this.BCOOLCHCODM()) ? "InventoryButton" : "mapselector.filter.rateduponly") : "CameraFilterPack/AAA_Blood");
	}

	// Token: 0x0600ACF1 RID: 44273 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void OEIIPLGFFPJ(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACF2 RID: 44274 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void EDFLKGFHKAL(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACF3 RID: 44275 RVA: 0x003FBC8C File Offset: 0x003F9E8C
	public virtual string PBOFHGKLJEJ()
	{
		return string.Format("itemdefid[0]", this.MHDLJEPHOOL(), this.EGCDPLGNMPD() ? ((!this.HOADIDIPPOB()) ? "settings.enableranking" : "#tryagain") : "SetSpeed");
	}

	// Token: 0x0600ACF4 RID: 44276 RVA: 0x003FB742 File Offset: 0x003F9942
	public string CGPHGEJJENL()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600ACF5 RID: 44277 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void AGBOIEJCFGO(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACF6 RID: 44278 RVA: 0x003FBCD8 File Offset: 0x003F9ED8
	public bool LJDEAFJCJDA()
	{
		return !this.EGCDPLGNMPD() || string.IsNullOrEmpty(this.CBHCBPMMMBI());
	}

	// Token: 0x0600ACF7 RID: 44279 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void IDDALFMFGAP(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACF8 RID: 44280 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void KNBBLDFCAKN(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACF9 RID: 44281 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void BHFPBHEJJFE(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACFA RID: 44282 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void ODGFKLJGCMO(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACFC RID: 44284 RVA: 0x003FB797 File Offset: 0x003F9997
	public string GLHFIJLHEFI()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600ACFD RID: 44285 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void NEBIPAIDEPL(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACFE RID: 44286 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void CJFPOLDHDBA(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600ACFF RID: 44287 RVA: 0x003FBCF6 File Offset: 0x003F9EF6
	public bool FFAABKOKFJO()
	{
		return !this.BBOLFNOHFAP() || string.IsNullOrEmpty(this.FBDJDJOIPKE());
	}

	// Token: 0x0600AD00 RID: 44288 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool EHKPPILFGEP()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD01 RID: 44289 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void JEAEIEJGEEG(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD02 RID: 44290 RVA: 0x003FBD14 File Offset: 0x003F9F14
	public override string ToString()
	{
		return string.Format("{0}\t is: {1}", this.Name, this.IsOnline ? ((!this.IsInRoom) ? "on master" : "playing") : "offline");
	}

	// Token: 0x0600AD03 RID: 44291 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void KFPLAFMHHGG(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD04 RID: 44292 RVA: 0x003FBD60 File Offset: 0x003F9F60
	public bool KCLEJMKKLMC()
	{
		return this.JNAJFMACOGJ() && !string.IsNullOrEmpty(this.ONDHOBHEKKL());
	}

	// Token: 0x0600AD05 RID: 44293 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void GDELAAGINMC(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD06 RID: 44294 RVA: 0x003FBD7E File Offset: 0x003F9F7E
	public bool MJDLOIIDJCN()
	{
		return !this.IIJLBFGNIHF() || !string.IsNullOrEmpty(this.LOIKJBGAELP());
	}

	// Token: 0x0600AD08 RID: 44296 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool LGCMNEAHJMM()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD09 RID: 44297 RVA: 0x003FBD9C File Offset: 0x003F9F9C
	public virtual string HHGDIJKEPMJ()
	{
		return string.Format("_Value", this.HFIJAGMJNBE(), this.FMIICCKLBIP() ? ((!this.MJDLOIIDJCN()) ? "SpeedSlider" : "_Value5") : "skin.hit_normal");
	}

	// Token: 0x0600AD0A RID: 44298 RVA: 0x003FB742 File Offset: 0x003F9942
	public string HDODGKECAFP()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AD0B RID: 44299 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool EGCDPLGNMPD()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD0C RID: 44300 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void JCGINDGJKDH(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD0D RID: 44301 RVA: 0x003FBDE8 File Offset: 0x003F9FE8
	public virtual string OEOLHIGBECD()
	{
		return string.Format("Set Player Distance", this.KKLNEKKBBAA(), this.FLPGFCBEDLH() ? ((!this.HOMMBNPKAFG()) ? "player.xp" : "Version 1.0") : "InfoButton");
	}

	// Token: 0x0600AD0E RID: 44302 RVA: 0x003FB797 File Offset: 0x003F9997
	public string IHHIHGAFMEM()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600AD0F RID: 44303 RVA: 0x003FBE34 File Offset: 0x003FA034
	public bool ALLPEILHDNE()
	{
		return !this.HIKEJGFCHJL() || string.IsNullOrEmpty(this.Room);
	}

	// Token: 0x0600AD10 RID: 44304 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void IFHEMHGGLAL(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD11 RID: 44305 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void BFPBGMKHDNJ(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD12 RID: 44306 RVA: 0x003FB742 File Offset: 0x003F9942
	public string HGOFHHPIBIH()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AD13 RID: 44307 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void JCMGNNHIMEE(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD14 RID: 44308 RVA: 0x003FB742 File Offset: 0x003F9942
	public string MNDIKKMONCE()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AD15 RID: 44309 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool FLPGFCBEDLH()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD16 RID: 44310 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void NMEGMFJGGGC(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD17 RID: 44311 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void KGMAEIOGAMK(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD18 RID: 44312 RVA: 0x003FBE54 File Offset: 0x003FA054
	public virtual string HCPGNPLIJHH()
	{
		return string.Format("_TimeX", this.KGOMDCOINGP(), this.HICNFMKCIAE() ? ((!this.ALLPEILHDNE()) ? "_DepthLevel" : "[PlayerController] ") : "_SoftZDistance");
	}

	// Token: 0x0600AD19 RID: 44313 RVA: 0x003FBEA0 File Offset: 0x003FA0A0
	public bool HKCIMEMKEBA()
	{
		return !this.MNDELAHCIGH() || !string.IsNullOrEmpty(this.AAMFLNGHIFB());
	}

	// Token: 0x0600AD1A RID: 44314 RVA: 0x003FBEBE File Offset: 0x003FA0BE
	public bool EEMPAPOFHLM()
	{
		return this.FLPGFCBEDLH() && string.IsNullOrEmpty(this.IHHIHGAFMEM());
	}

	// Token: 0x0600AD1B RID: 44315 RVA: 0x003FBEDC File Offset: 0x003FA0DC
	public bool MMMFOAACLIP()
	{
		return !this.FMIICCKLBIP() || !string.IsNullOrEmpty(this.Room);
	}

	// Token: 0x0600AD1C RID: 44316 RVA: 0x003FBEFC File Offset: 0x003FA0FC
	public virtual string CFALDCPGMCA()
	{
		return string.Format(".sawoutdatedmessage", this.HGOFHHPIBIH(), this.IGBNPLMMJBK() ? ((!this.HOADIDIPPOB()) ? "Load Game" : " | Level: ") : "[Up]");
	}

	// Token: 0x0600AD1D RID: 44317 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void OKDKADAABLC(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD1E RID: 44318 RVA: 0x003FB739 File Offset: 0x003F9939
	protected internal void PDKCONLPMAH(string DPNHODJHGJL)
	{
		this.<JACAIPDALBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD1F RID: 44319 RVA: 0x003FBF48 File Offset: 0x003FA148
	public bool KKKCFBPCKOD()
	{
		return this.JNAJFMACOGJ() && string.IsNullOrEmpty(this.LOIKJBGAELP());
	}

	// Token: 0x0600AD20 RID: 44320 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void HJMLAOEOOGC(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD21 RID: 44321 RVA: 0x003FBF66 File Offset: 0x003FA166
	public bool HOMMBNPKAFG()
	{
		return this.EGCDPLGNMPD() && string.IsNullOrEmpty(this.Room);
	}

	// Token: 0x0600AD22 RID: 44322 RVA: 0x003FB797 File Offset: 0x003F9997
	public string IPLIAOGLNEL()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600AD23 RID: 44323 RVA: 0x003FB797 File Offset: 0x003F9997
	public string LOIKJBGAELP()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}

	// Token: 0x0600AD24 RID: 44324 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool MHCLAKPPPNN()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD25 RID: 44325 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void NEOKJGJJMOB(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD26 RID: 44326 RVA: 0x003FB742 File Offset: 0x003F9942
	public string NJMAIKAOLOI()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AD27 RID: 44327 RVA: 0x003FB78F File Offset: 0x003F998F
	public bool JNAJFMACOGJ()
	{
		return this.<CLBHIJDEKKK>k__BackingField;
	}

	// Token: 0x0600AD28 RID: 44328 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void LPHFBDMMCFL(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD29 RID: 44329 RVA: 0x003FBF84 File Offset: 0x003FA184
	public virtual string GKEABMIBAEH()
	{
		return string.Format("</size>", this.HDODGKECAFP(), this.HIKEJGFCHJL() ? ((!this.FFAABKOKFJO()) ? "steamid" : "[Up-Left]") : "_MaxRayTraceDistance");
	}

	// Token: 0x0600AD2A RID: 44330 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void OEFEJBKOOOJ(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD2B RID: 44331 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void IHBCDLLAIDO(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD2C RID: 44332 RVA: 0x003FB864 File Offset: 0x003F9A64
	protected internal void MCINKJKFFHB(string DPNHODJHGJL)
	{
		this.<ONIAGJGNOJH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD2D RID: 44333 RVA: 0x003FBFD0 File Offset: 0x003FA1D0
	public virtual string AJMMDCEJHGN()
	{
		return string.Format("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.IMMMHNAELHH(), this.IsOnline ? ((!this.LJDEAFJCJDA()) ? "[DiscordController] Responding yes to Ask to Join request" : " or ") : "CameraFilterPack/3D_BlackHole");
	}

	// Token: 0x0600AD2E RID: 44334 RVA: 0x003FB786 File Offset: 0x003F9986
	protected internal void MADNADHPJCL(bool DPNHODJHGJL)
	{
		this.<CLBHIJDEKKK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AD2F RID: 44335 RVA: 0x003FB742 File Offset: 0x003F9942
	public string IMMMHNAELHH()
	{
		return this.<JACAIPDALBC>k__BackingField;
	}

	// Token: 0x0600AD30 RID: 44336 RVA: 0x003FB797 File Offset: 0x003F9997
	public string ONDHOBHEKKL()
	{
		return this.<ONIAGJGNOJH>k__BackingField;
	}
}
