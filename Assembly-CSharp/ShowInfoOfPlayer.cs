using System;
using Photon;
using UnityEngine;

// Token: 0x02000361 RID: 865
[RequireComponent(typeof(PhotonView))]
public class ShowInfoOfPlayer : Photon.MonoBehaviour
{
	// Token: 0x0600C1FE RID: 49662 RVA: 0x00468BDC File Offset: 0x00466DDC
	private void BGFJOEPFOPM()
	{
		bool flag = this.DisableOnOwnObjects && base.AAMNKPHHHCI().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer photonPlayer = base.JAEJDHHCJJO().JJFEGIOPFGN();
		if (photonPlayer != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("_DotSize" + photonPlayer.ID));
		}
		else if (base.GBHNDHLAJLI().FJEMLGIGOCJ())
		{
			this.GFNILPAPGJN.text = "Parent object ID. Case-Sensitive";
		}
		else
		{
			this.GFNILPAPGJN.text = ":";
		}
	}

	// Token: 0x0600C1FF RID: 49663 RVA: 0x00468CB0 File Offset: 0x00466EB0
	private void JAAJECBCCFM()
	{
		bool flag = this.DisableOnOwnObjects && base.OELHGNKAMEG().DOLKFPIABDD();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer photonPlayer = base.GMAHNPNHMFK().JFCKAGHNNCA();
		if (photonPlayer != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("Warning: No Shape Curve set for CurveWaveform.cs on " + photonPlayer.ID));
		}
		else if (base.photonView.FJEMLGIGOCJ())
		{
			this.GFNILPAPGJN.text = "SetEnvSpriteColor";
		}
		else
		{
			this.GFNILPAPGJN.text = "D-Pad Down";
		}
	}

	// Token: 0x0600C200 RID: 49664 RVA: 0x00468D84 File Offset: 0x00466F84
	private void CFIAKIJAILI()
	{
		bool flag = !this.DisableOnOwnObjects || base.EOOCGIFFKBG().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer owner = base.photonView.owner;
		if (owner != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_Params1" + owner.ID));
		}
		else if (base.GMAHNPNHMFK().isSceneView)
		{
			this.GFNILPAPGJN.text = "win";
		}
		else
		{
			this.GFNILPAPGJN.text = "_Far";
		}
	}

	// Token: 0x0600C201 RID: 49665 RVA: 0x00468E58 File Offset: 0x00467058
	private void Start()
	{
		if (this.font == null)
		{
			this.font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[0];
			Debug.LogWarning("No font defined. Found font: " + this.font);
		}
		if (this.GFNILPAPGJN == null)
		{
			this.GFLFBLOLIGA = new GameObject("3d text");
			this.GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			this.GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = this.GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = this.font.material;
			this.GFNILPAPGJN = this.GFLFBLOLIGA.AddComponent<TextMesh>();
			this.GFNILPAPGJN.font = this.font;
			this.GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (this.CharacterSize > 0f)
			{
				this.GFNILPAPGJN.characterSize = this.CharacterSize;
			}
		}
	}

	// Token: 0x0600C203 RID: 49667 RVA: 0x00468F64 File Offset: 0x00467164
	private void MFMIODIAKNI()
	{
		bool flag = this.DisableOnOwnObjects && base.FFIPLLNKGEN().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer photonPlayer = base.GBHNDHLAJLI().JFCKAGHNNCA();
		if (photonPlayer != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("/" + photonPlayer.ID));
		}
		else if (base.GBMJAPGLMGB().NADJFHDOFGD())
		{
			this.GFNILPAPGJN.text = ".sawoutdatedmessage";
		}
		else
		{
			this.GFNILPAPGJN.text = "_Value2";
		}
	}

	// Token: 0x0600C204 RID: 49668 RVA: 0x00469038 File Offset: 0x00467238
	private void OCMKCBBCEFG()
	{
		bool flag = this.DisableOnOwnObjects && base.GMAHNPNHMFK().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer photonPlayer = base.GMAHNPNHMFK().JJFEGIOPFGN();
		if (photonPlayer != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(photonPlayer.NickName)) ? photonPlayer.NickName : ("[LocalizationService] All languages: " + photonPlayer.ID));
		}
		else if (base.photonView.LIDEPDFOMFC())
		{
			this.GFNILPAPGJN.text = "[Up]";
		}
		else
		{
			this.GFNILPAPGJN.text = "_ScreenResolution";
		}
	}

	// Token: 0x0600C205 RID: 49669 RVA: 0x0046910C File Offset: 0x0046730C
	private void NBGIMIDICKE()
	{
		if (this.font == null)
		{
			this.font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("Load scene by name or build id" + this.font);
		}
		if (this.GFNILPAPGJN == null)
		{
			this.GFLFBLOLIGA = new GameObject("[PlayerController] ");
			this.GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			this.GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = this.GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = this.font.material;
			this.GFNILPAPGJN = this.GFLFBLOLIGA.AddComponent<TextMesh>();
			this.GFNILPAPGJN.font = this.font;
			this.GFNILPAPGJN.anchor = TextAnchor.UpperRight;
			if (this.CharacterSize > 923f)
			{
				this.GFNILPAPGJN.characterSize = this.CharacterSize;
			}
		}
	}

	// Token: 0x0600C206 RID: 49670 RVA: 0x00469218 File Offset: 0x00467418
	private void LEAHIBJDMBI()
	{
		bool flag = this.DisableOnOwnObjects && base.IBKCMBIGOEJ().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer owner = base.AAMNKPHHHCI().owner;
		if (owner != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("DPADHOR" + owner.ONIKFABKELO()));
		}
		else if (base.ACPGHFHDCIP().LIDEPDFOMFC())
		{
			this.GFNILPAPGJN.text = "Object ID. Case-Sensitive";
		}
		else
		{
			this.GFNILPAPGJN.text = "[MapsData] Found ";
		}
	}

	// Token: 0x0600C207 RID: 49671 RVA: 0x004692EC File Offset: 0x004674EC
	private void Update()
	{
		bool flag = !this.DisableOnOwnObjects || base.photonView.isMine;
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer owner = base.photonView.owner;
		if (owner != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("player" + owner.ID));
		}
		else if (base.photonView.isSceneView)
		{
			this.GFNILPAPGJN.text = "scn";
		}
		else
		{
			this.GFNILPAPGJN.text = "n/a";
		}
	}

	// Token: 0x0600C208 RID: 49672 RVA: 0x004693C0 File Offset: 0x004675C0
	private void JHPOIOELNCG()
	{
		bool flag = this.DisableOnOwnObjects && base.OELHGNKAMEG().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer owner = base.BLMHOKPIMOD().owner;
		if (owner != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_ScreenResolution" + owner.ONIKFABKELO()));
		}
		else if (base.GMAHNPNHMFK().FJEMLGIGOCJ())
		{
			this.GFNILPAPGJN.text = "_Distortion";
		}
		else
		{
			this.GFNILPAPGJN.text = "checkpoint";
		}
	}

	// Token: 0x0600C209 RID: 49673 RVA: 0x00469494 File Offset: 0x00467694
	private void AAPKBNDHBLI()
	{
		bool flag = !this.DisableOnOwnObjects || base.BLMHOKPIMOD().BGJKMGJBPFA();
		if (this.GFLFBLOLIGA != null)
		{
			this.GFLFBLOLIGA.SetActive(flag);
		}
		if (!flag)
		{
			return;
		}
		PhotonPlayer owner = base.GMAHNPNHMFK().owner;
		if (owner != null)
		{
			this.GFNILPAPGJN.text = ((!string.IsNullOrEmpty(owner.NickName)) ? owner.NickName : ("_Value2" + owner.ONIKFABKELO()));
		}
		else if (base.AAMNKPHHHCI().NADJFHDOFGD())
		{
			this.GFNILPAPGJN.text = "ItemsCountText";
		}
		else
		{
			this.GFNILPAPGJN.text = "_TimeX";
		}
	}

	// Token: 0x0600C20A RID: 49674 RVA: 0x00469568 File Offset: 0x00467768
	private void CCLNNLCOPBL()
	{
		if (this.font == null)
		{
			this.font = (Font)Resources.FindObjectsOfTypeAll(typeof(Font))[1];
			Debug.LogWarning("SetCrosshairColor" + this.font);
		}
		if (this.GFNILPAPGJN == null)
		{
			this.GFLFBLOLIGA = new GameObject("_Near");
			this.GFLFBLOLIGA.transform.parent = base.gameObject.transform;
			this.GFLFBLOLIGA.transform.localPosition = Vector3.zero;
			MeshRenderer meshRenderer = this.GFLFBLOLIGA.AddComponent<MeshRenderer>();
			meshRenderer.material = this.font.material;
			this.GFNILPAPGJN = this.GFLFBLOLIGA.AddComponent<TextMesh>();
			this.GFNILPAPGJN.font = this.font;
			this.GFNILPAPGJN.anchor = TextAnchor.MiddleCenter;
			if (this.CharacterSize > 358f)
			{
				this.GFNILPAPGJN.characterSize = this.CharacterSize;
			}
		}
	}

	// Token: 0x04001681 RID: 5761
	private GameObject GFLFBLOLIGA;

	// Token: 0x04001682 RID: 5762
	private TextMesh GFNILPAPGJN;

	// Token: 0x04001683 RID: 5763
	public float CharacterSize;

	// Token: 0x04001684 RID: 5764
	public Font font;

	// Token: 0x04001685 RID: 5765
	public bool DisableOnOwnObjects;
}
