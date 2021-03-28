using System;
using UnityEngine;

// Token: 0x0200022E RID: 558
public class Pool : MonoBehaviour
{
	// Token: 0x0600877D RID: 34685 RVA: 0x002FB944 File Offset: 0x002F9B44
	public GameObject OJLOOIEONGI()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x0600877E RID: 34686 RVA: 0x002FB9CC File Offset: 0x002F9BCC
	public void LONKKOFBDDN(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x0600877F RID: 34687 RVA: 0x002FBA24 File Offset: 0x002F9C24
	public void NLNEFOLJEIG(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008780 RID: 34688 RVA: 0x002FBA7C File Offset: 0x002F9C7C
	public void KMMFEBHJFAA(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008781 RID: 34689 RVA: 0x002FBAD4 File Offset: 0x002F9CD4
	public GameObject EDGJPEDMHFN()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x06008782 RID: 34690 RVA: 0x002FBB5C File Offset: 0x002F9D5C
	public GameObject JLLHOBJBDNN()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008783 RID: 34691 RVA: 0x002FBBE4 File Offset: 0x002F9DE4
	public void DBBKHGIJDOI(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008784 RID: 34692 RVA: 0x002FBC3C File Offset: 0x002F9E3C
	public void LHKJCDGPEKD(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x06008785 RID: 34693 RVA: 0x002FBC94 File Offset: 0x002F9E94
	public GameObject PODGFKFAFBN()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008786 RID: 34694 RVA: 0x002FBD1C File Offset: 0x002F9F1C
	public void DEPIAKEGAKE(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x06008787 RID: 34695 RVA: 0x002FBD74 File Offset: 0x002F9F74
	public void DOPLKFDBGAM(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x06008788 RID: 34696 RVA: 0x002FBDCC File Offset: 0x002F9FCC
	public void HDPNDDHNFOJ(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008789 RID: 34697 RVA: 0x002FBE24 File Offset: 0x002FA024
	public void OBPKKILBADL(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x0600878A RID: 34698 RVA: 0x002FBE7C File Offset: 0x002FA07C
	public GameObject GCKMCKGHKJB()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x0600878B RID: 34699 RVA: 0x002FBF04 File Offset: 0x002FA104
	public GameObject NBIKOBBNFGM()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x0600878C RID: 34700 RVA: 0x002FBF8C File Offset: 0x002FA18C
	public GameObject KFJOEEDEODL()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x0600878D RID: 34701 RVA: 0x002FC014 File Offset: 0x002FA214
	public void HCNGOHCCKBD(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x0600878E RID: 34702 RVA: 0x002FC06C File Offset: 0x002FA26C
	public GameObject DACIIEBNKBN()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x0600878F RID: 34703 RVA: 0x002FC0F4 File Offset: 0x002FA2F4
	public void NEPBGCDCDMC(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008790 RID: 34704 RVA: 0x002FC14C File Offset: 0x002FA34C
	public GameObject LIFAHJFIOMO()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008791 RID: 34705 RVA: 0x002FC1D4 File Offset: 0x002FA3D4
	public GameObject IFOCLAABDEI()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008792 RID: 34706 RVA: 0x002FC25C File Offset: 0x002FA45C
	public GameObject PBCCDPILANO()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x06008794 RID: 34708 RVA: 0x002FC2E4 File Offset: 0x002FA4E4
	public void JBNMLKGMFFA(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x06008795 RID: 34709 RVA: 0x002FC33C File Offset: 0x002FA53C
	public void ABBHFBOBILM(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x06008796 RID: 34710 RVA: 0x002FC394 File Offset: 0x002FA594
	public GameObject FIFJDDBGONJ()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008797 RID: 34711 RVA: 0x002FC41C File Offset: 0x002FA61C
	public GameObject JPGKNKKEMKC()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x06008798 RID: 34712 RVA: 0x002FC4A4 File Offset: 0x002FA6A4
	public void IECHADGJJBN(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x002FC4FC File Offset: 0x002FA6FC
	public void INPIOKFFDND(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x0600879A RID: 34714 RVA: 0x002FC554 File Offset: 0x002FA754
	public void EAANLGHMLDE(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x0600879B RID: 34715 RVA: 0x002FC5AC File Offset: 0x002FA7AC
	public void CNPMKMLFIJG(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x0600879C RID: 34716 RVA: 0x002FC604 File Offset: 0x002FA804
	public GameObject FONHLMLFLIM()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x0600879D RID: 34717 RVA: 0x002FC68C File Offset: 0x002FA88C
	public void CreatePool(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x0600879E RID: 34718 RVA: 0x002FC6E4 File Offset: 0x002FA8E4
	public GameObject GetObject()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x0600879F RID: 34719 RVA: 0x002FC76C File Offset: 0x002FA96C
	public void MJKODGBPPJI(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087A0 RID: 34720 RVA: 0x002FC7C4 File Offset: 0x002FA9C4
	public void PBJNBMDAEAM(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x060087A1 RID: 34721 RVA: 0x002FC81C File Offset: 0x002FAA1C
	public GameObject IECPFCOPIAH()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x060087A2 RID: 34722 RVA: 0x002FC8A4 File Offset: 0x002FAAA4
	public GameObject IAOPMEFNKKB()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087A3 RID: 34723 RVA: 0x002FC92C File Offset: 0x002FAB2C
	public GameObject KABEIEDMAJK()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x060087A4 RID: 34724 RVA: 0x002FC9B4 File Offset: 0x002FABB4
	public void HJGMKELNDPE(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x060087A5 RID: 34725 RVA: 0x002FCA0C File Offset: 0x002FAC0C
	public void KJHOEMJAAKF(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x060087A6 RID: 34726 RVA: 0x002FCA64 File Offset: 0x002FAC64
	public GameObject MFONOACAODI()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087A7 RID: 34727 RVA: 0x002FCAEC File Offset: 0x002FACEC
	public void PPGFJJMOOLC(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087A8 RID: 34728 RVA: 0x002FCB44 File Offset: 0x002FAD44
	public GameObject HDNMHMBPICA()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087A9 RID: 34729 RVA: 0x002FCBCC File Offset: 0x002FADCC
	public void NPGADDCHIEF(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087AA RID: 34730 RVA: 0x002FCC24 File Offset: 0x002FAE24
	public void KJFGJDHMLHJ(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087AB RID: 34731 RVA: 0x002FCC7C File Offset: 0x002FAE7C
	public GameObject AFCDLOLBNNM()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(false);
			}
		}
		return null;
	}

	// Token: 0x060087AC RID: 34732 RVA: 0x002FCD04 File Offset: 0x002FAF04
	public GameObject FGCEDMAPAGA()
	{
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087AD RID: 34733 RVA: 0x002FCD8C File Offset: 0x002FAF8C
	public GameObject NNMEAEKODCB()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i += 0)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(false);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087AE RID: 34734 RVA: 0x002FCE14 File Offset: 0x002FB014
	public void FAMGGJOHJFK(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087AF RID: 34735 RVA: 0x002FCE6C File Offset: 0x002FB06C
	public GameObject DPHGKHICPLP()
	{
		for (int i = 0; i < this.EGNHNBODKHP.Length; i++)
		{
			if (this.EGNHNBODKHP[i])
			{
				if (!this.EGNHNBODKHP[i].activeSelf)
				{
					this.EGNHNBODKHP[i].SetActive(true);
					return this.EGNHNBODKHP[i];
				}
			}
			else
			{
				this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(this.CMBAAHJGKLI);
				this.EGNHNBODKHP[i].SetActive(true);
			}
		}
		return null;
	}

	// Token: 0x060087B0 RID: 34736 RVA: 0x002FCEF4 File Offset: 0x002FB0F4
	public void GBLJPFECFLE(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i += 0)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(false);
		}
	}

	// Token: 0x060087B1 RID: 34737 RVA: 0x002FCF4C File Offset: 0x002FB14C
	public void GFGDPNACMBG(GameObject CMBAAHJGKLI, int OHHNPMICLBH)
	{
		this.EGNHNBODKHP = new GameObject[OHHNPMICLBH];
		this.CMBAAHJGKLI = CMBAAHJGKLI;
		for (int i = 1; i < this.EGNHNBODKHP.Length; i++)
		{
			this.EGNHNBODKHP[i] = UnityEngine.Object.Instantiate<GameObject>(CMBAAHJGKLI);
			this.EGNHNBODKHP[i].SetActive(true);
		}
	}

	// Token: 0x04000FB5 RID: 4021
	private GameObject[] EGNHNBODKHP;

	// Token: 0x04000FB6 RID: 4022
	private GameObject CMBAAHJGKLI;
}
