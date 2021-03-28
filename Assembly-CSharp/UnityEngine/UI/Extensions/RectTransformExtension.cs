using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002CF RID: 719
	public static class RectTransformExtension
	{
		// Token: 0x0600AAA2 RID: 43682 RVA: 0x003F5B5C File Offset: 0x003F3D5C
		public static Vector2 switchToRectTransform(this RectTransform BHNGOLDNELC, RectTransform HANEOLNMOEF)
		{
			Vector2 b = new Vector2(BHNGOLDNELC.rect.width * BHNGOLDNELC.pivot.x + BHNGOLDNELC.rect.xMin, BHNGOLDNELC.rect.height * BHNGOLDNELC.pivot.y + BHNGOLDNELC.rect.yMin);
			Vector2 vector = RectTransformUtility.WorldToScreenPoint(null, BHNGOLDNELC.position);
			vector += b;
			Vector2 b2;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(HANEOLNMOEF, vector, null, out b2);
			Vector2 b3 = new Vector2(HANEOLNMOEF.rect.width * HANEOLNMOEF.pivot.x + HANEOLNMOEF.rect.xMin, HANEOLNMOEF.rect.height * HANEOLNMOEF.pivot.y + HANEOLNMOEF.rect.yMin);
			return HANEOLNMOEF.anchoredPosition + b2 - b3;
		}
	}
}
