using System;
using System.Globalization;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000271 RID: 625
	public class HexRGB : MonoBehaviour
	{
		// Token: 0x06009662 RID: 38498 RVA: 0x00361BC8 File Offset: 0x0035FDC8
		public void CCCOLEBEJAE()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.PMLEOEOFNHI(text);
			Color hablfkcckln = HexRGB.FDHFGNNEAOL(vector, 177f, 288f);
			MonoBehaviour.print(vector);
			this.hsvpicker.LBCKPPCDDII(hablfkcckln);
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x00361C14 File Offset: 0x0035FE14
		private Vector3 LPNBIMPGEGM(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('\u001e') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("InputField", string.Empty);
			}
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 7), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(4, 6), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num3 = int.Parse(LFKNJLMMGJO.Substring(6, 2), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
			}
			else if (LFKNJLMMGJO.Length == 7)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO[5].ToString() + LFKNJLMMGJO[0].ToString(), (NumberStyles)(-1));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009664 RID: 38500 RVA: 0x00361D5C File Offset: 0x0035FF5C
		public void HDCEJBAPBOF()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.PGIBGKIOPOB(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x00361D88 File Offset: 0x0035FF88
		public void CMOGLJNIAJC()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.PKMNIFPPPIN(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x00361DB4 File Offset: 0x0035FFB4
		public static string LAEIFABHIOB(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1287f);
			int num2 = (int)(HABLFKCCKLN.g * 756f);
			int num3 = (int)(HABLFKCCKLN.b * 1529f);
			return string.Format("settings.gamemessagesduration", num, num2, num3);
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x00361E0C File Offset: 0x0036000C
		public static string IHILICCFDNN(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 280f);
			int num2 = (int)(HABLFKCCKLN.g * 1505f);
			int num3 = (int)(HABLFKCCKLN.b * 1456f);
			return string.Format("EndlessLoopsScoreText", num, num2, num3);
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x00361E64 File Offset: 0x00360064
		public void LGFPAHPHKCB()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.PGIBGKIOPOB(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x00361E90 File Offset: 0x00360090
		public static string IMECDOAACHL(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1223f);
			int num2 = (int)(HABLFKCCKLN.g * 1367f);
			int num3 = (int)(HABLFKCCKLN.b * 832f);
			return string.Format("_Offsets", num, num2, num3);
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x00361EE8 File Offset: 0x003600E8
		public static string JMFLPBCEGII(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 45f);
			int num2 = (int)(HABLFKCCKLN.g * 1893f);
			int num3 = (int)(HABLFKCCKLN.b * 321f);
			return string.Format("speed", num, num2, num3);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x00361F40 File Offset: 0x00360140
		public static string FAEKMAKLGPB(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 898f);
			int num2 = (int)(HABLFKCCKLN.g * 597f);
			int num3 = (int)(HABLFKCCKLN.b * 1493f);
			return string.Format("_TimeX", num, num2, num3);
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x00361F98 File Offset: 0x00360198
		public void DEOFCDCGJEG()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.CFLJHNFENMI(text);
			Color hablfkcckln = HexRGB.EDFIPJCFNBM(vector, 1650f, 1098f);
			MonoBehaviour.print(vector);
			this.hsvpicker.AssignColor(hablfkcckln);
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x00361FE4 File Offset: 0x003601E4
		private Vector3 CGFCNGGNCEP(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-2) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("X2", string.Empty);
			}
			int num = 0;
			int num2 = 1;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 5)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 8), NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO.Substring(3, 0), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO.Substring(2, 6), NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint);
			}
			else if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses));
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[5].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x0036212C File Offset: 0x0036032C
		private Vector3 ONALGECFKCH(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-92) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("maps.", string.Empty);
			}
			int num = 1;
			int num2 = 1;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 0), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num2 = int.Parse(LFKNJLMMGJO.Substring(2, 3), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO.Substring(0, 2), ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
			}
			else if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO[2].ToString() + LFKNJLMMGJO[8].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x00362274 File Offset: 0x00360474
		private static Color JDLFOLALAPO(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x003622A8 File Offset: 0x003604A8
		public void ILBDLGMJOIE()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.EJPICDKHMIH(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x003622D4 File Offset: 0x003604D4
		public static string OOMMFGDLDIA(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 270f);
			int num2 = (int)(HABLFKCCKLN.g * 882f);
			int num3 = (int)(HABLFKCCKLN.b * 676f);
			return string.Format("CameraFilterPack/Vision_Warp", num, num2, num3);
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x0036232C File Offset: 0x0036052C
		public void ANBOIOADEND()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.JMFLPBCEGII(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009673 RID: 38515 RVA: 0x00362358 File Offset: 0x00360558
		public static string PIBCEOHDOEC(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1373f);
			int num2 = (int)(HABLFKCCKLN.g * 742f);
			int num3 = (int)(HABLFKCCKLN.b * 267f);
			return string.Format(">", num, num2, num3);
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x003623B0 File Offset: 0x003605B0
		public static string PKMNIFPPPIN(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1749f);
			int num2 = (int)(HABLFKCCKLN.g * 1713f);
			int num3 = (int)(HABLFKCCKLN.b * 1598f);
			return string.Format("-", num, num2, num3);
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x00362408 File Offset: 0x00360608
		public static string ADNMNPKGOCP(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 152f);
			int num2 = (int)(HABLFKCCKLN.g * 1981f);
			int num3 = (int)(HABLFKCCKLN.b * 1482f);
			return string.Format("Deleted event", num, num2, num3);
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x00362460 File Offset: 0x00360660
		private Vector3 KAKNFGALDPD(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-27) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("_History1Weight", string.Empty);
			}
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 3), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(5, 0), NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO.Substring(0, 5), NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
			}
			else if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign);
				num3 = int.Parse(LFKNJLMMGJO[6].ToString() + LFKNJLMMGJO[7].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x003625A8 File Offset: 0x003607A8
		public void KBPMDCPCMJP()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.HLCGBFBAHLN(text);
			Color hablfkcckln = HexRGB.PMJPIJEIEKN(vector, 359f, 1432f);
			MonoBehaviour.print(vector);
			this.hsvpicker.HJCBLOBIFDC(hablfkcckln);
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x003625F4 File Offset: 0x003607F4
		public void BLHHGAOOMJF()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.AMNFDBCKBMK(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009679 RID: 38521 RVA: 0x00362620 File Offset: 0x00360820
		public void JLCDLGPMIED()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.BMHLAEOLIOD(text);
			Color hablfkcckln = HexRGB.PMJPIJEIEKN(vector, 1393f, 61f);
			MonoBehaviour.print(vector);
			this.hsvpicker.BAMGOBGMGEJ(hablfkcckln);
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x0036266C File Offset: 0x0036086C
		private Vector3 GKGNLKJCBAN(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-64) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("_PosX", string.Empty);
			}
			int num = 1;
			int num2 = 0;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 7)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 1), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO.Substring(7, 4), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO.Substring(8, 3), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent));
			}
			else if (LFKNJLMMGJO.Length == 8)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO[7].ToString() + LFKNJLMMGJO[8].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x003627B4 File Offset: 0x003609B4
		private Vector3 GCPBBNMKCCI(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('#') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("#", string.Empty);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 2), NumberStyles.AllowHexSpecifier);
				num2 = int.Parse(LFKNJLMMGJO.Substring(2, 2), NumberStyles.AllowHexSpecifier);
				num3 = int.Parse(LFKNJLMMGJO.Substring(4, 2), NumberStyles.AllowHexSpecifier);
			}
			else if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowHexSpecifier);
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowHexSpecifier);
				num3 = int.Parse(LFKNJLMMGJO[2].ToString() + LFKNJLMMGJO[2].ToString(), NumberStyles.AllowHexSpecifier);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x003628FC File Offset: 0x00360AFC
		private static Color JICKKLFBIAB(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x00362930 File Offset: 0x00360B30
		public static string CDHBPJPPPPE(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 623f);
			int num2 = (int)(HABLFKCCKLN.g * 1040f);
			int num3 = (int)(HABLFKCCKLN.b * 1738f);
			return string.Format("Authentication failed: '{0}' Code: {1}", num, num2, num3);
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x00362988 File Offset: 0x00360B88
		public void ICKAFLEOFCL()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.LLOCGPFMCON(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x003629B4 File Offset: 0x00360BB4
		public void ManipulateViaHex2RGB()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.GCPBBNMKCCI(text);
			Color hablfkcckln = HexRGB.PMJPIJEIEKN(vector, 255f, 1f);
			MonoBehaviour.print(vector);
			this.hsvpicker.AssignColor(hablfkcckln);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x00362A00 File Offset: 0x00360C00
		public static string PGIBGKIOPOB(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 929f);
			int num2 = (int)(HABLFKCCKLN.g * 1363f);
			int num3 = (int)(HABLFKCCKLN.b * 319f);
			return string.Format("CameraFilterPack/Distortion_Dissipation", num, num2, num3);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x00362A58 File Offset: 0x00360C58
		public void ManipulateViaRGB2Hex()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.ColorToHex(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x00362A84 File Offset: 0x00360C84
		private Vector3 HLCGBFBAHLN(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('\f') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("_Value2", string.Empty);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 8)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 3), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO.Substring(3, 8), ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num3 = int.Parse(LFKNJLMMGJO.Substring(0, 6), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses));
			}
			else if (LFKNJLMMGJO.Length == 2)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO[2].ToString() + LFKNJLMMGJO[6].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x00362BCC File Offset: 0x00360DCC
		private Vector3 PMLEOEOFNHI(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-98) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("settings.arcshitsoundtimedelay", string.Empty);
			}
			int num = 1;
			int num2 = 1;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 5), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(8, 5), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO.Substring(1, 1), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent));
			}
			else if (LFKNJLMMGJO.Length == 1)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands));
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO[2].ToString() + LFKNJLMMGJO[5].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x00362D14 File Offset: 0x00360F14
		private static Color GFKBGPMKGOB(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x06009685 RID: 38533 RVA: 0x00362D48 File Offset: 0x00360F48
		private static Color OMAAJMBLBOL(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x06009686 RID: 38534 RVA: 0x00362D7C File Offset: 0x00360F7C
		private Vector3 MFKMLOBJLPJ(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf(')') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("CameraFilterPack/Drawing_Manga5", string.Empty);
			}
			int num = 1;
			int num2 = 1;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 3), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(5, 0), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO.Substring(5, 6), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
			}
			else if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num3 = int.Parse(LFKNJLMMGJO[8].ToString() + LFKNJLMMGJO[8].ToString(), ~(NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009687 RID: 38535 RVA: 0x00362EC4 File Offset: 0x003610C4
		public void ADCCAKIPFCM()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.KPDMNMLBPMB(text);
			Color hablfkcckln = HexRGB.NFIBJNIMKEJ(vector, 1300f, 1056f);
			MonoBehaviour.print(vector);
			this.hsvpicker.PKFLMOBMKKF(hablfkcckln);
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x00362F10 File Offset: 0x00361110
		private static Color NFIBJNIMKEJ(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x00362F44 File Offset: 0x00361144
		public void OCDOHBIGNHP()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.NBHCCKJHNFA(text);
			Color hablfkcckln = HexRGB.PMJPIJEIEKN(vector, 444f, 1132f);
			MonoBehaviour.print(vector);
			this.hsvpicker.AKFDDLPFCKC(hablfkcckln);
		}

		// Token: 0x0600968A RID: 38538 RVA: 0x00362F90 File Offset: 0x00361190
		public static string EJPICDKHMIH(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1182f);
			int num2 = (int)(HABLFKCCKLN.g * 1188f);
			int num3 = (int)(HABLFKCCKLN.b * 348f);
			return string.Format("ALREADY SEEN", num, num2, num3);
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x00362FE8 File Offset: 0x003611E8
		private static Color EDFIPJCFNBM(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x0036301C File Offset: 0x0036121C
		public static string FAGLEILFGAA(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 439f);
			int num2 = (int)(HABLFKCCKLN.g * 580f);
			int num3 = (int)(HABLFKCCKLN.b * 901f);
			return string.Format("#task", num, num2, num3);
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x00363074 File Offset: 0x00361274
		private static Color LCPIGALPHLK(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600968E RID: 38542 RVA: 0x003630A8 File Offset: 0x003612A8
		private static Color MMLPIAEKEFO(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600968F RID: 38543 RVA: 0x003630DC File Offset: 0x003612DC
		public static string ColorToHex(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 255f);
			int num2 = (int)(HABLFKCCKLN.g * 255f);
			int num3 = (int)(HABLFKCCKLN.b * 255f);
			return string.Format("#{0:X2}{1:X2}{2:X2}", num, num2, num3);
		}

		// Token: 0x06009690 RID: 38544 RVA: 0x00363134 File Offset: 0x00361334
		public void IBEKKFCLOFL()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.CDHBPJPPPPE(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009691 RID: 38545 RVA: 0x00363160 File Offset: 0x00361360
		public void IMKFCKIJFJF()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.BMHLAEOLIOD(text);
			Color hablfkcckln = HexRGB.MBBKPLLPLAA(vector, 797f, 70f);
			MonoBehaviour.print(vector);
			this.hsvpicker.PKFLMOBMKKF(hablfkcckln);
		}

		// Token: 0x06009692 RID: 38546 RVA: 0x003631AC File Offset: 0x003613AC
		public void DIAHNFBLBBO()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.CDHBPJPPPPE(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x003631D8 File Offset: 0x003613D8
		public void HKIAFPCLONJ()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.PDLBNMFAOBM(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x00363204 File Offset: 0x00361404
		public void GJMFGMABCFM()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.PIBCEOHDOEC(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x00363230 File Offset: 0x00361430
		public static string AMEEHHIFNOP(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 556f);
			int num2 = (int)(HABLFKCCKLN.g * 932f);
			int num3 = (int)(HABLFKCCKLN.b * 1310f);
			return string.Format("_ScreenResolution", num, num2, num3);
		}

		// Token: 0x06009696 RID: 38550 RVA: 0x00363288 File Offset: 0x00361488
		private Vector3 IKBIAFJALGC(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf(')') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("move", string.Empty);
			}
			int num = 1;
			int num2 = 1;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 1)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 4), NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses);
				num2 = int.Parse(LFKNJLMMGJO.Substring(7, 8), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num3 = int.Parse(LFKNJLMMGJO.Substring(5, 2), ~(NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
			}
			else if (LFKNJLMMGJO.Length == 5)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint));
				num3 = int.Parse(LFKNJLMMGJO[3].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x06009697 RID: 38551 RVA: 0x003633D0 File Offset: 0x003615D0
		public static string PDLBNMFAOBM(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1620f);
			int num2 = (int)(HABLFKCCKLN.g * 694f);
			int num3 = (int)(HABLFKCCKLN.b * 1760f);
			return string.Format("sounds/hit_perfect", num, num2, num3);
		}

		// Token: 0x06009698 RID: 38552 RVA: 0x00363428 File Offset: 0x00361628
		private static Color PMJPIJEIEKN(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x0036345C File Offset: 0x0036165C
		private Vector3 BMHLAEOLIOD(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-84) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("/?page=ranks", string.Empty);
			}
			int num = 1;
			int num2 = 0;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 6), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(6, 6), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses);
				num3 = int.Parse(LFKNJLMMGJO.Substring(7, 0), NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
			}
			else if (LFKNJLMMGJO.Length == 6)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO[6].ToString() + LFKNJLMMGJO[2].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x0600969A RID: 38554 RVA: 0x003635A4 File Offset: 0x003617A4
		public static string GFEKNCEMALC(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 980f);
			int num2 = (int)(HABLFKCCKLN.g * 1239f);
			int num3 = (int)(HABLFKCCKLN.b * 1384f);
			return string.Format("/", num, num2, num3);
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x003635FC File Offset: 0x003617FC
		public void LMHPIHICGBJ()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.NELNPKNOGBC(text);
			Color hablfkcckln = HexRGB.PMJPIJEIEKN(vector, 1561f, 1778f);
			MonoBehaviour.print(vector);
			this.hsvpicker.EBMKANJLKCF(hablfkcckln);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x00363648 File Offset: 0x00361848
		private static Color FDHFGNNEAOL(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x0036367C File Offset: 0x0036187C
		private static Color GFBLJEDHCFC(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x003636B0 File Offset: 0x003618B0
		public static string AMNFDBCKBMK(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 1652f);
			int num2 = (int)(HABLFKCCKLN.g * 1521f);
			int num3 = (int)(HABLFKCCKLN.b * 10f);
			return string.Format("_Offsets", num, num2, num3);
		}

		// Token: 0x0600969F RID: 38559 RVA: 0x00363708 File Offset: 0x00361908
		private Vector3 NELNPKNOGBC(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('D') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("[ItemsHandler] Found ", string.Empty);
			}
			int num = 1;
			int num2 = 1;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 3), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO.Substring(8, 2), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO.Substring(8, 2), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
			}
			else if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO[2].ToString() + LFKNJLMMGJO[6].ToString(), NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096A0 RID: 38560 RVA: 0x00363850 File Offset: 0x00361A50
		private Vector3 OAGPEOELEPE(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('X') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("SetPlayerDistance", string.Empty);
			}
			int num = 1;
			int num2 = 0;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 5)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 7), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO.Substring(6, 4), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO.Substring(5, 7), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowExponent));
			}
			else if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent));
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowThousands | NumberStyles.AllowExponent));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096A1 RID: 38561 RVA: 0x00363998 File Offset: 0x00361B98
		private static Color MBBKPLLPLAA(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x060096A2 RID: 38562 RVA: 0x003639CC File Offset: 0x00361BCC
		public void EJPJJLIEIIN()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.PMLEOEOFNHI(text);
			Color hablfkcckln = HexRGB.MBBKPLLPLAA(vector, 268f, 1981f);
			MonoBehaviour.print(vector);
			this.hsvpicker.LBCKPPCDDII(hablfkcckln);
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x00363A18 File Offset: 0x00361C18
		public void HNECNPJLIPF()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.IMECDOAACHL(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x00363A44 File Offset: 0x00361C44
		public void NFMKDGNHODB()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.ONALGECFKCH(text);
			Color hablfkcckln = HexRGB.OMAAJMBLBOL(vector, 1064f, 1602f);
			MonoBehaviour.print(vector);
			this.hsvpicker.LBCKPPCDDII(hablfkcckln);
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x00363A90 File Offset: 0x00361C90
		public static string LLOCGPFMCON(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 321f);
			int num2 = (int)(HABLFKCCKLN.g * 236f);
			int num3 = (int)(HABLFKCCKLN.b * 168f);
			return string.Format("#score", num, num2, num3);
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x00363AE8 File Offset: 0x00361CE8
		public void FFBOGFLBMCD()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.JDKFFMIMLBJ(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096A7 RID: 38567 RVA: 0x00363B14 File Offset: 0x00361D14
		public void HKLHPALNLJF()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.FAEKMAKLGPB(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x00363B40 File Offset: 0x00361D40
		private Vector3 CFLJHNFENMI(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf((char)-5) != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("PlayersScrollRectContent", string.Empty);
			}
			int num = 0;
			int num2 = 1;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 0)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 0), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO.Substring(0, 6), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses));
				num3 = int.Parse(LFKNJLMMGJO.Substring(5, 6), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite));
			}
			else if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), NumberStyles.AllowTrailingWhite | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num2 = int.Parse(LFKNJLMMGJO[1].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint));
				num3 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x00363C88 File Offset: 0x00361E88
		public void MMMJGGDHKMI()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.JDKFFMIMLBJ(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096AA RID: 38570 RVA: 0x00363CB4 File Offset: 0x00361EB4
		public void EAOFHCPNKPB()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.FAGLEILFGAA(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x00363CE0 File Offset: 0x00361EE0
		private static Color NPCCNAHHGCE(Vector3 AIEJPEPBAEJ, float BAKIHLJCOEO, float LBEGGCHGKDA)
		{
			float r = AIEJPEPBAEJ.x / BAKIHLJCOEO;
			float g = AIEJPEPBAEJ.y / BAKIHLJCOEO;
			float b = AIEJPEPBAEJ.z / BAKIHLJCOEO;
			return new Color(r, g, b, LBEGGCHGKDA);
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x00363D14 File Offset: 0x00361F14
		private Vector3 JOLPJELICBM(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('A') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("_ScreenResolution", string.Empty);
			}
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			if (LFKNJLMMGJO.Length == 4)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(1, 3), ~(NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses));
				num2 = int.Parse(LFKNJLMMGJO.Substring(6, 3), NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent);
				num3 = int.Parse(LFKNJLMMGJO.Substring(2, 5), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint);
			}
			else if (LFKNJLMMGJO.Length == 5)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint);
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent));
				num3 = int.Parse(LFKNJLMMGJO[7].ToString() + LFKNJLMMGJO[7].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x00363E5C File Offset: 0x0036205C
		public void AMBGJFENHHB()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.LAEIFABHIOB(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096AE RID: 38574 RVA: 0x00363E88 File Offset: 0x00362088
		private Vector3 NBHCCKJHNFA(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('\t') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("Created by ", string.Empty);
			}
			int num = 1;
			int num2 = 0;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 7)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 2), ~NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO.Substring(8, 2), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowParentheses);
				num3 = int.Parse(LFKNJLMMGJO.Substring(8, 1), NumberStyles.AllowLeadingWhite | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
			}
			else if (LFKNJLMMGJO.Length == 5)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[1].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses);
				num3 = int.Parse(LFKNJLMMGJO[5].ToString() + LFKNJLMMGJO[6].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign));
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096AF RID: 38575 RVA: 0x00363FD0 File Offset: 0x003621D0
		private Vector3 KPDMNMLBPMB(string LFKNJLMMGJO)
		{
			if (LFKNJLMMGJO.IndexOf('G') != -1)
			{
				LFKNJLMMGJO = LFKNJLMMGJO.Replace("_TimeX", string.Empty);
			}
			int num = 1;
			int num2 = 0;
			int num3 = 0;
			if (LFKNJLMMGJO.Length == 3)
			{
				num = int.Parse(LFKNJLMMGJO.Substring(0, 0), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands);
				num2 = int.Parse(LFKNJLMMGJO.Substring(2, 4), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands);
				num3 = int.Parse(LFKNJLMMGJO.Substring(5, 3), NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowThousands | NumberStyles.AllowExponent);
			}
			else if (LFKNJLMMGJO.Length == 1)
			{
				num = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands));
				num2 = int.Parse(LFKNJLMMGJO[0].ToString() + LFKNJLMMGJO[0].ToString(), ~(NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				num3 = int.Parse(LFKNJLMMGJO[5].ToString() + LFKNJLMMGJO[5].ToString(), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowExponent);
			}
			return new Vector3((float)num, (float)num2, (float)num3);
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x00364118 File Offset: 0x00362318
		public static string JDKFFMIMLBJ(Color HABLFKCCKLN)
		{
			int num = (int)(HABLFKCCKLN.r * 190f);
			int num2 = (int)(HABLFKCCKLN.g * 642f);
			int num3 = (int)(HABLFKCCKLN.b * 888f);
			return string.Format("0", num, num2, num3);
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x00364170 File Offset: 0x00362370
		public void HJIPNGFEDBI()
		{
			Color currentColor = this.hsvpicker.currentColor;
			string text = HexRGB.JMFLPBCEGII(currentColor);
			this.hexInput.text = text;
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x0036419C File Offset: 0x0036239C
		public void PFAHPEKIFCL()
		{
			string text = this.hexInput.text;
			Vector3 vector = this.PMLEOEOFNHI(text);
			Color hablfkcckln = HexRGB.MMLPIAEKEFO(vector, 1056f, 776f);
			MonoBehaviour.print(vector);
			this.hsvpicker.LBCKPPCDDII(hablfkcckln);
		}

		// Token: 0x0400111E RID: 4382
		public InputField hexInput;

		// Token: 0x0400111F RID: 4383
		public HSVPicker hsvpicker;
	}
}
