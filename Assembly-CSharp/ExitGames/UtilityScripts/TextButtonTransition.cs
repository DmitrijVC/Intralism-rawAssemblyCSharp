using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ExitGames.UtilityScripts
{
	// Token: 0x02000368 RID: 872
	[RequireComponent(typeof(Text))]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
	{
		// Token: 0x0600C2DB RID: 49883 RVA: 0x0046E10C File Offset: 0x0046C30C
		public void Awake()
		{
			this._text = base.GetComponent<Text>();
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x0046E11A File Offset: 0x0046C31A
		public void OnPointerEnter(PointerEventData eventData)
		{
			this._text.color = this.HoverColor;
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x0046E12D File Offset: 0x0046C32D
		public void OnPointerExit(PointerEventData eventData)
		{
			this._text.color = this.NormalColor;
		}

		// Token: 0x04001691 RID: 5777
		private Text _text;

		// Token: 0x04001692 RID: 5778
		public Color NormalColor = Color.white;

		// Token: 0x04001693 RID: 5779
		public Color HoverColor = Color.black;
	}
}
