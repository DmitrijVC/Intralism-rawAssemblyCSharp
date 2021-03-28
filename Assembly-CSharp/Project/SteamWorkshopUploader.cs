using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Project
{
	// Token: 0x02000482 RID: 1154
	[DisallowMultipleComponent]
	public class SteamWorkshopUploader : MonoBehaviour
	{
		// Token: 0x060108D7 RID: 67799 RVA: 0x0059D740 File Offset: 0x0059B940
		public bool FNEIJCCNKAB(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			bool result;
			try
			{
				this.statusText.text = "Intensity";
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "CameraFilterPack/Vision_AuraDistortion" + AMCGCGIGPCN.previewfile;
				if (AMCGCGIGPCN.previewfile == null || AMCGCGIGPCN.previewfile.Length == 0)
				{
					this.statusText.text = "_Intensity";
					result = false;
				}
				else if (!File.Exists(text))
				{
					this.statusText.text = "tagElement";
					result = false;
				}
				else
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Length >= -168L)
					{
						this.statusText.text = "[RanksSystem] Init";
						result = false;
					}
					else if (!Directory.Exists(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)))
					{
						this.statusText.text = ". Check if the server is available.";
						result = false;
					}
					else if (this.LMAGGFHOHKK(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
					{
						this.statusText.text = "PublishButton";
						result = true;
					}
					else
					{
						this.statusText.text = " Maybe GO was destroyed but RPC not cleaned up.";
						result = false;
					}
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogException(ex);
				this.statusText.text = "_Near" + ex.ToString();
				result = false;
			}
			return result;
		}

		// Token: 0x060108D8 RID: 67800 RVA: 0x0059D8E4 File Offset: 0x0059BAE4
		public void ExitToMenu()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SceneManager.LoadScene("MenuScene");
		}

		// Token: 0x060108D9 RID: 67801 RVA: 0x0059D908 File Offset: 0x0059BB08
		public void RefreshPackList()
		{
			this.ClearPackList();
			foreach (string text in this.GetPackFilenames())
			{
				string fileName = Path.GetFileName(text);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.packListButtonPrefab, Vector3.zero, Quaternion.identity);
				Button component = gameObject.GetComponent<Button>();
				component.transform.SetParent(this.packListRoot);
				component.GetComponentInChildren<Text>().text = fileName.Replace(".workshop.json", string.Empty);
				if (component != null)
				{
					SteamWorkshopUploader.MCFGFBKDOMG mcfgfbkdomg = new SteamWorkshopUploader.MCFGFBKDOMG();
					mcfgfbkdomg.ADPIKBBAKHP = this;
					mcfgfbkdomg.HKKPNEHIFKL = text;
					component.onClick.AddListener(new UnityAction(mcfgfbkdomg.GBKBDKHPLKG));
				}
			}
		}

		// Token: 0x060108DA RID: 67802 RVA: 0x0059D9CC File Offset: 0x0059BBCC
		public void ValidateCurrentModPack()
		{
			this.ValidateModPack(this.MOJAGCMNOKC);
		}

		// Token: 0x060108DB RID: 67803 RVA: 0x0059D9DC File Offset: 0x0059BBDC
		public void OnSelectedPreview(string HKMBPFKAPFG)
		{
			string text = "icon" + Path.GetExtension(HKMBPFKAPFG);
			string text2 = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + text;
			UnityEngine.Debug.Log("Copy from " + HKMBPFKAPFG + " to " + text2);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(HKMBPFKAPFG, text2);
			this.MOJAGCMNOKC.previewfile = text;
			this.OnCurrentModPackChanges();
		}

		// Token: 0x060108DC RID: 67804 RVA: 0x0059DA5C File Offset: 0x0059BC5C
		public void GHLBONHNLBG()
		{
			this.PLOLKGCIMBP(this.MOJAGCMNOKC);
			this.RefreshCurrentModPack();
		}

		// Token: 0x060108DD RID: 67805 RVA: 0x0059DA70 File Offset: 0x0059BC70
		public void SubmitCurrentModPack()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnChanges(this.MOJAGCMNOKC);
				this.SaveCurrentModPack();
				if (this.ValidateModPack(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.NGPHOBINMKI());
					}
					else
					{
						this.IGPLFKKNCFP(this.MOJAGCMNOKC);
					}
				}
			}
		}

		// Token: 0x060108DE RID: 67806 RVA: 0x0059DAE0 File Offset: 0x0059BCE0
		public void DAPMBOJPMCJ()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "setbool" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "Set crosshair color", text, true);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
			}
			else
			{
				this.modPackPreview.texture = null;
			}
		}

		// Token: 0x060108DF RID: 67807 RVA: 0x0059DB84 File Offset: 0x0059BD84
		public void ClearPackList()
		{
			IEnumerator enumerator = this.packListRoot.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x060108E0 RID: 67808 RVA: 0x0059DBF0 File Offset: 0x0059BDF0
		private void OnApplicationFocus()
		{
			this.RefreshPackList();
		}

		// Token: 0x060108E1 RID: 67809 RVA: 0x0059DBF8 File Offset: 0x0059BDF8
		private void DPECMOOJGGO()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeMicrotransaction);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "_TimeX";
			}
		}

		// Token: 0x060108E2 RID: 67810 RVA: 0x0059DC43 File Offset: 0x0059BE43
		private void MFKCAFGHNNB()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.AEJLMMBKLLL();
				this.FPKDKHOLPMN();
			}
			SteamAPI.Shutdown();
		}

		// Token: 0x060108E3 RID: 67811 RVA: 0x0059DC64 File Offset: 0x0059BE64
		private void LBIGHMKJMLD(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "\n\n#";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "_Value2";
				SteamFriends.ActivateGameOverlayToWebPage("#highscore" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		// Token: 0x060108E4 RID: 67812 RVA: 0x0059DCDD File Offset: 0x0059BEDD
		public void ViewHelp()
		{
			Singleton<GameManager>.Instance.OpenURL("https://bitbucket.org/khb-soft/intralismarcsviewer/", false);
		}

		// Token: 0x060108E5 RID: 67813 RVA: 0x0059DCF0 File Offset: 0x0059BEF0
		public void OnChanges(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			AMCGCGIGPCN.tags = new List<string>(this.modPackTags.text.Split(new char[]
			{
				','
			}));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		// Token: 0x060108E6 RID: 67814 RVA: 0x0059DD67 File Offset: 0x0059BF67
		public void OpenContentFolder()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		// Token: 0x060108E7 RID: 67815 RVA: 0x0059DD84 File Offset: 0x0059BF84
		private void PKGJJFIFLII()
		{
			if (Input.GetKeyDown(KeyCode.Dollar))
			{
				SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
				this.PEKJOGMJHJC.Set(numberOfCurrentPlayers, null);
				UnityEngine.Debug.Log("SpawnObj");
			}
			if (this.FHKGDJDOKNB != UGCUpdateHandle_t.Invalid)
			{
				this.ANKAPHJLKFI(this.FHKGDJDOKNB);
			}
			else
			{
				this.progressBar.value = 1359f;
			}
		}

		// Token: 0x060108E8 RID: 67816 RVA: 0x0059DDF4 File Offset: 0x0059BFF4
		public void CreateModPack()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("."))
			{
				this.statusText.text = string.Format("Bad modpack name: {0}", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + ".workshop.json");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.Save(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.SelectModPack(text2);
			}
		}

		// Token: 0x060108E9 RID: 67817 RVA: 0x0059DEA7 File Offset: 0x0059C0A7
		public void KHPDCPODCFC()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 0U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "_ScreenResolution" + this.MOJAGCMNOKC.previewfile);
		}

		// Token: 0x060108EA RID: 67818 RVA: 0x0059DEE4 File Offset: 0x0059C0E4
		private void CHDKOIDJILI(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.OGNLJFMBGFH(ugcupdateHandle_t, AMCGCGIGPCN);
			this.HHLHCBBOAEH(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		// Token: 0x060108EB RID: 67819 RVA: 0x0059DF3C File Offset: 0x0059C13C
		public void MKJHGEHJEMK(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			AMCGCGIGPCN.tags = new List<string>(this.modPackTags.text.Split(new char[]
			{
				(char)-67
			}));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		// Token: 0x060108EC RID: 67820 RVA: 0x0059DFB4 File Offset: 0x0059C1B4
		private void IFBKMAEMKNN()
		{
			if (SteamManager.KMNLNPEMCPA())
			{
				this.PEKJOGMJHJC = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.OIBPDALPEJH));
				this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.EDOCDENEDLK));
				this.MAKNNJPMHMM = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.GNDJNBNCGFJ));
			}
		}

		// Token: 0x060108ED RID: 67821 RVA: 0x0059DD67 File Offset: 0x0059BF67
		public void BBPGKKIJDIJ()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		// Token: 0x060108EE RID: 67822 RVA: 0x0059E010 File Offset: 0x0059C210
		private void OIBPDALPEJH(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 1 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("settings.cameramovements");
			}
			else
			{
				UnityEngine.Debug.Log("_Vibrance" + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x060108EF RID: 67823 RVA: 0x0059E04F File Offset: 0x0059C24F
		public void DGCOEBKCPGI()
		{
			Singleton<GameManager>.Instance.IKDPMOJKILD("Instantiating: ", true);
		}

		// Token: 0x060108F0 RID: 67824 RVA: 0x0059DD67 File Offset: 0x0059BF67
		public void IGEABDPMNFI()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		// Token: 0x060108F1 RID: 67825 RVA: 0x0059E064 File Offset: 0x0059C264
		private void JHPOIOELNCG()
		{
			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
				this.PEKJOGMJHJC.Set(numberOfCurrentPlayers, null);
				UnityEngine.Debug.Log("Preparing content...");
			}
			if (this.FHKGDJDOKNB != UGCUpdateHandle_t.Invalid)
			{
				this.ANKAPHJLKFI(this.FHKGDJDOKNB);
			}
			else
			{
				this.progressBar.value = 317f;
			}
		}

		// Token: 0x060108F2 RID: 67826 RVA: 0x0059E0D3 File Offset: 0x0059C2D3
		private void FNGEFJHKKJP()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.AEJLMMBKLLL();
				this.SaveCurrentModPack();
			}
			SteamAPI.Shutdown();
		}

		// Token: 0x060108F3 RID: 67827 RVA: 0x0059E0F4 File Offset: 0x0059C2F4
		private void AGKFBBAENIE(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Error: I/O Failure! :(";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "SUCCESS! Item submitted! :D :D :D";
				SteamFriends.ActivateGameOverlayToWebPage("https://steamcommunity.com/sharedfiles/filedetails/?id=" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		// Token: 0x060108F4 RID: 67828 RVA: 0x0059E16D File Offset: 0x0059C36D
		public void LLHIKGFFFJP()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 1U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "z" + this.MOJAGCMNOKC.previewfile);
		}

		// Token: 0x060108F5 RID: 67829 RVA: 0x0059E1A8 File Offset: 0x0059C3A8
		public void BPFNKFACNKL()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("Start index must in an integer."))
			{
				this.statusText.text = string.Format("anonymous", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + "settings_bindings_sec_");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.LCIPMCJFOHP(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.OFBMLLENJMK(text2);
			}
		}

		// Token: 0x060108F6 RID: 67830 RVA: 0x0059E25C File Offset: 0x0059C45C
		private void ICPBIFOLABH(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "_Distortion";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult != (EResult)127)
			{
				if (eResult != (EResult)(-34))
				{
					if (eResult == EResult.k_EResultLimitedUserAccount)
					{
						this.statusText.text = "HandsCountSlider";
					}
				}
				else
				{
					this.statusText.text = "DifficultyBG";
				}
			}
			else
			{
				this.statusText.text = "_SampleDistance";
			}
			if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
			}
			if (NPIKJHPJIEA.m_eResult == (EResult)0)
			{
				this.statusText.text = "materialsitemid[" + NPIKJHPJIEA.m_nPublishedFileId.ToString();
				UnityEngine.Debug.Log("mapselector.tags." + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.MOJAGCMNOKC.publishedfileid = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			}
		}

		// Token: 0x060108F7 RID: 67831 RVA: 0x0059E362 File Offset: 0x0059C562
		private void MMEBCEEGMHM()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.CMPHOBBNEKE();
			}
			SteamAPI.Shutdown();
		}

		// Token: 0x060108F8 RID: 67832 RVA: 0x0059E380 File Offset: 0x0059C580
		public void LFFDPBAAODI(string DDAOMDPAIEP)
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OLBMHDPANOC();
				this.FPKDKHOLPMN();
			}
			SteamWorkshopUploader.WorkshopModPack workshopModPack = SteamWorkshopUploader.WorkshopModPack.AKADPGKKCMF(DDAOMDPAIEP);
			if (workshopModPack != null)
			{
				this.MOJAGCMNOKC = workshopModPack;
				this.MIKAJJJAOCP = DDAOMDPAIEP;
				this.LHEAHJCHEAI();
			}
		}

		// Token: 0x060108F9 RID: 67833 RVA: 0x0059E3C5 File Offset: 0x0059C5C5
		public void SaveCurrentModPack()
		{
			if (this.MOJAGCMNOKC != null && !string.IsNullOrEmpty(this.MIKAJJJAOCP))
			{
				this.MOJAGCMNOKC.Save(this.MIKAJJJAOCP);
			}
		}

		// Token: 0x060108FA RID: 67834 RVA: 0x0059E3F4 File Offset: 0x0059C5F4
		private void GEGMEOJODGO(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(MEHNKGDFPEF, AMCGCGIGPCN.changenote);
			this.MAKNNJPMHMM.Set(hAPICall, null);
		}

		// Token: 0x060108FB RID: 67835 RVA: 0x0059E41C File Offset: 0x0059C61C
		public void JIPBCDAMIJD(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			AMCGCGIGPCN.tags = new List<string>(this.modPackTags.text.Split(new char[]
			{
				(char)-22
			}));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		// Token: 0x060108FC RID: 67836 RVA: 0x0059E493 File Offset: 0x0059C693
		public string[] HOFLCLBMOND()
		{
			return Directory.GetFiles(this.GBDJMFMBKCG, "CameraFilterPack_Atmosphere_Rain_FX", SearchOption.TopDirectoryOnly);
		}

		// Token: 0x060108FD RID: 67837 RVA: 0x0059E4A6 File Offset: 0x0059C6A6
		private void ECBPLMKKNDB(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 1 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("Set Crosshair Emission");
			}
			else
			{
				UnityEngine.Debug.Log(". Not connectedAndReady." + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x060108FE RID: 67838 RVA: 0x0059E4E8 File Offset: 0x0059C6E8
		public void OOLNBPJJDDD(string HKMBPFKAPFG)
		{
			string text = "_MinVelocity" + Path.GetExtension(HKMBPFKAPFG);
			string text2 = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "_Value2" + text;
			UnityEngine.Debug.Log("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data" + HKMBPFKAPFG + "CameraFilterPack/Blend2Camera_ColorDodge" + text2);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(HKMBPFKAPFG, text2);
			this.MOJAGCMNOKC.previewfile = text;
			this.OnCurrentModPackChanges();
		}

		// Token: 0x060108FF RID: 67839 RVA: 0x0059E568 File Offset: 0x0059C768
		public void BOIMGMLBBFM()
		{
			IEnumerator enumerator = this.packListRoot.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06010900 RID: 67840 RVA: 0x0059E5D4 File Offset: 0x0059C7D4
		private void BLNHBIJJPFM(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(MEHNKGDFPEF, AMCGCGIGPCN.changenote);
			this.MAKNNJPMHMM.Set(hAPICall, null);
		}

		// Token: 0x06010901 RID: 67841 RVA: 0x0059E5FC File Offset: 0x0059C7FC
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F1))
			{
				SteamAPICall_t numberOfCurrentPlayers = SteamUserStats.GetNumberOfCurrentPlayers();
				this.PEKJOGMJHJC.Set(numberOfCurrentPlayers, null);
				UnityEngine.Debug.Log("Called GetNumberOfCurrentPlayers()");
			}
			if (this.FHKGDJDOKNB != UGCUpdateHandle_t.Invalid)
			{
				this.ILNGINIDLMJ(this.FHKGDJDOKNB);
			}
			else
			{
				this.progressBar.value = 0f;
			}
		}

		// Token: 0x06010902 RID: 67842 RVA: 0x0059E66C File Offset: 0x0059C86C
		private void HOACPFIONCO()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeMicrotransaction);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "Creating new item...";
			}
		}

		// Token: 0x06010903 RID: 67843 RVA: 0x0059E6B7 File Offset: 0x0059C8B7
		public void FPKDKHOLPMN()
		{
			if (this.MOJAGCMNOKC != null && !string.IsNullOrEmpty(this.MIKAJJJAOCP))
			{
				this.MOJAGCMNOKC.OEPMLPHPBBC(this.MIKAJJJAOCP);
			}
		}

		// Token: 0x06010904 RID: 67844 RVA: 0x0059E6E8 File Offset: 0x0059C8E8
		public void DKHBIDKHCDG(string HKMBPFKAPFG)
		{
			string text = "SpawnObj" + Path.GetExtension(HKMBPFKAPFG);
			string text2 = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "_Bloom2" + text;
			UnityEngine.Debug.Log("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory." + HKMBPFKAPFG + "DPADVER" + text2);
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			File.Copy(HKMBPFKAPFG, text2);
			this.MOJAGCMNOKC.previewfile = text;
			this.AEJLMMBKLLL();
		}

		// Token: 0x06010905 RID: 67845 RVA: 0x0059E768 File Offset: 0x0059C968
		private IEnumerable<string> HEFEBGBPNPF(string BNJFKKGOACF)
		{
			SteamWorkshopUploader.EDOGJGNAGMO edogjgnagmo = new SteamWorkshopUploader.EDOGJGNAGMO();
			edogjgnagmo.BNJFKKGOACF = BNJFKKGOACF;
			edogjgnagmo.ABMJMCOLHKE = BNJFKKGOACF;
			SteamWorkshopUploader.EDOGJGNAGMO edogjgnagmo2 = edogjgnagmo;
			edogjgnagmo2.KINKEHIEDHI = 25;
			return edogjgnagmo2;
		}

		// Token: 0x06010906 RID: 67846 RVA: 0x0059E794 File Offset: 0x0059C994
		private void KLMMJHBNNLN(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.IMGCNMHPKMB(ugcupdateHandle_t, AMCGCGIGPCN);
			this.GEGMEOJODGO(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		// Token: 0x06010907 RID: 67847 RVA: 0x0059E7E9 File Offset: 0x0059C9E9
		public void Shutdown()
		{
			SteamAPI.Shutdown();
		}

		// Token: 0x06010908 RID: 67848 RVA: 0x0059E7F0 File Offset: 0x0059C9F0
		public void HIKIHAKHOEB(string DDAOMDPAIEP)
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.AEJLMMBKLLL();
				this.SaveCurrentModPack();
			}
			SteamWorkshopUploader.WorkshopModPack workshopModPack = SteamWorkshopUploader.WorkshopModPack.HABPFPJKJND(DDAOMDPAIEP);
			if (workshopModPack != null)
			{
				this.MOJAGCMNOKC = workshopModPack;
				this.MIKAJJJAOCP = DDAOMDPAIEP;
				this.LHEAHJCHEAI();
			}
		}

		// Token: 0x06010909 RID: 67849 RVA: 0x0059E838 File Offset: 0x0059CA38
		public void PAFDFIMJLKN()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "_ColorBuffer" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "menu.playedpage", text, true);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
			}
			else
			{
				this.modPackPreview.texture = null;
			}
		}

		// Token: 0x0601090A RID: 67850 RVA: 0x0059E8D9 File Offset: 0x0059CAD9
		public void SubmitPreviewFile()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 0U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + this.MOJAGCMNOKC.previewfile);
		}

		// Token: 0x0601090B RID: 67851 RVA: 0x0059E913 File Offset: 0x0059CB13
		public void AEJLMMBKLLL()
		{
			this.PLOLKGCIMBP(this.MOJAGCMNOKC);
			this.LHEAHJCHEAI();
		}

		// Token: 0x0601090C RID: 67852 RVA: 0x0059E927 File Offset: 0x0059CB27
		public void LCOMLGDFJGK()
		{
			SteamUGC.SetItemDescription(this.FHKGDJDOKNB, this.modPackDescription.text);
		}

		// Token: 0x0601090D RID: 67853 RVA: 0x0059E940 File Offset: 0x0059CB40
		private IEnumerable<string> LMAGGFHOHKK(string BNJFKKGOACF)
		{
			SteamWorkshopUploader.EDOGJGNAGMO edogjgnagmo = new SteamWorkshopUploader.EDOGJGNAGMO();
			edogjgnagmo.BNJFKKGOACF = BNJFKKGOACF;
			edogjgnagmo.ABMJMCOLHKE = BNJFKKGOACF;
			SteamWorkshopUploader.EDOGJGNAGMO edogjgnagmo2 = edogjgnagmo;
			edogjgnagmo2.KINKEHIEDHI = 64;
			return edogjgnagmo2;
		}

		// Token: 0x0601090E RID: 67854 RVA: 0x0059E96C File Offset: 0x0059CB6C
		public void LGKLHCCCAOL()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.JIPBCDAMIJD(this.MOJAGCMNOKC);
				this.CMPHOBBNEKE();
				if (this.ValidateModPack(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.NGPHOBINMKI());
					}
					else
					{
						this.CHDKOIDJILI(this.MOJAGCMNOKC);
					}
				}
			}
		}

		// Token: 0x0601090F RID: 67855 RVA: 0x0059E9DC File Offset: 0x0059CBDC
		public void FCLLMKLEOKN()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("Set satellite trail width"))
			{
				this.statusText.text = string.Format(" on effect ", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + "_Value5");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.LAGOBJKALFB(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.HIKIHAKHOEB(text2);
			}
		}

		// Token: 0x06010910 RID: 67856 RVA: 0x0059EA90 File Offset: 0x0059CC90
		private void HLBILBJDODJ(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "public";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult != (EResult)120)
			{
				if (eResult != EResult.k_EResultServiceReadOnly)
				{
					if (eResult == EResult.k_EResultIgnored)
					{
						this.statusText.text = "_ClutTex";
					}
				}
				else
				{
					this.statusText.text = "GlassDistortion";
				}
			}
			else
			{
				this.statusText.text = "_TimeX";
			}
			if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
			}
			if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "[PlayerController] " + NPIKJHPJIEA.m_nPublishedFileId.ToString();
				UnityEngine.Debug.Log("Objects in List: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.MOJAGCMNOKC.publishedfileid = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			}
		}

		// Token: 0x06010911 RID: 67857 RVA: 0x0059EB98 File Offset: 0x0059CD98
		private void JPFMHEGEMNI()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "[EditorEvent] Exception: ";
			}
		}

		// Token: 0x06010912 RID: 67858 RVA: 0x0059DD67 File Offset: 0x0059BF67
		public void ACMHHAIOKAK()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		// Token: 0x06010913 RID: 67859 RVA: 0x0059EBE4 File Offset: 0x0059CDE4
		public void PLOLKGCIMBP(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			string text = this.modPackTags.text;
			char[] array = new char[0];
			array[1] = (char)-7;
			AMCGCGIGPCN.tags = new List<string>(text.Split(array));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		// Token: 0x06010914 RID: 67860 RVA: 0x0059EC5C File Offset: 0x0059CE5C
		public void MJNAILJHEJE()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.MKJHGEHJEMK(this.MOJAGCMNOKC);
				this.FPKDKHOLPMN();
				if (this.BNBAPAOKFDK(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.KOCJHPLNFHM());
					}
					else
					{
						this.IGPLFKKNCFP(this.MOJAGCMNOKC);
					}
				}
			}
		}

		// Token: 0x06010915 RID: 67861 RVA: 0x0059ECCC File Offset: 0x0059CECC
		public void OFBMLLENJMK(string DDAOMDPAIEP)
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.AEJLMMBKLLL();
				this.SaveCurrentModPack();
			}
			SteamWorkshopUploader.WorkshopModPack workshopModPack = SteamWorkshopUploader.WorkshopModPack.OEFGNCDIIFL(DDAOMDPAIEP);
			if (workshopModPack != null)
			{
				this.MOJAGCMNOKC = workshopModPack;
				this.MIKAJJJAOCP = DDAOMDPAIEP;
				this.RefreshCurrentModPack();
			}
		}

		// Token: 0x06010916 RID: 67862 RVA: 0x0059ED14 File Offset: 0x0059CF14
		private void FLBGMCIJGAN(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.OGNLJFMBGFH(ugcupdateHandle_t, AMCGCGIGPCN);
			this.HHLHCBBOAEH(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		// Token: 0x06010917 RID: 67863 RVA: 0x0059ED6C File Offset: 0x0059CF6C
		private IEnumerator NGPHOBINMKI()
		{
			this.HOACPFIONCO();
			yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
			this.IGPLFKKNCFP(this.MOJAGCMNOKC);
			yield break;
		}

		// Token: 0x06010918 RID: 67864 RVA: 0x0059ED88 File Offset: 0x0059CF88
		private void JPPGIKCKFJL()
		{
			if (SteamManager.CEIGOIJPONC())
			{
				this.PEKJOGMJHJC = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.ECBPLMKKNDB));
				this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.HLBILBJDODJ));
				this.MAKNNJPMHMM = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.LBIGHMKJMLD));
			}
		}

		// Token: 0x06010919 RID: 67865 RVA: 0x0059EDE4 File Offset: 0x0059CFE4
		public void HMNPAOLMDNB()
		{
			IEnumerator enumerator = this.packListRoot.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					UnityEngine.Object.Destroy(transform.gameObject);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x0601091A RID: 67866 RVA: 0x0059EE50 File Offset: 0x0059D050
		private void HHLHCBBOAEH(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamAPICall_t hAPICall = SteamUGC.SubmitItemUpdate(MEHNKGDFPEF, AMCGCGIGPCN.changenote);
			this.MAKNNJPMHMM.Set(hAPICall, null);
		}

		// Token: 0x0601091B RID: 67867 RVA: 0x0059EE77 File Offset: 0x0059D077
		public void CMPHOBBNEKE()
		{
			if (this.MOJAGCMNOKC != null && !string.IsNullOrEmpty(this.MIKAJJJAOCP))
			{
				this.MOJAGCMNOKC.BGPCGJNFHEO(this.MIKAJJJAOCP);
			}
		}

		// Token: 0x0601091C RID: 67868 RVA: 0x0059EEA8 File Offset: 0x0059D0A8
		private void KGDLDOBGBKB(UGCUpdateHandle_t MEHNKGDFPEF)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(MEHNKGDFPEF, out num, out num2);
			float value = num / num2;
			this.progressBar.value = value;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				if (this.LMAGGFHOHKK(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
				{
					this.statusText.text = "{0:0} second{1}";
				}
				else
				{
					this.statusText.text = "_Value4";
				}
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				this.statusText.text = "ComboScoreText";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				this.statusText.text = ".status";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				this.statusText.text = "Case-Sensitive";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				this.statusText.text = "_MainTex2";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				this.statusText.text = ". Going to ignore! Check PhotonServerSettings.RpcList";
				break;
			}
		}

		// Token: 0x0601091D RID: 67869 RVA: 0x0059EFBC File Offset: 0x0059D1BC
		private void ILNGINIDLMJ(UGCUpdateHandle_t MEHNKGDFPEF)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(MEHNKGDFPEF, out num, out num2);
			float value = num / num2;
			this.progressBar.value = value;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				if (this.GIMIDCCBDLB(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
				{
					this.statusText.text = "Item invalid. Make sure your mod contains at leats one file.";
				}
				else
				{
					this.statusText.text = "Item invalid. No idea why.";
				}
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				this.statusText.text = "Preparing configuration...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				this.statusText.text = "Preparing content...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				this.statusText.text = "Uploading content...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				this.statusText.text = "Uploading preview image...";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				this.statusText.text = "Committing changes...";
				break;
			}
		}

		// Token: 0x0601091E RID: 67870 RVA: 0x0059F0D0 File Offset: 0x0059D2D0
		public void AIAJMINHCDP(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			AMCGCGIGPCN.title = this.modPackTitle.text;
			AMCGCGIGPCN.description = this.modPackDescription.text;
			string text = this.modPackTags.text;
			char[] array = new char[0];
			array[1] = '<';
			AMCGCGIGPCN.tags = new List<string>(text.Split(array));
			AMCGCGIGPCN.itemtype = this.modPackItemType.value;
			AMCGCGIGPCN.visibility = this.modPackVisibility.value;
		}

		// Token: 0x0601091F RID: 67871 RVA: 0x0059F147 File Offset: 0x0059D347
		private void LJBLDNAIMIJ()
		{
			this.GBDJMFMBKCG = new DirectoryInfo(Helpers.GetDirectory("Uploader")).FullName;
			if (!Directory.Exists(this.GBDJMFMBKCG))
			{
				Directory.CreateDirectory(this.GBDJMFMBKCG);
			}
		}

		// Token: 0x06010920 RID: 67872 RVA: 0x0059F180 File Offset: 0x0059D380
		private void IGPLFKKNCFP(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.ICEAFLAMDJL(ugcupdateHandle_t, AMCGCGIGPCN);
			this.HHLHCBBOAEH(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		// Token: 0x06010921 RID: 67873 RVA: 0x0059F1D5 File Offset: 0x0059D3D5
		private void LBOBAIGNOML()
		{
			this.NDDAFHGLKJO();
		}

		// Token: 0x06010922 RID: 67874 RVA: 0x0059F1E0 File Offset: 0x0059D3E0
		public void LGFJHOBDHON()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "-showlogs" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "#tryagain", text, true);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
			}
			else
			{
				this.modPackPreview.texture = null;
			}
		}

		// Token: 0x06010923 RID: 67875 RVA: 0x0059E927 File Offset: 0x0059CB27
		public void IFCLAJOCHPA()
		{
			SteamUGC.SetItemDescription(this.FHKGDJDOKNB, this.modPackDescription.text);
		}

		// Token: 0x06010924 RID: 67876 RVA: 0x0059F284 File Offset: 0x0059D484
		private void DPFPADAHIMC(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamUGC.SetItemTitle(MEHNKGDFPEF, AMCGCGIGPCN.title);
			SteamUGC.SetItemDescription(MEHNKGDFPEF, AMCGCGIGPCN.description);
			SteamUGC.SetItemVisibility(MEHNKGDFPEF, (ERemoteStoragePublishedFileVisibility)AMCGCGIGPCN.visibility);
			SteamUGC.SetItemContent(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
			SteamUGC.SetItemPreview(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "Object ID. Case-Sensitive" + AMCGCGIGPCN.previewfile);
			SteamUGC.SetItemMetadata(MEHNKGDFPEF, AMCGCGIGPCN.metadata);
			List<string> list = new List<string>();
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("true");
			}
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("on master");
			}
			if (AMCGCGIGPCN.itemtype == 1)
			{
				list.Add(": ");
			}
			List<string> list2 = list;
			string text = this.modPackTags.text;
			char[] array = new char[0];
			array[1] = ')';
			list2.AddRange(text.Split(array));
			SteamUGC.SetItemTags(MEHNKGDFPEF, list);
		}

		// Token: 0x06010925 RID: 67877 RVA: 0x0059F384 File Offset: 0x0059D584
		private void PFIPOJIIODP(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Error: I/O Failure! :(";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult != EResult.k_EResultInsufficientPrivilege)
			{
				if (eResult != EResult.k_EResultTimeout)
				{
					if (eResult == EResult.k_EResultNotLoggedOn)
					{
						this.statusText.text = "Error: You're not logged into Steam!";
					}
				}
				else
				{
					this.statusText.text = "Error: Timeout :S";
				}
			}
			else
			{
				this.statusText.text = "Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
			}
			if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
			}
			if (NPIKJHPJIEA.m_eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "Item creation successful! Published Item ID: " + NPIKJHPJIEA.m_nPublishedFileId.ToString();
				UnityEngine.Debug.Log("Item created: Id: " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.MOJAGCMNOKC.publishedfileid = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			}
		}

		// Token: 0x06010926 RID: 67878 RVA: 0x0059F48C File Offset: 0x0059D68C
		public bool LHFIDPMAOJH(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			bool result;
			try
			{
				this.statusText.text = "hidden";
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "ComboText" + AMCGCGIGPCN.previewfile;
				if (AMCGCGIGPCN.previewfile == null || AMCGCGIGPCN.previewfile.Length == 0)
				{
					this.statusText.text = "_Value2";
					result = true;
				}
				else if (!File.Exists(text))
				{
					this.statusText.text = "MenuScene";
					result = true;
				}
				else
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Length >= -2L)
					{
						this.statusText.text = "Saved Game: ";
						result = false;
					}
					else if (!Directory.Exists(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)))
					{
						this.statusText.text = "_TimeX";
						result = false;
					}
					else if (this.GIMIDCCBDLB(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
					{
						this.statusText.text = "#tryagain";
						result = true;
					}
					else
					{
						this.statusText.text = "settings.disablestoryboard";
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogException(ex);
				this.statusText.text = "VeryHigh" + ex.ToString();
				result = true;
			}
			return result;
		}

		// Token: 0x06010927 RID: 67879 RVA: 0x0059F630 File Offset: 0x0059D830
		private void OKPOANHMEHD(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "AudioSampler";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == (EResult)0)
			{
				this.statusText.text = "_DotSize";
				SteamFriends.ActivateGameOverlayToWebPage("quit" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		// Token: 0x06010928 RID: 67880 RVA: 0x0059F6AC File Offset: 0x0059D8AC
		private void PODDPKLNCIL()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "GroupNameText";
			}
		}

		// Token: 0x06010929 RID: 67881 RVA: 0x0059F6F8 File Offset: 0x0059D8F8
		private void KAAFANPPFPH(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			ulong value = ulong.Parse(AMCGCGIGPCN.publishedfileid);
			PublishedFileId_t nPublishedFileID = new PublishedFileId_t(value);
			UGCUpdateHandle_t ugcupdateHandle_t = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), nPublishedFileID);
			AMCGCGIGPCN.changenote = this.modPackChangeNotes.text;
			this.FHKGDJDOKNB = ugcupdateHandle_t;
			this.ICEAFLAMDJL(ugcupdateHandle_t, AMCGCGIGPCN);
			this.GEGMEOJODGO(ugcupdateHandle_t, AMCGCGIGPCN);
		}

		// Token: 0x0601092A RID: 67882 RVA: 0x0059E927 File Offset: 0x0059CB27
		public void JCFHPLALGFF()
		{
			SteamUGC.SetItemDescription(this.FHKGDJDOKNB, this.modPackDescription.text);
		}

		// Token: 0x0601092C RID: 67884 RVA: 0x0059F760 File Offset: 0x0059D960
		public void JKFFCBMOCKD()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "_TimeX" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "_OcclusionBlurTexture", text, true);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
			}
			else
			{
				this.modPackPreview.texture = null;
			}
		}

		// Token: 0x0601092D RID: 67885 RVA: 0x0059F801 File Offset: 0x0059DA01
		private void HIPEHGNBJMN()
		{
			this.versionText.text = "skin.no_hit";
			if (SteamUtils.GetAppID() == AppId_t.Invalid)
			{
				UnityEngine.Debug.LogError("Value", this);
			}
			this.RefreshPackList();
			this.RefreshCurrentModPack();
		}

		// Token: 0x0601092E RID: 67886 RVA: 0x0059F83E File Offset: 0x0059DA3E
		private void HGHMIBJECEI(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 1 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("x");
			}
			else
			{
				UnityEngine.Debug.Log("_MotionBlurTmpCam" + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x0601092F RID: 67887 RVA: 0x0059F880 File Offset: 0x0059DA80
		private void ICEAFLAMDJL(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamUGC.SetItemTitle(MEHNKGDFPEF, AMCGCGIGPCN.title);
			SteamUGC.SetItemDescription(MEHNKGDFPEF, AMCGCGIGPCN.description);
			SteamUGC.SetItemVisibility(MEHNKGDFPEF, (ERemoteStoragePublishedFileVisibility)AMCGCGIGPCN.visibility);
			SteamUGC.SetItemContent(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
			SteamUGC.SetItemPreview(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + AMCGCGIGPCN.previewfile);
			SteamUGC.SetItemMetadata(MEHNKGDFPEF, AMCGCGIGPCN.metadata);
			List<string> list = new List<string>();
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("arcs");
			}
			if (AMCGCGIGPCN.itemtype == 1)
			{
				list.Add("menutheme");
			}
			if (AMCGCGIGPCN.itemtype == 2)
			{
				list.Add("MascotChallenge2019");
			}
			list.AddRange(this.modPackTags.text.Split(new char[]
			{
				','
			}));
			SteamUGC.SetItemTags(MEHNKGDFPEF, list);
		}

		// Token: 0x06010930 RID: 67888 RVA: 0x0059F97E File Offset: 0x0059DB7E
		private void JBIFKBNPHJE()
		{
			this.LJBLDNAIMIJ();
		}

		// Token: 0x06010931 RID: 67889 RVA: 0x0059F986 File Offset: 0x0059DB86
		private void EIFCCFBJKOO()
		{
			this.KNKNBGODJCE();
		}

		// Token: 0x06010932 RID: 67890 RVA: 0x0059F990 File Offset: 0x0059DB90
		public void PNDIDBNBLCO()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("tagElement"))
			{
				this.statusText.text = string.Format("_Offsets", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + "EditMenu");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.BGPCGJNFHEO(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.SelectModPack(text2);
			}
		}

		// Token: 0x06010933 RID: 67891 RVA: 0x0059DD67 File Offset: 0x0059BF67
		public void LACEDKKBGNJ()
		{
			Application.OpenURL(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
		}

		// Token: 0x06010934 RID: 67892 RVA: 0x0059FA44 File Offset: 0x0059DC44
		public void OIJFPLJGIJJ()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.PLOLKGCIMBP(this.MOJAGCMNOKC);
				this.SaveCurrentModPack();
				if (this.FNEIJCCNKAB(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.NGPHOBINMKI());
					}
					else
					{
						this.KAAFANPPFPH(this.MOJAGCMNOKC);
					}
				}
			}
		}

		// Token: 0x06010935 RID: 67893 RVA: 0x0059FAB2 File Offset: 0x0059DCB2
		public void OLBMHDPANOC()
		{
			this.OnChanges(this.MOJAGCMNOKC);
			this.RefreshCurrentModPack();
		}

		// Token: 0x06010936 RID: 67894 RVA: 0x0059FAC8 File Offset: 0x0059DCC8
		private void OnEnable()
		{
			if (SteamManager.Initialized)
			{
				this.PEKJOGMJHJC = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.JGJHAPAHBEJ));
				this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
				this.MAKNNJPMHMM = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.AGKFBBAENIE));
			}
		}

		// Token: 0x06010937 RID: 67895 RVA: 0x0059FB24 File Offset: 0x0059DD24
		private void EDOCDENEDLK(CreateItemResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Case-Sensitive";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult != (EResult)(-52))
			{
				if (eResult != EResult.k_EResultNotSettled)
				{
					if (eResult == EResult.k_EResultValueOutOfRange)
					{
						this.statusText.text = "_Value";
					}
				}
				else
				{
					this.statusText.text = "_Value2";
				}
			}
			else
			{
				this.statusText.text = "ViewMenu";
			}
			if (NPIKJHPJIEA.m_bUserNeedsToAcceptWorkshopLegalAgreement)
			{
			}
			if (NPIKJHPJIEA.m_eResult == (EResult)0)
			{
				this.statusText.text = "_Red_C" + NPIKJHPJIEA.m_nPublishedFileId.ToString();
				UnityEngine.Debug.Log("WARNING: rotation axis set to 0 on " + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.MOJAGCMNOKC.publishedfileid = NPIKJHPJIEA.m_nPublishedFileId.ToString();
			}
		}

		// Token: 0x06010938 RID: 67896 RVA: 0x0059FC2A File Offset: 0x0059DE2A
		public void DBGOKAPFDEI()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 0U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + " Remote called." + this.MOJAGCMNOKC.previewfile);
		}

		// Token: 0x06010939 RID: 67897 RVA: 0x0059DBF0 File Offset: 0x0059BDF0
		private void GFGFNBMCMCM()
		{
			this.RefreshPackList();
		}

		// Token: 0x0601093A RID: 67898 RVA: 0x0059FC64 File Offset: 0x0059DE64
		public bool BNBAPAOKFDK(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			bool result;
			try
			{
				this.statusText.text = "PLEASE WAIT";
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "SetPlayerDistance" + AMCGCGIGPCN.previewfile;
				if (AMCGCGIGPCN.previewfile == null || AMCGCGIGPCN.previewfile.Length == 0)
				{
					this.statusText.text = "Most likely the game became empty during the switch to GameServer.";
					result = false;
				}
				else if (!File.Exists(text))
				{
					this.statusText.text = "LevelConfigButton";
					result = false;
				}
				else
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Length >= -94L)
					{
						this.statusText.text = ":";
						result = true;
					}
					else if (!Directory.Exists(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)))
					{
						this.statusText.text = "CameraFilterPack/Glitch_Mozaic";
						result = true;
					}
					else if (this.LMAGGFHOHKK(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
					{
						this.statusText.text = "Editor/";
						result = true;
					}
					else
					{
						this.statusText.text = "_Blue_C";
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogException(ex);
				this.statusText.text = "Is it practically possible?" + ex.ToString();
				result = false;
			}
			return result;
		}

		// Token: 0x0601093B RID: 67899 RVA: 0x0059FE08 File Offset: 0x0059E008
		public void LJDDEHIHIHJ()
		{
			SteamUGC.UpdateItemPreviewFile(this.FHKGDJDOKNB, 0U, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "skin." + this.MOJAGCMNOKC.previewfile);
		}

		// Token: 0x0601093C RID: 67900 RVA: 0x0059FE44 File Offset: 0x0059E044
		public bool ValidateModPack(SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			bool result;
			try
			{
				this.statusText.text = "Validating mod pack...";
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + AMCGCGIGPCN.previewfile;
				if (AMCGCGIGPCN.previewfile == null || AMCGCGIGPCN.previewfile.Length == 0)
				{
					this.statusText.text = "ERROR: preview file name is empty in modName.workshop.json";
					result = false;
				}
				else if (!File.Exists(text))
				{
					this.statusText.text = "ERROR: Preview file name in modName.workshop.json doesn't match any file";
					result = false;
				}
				else
				{
					FileInfo fileInfo = new FileInfo(text);
					if (fileInfo.Length >= 1048576L)
					{
						this.statusText.text = "ERROR: Preview file must be <1MB!";
						result = false;
					}
					else if (!Directory.Exists(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)))
					{
						this.statusText.text = "ERROR: mod directory not found!";
						result = false;
					}
					else if (this.GIMIDCCBDLB(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
					{
						this.statusText.text = "ERROR: Make sure your mod contains at leats one file!";
						result = false;
					}
					else
					{
						this.statusText.text = "No problem found, so far";
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogException(ex);
				this.statusText.text = "EXCEPTION:" + ex.ToString();
				result = false;
			}
			return result;
		}

		// Token: 0x0601093D RID: 67901 RVA: 0x0059E927 File Offset: 0x0059CB27
		public void SubmitDescription()
		{
			SteamUGC.SetItemDescription(this.FHKGDJDOKNB, this.modPackDescription.text);
		}

		// Token: 0x0601093E RID: 67902 RVA: 0x0059FFE8 File Offset: 0x0059E1E8
		private void OGNLJFMBGFH(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamUGC.SetItemTitle(MEHNKGDFPEF, AMCGCGIGPCN.title);
			SteamUGC.SetItemDescription(MEHNKGDFPEF, AMCGCGIGPCN.description);
			SteamUGC.SetItemVisibility(MEHNKGDFPEF, (ERemoteStoragePublishedFileVisibility)AMCGCGIGPCN.visibility);
			SteamUGC.SetItemContent(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
			SteamUGC.SetItemPreview(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "[PlayerController] " + AMCGCGIGPCN.previewfile);
			SteamUGC.SetItemMetadata(MEHNKGDFPEF, AMCGCGIGPCN.metadata);
			List<string> list = new List<string>();
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("_ScreenResolution");
			}
			if (AMCGCGIGPCN.itemtype == 1)
			{
				list.Add("player.quantum");
			}
			if (AMCGCGIGPCN.itemtype == 2)
			{
				list.Add("_TimeX");
			}
			List<string> list2 = list;
			string text = this.modPackTags.text;
			char[] array = new char[1];
			array[1] = (char)-34;
			list2.AddRange(text.Split(array));
			SteamUGC.SetItemTags(MEHNKGDFPEF, list);
		}

		// Token: 0x0601093F RID: 67903 RVA: 0x0059F97E File Offset: 0x0059DB7E
		private void Awake()
		{
			this.LJBLDNAIMIJ();
		}

		// Token: 0x06010940 RID: 67904 RVA: 0x005A00E6 File Offset: 0x0059E2E6
		private void JGJHAPAHBEJ(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 1 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("There was an error retrieving the NumberOfCurrentPlayers.");
			}
			else
			{
				UnityEngine.Debug.Log("The number of players playing your game: " + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x06010941 RID: 67905 RVA: 0x005A0125 File Offset: 0x0059E325
		private void FPFBHJCLAKD(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 0 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("GlassAberration");
			}
			else
			{
				UnityEngine.Debug.Log("_Value3" + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x06010942 RID: 67906 RVA: 0x005A0164 File Offset: 0x0059E364
		public void EditModPack(string HEDGDOFMELF)
		{
			Process.Start(HEDGDOFMELF);
		}

		// Token: 0x06010943 RID: 67907 RVA: 0x005A0170 File Offset: 0x0059E370
		private void GPOGGKBLHLB(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "ItemNameText";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == (EResult)0)
			{
				this.statusText.text = "SfxVolumeSlider";
				SteamFriends.ActivateGameOverlayToWebPage("_TimeX" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		// Token: 0x06010944 RID: 67908 RVA: 0x0059DBF0 File Offset: 0x0059BDF0
		private void LEAHIEEINFH()
		{
			this.RefreshPackList();
		}

		// Token: 0x06010945 RID: 67909 RVA: 0x005A01EC File Offset: 0x0059E3EC
		private void BGAFFMDGFJN(UGCUpdateHandle_t MEHNKGDFPEF)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(MEHNKGDFPEF, out num, out num2);
			float value = num / num2;
			this.progressBar.value = value;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				if (this.GIMIDCCBDLB(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
				{
					this.statusText.text = "mapselector.orderby";
				}
				else
				{
					this.statusText.text = "_CutOff";
				}
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				this.statusText.text = "Failed to Instantiate prefab: ";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				this.statusText.text = "_VelocityScale";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				this.statusText.text = "Please specify either t or f.";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				this.statusText.text = "FinishMap";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				this.statusText.text = "https://store.steampowered.com/recommended/recommendgame/";
				break;
			}
		}

		// Token: 0x06010946 RID: 67910 RVA: 0x005A02FD File Offset: 0x0059E4FD
		public string[] GetPackFilenames()
		{
			return Directory.GetFiles(this.GBDJMFMBKCG, "*.workshop.json", SearchOption.TopDirectoryOnly);
		}

		// Token: 0x06010947 RID: 67911 RVA: 0x005A0310 File Offset: 0x0059E510
		private void IHINPPMDGBE(NumberOfCurrentPlayers_t IAFAANLMOAG, bool MIOCPAMDBCN)
		{
			if (IAFAANLMOAG.m_bSuccess != 0 || MIOCPAMDBCN)
			{
				UnityEngine.Debug.Log("z");
			}
			else
			{
				UnityEngine.Debug.Log("Set Sun Emission" + IAFAANLMOAG.m_cPlayers);
			}
		}

		// Token: 0x06010948 RID: 67912 RVA: 0x005A0350 File Offset: 0x0059E550
		public void RefreshPreview()
		{
			if (this.MOJAGCMNOKC.previewfile != null && this.MOJAGCMNOKC.previewfile.Length != 0)
			{
				string text = Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + "/" + this.MOJAGCMNOKC.previewfile;
				if (!File.Exists(text))
				{
					File.Copy(Application.streamingAssetsPath + "/512px-512px.png", text, false);
				}
				this.modPackPreview.texture = FILE.ReadTexture(text);
			}
			else
			{
				this.modPackPreview.texture = null;
			}
		}

		// Token: 0x06010949 RID: 67913 RVA: 0x005A03F4 File Offset: 0x0059E5F4
		private void GNDJNBNCGFJ(SubmitItemUpdateResult_t NPIKJHPJIEA, bool DNMPOBBBLBD)
		{
			if (DNMPOBBBLBD)
			{
				this.statusText.text = "Preparing content";
				return;
			}
			EResult eResult = NPIKJHPJIEA.m_eResult;
			if (eResult == EResult.k_EResultOK)
			{
				this.statusText.text = "LastNewsButton";
				SteamFriends.ActivateGameOverlayToWebPage("#FFDA44" + NPIKJHPJIEA.m_nPublishedFileId.ToString());
				this.FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;
			}
		}

		// Token: 0x0601094A RID: 67914 RVA: 0x005A0470 File Offset: 0x0059E670
		private void HIFPDKKBDHJ()
		{
			if (SteamManager.EKLAPOPMFBB())
			{
				this.PEKJOGMJHJC = CallResult<NumberOfCurrentPlayers_t>.Create(new CallResult<NumberOfCurrentPlayers_t>.APIDispatchDelegate(this.ECBPLMKKNDB));
				this.CEJIPNKDJKJ = CallResult<CreateItemResult_t>.Create(new CallResult<CreateItemResult_t>.APIDispatchDelegate(this.PFIPOJIIODP));
				this.MAKNNJPMHMM = CallResult<SubmitItemUpdateResult_t>.Create(new CallResult<SubmitItemUpdateResult_t>.APIDispatchDelegate(this.LBIGHMKJMLD));
			}
		}

		// Token: 0x0601094B RID: 67915 RVA: 0x005A04CC File Offset: 0x0059E6CC
		private void NDDAFHGLKJO()
		{
			this.GBDJMFMBKCG = new DirectoryInfo(Helpers.GetDirectory("[DiscordController] Connected to {0}#{1}: {2}")).FullName;
			if (!Directory.Exists(this.GBDJMFMBKCG))
			{
				Directory.CreateDirectory(this.GBDJMFMBKCG);
			}
		}

		// Token: 0x0601094C RID: 67916 RVA: 0x005A0164 File Offset: 0x0059E364
		public void EEFMNDPJGII(string HEDGDOFMELF)
		{
			Process.Start(HEDGDOFMELF);
		}

		// Token: 0x0601094D RID: 67917 RVA: 0x0059DBF0 File Offset: 0x0059BDF0
		private void JDJCBKLPBFJ()
		{
			this.RefreshPackList();
		}

		// Token: 0x0601094E RID: 67918 RVA: 0x005A0504 File Offset: 0x0059E704
		private IEnumerable<string> GIMIDCCBDLB(string BNJFKKGOACF)
		{
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(BNJFKKGOACF);
			while (queue.Count > 0)
			{
				BNJFKKGOACF = queue.Dequeue();
				try
				{
					foreach (string item in Directory.GetDirectories(BNJFKKGOACF))
					{
						queue.Enqueue(item);
					}
				}
				catch (Exception message)
				{
					UnityEngine.Debug.LogError(message);
				}
				string[] array = null;
				try
				{
					array = Directory.GetFiles(BNJFKKGOACF);
				}
				catch (Exception message2)
				{
					UnityEngine.Debug.LogError(message2);
				}
				if (array != null)
				{
					for (int j = 0; j < array.Length; j++)
					{
						yield return array[j];
					}
				}
			}
			yield break;
		}

		// Token: 0x0601094F RID: 67919 RVA: 0x005A052E File Offset: 0x0059E72E
		private void Start()
		{
			this.versionText.text = "<b>Intralism Items Uploader</b> by Oxy949";
			if (SteamUtils.GetAppID() == AppId_t.Invalid)
			{
				UnityEngine.Debug.LogError("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", this);
			}
			this.RefreshPackList();
			this.RefreshCurrentModPack();
		}

		// Token: 0x06010950 RID: 67920 RVA: 0x005A056C File Offset: 0x0059E76C
		private IEnumerator KOCJHPLNFHM()
		{
			this.HOACPFIONCO();
			yield return new WaitWhile(new Func<bool>(base.GBKBDKHPLKG));
			this.IGPLFKKNCFP(this.MOJAGCMNOKC);
			yield break;
		}

		// Token: 0x06010951 RID: 67921 RVA: 0x005A0588 File Offset: 0x0059E788
		public void LHEAHJCHEAI()
		{
			if (this.MOJAGCMNOKC == null)
			{
				this.currentItemPanel.gameObject.SetActive(false);
				return;
			}
			this.currentItemPanel.gameObject.SetActive(false);
			string filename = this.MOJAGCMNOKC.filename;
			this.submitButtonText.text = string.Format("_TimeX", Path.GetFileNameWithoutExtension(filename.Replace("FileMenu", string.Empty)));
			this.modPackContents.text = JsonUtility.ToJson(this.MOJAGCMNOKC, false);
			this.JKFFCBMOCKD();
			this.modPackTitle.text = this.MOJAGCMNOKC.title;
			this.modPackPreviewFilename.text = this.MOJAGCMNOKC.previewfile;
			this.modPackContentFolder.text = this.MOJAGCMNOKC.contentfolder;
			this.modPackDescription.text = this.MOJAGCMNOKC.description;
			this.modPackTags.text = string.Join("maps.", this.MOJAGCMNOKC.tags.ToArray());
			this.modPackVisibility.value = this.MOJAGCMNOKC.visibility;
			this.modPackItemType.value = this.MOJAGCMNOKC.itemtype;
		}

		// Token: 0x06010952 RID: 67922 RVA: 0x0059FAB2 File Offset: 0x0059DCB2
		public void OnCurrentModPackChanges()
		{
			this.OnChanges(this.MOJAGCMNOKC);
			this.RefreshCurrentModPack();
		}

		// Token: 0x06010953 RID: 67923 RVA: 0x005A06C0 File Offset: 0x0059E8C0
		public void MAOJKDHEKPD()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.PLOLKGCIMBP(this.MOJAGCMNOKC);
				this.CMPHOBBNEKE();
				if (this.LHFIDPMAOJH(this.MOJAGCMNOKC))
				{
					if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
					{
						base.StartCoroutine(this.NGPHOBINMKI());
					}
					else
					{
						this.KLMMJHBNNLN(this.MOJAGCMNOKC);
					}
				}
			}
		}

		// Token: 0x06010954 RID: 67924 RVA: 0x005A0730 File Offset: 0x0059E930
		private void ANKAPHJLKFI(UGCUpdateHandle_t MEHNKGDFPEF)
		{
			ulong num;
			ulong num2;
			EItemUpdateStatus itemUpdateProgress = SteamUGC.GetItemUpdateProgress(MEHNKGDFPEF, out num, out num2);
			float value = num / num2;
			this.progressBar.value = value;
			switch (itemUpdateProgress)
			{
			case EItemUpdateStatus.k_EItemUpdateStatusInvalid:
				if (this.GIMIDCCBDLB(Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder)).ToList<string>().Count == 0)
				{
					this.statusText.text = "/config";
				}
				else
				{
					this.statusText.text = "#tryagain";
				}
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingConfig:
				this.statusText.text = "_FarCamera";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusPreparingContent:
				this.statusText.text = "Items/";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingContent:
				this.statusText.text = "[PlayerBase] ShowTitle error: ";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusUploadingPreviewFile:
				this.statusText.text = "_Fade";
				break;
			case EItemUpdateStatus.k_EItemUpdateStatusCommittingChanges:
				this.statusText.text = "ReconnectAndRejoin() with AuthValues == null is not correct!";
				break;
			}
		}

		// Token: 0x06010955 RID: 67925 RVA: 0x005A0841 File Offset: 0x0059EA41
		public string[] GLOPHHCPDIB()
		{
			return Directory.GetFiles(this.GBDJMFMBKCG, "Please attach component to a Graphical UI component", SearchOption.TopDirectoryOnly);
		}

		// Token: 0x06010956 RID: 67926 RVA: 0x0059F97E File Offset: 0x0059DB7E
		private void CNDGDDLEFJF()
		{
			this.LJBLDNAIMIJ();
		}

		// Token: 0x06010957 RID: 67927 RVA: 0x005A0854 File Offset: 0x0059EA54
		public void RefreshCurrentModPack()
		{
			if (this.MOJAGCMNOKC == null)
			{
				this.currentItemPanel.gameObject.SetActive(false);
				return;
			}
			this.currentItemPanel.gameObject.SetActive(true);
			string filename = this.MOJAGCMNOKC.filename;
			this.submitButtonText.text = string.Format("SUBMIT '{0}' FILES", Path.GetFileNameWithoutExtension(filename.Replace(".workshop", string.Empty)));
			this.modPackContents.text = JsonUtility.ToJson(this.MOJAGCMNOKC, true);
			this.RefreshPreview();
			this.modPackTitle.text = this.MOJAGCMNOKC.title;
			this.modPackPreviewFilename.text = this.MOJAGCMNOKC.previewfile;
			this.modPackContentFolder.text = this.MOJAGCMNOKC.contentfolder;
			this.modPackDescription.text = this.MOJAGCMNOKC.description;
			this.modPackTags.text = string.Join(",", this.MOJAGCMNOKC.tags.ToArray());
			this.modPackVisibility.value = this.MOJAGCMNOKC.visibility;
			this.modPackItemType.value = this.MOJAGCMNOKC.itemtype;
		}

		// Token: 0x06010958 RID: 67928 RVA: 0x0059E362 File Offset: 0x0059C562
		private void DACAFDPDPAJ()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.CMPHOBBNEKE();
			}
			SteamAPI.Shutdown();
		}

		// Token: 0x06010959 RID: 67929 RVA: 0x005A098C File Offset: 0x0059EB8C
		public void SelectModPack(string DDAOMDPAIEP)
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SteamWorkshopUploader.WorkshopModPack workshopModPack = SteamWorkshopUploader.WorkshopModPack.Load(DDAOMDPAIEP);
			if (workshopModPack != null)
			{
				this.MOJAGCMNOKC = workshopModPack;
				this.MIKAJJJAOCP = DDAOMDPAIEP;
				this.RefreshCurrentModPack();
			}
		}

		// Token: 0x0601095A RID: 67930 RVA: 0x005A09D4 File Offset: 0x0059EBD4
		private void IMGCNMHPKMB(UGCUpdateHandle_t MEHNKGDFPEF, SteamWorkshopUploader.WorkshopModPack AMCGCGIGPCN)
		{
			SteamUGC.SetItemTitle(MEHNKGDFPEF, AMCGCGIGPCN.title);
			SteamUGC.SetItemDescription(MEHNKGDFPEF, AMCGCGIGPCN.description);
			SteamUGC.SetItemVisibility(MEHNKGDFPEF, (ERemoteStoragePublishedFileVisibility)AMCGCGIGPCN.visibility);
			SteamUGC.SetItemContent(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder));
			SteamUGC.SetItemPreview(MEHNKGDFPEF, Path.Combine(this.GBDJMFMBKCG, this.MOJAGCMNOKC.contentfolder) + ")." + AMCGCGIGPCN.previewfile);
			SteamUGC.SetItemMetadata(MEHNKGDFPEF, AMCGCGIGPCN.metadata);
			List<string> list = new List<string>();
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("_LightIntensity");
			}
			if (AMCGCGIGPCN.itemtype == 0)
			{
				list.Add("PerfectHitsScoreText");
			}
			if (AMCGCGIGPCN.itemtype == 5)
			{
				list.Add(" has been disabled as it's not supported on the current platform.");
			}
			List<string> list2 = list;
			string text = this.modPackTags.text;
			char[] array = new char[0];
			array[1] = 'G';
			list2.AddRange(text.Split(array));
			SteamUGC.SetItemTags(MEHNKGDFPEF, list);
		}

		// Token: 0x0601095B RID: 67931 RVA: 0x005A0AD4 File Offset: 0x0059ECD4
		private void FBIJAADFFHH()
		{
			if (string.IsNullOrEmpty(this.MOJAGCMNOKC.publishedfileid))
			{
				SteamAPICall_t hAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeFirst);
				this.CEJIPNKDJKJ.Set(hAPICall, null);
				this.statusText.text = "_ScreenResolution";
			}
		}

		// Token: 0x0601095C RID: 67932 RVA: 0x005A0B20 File Offset: 0x0059ED20
		public void COLJBNBGKBL()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("CameraFilterPack/TV_CompressionFX"))
			{
				this.statusText.text = string.Format(" not exist", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + "float,0");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.JLEABMCEMNE(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.SelectModPack(text2);
			}
		}

		// Token: 0x0601095D RID: 67933 RVA: 0x005A0BD3 File Offset: 0x0059EDD3
		private void OnApplicationQuit()
		{
			if (this.MOJAGCMNOKC != null)
			{
				this.OnCurrentModPackChanges();
				this.SaveCurrentModPack();
			}
			SteamAPI.Shutdown();
		}

		// Token: 0x0601095E RID: 67934 RVA: 0x005A0BF4 File Offset: 0x0059EDF4
		public void LMFGLOFEAIO()
		{
			string text = this.modPackName.text;
			if (string.IsNullOrEmpty(text) || text.Contains("UseScanLine"))
			{
				this.statusText.text = string.Format("RoomNameText", this.modPackName.text);
			}
			else
			{
				string text2 = Path.Combine(this.GBDJMFMBKCG, text + "Please attach component to a Graphical UI component");
				new SteamWorkshopUploader.WorkshopModPack
				{
					contentfolder = text
				}.Save(text2);
				string text3 = this.modPackName.text;
				string path = Path.Combine(this.GBDJMFMBKCG, text3);
				Directory.CreateDirectory(path);
				this.RefreshPackList();
				this.LFFDPBAAODI(text2);
			}
		}

		// Token: 0x0601095F RID: 67935 RVA: 0x005A0CA7 File Offset: 0x0059EEA7
		private void KNKNBGODJCE()
		{
			this.GBDJMFMBKCG = new DirectoryInfo(Helpers.GetDirectory("&map=")).FullName;
			if (!Directory.Exists(this.GBDJMFMBKCG))
			{
				Directory.CreateDirectory(this.GBDJMFMBKCG);
			}
		}

		// Token: 0x04001CF2 RID: 7410
		public const int version = 6;

		// Token: 0x04001CF3 RID: 7411
		public Text versionText;

		// Token: 0x04001CF4 RID: 7412
		public Text statusText;

		// Token: 0x04001CF5 RID: 7413
		public Slider progressBar;

		// Token: 0x04001CF6 RID: 7414
		public RectTransform packListRoot;

		// Token: 0x04001CF7 RID: 7415
		public GameObject packListButtonPrefab;

		// Token: 0x04001CF8 RID: 7416
		[Header("ModPack Interface")]
		public RectTransform currentItemPanel;

		// Token: 0x04001CF9 RID: 7417
		public Text submitButtonText;

		// Token: 0x04001CFA RID: 7418
		public Text modPackContents;

		// Token: 0x04001CFB RID: 7419
		public RawImage modPackPreview;

		// Token: 0x04001CFC RID: 7420
		public InputField modPackName;

		// Token: 0x04001CFD RID: 7421
		public InputField modPackTitle;

		// Token: 0x04001CFE RID: 7422
		public InputField modPackPreviewFilename;

		// Token: 0x04001CFF RID: 7423
		public InputField modPackContentFolder;

		// Token: 0x04001D00 RID: 7424
		public InputField modPackChangeNotes;

		// Token: 0x04001D01 RID: 7425
		public InputField modPackDescription;

		// Token: 0x04001D02 RID: 7426
		public InputField modPackTags;

		// Token: 0x04001D03 RID: 7427
		public Dropdown modPackItemType;

		// Token: 0x04001D04 RID: 7428
		public Dropdown modPackVisibility;

		// Token: 0x04001D05 RID: 7429
		private const string MLGHCBDKEFO = "NewCustomItem.workshop.json";

		// Token: 0x04001D06 RID: 7430
		private const string GKIMDKGACEO = "NewCustomItem";

		// Token: 0x04001D07 RID: 7431
		private const string KPEELNPGEIJ = "Uploader";

		// Token: 0x04001D08 RID: 7432
		private string GBDJMFMBKCG;

		// Token: 0x04001D09 RID: 7433
		private SteamWorkshopUploader.WorkshopModPack MOJAGCMNOKC;

		// Token: 0x04001D0A RID: 7434
		private string MIKAJJJAOCP;

		// Token: 0x04001D0B RID: 7435
		private UGCUpdateHandle_t FHKGDJDOKNB = UGCUpdateHandle_t.Invalid;

		// Token: 0x04001D0C RID: 7436
		protected CallResult<CreateItemResult_t> CEJIPNKDJKJ;

		// Token: 0x04001D0D RID: 7437
		protected CallResult<SubmitItemUpdateResult_t> MAKNNJPMHMM;

		// Token: 0x04001D0E RID: 7438
		private CallResult<NumberOfCurrentPlayers_t> PEKJOGMJHJC;

		// Token: 0x02000483 RID: 1155
		[Serializable]
		public class WorkshopModPack
		{
			// Token: 0x06010960 RID: 67936 RVA: 0x005A0CE0 File Offset: 0x0059EEE0
			public void BELFGOHNGEN(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010961 RID: 67937 RVA: 0x005A0D00 File Offset: 0x0059EF00
			public static SteamWorkshopUploader.WorkshopModPack CIOIMOJMLGO(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010962 RID: 67938 RVA: 0x005A0D24 File Offset: 0x0059EF24
			public void NKAFIAINMEE(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010963 RID: 67939 RVA: 0x005A0D44 File Offset: 0x0059EF44
			public void PAJBNCNDGPC(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010964 RID: 67940 RVA: 0x005A0D64 File Offset: 0x0059EF64
			public void OEPMLPHPBBC(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010965 RID: 67941 RVA: 0x005A0D84 File Offset: 0x0059EF84
			public static SteamWorkshopUploader.WorkshopModPack OEFGNCDIIFL(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010966 RID: 67942 RVA: 0x005A0DA8 File Offset: 0x0059EFA8
			public void NFBNMAOJLKO(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010967 RID: 67943 RVA: 0x005A0DC8 File Offset: 0x0059EFC8
			public void JCEANEDDOHM(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010968 RID: 67944 RVA: 0x005A0DE8 File Offset: 0x0059EFE8
			public void AODHECFEHDF(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601096A RID: 67946 RVA: 0x005A0E74 File Offset: 0x0059F074
			public static SteamWorkshopUploader.WorkshopModPack KHDAEIMPHOB(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x0601096B RID: 67947 RVA: 0x005A0E98 File Offset: 0x0059F098
			public void LAGOBJKALFB(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601096C RID: 67948 RVA: 0x005A0EB8 File Offset: 0x0059F0B8
			public static SteamWorkshopUploader.WorkshopModPack HABPFPJKJND(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x0601096D RID: 67949 RVA: 0x005A0EDC File Offset: 0x0059F0DC
			public void GKCJNNGAAON(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601096E RID: 67950 RVA: 0x005A0EFC File Offset: 0x0059F0FC
			public void DJKOAFHGPAK(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601096F RID: 67951 RVA: 0x005A0F1C File Offset: 0x0059F11C
			public static SteamWorkshopUploader.WorkshopModPack EGIHAPICIOC(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010970 RID: 67952 RVA: 0x005A0F40 File Offset: 0x0059F140
			public void JLEABMCEMNE(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010971 RID: 67953 RVA: 0x005A0F60 File Offset: 0x0059F160
			public void LCIPMCJFOHP(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010972 RID: 67954 RVA: 0x005A0F80 File Offset: 0x0059F180
			public static SteamWorkshopUploader.WorkshopModPack Load(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010973 RID: 67955 RVA: 0x005A0FA4 File Offset: 0x0059F1A4
			public static SteamWorkshopUploader.WorkshopModPack OECIAHFMEKL(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010974 RID: 67956 RVA: 0x005A0FC8 File Offset: 0x0059F1C8
			public void NHBPDNHIJPA(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010975 RID: 67957 RVA: 0x005A0FE8 File Offset: 0x0059F1E8
			public static SteamWorkshopUploader.WorkshopModPack KDPOBGDKNCF(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010976 RID: 67958 RVA: 0x005A100C File Offset: 0x0059F20C
			public static SteamWorkshopUploader.WorkshopModPack JMDMEOIHENN(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010977 RID: 67959 RVA: 0x005A1030 File Offset: 0x0059F230
			public static SteamWorkshopUploader.WorkshopModPack GDLAFPKOMFI(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x06010978 RID: 67960 RVA: 0x005A1054 File Offset: 0x0059F254
			public void Save(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x06010979 RID: 67961 RVA: 0x005A1074 File Offset: 0x0059F274
			public static SteamWorkshopUploader.WorkshopModPack NCPNNHPJPFA(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x0601097A RID: 67962 RVA: 0x005A1098 File Offset: 0x0059F298
			public void BBKHOOKDOAP(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, false);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601097B RID: 67963 RVA: 0x005A10B8 File Offset: 0x0059F2B8
			public void BGPCGJNFHEO(string HAEBGHHMEBH)
			{
				string eafamamdneg = JsonUtility.ToJson(this, true);
				FILE.WriteText(HAEBGHHMEBH, eafamamdneg);
			}

			// Token: 0x0601097C RID: 67964 RVA: 0x005A10D8 File Offset: 0x0059F2D8
			public static SteamWorkshopUploader.WorkshopModPack MKCBFNCOCHK(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x0601097D RID: 67965 RVA: 0x005A10FC File Offset: 0x0059F2FC
			public static SteamWorkshopUploader.WorkshopModPack AKADPGKKCMF(string HAEBGHHMEBH)
			{
				string json = FILE.ReadText(HAEBGHHMEBH);
				SteamWorkshopUploader.WorkshopModPack workshopModPack = JsonUtility.FromJson<SteamWorkshopUploader.WorkshopModPack>(json);
				workshopModPack.filename = HAEBGHHMEBH;
				return workshopModPack;
			}

			// Token: 0x04001D0F RID: 7439
			[NonSerialized]
			public string filename;

			// Token: 0x04001D10 RID: 7440
			[NonSerialized]
			public string changenote = "Version 1.0";

			// Token: 0x04001D11 RID: 7441
			public string publishedfileid = string.Empty;

			// Token: 0x04001D12 RID: 7442
			public string contentfolder = string.Empty;

			// Token: 0x04001D13 RID: 7443
			public string previewfile = string.Empty;

			// Token: 0x04001D14 RID: 7444
			public int visibility;

			// Token: 0x04001D15 RID: 7445
			public int itemtype;

			// Token: 0x04001D16 RID: 7446
			public string title = "My New Mod Pack";

			// Token: 0x04001D17 RID: 7447
			public string description = "Description goes here";

			// Token: 0x04001D18 RID: 7448
			public string metadata = string.Empty;

			// Token: 0x04001D19 RID: 7449
			public List<string> tags = new List<string>();
		}

		// Token: 0x02000485 RID: 1157
		[CompilerGenerated]
		private sealed class MCFGFBKDOMG
		{
			// Token: 0x060109A7 RID: 68007 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void DBFPGFHEGKA()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109A8 RID: 68008 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void MEMPOPNAEDN()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109A9 RID: 68009 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void LNDGINDKPFA()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AA RID: 68010 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void FFEGPHJKMFK()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AB RID: 68011 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void OFHCGKJFGDI()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AC RID: 68012 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void HBJFIOJFBHC()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AD RID: 68013 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void FJDBPPKABJE()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AE RID: 68014 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void EKHOOPGPPGE()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109AF RID: 68015 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void IGFOBPKFCDJ()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B0 RID: 68016 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void JDELIMPGFDJ()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B1 RID: 68017 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void BKNHHGBPLGH()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B3 RID: 68019 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void FIPCLHEKKCA()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B4 RID: 68020 RVA: 0x005A19D5 File Offset: 0x0059FBD5
			internal void EGKGJJGAPMN()
			{
				this.ADPIKBBAKHP.OFBMLLENJMK(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B5 RID: 68021 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void BFEABMIFIEE()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B6 RID: 68022 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void GBKBDKHPLKG()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B7 RID: 68023 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void LLNDDFGPOPL()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B8 RID: 68024 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void KGKMOLCPDIH()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109B9 RID: 68025 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void BMAOCLKPNNC()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BA RID: 68026 RVA: 0x005A19D5 File Offset: 0x0059FBD5
			internal void JKEDCEOCPJO()
			{
				this.ADPIKBBAKHP.OFBMLLENJMK(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BB RID: 68027 RVA: 0x005A19D5 File Offset: 0x0059FBD5
			internal void OLIGLEMPFOP()
			{
				this.ADPIKBBAKHP.OFBMLLENJMK(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BC RID: 68028 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void KFNBKFELFLH()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BD RID: 68029 RVA: 0x005A19C2 File Offset: 0x0059FBC2
			internal void PIJAOCFAPKC()
			{
				this.ADPIKBBAKHP.HIKIHAKHOEB(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BE RID: 68030 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void LHHFJBIAHCN()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109BF RID: 68031 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void AEINPAGJFME()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109C0 RID: 68032 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void DKGPCPBNDPK()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109C1 RID: 68033 RVA: 0x005A199C File Offset: 0x0059FB9C
			internal void PBCAHKDLFPE()
			{
				this.ADPIKBBAKHP.LFFDPBAAODI(this.HKKPNEHIFKL);
			}

			// Token: 0x060109C2 RID: 68034 RVA: 0x005A19D5 File Offset: 0x0059FBD5
			internal void LOEAMHGMMPK()
			{
				this.ADPIKBBAKHP.OFBMLLENJMK(this.HKKPNEHIFKL);
			}

			// Token: 0x060109C3 RID: 68035 RVA: 0x005A19AF File Offset: 0x0059FBAF
			internal void AGJKEBOPIOC()
			{
				this.ADPIKBBAKHP.SelectModPack(this.HKKPNEHIFKL);
			}

			// Token: 0x060109C4 RID: 68036 RVA: 0x005A19D5 File Offset: 0x0059FBD5
			internal void BDGDIDPDBHG()
			{
				this.ADPIKBBAKHP.OFBMLLENJMK(this.HKKPNEHIFKL);
			}

			// Token: 0x04001D22 RID: 7458
			internal string HKKPNEHIFKL;

			// Token: 0x04001D23 RID: 7459
			internal SteamWorkshopUploader ADPIKBBAKHP;
		}
	}
}
