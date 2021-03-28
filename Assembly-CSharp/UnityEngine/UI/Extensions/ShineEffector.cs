using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200026C RID: 620
	[AddComponentMenu("UI/Effects/Extensions/Shining Effect")]
	public class ShineEffector : MonoBehaviour
	{
		// Token: 0x0600948B RID: 38027 RVA: 0x00345680 File Offset: 0x00343880
		private void EMABEGEAGII()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("#pleasewait");
				this.effectRoot = new GameObject("Joystick1Button3");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1180f, 941f, 185f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.Width = this.width;
			if (this.yOffset <= 1247f || this.yOffset >= 293f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x003458E0 File Offset: 0x00343AE0
		private void LMADKINICIN()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 1092f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.EOLEPGEMBCH(787f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.OADGABMNGNM() < 1450f)
				{
					this.YOffset = this.CLLHKFMMJLE() + this.animSpeed * Time.deltaTime;
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x00345982 File Offset: 0x00343B82
		public float GMDBCLDNAAL()
		{
			return this.yOffset;
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x0034598C File Offset: 0x00343B8C
		private void AEIJFLJEABG()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 704f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.HOHJPIOGOGE(1475f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.MNBCMLGAABA() < 1905f)
				{
					this.MHJAMPBJIJG(this.AKNGOEDLMBF() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x00345982 File Offset: 0x00343B82
		public float AALPBJAPFMF()
		{
			return this.yOffset;
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00345A30 File Offset: 0x00343C30
		private void ANOGBFBCPPD(float DPNHODJHGJL)
		{
			this.effector.HDBJFEACEIP(DPNHODJHGJL);
			if (DPNHODJHGJL <= 568f || DPNHODJHGJL >= 1311f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x00345A8C File Offset: 0x00343C8C
		public void OKOJIJGBDFD(float DPNHODJHGJL)
		{
			this.OMMFIFNCNPC(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x00345A9C File Offset: 0x00343C9C
		private void JIPEMDLKAGO()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("getbool");
				this.effectRoot = new GameObject("CameraFilterPack_TV_Noise2");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1057f, 628f, 1215f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.IKFAKIHBCNO(this.width);
			if (this.yOffset <= 106f || this.yOffset >= 1530f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x00345CFC File Offset: 0x00343EFC
		private void EAIPPDOABCG()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("DifficultyBG");
				this.effectRoot = new GameObject("_EmissionGain");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(941f, 903f, 644f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.MLAGEPNCCGM();
			}
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x00345EF0 File Offset: 0x003440F0
		private void JALJCACDDOK(float DPNHODJHGJL)
		{
			this.effector.JAELNOHDBGN(DPNHODJHGJL);
			if (DPNHODJHGJL <= 1460f || DPNHODJHGJL >= 251f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x00345F4C File Offset: 0x0034414C
		public void PIEBFINLOIG(float DPNHODJHGJL)
		{
			this.ANOGBFBCPPD(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00345982 File Offset: 0x00343B82
		public float MKDIEKBHAAG()
		{
			return this.yOffset;
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x00345F5C File Offset: 0x0034415C
		private void PGLLHPHPMJN()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00345F84 File Offset: 0x00344184
		private void IIJAPKAADNH()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("f");
				this.effectRoot = new GameObject("Bad parameters for getbool! Use <key> <value>");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1118f, 663f, 427f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.IKFAKIHBCNO(this.width);
			if (this.yOffset <= 1762f || this.yOffset >= 1449f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06009499 RID: 38041 RVA: 0x00345982 File Offset: 0x00343B82
		// (set) Token: 0x060094B3 RID: 38067 RVA: 0x00345A8C File Offset: 0x00343C8C
		public float YOffset
		{
			get
			{
				return this.yOffset;
			}
			set
			{
				this.OMMFIFNCNPC(value);
				this.yOffset = value;
			}
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x003461E4 File Offset: 0x003443E4
		private void AENGMPAMCFL()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("BadgeImage");
				this.effectRoot = new GameObject("MapEnd");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(500f, 1335f, 1740f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.LOOGLMFBJHK();
			}
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x003463D8 File Offset: 0x003445D8
		public void LGJHICEKCCF(float DPNHODJHGJL)
		{
			this.PFFHJNGABEE(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x003463E8 File Offset: 0x003445E8
		private void EPALOMHECJM()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("#ok");
				this.effectRoot = new GameObject(".");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(776f, 1020f, 1762f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.Width = this.width;
			if (this.yOffset <= 1971f || this.yOffset >= 304f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00345F5C File Offset: 0x0034415C
		private void CDPBNLJPAKH()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00346648 File Offset: 0x00344848
		private void OMMFIFNCNPC(float DPNHODJHGJL)
		{
			this.effector.Yoffset = DPNHODJHGJL;
			if (DPNHODJHGJL <= -1f || DPNHODJHGJL >= 1f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x003466A4 File Offset: 0x003448A4
		public void KHMMFOKMHEI(float DPNHODJHGJL)
		{
			this.DCODDEMMOFH(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x003466B4 File Offset: 0x003448B4
		private void PMOMPBFKOAM()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("Setting autoCleanUpPlayerObjects while in a room is not supported.");
				this.effectRoot = new GameObject("[TextSaver] Text saved to ");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1571f, 1089f, 1926f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.EPALOMHECJM();
			}
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x003468A8 File Offset: 0x00344AA8
		private void Update()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 0f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.YOffset = -1f;
						this.MEEFGCCLCDH = false;
					}
				}
				else if (this.YOffset < 1f)
				{
					this.YOffset += this.animSpeed * Time.deltaTime;
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x0034694C File Offset: 0x00344B4C
		private void KGHFKHBPHEH()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).");
				this.effectRoot = new GameObject("_TimeX");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(304f, 1681f, 1367f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.MBFNACDMEEK();
			}
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00346B40 File Offset: 0x00344D40
		private void DDBOODLPCAM()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 1293f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.OKOJIJGBDFD(1778f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.AKNGOEDLMBF() < 1513f)
				{
					this.EOLEPGEMBCH(this.MNBCMLGAABA() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = false;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00346BE4 File Offset: 0x00344DE4
		private void GFOOJOMCCBP()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("_Intensity");
				this.effectRoot = new GameObject("Month_");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1167f, 1794f, 1811f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.ICNHAAKIJKP(this.width);
			if (this.yOffset <= 137f || this.yOffset >= 968f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x00346E6C File Offset: 0x0034506C
		private void LBIOIEANMGI()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 1808f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.HOHJPIOGOGE(1537f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.JINAMAKBCGP() < 1880f)
				{
					this.EOLEPGEMBCH(this.CLLHKFMMJLE() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00345982 File Offset: 0x00343B82
		public float COIFMPMBNEF()
		{
			return this.yOffset;
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00346F10 File Offset: 0x00345110
		private void LMPIBJBOLCA(float DPNHODJHGJL)
		{
			this.effector.Yoffset = DPNHODJHGJL;
			if (DPNHODJHGJL <= 1217f || DPNHODJHGJL >= 1964f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00345982 File Offset: 0x00343B82
		public float PDJDJDDMNEP()
		{
			return this.yOffset;
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x00345982 File Offset: 0x00343B82
		public float MNBCMLGAABA()
		{
			return this.yOffset;
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x00346F6C File Offset: 0x0034516C
		public void EOLEPGEMBCH(float DPNHODJHGJL)
		{
			this.LMPIBJBOLCA(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x00345982 File Offset: 0x00343B82
		public float MNMOPICGMBD()
		{
			return this.yOffset;
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00346F7C File Offset: 0x0034517C
		private void PFFHJNGABEE(float DPNHODJHGJL)
		{
			this.effector.HDBJFEACEIP(DPNHODJHGJL);
			if (DPNHODJHGJL <= 824f || DPNHODJHGJL >= 1829f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x00345982 File Offset: 0x00343B82
		public float AKNGOEDLMBF()
		{
			return this.yOffset;
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x00345F5C File Offset: 0x0034415C
		private void OAENEDHDDNC()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x00345982 File Offset: 0x00343B82
		public float JINAMAKBCGP()
		{
			return this.yOffset;
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x00345F5C File Offset: 0x0034415C
		private void OMMJBCAKHAP()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x00345F5C File Offset: 0x0034415C
		private void LBFLFFGLMDB()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x00346FD8 File Offset: 0x003451D8
		private void BLDMINMDHPA()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("CameraFilterPack/Drawing_Paper2");
				this.effectRoot = new GameObject("_Value2");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(529f, 10f, 994f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.IKFAKIHBCNO(this.width);
			if (this.yOffset <= 1068f || this.yOffset >= 929f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00347238 File Offset: 0x00345438
		private void DLJIGFOHOKN(float DPNHODJHGJL)
		{
			this.effector.JAELNOHDBGN(DPNHODJHGJL);
			if (DPNHODJHGJL <= 130f || DPNHODJHGJL >= 1348f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00347294 File Offset: 0x00345494
		private void GPJHPNGNEBP()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("_TimeX");
				this.effectRoot = new GameObject("_SceneFogMode");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1670f, 794f, 951f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.ICNHAAKIJKP(this.width);
			if (this.yOffset <= 1469f || this.yOffset >= 651f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x00345982 File Offset: 0x00343B82
		public float CLLHKFMMJLE()
		{
			return this.yOffset;
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x003474F4 File Offset: 0x003456F4
		private void DBIBFOINCKM()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
				this.effectRoot = new GameObject("maps.");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(769f, 943f, 1959f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.ICNHAAKIJKP(this.width);
			if (this.yOffset <= 668f || this.yOffset >= 1297f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00345982 File Offset: 0x00343B82
		public float FONIILBDELH()
		{
			return this.yOffset;
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00347754 File Offset: 0x00345954
		private void AENIGCONKBD()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("#pleasewait");
				this.effectRoot = new GameObject("_Bullet_1");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(314f, 1954f, 2f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.IIJAPKAADNH();
			}
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x00345F5C File Offset: 0x0034415C
		private void ALKBPKHCJAK()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00345F5C File Offset: 0x0034415C
		private void BPDNKMPLPBG()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x00345982 File Offset: 0x00343B82
		public float OADGABMNGNM()
		{
			return this.yOffset;
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x00345982 File Offset: 0x00343B82
		public float DGLHKCDNBBG()
		{
			return this.yOffset;
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00347948 File Offset: 0x00345B48
		private void ANLNGCLJABH(float DPNHODJHGJL)
		{
			this.effector.Yoffset = DPNHODJHGJL;
			if (DPNHODJHGJL <= 1204f || DPNHODJHGJL >= 191f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x00345982 File Offset: 0x00343B82
		public float PCKECMCEEJA()
		{
			return this.yOffset;
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x003479A4 File Offset: 0x00345BA4
		private void CFIAKIJAILI()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 635f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.MHJAMPBJIJG(1267f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.AALPBJAPFMF() < 1589f)
				{
					this.PEPBDEEGFDK(this.FONIILBDELH() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00347A48 File Offset: 0x00345C48
		private void OnValidate()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("effector");
				this.effectRoot = new GameObject("ShineEffect");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(0f, 0f, -8f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.Yoffset = this.yOffset;
			this.effector.Width = this.width;
			if (this.yOffset <= -1f || this.yOffset >= 1f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x00345982 File Offset: 0x00343B82
		public float HLCEFLICDDP()
		{
			return this.yOffset;
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x00347CA8 File Offset: 0x00345EA8
		private void PPFGHAKKLMN()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject(".icon");
				this.effectRoot = new GameObject("[MapEditor] Prepairing map editor...");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1646f, 634f, 1465f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.LOOGLMFBJHK();
			}
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00345F5C File Offset: 0x0034415C
		private void BGLJELNNPPK()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x00347E9C File Offset: 0x0034609C
		private void IHPLMLBJELK()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject(": ");
				this.effectRoot = new GameObject("_Shadow");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1267f, 1063f, 221f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.POIFMMFPELA();
			}
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x00348090 File Offset: 0x00346290
		private void OnEnable()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("effector");
				this.effectRoot = new GameObject("ShineEffect");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(0f, 0f, -8f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.OnValidate();
			}
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00348284 File Offset: 0x00346484
		public void DHBHEHCKGKO(float DPNHODJHGJL)
		{
			this.NJCFPFMMOHE(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00345F5C File Offset: 0x0034415C
		private void EKBAAGELBNJ()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x00346F6C File Offset: 0x0034516C
		public void BNGGLJDPLAL(float DPNHODJHGJL)
		{
			this.LMPIBJBOLCA(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x00345F5C File Offset: 0x0034415C
		private void FJKCKAAHJPB()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x00348294 File Offset: 0x00346494
		private void NJCFPFMMOHE(float DPNHODJHGJL)
		{
			this.effector.HDBJFEACEIP(DPNHODJHGJL);
			if (DPNHODJHGJL <= 1327f || DPNHODJHGJL >= 437f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094CD RID: 38093 RVA: 0x003482F0 File Offset: 0x003464F0
		private void MBFNACDMEEK()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("</color>");
				this.effectRoot = new GameObject("player.lollipop");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1791f, 225f, 1528f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.Width = this.width;
			if (this.yOffset <= 1656f || this.yOffset >= 356f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094CE RID: 38094 RVA: 0x00348284 File Offset: 0x00346484
		public void PEPBDEEGFDK(float DPNHODJHGJL)
		{
			this.NJCFPFMMOHE(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094CF RID: 38095 RVA: 0x00345F5C File Offset: 0x0034415C
		private void BEFPBOCFOHM()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094D0 RID: 38096 RVA: 0x00348550 File Offset: 0x00346750
		private void HLDFOJMHKNL()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 982f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.KHMMFOKMHEI(1865f);
						this.MEEFGCCLCDH = false;
					}
				}
				else if (this.PCKECMCEEJA() < 495f)
				{
					this.DHBHEHCKGKO(this.COIFMPMBNEF() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094D1 RID: 38097 RVA: 0x00345F5C File Offset: 0x0034415C
		private void JNJMGIFMNBF()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094D2 RID: 38098 RVA: 0x003485F4 File Offset: 0x003467F4
		private void MLAGEPNCCGM()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("Editor/");
				this.effectRoot = new GameObject("/files/editor_manual.pdf");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1897f, 357f, 1072f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.FNPHBKMMPEG(this.width);
			if (this.yOffset <= 1478f || this.yOffset >= 260f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094D3 RID: 38099 RVA: 0x00348854 File Offset: 0x00346A54
		private void LOOGLMFBJHK()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("_TimeX");
				this.effectRoot = new GameObject("_Value");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(756f, 775f, 58f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.FNPHBKMMPEG(this.width);
			if (this.yOffset <= 265f || this.yOffset >= 1643f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094D4 RID: 38100 RVA: 0x00348AB4 File Offset: 0x00346CB4
		private void HIFPDKKBDHJ()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("maps.");
				this.effectRoot = new GameObject("Set Sun DirectionVector");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(393f, 837f, 1492f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.GPJHPNGNEBP();
			}
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x00348CA8 File Offset: 0x00346EA8
		private void NKLIHNJCHOG()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 812f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.KHMMFOKMHEI(834f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.AALPBJAPFMF() < 1314f)
				{
					this.IDCHMBPAJBP(this.CLLHKFMMJLE() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x00345F5C File Offset: 0x0034415C
		private void OBPIMJPMGFA()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x00348D4C File Offset: 0x00346F4C
		private void POIFMMFPELA()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("/");
				this.effectRoot = new GameObject("/");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1353f, 1379f, 1165f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.Width = this.width;
			if (this.yOffset <= 262f || this.yOffset >= 872f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00345F5C File Offset: 0x0034415C
		private void BPNDDNKKFDD()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x00348FAC File Offset: 0x003471AC
		private void AEEGKLABFLN()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 1844f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.LGJHICEKCCF(219f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.YOffset < 1307f)
				{
					this.EOLEPGEMBCH(this.MKDIEKBHAAG() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094DA RID: 38106 RVA: 0x00349050 File Offset: 0x00347250
		private void BILILBEBLFL()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("Encryption wasn't established: ");
				this.effectRoot = new GameObject("SpeedSlider");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(960f, 128f, 636f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.OnValidate();
			}
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x00349244 File Offset: 0x00347444
		private void EHCGBJDFMHG()
		{
			if (this.animated)
			{
				if (this.MEEFGCCLCDH)
				{
					if (this.CPMBKFPLBFL > 1063f)
					{
						this.CPMBKFPLBFL -= Time.deltaTime;
					}
					else
					{
						this.MHJAMPBJIJG(1285f);
						this.MEEFGCCLCDH = true;
					}
				}
				else if (this.PCKECMCEEJA() < 172f)
				{
					this.OKOJIJGBDFD(this.CLLHKFMMJLE() + this.animSpeed * Time.deltaTime);
				}
				else
				{
					this.MEEFGCCLCDH = true;
					this.CPMBKFPLBFL = this.animCD;
				}
			}
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x003492E6 File Offset: 0x003474E6
		public void LCCNMFLCAJM(float DPNHODJHGJL)
		{
			this.JALJCACDDOK(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x00345F5C File Offset: 0x0034415C
		private void ENCOHKLHOLD()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x003492F8 File Offset: 0x003474F8
		private void MEJPBKFMAIG()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("AudioSampler");
				this.effectRoot = new GameObject("Curve texture");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(1775f, 1368f, 574f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.MBFNACDMEEK();
			}
		}

		// Token: 0x060094DF RID: 38111 RVA: 0x003494EC File Offset: 0x003476EC
		public void IDCHMBPAJBP(float DPNHODJHGJL)
		{
			this.DLJIGFOHOKN(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094E0 RID: 38112 RVA: 0x00345F5C File Offset: 0x0034415C
		private void OnDestroy()
		{
			if (!Application.isPlaying)
			{
				Object.DestroyImmediate(this.effectRoot);
			}
			else
			{
				Object.Destroy(this.effectRoot);
			}
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x003494FC File Offset: 0x003476FC
		private void KMFGIAALGFC()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("mapselector.filter.officialsortmode");
				this.effectRoot = new GameObject(",");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(129f, 1869f, 1885f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.HDBJFEACEIP(this.yOffset);
			this.effector.ICNHAAKIJKP(this.width);
			if (this.yOffset <= 1427f || this.yOffset >= 1227f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x003492E6 File Offset: 0x003474E6
		public void HOHJPIOGOGE(float DPNHODJHGJL)
		{
			this.JALJCACDDOK(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x0034975C File Offset: 0x0034795C
		private void KKDDHFJOAAD()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("/Segment-[Down]");
				this.effectRoot = new GameObject("CameraFilterPack/Deep_OilPaintHQ");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = false;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(681f, 322f, 1479f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
			}
			this.effector.JAELNOHDBGN(this.yOffset);
			this.effector.FNPHBKMMPEG(this.width);
			if (this.yOffset <= 510f || this.yOffset >= 342f)
			{
				this.effectRoot.SetActive(true);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(true);
			}
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x00345982 File Offset: 0x00343B82
		public float ACEMJNBPDJJ()
		{
			return this.yOffset;
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x003499BC File Offset: 0x00347BBC
		private void DCODDEMMOFH(float DPNHODJHGJL)
		{
			this.effector.JAELNOHDBGN(DPNHODJHGJL);
			if (DPNHODJHGJL <= 921f || DPNHODJHGJL >= 1027f)
			{
				this.effectRoot.SetActive(false);
			}
			else if (!this.effectRoot.activeSelf)
			{
				this.effectRoot.SetActive(false);
			}
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x00348284 File Offset: 0x00346484
		public void MHJAMPBJIJG(float DPNHODJHGJL)
		{
			this.NJCFPFMMOHE(DPNHODJHGJL);
			this.yOffset = DPNHODJHGJL;
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x00349A18 File Offset: 0x00347C18
		private void BLNLHBNBKOH()
		{
			if (this.effector == null)
			{
				GameObject gameObject = new GameObject("challenges/");
				this.effectRoot = new GameObject("\n");
				this.effectRoot.transform.SetParent(base.transform);
				this.effectRoot.AddComponent<Image>().sprite = base.gameObject.GetComponent<Image>().sprite;
				this.effectRoot.GetComponent<Image>().type = base.gameObject.GetComponent<Image>().type;
				this.effectRoot.AddComponent<Mask>().showMaskGraphic = true;
				this.effectRoot.transform.localScale = Vector3.one;
				this.effectRoot.GetComponent<RectTransform>().anchoredPosition3D = Vector3.zero;
				this.effectRoot.GetComponent<RectTransform>().anchorMax = Vector2.one;
				this.effectRoot.GetComponent<RectTransform>().anchorMin = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMax = Vector2.zero;
				this.effectRoot.GetComponent<RectTransform>().offsetMin = Vector2.zero;
				this.effectRoot.transform.SetAsFirstSibling();
				gameObject.AddComponent<RectTransform>();
				gameObject.transform.SetParent(this.effectRoot.transform);
				this.IOIMCKBKOKC = gameObject.GetComponent<RectTransform>();
				this.IOIMCKBKOKC.localScale = Vector3.one;
				this.IOIMCKBKOKC.anchoredPosition3D = Vector3.zero;
				this.IOIMCKBKOKC.gameObject.AddComponent<ShineEffect>();
				this.IOIMCKBKOKC.anchorMax = Vector2.one;
				this.IOIMCKBKOKC.anchorMin = Vector2.zero;
				this.IOIMCKBKOKC.Rotate(462f, 1178f, 1152f);
				this.effector = gameObject.GetComponent<ShineEffect>();
				this.IOIMCKBKOKC.offsetMax = Vector2.zero;
				this.IOIMCKBKOKC.offsetMin = Vector2.zero;
				this.OnValidate();
			}
		}

		// Token: 0x040010EF RID: 4335
		public bool animated;

		// Token: 0x040010F0 RID: 4336
		public float animSpeed;

		// Token: 0x040010F1 RID: 4337
		public float animCD = 2f;

		// Token: 0x040010F2 RID: 4338
		private float CPMBKFPLBFL;

		// Token: 0x040010F3 RID: 4339
		public ShineEffect effector;

		// Token: 0x040010F4 RID: 4340
		[HideInInspector]
		[SerializeField]
		private GameObject effectRoot;

		// Token: 0x040010F5 RID: 4341
		[Range(-1f, 1f)]
		public float yOffset = -1f;

		// Token: 0x040010F6 RID: 4342
		[Range(0.1f, 1f)]
		public float width = 0.5f;

		// Token: 0x040010F7 RID: 4343
		private RectTransform IOIMCKBKOKC;

		// Token: 0x040010F8 RID: 4344
		private bool MEEFGCCLCDH;
	}
}
