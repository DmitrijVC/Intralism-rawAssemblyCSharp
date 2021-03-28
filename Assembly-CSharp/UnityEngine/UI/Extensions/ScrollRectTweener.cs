using System;
using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002BC RID: 700
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("UI/Extensions/ScrollRectTweener")]
	public class ScrollRectTweener : MonoBehaviour, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600A78B RID: 42891 RVA: 0x003E3085 File Offset: 0x003E1285
		private void HIDKKOPMLLN()
		{
			this.GIGHNDOLPBN.horizontal = this.BKDMFGCFOAJ;
			this.GIGHNDOLPBN.vertical = this.HLBMCMOBJBE;
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x003E30A9 File Offset: 0x003E12A9
		public void PCEOILFIIAF(Vector2 CJOBMALLBEC)
		{
			this.JKBLJBOFMNI(CJOBMALLBEC, this.PLDLLFGIJIB(CJOBMALLBEC));
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 NDFBDLHMFJN()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x003E30D8 File Offset: 0x003E12D8
		private float KFELCGOLOPO(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.FNKHCMPLDDH();
			return Vector2.Distance(this.NGOBDDNCGEH(cjobmallbec), this.NGOBDDNCGEH(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x003E3108 File Offset: 0x003E1308
		private float JLPHNDFMCLF(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.BJAJHAGBBFN();
			return Vector2.Distance(this.KHJMHBENIPD(cjobmallbec), this.JDDMHHBMAAJ(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x003E3136 File Offset: 0x003E1336
		public void EGFNFFPBIMD(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.BGPAEJKBEIG();
			}
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x003E3085 File Offset: 0x003E1285
		private void NKAMECPKMFD()
		{
			this.GIGHNDOLPBN.horizontal = this.BKDMFGCFOAJ;
			this.GIGHNDOLPBN.vertical = this.HLBMCMOBJBE;
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x003E3149 File Offset: 0x003E1349
		private void NMGNDPFPOJN()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = false;
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x003E3163 File Offset: 0x003E1363
		public void CCBOFFHAOLL(float APEKBGJHBPJ, float HNIFGMOMJMA)
		{
			this.KPBELHNNHGL(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition), HNIFGMOMJMA);
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x003E317D File Offset: 0x003E137D
		public void EGBPCIEEPPN(float APEKBGJHBPJ)
		{
			this.EEPMPOMBLDC(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition));
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x003E3196 File Offset: 0x003E1396
		public void EEOLDBIBAPM(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.PIMLCOAIHNG();
			}
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x003E31A9 File Offset: 0x003E13A9
		public void GNEJIFIAMFL(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.CKBLKIPOGLI();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.NMGNDPFPOJN();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.EEKGLJCOMDN(HNIFGMOMJMA));
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x003E31E3 File Offset: 0x003E13E3
		public void AIDHIEDCKGD(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.MPJPENLCIMG(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x003E3200 File Offset: 0x003E1400
		private Vector2 NGOBDDNCGEH(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x003E3252 File Offset: 0x003E1452
		public void ScrollVertical(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.Scroll(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x003E326C File Offset: 0x003E146C
		private float OPFGBMPPNGF(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.IKMIOKHMKOA();
			return Vector2.Distance(this.KHJMHBENIPD(cjobmallbec), this.NGOBDDNCGEH(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x003E329A File Offset: 0x003E149A
		private void MFCCNPEIOGP()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			this.BKDMFGCFOAJ = this.GIGHNDOLPBN.horizontal;
			this.HLBMCMOBJBE = this.GIGHNDOLPBN.vertical;
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x003E32CC File Offset: 0x003E14CC
		private float MABODMMBCPD(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.BJAJHAGBBFN();
			return Vector2.Distance(this.KHJMHBENIPD(cjobmallbec), this.AGNEJEPHBDP(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x003E32FC File Offset: 0x003E14FC
		private float PLDLLFGIJIB(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.CKBLKIPOGLI();
			return Vector2.Distance(this.EBMHMFBKCCJ(cjobmallbec), this.EBMHMFBKCCJ(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x003E332C File Offset: 0x003E152C
		private IEnumerator NPBFCPDNBAP(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			Vector2 knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			float num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x003E334E File Offset: 0x003E154E
		public void MPJPENLCIMG(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.CKBLKIPOGLI();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.NMGNDPFPOJN();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.BLMFFCHAPHH(HNIFGMOMJMA));
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x003E3149 File Offset: 0x003E1349
		private void BBBHKHLLKJJ()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = false;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x003E3149 File Offset: 0x003E1349
		private void LCCNECBLBGC()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = false;
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 IKMIOKHMKOA()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x003E3388 File Offset: 0x003E1588
		private void HGGOLFBACKB()
		{
			base.StopAllCoroutines();
			if (this.disableDragWhileTweening)
			{
				this.EBILHCMBCMA();
			}
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x003E33A4 File Offset: 0x003E15A4
		private IEnumerator MFPIDDMEEFG(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x003E33C8 File Offset: 0x003E15C8
		public Vector2 EaseVector(float GNDPILFCALF, Vector2 KGPBBCIGIIE, Vector2 KNOOJALCFNN, float HNIFGMOMJMA)
		{
			return new Vector2(KNOOJALCFNN.x * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1.57079637f) + KGPBBCIGIIE.x, KNOOJALCFNN.y * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1.57079637f) + KGPBBCIGIIE.y);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x003E3418 File Offset: 0x003E1618
		public void GEEMOFIOPPP(Vector2 CJOBMALLBEC)
		{
			this.JKBLJBOFMNI(CJOBMALLBEC, this.HIBEMKLGABM(CJOBMALLBEC));
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x003E329A File Offset: 0x003E149A
		private void LOMHIIKFFEP()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			this.BKDMFGCFOAJ = this.GIGHNDOLPBN.horizontal;
			this.HLBMCMOBJBE = this.GIGHNDOLPBN.vertical;
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 BJAJHAGBBFN()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x003E343B File Offset: 0x003E163B
		public void HBFCICDEOLE(float LNHKJHHLAEN)
		{
			this.OEPHKBNHKLI(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN));
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x003E31E3 File Offset: 0x003E13E3
		public void LJLHIFGAHEG(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.MPJPENLCIMG(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x003E3454 File Offset: 0x003E1654
		private Vector2 EFIAJNAGLLF(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x003E3388 File Offset: 0x003E1588
		private void LLIFBAANOCE()
		{
			base.StopAllCoroutines();
			if (this.disableDragWhileTweening)
			{
				this.EBILHCMBCMA();
			}
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 CKBLKIPOGLI()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x003E34A6 File Offset: 0x003E16A6
		private void POFEOPHEJBJ()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = true;
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x003E34C0 File Offset: 0x003E16C0
		public void HCELMPDHJKA(Vector2 CJOBMALLBEC)
		{
			this.Scroll(CJOBMALLBEC, this.OPFGBMPPNGF(CJOBMALLBEC));
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x003E34D0 File Offset: 0x003E16D0
		private float BKANEDKLHIO(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.NDFBDLHMFJN();
			return Vector2.Distance(this.KHJMHBENIPD(cjobmallbec), this.EBMHMFBKCCJ(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x003E3136 File Offset: 0x003E1336
		public void PPJOEEEOEKK(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.BGPAEJKBEIG();
			}
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 KFFMHPAFCBM()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x003E34FE File Offset: 0x003E16FE
		private void FGNABBCPOBM()
		{
			this.GIGHNDOLPBN.horizontal = true;
			this.GIGHNDOLPBN.vertical = true;
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x003E3518 File Offset: 0x003E1718
		private IEnumerator ADIFLJOEDNF(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x003E353A File Offset: 0x003E173A
		public void ONJOLCJDJJJ(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.GNEJIFIAMFL(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x003E3554 File Offset: 0x003E1754
		private float HIBEMKLGABM(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.NDFBDLHMFJN();
			return Vector2.Distance(this.JDLGLHCLKNL(cjobmallbec), this.NGOBDDNCGEH(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A7B8 RID: 42936 RVA: 0x003E329A File Offset: 0x003E149A
		private void GEPELODHBFN()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			this.BKDMFGCFOAJ = this.GIGHNDOLPBN.horizontal;
			this.HLBMCMOBJBE = this.GIGHNDOLPBN.vertical;
		}

		// Token: 0x0600A7B9 RID: 42937 RVA: 0x003E31E3 File Offset: 0x003E13E3
		public void CHCCEKBBDOA(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.MPJPENLCIMG(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x003E3584 File Offset: 0x003E1784
		private IEnumerator BLMFFCHAPHH(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x003E30B9 File Offset: 0x003E12B9
		private Vector2 FNKHCMPLDDH()
		{
			return new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, this.GIGHNDOLPBN.verticalNormalizedPosition);
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x003E35A8 File Offset: 0x003E17A8
		private IEnumerator HHBEPFIABCG(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x003E35CA File Offset: 0x003E17CA
		public void CMCEBEEBLMP(float APEKBGJHBPJ)
		{
			this.HCELMPDHJKA(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition));
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x003E35E3 File Offset: 0x003E17E3
		public void BNDHLJAOMCM(float APEKBGJHBPJ)
		{
			this.DLENJDKDAOH(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition));
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x003E35FC File Offset: 0x003E17FC
		public void IKCDGFFDGJD(float LNHKJHHLAEN)
		{
			this.PCEOILFIIAF(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN));
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x003E3085 File Offset: 0x003E1285
		private void OMGPBGLNOJG()
		{
			this.GIGHNDOLPBN.horizontal = this.BKDMFGCFOAJ;
			this.GIGHNDOLPBN.vertical = this.HLBMCMOBJBE;
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x003E329A File Offset: 0x003E149A
		private void Awake()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			this.BKDMFGCFOAJ = this.GIGHNDOLPBN.horizontal;
			this.HLBMCMOBJBE = this.GIGHNDOLPBN.vertical;
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x003E3618 File Offset: 0x003E1818
		private Vector2 KHJMHBENIPD(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x003E34A6 File Offset: 0x003E16A6
		private void DDBMLJAFPJD()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = true;
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x003E3085 File Offset: 0x003E1285
		private void EBILHCMBCMA()
		{
			this.GIGHNDOLPBN.horizontal = this.BKDMFGCFOAJ;
			this.GIGHNDOLPBN.vertical = this.HLBMCMOBJBE;
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x003E366A File Offset: 0x003E186A
		public void KPBELHNNHGL(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.NDFBDLHMFJN();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.ECFNOPCJEIE();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.HHBEPFIABCG(HNIFGMOMJMA));
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x003E36A4 File Offset: 0x003E18A4
		public Vector2 LOGDFBNBDPN(float GNDPILFCALF, Vector2 KGPBBCIGIIE, Vector2 KNOOJALCFNN, float HNIFGMOMJMA)
		{
			return new Vector2(KNOOJALCFNN.x * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1123f) + KGPBBCIGIIE.x, KNOOJALCFNN.y * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1154f) + KGPBBCIGIIE.y);
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x003E36F4 File Offset: 0x003E18F4
		public void IJOKICJHDHE(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.LLIFBAANOCE();
			}
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x003E3708 File Offset: 0x003E1908
		private Vector2 AGNEJEPHBDP(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x003E375A File Offset: 0x003E195A
		public void DLENJDKDAOH(Vector2 CJOBMALLBEC)
		{
			this.KANBEBLDDJF(CJOBMALLBEC, this.MABODMMBCPD(CJOBMALLBEC));
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x003E376C File Offset: 0x003E196C
		private float LFCPCNEMGFD(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.KFFMHPAFCBM();
			return Vector2.Distance(this.EFIAJNAGLLF(cjobmallbec), this.EBMHMFBKCCJ(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x003E379A File Offset: 0x003E199A
		public void Scroll(Vector2 CJOBMALLBEC)
		{
			this.Scroll(CJOBMALLBEC, this.KFELCGOLOPO(CJOBMALLBEC));
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x003E37AA File Offset: 0x003E19AA
		public void Scroll(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.FNKHCMPLDDH();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.NMGNDPFPOJN();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.MFPIDDMEEFG(HNIFGMOMJMA));
		}

		// Token: 0x0600A7CD RID: 42957 RVA: 0x003E37E4 File Offset: 0x003E19E4
		public void JKBLJBOFMNI(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.BJAJHAGBBFN();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.IAHEABHJACH();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.BLMFFCHAPHH(HNIFGMOMJMA));
		}

		// Token: 0x0600A7CE RID: 42958 RVA: 0x003E353A File Offset: 0x003E173A
		public void HGMPOFHBPFG(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.GNEJIFIAMFL(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x003E381E File Offset: 0x003E1A1E
		public void JIHICNOGGBM(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.KANBEBLDDJF(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x003E3838 File Offset: 0x003E1A38
		private Vector2 JDDMHHBMAAJ(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7D1 RID: 42961 RVA: 0x003E3136 File Offset: 0x003E1336
		public void PNAFHIHBKHB(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.BGPAEJKBEIG();
			}
		}

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x003E388A File Offset: 0x003E1A8A
		public void NAFLLKBCDKM(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.HGGOLFBACKB();
			}
		}

		// Token: 0x0600A7D3 RID: 42963 RVA: 0x003E389D File Offset: 0x003E1A9D
		public void MHCLNEFBGPA(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.JKBLJBOFMNI(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x003E38B7 File Offset: 0x003E1AB7
		private void BGPAEJKBEIG()
		{
			base.StopAllCoroutines();
			if (this.disableDragWhileTweening)
			{
				this.MAGGPCHGEMN();
			}
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x003E34A6 File Offset: 0x003E16A6
		private void ECFNOPCJEIE()
		{
			this.GIGHNDOLPBN.horizontal = false;
			this.GIGHNDOLPBN.vertical = true;
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x003E38D0 File Offset: 0x003E1AD0
		public void FJHDAJKNGKM(float APEKBGJHBPJ, float HNIFGMOMJMA)
		{
			this.KANBEBLDDJF(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition), HNIFGMOMJMA);
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x003E3196 File Offset: 0x003E1396
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.PIMLCOAIHNG();
			}
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x003E38EA File Offset: 0x003E1AEA
		public void NDBKOCNEGAO(float APEKBGJHBPJ, float HNIFGMOMJMA)
		{
			this.JKBLJBOFMNI(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition), HNIFGMOMJMA);
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x003E3904 File Offset: 0x003E1B04
		private Vector2 EBMHMFBKCCJ(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x003E3956 File Offset: 0x003E1B56
		public void EEPMPOMBLDC(Vector2 CJOBMALLBEC)
		{
			this.KANBEBLDDJF(CJOBMALLBEC, this.JLPHNDFMCLF(CJOBMALLBEC));
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x003E3968 File Offset: 0x003E1B68
		public Vector2 NCJNHHOMBAF(float GNDPILFCALF, Vector2 KGPBBCIGIIE, Vector2 KNOOJALCFNN, float HNIFGMOMJMA)
		{
			return new Vector2(KNOOJALCFNN.x * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 893f) + KGPBBCIGIIE.x, KNOOJALCFNN.y * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1559f) + KGPBBCIGIIE.y);
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x003E39B8 File Offset: 0x003E1BB8
		public void OEPHKBNHKLI(Vector2 CJOBMALLBEC)
		{
			this.GNEJIFIAMFL(CJOBMALLBEC, this.HIBEMKLGABM(CJOBMALLBEC));
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x003E36F4 File Offset: 0x003E18F4
		public void JLBDLJNKNKN(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.LLIFBAANOCE();
			}
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x003E389D File Offset: 0x003E1A9D
		public void CCFNHMLEAJO(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.JKBLJBOFMNI(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x003E39C8 File Offset: 0x003E1BC8
		public void KANBEBLDDJF(Vector2 CJOBMALLBEC, float HNIFGMOMJMA)
		{
			this.KMELADALIDN = this.BJAJHAGBBFN();
			this.GIEKAJJGFJD = CJOBMALLBEC;
			if (this.disableDragWhileTweening)
			{
				this.FGNABBCPOBM();
			}
			base.StopAllCoroutines();
			base.StartCoroutine(this.MFPIDDMEEFG(HNIFGMOMJMA));
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x003E3A02 File Offset: 0x003E1C02
		public void ScrollHorizontal(float APEKBGJHBPJ)
		{
			this.Scroll(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition));
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x003E329A File Offset: 0x003E149A
		private void GLGOLEOAFOD()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			this.BKDMFGCFOAJ = this.GIGHNDOLPBN.horizontal;
			this.HLBMCMOBJBE = this.GIGHNDOLPBN.vertical;
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x003E3A1C File Offset: 0x003E1C1C
		private float KEDFCDJIAAB(Vector2 CJOBMALLBEC)
		{
			Vector2 cjobmallbec = this.BJAJHAGBBFN();
			return Vector2.Distance(this.NGOBDDNCGEH(cjobmallbec), this.KHJMHBENIPD(CJOBMALLBEC)) / this.moveSpeed;
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x003E3A4A File Offset: 0x003E1C4A
		private void IAHEABHJACH()
		{
			this.GIGHNDOLPBN.horizontal = true;
			this.GIGHNDOLPBN.vertical = false;
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x003E3A64 File Offset: 0x003E1C64
		public void ScrollVertical(float LNHKJHHLAEN)
		{
			this.Scroll(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN));
		}

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x003E3A7D File Offset: 0x003E1C7D
		private void MANJBAJEFJI()
		{
			base.StopAllCoroutines();
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
		}

		// Token: 0x0600A7E6 RID: 42982 RVA: 0x003E3A96 File Offset: 0x003E1C96
		public void LPENBOCGNJK(PointerEventData OLIIPKODDIN)
		{
			if (!this.disableDragWhileTweening)
			{
				this.MANJBAJEFJI();
			}
		}

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x003E3AAC File Offset: 0x003E1CAC
		private IEnumerator EEKGLJCOMDN(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA < 0.05f)
			{
				yield break;
			}
			knoojalcfnn = this.GIEKAJJGFJD - this.KMELADALIDN;
			num = 0f;
			while (num < HNIFGMOMJMA)
			{
				num += Time.deltaTime;
				this.GIGHNDOLPBN.normalizedPosition = this.EaseVector(num, this.KMELADALIDN, knoojalcfnn, HNIFGMOMJMA);
				yield return null;
			}
			this.GIGHNDOLPBN.normalizedPosition = this.GIEKAJJGFJD;
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
			yield break;
		}

		// Token: 0x0600A7E8 RID: 42984 RVA: 0x003E381E File Offset: 0x003E1A1E
		public void CCLKIFMFDOB(float LNHKJHHLAEN, float HNIFGMOMJMA)
		{
			this.KANBEBLDDJF(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN), HNIFGMOMJMA);
		}

		// Token: 0x0600A7E9 RID: 42985 RVA: 0x003E343B File Offset: 0x003E163B
		public void GLHHIFLHCKH(float LNHKJHHLAEN)
		{
			this.OEPHKBNHKLI(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN));
		}

		// Token: 0x0600A7EA RID: 42986 RVA: 0x003E3AD0 File Offset: 0x003E1CD0
		private Vector2 JDLGLHCLKNL(Vector2 CJOBMALLBEC)
		{
			return new Vector2(CJOBMALLBEC.x * this.GIGHNDOLPBN.content.rect.width, CJOBMALLBEC.y * this.GIGHNDOLPBN.content.rect.height);
		}

		// Token: 0x0600A7EB RID: 42987 RVA: 0x003E3B22 File Offset: 0x003E1D22
		public void ScrollHorizontal(float APEKBGJHBPJ, float HNIFGMOMJMA)
		{
			this.Scroll(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition), HNIFGMOMJMA);
		}

		// Token: 0x0600A7EC RID: 42988 RVA: 0x003E3085 File Offset: 0x003E1285
		private void MAGGPCHGEMN()
		{
			this.GIGHNDOLPBN.horizontal = this.BKDMFGCFOAJ;
			this.GIGHNDOLPBN.vertical = this.HLBMCMOBJBE;
		}

		// Token: 0x0600A7ED RID: 42989 RVA: 0x003E3B3C File Offset: 0x003E1D3C
		public void PNFJFGDNGDB(float APEKBGJHBPJ)
		{
			this.GEEMOFIOPPP(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition));
		}

		// Token: 0x0600A7EE RID: 42990 RVA: 0x003E3A7D File Offset: 0x003E1C7D
		private void PIMLCOAIHNG()
		{
			base.StopAllCoroutines();
			if (this.disableDragWhileTweening)
			{
				this.NKAMECPKMFD();
			}
		}

		// Token: 0x0600A7EF RID: 42991 RVA: 0x003E34FE File Offset: 0x003E16FE
		private void HKENNFLINDJ()
		{
			this.GIGHNDOLPBN.horizontal = true;
			this.GIGHNDOLPBN.vertical = true;
		}

		// Token: 0x0600A7F0 RID: 42992 RVA: 0x003E343B File Offset: 0x003E163B
		public void NAHAKMPMKFB(float LNHKJHHLAEN)
		{
			this.OEPHKBNHKLI(new Vector2(this.GIGHNDOLPBN.horizontalNormalizedPosition, LNHKJHHLAEN));
		}

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x003E38EA File Offset: 0x003E1AEA
		public void IPNENFAMIKH(float APEKBGJHBPJ, float HNIFGMOMJMA)
		{
			this.JKBLJBOFMNI(new Vector2(APEKBGJHBPJ, this.GIGHNDOLPBN.verticalNormalizedPosition), HNIFGMOMJMA);
		}

		// Token: 0x0600A7F2 RID: 42994 RVA: 0x003E3B58 File Offset: 0x003E1D58
		public Vector2 KKMNNNBHNAH(float GNDPILFCALF, Vector2 KGPBBCIGIIE, Vector2 KNOOJALCFNN, float HNIFGMOMJMA)
		{
			return new Vector2(KNOOJALCFNN.x * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 1002f) + KGPBBCIGIIE.x, KNOOJALCFNN.y * Mathf.Sin(GNDPILFCALF / HNIFGMOMJMA * 471f) + KGPBBCIGIIE.y);
		}

		// Token: 0x040012B7 RID: 4791
		private ScrollRect GIGHNDOLPBN;

		// Token: 0x040012B8 RID: 4792
		private Vector2 KMELADALIDN;

		// Token: 0x040012B9 RID: 4793
		private Vector2 GIEKAJJGFJD;

		// Token: 0x040012BA RID: 4794
		private bool BKDMFGCFOAJ;

		// Token: 0x040012BB RID: 4795
		private bool HLBMCMOBJBE;

		// Token: 0x040012BC RID: 4796
		public float moveSpeed = 5000f;

		// Token: 0x040012BD RID: 4797
		public bool disableDragWhileTweening;
	}
}
