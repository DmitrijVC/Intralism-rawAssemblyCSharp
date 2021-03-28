using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002B3 RID: 691
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("UI/Extensions/Scrollrect Conflict Manager")]
	public class ScrollConflictManager : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600A65E RID: 42590 RVA: 0x003DF6D4 File Offset: 0x003DD8D4
		private void IIPMEPPIFCK()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("FrostCanvas");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("_ReflectionTexture2");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("Value");
			}
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void BPFLEOPNLJK(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void NODMNIIGNBI(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void EDOEOAMHECF(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x003DF775 File Offset: 0x003DD975
		public void KJHPAKNENEE(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnEndDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x003DF7A4 File Offset: 0x003DD9A4
		public void JFMLICLMLJH(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = false;
					this.IABMMMBOABO.enabled = true;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = false;
				this.IABMMMBOABO.enabled = false;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x003DF858 File Offset: 0x003DDA58
		private void MMPOJCFOGJJ()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("ReconnectToMaster() with AuthValues == null is not correct!");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("PlayButton");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("IntraSig");
			}
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x003DF8E0 File Offset: 0x003DDAE0
		private void EPCGHAAONLN()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("y");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("Parent object ID. Case-Sensitive");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("maps.");
			}
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void ABIGIFHIJLH(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x003DF968 File Offset: 0x003DDB68
		public void CNGGFDHOLOA(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = false;
					this.IABMMMBOABO.enabled = true;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = false;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x003DFA1C File Offset: 0x003DDC1C
		private void PPCGJBIIFAO()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("Sending RPC \"");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("<scene_name> or <id>");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("RemoveEnvironmentObject");
			}
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x003DFAA4 File Offset: 0x003DDCA4
		public void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = true;
					this.IABMMMBOABO.enabled = false;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = false;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void NNFOLDFHNAE(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x003DFB58 File Offset: 0x003DDD58
		private void BFIOIDMHPPL()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("[MapsData] Installed: ");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("CameraFilterPack/OldFilm_Cutting2");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("ViewMenu");
			}
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void NFBHNMNAOLO(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x003DF775 File Offset: 0x003DD975
		public void CHFGACLKMIG(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnEndDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A66F RID: 42607 RVA: 0x003DFBE0 File Offset: 0x003DDDE0
		public void IFGCHPBIBOL(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = false;
					this.IABMMMBOABO.enabled = true;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = false;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x003DFC94 File Offset: 0x003DDE94
		public void COMGOCAKBLD(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = false;
					this.IABMMMBOABO.enabled = false;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = false;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x003DFD45 File Offset: 0x003DDF45
		public void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.IDBNOMMMDAH = false;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnEndDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void OnDrag(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A673 RID: 42611 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void PHMLOFLENEF(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x003DFD74 File Offset: 0x003DDF74
		private void FMAFBLKAJDF()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("ERROR: Preview file name in modName.workshop.json doesn't match any file");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("ResourceIDInputField");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("shader.frost");
			}
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x003DFDFC File Offset: 0x003DDFFC
		private void Awake()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("You have added the SecondScrollRect to a scroll view that already has both directions selected");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("The other scroll rect doesnt support scrolling horizontally");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("The other scroll rect doesnt support scrolling vertically");
			}
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void GIKAADBPOKK(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void PPJOEEEOEKK(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x003DFE84 File Offset: 0x003DE084
		public void PPGKDDENPLF(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = false;
					this.IABMMMBOABO.enabled = false;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = false;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void LPENBOCGNJK(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x003DFF38 File Offset: 0x003DE138
		private void NLNAJMCBNDC()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log(".completedMaps");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("curScn");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("_SecondTex");
			}
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void KOGFFLNAJGB(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void DCDNJADEHFA(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x003DFFC0 File Offset: 0x003DE1C0
		private void LOMHIIKFFEP()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("_Distortion");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("Spawn new environment object (sun, satellite etc) and sets its id");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("No valid adaptive tonemapper type found!");
			}
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x003E0048 File Offset: 0x003DE248
		private void BMAGFLLGDPJ()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("SetCrosshairColor");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("Connected to gameserver.");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("menu.playedsolo");
			}
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x003DF775 File Offset: 0x003DD975
		public void ANHIGNCMLEE(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnEndDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x003E00D0 File Offset: 0x003DE2D0
		private void AJIKPEIGACI()
		{
			this.IABMMMBOABO = base.GetComponent<ScrollRect>();
			this.GGFBEGDGCIK = this.IABMMMBOABO.vertical;
			if (this.GGFBEGDGCIK)
			{
				if (this.IABMMMBOABO.horizontal)
				{
					Debug.Log("LevelInfoInputField");
				}
				if (!this.ParentScrollRect.horizontal)
				{
					Debug.Log("Default UI Material");
				}
			}
			else if (!this.ParentScrollRect.vertical)
			{
				Debug.Log("Source directory does not exist or could not be found: ");
			}
		}

		// Token: 0x0600A681 RID: 42625 RVA: 0x003DF75C File Offset: 0x003DD95C
		public void JPHMFELEOND(PointerEventData OLIIPKODDIN)
		{
			if (this.IDBNOMMMDAH)
			{
				this.ParentScrollRect.OnDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x0600A682 RID: 42626 RVA: 0x003E0158 File Offset: 0x003DE358
		public void FPFOHNHFKGM(PointerEventData OLIIPKODDIN)
		{
			float num = Mathf.Abs(OLIIPKODDIN.position.x - OLIIPKODDIN.pressPosition.x);
			float num2 = Mathf.Abs(OLIIPKODDIN.position.y - OLIIPKODDIN.pressPosition.y);
			if (this.GGFBEGDGCIK)
			{
				if (num > num2)
				{
					this.IDBNOMMMDAH = true;
					this.IABMMMBOABO.enabled = true;
					this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
				}
			}
			else if (num2 > num)
			{
				this.IDBNOMMMDAH = true;
				this.IABMMMBOABO.enabled = true;
				this.ParentScrollRect.OnBeginDrag(OLIIPKODDIN);
			}
		}

		// Token: 0x040012AA RID: 4778
		public ScrollRect ParentScrollRect;

		// Token: 0x040012AB RID: 4779
		private ScrollRect IABMMMBOABO;

		// Token: 0x040012AC RID: 4780
		private bool IDBNOMMMDAH;

		// Token: 0x040012AD RID: 4781
		private bool GGFBEGDGCIK;
	}
}
