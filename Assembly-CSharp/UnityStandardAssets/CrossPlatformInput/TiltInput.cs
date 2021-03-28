using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x0200018D RID: 397
	public class TiltInput : MonoBehaviour
	{
		// Token: 0x0600746E RID: 29806 RVA: 0x0023A718 File Offset: 0x00238918
		private void OCMKCBBCEFG()
		{
			float value = 363f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1261f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1032f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 281f - 475f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.LLJLDLLNFBH(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x0023A855 File Offset: 0x00238A55
		private void OnDisable()
		{
			this.BONEKGOJGEK.Remove();
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x0023A862 File Offset: 0x00238A62
		private void DLMPALHKMON()
		{
			this.BONEKGOJGEK.FAJPCAIIKHF();
		}

		// Token: 0x06007471 RID: 29809 RVA: 0x0023A86F File Offset: 0x00238A6F
		private void BFEILOMHNPC()
		{
			this.BONEKGOJGEK.OIGFKCBEMLN();
		}

		// Token: 0x06007472 RID: 29810 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void PAHNKEGFGHB()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x0023A8B0 File Offset: 0x00238AB0
		private void LLJLDLLNFBH()
		{
			float value = 1467f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1231f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1669f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1546f - 990f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.Update(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void HGIMCCHIPCP()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x0023A9F0 File Offset: 0x00238BF0
		private void LJIHHJOAJCN()
		{
			float value = 1433f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 331f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 475f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1818f - 599f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.Update(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x0023A862 File Offset: 0x00238A62
		private void NAOLAJPDGIC()
		{
			this.BONEKGOJGEK.FAJPCAIIKHF();
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x0023AB30 File Offset: 0x00238D30
		private void ONMGIPAILOH()
		{
			float value = 1009f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 640f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 814f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1313f - 1195f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.IBHACCEEFFI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x0023AC70 File Offset: 0x00238E70
		private void MMBPLGGLPDB()
		{
			float value = 1838f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1528f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 950f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1637f - 54f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.JNBPKNNBMDI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x0023ADB0 File Offset: 0x00238FB0
		private void OMCLOFCJMPG()
		{
			float value = 932f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1124f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1194f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1611f - 0f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.LLJLDLLNFBH(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void BDBKIEIIFPB()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void IFBPAGFGDGD()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x0023AEF0 File Offset: 0x002390F0
		private void AIJGAJIOJDJ()
		{
			float value = 1315f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 305f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 622f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 25f - 1224f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.JNBPKNNBMDI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x0023A862 File Offset: 0x00238A62
		private void CPAJLKHMOJB()
		{
			this.BONEKGOJGEK.FAJPCAIIKHF();
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x0023B030 File Offset: 0x00239230
		private void LEAHIBJDMBI()
		{
			float value = 1027f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 850f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1877f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 735f - 1985f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.BGFJOEPFOPM(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void HIFPDKKBDHJ()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x0023B16D File Offset: 0x0023936D
		private void ODAIMOJLJOF()
		{
			this.BONEKGOJGEK.KHPOJPKOEJP();
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x0023B17C File Offset: 0x0023937C
		private void IBHACCEEFFI()
		{
			float value = 1611f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1838f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 196f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1894f - 1680f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.IBHACCEEFFI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x0023B16D File Offset: 0x0023936D
		private void ICDBMJKMIKC()
		{
			this.BONEKGOJGEK.KHPOJPKOEJP();
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x0023A86F File Offset: 0x00238A6F
		private void JOJFHFHOCHO()
		{
			this.BONEKGOJGEK.OIGFKCBEMLN();
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void JKMLIADBEOB()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void PPGEGFMNIKO()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x0023B2BC File Offset: 0x002394BC
		private void HDDECCMEJKA()
		{
			float value = 374f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1309f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 559f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 678f - 1390f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.IBHACCEEFFI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x0023A862 File Offset: 0x00238A62
		private void DPFOEBCADNP()
		{
			this.BONEKGOJGEK.FAJPCAIIKHF();
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void JCDPMLPNOOC()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void HPGKMAIPDEO()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void OnEnable()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x0023B3F9 File Offset: 0x002395F9
		private void LOMDIOLNFHI()
		{
			this.BONEKGOJGEK.HPFNAMAOKLC();
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void CNHEENCFCMF()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x0023B408 File Offset: 0x00239608
		private void MFMIODIAKNI()
		{
			float value = 985f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1006f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1586f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1644f - 713f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.NKLIHNJCHOG(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x0023B548 File Offset: 0x00239748
		private void BGFJOEPFOPM()
		{
			float value = 457f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 18f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1301f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1424f - 976f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.BGFJOEPFOPM(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x0023B688 File Offset: 0x00239888
		private void HLDFOJMHKNL()
		{
			float value = 752f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 857f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 937f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1595f - 983f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.IBHACCEEFFI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x0023B7C8 File Offset: 0x002399C8
		private void JBNPEHMDCMI()
		{
			float value = 983f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.ForwardAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 306f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 216f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1807f - 460f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.BGFJOEPFOPM(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x0023B905 File Offset: 0x00239B05
		private void NJHJHBOJKIC()
		{
			this.BONEKGOJGEK.LCAAPKEOIMI();
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x0023A86F File Offset: 0x00238A6F
		private void HLLHJIDOOGA()
		{
			this.BONEKGOJGEK.OIGFKCBEMLN();
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void EAOKCECGKAK()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void OOBIMFILNED()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x0023B912 File Offset: 0x00239B12
		private void ALMGMOOHLMA()
		{
			this.BONEKGOJGEK.JJPCNFLGLDL();
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void IJCBBIJOCAH()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void IBFHEDHJDLH()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void LLDBPKHDPKI()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x0023B91F File Offset: 0x00239B1F
		private void PAEGLMEOKHP()
		{
			this.BONEKGOJGEK.HKBINDMJGFJ();
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x0023B92C File Offset: 0x00239B2C
		private void EHCGBJDFMHG()
		{
			float value = 1557f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1837f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 841f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 75f - 86f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.IBHACCEEFFI(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x0023BA6C File Offset: 0x00239C6C
		private void BGDONBMDPGM()
		{
			float value = 74f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 578f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 773f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1285f - 282f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.LLJLDLLNFBH(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x0023B905 File Offset: 0x00239B05
		private void CBIBDOIBJAI()
		{
			this.BONEKGOJGEK.LCAAPKEOIMI();
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x0023BBAC File Offset: 0x00239DAC
		private void Update()
		{
			float value = 0f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 57.29578f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 57.29578f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 2f - 1f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.Update(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x0023BCEC File Offset: 0x00239EEC
		private void JNBPKNNBMDI()
		{
			float value = 343f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 395f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 1316f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1275f - 742f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.Update(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x0023BE2C File Offset: 0x0023A02C
		private void FABMDEHEDNO()
		{
			float value = 954f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 1897f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 638f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1045f - 1536f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.NDAJBJFJGCF(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x0023B3F9 File Offset: 0x002395F9
		private void FJIKDJAMOHA()
		{
			this.BONEKGOJGEK.HPFNAMAOKLC();
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x0023BF6C File Offset: 0x0023A16C
		private void JOACBIEHHCE()
		{
			float value = 494f;
			if (Input.acceleration != Vector3.zero)
			{
				TiltInput.AxisOptions axisOptions = this.tiltAroundAxis;
				if (axisOptions != TiltInput.AxisOptions.ForwardAxis)
				{
					if (axisOptions == TiltInput.AxisOptions.SidewaysAxis)
					{
						value = Mathf.Atan2(Input.acceleration.z, -Input.acceleration.y) * 546f + this.centreAngleOffset;
					}
				}
				else
				{
					value = Mathf.Atan2(Input.acceleration.x, -Input.acceleration.y) * 313f + this.centreAngleOffset;
				}
			}
			float num = Mathf.InverseLerp(-this.fullTiltAngle, this.fullTiltAngle, value) * 1938f - 1401f;
			switch (this.mapping.type)
			{
			case TiltInput.AxisMapping.MappingType.NamedAxis:
				this.BONEKGOJGEK.NKLIHNJCHOG(num);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case TiltInput.AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void IFKNIHJCAFB()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x0023A86F File Offset: 0x00238A6F
		private void HNILMGEKDEC()
		{
			this.BONEKGOJGEK.OIGFKCBEMLN();
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x0023A87C File Offset: 0x00238A7C
		private void EMAMCDFBGOA()
		{
			if (this.mapping.type == TiltInput.AxisMapping.MappingType.NamedAxis)
			{
				this.BONEKGOJGEK = new CrossPlatformInputManager.VirtualAxis(this.mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.BONEKGOJGEK);
			}
		}

		// Token: 0x04000BB1 RID: 2993
		public TiltInput.AxisMapping mapping;

		// Token: 0x04000BB2 RID: 2994
		public TiltInput.AxisOptions tiltAroundAxis;

		// Token: 0x04000BB3 RID: 2995
		public float fullTiltAngle = 25f;

		// Token: 0x04000BB4 RID: 2996
		public float centreAngleOffset;

		// Token: 0x04000BB5 RID: 2997
		private CrossPlatformInputManager.VirtualAxis BONEKGOJGEK;

		// Token: 0x0200018E RID: 398
		public enum AxisOptions
		{
			// Token: 0x04000BB7 RID: 2999
			ForwardAxis,
			// Token: 0x04000BB8 RID: 3000
			SidewaysAxis
		}

		// Token: 0x0200018F RID: 399
		[Serializable]
		public class AxisMapping
		{
			// Token: 0x04000BB9 RID: 3001
			public TiltInput.AxisMapping.MappingType type;

			// Token: 0x04000BBA RID: 3002
			public string axisName;

			// Token: 0x02000190 RID: 400
			public enum MappingType
			{
				// Token: 0x04000BBC RID: 3004
				NamedAxis,
				// Token: 0x04000BBD RID: 3005
				MousePositionX,
				// Token: 0x04000BBE RID: 3006
				MousePositionY,
				// Token: 0x04000BBF RID: 3007
				MousePositionZ
			}
		}
	}
}
