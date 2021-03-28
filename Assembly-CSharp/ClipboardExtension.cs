using System;
using UnityEngine;

// Token: 0x0200040C RID: 1036
public static class ClipboardExtension
{
	// Token: 0x0600ED9A RID: 60826 RVA: 0x00537F98 File Offset: 0x00536198
	public static void CopyToClipboard(this string LEFMNANHGDA)
	{
		TextEditor textEditor = new TextEditor();
		textEditor.text = LEFMNANHGDA;
		textEditor.SelectAll();
		textEditor.Copy();
	}
}
