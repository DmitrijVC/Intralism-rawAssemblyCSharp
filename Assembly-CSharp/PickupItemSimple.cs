using System;
using Photon;
using UnityEngine;

// Token: 0x02000354 RID: 852
[RequireComponent(typeof(PhotonView))]
public class PickupItemSimple : Photon.MonoBehaviour
{
	// Token: 0x0600C034 RID: 49204 RVA: 0x0045EAFC File Offset: 0x0045CCFC
	public void JFIKFFBMPNK()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.IBKCMBIGOEJ().MIAHMDGOOPJ("CameraFilterPack/Color_GrayScale", (PhotonTargets)7, new object[0]);
	}

	// Token: 0x0600C035 RID: 49205 RVA: 0x0045EB28 File Offset: 0x0045CD28
	public void NNEPGDNHNGJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("ViewMenu" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.CMHMBFHAKOE();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 607f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("_MainTex2", num2);
		}
	}

	// Token: 0x0600C036 RID: 49206 RVA: 0x0045EBCE File Offset: 0x0045CDCE
	public void HMOLMNEJEHK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600C037 RID: 49207 RVA: 0x0045EBED File Offset: 0x0045CDED
	public void CNHPLAONDNB()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.IBKCMBIGOEJ().MIAHMDGOOPJ("DPADHOR", PhotonTargets.OthersBuffered, new object[1]);
	}

	// Token: 0x0600C038 RID: 49208 RVA: 0x0045EC1C File Offset: 0x0045CE1C
	public void ECBAINLOAMA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			this.AHJGIFKOFJB();
		}
	}

	// Token: 0x0600C039 RID: 49209 RVA: 0x0045EC58 File Offset: 0x0045CE58
	public void ONHEDAINMAF()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.FFIPLLNKGEN().RPC("_SceneFogMode", (PhotonTargets)7, new object[1]);
	}

	// Token: 0x0600C03A RID: 49210 RVA: 0x0045EC84 File Offset: 0x0045CE84
	public void OnTriggerEnter(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.isMine)
		{
			this.Pickup();
		}
	}

	// Token: 0x0600C03B RID: 49211 RVA: 0x0045ECC0 File Offset: 0x0045CEC0
	public void GFKEGEMFJJE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("id" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.LLINIHLINLF();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 250f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("EventTimeInputField", num2);
		}
	}

	// Token: 0x0600C03C RID: 49212 RVA: 0x0045ED68 File Offset: 0x0045CF68
	public void OMEDCHKGMND(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_ClutTex" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.PKDPOGPDJNI();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 1638f)
		{
			base.gameObject.SetActive(false);
			base.Invoke("mapselector.orderby", num2);
		}
	}

	// Token: 0x0600C03D RID: 49213 RVA: 0x0045EE10 File Offset: 0x0045D010
	public void NEGODKBGGKO(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.isMine)
		{
			this.AHJGIFKOFJB();
		}
	}

	// Token: 0x0600C03E RID: 49214 RVA: 0x0045EE4C File Offset: 0x0045D04C
	public void HOLAHMOGJGK()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C03F RID: 49215 RVA: 0x0045EE6B File Offset: 0x0045D06B
	public void GJIAHMCOIMM()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GBHNDHLAJLI().PBMFBOOALKA("CameraFilterPack/Distortion_Wave_Horizontal", PhotonTargets.All, new object[1]);
	}

	// Token: 0x0600C040 RID: 49216 RVA: 0x0045EE98 File Offset: 0x0045D098
	public void KKJLFIMOBAH(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_Value5" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.MAOGNACLFAA();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 586f)
		{
			base.gameObject.SetActive(false);
			base.Invoke("CameraFilterPack_RainFX_Anm2", num2);
		}
	}

	// Token: 0x0600C041 RID: 49217 RVA: 0x0045EF3E File Offset: 0x0045D13E
	public void GJJLCODONCE()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.EOOCGIFFKBG().MIAHMDGOOPJ("settings.enablerankingnotifications", PhotonTargets.MasterClient, new object[0]);
	}

	// Token: 0x0600C042 RID: 49218 RVA: 0x0045EF6A File Offset: 0x0045D16A
	public void AHJGIFKOFJB()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.JAEJDHHCJJO().MIAHMDGOOPJ("Set sun min/max size", PhotonTargets.AllBufferedViaServer, new object[0]);
	}

	// Token: 0x0600C043 RID: 49219 RVA: 0x0045EBCE File Offset: 0x0045CDCE
	public void NGPIGBJGKBF()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600C044 RID: 49220 RVA: 0x0045EF96 File Offset: 0x0045D196
	public void AHFONDPGGHC()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.ACPGHFHDCIP().KEKKFNNMLMG("_SunPosition", (PhotonTargets)8, new object[1]);
	}

	// Token: 0x0600C045 RID: 49221 RVA: 0x0045EFC4 File Offset: 0x0045D1C4
	public void NHJONLFALMB(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_FgOverlap" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.GJDFJLLPCEC();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 811f)
		{
			base.gameObject.SetActive(false);
			base.Invoke("_MainTex2", num2);
		}
	}

	// Token: 0x0600C046 RID: 49222 RVA: 0x0045EE4C File Offset: 0x0045D04C
	public void LLEJLALFCPH()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C047 RID: 49223 RVA: 0x0045F06A File Offset: 0x0045D26A
	public void EFLMEDBKOAF()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GMAHNPNHMFK().KEKKFNNMLMG("Tab2Content", PhotonTargets.AllBufferedViaServer, new object[0]);
	}

	// Token: 0x0600C048 RID: 49224 RVA: 0x0045F098 File Offset: 0x0045D298
	public void LEMBMJCAAKF(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_CameraClipInfo" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KDGEAANCGLG();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 1791f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("id", num2);
		}
	}

	// Token: 0x0600C049 RID: 49225 RVA: 0x0045EBCE File Offset: 0x0045CDCE
	public void RespawnAfter()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(true);
		}
	}

	// Token: 0x0600C04A RID: 49226 RVA: 0x0045F140 File Offset: 0x0045D340
	public void KLJHODOACJL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			this.AHFONDPGGHC();
		}
	}

	// Token: 0x0600C04B RID: 49227 RVA: 0x0045F17C File Offset: 0x0045D37C
	public void NJOLEFIKLPL(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			this.ONHEDAINMAF();
		}
	}

	// Token: 0x0600C04C RID: 49228 RVA: 0x0045F1B8 File Offset: 0x0045D3B8
	public void HKHGPJDAJKA()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.AAMNKPHHHCI().MIAHMDGOOPJ("_Value3", PhotonTargets.OthersBuffered, new object[1]);
	}

	// Token: 0x0600C04D RID: 49229 RVA: 0x0045F1E4 File Offset: 0x0045D3E4
	public void LJEPIJMPBHH(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			this.GJJLCODONCE();
		}
	}

	// Token: 0x0600C04E RID: 49230 RVA: 0x0045EE4C File Offset: 0x0045D04C
	public void LKKOKEBPMPC()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C04F RID: 49231 RVA: 0x0045F220 File Offset: 0x0045D420
	public void GLBMAGNIFDC()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = false;
		base.GBHNDHLAJLI().PBMFBOOALKA("value", (PhotonTargets)8, new object[1]);
	}

	// Token: 0x0600C050 RID: 49232 RVA: 0x0045F24C File Offset: 0x0045D44C
	public void CDEMOBDDOBE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log(".lastCheckpoint.penaltyScore" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.JLEPHCGPKMB();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 1328f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("_Value2", num2);
		}
	}

	// Token: 0x0600C052 RID: 49234 RVA: 0x0045F305 File Offset: 0x0045D505
	public void MCODMMGCDLM()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.OELHGNKAMEG().RPC("_Value2", PhotonTargets.Others, new object[0]);
	}

	// Token: 0x0600C053 RID: 49235 RVA: 0x0045F331 File Offset: 0x0045D531
	public void Pickup()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.photonView.RPC("PunPickupSimple", PhotonTargets.AllViaServer, new object[0]);
	}

	// Token: 0x0600C054 RID: 49236 RVA: 0x0045F360 File Offset: 0x0045D560
	public void JDKADFHCGML(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.BGJKMGJBPFA())
		{
			this.ONHEDAINMAF();
		}
	}

	// Token: 0x0600C055 RID: 49237 RVA: 0x0045F39C File Offset: 0x0045D59C
	public void GHNNBBKDPJL(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Using Stopwatch as precision timer for PUN." + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 1072f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("_ScreenResolution", num2);
		}
	}

	// Token: 0x0600C056 RID: 49238 RVA: 0x0045F444 File Offset: 0x0045D644
	public void GHBMODAKDHJ(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("offsets" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.ALPEKJJGCGG();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 339f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("SetParticlesParticleSpeed", num2);
		}
	}

	// Token: 0x0600C057 RID: 49239 RVA: 0x0045F4EA File Offset: 0x0045D6EA
	public void PJPNDBBNFBN()
	{
		if (this.SentPickup)
		{
			return;
		}
		this.SentPickup = true;
		base.GBMJAPGLMGB().RPC("maps.", PhotonTargets.AllViaServer, new object[1]);
	}

	// Token: 0x0600C058 RID: 49240 RVA: 0x0045F518 File Offset: 0x0045D718
	public void HHCAGPCFOAE(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("CameraFilterPack/Blend2Camera_Hue" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.HLOHLMIDPEE();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 108f)
		{
			base.gameObject.SetActive(false);
			base.Invoke("SupportLogger OnFailedToConnectToPhoton(", num2);
		}
	}

	// Token: 0x0600C059 RID: 49241 RVA: 0x0045F5C0 File Offset: 0x0045D7C0
	public void BAGDABNNIFI(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = true;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("_ScreenResolution" + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.KBICNLABBMP();
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 656f)
		{
			base.gameObject.SetActive(true);
			base.Invoke("achievements.21.progress", num2);
		}
	}

	// Token: 0x0600C05A RID: 49242 RVA: 0x0045EE4C File Offset: 0x0045D04C
	public void KHOGKNEBBOI()
	{
		if (base.gameObject != null)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600C05B RID: 49243 RVA: 0x0045F668 File Offset: 0x0045D868
	public void HPHCKKOKBOA(Collider AGGOHIAAMHN)
	{
		PhotonView component = AGGOHIAAMHN.GetComponent<PhotonView>();
		if (this.PickupOnCollide && component != null && component.DOLKFPIABDD())
		{
			this.CNHPLAONDNB();
		}
	}

	// Token: 0x0600C05C RID: 49244 RVA: 0x0045F6A4 File Offset: 0x0045D8A4
	[PunRPC]
	public void PunPickupSimple(PhotonMessageInfo PDBKGCDNLNG)
	{
		if (!this.SentPickup || !PDBKGCDNLNG.sender.IsLocal || base.gameObject.GetActive())
		{
		}
		this.SentPickup = false;
		if (!base.gameObject.GetActive())
		{
			Debug.Log("Ignored PU RPC, cause item is inactive. " + base.gameObject);
			return;
		}
		double num = PhotonNetwork.time - PDBKGCDNLNG.timestamp;
		float num2 = this.SecondsBeforeRespawn - (float)num;
		if (num2 > 0f)
		{
			base.gameObject.SetActive(false);
			base.Invoke("RespawnAfter", num2);
		}
	}

	// Token: 0x0400166B RID: 5739
	public float SecondsBeforeRespawn = 2f;

	// Token: 0x0400166C RID: 5740
	public bool PickupOnCollide;

	// Token: 0x0400166D RID: 5741
	public bool SentPickup;
}
