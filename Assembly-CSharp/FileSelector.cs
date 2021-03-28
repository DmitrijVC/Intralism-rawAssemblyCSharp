using System;
using System.Collections;
using System.IO;
using OxOD;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000172 RID: 370
public class FileSelector : MonoBehaviour
{
	// Token: 0x06006D06 RID: 27910 RVA: 0x00221EE4 File Offset: 0x002200E4
	public void GBCGFMJGEBI()
	{
		base.StartCoroutine(this.MINHCHHPLAB(this.result));
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x00221EFC File Offset: 0x002200FC
	public IEnumerator LLFLGFKAKBP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x00221F20 File Offset: 0x00220120
	public IEnumerator NJPKLKNKAGG(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D09 RID: 27913 RVA: 0x00221F42 File Offset: 0x00220142
	public void KHAECNKOKIB()
	{
		base.StartCoroutine(this.MEBEKMMKFOO(this.result));
	}

	// Token: 0x06006D0A RID: 27914 RVA: 0x00221F57 File Offset: 0x00220157
	public void AEEABNAHHKJ()
	{
		base.StartCoroutine(this.LEPEOHFJJDM(this.result));
	}

	// Token: 0x06006D0B RID: 27915 RVA: 0x00221F6C File Offset: 0x0022016C
	public void PAFNGGDJCEJ()
	{
		base.StartCoroutine(this.PPFJBPAAEON(this.result));
	}

	// Token: 0x06006D0C RID: 27916 RVA: 0x00221F84 File Offset: 0x00220184
	public IEnumerator PPFJBPAAEON(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D0D RID: 27917 RVA: 0x00221FA6 File Offset: 0x002201A6
	public void DNHNFGJEINP()
	{
		base.StartCoroutine(this.INDAPPMHOCJ(this.result));
	}

	// Token: 0x06006D0E RID: 27918 RVA: 0x00221FBB File Offset: 0x002201BB
	public void IAIAJNEHGPJ()
	{
		base.StartCoroutine(this.GEJKLOJNDFD(this.result));
	}

	// Token: 0x06006D0F RID: 27919 RVA: 0x00221FD0 File Offset: 0x002201D0
	public void GFFICCJNHMA()
	{
		base.StartCoroutine(this.ECCJPEGIBNM(this.result));
	}

	// Token: 0x06006D10 RID: 27920 RVA: 0x00221FE5 File Offset: 0x002201E5
	public void HEMNBIHCDAC()
	{
		base.StartCoroutine(this.DGPLLJKGIMP(this.result));
	}

	// Token: 0x06006D12 RID: 27922 RVA: 0x00221EE4 File Offset: 0x002200E4
	public void FKIAAOEIDKP()
	{
		base.StartCoroutine(this.MINHCHHPLAB(this.result));
	}

	// Token: 0x06006D13 RID: 27923 RVA: 0x00222010 File Offset: 0x00220210
	public IEnumerator NDHAPEKJGLE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D14 RID: 27924 RVA: 0x00222034 File Offset: 0x00220234
	public IEnumerator ECCJPEGIBNM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D15 RID: 27925 RVA: 0x00221FE5 File Offset: 0x002201E5
	public void DOHPDBNDGEK()
	{
		base.StartCoroutine(this.DGPLLJKGIMP(this.result));
	}

	// Token: 0x06006D16 RID: 27926 RVA: 0x00222058 File Offset: 0x00220258
	public IEnumerator EMKJEINLLJD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D17 RID: 27927 RVA: 0x0022207C File Offset: 0x0022027C
	public IEnumerator GEJKLOJNDFD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D18 RID: 27928 RVA: 0x0022209E File Offset: 0x0022029E
	public void KIPKADHBLLK()
	{
		base.StartCoroutine(this.BOBMDOJALEC(this.result));
	}

	// Token: 0x06006D19 RID: 27929 RVA: 0x002220B4 File Offset: 0x002202B4
	public IEnumerator BOBMDOJALEC(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D1A RID: 27930 RVA: 0x002220D8 File Offset: 0x002202D8
	public IEnumerator JODDNKKOFKL(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D1B RID: 27931 RVA: 0x002220FC File Offset: 0x002202FC
	public IEnumerator HNJPPHHBPNI(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D1C RID: 27932 RVA: 0x0022211E File Offset: 0x0022031E
	public void HFEAFEANNBA()
	{
		base.StartCoroutine(this.HMCBBLKONGK(this.result));
	}

	// Token: 0x06006D1D RID: 27933 RVA: 0x00222133 File Offset: 0x00220333
	public void AFFKPKAALCF()
	{
		base.StartCoroutine(this.NCCJLJFFDIN(this.result));
	}

	// Token: 0x06006D1E RID: 27934 RVA: 0x00222148 File Offset: 0x00220348
	public IEnumerator FCPPLPPLKIP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D1F RID: 27935 RVA: 0x00222133 File Offset: 0x00220333
	public void KEIGJBNBALG()
	{
		base.StartCoroutine(this.NCCJLJFFDIN(this.result));
	}

	// Token: 0x06006D20 RID: 27936 RVA: 0x0022216C File Offset: 0x0022036C
	public IEnumerator HMCBBLKONGK(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D21 RID: 27937 RVA: 0x00222190 File Offset: 0x00220390
	public IEnumerator CINOPGELIBO(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D22 RID: 27938 RVA: 0x002221B4 File Offset: 0x002203B4
	public IEnumerator MINHCHHPLAB(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D23 RID: 27939 RVA: 0x002221D8 File Offset: 0x002203D8
	public IEnumerator LOFELHNPENM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D24 RID: 27940 RVA: 0x002221FC File Offset: 0x002203FC
	public IEnumerator GNKLLIABLOP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D25 RID: 27941 RVA: 0x0022221E File Offset: 0x0022041E
	public void NCICCMIOIEA()
	{
		base.StartCoroutine(this.NJPKLKNKAGG(this.result));
	}

	// Token: 0x06006D26 RID: 27942 RVA: 0x00222233 File Offset: 0x00220433
	public void ADKHCIMAGDM()
	{
		base.StartCoroutine(this.JODDNKKOFKL(this.result));
	}

	// Token: 0x06006D27 RID: 27943 RVA: 0x00222248 File Offset: 0x00220448
	public IEnumerator MEBEKMMKFOO(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D28 RID: 27944 RVA: 0x0022226C File Offset: 0x0022046C
	public IEnumerator NCCJLJFFDIN(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D29 RID: 27945 RVA: 0x00221FA6 File Offset: 0x002201A6
	public void GINBADBDBHK()
	{
		base.StartCoroutine(this.INDAPPMHOCJ(this.result));
	}

	// Token: 0x06006D2A RID: 27946 RVA: 0x00221F42 File Offset: 0x00220142
	public void KFCOMPNAOFC()
	{
		base.StartCoroutine(this.MEBEKMMKFOO(this.result));
	}

	// Token: 0x06006D2B RID: 27947 RVA: 0x00222290 File Offset: 0x00220490
	public IEnumerator FMGHJKGBCPD(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D2C RID: 27948 RVA: 0x002222B4 File Offset: 0x002204B4
	public IEnumerator INDAPPMHOCJ(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D2D RID: 27949 RVA: 0x002222D6 File Offset: 0x002204D6
	public void EBGANBHIODB()
	{
		base.StartCoroutine(this.Select(this.result));
	}

	// Token: 0x06006D2E RID: 27950 RVA: 0x002222EB File Offset: 0x002204EB
	public void FHNENEALHBB()
	{
		base.StartCoroutine(this.HNJPPHHBPNI(this.result));
	}

	// Token: 0x06006D2F RID: 27951 RVA: 0x00222300 File Offset: 0x00220500
	public void FHJPHAHBALC()
	{
		base.StartCoroutine(this.MCDNOKAMKDE(this.result));
	}

	// Token: 0x06006D30 RID: 27952 RVA: 0x00222318 File Offset: 0x00220518
	public IEnumerator OFGHPPOPIFA(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D31 RID: 27953 RVA: 0x0022233A File Offset: 0x0022053A
	public void KAFFNJNFAEC()
	{
		base.StartCoroutine(this.GNKLLIABLOP(this.result));
	}

	// Token: 0x06006D32 RID: 27954 RVA: 0x00222350 File Offset: 0x00220550
	public IEnumerator HOFNMDNHFPM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D33 RID: 27955 RVA: 0x00222374 File Offset: 0x00220574
	public IEnumerator LEPEOHFJJDM(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D34 RID: 27956 RVA: 0x00222398 File Offset: 0x00220598
	public IEnumerator MCDNOKAMKDE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D35 RID: 27957 RVA: 0x002223BC File Offset: 0x002205BC
	public IEnumerator DGPLLJKGIMP(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D36 RID: 27958 RVA: 0x0022211E File Offset: 0x0022031E
	public void IPLAJIODIKM()
	{
		base.StartCoroutine(this.HMCBBLKONGK(this.result));
	}

	// Token: 0x06006D37 RID: 27959 RVA: 0x002222D6 File Offset: 0x002204D6
	public void SelectFile()
	{
		base.StartCoroutine(this.Select(this.result));
	}

	// Token: 0x06006D38 RID: 27960 RVA: 0x002223E0 File Offset: 0x002205E0
	public IEnumerator EABEPBGOBNE(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D39 RID: 27961 RVA: 0x002222EB File Offset: 0x002204EB
	public void JKOEJIELDOJ()
	{
		base.StartCoroutine(this.HNJPPHHBPNI(this.result));
	}

	// Token: 0x06006D3A RID: 27962 RVA: 0x00222404 File Offset: 0x00220604
	public IEnumerator Select(string BNJFKKGOACF)
	{
		Debug.Log("[FileSelector] Starting file dialog");
		if (this.mode == FileDialog.FileDialogMode.Open)
		{
			yield return base.StartCoroutine(this.dialog.Open(BNJFKKGOACF, this.extensions, "OPEN FILE", null, (long)this.maxSize, this.saveLastPath));
		}
		else
		{
			yield return base.StartCoroutine(this.dialog.Save(BNJFKKGOACF, this.extensions, "SAVE FILE", null, this.saveLastPath));
		}
		if (this.dialog.result != null)
		{
			Debug.Log("[FileSelector] Dialog ended, result: " + this.dialog.result);
			this.result = this.dialog.result;
			this.selectedFile.text = new FileInfo(this.dialog.result).Name;
			this.OnFileSelected.Invoke();
			this.OnFileSelectedString.Invoke(this.dialog.result);
		}
		else
		{
			Debug.Log("[FileSelector] Dialog canceled");
		}
		yield break;
	}

	// Token: 0x06006D3B RID: 27963 RVA: 0x00222233 File Offset: 0x00220433
	public void CMIMCKDJHBH()
	{
		base.StartCoroutine(this.JODDNKKOFKL(this.result));
	}

	// Token: 0x06006D3C RID: 27964 RVA: 0x00222133 File Offset: 0x00220333
	public void CJCIJJOBIIK()
	{
		base.StartCoroutine(this.NCCJLJFFDIN(this.result));
	}

	// Token: 0x04000B22 RID: 2850
	[Header("OxOD Reference")]
	public FileDialog dialog;

	// Token: 0x04000B23 RID: 2851
	[Header("File Dialog Options")]
	public FileDialog.FileDialogMode mode;

	// Token: 0x04000B24 RID: 2852
	public string extensions;

	// Token: 0x04000B25 RID: 2853
	public int maxSize = -1;

	// Token: 0x04000B26 RID: 2854
	public bool saveLastPath = true;

	// Token: 0x04000B27 RID: 2855
	[Header("Events")]
	public UnityEvent OnFileSelected;

	// Token: 0x04000B28 RID: 2856
	public FileSelector.StringEvent OnFileSelectedString;

	// Token: 0x04000B29 RID: 2857
	[Header("Internal References")]
	public InputField selectedFile;

	// Token: 0x04000B2A RID: 2858
	[HideInInspector]
	public string result;

	// Token: 0x02000173 RID: 371
	[Serializable]
	public class StringEvent : UnityEvent<string>
	{
	}
}
