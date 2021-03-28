using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Photon;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

// Token: 0x020003D2 RID: 978
[Serializable]
public class PlayerBase : PunBehaviour
{
	// Token: 0x0600DD63 RID: 56675 RVA: 0x004E5164 File Offset: 0x004E3364
	private void DGIJAFGLGHC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 scale = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetScale(scale);
	}

	// Token: 0x0600DD64 RID: 56676 RVA: 0x004E51A8 File Offset: 0x004E33A8
	public void OINDBALDPDP(string DPNHODJHGJL)
	{
		foreach (CrosshairController crosshairController in this.crosshairsList)
		{
			crosshairController.LNEHFHIBAIO(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
		}
	}

	// Token: 0x0600DD65 RID: 56677 RVA: 0x004E5210 File Offset: 0x004E3410
	public void RunMapEvents()
	{
		bool flag = true;
		while (flag)
		{
			if (this.currentEventID < this.fullLevelData.mapData.events.Count && this.fullLevelData.mapData.events[this.currentEventID].time <= this.gameScene.HPAnimationTime)
			{
				this.currentEventID++;
				this.InvokeEvent(this.fullLevelData.mapData.events[this.currentEventID - 1].data[0], this.fullLevelData.mapData.events[this.currentEventID - 1].data[1]);
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
	}

	// Token: 0x0600DD66 RID: 56678 RVA: 0x004E52EC File Offset: 0x004E34EC
	public GameObject ABAIBAMGNDA(string HMGBJCGOLMI, string JMMILEFMACB)
	{
		GameObject gameObject = null;
		if (HMGBJCGOLMI.ToLower() == " not exist")
		{
			gameObject = this.sunGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "_Value")
		{
			gameObject = this.satelliteGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "#challengecomplete")
		{
			gameObject = this.particlesGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "CameraFilterPack/Blend2Camera_ColorKey")
		{
			gameObject = this.spriteGameObject;
		}
		if (gameObject)
		{
			GameObject gameObject2 = TrashMan.BGNBCDOHBNC(gameObject, this.environmentBase.transform.position, default(Quaternion));
			if (gameObject2 != null)
			{
				if (HMGBJCGOLMI.ToLower() == ".")
				{
					this.sunList.Add(gameObject2);
				}
				gameObject2.name = JMMILEFMACB;
				gameObject2.transform.SetParent(this.environmentBase.transform);
				gameObject2.GetComponent<EnvironmentController>().EMANBHKAONB();
				gameObject2.GetComponent<EnvironmentController>().BJIKAHNJNEB();
				if (this.environmentObjects.ContainsKey(JMMILEFMACB))
				{
					this.environmentObjects[JMMILEFMACB] = gameObject2;
				}
				else
				{
					this.environmentObjects.Add(JMMILEFMACB, gameObject2);
				}
				return gameObject2;
			}
		}
		return null;
	}

	// Token: 0x0600DD67 RID: 56679 RVA: 0x004E5429 File Offset: 0x004E3629
	public float GetLifesProgrees()
	{
		return Mathf.Clamp01((float)this.lives / (float)this.fullLevelData.mapData.maxLives);
	}

	// Token: 0x0600DD68 RID: 56680 RVA: 0x004E5449 File Offset: 0x004E3649
	public void SetSunEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD69 RID: 56681 RVA: 0x004E5461 File Offset: 0x004E3661
	public void OFONJJCJAGK(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().DNDDCKDKKHI(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD6A RID: 56682 RVA: 0x004E5479 File Offset: 0x004E3679
	[CompilerGenerated]
	private static void IIHKFKDIDDD(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(false);
	}

	// Token: 0x0600DD6B RID: 56683 RVA: 0x004E5482 File Offset: 0x004E3682
	public int LJBFCKKNPGN()
	{
		return this._lives;
	}

	// Token: 0x0600DD6C RID: 56684 RVA: 0x004E548F File Offset: 0x004E368F
	public void IEEIMEBECNG(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().NGANFKALCCB(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD6D RID: 56685 RVA: 0x004E54A7 File Offset: 0x004E36A7
	public void SetSatelliteRadius(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRadius(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD6E RID: 56686 RVA: 0x004E54C0 File Offset: 0x004E36C0
	[PunRPC]
	public void SetPlayerDistance(string HNDMDHJEEAB)
	{
		try
		{
			this.SetPlayerDistance(float.Parse(HNDMDHJEEAB, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetPlayerDistance error: " + ex.ToString());
		}
	}

	// Token: 0x0600DD6F RID: 56687 RVA: 0x004E5510 File Offset: 0x004E3710
	public void BIFANNFPPFF(float KEDDLFDAIDE)
	{
		this.moveFSpeed = -KEDDLFDAIDE;
	}

	// Token: 0x0600DD70 RID: 56688 RVA: 0x004E551A File Offset: 0x004E371A
	public void CHPKFAAAAPF(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().AGAOJLOEFHM(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD71 RID: 56689 RVA: 0x004E5534 File Offset: 0x004E3734
	public void ActivateEnvironment()
	{
		this.environmentBase.SetActive(true);
		foreach (TrailRenderer trailRenderer in this.environmentBase.transform.GetComponentsInChildren<TrailRenderer>())
		{
			trailRenderer.Clear();
		}
		if (this.crosshairsList.Count > 1)
		{
			this.crosshairsList[0].SetPosition(new Vector3(-20f, 0f, 0f));
			this.crosshairsList[1].SetPosition(new Vector3(20f, 0f, 0f));
		}
	}

	// Token: 0x0600DD72 RID: 56690 RVA: 0x004E55D8 File Offset: 0x004E37D8
	public void SetSunDirectionVector(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 directionVector = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetDirectionVector(directionVector);
	}

	// Token: 0x0600DD73 RID: 56691 RVA: 0x004E561C File Offset: 0x004E381C
	public IEnumerator ShowImage(Sprite IFGKDBEFCCA, int JOPCODOJBHD, bool NDJJNODFFAF, float EHHBHEJBHNG, float LJJHPMNLFAB = 0.2f, float FNBFCGGEBEI = 0.2f)
	{
		GameObject gameObject = null;
		if (JOPCODOJBHD == 0)
		{
			gameObject = this.bgLevelCanvas;
		}
		else if (JOPCODOJBHD == 1)
		{
			gameObject = this.gameScene.levelCanvas;
		}
		GameObject gameObject2 = TrashMan.spawn(this.levelCanvasImage, gameObject.transform.position, gameObject.transform.rotation);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		Image component = gameObject2.GetComponent<Image>();
		component.preserveAspect = NDJJNODFFAF;
		component.sprite = IFGKDBEFCCA;
		component.color = new Color(component.color.r, component.color.g, component.color.b, 0f);
		RectTransform component2 = gameObject2.GetComponent<RectTransform>();
		component2.anchorMin = new Vector2(0f, 0f);
		component2.anchorMax = new Vector2(1f, 1f);
		component2.pivot = new Vector2(0.5f, 0.5f);
		component2.sizeDelta = new Vector2(0f, 0f);
		component2.anchoredPosition3D = new Vector3(0f, 0f, 0f);
		if (this.fullLevelData.mapData.configVersion < 2)
		{
			yield return base.StartCoroutine(this.LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			yield return new WaitForSeconds(EHHBHEJBHNG);
			yield return base.StartCoroutine(this.LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
		}
		else
		{
			yield return base.StartCoroutine(this.LJDOOIBDHBF(component, 1f, LJJHPMNLFAB));
			if (EHHBHEJBHNG > 0f)
			{
				yield return new WaitForSeconds(EHHBHEJBHNG - LJJHPMNLFAB - FNBFCGGEBEI);
				yield return base.StartCoroutine(this.LJDOOIBDHBF(component, 0f, FNBFCGGEBEI));
			}
		}
		if (EHHBHEJBHNG > 0f)
		{
			TrashMan.despawn(gameObject2.gameObject);
		}
		yield return null;
		yield break;
	}

	// Token: 0x0600DD74 RID: 56692 RVA: 0x004E5482 File Offset: 0x004E3682
	public int NCBBBJINGMM()
	{
		return this._lives;
	}

	// Token: 0x0600DD75 RID: 56693 RVA: 0x004E5664 File Offset: 0x004E3864
	private void MIOEMMBCAOC(float AIEJPEPBAEJ)
	{
		this.currentArcsSpeed = -AIEJPEPBAEJ;
	}

	// Token: 0x0600DD76 RID: 56694 RVA: 0x004E566E File Offset: 0x004E386E
	private static void FJEGEDIPEGF(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(true);
	}

	// Token: 0x0600DD77 RID: 56695 RVA: 0x004E5677 File Offset: 0x004E3877
	public void AJJOMLBEIII(int BOAKOPHKGHC)
	{
		this._lives = BOAKOPHKGHC;
	}

	// Token: 0x0600DD78 RID: 56696 RVA: 0x004E5688 File Offset: 0x004E3888
	public bool CanResumeFromCheckpoint()
	{
		return this.gameScene.usingCheckpoints && Singleton<SaveSystem>.Instance.GetFloat(string.Concat(new string[]
		{
			"maps.",
			this.gameScene.mapID,
			".",
			this.gameScene.gameMode.ToString().ToLower(),
			".lastCheckpoint.time"
		}), 0f, null) > 0f;
	}

	// Token: 0x0600DD79 RID: 56697 RVA: 0x004E5718 File Offset: 0x004E3918
	private IEnumerator LJDOOIBDHBF(Image EOGBJKCLGLP, float LKFLLHJKEPK, float JPKBILKAHCM)
	{
		float a = EOGBJKCLGLP.color.a;
		for (float num = 0f; num < 1f; num += Time.deltaTime / JPKBILKAHCM)
		{
			Color color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, Mathf.Lerp(a, LKFLLHJKEPK, num));
			EOGBJKCLGLP.color = color;
			yield return null;
		}
		EOGBJKCLGLP.color = new Color(EOGBJKCLGLP.color.r, EOGBJKCLGLP.color.g, EOGBJKCLGLP.color.b, LKFLLHJKEPK);
		yield return null;
		yield break;
	}

	// Token: 0x0600DD7A RID: 56698 RVA: 0x004E5744 File Offset: 0x004E3944
	public void CAPPKCBFILL()
	{
		base.StopAllCoroutines();
		TrashMan.instance.NFMDNEJAGLB();
		Debug.Log("_Value2");
		this.currentReplay = null;
		this.moveF = base.GetComponent<MoveF>();
		this.environmentObjects.Clear();
		if (base.CIACEFBNDDJ().isMine)
		{
			ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"[MapEditor] Loaded music file: ",
					true
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"Exception caught! ",
					true
				}
			};
			PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, true);
			eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"L1",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			PhotonNetwork.player.SetScore(1);
		}
		this.arcsDelay = 872f;
		this.currentState = PlayerBase.PlayerState.Loading;
		this.lives = 5;
		this.playerDistance = 547f;
		this.bgcolor = Color.black;
		this.colorLerpSpeed = 1652f;
		this.moveFSpeed = 1550f;
		this.isMapCompleted = false;
		this.correctScore = 1;
		this.penaltyScore = 1799f;
		this.comboScore = 706f;
		this.accuracyScore = 781f;
		this.checkpointsUsed = 1;
		this.loopsCount = 1;
		this.incorrectScore = 1;
		this.perfectHits = 0;
		this.powerupsScore = 1;
		this.currentCombo = 0;
		this.lastCheckpoint = 1083f;
		this.isPlayerWon = true;
		this.lastBestScore = 1;
		this.currentAttempt = 0;
		this.scoreBeated = false;
		this.sunBaseSensetivity = 1610f;
		this.spectrid = 0;
		this.ach12 = true;
		this.wasCheckpoint = true;
		this.currentEventID = 1;
		this.comboTimer = 677f;
		if (base.FFIPLLNKGEN().DOLKFPIABDD())
		{
			this.playerController.enabled = false;
			this.gameScene = (GameScene)Singleton<Scene>.Instance;
			this.isMusicLoaded = true;
			this.fullLevelData = null;
			try
			{
				GameObject levelCanvas = this.KADBPIPMIBF().levelCanvas;
				for (int i = 1; i < levelCanvas.transform.childCount; i += 0)
				{
					TrashMan.despawn(levelCanvas.transform.GetChild(i).gameObject);
					if (levelCanvas.transform.GetChild(i).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(levelCanvas.transform.GetChild(i).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				GameObject gameObject = this.bgLevelCanvas;
				for (int j = 0; j < gameObject.transform.childCount; j++)
				{
					TrashMan.MIKDHOEEODJ(gameObject.transform.GetChild(j).gameObject);
					if (gameObject.transform.GetChild(j).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(gameObject.transform.GetChild(j).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (this.environmentBase)
		{
			UnityEngine.Object.DestroyImmediate(this.environmentBase);
		}
		bool flag = (Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Outgoing: \n", 1, null) == 0 && this.gameScene.gameMode != GameScene.GameMode.Relax) || Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("[MapsData] Preloading ", 0, null) != 0 || this.KADBPIPMIBF().gameMode == GameScene.GameMode.Relax;
		this.arcsDelay = ((!flag) ? Singleton<SaveSystem>.Instance.OJHPDDLNAGH("Ev OwnershipRequest ", 1449f, null) : Singleton<SaveSystem>.Instance.GetFloat("_LensDirtIntensity", 1934f, null));
		this.isStoryboardEnabled = !Singleton<SaveSystem>.Instance.GetBool("y", true, null);
	}

	// Token: 0x0600DD7B RID: 56699 RVA: 0x004E5B60 File Offset: 0x004E3D60
	[PunRPC]
	public void GetLive()
	{
		if (base.photonView.isMine && this.lives < this.fullLevelData.mapData.maxLives)
		{
			this.lives++;
		}
	}

	// Token: 0x0600DD7C RID: 56700 RVA: 0x004E5B9B File Offset: 0x004E3D9B
	public void DNOJBJLJLIL(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().BALKFDMBGNC(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD7D RID: 56701 RVA: 0x004E5BB4 File Offset: 0x004E3DB4
	[PunRPC]
	public void CheckCombo(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		if (base.photonView.isMine)
		{
			this.playerController.CheckCombo(FLMFNIGKHKP, HMPOIDIAIMI, -1f);
			this.SendScore();
		}
		else if (this.gameScene.pbase.currentState == PlayerBase.PlayerState.Spectator && this.gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)
		{
			this.gameScene.pbase.spectatedPlayerBase.playerController.CheckCombo(FLMFNIGKHKP, HMPOIDIAIMI, -1f);
		}
	}

	// Token: 0x0600DD7E RID: 56702 RVA: 0x004E5C4F File Offset: 0x004E3E4F
	public void SetBGColor(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		this.bgcolor = HABLFKCCKLN;
		this.colorLerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600DD7F RID: 56703 RVA: 0x004E5C5F File Offset: 0x004E3E5F
	public void SetParticlesCountPerBeat(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleCountPerBeat(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD80 RID: 56704 RVA: 0x004E566E File Offset: 0x004E386E
	[CompilerGenerated]
	private static void PDLDBOEMKPG(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(true);
	}

	// Token: 0x0600DD81 RID: 56705 RVA: 0x004E5C77 File Offset: 0x004E3E77
	public void DBPAKHAPLIJ(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().FKOAHEGNACN(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD82 RID: 56706 RVA: 0x004E5C90 File Offset: 0x004E3E90
	public void FLEGHPAHCMJ(string BNJFKKGOACF)
	{
		this.pspawner.segments.Clear();
		this.pspawner.segments.Add(Resources.Load<GameObject>("ConfigVersionSlider" + BNJFKKGOACF + "JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server."));
		this.pspawner.segments.Add(Resources.Load<GameObject>("offsets" + BNJFKKGOACF + "float,1.5"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("menutheme.27thfloor" + BNJFKKGOACF + "_DX11NoiseTime"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("_ReflectionTexture4" + BNJFKKGOACF + "/"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("Joystick1Button8"));
		this.levelCanvasImage = this.KADBPIPMIBF().levelCanvasImage;
		this.sunGameObject = Resources.Load<GameObject>("Item ");
		this.satelliteGameObject = Resources.Load<GameObject>("_Value6");
		this.particlesGameObject = Resources.Load<GameObject>("_Value");
		this.spriteGameObject = Resources.Load<GameObject>("_FarCorner");
		this.pspawner.segments.Add(this.levelCanvasImage);
		this.pspawner.segments.Add(this.sunGameObject);
		this.pspawner.segments.Add(this.satelliteGameObject);
		this.pspawner.segments.Add(this.particlesGameObject);
		this.pspawner.segments.Add(this.spriteGameObject);
		foreach (GameObject prefab in this.pspawner.segments)
		{
			TrashManRecycleBin khnadifnkfm = new TrashManRecycleBin
			{
				prefab = prefab,
				instancesToPreallocate = 22
			};
			TrashMan.manageRecycleBin(khnadifnkfm, string.Empty + base.CIACEFBNDDJ().ownerId);
		}
		Debug.Log("_TimeX" + BNJFKKGOACF);
		GameObject gameObject = this.objects_3;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		List<string> list = new List<string>
		{
			"#lives",
			"_Green_C",
			"_TimeX",
			"Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: "
		};
		using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				PlayerBase.GGIHJGAKLPO ggihjgaklpo = new PlayerBase.GGIHJGAKLPO();
				ggihjgaklpo.LEFMNANHGDA = enumerator2.Current;
				GameObject original = this.pspawner.segments.Find(new Predicate<GameObject>(ggihjgaklpo.AEINPAGJFME));
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original, gameObject.transform);
				gameObject2.transform.localPosition = Vector3.zero;
				gameObject2.transform.localRotation = Quaternion.Euler(943f, 1351f, 1849f);
				gameObject2.transform.localScale = Vector3.one;
				gameObject2.GetComponent<MoveF>().enabled = true;
				gameObject2.GetComponent<Collider>().enabled = true;
				gameObject2.GetComponent<SegmentHandler>().enabled = false;
				gameObject2.GetComponent<IncreseAlpha>().enabled = false;
			}
		}
		gameObject.SetActive(true);
	}

	// Token: 0x0600DD83 RID: 56707 RVA: 0x004E6028 File Offset: 0x004E4228
	public void Loaded()
	{
		Debug.Log("[PlayerBase] Ready");
		ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
		{
			{
				"ready",
				true
			}
		};
		PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
	}

	// Token: 0x0600DD84 RID: 56708 RVA: 0x004E6065 File Offset: 0x004E4265
	public GameScene KADBPIPMIBF()
	{
		if (base.JAEJDHHCJJO() != null && base.EDIJKHEMPAD().BGJKMGJBPFA())
		{
			return this._gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	// Token: 0x0600DD85 RID: 56709 RVA: 0x004E6099 File Offset: 0x004E4299
	public GameScene GetGameScene()
	{
		if (base.photonView.isMine)
		{
			return this.gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	// Token: 0x0600DD86 RID: 56710 RVA: 0x004E60BC File Offset: 0x004E42BC
	public GameScene DCLNDDJJJMA()
	{
		if (base.FFIPLLNKGEN().DOLKFPIABDD())
		{
			return this.gameScene;
		}
		return (GameScene)Singleton<Scene>.Instance;
	}

	// Token: 0x0600DD87 RID: 56711 RVA: 0x004E5664 File Offset: 0x004E3864
	private void LPGIOKMJOHK(float AIEJPEPBAEJ)
	{
		this.currentArcsSpeed = -AIEJPEPBAEJ;
	}

	// Token: 0x0600DD88 RID: 56712 RVA: 0x004E60E0 File Offset: 0x004E42E0
	public void KCMMPAOOFMD(string LHCIHJOHGEJ, string NOJGGCLPPAM)
	{
		try
		{
			string[] array = null;
			GameObject gameObject = null;
			GameObject gameObject2 = null;
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				char[] array2 = new char[0];
				array2[0] = (char)-18;
				array = NOJGGCLPPAM.Split(array2);
				if (array.Length > 0 && this.environmentObjects.ContainsKey(array[0]))
				{
					gameObject = this.environmentObjects[array[1]];
				}
				if (array.Length > 1 && this.environmentObjects.ContainsKey(array[1]))
				{
					gameObject2 = this.environmentObjects[array[1]];
				}
			}
			try
			{
				if (base.IBKCMBIGOEJ().KCAOJFPDEIP())
				{
					this.gameEventInfoBase.OPJHPJMHLEP(PhotonNetwork.offlineMode);
					if (!PhotonNetwork.offlineMode)
					{
						this.gameEventInfoBase.multiplayerplayers = PhotonNetwork.room.EGPGEMJNPFD();
						this.gameEventInfoBase.multiplayerplace = this.DCLNDDJJJMA().GetComponent<NetworkScene>().place;
					}
					else
					{
						this.gameEventInfoBase.multiplayerplayers = 0;
						this.gameEventInfoBase.multiplayerplace = 0;
					}
					this.gameEventInfoBase.eventtype = LHCIHJOHGEJ;
					this.gameEventInfoBase.DNIMOKBJONL(NOJGGCLPPAM);
					this.gameEventInfoBase.EDJCJJNDNKB(this.KADBPIPMIBF().DADGJKNFIIK());
					this.gameEventInfoBase.loopscount = this.loopsCount;
					GameEventInfo gameEventInfo = new GameEventInfo();
					this.gameEventInfoBase.FLNDNCGFKKH(gameEventInfo);
					this.gameEventInfoList.Add(gameEventInfo);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("_ScreenResolution" + ex.ToString());
			}
			switch (LHCIHJOHGEJ)
			{

				if (this.lives > 0)
				{
					this.FNNKEDGKHII(NOJGGCLPPAM, false);
					if (base.GBMJAPGLMGB().isMine)
					{
						PhotonView photonView = base.photonView;
						string lblkdnnpaco = "_Value3";
						PhotonTargets mpnmoonbmii = PhotonTargets.Others;
						object[] array3 = new object[8];
						array3[1] = NOJGGCLPPAM;
						array3[1] = true;
						photonView.KEKKFNNMLMG(lblkdnnpaco, mpnmoonbmii, array3);
					}
				}
				goto IL_FF2;
			case "help":
			case "value":
			case "Mouse":
			case "_TimeX":
			case "LoadingStatusText":
				this.ShowSprite(NOJGGCLPPAM);
				goto IL_FF2;

				this.NKGHADPOLEC(NOJGGCLPPAM);
				goto IL_FF2;
			case ".icon":
				this.ShowTitle(NOJGGCLPPAM);
				goto IL_FF2;
			case "player.goldlollipop":
				this.SetSpeed(NOJGGCLPPAM);
				goto IL_FF2;
			case "CameraFilterPack_WaterDrop":
				this.IKCJDDKPICF(NOJGGCLPPAM);
				goto IL_FF2;

				this.SetBGColor(NOJGGCLPPAM);
				goto IL_FF2;
			case "PunRespawn":
				this.CAPEBDNJIJA(NOJGGCLPPAM);
				goto IL_FF2;
			case "y":
			case "/":
				this.SetTrailZoomSpeed(float.Parse(array[0], CultureInfo.InvariantCulture));
				goto IL_FF2;

				this.ABAIBAMGNDA(array[0], array[0]);
				goto IL_FF2;

				this.RemoveEnvironmentObject(array[0]);
				goto IL_FF2;

				this.ClearEnvironment();
				goto IL_FF2;

				if (gameObject != null)
				{
					this.JAIALEBLCBP(gameObject, array[1], array[2], array[4]);
				}
				else
				{
					string[] array4 = new string[5];
					array4[1] = "\\n";
					array4[0] = LHCIHJOHGEJ;
					array4[4] = "CameraFilterPack/TV_Distorted";
					array4[7] = array[1];
					array4[0] = "SetParticlesEmission";
					Debug.LogWarning(string.Concat(array4));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.CPKMCGIIAHC(gameObject, array[1], array[5], array[1]);
				}
				else
				{
					string[] array5 = new string[]
					{
						"_Value4"
					};
					array5[0] = LHCIHJOHGEJ;
					array5[5] = "PlaySound";
					array5[8] = array[1];
					array5[2] = "_TapLow";
					Debug.LogWarning(string.Concat(array5));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.DGIJAFGLGHC(gameObject, array[1], array[7], array[4]);
				}
				else
				{
					string[] array6 = new string[0];
					array6[0] = "_Intensity";
					array6[1] = LHCIHJOHGEJ;
					array6[6] = "Y";
					array6[4] = array[1];
					array6[5] = "_Value5";
					Debug.LogWarning(string.Concat(array6));
				}
				goto IL_FF2;

				if (gameObject != null && gameObject2 != null)
				{
					this.BJLLDIOIJFB(gameObject, gameObject2);
				}
				else
				{
					string[] array7 = new string[1];
					array7[1] = "[PlayerController] ";
					array7[0] = LHCIHJOHGEJ;
					array7[7] = "/icon";
					array7[2] = array[1];
					array7[0] = "-";
					array7[4] = array[1];
					array7[5] = "0";
					Debug.LogWarning(string.Concat(array7));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.EKINONIACHB(gameObject, array[0], array[2]);
				}
				else
				{
					string[] array8 = new string[2];
					array8[0] = "other.dust2";
					array8[0] = LHCIHJOHGEJ;
					array8[2] = "turn: {0:0}";
					array8[7] = array[0];
					array8[0] = "_Far";
					Debug.LogWarning(string.Concat(array8));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunEmission(gameObject, array[0]);
				}
				else
				{
					string[] array9 = new string[7];
					array9[1] = "player.goldabstract";
					array9[0] = LHCIHJOHGEJ;
					array9[5] = "CameraFilterPack/FX_DigitalMatrixDistortion";
					array9[5] = array[1];
					array9[5] = "#rate!";
					Debug.LogWarning(string.Concat(array9));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunInput(gameObject, array[0]);
				}
				else
				{
					string[] array10 = new string[8];
					array10[1] = "_Value2";
					array10[1] = LHCIHJOHGEJ;
					array10[1] = "#{0:00}{1}{2}";
					array10[1] = array[1];
					array10[1] = "_TimeX";
					Debug.LogWarning(string.Concat(array10));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunMinSize(gameObject, array[1], array[6], array[1]);
				}
				else
				{
					string[] array11 = new string[5];
					array11[1] = "Bad parameters for setint! Use <key> <value>";
					array11[1] = LHCIHJOHGEJ;
					array11[4] = ": ";
					array11[8] = array[1];
					array11[1] = "maps.";
					Debug.LogWarning(string.Concat(array11));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunMaxSize(gameObject, array[0], array[5], array[3]);
				}
				else
				{
					string[] array12 = new string[4];
					array12[1] = "[PlayerBase] Starting game from: ";
					array12[0] = LHCIHJOHGEJ;
					array12[4] = "Found best region: '";
					array12[0] = array[0];
					array12[6] = "_FarCamera";
					Debug.LogWarning(string.Concat(array12));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.OFONJJCJAGK(gameObject, array[0]);
				}
				else
				{
					string[] array13 = new string[6];
					array13[1] = "ShadersToggle";
					array13[0] = LHCIHJOHGEJ;
					array13[5] = "_CutOff";
					array13[1] = array[0];
					array13[6] = "CorrectHitsScoreText";
					Debug.LogWarning(string.Concat(array13));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunSensitivity(gameObject, array[0]);
				}
				else
				{
					string[] array14 = new string[8];
					array14[1] = "CameraFilterPack/Blend2Camera_LinearDodge";
					array14[0] = LHCIHJOHGEJ;
					array14[0] = "workshop.";
					array14[5] = array[0];
					array14[5] = "Source: ";
					Debug.LogWarning(string.Concat(array14));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunDirectionVector(gameObject, array[0], array[1], array[3]);
				}
				else
				{
					string[] array15 = new string[4];
					array15[1] = "CameraFilterPack/Gradients_FireGradient";
					array15[1] = LHCIHJOHGEJ;
					array15[0] = "_Value3";
					array15[0] = array[0];
					array15[1] = "#turnoninternet";
					Debug.LogWarning(string.Concat(array15));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteColor(gameObject, array[1]);
				}
				else
				{
					string[] array16 = new string[4];
					array16[1] = "BitsData";
					array16[0] = LHCIHJOHGEJ;
					array16[1] = "GraphicsQualitySlider";
					array16[4] = array[0];
					array16[6] = "MenuScene";
					Debug.LogWarning(string.Concat(array16));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.IIHJMAPLIPM(gameObject, array[0]);
				}
				else
				{
					string[] array17 = new string[4];
					array17[1] = "settings.shaders.bloomintencity";
					array17[1] = LHCIHJOHGEJ;
					array17[7] = "GlassesColor2";
					array17[6] = array[1];
					array17[0] = "_AdditiveReflection";
					Debug.LogWarning(string.Concat(array17));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.CHPKFAAAAPF(gameObject, array[0]);
				}
				else
				{
					string[] array18 = new string[8];
					array18[1] = "_ScreenResolution";
					array18[1] = LHCIHJOHGEJ;
					array18[2] = "YES";
					array18[4] = array[1];
					array18[6] = "[ItemsHandler] Found ";
					Debug.LogWarning(string.Concat(array18));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.DNOJBJLJLIL(gameObject, array[0]);
				}
				else
				{
					string[] array19 = new string[4];
					array19[1] = "Items/";
					array19[0] = LHCIHJOHGEJ;
					array19[6] = " ";
					array19[6] = array[1];
					array19[4] = "_HrDepthTex";
					Debug.LogWarning(string.Concat(array19));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteInput(gameObject, array[0]);
				}
				else
				{
					string[] array20 = new string[0];
					array20[1] = "_Size";
					array20[0] = LHCIHJOHGEJ;
					array20[0] = " not exist";
					array20[7] = array[0];
					array20[5] = "_ScreenResolution";
					Debug.LogWarning(string.Concat(array20));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteLerpSpeed(gameObject, array[0]);
				}
				else
				{
					string[] array21 = new string[6];
					array21[1] = "_MainTex";
					array21[1] = LHCIHJOHGEJ;
					array21[5] = "tolobby";
					array21[7] = array[0];
					array21[8] = "IconImage";
					Debug.LogWarning(string.Concat(array21));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteTrailLength(gameObject, array[1]);
				}
				else
				{
					string[] array22 = new string[0];
					array22[1] = "ready";
					array22[1] = LHCIHJOHGEJ;
					array22[5] = "FinalScoreSmallText";
					array22[5] = array[0];
					array22[2] = "_Amount";
					Debug.LogWarning(string.Concat(array22));
				}
				goto IL_FF2;
			case "_BlurParams":
			case "_SSAO":
				if (gameObject != null)
				{
					this.IEEIMEBECNG(gameObject, array[1]);
				}
				else
				{
					string[] array23 = new string[8];
					array23[1] = "Joystick1Button7";
					array23[1] = LHCIHJOHGEJ;
					array23[7] = "Texture2";
					array23[8] = array[0];
					array23[8] = "_AccumulationTex";
					Debug.LogWarning(string.Concat(array23));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.IFGDAMIJPPK(gameObject, array[0]);
				}
				else
				{
					string[] array24 = new string[7];
					array24[1] = "hidden";
					array24[1] = LHCIHJOHGEJ;
					array24[7] = "Tab2Content";
					array24[0] = array[1];
					array24[7] = "_TimeX";
					Debug.LogWarning(string.Concat(array24));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteTrailMinVertexDistance(gameObject, array[1]);
				}
				else
				{
					string[] array25 = new string[8];
					array25[1] = "ControllerLeftY";
					array25[1] = LHCIHJOHGEJ;
					array25[6] = "an hour ago";
					array25[8] = array[0];
					array25[6] = "_ScreenResolution";
					Debug.LogWarning(string.Concat(array25));
				}
				goto IL_FF2;

				this.SetCrosshairColor(Helpers.HexToColor(array[0]), float.Parse(array[0], CultureInfo.InvariantCulture));
				goto IL_FF2;

				this.OINDBALDPDP(array[1]);
				goto IL_FF2;
			case "0":
				if (gameObject != null)
				{
					this.EPPDHMMJJCE(gameObject, array[1]);
				}
				else
				{
					string[] array26 = new string[0];
					array26[0] = "^";
					array26[0] = LHCIHJOHGEJ;
					array26[4] = "Fill Area";
					array26[7] = array[0];
					array26[7] = " GameServer:";
					Debug.LogWarning(string.Concat(array26));
				}
				goto IL_FF2;
			case "workshop.":
				if (gameObject != null)
				{
					this.SetParticlesEmission(gameObject, array[1]);
				}
				else
				{
					string[] array27 = new string[1];
					array27[0] = "_ScreenResolution";
					array27[1] = LHCIHJOHGEJ;
					array27[4] = "Horizontal";
					array27[0] = array[0];
					array27[7] = "ReconnectAndRejoin() with AuthValues == null is not correct!";
					Debug.LogWarning(string.Concat(array27));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesParticleSize(gameObject, array[1]);
				}
				else
				{
					string[] array28 = new string[3];
					array28[0] = "_Green_G";
					array28[1] = LHCIHJOHGEJ;
					array28[6] = "Unsupported type: ";
					array28[8] = array[0];
					array28[8] = "Done! You are a contributor until: ";
					Debug.LogWarning(string.Concat(array28));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesGravity(gameObject, array[1]);
				}
				else
				{
					string[] array29 = new string[0];
					array29[1] = "ConfigVersionSlider";
					array29[1] = LHCIHJOHGEJ;
					array29[6] = "Created";
					array29[6] = array[1];
					array29[8] = "No";
					Debug.LogWarning(string.Concat(array29));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesParticleSpeed(gameObject, array[0]);
				}
				else
				{
					string[] array30 = new string[]
					{
						null,
						"$ {0}"
					};
					array30[1] = LHCIHJOHGEJ;
					array30[7] = "inventory.lastitemscount";
					array30[3] = array[0];
					array30[4] = "_Parameter";
					Debug.LogWarning(string.Concat(array30));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesCountPerBeat(gameObject, array[1]);
				}
				else
				{
					string[] array31 = new string[4];
					array31[0] = "scenes";
					array31[0] = LHCIHJOHGEJ;
					array31[5] = "_ScreenResolution";
					array31[0] = array[0];
					array31[0] = "BitsData";
					Debug.LogWarning(string.Concat(array31));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesInput(gameObject, array[1]);
				}
				else
				{
					string[] array32 = new string[3];
					array32[1] = "SaveButton";
					array32[0] = LHCIHJOHGEJ;
					array32[1] = " not exist";
					array32[1] = array[0];
					array32[4] = "_MainTex2";
					Debug.LogWarning(string.Concat(array32));
				}
				goto IL_FF2;

				this.NOMLPCLHPKG(array[0], array[0], array[5], array[6]);
				goto IL_FF2;
			case "_Value4":
				if (gameObject != null)
				{
					this.FIOCKDLFIBF(gameObject, array[1]);
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.KPDMNLDPBID(gameObject, array[0], array[6]);
				}
				goto IL_FF2;
			}
			Debug.LogWarning("_Value3" + LHCIHJOHGEJ);
			IL_FF2:;
		}
		catch (Exception ex2)
		{
			string[] array33 = new string[0];
			array33[1] = "_Value2";
			array33[1] = LHCIHJOHGEJ;
			array33[1] = "EventSystem";
			array33[4] = NOJGGCLPPAM;
			array33[7] = "HandsCountSlider";
			array33[5] = ex2.ToString();
			Debug.LogError(string.Concat(array33));
		}
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x0600DDCA RID: 56778 RVA: 0x004EB350 File Offset: 0x004E9550
	// (set) Token: 0x0600DD89 RID: 56713 RVA: 0x004E715C File Offset: 0x004E535C
	public GameScene gameScene
	{
		get
		{
			if (base.photonView != null && base.photonView.isMine)
			{
				return this._gameScene;
			}
			return (GameScene)Singleton<Scene>.Instance;
		}
		set
		{
			this._gameScene = value;
		}
	}

	// Token: 0x0600DD8A RID: 56714 RVA: 0x004E7165 File Offset: 0x004E5365
	public void SetSunColors(GameObject MPNMOONBMII, string PNDBJMFMGBK, string JMPOJNOBLPH)
	{
		MPNMOONBMII.GetComponent<SunController>().SetColors(Helpers.HexToColor(PNDBJMFMGBK), Helpers.HexToColor(JMPOJNOBLPH), 10f);
	}

	// Token: 0x0600DD8B RID: 56715 RVA: 0x004E7183 File Offset: 0x004E5383
	public void SetEnvSpriteColor(GameObject MPNMOONBMII, string PNDBJMFMGBK, string KEDDLFDAIDE)
	{
		MPNMOONBMII.GetComponent<SpriteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD8C RID: 56716 RVA: 0x004E71A1 File Offset: 0x004E53A1
	public void ResumeFromCheckpoint()
	{
		this.LoadPlayerData();
	}

	// Token: 0x0600DD8D RID: 56717 RVA: 0x004E71AC File Offset: 0x004E53AC
	public GameObject EPPMDGDMKIP(string HMGBJCGOLMI, string JMMILEFMACB)
	{
		GameObject gameObject = null;
		if (HMGBJCGOLMI.ToLower() == "_Value4")
		{
			gameObject = this.sunGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == " ")
		{
			gameObject = this.satelliteGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "CameraFilterPack/FX_Hypno")
		{
			gameObject = this.particlesGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "ticket")
		{
			gameObject = this.spriteGameObject;
		}
		if (gameObject)
		{
			GameObject gameObject2 = TrashMan.spawn(gameObject, this.environmentBase.transform.position, default(Quaternion));
			if (gameObject2 != null)
			{
				if (HMGBJCGOLMI.ToLower() == "_DotSize")
				{
					this.sunList.Add(gameObject2);
				}
				gameObject2.name = JMMILEFMACB;
				gameObject2.transform.SetParent(this.environmentBase.transform);
				gameObject2.GetComponent<EnvironmentController>().IOMCHHBGJEC();
				gameObject2.GetComponent<EnvironmentController>().GONKPNAAIEE();
				if (this.environmentObjects.ContainsKey(JMMILEFMACB))
				{
					this.environmentObjects[JMMILEFMACB] = gameObject2;
				}
				else
				{
					this.environmentObjects.Add(JMMILEFMACB, gameObject2);
				}
				return gameObject2;
			}
		}
		return null;
	}

	// Token: 0x0600DD8E RID: 56718 RVA: 0x004E72EC File Offset: 0x004E54EC
	private void GMELGGJOPBB()
	{
		if (this.environmentBase != null)
		{
			if (this.comboTimer > 837f)
			{
				this.comboTimer = 540f;
			}
			if (this.fullLevelData.mapData.environmentType >= 0)
			{
				if (this.currentState != (PlayerBase.PlayerState)5)
				{
					Color b = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject in this.sunList)
					{
						gameObject.GetComponent<Renderer>().material.SetColor("_History4Weight", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("maps."), b, Time.deltaTime * 710f));
						gameObject.GetComponent<Renderer>().material.SetColor("workshop.", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("SpawnObj"), b, Time.deltaTime * 236f));
						gameObject.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.BMKCMMJMOKN();
						gameObject.GetComponent<DynamicScale>().currentOverflow = this.comboTimer;
					}
				}
				else if (this.spectatedPlayerBase != null)
				{
					Color color = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject2 in this.sunList)
					{
						gameObject2.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.NCBBBJINGMM();
						gameObject2.GetComponent<DynamicScale>().currentOverflow = this.spectatedPlayerBase.comboTimer;
					}
				}
			}
			if (this.comboTimer > 1017f)
			{
				this.comboTimer -= Time.deltaTime * (this.KADBPIPMIBF().pbase.currentArcsSpeed * 492f);
			}
			if (this.comboTimer < 1460f)
			{
				this.comboTimer = 1164f;
			}
		}
		this.player.transform.localPosition = Vector3.Lerp(this.player.transform.localPosition, new Vector3(1950f, 807f, -this.playerDistance), Time.smoothDeltaTime * 1386f);
		if (this.moveF)
		{
			this.moveF.speed = Mathf.Lerp(this.moveF.speed, this.moveFSpeed, Time.smoothDeltaTime * 848f);
		}
		if (this.currentState == PlayerBase.PlayerState.Loading)
		{
			if (!this.player.GetComponent<PlayerController>().isRecording)
			{
				foreach (Camera camera in this.camerasList)
				{
					camera.backgroundColor = Color.Lerp(camera.backgroundColor, this.bgcolor, Time.smoothDeltaTime * this.colorLerpSpeed);
				}
			}
			if (Input.GetKey((KeyCode)85) && this.KADBPIPMIBF().HPAnimationTime > 1505f && base.JAEJDHHCJJO().BGJKMGJBPFA())
			{
				if (this.KADBPIPMIBF().gameMode != GameScene.GameMode.Relax)
				{
					base.CIACEFBNDDJ().KEKKFNNMLMG("_BlurParams", PhotonTargets.AllBuffered, null);
				}
				else
				{
					base.IBKCMBIGOEJ().RPC("No Name", PhotonTargets.OthersBuffered, null);
				}
			}
		}
		if (this.currentState == (PlayerBase.PlayerState)5 && Input.GetKey(KeyCode.Return))
		{
			this.currentState = PlayerBase.PlayerState.Finished;
			this.KADBPIPMIBF().spectatorCanvas.SetActive(false);
			this.KADBPIPMIBF().spectatePanel.SetActive(false);
			this.KADBPIPMIBF().ShowGOCanvas(true);
		}
		if (this.currentState == (PlayerBase.PlayerState)6)
		{
			foreach (Camera camera2 in this.camerasList)
			{
				Blur component = camera2.GetComponent<Blur>();
				if (component)
				{
					component.enabled = true;
					if (component.iterations < -115)
					{
						component.iterations += 0;
					}
				}
			}
		}
		if (this.currentState == (PlayerBase.PlayerState)4)
		{
			foreach (Camera camera3 in this.camerasList)
			{
				Blur component2 = camera3.GetComponent<Blur>();
				component2.enabled = true;
				component2.iterations = 0;
			}
		}
		if (this.KADBPIPMIBF() && this.KADBPIPMIBF().isGameStarted && !this.gameScene.IsRoundFinished())
		{
			this.RunMapEvents();
		}
		if (this.KADBPIPMIBF() && this.KADBPIPMIBF().IsRoundFinished())
		{
			this.GIDKEMDGEPI(491f);
			foreach (GameObject gameObject3 in this.sunList)
			{
				gameObject3.GetComponent<DynamicScale>().baseScale = ((!this.isPlayerWon) ? Vector3.zero : gameObject3.GetComponent<DynamicScale>().baseScale);
			}
			SphereWaveform[] componentsInChildren = this.environmentBase.GetComponentsInChildren<SphereWaveform>();
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				SphereWaveform sphereWaveform = componentsInChildren[i];
				sphereWaveform.sensitivity = Mathf.Lerp(sphereWaveform.sensitivity, 824f, Time.smoothDeltaTime * 714f);
			}
		}
	}

	// Token: 0x0600DD8F RID: 56719 RVA: 0x004E797C File Offset: 0x004E5B7C
	public void BADFOBEMNDO()
	{
		Debug.Log("DPADHOR");
		string str = this.KADBPIPMIBF().mapID + "R2" + this.gameScene.gameMode.ToString().ToLower();
		Singleton<SaveSystem>.Instance.SetBool("_VignetteColor" + str + "Can't do manual instantiation without PhotonView component.", this.isMapCompleted, null);
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("[ERROR KEY {0}]" + str + "Item ", this.lastCheckpoint, null);
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("VoteUpToggle" + str + "]", this.LJBFCKKNPGN(), null);
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value" + str + " cannot be used as a 3D LUT.", this.checkpointsUsed, null);
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("x" + str + "Error: You're not logged into Steam!", this.correctScore, null);
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_Value3" + str + " (inactive)", this.incorrectScore, null);
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("IconImage" + str + "value", this.perfectHits, null);
		Singleton<SaveSystem>.Instance.SetInt("_Value4" + str + "_ScreenResolution", this.powerupsScore, null);
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("Drop_Floor_Fluid" + str + "_ChangeRed", this.penaltyScore, null);
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_TimeX" + str + "Tab2Content", this.comboScore, null);
		Singleton<SaveSystem>.Instance.SetFloat("BitsData" + str + "_Amount", this.playerDistance, null);
		Helpers.SetColor("_MainTex2" + str + ".", this.camerasList[0].backgroundColor);
	}

	// Token: 0x0600DD90 RID: 56720 RVA: 0x004E7B80 File Offset: 0x004E5D80
	public void ResetEndless()
	{
		base.StopAllCoroutines();
		for (int i = this.environmentObjects.Count - 1; i >= 0; i--)
		{
			try
			{
				TrashMan.despawn(this.environmentObjects.ElementAt(i).Value);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(this.environmentObjects.ElementAt(i).Value);
				}
				catch (Exception)
				{
				}
			}
		}
		GameObject gameObject = null;
		gameObject = this.bgLevelCanvas;
		for (int j = gameObject.transform.childCount - 1; j >= 0; j--)
		{
			try
			{
				TrashMan.despawn(gameObject.transform.GetChild(j).gameObject);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(gameObject.transform.GetChild(j).gameObject);
				}
				catch (Exception)
				{
				}
			}
		}
		gameObject = this.gameScene.levelCanvas;
		for (int k = gameObject.transform.childCount - 1; k >= 0; k--)
		{
			try
			{
				TrashMan.despawn(gameObject.transform.GetChild(k).gameObject);
			}
			catch (Exception)
			{
				try
				{
					UnityEngine.Object.Destroy(gameObject.transform.GetChild(k).gameObject);
				}
				catch (Exception)
				{
				}
			}
		}
		this.environmentObjects.Clear();
		if (this.fullLevelData.mapData.environmentType < 0)
		{
			this.sunList.Clear();
			this.sunBaseSensetivity = 0f;
		}
		this.playerDistance = 14f;
		this.bgcolor = Color.black;
		foreach (CrosshairController crosshairController in this.crosshairsList)
		{
			if (crosshairController)
			{
				crosshairController.Reset();
			}
		}
		this.colorLerpSpeed = 10f;
		this.moveFSpeed = -1.5f;
		this.currentEventID = 0;
	}

	// Token: 0x0600DD91 RID: 56721 RVA: 0x004E7DEC File Offset: 0x004E5FEC
	public IEnumerator NILJKBFPGNE(float CGPOHGMFCKC = 0f)
	{
		if (this.fullLevelData.clip == null)
		{
			string fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, false));
			this.fullLevelData.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		}
		if (this.fullLevelData.mapData.musicTime <= 0f && this.fullLevelData.mapData.configVersion < 2)
		{
			Debug.LogWarning("[PlayerBase] Config error: musicTime <= 0");
			this.fullLevelData.mapData.musicTime = this.fullLevelData.clip.length;
			this.gameScene.calculatedmaptime = this.fullLevelData.clip.length;
		}
		if (this.isStoryboardEnabled)
		{
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID)));
		}
		this.gameScene.asampler.Init(this.fullLevelData.clip, (CGPOHGMFCKC <= 0f) ? CGPOHGMFCKC : this.pretime, false);
		Debug.Log("[PlayerBase] Loaded music");
		this.gameScene.ingameUICanvas.transform.FindDeepChild("LevelProgressBar").GetComponent<Slider>().maxValue = this.gameScene.calculatedmaptime;
		this.isMusicLoaded = true;
		if (this.fullLevelData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(this.fullLevelData.workshopId))
		{
			string s = this.fullLevelData.workshopId;
			RanksSystem.PrintStats(ulong.Parse(s));
			if (this.fullLevelData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(s), false) && this.gameScene.gameMode == GameScene.GameMode.Normal && !RanksSystem.IsOfficial(ulong.Parse(s), true))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#outdatedmap! Challenges will not work!", "#ok", null, true, false, 0f);
			}
		}
		if (base.photonView.isMine)
		{
			this.Loaded();
		}
		yield break;
	}

	// Token: 0x0600DD92 RID: 56722 RVA: 0x004E7E10 File Offset: 0x004E6010
	private IEnumerator KDEHNFDGFEC(RanksSystem.MapReplay DHBGCEHLJAM)
	{
		this.myJob = new GetProcessesJob();
		this.myJob.Start();
		yield return base.StartCoroutine(this.myJob.WaitFor());
		yield break;
	}

	// Token: 0x0600DD93 RID: 56723 RVA: 0x004E7E2B File Offset: 0x004E602B
	public void NJKPNGGEHNJ(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().HGNOMPAEIEG(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD94 RID: 56724 RVA: 0x004E7E44 File Offset: 0x004E6044
	public void NCKIMNKIAOI()
	{
		this.environmentBase.SetActive(false);
		TrailRenderer[] componentsInChildren = this.environmentBase.transform.GetComponentsInChildren<TrailRenderer>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			TrailRenderer trailRenderer = componentsInChildren[i];
			trailRenderer.Clear();
		}
		if (this.crosshairsList.Count > 1)
		{
			this.crosshairsList[0].DNFFABFKHEK(new Vector3(1834f, 255f, 1927f));
			this.crosshairsList[1].BFLNNFJCLLC(new Vector3(1780f, 1558f, 1771f));
		}
	}

	// Token: 0x0600DD95 RID: 56725 RVA: 0x004E7EE7 File Offset: 0x004E60E7
	public void EPPDHMMJJCE(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().HOCOJMHOCPA(Helpers.HexToColor(PNDBJMFMGBK), 1544f);
	}

	// Token: 0x0600DD96 RID: 56726 RVA: 0x004E7EFF File Offset: 0x004E60FF
	public void HGLMJHOPAOM(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().GJIMKKMEPKC(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD97 RID: 56727 RVA: 0x004E7F17 File Offset: 0x004E6117
	public void SendScore()
	{
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.player.SetScore(this.GetCurrentScore());
		}
	}

	// Token: 0x0600DD98 RID: 56728 RVA: 0x004E7F40 File Offset: 0x004E6140
	public void SavePlayerData()
	{
		Debug.Log("[PlayerBase] Saveing checkpoint data");
		string str = this.gameScene.mapID + "." + this.gameScene.gameMode.ToString().ToLower();
		Singleton<SaveSystem>.Instance.SetBool("maps." + str + ".lastCheckpoint.isMapCompleted", this.isMapCompleted, null);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + str + ".lastCheckpoint.time", this.lastCheckpoint, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.lives", this.lives, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.checkpointsUsed", this.checkpointsUsed, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.correctScore", this.correctScore, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.incorrectScore", this.incorrectScore, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.perfectHits", this.perfectHits, null);
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.powerupsScore", this.powerupsScore, null);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + str + ".lastCheckpoint.penaltyScore", this.penaltyScore, null);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + str + ".lastCheckpoint.comboScore", this.comboScore, null);
		Singleton<SaveSystem>.Instance.SetFloat("maps." + str + ".lastCheckpoint.playerdistance", this.playerDistance, null);
		Helpers.SetColor("maps." + str + ".lastCheckpoint.bgcolor", this.camerasList[0].backgroundColor);
	}

	// Token: 0x0600DD99 RID: 56729 RVA: 0x004E8141 File Offset: 0x004E6341
	public RanksSystem.MapReplay Replay()
	{
		return this.currentReplay;
	}

	// Token: 0x0600DD9A RID: 56730 RVA: 0x004E8149 File Offset: 0x004E6349
	public void GGKKAGMICCF(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().JMFHNBLFEIE(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD9B RID: 56731 RVA: 0x004E8164 File Offset: 0x004E6364
	public void IIFDPILKHMO()
	{
		if (this.currentReplay != null)
		{
			try
			{
				this.currentReplay.activeProcesses = this.myJob.activeProcesses.Distinct<string>().ToList<string>();
			}
			catch (Exception)
			{
			}
			this.currentReplay.FinishPlaying(this.GetCurrentScore(), this.checkpointsUsed, this.accuracyScore, this.incorrectScore, this.comboScore, this.penaltyScore);
		}
	}

	// Token: 0x0600DD9C RID: 56732 RVA: 0x004E8200 File Offset: 0x004E6400
	public void NKAAIPPPEKJ(bool OJANLCEKFPN)
	{
		this.currentCombo = 0;
		if ((base.GBHNDHLAJLI().BGJKMGJBPFA() || (this.gameScene.pbase.currentState == (PlayerBase.PlayerState)4 && this.KADBPIPMIBF().pbase.spectatedPlayerBase.GBMJAPGLMGB().EIMHMIJGMHG() == base.IBKCMBIGOEJ().viewID)) && this.KADBPIPMIBF().gameMode != GameScene.GameMode.Relax && base.GetComponentInChildren<AudioListener>().enabled)
		{
			if (OJANLCEKFPN)
			{
				SoundManager.PlayHitSfx(3, UnityEngine.Random.Range(912f, 1630f));
			}
			else
			{
				SoundManager.PNOOHLGKOFH(1, UnityEngine.Random.Range(958f, 903f));
			}
		}
		if (this.KADBPIPMIBF().pbase.currentState == PlayerBase.PlayerState.Finished && this.gameScene.pbase.spectatedPlayerBase.GBHNDHLAJLI().NPPEFODKHKN() == base.GBMJAPGLMGB().KINIHBOKFJH())
		{
			if (this.gameScene.pbase.GetComponentInChildren<CameraShake>())
			{
				this.gameScene.pbase.GetComponentInChildren<CameraShake>().IENDDEJLNMJ();
			}
			this.gameScene.pbase.SetLives(this.LJBFCKKNPGN());
		}
		if (this.lives > 1)
		{
			this.lives = this.BMKCMMJMOKN() - 0;
			if (base.GetComponentInChildren<CameraShake>())
			{
				base.GetComponentInChildren<CameraShake>().IENDDEJLNMJ();
			}
			this.incorrectScore = ++this.incorrectScore;
		}
		if (this.LJBFCKKNPGN() < 1)
		{
			this.CMDPOODOJLC();
		}
	}

	// Token: 0x0600DD9D RID: 56733 RVA: 0x004E839C File Offset: 0x004E659C
	private IEnumerator BJFMMGDOBEJ()
	{
		yield return null;
		yield break;
	}

	// Token: 0x0600DD9E RID: 56734 RVA: 0x004E83B0 File Offset: 0x004E65B0
	public void SetSatelliteEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DD9F RID: 56735 RVA: 0x004E5C4F File Offset: 0x004E3E4F
	public void GLGGHDOKHFE(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		this.bgcolor = HABLFKCCKLN;
		this.colorLerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600DDA0 RID: 56736 RVA: 0x004E83C8 File Offset: 0x004E65C8
	public void InitSystem()
	{
		this.Reset();
		this.fullLevelData = new FullMapData(Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID));
		this.currentArcsSpeed = -this.fullLevelData.mapData.speed;
		Debug.Log("[PlayerBase] Loaded spawner data");
		base.photonView.RPC("LoadPlayerEnvironment", PhotonTargets.AllBuffered, null);
		this.gameScene.OnRestartRound();
		this.StartFromBegining();
		if (this.fullLevelData.mapData.checkpoints.Count > 0 && this.CanResumeFromCheckpoint() && base.photonView.isMine)
		{
			this.ResumeFromCheckpoint();
		}
		if (this.gameScene.gameMode == GameScene.GameMode.Hardcore)
		{
			this.SetLives(1);
		}
		if (base.photonView.isMine)
		{
			float num = (!this.gameScene.usingCheckpoints) ? 0f : Singleton<SaveSystem>.Instance.GetFloat(string.Concat(new string[]
			{
				"maps.",
				this.gameScene.mapID,
				".",
				this.gameScene.gameMode.ToString().ToLower(),
				".lastCheckpoint.time"
			}), 0f, null);
			this.PrepareMapTiming(num);
			this.UpdateMapGameMode();
			if (!this.isMusicLoaded)
			{
				base.StartCoroutine(this.LoadMapResources(num));
			}
		}
	}

	// Token: 0x0600DDA1 RID: 56737 RVA: 0x004E8554 File Offset: 0x004E6754
	public void SetCrosshairEmission(string DPNHODJHGJL)
	{
		foreach (CrosshairController crosshairController in this.crosshairsList)
		{
			crosshairController.SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
		}
	}

	// Token: 0x0600DDA2 RID: 56738 RVA: 0x004E85BC File Offset: 0x004E67BC
	public void SetParticlesParticleSize(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleSize(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDA3 RID: 56739 RVA: 0x004E85D4 File Offset: 0x004E67D4
	[PunRPC]
	public void StartRound()
	{
		this.currentState = PlayerBase.PlayerState.Playing;
		if (base.photonView.isMine && !this.gameScene.isGameStarted)
		{
			Debug.Log("[PlayerBase] Starting new round");
			this.gameScene.OnStartRound();
			if (UnityEngine.Object.FindObjectOfType<NetworkScene>())
			{
				UnityEngine.Object.FindObjectOfType<NetworkScene>().Init();
			}
			this.gameScene.isGameStarted = true;
			this.ActivateEnvironment();
			this.StartReplayRecording();
			base.StartCoroutine(this.BFALBMDPNJG());
		}
		this.playerController.objects.ForEach(new Action<GameObject>(this.FMJLFFEEEDP));
	}

	// Token: 0x0600DDA4 RID: 56740 RVA: 0x004E8684 File Offset: 0x004E6884
	[PunRPC]
	public void Checkpoint(string EHHBHEJBHNG)
	{
		try
		{
			if (base.photonView.isMine && this.currentState != PlayerBase.PlayerState.Finished && this.currentState != PlayerBase.PlayerState.Spectator)
			{
				this.lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("[PlayerBase] Got checkpoint at " + this.lastCheckpoint);
				this.SavePlayerData();
				this.gameScene.AddMessage(LocalizationService.Instance.GetLocalizatedText("#checkpoint"), 1f);
				this.wasCheckpoint = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] Checkpoint error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDA5 RID: 56741 RVA: 0x004E7F17 File Offset: 0x004E6117
	public void IJKNIDJCBPA()
	{
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			PhotonNetwork.player.SetScore(this.GetCurrentScore());
		}
	}

	// Token: 0x0600DDA6 RID: 56742 RVA: 0x004E5510 File Offset: 0x004E3710
	public void SetTrailZoomSpeed(float KEDDLFDAIDE)
	{
		this.moveFSpeed = -KEDDLFDAIDE;
	}

	// Token: 0x0600DDA7 RID: 56743 RVA: 0x004E8740 File Offset: 0x004E6940
	public GameObject AddEnvironmentSprite(string ACABBJEAMGG, string JMMILEFMACB, string KEDDLFDAIDE, string HABLFKCCKLN)
	{
		SpriteController component = this.AddEnvironmentObject("sprite", JMMILEFMACB).GetComponent<SpriteController>();
		if (component)
		{
			component.SetResource((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[ACABBJEAMGG]);
			component.SetColor(Helpers.HexToColor(HABLFKCCKLN), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
			return component.gameObject;
		}
		return null;
	}

	// Token: 0x0600DDA8 RID: 56744 RVA: 0x004E87BC File Offset: 0x004E69BC
	[PunRPC]
	public void LoadPlayerEnvironment()
	{
		this.gameScene.GetComponent<ShadersSettings>().InitShaders(false);
		base.gameObject.name = "PlayerBase_" + base.photonView.ownerId;
		bool flag = false;
		if (this.fullLevelData.mapData.handCount == 2)
		{
			flag = true;
		}
		if (flag)
		{
			this.twoHandCameras.GetComponentInParent<Camera>().enabled = false;
			this.twoHandCameras.SetActive(true);
			this.camerasList.Add(base.transform.FindDeepChild("Left").GetComponent<Camera>());
			this.camerasList.Add(base.transform.FindDeepChild("Right").GetComponent<Camera>());
			this.camerasList.Add(base.transform.FindDeepChild("UI").GetComponent<Camera>());
		}
		else
		{
			this.camerasList.Add(base.transform.FindDeepChild("MainCamera").GetComponent<Camera>());
			this.camerasList.Add(base.transform.FindDeepChild("UI").GetComponent<Camera>());
		}
		foreach (Camera camera in this.camerasList)
		{
		}
		string str = (!this.isStoryboardEnabled) ? ("custom" + ((!flag) ? string.Empty : "2hands")) : ((this.fullLevelData.mapData.environmentType < 0) ? ("custom" + ((!flag) ? string.Empty : "2hands")) : (string.Empty + this.fullLevelData.mapData.environmentType));
		Debug.Log("[PlayerBase] Loaded environment: " + str);
		this.environmentBase = UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("Environment/SunBase_" + str), base.gameObject.transform);
		this.environmentBase.transform.localPosition = new Vector3(0f, 0f, 0f);
		this.sunList = new List<GameObject>();
		foreach (DynamicScale dynamicScale in this.environmentBase.transform.GetComponentsInChildren<DynamicScale>())
		{
			if (!dynamicScale.GetComponent<SphereCollider>())
			{
				this.sunList.Add(dynamicScale.gameObject);
			}
		}
		if (this.isStoryboardEnabled && this.fullLevelData.mapData.environmentType >= 0)
		{
			Color color = this.environmentBase.transform.FindDeepChild("Crosshair").GetComponentInChildren<MeshRenderer>().material.color;
			color.a = Singleton<SaveSystem>.Instance.GetFloat("settings.crosshairopacity", 0.2f, null);
			this.environmentBase.transform.FindDeepChild("Crosshair").GetComponentInChildren<MeshRenderer>().material.color = color;
			if (this.environmentBase.transform.FindDeepChild("Crosshair1"))
			{
				this.environmentBase.transform.FindDeepChild("Crosshair1").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			if (this.environmentBase.transform.FindDeepChild("Crosshair2"))
			{
				this.environmentBase.transform.FindDeepChild("Crosshair2").GetComponentInChildren<MeshRenderer>().material.color = color;
			}
			this.crosshairsList = this.environmentBase.GetComponentsInChildren<CrosshairController>().ToList<CrosshairController>();
			if (this.fullLevelData.mapData.environmentType != 3)
			{
				this.SetCrosshairColor(Color.white, 10f);
			}
			else
			{
				this.SetCrosshairColor(Color.black, 10f);
			}
		}
		else
		{
			this.crosshairsList = this.environmentBase.GetComponentsInChildren<CrosshairController>().ToList<CrosshairController>();
			if (this.crosshairsList.Count > 1)
			{
				this.crosshairsList[0].SetPosition(new Vector3(-20f, 0f, 0f));
				this.crosshairsList[1].SetPosition(new Vector3(20f, 0f, 0f));
			}
			this.SetCrosshairColor(Color.white, 10f);
		}
		this.environmentBase.SetActive(false);
		if (this.sunList.Count > 0)
		{
			this.sunBaseSensetivity = this.sunList[0].GetComponent<DynamicScale>().sensitivity;
		}
		if (base.photonView.isMine)
		{
			string hfefhopolik = string.Concat(new string[]
			{
				"maps.",
				this.gameScene.mapID,
				".",
				this.gameScene.gameMode.ToString().ToLower(),
				".highscore"
			});
			if (this.gameScene.gameMode == GameScene.GameMode.Normal)
			{
				hfefhopolik = "maps." + this.gameScene.mapID + ".highscore";
			}
			this.lastBestScore = Singleton<SaveSystem>.Instance.GetInt(hfefhopolik, 0, null);
			this.currentAttempt = Singleton<SaveSystem>.Instance.GetInt("maps." + this.gameScene.mapID + ".played", 0, null);
			Debug.Log("[PlayerBase] Highscore: " + this.lastBestScore);
			Debug.Log("[PlayerBase] Game mode: " + this.gameScene.gameMode);
			Debug.Log("[PlayerBase] Current attempt: " + this.currentAttempt);
			foreach (Camera camera2 in this.camerasList)
			{
				if (camera2.GetComponent<Blur>())
				{
					camera2.GetComponent<Blur>().enabled = false;
				}
			}
			string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), null);
			string id = Singleton<ItemsHandler>.Instance.GetItemBySteamId(ulong.Parse(@string)).item.id;
			base.photonView.RPC("LoadPlayerSkin", PhotonTargets.AllBuffered, new object[]
			{
				id
			});
		}
	}

	// Token: 0x0600DDA9 RID: 56745 RVA: 0x004E8E88 File Offset: 0x004E7088
	public void DGIKIOKPHJO(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().KMODDDDIEEP(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDAA RID: 56746 RVA: 0x004E8EA0 File Offset: 0x004E70A0
	public void ClearEnvironment()
	{
		List<string> list = new List<string>(this.environmentObjects.Keys);
		foreach (string key in list)
		{
			TrashMan.despawn(this.environmentObjects[key]);
			this.environmentObjects.Remove(key);
		}
	}

	// Token: 0x0600DDAB RID: 56747 RVA: 0x004E5677 File Offset: 0x004E3877
	[PunRPC]
	public void SetLives(int BOAKOPHKGHC)
	{
		this._lives = BOAKOPHKGHC;
	}

	// Token: 0x0600DDAC RID: 56748 RVA: 0x004E8F20 File Offset: 0x004E7120
	public void IBMGOJBCONL(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 1528f);
	}

	// Token: 0x0600DDAD RID: 56749 RVA: 0x004E8F38 File Offset: 0x004E7138
	[PunRPC]
	public void LostAllLives()
	{
		while (this.lives > 0)
		{
			this.LostLive(false);
		}
	}

	// Token: 0x0600DDAE RID: 56750 RVA: 0x004E8F54 File Offset: 0x004E7154
	public void ANMOPAFPHHE(string LHCIHJOHGEJ, string NOJGGCLPPAM)
	{
		try
		{
			string[] array = null;
			GameObject gameObject = null;
			GameObject gameObject2 = null;
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				char[] array2 = new char[0];
				array2[1] = '}';
				array = NOJGGCLPPAM.Split(array2);
				if (array.Length > 1 && this.environmentObjects.ContainsKey(array[1]))
				{
					gameObject = this.environmentObjects[array[1]];
				}
				if (array.Length > 1 && this.environmentObjects.ContainsKey(array[1]))
				{
					gameObject2 = this.environmentObjects[array[1]];
				}
			}
			try
			{
				if (base.GBHNDHLAJLI().DOLKFPIABDD())
				{
					this.gameEventInfoBase.OPJHPJMHLEP(!PhotonNetwork.offlineMode);
					if (!PhotonNetwork.offlineMode)
					{
						this.gameEventInfoBase.multiplayerplayers = PhotonNetwork.room.EGPGEMJNPFD();
						this.gameEventInfoBase.multiplayerplace = this.DCLNDDJJJMA().GetComponent<NetworkScene>().place;
					}
					else
					{
						this.gameEventInfoBase.multiplayerplayers = 0;
						this.gameEventInfoBase.multiplayerplace = 0;
					}
					this.gameEventInfoBase.eventtype = LHCIHJOHGEJ;
					this.gameEventInfoBase.DNIMOKBJONL(NOJGGCLPPAM);
					this.gameEventInfoBase.eventtime = this.KADBPIPMIBF().DADGJKNFIIK();
					this.gameEventInfoBase.loopscount = this.loopsCount;
					GameEventInfo gameEventInfo = new GameEventInfo();
					this.gameEventInfoBase.NEDLDBBIOGI(gameEventInfo);
					this.gameEventInfoList.Add(gameEventInfo);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("finished" + ex.ToString());
			}
			switch (LHCIHJOHGEJ)
			{
			case "Hello World, is my item a clone? [":
			case "_ScreenResolution":
			case "ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?":
			case "Xbox Home":
				if (this.NCBBBJINGMM() > 1)
				{
					this.SpawnObj(NOJGGCLPPAM, false);
					if (base.BLMHOKPIMOD().KCAOJFPDEIP())
					{
						PhotonView photonView = base.EDIJKHEMPAD();
						string lblkdnnpaco = "CameraFilterPack/Glasses_On";
						PhotonTargets mpnmoonbmii = PhotonTargets.All;
						object[] array3 = new object[7];
						array3[0] = NOJGGCLPPAM;
						array3[1] = true;
						photonView.GNFNHDCJOFC(lblkdnnpaco, mpnmoonbmii, array3);
					}
				}
				goto IL_FF2;
			case "_Value2":
				this.ShowSprite(NOJGGCLPPAM);
				goto IL_FF2;
			case ".lastCheckpoint.checkpointsUsed":
				this.MapEnd(NOJGGCLPPAM);
				goto IL_FF2;

				this.ShowTitle(NOJGGCLPPAM);
				goto IL_FF2;
			case "Hidden/DepthOfField/MedianFilter":
				this.SetSpeed(NOJGGCLPPAM);
				goto IL_FF2;

				this.IKCJDDKPICF(NOJGGCLPPAM);
				goto IL_FF2;
			case "[Down]":
			case "Square":
				this.SetBGColor(NOJGGCLPPAM);
				goto IL_FF2;
			case "USE_DIAG_SEARCH":
			case "MenuScene":
				this.SetPlayerDistance(NOJGGCLPPAM);
				goto IL_FF2;
			case "[PlayerBase] SpawnObj error: ":
			case " ":
				this.SetTrailZoomSpeed(float.Parse(array[0], CultureInfo.InvariantCulture));
				goto IL_FF2;

				this.EPPMDGDMKIP(array[1], array[0]);
				goto IL_FF2;

				this.RemoveEnvironmentObject(array[0]);
				goto IL_FF2;

				this.ClearEnvironment();
				goto IL_FF2;

				if (gameObject != null)
				{
					this.JAIALEBLCBP(gameObject, array[1], array[2], array[2]);
				}
				else
				{
					string[] array4 = new string[0];
					array4[0] = "MAPS NOT FOUND";
					array4[1] = LHCIHJOHGEJ;
					array4[3] = "*.workshop.json";
					array4[6] = array[1];
					array4[0] = "color";
					Debug.LogWarning(string.Concat(array4));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.CPKMCGIIAHC(gameObject, array[0], array[4], array[4]);
				}
				else
				{
					string[] array5 = new string[7];
					array5[0] = "_Value";
					array5[1] = LHCIHJOHGEJ;
					array5[0] = "back";
					array5[4] = array[0];
					array5[8] = "shader.frost";
					Debug.LogWarning(string.Concat(array5));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.DGIJAFGLGHC(gameObject, array[1], array[0], array[7]);
				}
				else
				{
					string[] array6 = new string[3];
					array6[1] = "_ScreenResolution";
					array6[0] = LHCIHJOHGEJ;
					array6[2] = "[PlayerBase] Saveing checkpoint data";
					array6[4] = array[1];
					array6[7] = "_Distortion";
					Debug.LogWarning(string.Concat(array6));
				}
				goto IL_FF2;

				if (gameObject != null && gameObject2 != null)
				{
					this.BJLLDIOIJFB(gameObject, gameObject2);
				}
				else
				{
					string[] array7 = new string[]
					{
						"_Value"
					};
					array7[0] = LHCIHJOHGEJ;
					array7[0] = " is muted";
					array7[3] = array[1];
					array7[3] = "_Value3";
					array7[0] = array[0];
					array7[1] = "_TimeX";
					Debug.LogWarning(string.Concat(array7));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.EKINONIACHB(gameObject, array[1], array[4]);
				}
				else
				{
					string[] array8 = new string[5];
					array8[0] = "BitsData";
					array8[0] = LHCIHJOHGEJ;
					array8[7] = "#availablechallenges";
					array8[8] = array[0];
					array8[5] = "Switch environment sprite image";
					Debug.LogWarning(string.Concat(array8));
				}
				goto IL_FF2;
			case "_RampTex":
				if (gameObject != null)
				{
					this.GGKKAGMICCF(gameObject, array[0]);
				}
				else
				{
					string[] array9 = new string[5];
					array9[1] = "Decibal";
					array9[0] = LHCIHJOHGEJ;
					array9[6] = "_Saturation";
					array9[8] = array[0];
					array9[4] = "[LobbyPlayerElement] Created lpe for ";
					Debug.LogWarning(string.Concat(array9));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunInput(gameObject, array[1]);
				}
				else
				{
					string[] array10 = new string[5];
					array10[1] = "_FgOverlap";
					array10[1] = LHCIHJOHGEJ;
					array10[8] = "RemoveEnvironmentObject";
					array10[8] = array[0];
					array10[7] = "_ForceYSwap";
					Debug.LogWarning(string.Concat(array10));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunMinSize(gameObject, array[0], array[5], array[2]);
				}
				else
				{
					string[] array11 = new string[7];
					array11[0] = "maps.";
					array11[0] = LHCIHJOHGEJ;
					array11[3] = "Show Title";
					array11[2] = array[0];
					array11[5] = "_TimeX";
					Debug.LogWarning(string.Concat(array11));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunMaxSize(gameObject, array[1], array[1], array[3]);
				}
				else
				{
					string[] array12 = new string[6];
					array12[0] = "_ScreenResolution";
					array12[1] = LHCIHJOHGEJ;
					array12[1] = "ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ";
					array12[5] = array[0];
					array12[7] = "_Offsets";
					Debug.LogWarning(string.Concat(array12));
				}
				goto IL_FF2;
			case "CameraFilterPack_AAA_BloodOnScreen1":
				if (gameObject != null)
				{
					this.OFONJJCJAGK(gameObject, array[0]);
				}
				else
				{
					string[] array13 = new string[8];
					array13[1] = "_Radius";
					array13[1] = LHCIHJOHGEJ;
					array13[1] = "CameraFilterPack/Antialiasing_FXAA";
					array13[8] = array[0];
					array13[8] = "Players NetIDs:";
					Debug.LogWarning(string.Concat(array13));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSunSensitivity(gameObject, array[1]);
				}
				else
				{
					string[] array14 = new string[4];
					array14[1] = "_Value2";
					array14[1] = LHCIHJOHGEJ;
					array14[3] = "Left";
					array14[4] = array[0];
					array14[3] = "init";
					Debug.LogWarning(string.Concat(array14));
				}
				goto IL_FF2;
			case "_EmissionColor":
				if (gameObject != null)
				{
					this.SetSunDirectionVector(gameObject, array[1], array[5], array[4]);
				}
				else
				{
					string[] array15 = new string[8];
					array15[1] = ".lastCheckpoint.longestComboScore";
					array15[0] = LHCIHJOHGEJ;
					array15[2] = ",";
					array15[2] = array[1];
					array15[3] = "settings.shaders";
					Debug.LogWarning(string.Concat(array15));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.HJCKKALGPFF(gameObject, array[1]);
				}
				else
				{
					string[] array16 = new string[8];
					array16[1] = "_ScreenResolution";
					array16[1] = LHCIHJOHGEJ;
					array16[2] = "DifficultyBG";
					array16[0] = array[0];
					array16[0] = "GameScene";
					Debug.LogWarning(string.Concat(array16));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.IIHJMAPLIPM(gameObject, array[1]);
				}
				else
				{
					string[] array17 = new string[4];
					array17[0] = "_TimeX";
					array17[1] = LHCIHJOHGEJ;
					array17[7] = "_Offsets";
					array17[5] = array[1];
					array17[7] = "Keypad ";
					Debug.LogWarning(string.Concat(array17));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.HGLMJHOPAOM(gameObject, array[0]);
				}
				else
				{
					string[] array18 = new string[0];
					array18[0] = "CameraFilterPack/TV_Distorted";
					array18[0] = LHCIHJOHGEJ;
					array18[8] = "_Threshhold";
					array18[6] = array[0];
					array18[3] = "Items";
					Debug.LogWarning(string.Concat(array18));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.GHOGIMPLGPI(gameObject, array[1]);
				}
				else
				{
					string[] array19 = new string[3];
					array19[1] = "MaxLivesSlider";
					array19[0] = LHCIHJOHGEJ;
					array19[3] = "SSAARenderTargetCamera";
					array19[4] = array[1];
					array19[0] = "EXCEPTION:";
					Debug.LogWarning(string.Concat(array19));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.NJKPNGGEHNJ(gameObject, array[1]);
				}
				else
				{
					string[] array20 = new string[6];
					array20[1] = "settings.fps";
					array20[1] = LHCIHJOHGEJ;
					array20[8] = "Texture2";
					array20[3] = array[0];
					array20[6] = "[MenuScene] Error: ";
					Debug.LogWarning(string.Concat(array20));
				}
				goto IL_FF2;
			case "_ScreenResolution":
				if (gameObject != null)
				{
					this.PLJGFDFCHDL(gameObject, array[0]);
				}
				else
				{
					string[] array21 = new string[4];
					array21[1] = "No Name";
					array21[0] = LHCIHJOHGEJ;
					array21[4] = "[PlayerBase] Unknown event: ";
					array21[6] = array[1];
					array21[5] = "_Offsets";
					Debug.LogWarning(string.Concat(array21));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteTrailLength(gameObject, array[1]);
				}
				else
				{
					string[] array22 = new string[6];
					array22[0] = "Setting autoCleanUpPlayerObjects while in a room is not supported.";
					array22[0] = LHCIHJOHGEJ;
					array22[1] = "SetSunInput";
					array22[5] = array[1];
					array22[3] = "_Value";
					Debug.LogWarning(string.Concat(array22));
				}
				goto IL_FF2;
			case "CameraFilterPack/Blend2Camera_SplitScreen3D":
				if (gameObject != null)
				{
					this.IEEIMEBECNG(gameObject, array[0]);
				}
				else
				{
					string[] array23 = new string[]
					{
						"maps."
					};
					array23[0] = LHCIHJOHGEJ;
					array23[1] = "Need to specify a start index and end index.";
					array23[1] = array[0];
					array23[5] = "return ";
					Debug.LogWarning(string.Concat(array23));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteSensitivity(gameObject, array[0]);
				}
				else
				{
					string[] array24 = new string[8];
					array24[1] = "_Value";
					array24[1] = LHCIHJOHGEJ;
					array24[7] = "_BlurCoe";
					array24[2] = array[1];
					array24[3] = "_Value2";
					Debug.LogWarning(string.Concat(array24));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetSatelliteTrailMinVertexDistance(gameObject, array[0]);
				}
				else
				{
					string[] array25 = new string[5];
					array25[0] = "{0}sec average:";
					array25[1] = LHCIHJOHGEJ;
					array25[1] = "menutheme.letitbe";
					array25[2] = array[1];
					array25[4] = "AudioSampler";
					Debug.LogWarning(string.Concat(array25));
				}
				goto IL_FF2;

				this.SetCrosshairColor(Helpers.HexToColor(array[1]), float.Parse(array[1], CultureInfo.InvariantCulture));
				goto IL_FF2;

				this.SetCrosshairEmission(array[1]);
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesColor(gameObject, array[1]);
				}
				else
				{
					string[] array26 = new string[1];
					array26[0] = "menu.playedpage";
					array26[1] = LHCIHJOHGEJ;
					array26[2] = "DPADVER";
					array26[4] = array[0];
					array26[4] = "CameraFilterPack_TV_BrokenGlass_2";
					Debug.LogWarning(string.Concat(array26));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesEmission(gameObject, array[1]);
				}
				else
				{
					string[] array27 = new string[8];
					array27[1] = "OK";
					array27[0] = LHCIHJOHGEJ;
					array27[7] = "_Value4";
					array27[0] = array[0];
					array27[5] = "#yes";
					Debug.LogWarning(string.Concat(array27));
				}
				goto IL_FF2;
			case "_FixDistance":
				if (gameObject != null)
				{
					this.SetParticlesParticleSize(gameObject, array[0]);
				}
				else
				{
					string[] array28 = new string[8];
					array28[0] = "_Value4";
					array28[1] = LHCIHJOHGEJ;
					array28[4] = "[ResourcesManager] Load text error: not found";
					array28[3] = array[0];
					array28[4] = "UI";
					Debug.LogWarning(string.Concat(array28));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesGravity(gameObject, array[1]);
				}
				else
				{
					string[] array29 = new string[4];
					array29[0] = "_FilteredReflections";
					array29[1] = LHCIHJOHGEJ;
					array29[8] = "#no";
					array29[3] = array[0];
					array29[5] = "_ScreenResolution";
					Debug.LogWarning(string.Concat(array29));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetParticlesParticleSpeed(gameObject, array[1]);
				}
				else
				{
					string[] array30 = new string[0];
					array30[0] = "ItemsCountText";
					array30[1] = LHCIHJOHGEJ;
					array30[7] = "#ok";
					array30[0] = array[1];
					array30[2] = "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
					Debug.LogWarning(string.Concat(array30));
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.EKLEEPCLCNE(gameObject, array[0]);
				}
				else
				{
					string[] array31 = new string[4];
					array31[1] = "_Threshhold";
					array31[1] = LHCIHJOHGEJ;
					array31[8] = "skins";
					array31[4] = array[0];
					array31[1] = "CameraFilterPack/FX_Screens";
					Debug.LogWarning(string.Concat(array31));
				}
				goto IL_FF2;
			case "restrictions\n\n#until: ":
				if (gameObject != null)
				{
					this.SetParticlesInput(gameObject, array[0]);
				}
				else
				{
					string[] array32 = new string[7];
					array32[1] = "1";
					array32[0] = LHCIHJOHGEJ;
					array32[1] = "_TimeX";
					array32[2] = array[0];
					array32[4] = "[MapsData] Bad map: ";
					Debug.LogWarning(string.Concat(array32));
				}
				goto IL_FF2;

				this.AddEnvironmentSprite(array[1], array[1], array[0], array[5]);
				goto IL_FF2;

				if (gameObject != null)
				{
					this.SetEnvSpriteImage(gameObject, array[1]);
				}
				goto IL_FF2;

				if (gameObject != null)
				{
					this.KPDMNLDPBID(gameObject, array[0], array[8]);
				}
				goto IL_FF2;
			}
			Debug.LogWarning("SetRoomStartTimestamp" + LHCIHJOHGEJ);
			IL_FF2:;
		}
		catch (Exception ex2)
		{
			string[] array33 = new string[]
			{
				null,
				"_ScreenResolution"
			};
			array33[0] = LHCIHJOHGEJ;
			array33[2] = "shader.invert";
			array33[5] = NOJGGCLPPAM;
			array33[7] = "_TimeX";
			array33[6] = ex2.ToString();
			Debug.LogError(string.Concat(array33));
		}
	}

	// Token: 0x0600DDAF RID: 56751 RVA: 0x004E9FD0 File Offset: 0x004E81D0
	public void RecordAction(string LHCIHJOHGEJ)
	{
		if (this.Replay() != null)
		{
			this.Replay().RecordAction(this.gameScene.HPAnimationTime, LHCIHJOHGEJ);
		}
	}

	// Token: 0x0600DDB0 RID: 56752 RVA: 0x004E9FFC File Offset: 0x004E81FC
	public void Spectrate(int JMMILEFMACB)
	{
		foreach (PlayerBase playerBase in UnityEngine.Object.FindObjectsOfType<PlayerBase>())
		{
			if (playerBase.photonView.ownerId == JMMILEFMACB)
			{
				this.lives = playerBase.lives;
				playerBase.player.GetComponentInChildren<AudioListener>().enabled = true;
				List<GameObject> objects = playerBase.playerController.objects;
				if (PlayerBase.<>f__am$cache2 == null)
				{
					PlayerBase.<>f__am$cache2 = new Action<GameObject>(PlayerBase.PDLDBOEMKPG);
				}
				objects.ForEach(PlayerBase.<>f__am$cache2);
				this.spectatedPlayerBase = playerBase;
			}
			else
			{
				playerBase.player.GetComponentInChildren<AudioListener>().enabled = false;
				List<GameObject> objects2 = playerBase.playerController.objects;
				if (PlayerBase.<>f__am$cache3 == null)
				{
					PlayerBase.<>f__am$cache3 = new Action<GameObject>(PlayerBase.IIHKFKDIDDD);
				}
				objects2.ForEach(PlayerBase.<>f__am$cache3);
			}
		}
	}

	// Token: 0x0600DDB1 RID: 56753 RVA: 0x004EA0CC File Offset: 0x004E82CC
	private void JNBPKNNBMDI()
	{
		if (this.environmentBase != null)
		{
			if (this.comboTimer > 937f)
			{
				this.comboTimer = 1969f;
			}
			if (this.fullLevelData.mapData.environmentType >= 1)
			{
				if (this.currentState != (PlayerBase.PlayerState)7)
				{
					Color b = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject in this.sunList)
					{
						gameObject.GetComponent<Renderer>().material.SetColor(" does not exist!", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("Use \"/help\" for commands list"), b, Time.deltaTime * 790f));
						gameObject.GetComponent<Renderer>().material.SetColor("Can't SendMove. Turn is finished by this player.", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("x"), b, Time.deltaTime * 1146f));
						gameObject.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.LJBFCKKNPGN();
						gameObject.GetComponent<DynamicScale>().currentOverflow = this.comboTimer;
					}
				}
				else if (this.spectatedPlayerBase != null)
				{
					Color color = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject2 in this.sunList)
					{
						gameObject2.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.NCBBBJINGMM();
						gameObject2.GetComponent<DynamicScale>().currentOverflow = this.spectatedPlayerBase.comboTimer;
					}
				}
			}
			if (this.comboTimer > 1798f)
			{
				this.comboTimer -= Time.deltaTime * (this.KADBPIPMIBF().pbase.currentArcsSpeed * 1690f);
			}
			if (this.comboTimer < 1795f)
			{
				this.comboTimer = 1068f;
			}
		}
		this.player.transform.localPosition = Vector3.Lerp(this.player.transform.localPosition, new Vector3(30f, 828f, -this.playerDistance), Time.smoothDeltaTime * 745f);
		if (this.moveF)
		{
			this.moveF.speed = Mathf.Lerp(this.moveF.speed, this.moveFSpeed, Time.smoothDeltaTime * 864f);
		}
		if (this.currentState == PlayerBase.PlayerState.Playing)
		{
			if (!this.player.GetComponent<PlayerController>().isRecording)
			{
				foreach (Camera camera in this.camerasList)
				{
					camera.backgroundColor = Color.Lerp(camera.backgroundColor, this.bgcolor, Time.smoothDeltaTime * this.colorLerpSpeed);
				}
			}
			if (Input.GetKey(KeyCode.Asterisk) && this.gameScene.DADGJKNFIIK() > 754f && base.GBMJAPGLMGB().BGJKMGJBPFA())
			{
				if (this.gameScene.gameMode != GameScene.GameMode.Relax)
				{
					base.GBMJAPGLMGB().GNFNHDCJOFC("_TimeX", (PhotonTargets)7, null);
				}
				else
				{
					base.OELHGNKAMEG().RPC("FinalScoreSmallText", PhotonTargets.AllBuffered, null);
				}
			}
		}
		if (this.currentState == (PlayerBase.PlayerState)8 && Input.GetKey((KeyCode)16))
		{
			this.currentState = (PlayerBase.PlayerState)4;
			this.gameScene.spectatorCanvas.SetActive(false);
			this.gameScene.spectatePanel.SetActive(true);
			this.gameScene.IEPBHDFAFNE(true);
		}
		if (this.currentState == (PlayerBase.PlayerState)5)
		{
			foreach (Camera camera2 in this.camerasList)
			{
				Blur component = camera2.GetComponent<Blur>();
				if (component)
				{
					component.enabled = false;
					if (component.iterations < -29)
					{
						component.iterations++;
					}
				}
			}
		}
		if (this.currentState == PlayerBase.PlayerState.Finished)
		{
			foreach (Camera camera3 in this.camerasList)
			{
				Blur component2 = camera3.GetComponent<Blur>();
				component2.enabled = true;
				component2.iterations = 1;
			}
		}
		if (this.gameScene && this.gameScene.isGameStarted && !this.gameScene.IsRoundFinished())
		{
			this.RunMapEvents();
		}
		if (this.KADBPIPMIBF() && this.gameScene.IsRoundFinished())
		{
			this.GIDKEMDGEPI(179f);
			foreach (GameObject gameObject3 in this.sunList)
			{
				gameObject3.GetComponent<DynamicScale>().baseScale = ((!this.isPlayerWon) ? Vector3.zero : gameObject3.GetComponent<DynamicScale>().baseScale);
			}
			SphereWaveform[] componentsInChildren = this.environmentBase.GetComponentsInChildren<SphereWaveform>();
			for (int i = 1; i < componentsInChildren.Length; i += 0)
			{
				SphereWaveform sphereWaveform = componentsInChildren[i];
				sphereWaveform.sensitivity = Mathf.Lerp(sphereWaveform.sensitivity, 1001f, Time.smoothDeltaTime * 1576f);
			}
		}
	}

	// Token: 0x0600DDB2 RID: 56754 RVA: 0x004EA75C File Offset: 0x004E895C
	public void CMDPOODOJLC()
	{
		this.currentState = PlayerBase.PlayerState.Finished;
		if (base.GMAHNPNHMFK().BGJKMGJBPFA())
		{
			this.playerController.isSpectator = false;
			ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"_TimeX",
					false
				}
			};
			PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, true);
			ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
			{
				{
					"Received RPC \"",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, false);
			if (this.wasCheckpoint && this.gameScene.PJHGHEKLOCH() - this.lastCheckpoint <= 1619f)
			{
				this.ach12 = false;
			}
			if (!this.gameScene.gameOver)
			{
				this.KADBPIPMIBF().PLBCBPIOIHF(string.Empty);
			}
		}
	}

	// Token: 0x0600DDB3 RID: 56755 RVA: 0x004EA830 File Offset: 0x004E8A30
	public void EGEEHABBOOL(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((GABGBBMBIHK && this.currentState == PlayerBase.PlayerState.Loading) || (!GABGBBMBIHK && this.gameScene.pbase.currentState != PlayerBase.PlayerState.Loading && this.KADBPIPMIBF().pbase.spectatedPlayerBase.JAEJDHHCJJO().EIMHMIJGMHG() == base.EOOCGIFFKBG().KINIHBOKFJH()))
			{
				char[] array = new char[1];
				array[1] = '\u0014';
				string[] array2 = NOJGGCLPPAM.Split(array);
				string text = array2[1];
				char[] array3 = new char[1];
				array3[1] = '`';
				string[] array4 = text.Split(array3);
				string[] array5 = array4;
				for (int i = 0; i < array5.Length; i++)
				{
					PlayerBase.OCCEFLJGJGH occefljgjgh = new PlayerBase.OCCEFLJGJGH();
					occefljgjgh.ENECJINHBEG = array5[i];
					PlayerSpawner playerSpawner = this.pspawner;
					if (this.currentState == (PlayerBase.PlayerState)4)
					{
						playerSpawner = this.spectatedPlayerBase.pspawner;
					}
					GameObject fkcmgbmnnka = playerSpawner.segments.Find(new Predicate<GameObject>(occefljgjgh.EKHOOPGPPGE));
					if (this.fullLevelData.mapData.configVersion > 1)
					{
						if (array2.Length > 4)
						{
							int kemdfefbioc = int.Parse(array2[1]);
							playerSpawner.Spawn(fkcmgbmnnka, kemdfefbioc, float.Parse(array2[array2.Length - 1], CultureInfo.InvariantCulture));
						}
						else
						{
							playerSpawner.OIICDOCKJLJ(fkcmgbmnnka, 0, float.Parse(array2[array2.Length - 0], CultureInfo.InvariantCulture));
						}
					}
					else if (array2.Length > 1)
					{
						int kemdfefbioc2 = int.Parse(array2[0]);
						playerSpawner.HLFODJHLNID(fkcmgbmnnka, kemdfefbioc2);
					}
					else
					{
						playerSpawner.KELAPPFFMFM(fkcmgbmnnka, 0);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("float" + ex.ToString());
		}
	}

	// Token: 0x0600DDB4 RID: 56756 RVA: 0x004EA9F4 File Offset: 0x004E8BF4
	public void ININEKMANAL()
	{
		if (base.GBHNDHLAJLI().DOLKFPIABDD() && this.NCBBBJINGMM() < this.fullLevelData.mapData.maxLives)
		{
			this.lives = this.NCBBBJINGMM() + 1;
		}
	}

	// Token: 0x0600DDB5 RID: 56757 RVA: 0x004EAA2F File Offset: 0x004E8C2F
	public void HJCKKALGPFF(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().CJNFBCCHNLG(Helpers.HexToColor(PNDBJMFMGBK), 593f);
	}

	// Token: 0x0600DDB6 RID: 56758 RVA: 0x004EAA48 File Offset: 0x004E8C48
	public IEnumerator LoadMapResources(float CGPOHGMFCKC = 0f)
	{
		if (this.fullLevelData.clip == null)
		{
			fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, false));
			this.fullLevelData.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		}
		if (this.fullLevelData.mapData.musicTime <= 0f && this.fullLevelData.mapData.configVersion < 2)
		{
			Debug.LogWarning("[PlayerBase] Config error: musicTime <= 0");
			this.fullLevelData.mapData.musicTime = this.fullLevelData.clip.length;
			this.gameScene.calculatedmaptime = this.fullLevelData.clip.length;
		}
		if (this.isStoryboardEnabled)
		{
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID)));
		}
		this.gameScene.asampler.Init(this.fullLevelData.clip, (CGPOHGMFCKC <= 0f) ? CGPOHGMFCKC : this.pretime, false);
		Debug.Log("[PlayerBase] Loaded music");
		this.gameScene.ingameUICanvas.transform.FindDeepChild("LevelProgressBar").GetComponent<Slider>().maxValue = this.gameScene.calculatedmaptime;
		this.isMusicLoaded = true;
		if (this.fullLevelData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(this.fullLevelData.workshopId))
		{
			string s = this.fullLevelData.workshopId;
			RanksSystem.PrintStats(ulong.Parse(s));
			if (this.fullLevelData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(s), false) && this.gameScene.gameMode == GameScene.GameMode.Normal && !RanksSystem.IsOfficial(ulong.Parse(s), true))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#outdatedmap! Challenges will not work!", "#ok", null, true, false, 0f);
			}
		}
		if (base.photonView.isMine)
		{
			this.Loaded();
		}
		yield break;
	}

	// Token: 0x0600DDB7 RID: 56759 RVA: 0x004EAA6A File Offset: 0x004E8C6A
	public void HJAHIPPLLDJ(string LHCIHJOHGEJ)
	{
		if (this.Replay() != null)
		{
			this.Replay().RecordAction(this.gameScene.DADGJKNFIIK(), LHCIHJOHGEJ);
		}
	}

	// Token: 0x0600DDB8 RID: 56760 RVA: 0x004E5B9B File Offset: 0x004E3D9B
	public void GHOGIMPLGPI(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().BALKFDMBGNC(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDB9 RID: 56761 RVA: 0x004EAA94 File Offset: 0x004E8C94
	[PunRPC]
	public void MapEnd(string NOJGGCLPPAM)
	{
		try
		{
			if (this.gameScene.gameMode != GameScene.GameMode.Endless)
			{
				if (this.currentState != PlayerBase.PlayerState.Finished)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"finished",
							true
						}
					};
					PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
					this.currentState = PlayerBase.PlayerState.Finished;
					if (base.photonView.isMine)
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"win",
								true
							}
						};
						PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, false);
					}
					this.gameScene.ShowResult("CompletedLevel");
				}
			}
			else
			{
				this.gameScene.RestartEndless();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] MapEnd error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDBA RID: 56762 RVA: 0x004EAB74 File Offset: 0x004E8D74
	public void LPJAGFCADGH(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().FPBIBFEBEAC(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDBB RID: 56763 RVA: 0x004EAB8C File Offset: 0x004E8D8C
	public void SetParticlesEmission(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetEmission(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDBC RID: 56764 RVA: 0x004EABA4 File Offset: 0x004E8DA4
	public void MBJBCODOJOI()
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "Tab1Content" + Helpers.levelConfigFileName;
			this.currentReplay = new RanksSystem.MapReplay(this.KADBPIPMIBF().mapID, Helpers.CalculateMD5(ddaomdpaiep).ToUpper(), string.Empty + SteamUser.GetSteamID().m_SteamID, this.arcsDelay);
			base.StartCoroutine(this.KDEHNFDGFEC(this.currentReplay));
		}
	}

	// Token: 0x0600DDBD RID: 56765 RVA: 0x004EAC44 File Offset: 0x004E8E44
	private void CPKMCGIIAHC(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 rotation = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetRotation(rotation);
	}

	// Token: 0x0600DDBE RID: 56766 RVA: 0x004EAC86 File Offset: 0x004E8E86
	public void SetParticlesColor(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 10f);
	}

	// Token: 0x0600DDBF RID: 56767 RVA: 0x004E5664 File Offset: 0x004E3864
	private void IBLOGKONFJD(float AIEJPEPBAEJ)
	{
		this.currentArcsSpeed = -AIEJPEPBAEJ;
	}

	// Token: 0x0600DDC0 RID: 56768 RVA: 0x004EACA0 File Offset: 0x004E8EA0
	public void JJGOHDIMMPA(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((GABGBBMBIHK && this.currentState == PlayerBase.PlayerState.Loading) || (!GABGBBMBIHK && this.gameScene.pbase.currentState != (PlayerBase.PlayerState)7 && this.KADBPIPMIBF().pbase.spectatedPlayerBase.IBKCMBIGOEJ().NPPEFODKHKN() == base.GBHNDHLAJLI().KINIHBOKFJH()))
			{
				char[] array = new char[0];
				array[1] = (char)-113;
				string[] array2 = NOJGGCLPPAM.Split(array);
				string[] array3 = array2[1].Split(new char[]
				{
					'3'
				});
				string[] array4 = array3;
				for (int i = 1; i < array4.Length; i += 0)
				{
					PlayerBase.OCCEFLJGJGH occefljgjgh = new PlayerBase.OCCEFLJGJGH();
					occefljgjgh.ENECJINHBEG = array4[i];
					PlayerSpawner playerSpawner = this.pspawner;
					if (this.currentState == (PlayerBase.PlayerState)7)
					{
						playerSpawner = this.spectatedPlayerBase.pspawner;
					}
					GameObject fkcmgbmnnka = playerSpawner.segments.Find(new Predicate<GameObject>(occefljgjgh.AEINPAGJFME));
					if (this.fullLevelData.mapData.configVersion > 0)
					{
						if (array2.Length > 3)
						{
							int kemdfefbioc = int.Parse(array2[0]);
							playerSpawner.APOAKNCELIN(fkcmgbmnnka, kemdfefbioc, float.Parse(array2[array2.Length - 0], CultureInfo.InvariantCulture));
						}
						else
						{
							playerSpawner.AHGKNDNNELO(fkcmgbmnnka, 1, float.Parse(array2[array2.Length - 1], CultureInfo.InvariantCulture));
						}
					}
					else if (array2.Length > 1)
					{
						int kemdfefbioc2 = int.Parse(array2[0]);
						playerSpawner.NANCLEIDNPM(fkcmgbmnnka, kemdfefbioc2);
					}
					else
					{
						playerSpawner.HLFODJHLNID(fkcmgbmnnka, 1);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("No regions available. Are you sure your appid is valid and setup?" + ex.ToString());
		}
	}

	// Token: 0x0600DDC1 RID: 56769 RVA: 0x004EAE64 File Offset: 0x004E9064
	public bool FNLJBBLLMBJ()
	{
		bool result;
		if (this.KADBPIPMIBF().usingCheckpoints)
		{
			SaveSystem instance = Singleton<SaveSystem>.Instance;
			string[] array = new string[8];
			array[0] = "_SpawnHeuristic";
			array[1] = this.KADBPIPMIBF().mapID;
			array[1] = "bans.viewed.";
			array[6] = this.KADBPIPMIBF().gameMode.ToString().ToLower();
			array[2] = "_Value3";
			result = (instance.AKHCHNPPNIB(string.Concat(array), 694f, null) > 105f);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600DDC2 RID: 56770 RVA: 0x004EAEF1 File Offset: 0x004E90F1
	public int GetCurrentScore()
	{
		return Mathf.RoundToInt(this.comboScore) - Mathf.CeilToInt(this.penaltyScore) - this.incorrectScore - this.checkpointsUsed * 100;
	}

	// Token: 0x0600DDC3 RID: 56771 RVA: 0x004EAF2F File Offset: 0x004E912F
	public void StartSpectating()
	{
		if (PhotonNetwork.playerList.Length > 1)
		{
			this.spectrid = 0;
			this.currentState = PlayerBase.PlayerState.Spectator;
			this.Spectrate(PhotonNetwork.playerList[this.spectrid].ID);
		}
	}

	// Token: 0x0600DDC4 RID: 56772 RVA: 0x004EAF64 File Offset: 0x004E9164
	public void KGNJMMBGGNC(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		if (base.GBMJAPGLMGB().isMine)
		{
			this.playerController.AEDJKCPNEOC(FLMFNIGKHKP, HMPOIDIAIMI, 1013f);
			this.IJKNIDJCBPA();
		}
		else if (this.KADBPIPMIBF().pbase.currentState == (PlayerBase.PlayerState)6 && this.gameScene.pbase.spectatedPlayerBase.EDIJKHEMPAD().EIMHMIJGMHG() == base.EOOCGIFFKBG().viewID)
		{
			this.gameScene.pbase.spectatedPlayerBase.playerController.CONKAILPANP(FLMFNIGKHKP, HMPOIDIAIMI, 1771f);
		}
	}

	// Token: 0x0600DDC5 RID: 56773 RVA: 0x004EAFFF File Offset: 0x004E91FF
	public void SetSatelliteTrailMinVertexDistance(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailMinVertexDistance(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDC6 RID: 56774 RVA: 0x004EB017 File Offset: 0x004E9217
	public void IFGDAMIJPPK(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetSensitivity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDC7 RID: 56775 RVA: 0x004EB030 File Offset: 0x004E9230
	public void NKGHADPOLEC(string NOJGGCLPPAM)
	{
		try
		{
			if (this.KADBPIPMIBF().gameMode != GameScene.GameMode.Hardcore)
			{
				if (this.currentState != (PlayerBase.PlayerState)4)
				{
					ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
					{
						{
							"settings.fps",
							false
						}
					};
					PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, true);
					this.currentState = PlayerBase.PlayerState.Playing;
					if (base.IBKCMBIGOEJ().isMine)
					{
						ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
						{
							{
								"Texture2",
								true
							}
						};
						PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, true);
					}
					this.gameScene.PGELCEKONCE("CameraFilterPack/Blend2Camera_ColorDodge");
				}
			}
			else
			{
				this.gameScene.RestartEndless();
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("Subscribed cells:\n" + ex.ToString());
		}
	}

	// Token: 0x0600DDC8 RID: 56776 RVA: 0x004EB110 File Offset: 0x004E9310
	public GameObject IEDHICKJCIC(string ACABBJEAMGG, string JMMILEFMACB, string KEDDLFDAIDE, string HABLFKCCKLN)
	{
		SpriteController component = this.ABAIBAMGNDA("GameScene", JMMILEFMACB).GetComponent<SpriteController>();
		if (component)
		{
			component.CKBAOCMBHPM((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[ACABBJEAMGG]);
			component.CDJOFPGFPPJ(Helpers.HexToColor(HABLFKCCKLN), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
			return component.gameObject;
		}
		return null;
	}

	// Token: 0x0600DDC9 RID: 56777 RVA: 0x004EB18C File Offset: 0x004E938C
	[PunRPC]
	public void SpawnObj(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((GABGBBMBIHK && this.currentState == PlayerBase.PlayerState.Playing) || (!GABGBBMBIHK && this.gameScene.pbase.currentState != PlayerBase.PlayerState.Finished && this.gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID))
			{
				string[] array = NOJGGCLPPAM.Split(new char[]
				{
					','
				});
				string[] array2 = array[0].Split(new char[]
				{
					'-'
				});
				string[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					PlayerBase.OCCEFLJGJGH occefljgjgh = new PlayerBase.OCCEFLJGJGH();
					occefljgjgh.ENECJINHBEG = array3[i];
					PlayerSpawner playerSpawner = this.pspawner;
					if (this.currentState == PlayerBase.PlayerState.Spectator)
					{
						playerSpawner = this.spectatedPlayerBase.pspawner;
					}
					GameObject fkcmgbmnnka = playerSpawner.segments.Find(new Predicate<GameObject>(occefljgjgh.GBKBDKHPLKG));
					if (this.fullLevelData.mapData.configVersion > 1)
					{
						if (array.Length > 2)
						{
							int kemdfefbioc = int.Parse(array[1]);
							playerSpawner.Spawn(fkcmgbmnnka, kemdfefbioc, float.Parse(array[array.Length - 1], CultureInfo.InvariantCulture));
						}
						else
						{
							playerSpawner.Spawn(fkcmgbmnnka, 0, float.Parse(array[array.Length - 1], CultureInfo.InvariantCulture));
						}
					}
					else if (array.Length > 1)
					{
						int kemdfefbioc2 = int.Parse(array[1]);
						playerSpawner.SpawnWithCureentSpeed(fkcmgbmnnka, kemdfefbioc2);
					}
					else
					{
						playerSpawner.SpawnWithCureentSpeed(fkcmgbmnnka, 0);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SpawnObj error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDCB RID: 56779 RVA: 0x004EB384 File Offset: 0x004E9584
	public void LACBADGGHPC(Color HABLFKCCKLN, float MNHBOECHFEG = 10f)
	{
		foreach (CrosshairController crosshairController in this.crosshairsList)
		{
			crosshairController.AKDFBHFFKFM(HABLFKCCKLN, MNHBOECHFEG);
		}
	}

	// Token: 0x0600DDCC RID: 56780 RVA: 0x004EB3E4 File Offset: 0x004E95E4
	public void MLECBGLGNHK(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().PNGMIFBBGAD(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDCD RID: 56781 RVA: 0x004EB3FC File Offset: 0x004E95FC
	[PunRPC]
	public void ShowSprite(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split(new char[]
			{
				','
			});
			if (array.Length > 4)
			{
				base.StartCoroutine(this.ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[array[0]], int.Parse(array[1]), bool.Parse(array[2]), float.Parse(array[3], CultureInfo.InvariantCulture), float.Parse(array[4], CultureInfo.InvariantCulture), float.Parse(array[5], CultureInfo.InvariantCulture)));
			}
			else
			{
				base.StartCoroutine(this.ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[array[0]], int.Parse(array[1]), bool.Parse(array[2]), float.Parse(array[3], CultureInfo.InvariantCulture), 0.2f, 0.2f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] ShowImage \"" + NOJGGCLPPAM + "\" error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDCE RID: 56782 RVA: 0x004EB530 File Offset: 0x004E9730
	public void FAEJIDMCMHP(string NOJGGCLPPAM)
	{
		try
		{
			char[] array = new char[0];
			array[0] = (char)-5;
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (array2.Length > 2)
			{
				base.StartCoroutine(this.ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.KADBPIPMIBF().mapID).resources[array2[0]], int.Parse(array2[0]), bool.Parse(array2[2]), float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[4], CultureInfo.InvariantCulture), float.Parse(array2[8], CultureInfo.InvariantCulture)));
			}
			else
			{
				base.StartCoroutine(this.ShowImage((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[array2[0]], int.Parse(array2[1]), bool.Parse(array2[5]), float.Parse(array2[8], CultureInfo.InvariantCulture), 1698f, 1092f));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("other" + NOJGGCLPPAM + "_LensDirtIntensity" + ex.ToString());
		}
	}

	// Token: 0x0600DDCF RID: 56783 RVA: 0x004EB664 File Offset: 0x004E9864
	private void BJLLDIOIJFB(GameObject MPNMOONBMII, GameObject OJICGBOIKNA)
	{
		MPNMOONBMII.transform.SetParent(OJICGBOIKNA.GetComponent<EnvironmentController>().GetChild());
		MPNMOONBMII.transform.localPosition = new Vector3(0f, 0f, 0f);
	}

	// Token: 0x0600DDD0 RID: 56784 RVA: 0x004EB69B File Offset: 0x004E989B
	public void SetSatelliteColor(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetColor(Helpers.HexToColor(PNDBJMFMGBK), 10f);
	}

	// Token: 0x0600DDD1 RID: 56785 RVA: 0x004EB6B3 File Offset: 0x004E98B3
	public void SetSatelliteInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDD2 RID: 56786 RVA: 0x004EB6CC File Offset: 0x004E98CC
	[PunRPC]
	public void SetSpeed(string KEDDLFDAIDE)
	{
		try
		{
			this.IBLOGKONFJD(float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetSpeed error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDD3 RID: 56787 RVA: 0x004EB71C File Offset: 0x004E991C
	private IEnumerator BFALBMDPNJG()
	{
		yield return null;
		yield break;
	}

	// Token: 0x0600DDD4 RID: 56788 RVA: 0x004EB730 File Offset: 0x004E9930
	public void PEGMONDACNM()
	{
		if (PhotonNetwork.playerList.Length > 1)
		{
			this.spectrid = 0;
			this.currentState = (PlayerBase.PlayerState)7;
			this.Spectrate(PhotonNetwork.playerList[this.spectrid].ID);
		}
	}

	// Token: 0x0600DDD5 RID: 56789 RVA: 0x004EB764 File Offset: 0x004E9964
	public void StartReplayRecording()
	{
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID);
		if (mapData != null)
		{
			string ddaomdpaiep = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			this.currentReplay = new RanksSystem.MapReplay(this.gameScene.mapID, Helpers.CalculateMD5(ddaomdpaiep).ToUpper(), string.Empty + SteamUser.GetSteamID().m_SteamID, this.arcsDelay);
			base.StartCoroutine(this.AJOPLECODPP(this.currentReplay));
		}
	}

	// Token: 0x0600DDD6 RID: 56790 RVA: 0x004EB804 File Offset: 0x004E9A04
	[PunRPC]
	public void LostLive(bool OJANLCEKFPN)
	{
		this.currentCombo = 0;
		if ((base.photonView.isMine || (this.gameScene.pbase.currentState == PlayerBase.PlayerState.Spectator && this.gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)) && this.gameScene.gameMode != GameScene.GameMode.Relax && base.GetComponentInChildren<AudioListener>().enabled)
		{
			if (OJANLCEKFPN)
			{
				SoundManager.PlayHitSfx(2, UnityEngine.Random.Range(0.7f, 1.3f));
			}
			else
			{
				SoundManager.PlayHitSfx(3, UnityEngine.Random.Range(0.7f, 1.3f));
			}
		}
		if (this.gameScene.pbase.currentState == PlayerBase.PlayerState.Spectator && this.gameScene.pbase.spectatedPlayerBase.photonView.viewID == base.photonView.viewID)
		{
			if (this.gameScene.pbase.GetComponentInChildren<CameraShake>())
			{
				this.gameScene.pbase.GetComponentInChildren<CameraShake>().DoShake();
			}
			this.gameScene.pbase.SetLives(this.lives);
		}
		if (this.lives > 0)
		{
			this.lives--;
			if (base.GetComponentInChildren<CameraShake>())
			{
				base.GetComponentInChildren<CameraShake>().DoShake();
			}
			this.incorrectScore = ++this.incorrectScore;
		}
		if (this.lives < 1)
		{
			this.FinishMap();
		}
	}

	// Token: 0x0600DDD7 RID: 56791 RVA: 0x004E5677 File Offset: 0x004E3877
	public void KCMADOKFCLM(int BOAKOPHKGHC)
	{
		this._lives = BOAKOPHKGHC;
	}

	// Token: 0x0600DDD8 RID: 56792 RVA: 0x004EB99F File Offset: 0x004E9B9F
	[CompilerGenerated]
	private static int KKDGOEJNNMI(MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC)
	{
		return DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time);
	}

	// Token: 0x0600DDD9 RID: 56793 RVA: 0x004EB9B4 File Offset: 0x004E9BB4
	public void CLNHKLHPEGE()
	{
		this.environmentBase.SetActive(false);
		TrailRenderer[] componentsInChildren = this.environmentBase.transform.GetComponentsInChildren<TrailRenderer>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			TrailRenderer trailRenderer = componentsInChildren[i];
			trailRenderer.Clear();
		}
		if (this.crosshairsList.Count > 0)
		{
			this.crosshairsList[0].BFLNNFJCLLC(new Vector3(697f, 1888f, 817f));
			this.crosshairsList[1].EHNKGKELFCC(new Vector3(1919f, 750f, 1750f));
		}
	}

	// Token: 0x0600DDDA RID: 56794 RVA: 0x004EBA57 File Offset: 0x004E9C57
	public void NEIAAFPOOAM(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetGravity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDDB RID: 56795 RVA: 0x004EBA70 File Offset: 0x004E9C70
	public void StopReplayRecording()
	{
		if (this.currentReplay != null)
		{
			try
			{
				this.currentReplay.activeProcesses = this.myJob.activeProcesses.Distinct<string>().ToList<string>();
			}
			catch (Exception)
			{
			}
			this.currentReplay.FinishPlaying(this.GetCurrentScore(), this.checkpointsUsed, this.accuracyScore, this.incorrectScore, this.comboScore, this.penaltyScore);
		}
	}

	// Token: 0x0600DDDC RID: 56796 RVA: 0x004EBB0C File Offset: 0x004E9D0C
	public void ANIIKMEJAFL(string NOJGGCLPPAM)
	{
		try
		{
			char[] array = new char[1];
			array[1] = '\u001c';
			string[] array2 = NOJGGCLPPAM.Split(array);
			if (array2.Length > 6)
			{
				Color hablfkcckln = new Color(float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[1], CultureInfo.InvariantCulture), float.Parse(array2[7], CultureInfo.InvariantCulture));
				this.HPFKGCKKLCM(hablfkcckln, float.Parse(array2[4], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hablfkcckln2 = Helpers.HexToColor(NOJGGCLPPAM);
				this.SetBGColor(hablfkcckln2, float.Parse(array2[0], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("_TimeX" + ex.ToString());
		}
	}

	// Token: 0x0600DDDD RID: 56797 RVA: 0x004EBBC8 File Offset: 0x004E9DC8
	public void JJPAFEHGADI(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		if (base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			this.playerController.OGACJDOPABH(FLMFNIGKHKP, HMPOIDIAIMI, 1476f);
			this.IJKNIDJCBPA();
		}
		else if (this.gameScene.pbase.currentState == PlayerBase.PlayerState.Spectator && this.KADBPIPMIBF().pbase.spectatedPlayerBase.GBHNDHLAJLI().KINIHBOKFJH() == base.GBMJAPGLMGB().NPPEFODKHKN())
		{
			this.KADBPIPMIBF().pbase.spectatedPlayerBase.playerController.PPJDDKHHDMP(FLMFNIGKHKP, HMPOIDIAIMI, 673f);
		}
	}

	// Token: 0x0600DDDE RID: 56798 RVA: 0x004EBC64 File Offset: 0x004E9E64
	public void SetCrosshairColor(Color HABLFKCCKLN, float MNHBOECHFEG = 10f)
	{
		foreach (CrosshairController crosshairController in this.crosshairsList)
		{
			crosshairController.SetColor(HABLFKCCKLN, MNHBOECHFEG);
		}
	}

	// Token: 0x0600DDDF RID: 56799 RVA: 0x004EBCC4 File Offset: 0x004E9EC4
	public void LoadPlayerData()
	{
		Debug.Log("[PlayerBase] Loading checkpoint data");
		string str = this.gameScene.mapID + "." + this.gameScene.gameMode.ToString().ToLower();
		this.isMapCompleted = Singleton<SaveSystem>.Instance.GetBool("maps." + str + ".lastCheckpoint.isMapCompleted", null);
		this.lives = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.lives", null);
		this.correctScore = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.correctScore", null);
		this.checkpointsUsed = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.checkpointsUsed", 0, null);
		this.checkpointsUsed = ++this.checkpointsUsed;
		Singleton<SaveSystem>.Instance.SetInt("maps." + str + ".lastCheckpoint.checkpointsUsed", this.checkpointsUsed, null);
		this.incorrectScore = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.incorrectScore", null);
		this.perfectHits = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.perfectHits", null);
		this.powerupsScore = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.powerupsScore", null);
		this.penaltyScore = Singleton<SaveSystem>.Instance.GetFloat("maps." + str + ".lastCheckpoint.penaltyScore", null);
		this.comboScore = Singleton<SaveSystem>.Instance.GetFloat("maps." + str + ".lastCheckpoint.comboScore", null);
		this.currentCombo = Singleton<SaveSystem>.Instance.GetInt("maps." + str + ".lastCheckpoint.currentCombo", null);
		this.playerDistance = Singleton<SaveSystem>.Instance.GetFloat("maps." + str + ".lastCheckpoint.playerdistance", null);
		Color color = Helpers.GetColor("maps." + str + ".lastCheckpoint.bgcolor", Color.black);
		this.SetBGColor(color, 10f);
	}

	// Token: 0x0600DDE0 RID: 56800 RVA: 0x004EBF04 File Offset: 0x004EA104
	public void StartFromBegining()
	{
		this.lastCheckpoint = 0f;
		this.wasCheckpoint = false;
		this.lives = this.fullLevelData.mapData.lives;
		this.isMapCompleted = false;
		this.correctScore = 0;
		this.checkpointsUsed = 0;
		this.loopsCount = 0;
		this.accuracyScore = 0f;
		this.penaltyScore = 0f;
		this.comboScore = 0f;
		this.perfectHits = 0;
		this.incorrectScore = 0;
		this.powerupsScore = 0;
		this.currentCombo = 0;
	}

	// Token: 0x0600DDE1 RID: 56801 RVA: 0x004EBFC4 File Offset: 0x004EA1C4
	[PunRPC]
	public void LoadPlayerSkin(string BNJFKKGOACF)
	{
		this.pspawner.segments.Clear();
		this.pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Up]"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Right]"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Down]"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("Items/" + BNJFKKGOACF + "/Segment-[Left]"));
		this.pspawner.segments.Add(Resources.Load<GameObject>("Gameplay/Segment-[PowerUp]"));
		this.levelCanvasImage = this.gameScene.levelCanvasImage;
		this.sunGameObject = Resources.Load<GameObject>("Gameplay/sun");
		this.satelliteGameObject = Resources.Load<GameObject>("Gameplay/satellite");
		this.particlesGameObject = Resources.Load<GameObject>("Gameplay/particles");
		this.spriteGameObject = Resources.Load<GameObject>("Gameplay/sprite");
		this.pspawner.segments.Add(this.levelCanvasImage);
		this.pspawner.segments.Add(this.sunGameObject);
		this.pspawner.segments.Add(this.satelliteGameObject);
		this.pspawner.segments.Add(this.particlesGameObject);
		this.pspawner.segments.Add(this.spriteGameObject);
		foreach (GameObject prefab in this.pspawner.segments)
		{
			TrashManRecycleBin khnadifnkfm = new TrashManRecycleBin
			{
				prefab = prefab,
				instancesToPreallocate = 20
			};
			TrashMan.manageRecycleBin(khnadifnkfm, string.Empty + base.photonView.ownerId);
		}
		Debug.Log("[PlayerBase] Loaded custom model: " + BNJFKKGOACF);
		GameObject gameObject = this.objects_3;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		List<string> list = new List<string>
		{
			"[Up]",
			"[Right]",
			"[Down]",
			"[Left]"
		};
		using (List<string>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				PlayerBase.GGIHJGAKLPO ggihjgaklpo = new PlayerBase.GGIHJGAKLPO();
				ggihjgaklpo.LEFMNANHGDA = enumerator2.Current;
				GameObject original = this.pspawner.segments.Find(new Predicate<GameObject>(ggihjgaklpo.GBKBDKHPLKG));
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(original, gameObject.transform);
				gameObject2.transform.localPosition = Vector3.zero;
				gameObject2.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
				gameObject2.transform.localScale = Vector3.one;
				gameObject2.GetComponent<MoveF>().enabled = false;
				gameObject2.GetComponent<Collider>().enabled = false;
				gameObject2.GetComponent<SegmentHandler>().enabled = false;
				gameObject2.GetComponent<IncreseAlpha>().enabled = false;
			}
		}
		gameObject.SetActive(false);
	}

	// Token: 0x0600DDE2 RID: 56802 RVA: 0x004EC35C File Offset: 0x004EA55C
	public void EKINONIACHB(GameObject MPNMOONBMII, string PNDBJMFMGBK, string JMPOJNOBLPH)
	{
		MPNMOONBMII.GetComponent<SunController>().CHOKKIPDAPF(Helpers.HexToColor(PNDBJMFMGBK), Helpers.HexToColor(JMPOJNOBLPH), 1665f);
	}

	// Token: 0x0600DDE3 RID: 56803 RVA: 0x004EC37C File Offset: 0x004EA57C
	[PunRPC]
	public void SetBGColor(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split(new char[]
			{
				','
			});
			if (array.Length > 3)
			{
				Color hablfkcckln = new Color(float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
				this.SetBGColor(hablfkcckln, float.Parse(array[3], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hablfkcckln2 = Helpers.HexToColor(NOJGGCLPPAM);
				this.SetBGColor(hablfkcckln2, float.Parse(array[1], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] SetBGColor error: " + ex.ToString());
		}
	}

	// Token: 0x0600DDE4 RID: 56804 RVA: 0x004EC438 File Offset: 0x004EA638
	public void SetSunMinSize(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 minSize = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetMinSize(minSize);
	}

	// Token: 0x0600DDE5 RID: 56805 RVA: 0x004EC47A File Offset: 0x004EA67A
	public void ONOEOGGMDAP(string LHCIHJOHGEJ)
	{
		if (this.Replay() != null)
		{
			this.Replay().RecordAction(this.KADBPIPMIBF().DADGJKNFIIK(), LHCIHJOHGEJ);
		}
	}

	// Token: 0x0600DDE6 RID: 56806 RVA: 0x004EC4A4 File Offset: 0x004EA6A4
	[PunRPC]
	public void FinishMap()
	{
		this.currentState = PlayerBase.PlayerState.Finished;
		if (base.photonView.isMine)
		{
			this.playerController.isSpectator = true;
			ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"finished",
					true
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
			{
				{
					"win",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, false);
			if (this.wasCheckpoint && this.gameScene.HPAnimationTime - this.lastCheckpoint <= 1f)
			{
				this.ach12 = true;
			}
			if (!this.gameScene.gameOver)
			{
				this.gameScene.ShowResult(string.Empty);
			}
		}
	}

	// Token: 0x0600DDE7 RID: 56807 RVA: 0x004EC578 File Offset: 0x004EA778
	public void PLJGFDFCHDL(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDE8 RID: 56808 RVA: 0x004EBA57 File Offset: 0x004E9C57
	public void SetParticlesGravity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetGravity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDE9 RID: 56809 RVA: 0x004EC590 File Offset: 0x004EA790
	public void UpdateComboTimer(float FGFEGFGPGHI)
	{
		if (FGFEGFGPGHI < 5f)
		{
			this.comboTimer += (5f - FGFEGFGPGHI) / 5f;
		}
	}

	// Token: 0x0600DDEA RID: 56810 RVA: 0x004EC5B7 File Offset: 0x004EA7B7
	public void KPDMNLDPBID(GameObject MPNMOONBMII, string PNDBJMFMGBK, string KEDDLFDAIDE)
	{
		MPNMOONBMII.GetComponent<SpriteController>().BDHJEDNAKNO(Helpers.HexToColor(PNDBJMFMGBK), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDEB RID: 56811 RVA: 0x004EC5D8 File Offset: 0x004EA7D8
	public void ECFDCBDFFHL(string NOJGGCLPPAM)
	{
		try
		{
			string[] array = NOJGGCLPPAM.Split(new char[]
			{
				(char)-95
			});
			if (array.Length > 8)
			{
				Color hablfkcckln = new Color(float.Parse(array[1], CultureInfo.InvariantCulture), float.Parse(array[0], CultureInfo.InvariantCulture), float.Parse(array[2], CultureInfo.InvariantCulture));
				this.GLGGHDOKHFE(hablfkcckln, float.Parse(array[6], CultureInfo.InvariantCulture));
			}
			else
			{
				Color hablfkcckln2 = Helpers.HexToColor(NOJGGCLPPAM);
				this.HPFKGCKKLCM(hablfkcckln2, float.Parse(array[1], CultureInfo.InvariantCulture));
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("<color=white>" + ex.ToString());
		}
	}

	// Token: 0x0600DDEC RID: 56812 RVA: 0x004EC694 File Offset: 0x004EA894
	private IEnumerator CLHHFCILABL()
	{
		yield return null;
		yield break;
	}

	// Token: 0x0600DDED RID: 56813 RVA: 0x004EC6A8 File Offset: 0x004EA8A8
	public void NOAAMEEMJKN()
	{
		if (PhotonNetwork.playerList.Length > 1)
		{
			this.spectrid = 0;
			this.currentState = (PlayerBase.PlayerState)6;
			this.Spectrate(PhotonNetwork.playerList[this.spectrid].ID);
		}
	}

	// Token: 0x0600DDEE RID: 56814 RVA: 0x004EC6DC File Offset: 0x004EA8DC
	public void GIDKEMDGEPI(float PNNFAOFBLHK)
	{
		this.playerDistance = PNNFAOFBLHK;
	}

	// Token: 0x0600DDF0 RID: 56816 RVA: 0x004E5C4F File Offset: 0x004E3E4F
	public void HPFKGCKKLCM(Color HABLFKCCKLN, float KEDDLFDAIDE)
	{
		this.bgcolor = HABLFKCCKLN;
		this.colorLerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600DDF1 RID: 56817 RVA: 0x004EC7F7 File Offset: 0x004EA9F7
	public void FIOCKDLFIBF(GameObject MPNMOONBMII, string ACABBJEAMGG)
	{
		MPNMOONBMII.GetComponent<SpriteController>().BPBMKAEMIJC((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.KADBPIPMIBF().mapID).resources[ACABBJEAMGG]);
	}

	// Token: 0x0600DDF2 RID: 56818 RVA: 0x004EC82E File Offset: 0x004EAA2E
	public void EMDDGALHKOJ(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().HEFDKAKLJMB(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDF3 RID: 56819 RVA: 0x004E5664 File Offset: 0x004E3864
	private void NLBFEGAFLBL(float AIEJPEPBAEJ)
	{
		this.currentArcsSpeed = -AIEJPEPBAEJ;
	}

	// Token: 0x0600DDF4 RID: 56820 RVA: 0x004EC846 File Offset: 0x004EAA46
	public void HMAPNECCIFP()
	{
		if (base.GMAHNPNHMFK().KCAOJFPDEIP() && this.lives < this.fullLevelData.mapData.maxLives)
		{
			this.lives = this.NCBBBJINGMM() + 1;
		}
	}

	// Token: 0x0600DDF5 RID: 56821 RVA: 0x004EC881 File Offset: 0x004EAA81
	public void FMHJJIKIAJJ(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().HOCOJMHOCPA(Helpers.HexToColor(PNDBJMFMGBK), 347f);
	}

	// Token: 0x0600DDF6 RID: 56822 RVA: 0x004EC89C File Offset: 0x004EAA9C
	public void KEGEOALBFOC()
	{
		Debug.Log("Environment/SunBase_");
		string str = this.gameScene.mapID + ".lastCheckpoint.playerdistance" + this.KADBPIPMIBF().gameMode.ToString().ToLower();
		this.isMapCompleted = Singleton<SaveSystem>.Instance.GetBool("_TileMaxOffs" + str + "/", null);
		this.lives = Singleton<SaveSystem>.Instance.JLPLKBDBIJC("FinalScoreText" + str + " does not exist!", null);
		this.correctScore = Singleton<SaveSystem>.Instance.DNBCCNHDJDK("effector" + str + ".lastCheckpoint.lives", null);
		this.checkpointsUsed = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("_FarCamera" + str + "_Bloom2", 0, null);
		this.checkpointsUsed = ++this.checkpointsUsed;
		Singleton<SaveSystem>.Instance.SetInt("settings_bindings_" + str + "CameraFilterPack/Blend2Camera_Color", this.checkpointsUsed, null);
		this.incorrectScore = Singleton<SaveSystem>.Instance.PPBFNLHCKCP("shader.none" + str + " Server: ", null);
		this.perfectHits = Singleton<SaveSystem>.Instance.PPBFNLHCKCP("Please specify a map name or buildID" + str + "https://steamcommunity.com/sharedfiles/filedetails/?id=", null);
		this.powerupsScore = Singleton<SaveSystem>.Instance.DNBCCNHDJDK(" - LOCAL" + str + "ResourceIDInputField", null);
		this.penaltyScore = Singleton<SaveSystem>.Instance.GLDCKMNIIDE("_Value2" + str + ".jpg", null);
		this.comboScore = Singleton<SaveSystem>.Instance.GLDCKMNIIDE("_Saturation" + str + "[PlayerController] ", null);
		this.currentCombo = Singleton<SaveSystem>.Instance.DNBCCNHDJDK(" left" + str + "Object ID", null);
		this.playerDistance = Singleton<SaveSystem>.Instance.GetFloat("return " + str + "_MainTex2", null);
		Color color = Helpers.GetColor("CameraFilterPack/BlurTiltShift_Hole" + str + "_MainTex2", Color.black);
		this.HPFKGCKKLCM(color, 1800f);
	}

	// Token: 0x0600DDF7 RID: 56823 RVA: 0x004ECADC File Offset: 0x004EACDC
	public IEnumerator GAIAGDBAELF(float CGPOHGMFCKC = 0f)
	{
		if (this.fullLevelData.clip == null)
		{
			fullName = new FileInfo(this.fullLevelData.fullLevelPath + "/" + this.fullLevelData.mapData.musicFile).FullName;
			yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAudio(fullName, fullName, true, false, false));
			this.fullLevelData.clip = (AudioClip)ResourcesManager.GetLoadedResource(fullName);
		}
		if (this.fullLevelData.mapData.musicTime <= 0f && this.fullLevelData.mapData.configVersion < 2)
		{
			Debug.LogWarning("[PlayerBase] Config error: musicTime <= 0");
			this.fullLevelData.mapData.musicTime = this.fullLevelData.clip.length;
			this.gameScene.calculatedmaptime = this.fullLevelData.clip.length;
		}
		if (this.isStoryboardEnabled)
		{
			yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID)));
		}
		this.gameScene.asampler.Init(this.fullLevelData.clip, (CGPOHGMFCKC <= 0f) ? CGPOHGMFCKC : this.pretime, false);
		Debug.Log("[PlayerBase] Loaded music");
		this.gameScene.ingameUICanvas.transform.FindDeepChild("LevelProgressBar").GetComponent<Slider>().maxValue = this.gameScene.calculatedmaptime;
		this.isMusicLoaded = true;
		if (this.fullLevelData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(this.fullLevelData.workshopId))
		{
			string s = this.fullLevelData.workshopId;
			RanksSystem.PrintStats(ulong.Parse(s));
			if (this.fullLevelData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(s), false) && this.gameScene.gameMode == GameScene.GameMode.Normal && !RanksSystem.IsOfficial(ulong.Parse(s), true))
			{
				Singleton<MessageBoxPanel>.Instance.DisplayMessage("#outdatedmap! Challenges will not work!", "#ok", null, true, false, 0f);
			}
		}
		if (base.photonView.isMine)
		{
			this.Loaded();
		}
		yield break;
	}

	// Token: 0x0600DDF8 RID: 56824 RVA: 0x004ECAFE File Offset: 0x004EACFE
	public void SetParticlesParticleSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetParticleSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDF9 RID: 56825 RVA: 0x004ECB18 File Offset: 0x004EAD18
	public void UpdateMapGameMode()
	{
		this.gameScene.hiddenImage.gameObject.SetActive(this.gameScene.gameMode == GameScene.GameMode.Hidden);
		foreach (MapEvent mapEvent in this.fullLevelData.mapData.events)
		{
			if (mapEvent.data[0] == "SpawnObj")
			{
				if (this.gameScene.gameMode == GameScene.GameMode.Random)
				{
					List<string> list = mapEvent.data[1].Split(new char[]
					{
						','
					}).ToList<string>();
					int num = list[0].Split(new char[]
					{
						'-'
					}).Length;
					List<string> list2 = new List<string>();
					string a = list[0];
					float num2 = 0.199999988f;
					float num3 = 0.5f;
					float num4 = 0.9f;
					if (a == Helpers.patternsMap[0])
					{
						list2.Add(Helpers.patternsMap[1]);
						list2.Add(Helpers.patternsMap[2]);
						list2.Add(Helpers.patternsMap[3]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[0]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num3)
						{
							list2.Add(Helpers.patternsMap[10]);
							list2.Add(Helpers.patternsMap[12]);
						}
					}
					if (a == Helpers.patternsMap[1])
					{
						list2.Add(Helpers.patternsMap[0]);
						list2.Add(Helpers.patternsMap[2]);
						list2.Add(Helpers.patternsMap[3]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[1]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num3)
						{
							list2.Add(Helpers.patternsMap[10]);
							list2.Add(Helpers.patternsMap[13]);
						}
					}
					if (a == Helpers.patternsMap[2])
					{
						list2.Add(Helpers.patternsMap[0]);
						list2.Add(Helpers.patternsMap[1]);
						list2.Add(Helpers.patternsMap[3]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[2]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num3)
						{
							list2.Add(Helpers.patternsMap[13]);
							list2.Add(Helpers.patternsMap[15]);
						}
					}
					if (a == Helpers.patternsMap[3])
					{
						list2.Add(Helpers.patternsMap[0]);
						list2.Add(Helpers.patternsMap[1]);
						list2.Add(Helpers.patternsMap[2]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[3]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num3)
						{
							list2.Add(Helpers.patternsMap[12]);
							list2.Add(Helpers.patternsMap[15]);
						}
					}
					if (a == Helpers.patternsMap[10])
					{
						list2.Add(Helpers.patternsMap[10]);
						list2.Add(Helpers.patternsMap[12]);
						list2.Add(Helpers.patternsMap[13]);
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[4]);
							list2.Add(Helpers.patternsMap[5]);
						}
					}
					if (a == Helpers.patternsMap[11])
					{
						list2.Add(Helpers.patternsMap[14]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[11]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[5]);
							list2.Add(Helpers.patternsMap[7]);
						}
					}
					if (a == Helpers.patternsMap[12])
					{
						list2.Add(Helpers.patternsMap[10]);
						list2.Add(Helpers.patternsMap[12]);
						list2.Add(Helpers.patternsMap[15]);
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[4]);
							list2.Add(Helpers.patternsMap[7]);
						}
					}
					if (a == Helpers.patternsMap[13])
					{
						list2.Add(Helpers.patternsMap[10]);
						list2.Add(Helpers.patternsMap[13]);
						list2.Add(Helpers.patternsMap[15]);
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[5]);
							list2.Add(Helpers.patternsMap[6]);
						}
					}
					if (a == Helpers.patternsMap[14])
					{
						list2.Add(Helpers.patternsMap[11]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[14]);
						}
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[4]);
							list2.Add(Helpers.patternsMap[6]);
						}
					}
					if (a == Helpers.patternsMap[15])
					{
						list2.Add(Helpers.patternsMap[12]);
						list2.Add(Helpers.patternsMap[13]);
						list2.Add(Helpers.patternsMap[15]);
						if (UnityEngine.Random.Range(0f, 1f) > num4)
						{
							list2.Add(Helpers.patternsMap[6]);
							list2.Add(Helpers.patternsMap[7]);
						}
					}
					if (a == Helpers.patternsMap[4])
					{
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[6]);
						list2.Add(Helpers.patternsMap[7]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[4]);
						}
					}
					if (a == Helpers.patternsMap[5])
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[6]);
						list2.Add(Helpers.patternsMap[7]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[5]);
						}
					}
					if (a == Helpers.patternsMap[6])
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[7]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[6]);
						}
					}
					if (a == Helpers.patternsMap[7])
					{
						list2.Add(Helpers.patternsMap[4]);
						list2.Add(Helpers.patternsMap[5]);
						list2.Add(Helpers.patternsMap[6]);
						if (UnityEngine.Random.Range(0f, 1f) > num2)
						{
							list2.Add(Helpers.patternsMap[7]);
						}
					}
					if (a == Helpers.patternsMap[8])
					{
						list2.Add(Helpers.patternsMap[8]);
					}
					if (a == Helpers.patternsMap[9])
					{
						list2.Add(Helpers.patternsMap[9]);
					}
					if (list2.Count > 0)
					{
						list[0] = list2[UnityEngine.Random.Range(0, list2.Count)];
						mapEvent.data[1] = string.Join(",", list.ToArray());
					}
				}
				else if (this.gameScene.gameMode == GameScene.GameMode.Endless)
				{
				}
			}
		}
	}

	// Token: 0x0600DDFA RID: 56826 RVA: 0x004ED4C4 File Offset: 0x004EB6C4
	public void SpectateNext(bool BAMMECKEJKB)
	{
		if (PhotonNetwork.playerList.Length > 1)
		{
			if (BAMMECKEJKB)
			{
				if (this.spectrid < PhotonNetwork.playerList.Length - 1)
				{
					this.spectrid++;
				}
				else
				{
					this.spectrid = 0;
				}
			}
			else if (this.spectrid > 0)
			{
				this.spectrid--;
			}
			else
			{
				this.spectrid = 0;
			}
			this.Spectrate(PhotonNetwork.playerList[this.spectrid].ID);
		}
	}

	// Token: 0x0600DDFB RID: 56827 RVA: 0x004ED554 File Offset: 0x004EB754
	public GameObject NOMLPCLHPKG(string ACABBJEAMGG, string JMMILEFMACB, string KEDDLFDAIDE, string HABLFKCCKLN)
	{
		SpriteController component = this.ABAIBAMGNDA("_Value2", JMMILEFMACB).GetComponent<SpriteController>();
		if (component)
		{
			component.SetResource((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[ACABBJEAMGG]);
			component.DPOGDACJIMM(Helpers.HexToColor(HABLFKCCKLN), float.Parse(KEDDLFDAIDE, CultureInfo.InvariantCulture));
			return component.gameObject;
		}
		return null;
	}

	// Token: 0x0600DDFC RID: 56828 RVA: 0x004EC6DC File Offset: 0x004EA8DC
	public void SetPlayerDistance(float PNNFAOFBLHK)
	{
		this.playerDistance = PNNFAOFBLHK;
	}

	// Token: 0x0600DDFD RID: 56829 RVA: 0x004ED5CE File Offset: 0x004EB7CE
	public void SetSunLerpSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DDFE RID: 56830 RVA: 0x004ED5E8 File Offset: 0x004EB7E8
	public void IEHGEJNAPGL(int FLMFNIGKHKP, int HMPOIDIAIMI)
	{
		if (base.GBMJAPGLMGB().DOLKFPIABDD())
		{
			this.playerController.NLPAHKLGJMK(FLMFNIGKHKP, HMPOIDIAIMI, 768f);
			this.SendScore();
		}
		else if (this.KADBPIPMIBF().pbase.currentState == (PlayerBase.PlayerState)7 && this.gameScene.pbase.spectatedPlayerBase.BLMHOKPIMOD().EIMHMIJGMHG() == base.FFIPLLNKGEN().KINIHBOKFJH())
		{
			this.gameScene.pbase.spectatedPlayerBase.playerController.AEDJKCPNEOC(FLMFNIGKHKP, HMPOIDIAIMI, 1345f);
		}
	}

	// Token: 0x0600DDFF RID: 56831 RVA: 0x004ED683 File Offset: 0x004EB883
	public void EKLEEPCLCNE(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().HAICKBPCHBK(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE00 RID: 56832 RVA: 0x004ED69C File Offset: 0x004EB89C
	public void EPEOEBCFLLG(string EHHBHEJBHNG)
	{
		try
		{
			if (base.GBHNDHLAJLI().isMine && this.currentState != PlayerBase.PlayerState.Loading && this.currentState != (PlayerBase.PlayerState)6)
			{
				this.lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("subscribeall" + this.lastCheckpoint);
				this.SavePlayerData();
				this.KADBPIPMIBF().AddMessage(LocalizationService.Instance.GetLocalizatedText("\r"), 1858f);
				this.wasCheckpoint = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("#changenote" + ex.ToString());
		}
	}

	// Token: 0x0600DE01 RID: 56833 RVA: 0x004ED758 File Offset: 0x004EB958
	private void NFFGCGCDADK(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(base.photonView.KCAOJFPDEIP());
	}

	// Token: 0x0600DE02 RID: 56834 RVA: 0x004ED76B File Offset: 0x004EB96B
	public void FKKPEHGFOPE(GameObject MPNMOONBMII, string PNDBJMFMGBK, string JMPOJNOBLPH)
	{
		MPNMOONBMII.GetComponent<SunController>().DICHOHBLHAH(Helpers.HexToColor(PNDBJMFMGBK), Helpers.HexToColor(JMPOJNOBLPH), 1918f);
	}

	// Token: 0x0600DE03 RID: 56835 RVA: 0x004EC578 File Offset: 0x004EA778
	public void SetSatelliteLerpSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE04 RID: 56836 RVA: 0x004ED789 File Offset: 0x004EB989
	[CompilerGenerated]
	private void FMJLFFEEEDP(GameObject IACGDFHKCAE)
	{
		IACGDFHKCAE.SetActive(base.photonView.isMine);
	}

	// Token: 0x0600DE05 RID: 56837 RVA: 0x004ED79C File Offset: 0x004EB99C
	public void JGAIOGPEACE()
	{
		this.currentState = PlayerBase.PlayerState.Playing;
		if (base.JAEJDHHCJJO().DOLKFPIABDD())
		{
			this.playerController.isSpectator = false;
			ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"VisionBlur",
					false
				}
			};
			PhotonNetwork.player.MGMCOJHGJNO(eneebhgaajh, null, false);
			ExitGames.Client.Photon.Hashtable eneebhgaajh2 = new ExitGames.Client.Photon.Hashtable
			{
				{
					"_BlurPass",
					true
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh2, null, true);
			if (this.wasCheckpoint && this.KADBPIPMIBF().PJHGHEKLOCH() - this.lastCheckpoint <= 576f)
			{
				this.ach12 = false;
			}
			if (!this.KADBPIPMIBF().gameOver)
			{
				this.gameScene.PGELCEKONCE(string.Empty);
			}
		}
	}

	// Token: 0x0600DE06 RID: 56838 RVA: 0x004ED870 File Offset: 0x004EBA70
	public void POMFLOLIOPJ()
	{
		Debug.Log("LeaderboardsButton");
		string str = this.gameScene.mapID + "PublishButton" + this.KADBPIPMIBF().gameMode.ToString().ToLower();
		Singleton<SaveSystem>.Instance.DeleteKey("SupportLogger " + str + "GroupNameText", null);
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("s" + str + "_ScreenResolution", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("UseScanLine" + str + "_BlurRadius4", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("CurrentTimeLabel" + str + "_Visualize", null);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_Value3" + str + "_Green_C", null);
		Singleton<SaveSystem>.Instance.DeleteKey("SetEnvSpriteColor" + str + "LevelNameInputField", null);
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("_Lift" + str + ".icon", null);
		Singleton<SaveSystem>.Instance.DeleteKey("setint" + str + "_FgOverlap", null);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("_Value1" + str + "_TimeX", null);
		Singleton<SaveSystem>.Instance.DeleteKey("id" + str + "[NetworkMenu] Joining ", null);
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP("CameraFilterPack/TV_BrokenGlass" + str + "OnPlayerGameMessage", null);
		Helpers.DeleteColorKey("mapselector.filter.favoriteonly" + str + "#E14FFF");
	}

	// Token: 0x0600DE07 RID: 56839 RVA: 0x004ED9FB File Offset: 0x004EBBFB
	public void SetSunInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE08 RID: 56840 RVA: 0x004EB99F File Offset: 0x004E9B9F
	[CompilerGenerated]
	private static int KGJMABKHFBN(MapEvent DAHCBICJEHO, MapEvent HGONFEPOGHC)
	{
		return DAHCBICJEHO.time.CompareTo(HGONFEPOGHC.time);
	}

	// Token: 0x0600DE09 RID: 56841 RVA: 0x004EDA13 File Offset: 0x004EBC13
	public void SetSatelliteRotationSpeed(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetRotationSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE0A RID: 56842 RVA: 0x004EDA2B File Offset: 0x004EBC2B
	public void IIHJMAPLIPM(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().DBCGALPFIMJ(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE0B RID: 56843 RVA: 0x004EDA44 File Offset: 0x004EBC44
	public void Reset()
	{
		base.StopAllCoroutines();
		TrashMan.instance.Reset();
		Debug.Log("[PlayerBase] Reset");
		this.currentReplay = null;
		this.moveF = base.GetComponent<MoveF>();
		this.environmentObjects.Clear();
		if (base.photonView.isMine)
		{
			ExitGames.Client.Photon.Hashtable eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"ready",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"win",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			eneebhgaajh = new ExitGames.Client.Photon.Hashtable
			{
				{
					"finished",
					false
				}
			};
			PhotonNetwork.player.SetCustomProperties(eneebhgaajh, null, false);
			PhotonNetwork.player.SetScore(0);
		}
		this.arcsDelay = 0f;
		this.currentState = PlayerBase.PlayerState.Loading;
		this.lives = 5;
		this.playerDistance = 14f;
		this.bgcolor = Color.black;
		this.colorLerpSpeed = 5f;
		this.moveFSpeed = -1.5f;
		this.isMapCompleted = false;
		this.correctScore = 0;
		this.penaltyScore = 0f;
		this.comboScore = 0f;
		this.accuracyScore = 0f;
		this.checkpointsUsed = 0;
		this.loopsCount = 0;
		this.incorrectScore = 0;
		this.perfectHits = 0;
		this.powerupsScore = 0;
		this.currentCombo = 0;
		this.lastCheckpoint = 0f;
		this.isPlayerWon = false;
		this.lastBestScore = 0;
		this.currentAttempt = 0;
		this.scoreBeated = false;
		this.sunBaseSensetivity = 0f;
		this.spectrid = 0;
		this.ach12 = false;
		this.wasCheckpoint = false;
		this.currentEventID = 0;
		this.comboTimer = 0f;
		if (base.photonView.isMine)
		{
			this.playerController.enabled = true;
			this.gameScene = (GameScene)Singleton<Scene>.Instance;
			this.isMusicLoaded = false;
			this.fullLevelData = null;
			try
			{
				GameObject levelCanvas = this.gameScene.levelCanvas;
				for (int i = 0; i < levelCanvas.transform.childCount; i++)
				{
					TrashMan.despawn(levelCanvas.transform.GetChild(i).gameObject);
					if (levelCanvas.transform.GetChild(i).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(levelCanvas.transform.GetChild(i).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				GameObject gameObject = this.bgLevelCanvas;
				for (int j = 0; j < gameObject.transform.childCount; j++)
				{
					TrashMan.despawn(gameObject.transform.GetChild(j).gameObject);
					if (gameObject.transform.GetChild(j).gameObject.activeSelf)
					{
						UnityEngine.Object.Destroy(gameObject.transform.GetChild(j).gameObject);
					}
				}
			}
			catch (Exception)
			{
			}
		}
		if (this.environmentBase)
		{
			UnityEngine.Object.DestroyImmediate(this.environmentBase);
		}
		bool flag = (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinnormal", 1, null) == 1 && this.gameScene.gameMode != GameScene.GameMode.Relax) || (Singleton<SaveSystem>.Instance.GetInt("settings.enablehitsoundsinrelax", 0, null) == 1 && this.gameScene.gameMode == GameScene.GameMode.Relax);
		this.arcsDelay = ((!flag) ? Singleton<SaveSystem>.Instance.GetFloat("settings.arcsnohitsoundtimedelay", 0f, null) : Singleton<SaveSystem>.Instance.GetFloat("settings.arcshitsoundtimedelay", -0.11f, null));
		this.isStoryboardEnabled = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false, null);
	}

	// Token: 0x0600DE0C RID: 56844 RVA: 0x004EDE60 File Offset: 0x004EC060
	public void SetSatelliteTrailLength(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailLength(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE0D RID: 56845 RVA: 0x004EDE78 File Offset: 0x004EC078
	public void SetEnvSpriteImage(GameObject MPNMOONBMII, string ACABBJEAMGG)
	{
		MPNMOONBMII.GetComponent<SpriteController>().SetResource((Sprite)Singleton<MapsSystem>.Instance.GetMapData(this.gameScene.mapID).resources[ACABBJEAMGG]);
	}

	// Token: 0x0600DE0E RID: 56846 RVA: 0x004EDEAF File Offset: 0x004EC0AF
	public void FJCMHJKGENH(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().FJKEADHFDME(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE0F RID: 56847 RVA: 0x004EDEC8 File Offset: 0x004EC0C8
	public void FNNKEDGKHII(string NOJGGCLPPAM, bool GABGBBMBIHK = false)
	{
		try
		{
			if ((GABGBBMBIHK && this.currentState == PlayerBase.PlayerState.Loading) || (!GABGBBMBIHK && this.KADBPIPMIBF().pbase.currentState != PlayerBase.PlayerState.Playing && this.gameScene.pbase.spectatedPlayerBase.photonView.KINIHBOKFJH() == base.GBHNDHLAJLI().EIMHMIJGMHG()))
			{
				char[] array = new char[1];
				array[1] = (char)-85;
				string[] array2 = NOJGGCLPPAM.Split(array);
				string text = array2[1];
				char[] array3 = new char[1];
				array3[1] = 'Q';
				string[] array4 = text.Split(array3);
				string[] array5 = array4;
				for (int i = 0; i < array5.Length; i++)
				{
					PlayerBase.OCCEFLJGJGH occefljgjgh = new PlayerBase.OCCEFLJGJGH();
					occefljgjgh.ENECJINHBEG = array5[i];
					PlayerSpawner playerSpawner = this.pspawner;
					if (this.currentState == (PlayerBase.PlayerState)4)
					{
						playerSpawner = this.spectatedPlayerBase.pspawner;
					}
					GameObject fkcmgbmnnka = playerSpawner.segments.Find(new Predicate<GameObject>(occefljgjgh.EKHOOPGPPGE));
					if (this.fullLevelData.mapData.configVersion > 0)
					{
						if (array2.Length > 7)
						{
							int kemdfefbioc = int.Parse(array2[1]);
							playerSpawner.MNDBJHPIOCH(fkcmgbmnnka, kemdfefbioc, float.Parse(array2[array2.Length - 1], CultureInfo.InvariantCulture));
						}
						else
						{
							playerSpawner.MFILHAGLPOI(fkcmgbmnnka, 0, float.Parse(array2[array2.Length - 0], CultureInfo.InvariantCulture));
						}
					}
					else if (array2.Length > 1)
					{
						int kemdfefbioc2 = int.Parse(array2[0]);
						playerSpawner.LEPDOCHGDLE(fkcmgbmnnka, kemdfefbioc2);
					}
					else
					{
						playerSpawner.ELJCIMPOEPL(fkcmgbmnnka, 1);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("NetworkCanvas" + ex.ToString());
		}
	}

	// Token: 0x0600DE10 RID: 56848 RVA: 0x004EE08C File Offset: 0x004EC28C
	public GameObject AddEnvironmentObject(string HMGBJCGOLMI, string JMMILEFMACB)
	{
		GameObject gameObject = null;
		if (HMGBJCGOLMI.ToLower() == "0")
		{
			gameObject = this.sunGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "1")
		{
			gameObject = this.satelliteGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "2")
		{
			gameObject = this.particlesGameObject;
		}
		if (HMGBJCGOLMI.ToLower() == "sprite")
		{
			gameObject = this.spriteGameObject;
		}
		if (gameObject)
		{
			GameObject gameObject2 = TrashMan.spawn(gameObject, this.environmentBase.transform.position, default(Quaternion));
			if (gameObject2 != null)
			{
				if (HMGBJCGOLMI.ToLower() == "0")
				{
					this.sunList.Add(gameObject2);
				}
				gameObject2.name = JMMILEFMACB;
				gameObject2.transform.SetParent(this.environmentBase.transform);
				gameObject2.GetComponent<EnvironmentController>().Awake();
				gameObject2.GetComponent<EnvironmentController>().Reset();
				if (this.environmentObjects.ContainsKey(JMMILEFMACB))
				{
					this.environmentObjects[JMMILEFMACB] = gameObject2;
				}
				else
				{
					this.environmentObjects.Add(JMMILEFMACB, gameObject2);
				}
				return gameObject2;
			}
		}
		return null;
	}

	// Token: 0x0600DE11 RID: 56849 RVA: 0x004EE1CC File Offset: 0x004EC3CC
	public void JPBHAILACAI()
	{
		this.Reset();
		this.fullLevelData = new FullMapData(Singleton<MapsSystem>.Instance.GetMapData(this.KADBPIPMIBF().mapID));
		this.currentArcsSpeed = -this.fullLevelData.mapData.speed;
		Debug.Log("_Value2");
		base.EDIJKHEMPAD().KEKKFNNMLMG(" | ", (PhotonTargets)8, null);
		this.KADBPIPMIBF().OnRestartRound();
		this.StartFromBegining();
		if (this.fullLevelData.mapData.checkpoints.Count > 1 && this.CanResumeFromCheckpoint() && base.OELHGNKAMEG().isMine)
		{
			this.ResumeFromCheckpoint();
		}
		if (this.gameScene.gameMode == GameScene.GameMode.Normal)
		{
			this.KCMADOKFCLM(1);
		}
		if (base.FFIPLLNKGEN().isMine)
		{
			float num;
			if (this.gameScene.usingCheckpoints)
			{
				SaveSystem instance = Singleton<SaveSystem>.Instance;
				string[] array = new string[1];
				array[0] = "_HalfResolution";
				array[1] = this.gameScene.mapID;
				array[1] = "L1";
				array[6] = this.KADBPIPMIBF().gameMode.ToString().ToLower();
				array[2] = "\"";
				num = instance.OJHPDDLNAGH(string.Concat(array), 1140f, null);
			}
			else
			{
				num = 686f;
			}
			float num2 = num;
			this.PrepareMapTiming(num2);
			this.UpdateMapGameMode();
			if (!this.isMusicLoaded)
			{
				base.StartCoroutine(this.GAIAGDBAELF(num2));
			}
		}
	}

	// Token: 0x0600DE12 RID: 56850 RVA: 0x004ED5CE File Offset: 0x004EB7CE
	public void FIBEGLNEFMO(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetLerpSpeed(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x0600DE1F RID: 56863 RVA: 0x004E5482 File Offset: 0x004E3682
	// (set) Token: 0x0600DE13 RID: 56851 RVA: 0x004EE358 File Offset: 0x004EC558
	public int lives
	{
		get
		{
			return this._lives;
		}
		set
		{
			this._lives = value;
			if (base.photonView.isMine)
			{
				base.photonView.RPC("SetLives", PhotonTargets.AllBuffered, new object[]
				{
					this._lives
				});
			}
		}
	}

	// Token: 0x0600DE14 RID: 56852 RVA: 0x004E5677 File Offset: 0x004E3877
	public void MKIFNAHDECD(int BOAKOPHKGHC)
	{
		this._lives = BOAKOPHKGHC;
	}

	// Token: 0x0600DE15 RID: 56853 RVA: 0x004EE3AC File Offset: 0x004EC5AC
	private IEnumerator AJOPLECODPP(RanksSystem.MapReplay DHBGCEHLJAM)
	{
		this.myJob = new GetProcessesJob();
		this.myJob.Start();
		yield return base.StartCoroutine(this.myJob.WaitFor());
		yield break;
	}

	// Token: 0x0600DE16 RID: 56854 RVA: 0x004EE3C8 File Offset: 0x004EC5C8
	private void JAIALEBLCBP(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 position = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<EnvironmentController>().SetPosition(position);
	}

	// Token: 0x0600DE17 RID: 56855 RVA: 0x004EE40C File Offset: 0x004EC60C
	public void SetSunMaxSize(GameObject MPNMOONBMII, string IACGDFHKCAE, string OKAHCMOGDGF, string OOGLOGACOAH)
	{
		Vector3 maxSize = new Vector3(float.Parse(IACGDFHKCAE, CultureInfo.InvariantCulture), float.Parse(OKAHCMOGDGF, CultureInfo.InvariantCulture), float.Parse(OOGLOGACOAH, CultureInfo.InvariantCulture));
		MPNMOONBMII.GetComponent<SunController>().SetMaxSize(maxSize);
	}

	// Token: 0x0600DE18 RID: 56856 RVA: 0x004EE450 File Offset: 0x004EC650
	public void InvokeEvent(string LHCIHJOHGEJ, string NOJGGCLPPAM)
	{
		try
		{
			string[] array = null;
			GameObject gameObject = null;
			GameObject gameObject2 = null;
			if (!string.IsNullOrEmpty(NOJGGCLPPAM))
			{
				array = NOJGGCLPPAM.Split(new char[]
				{
					','
				});
				if (array.Length > 0 && this.environmentObjects.ContainsKey(array[0]))
				{
					gameObject = this.environmentObjects[array[0]];
				}
				if (array.Length > 1 && this.environmentObjects.ContainsKey(array[1]))
				{
					gameObject2 = this.environmentObjects[array[1]];
				}
			}
			try
			{
				if (base.photonView.isMine)
				{
					this.gameEventInfoBase.ismultiplayer = !PhotonNetwork.offlineMode;
					if (!PhotonNetwork.offlineMode)
					{
						this.gameEventInfoBase.multiplayerplayers = PhotonNetwork.room.PlayerCount;
						this.gameEventInfoBase.multiplayerplace = this.GetGameScene().GetComponent<NetworkScene>().place;
					}
					else
					{
						this.gameEventInfoBase.multiplayerplayers = 1;
						this.gameEventInfoBase.multiplayerplace = 1;
					}
					this.gameEventInfoBase.eventtype = LHCIHJOHGEJ;
					this.gameEventInfoBase.eventdata = NOJGGCLPPAM;
					this.gameEventInfoBase.eventtime = this.gameScene.HPAnimationTime;
					this.gameEventInfoBase.loopscount = this.loopsCount;
					GameEventInfo gameEventInfo = new GameEventInfo();
					this.gameEventInfoBase.CopyValues(gameEventInfo);
					this.gameEventInfoList.Add(gameEventInfo);
				}
			}
			catch (Exception ex)
			{
				Debug.LogError("[GameEvent] Exeption:" + ex.ToString());
			}
			switch (LHCIHJOHGEJ)
			{
			case "SpawnObj":
				if (this.lives > 0)
				{
					this.SpawnObj(NOJGGCLPPAM, true);
					if (base.photonView.isMine)
					{
						base.photonView.RPC("SpawnObj", PhotonTargets.Others, new object[]
						{
							NOJGGCLPPAM,
							false
						});
					}
				}
				goto IL_FF2;
			case "ShowSprite":
				this.ShowSprite(NOJGGCLPPAM);
				goto IL_FF2;
			case "MapEnd":
				this.MapEnd(NOJGGCLPPAM);
				goto IL_FF2;
			case "ShowTitle":
				this.ShowTitle(NOJGGCLPPAM);
				goto IL_FF2;
			case "SetSpeed":
				this.SetSpeed(NOJGGCLPPAM);
				goto IL_FF2;
			case "Checkpoint":
				this.Checkpoint(NOJGGCLPPAM);
				goto IL_FF2;
			case "SetBGColor":
				this.SetBGColor(NOJGGCLPPAM);
				goto IL_FF2;
			case "SetPlayerDistance":
				this.SetPlayerDistance(NOJGGCLPPAM);
				goto IL_FF2;
			case "SetTrailZoomSpeed":
				this.SetTrailZoomSpeed(float.Parse(array[0], CultureInfo.InvariantCulture));
				goto IL_FF2;
			case "AddEnvironmentObject":
				this.AddEnvironmentObject(array[0], array[1]);
				goto IL_FF2;
			case "RemoveEnvironmentObject":
				this.RemoveEnvironmentObject(array[0]);
				goto IL_FF2;
			case "ClearEnvironment":
				this.ClearEnvironment();
				goto IL_FF2;
			case "SetPosition":
				if (gameObject != null)
				{
					this.JAIALEBLCBP(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetRotation":
				if (gameObject != null)
				{
					this.CPKMCGIIAHC(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetScale":
				if (gameObject != null)
				{
					this.DGIJAFGLGHC(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParent":
				if (gameObject != null && gameObject2 != null)
				{
					this.BJLLDIOIJFB(gameObject, gameObject2);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						":",
						array[0],
						" or ",
						array[1],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunColors":
				if (gameObject != null)
				{
					this.SetSunColors(gameObject, array[1], array[2]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunEmission":
				if (gameObject != null)
				{
					this.SetSunEmission(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunInput":
				if (gameObject != null)
				{
					this.SetSunInput(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunMinSize":
				if (gameObject != null)
				{
					this.SetSunMinSize(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunMaxSize":
				if (gameObject != null)
				{
					this.SetSunMaxSize(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunLerpSpeed":
				if (gameObject != null)
				{
					this.SetSunLerpSpeed(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunSensitivity":
				if (gameObject != null)
				{
					this.SetSunSensitivity(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSunDirectionVector":
				if (gameObject != null)
				{
					this.SetSunDirectionVector(gameObject, array[1], array[2], array[3]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteColor":
				if (gameObject != null)
				{
					this.SetSatelliteColor(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteEmission":
				if (gameObject != null)
				{
					this.SetSatelliteEmission(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteRotationSpeed":
				if (gameObject != null)
				{
					this.SetSatelliteRotationSpeed(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteRadius":
				if (gameObject != null)
				{
					this.SetSatelliteRadius(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteInput":
				if (gameObject != null)
				{
					this.SetSatelliteInput(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteLerpSpeed":
				if (gameObject != null)
				{
					this.SetSatelliteLerpSpeed(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteTrailLength":
				if (gameObject != null)
				{
					this.SetSatelliteTrailLength(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteTrailWidth":
				if (gameObject != null)
				{
					this.SetSatelliteTrailWidth(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteSensitivity":
				if (gameObject != null)
				{
					this.SetSatelliteSensitivity(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetSatelliteTrailMinVertexDistance":
				if (gameObject != null)
				{
					this.SetSatelliteTrailMinVertexDistance(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetCrosshairColor":
				this.SetCrosshairColor(Helpers.HexToColor(array[0]), float.Parse(array[1], CultureInfo.InvariantCulture));
				goto IL_FF2;
			case "SetCrosshairEmission":
				this.SetCrosshairEmission(array[0]);
				goto IL_FF2;
			case "SetParticlesColor":
				if (gameObject != null)
				{
					this.SetParticlesColor(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesEmission":
				if (gameObject != null)
				{
					this.SetParticlesEmission(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesParticleSize":
				if (gameObject != null)
				{
					this.SetParticlesParticleSize(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesGravity":
				if (gameObject != null)
				{
					this.SetParticlesGravity(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesParticleSpeed":
				if (gameObject != null)
				{
					this.SetParticlesParticleSpeed(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesCountPerBeat":
				if (gameObject != null)
				{
					this.SetParticlesCountPerBeat(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "SetParticlesInput":
				if (gameObject != null)
				{
					this.SetParticlesInput(gameObject, array[1]);
				}
				else
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"[PlayerController] ",
						LHCIHJOHGEJ,
						": ",
						array[0],
						" not exist"
					}));
				}
				goto IL_FF2;
			case "AddEnvironmentSprite":
				this.AddEnvironmentSprite(array[0], array[1], array[2], array[3]);
				goto IL_FF2;
			case "SetEnvSpriteImage":
				if (gameObject != null)
				{
					this.SetEnvSpriteImage(gameObject, array[1]);
				}
				goto IL_FF2;
			case "SetEnvSpriteColor":
				if (gameObject != null)
				{
					this.SetEnvSpriteColor(gameObject, array[1], array[2]);
				}
				goto IL_FF2;
			}
			Debug.LogWarning("[PlayerBase] Unknown event: " + LHCIHJOHGEJ);
			IL_FF2:;
		}
		catch (Exception ex2)
		{
			Debug.LogError(string.Concat(new string[]
			{
				"[PlayerBase] Invoke event ",
				LHCIHJOHGEJ,
				"(",
				NOJGGCLPPAM,
				") error: ",
				ex2.ToString()
			}));
		}
	}

	// Token: 0x0600DE19 RID: 56857 RVA: 0x004EF4CC File Offset: 0x004ED6CC
	private void Update()
	{
		if (this.environmentBase != null)
		{
			if (this.comboTimer > 1f)
			{
				this.comboTimer = 1f;
			}
			if (this.fullLevelData.mapData.environmentType >= 0)
			{
				if (this.currentState != PlayerBase.PlayerState.Spectator)
				{
					Color b = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject in this.sunList)
					{
						gameObject.GetComponent<Renderer>().material.SetColor("_DiffuseColor", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("_DiffuseColor"), b, Time.deltaTime * 5f));
						gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.Lerp(gameObject.GetComponent<Renderer>().material.GetColor("_EmissionColor"), b, Time.deltaTime * 5f));
						gameObject.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.lives;
						gameObject.GetComponent<DynamicScale>().currentOverflow = this.comboTimer;
					}
				}
				else if (this.spectatedPlayerBase != null)
				{
					Color color = Helpers.ColorGradient(this.environmentBase.GetComponent<EnvironmentConfig>().maxLivesColor, this.environmentBase.GetComponent<EnvironmentConfig>().zeroLivesColor, this.GetLifesProgrees());
					foreach (GameObject gameObject2 in this.sunList)
					{
						gameObject2.GetComponent<DynamicScale>().sensitivity = this.sunBaseSensetivity / (float)this.fullLevelData.mapData.lives * (float)this.lives;
						gameObject2.GetComponent<DynamicScale>().currentOverflow = this.spectatedPlayerBase.comboTimer;
					}
				}
			}
			if (this.comboTimer > 0f)
			{
				this.comboTimer -= Time.deltaTime * (this.gameScene.pbase.currentArcsSpeed * -0.1f);
			}
			if (this.comboTimer < 0f)
			{
				this.comboTimer = 0f;
			}
		}
		this.player.transform.localPosition = Vector3.Lerp(this.player.transform.localPosition, new Vector3(0f, 0f, -this.playerDistance), Time.smoothDeltaTime * 5f);
		if (this.moveF)
		{
			this.moveF.speed = Mathf.Lerp(this.moveF.speed, this.moveFSpeed, Time.smoothDeltaTime * 5f);
		}
		if (this.currentState == PlayerBase.PlayerState.Playing)
		{
			if (!this.player.GetComponent<PlayerController>().isRecording)
			{
				foreach (Camera camera in this.camerasList)
				{
					camera.backgroundColor = Color.Lerp(camera.backgroundColor, this.bgcolor, Time.smoothDeltaTime * this.colorLerpSpeed);
				}
			}
			if (Input.GetKey(KeyCode.Escape) && this.gameScene.HPAnimationTime > 0f && base.photonView.isMine)
			{
				if (this.gameScene.gameMode != GameScene.GameMode.Relax)
				{
					base.photonView.RPC("LostAllLives", PhotonTargets.AllBuffered, null);
				}
				else
				{
					base.photonView.RPC("FinishMap", PhotonTargets.AllBuffered, null);
				}
			}
		}
		if (this.currentState == PlayerBase.PlayerState.Spectator && Input.GetKey(KeyCode.Escape))
		{
			this.currentState = PlayerBase.PlayerState.Finished;
			this.gameScene.spectatorCanvas.SetActive(false);
			this.gameScene.spectatePanel.SetActive(false);
			this.gameScene.ShowGOCanvas(true);
		}
		if (this.currentState == PlayerBase.PlayerState.Finished)
		{
			foreach (Camera camera2 in this.camerasList)
			{
				Blur component = camera2.GetComponent<Blur>();
				if (component)
				{
					component.enabled = true;
					if (component.iterations < 10)
					{
						component.iterations++;
					}
				}
			}
		}
		if (this.currentState == PlayerBase.PlayerState.Spectator)
		{
			foreach (Camera camera3 in this.camerasList)
			{
				Blur component2 = camera3.GetComponent<Blur>();
				component2.enabled = false;
				component2.iterations = 1;
			}
		}
		if (this.gameScene && this.gameScene.isGameStarted && !this.gameScene.IsRoundFinished())
		{
			this.RunMapEvents();
		}
		if (this.gameScene && this.gameScene.IsRoundFinished())
		{
			this.SetPlayerDistance(7f);
			foreach (GameObject gameObject3 in this.sunList)
			{
				gameObject3.GetComponent<DynamicScale>().baseScale = ((!this.isPlayerWon) ? Vector3.zero : gameObject3.GetComponent<DynamicScale>().baseScale);
			}
			foreach (SphereWaveform sphereWaveform in this.environmentBase.GetComponentsInChildren<SphereWaveform>())
			{
				sphereWaveform.sensitivity = Mathf.Lerp(sphereWaveform.sensitivity, 0f, Time.smoothDeltaTime * 0.5f);
			}
		}
	}

	// Token: 0x0600DE1A RID: 56858 RVA: 0x004EFB5C File Offset: 0x004EDD5C
	[PunRPC]
	public void ShowTitle(string NOJGGCLPPAM)
	{
		try
		{
			if (this.currentState != PlayerBase.PlayerState.Finished)
			{
				string[] array = NOJGGCLPPAM.Split(new char[]
				{
					','
				});
				if (base.photonView.isMine)
				{
					if (array.Length > 1)
					{
						this.gameScene.AddMessage(array[0], float.Parse(array[1], CultureInfo.InvariantCulture));
					}
					else
					{
						this.gameScene.AddMessage(array[0], 1f);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("[PlayerBase] ShowTitle error: " + ex.ToString());
		}
	}

	// Token: 0x0600DE1B RID: 56859 RVA: 0x004EFC04 File Offset: 0x004EDE04
	public void IKCJDDKPICF(string EHHBHEJBHNG)
	{
		try
		{
			if (base.GBHNDHLAJLI().BGJKMGJBPFA() && this.currentState != PlayerBase.PlayerState.Finished && this.currentState != (PlayerBase.PlayerState)7)
			{
				this.lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("_Amount" + this.lastCheckpoint);
				this.BADFOBEMNDO();
				this.KADBPIPMIBF().AddMessage(LocalizationService.Instance.HOPMEAJKPHL("Music End"), 1779f);
				this.wasCheckpoint = true;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("ItemsCountText" + ex.ToString());
		}
	}

	// Token: 0x0600DE1C RID: 56860 RVA: 0x004EFCC0 File Offset: 0x004EDEC0
	private IEnumerator HJAALCDIDAN(RanksSystem.MapReplay DHBGCEHLJAM)
	{
		this.myJob = new GetProcessesJob();
		this.myJob.Start();
		yield return base.StartCoroutine(this.myJob.WaitFor());
		yield break;
	}

	// Token: 0x0600DE1D RID: 56861 RVA: 0x004EFCDC File Offset: 0x004EDEDC
	public void DeletePlayerData()
	{
		Debug.Log("[PlayerBase] Delete checkpoint data");
		string str = this.gameScene.mapID + "." + this.gameScene.gameMode.ToString().ToLower();
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.time", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.lives", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.correctScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.checkpointsUsed", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.incorrectScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.currentCombo", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.penaltyScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.comboScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.powerupsScore", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.playerdistance", null);
		Singleton<SaveSystem>.Instance.DeleteKey("maps." + str + ".lastCheckpoint.perfectHits", null);
		Helpers.DeleteColorKey("maps." + str + ".lastCheckpoint.bgcolor");
	}

	// Token: 0x0600DE1E RID: 56862 RVA: 0x004EFE68 File Offset: 0x004EE068
	public void RemoveEnvironmentObject(string JMMILEFMACB)
	{
		if (this.sunList.Contains(this.environmentObjects[JMMILEFMACB]))
		{
			this.sunList.Remove(this.environmentObjects[JMMILEFMACB]);
		}
		TrashMan.despawn(this.environmentObjects[JMMILEFMACB]);
		this.environmentObjects.Remove(JMMILEFMACB);
	}

	// Token: 0x0600DE20 RID: 56864 RVA: 0x004EFEC7 File Offset: 0x004EE0C7
	public void CMCEMNPBDHL(GameObject MPNMOONBMII, string PNDBJMFMGBK)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().CJNFBCCHNLG(Helpers.HexToColor(PNDBJMFMGBK), 127f);
	}

	// Token: 0x0600DE21 RID: 56865 RVA: 0x004EB017 File Offset: 0x004E9217
	public void SetSatelliteSensitivity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetSensitivity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE22 RID: 56866 RVA: 0x004EFEDF File Offset: 0x004EE0DF
	public void IBLFLLGIIMD()
	{
		if (base.IBKCMBIGOEJ().BGJKMGJBPFA() && this.LJBFCKKNPGN() < this.fullLevelData.mapData.maxLives)
		{
			this.lives = this.NCBBBJINGMM() + 0;
		}
	}

	// Token: 0x0600DE23 RID: 56867 RVA: 0x004EFF1C File Offset: 0x004EE11C
	public void CAPEBDNJIJA(string HNDMDHJEEAB)
	{
		try
		{
			this.SetPlayerDistance(float.Parse(HNDMDHJEEAB, CultureInfo.InvariantCulture));
		}
		catch (Exception ex)
		{
			Debug.LogWarning("BadgeText" + ex.ToString());
		}
	}

	// Token: 0x0600DE24 RID: 56868 RVA: 0x004EFF6C File Offset: 0x004EE16C
	public void SetParticlesInput(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<ParticlesController>().SetInput(int.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE25 RID: 56869 RVA: 0x004EFF84 File Offset: 0x004EE184
	public void PrepareMapTiming(float JFMIIPKLCPA)
	{
		Debug.Log("[MapData] Map timing update from: " + JFMIIPKLCPA);
		if (this.fullLevelData.mapData.configVersion >= 3 && !string.IsNullOrEmpty(this.fullLevelData.mapData.e))
		{
			try
			{
				MapData.EData edata = JsonConvert.DeserializeObject<MapData.EData>(global::Console.Error(this.fullLevelData.mapData.e, Singleton<SaveSystem>.Instance.folder));
				this.fullLevelData.mapData.events.AddRange(edata.events);
			}
			catch (Exception)
			{
			}
		}
		List<MapEvent> events = this.fullLevelData.mapData.events;
		if (PlayerBase.<>f__am$cache0 == null)
		{
			PlayerBase.<>f__am$cache0 = new Comparison<MapEvent>(PlayerBase.KKDGOEJNNMI);
		}
		events.Sort(PlayerBase.<>f__am$cache0);
		float num = this.fullLevelData.mapData.speed;
		float num2 = -this.pspawner.transform.localPosition.z;
		this.pretime = 0f;
		if (this.fullLevelData.mapData.configVersion >= 2)
		{
			foreach (MapEvent mapEvent in this.fullLevelData.mapData.events)
			{
				if (mapEvent.data[0] == "SetSpeed")
				{
					num = float.Parse(mapEvent.data[1], CultureInfo.InvariantCulture);
				}
				if (mapEvent.data[0] == "SetPlayerDistance")
				{
				}
				if (mapEvent.data[0] == "SpawnObj")
				{
					List<string> list = mapEvent.data[1].Split(new char[]
					{
						','
					}).ToList<string>();
					list.Add(string.Empty + (mapEvent.time + this.arcsDelay + 0.11f));
					mapEvent.time -= num2 / num;
					mapEvent.time += this.arcsDelay + 0.11f;
					mapEvent.data[1] = string.Join(",", list.ToArray());
					if (mapEvent.time < 0f && mapEvent.time < this.pretime)
					{
						this.pretime = mapEvent.time;
					}
				}
			}
		}
		else
		{
			foreach (MapEvent mapEvent2 in this.fullLevelData.mapData.events)
			{
				float num3 = 10f / this.fullLevelData.mapData.speed;
				mapEvent2.time -= num3;
				if (mapEvent2.data[0] == "SpawnObj")
				{
					mapEvent2.time += this.arcsDelay;
				}
				if (mapEvent2.time < 0f && mapEvent2.time < this.pretime)
				{
					this.pretime = mapEvent2.time;
				}
			}
		}
		if (!this.isStoryboardEnabled)
		{
			PlayerBase.LMIJECACDOG lmijecacdog = new PlayerBase.LMIJECACDOG();
			lmijecacdog.ADPIKBBAKHP = this;
			lmijecacdog.EGMPIBBOEMH = this.fullLevelData.mapData.events.Count - 1;
			while (lmijecacdog.EGMPIBBOEMH >= 0)
			{
				if (Helpers.eventsMap.Exists(new Predicate<EditorEventFunctionInfo>(lmijecacdog.GBKBDKHPLKG)))
				{
					this.fullLevelData.mapData.events.RemoveAt(lmijecacdog.EGMPIBBOEMH);
				}
				lmijecacdog.EGMPIBBOEMH--;
			}
		}
		if (this.gameScene.usingCheckpoints)
		{
			foreach (float num4 in this.fullLevelData.mapData.checkpoints)
			{
				if (num4 > JFMIIPKLCPA)
				{
					this.fullLevelData.mapData.events.Add(new MapEvent(num4, new List<string>
					{
						"Checkpoint",
						num4.ToString()
					}));
				}
			}
		}
		List<MapEvent> events2 = this.fullLevelData.mapData.events;
		if (PlayerBase.<>f__am$cache1 == null)
		{
			PlayerBase.<>f__am$cache1 = new Comparison<MapEvent>(PlayerBase.KGJMABKHFBN);
		}
		events2.Sort(PlayerBase.<>f__am$cache1);
		if (JFMIIPKLCPA > 0f)
		{
			this.pretime = JFMIIPKLCPA;
		}
		this.pretime -= 1f;
		Debug.Log("[PlayerBase] Starting game from: " + this.pretime);
		this.gameScene.HPAnimationTime = this.pretime;
		for (int i = this.fullLevelData.mapData.events.Count - 1; i >= 0; i--)
		{
			if (this.fullLevelData.mapData.events[i].time <= this.pretime)
			{
				if (this.fullLevelData.mapData.events[i].data[0] == "ShowSprite")
				{
					string[] array = this.fullLevelData.mapData.events[i].data[1].Split(new char[]
					{
						','
					});
					float num5 = float.Parse(array[3], CultureInfo.InvariantCulture);
					if (num5 == 0f || this.fullLevelData.mapData.events[i].time + num5 > this.pretime)
					{
						if (num5 > 0f)
						{
							array[3] = (this.fullLevelData.mapData.events[i].time + num5 - this.pretime).ToString();
						}
						else
						{
							array[3] = string.Empty + 0;
						}
						base.photonView.RPC(this.fullLevelData.mapData.events[i].data[0], PhotonTargets.All, new object[]
						{
							string.Join(",", array)
						});
					}
					else
					{
						this.fullLevelData.mapData.events.RemoveAt(i);
					}
				}
				if (this.fullLevelData.mapData.events[i].data[0] == "SpawnObj")
				{
					this.fullLevelData.mapData.events.RemoveAt(i);
				}
			}
		}
		this.currentEventID = 0;
	}

	// Token: 0x0600DE26 RID: 56870 RVA: 0x004F0710 File Offset: 0x004EE910
	public void SetSunSensitivity(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SunController>().SetSensitivity(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE27 RID: 56871 RVA: 0x004F0728 File Offset: 0x004EE928
	public void SetSatelliteTrailWidth(GameObject MPNMOONBMII, string DPNHODJHGJL)
	{
		MPNMOONBMII.GetComponent<SatelliteController>().SetTrailWidth(float.Parse(DPNHODJHGJL, CultureInfo.InvariantCulture));
	}

	// Token: 0x0600DE28 RID: 56872 RVA: 0x004F0740 File Offset: 0x004EE940
	public void JBGKGGLKLPC(string EHHBHEJBHNG)
	{
		try
		{
			if (base.GBMJAPGLMGB().DOLKFPIABDD() && this.currentState != PlayerBase.PlayerState.Finished && this.currentState != PlayerBase.PlayerState.Playing)
			{
				this.lastCheckpoint = float.Parse(EHHBHEJBHNG, CultureInfo.InvariantCulture);
				Debug.Log("_Value2" + this.lastCheckpoint);
				this.BADFOBEMNDO();
				this.gameScene.AddMessage(LocalizationService.Instance.HOPMEAJKPHL("_Value"), 13f);
				this.wasCheckpoint = false;
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning("Avoid using this directly. Thanks." + ex.ToString());
		}
	}

	// Token: 0x0600DE29 RID: 56873 RVA: 0x004E5482 File Offset: 0x004E3682
	public int BMKCMMJMOKN()
	{
		return this._lives;
	}

	// Token: 0x040018E8 RID: 6376
	[HideInInspector]
	public GameEventInfo gameEventInfoBase;

	// Token: 0x040018E9 RID: 6377
	[HideInInspector]
	public List<GameEventInfo> gameEventInfoList = new List<GameEventInfo>();

	// Token: 0x040018EA RID: 6378
	[HideInInspector]
	public float currentArcsSpeed = 50f;

	// Token: 0x040018EB RID: 6379
	public List<GameObject> spawnedArcs;

	// Token: 0x040018EC RID: 6380
	[HideInInspector]
	public FullMapData fullLevelData;

	// Token: 0x040018ED RID: 6381
	public GameObject player;

	// Token: 0x040018EE RID: 6382
	public GameObject bgLevelCanvas;

	// Token: 0x040018EF RID: 6383
	public PlayerSpawner pspawner;

	// Token: 0x040018F0 RID: 6384
	public PlayerController playerController;

	// Token: 0x040018F1 RID: 6385
	public GameObject twoHandCameras;

	// Token: 0x040018F2 RID: 6386
	[HideInInspector]
	public List<Camera> camerasList;

	// Token: 0x040018F3 RID: 6387
	[SerializeField]
	private GameObject objects_3;

	// Token: 0x040018F4 RID: 6388
	public PlayerBase.PlayerState currentState;

	// Token: 0x040018F5 RID: 6389
	private ObscuredInt _lives = 5;

	// Token: 0x040018F6 RID: 6390
	public float playerDistance = 14f;

	// Token: 0x040018F7 RID: 6391
	public Color bgcolor = Color.black;

	// Token: 0x040018F8 RID: 6392
	public float colorLerpSpeed = 5f;

	// Token: 0x040018F9 RID: 6393
	public float moveFSpeed = -1.5f;

	// Token: 0x040018FA RID: 6394
	[HideInInspector]
	public bool isMapCompleted;

	// Token: 0x040018FB RID: 6395
	[HideInInspector]
	public ObscuredInt correctScore = 0;

	// Token: 0x040018FC RID: 6396
	[HideInInspector]
	public ObscuredInt perfectHits = 0;

	// Token: 0x040018FD RID: 6397
	[HideInInspector]
	public ObscuredFloat penaltyScore = 0f;

	// Token: 0x040018FE RID: 6398
	[HideInInspector]
	public ObscuredFloat accuracyScore = 0f;

	// Token: 0x040018FF RID: 6399
	[HideInInspector]
	public ObscuredInt incorrectScore = 0;

	// Token: 0x04001900 RID: 6400
	[HideInInspector]
	public ObscuredInt powerupsScore = 0;

	// Token: 0x04001901 RID: 6401
	[HideInInspector]
	public ObscuredInt checkpointsUsed = 0;

	// Token: 0x04001902 RID: 6402
	[HideInInspector]
	public ObscuredInt loopsCount = 0;

	// Token: 0x04001903 RID: 6403
	[HideInInspector]
	public ObscuredInt currentCombo = 0;

	// Token: 0x04001904 RID: 6404
	[HideInInspector]
	public ObscuredFloat comboScore = 0f;

	// Token: 0x04001905 RID: 6405
	[HideInInspector]
	public float lastCheckpoint;

	// Token: 0x04001906 RID: 6406
	[HideInInspector]
	public ObscuredBool isPlayerWon = false;

	// Token: 0x04001907 RID: 6407
	[HideInInspector]
	public int lastBestScore;

	// Token: 0x04001908 RID: 6408
	[HideInInspector]
	public int currentAttempt;

	// Token: 0x04001909 RID: 6409
	[HideInInspector]
	public bool scoreBeated;

	// Token: 0x0400190A RID: 6410
	[HideInInspector]
	public GameObject environmentBase;

	// Token: 0x0400190B RID: 6411
	[HideInInspector]
	public List<GameObject> sunList;

	// Token: 0x0400190C RID: 6412
	[HideInInspector]
	public float sunBaseSensetivity;

	// Token: 0x0400190D RID: 6413
	[HideInInspector]
	public int spectrid;

	// Token: 0x0400190E RID: 6414
	public bool ach12;

	// Token: 0x0400190F RID: 6415
	private bool wasCheckpoint;

	// Token: 0x04001910 RID: 6416
	private GameScene _gameScene;

	// Token: 0x04001911 RID: 6417
	[HideInInspector]
	public float comboTimer;

	// Token: 0x04001912 RID: 6418
	private ObscuredBool isMusicLoaded = false;

	// Token: 0x04001913 RID: 6419
	private int currentEventID;

	// Token: 0x04001914 RID: 6420
	[HideInInspector]
	public Dictionary<string, GameObject> environmentObjects = new Dictionary<string, GameObject>();

	// Token: 0x04001915 RID: 6421
	[HideInInspector]
	public List<CrosshairController> crosshairsList;

	// Token: 0x04001916 RID: 6422
	private MoveF moveF;

	// Token: 0x04001917 RID: 6423
	public float arcsDelay;

	// Token: 0x04001918 RID: 6424
	private bool isStoryboardEnabled = true;

	// Token: 0x04001919 RID: 6425
	private RanksSystem.MapReplay currentReplay;

	// Token: 0x0400191A RID: 6426
	[HideInInspector]
	public float pretime;

	// Token: 0x0400191B RID: 6427
	private GetProcessesJob myJob;

	// Token: 0x0400191C RID: 6428
	[HideInInspector]
	public PlayerBase spectatedPlayerBase;

	// Token: 0x0400191D RID: 6429
	private GameObject levelCanvasImage;

	// Token: 0x0400191E RID: 6430
	private GameObject sunGameObject;

	// Token: 0x0400191F RID: 6431
	private GameObject satelliteGameObject;

	// Token: 0x04001920 RID: 6432
	private GameObject particlesGameObject;

	// Token: 0x04001921 RID: 6433
	private GameObject spriteGameObject;

	// Token: 0x020003D3 RID: 979
	public enum PlayerState
	{
		// Token: 0x04001928 RID: 6440
		Loading,
		// Token: 0x04001929 RID: 6441
		Playing,
		// Token: 0x0400192A RID: 6442
		Finished,
		// Token: 0x0400192B RID: 6443
		Spectator
	}

	// Token: 0x020003D4 RID: 980
	[CompilerGenerated]
	private sealed class LMIJECACDOG
	{
		// Token: 0x0600DE2A RID: 56874 RVA: 0x004F07FC File Offset: 0x004EE9FC
		internal bool EDGAPOPEIJF(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x004F0850 File Offset: 0x004EEA50
		internal bool PKAPLCFHDOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x004F08A4 File Offset: 0x004EEAA4
		internal bool BDGDIDPDBHG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x004F08F8 File Offset: 0x004EEAF8
		internal bool JKEDCEOCPJO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x004F094C File Offset: 0x004EEB4C
		internal bool JBAJEMGOPDL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x004F09A0 File Offset: 0x004EEBA0
		internal bool LJDLIIIPIIJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x004F09F4 File Offset: 0x004EEBF4
		internal bool BJMAIJDIKCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x004F0A48 File Offset: 0x004EEC48
		internal bool DKGPCPBNDPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE32 RID: 56882 RVA: 0x004F0A9C File Offset: 0x004EEC9C
		internal bool GBKBDKHPLKG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE33 RID: 56883 RVA: 0x004F0AF0 File Offset: 0x004EECF0
		internal bool INHOEMCLAAP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE34 RID: 56884 RVA: 0x004F0B44 File Offset: 0x004EED44
		internal bool FIPCLHEKKCA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE35 RID: 56885 RVA: 0x004F0B98 File Offset: 0x004EED98
		internal bool LHHFJBIAHCN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE36 RID: 56886 RVA: 0x004F0BEC File Offset: 0x004EEDEC
		internal bool AGJKEBOPIOC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE37 RID: 56887 RVA: 0x004F0C40 File Offset: 0x004EEE40
		internal bool BKNHHGBPLGH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE38 RID: 56888 RVA: 0x004F0C94 File Offset: 0x004EEE94
		internal bool FFEGPHJKMFK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x004F0CE8 File Offset: 0x004EEEE8
		internal bool KGKMOLCPDIH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE3A RID: 56890 RVA: 0x004F0D3C File Offset: 0x004EEF3C
		internal bool LOEAMHGMMPK(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE3B RID: 56891 RVA: 0x004F0D90 File Offset: 0x004EEF90
		internal bool EGKGJJGAPMN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x004F0DE4 File Offset: 0x004EEFE4
		internal bool JDELIMPGFDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x004F0E38 File Offset: 0x004EF038
		internal bool LNDGINDKPFA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE3E RID: 56894 RVA: 0x004F0E8C File Offset: 0x004EF08C
		internal bool BEBAENEJFLD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x004F0EE0 File Offset: 0x004EF0E0
		internal bool EKHOOPGPPGE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x004F0F34 File Offset: 0x004EF134
		internal bool OMBHIBNMFNB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE42 RID: 56898 RVA: 0x004F0F88 File Offset: 0x004EF188
		internal bool OFHCGKJFGDI(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE43 RID: 56899 RVA: 0x004F0FDC File Offset: 0x004EF1DC
		internal bool OLIGLEMPFOP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE44 RID: 56900 RVA: 0x004F1030 File Offset: 0x004EF230
		internal bool DNIMHEKGJHB(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE45 RID: 56901 RVA: 0x004F1084 File Offset: 0x004EF284
		internal bool FJDBPPKABJE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE46 RID: 56902 RVA: 0x004F10D8 File Offset: 0x004EF2D8
		internal bool MEMPOPNAEDN(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x004F112C File Offset: 0x004EF32C
		internal bool DBFPGFHEGKA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE48 RID: 56904 RVA: 0x004F1180 File Offset: 0x004EF380
		internal bool FDAIFOAGDLA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE49 RID: 56905 RVA: 0x004F11D4 File Offset: 0x004EF3D4
		internal bool FHFECFLBHMA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x004F1228 File Offset: 0x004EF428
		internal bool LLNDDFGPOPL(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE4B RID: 56907 RVA: 0x004F127C File Offset: 0x004EF47C
		internal bool BMAOCLKPNNC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE4C RID: 56908 RVA: 0x004F12D0 File Offset: 0x004EF4D0
		internal bool PBCAHKDLFPE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE4D RID: 56909 RVA: 0x004F1324 File Offset: 0x004EF524
		internal bool KFNBKFELFLH(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE4E RID: 56910 RVA: 0x004F1378 File Offset: 0x004EF578
		internal bool AEIFJLBBKBP(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE4F RID: 56911 RVA: 0x004F13CC File Offset: 0x004EF5CC
		internal bool EFAPFFFGOOA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE50 RID: 56912 RVA: 0x004F1420 File Offset: 0x004EF620
		internal bool FMIHBNPKEEO(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE51 RID: 56913 RVA: 0x004F1474 File Offset: 0x004EF674
		internal bool OFLDIMDDLHM(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE52 RID: 56914 RVA: 0x004F14C8 File Offset: 0x004EF6C8
		internal bool MGENGAEDACG(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE53 RID: 56915 RVA: 0x004F151C File Offset: 0x004EF71C
		internal bool IGFOBPKFCDJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE54 RID: 56916 RVA: 0x004F1570 File Offset: 0x004EF770
		internal bool JBCHBMKPDAJ(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE55 RID: 56917 RVA: 0x004F15C4 File Offset: 0x004EF7C4
		internal bool AEINPAGJFME(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[0]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE56 RID: 56918 RVA: 0x004F1618 File Offset: 0x004EF818
		internal bool FHIJCPPECHA(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE57 RID: 56919 RVA: 0x004F166C File Offset: 0x004EF86C
		internal bool HBJFIOJFBHC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0600DE58 RID: 56920 RVA: 0x004F16C0 File Offset: 0x004EF8C0
		internal bool BFEABMIFIEE(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE59 RID: 56921 RVA: 0x004F1714 File Offset: 0x004EF914
		internal bool PIJAOCFAPKC(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1] && IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Arcs;
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x004F1768 File Offset: 0x004EF968
		internal bool FCAGEDLBBHD(EditorEventFunctionInfo IACGDFHKCAE)
		{
			return !(IACGDFHKCAE.id == this.ADPIKBBAKHP.fullLevelData.mapData.events[this.EGMPIBBOEMH].data[1]) || IACGDFHKCAE.eventType == EditorEventFunctionInfo.EditorEventType.Storyboard;
		}

		// Token: 0x0400192C RID: 6444
		internal int EGMPIBBOEMH;

		// Token: 0x0400192D RID: 6445
		internal PlayerBase ADPIKBBAKHP;
	}

	// Token: 0x020003D6 RID: 982
	[CompilerGenerated]
	private sealed class GGIHJGAKLPO
	{
		// Token: 0x0600DEA3 RID: 56995 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool AGFDCBCBAGI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool AKDOOLPMPMG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BEBAENEJFLD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool PKAPLCFHDOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool MAGEPMCPGOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool EDGAPOPEIJF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool INHOEMCLAAP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FMIHBNPKEEO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool JBCHBMKPDAJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool MPGGBMMPNDH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool BBIADFAPKDL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECE RID: 57038 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED5 RID: 57045 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED6 RID: 57046 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool OMBHIBNMFNB(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED7 RID: 57047 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED8 RID: 57048 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool PCDFLCEIHFF(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x0600DED9 RID: 57049 RVA: 0x004F51C9 File Offset: 0x004F33C9
		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.LEFMNANHGDA);
		}

		// Token: 0x04001934 RID: 6452
		internal string LEFMNANHGDA;
	}

	// Token: 0x020003D9 RID: 985
	[CompilerGenerated]
	private sealed class OCCEFLJGJGH
	{
		// Token: 0x0600DF5F RID: 57183 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF62 RID: 57186 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF63 RID: 57187 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF64 RID: 57188 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF65 RID: 57189 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF66 RID: 57190 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF67 RID: 57191 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF68 RID: 57192 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF69 RID: 57193 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF6A RID: 57194 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF6F RID: 57199 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0600DF70 RID: 57200 RVA: 0x004F602F File Offset: 0x004F422F
		internal bool EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			return IACGDFHKCAE.name.Contains(this.ENECJINHBEG);
		}

		// Token: 0x0400193C RID: 6460
		internal string ENECJINHBEG;
	}
}
