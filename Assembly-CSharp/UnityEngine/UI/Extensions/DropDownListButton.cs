using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000251 RID: 593
	[RequireComponent(typeof(RectTransform), typeof(Button))]
	public class DropDownListButton
	{
		// Token: 0x06008F77 RID: 36727 RVA: 0x00319EE4 File Offset: 0x003180E4
		public DropDownListButton(GameObject LHEIGNNIMAF)
		{
			this.gameobject = LHEIGNNIMAF;
			this.rectTransform = LHEIGNNIMAF.GetComponent<RectTransform>();
			this.btnImg = LHEIGNNIMAF.GetComponent<Image>();
			this.btn = LHEIGNNIMAF.GetComponent<Button>();
			this.txt = this.rectTransform.Find("Text").GetComponent<Text>();
			this.img = this.rectTransform.Find("Image").GetComponent<Image>();
		}

		// Token: 0x04001087 RID: 4231
		public RectTransform rectTransform;

		// Token: 0x04001088 RID: 4232
		public Button btn;

		// Token: 0x04001089 RID: 4233
		public Text txt;

		// Token: 0x0400108A RID: 4234
		public Image btnImg;

		// Token: 0x0400108B RID: 4235
		public Image img;

		// Token: 0x0400108C RID: 4236
		public GameObject gameobject;
	}
}
