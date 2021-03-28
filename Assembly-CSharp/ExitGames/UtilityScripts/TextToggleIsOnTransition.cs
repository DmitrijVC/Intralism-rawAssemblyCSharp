using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	// Token: 0x02000369 RID: 873
	[RequireComponent(typeof(Text))]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		// Token: 0x0600C2DF RID: 49887 RVA: 0x0046E174 File Offset: 0x0046C374
		public void OnEnable()
		{
			this._text = base.GetComponent<Text>();
			this.toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x0046E19E File Offset: 0x0046C39E
		public void OnDisable()
		{
			this.toggle.onValueChanged.RemoveListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x0600C2E1 RID: 49889 RVA: 0x0046E1BC File Offset: 0x0046C3BC
		public void OnValueChanged(bool isOn)
		{
			this._text.color = ((!isOn) ? ((!this.isHover) ? this.NormalOffColor : this.NormalOnColor) : ((!this.isHover) ? this.HoverOffColor : this.HoverOnColor));
		}

		// Token: 0x0600C2E2 RID: 49890 RVA: 0x0046E217 File Offset: 0x0046C417
		public void OnPointerEnter(PointerEventData eventData)
		{
			this.isHover = true;
			this._text.color = ((!this.toggle.isOn) ? this.HoverOffColor : this.HoverOnColor);
		}

		// Token: 0x0600C2E3 RID: 49891 RVA: 0x0046E24C File Offset: 0x0046C44C
		public void OnPointerExit(PointerEventData eventData)
		{
			this.isHover = false;
			this._text.color = ((!this.toggle.isOn) ? this.NormalOffColor : this.NormalOnColor);
		}

		// Token: 0x04001694 RID: 5780
		public Toggle toggle;

		// Token: 0x04001695 RID: 5781
		private Text _text;

		// Token: 0x04001696 RID: 5782
		public Color NormalOnColor = Color.white;

		// Token: 0x04001697 RID: 5783
		public Color NormalOffColor = Color.black;

		// Token: 0x04001698 RID: 5784
		public Color HoverOnColor = Color.black;

		// Token: 0x04001699 RID: 5785
		public Color HoverOffColor = Color.black;

		// Token: 0x0400169A RID: 5786
		private bool isHover;
	}
}
