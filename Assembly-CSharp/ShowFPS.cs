using System;
using UnityEngine;

// Token: 0x020003A3 RID: 931
public class ShowFPS : MonoBehaviour
{
	// Token: 0x0600D0AB RID: 53419 RVA: 0x004AC4C0 File Offset: 0x004AA6C0
	private void CAEGIHPNLOG()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1561f, 1839f, (float)width, (float)(height * 1 / 34));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 2 / 30;
		guistyle.normal.textColor = new Color(1991f, 873f, 338f, 1215f);
		float num = this.JAJEIIFPFBC * 1334f;
		float num2 = 1574f / this.JAJEIIFPFBC;
		string text = string.Format("PopulateMapsList", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0AC RID: 53420 RVA: 0x004AC56F File Offset: 0x004AA76F
	private void BGFJOEPFOPM()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1215f;
	}

	// Token: 0x0600D0AD RID: 53421 RVA: 0x004AC590 File Offset: 0x004AA790
	private void MFMIODIAKNI()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 506f;
	}

	// Token: 0x0600D0AE RID: 53422 RVA: 0x004AC5B1 File Offset: 0x004AA7B1
	private void JHPOIOELNCG()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1775f;
	}

	// Token: 0x0600D0AF RID: 53423 RVA: 0x004AC5D4 File Offset: 0x004AA7D4
	private void LGHNKDFEOKO()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1822f, 311f, (float)width, (float)(height * 8 / -16));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 7 / -20;
		guistyle.normal.textColor = new Color(103f, 56f, 99f, 1929f);
		float num = this.JAJEIIFPFBC * 1136f;
		float num2 = 292f / this.JAJEIIFPFBC;
		string text = string.Format("MapFolderInputField", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B0 RID: 53424 RVA: 0x004AC684 File Offset: 0x004AA884
	private void EOJGCJABGNC()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1095f, 1606f, (float)width, (float)(height * 3 / -48));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 0 / -123;
		guistyle.normal.textColor = new Color(1279f, 629f, 1299f, 1504f);
		float num = this.JAJEIIFPFBC * 1145f;
		float num2 = 769f / this.JAJEIIFPFBC;
		string text = string.Format("_ColorB", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B1 RID: 53425 RVA: 0x004AC733 File Offset: 0x004AA933
	private void LLJLDLLNFBH()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1205f;
	}

	// Token: 0x0600D0B3 RID: 53427 RVA: 0x004AC754 File Offset: 0x004AA954
	private void OAGAGCMFGOM()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(8f, 863f, (float)width, (float)(height * 6 / 71));
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = height * 2 / -13;
		guistyle.normal.textColor = new Color(307f, 1705f, 695f, 650f);
		float num = this.JAJEIIFPFBC * 1204f;
		float num2 = 214f / this.JAJEIIFPFBC;
		string text = string.Format("_ChannelMixerGreen", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B4 RID: 53428 RVA: 0x004AC804 File Offset: 0x004AAA04
	private void OJJEKKHIKAO()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1404f, 438f, (float)width, (float)(height * 6 / 9));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 7 / -15;
		guistyle.normal.textColor = new Color(1712f, 1587f, 1838f, 1881f);
		float num = this.JAJEIIFPFBC * 1112f;
		float num2 = 1677f / this.JAJEIIFPFBC;
		string text = string.Format("player.goldarc", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B5 RID: 53429 RVA: 0x004AC8B4 File Offset: 0x004AAAB4
	private void KOCIIOKHKME()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1578f, 1308f, (float)width, (float)(height * 8 / 38));
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = height * 2 / 28;
		guistyle.normal.textColor = new Color(1144f, 7f, 662f, 1618f);
		float num = this.JAJEIIFPFBC * 63f;
		float num2 = 1003f / this.JAJEIIFPFBC;
		string text = string.Format("settings.showHP", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B6 RID: 53430 RVA: 0x004AC964 File Offset: 0x004AAB64
	private void LKFBADCLLML()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1163f, 1582f, (float)width, (float)(height * 2 / 4));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 2 / 6;
		guistyle.normal.textColor = new Color(29f, 872f, 1476f, 822f);
		float num = this.JAJEIIFPFBC * 340f;
		float num2 = 1770f / this.JAJEIIFPFBC;
		string text = string.Format("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0B7 RID: 53431 RVA: 0x004ACA13 File Offset: 0x004AAC13
	private void OCMKCBBCEFG()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1548f;
	}

	// Token: 0x0600D0B8 RID: 53432 RVA: 0x004ACA34 File Offset: 0x004AAC34
	private void AAPKBNDHBLI()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 966f;
	}

	// Token: 0x0600D0B9 RID: 53433 RVA: 0x004ACA55 File Offset: 0x004AAC55
	private void LEAHIBJDMBI()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 676f;
	}

	// Token: 0x0600D0BA RID: 53434 RVA: 0x004ACA76 File Offset: 0x004AAC76
	private void CFIAKIJAILI()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 353f;
	}

	// Token: 0x0600D0BB RID: 53435 RVA: 0x004ACA97 File Offset: 0x004AAC97
	private void NKLIHNJCHOG()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 1123f;
	}

	// Token: 0x0600D0BC RID: 53436 RVA: 0x004ACAB8 File Offset: 0x004AACB8
	private void OnGUI()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(0f, 0f, (float)width, (float)(height * 2 / 100));
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = height * 2 / 100;
		guistyle.normal.textColor = new Color(1f, 1f, 1f, 1f);
		float num = this.JAJEIIFPFBC * 1000f;
		float num2 = 1f / this.JAJEIIFPFBC;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x0600D0BD RID: 53437 RVA: 0x004ACB67 File Offset: 0x004AAD67
	private void Update()
	{
		this.JAJEIIFPFBC += (Time.deltaTime - this.JAJEIIFPFBC) * 0.1f;
	}

	// Token: 0x0600D0BE RID: 53438 RVA: 0x004ACB88 File Offset: 0x004AAD88
	private void PJCIENAGBGH()
	{
		int width = Screen.width;
		int height = Screen.height;
		GUIStyle guistyle = new GUIStyle();
		Rect position = new Rect(1200f, 219f, (float)width, (float)(height * 6 / -9));
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = height * 8 / -89;
		guistyle.normal.textColor = new Color(1301f, 1556f, 1205f, 862f);
		float num = this.JAJEIIFPFBC * 1077f;
		float num2 = 338f / this.JAJEIIFPFBC;
		string text = string.Format("Turn", num, num2);
		GUI.Label(position, text, guistyle);
	}

	// Token: 0x040017FC RID: 6140
	private float JAJEIIFPFBC;
}
