using System;
using UnityEngine;

// Token: 0x0200015B RID: 347
[AddComponentMenu("Hard Shell Studios/Examples/Player Move")]
public class Player_Move : MonoBehaviour
{
	// Token: 0x0600677E RID: 26494 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void BEBNOKFLJPH()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600677F RID: 26495 RVA: 0x001F1B4C File Offset: 0x001EFD4C
	private void IDIIELPAMCJ()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("w", "player.circle", 1733f) + hardInput.PMJHMIKCPBI("PlayerBase_", 1103f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("mapselector.filter.favoriteonly", "offsets", 461f) + hardInput.GMNJKCNIPGD("curScn", 285f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA("Please define the RectTransform for the Center viewport of the scrollable area") && this.NAEONENECEC())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006780 RID: 26496 RVA: 0x001F1C3C File Offset: 0x001EFE3C
	private void IIFCIDDJHPM()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("CameraFilterPack/Distortion_Dream", "_Value", 1462f) + hardInput.PMJHMIKCPBI("_BlurRadius4", 373f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("0.00", "_Value4", 405f) + hardInput.GetAxis("_Value7", 181f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(": ") && this.PCKCJNKFAPF())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006781 RID: 26497 RVA: 0x001F1D2C File Offset: 0x001EFF2C
	private bool NAEONENECEC()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 0.1f);
	}

	// Token: 0x06006782 RID: 26498 RVA: 0x001F1DF4 File Offset: 0x001EFFF4
	private bool AHFGFIOCMJF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 694f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1617f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 867f);
	}

	// Token: 0x06006783 RID: 26499 RVA: 0x001F1EBC File Offset: 0x001F00BC
	private bool JLMPFNOJJOK()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 658f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 380f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 1652f);
	}

	// Token: 0x06006784 RID: 26500 RVA: 0x001F1F84 File Offset: 0x001F0184
	private void MAOCOEGAFND()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("_TimeX", "(from resources)", 1255f) + hardInput.GetAxis("achievements.21.completed.", 1469f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.DAKLFCPPJDB("sounds/no_hit", "CameraFilterPack/Blur_DitherOffset", 145f) + hardInput.GetAxis("SetSatelliteSensitivity", 41f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.AADFFLGEJPP("#") && this.NAEONENECEC())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006785 RID: 26501 RVA: 0x001F2074 File Offset: 0x001F0274
	private bool NANPNECJKMO()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1030f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 498f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 568f);
	}

	// Token: 0x06006786 RID: 26502 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void DIPDEHOOBPG()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06006787 RID: 26503 RVA: 0x001F213C File Offset: 0x001F033C
	private void JAAJECBCCFM()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("_Value", "ExitButton", 1004f) + hardInput.GetAxis("[PlayerController] ", 568f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("_ScreenResolution", "_EmissionGain", 424f) + hardInput.PMJHMIKCPBI("Mouse Wheel Up", 587f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Connecting") && this.AHFGFIOCMJF())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006788 RID: 26504 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void Start()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06006789 RID: 26505 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void EPEGAEGDJAM()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600678A RID: 26506 RVA: 0x001F222C File Offset: 0x001F042C
	private bool FDFDMGDFNPP()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1671f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1441f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 1447f);
	}

	// Token: 0x0600678B RID: 26507 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void MMOKKAPFGAK()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600678C RID: 26508 RVA: 0x001F22F4 File Offset: 0x001F04F4
	private bool ICJGHMEFKLD()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1947f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1087f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 1723f);
	}

	// Token: 0x0600678D RID: 26509 RVA: 0x001F23BC File Offset: 0x001F05BC
	private void LEAHIBJDMBI()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("<command>", "_ScreenResolution", 804f) + hardInput.GetAxis("_Value4", 593f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("(from resources)", "GlassDistortion", 1603f) + hardInput.GMNJKCNIPGD("_TimeX", 1714f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(". local RequestedView.ownerId: ") && this.NAMJGDMJNPN())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x0600678E RID: 26510 RVA: 0x001F24AC File Offset: 0x001F06AC
	private bool FFNDLLMCLBE()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 8f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1844f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 101f);
	}

	// Token: 0x0600678F RID: 26511 RVA: 0x001F2574 File Offset: 0x001F0774
	private bool JKMFLNFDNEF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1137f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 643f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 804f);
	}

	// Token: 0x06006790 RID: 26512 RVA: 0x001F263C File Offset: 0x001F083C
	private void FABKIGNFECE()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("colorD", "_Value4", 784f) + hardInput.GMNJKCNIPGD("_Value3", 740f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.DAKLFCPPJDB("_Fade", "CameraFilterPack/EyesVision_1", 991f) + hardInput.GMNJKCNIPGD("</color>", 759f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown(" : ") && this.FFNDLLMCLBE())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006791 RID: 26513 RVA: 0x001F272C File Offset: 0x001F092C
	private void OEENOOGEEHD()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Tab2Content", "_LightIntensity", 1832f) + hardInput.GMNJKCNIPGD("Drop_Far", 364f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("menu.selectedlevelid", "_AccumOrig", 1813f) + hardInput.PMJHMIKCPBI("CameraFilterPack/Color_Sepia", 748f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("Drop_Floor_Fluid") && this.FBMAFPFLLMB())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006792 RID: 26514 RVA: 0x001F281C File Offset: 0x001F0A1C
	private bool NAMJGDMJNPN()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1917f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 726f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 627f);
	}

	// Token: 0x06006793 RID: 26515 RVA: 0x001F28E4 File Offset: 0x001F0AE4
	private bool LBIPPEAGECA()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 691f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 130f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 1248f);
	}

	// Token: 0x06006794 RID: 26516 RVA: 0x001F29AC File Offset: 0x001F0BAC
	private void FABMDEHEDNO()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("player.goldarc", "_ScreenResolution", 1044f) + hardInput.PMJHMIKCPBI("Joystick1Button3", 1110f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("PunPickup", "id", 1432f) + hardInput.GMNJKCNIPGD("DifficultyBG", 95f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("_RotationMatrix") && this.FFNDLLMCLBE())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006795 RID: 26517 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void DLBODOFAJGM()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06006796 RID: 26518 RVA: 0x001F2A9C File Offset: 0x001F0C9C
	private void MFMIODIAKNI()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.GetAxis("_ScreenResolution", "maps.", 864f) + hardInput.GMNJKCNIPGD("_Value", 220f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.JLPPEGBDNKA("float,10", "_Blue_G", 337f) + hardInput.GetAxis("_TimeX", 653f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("_TimeX") && this.FFNDLLMCLBE())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x06006797 RID: 26519 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void AGEJKLMJGDO()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06006798 RID: 26520 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void JKFDDNMPOJH()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x06006799 RID: 26521 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void KLILJHJNICK()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600679A RID: 26522 RVA: 0x001F2B8C File Offset: 0x001F0D8C
	private bool KBHPPEAGMJB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1134f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 267f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 356f);
	}

	// Token: 0x0600679B RID: 26523 RVA: 0x001F2C54 File Offset: 0x001F0E54
	private bool FBMAFPFLLMB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 667f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 219f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 879f);
	}

	// Token: 0x0600679C RID: 26524 RVA: 0x001F2D1C File Offset: 0x001F0F1C
	private void LCJHDLKJEOM()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("_Value", "_ScreenResolution", 77f) + hardInput.GMNJKCNIPGD("CameraFilterPack_3D_Myst1", 1894f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis(":", "#done", 1762f) + hardInput.GMNJKCNIPGD("_TimeX", 1562f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.AADFFLGEJPP("BitsData") && this.JLMPFNOJJOK())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x0600679D RID: 26525 RVA: 0x001F2E0C File Offset: 0x001F100C
	private bool PCKCJNKFAPF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1013f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 403f, base.transform.position.z), -Vector3.up, this.LODOOHOEFND + 482f);
	}

	// Token: 0x0600679E RID: 26526 RVA: 0x001F2ED4 File Offset: 0x001F10D4
	private void Update()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Right", "Left", 7f) + hardInput.GetAxis("ControllerLeftX", 7f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.GetAxis("Forward", "Backward", 7f) + hardInput.GetAxis("ControllerLeftY", 7f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Jump") && this.NAEONENECEC())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x0600679F RID: 26527 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void NCNPAKFAFOE()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060067A0 RID: 26528 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void CCLNNLCOPBL()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060067A1 RID: 26529 RVA: 0x001F2FC4 File Offset: 0x001F11C4
	private void AGMJDGHLBMN()
	{
		if (this.canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(this.PGONDACAPAA.velocity);
			float num = this.moveSpeed;
			direction = new Vector3((hardInput.GetAxis("GenerationMenu", "_TimeX", 974f) + hardInput.PMJHMIKCPBI("float,50", 1518f)) * num, this.PGONDACAPAA.velocity.y, (hardInput.JLPPEGBDNKA("Bad parameters for delete! Use <key>", "Warning: No Shape Curve set for CurveWaveform.cs on ", 1834f) + hardInput.PMJHMIKCPBI("LetterSpacing: Missing Text component", 137f)) * num);
			this.PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(".lastCheckpoint.lives") && this.NAMJGDMJNPN())
			{
				this.PGONDACAPAA.AddForceAtPosition(Vector3.up * this.jumpForce, Vector3.up);
			}
		}
	}

	// Token: 0x060067A2 RID: 26530 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void CNGAJDBOCLJ()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x060067A3 RID: 26531 RVA: 0x001F1B3D File Offset: 0x001EFD3D
	private void FEHCNJLLJMP()
	{
		this.PGONDACAPAA = base.GetComponent<Rigidbody>();
	}

	// Token: 0x04000A9F RID: 2719
	public bool canMove;

	// Token: 0x04000AA0 RID: 2720
	public float moveSpeed;

	// Token: 0x04000AA1 RID: 2721
	public float sprintMultiplier;

	// Token: 0x04000AA2 RID: 2722
	public float jumpForce;

	// Token: 0x04000AA3 RID: 2723
	private float LODOOHOEFND = 0.5f;

	// Token: 0x04000AA4 RID: 2724
	private Rigidbody PGONDACAPAA;
}
