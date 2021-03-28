using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A4 RID: 676
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/Tooltip")]
	public class ToolTip : MonoBehaviour
	{
		// Token: 0x0600A300 RID: 41728 RVA: 0x003D09C8 File Offset: 0x003CEBC8
		public void CJMLHADMDCK()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1687f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(146f, 787f, 1287f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1181f, 1644f, 1550f));
			float num = vector.x + this.CJDDBGPKDLP / 179f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 577f, 978f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1442f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 292f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 66f, 512f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 627f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 283f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(37f, 1144f + this.PBMAGEKDPLI / 1930f, 1099f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 692f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 496f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(998f, 479f + this.PBMAGEKDPLI / 1063f, 1192f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1830f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 695f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A301 RID: 41729 RVA: 0x003D0CC4 File Offset: 0x003CEEC4
		public void SetTooltip(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 40f, this.HGCMBKALPME.preferredHeight + 25f);
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x003D0D21 File Offset: 0x003CEF21
		private void POKHKAIPAJE()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.CBPNKOAKCAI();
			}
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x003D0D40 File Offset: 0x003CEF40
		public void BEFGGJNCDLH(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 675f, this.HGCMBKALPME.preferredHeight + 1015f);
				this.AHCALFOCHFE();
			}
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x003D0DA0 File Offset: 0x003CEFA0
		public void CBPNKOAKCAI()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1278f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(404f, 371f, 1157f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(35f, 623f, 1393f));
			float num = vector.x + this.CJDDBGPKDLP / 1129f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1026f, 366f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 95f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 841f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 851f, 1674f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 585f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1158f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1036f, 766f + this.PBMAGEKDPLI / 1337f, 649f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1355f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 818f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1938f, 1771f + this.PBMAGEKDPLI / 1857f, 54f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 21f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1446f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x003D109C File Offset: 0x003CF29C
		public void BFIOIDMHPPL()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 743f;
			this.FHHAGMOJHJO = 457f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A306 RID: 41734 RVA: 0x003D1109 File Offset: 0x003CF309
		public void AMGEKAGPJHM()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x003D112A File Offset: 0x003CF32A
		private void AFCLNNJHOOK()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.AAEHNIIINMO();
			}
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x003D114C File Offset: 0x003CF34C
		public void LGNMHMDEECO()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 380f;
			this.FHHAGMOJHJO = 204f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x003D11B9 File Offset: 0x003CF3B9
		private void AIOEKGMKMLN()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HLDALGBPALG();
			}
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x003D11D8 File Offset: 0x003CF3D8
		private void BIHKDAPNKMF()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.AAEHNIIINMO();
			}
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x003D11F8 File Offset: 0x003CF3F8
		public void MEGHEDOPDHE()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 353f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1026f, 1253f, 1931f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1201f, 1155f, 103f));
			float num = vector.x + this.CJDDBGPKDLP / 752f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 179f, 1600f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 377f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 811f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 276f, 1436f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 285f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1521f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(580f, 1710f + this.PBMAGEKDPLI / 480f, 851f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1657f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 637f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1788f, 967f + this.PBMAGEKDPLI / 409f, 2f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1979f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 674f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x003D14F4 File Offset: 0x003CF6F4
		public void GEGFJJBCHPE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1531f;
			this.FHHAGMOJHJO = 573f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x003D1564 File Offset: 0x003CF764
		public void GGHEPDCEHCK()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 346f;
			this.FHHAGMOJHJO = 147f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x003D15D4 File Offset: 0x003CF7D4
		public void EPCGHAAONLN()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 961f;
			this.FHHAGMOJHJO = 1353f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A310 RID: 41744 RVA: 0x003D1644 File Offset: 0x003CF844
		public void AHCALFOCHFE()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 523f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(455f, 1655f, 1511f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1240f, 1545f, 1760f));
			float num = vector.x + this.CJDDBGPKDLP / 1683f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1529f, 1167f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1695f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1030f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 541f, 1304f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 595f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1352f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(350f, 1415f + this.PBMAGEKDPLI / 567f, 641f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1692f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1549f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(817f, 345f + this.PBMAGEKDPLI / 778f, 1549f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1669f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 891f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x003D1940 File Offset: 0x003CFB40
		public void LFHKGIHNONL()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 175f;
			this.FHHAGMOJHJO = 1650f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x003D19AD File Offset: 0x003CFBAD
		private void GGLOGIGAJCA()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.AHCALFOCHFE();
			}
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x003D11D8 File Offset: 0x003CF3D8
		private void BDGLFDNFLAF()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.AAEHNIIINMO();
			}
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void FNNDDGKBBGF()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x003D19F0 File Offset: 0x003CFBF0
		public void LOMHIIKFFEP()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1232f;
			this.FHHAGMOJHJO = 1993f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x003D1A5D File Offset: 0x003CFC5D
		private void KNMHJOPHALM()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.EFOPLJIKBCM();
			}
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x003D1A7C File Offset: 0x003CFC7C
		public void JIJPHEDDIHC()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1804f;
			this.FHHAGMOJHJO = 1175f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A318 RID: 41752 RVA: 0x003D1AEC File Offset: 0x003CFCEC
		public void IGCLCJPPJCL(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 963f, this.HGCMBKALPME.preferredHeight + 1303f);
				this.MEGHEDOPDHE();
			}
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x003D1B49 File Offset: 0x003CFD49
		private void HGNJDPGPCEL()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.CPFJFIBMEOK();
			}
		}

		// Token: 0x0600A31A RID: 41754 RVA: 0x003D1B68 File Offset: 0x003CFD68
		public void LDDJDAPGIAL(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 749f, this.HGCMBKALPME.preferredHeight + 1171f);
				this.EFOPLJIKBCM();
			}
		}

		// Token: 0x0600A31B RID: 41755 RVA: 0x003D1BC8 File Offset: 0x003CFDC8
		public void GKNIJBHMENO()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 675f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1373f, 952f, 119f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1430f, 1224f, 1767f));
			float num = vector.x + this.CJDDBGPKDLP / 1917f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 689f, 597f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 527f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1466f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 236f, 1096f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 1865f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1536f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1572f, 779f + this.PBMAGEKDPLI / 417f, 885f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1890f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1418f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(958f, 999f + this.PBMAGEKDPLI / 1848f, 679f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1164f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 371f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x003D1EC4 File Offset: 0x003D00C4
		public void PKCCCNMBOCF()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1609f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1109f, 1159f, 46f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1310f, 414f, 1220f));
			float num = vector.x + this.CJDDBGPKDLP / 412f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 124f, 1788f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1569f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1273f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1648f, 1038f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 829f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 889f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1665f, 1376f + this.PBMAGEKDPLI / 361f, 1857f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 846f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 421f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1487f, 1006f + this.PBMAGEKDPLI / 569f, 463f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1619f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 370f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x003D21C0 File Offset: 0x003D03C0
		public void FCMOEMIJJKK()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1934f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(576f, 702f, 1066f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1795f, 728f, 1805f));
			float num = vector.x + this.CJDDBGPKDLP / 948f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1791f, 36f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 899f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 596f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1543f, 530f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 815f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 85f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(347f, 1988f + this.PBMAGEKDPLI / 855f, 1281f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1341f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 968f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1485f, 4f + this.PBMAGEKDPLI / 1325f, 403f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1220f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1234f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A31E RID: 41758 RVA: 0x003D24BC File Offset: 0x003D06BC
		public void EPFFFDFBFMA()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1732f;
			this.FHHAGMOJHJO = 1340f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A31F RID: 41759 RVA: 0x003D2529 File Offset: 0x003D0729
		private void KNBFLJKOPHB()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.IJCAIPKFHFC();
			}
		}

		// Token: 0x0600A320 RID: 41760 RVA: 0x003D2548 File Offset: 0x003D0748
		private void LICDHMGLBCH()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.AIMEDGAFPAL();
			}
		}

		// Token: 0x0600A321 RID: 41761 RVA: 0x003D2567 File Offset: 0x003D0767
		public void HCLHKEOAKBL()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A322 RID: 41762 RVA: 0x003D2588 File Offset: 0x003D0788
		public void AAEHNIIINMO()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1334f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1047f, 1508f, 917f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1868f, 1127f, 1041f));
			float num = vector.x + this.CJDDBGPKDLP / 191f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 709f, 1140f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1087f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1420f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1722f, 1577f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 554f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 441f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1606f, 1749f + this.PBMAGEKDPLI / 1976f, 1790f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 751f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 576f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1750f, 1068f + this.PBMAGEKDPLI / 1971f, 223f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1828f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1575f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A323 RID: 41763 RVA: 0x003D11B9 File Offset: 0x003CF3B9
		private void AONLFBOLNIJ()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HLDALGBPALG();
			}
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x003D2884 File Offset: 0x003D0A84
		public void PGGNGAMLGAJ()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 876f;
			this.FHHAGMOJHJO = 854f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x003D28F4 File Offset: 0x003D0AF4
		public void OJACCGOHBGH()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 572f;
			this.FHHAGMOJHJO = 260f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x003D2964 File Offset: 0x003D0B64
		public void BLCDKNKHJKF(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 952f, this.HGCMBKALPME.preferredHeight + 1758f);
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x003D29C4 File Offset: 0x003D0BC4
		public void AALONHDMCKO()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1334f;
			this.FHHAGMOJHJO = 119f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x003D2A34 File Offset: 0x003D0C34
		public void APCLIEFJLKI()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1739f;
			this.FHHAGMOJHJO = 382f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x003D2AA4 File Offset: 0x003D0CA4
		public void BGAGIKLPPOH(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 160f, this.HGCMBKALPME.preferredHeight + 1776f);
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x003D2B04 File Offset: 0x003D0D04
		public void ICIFIEMNDAM()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 589f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(9f, 1063f, 352f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(541f, 69f, 87f));
			float num = vector.x + this.CJDDBGPKDLP / 256f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 445f, 805f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 347f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 171f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 604f, 926f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 942f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1544f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(827f, 1081f + this.PBMAGEKDPLI / 1269f, 398f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 308f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 894f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1788f, 607f + this.PBMAGEKDPLI / 1874f, 511f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 173f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1179f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x003D2E00 File Offset: 0x003D1000
		public void FEEPCNIPGOD(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1023f, this.HGCMBKALPME.preferredHeight + 1732f);
				this.CJMLHADMDCK();
			}
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x003D2E60 File Offset: 0x003D1060
		public void MCIEAOAMOIG()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 875f;
			this.FHHAGMOJHJO = 60f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x003D2ED0 File Offset: 0x003D10D0
		public void EFOPLJIKBCM()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1204f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(383f, 104f, 1983f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1512f, 299f, 1531f));
			float num = vector.x + this.CJDDBGPKDLP / 560f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 377f, 996f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1926f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 520f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1236f, 1531f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 1294f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1614f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(325f, 501f + this.PBMAGEKDPLI / 321f, 1358f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 752f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1952f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1283f, 1997f + this.PBMAGEKDPLI / 1244f, 1211f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 510f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1435f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x003D31CC File Offset: 0x003D13CC
		public void CIIPBIGLHAE(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1910f, this.HGCMBKALPME.preferredHeight + 255f);
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void MBOKIADNFOK()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x003D322C File Offset: 0x003D142C
		public void OCBALAKMNNH(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 217f, this.HGCMBKALPME.preferredHeight + 1382f);
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x003D328C File Offset: 0x003D148C
		public void BNGGJMNMBBL()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 897f;
			this.FHHAGMOJHJO = 1425f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x003D32F9 File Offset: 0x003D14F9
		public void NLDBIIJCFFA()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x003D331C File Offset: 0x003D151C
		public void OIHECMIICIJ(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1216f, this.HGCMBKALPME.preferredHeight + 273f);
				this.GKNIJBHMENO();
			}
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x003D3379 File Offset: 0x003D1579
		public void CEKAGICFNFG()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void NKLLLBLGBPN()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x003D339C File Offset: 0x003D159C
		public void LBOBAIGNOML()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 492f;
			this.FHHAGMOJHJO = 158f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A337 RID: 41783 RVA: 0x003D3409 File Offset: 0x003D1609
		private void IFMMDLHMDOB()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.CPFJFIBMEOK();
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x003D0D21 File Offset: 0x003CEF21
		private void MFMILEABJBO()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.CBPNKOAKCAI();
			}
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x003D3428 File Offset: 0x003D1628
		public void BNIFJJAMLBE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1029f;
			this.FHHAGMOJHJO = 147f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x003D3495 File Offset: 0x003D1695
		public void OEKPKGOCKOC()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x003D34B8 File Offset: 0x003D16B8
		public void JFAHFAIEPLG()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 178f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(711f, 459f, 213f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(477f, 310f, 313f));
			float num = vector.x + this.CJDDBGPKDLP / 482f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1084f, 1964f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1474f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1270f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1337f, 493f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 115f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 112f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(753f, 302f + this.PBMAGEKDPLI / 1720f, 1863f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 993f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 387f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1917f, 240f + this.PBMAGEKDPLI / 129f, 963f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 125f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 945f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x003D37B4 File Offset: 0x003D19B4
		public void CEAKHNOBCAD(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 154f, this.HGCMBKALPME.preferredHeight + 1785f);
				this.EFOPLJIKBCM();
			}
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x003D112A File Offset: 0x003CF32A
		private void OELBEFIMKFB()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.AAEHNIIINMO();
			}
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x003D3814 File Offset: 0x003D1A14
		public void PIIMBOLGHOE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1420f;
			this.FHHAGMOJHJO = 1797f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x003D3884 File Offset: 0x003D1A84
		public void IJCAIPKFHFC()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1529f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(580f, 1698f, 1309f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1041f, 1189f, 141f));
			float num = vector.x + this.CJDDBGPKDLP / 1495f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1832f, 719f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1300f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1406f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1468f, 1769f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 990f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1578f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1207f, 744f + this.PBMAGEKDPLI / 926f, 1117f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1400f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 454f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(682f, 411f + this.PBMAGEKDPLI / 9f, 1485f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1112f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1609f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x003D3B7E File Offset: 0x003D1D7E
		private void PEJJBPAAKKE()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x003D3BA0 File Offset: 0x003D1DA0
		public void OnScreenSpaceCamera()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 0f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));
			float num = vector.x + this.CJDDBGPKDLP / 2f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 0f, 0f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 0f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 2f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 0f, 0f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 0f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 2f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(0f, 35f + this.PBMAGEKDPLI / 2f, 0f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 0f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 2f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(0f, 35f + this.PBMAGEKDPLI / 2f, 0f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 0f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 0f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x003D3E9A File Offset: 0x003D209A
		private void CCMPJCKFHIN()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.EFOPLJIKBCM();
			}
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x003D3EBC File Offset: 0x003D20BC
		public void ADMCHHPAPKI(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1525f, this.HGCMBKALPME.preferredHeight + 1595f);
				this.ICIFIEMNDAM();
			}
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x003D3495 File Offset: 0x003D1695
		public void FCALCJMHGOK()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x003D2567 File Offset: 0x003D0767
		public void HJCDMGGKBNE()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x003D3F1C File Offset: 0x003D211C
		public void KEKNHAAEPCJ()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 726f;
			this.FHHAGMOJHJO = 475f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x003D3F8C File Offset: 0x003D218C
		public void BODPLDJLFCF()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1602f;
			this.FHHAGMOJHJO = 1597f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x003D3FFC File Offset: 0x003D21FC
		public void OFFGFINPBMK()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1147f;
			this.FHHAGMOJHJO = 1174f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x003D4069 File Offset: 0x003D2269
		public void HJKLHJEDIPA()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x003D32F9 File Offset: 0x003D14F9
		public void GMIANNDNEHK()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x003D408C File Offset: 0x003D228C
		public void FODNDCOONIN(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 277f, this.HGCMBKALPME.preferredHeight + 1925f);
				this.AAEHNIIINMO();
			}
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void MEBKAPLODOJ()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x003D40EC File Offset: 0x003D22EC
		public void OLGJNDAJEBD(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1248f, this.HGCMBKALPME.preferredHeight + 899f);
				this.FMLBKJKADDC();
			}
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x003D4149 File Offset: 0x003D2349
		private void FixedUpdate()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x003D3379 File Offset: 0x003D1579
		public void NLMILEAIFHJ()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x003D1A5D File Offset: 0x003CFC5D
		private void NLNMGNBNNAO()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.EFOPLJIKBCM();
			}
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x003D4168 File Offset: 0x003D2368
		public void DBODOKLKNFB(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 807f, this.HGCMBKALPME.preferredHeight + 596f);
				this.FCMOEMIJJKK();
			}
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x003D3B7E File Offset: 0x003D1D7E
		private void PNLDPCGGNGH()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x003D41C8 File Offset: 0x003D23C8
		public void JGKNMAPODBN(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 385f, this.HGCMBKALPME.preferredHeight + 1381f);
				this.CJMLHADMDCK();
			}
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x003D4228 File Offset: 0x003D2428
		public void GDKDIEKHEAC(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 611f, this.HGCMBKALPME.preferredHeight + 19f);
				this.MEGHEDOPDHE();
			}
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x003D4288 File Offset: 0x003D2488
		public void FMAKOFPNPAA(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1514f, this.HGCMBKALPME.preferredHeight + 35f);
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x003D42E8 File Offset: 0x003D24E8
		public void JNBMKLFJCEM()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 73f;
			this.FHHAGMOJHJO = 12f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x003D4358 File Offset: 0x003D2558
		public void AIMEDGAFPAL()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 223f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[0];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1154f, 4f, 181f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(904f, 1396f, 1089f));
			float num = vector.x + this.CJDDBGPKDLP / 1714f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 502f, 300f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1880f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1645f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 526f, 1954f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 1710f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1368f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(58f, 735f + this.PBMAGEKDPLI / 827f, 896f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1135f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1299f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1706f, 198f + this.PBMAGEKDPLI / 1210f, 1341f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 993f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 297f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x003D4654 File Offset: 0x003D2854
		public void LJEFMGOBKGE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1891f;
			this.FHHAGMOJHJO = 837f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x003D46C4 File Offset: 0x003D28C4
		public void CPFJFIBMEOK()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1310f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1706f, 1154f, 1887f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(432f, 1217f, 1809f));
			float num = vector.x + this.CJDDBGPKDLP / 566f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 458f, 392f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 604f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1685f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 427f, 160f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 501f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 937f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(622f, 1140f + this.PBMAGEKDPLI / 123f, 1172f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1347f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1851f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1191f, 1015f + this.PBMAGEKDPLI / 945f, 1939f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1372f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 67f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x003D2567 File Offset: 0x003D0767
		public void BLOPIBEMDOO()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x003D49C0 File Offset: 0x003D2BC0
		public void JNIPABEGJND()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 778f;
			this.FHHAGMOJHJO = 592f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void OJEBAJNOLJC()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x003D4A30 File Offset: 0x003D2C30
		public void DHNANELONED()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1657f;
			this.FHHAGMOJHJO = 1316f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x003D4AA0 File Offset: 0x003D2CA0
		public void HLDALGBPALG()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 35f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1976f, 502f, 936f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(596f, 143f, 1461f));
			float num = vector.x + this.CJDDBGPKDLP / 1681f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1787f, 1143f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1360f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 676f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1372f, 1634f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 214f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 790f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(52f, 116f + this.PBMAGEKDPLI / 490f, 163f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1487f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 858f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1070f, 493f + this.PBMAGEKDPLI / 276f, 997f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1857f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 630f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x003D4D9A File Offset: 0x003D2F9A
		private void LBEDBOPGPBA()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.FCMOEMIJJKK();
			}
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x003D3495 File Offset: 0x003D1695
		public void CFAHKPOMNLF()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x003D4DBC File Offset: 0x003D2FBC
		public void MJAEJKDNFMD()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 679f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1667f, 1683f, 353f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(466f, 201f, 838f));
			float num = vector.x + this.CJDDBGPKDLP / 444f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1051f, 669f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1027f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1731f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1727f, 42f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 912f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1044f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(150f, 1807f + this.PBMAGEKDPLI / 133f, 511f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1946f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 760f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1390f, 1016f + this.PBMAGEKDPLI / 1953f, 778f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1122f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1993f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x003D3379 File Offset: 0x003D1579
		public void EEJFFOPGCPB()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x003D50B8 File Offset: 0x003D32B8
		public void PPCGJBIIFAO()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 1092f;
			this.FHHAGMOJHJO = 184f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x003D2529 File Offset: 0x003D0729
		private void LBBBICDEPHA()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.IJCAIPKFHFC();
			}
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x003D5128 File Offset: 0x003D3328
		public void CHPHJEBAABK()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 90f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(314f, 295f, 1851f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1896f, 1213f, 683f));
			float num = vector.x + this.CJDDBGPKDLP / 997f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 772f, 1793f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1021f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 4f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1586f, 1922f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 1953f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1953f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(1488f, 1798f + this.PBMAGEKDPLI / 288f, 802f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1919f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1345f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1607f, 1450f + this.PBMAGEKDPLI / 1343f, 601f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1106f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 33f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x003D5424 File Offset: 0x003D3624
		public void FNDBDABPAMH()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 722f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(201f, 1487f, 427f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1317f, 612f, 1545f));
			float num = vector.x + this.CJDDBGPKDLP / 1973f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1390f, 1245f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 744f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 1772f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1050f, 249f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 240f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 133f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(660f, 421f + this.PBMAGEKDPLI / 233f, 1099f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 936f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1419f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1691f, 1526f + this.PBMAGEKDPLI / 979f, 1923f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 301f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1141f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void IGEGIDEMNFG()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x003D5720 File Offset: 0x003D3920
		public void KAMMKPFNJJF()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 617f;
			this.FHHAGMOJHJO = 1983f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x003D5790 File Offset: 0x003D3990
		public void FMLBKJKADDC()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 110f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1906f, 966f, 195f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(662f, 1575f, 522f));
			float num = vector.x + this.CJDDBGPKDLP / 519f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1195f, 582f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 666f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 272f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1591f, 520f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 1785f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 492f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(277f, 691f + this.PBMAGEKDPLI / 1986f, 1659f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 348f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 1183f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(1391f, 36f + this.PBMAGEKDPLI / 785f, 1011f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 901f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 932f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = false;
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x003D5A8C File Offset: 0x003D3C8C
		public void Awake()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 0f;
			this.FHHAGMOJHJO = -30f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x003D5AFC File Offset: 0x003D3CFC
		public void AMCPIEINNBO(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 520f, this.HGCMBKALPME.preferredHeight + 1561f);
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void DMDHNJPDJJK()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x003D5B59 File Offset: 0x003D3D59
		public void FLIHDHGJJPF()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x003D5B7A File Offset: 0x003D3D7A
		private void FNALDLBGCJA()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.AHCALFOCHFE();
			}
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x003D2567 File Offset: 0x003D0767
		public void AMCLOIDEKGF()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x003D5B99 File Offset: 0x003D3D99
		private void HEPPILHCKJC()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.CBPNKOAKCAI();
			}
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x003D5BB8 File Offset: 0x003D3DB8
		public void IAHAPOKAJGM()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1820f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[1];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1098f, 765f, 916f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(1401f, 1884f, 580f));
			float num = vector.x + this.CJDDBGPKDLP / 187f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1043f, 564f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1344f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 53f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 1332f, 1494f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 823f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 102f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(14f, 129f + this.PBMAGEKDPLI / 1138f, 1357f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 611f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 601f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(698f, 1938f + this.PBMAGEKDPLI / 884f, 1567f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1506f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 674f);
			base.gameObject.SetActive(true);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x003D4069 File Offset: 0x003D2269
		public void PGKLJEGOOKJ()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x003D3379 File Offset: 0x003D1579
		public void ENPHOEJPAPH()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x003D5EB4 File Offset: 0x003D40B4
		public void CFEDCGINIFP(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 1349f, this.HGCMBKALPME.preferredHeight + 115f);
				this.PKCCCNMBOCF();
			}
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x003D5F14 File Offset: 0x003D4114
		public void HCNECNPPEKA()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1876f;
			this.FHHAGMOJHJO = 552f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x003D32F9 File Offset: 0x003D14F9
		public void OKDGGFNIFCI()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x003D5F84 File Offset: 0x003D4184
		public void DAHIMKKFNPH()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 368f;
			this.FHHAGMOJHJO = 504f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x003D3495 File Offset: 0x003D1695
		public void HPGCALOCMMC()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x003D5FF1 File Offset: 0x003D41F1
		private void EKECFMONIPL()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.CJMLHADMDCK();
			}
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x003D4069 File Offset: 0x003D2269
		public void HideTooltip()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceCamera)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x003D6010 File Offset: 0x003D4210
		public void IDOJLLNALPD(string KPMIEBJLLFE)
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.HGCMBKALPME.text = KPMIEBJLLFE;
				this.IHOLCKOEPAP.sizeDelta = new Vector2(this.HGCMBKALPME.preferredWidth + 394f, this.HGCMBKALPME.preferredHeight + 878f);
				this.CBPNKOAKCAI();
			}
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x003D5B59 File Offset: 0x003D3D59
		public void DLCJBOLOLNE()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x003D606D File Offset: 0x003D426D
		private void FPFPBEEDGBP()
		{
			if (this.JNKBGLEGOFD && this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				this.JFAHFAIEPLG();
			}
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x003D608C File Offset: 0x003D428C
		public void CBKCKDFLEEJ()
		{
			Vector3 position = this.CAMPLBLPNLM.ScreenToViewportPoint(Input.mousePosition - new Vector3(this.JAEJOBOKKNA, this.FHHAGMOJHJO, 1377f));
			Vector3 vector = this.CAMPLBLPNLM.ViewportToWorldPoint(position);
			this.CJDDBGPKDLP = this.IHOLCKOEPAP.sizeDelta[1];
			this.PBMAGEKDPLI = this.IHOLCKOEPAP.sizeDelta[0];
			Vector3 vector2 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(979f, 730f, 450f));
			Vector3 vector3 = this.CAMPLBLPNLM.ViewportToWorldPoint(new Vector3(923f, 1430f, 680f));
			float num = vector.x + this.CJDDBGPKDLP / 439f;
			if (num > vector3.x)
			{
				Vector3 vector4 = new Vector3(num - vector3.x, 1716f, 1600f);
				Vector3 position2 = new Vector3(vector.x - vector4.x, position.y, 1398f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position2).x;
			}
			num = vector.x - this.CJDDBGPKDLP / 360f;
			if (num < vector2.x)
			{
				Vector3 vector5 = new Vector3(vector2.x - num, 120f, 1891f);
				Vector3 position3 = new Vector3(vector.x + vector5.x, position.y, 231f);
				position.x = this.CAMPLBLPNLM.WorldToViewportPoint(position3).x;
			}
			num = vector.y + this.PBMAGEKDPLI / 1677f;
			if (num > vector3.y)
			{
				Vector3 vector6 = new Vector3(271f, 1752f + this.PBMAGEKDPLI / 834f, 1036f);
				Vector3 position4 = new Vector3(position.x, vector.y - vector6.y, 1162f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position4).y;
			}
			num = vector.y - this.PBMAGEKDPLI / 753f;
			if (num < vector2.y)
			{
				Vector3 vector7 = new Vector3(278f, 142f + this.PBMAGEKDPLI / 808f, 565f);
				Vector3 position5 = new Vector3(position.x, vector.y + vector7.y, 1029f);
				position.y = this.CAMPLBLPNLM.WorldToViewportPoint(position5).y;
			}
			base.transform.position = new Vector3(vector.x, vector.y, 1233f);
			base.gameObject.SetActive(false);
			this.JNKBGLEGOFD = true;
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x003D6388 File Offset: 0x003D4588
		public void KGMCGGIEPDE()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = false;
			this.JAEJOBOKKNA = 1105f;
			this.FHHAGMOJHJO = 493f;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A380 RID: 41856 RVA: 0x003D3379 File Offset: 0x003D1579
		public void NPIMJLPHDHH()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(true);
				this.JNKBGLEGOFD = false;
			}
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x003D63F8 File Offset: 0x003D45F8
		public void GBNOIKAPBBO()
		{
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.CAMPLBLPNLM = componentInParent.worldCamera;
			this.FLCNIDLCLAH = componentInParent.renderMode;
			this.IHOLCKOEPAP = base.GetComponent<RectTransform>();
			this.HGCMBKALPME = base.GetComponentInChildren<Text>();
			this.JNKBGLEGOFD = true;
			this.JAEJOBOKKNA = 236f;
			this.FHHAGMOJHJO = 669f;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x003D19CC File Offset: 0x003CFBCC
		public void ANHJNDMOHDL()
		{
			if (this.FLCNIDLCLAH == RenderMode.ScreenSpaceOverlay)
			{
				base.gameObject.SetActive(false);
				this.JNKBGLEGOFD = true;
			}
		}

		// Token: 0x04001274 RID: 4724
		private Text HGCMBKALPME;

		// Token: 0x04001275 RID: 4725
		private RectTransform IHOLCKOEPAP;

		// Token: 0x04001276 RID: 4726
		private bool JNKBGLEGOFD;

		// Token: 0x04001277 RID: 4727
		private float CJDDBGPKDLP;

		// Token: 0x04001278 RID: 4728
		private float PBMAGEKDPLI;

		// Token: 0x04001279 RID: 4729
		private float FHHAGMOJHJO;

		// Token: 0x0400127A RID: 4730
		private float JAEJOBOKKNA;

		// Token: 0x0400127B RID: 4731
		private RenderMode FLCNIDLCLAH;

		// Token: 0x0400127C RID: 4732
		private Camera CAMPLBLPNLM;
	}
}
