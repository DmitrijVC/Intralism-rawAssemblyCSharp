using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace OxOD
{
	// Token: 0x02000178 RID: 376
	public class FileDialog : MonoBehaviour
	{
		// Token: 0x06006EAC RID: 28332 RVA: 0x0022805F File Offset: 0x0022625F
		private void IDENAIOPIAB()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06006EAD RID: 28333 RVA: 0x00228070 File Offset: 0x00226270
		private void AAFAONOCAOE()
		{
			GameObject gameObject = this.drivesScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int j = 0; j < logicalDrives.Length; j++)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.drivesScrollRectElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				FileListElement component = gameObject2.GetComponent<FileListElement>();
				component.instance = this;
				component.data = logicalDrives[j];
				component.elementName.text = logicalDrives[j];
				component.isFile = false;
			}
		}

		// Token: 0x06006EAE RID: 28334 RVA: 0x0022814C File Offset: 0x0022634C
		public IEnumerator BBKHOOKDOAP(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "SAVE FILE", Sprite PKDNIDBCMEC = null, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Save;
			this.commit.GetComponentInChildren<Text>().text = "SAVE";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = -1L;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x0022818C File Offset: 0x0022638C
		[CompilerGenerated]
		private bool NCGHIKJOEHI(FileInfo HBJIMONFKNL)
		{
			return this.AIPEHLPLAKK.Contains(HBJIMONFKNL.Extension.ToLower());
		}

		// Token: 0x06006EB0 RID: 28336 RVA: 0x002281A4 File Offset: 0x002263A4
		private void GKCPHHGEDPC()
		{
			GameObject gameObject = this.drivesScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i += 0)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int j = 1; j < logicalDrives.Length; j += 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.drivesScrollRectElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, false);
				gameObject2.transform.localScale = new Vector3(1290f, 528f, 1143f);
				FileListElement component = gameObject2.GetComponent<FileListElement>();
				component.instance = this;
				component.data = logicalDrives[j];
				component.elementName.text = logicalDrives[j];
				component.isFile = true;
			}
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x0022805F File Offset: 0x0022625F
		private void EGJDFKMPGKL()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00228280 File Offset: 0x00226480
		public void OnCancelClick()
		{
			this.result = null;
			this.finished = true;
			this.EGJDFKMPGKL();
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00228296 File Offset: 0x00226496
		public void OFNCIEGIMGD()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = string.Empty;
				this.UpdateFileInfo();
			}
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x002282CB File Offset: 0x002264CB
		public void LKFCHDFLMAO()
		{
			this.BAHCHDMIHKN(this.MIAHHIOALGI + "id");
		}

		// Token: 0x06006EB6 RID: 28342 RVA: 0x002282E3 File Offset: 0x002264E3
		public void SelectFile(string NKAFFBEECFN)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = Path.GetFullPath(NKAFFBEECFN);
			}
			else
			{
				this.IAJGABMBJNH = new FileInfo(Path.GetFullPath(NKAFFBEECFN)).Name;
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x0022831D File Offset: 0x0022651D
		private void FPJBLGCIIHJ()
		{
			this.currentPath.text = this.MIAHHIOALGI;
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00228330 File Offset: 0x00226530
		public void NMEAJNOKKII(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				if (this.AIPEHLPLAKK != null)
				{
					if (this.AIPEHLPLAKK.Contains(new FileInfo(this.IAJGABMBJNH).Extension.ToLower()))
					{
						this.IAJGABMBJNH = LFLMKGGEGDO;
					}
					else
					{
						this.IAJGABMBJNH = LFLMKGGEGDO + this.AIPEHLPLAKK[0];
					}
				}
				else
				{
					this.IAJGABMBJNH = LFLMKGGEGDO;
				}
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x002283AC File Offset: 0x002265AC
		public void UpdateFileInfo()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				try
				{
					this.fileName.text = new FileInfo(this.IAJGABMBJNH).Name;
					this.commit.interactable = File.Exists(this.IAJGABMBJNH);
				}
				catch (Exception)
				{
					this.fileName.text = string.Empty;
					this.commit.interactable = false;
				}
			}
			else
			{
				if (this.IAJGABMBJNH.Length > 0)
				{
					this.fileName.text = new FileInfo(this.IAJGABMBJNH).Name;
				}
				this.commit.interactable = (this.IAJGABMBJNH.Length > 0);
			}
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0022831D File Offset: 0x0022651D
		private void IJEIDOCHNCD()
		{
			this.currentPath.text = this.MIAHHIOALGI;
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x00228480 File Offset: 0x00226680
		public void FDAAMBOINPB()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.result = Path.GetFullPath(this.IAJGABMBJNH);
			}
			else
			{
				this.result = Path.GetFullPath(this.MIAHHIOALGI + "_Value2" + this.IAJGABMBJNH);
			}
			this.finished = false;
			if (this.OOABHMJGDNC)
			{
				Singleton<SaveSystem>.Instance.LIFMHPJPNEP("] to be droppable", this.MIAHHIOALGI, null);
			}
			this.EGJDFKMPGKL();
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x002282E3 File Offset: 0x002264E3
		public void OEAFNCEELAD(string NKAFFBEECFN)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = Path.GetFullPath(NKAFFBEECFN);
			}
			else
			{
				this.IAJGABMBJNH = new FileInfo(Path.GetFullPath(NKAFFBEECFN)).Name;
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x00228500 File Offset: 0x00226700
		private void DOIAODFFNFJ()
		{
			GameObject gameObject = this.drivesScrollRectContent;
			for (int i = 1; i < gameObject.transform.childCount; i += 0)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int j = 0; j < logicalDrives.Length; j += 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.drivesScrollRectElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1280f, 1739f, 71f);
				FileListElement component = gameObject2.GetComponent<FileListElement>();
				component.instance = this;
				component.data = logicalDrives[j];
				component.elementName.text = logicalDrives[j];
				component.isFile = false;
			}
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x002285DC File Offset: 0x002267DC
		public void NEJAAICCKIF(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				if (this.AIPEHLPLAKK != null)
				{
					if (this.AIPEHLPLAKK.Contains(new FileInfo(this.IAJGABMBJNH).Extension.ToLower()))
					{
						this.IAJGABMBJNH = LFLMKGGEGDO;
					}
					else
					{
						this.IAJGABMBJNH = LFLMKGGEGDO + this.AIPEHLPLAKK[1];
					}
				}
				else
				{
					this.IAJGABMBJNH = LFLMKGGEGDO;
				}
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00228657 File Offset: 0x00226857
		public void CAFNPKJKNOA(string NKAFFBEECFN)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = Path.GetFullPath(NKAFFBEECFN);
			}
			else
			{
				this.IAJGABMBJNH = new FileInfo(Path.GetFullPath(NKAFFBEECFN)).Name;
			}
			this.IJOGFIPEHFA();
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x0022818C File Offset: 0x0022638C
		private bool EPEMOBKNJGP(FileInfo HBJIMONFKNL)
		{
			return this.AIPEHLPLAKK.Contains(HBJIMONFKNL.Extension.ToLower());
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00228694 File Offset: 0x00226894
		public void OnCommitClick()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.result = Path.GetFullPath(this.IAJGABMBJNH);
			}
			else
			{
				this.result = Path.GetFullPath(this.MIAHHIOALGI + "/" + this.IAJGABMBJNH);
			}
			this.finished = true;
			if (this.OOABHMJGDNC)
			{
				Singleton<SaveSystem>.Instance.SetString("OxOD.lastPath", this.MIAHHIOALGI, null);
			}
			this.EGJDFKMPGKL();
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00228714 File Offset: 0x00226914
		public IEnumerator OBMMJMIPEBO(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "OPEN FILE", Sprite PKDNIDBCMEC = null, long JJIJODIEBFP = -1L, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Open;
			this.commit.GetComponentInChildren<Text>().text = "OPEN";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = JJIJODIEBFP;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x0022875C File Offset: 0x0022695C
		public IEnumerator KHAOCEGDGAI(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "OPEN FILE", Sprite PKDNIDBCMEC = null, long JJIJODIEBFP = -1L, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Open;
			this.commit.GetComponentInChildren<Text>().text = "OPEN";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = JJIJODIEBFP;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x0022818C File Offset: 0x0022638C
		private bool AMLMJNJBEJG(FileInfo HBJIMONFKNL)
		{
			return this.AIPEHLPLAKK.Contains(HBJIMONFKNL.Extension.ToLower());
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x002287A4 File Offset: 0x002269A4
		public void JGIHEJKMDOC(string HMPALADNHDE)
		{
			if (new DirectoryInfo(HMPALADNHDE).Exists)
			{
				this.BAHCHDMIHKN(HMPALADNHDE + "{0:0} day{1}, ");
			}
			else if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				if (new FileInfo(HMPALADNHDE).Exists)
				{
					this.BAHCHDMIHKN(new FileInfo(HMPALADNHDE).Directory.FullName + "ready");
					this.OKLCBEJDKJK(HMPALADNHDE);
				}
				else
				{
					this.BAHCHDMIHKN(Application.dataPath + "_Value3");
				}
			}
			else if (new DirectoryInfo(new FileInfo(HMPALADNHDE).Directory.FullName + "RT").Exists)
			{
				this.OpenDir(new FileInfo(HMPALADNHDE).Directory.FullName + "note.5");
				this.OKLCBEJDKJK(HMPALADNHDE);
			}
			else
			{
				this.BAHCHDMIHKN(Application.dataPath + "Tab1Content");
			}
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x002288A2 File Offset: 0x00226AA2
		public void GoUp()
		{
			this.OpenDir(this.MIAHHIOALGI + "/../");
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x0022818C File Offset: 0x0022638C
		private bool KNIBBHONKAH(FileInfo HBJIMONFKNL)
		{
			return this.AIPEHLPLAKK.Contains(HBJIMONFKNL.Extension.ToLower());
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x002288BA File Offset: 0x00226ABA
		private void GJJBOKAFBGD()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x06006EC9 RID: 28361 RVA: 0x002288C8 File Offset: 0x00226AC8
		private void BGFJLCFNPFO()
		{
			GameObject gameObject = this.filesScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(this.MIAHHIOALGI);
			try
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int j = 0; j < directories.Length; j++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					FileListElement component = gameObject2.GetComponent<FileListElement>();
					component.instance = this;
					component.data = directories[j].FullName + "/";
					component.elementName.text = directories[j].Name;
					component.size.text = string.Empty;
					component.icon.sprite = this.folderIcon;
					component.isFile = false;
				}
				if (this.AIPEHLPLAKK != null)
				{
					FileInfo[] array = directoryInfo.GetFiles().Where(new Func<FileInfo, bool>(this.NCGHIKJOEHI)).ToArray<FileInfo>();
					for (int k = 0; k < array.Length; k++)
					{
						if (this.JJIJODIEBFP > 0L)
						{
							if (array[k].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject3.transform.SetParent(gameObject.transform, true);
								gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
								FileListElement component2 = gameObject3.GetComponent<FileListElement>();
								component2.instance = this;
								component2.data = array[k].FullName;
								component2.size.text = this.GLHOKPNGKOH(array[k].Length);
								component2.elementName.text = array[k].Name;
								component2.icon.sprite = this.fileIcon;
								component2.isFile = true;
							}
						}
						else
						{
							GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject4.transform.SetParent(gameObject.transform, true);
							gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
							FileListElement component3 = gameObject4.GetComponent<FileListElement>();
							component3.instance = this;
							component3.data = array[k].FullName;
							component3.size.text = this.GLHOKPNGKOH(array[k].Length);
							component3.elementName.text = array[k].Name;
							component3.icon.sprite = this.fileIcon;
							component3.isFile = true;
						}
					}
				}
				else
				{
					FileInfo[] files = directoryInfo.GetFiles();
					for (int l = 0; l < files.Length; l++)
					{
						if (this.JJIJODIEBFP > 0L)
						{
							if (files[l].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject5.transform.SetParent(gameObject.transform, true);
								gameObject5.transform.localScale = new Vector3(1f, 1f, 1f);
								FileListElement component4 = gameObject5.GetComponent<FileListElement>();
								component4.instance = this;
								component4.data = files[l].FullName;
								component4.size.text = this.GLHOKPNGKOH(files[l].Length);
								component4.elementName.text = files[l].Name;
								component4.icon.sprite = this.fileIcon;
								component4.isFile = true;
							}
						}
						else
						{
							GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject6.transform.SetParent(gameObject.transform, true);
							gameObject6.transform.localScale = new Vector3(1f, 1f, 1f);
							FileListElement component5 = gameObject6.GetComponent<FileListElement>();
							component5.instance = this;
							component5.data = files[l].FullName;
							component5.size.text = this.GLHOKPNGKOH(files[l].Length);
							component5.elementName.text = files[l].Name;
							component5.icon.sprite = this.fileIcon;
							component5.isFile = true;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06006ECA RID: 28362 RVA: 0x00228DAC File Offset: 0x00226FAC
		public void OnTypedFilename(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = this.MIAHHIOALGI + "/" + LFLMKGGEGDO;
			}
			else
			{
				this.IAJGABMBJNH = LFLMKGGEGDO;
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x00228DE4 File Offset: 0x00226FE4
		public void GMPKAJNJGPE()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.result = Path.GetFullPath(this.IAJGABMBJNH);
			}
			else
			{
				this.result = Path.GetFullPath(this.MIAHHIOALGI + "_FixDistance" + this.IAJGABMBJNH);
			}
			this.finished = true;
			if (this.OOABHMJGDNC)
			{
				Singleton<SaveSystem>.Instance.KOMAMFOPJID("custom", this.MIAHHIOALGI, null);
			}
			this.MNPFOOPEKNL();
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00228E64 File Offset: 0x00227064
		public IEnumerator Open(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "OPEN FILE", Sprite PKDNIDBCMEC = null, long JJIJODIEBFP = -1L, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Open;
			this.commit.GetComponentInChildren<Text>().text = "OPEN";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = JJIJODIEBFP;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x0022818C File Offset: 0x0022638C
		private bool JADBDECGOEL(FileInfo HBJIMONFKNL)
		{
			return this.AIPEHLPLAKK.Contains(HBJIMONFKNL.Extension.ToLower());
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00228EAC File Offset: 0x002270AC
		public IEnumerator Save(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "SAVE FILE", Sprite PKDNIDBCMEC = null, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Save;
			this.commit.GetComponentInChildren<Text>().text = "SAVE";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = -1L;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x00228EEC File Offset: 0x002270EC
		public IEnumerator BOGKEJDCBIK(string BNJFKKGOACF = null, string AIPEHLPLAKK = null, string KCLEHPAJABP = "OPEN FILE", Sprite PKDNIDBCMEC = null, long JJIJODIEBFP = -1L, bool OOABHMJGDNC = true)
		{
			this.DLGIPFOEDCF = FileDialog.FileDialogMode.Open;
			this.commit.GetComponentInChildren<Text>().text = "OPEN";
			this.fileName.text = string.Empty;
			this.MIAHHIOALGI = string.Empty;
			this.IAJGABMBJNH = string.Empty;
			this.result = null;
			this.finished = false;
			this.JJIJODIEBFP = JJIJODIEBFP;
			this.OOABHMJGDNC = OOABHMJGDNC;
			if (!string.IsNullOrEmpty(AIPEHLPLAKK))
			{
				AIPEHLPLAKK = AIPEHLPLAKK.ToLower();
				this.AIPEHLPLAKK = AIPEHLPLAKK.Split(new char[]
				{
					'|'
				});
			}
			if (string.IsNullOrEmpty(BNJFKKGOACF))
			{
				BNJFKKGOACF = ((!OOABHMJGDNC) ? (Application.dataPath + "/../") : ((!string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null))) ? Singleton<SaveSystem>.Instance.GetString("OxOD.lastPath", null) : (Application.dataPath + "/../")));
			}
			this.windowName.text = KCLEHPAJABP;
			if (PKDNIDBCMEC)
			{
				this.windowIcon.sprite = PKDNIDBCMEC;
			}
			this.GoTo(BNJFKKGOACF);
			base.gameObject.SetActive(true);
			while (!this.finished)
			{
				yield return new WaitForSeconds(0.1f);
			}
			yield break;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00228296 File Offset: 0x00226496
		public void ClearSelection()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = string.Empty;
				this.UpdateFileInfo();
			}
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00228F34 File Offset: 0x00227134
		public void PFMMIDKLCGA(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = this.MIAHHIOALGI + "_TimeX" + LFLMKGGEGDO;
			}
			else
			{
				this.IAJGABMBJNH = LFLMKGGEGDO;
			}
			this.IJOGFIPEHFA();
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00228F6C File Offset: 0x0022716C
		public void GDBCPGAJMKB(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				if (this.AIPEHLPLAKK != null)
				{
					if (this.AIPEHLPLAKK.Contains(new FileInfo(this.IAJGABMBJNH).Extension.ToLower()))
					{
						this.IAJGABMBJNH = LFLMKGGEGDO;
					}
					else
					{
						this.IAJGABMBJNH = LFLMKGGEGDO + this.AIPEHLPLAKK[1];
					}
				}
				else
				{
					this.IAJGABMBJNH = LFLMKGGEGDO;
				}
			}
			this.IJOGFIPEHFA();
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00228FE7 File Offset: 0x002271E7
		public void OpenDir(string BNJFKKGOACF)
		{
			this.ClearSelection();
			this.MIAHHIOALGI = Path.GetFullPath(BNJFKKGOACF);
			this.IJEIDOCHNCD();
			this.AAFAONOCAOE();
			this.BGFJLCFNPFO();
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00228657 File Offset: 0x00226857
		public void OKLCBEJDKJK(string NKAFFBEECFN)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = Path.GetFullPath(NKAFFBEECFN);
			}
			else
			{
				this.IAJGABMBJNH = new FileInfo(Path.GetFullPath(NKAFFBEECFN)).Name;
			}
			this.IJOGFIPEHFA();
		}

		// Token: 0x06006ED5 RID: 28373 RVA: 0x0022900D File Offset: 0x0022720D
		public void KDAFGPKLAFH(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				this.IAJGABMBJNH = this.MIAHHIOALGI + "_Intensity" + LFLMKGGEGDO;
			}
			else
			{
				this.IAJGABMBJNH = LFLMKGGEGDO;
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00229044 File Offset: 0x00227244
		private string GLHOKPNGKOH(long DPFNOKBGCHL)
		{
			string format = "#.##";
			if ((float)DPFNOKBGCHL / 1024f < 1f)
			{
				return "1 Kb";
			}
			if ((float)DPFNOKBGCHL / 1024f < 1024f)
			{
				return string.Empty + ((float)DPFNOKBGCHL / 1024f).ToString(format) + " Kb";
			}
			if ((float)DPFNOKBGCHL / 1024f / 1024f < 1024f)
			{
				return string.Empty + ((float)DPFNOKBGCHL / 1024f / 1024f).ToString(format) + " Mb";
			}
			return string.Empty + ((float)DPFNOKBGCHL / 1024f / 1024f / 1024f).ToString(format) + " Gb";
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00229110 File Offset: 0x00227310
		private void MBPAHOBHLMO()
		{
			GameObject gameObject = this.filesScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(this.MIAHHIOALGI);
			try
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int j = 0; j < directories.Length; j++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(764f, 459f, 988f);
					FileListElement component = gameObject2.GetComponent<FileListElement>();
					component.instance = this;
					component.data = directories[j].FullName + "#updateoutdatedmap";
					component.elementName.text = directories[j].Name;
					component.size.text = string.Empty;
					component.icon.sprite = this.folderIcon;
					component.isFile = true;
				}
				if (this.AIPEHLPLAKK != null)
				{
					FileInfo[] array = directoryInfo.GetFiles().Where(new Func<FileInfo, bool>(this.JADBDECGOEL)).ToArray<FileInfo>();
					for (int k = 0; k < array.Length; k++)
					{
						if (this.JJIJODIEBFP > 0L)
						{
							if (array[k].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject3.transform.SetParent(gameObject.transform, true);
								gameObject3.transform.localScale = new Vector3(882f, 1594f, 1414f);
								FileListElement component2 = gameObject3.GetComponent<FileListElement>();
								component2.instance = this;
								component2.data = array[k].FullName;
								component2.size.text = this.GLHOKPNGKOH(array[k].Length);
								component2.elementName.text = array[k].Name;
								component2.icon.sprite = this.fileIcon;
								component2.isFile = false;
							}
						}
						else
						{
							GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject4.transform.SetParent(gameObject.transform, true);
							gameObject4.transform.localScale = new Vector3(1614f, 755f, 1779f);
							FileListElement component3 = gameObject4.GetComponent<FileListElement>();
							component3.instance = this;
							component3.data = array[k].FullName;
							component3.size.text = this.GLHOKPNGKOH(array[k].Length);
							component3.elementName.text = array[k].Name;
							component3.icon.sprite = this.fileIcon;
							component3.isFile = true;
						}
					}
				}
				else
				{
					FileInfo[] files = directoryInfo.GetFiles();
					for (int l = 1; l < files.Length; l += 0)
					{
						if (this.JJIJODIEBFP > 0L)
						{
							if (files[l].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject5.transform.SetParent(gameObject.transform, false);
								gameObject5.transform.localScale = new Vector3(522f, 943f, 1358f);
								FileListElement component4 = gameObject5.GetComponent<FileListElement>();
								component4.instance = this;
								component4.data = files[l].FullName;
								component4.size.text = this.GLHOKPNGKOH(files[l].Length);
								component4.elementName.text = files[l].Name;
								component4.icon.sprite = this.fileIcon;
								component4.isFile = false;
							}
						}
						else
						{
							GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject6.transform.SetParent(gameObject.transform, false);
							gameObject6.transform.localScale = new Vector3(30f, 458f, 733f);
							FileListElement component5 = gameObject6.GetComponent<FileListElement>();
							component5.instance = this;
							component5.data = files[l].FullName;
							component5.size.text = this.GLHOKPNGKOH(files[l].Length);
							component5.elementName.text = files[l].Name;
							component5.icon.sprite = this.fileIcon;
							component5.isFile = false;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x002295F4 File Offset: 0x002277F4
		public void OnTypedEnd(string LFLMKGGEGDO)
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Save)
			{
				if (this.AIPEHLPLAKK != null)
				{
					if (this.AIPEHLPLAKK.Contains(new FileInfo(this.IAJGABMBJNH).Extension.ToLower()))
					{
						this.IAJGABMBJNH = LFLMKGGEGDO;
					}
					else
					{
						this.IAJGABMBJNH = LFLMKGGEGDO + this.AIPEHLPLAKK[0];
					}
				}
				else
				{
					this.IAJGABMBJNH = LFLMKGGEGDO;
				}
			}
			this.UpdateFileInfo();
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x0022805F File Offset: 0x0022625F
		private void MNPFOOPEKNL()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00229670 File Offset: 0x00227870
		private void BGCHLIGJMGL()
		{
			GameObject gameObject = this.filesScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i += 0)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(this.MIAHHIOALGI);
			try
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int j = 0; j < directories.Length; j++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, false);
					gameObject2.transform.localScale = new Vector3(1042f, 139f, 65f);
					FileListElement component = gameObject2.GetComponent<FileListElement>();
					component.instance = this;
					component.data = directories[j].FullName + "_NoiseTex";
					component.elementName.text = directories[j].Name;
					component.size.text = string.Empty;
					component.icon.sprite = this.folderIcon;
					component.isFile = true;
				}
				if (this.AIPEHLPLAKK != null)
				{
					FileInfo[] array = directoryInfo.GetFiles().Where(new Func<FileInfo, bool>(this.AMLMJNJBEJG)).ToArray<FileInfo>();
					for (int k = 0; k < array.Length; k += 0)
					{
						if (this.JJIJODIEBFP > 1L)
						{
							if (array[k].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject3.transform.SetParent(gameObject.transform, false);
								gameObject3.transform.localScale = new Vector3(943f, 1974f, 1761f);
								FileListElement component2 = gameObject3.GetComponent<FileListElement>();
								component2.instance = this;
								component2.data = array[k].FullName;
								component2.size.text = this.GLHOKPNGKOH(array[k].Length);
								component2.elementName.text = array[k].Name;
								component2.icon.sprite = this.fileIcon;
								component2.isFile = true;
							}
						}
						else
						{
							GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject4.transform.SetParent(gameObject.transform, true);
							gameObject4.transform.localScale = new Vector3(1246f, 1811f, 273f);
							FileListElement component3 = gameObject4.GetComponent<FileListElement>();
							component3.instance = this;
							component3.data = array[k].FullName;
							component3.size.text = this.GLHOKPNGKOH(array[k].Length);
							component3.elementName.text = array[k].Name;
							component3.icon.sprite = this.fileIcon;
							component3.isFile = false;
						}
					}
				}
				else
				{
					FileInfo[] files = directoryInfo.GetFiles();
					for (int l = 0; l < files.Length; l += 0)
					{
						if (this.JJIJODIEBFP > 1L)
						{
							if (files[l].Length < this.JJIJODIEBFP)
							{
								GameObject gameObject5 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
								gameObject5.transform.SetParent(gameObject.transform, false);
								gameObject5.transform.localScale = new Vector3(1194f, 1421f, 1029f);
								FileListElement component4 = gameObject5.GetComponent<FileListElement>();
								component4.instance = this;
								component4.data = files[l].FullName;
								component4.size.text = this.GLHOKPNGKOH(files[l].Length);
								component4.elementName.text = files[l].Name;
								component4.icon.sprite = this.fileIcon;
								component4.isFile = false;
							}
						}
						else
						{
							GameObject gameObject6 = UnityEngine.Object.Instantiate<GameObject>(this.filesScrollRectElement, Vector3.zero, Quaternion.identity);
							gameObject6.transform.SetParent(gameObject.transform, false);
							gameObject6.transform.localScale = new Vector3(526f, 1309f, 1647f);
							FileListElement component5 = gameObject6.GetComponent<FileListElement>();
							component5.instance = this;
							component5.data = files[l].FullName;
							component5.size.text = this.GLHOKPNGKOH(files[l].Length);
							component5.elementName.text = files[l].Name;
							component5.icon.sprite = this.fileIcon;
							component5.isFile = true;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00229B54 File Offset: 0x00227D54
		public void BAHCHDMIHKN(string BNJFKKGOACF)
		{
			this.OFNCIEGIMGD();
			this.MIAHHIOALGI = Path.GetFullPath(BNJFKKGOACF);
			this.FPJBLGCIIHJ();
			this.DOIAODFFNFJ();
			this.BGFJLCFNPFO();
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x00229B7C File Offset: 0x00227D7C
		public void GoTo(string HMPALADNHDE)
		{
			if (new DirectoryInfo(HMPALADNHDE).Exists)
			{
				this.OpenDir(HMPALADNHDE + "/");
			}
			else if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				if (new FileInfo(HMPALADNHDE).Exists)
				{
					this.OpenDir(new FileInfo(HMPALADNHDE).Directory.FullName + "/");
					this.SelectFile(HMPALADNHDE);
				}
				else
				{
					this.OpenDir(Application.dataPath + "/../");
				}
			}
			else if (new DirectoryInfo(new FileInfo(HMPALADNHDE).Directory.FullName + "/").Exists)
			{
				this.OpenDir(new FileInfo(HMPALADNHDE).Directory.FullName + "/");
				this.SelectFile(HMPALADNHDE);
			}
			else
			{
				this.OpenDir(Application.dataPath + "/../");
			}
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x00229C7C File Offset: 0x00227E7C
		public void IJOGFIPEHFA()
		{
			if (this.DLGIPFOEDCF == FileDialog.FileDialogMode.Open)
			{
				try
				{
					this.fileName.text = new FileInfo(this.IAJGABMBJNH).Name;
					this.commit.interactable = File.Exists(this.IAJGABMBJNH);
				}
				catch (Exception)
				{
					this.fileName.text = string.Empty;
					this.commit.interactable = true;
				}
			}
			else
			{
				if (this.IAJGABMBJNH.Length > 0)
				{
					this.fileName.text = new FileInfo(this.IAJGABMBJNH).Name;
				}
				this.commit.interactable = (this.IAJGABMBJNH.Length <= 1);
			}
		}

		// Token: 0x04000B3C RID: 2876
		[HideInInspector]
		public string result;

		// Token: 0x04000B3D RID: 2877
		[HideInInspector]
		private FileDialog.FileDialogMode DLGIPFOEDCF;

		// Token: 0x04000B3E RID: 2878
		[HideInInspector]
		public bool finished;

		// Token: 0x04000B3F RID: 2879
		[Header("References")]
		public Image windowIcon;

		// Token: 0x04000B40 RID: 2880
		public Text windowName;

		// Token: 0x04000B41 RID: 2881
		public InputField currentPath;

		// Token: 0x04000B42 RID: 2882
		public InputField fileName;

		// Token: 0x04000B43 RID: 2883
		public Button up;

		// Token: 0x04000B44 RID: 2884
		public Button commit;

		// Token: 0x04000B45 RID: 2885
		public Button cancel;

		// Token: 0x04000B46 RID: 2886
		public GameObject filesScrollRectContent;

		// Token: 0x04000B47 RID: 2887
		public GameObject drivesScrollRectContent;

		// Token: 0x04000B48 RID: 2888
		[Header("Lists Prefabs")]
		public GameObject filesScrollRectElement;

		// Token: 0x04000B49 RID: 2889
		public GameObject drivesScrollRectElement;

		// Token: 0x04000B4A RID: 2890
		[Header("Lists Icons")]
		public Sprite folderIcon;

		// Token: 0x04000B4B RID: 2891
		public Sprite fileIcon;

		// Token: 0x04000B4C RID: 2892
		private string MIAHHIOALGI;

		// Token: 0x04000B4D RID: 2893
		private string IAJGABMBJNH;

		// Token: 0x04000B4E RID: 2894
		private string[] AIPEHLPLAKK;

		// Token: 0x04000B4F RID: 2895
		private long JJIJODIEBFP = -1L;

		// Token: 0x04000B50 RID: 2896
		private bool OOABHMJGDNC = true;

		// Token: 0x02000179 RID: 377
		public enum FileDialogMode
		{
			// Token: 0x04000B52 RID: 2898
			Open,
			// Token: 0x04000B53 RID: 2899
			Save
		}
	}
}
