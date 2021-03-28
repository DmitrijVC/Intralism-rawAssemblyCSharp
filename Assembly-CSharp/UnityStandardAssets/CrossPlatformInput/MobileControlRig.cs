using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x0200018A RID: 394
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		// Token: 0x0600734C RID: 29516 RVA: 0x00238BE8 File Offset: 0x00236DE8
		private void IIBHHALOJOD(bool CKALCHJAFBE)
		{
			IEnumerator enumerator = base.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(CKALCHJAFBE);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00238C54 File Offset: 0x00236E54
		private void CIPKEPDELJB()
		{
			EventSystem x = UnityEngine.Object.FindObjectOfType<EventSystem>();
			if (x == null)
			{
				GameObject gameObject = new GameObject("_TimeX");
				gameObject.AddComponent<EventSystem>();
				gameObject.AddComponent<StandaloneInputModule>();
			}
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x00238C8C File Offset: 0x00236E8C
		private void OOBIMFILNED()
		{
			this.CLPAPEODCPD();
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00238C94 File Offset: 0x00236E94
		private void OnEnable()
		{
			this.NOOICGOMHDK();
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x00238C9C File Offset: 0x00236E9C
		private void Start()
		{
			EventSystem x = UnityEngine.Object.FindObjectOfType<EventSystem>();
			if (x == null)
			{
				GameObject gameObject = new GameObject("EventSystem");
				gameObject.AddComponent<EventSystem>();
				gameObject.AddComponent<StandaloneInputModule>();
			}
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x00238CD4 File Offset: 0x00236ED4
		private void IBEAPBDAOCC()
		{
			this.HGEGHEIPHKD();
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x00238CDC File Offset: 0x00236EDC
		private void NMACNDPFJKJ()
		{
			this.IIBHHALOJOD(false);
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x00238CE8 File Offset: 0x00236EE8
		private void CKAFBINJIJD(bool CKALCHJAFBE)
		{
			IEnumerator enumerator = base.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(CKALCHJAFBE);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x00238D54 File Offset: 0x00236F54
		private void HGEGHEIPHKD()
		{
			this.KHOHPPFDCCP(false);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00238D5D File Offset: 0x00236F5D
		private void CLPAPEODCPD()
		{
			this.KHOHPPFDCCP(true);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x00238D68 File Offset: 0x00236F68
		private void NCNPAKFAFOE()
		{
			EventSystem x = UnityEngine.Object.FindObjectOfType<EventSystem>();
			if (x == null)
			{
				GameObject gameObject = new GameObject("_ProjInfo");
				gameObject.AddComponent<EventSystem>();
				gameObject.AddComponent<StandaloneInputModule>();
			}
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00238D54 File Offset: 0x00236F54
		private void NOOICGOMHDK()
		{
			this.KHOHPPFDCCP(false);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x00238DA0 File Offset: 0x00236FA0
		private void BOFNFKNMPBI(bool CKALCHJAFBE)
		{
			IEnumerator enumerator = base.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(CKALCHJAFBE);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x00238E0C File Offset: 0x0023700C
		private void KHOHPPFDCCP(bool CKALCHJAFBE)
		{
			IEnumerator enumerator = base.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(CKALCHJAFBE);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x00238CD4 File Offset: 0x00236ED4
		private void IFKNIHJCAFB()
		{
			this.HGEGHEIPHKD();
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x00238E78 File Offset: 0x00237078
		private void KDMANOEMOCA()
		{
			EventSystem x = UnityEngine.Object.FindObjectOfType<EventSystem>();
			if (x == null)
			{
				GameObject gameObject = new GameObject("ServerSettings: ");
				gameObject.AddComponent<EventSystem>();
				gameObject.AddComponent<StandaloneInputModule>();
			}
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x00238CD4 File Offset: 0x00236ED4
		private void JCDPMLPNOOC()
		{
			this.HGEGHEIPHKD();
		}
	}
}
