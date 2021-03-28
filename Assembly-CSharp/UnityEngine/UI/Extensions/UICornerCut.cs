using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000288 RID: 648
	[AddComponentMenu("UI/Extensions/Primitives/Cut Corners")]
	public class UICornerCut : UIPrimitiveBase
	{
		// Token: 0x06009C93 RID: 40083 RVA: 0x00391354 File Offset: 0x0038F554
		private static void FLIDFJMCJJP(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KGABFNLGIHA(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.AFLGKFAOFDD(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.BABGJFDLOKO(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FKKNFOLKHCI(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x003913E0 File Offset: 0x0038F5E0
		private static int MBJKHEGLEIE(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009C95 RID: 40085 RVA: 0x00391438 File Offset: 0x0038F638
		private static void IPKDJNCHBGH(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.AFLGKFAOFDD(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.MBJKHEGLEIE(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPAOEDHFEBJ(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C96 RID: 40086 RVA: 0x003914C4 File Offset: 0x0038F6C4
		protected virtual void ENKDIHBFIJF(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 1835f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.CAKAHOPMHHA(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.ALHGOAAMCHA(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.INIGEIOIMLK(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.OFDOLOBLNNH(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.PHELCAEGONM(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.HAMPEFKGKHK(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x003918DC File Offset: 0x0038FADC
		private static int PHNFFPADLOD(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x00391934 File Offset: 0x0038FB34
		private static void PHELCAEGONM(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.ANMIBHBFGAG(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.AFLGKFAOFDD(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KPOKJKDNCPL(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x003919B0 File Offset: 0x0038FBB0
		private static int CHGCHCNOLCI(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x00391A08 File Offset: 0x0038FC08
		private static void ILFAIDABOEC(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPLIMKHPKPN(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.CHGCHCNOLCI(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.LOBAPDNMNNG(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FKKNFOLKHCI(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x00391A84 File Offset: 0x0038FC84
		protected virtual void FJKMPFOFNIM(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 774f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.BMIEJPAJCOP(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.DLJIAJEFDMO(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.OFDOLOBLNNH(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.BMIEJPAJCOP(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HNNFJBIBFID(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.BFLPFMJLIDD(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x00391E9C File Offset: 0x0039009C
		private static int NELLAPCLAEO(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x00391EF4 File Offset: 0x003900F4
		private static void KEBHKLCALCG(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.MBJKHEGLEIE(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.AFLGKFAOFDD(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.KGABFNLGIHA(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.CHGCHCNOLCI(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x00391F80 File Offset: 0x00390180
		private static void IAEJCGHCFBB(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.PHNFFPADLOD(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.ANMIBHBFGAG(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.ANMIBHBFGAG(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009C9F RID: 40095 RVA: 0x00391FFC File Offset: 0x003901FC
		private static void MKOKBFCHGNK(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NFGNDNDLIIF(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.NFGNDNDLIIF(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.ANMIBHBFGAG(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPAOEDHFEBJ(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CA0 RID: 40096 RVA: 0x00392078 File Offset: 0x00390278
		private static void DFIKMEHLNEG(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.PHNFFPADLOD(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.CHGCHCNOLCI(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CA1 RID: 40097 RVA: 0x003920F4 File Offset: 0x003902F4
		private static void HNNFJBIBFID(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.FCJHJMBMOGN(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.FCJHJMBMOGN(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.FCJHJMBMOGN(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FCJHJMBMOGN(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CA2 RID: 40098 RVA: 0x00392180 File Offset: 0x00390380
		private static int FCJHJMBMOGN(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CA3 RID: 40099 RVA: 0x003921D8 File Offset: 0x003903D8
		private static void BMMHDFJGABI(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPLIMKHPKPN(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.KPLJOBPFKFJ(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.NELLAPCLAEO(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.LOBAPDNMNNG(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CA4 RID: 40100 RVA: 0x00392264 File Offset: 0x00390464
		private static int KGABFNLGIHA(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x003922BC File Offset: 0x003904BC
		protected virtual void LGKDHINHPAK(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 287f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.HNNFJBIBFID(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.LOPICPMGGEE(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.CCMCIDJGBFD(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.IMHFHPBDLIM(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HCCJHCGIFHP(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.HCCJHCGIFHP(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x003926D4 File Offset: 0x003908D4
		private static int LOBAPDNMNNG(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0039272C File Offset: 0x0039092C
		private static int BABGJFDLOKO(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x00392784 File Offset: 0x00390984
		protected virtual void HJFGAKFDGEH(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 1353f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.LOPICPMGGEE(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.KEBHKLCALCG(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.FCKKKLJFDHI(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.BMMHDFJGABI(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HCCJHCGIFHP(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.OONJDFJIOMM(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x00392B9C File Offset: 0x00390D9C
		private static void JPMKLIOCBJM(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KGABFNLGIHA(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BABGJFDLOKO(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.LOBAPDNMNNG(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.MBJKHEGLEIE(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x00392C18 File Offset: 0x00390E18
		private static void OONJDFJIOMM(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.LOBAPDNMNNG(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.PHNFFPADLOD(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x00392C94 File Offset: 0x00390E94
		private static void HCCJHCGIFHP(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPAOEDHFEBJ(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BABGJFDLOKO(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.KPOKJKDNCPL(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPLIMKHPKPN(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x00392D10 File Offset: 0x00390F10
		private static void JKIIHIBLJLD(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPLIMKHPKPN(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.KGABFNLGIHA(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.BPAOEDHFEBJ(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.ANMIBHBFGAG(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x00392D9C File Offset: 0x00390F9C
		private static void GHGBHBLPPEF(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KGABFNLGIHA(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.FKKNFOLKHCI(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.NELLAPCLAEO(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPLIMKHPKPN(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x00392E28 File Offset: 0x00391028
		private static void DABNCMDKBDL(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.COGFEHEBBPP(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BABGJFDLOKO(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.BABGJFDLOKO(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.NFGNDNDLIIF(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x00392EA4 File Offset: 0x003910A4
		private static void IMHFHPBDLIM(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.KPLJOBPFKFJ(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.COGFEHEBBPP(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x00392F30 File Offset: 0x00391130
		private static void MADFKLNMDPD(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.MBJKHEGLEIE(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.MBJKHEGLEIE(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.AFLGKFAOFDD(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x00392FAC File Offset: 0x003911AC
		private static void CCMCIDJGBFD(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.FCJHJMBMOGN(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.FKKNFOLKHCI(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.FCJHJMBMOGN(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPLIMKHPKPN(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x00393038 File Offset: 0x00391238
		private static void INIGEIOIMLK(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.MBJKHEGLEIE(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.LOBAPDNMNNG(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPAOEDHFEBJ(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x003930C4 File Offset: 0x003912C4
		protected virtual void IIDGGGPKEPO(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 1988f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.INIGEIOIMLK(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.JKIIHIBLJLD(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.ALHGOAAMCHA(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.OFDOLOBLNNH(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HCCJHCGIFHP(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.MJFLCPICFBC(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CB4 RID: 40116 RVA: 0x003934DC File Offset: 0x003916DC
		private static void DLJIAJEFDMO(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPAOEDHFEBJ(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.ANMIBHBFGAG(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KGABFNLGIHA(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CB5 RID: 40117 RVA: 0x00393568 File Offset: 0x00391768
		protected virtual void PKHOCKPIJBP(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 946f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.INIGEIOIMLK(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.IMHFHPBDLIM(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.ALHGOAAMCHA(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.BMIEJPAJCOP(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HNNFJBIBFID(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.HAMPEFKGKHK(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CB6 RID: 40118 RVA: 0x00393980 File Offset: 0x00391B80
		protected virtual void CHDHLKFBOLN(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 117f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.FCKKKLJFDHI(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.DLJIAJEFDMO(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.DLJIAJEFDMO(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.IPKDJNCHBGH(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.ILFAIDABOEC(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.DABNCMDKBDL(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CB7 RID: 40119 RVA: 0x00393D98 File Offset: 0x00391F98
		protected virtual void DOMHPHECEFE(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 1294f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.INIGEIOIMLK(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.CCMCIDJGBFD(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.IFLDCPECNNN(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.IMHFHPBDLIM(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.JPMKLIOCBJM(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.MJFLCPICFBC(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x06009CB9 RID: 40121 RVA: 0x00394200 File Offset: 0x00392400
		private static int ANMIBHBFGAG(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x00394258 File Offset: 0x00392458
		private static void FMPFABHMEHG(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.ANMIBHBFGAG(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.COGFEHEBBPP(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.PHNFFPADLOD(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FKKNFOLKHCI(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x003942D4 File Offset: 0x003924D4
		private static void IFLDCPECNNN(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.FCJHJMBMOGN(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.COGFEHEBBPP(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.NFGNDNDLIIF(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.CHGCHCNOLCI(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CBC RID: 40124 RVA: 0x00394360 File Offset: 0x00392560
		private static void BFLPFMJLIDD(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPAOEDHFEBJ(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.COGFEHEBBPP(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.MBJKHEGLEIE(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CBD RID: 40125 RVA: 0x003943DC File Offset: 0x003925DC
		private static int AFLGKFAOFDD(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CBE RID: 40126 RVA: 0x00394434 File Offset: 0x00392634
		private static void HAMPEFKGKHK(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KGABFNLGIHA(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.COGFEHEBBPP(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.AFLGKFAOFDD(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CBF RID: 40127 RVA: 0x003944B0 File Offset: 0x003926B0
		private static void LOPICPMGGEE(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KPOKJKDNCPL(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.KPOKJKDNCPL(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.BPAOEDHFEBJ(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.NELLAPCLAEO(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC0 RID: 40128 RVA: 0x0039453C File Offset: 0x0039273C
		private static void BMIEJPAJCOP(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.BPAOEDHFEBJ(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPAOEDHFEBJ(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.NELLAPCLAEO(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KPOKJKDNCPL(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC1 RID: 40129 RVA: 0x003945C8 File Offset: 0x003927C8
		private static int NFGNDNDLIIF(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CC2 RID: 40130 RVA: 0x00394620 File Offset: 0x00392820
		private static int BPAOEDHFEBJ(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CC3 RID: 40131 RVA: 0x00394678 File Offset: 0x00392878
		private static void FCKKKLJFDHI(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.KGABFNLGIHA(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.KPOKJKDNCPL(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.PHNFFPADLOD(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.KPLJOBPFKFJ(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC4 RID: 40132 RVA: 0x00394704 File Offset: 0x00392904
		private static void NDBOHEOADLN(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPAOEDHFEBJ(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.MBJKHEGLEIE(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BPLIMKHPKPN(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC5 RID: 40133 RVA: 0x00394780 File Offset: 0x00392980
		private static int KPOKJKDNCPL(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CC6 RID: 40134 RVA: 0x003947D8 File Offset: 0x003929D8
		private static int COGFEHEBBPP(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CC7 RID: 40135 RVA: 0x00394830 File Offset: 0x00392A30
		private static void MJFLCPICFBC(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.KPLJOBPFKFJ(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.CHGCHCNOLCI(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC8 RID: 40136 RVA: 0x003948AC File Offset: 0x00392AAC
		private static void CAKAHOPMHHA(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.PHNFFPADLOD(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.NFGNDNDLIIF(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.BABGJFDLOKO(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.NFGNDNDLIIF(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CC9 RID: 40137 RVA: 0x00394938 File Offset: 0x00392B38
		private static void HNNFJBIBFID(Rect JEADHPKABMD, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMin, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMin, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMax, JEADHPKABMD.yMax, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.FCJHJMBMOGN(JEADHPKABMD.xMax, JEADHPKABMD.yMin, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CCA RID: 40138 RVA: 0x003949B4 File Offset: 0x00392BB4
		private static int KPLJOBPFKFJ(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CCB RID: 40139 RVA: 0x00394A0C File Offset: 0x00392C0C
		private static void OFDOLOBLNNH(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.MBJKHEGLEIE(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.CHGCHCNOLCI(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.NFGNDNDLIIF(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CCC RID: 40140 RVA: 0x00394A98 File Offset: 0x00392C98
		private static int BPLIMKHPKPN(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 0;
		}

		// Token: 0x06009CCD RID: 40141 RVA: 0x00394AF0 File Offset: 0x00392CF0
		private static void ALHGOAAMCHA(Vector2 LBEGGCHGKDA, Vector2 EEINGFCFEGF, Vector2 MFBONCMHEJF, Vector2 LPGNCFKLMEH, Rect OGJJPGIFDBM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			int num = UICornerCut.NELLAPCLAEO(LBEGGCHGKDA.x, LBEGGCHGKDA.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx = UICornerCut.BPLIMKHPKPN(EEINGFCFEGF.x, EEINGFCFEGF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int num2 = UICornerCut.MBJKHEGLEIE(MFBONCMHEJF.x, MFBONCMHEJF.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			int idx2 = UICornerCut.BABGJFDLOKO(LPGNCFKLMEH.x, LPGNCFKLMEH.y, OGJJPGIFDBM, CNDLPAPKIPH, CBFPMKACAHH);
			CBFPMKACAHH.AddTriangle(num, idx, num2);
			CBFPMKACAHH.AddTriangle(num2, idx2, num);
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x00394B7C File Offset: 0x00392D7C
		private static int FKKNFOLKHCI(float IACGDFHKCAE, float OKAHCMOGDGF, Rect FPFEGCNNDEM, Color32 CNDLPAPKIPH, VertexHelper CBFPMKACAHH)
		{
			Vector2 uv = new Vector2(Mathf.InverseLerp(FPFEGCNNDEM.xMin, FPFEGCNNDEM.xMax, IACGDFHKCAE), Mathf.InverseLerp(FPFEGCNNDEM.yMin, FPFEGCNNDEM.yMax, OKAHCMOGDGF));
			CBFPMKACAHH.AddVert(new Vector3(IACGDFHKCAE, OKAHCMOGDGF), CNDLPAPKIPH, uv);
			return CBFPMKACAHH.currentVertCount - 1;
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x00394BD4 File Offset: 0x00392DD4
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			Rect rect = base.rectTransform.rect;
			Rect rect2 = rect;
			Color32 color = this.color;
			bool flag = this.cutUL | this.cutUR;
			bool flag2 = this.cutLL | this.cutLR;
			bool flag3 = this.cutLL | this.cutUL;
			bool flag4 = this.cutLR | this.cutUR;
			bool flag5 = flag || flag2;
			if (flag5 && this.cornerSize.sqrMagnitude > 0f)
			{
				CBFPMKACAHH.Clear();
				if (flag3)
				{
					rect2.xMin += this.cornerSize.x;
				}
				if (flag2)
				{
					rect2.yMin += this.cornerSize.y;
				}
				if (flag)
				{
					rect2.yMax -= this.cornerSize.y;
				}
				if (flag4)
				{
					rect2.xMax -= this.cornerSize.x;
				}
				if (this.makeColumns)
				{
					Vector2 vector = new Vector2(rect.xMin, (!this.cutUL) ? rect.yMax : rect2.yMax);
					Vector2 vector2 = new Vector2(rect.xMax, (!this.cutUR) ? rect.yMax : rect2.yMax);
					Vector2 vector3 = new Vector2(rect.xMin, (!this.cutLL) ? rect.yMin : rect2.yMin);
					Vector2 vector4 = new Vector2(rect.xMax, (!this.cutLR) ? rect.yMin : rect2.yMin);
					if (flag3)
					{
						UICornerCut.HNNFJBIBFID(vector3, vector, new Vector2(rect2.xMin, rect.yMax), new Vector2(rect2.xMin, rect.yMin), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
					if (flag4)
					{
						UICornerCut.HNNFJBIBFID(vector2, vector4, new Vector2(rect2.xMax, rect.yMin), new Vector2(rect2.xMax, rect.yMax), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
				}
				else
				{
					Vector2 vector = new Vector2((!this.cutUL) ? rect.xMin : rect2.xMin, rect.yMax);
					Vector2 vector2 = new Vector2((!this.cutUR) ? rect.xMax : rect2.xMax, rect.yMax);
					Vector2 vector3 = new Vector2((!this.cutLL) ? rect.xMin : rect2.xMin, rect.yMin);
					Vector2 vector4 = new Vector2((!this.cutLR) ? rect.xMax : rect2.xMax, rect.yMin);
					if (flag2)
					{
						UICornerCut.HNNFJBIBFID(vector4, vector3, new Vector2(rect.xMin, rect2.yMin), new Vector2(rect.xMax, rect2.yMin), rect, (!this.useColorDown) ? color : this.colorDown, CBFPMKACAHH);
					}
					if (flag)
					{
						UICornerCut.HNNFJBIBFID(vector, vector2, new Vector2(rect.xMax, rect2.yMax), new Vector2(rect.xMin, rect2.yMax), rect, (!this.useColorUp) ? color : this.colorUp, CBFPMKACAHH);
					}
				}
				if (this.makeColumns)
				{
					UICornerCut.HNNFJBIBFID(new Rect(rect2.xMin, rect.yMin, rect2.width, rect.height), rect, color, CBFPMKACAHH);
				}
				else
				{
					UICornerCut.HNNFJBIBFID(new Rect(rect.xMin, rect2.yMin, rect.width, rect2.height), rect, color, CBFPMKACAHH);
				}
			}
		}

		// Token: 0x040011D2 RID: 4562
		public Vector2 cornerSize = new Vector2(16f, 16f);

		// Token: 0x040011D3 RID: 4563
		[Header("Corners to cut")]
		public bool cutUL = true;

		// Token: 0x040011D4 RID: 4564
		public bool cutUR;

		// Token: 0x040011D5 RID: 4565
		public bool cutLL;

		// Token: 0x040011D6 RID: 4566
		public bool cutLR;

		// Token: 0x040011D7 RID: 4567
		[Tooltip("Up-Down colors become Left-Right colors")]
		public bool makeColumns;

		// Token: 0x040011D8 RID: 4568
		[Header("Color the cut bars differently")]
		public bool useColorUp;

		// Token: 0x040011D9 RID: 4569
		public Color32 colorUp = Color.blue;

		// Token: 0x040011DA RID: 4570
		public bool useColorDown;

		// Token: 0x040011DB RID: 4571
		public Color32 colorDown = Color.green;
	}
}
