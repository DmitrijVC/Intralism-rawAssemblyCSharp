using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000264 RID: 612
	[AddComponentMenu("UI/Extensions/Raycast Mask")]
	[RequireComponent(typeof(Image))]
	[RequireComponent(typeof(RectTransform))]
	public class RaycastMask : MonoBehaviour, ICanvasRaycastFilter
	{
		// Token: 0x06009244 RID: 37444 RVA: 0x00334B44 File Offset: 0x00332D44
		public bool PHPKDFIGIOP(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 83f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009245 RID: 37445 RVA: 0x00334E60 File Offset: 0x00333060
		public bool NANGDCEFJNI(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1906f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("?");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009246 RID: 37446 RVA: 0x0033517C File Offset: 0x0033337C
		public bool PBACMJCLKPJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1003f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value8");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009247 RID: 37447 RVA: 0x00335498 File Offset: 0x00333698
		private void JHANGPCOCIG()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009248 RID: 37448 RVA: 0x00335498 File Offset: 0x00333698
		private void HDMDKOKOOJC()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009249 RID: 37449 RVA: 0x00335498 File Offset: 0x00333698
		private void PDHKMDBNGGN()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600924A RID: 37450 RVA: 0x00335498 File Offset: 0x00333698
		private void PMPKMGKAAJH()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600924B RID: 37451 RVA: 0x003354A8 File Offset: 0x003336A8
		public bool AKOONOPLKKC(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1381f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_VignetteTex");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600924C RID: 37452 RVA: 0x003357C4 File Offset: 0x003339C4
		public bool AJLIMCOLOMG(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1380f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value2");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x00335498 File Offset: 0x00333698
		private void KCCIEMBMOBA()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x00335AE0 File Offset: 0x00333CE0
		public bool BPHBOCGJJON(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 688f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value4");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x00335DFC File Offset: 0x00333FFC
		public bool OOLMNOBFJBJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 342f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Out {0,4} | In {1,4} | Sum {2,4}");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x00336118 File Offset: 0x00334318
		public bool EHKBABAPCDJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 139f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("PopulateMapsList");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009251 RID: 37457 RVA: 0x00336434 File Offset: 0x00334634
		public bool NNGDLANIADP(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 331f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("maps.");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x00336750 File Offset: 0x00334950
		public bool EFELEICNOLK(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1027f);
			}
			catch (UnityException)
			{
				Debug.LogWarning(": ");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x00336A6C File Offset: 0x00334C6C
		public bool FGAFFIIFAID(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 928f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_BorderColor");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x00335498 File Offset: 0x00333698
		private void FJNCHGLIEMA()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00336D88 File Offset: 0x00334F88
		public bool DPFIBPGEBCA(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1596f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("mapselector.orderby");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x003370A4 File Offset: 0x003352A4
		public bool IsRaycastLocationValid(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 0f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009257 RID: 37463 RVA: 0x003373C0 File Offset: 0x003355C0
		public bool AONIPFDKNGI(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1862f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("CheckpointsScoreText");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x003376DC File Offset: 0x003358DC
		public bool GDONHNFFBOP(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1061f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("settings.arcshitsoundtimedelay");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x00335498 File Offset: 0x00333698
		private void ILCFPCIPENO()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x003379F8 File Offset: 0x00335BF8
		public bool PMIICIMPEJK(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 858f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("menu.playedsolo");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600925B RID: 37467 RVA: 0x00335498 File Offset: 0x00333698
		private void DKGBFNCOAEO()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x00337D14 File Offset: 0x00335F14
		public bool KPPIPPCJPFC(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 637f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_TimeX");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x00335498 File Offset: 0x00333698
		private void JOPCCCCHNLI()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600925E RID: 37470 RVA: 0x00338030 File Offset: 0x00336230
		public bool MCLGPJHOOLA(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 448f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("CameraFilterPack_Atmosphere_Rain_FX");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x0033834C File Offset: 0x0033654C
		public bool PGFHMDEIAPB(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 938f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Right Stick Click");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x00335498 File Offset: 0x00333698
		private void MKIMDFLBFOM()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x00338668 File Offset: 0x00336868
		public bool DGNOENMBMDM(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 350f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Gain");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009262 RID: 37474 RVA: 0x00338984 File Offset: 0x00336B84
		public bool EKLPFOAKOEK(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 128f);
			}
			catch (UnityException)
			{
				Debug.LogWarning(" ");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009263 RID: 37475 RVA: 0x00338CA0 File Offset: 0x00336EA0
		public bool FMDCAFLIFMC(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1878f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Red_B");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x00338FBC File Offset: 0x003371BC
		public bool HCPIFKGKGIJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 769f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("value");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x00335498 File Offset: 0x00333698
		private void FBPHNEJBDJN()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00335498 File Offset: 0x00333698
		private void JMEOGJHCONJ()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x003392D8 File Offset: 0x003374D8
		public bool PNIFOKGIPNP(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 806f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("21x3");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00335498 File Offset: 0x00333698
		private void LIBGAKMKHJJ()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x00335498 File Offset: 0x00333698
		private void ANCKKLFPGDI()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x00335498 File Offset: 0x00333698
		private void IDJKNBDKHBD()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x003395F4 File Offset: 0x003377F4
		public bool NKOHELDDOOO(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 525f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Save the map before exiting?");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x00339910 File Offset: 0x00337B10
		public bool BEFBKEBGEEH(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 805f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_EmissionColor");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x00335498 File Offset: 0x00333698
		private void NNFMIAFHMJM()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x00339C2C File Offset: 0x00337E2C
		public bool PEENGKJOBPO(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 52f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Texture2");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x00339F48 File Offset: 0x00338148
		public bool PBIKBKGNJMA(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1862f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("StartButton");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x0033A264 File Offset: 0x00338464
		public bool JKDEAFGCEAE(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1066f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Change Note:");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x0033A580 File Offset: 0x00338780
		public bool CIFMIEEHNJH(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("note.6");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009273 RID: 37491 RVA: 0x0033A89C File Offset: 0x00338A9C
		public bool MHLDBPMEHIK(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 50f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value12");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009274 RID: 37492 RVA: 0x0033ABB8 File Offset: 0x00338DB8
		public bool BEMMPILEPNF(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 345f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_TimeX");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x0033AED4 File Offset: 0x003390D4
		public bool HAKLEBNFNOJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 984f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x0033B1F0 File Offset: 0x003393F0
		public bool HPFEMGHINDL(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 476f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Distance");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x0033B50C File Offset: 0x0033970C
		public bool EHNDEPPAGPM(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 489f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("Saved Game: ");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x0033B828 File Offset: 0x00339A28
		public bool PDHFMJMLNKE(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1707f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("workshop.");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x00335498 File Offset: 0x00333698
		private void FNCDAPDOBBI()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x0033BB44 File Offset: 0x00339D44
		public bool AAGEKLEJKEG(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 435f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("maps.");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x00335498 File Offset: 0x00333698
		private void DIPDEHOOBPG()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x0033BE60 File Offset: 0x0033A060
		public bool OODFEPELNPA(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 607f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_ScreenResolution");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x00335498 File Offset: 0x00333698
		private void Start()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x00335498 File Offset: 0x00333698
		private void BEBNOKFLJPH()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x00335498 File Offset: 0x00333698
		private void MGMAOBPPOBJ()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x0033C17C File Offset: 0x0033A37C
		public bool EJABFDLFGEE(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 675f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_ScreenResolution");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x0033C498 File Offset: 0x0033A698
		public bool CEMNDCENBNF(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 3f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("#ok");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x0033C7B4 File Offset: 0x0033A9B4
		public bool BGMEGMDPBBD(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 762f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("BloodAlternative1");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00335498 File Offset: 0x00333698
		private void COIJKMKIEAK()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x00335498 File Offset: 0x00333698
		private void MMOKKAPFGAK()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x0033CAD0 File Offset: 0x0033ACD0
		public bool CPIBOHONBIJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 97f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("settings.enableranking");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x00335498 File Offset: 0x00333698
		private void FHPFJBFCOOF()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00335498 File Offset: 0x00333698
		private void DLBODOFAJGM()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00335498 File Offset: 0x00333698
		private void FLKEJJEGCFA()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x00335498 File Offset: 0x00333698
		private void KLILJHJNICK()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600928A RID: 37514 RVA: 0x0033CDEC File Offset: 0x0033AFEC
		public bool IOACONBJLIJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 150f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_DotSize");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00335498 File Offset: 0x00333698
		private void KDMANOEMOCA()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x0033D108 File Offset: 0x0033B308
		public bool KHNAMACGHKM(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1094f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("value");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x0033D424 File Offset: 0x0033B624
		public bool HJOOOPKGDCC(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1033f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("/");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x0033D740 File Offset: 0x0033B940
		public bool ONJLPKFNPJG(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1165f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x0033DA5C File Offset: 0x0033BC5C
		public bool APKFGDBFFBL(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 915f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("In Main Menu");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x0033DD78 File Offset: 0x0033BF78
		public bool ELLAGKBIDCD(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Simple)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1281f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("USE_DIAG_SEARCH");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x0033E094 File Offset: 0x0033C294
		public bool ODOIOCMJGGF(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1831f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("No Dispatcher exists in the scene. Actions will not be invoked!");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x0033E3B0 File Offset: 0x0033C5B0
		public bool GMHEPCHCFOJ(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 1072f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("' has been reset to the fault value");
				Object.Destroy(this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00335498 File Offset: 0x00333698
		private void NPLCENPNJBM()
		{
			this.BBEMBMEOCAI = base.GetComponent<Image>();
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x0033E6CC File Offset: 0x0033C8CC
		public bool LJDAEBHIJKO(Vector2 OKLIAJCEFIL, Camera FHEBFGGLJPA)
		{
			this.BIDJLEIPNNM = this.BBEMBMEOCAI.sprite;
			RectTransform rectTransform = (RectTransform)base.transform;
			Vector2 vector;
			RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)base.transform, OKLIAJCEFIL, FHEBFGGLJPA, out vector);
			Vector2 vector2 = new Vector2(vector.x + rectTransform.pivot.x * rectTransform.rect.width, vector.y + rectTransform.pivot.y * rectTransform.rect.height);
			Rect textureRect = this.BIDJLEIPNNM.textureRect;
			Rect rect = rectTransform.rect;
			Image.Type type = this.BBEMBMEOCAI.type;
			int x;
			int y;
			if (type != Image.Type.Sliced)
			{
				if (type != Image.Type.Simple)
				{
				}
				x = Mathf.FloorToInt(textureRect.x + textureRect.width * vector2.x / rect.width);
				y = Mathf.FloorToInt(textureRect.y + textureRect.height * vector2.y / rect.height);
			}
			else
			{
				Vector4 border = this.BIDJLEIPNNM.border;
				if (vector2.x < border.x)
				{
					x = Mathf.FloorToInt(textureRect.x + vector2.x);
				}
				else if (vector2.x > rect.width - border.z)
				{
					x = Mathf.FloorToInt(textureRect.x + textureRect.width - (rect.width - vector2.x));
				}
				else
				{
					x = Mathf.FloorToInt(textureRect.x + border.x + (vector2.x - border.x) / (rect.width - border.x - border.z) * (textureRect.width - border.x - border.z));
				}
				if (vector2.y < border.y)
				{
					y = Mathf.FloorToInt(textureRect.y + vector2.y);
				}
				else if (vector2.y > rect.height - border.w)
				{
					y = Mathf.FloorToInt(textureRect.y + textureRect.height - (rect.height - vector2.y));
				}
				else
				{
					y = Mathf.FloorToInt(textureRect.y + border.y + (vector2.y - border.y) / (rect.height - border.y - border.w) * (textureRect.height - border.y - border.w));
				}
			}
			bool result;
			try
			{
				result = (this.BIDJLEIPNNM.texture.GetPixel(x, y).a > 851f);
			}
			catch (UnityException)
			{
				Debug.LogWarning("_Value2");
				Object.Destroy(this);
				result = false;
			}
			return result;
		}

		// Token: 0x040010E0 RID: 4320
		private Image BBEMBMEOCAI;

		// Token: 0x040010E1 RID: 4321
		private Sprite BIDJLEIPNNM;
	}
}
