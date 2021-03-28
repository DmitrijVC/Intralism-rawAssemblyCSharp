using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000324 RID: 804
[RequireComponent(typeof(PhotonView))]
[RequireComponent(typeof(Animator))]
[AddComponentMenu("Photon Networking/Photon Animator View")]
public class PhotonAnimatorView : MonoBehaviour, IPunObservable
{
	// Token: 0x0600B8B7 RID: 47287 RVA: 0x00438300 File Offset: 0x00436500
	private void NKLIHNJCHOG()
	{
		if (this.PGKLKGGALMP.applyRootMotion && !this.GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			this.PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.EGPGEMJNPFD() <= 1)
		{
			this.GAMOKOLALHP.KNNOEGLLDAN();
			return;
		}
		if (this.GDIAJCAHCEC.isMine)
		{
			this.CDPNDOMBEFA();
			this.CacheDiscreteTriggers();
		}
		else
		{
			this.JDIONMKAPGA();
		}
	}

	// Token: 0x0600B8B8 RID: 47288 RVA: 0x00438390 File Offset: 0x00436590
	private void CDPNDOMBEFA()
	{
		if (this.PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == (PhotonAnimatorView.SynchronizeType)3)
			{
				this.GAMOKOLALHP.DDHLHOGOGNP(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Disabled)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.GAMOKOLALHP.FIDPDKNOIFH(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)(-33))
					{
						this.GAMOKOLALHP.ILHKKFBHAIC(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.GAMOKOLALHP.DGJOBJMAJNJ(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	// Token: 0x0600B8B9 RID: 47289 RVA: 0x00438508 File Offset: 0x00436708
	public void MHAAMGJIMDB(int PKFOGBFGICJ, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.OMKKJMMOLMJ omkkjmmolmj = new PhotonAnimatorView.OMKKJMMOLMJ();
		omkkjmmolmj.PKFOGBFGICJ = PKFOGBFGICJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = false;
		}
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(omkkjmmolmj.MEMPOPNAEDN));
		if (num == -1)
		{
			this.m_SynchronizeLayers.Add(new PhotonAnimatorView.SynchronizedLayer
			{
				LayerIndex = omkkjmmolmj.PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8BA RID: 47290 RVA: 0x00438590 File Offset: 0x00436790
	public bool MFNDNGCIAFF(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.GEJGKCEDKJF gejgkcedkjf = new PhotonAnimatorView.GEJGKCEDKJF();
		gejgkcedkjf.PKFOGBFGICJ = PKFOGBFGICJ;
		return this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(gejgkcedkjf.LLNDDFGPOPL)) == -1;
	}

	// Token: 0x0600B8BB RID: 47291 RVA: 0x004385C8 File Offset: 0x004367C8
	private void IIFCIDDJHPM()
	{
		if (this.PGKLKGGALMP.applyRootMotion && !this.GDIAJCAHCEC.DOLKFPIABDD() && PhotonNetwork.connected)
		{
			this.PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.EGPGEMJNPFD() <= 0)
		{
			this.GAMOKOLALHP.Reset();
			return;
		}
		if (this.GDIAJCAHCEC.BGJKMGJBPFA())
		{
			this.DEOGPJBPEPP();
			this.OHHBFDOOOFH();
		}
		else
		{
			this.NOHDKANLKGD();
		}
	}

	// Token: 0x0600B8BC RID: 47292 RVA: 0x00438658 File Offset: 0x00436858
	public bool DODEDMFEKGM(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.KCINJFMOMBP kcinjfmombp = new PhotonAnimatorView.KCINJFMOMBP();
		kcinjfmombp.EBEHBBDKDFJ = EBEHBBDKDFJ;
		return this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(kcinjfmombp.AEIFJLBBKBP)) != -1;
	}

	// Token: 0x0600B8BD RID: 47293 RVA: 0x00438690 File Offset: 0x00436890
	public PhotonAnimatorView.SynchronizeType DGDDJHGKCCN(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.EJEGDAFJHIM ejegdafjhim = new PhotonAnimatorView.EJEGDAFJHIM();
		ejegdafjhim.PKFOGBFGICJ = PKFOGBFGICJ;
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(ejegdafjhim.BMAOCLKPNNC));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeLayers[num].SynchronizeType;
	}

	// Token: 0x0600B8BE RID: 47294 RVA: 0x004386DC File Offset: 0x004368DC
	private void ICLOBEBBKHD(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = (byte[])HCIJEDFCNOP.ReceiveNext();
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			this.m_SynchronizeLayers[i].SynchronizeType = (PhotonAnimatorView.SynchronizeType)array[i];
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			this.m_SynchronizeParameters[j].SynchronizeType = (PhotonAnimatorView.SynchronizeType)array[this.m_SynchronizeLayers.Count + j];
		}
	}

	// Token: 0x0600B8BF RID: 47295 RVA: 0x00438764 File Offset: 0x00436964
	public void BNKBEEPOHMG(string EBEHBBDKDFJ, PhotonAnimatorView.ParameterType HMGBJCGOLMI, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.NJGHCFAPGMB njghcfapgmb = new PhotonAnimatorView.NJGHCFAPGMB();
		njghcfapgmb.EBEHBBDKDFJ = EBEHBBDKDFJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = true;
		}
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(njghcfapgmb.EKHOOPGPPGE));
		if (num == -1)
		{
			this.m_SynchronizeParameters.Add(new PhotonAnimatorView.SynchronizedParameter
			{
				Name = njghcfapgmb.EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8C0 RID: 47296 RVA: 0x004387F4 File Offset: 0x004369F4
	private void NOHDKANLKGD()
	{
		if (!this.GAMOKOLALHP.POPNINEGMHF())
		{
			return;
		}
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == (PhotonAnimatorView.SynchronizeType)7)
			{
				this.PGKLKGGALMP.SetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex, (float)this.GAMOKOLALHP.IKEKLFCNONN());
			}
		}
		for (int j = 1; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == (PhotonAnimatorView.SynchronizeType)3)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)this.GAMOKOLALHP.ReceiveNext());
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)88)
					{
						this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.IKEKLFCNONN());
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)this.GAMOKOLALHP.LHDLFDPJLEA());
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.IKEKLFCNONN());
					break;
				}
			}
		}
	}

	// Token: 0x0600B8C1 RID: 47297 RVA: 0x0043896C File Offset: 0x00436B6C
	private void CPALFOIHHAE(PhotonStream HCIJEDFCNOP)
	{
		byte[] array = new byte[this.m_SynchronizeLayers.Count + this.m_SynchronizeParameters.Count];
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			array[i] = (byte)this.m_SynchronizeLayers[i].SynchronizeType;
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			array[this.m_SynchronizeLayers.Count + j] = (byte)this.m_SynchronizeParameters[j].SynchronizeType;
		}
		HCIJEDFCNOP.SendNext(array);
	}

	// Token: 0x0600B8C2 RID: 47298 RVA: 0x00438A0C File Offset: 0x00436C0C
	public PhotonAnimatorView.SynchronizeType GetLayerSynchronizeType(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.EJEGDAFJHIM ejegdafjhim = new PhotonAnimatorView.EJEGDAFJHIM();
		ejegdafjhim.PKFOGBFGICJ = PKFOGBFGICJ;
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(ejegdafjhim.GBKBDKHPLKG));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeLayers[num].SynchronizeType;
	}

	// Token: 0x0600B8C3 RID: 47299 RVA: 0x00438A58 File Offset: 0x00436C58
	public bool CELPIAIHAIO(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.GEJGKCEDKJF gejgkcedkjf = new PhotonAnimatorView.GEJGKCEDKJF();
		gejgkcedkjf.PKFOGBFGICJ = PKFOGBFGICJ;
		return this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(gejgkcedkjf.EGKGJJGAPMN)) != -1;
	}

	// Token: 0x0600B8C5 RID: 47301 RVA: 0x00438AD0 File Offset: 0x00436CD0
	public bool JGHBPPLDJPP(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.KCINJFMOMBP kcinjfmombp = new PhotonAnimatorView.KCINJFMOMBP();
		kcinjfmombp.EBEHBBDKDFJ = EBEHBBDKDFJ;
		return this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(kcinjfmombp.OMBHIBNMFNB)) != -1;
	}

	// Token: 0x0600B8C6 RID: 47302 RVA: 0x00438B08 File Offset: 0x00436D08
	public PhotonAnimatorView.SynchronizeType PFEAKIPNMLO(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.NMHDILBGNEE nmhdilbgnee = new PhotonAnimatorView.NMHDILBGNEE();
		nmhdilbgnee.EBEHBBDKDFJ = EBEHBBDKDFJ;
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(nmhdilbgnee.JKEDCEOCPJO));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeParameters[num].SynchronizeType;
	}

	// Token: 0x0600B8C7 RID: 47303 RVA: 0x00438B54 File Offset: 0x00436D54
	private void NINPKPDJAME(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.SendNext(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					HCIJEDFCNOP.SendNext(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == PhotonAnimatorView.ParameterType.Trigger)
					{
						HCIJEDFCNOP.SendNext(this.JNMGDECFIMB.Contains(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					HCIJEDFCNOP.SendNext(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					HCIJEDFCNOP.SendNext(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
		this.JNMGDECFIMB.Clear();
	}

	// Token: 0x0600B8C8 RID: 47304 RVA: 0x00438CAC File Offset: 0x00436EAC
	public bool DNFINIMAEJA(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.GEJGKCEDKJF gejgkcedkjf = new PhotonAnimatorView.GEJGKCEDKJF();
		gejgkcedkjf.PKFOGBFGICJ = PKFOGBFGICJ;
		return this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(gejgkcedkjf.EKHOOPGPPGE)) == -1;
	}

	// Token: 0x0600B8C9 RID: 47305 RVA: 0x00438CE4 File Offset: 0x00436EE4
	private void MODNODMLGBK(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i += 0)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				this.PGKLKGGALMP.SetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.ReceiveNext());
			}
		}
		for (int j = 1; j < this.m_SynchronizeParameters.Count; j += 0)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Disabled)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					if (!(HCIJEDFCNOP.IDCPJJPFEJJ() is float))
					{
						return;
					}
					this.PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.IDKHBJIHKEB());
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)(-128))
					{
						if (!(HCIJEDFCNOP.KDNNJPIKFIC() is bool))
						{
							return;
						}
						if ((bool)HCIJEDFCNOP.NLPFEFOCGBC())
						{
							this.PGKLKGGALMP.SetTrigger(synchronizedParameter.Name);
						}
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					if (!(HCIJEDFCNOP.AOKDKJCKNCI() is int))
					{
						return;
					}
					this.PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.FIBMOBNIALK());
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					if (!(HCIJEDFCNOP.AOKDKJCKNCI() is bool))
					{
						return;
					}
					this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.NLPFEFOCGBC());
					break;
				}
			}
		}
	}

	// Token: 0x0600B8CA RID: 47306 RVA: 0x00438E79 File Offset: 0x00437079
	private void Awake()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.GAMOKOLALHP = new PhotonStreamQueue(120);
		this.PGKLKGGALMP = base.GetComponent<Animator>();
	}

	// Token: 0x0600B8CB RID: 47307 RVA: 0x00438EA0 File Offset: 0x004370A0
	public void MFJNOJKGGDK(int PKFOGBFGICJ, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.OMKKJMMOLMJ omkkjmmolmj = new PhotonAnimatorView.OMKKJMMOLMJ();
		omkkjmmolmj.PKFOGBFGICJ = PKFOGBFGICJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = false;
		}
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(omkkjmmolmj.LOEAMHGMMPK));
		if (num == -1)
		{
			this.m_SynchronizeLayers.Add(new PhotonAnimatorView.SynchronizedLayer
			{
				LayerIndex = omkkjmmolmj.PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8CC RID: 47308 RVA: 0x00438F26 File Offset: 0x00437126
	public List<PhotonAnimatorView.SynchronizedParameter> GetSynchronizedParameters()
	{
		return this.m_SynchronizeParameters;
	}

	// Token: 0x0600B8CD RID: 47309 RVA: 0x00438F30 File Offset: 0x00437130
	private void NENDODGHIDJ()
	{
		if (this.PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Continuous)
			{
				this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Continuous)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == PhotonAnimatorView.ParameterType.Trigger)
					{
						this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	// Token: 0x0600B8CE RID: 47310 RVA: 0x004390A8 File Offset: 0x004372A8
	public void OHHBFDOOOFH()
	{
		for (int i = 1; i < this.m_SynchronizeParameters.Count; i++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete && synchronizedParameter.Type == (PhotonAnimatorView.ParameterType)(-73) && this.PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == (PhotonAnimatorView.ParameterType)(-93))
			{
				this.JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	// Token: 0x0600B8CF RID: 47311 RVA: 0x00439130 File Offset: 0x00437330
	public void MCGGIDPEPAN(int PKFOGBFGICJ, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.OMKKJMMOLMJ omkkjmmolmj = new PhotonAnimatorView.OMKKJMMOLMJ();
		omkkjmmolmj.PKFOGBFGICJ = PKFOGBFGICJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = true;
		}
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(omkkjmmolmj.EGKGJJGAPMN));
		if (num == -1)
		{
			this.m_SynchronizeLayers.Add(new PhotonAnimatorView.SynchronizedLayer
			{
				LayerIndex = omkkjmmolmj.PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8D0 RID: 47312 RVA: 0x004391B8 File Offset: 0x004373B8
	public bool DEGDKLFMCAP(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.KCINJFMOMBP kcinjfmombp = new PhotonAnimatorView.KCINJFMOMBP();
		kcinjfmombp.EBEHBBDKDFJ = EBEHBBDKDFJ;
		return this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(kcinjfmombp.PBCAHKDLFPE)) == -1;
	}

	// Token: 0x0600B8D1 RID: 47313 RVA: 0x004391F0 File Offset: 0x004373F0
	public void CacheDiscreteTriggers()
	{
		for (int i = 0; i < this.m_SynchronizeParameters.Count; i++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[i];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete && synchronizedParameter.Type == PhotonAnimatorView.ParameterType.Trigger && this.PGKLKGGALMP.GetBool(synchronizedParameter.Name) && synchronizedParameter.Type == PhotonAnimatorView.ParameterType.Trigger)
			{
				this.JNMGDECFIMB.Add(synchronizedParameter.Name);
				break;
			}
		}
	}

	// Token: 0x0600B8D2 RID: 47314 RVA: 0x00439278 File Offset: 0x00437478
	private void DOCHFABJBJG(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				this.PGKLKGGALMP.SetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex, (float)HCIJEDFCNOP.ReceiveNext());
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					if (!(HCIJEDFCNOP.PeekNext() is float))
					{
						return;
					}
					this.PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)HCIJEDFCNOP.ReceiveNext());
					break;
				default:
					if (type == PhotonAnimatorView.ParameterType.Trigger)
					{
						if (!(HCIJEDFCNOP.PeekNext() is bool))
						{
							return;
						}
						if ((bool)HCIJEDFCNOP.ReceiveNext())
						{
							this.PGKLKGGALMP.SetTrigger(synchronizedParameter.Name);
						}
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					if (!(HCIJEDFCNOP.PeekNext() is int))
					{
						return;
					}
					this.PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)HCIJEDFCNOP.ReceiveNext());
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					if (!(HCIJEDFCNOP.PeekNext() is bool))
					{
						return;
					}
					this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)HCIJEDFCNOP.ReceiveNext());
					break;
				}
			}
		}
	}

	// Token: 0x0600B8D3 RID: 47315 RVA: 0x00438F26 File Offset: 0x00437126
	public List<PhotonAnimatorView.SynchronizedParameter> GGDKJACBGGP()
	{
		return this.m_SynchronizeParameters;
	}

	// Token: 0x0600B8D4 RID: 47316 RVA: 0x00439410 File Offset: 0x00437610
	public bool DoesLayerSynchronizeTypeExist(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.GEJGKCEDKJF gejgkcedkjf = new PhotonAnimatorView.GEJGKCEDKJF();
		gejgkcedkjf.PKFOGBFGICJ = PKFOGBFGICJ;
		return this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(gejgkcedkjf.GBKBDKHPLKG)) != -1;
	}

	// Token: 0x0600B8D5 RID: 47317 RVA: 0x00439448 File Offset: 0x00437648
	public void SetLayerSynchronized(int PKFOGBFGICJ, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.OMKKJMMOLMJ omkkjmmolmj = new PhotonAnimatorView.OMKKJMMOLMJ();
		omkkjmmolmj.PKFOGBFGICJ = PKFOGBFGICJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = true;
		}
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(omkkjmmolmj.GBKBDKHPLKG));
		if (num == -1)
		{
			this.m_SynchronizeLayers.Add(new PhotonAnimatorView.SynchronizedLayer
			{
				LayerIndex = omkkjmmolmj.PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8D6 RID: 47318 RVA: 0x004394D0 File Offset: 0x004376D0
	public PhotonAnimatorView.SynchronizeType EBDKNHAEFEI(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.EJEGDAFJHIM ejegdafjhim = new PhotonAnimatorView.EJEGDAFJHIM();
		ejegdafjhim.PKFOGBFGICJ = PKFOGBFGICJ;
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(ejegdafjhim.FCAGEDLBBHD));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeLayers[num].SynchronizeType;
	}

	// Token: 0x0600B8D7 RID: 47319 RVA: 0x0043951C File Offset: 0x0043771C
	private void JDIONMKAPGA()
	{
		if (!this.GAMOKOLALHP.FGIECEGOCGK())
		{
			return;
		}
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i += 0)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				this.PGKLKGGALMP.SetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex, (float)this.GAMOKOLALHP.IDKHBJIHKEB());
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j += 0)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Disabled)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case (PhotonAnimatorView.ParameterType)0:
					this.PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)this.GAMOKOLALHP.IKEKLFCNONN());
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)(-16))
					{
						this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.LHDLFDPJLEA());
					}
					break;
				case (PhotonAnimatorView.ParameterType)2:
					this.PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)this.GAMOKOLALHP.IKEKLFCNONN());
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.IDKHBJIHKEB());
					break;
				}
			}
		}
	}

	// Token: 0x0600B8D8 RID: 47320 RVA: 0x00439694 File Offset: 0x00437894
	public bool DoesParameterSynchronizeTypeExist(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.KCINJFMOMBP kcinjfmombp = new PhotonAnimatorView.KCINJFMOMBP();
		kcinjfmombp.EBEHBBDKDFJ = EBEHBBDKDFJ;
		return this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(kcinjfmombp.GBKBDKHPLKG)) != -1;
	}

	// Token: 0x0600B8D9 RID: 47321 RVA: 0x004396CC File Offset: 0x004378CC
	public PhotonAnimatorView.SynchronizeType BAKMDMLOMPA(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.EJEGDAFJHIM ejegdafjhim = new PhotonAnimatorView.EJEGDAFJHIM();
		ejegdafjhim.PKFOGBFGICJ = PKFOGBFGICJ;
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(ejegdafjhim.BFEABMIFIEE));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Discrete;
		}
		return this.m_SynchronizeLayers[num].SynchronizeType;
	}

	// Token: 0x0600B8DA RID: 47322 RVA: 0x00439718 File Offset: 0x00437918
	private void LCJHDLKJEOM()
	{
		if (this.PGKLKGGALMP.applyRootMotion && !this.GDIAJCAHCEC.BGJKMGJBPFA() && PhotonNetwork.connected)
		{
			this.PGKLKGGALMP.applyRootMotion = true;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.DHOGHIOACME() <= 1)
		{
			this.GAMOKOLALHP.Reset();
			return;
		}
		if (this.GDIAJCAHCEC.DOLKFPIABDD())
		{
			this.CDPNDOMBEFA();
			this.OHHBFDOOOFH();
		}
		else
		{
			this.JDIONMKAPGA();
		}
	}

	// Token: 0x0600B8DB RID: 47323 RVA: 0x004397A8 File Offset: 0x004379A8
	public bool JCLNMPFEIFK(int PKFOGBFGICJ)
	{
		PhotonAnimatorView.GEJGKCEDKJF gejgkcedkjf = new PhotonAnimatorView.GEJGKCEDKJF();
		gejgkcedkjf.PKFOGBFGICJ = PKFOGBFGICJ;
		return this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(gejgkcedkjf.BFEABMIFIEE)) != -1;
	}

	// Token: 0x0600B8DC RID: 47324 RVA: 0x004397E0 File Offset: 0x004379E0
	public PhotonAnimatorView.SynchronizeType KODBNLBNMBB(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.NMHDILBGNEE nmhdilbgnee = new PhotonAnimatorView.NMHDILBGNEE();
		nmhdilbgnee.EBEHBBDKDFJ = EBEHBBDKDFJ;
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(nmhdilbgnee.OLIGLEMPFOP));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeParameters[num].SynchronizeType;
	}

	// Token: 0x0600B8DD RID: 47325 RVA: 0x0043982C File Offset: 0x00437A2C
	private void FLFBBNEIAAB()
	{
		if (this.PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i += 0)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == (PhotonAnimatorView.SynchronizeType)7)
			{
				this.GAMOKOLALHP.HPCOFADNBPA(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Disabled)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.GAMOKOLALHP.FIDPDKNOIFH(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)45)
					{
						this.GAMOKOLALHP.HPCOFADNBPA(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.GAMOKOLALHP.DGJOBJMAJNJ(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.GAMOKOLALHP.SendNext(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	// Token: 0x0600B8DE RID: 47326 RVA: 0x004399A4 File Offset: 0x00437BA4
	private void MHOKCLFCMDH(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i += 0)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.SendNext(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 1; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Disabled)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case (PhotonAnimatorView.ParameterType)0:
					HCIJEDFCNOP.CPIBABMPJLE(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)(-22))
					{
						HCIJEDFCNOP.OLACNHHHOEL(this.JNMGDECFIMB.Contains(synchronizedParameter.Name));
					}
					break;
				case (PhotonAnimatorView.ParameterType)2:
					HCIJEDFCNOP.PNAPNHJHBMN(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Int:
					HCIJEDFCNOP.CPIBABMPJLE(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
		this.JNMGDECFIMB.Clear();
	}

	// Token: 0x0600B8DF RID: 47327 RVA: 0x00439AFC File Offset: 0x00437CFC
	private void FAODPBIIFDF()
	{
		if (!this.GAMOKOLALHP.HasQueuedObjects())
		{
			return;
		}
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Continuous)
			{
				this.PGKLKGGALMP.SetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex, (float)this.GAMOKOLALHP.ReceiveNext());
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Continuous)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.PGKLKGGALMP.SetFloat(synchronizedParameter.Name, (float)this.GAMOKOLALHP.ReceiveNext());
					break;
				default:
					if (type == PhotonAnimatorView.ParameterType.Trigger)
					{
						this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.ReceiveNext());
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.PGKLKGGALMP.SetInteger(synchronizedParameter.Name, (int)this.GAMOKOLALHP.ReceiveNext());
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.PGKLKGGALMP.SetBool(synchronizedParameter.Name, (bool)this.GAMOKOLALHP.ReceiveNext());
					break;
				}
			}
		}
	}

	// Token: 0x0600B8E0 RID: 47328 RVA: 0x00439C72 File Offset: 0x00437E72
	public List<PhotonAnimatorView.SynchronizedLayer> LKFLOHIMJMJ()
	{
		return this.m_SynchronizeLayers;
	}

	// Token: 0x0600B8E1 RID: 47329 RVA: 0x00438F26 File Offset: 0x00437126
	public List<PhotonAnimatorView.SynchronizedParameter> NGDLFDKJEKH()
	{
		return this.m_SynchronizeParameters;
	}

	// Token: 0x0600B8E2 RID: 47330 RVA: 0x00439C7C File Offset: 0x00437E7C
	public void JEPABGBLOFE(string EBEHBBDKDFJ, PhotonAnimatorView.ParameterType HMGBJCGOLMI, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.NJGHCFAPGMB njghcfapgmb = new PhotonAnimatorView.NJGHCFAPGMB();
		njghcfapgmb.EBEHBBDKDFJ = EBEHBBDKDFJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = true;
		}
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(njghcfapgmb.GBKBDKHPLKG));
		if (num == -1)
		{
			this.m_SynchronizeParameters.Add(new PhotonAnimatorView.SynchronizedParameter
			{
				Name = njghcfapgmb.EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8E3 RID: 47331 RVA: 0x00439D0C File Offset: 0x00437F0C
	private void DEOGPJBPEPP()
	{
		if (this.PGKLKGGALMP == null)
		{
			return;
		}
		for (int i = 1; i < this.m_SynchronizeLayers.Count; i++)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == (PhotonAnimatorView.SynchronizeType)3)
			{
				this.GAMOKOLALHP.MJLPEADKIMK(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Continuous)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					this.GAMOKOLALHP.MJLPEADKIMK(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)(-93))
					{
						this.GAMOKOLALHP.DDHLHOGOGNP(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					this.GAMOKOLALHP.DGJOBJMAJNJ(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					this.GAMOKOLALHP.HPCOFADNBPA(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
	}

	// Token: 0x0600B8E4 RID: 47332 RVA: 0x00439E84 File Offset: 0x00438084
	public bool EGPEPEJDGCJ(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.KCINJFMOMBP kcinjfmombp = new PhotonAnimatorView.KCINJFMOMBP();
		kcinjfmombp.EBEHBBDKDFJ = EBEHBBDKDFJ;
		return this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(kcinjfmombp.KFNBKFELFLH)) != -1;
	}

	// Token: 0x0600B8E5 RID: 47333 RVA: 0x00439EBC File Offset: 0x004380BC
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.PGKLKGGALMP == null)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.MENGIFKONIP)
			{
				this.GAMOKOLALHP.Reset();
				this.CPALFOIHHAE(HCIJEDFCNOP);
				this.MENGIFKONIP = false;
			}
			this.GAMOKOLALHP.Serialize(HCIJEDFCNOP);
			this.NINPKPDJAME(HCIJEDFCNOP);
		}
		else
		{
			if (HCIJEDFCNOP.PeekNext() is byte[])
			{
				this.ICLOBEBBKHD(HCIJEDFCNOP);
			}
			this.GAMOKOLALHP.Deserialize(HCIJEDFCNOP);
			this.DOCHFABJBJG(HCIJEDFCNOP);
		}
	}

	// Token: 0x0600B8E6 RID: 47334 RVA: 0x00439F4C File Offset: 0x0043814C
	private void AJIKPEIGACI()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.GAMOKOLALHP = new PhotonStreamQueue(-5);
		this.PGKLKGGALMP = base.GetComponent<Animator>();
	}

	// Token: 0x0600B8E7 RID: 47335 RVA: 0x00439F74 File Offset: 0x00438174
	public void SetParameterSynchronized(string EBEHBBDKDFJ, PhotonAnimatorView.ParameterType HMGBJCGOLMI, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.NJGHCFAPGMB njghcfapgmb = new PhotonAnimatorView.NJGHCFAPGMB();
		njghcfapgmb.EBEHBBDKDFJ = EBEHBBDKDFJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = true;
		}
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(njghcfapgmb.GBKBDKHPLKG));
		if (num == -1)
		{
			this.m_SynchronizeParameters.Add(new PhotonAnimatorView.SynchronizedParameter
			{
				Name = njghcfapgmb.EBEHBBDKDFJ,
				Type = HMGBJCGOLMI,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeParameters[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8E8 RID: 47336 RVA: 0x0043A004 File Offset: 0x00438204
	private void DGANFOLNABB(PhotonStream HCIJEDFCNOP)
	{
		for (int i = 0; i < this.m_SynchronizeLayers.Count; i += 0)
		{
			if (this.m_SynchronizeLayers[i].SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.PGKLKGGALMP.GetLayerWeight(this.m_SynchronizeLayers[i].LayerIndex));
			}
		}
		for (int j = 0; j < this.m_SynchronizeParameters.Count; j++)
		{
			PhotonAnimatorView.SynchronizedParameter synchronizedParameter = this.m_SynchronizeParameters[j];
			if (synchronizedParameter.SynchronizeType == PhotonAnimatorView.SynchronizeType.Discrete)
			{
				PhotonAnimatorView.ParameterType type = synchronizedParameter.Type;
				switch (type)
				{
				case PhotonAnimatorView.ParameterType.Float:
					HCIJEDFCNOP.PBECMJMDHBI(this.PGKLKGGALMP.GetFloat(synchronizedParameter.Name));
					break;
				default:
					if (type == (PhotonAnimatorView.ParameterType)99)
					{
						HCIJEDFCNOP.IBCLJIACBKG(this.JNMGDECFIMB.Contains(synchronizedParameter.Name));
					}
					break;
				case PhotonAnimatorView.ParameterType.Int:
					HCIJEDFCNOP.OLACNHHHOEL(this.PGKLKGGALMP.GetInteger(synchronizedParameter.Name));
					break;
				case PhotonAnimatorView.ParameterType.Bool:
					HCIJEDFCNOP.IBCLJIACBKG(this.PGKLKGGALMP.GetBool(synchronizedParameter.Name));
					break;
				}
			}
		}
		this.JNMGDECFIMB.Clear();
	}

	// Token: 0x0600B8E9 RID: 47337 RVA: 0x00439C72 File Offset: 0x00437E72
	public List<PhotonAnimatorView.SynchronizedLayer> GetSynchronizedLayers()
	{
		return this.m_SynchronizeLayers;
	}

	// Token: 0x0600B8EA RID: 47338 RVA: 0x0043A15C File Offset: 0x0043835C
	public void ACPDDODDGLE(int PKFOGBFGICJ, PhotonAnimatorView.SynchronizeType JBLLFKFMPNO)
	{
		PhotonAnimatorView.OMKKJMMOLMJ omkkjmmolmj = new PhotonAnimatorView.OMKKJMMOLMJ();
		omkkjmmolmj.PKFOGBFGICJ = PKFOGBFGICJ;
		if (Application.isPlaying)
		{
			this.MENGIFKONIP = false;
		}
		int num = this.m_SynchronizeLayers.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedLayer>(omkkjmmolmj.BJMAIJDIKCN));
		if (num == -1)
		{
			this.m_SynchronizeLayers.Add(new PhotonAnimatorView.SynchronizedLayer
			{
				LayerIndex = omkkjmmolmj.PKFOGBFGICJ,
				SynchronizeType = JBLLFKFMPNO
			});
		}
		else
		{
			this.m_SynchronizeLayers[num].SynchronizeType = JBLLFKFMPNO;
		}
	}

	// Token: 0x0600B8EB RID: 47339 RVA: 0x0043A1E4 File Offset: 0x004383E4
	private void Update()
	{
		if (this.PGKLKGGALMP.applyRootMotion && !this.GDIAJCAHCEC.isMine && PhotonNetwork.connected)
		{
			this.PGKLKGGALMP.applyRootMotion = false;
		}
		if (!PhotonNetwork.inRoom || PhotonNetwork.room.PlayerCount <= 1)
		{
			this.GAMOKOLALHP.Reset();
			return;
		}
		if (this.GDIAJCAHCEC.isMine)
		{
			this.NENDODGHIDJ();
			this.CacheDiscreteTriggers();
		}
		else
		{
			this.FAODPBIIFDF();
		}
	}

	// Token: 0x0600B8EC RID: 47340 RVA: 0x0043A274 File Offset: 0x00438474
	public PhotonAnimatorView.SynchronizeType GetParameterSynchronizeType(string EBEHBBDKDFJ)
	{
		PhotonAnimatorView.NMHDILBGNEE nmhdilbgnee = new PhotonAnimatorView.NMHDILBGNEE();
		nmhdilbgnee.EBEHBBDKDFJ = EBEHBBDKDFJ;
		int num = this.m_SynchronizeParameters.FindIndex(new Predicate<PhotonAnimatorView.SynchronizedParameter>(nmhdilbgnee.GBKBDKHPLKG));
		if (num == -1)
		{
			return PhotonAnimatorView.SynchronizeType.Disabled;
		}
		return this.m_SynchronizeParameters[num].SynchronizeType;
	}

	// Token: 0x0400159F RID: 5535
	private Animator PGKLKGGALMP;

	// Token: 0x040015A0 RID: 5536
	private PhotonStreamQueue GAMOKOLALHP;

	// Token: 0x040015A1 RID: 5537
	[SerializeField]
	[HideInInspector]
	private bool ShowLayerWeightsInspector = true;

	// Token: 0x040015A2 RID: 5538
	[SerializeField]
	[HideInInspector]
	private bool ShowParameterInspector = true;

	// Token: 0x040015A3 RID: 5539
	[HideInInspector]
	[SerializeField]
	private List<PhotonAnimatorView.SynchronizedParameter> m_SynchronizeParameters = new List<PhotonAnimatorView.SynchronizedParameter>();

	// Token: 0x040015A4 RID: 5540
	[SerializeField]
	[HideInInspector]
	private List<PhotonAnimatorView.SynchronizedLayer> m_SynchronizeLayers = new List<PhotonAnimatorView.SynchronizedLayer>();

	// Token: 0x040015A5 RID: 5541
	private Vector3 DNCIIEPNCPD;

	// Token: 0x040015A6 RID: 5542
	private float HOAEICIPNOF;

	// Token: 0x040015A7 RID: 5543
	private bool MENGIFKONIP = true;

	// Token: 0x040015A8 RID: 5544
	private PhotonView GDIAJCAHCEC;

	// Token: 0x040015A9 RID: 5545
	private List<string> JNMGDECFIMB = new List<string>();

	// Token: 0x02000325 RID: 805
	public enum ParameterType
	{
		// Token: 0x040015AB RID: 5547
		Float = 1,
		// Token: 0x040015AC RID: 5548
		Int = 3,
		// Token: 0x040015AD RID: 5549
		Bool,
		// Token: 0x040015AE RID: 5550
		Trigger = 9
	}

	// Token: 0x02000326 RID: 806
	public enum SynchronizeType
	{
		// Token: 0x040015B0 RID: 5552
		Disabled,
		// Token: 0x040015B1 RID: 5553
		Discrete,
		// Token: 0x040015B2 RID: 5554
		Continuous
	}

	// Token: 0x02000327 RID: 807
	[Serializable]
	public class SynchronizedParameter
	{
		// Token: 0x040015B3 RID: 5555
		public PhotonAnimatorView.ParameterType Type;

		// Token: 0x040015B4 RID: 5556
		public PhotonAnimatorView.SynchronizeType SynchronizeType;

		// Token: 0x040015B5 RID: 5557
		public string Name;
	}

	// Token: 0x02000328 RID: 808
	[Serializable]
	public class SynchronizedLayer
	{
		// Token: 0x040015B6 RID: 5558
		public PhotonAnimatorView.SynchronizeType SynchronizeType;

		// Token: 0x040015B7 RID: 5559
		public int LayerIndex;
	}

	// Token: 0x02000329 RID: 809
	[CompilerGenerated]
	private sealed class GEJGKCEDKJF
	{
		// Token: 0x0600B8EF RID: 47343 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool JDELIMPGFDJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F1 RID: 47345 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F2 RID: 47346 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F3 RID: 47347 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool AGJKEBOPIOC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool FJDBPPKABJE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool EGKGJJGAPMN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool LHHFJBIAHCN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8FC RID: 47356 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool DKGPCPBNDPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8FD RID: 47357 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8FE RID: 47358 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B8FF RID: 47359 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B900 RID: 47360 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B901 RID: 47361 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool FIPCLHEKKCA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool KGKMOLCPDIH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x0043A2C0 File Offset: 0x004384C0
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x040015B8 RID: 5560
		internal int PKFOGBFGICJ;
	}

	// Token: 0x0200032A RID: 810
	[CompilerGenerated]
	private sealed class KCINJFMOMBP
	{
		// Token: 0x0600B909 RID: 47369 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FDAIFOAGDLA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90A RID: 47370 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90B RID: 47371 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool INHOEMCLAAP(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90C RID: 47372 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BEBAENEJFLD(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool JBAJEMGOPDL(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B910 RID: 47376 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FMIHBNPKEEO(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B911 RID: 47377 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FJDBPPKABJE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B912 RID: 47378 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B913 RID: 47379 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool EFAPFFFGOOA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B914 RID: 47380 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool EGKGJJGAPMN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B915 RID: 47381 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B916 RID: 47382 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool PIJAOCFAPKC(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B917 RID: 47383 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FIPCLHEKKCA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B918 RID: 47384 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B919 RID: 47385 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool AEIFJLBBKBP(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91A RID: 47386 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91B RID: 47387 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool PKAPLCFHDOC(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91C RID: 47388 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool JDELIMPGFDJ(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91D RID: 47389 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FHFECFLBHMA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91E RID: 47390 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FHIJCPPECHA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B91F RID: 47391 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BJMAIJDIKCN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B920 RID: 47392 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool OMBHIBNMFNB(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B922 RID: 47394 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B923 RID: 47395 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B924 RID: 47396 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool DKGPCPBNDPK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B925 RID: 47397 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B926 RID: 47398 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool IGFOBPKFCDJ(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B927 RID: 47399 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B928 RID: 47400 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool OFLDIMDDLHM(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B929 RID: 47401 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92A RID: 47402 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool AGJKEBOPIOC(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool BMAOCLKPNNC(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool LJDLIIIPIIJ(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B92F RID: 47407 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool EDGAPOPEIJF(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B930 RID: 47408 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B931 RID: 47409 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B932 RID: 47410 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool JBCHBMKPDAJ(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool MGENGAEDACG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool DNIMHEKGJHB(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool HBJFIOJFBHC(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool LHHFJBIAHCN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool KGKMOLCPDIH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x0043A2D0 File Offset: 0x004384D0
		internal bool FCAGEDLBBHD(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x040015B9 RID: 5561
		internal string EBEHBBDKDFJ;
	}

	// Token: 0x0200032B RID: 811
	[CompilerGenerated]
	private sealed class EJEGDAFJHIM
	{
		// Token: 0x0600B93A RID: 47418 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool PIJAOCFAPKC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool DKGPCPBNDPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool HBJFIOJFBHC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool IGFOBPKFCDJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FHIJCPPECHA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool AGJKEBOPIOC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FDAIFOAGDLA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FIPCLHEKKCA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool KGKMOLCPDIH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool OFLDIMDDLHM(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool EGKGJJGAPMN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool JDELIMPGFDJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FCAGEDLBBHD(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool DNIMHEKGJHB(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool LHHFJBIAHCN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool FJDBPPKABJE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B95B RID: 47451 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool BMAOCLKPNNC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x0043A2E3 File Offset: 0x004384E3
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x040015BA RID: 5562
		internal int PKFOGBFGICJ;
	}

	// Token: 0x0200032C RID: 812
	[CompilerGenerated]
	private sealed class NMHDILBGNEE
	{
		// Token: 0x0600B95D RID: 47453 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x0043A2F3 File Offset: 0x004384F3
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x040015BB RID: 5563
		internal string EBEHBBDKDFJ;
	}

	// Token: 0x0200032D RID: 813
	[CompilerGenerated]
	private sealed class OMKKJMMOLMJ
	{
		// Token: 0x0600B96F RID: 47471 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool JDELIMPGFDJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool LJDLIIIPIIJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B972 RID: 47474 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool OFLDIMDDLHM(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool BMAOCLKPNNC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FHIJCPPECHA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool LHHFJBIAHCN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool EGKGJJGAPMN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool MGENGAEDACG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool IGFOBPKFCDJ(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FCAGEDLBBHD(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool PIJAOCFAPKC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool DKGPCPBNDPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool KGKMOLCPDIH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FHFECFLBHMA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool DNIMHEKGJHB(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FDAIFOAGDLA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FIPCLHEKKCA(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool HBJFIOJFBHC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool BJMAIJDIKCN(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool FJDBPPKABJE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool AGJKEBOPIOC(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x0043A306 File Offset: 0x00438506
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedLayer DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.LayerIndex == this.PKFOGBFGICJ;
		}

		// Token: 0x040015BC RID: 5564
		internal int PKFOGBFGICJ;
	}

	// Token: 0x0200032E RID: 814
	[CompilerGenerated]
	private sealed class NJGHCFAPGMB
	{
		// Token: 0x0600B996 RID: 47510 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool LNDGINDKPFA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool BKNHHGBPLGH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool PBCAHKDLFPE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool FFEGPHJKMFK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool MEMPOPNAEDN(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool LLNDDFGPOPL(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool AEINPAGJFME(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool GBKBDKHPLKG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool EKHOOPGPPGE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool KFNBKFELFLH(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool BDGDIDPDBHG(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool OLIGLEMPFOP(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool DBFPGFHEGKA(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool JKEDCEOCPJO(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool OFHCGKJFGDI(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool LOEAMHGMMPK(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x0043A316 File Offset: 0x00438516
		internal bool BFEABMIFIEE(PhotonAnimatorView.SynchronizedParameter DBIMJHMKHNK)
		{
			return DBIMJHMKHNK.Name == this.EBEHBBDKDFJ;
		}

		// Token: 0x040015BD RID: 5565
		internal string EBEHBBDKDFJ;
	}
}
