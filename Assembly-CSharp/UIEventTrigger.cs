using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000474 RID: 1140
public class UIEventTrigger : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
{
	// Token: 0x060105DD RID: 67037 RVA: 0x005942C4 File Offset: 0x005924C4
	public void LNMLCNDAOPC(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x060105DE RID: 67038 RVA: 0x005942D1 File Offset: 0x005924D1
	public void OnPointerEnter(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerEnter.Invoke();
	}

	// Token: 0x060105DF RID: 67039 RVA: 0x005942DE File Offset: 0x005924DE
	public void OnSelect(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105E0 RID: 67040 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLIAEEMGBHN()
	{
	}

	// Token: 0x060105E1 RID: 67041 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060105E2 RID: 67042 RVA: 0x005942EB File Offset: 0x005924EB
	public void FPGBAKDMNFF(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerClick.Invoke();
	}

	// Token: 0x060105E3 RID: 67043 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060105E4 RID: 67044 RVA: 0x005942C4 File Offset: 0x005924C4
	public void MKFGJGKNDIB(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x060105E5 RID: 67045 RVA: 0x005942DE File Offset: 0x005924DE
	public void MDDELAOIKPD(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105E6 RID: 67046 RVA: 0x005942F8 File Offset: 0x005924F8
	public void OnDeselect(BaseEventData OLIIPKODDIN)
	{
		this.onDeselect.Invoke();
	}

	// Token: 0x060105E7 RID: 67047 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060105E8 RID: 67048 RVA: 0x005942D1 File Offset: 0x005924D1
	public void BDNEOOBFNBN(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerEnter.Invoke();
	}

	// Token: 0x060105E9 RID: 67049 RVA: 0x00594305 File Offset: 0x00592505
	public void ABKDPJJOEAK(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerUp.Invoke();
	}

	// Token: 0x060105EB RID: 67051 RVA: 0x005942EB File Offset: 0x005924EB
	public void NEJNJNBAKGG(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerClick.Invoke();
	}

	// Token: 0x060105EC RID: 67052 RVA: 0x005942F8 File Offset: 0x005924F8
	public void BLMBJDOCJEG(BaseEventData OLIIPKODDIN)
	{
		this.onDeselect.Invoke();
	}

	// Token: 0x060105ED RID: 67053 RVA: 0x00594305 File Offset: 0x00592505
	public void LFLIIDGPAJC(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerUp.Invoke();
	}

	// Token: 0x060105EE RID: 67054 RVA: 0x005942EB File Offset: 0x005924EB
	public void OnPointerClick(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerClick.Invoke();
	}

	// Token: 0x060105EF RID: 67055 RVA: 0x005942D1 File Offset: 0x005924D1
	public void LKEOEKONABE(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerEnter.Invoke();
	}

	// Token: 0x060105F0 RID: 67056 RVA: 0x00594312 File Offset: 0x00592512
	public void OPMBOIOMIMN(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerExit.Invoke();
	}

	// Token: 0x060105F1 RID: 67057 RVA: 0x005942D1 File Offset: 0x005924D1
	public void KPJKJNIDECJ(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerEnter.Invoke();
	}

	// Token: 0x060105F2 RID: 67058 RVA: 0x005942DE File Offset: 0x005924DE
	public void HPEKIOCMHCM(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105F3 RID: 67059 RVA: 0x005942C4 File Offset: 0x005924C4
	public void INKFELLKDFO(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x060105F4 RID: 67060 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDPIHMAACO()
	{
	}

	// Token: 0x060105F5 RID: 67061 RVA: 0x00594312 File Offset: 0x00592512
	public void OnPointerExit(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerExit.Invoke();
	}

	// Token: 0x060105F6 RID: 67062 RVA: 0x005942C4 File Offset: 0x005924C4
	public void PIPIDPPIJCF(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x060105F7 RID: 67063 RVA: 0x0002523B File Offset: 0x0002343B
	private void CCLNNLCOPBL()
	{
	}

	// Token: 0x060105F8 RID: 67064 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x060105F9 RID: 67065 RVA: 0x005942D1 File Offset: 0x005924D1
	public void KGFKGMLPFEC(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerEnter.Invoke();
	}

	// Token: 0x060105FA RID: 67066 RVA: 0x005942DE File Offset: 0x005924DE
	public void APIEEAJLPBO(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105FB RID: 67067 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060105FC RID: 67068 RVA: 0x005942DE File Offset: 0x005924DE
	public void OAOMDADPBCL(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105FD RID: 67069 RVA: 0x0002523B File Offset: 0x0002343B
	private void NPLCENPNJBM()
	{
	}

	// Token: 0x060105FE RID: 67070 RVA: 0x005942DE File Offset: 0x005924DE
	public void LBLPGKPCPAL(BaseEventData GIOOFMGDGNH)
	{
		this.onSelect.Invoke();
	}

	// Token: 0x060105FF RID: 67071 RVA: 0x005942C4 File Offset: 0x005924C4
	public void OnPointerDown(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x06010600 RID: 67072 RVA: 0x005942EB File Offset: 0x005924EB
	public void FHFNOPDMFEH(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerClick.Invoke();
	}

	// Token: 0x06010601 RID: 67073 RVA: 0x00594305 File Offset: 0x00592505
	public void OnPointerUp(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerUp.Invoke();
	}

	// Token: 0x06010602 RID: 67074 RVA: 0x005942C4 File Offset: 0x005924C4
	public void HDIFNFDNLDE(PointerEventData GIOOFMGDGNH)
	{
		this.onPointerDown.Invoke();
	}

	// Token: 0x04001CBA RID: 7354
	public UnityEvent onPointerEnter;

	// Token: 0x04001CBB RID: 7355
	public UnityEvent onPointerExit;

	// Token: 0x04001CBC RID: 7356
	public UnityEvent onPointerClick;

	// Token: 0x04001CBD RID: 7357
	public UnityEvent onPointerDown;

	// Token: 0x04001CBE RID: 7358
	public UnityEvent onPointerUp;

	// Token: 0x04001CBF RID: 7359
	public UnityEvent onSelect;

	// Token: 0x04001CC0 RID: 7360
	public UnityEvent onDeselect;
}
