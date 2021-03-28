using System;
using System.Collections;
using Photon;
using UnityEngine;

// Token: 0x0200034B RID: 843
[RequireComponent(typeof(PhotonView))]
public class OnClickDestroy : Photon.MonoBehaviour
{
	// Token: 0x0600BE9C RID: 48796 RVA: 0x00458814 File Offset: 0x00456A14
	public IEnumerator MIOMHKDPDDN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BE9D RID: 48797 RVA: 0x00458830 File Offset: 0x00456A30
	public IEnumerator HDOMAFFLHDN()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BE9E RID: 48798 RVA: 0x0045884B File Offset: 0x00456A4B
	public void AKEIPNLIHNL()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.photonView.IKIJDNPJKPM("_InvViewProj", PhotonTargets.MasterClient, new object[0]);
		}
	}

	// Token: 0x0600BE9F RID: 48799 RVA: 0x0045887F File Offset: 0x00456A7F
	public void NLGGGEBBFAH()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.ACPGHFHDCIP().PBMFBOOALKA("_Value5", PhotonTargets.Others, new object[1]);
		}
	}

	// Token: 0x0600BEA0 RID: 48800 RVA: 0x004588B4 File Offset: 0x00456AB4
	public IEnumerator JABKLNDKJBD()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA1 RID: 48801 RVA: 0x004588D0 File Offset: 0x00456AD0
	public IEnumerator OKNCPHPIGIJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA3 RID: 48803 RVA: 0x004588EC File Offset: 0x00456AEC
	public IEnumerator MPNNIGNAMGO()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA4 RID: 48804 RVA: 0x00458907 File Offset: 0x00456B07
	public void PCHKMGNOEDF()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.GBHNDHLAJLI().RPC("https://api.steampowered.com/IInventoryService/AddItem/v001", PhotonTargets.MasterClient, new object[0]);
		}
	}

	// Token: 0x0600BEA5 RID: 48805 RVA: 0x0045893C File Offset: 0x00456B3C
	public IEnumerator GPONFOHFAAJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x00458958 File Offset: 0x00456B58
	public IEnumerator CEPFEBJKNKI()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA7 RID: 48807 RVA: 0x00458973 File Offset: 0x00456B73
	public void ONNJFFAFGGN()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.EOOCGIFFKBG().PBMFBOOALKA(").png", PhotonTargets.MasterClient, new object[1]);
		}
	}

	// Token: 0x0600BEA8 RID: 48808 RVA: 0x004589A8 File Offset: 0x00456BA8
	public IEnumerator DFKBMBKKHCI()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEA9 RID: 48809 RVA: 0x004589C3 File Offset: 0x00456BC3
	public void HFGANPKDCJI()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.IBKCMBIGOEJ().GNFNHDCJOFC("Alpha", PhotonTargets.AllViaServer, new object[1]);
		}
	}

	// Token: 0x0600BEAA RID: 48810 RVA: 0x004589F8 File Offset: 0x00456BF8
	public IEnumerator MHCFBJACDJC()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEAB RID: 48811 RVA: 0x00458A14 File Offset: 0x00456C14
	public IEnumerator OKDBDPLBJNA()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEAC RID: 48812 RVA: 0x00458A30 File Offset: 0x00456C30
	[PunRPC]
	public IEnumerator DestroyRpc()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEAD RID: 48813 RVA: 0x00458A4B File Offset: 0x00456C4B
	public void KKBODBLJHOB()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.CIACEFBNDDJ().PBMFBOOALKA("Share", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	// Token: 0x0600BEAE RID: 48814 RVA: 0x00458A80 File Offset: 0x00456C80
	public IEnumerator IKDFLMEIDGD()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEAF RID: 48815 RVA: 0x00458A9C File Offset: 0x00456C9C
	public IEnumerator KFPPAKHLILA()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEB0 RID: 48816 RVA: 0x00458AB7 File Offset: 0x00456CB7
	public void KBOKCPHKCMI()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.JAEJDHHCJJO().IKIJDNPJKPM("NetworkCanvas", PhotonTargets.AllBuffered, new object[1]);
		}
	}

	// Token: 0x0600BEB1 RID: 48817 RVA: 0x00458AEB File Offset: 0x00456CEB
	public void GAIOOLFFAFI()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.EOOCGIFFKBG().IKIJDNPJKPM("_Bullet_3", (PhotonTargets)8, new object[1]);
		}
	}

	// Token: 0x0600BEB2 RID: 48818 RVA: 0x00458B20 File Offset: 0x00456D20
	public IEnumerator NNMLKBEKBAG()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEB3 RID: 48819 RVA: 0x00458B3C File Offset: 0x00456D3C
	public IEnumerator AOOICLHFCEA()
	{
		UnityEngine.Object.Destroy(base.gameObject);
		yield return 0;
		PhotonNetwork.UnAllocateViewID(base.photonView.viewID);
		yield break;
	}

	// Token: 0x0600BEB4 RID: 48820 RVA: 0x00458B57 File Offset: 0x00456D57
	public void OnClick()
	{
		if (!this.DestroyByRpc)
		{
			PhotonNetwork.Destroy(base.gameObject);
		}
		else
		{
			base.photonView.RPC("DestroyRpc", PhotonTargets.AllBuffered, new object[0]);
		}
	}

	// Token: 0x04001650 RID: 5712
	public bool DestroyByRpc;
}
