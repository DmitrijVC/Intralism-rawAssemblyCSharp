using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020003DD RID: 989
public class PlayerController : MonoBehaviour
{
	// Token: 0x0600E0C3 RID: 57539 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool HMOFKPGCJCE()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0C4 RID: 57540 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase PELOCGBHJFO()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0C5 RID: 57541 RVA: 0x00504BA0 File Offset: 0x00502DA0
	public void AIFIMLBHNOM(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.KEGJGPOECHA() == "ArcsHitsoundTimeDelaySlider" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = this.FMOHBPMDAOK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.JHEFABODNPO().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.playerBase.CIACEFBNDDJ().isMine)
					{
						PhotonView photonView = this.DFLDMFKFBPC().ACPGHFHDCIP();
						string lblkdnnpaco = "CameraFilterPack/Film_ColorPerfection";
						PhotonTargets mpnmoonbmii = PhotonTargets.AllBufferedViaServer;
						object[] array = new object[0];
						array[0] = true;
						photonView.PBMFBOOALKA(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.DMFKOAIAHDC();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.JHEFABODNPO().currentCombo = 0;
					if (this.JDHHBDEAEID && this.NODPGAOEHGL().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(3, UnityEngine.Random.Range(407f, 1587f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_ScreenResolution")
				{
					PlayerBase playerBase2 = this.ODHBANOIMPN();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.CCBCAICCJLD().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1455f - this.FNEPAIOLEOD) > 425.0) ? (1298f - this.FNEPAIOLEOD) : 496f;
						float max = 808f + this.FNEPAIOLEOD;
						if (num <= 1469f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.KEFGHEIOHON().GBHNDHLAJLI().KEKKFNNMLMG("SteamManager", PhotonTargets.MasterClient, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1526f) + 1873f;
					if (num3 > 1751f)
					{
						num3 = 863f;
					}
					if (num3 < 1256f)
					{
						num3 = 655f;
					}
					float num4 = (num3 >= 1526f) ? 209f : ((1792f - num3) * num2 * num2);
					if (num3 >= 823f)
					{
						PlayerBase playerBase3 = this.EICAMMJELIE();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.NODPGAOEHGL();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.NLIGEMDBEOA();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.DGNIAONOGKK();
					playerBase6.comboScore += (float)this.NLIGEMDBEOA().currentCombo;
					PlayerBase playerBase7 = this.JJPEGCHJJED();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.DMFKOAIAHDC();
					playerBase8.accuracyScore += (num3 - this.NODPGAOEHGL().accuracyScore) / (float)(this.KEFGHEIOHON().incorrectScore + this.JHEFABODNPO().correctScore);
					if (this.JDHHBDEAEID && this.ODHBANOIMPN().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(915f - this.FNEPAIOLEOD) > 1979.0) ? (1508f - this.FNEPAIOLEOD) : 286f;
						float max2 = 1311f + this.FNEPAIOLEOD;
						if (num3 >= 1475f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.DFLDMFKFBPC().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1843f * ((820f - this.OMGIMLPPNFI) * 1647f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -72 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E0C6 RID: 57542 RVA: 0x00505054 File Offset: 0x00503254
	public int GBLDJPCFLPC()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 0)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.CMALDOOPBEB);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "MapEnd";
				}
				text = " " + text.Remove(text.Length - 0, 0) + "#";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Scene" + this.currentCombo[1].ToString() + "_PColor");
		}
		return -1;
	}

	// Token: 0x0600E0C7 RID: 57543 RVA: 0x00505190 File Offset: 0x00503390
	private GameObject AGGPFPNKMFC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1684f, 1233f, 448f);
		Vector3 b2 = new Vector3(348f, 610f, 1118f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(1444f, 1470f, 1759f);
		}
		if (this.ACODLKJMCJF == 1)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1389f, 250f, 943f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(350f, 1143f, 495f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1743f, 1693f, 1701f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1338f;
			b.y = 642f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 497f;
			b.y = 686f;
		}
		if (FLMFNIGKHKP == 8)
		{
			b.x = 889f;
			b.y = 1775f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1535f;
			b.y = 88f;
		}
		bool flag = FLMFNIGKHKP != -100;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.DNOKKLIKLAM().transform.position + b + b2, this.playerBase.transform.TransformDirection(Vector3.back), out raycastHit, 1788f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DNOKKLIKLAM().transform.position + b + b2, this.NODPGAOEHGL().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 384f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.DGNIAONOGKK().transform.position + b + b2, this.NFANBIICAFM().transform.TransformDirection(Vector3.back) * 969f, Color.white, 983f);
		return null;
	}

	// Token: 0x0600E0C8 RID: 57544 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int NJHMHPKJDCL(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0C9 RID: 57545 RVA: 0x005053D6 File Offset: 0x005035D6
	public void PKFFJEOBLGD(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E0CA RID: 57546 RVA: 0x005053E0 File Offset: 0x005035E0
	private GameObject AKBLLMJBONI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1200f, 68f, 102f);
		Vector3 b2 = new Vector3(1438f, 891f, 654f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(1061f, 396f, 345f);
		}
		if (this.ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1951f, 1292f, 1027f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(574f, 205f, 523f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1424f, 1280f, 143f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1480f;
			b.y = 805f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 1500f;
			b.y = 1487f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1772f;
			b.y = 180f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1716f;
			b.y = 1575f;
		}
		bool flag = FLMFNIGKHKP == -2;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.PELOCGBHJFO().transform.position + b + b2, this.DMFKOAIAHDC().transform.TransformDirection(Vector3.back), out raycastHit, 808f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.EICAMMJELIE().transform.position + b + b2, this.PELOCGBHJFO().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1392f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.ODHBANOIMPN().transform.position + b + b2, this.ODHBANOIMPN().transform.TransformDirection(Vector3.back) * 754f, Color.white, 843f);
		return null;
	}

	// Token: 0x0600E0CB RID: 57547 RVA: 0x00505624 File Offset: 0x00503824
	public int DJLACMJODFF()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.LKJEPINPFLC);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "_ScreenResolution";
				}
				text = "ResetButton" + text.Remove(text.Length - 1, 1) + "#no";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("_ScreenResolution" + this.currentCombo[0].ToString() + "visible");
		}
		return -1;
	}

	// Token: 0x0600E0CC RID: 57548 RVA: 0x00505760 File Offset: 0x00503960
	public void GIGMGMDAJOG(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "_Value" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = this.DMCMLADEEEK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.NLIGEMDBEOA().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.NODPGAOEHGL().OELHGNKAMEG().BGJKMGJBPFA())
					{
						PhotonView photonView = this.CCBCAICCJLD().OELHGNKAMEG();
						string lblkdnnpaco = "_Extra2";
						PhotonTargets mpnmoonbmii = (PhotonTargets)7;
						object[] array = new object[0];
						array[0] = true;
						photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.NFANBIICAFM();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.DNOKKLIKLAM().currentCombo = 1;
					if (this.JDHHBDEAEID && this.JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(732f, 307f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "RPCs can only be sent in rooms. Call of \"")
				{
					PlayerBase playerBase2 = this.EICAMMJELIE();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(67f - this.FNEPAIOLEOD) > 419.0) ? (1216f - this.FNEPAIOLEOD) : 576f;
						float max = 1075f + this.FNEPAIOLEOD;
						if (num <= 1416f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.KEFGHEIOHON().GBMJAPGLMGB().IKIJDNPJKPM("In Main Menu", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1499f) + 894f;
					if (num3 > 1384f)
					{
						num3 = 980f;
					}
					if (num3 < 1558f)
					{
						num3 = 1977f;
					}
					float num4 = (num3 >= 942f) ? 635f : ((1177f - num3) * num2 * num2);
					if (num3 >= 1912f)
					{
						PlayerBase playerBase3 = this.NFANBIICAFM();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.JHEFABODNPO();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.EICAMMJELIE();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.ODHBANOIMPN();
					playerBase6.comboScore += (float)this.JJPEGCHJJED().currentCombo;
					PlayerBase playerBase7 = this.KEFGHEIOHON();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.DGNIAONOGKK();
					playerBase8.accuracyScore += (num3 - this.DFLDMFKFBPC().accuracyScore) / (float)(this.NODPGAOEHGL().incorrectScore + this.NODPGAOEHGL().correctScore);
					if (this.JDHHBDEAEID && this.ODHBANOIMPN().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(215f - this.FNEPAIOLEOD) > 636.0) ? (1782f - this.FNEPAIOLEOD) : 677f;
						float max2 = 1473f + this.FNEPAIOLEOD;
						if (num3 >= 1069f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 370f * ((832f - this.OMGIMLPPNFI) * 1522f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 47 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E0CD RID: 57549 RVA: 0x00505C14 File Offset: 0x00503E14
	private void FIJHDKIPENG()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().BLMHOKPIMOD().isMine)
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.KJFEMNPENDO(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.JHEFABODNPO().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[6], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[4], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[5], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[0], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[2], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("settings_bindings_controller_type", 1390f, null);
			if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "hidden")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CMAFBKOEPLP("sounds/hit_wrong", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.CMAFBKOEPLP(" | ", 0, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Joystick1Button0", 1785f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("maps.", 396f, null);
		}
	}

	// Token: 0x0600E0CE RID: 57550 RVA: 0x00505EC4 File Offset: 0x005040C4
	private void POEMOLBJDLG()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = true;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[5]) || hardInput.GetKey(this.PIHEMHOGGPL[0]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.MFMIODIAKNI();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.playerBase.HJAHIPPLLDJ(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E0CF RID: 57551 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase DGNIAONOGKK()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0D0 RID: 57552 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool CPEJFCKHKOL()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0D1 RID: 57553 RVA: 0x005061F4 File Offset: 0x005043F4
	private void OHFOLGANOLC()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().GBHNDHLAJLI().KCAOJFPDEIP())
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.OADIPGANJAM(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DNOKKLIKLAM().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[3], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[2], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[4], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[2], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[5], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[6], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[92], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Texture2", 1579f, null);
			if (Singleton<Scene>.Instance.EMOAHNADEHK() == "_Value2")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Coroutine container not configured... did you forget to call Init?", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("USE_CORNER_DETECTION", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_TimeX", 1819f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(" has no method \"", 211f, null);
		}
	}

	// Token: 0x0600E0D2 RID: 57554 RVA: 0x005053D6 File Offset: 0x005035D6
	public void NFDDPIGLDBG(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E0D3 RID: 57555 RVA: 0x005053D6 File Offset: 0x005035D6
	public void NMCKPDLLBBG(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E0D4 RID: 57556 RVA: 0x005064A4 File Offset: 0x005046A4
	public void CONKAILPANP(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.id == "Uploader" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.BHNJNLOHFLC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.DNOKKLIKLAM().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.DFLDMFKFBPC().ACPGHFHDCIP().DOLKFPIABDD())
					{
						PhotonView photonView = this.JHEFABODNPO().ACPGHFHDCIP();
						string lblkdnnpaco = "_Red_R";
						PhotonTargets mpnmoonbmii = PhotonTargets.OthersBuffered;
						object[] array = new object[0];
						array[0] = true;
						photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.EICAMMJELIE();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.KEFGHEIOHON().currentCombo = 1;
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(3, UnityEngine.Random.Range(700f, 705f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "\r")
				{
					PlayerBase playerBase2 = this.JJPEGCHJJED();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(144f - this.FNEPAIOLEOD) > 862.0) ? (49f - this.FNEPAIOLEOD) : 993f;
						float max = 1212f + this.FNEPAIOLEOD;
						if (num <= 710f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.JJPEGCHJJED().IBKCMBIGOEJ().GNFNHDCJOFC("Object ID. Case-Sensitive", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1482f) + 1810f;
					if (num3 > 1922f)
					{
						num3 = 167f;
					}
					if (num3 < 151f)
					{
						num3 = 1009f;
					}
					float num4 = (num3 >= 1461f) ? 508f : ((1527f - num3) * num2 * num2);
					if (num3 >= 121f)
					{
						PlayerBase playerBase3 = this.playerBase;
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.DNOKKLIKLAM();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.DGNIAONOGKK();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.NLIGEMDBEOA();
					playerBase6.comboScore += (float)this.NODPGAOEHGL().currentCombo;
					PlayerBase playerBase7 = this.playerBase;
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.DGNIAONOGKK();
					playerBase8.accuracyScore += (num3 - this.JHEFABODNPO().accuracyScore) / (float)(this.HBDLLAKOFKJ().incorrectScore + this.PELOCGBHJFO().correctScore);
					if (this.JDHHBDEAEID && this.PELOCGBHJFO().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(922f - this.FNEPAIOLEOD) > 550.0) ? (1277f - this.FNEPAIOLEOD) : 1956f;
						float max2 = 44f + this.FNEPAIOLEOD;
						if (num3 >= 858f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.PELOCGBHJFO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1933f * ((1647f - this.OMGIMLPPNFI) * 1254f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 54 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E0D5 RID: 57557 RVA: 0x00506958 File Offset: 0x00504B58
	private void NNFMIAFHMJM()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().AAMNKPHHHCI().DOLKFPIABDD())
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.PFECOLHJNIM(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.JHEFABODNPO().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[5], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[2], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[6], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[3], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[25], 6, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Object ID. Case-Sensitive", 1722f, null);
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "\r")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_Near", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("Mouse ", 0, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("[Singleton] multiple instances of '", 198f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("restrictions\n\n#until: ", 50f, null);
		}
	}

	// Token: 0x0600E0D6 RID: 57558 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int DCDDFEHJBNO(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0D7 RID: 57559 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int NBEGHEOCMIO(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0D8 RID: 57560 RVA: 0x00506C08 File Offset: 0x00504E08
	public int HFKKBJFPABL()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 0)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.DBMFINNHKGA);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "[MapsData] Found ";
				}
				text = "_Value" + text.Remove(text.Length - 1, 1) + "inventory.selected.";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("_ScreenResolution" + this.currentCombo[1].ToString() + "Error: Timeout :S");
		}
		return -1;
	}

	// Token: 0x0600E0D9 RID: 57561 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int DBMFINNHKGA(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0DA RID: 57562 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase EICAMMJELIE()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0DB RID: 57563 RVA: 0x00506D44 File Offset: 0x00504F44
	private void Update()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = false;
			this.MOFDJECEOBO = false;
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[5]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[3]) || hardInput.GetKey(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[0]) || hardInput.GetKey(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[2]) || hardInput.GetKey(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.Update();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.playerBase.RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E0DC RID: 57564 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase NODPGAOEHGL()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0DD RID: 57565 RVA: 0x00507074 File Offset: 0x00505274
	private void HJPCJGOEKMF()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().EOOCGIFFKBG().isMine)
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.BGGJDCJGFFN(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[0], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[3], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[-59], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_TimeX", 1665f, null);
			if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_Saturation")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack/Blend2Camera_ColorBurn", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.CMAFBKOEPLP("skin.", 0, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("_ScreenResolution", 1543f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Loading inventory", 155f, null);
		}
	}

	// Token: 0x0600E0DE RID: 57566 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool PAGJGFIGBNJ()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0DF RID: 57567 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int ICBKBIOCAKL(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0E0 RID: 57568 RVA: 0x005053D6 File Offset: 0x005035D6
	public void GFAAIOBADNN(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E0E1 RID: 57569 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase CCBCAICCJLD()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0E2 RID: 57570 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase JHEFABODNPO()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0E3 RID: 57571 RVA: 0x00507324 File Offset: 0x00505524
	private GameObject LOKEFJGIFNK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1307f, 1461f, 1025f);
		Vector3 b2 = new Vector3(1309f, 294f, 992f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(32f, 1034f, 1613f);
		}
		if (this.ACODLKJMCJF == 3)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1794f, 815f, 1004f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(1166f, 1164f, 1307f);
			}
			if (HMPOIDIAIMI == 5)
			{
				b2 = new Vector3(1123f, 1151f, 32f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 175f;
			b.y = 1790f;
		}
		if (FLMFNIGKHKP == 2)
		{
			b.x = 0f;
			b.y = 1995f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 1192f;
			b.y = 131f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 747f;
			b.y = 1137f;
		}
		bool flag = FLMFNIGKHKP == 99;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.EICAMMJELIE().transform.position + b + b2, this.ODHBANOIMPN().transform.TransformDirection(Vector3.back), out raycastHit, 733f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DFLDMFKFBPC().transform.position + b + b2, this.DFLDMFKFBPC().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 909f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.NFANBIICAFM().transform.position + b + b2, this.NLIGEMDBEOA().transform.TransformDirection(Vector3.back) * 1490f, Color.white, 922f);
		return null;
	}

	// Token: 0x0600E0E4 RID: 57572 RVA: 0x00507568 File Offset: 0x00505768
	private void FOLDLDLFFLM()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[5]) || hardInput.GetKey(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[0]) || hardInput.GetKey(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[2]) || hardInput.GetKey(this.PIHEMHOGGPL[5]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.HLDFOJMHKNL();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.EICAMMJELIE().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E0E5 RID: 57573 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool MJADKEGNKAC()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0E6 RID: 57574 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase NLIGEMDBEOA()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0E7 RID: 57575 RVA: 0x005053D3 File Offset: 0x005035D3
	[CompilerGenerated]
	private static int OAEFKCKJNHC(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0E8 RID: 57576 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool MAKFPOGABLH()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0E9 RID: 57577 RVA: 0x005053D6 File Offset: 0x005035D6
	public void OFMKPIFJNOA(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E0EA RID: 57578 RVA: 0x00507898 File Offset: 0x00505A98
	private void LCHBFNIPBHB()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[7]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.GPFJMKCGHGB();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.JJPEGCHJJED().HJAHIPPLLDJ(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E0EB RID: 57579 RVA: 0x00507BC8 File Offset: 0x00505DC8
	private void IDJKNBDKHBD()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().OELHGNKAMEG().isMine)
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.NMCKPDLLBBG(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.JJPEGCHJJED().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[6], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[2], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[7], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[6], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[5], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[-70], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("#newhighscore", 1950f, null);
			if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "[MapEditor] Updating map assets")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.ANECPPFPKAP("_ScreenResolution", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.GetInt("_Source", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH(",", 134f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Keeping GameObject in the scene: ", 1564f, null);
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x0600E10C RID: 57612 RVA: 0x00504B7F File Offset: 0x00502D7F
	// (set) Token: 0x0600E0EC RID: 57580 RVA: 0x005053D6 File Offset: 0x005035D6
	[HideInInspector]
	public PlayerBase playerBase
	{
		get
		{
			if (this.HFNAKOHHIAF != null)
			{
				return this.HFNAKOHHIAF;
			}
			return base.GetComponentInParent<PlayerBase>();
		}
		set
		{
			this.HFNAKOHHIAF = value;
		}
	}

	// Token: 0x0600E0ED RID: 57581 RVA: 0x00507E78 File Offset: 0x00506078
	private void JECMJNFGBGC()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().EDIJKHEMPAD().isMine)
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.OFMKPIFJNOA(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DGNIAONOGKK().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[2], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[4], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[2], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[7], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[6], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[7], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[125], 3, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("[LocalizationService] All languages: ", 517f, null);
			if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "D-Pad Up")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.GetInt(":", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_Value3", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("_ScreenResolution", 1500f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("float,1.5", 1339f, null);
		}
	}

	// Token: 0x0600E0EE RID: 57582 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int GDMDCLGAFIK(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0EF RID: 57583 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase DMFKOAIAHDC()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0F0 RID: 57584 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int NLLEPGKCAFH(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0F1 RID: 57585 RVA: 0x00508128 File Offset: 0x00506328
	private GameObject BPECFHECJCK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1688f, 919f, 981f);
		Vector3 b2 = new Vector3(1523f, 161f, 1661f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(1736f, 1371f, 206f);
		}
		if (this.ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1564f, 1431f, 253f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1770f, 1602f, 833f);
			}
			if (HMPOIDIAIMI == 6)
			{
				b2 = new Vector3(1824f, 947f, 956f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1744f;
			b.y = 1101f;
		}
		if (FLMFNIGKHKP == 4)
		{
			b.x = 1926f;
			b.y = 1899f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 1779f;
			b.y = 1530f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 733f;
			b.y = 860f;
		}
		bool flag = FLMFNIGKHKP != -114;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.HBDLLAKOFKJ().transform.position + b + b2, this.ODHBANOIMPN().transform.TransformDirection(Vector3.back), out raycastHit, 198f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.NODPGAOEHGL().transform.position + b + b2, this.JJPEGCHJJED().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 629f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.ODHBANOIMPN().transform.position + b + b2, this.DFLDMFKFBPC().transform.TransformDirection(Vector3.back) * 277f, Color.white, 1563f);
		return null;
	}

	// Token: 0x0600E0F2 RID: 57586 RVA: 0x0050836C File Offset: 0x0050656C
	private void JBMBNKOOENB()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = true;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[6]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[4]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.OIBMHPIFAKK();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.NLIGEMDBEOA().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E0F3 RID: 57587 RVA: 0x0050869C File Offset: 0x0050689C
	public void DPOCLHCABII(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.PACECPHKLNE() == "float,0" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = this.AKBLLMJBONI(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.DGNIAONOGKK().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.DMFKOAIAHDC().photonView.KCAOJFPDEIP())
					{
						PhotonView photonView = this.NODPGAOEHGL().photonView;
						string lblkdnnpaco = "setbool";
						PhotonTargets mpnmoonbmii = PhotonTargets.Others;
						object[] array = new object[0];
						array[1] = false;
						photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.NFANBIICAFM();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.EICAMMJELIE().currentCombo = 0;
					if (this.JDHHBDEAEID && this.DNOKKLIKLAM().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(2, UnityEngine.Random.Range(543f, 1024f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "ArcsDestroyDelaySlider")
				{
					PlayerBase playerBase2 = this.DFLDMFKFBPC();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(388f - this.FNEPAIOLEOD) > 838.0) ? (523f - this.FNEPAIOLEOD) : 1602f;
						float max = 1561f + this.FNEPAIOLEOD;
						if (num <= 1576f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.NODPGAOEHGL().GBMJAPGLMGB().IKIJDNPJKPM("FinalScoreText", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 373f) + 1896f;
					if (num3 > 348f)
					{
						num3 = 358f;
					}
					if (num3 < 1925f)
					{
						num3 = 1713f;
					}
					float num4 = (num3 >= 523f) ? 745f : ((1647f - num3) * num2 * num2);
					if (num3 >= 201f)
					{
						PlayerBase playerBase3 = this.playerBase;
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.EICAMMJELIE();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.playerBase;
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.DFLDMFKFBPC();
					playerBase6.comboScore += (float)this.DNOKKLIKLAM().currentCombo;
					PlayerBase playerBase7 = this.KEFGHEIOHON();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.NODPGAOEHGL();
					playerBase8.accuracyScore += (num3 - this.NLIGEMDBEOA().accuracyScore) / (float)(this.PELOCGBHJFO().incorrectScore + this.JHEFABODNPO().correctScore);
					if (this.JDHHBDEAEID && this.NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(285f - this.FNEPAIOLEOD) > 1810.0) ? (1915f - this.FNEPAIOLEOD) : 1373f;
						float max2 = 510f + this.FNEPAIOLEOD;
						if (num3 >= 101f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.JHEFABODNPO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 790f * ((664f - this.OMGIMLPPNFI) * 791f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -74 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E0F4 RID: 57588 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool NJCKDLBJAGD()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0F5 RID: 57589 RVA: 0x00508B50 File Offset: 0x00506D50
	private void LIBGAKMKHJJ()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().CIACEFBNDDJ().BGJKMGJBPFA())
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.KJFEMNPENDO(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.NODPGAOEHGL().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[2], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[3], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[7], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[-89], 4, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("_MainTex2", 1758f, null);
			if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "_TimeX")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_TimeX", 1, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.GetInt("challenges.", 0, null) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Far", 1894f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Value", 1412f, null);
		}
	}

	// Token: 0x0600E0F6 RID: 57590 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool GLIGAKBIBPA()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0F7 RID: 57591 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int DICBHLDJAOH(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E0F8 RID: 57592 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool MPJDIKBOGEL()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0F9 RID: 57593 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool NEGHFGAOPAJ()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0FA RID: 57594 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool PJBOPNEOFIC()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0FB RID: 57595 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase ODHBANOIMPN()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0FC RID: 57596 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool KIGGFMAPEGJ()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E0FD RID: 57597 RVA: 0x00508E00 File Offset: 0x00507000
	private GameObject IHPLCFKOBND(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(314f, 158f, 1151f);
		Vector3 b2 = new Vector3(1301f, 1555f, 1923f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(134f, 1859f, 1300f);
		}
		if (this.ACODLKJMCJF == 0)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1445f, 203f, 725f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(381f, 897f, 144f);
			}
			if (HMPOIDIAIMI == 5)
			{
				b2 = new Vector3(688f, 1971f, 1f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 411f;
			b.y = 16f;
		}
		if (FLMFNIGKHKP == 2)
		{
			b.x = 581f;
			b.y = 845f;
		}
		if (FLMFNIGKHKP == 3)
		{
			b.x = 1176f;
			b.y = 1941f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 761f;
			b.y = 469f;
		}
		bool flag = FLMFNIGKHKP != -99;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.DGNIAONOGKK().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back), out raycastHit, 31f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.ODHBANOIMPN().transform.position + b + b2, this.DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1762f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.EICAMMJELIE().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back) * 61f, Color.white, 530f);
		return null;
	}

	// Token: 0x0600E0FE RID: 57598 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase JJPEGCHJJED()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E0FF RID: 57599 RVA: 0x00509044 File Offset: 0x00507244
	public void HPBPJKFHMCD(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.CFADADIIOAM() == "OxOD.lastPath" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = this.IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.playerBase.GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.NFANBIICAFM().GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = this.CCBCAICCJLD().EOOCGIFFKBG();
						string lblkdnnpaco = " [";
						PhotonTargets mpnmoonbmii = (PhotonTargets)7;
						object[] array = new object[1];
						array[1] = false;
						photonView.RPC(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.JJPEGCHJJED();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.JJPEGCHJJED().currentCombo = 0;
					if (this.JDHHBDEAEID && this.KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(3, UnityEngine.Random.Range(183f, 1070f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "/")
				{
					PlayerBase playerBase2 = this.EICAMMJELIE();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1330f - this.FNEPAIOLEOD) > 1433.0) ? (1317f - this.FNEPAIOLEOD) : 1836f;
						float max = 1292f + this.FNEPAIOLEOD;
						if (num <= 751f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.NODPGAOEHGL().OELHGNKAMEG().MIAHMDGOOPJ("note.3", PhotonTargets.All, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1897f) + 1262f;
					if (num3 > 1118f)
					{
						num3 = 1188f;
					}
					if (num3 < 1586f)
					{
						num3 = 793f;
					}
					float num4 = (num3 >= 347f) ? 319f : ((1666f - num3) * num2 * num2);
					if (num3 >= 302f)
					{
						PlayerBase playerBase3 = this.NFANBIICAFM();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.JJPEGCHJJED();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.playerBase;
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.NODPGAOEHGL();
					playerBase6.comboScore += (float)this.DMFKOAIAHDC().currentCombo;
					PlayerBase playerBase7 = this.CCBCAICCJLD();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.ODHBANOIMPN();
					playerBase8.accuracyScore += (num3 - this.playerBase.accuracyScore) / (float)(this.DNOKKLIKLAM().incorrectScore + this.CCBCAICCJLD().correctScore);
					if (this.JDHHBDEAEID && this.NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(1367f - this.FNEPAIOLEOD) > 130.0) ? (1192f - this.FNEPAIOLEOD) : 1686f;
						float max2 = 818f + this.FNEPAIOLEOD;
						if (num3 >= 72f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.JHEFABODNPO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1795f * ((121f - this.OMGIMLPPNFI) * 330f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 116 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E100 RID: 57600 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool IKKFHBNDNEG()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E101 RID: 57601 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool HKFGAHHOCLI()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E102 RID: 57602 RVA: 0x005094F8 File Offset: 0x005076F8
	public int BODCFCGDMDA()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.PNBKEIFHAAN);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "View";
				}
				text = "_TimeX" + text.Remove(text.Length - 1, 1) + "(scene)";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Can't set visible when not in that room." + this.currentCombo[0].ToString() + "Set sun min/max size");
		}
		return -1;
	}

	// Token: 0x0600E103 RID: 57603 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int CMALDOOPBEB(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E104 RID: 57604 RVA: 0x00509634 File Offset: 0x00507834
	private GameObject BHNJNLOHFLC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(182f, 1733f, 1730f);
		Vector3 b2 = new Vector3(1375f, 1034f, 618f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(317f, 1872f, 146f);
		}
		if (this.ACODLKJMCJF == 7)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(485f, 302f, 524f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1145f, 229f, 1682f);
			}
			if (HMPOIDIAIMI == 3)
			{
				b2 = new Vector3(733f, 1534f, 460f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1605f;
			b.y = 266f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1655f;
			b.y = 520f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 962f;
			b.y = 1732f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 177f;
			b.y = 176f;
		}
		bool flag = FLMFNIGKHKP != 76;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.KEFGHEIOHON().transform.position + b + b2, this.ODHBANOIMPN().transform.TransformDirection(Vector3.back), out raycastHit, 1216f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DGNIAONOGKK().transform.position + b + b2, this.HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1035f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.DFLDMFKFBPC().transform.position + b + b2, this.HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * 118f, Color.white, 1105f);
		return null;
	}

	// Token: 0x0600E105 RID: 57605 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase HBDLLAKOFKJ()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E106 RID: 57606 RVA: 0x00509878 File Offset: 0x00507A78
	private GameObject IFKKCGODNIE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1325f, 1903f, 711f);
		Vector3 b2 = new Vector3(445f, 258f, 1675f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(1638f, 1714f, 987f);
		}
		if (this.ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1889f, 419f, 658f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(1043f, 1780f, 972f);
			}
			if (HMPOIDIAIMI == 8)
			{
				b2 = new Vector3(731f, 1989f, 1360f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1887f;
			b.y = 871f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 416f;
			b.y = 1591f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 1109f;
			b.y = 455f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1554f;
			b.y = 1103f;
		}
		bool flag = FLMFNIGKHKP != 10;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.KEFGHEIOHON().transform.position + b + b2, this.DNOKKLIKLAM().transform.TransformDirection(Vector3.back), out raycastHit, 922f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.CCBCAICCJLD().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1426f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.KEFGHEIOHON().transform.position + b + b2, this.HBDLLAKOFKJ().transform.TransformDirection(Vector3.back) * 1155f, Color.white, 740f);
		return null;
	}

	// Token: 0x0600E107 RID: 57607 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int LBCCOLFINCB(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E108 RID: 57608 RVA: 0x00509ABC File Offset: 0x00507CBC
	private void BMIOFJFMCBG()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().EDIJKHEMPAD().KCAOJFPDEIP())
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.PMIIAMPLFNI(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DNOKKLIKLAM().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[7], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[3], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[2], 7, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[1], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[7], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[-16], 3, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.MFNCMBBPJPA(" not exist", 717f, null);
			if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "CameraFilterPack_Atmosphere_Rain_FX")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_FresnelFadePower", 1, null) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("<b>#", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("{0:0} day{1}, ", 757f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 72f, null);
		}
	}

	// Token: 0x0600E109 RID: 57609 RVA: 0x00509D6C File Offset: 0x00507F6C
	private void FJHFOBHJEHL()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = true;
			if (hardInput.GetKey(this.PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[0]) || hardInput.GetKey(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[2]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.Update();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.DMFKOAIAHDC().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E10A RID: 57610 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int NFHBMNGNOIH(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E10B RID: 57611 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase DFLDMFKFBPC()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E10D RID: 57613 RVA: 0x0050A09C File Offset: 0x0050829C
	private void FOMNCPKKCFN()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = true;
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[8]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[4]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.GPFJMKCGHGB();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.ODHBANOIMPN().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E10E RID: 57614 RVA: 0x0050A3CC File Offset: 0x005085CC
	public void BHMNLMFCJLE(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "SpectatingUserInfo" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = this.DMCMLADEEEK(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.NLIGEMDBEOA().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.playerBase.AAMNKPHHHCI().DOLKFPIABDD())
					{
						this.DFLDMFKFBPC().GMAHNPNHMFK().MIAHMDGOOPJ("Editor/", PhotonTargets.AllBuffered, new object[]
						{
							false
						});
					}
				}
				else
				{
					PlayerBase playerBase = this.DNOKKLIKLAM();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.NFANBIICAFM().currentCombo = 1;
					if (this.JDHHBDEAEID && this.JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(1041f, 259f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "\n")
				{
					PlayerBase playerBase2 = this.NODPGAOEHGL();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.HBDLLAKOFKJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1167f - this.FNEPAIOLEOD) > 347.0) ? (1737f - this.FNEPAIOLEOD) : 1617f;
						float max = 1331f + this.FNEPAIOLEOD;
						if (num <= 1447f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.CCBCAICCJLD().GBMJAPGLMGB().MIAHMDGOOPJ("time", PhotonTargets.AllBufferedViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1420f) + 113f;
					if (num3 > 1884f)
					{
						num3 = 1025f;
					}
					if (num3 < 1037f)
					{
						num3 = 1198f;
					}
					float num4 = (num3 >= 904f) ? 737f : ((377f - num3) * num2 * num2);
					if (num3 >= 966f)
					{
						PlayerBase playerBase3 = this.CCBCAICCJLD();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.KEFGHEIOHON();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.HBDLLAKOFKJ();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.DMFKOAIAHDC();
					playerBase6.comboScore += (float)this.JHEFABODNPO().currentCombo;
					PlayerBase playerBase7 = this.NFANBIICAFM();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.ODHBANOIMPN();
					playerBase8.accuracyScore += (num3 - this.DNOKKLIKLAM().accuracyScore) / (float)(this.DMFKOAIAHDC().incorrectScore + this.JJPEGCHJJED().correctScore);
					if (this.JDHHBDEAEID && this.EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(1956f - this.FNEPAIOLEOD) > 785.0) ? (1866f - this.FNEPAIOLEOD) : 1359f;
						float max2 = 1009f + this.FNEPAIOLEOD;
						if (num3 >= 1682f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.DFLDMFKFBPC().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1458f * ((459f - this.OMGIMLPPNFI) * 1885f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -128 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E10F RID: 57615 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool DFDJCONLKPA()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E110 RID: 57616 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool NJKBNLLLJCI()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E111 RID: 57617 RVA: 0x005053D6 File Offset: 0x005035D6
	public void LCKNOFOLFNL(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E112 RID: 57618 RVA: 0x005053D6 File Offset: 0x005035D6
	public void BGGJDCJGFFN(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E113 RID: 57619 RVA: 0x0050A880 File Offset: 0x00508A80
	private void FABKIGNFECE()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[5]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.MAOCOEGAFND();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.NLIGEMDBEOA().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E114 RID: 57620 RVA: 0x0050ABB0 File Offset: 0x00508DB0
	public int ALKGJEEHEBN()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.CMALDOOPBEB);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "_Value";
				}
				text = "_DotSize" + text.Remove(text.Length - 1, 0) + "icon.png";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Can't do manual instantiation without PhotonView component." + this.currentCombo[1].ToString() + "CameraFilterPack/Distortion_Twist_Square");
		}
		return -1;
	}

	// Token: 0x0600E115 RID: 57621 RVA: 0x0050ACEC File Offset: 0x00508EEC
	private void KDMANOEMOCA()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().BLMHOKPIMOD().DOLKFPIABDD())
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.GFAAIOBADNN(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.KEFGHEIOHON().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[6], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[3], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[7], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[2], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[5], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[6], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[48], 7, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("/", 1728f, null);
			if (Singleton<Scene>.Instance.BDJMLNLIIMB() == "_TimeX")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.GetInt("Connection error: ", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.ANECPPFPKAP("Joystick1Button0", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.AKHCHNPPNIB("VIGNETTE_DESAT", 1724f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OJHPDDLNAGH("Tab1Content", 278f, null);
		}
	}

	// Token: 0x0600E116 RID: 57622 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool CDFOGOEFHIF()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E117 RID: 57623 RVA: 0x0050AF9C File Offset: 0x0050919C
	public void PPJDDKHHDMP(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "ScreenResolutionPanel" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.AGGPFPNKMFC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.JHEFABODNPO().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.NLIGEMDBEOA().AAMNKPHHHCI().KCAOJFPDEIP())
					{
						PhotonView photonView = this.DGNIAONOGKK().photonView;
						string lblkdnnpaco = "EventSystem";
						PhotonTargets mpnmoonbmii = (PhotonTargets)8;
						object[] array = new object[0];
						array[0] = true;
						photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.NLIGEMDBEOA();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.EICAMMJELIE().currentCombo = 0;
					if (this.JDHHBDEAEID && this.EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(7, UnityEngine.Random.Range(1546f, 1967f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "UI")
				{
					PlayerBase playerBase2 = this.ODHBANOIMPN();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.HBDLLAKOFKJ().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(475f - this.FNEPAIOLEOD) > 1083.0) ? (1599f - this.FNEPAIOLEOD) : 305f;
						float max = 1979f + this.FNEPAIOLEOD;
						if (num <= 653f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.ODHBANOIMPN().GMAHNPNHMFK().MIAHMDGOOPJ("error", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 777f) + 1632f;
					if (num3 > 842f)
					{
						num3 = 1090f;
					}
					if (num3 < 87f)
					{
						num3 = 1583f;
					}
					float num4 = (num3 >= 964f) ? 1550f : ((183f - num3) * num2 * num2);
					if (num3 >= 1702f)
					{
						PlayerBase playerBase3 = this.NODPGAOEHGL();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.DFLDMFKFBPC();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.JJPEGCHJJED();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.DMFKOAIAHDC();
					playerBase6.comboScore += (float)this.DMFKOAIAHDC().currentCombo;
					PlayerBase playerBase7 = this.JHEFABODNPO();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.PELOCGBHJFO();
					playerBase8.accuracyScore += (num3 - this.CCBCAICCJLD().accuracyScore) / (float)(this.DGNIAONOGKK().incorrectScore + this.KEFGHEIOHON().correctScore);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(719f - this.FNEPAIOLEOD) > 1297.0) ? (941f - this.FNEPAIOLEOD) : 259f;
						float max2 = 705f + this.FNEPAIOLEOD;
						if (num3 >= 1649f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.DNOKKLIKLAM().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1934f * ((1808f - this.OMGIMLPPNFI) * 773f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 73 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E118 RID: 57624 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool JMEGFBEDAML()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E119 RID: 57625 RVA: 0x005053D6 File Offset: 0x005035D6
	public void OADIPGANJAM(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E11A RID: 57626 RVA: 0x0050B450 File Offset: 0x00509650
	public void AEDJKCPNEOC(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "#done" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.NFANBIICAFM().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.playerBase.EOOCGIFFKBG().BGJKMGJBPFA())
					{
						PhotonView photonView = this.DGNIAONOGKK().EOOCGIFFKBG();
						string lblkdnnpaco = "Brightness";
						PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
						object[] array = new object[0];
						array[1] = true;
						photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.PELOCGBHJFO();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.DFLDMFKFBPC().currentCombo = 1;
					if (this.JDHHBDEAEID && this.NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(6, UnityEngine.Random.Range(1954f, 1707f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Hex value #RRGGBB")
				{
					PlayerBase playerBase2 = this.KEFGHEIOHON();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1629f - this.FNEPAIOLEOD) > 878.0) ? (1950f - this.FNEPAIOLEOD) : 710f;
						float max = 181f + this.FNEPAIOLEOD;
						if (num <= 1854f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.HBDLLAKOFKJ().FFIPLLNKGEN().MIAHMDGOOPJ("12", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1584f) + 632f;
					if (num3 > 1902f)
					{
						num3 = 1430f;
					}
					if (num3 < 577f)
					{
						num3 = 156f;
					}
					float num4 = (num3 >= 1880f) ? 340f : ((1793f - num3) * num2 * num2);
					if (num3 >= 905f)
					{
						PlayerBase playerBase3 = this.NFANBIICAFM();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.playerBase;
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.NLIGEMDBEOA();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.playerBase;
					playerBase6.comboScore += (float)this.PELOCGBHJFO().currentCombo;
					PlayerBase playerBase7 = this.NFANBIICAFM();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.ODHBANOIMPN();
					playerBase8.accuracyScore += (num3 - this.JHEFABODNPO().accuracyScore) / (float)(this.KEFGHEIOHON().incorrectScore + this.HBDLLAKOFKJ().correctScore);
					if (this.JDHHBDEAEID && this.DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(907f - this.FNEPAIOLEOD) > 1805.0) ? (206f - this.FNEPAIOLEOD) : 334f;
						float max2 = 1834f + this.FNEPAIOLEOD;
						if (num3 >= 462f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.PELOCGBHJFO().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 78f * ((1647f - this.OMGIMLPPNFI) * 1327f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.MFDJLFOJAMF(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -78 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E11B RID: 57627 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int PNBKEIFHAAN(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E11C RID: 57628 RVA: 0x0050B904 File Offset: 0x00509B04
	private void POIMNOBDBBN()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = true;
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[2]) || hardInput.GetKey(this.PIHEMHOGGPL[0]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = true;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.JNBPKNNBMDI();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.NLIGEMDBEOA().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E11D RID: 57629 RVA: 0x0050BC34 File Offset: 0x00509E34
	private void KCDOMIJBFLL()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[5]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[2]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.GPFJMKCGHGB();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.DMFKOAIAHDC().RecordAction(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E11E RID: 57630 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase KEFGHEIOHON()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E11F RID: 57631 RVA: 0x0050BF64 File Offset: 0x0050A164
	private GameObject NKCPIGFJILI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1539f, 1798f, 386f);
		Vector3 b2 = new Vector3(1555f, 1979f, 1386f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(1594f, 1316f, 531f);
		}
		if (this.ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1769f, 80f, 718f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(324f, 1248f, 1332f);
			}
			if (HMPOIDIAIMI == 7)
			{
				b2 = new Vector3(82f, 1142f, 1109f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 621f;
			b.y = 225f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 1996f;
			b.y = 429f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 1575f;
			b.y = 1780f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1713f;
			b.y = 1873f;
		}
		bool flag = FLMFNIGKHKP != -53;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.CCBCAICCJLD().transform.position + b + b2, this.EICAMMJELIE().transform.TransformDirection(Vector3.back), out raycastHit, 262f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.JHEFABODNPO().transform.position + b + b2, this.PELOCGBHJFO().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 94f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.DNOKKLIKLAM().transform.position + b + b2, this.NODPGAOEHGL().transform.TransformDirection(Vector3.back) * 1072f, Color.white, 73f);
		return null;
	}

	// Token: 0x0600E120 RID: 57632 RVA: 0x0050C1A8 File Offset: 0x0050A3A8
	private void NBGIMIDICKE()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().GBMJAPGLMGB().BGJKMGJBPFA())
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.OADIPGANJAM(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)6, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[3], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[6], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[0], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[8], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[3], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[-34], 0, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(". Possible scene loading in progress?", 1248f, null);
			if (Singleton<Scene>.Instance.KHDLEJLPGKP() == ".lastCheckpoint.time")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_EmissionColor", 0, null) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && Singleton<SaveSystem>.Instance.ANECPPFPKAP("st", 1, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Item ", 770f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.AKHCHNPPNIB(" method: ", 1505f, null);
		}
	}

	// Token: 0x0600E121 RID: 57633 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase NFANBIICAFM()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E122 RID: 57634 RVA: 0x0050C458 File Offset: 0x0050A658
	private GameObject NDNFOGNNKOF(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1835f, 1019f, 1173f);
		Vector3 b2 = new Vector3(319f, 652f, 1609f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(931f, 317f, 175f);
		}
		if (this.ACODLKJMCJF == 5)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(725f, 314f, 1816f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1323f, 1992f, 1768f);
			}
			if (HMPOIDIAIMI == 4)
			{
				b2 = new Vector3(841f, 1440f, 129f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1822f;
			b.y = 674f;
		}
		if (FLMFNIGKHKP == 3)
		{
			b.x = 1211f;
			b.y = 231f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 261f;
			b.y = 732f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 100f;
			b.y = 1770f;
		}
		bool flag = FLMFNIGKHKP != 33;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.DFLDMFKFBPC().transform.position + b + b2, this.ODHBANOIMPN().transform.TransformDirection(Vector3.back), out raycastHit, 1977f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.NLIGEMDBEOA().transform.position + b + b2, this.CCBCAICCJLD().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 40f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.CCBCAICCJLD().transform.position + b + b2, this.JJPEGCHJJED().transform.TransformDirection(Vector3.back) * 1438f, Color.white, 1286f);
		return null;
	}

	// Token: 0x0600E123 RID: 57635 RVA: 0x0050C69C File Offset: 0x0050A89C
	public void NLPAHKLGJMK(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.JOAAANFJKIC() == "_PColor2" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.EICAMMJELIE().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.HBDLLAKOFKJ().EOOCGIFFKBG().DOLKFPIABDD())
					{
						PhotonView photonView = this.NFANBIICAFM().FFIPLLNKGEN();
						string lblkdnnpaco = "Start Color's hex value #RRGGBBAA";
						PhotonTargets mpnmoonbmii = (PhotonTargets)7;
						object[] array = new object[0];
						array[1] = false;
						photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.NODPGAOEHGL();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.JHEFABODNPO().currentCombo = 0;
					if (this.JDHHBDEAEID && this.KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(8f, 1429f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "[MapEditor] Openning ")
				{
					PlayerBase playerBase2 = this.DGNIAONOGKK();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.PELOCGBHJFO().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(559f - this.FNEPAIOLEOD) > 361.0) ? (1423f - this.FNEPAIOLEOD) : 763f;
						float max = 759f + this.FNEPAIOLEOD;
						if (num <= 142f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.JJPEGCHJJED().EOOCGIFFKBG().KEKKFNNMLMG("_Value", (PhotonTargets)7, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 131f) + 223f;
					if (num3 > 256f)
					{
						num3 = 203f;
					}
					if (num3 < 573f)
					{
						num3 = 1322f;
					}
					float num4 = (num3 >= 722f) ? 1309f : ((593f - num3) * num2 * num2);
					if (num3 >= 1759f)
					{
						PlayerBase playerBase3 = this.NODPGAOEHGL();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.CCBCAICCJLD();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.DNOKKLIKLAM();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.EICAMMJELIE();
					playerBase6.comboScore += (float)this.JJPEGCHJJED().currentCombo;
					PlayerBase playerBase7 = this.HBDLLAKOFKJ();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.CCBCAICCJLD();
					playerBase8.accuracyScore += (num3 - this.EICAMMJELIE().accuracyScore) / (float)(this.playerBase.incorrectScore + this.JJPEGCHJJED().correctScore);
					if (this.JDHHBDEAEID && this.NLIGEMDBEOA().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(753f - this.FNEPAIOLEOD) > 112.0) ? (1529f - this.FNEPAIOLEOD) : 624f;
						float max2 = 1384f + this.FNEPAIOLEOD;
						if (num3 >= 160f)
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.NLIGEMDBEOA().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 800f * ((1187f - this.OMGIMLPPNFI) * 136f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -114 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E124 RID: 57636 RVA: 0x0050CB50 File Offset: 0x0050AD50
	private void AEOLJEIDMDB()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().CIACEFBNDDJ().KCAOJFPDEIP())
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.NFDDPIGLDBG(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DFLDMFKFBPC().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[3], 8, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[2], 7, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[5], 7, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[-46], 8, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_Value13", 1498f, null);
			if (Singleton<Scene>.Instance.HLGJHICPDMO() == "FullscreenToggle")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_Value2", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Value3", 0, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("0.00", 14f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("Object ID. Case-Sensitive", 829f, null);
		}
	}

	// Token: 0x0600E125 RID: 57637 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int DLFAILMGMEL(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E126 RID: 57638 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int FEFLEOCHEDN(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E127 RID: 57639 RVA: 0x0050CE00 File Offset: 0x0050B000
	private void ANCKKLFPGDI()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().BLMHOKPIMOD().BGJKMGJBPFA())
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.GFAAIOBADNN(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.HBDLLAKOFKJ().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[4], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[3], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[1], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[5], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[51], 6, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Set Satellite Sensitivity", 795f, null);
			if (Singleton<Scene>.Instance.JOAAANFJKIC() == "_TimeX")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.ANECPPFPKAP("DPADHOR", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.CEKEOJDAEOD("<b>(╯°□°）╯︵ ┻━┻</b>", 0, null) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("Keypad", 982f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("Item invalid. No idea why.", 86f, null);
		}
	}

	// Token: 0x0600E128 RID: 57640 RVA: 0x0050D0B0 File Offset: 0x0050B2B0
	public void POFBCEKBIDH(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "_RampOffset" && ((GameScene)Singleton<Scene>.Instance).FJGOEKJIPFD())
			{
				return;
			}
			GameObject gameObject = this.AKBLLMJBONI(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.NLIGEMDBEOA().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.NODPGAOEHGL().JAEJDHHCJJO().isMine)
					{
						PhotonView photonView = this.HBDLLAKOFKJ().GMAHNPNHMFK();
						string lblkdnnpaco = "PublishButton";
						PhotonTargets mpnmoonbmii = PhotonTargets.AllViaServer;
						object[] array = new object[1];
						array[1] = true;
						photonView.MIAHMDGOOPJ(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.DMFKOAIAHDC();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.PELOCGBHJFO().currentCombo = 1;
					if (this.JDHHBDEAEID && this.JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(5, UnityEngine.Random.Range(1242f, 1369f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_MainTex2")
				{
					PlayerBase playerBase2 = this.JJPEGCHJJED();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.KEFGHEIOHON().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1152f - this.FNEPAIOLEOD) > 1152.0) ? (1646f - this.FNEPAIOLEOD) : 1112f;
						float max = 1285f + this.FNEPAIOLEOD;
						if (num <= 749f)
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.JJPEGCHJJED().GBHNDHLAJLI().RPC("Case-Sensitive", PhotonTargets.OthersBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 623f) + 1973f;
					if (num3 > 1672f)
					{
						num3 = 113f;
					}
					if (num3 < 1008f)
					{
						num3 = 39f;
					}
					float num4 = (num3 >= 240f) ? 855f : ((1449f - num3) * num2 * num2);
					if (num3 >= 684f)
					{
						PlayerBase playerBase3 = this.DGNIAONOGKK();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.DNOKKLIKLAM();
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.NFANBIICAFM();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.ODHBANOIMPN();
					playerBase6.comboScore += (float)this.CCBCAICCJLD().currentCombo;
					PlayerBase playerBase7 = this.DGNIAONOGKK();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.CCBCAICCJLD();
					playerBase8.accuracyScore += (num3 - this.JJPEGCHJJED().accuracyScore) / (float)(this.PELOCGBHJFO().incorrectScore + this.DMFKOAIAHDC().correctScore);
					if (this.JDHHBDEAEID && this.JJPEGCHJJED().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(425f - this.FNEPAIOLEOD) > 767.0) ? (970f - this.FNEPAIOLEOD) : 1578f;
						float max2 = 1777f + this.FNEPAIOLEOD;
						if (num3 >= 365f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1062f * ((1673f - this.OMGIMLPPNFI) * 1686f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -30 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E129 RID: 57641 RVA: 0x0050D564 File Offset: 0x0050B764
	private void LCDJFJIBADI()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = false;
			this.MOFDJECEOBO = false;
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[2]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.MFMIODIAKNI();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.CCBCAICCJLD().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E12A RID: 57642 RVA: 0x0050D894 File Offset: 0x0050BA94
	public int PDKJFCMEIEE()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.CMALDOOPBEB);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "Mine";
				}
				text = "points:" + text.Remove(text.Length - 1, 1) + "_Value4";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 1)
		{
			return Helpers.patternsMap.IndexOf("MenuPlayButton" + this.currentCombo[0].ToString() + "catched: ");
		}
		return -1;
	}

	// Token: 0x0600E12B RID: 57643 RVA: 0x0050D9D0 File Offset: 0x0050BBD0
	private void BMOFEBKGLFI()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().GMAHNPNHMFK().isMine)
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.NMCKPDLLBBG(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.HBDLLAKOFKJ().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[4], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[8], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[7], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[7], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[-4], 5, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN(".workshop.json", 860f, null);
			if (Singleton<Scene>.Instance.ALIGPAANMFA() == "remaining: {0:0.000}")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.JPEEFKKPFIL("#onfirstranktext", 0, null) != 0 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax) && (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("_ScreenResolution", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("mapselector.filter.favoriteonly", 377f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("/", 1873f, null);
		}
	}

	// Token: 0x0600E12C RID: 57644 RVA: 0x0050DC80 File Offset: 0x0050BE80
	public void DBKJHNBJBKK(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "Blues" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = this.IHPLCFKOBND(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.JHEFABODNPO().GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.NLIGEMDBEOA().GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = this.DFLDMFKFBPC().FFIPLLNKGEN();
						string lblkdnnpaco = "_ConsoleSettings";
						PhotonTargets mpnmoonbmii = (PhotonTargets)8;
						object[] array = new object[0];
						array[0] = false;
						photonView.IKIJDNPJKPM(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.DMFKOAIAHDC();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.DGNIAONOGKK().currentCombo = 0;
					if (this.JDHHBDEAEID && this.JHEFABODNPO().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(5, UnityEngine.Random.Range(1986f, 5f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "The process failed: ")
				{
					PlayerBase playerBase2 = this.playerBase;
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1304f - this.FNEPAIOLEOD) > 109.0) ? (660f - this.FNEPAIOLEOD) : 1211f;
						float max = 1735f + this.FNEPAIOLEOD;
						if (num <= 1249f)
						{
							SoundManager.HAPJJNMDBCO(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.EICAMMJELIE().OELHGNKAMEG().RPC("[LocalizationService] Loading file: ", (PhotonTargets)7, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1644f) + 664f;
					if (num3 > 835f)
					{
						num3 = 575f;
					}
					if (num3 < 777f)
					{
						num3 = 1972f;
					}
					float num4 = (num3 >= 1335f) ? 760f : ((1848f - num3) * num2 * num2);
					if (num3 >= 685f)
					{
						PlayerBase playerBase3 = this.JHEFABODNPO();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.playerBase;
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.JJPEGCHJJED();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.HBDLLAKOFKJ();
					playerBase6.comboScore += (float)this.NLIGEMDBEOA().currentCombo;
					PlayerBase playerBase7 = this.DMFKOAIAHDC();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.NFANBIICAFM();
					playerBase8.accuracyScore += (num3 - this.HBDLLAKOFKJ().accuracyScore) / (float)(this.playerBase.incorrectScore + this.ODHBANOIMPN().correctScore);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(886f - this.FNEPAIOLEOD) > 1945.0) ? (19f - this.FNEPAIOLEOD) : 135f;
						float max2 = 610f + this.FNEPAIOLEOD;
						if (num3 >= 14f)
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.KEFGHEIOHON().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = true;
				gameObject.GetComponent<IncreseAlpha>().time = 1586f * ((1163f - this.OMGIMLPPNFI) * 1235f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -70 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E12D RID: 57645 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool ODEEHAOHJBK()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E12E RID: 57646 RVA: 0x0050E134 File Offset: 0x0050C334
	private void EIDKCANPHJE()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = false;
			this.MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[3]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[8]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[0]) || hardInput.GetKey(this.PIHEMHOGGPL[2]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[6]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[5]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.GPFJMKCGHGB();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.NFANBIICAFM().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E12F RID: 57647 RVA: 0x005053D6 File Offset: 0x005035D6
	public void KJFEMNPENDO(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E130 RID: 57648 RVA: 0x0050E464 File Offset: 0x0050C664
	private void MFMIODIAKNI()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = false;
			this.BDKICAKJKKJ = true;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = true;
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[6]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[5]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = true;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[1]) || hardInput.GetKey(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.LMBDNPLDGIJ();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.DMFKOAIAHDC().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E131 RID: 57649 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool JJGHPHBHAIN()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E132 RID: 57650 RVA: 0x0050E794 File Offset: 0x0050C994
	private GameObject KJFGMJFMEFO(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(0f, 0f, 16f);
		Vector3 b2 = new Vector3(0f, 0f, 0f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(0f, 0f, 0f);
		}
		if (this.ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(0f, 0f, 0f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(-20f, 0f, 0f);
			}
			if (HMPOIDIAIMI == 2)
			{
				b2 = new Vector3(20f, 0f, 0f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 0f;
			b.y = 1.5f;
		}
		if (FLMFNIGKHKP == 2)
		{
			b.x = 0f;
			b.y = -1.5f;
		}
		if (FLMFNIGKHKP == 3)
		{
			b.x = -1.5f;
			b.y = 0f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1.5f;
			b.y = 0f;
		}
		bool flag = FLMFNIGKHKP != 9;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.playerBase.transform.position + b + b2, this.playerBase.transform.TransformDirection(Vector3.back), out raycastHit, 30f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.playerBase.transform.position + b + b2, this.playerBase.transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.playerBase.transform.position + b + b2, this.playerBase.transform.TransformDirection(Vector3.back) * 30f, Color.white, 1f);
		return null;
	}

	// Token: 0x0600E133 RID: 57651 RVA: 0x0050E9D8 File Offset: 0x0050CBD8
	public int GetCombo()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 0)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.OAEFKCKJNHC);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "-";
				}
				text = "[" + text.Remove(text.Length - 1, 1) + "]";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("[" + this.currentCombo[0].ToString() + "]");
		}
		return -1;
	}

	// Token: 0x0600E134 RID: 57652 RVA: 0x005053D6 File Offset: 0x005035D6
	public void PMIIAMPLFNI(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E135 RID: 57653 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool HBGNCIPPOOL()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E136 RID: 57654 RVA: 0x0050EB14 File Offset: 0x0050CD14
	private void KOJKBFDNGDK()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().AAMNKPHHHCI().BGJKMGJBPFA())
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.PMIIAMPLFNI(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DGNIAONOGKK().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[3], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)8, this.PIHEMHOGGPL[4], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[2], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[7], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[0], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[0], 5, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[-101], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("Set satellite trail width", 240f, null);
			if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "ArcsNoHitsoundTimeDelaySlider")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack/TV_WideScreenCircle", 1, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("PointsScoreText", 1, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("_Value4", 793f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.MFNCMBBPJPA("DifficultyBG", 1558f, null);
		}
	}

	// Token: 0x0600E137 RID: 57655 RVA: 0x0050EDC4 File Offset: 0x0050CFC4
	public int FPFBFHALAJD()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 0)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.FEFLEOCHEDN);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "_MaxBlurRadius";
				}
				text = "PhotonNetwork error: Could not Instantiate the prefab [" + text.Remove(text.Length - 1, 1) + "_CenterRadius";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("Bad parameters for getbool! Use <key> <value>" + this.currentCombo[0].ToString() + "GhostFade2");
		}
		return -1;
	}

	// Token: 0x0600E138 RID: 57656 RVA: 0x0050EF00 File Offset: 0x0050D100
	private void HMPGIFBJFIK()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().JAEJDHHCJJO().isMine)
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = true;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.GFAAIOBADNN(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.DFLDMFKFBPC().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)5, this.PIHEMHOGGPL[4], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[3], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[3], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[6], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[5], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler((PlayerController.Direction)7, this.PIHEMHOGGPL[-126], 4, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.DHFOFEJPGPP(" with a prefix of ", 1152f, null);
			if (Singleton<Scene>.Instance.KCGOFGJNCME() == "LevelNameInputField")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_EmissionGain", 0, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.JPEEFKKPFIL("[ItemsHandler] Inventory has changed", 0, null) != 1 || ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Normal);
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("_BokehParams", 119f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("*.workshop.json", 865f, null);
		}
	}

	// Token: 0x0600E139 RID: 57657 RVA: 0x0050F1B0 File Offset: 0x0050D3B0
	private GameObject HMMNKKFLIIE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(994f, 1677f, 101f);
		Vector3 b2 = new Vector3(1676f, 254f, 414f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(664f, 1506f, 63f);
		}
		if (this.ACODLKJMCJF == 4)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(208f, 1194f, 1068f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(179f, 1226f, 682f);
			}
			if (HMPOIDIAIMI == 8)
			{
				b2 = new Vector3(1764f, 1755f, 1425f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 456f;
			b.y = 692f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 717f;
			b.y = 100f;
		}
		if (FLMFNIGKHKP == 6)
		{
			b.x = 776f;
			b.y = 964f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 867f;
			b.y = 1432f;
		}
		bool flag = FLMFNIGKHKP != 61;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.ODHBANOIMPN().transform.position + b + b2, this.CCBCAICCJLD().transform.TransformDirection(Vector3.back), out raycastHit, 264f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.playerBase.transform.position + b + b2, this.JJPEGCHJJED().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 875f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.NODPGAOEHGL().transform.position + b + b2, this.EICAMMJELIE().transform.TransformDirection(Vector3.back) * 40f, Color.white, 623f);
		return null;
	}

	// Token: 0x0600E13A RID: 57658 RVA: 0x0050F3F4 File Offset: 0x0050D5F4
	public void CheckCombo(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.id == "GameScene" && ((GameScene)Singleton<Scene>.Instance).AllPlayersFinished())
			{
				return;
			}
			GameObject gameObject = this.KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.playerBase.GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.playerBase.photonView.isMine)
					{
						this.playerBase.photonView.RPC("LostLive", PhotonTargets.AllBuffered, new object[]
						{
							true
						});
					}
				}
				else
				{
					PlayerBase playerBase = this.playerBase;
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.playerBase.currentCombo = 0;
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(0.7f, 1.3f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "PowerUp")
				{
					PlayerBase playerBase2 = this.playerBase;
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(1f - this.FNEPAIOLEOD) > 0.5) ? (1f - this.FNEPAIOLEOD) : 0.5f;
						float max = 1f + this.FNEPAIOLEOD;
						if (num <= 2.5f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.playerBase.photonView.RPC("GetLive", PhotonTargets.AllBuffered, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 64f) + 1.04f;
					if (num3 > 1f)
					{
						num3 = 1f;
					}
					if (num3 < 0f)
					{
						num3 = 0f;
					}
					float num4 = (num3 >= 1f) ? 0f : ((1f - num3) * num2 * num2);
					if (num3 >= 0.75f)
					{
						PlayerBase playerBase3 = this.playerBase;
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.playerBase;
						playerBase4.currentCombo++;
					}
					PlayerBase playerBase5 = this.playerBase;
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.playerBase;
					playerBase6.comboScore += (float)this.playerBase.currentCombo;
					PlayerBase playerBase7 = this.playerBase;
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.playerBase;
					playerBase8.accuracyScore += (num3 - this.playerBase.accuracyScore) / (float)(this.playerBase.incorrectScore + this.playerBase.correctScore);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(1f - this.FNEPAIOLEOD) > 0.5) ? (1f - this.FNEPAIOLEOD) : 0.5f;
						float max2 = 1f + this.FNEPAIOLEOD;
						if (num3 >= 0.75f)
						{
							SoundManager.PlayHitSfx(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PlayHitSfx(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.playerBase.UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 10f * ((0.4f - this.OMGIMLPPNFI) * 2f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != 9 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E13B RID: 57659 RVA: 0x0050F8A8 File Offset: 0x0050DAA8
	public int KNBOIOEKJID()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.DICBHLDJAOH);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "/";
				}
				text = "input" + text.Remove(text.Length - 0, 1) + "_Value";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("icon.png" + this.currentCombo[1].ToString() + "health");
		}
		return -1;
	}

	// Token: 0x0600E13C RID: 57660 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool FKMLHDHIOJA()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E13D RID: 57661 RVA: 0x0050F9E4 File Offset: 0x0050DBE4
	private GameObject GANPPIKGDDE(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1738f, 948f, 1708f);
		Vector3 b2 = new Vector3(1974f, 450f, 110f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(118f, 499f, 1765f);
		}
		if (this.ACODLKJMCJF == 0)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(530f, 231f, 1405f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(913f, 341f, 1853f);
			}
			if (HMPOIDIAIMI == 4)
			{
				b2 = new Vector3(88f, 1439f, 1322f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 703f;
			b.y = 355f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 1620f;
			b.y = 976f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 470f;
			b.y = 840f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1921f;
			b.y = 614f;
		}
		bool flag = FLMFNIGKHKP == -79;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.ODHBANOIMPN().transform.position + b + b2, this.CCBCAICCJLD().transform.TransformDirection(Vector3.back), out raycastHit, 681f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DMFKOAIAHDC().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1217f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.JJPEGCHJJED().transform.position + b + b2, this.DNOKKLIKLAM().transform.TransformDirection(Vector3.back) * 1128f, Color.white, 678f);
		return null;
	}

	// Token: 0x0600E13E RID: 57662 RVA: 0x0050FC28 File Offset: 0x0050DE28
	public int MHMBDPMDDAC()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 1)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.DICBHLDJAOH);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "_Value3";
				}
				text = "hidden" + text.Remove(text.Length - 0, 0) + "SetParticlesInput";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf("maps." + this.currentCombo[0].ToString() + "x");
		}
		return -1;
	}

	// Token: 0x0600E140 RID: 57664 RVA: 0x0050FE74 File Offset: 0x0050E074
	private GameObject HNLBLLNALJC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1930f, 1496f, 562f);
		Vector3 b2 = new Vector3(589f, 1679f, 1818f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(293f, 111f, 1662f);
		}
		if (this.ACODLKJMCJF == 7)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(249f, 1332f, 248f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(1484f, 493f, 1112f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(83f, 1261f, 165f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 218f;
			b.y = 1025f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 969f;
			b.y = 1388f;
		}
		if (FLMFNIGKHKP == 3)
		{
			b.x = 1348f;
			b.y = 224f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1911f;
			b.y = 411f;
		}
		bool flag = FLMFNIGKHKP == -79;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.playerBase.transform.position + b + b2, this.DNOKKLIKLAM().transform.TransformDirection(Vector3.back), out raycastHit, 1030f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DGNIAONOGKK().transform.position + b + b2, this.JJPEGCHJJED().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 810f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.DNOKKLIKLAM().transform.position + b + b2, this.PELOCGBHJFO().transform.TransformDirection(Vector3.back) * 1232f, Color.white, 991f);
		return null;
	}

	// Token: 0x0600E141 RID: 57665 RVA: 0x005053D6 File Offset: 0x005035D6
	public void PFECOLHJNIM(PlayerBase DPNHODJHGJL)
	{
		this.HFNAKOHHIAF = DPNHODJHGJL;
	}

	// Token: 0x0600E142 RID: 57666 RVA: 0x005100B8 File Offset: 0x0050E2B8
	public void NBMHHGHIHDJ(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "Joystick1Button2" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.KJFGMJFMEFO(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.JHEFABODNPO().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.JHEFABODNPO().GMAHNPNHMFK().DOLKFPIABDD())
					{
						PhotonView photonView = this.PELOCGBHJFO().JAEJDHHCJJO();
						string lblkdnnpaco = "_Value";
						PhotonTargets mpnmoonbmii = (PhotonTargets)8;
						object[] array = new object[0];
						array[0] = false;
						photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.NODPGAOEHGL();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.playerBase.currentCombo = 0;
					if (this.JDHHBDEAEID && this.DFLDMFKFBPC().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(8, UnityEngine.Random.Range(149f, 418f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "_MainTex2")
				{
					PlayerBase playerBase2 = this.NLIGEMDBEOA();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(505f - this.FNEPAIOLEOD) > 1154.0) ? (1351f - this.FNEPAIOLEOD) : 43f;
						float max = 226f + this.FNEPAIOLEOD;
						if (num <= 1736f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.playerBase.photonView.KEKKFNNMLMG("[SoundManager] Loaded skin audio", (PhotonTargets)8, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1122f) + 1590f;
					if (num3 > 1333f)
					{
						num3 = 1933f;
					}
					if (num3 < 448f)
					{
						num3 = 1060f;
					}
					float num4 = (num3 >= 614f) ? 1964f : ((1189f - num3) * num2 * num2);
					if (num3 >= 1084f)
					{
						PlayerBase playerBase3 = this.DNOKKLIKLAM();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.DFLDMFKFBPC();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.NFANBIICAFM();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.EICAMMJELIE();
					playerBase6.comboScore += (float)this.playerBase.currentCombo;
					PlayerBase playerBase7 = this.playerBase;
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.DNOKKLIKLAM();
					playerBase8.accuracyScore += (num3 - this.ODHBANOIMPN().accuracyScore) / (float)(this.DFLDMFKFBPC().incorrectScore + this.playerBase.correctScore);
					if (this.JDHHBDEAEID && this.NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(413f - this.FNEPAIOLEOD) > 980.0) ? (1390f - this.FNEPAIOLEOD) : 307f;
						float max2 = 573f + this.FNEPAIOLEOD;
						if (num3 >= 959f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.NFANBIICAFM().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1747f * ((1582f - this.OMGIMLPPNFI) * 470f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -73 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E143 RID: 57667 RVA: 0x0051056C File Offset: 0x0050E76C
	public void LNAOENCHKGI(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_TimeX" && ((GameScene)Singleton<Scene>.Instance).GDNMAFDLPHN())
			{
				return;
			}
			GameObject gameObject = this.NDNFOGNNKOF(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.DMFKOAIAHDC().DCLNDDJJJMA().gameMode != GameScene.GameMode.Relax)
				{
					if (this.DNOKKLIKLAM().IBKCMBIGOEJ().isMine)
					{
						this.NFANBIICAFM().GMAHNPNHMFK().IKIJDNPJKPM("SetPosition", PhotonTargets.OthersBuffered, new object[]
						{
							true
						});
					}
				}
				else
				{
					PlayerBase playerBase = this.DNOKKLIKLAM();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.EICAMMJELIE().currentCombo = 0;
					if (this.JDHHBDEAEID && this.EICAMMJELIE().GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.HAPJJNMDBCO(3, UnityEngine.Random.Range(1774f, 1032f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "Please wait..")
				{
					PlayerBase playerBase2 = this.KEFGHEIOHON();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.NODPGAOEHGL().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(510f - this.FNEPAIOLEOD) > 1560.0) ? (127f - this.FNEPAIOLEOD) : 364f;
						float max = 244f + this.FNEPAIOLEOD;
						if (num <= 623f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min, max));
						}
					}
					this.playerBase.CIACEFBNDDJ().PBMFBOOALKA("Sequence contains no elements", PhotonTargets.MasterClient, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1341f) + 300f;
					if (num3 > 817f)
					{
						num3 = 999f;
					}
					if (num3 < 231f)
					{
						num3 = 1807f;
					}
					float num4 = (num3 >= 1480f) ? 739f : ((969f - num3) * num2 * num2);
					if (num3 >= 1997f)
					{
						PlayerBase playerBase3 = this.CCBCAICCJLD();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.NLIGEMDBEOA();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.CCBCAICCJLD();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.DGNIAONOGKK();
					playerBase6.comboScore += (float)this.JJPEGCHJJED().currentCombo;
					PlayerBase playerBase7 = this.ODHBANOIMPN();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.NODPGAOEHGL();
					playerBase8.accuracyScore += (num3 - this.NFANBIICAFM().accuracyScore) / (float)(this.CCBCAICCJLD().incorrectScore + this.NFANBIICAFM().correctScore);
					if (this.JDHHBDEAEID && this.NFANBIICAFM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(731f - this.FNEPAIOLEOD) > 1865.0) ? (896f - this.FNEPAIOLEOD) : 915f;
						float max2 = 328f + this.FNEPAIOLEOD;
						if (num3 >= 1532f)
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.NLIGEMDBEOA().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = true;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1425f * ((504f - this.OMGIMLPPNFI) * 826f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.despawnAfterDelay(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -117 && FLMFNIGKHKP >= 1)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E144 RID: 57668 RVA: 0x00510A20 File Offset: 0x0050EC20
	private void Start()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().photonView.isMine)
			{
				this.isSpectator = true;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = false;
			}
			else
			{
				this.playerBase = base.GetComponentInParent<PlayerBase>();
				this.ACODLKJMCJF = this.playerBase.fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[1], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[2], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[3], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[4], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[5], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[6], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[7], 2, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[8], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[9], 2, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.GetFloat("settings.cameramovements", 1f, null);
			if (Singleton<Scene>.Instance.id == "GameScene")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0, null) == 1 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("settings.hitvariation", 0.25f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.GetFloat("settings.arcsdestroydelay", 0.1f, null);
		}
	}

	// Token: 0x0600E145 RID: 57669 RVA: 0x00510CD0 File Offset: 0x0050EED0
	private void GNCIOPKPLLA()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = true;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = false;
			this.MOFDJECEOBO = false;
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[1]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[5]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = true;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[1]) || hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[6]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[6]) || hardInput.GetKey(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.Update();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.JHEFABODNPO().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0600E146 RID: 57670 RVA: 0x00511000 File Offset: 0x0050F200
	private void EGEPLFGKGLI()
	{
		if (!this.isRecording)
		{
			if (base.GetComponentInParent<PlayerBase>() && !base.GetComponentInParent<PlayerBase>().GBMJAPGLMGB().DOLKFPIABDD())
			{
				this.isSpectator = false;
				base.GetComponentInChildren<Camera>().enabled = false;
				base.GetComponentInChildren<AudioListener>().enabled = true;
			}
			else
			{
				this.PFECOLHJNIM(base.GetComponentInParent<PlayerBase>());
				this.ACODLKJMCJF = this.EICAMMJELIE().fullLevelData.mapData.handCount;
			}
		}
		this.keys.Clear();
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[8], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Down, this.PIHEMHOGGPL[2], 0, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[0], 6, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Right, this.PIHEMHOGGPL[2], 4, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[0], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Left, this.PIHEMHOGGPL[5], 3, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.PowerUp, this.PIHEMHOGGPL[7], 1, this));
		this.keys.Add(new PlayerControllerKeyHandler(PlayerController.Direction.Up, this.PIHEMHOGGPL[88], 1, this));
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = base.transform.localPosition;
			this.AJPABMEPCDO = Singleton<SaveSystem>.Instance.NPNOOLFEDKN("SetSpeed", 979f, null);
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "Please wait..")
			{
				this.JDHHBDEAEID = ((Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Luminance", 1, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("/", 0, null) == 0 && ((GameScene)Singleton<Scene>.Instance).gameMode == GameScene.GameMode.Relax));
			}
			this.FNEPAIOLEOD = Singleton<SaveSystem>.Instance.GetFloat("shader.frost", 1408f, null);
			this.OMGIMLPPNFI = Singleton<SaveSystem>.Instance.OLHIEOKMOAK("CameraFilterPack/FX_Dot_Circle", 1004f, null);
		}
	}

	// Token: 0x0600E147 RID: 57671 RVA: 0x005112B0 File Offset: 0x0050F4B0
	private GameObject FMOHBPMDAOK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(456f, 255f, 66f);
		Vector3 b2 = new Vector3(1042f, 1346f, 1074f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(1952f, 572f, 132f);
		}
		if (this.ACODLKJMCJF == 8)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1401f, 20f, 132f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(4f, 1557f, 133f);
			}
			if (HMPOIDIAIMI == 5)
			{
				b2 = new Vector3(1818f, 1583f, 1106f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1212f;
			b.y = 520f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 1330f;
			b.y = 418f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 1177f;
			b.y = 1073f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 277f;
			b.y = 1109f;
		}
		bool flag = FLMFNIGKHKP != -40;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.NFANBIICAFM().transform.position + b + b2, this.HBDLLAKOFKJ().transform.TransformDirection(Vector3.back), out raycastHit, 132f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.NODPGAOEHGL().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 440f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.DNOKKLIKLAM().transform.position + b + b2, this.JHEFABODNPO().transform.TransformDirection(Vector3.back) * 1472f, Color.white, 692f);
		return null;
	}

	// Token: 0x0600E148 RID: 57672 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int IBIJNHEMBOO(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E149 RID: 57673 RVA: 0x005114F4 File Offset: 0x0050F6F4
	private GameObject DJHFDCLPHLF(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(269f, 306f, 136f);
		Vector3 b2 = new Vector3(1584f, 1382f, 948f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(269f, 1853f, 992f);
		}
		if (this.ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(685f, 1307f, 921f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1154f, 39f, 1114f);
			}
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(141f, 1212f, 1449f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 533f;
			b.y = 372f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 285f;
			b.y = 1339f;
		}
		if (FLMFNIGKHKP == 3)
		{
			b.x = 1108f;
			b.y = 613f;
		}
		if (FLMFNIGKHKP == 1)
		{
			b.x = 1355f;
			b.y = 1964f;
		}
		bool flag = FLMFNIGKHKP != -92;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.NFANBIICAFM().transform.position + b + b2, this.NFANBIICAFM().transform.TransformDirection(Vector3.back), out raycastHit, 1294f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.PELOCGBHJFO().transform.position + b + b2, this.NODPGAOEHGL().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 1508f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.PELOCGBHJFO().transform.position + b + b2, this.KEFGHEIOHON().transform.TransformDirection(Vector3.back) * 1748f, Color.white, 1566f);
		return null;
	}

	// Token: 0x0600E14A RID: 57674 RVA: 0x00511738 File Offset: 0x0050F938
	public void OGACJDOPABH(int FLMFNIGKHKP, int HMPOIDIAIMI, float NPAFFMIFMCD = -1f)
	{
		if (!this.isRecording)
		{
			if (Singleton<Scene>.Instance.EODGDBPONOL() == "_RgbDepthTex" && ((GameScene)Singleton<Scene>.Instance).KFFHJFIJHIC())
			{
				return;
			}
			GameObject gameObject = this.BHNJNLOHFLC(FLMFNIGKHKP, HMPOIDIAIMI);
			if (!gameObject)
			{
				if (this.loseOnWrongKey && this.playerBase.GetGameScene().gameMode != GameScene.GameMode.Relax)
				{
					if (this.DMFKOAIAHDC().EOOCGIFFKBG().isMine)
					{
						PhotonView photonView = this.DMFKOAIAHDC().BLMHOKPIMOD();
						string lblkdnnpaco = "warning: Audio Source: ";
						PhotonTargets mpnmoonbmii = (PhotonTargets)7;
						object[] array = new object[0];
						array[1] = true;
						photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array);
					}
				}
				else
				{
					PlayerBase playerBase = this.CCBCAICCJLD();
					playerBase.incorrectScore = ++playerBase.incorrectScore;
					this.CCBCAICCJLD().currentCombo = 0;
					if (this.JDHHBDEAEID && this.playerBase.GetComponentInChildren<AudioListener>().enabled)
					{
						SoundManager.PNOOHLGKOFH(6, UnityEngine.Random.Range(830f, 737f));
					}
				}
			}
			else
			{
				if (gameObject.tag == "CameraFilterPack/Real_VHS")
				{
					PlayerBase playerBase2 = this.JHEFABODNPO();
					playerBase2.powerupsScore = ++playerBase2.powerupsScore;
					float num = Mathf.Abs(gameObject.transform.localPosition.z);
					if (this.JDHHBDEAEID && this.DGNIAONOGKK().GetComponentInChildren<AudioListener>().enabled)
					{
						float min = ((double)(40f - this.FNEPAIOLEOD) > 1347.0) ? (1625f - this.FNEPAIOLEOD) : 632f;
						float max = 1826f + this.FNEPAIOLEOD;
						if (num <= 1925f)
						{
							SoundManager.FCNBLDODPKG(1, UnityEngine.Random.Range(min, max));
						}
						else
						{
							SoundManager.HAPJJNMDBCO(0, UnityEngine.Random.Range(min, max));
						}
					}
					this.DGNIAONOGKK().BLMHOKPIMOD().RPC("roomDescription", PhotonTargets.AllViaServer, null);
				}
				else
				{
					float num2 = Mathf.Abs(gameObject.transform.localPosition.z);
					float num3 = -(num2 * num2 / 1520f) + 1640f;
					if (num3 > 1784f)
					{
						num3 = 475f;
					}
					if (num3 < 137f)
					{
						num3 = 32f;
					}
					float num4 = (num3 >= 1238f) ? 1808f : ((921f - num3) * num2 * num2);
					if (num3 >= 1697f)
					{
						PlayerBase playerBase3 = this.DGNIAONOGKK();
						playerBase3.perfectHits = ++playerBase3.perfectHits;
						PlayerBase playerBase4 = this.JHEFABODNPO();
						playerBase4.currentCombo += 0;
					}
					PlayerBase playerBase5 = this.DNOKKLIKLAM();
					playerBase5.correctScore = ++playerBase5.correctScore;
					PlayerBase playerBase6 = this.NODPGAOEHGL();
					playerBase6.comboScore += (float)this.PELOCGBHJFO().currentCombo;
					PlayerBase playerBase7 = this.NLIGEMDBEOA();
					playerBase7.penaltyScore += num4;
					PlayerBase playerBase8 = this.NLIGEMDBEOA();
					playerBase8.accuracyScore += (num3 - this.playerBase.accuracyScore) / (float)(this.EICAMMJELIE().incorrectScore + this.DNOKKLIKLAM().correctScore);
					if (this.JDHHBDEAEID && this.DNOKKLIKLAM().GetComponentInChildren<AudioListener>().enabled)
					{
						float min2 = ((double)(823f - this.FNEPAIOLEOD) > 1602.0) ? (1761f - this.FNEPAIOLEOD) : 1101f;
						float max2 = 1988f + this.FNEPAIOLEOD;
						if (num3 >= 600f)
						{
							SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(min2, max2));
						}
						else
						{
							SoundManager.FCNBLDODPKG(0, UnityEngine.Random.Range(min2, max2));
						}
					}
					this.NODPGAOEHGL().UpdateComboTimer(num2);
				}
				gameObject.GetComponent<MoveF>().enabled = false;
				gameObject.GetComponent<Collider>().enabled = false;
				gameObject.GetComponent<IncreseAlpha>().time = 1858f * ((488f - this.OMGIMLPPNFI) * 1432f);
				gameObject.GetComponent<SegmentHandler>().onDestroy.Invoke();
				TrashMan.CGKHFEPBDMH(gameObject, this.OMGIMLPPNFI);
			}
		}
		else if (Singleton<MapEditor>.Instance.isRecording && FLMFNIGKHKP != -104 && FLMFNIGKHKP >= 0)
		{
			Singleton<MapEditor>.Instance.AddRecordedEventGO(Helpers.patternsMap[FLMFNIGKHKP], HMPOIDIAIMI, NPAFFMIFMCD);
		}
		this.currentCombo.Clear();
	}

	// Token: 0x0600E14B RID: 57675 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool EENNMLHLCDF()
	{
		return this.JDHHBDEAEID;
	}

	// Token: 0x0600E14C RID: 57676 RVA: 0x005053D3 File Offset: 0x005035D3
	private static int LKJEPINPFLC(PlayerController.Direction HPHENPOHOMK)
	{
		return (int)HPHENPOHOMK;
	}

	// Token: 0x0600E14D RID: 57677 RVA: 0x00511BEC File Offset: 0x0050FDEC
	private GameObject DMCMLADEEEK(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(244f, 1494f, 1112f);
		Vector3 b2 = new Vector3(331f, 977f, 173f);
		if (this.ACODLKJMCJF == 1)
		{
			b2 = new Vector3(750f, 393f, 372f);
		}
		if (this.ACODLKJMCJF == 6)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(491f, 1890f, 619f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(1846f, 1623f, 191f);
			}
			if (HMPOIDIAIMI == 4)
			{
				b2 = new Vector3(373f, 1398f, 1105f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1505f;
			b.y = 903f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 72f;
			b.y = 1457f;
		}
		if (FLMFNIGKHKP == 5)
		{
			b.x = 988f;
			b.y = 1071f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1455f;
			b.y = 1416f;
		}
		bool flag = FLMFNIGKHKP == -92;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.NLIGEMDBEOA().transform.position + b + b2, this.JJPEGCHJJED().transform.TransformDirection(Vector3.back), out raycastHit, 156f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.NFANBIICAFM().transform.position + b + b2, this.KEFGHEIOHON().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 24f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.NODPGAOEHGL().transform.position + b + b2, this.DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * 1450f, Color.white, 126f);
		return null;
	}

	// Token: 0x0600E14E RID: 57678 RVA: 0x00511E30 File Offset: 0x00510030
	private GameObject GCPCLMIKIMI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		Vector3 b = new Vector3(1281f, 1003f, 706f);
		Vector3 b2 = new Vector3(1937f, 1866f, 1031f);
		if (this.ACODLKJMCJF == 0)
		{
			b2 = new Vector3(1816f, 497f, 1830f);
		}
		if (this.ACODLKJMCJF == 2)
		{
			if (HMPOIDIAIMI == 0)
			{
				b2 = new Vector3(1646f, 252f, 13f);
			}
			if (HMPOIDIAIMI == 1)
			{
				b2 = new Vector3(666f, 1719f, 1869f);
			}
			if (HMPOIDIAIMI == 7)
			{
				b2 = new Vector3(182f, 1784f, 1184f);
			}
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1890f;
			b.y = 148f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 379f;
			b.y = 733f;
		}
		if (FLMFNIGKHKP == 7)
		{
			b.x = 1489f;
			b.y = 1215f;
		}
		if (FLMFNIGKHKP == 0)
		{
			b.x = 1858f;
			b.y = 243f;
		}
		bool flag = FLMFNIGKHKP != -56;
		RaycastHit raycastHit;
		if (Physics.Raycast(this.HBDLLAKOFKJ().transform.position + b + b2, this.EICAMMJELIE().transform.TransformDirection(Vector3.back), out raycastHit, 413f, (!flag) ? this.powerupsLayerMask : this.arksLayerMask))
		{
			Debug.DrawRay(this.DMFKOAIAHDC().transform.position + b + b2, this.DMFKOAIAHDC().transform.TransformDirection(Vector3.back) * raycastHit.distance, Color.yellow, 615f);
			return raycastHit.collider.gameObject;
		}
		Debug.DrawRay(this.EICAMMJELIE().transform.position + b + b2, this.playerBase.transform.TransformDirection(Vector3.back) * 1022f, Color.white, 95f);
		return null;
	}

	// Token: 0x0600E14F RID: 57679 RVA: 0x00504B7F File Offset: 0x00502D7F
	public PlayerBase DNOKKLIKLAM()
	{
		if (this.HFNAKOHHIAF != null)
		{
			return this.HFNAKOHHIAF;
		}
		return base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600E150 RID: 57680 RVA: 0x00512074 File Offset: 0x00510274
	public int JPDMLANDOOI()
	{
		if (this.isRecording)
		{
			if (this.currentCombo.Count > 0)
			{
				IEnumerable<PlayerController.Direction> source = this.currentCombo;
				if (PlayerController.LNIJKGECNME == null)
				{
					PlayerController.LNIJKGECNME = new Func<PlayerController.Direction, int>(PlayerController.DCDDFEHJBNO);
				}
				this.currentCombo = source.OrderBy(PlayerController.LNIJKGECNME).ToList<PlayerController.Direction>();
				string text = string.Empty;
				foreach (PlayerController.Direction direction in this.currentCombo)
				{
					text = text + direction.ToString() + "maps.";
				}
				text = "_Blue_C" + text.Remove(text.Length - 0, 1) + "_BlurRadius4";
				return Helpers.patternsMap.IndexOf(text);
			}
		}
		else if (this.currentCombo.Count > 0)
		{
			return Helpers.patternsMap.IndexOf(" or player:" + this.currentCombo[0].ToString() + "plogs");
		}
		return -1;
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x0600E151 RID: 57681 RVA: 0x00504B77 File Offset: 0x00502D77
	public bool HitSounds
	{
		get
		{
			return this.JDHHBDEAEID;
		}
	}

	// Token: 0x0600E152 RID: 57682 RVA: 0x005121B0 File Offset: 0x005103B0
	private void ONMGIPAILOH()
	{
		if (!this.isRecording)
		{
			this.JDAPEMPBJKM = new Vector3(this.JDAPEMPBJKM.x, this.JDAPEMPBJKM.y, base.transform.localPosition.z);
			this.MPNMOONBMII = this.JDAPEMPBJKM;
			this.ABINANMGBCE = true;
			this.BDKICAKJKKJ = false;
			this.DGLOHIKKOBA = true;
			this.MOFDJECEOBO = true;
			if (hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[0]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x + this.delta.x * this.AJPABMEPCDO;
				this.ABINANMGBCE = false;
			}
			if (hardInput.GKLCHNPAEAL(this.PIHEMHOGGPL[5]) || hardInput.GetKey(this.PIHEMHOGGPL[7]))
			{
				this.MPNMOONBMII.x = this.MPNMOONBMII.x - this.delta.x * this.AJPABMEPCDO;
				this.BDKICAKJKKJ = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[0]) || hardInput.GetKey(this.PIHEMHOGGPL[8]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y + this.delta.y * this.AJPABMEPCDO;
				this.DGLOHIKKOBA = false;
			}
			if (hardInput.GetKey(this.PIHEMHOGGPL[8]) || hardInput.KFKHHOLEGOK(this.PIHEMHOGGPL[4]))
			{
				this.MPNMOONBMII.y = this.MPNMOONBMII.y - this.delta.y * this.AJPABMEPCDO;
				this.MOFDJECEOBO = false;
			}
			if ((this.ABINANMGBCE && this.BDKICAKJKKJ) || (this.DGLOHIKKOBA && this.MOFDJECEOBO))
			{
				this.MPNMOONBMII.z = this.MPNMOONBMII.z + this.delta.z * this.AJPABMEPCDO;
			}
			base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, this.MPNMOONBMII, Time.smoothDeltaTime * this.lerpSpeed);
		}
		if (!this.isSpectator)
		{
			foreach (PlayerControllerKeyHandler playerControllerKeyHandler in this.keys)
			{
				playerControllerKeyHandler.DPIPGGDNGHN();
			}
			if (!this.isRecording)
			{
				IEnumerator enumerator2 = Enum.GetValues(typeof(KeyCode)).GetEnumerator();
				try
				{
					while (enumerator2.MoveNext())
					{
						object obj = enumerator2.Current;
						KeyCode key = (KeyCode)obj;
						if (Input.GetKeyDown(key))
						{
							this.JJPEGCHJJED().ONOEOGGMDAP(key.ToString());
						}
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator2 as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
			}
		}
	}

	// Token: 0x0400195B RID: 6491
	public LayerMask arksLayerMask;

	// Token: 0x0400195C RID: 6492
	public LayerMask powerupsLayerMask;

	// Token: 0x0400195D RID: 6493
	public bool isRecording;

	// Token: 0x0400195E RID: 6494
	public bool isSpectator;

	// Token: 0x0400195F RID: 6495
	public List<GameObject> objects;

	// Token: 0x04001960 RID: 6496
	private Vector3 JDAPEMPBJKM;

	// Token: 0x04001961 RID: 6497
	public Vector3 delta = new Vector3(5f, 5f, 1f);

	// Token: 0x04001962 RID: 6498
	public float lerpSpeed = 5f;

	// Token: 0x04001963 RID: 6499
	public bool loseOnWrongKey = true;

	// Token: 0x04001964 RID: 6500
	public bool useComboSystem;

	// Token: 0x04001965 RID: 6501
	[HideInInspector]
	private List<string> PIHEMHOGGPL = new List<string>
	{
		"note.0",
		"note.1",
		"note.2",
		"note.3",
		"note.4",
		"note.5",
		"note.6",
		"note.7",
		"powerup.0",
		"powerup.1"
	};

	// Token: 0x04001966 RID: 6502
	[HideInInspector]
	public List<PlayerController.Direction> currentCombo;

	// Token: 0x04001967 RID: 6503
	public float currentComboTimeout = 0.15f;

	// Token: 0x04001968 RID: 6504
	[HideInInspector]
	public List<PlayerControllerKeyHandler> keys = new List<PlayerControllerKeyHandler>();

	// Token: 0x04001969 RID: 6505
	private float AJPABMEPCDO = 1f;

	// Token: 0x0400196A RID: 6506
	private bool JDHHBDEAEID = true;

	// Token: 0x0400196B RID: 6507
	private float OMGIMLPPNFI = 0.1f;

	// Token: 0x0400196C RID: 6508
	private PlayerBase HFNAKOHHIAF;

	// Token: 0x0400196D RID: 6509
	private float FNEPAIOLEOD = 0.5f;

	// Token: 0x0400196E RID: 6510
	private int ACODLKJMCJF = 1;

	// Token: 0x0400196F RID: 6511
	private Vector3 MPNMOONBMII = default(Vector3);

	// Token: 0x04001970 RID: 6512
	private bool ABINANMGBCE;

	// Token: 0x04001971 RID: 6513
	private bool BDKICAKJKKJ;

	// Token: 0x04001972 RID: 6514
	private bool DGLOHIKKOBA;

	// Token: 0x04001973 RID: 6515
	private bool MOFDJECEOBO;

	// Token: 0x04001974 RID: 6516
	[CompilerGenerated]
	private static Func<PlayerController.Direction, int> LNIJKGECNME;

	// Token: 0x020003DE RID: 990
	public enum Direction
	{
		// Token: 0x04001976 RID: 6518
		Up,
		// Token: 0x04001977 RID: 6519
		Right,
		// Token: 0x04001978 RID: 6520
		Down,
		// Token: 0x04001979 RID: 6521
		Left,
		// Token: 0x0400197A RID: 6522
		PowerUp
	}
}
