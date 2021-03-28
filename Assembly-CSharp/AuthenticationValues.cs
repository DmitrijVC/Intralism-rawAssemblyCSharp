using System;

// Token: 0x020002FC RID: 764
public class AuthenticationValues
{
	// Token: 0x0600AEC2 RID: 44738 RVA: 0x004052C4 File Offset: 0x004034C4
	private void JFDHMIGNFAL(object DPNHODJHGJL)
	{
		this.<KKLGJFDHKIJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x0600AED6 RID: 44758 RVA: 0x004053ED File Offset: 0x004035ED
	// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x004052CD File Offset: 0x004034CD
	public CustomAuthenticationType AuthType
	{
		get
		{
			return this.EJBNALIEBFH;
		}
		set
		{
			this.EJBNALIEBFH = value;
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x0600AEC4 RID: 44740 RVA: 0x004052D6 File Offset: 0x004034D6
	// (set) Token: 0x0600AEDA RID: 44762 RVA: 0x004053E4 File Offset: 0x004035E4
	public string Token { get; set; }

	// Token: 0x0600AEC5 RID: 44741 RVA: 0x004052E0 File Offset: 0x004034E0
	public virtual void AddAuthParameter(string HFEFHOPOLIK, string DPNHODJHGJL)
	{
		string text = (!string.IsNullOrEmpty(this.AuthGetParameters)) ? "&" : string.Empty;
		this.AuthGetParameters = string.Format("{0}{1}{2}={3}", new object[]
		{
			this.AuthGetParameters,
			text,
			Uri.EscapeDataString(HFEFHOPOLIK),
			Uri.EscapeDataString(DPNHODJHGJL)
		});
	}

	// Token: 0x0600AEC6 RID: 44742 RVA: 0x00405342 File Offset: 0x00403542
	public virtual void AFDLFNGEEOF(byte[] HNCGEEOBGGO)
	{
		this.GHEBBKIENKD(HNCGEEOBGGO);
	}

	// Token: 0x0600AEC7 RID: 44743 RVA: 0x0040534B File Offset: 0x0040354B
	public virtual string HNHNKFEAAKA()
	{
		return string.Format("quantity", this.NEPEFCOOEGO(), this.OMCPFLLPIPM(), this.PPFIBJOHICJ() == null);
	}

	// Token: 0x0600AEC8 RID: 44744 RVA: 0x00405374 File Offset: 0x00403574
	public void AJBJIDHDDAB(string DPNHODJHGJL)
	{
		this.<DELIHEHNGKB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEC9 RID: 44745 RVA: 0x0040537D File Offset: 0x0040357D
	public AuthenticationValues()
	{
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x0600AECA RID: 44746 RVA: 0x00405390 File Offset: 0x00403590
	// (set) Token: 0x0600AED2 RID: 44754 RVA: 0x004052C4 File Offset: 0x004034C4
	public object AuthPostData { get; private set; }

	// Token: 0x0600AECB RID: 44747 RVA: 0x00405398 File Offset: 0x00403598
	public virtual string EDFALDILGCL()
	{
		return string.Format("BitsData", this.NEPEFCOOEGO(), this.OMCPFLLPIPM(), this.PPFIBJOHICJ() == null);
	}

	// Token: 0x0600AECC RID: 44748 RVA: 0x004052D6 File Offset: 0x004034D6
	public string IFKGNPNPDDI()
	{
		return this.<FABPAJHAJCG>k__BackingField;
	}

	// Token: 0x0600AECD RID: 44749 RVA: 0x004052C4 File Offset: 0x004034C4
	private void GHEBBKIENKD(object DPNHODJHGJL)
	{
		this.<KKLGJFDHKIJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AECE RID: 44750 RVA: 0x004053C1 File Offset: 0x004035C1
	public virtual void NLFHIBOHFGG(string MGJCBKGCFHA)
	{
		this.AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x004053FD File Offset: 0x004035FD
	// (set) Token: 0x0600AECF RID: 44751 RVA: 0x00405374 File Offset: 0x00403574
	public string UserId { get; set; }

	// Token: 0x0600AED0 RID: 44752 RVA: 0x004053DB File Offset: 0x004035DB
	public void LJDKJPICAEI(string DPNHODJHGJL)
	{
		this.<JBOIDBBKGGI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AED1 RID: 44753 RVA: 0x004052C4 File Offset: 0x004034C4
	private void BMFPDIEKHJA(object DPNHODJHGJL)
	{
		this.<KKLGJFDHKIJ>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AED3 RID: 44755 RVA: 0x004053C1 File Offset: 0x004035C1
	public virtual void MCBJCDIEPME(string MGJCBKGCFHA)
	{
		this.AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	// Token: 0x0600AED4 RID: 44756 RVA: 0x00405374 File Offset: 0x00403574
	public void JCECBNKFODG(string DPNHODJHGJL)
	{
		this.<DELIHEHNGKB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AED5 RID: 44757 RVA: 0x004053E4 File Offset: 0x004035E4
	public void FNCDLDJFJAM(string DPNHODJHGJL)
	{
		this.<FABPAJHAJCG>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AED7 RID: 44759 RVA: 0x00405374 File Offset: 0x00403574
	public void MIHBPLHLFGG(string DPNHODJHGJL)
	{
		this.<DELIHEHNGKB>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AED8 RID: 44760 RVA: 0x004053F5 File Offset: 0x004035F5
	public string OMCPFLLPIPM()
	{
		return this.<JBOIDBBKGGI>k__BackingField;
	}

	// Token: 0x0600AEDB RID: 44763 RVA: 0x004052D6 File Offset: 0x004034D6
	public string DGINDFBNNDO()
	{
		return this.<FABPAJHAJCG>k__BackingField;
	}

	// Token: 0x0600AEDC RID: 44764 RVA: 0x004052D6 File Offset: 0x004034D6
	public string PPFIBJOHICJ()
	{
		return this.<FABPAJHAJCG>k__BackingField;
	}

	// Token: 0x0600AEDD RID: 44765 RVA: 0x004053E4 File Offset: 0x004035E4
	public void NNIDGJOPJOI(string DPNHODJHGJL)
	{
		this.<FABPAJHAJCG>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEDE RID: 44766 RVA: 0x004053ED File Offset: 0x004035ED
	public CustomAuthenticationType NKIEPEALJIB()
	{
		return this.EJBNALIEBFH;
	}

	// Token: 0x0600AEDF RID: 44767 RVA: 0x004053FD File Offset: 0x004035FD
	public string NEPEFCOOEGO()
	{
		return this.<DELIHEHNGKB>k__BackingField;
	}

	// Token: 0x0600AEE0 RID: 44768 RVA: 0x004053DB File Offset: 0x004035DB
	public void BLJGPAAPBKN(string DPNHODJHGJL)
	{
		this.<JBOIDBBKGGI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x004053F5 File Offset: 0x004035F5
	// (set) Token: 0x0600AEE1 RID: 44769 RVA: 0x004053DB File Offset: 0x004035DB
	public string AuthGetParameters { get; set; }

	// Token: 0x0600AEE2 RID: 44770 RVA: 0x004053C1 File Offset: 0x004035C1
	public virtual void SetAuthPostData(string MGJCBKGCFHA)
	{
		this.AuthPostData = ((!string.IsNullOrEmpty(MGJCBKGCFHA)) ? MGJCBKGCFHA : null);
	}

	// Token: 0x0600AEE3 RID: 44771 RVA: 0x004053E4 File Offset: 0x004035E4
	public void NJJEJBOAEDG(string DPNHODJHGJL)
	{
		this.<FABPAJHAJCG>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEE4 RID: 44772 RVA: 0x004053DB File Offset: 0x004035DB
	public void AMNGGOOHECA(string DPNHODJHGJL)
	{
		this.<JBOIDBBKGGI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEE5 RID: 44773 RVA: 0x00405405 File Offset: 0x00403605
	public override string ToString()
	{
		return string.Format("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", this.UserId, this.AuthGetParameters, this.Token != null);
	}

	// Token: 0x0600AEE6 RID: 44774 RVA: 0x00405390 File Offset: 0x00403590
	public object LPMFOIPADGG()
	{
		return this.<KKLGJFDHKIJ>k__BackingField;
	}

	// Token: 0x0600AEE8 RID: 44776 RVA: 0x0040542E File Offset: 0x0040362E
	public AuthenticationValues(string DJACMLGPOJB)
	{
		this.UserId = DJACMLGPOJB;
	}

	// Token: 0x0600AEE9 RID: 44777 RVA: 0x00405390 File Offset: 0x00403590
	public object MLKCIABICJB()
	{
		return this.<KKLGJFDHKIJ>k__BackingField;
	}

	// Token: 0x0600AEEA RID: 44778 RVA: 0x00405448 File Offset: 0x00403648
	public virtual void MHDGFNJJLCM(byte[] HNCGEEOBGGO)
	{
		this.BMFPDIEKHJA(HNCGEEOBGGO);
	}

	// Token: 0x0600AEEB RID: 44779 RVA: 0x004053E4 File Offset: 0x004035E4
	public void AIOHGAFEHJG(string DPNHODJHGJL)
	{
		this.<FABPAJHAJCG>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEEC RID: 44780 RVA: 0x004053DB File Offset: 0x004035DB
	public void DHDAMKILAND(string DPNHODJHGJL)
	{
		this.<JBOIDBBKGGI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0600AEED RID: 44781 RVA: 0x00405451 File Offset: 0x00403651
	public virtual void SetAuthPostData(byte[] HNCGEEOBGGO)
	{
		this.AuthPostData = HNCGEEOBGGO;
	}

	// Token: 0x0400145D RID: 5213
	private CustomAuthenticationType EJBNALIEBFH = CustomAuthenticationType.None;
}
