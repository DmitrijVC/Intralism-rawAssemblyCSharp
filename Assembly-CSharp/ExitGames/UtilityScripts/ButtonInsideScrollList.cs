using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	// Token: 0x02000367 RID: 871
	public class ButtonInsideScrollList : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x0600C2D7 RID: 49879 RVA: 0x0046E087 File Offset: 0x0046C287
		private void Start()
		{
			this.scrollRect = base.GetComponentInParent<ScrollRect>();
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x0046E095 File Offset: 0x0046C295
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			if (this.scrollRect != null)
			{
				this.scrollRect.StopMovement();
				this.scrollRect.enabled = false;
			}
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x0046E0BF File Offset: 0x0046C2BF
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
			if (this.scrollRect != null && !this.scrollRect.enabled)
			{
				this.scrollRect.enabled = true;
			}
		}

		// Token: 0x04001690 RID: 5776
		private ScrollRect scrollRect;
	}
}
