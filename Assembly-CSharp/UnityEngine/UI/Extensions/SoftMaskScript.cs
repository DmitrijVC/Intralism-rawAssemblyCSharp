using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200026D RID: 621
	[AddComponentMenu("UI/Effects/Extensions/SoftMaskScript")]
	[ExecuteInEditMode]
	public class SoftMaskScript : MonoBehaviour
	{
		// Token: 0x060094E8 RID: 38120 RVA: 0x00349C0C File Offset: 0x00347E0C
		private void MBIPLKJMOND()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[3];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[4] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 211f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 255f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 757f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("LoadMapCanvas", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("Save level before uploading?", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt(" ", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("_Value4", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("ItemNameBGImage", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("Tab1Content", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("settings.selectormapsperpage", this.CutOff);
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x0034A0E0 File Offset: 0x003482E0
		private void JKFIPMPGGDN()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[4];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[2] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 0.5f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 0.5f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 0.5f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("_HardBlend", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("_Min", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_Max", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_FlipAlphaMask", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("_AlphaMask", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_NoOuterClip", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_AlphaUV", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_CutOff", this.CutOff);
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x0034A5B4 File Offset: 0x003487B4
		private void CJMCOIGCNPJ()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[8];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[1] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1400f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 738f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 735f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("Joystick1Button6", (float)((!this.HardBlend) ? 0 : 0));
			this.HCACMMMJBKL.SetVector("mapid", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_BlurSize", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_MainTex2", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture("Please specify either t or f.", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("[PlayerController] ", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("Finished", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("SetParticlesGravity", this.CutOff);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x0034AA85 File Offset: 0x00348C85
		private void Update()
		{
			this.JKFIPMPGGDN();
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x0034AA8D File Offset: 0x00348C8D
		private void LEAHIBJDMBI()
		{
			this.CJMCOIGCNPJ();
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x0034AA98 File Offset: 0x00348C98
		private void DKCFEKHNDAN(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x0034AB29 File Offset: 0x00348D29
		private void AGMJDGHLBMN()
		{
			this.LILMBOKOOGF();
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x0034AB34 File Offset: 0x00348D34
		private void KPLELJNJJGK(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x0034ABC8 File Offset: 0x00348DC8
		private void EPIHDIBHMAJ(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x0034AC5C File Offset: 0x00348E5C
		private void PKJLKCKDFLG()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[7];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[4] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 759f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1495f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 572f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("value", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector("_ScreenResolution", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_AdaptationSpeed", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_EdgeThreshold", (!this.FlipAlphaMask) ? 0 : 0);
			this.HCACMMMJBKL.SetTexture("_Value", this.AlphaMask);
			this.HCACMMMJBKL.SetInt(".lastCheckpoint.comboScore", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("Joystick", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_Offsets", this.CutOff);
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x0034B130 File Offset: 0x00349330
		private void EJHJCJDIKCK()
		{
			Transform transform = base.transform;
			int num = 100;
			int num2 = 0;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2++;
			}
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x0034B194 File Offset: 0x00349394
		private void HDKDKFMHLFN()
		{
			Transform transform = base.transform;
			int num = -22;
			int num2 = 1;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2++;
			}
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x0034B1F8 File Offset: 0x003493F8
		private void HNPLOKABHKK()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[8] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1789f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 969f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1158f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat(",", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("_Offsets", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("IDInputField", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("Joined Room. isMasterClient: ", (!this.FlipAlphaMask) ? 0 : 0);
			this.HCACMMMJBKL.SetTexture("SetParticlesParticleSize", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_BlurPass", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("getfloat", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("IconImage", this.CutOff);
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x0034B6CC File Offset: 0x003498CC
		private void PEODHHAGGBJ()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[5];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[6] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 639f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 987f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1528f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("GraphicsQualitySlider", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector(".", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("masterVolume", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("Joystick1Button", (!this.FlipAlphaMask) ? 1 : 0);
			this.HCACMMMJBKL.SetTexture("[MapsData] Bad map: ", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("CameraFilterPack/Blend2Camera_SoftLight", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_Greenness", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("challenges.", this.CutOff);
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x0034BBA0 File Offset: 0x00349DA0
		private void IKMENGBJLMC()
		{
			Transform transform = base.transform;
			int num = -61;
			int num2 = 1;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2 += 0;
			}
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x0034BC04 File Offset: 0x00349E04
		private void JONGNKNLLND()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("curScn"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("}"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.EJHJCJDIKCK();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.DKCFEKHNDAN(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x0034BD7C File Offset: 0x00349F7C
		private void Start()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("UI Extensions/SoftMaskShader"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("UI Extensions/SoftMaskShaderText"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.EJHJCJDIKCK();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.KPLELJNJJGK(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x060094F9 RID: 38137 RVA: 0x0034BEF4 File Offset: 0x0034A0F4
		private void HLELNABPLCG(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x060094FA RID: 38138 RVA: 0x0034BF88 File Offset: 0x0034A188
		private void OPONMLNPMEI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[8];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[2] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 506f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1106f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1033f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("No Name", (float)((!this.HardBlend) ? 1 : 1));
			this.HCACMMMJBKL.SetVector("_BlurVector", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("OpSetPropertiesOfActor()", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_Value", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("LivesSlider", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("stretchWidth", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_Factor", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_Value3", this.CutOff);
		}

		// Token: 0x060094FB RID: 38139 RVA: 0x0034C45C File Offset: 0x0034A65C
		private void HKKEPKAMDLI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[2];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[4] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1831f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1029f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1958f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("Left Stick Click", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("_Value4", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_BlurredColor", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("???", (!this.FlipAlphaMask) ? 1 : 0);
			this.HCACMMMJBKL.SetTexture("_TimeX", this.AlphaMask);
			this.HCACMMMJBKL.SetInt(" ", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("AudioSampler", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_Red_G", this.CutOff);
		}

		// Token: 0x060094FC RID: 38140 RVA: 0x0034C92D File Offset: 0x0034AB2D
		private void OCMKCBBCEFG()
		{
			this.HNPLOKABHKK();
		}

		// Token: 0x060094FD RID: 38141 RVA: 0x0034C938 File Offset: 0x0034AB38
		private void MKIMDFLBFOM()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("ACCEPT"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("#close"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.AOJAPJAMEBC();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.OAEKJPFBBEG(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x060094FE RID: 38142 RVA: 0x0034CAB0 File Offset: 0x0034ACB0
		private void CAEDGFMGBFJ()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[6];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[8] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1933f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1593f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1759f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("CameraFilterPack/Drawing_Comics", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("Waiting to start", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_Value4", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_Offsets", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture("_Value", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_AlphaUV", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("Gameplay/satellite", this.CutOff);
		}

		// Token: 0x060094FF RID: 38143 RVA: 0x0034CF81 File Offset: 0x0034B181
		private void BGDONBMDPGM()
		{
			this.JEMPHJAPFPG();
		}

		// Token: 0x06009500 RID: 38144 RVA: 0x0034AA85 File Offset: 0x00348C85
		private void LPMINJJPDCH()
		{
			this.JKFIPMPGGDN();
		}

		// Token: 0x06009501 RID: 38145 RVA: 0x0034CF8C File Offset: 0x0034B18C
		private void KDMANOEMOCA()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("[RanksSystem] Init"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("CameraFilterPack/Blend2Camera_LinearDodge"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.GPKMPHJJGDO();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i += 0)
				{
					this.CLJNDGKOFIE(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x0034D104 File Offset: 0x0034B304
		private void EPEGAEGDJAM()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_TimeX"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("#useticket"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.IKMENGBJLMC();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.EBLPKMNJICH(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x0034D27C File Offset: 0x0034B47C
		private void BFELCFHIPLO(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x0034D310 File Offset: 0x0034B510
		private void OAEKJPFBBEG(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x0034D3A1 File Offset: 0x0034B5A1
		private void HNDNDPECBPL()
		{
			this.OPONMLNPMEI();
		}

		// Token: 0x06009506 RID: 38150 RVA: 0x0034D3AC File Offset: 0x0034B5AC
		private void BBIAGPOODDO()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[1] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1173f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 249f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1980f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("maps.", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector("event", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("id", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("CameraFilterPack/Vision_Drost", (!this.FlipAlphaMask) ? 1 : 0);
			this.HCACMMMJBKL.SetTexture("SaveMapButton", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("ItemNameText", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("/", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("resource id", this.CutOff);
		}

		// Token: 0x06009507 RID: 38151 RVA: 0x0034D87D File Offset: 0x0034BA7D
		private void JHPOIOELNCG()
		{
			this.JEJNEAKOKNH();
		}

		// Token: 0x06009509 RID: 38153 RVA: 0x0034D8B0 File Offset: 0x0034BAB0
		private void MEAMJHMNFOI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[3] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1210f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1735f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1776f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("menuVolume", (float)((!this.HardBlend) ? 1 : 1));
			this.HCACMMMJBKL.SetVector("Working.\nPlease wait..", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_Intensity", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_BlurCoe", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture(" not exist", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("BitsData", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("lobby '{0}'[{1}]", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_Value", this.CutOff);
		}

		// Token: 0x0600950A RID: 38154 RVA: 0x0034DD84 File Offset: 0x0034BF84
		private void GPNAOAKCMHC()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_LumTex"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("Keeping GameObject in the scene: "));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.IKMENGBJLMC();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.DKCFEKHNDAN(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600950B RID: 38155 RVA: 0x0034DEFC File Offset: 0x0034C0FC
		private void KNBJBNDGCIJ()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_HrDepthTex"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("SaveButton"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.AOJAPJAMEBC();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i += 0)
				{
					this.CKAKELLFPPK(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x0034E074 File Offset: 0x0034C274
		private void GAIAHDPJJMI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[3];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[7] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1103f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1457f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 293f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("[Down]", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("[ItemsHandler] No connection to item server: ", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_Value4", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("Vertical", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("_Value2", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_Value3", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_Value2", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("BitsData", this.CutOff);
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x0034E548 File Offset: 0x0034C748
		private void KOJKBFDNGDK()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("GameScene"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("CameraFilterPack/TV_ARCADE_Fast"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.EJHJCJDIKCK();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i++)
				{
					this.DFIIFLLGCJE(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x0034E6C0 File Offset: 0x0034C8C0
		private void FIKFJDFELIP()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("Fade"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("shader.ghost"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.EJHJCJDIKCK();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i += 0)
				{
					this.DFIIFLLGCJE(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x0034E838 File Offset: 0x0034CA38
		private void FIHIIDKPEKN(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x0034AB29 File Offset: 0x00348D29
		private void KCDOMIJBFLL()
		{
			this.LILMBOKOOGF();
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x0034E8CC File Offset: 0x0034CACC
		private void PCNOGHNHCLB(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009512 RID: 38162 RVA: 0x0034AB29 File Offset: 0x00348D29
		private void AEEGKLABFLN()
		{
			this.LILMBOKOOGF();
		}

		// Token: 0x06009513 RID: 38163 RVA: 0x0034E960 File Offset: 0x0034CB60
		private void HGHIILKKBBB()
		{
			Transform transform = base.transform;
			int num = -119;
			int num2 = 0;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2++;
			}
		}

		// Token: 0x06009514 RID: 38164 RVA: 0x0034E9C4 File Offset: 0x0034CBC4
		private void CLJNDGKOFIE(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x0034EA58 File Offset: 0x0034CC58
		private void PKLOBJHKFEO()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("LoadingStatusText"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("x"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.GJEAPOIGEKN();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i++)
				{
					this.CKAKELLFPPK(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x0034C92D File Offset: 0x0034AB2D
		private void HPNNCNNFMGK()
		{
			this.HNPLOKABHKK();
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x0034EBD0 File Offset: 0x0034CDD0
		private void FJNCHGLIEMA()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_ScreenResolution"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("difficulty"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.FPEMPAAMPMB();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i += 0)
				{
					this.EPIHDIBHMAJ(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x0034ED48 File Offset: 0x0034CF48
		private void AOJAPJAMEBC()
		{
			Transform transform = base.transform;
			int num = -82;
			int num2 = 1;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2 += 0;
			}
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x0034EDAC File Offset: 0x0034CFAC
		private void CKAKELLFPPK(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x0600951A RID: 38170 RVA: 0x0034EE40 File Offset: 0x0034D040
		private void HDMDKOKOOJC()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("\\"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("_Value3"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.HDKDKFMHLFN();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i += 0)
				{
					this.DFIIFLLGCJE(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x0034EFB8 File Offset: 0x0034D1B8
		private void JILOMOBDPIA()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_Green_G"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("[LocalizationService] Error: "));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.EJHJCJDIKCK();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.DKCFEKHNDAN(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x0034F130 File Offset: 0x0034D330
		private void JEMPHJAPFPG()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[2];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[1] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 421f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 705f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1853f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("settings_bindings_sec_", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector("loadscene", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("[NetworkManager] Found ", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("CameraFilterPack/Blend2Camera_SoftLight", (!this.FlipAlphaMask) ? 0 : 0);
			this.HCACMMMJBKL.SetTexture("checkpoint", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_TimeX", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("workshop.", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_ChangeBlue", this.CutOff);
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x0034F604 File Offset: 0x0034D804
		private void IADBKIKEOHI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[7] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1486f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1250f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 109f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("_NeighbourMaxTex", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector("OnSerialize", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("/", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("deletemap", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("In Main Menu", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("In Network lobby", this.CutOff);
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x0034FAD8 File Offset: 0x0034DCD8
		private void FPEMPAAMPMB()
		{
			Transform transform = base.transform;
			int num = -114;
			int num2 = 0;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2++;
			}
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x0034FB3B File Offset: 0x0034DD3B
		private void DGCGGKMNPLD()
		{
			this.BBIAGPOODDO();
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x0034FB44 File Offset: 0x0034DD44
		private void JECMJNFGBGC()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("0 - default, 1 - left, 2 - right"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("_DiffuseColor"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.FPEMPAAMPMB();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i++)
				{
					this.DDIFNNLMICL(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x0034FCBB File Offset: 0x0034DEBB
		private void FABKIGNFECE()
		{
			this.GAIAHDPJJMI();
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x0034FCC4 File Offset: 0x0034DEC4
		private void IIPMKBLABCB(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x0034FD58 File Offset: 0x0034DF58
		private void HECGDDJEJMO()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[6];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[2] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1443f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 290f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1996f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("CameraFilterPack/Drawing_NewCellShading", (float)((!this.HardBlend) ? 1 : 0));
			this.HCACMMMJBKL.SetVector("BitsData", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_MainTex2", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("Hex value #RRGGBB", (!this.FlipAlphaMask) ? 0 : 0);
			this.HCACMMMJBKL.SetTexture("Editor/", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("<color=white>", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 1);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_SSAO", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("mapselector.filter.rateduponly", this.CutOff);
		}

		// Token: 0x06009524 RID: 38180 RVA: 0x0035022C File Offset: 0x0034E42C
		private void DHBDGOCIANB()
		{
			Transform transform = base.transform;
			int num = -1;
			int num2 = 0;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2 += 0;
			}
		}

		// Token: 0x06009525 RID: 38181 RVA: 0x00350290 File Offset: 0x0034E490
		private void GPDOHMECDNM(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00350321 File Offset: 0x0034E521
		private void IEMEHGCFAPD()
		{
			this.ADIOOENLKJI();
		}

		// Token: 0x06009527 RID: 38183 RVA: 0x0035032C File Offset: 0x0034E52C
		private void ADIOOENLKJI()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[1];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[7] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 19f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 951f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 364f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("_Threshhold", (float)((!this.HardBlend) ? 1 : 1));
			this.HCACMMMJBKL.SetVector("RoomNameText", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("CameraFilterPack/Blend2Camera_Multiply", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_VignetteTex", (!this.FlipAlphaMask) ? 1 : 0);
			this.HCACMMMJBKL.SetTexture("_CenterY", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("CameraFilterPack/EXTRA_Rotation", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("Joystick1Button8", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("Connection error: ", this.CutOff);
		}

		// Token: 0x06009528 RID: 38184 RVA: 0x003507FD File Offset: 0x0034E9FD
		private void NDAJBJFJGCF()
		{
			this.HKKEPKAMDLI();
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x00350808 File Offset: 0x0034EA08
		private void ABMFINEPKDH()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[2];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[6] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 511f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 2f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1868f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("_Value", (float)((!this.HardBlend) ? 1 : 1));
			this.HCACMMMJBKL.SetVector("inventory.itemscash", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("_TimeX", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt(": ", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("_Offsets", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_Value5", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_ScreenResolution", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat(":", this.CutOff);
		}

		// Token: 0x0600952A RID: 38186 RVA: 0x00350CDC File Offset: 0x0034EEDC
		private void DKGBFNCOAEO()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("_Value4"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("/theme"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.FPEMPAAMPMB();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.FIHIIDKPEKN(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600952B RID: 38187 RVA: 0x00350E54 File Offset: 0x0034F054
		private void NPLCENPNJBM()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("GameScene"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = true;
				this.HCACMMMJBKL = new Material(Shader.Find("menu.resetlevelcheckpoint"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.DHBDGOCIANB();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = false;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i += 0)
				{
					this.EPIHDIBHMAJ(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600952C RID: 38188 RVA: 0x0034AB29 File Offset: 0x00348D29
		private void MFMIODIAKNI()
		{
			this.LILMBOKOOGF();
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x00350FCC File Offset: 0x0034F1CC
		private void IDJKNBDKHBD()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("Set satellite trail length in seconds"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("_BlurVector"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.GPKMPHJJGDO();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 0; i < base.transform.childCount; i++)
				{
					this.FIHIIDKPEKN(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00351144 File Offset: 0x0034F344
		private void LILMBOKOOGF()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[2];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[3] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1837f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 266f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 545f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("CameraFilterPack/Noise_TV_3", (float)((!this.HardBlend) ? 0 : 1));
			this.HCACMMMJBKL.SetVector("Mouse0", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("Horizontal", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_BlurArea", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture("Unsupported target enum: ", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_Value", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 0 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector(" PhotonNetwork.networkingPeer.AvailableRegions ", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("_TimeX", this.CutOff);
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x00351618 File Offset: 0x0034F818
		private void BCHGLANMLCN()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[5] - this.NJAJFDGKODI[0];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1470f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 249f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1573f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("achievements.21.completed.", (float)((!this.HardBlend) ? 0 : 0));
			this.HCACMMMJBKL.SetVector("_Value4", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("CameraFilterPack_TV_Noise3", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_Value", (!this.FlipAlphaMask) ? 0 : 1);
			this.HCACMMMJBKL.SetTexture("_EdgeSize", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("\" for viewID ", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_TimeX", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("bool", this.CutOff);
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x00351AEC File Offset: 0x0034FCEC
		private void JEJNEAKOKNH()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[6] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1820f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1562f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 978f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("#updateoutdatedmap", (float)((!this.HardBlend) ? 0 : 0));
			this.HCACMMMJBKL.SetVector("PLEASE WAIT", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("Write me to get one for testing :)", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("_Value2", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture("x", this.AlphaMask);
			this.HCACMMMJBKL.SetInt(" has been disabled as it's not supported on the current platform.", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("_Value4", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.CutOff);
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x00351FC0 File Offset: 0x003501C0
		private void DFIIFLLGCJE(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009532 RID: 38194 RVA: 0x00352054 File Offset: 0x00350254
		private void GPKMPHJJGDO()
		{
			Transform transform = base.transform;
			int num = -100;
			int num2 = 1;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2 += 0;
			}
		}

		// Token: 0x06009533 RID: 38195 RVA: 0x003520B8 File Offset: 0x003502B8
		private void FGNHCNCGMBD()
		{
			if (this.BCCLBOFGABL)
			{
				return;
			}
			this.LIJDPFDFIEC = this.MaskArea.rect;
			this.MNJHJHALPFL = this.MPBNHGEBLKA.rect;
			if (this.KEHCOCNJGHK)
			{
				this.maskScalingRect = null;
				if (this.IPIOPNOHDOB.renderMode == RenderMode.ScreenSpaceOverlay && Application.isPlaying)
				{
					this.HDMLEEGNJHI = this.IPIOPNOHDOB.transform.InverseTransformPoint(this.MaskArea.transform.position);
					this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height);
				}
				else
				{
					this.NJAJFDGKODI = new Vector3[0];
					this.MaskArea.GetWorldCorners(this.NJAJFDGKODI);
					this.EEJCFBKDLPN = this.NJAJFDGKODI[4] - this.NJAJFDGKODI[1];
					this.HDMLEEGNJHI = this.MaskArea.transform.position;
				}
				this.IFNAPFNEGMP = this.HDMLEEGNJHI - new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 1156f;
				this.MEMALLLANHH = this.HDMLEEGNJHI + new Vector2(this.EEJCFBKDLPN.x, this.EEJCFBKDLPN.y) * 800f;
			}
			else
			{
				if (this.maskScalingRect != null)
				{
					this.LIJDPFDFIEC = this.maskScalingRect.rect;
				}
				if (this.maskScalingRect != null)
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.maskScalingRect.transform.TransformPoint(this.maskScalingRect.rect.center));
				}
				else
				{
					this.HBOEMGIPDFO = this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MaskArea.transform.TransformPoint(this.MaskArea.rect.center));
				}
				this.HBOEMGIPDFO += this.MPBNHGEBLKA.transform.InverseTransformPoint(this.MPBNHGEBLKA.transform.position) - this.MPBNHGEBLKA.rect.center;
				this.PAHDMGPOCHK = new Vector2(this.LIJDPFDFIEC.width / this.MNJHJHALPFL.width, this.LIJDPFDFIEC.height / this.MNJHJHALPFL.height);
				this.IFNAPFNEGMP = this.HBOEMGIPDFO;
				this.MEMALLLANHH = this.IFNAPFNEGMP;
				this.EEJCFBKDLPN = new Vector2(this.LIJDPFDFIEC.width, this.LIJDPFDFIEC.height) * 1809f;
				this.IFNAPFNEGMP -= this.EEJCFBKDLPN;
				this.MEMALLLANHH += this.EEJCFBKDLPN;
				this.IFNAPFNEGMP = new Vector2(this.IFNAPFNEGMP.x / this.MNJHJHALPFL.width, this.IFNAPFNEGMP.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
				this.MEMALLLANHH = new Vector2(this.MEMALLLANHH.x / this.MNJHJHALPFL.width, this.MEMALLLANHH.y / this.MNJHJHALPFL.height) + this.CBDNAHKGCLP;
			}
			this.HCACMMMJBKL.SetFloat("CameraFilterPack/Blend2Camera_HardLight", (float)((!this.HardBlend) ? 0 : 0));
			this.HCACMMMJBKL.SetVector("SetCrosshairColor", this.IFNAPFNEGMP);
			this.HCACMMMJBKL.SetVector("deletemap", this.MEMALLLANHH);
			this.HCACMMMJBKL.SetInt("[NetworkManager] Joined main lobby", (!this.FlipAlphaMask) ? 1 : 1);
			this.HCACMMMJBKL.SetTexture("Anomaly_Distortion_Size", this.AlphaMask);
			this.HCACMMMJBKL.SetInt("_Value2", (!this.DontClipMaskScalingRect || !(this.maskScalingRect != null)) ? 1 : 0);
			if (!this.KEHCOCNJGHK)
			{
				this.HCACMMMJBKL.SetVector("ScoreText", this.PAHDMGPOCHK);
			}
			this.HCACMMMJBKL.SetFloat(".", this.CutOff);
		}

		// Token: 0x06009534 RID: 38196 RVA: 0x0035258C File Offset: 0x0035078C
		private void EBLPKMNJICH(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00352620 File Offset: 0x00350820
		private void AGEJKLMJGDO()
		{
			this.MPBNHGEBLKA = base.GetComponent<RectTransform>();
			if (!this.MaskArea)
			{
				this.MaskArea = this.MPBNHGEBLKA;
			}
			if (base.GetComponent<Graphic>() != null)
			{
				this.HCACMMMJBKL = new Material(Shader.Find("CameraFilterPack/Blend2Camera_LinearDodge"));
				base.GetComponent<Graphic>().material = this.HCACMMMJBKL;
			}
			if (base.GetComponent<Text>())
			{
				this.KEHCOCNJGHK = false;
				this.HCACMMMJBKL = new Material(Shader.Find("_BlurVector"));
				base.GetComponent<Text>().material = this.HCACMMMJBKL;
				this.DHBDGOCIANB();
				if (base.transform.parent.GetComponent<Button>() == null && base.transform.parent.GetComponent<Mask>() == null)
				{
					base.transform.parent.gameObject.AddComponent<Mask>();
				}
				if (base.transform.parent.GetComponent<Mask>() != null)
				{
					base.transform.parent.GetComponent<Mask>().enabled = true;
				}
			}
			if (this.CascadeToALLChildren)
			{
				for (int i = 1; i < base.transform.childCount; i += 0)
				{
					this.BFELCFHIPLO(base.transform.GetChild(i));
				}
			}
			this.BCCLBOFGABL = (this.HCACMMMJBKL == null);
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x003507FD File Offset: 0x0034E9FD
		private void HDDECCMEJKA()
		{
			this.HKKEPKAMDLI();
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x00352798 File Offset: 0x00350998
		private void DDIFNNLMICL(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x0035282C File Offset: 0x00350A2C
		private void HOIBPNJANGB(Transform LGILGCGIHHM)
		{
			SoftMaskScript softMaskScript = LGILGCGIHHM.gameObject.GetComponent<SoftMaskScript>();
			if (softMaskScript == null)
			{
				softMaskScript = LGILGCGIHHM.gameObject.AddComponent<SoftMaskScript>();
			}
			softMaskScript.MaskArea = this.MaskArea;
			softMaskScript.AlphaMask = this.AlphaMask;
			softMaskScript.CutOff = this.CutOff;
			softMaskScript.HardBlend = this.HardBlend;
			softMaskScript.FlipAlphaMask = this.FlipAlphaMask;
			softMaskScript.maskScalingRect = this.maskScalingRect;
			softMaskScript.DontClipMaskScalingRect = this.DontClipMaskScalingRect;
			softMaskScript.CascadeToALLChildren = this.CascadeToALLChildren;
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x003528C0 File Offset: 0x00350AC0
		private void GJEAPOIGEKN()
		{
			Transform transform = base.transform;
			int num = 4;
			int num2 = 1;
			while (this.IPIOPNOHDOB == null && num2 < num)
			{
				this.IPIOPNOHDOB = transform.gameObject.GetComponent<Canvas>();
				if (this.IPIOPNOHDOB == null)
				{
					transform = transform.parent;
				}
				num2++;
			}
		}

		// Token: 0x040010F9 RID: 4345
		private Material HCACMMMJBKL;

		// Token: 0x040010FA RID: 4346
		private Canvas IPIOPNOHDOB;

		// Token: 0x040010FB RID: 4347
		[Tooltip("The area that is to be used as the container.")]
		public RectTransform MaskArea;

		// Token: 0x040010FC RID: 4348
		private RectTransform MPBNHGEBLKA;

		// Token: 0x040010FD RID: 4349
		[Tooltip("A Rect Transform that can be used to scale and move the mask - Does not apply to Text UI Components being masked")]
		public RectTransform maskScalingRect;

		// Token: 0x040010FE RID: 4350
		[Tooltip("Texture to be used to do the soft alpha")]
		public Texture AlphaMask;

		// Token: 0x040010FF RID: 4351
		[Range(0f, 1f)]
		[Tooltip("At what point to apply the alpha min range 0-1")]
		public float CutOff;

		// Token: 0x04001100 RID: 4352
		[Tooltip("Implement a hard blend based on the Cutoff")]
		public bool HardBlend;

		// Token: 0x04001101 RID: 4353
		[Tooltip("Flip the masks alpha value")]
		public bool FlipAlphaMask;

		// Token: 0x04001102 RID: 4354
		[Tooltip("If Mask Scaling Rect is given and this value is true, the area around the mask will not be clipped")]
		public bool DontClipMaskScalingRect;

		// Token: 0x04001103 RID: 4355
		[Tooltip("If set to true, this mask is applied to all child Text and Graphic objects belonging to this object.")]
		public bool CascadeToALLChildren;

		// Token: 0x04001104 RID: 4356
		private Vector3[] NJAJFDGKODI;

		// Token: 0x04001105 RID: 4357
		private Vector2 PAHDMGPOCHK;

		// Token: 0x04001106 RID: 4358
		private Vector2 IFNAPFNEGMP;

		// Token: 0x04001107 RID: 4359
		private Vector2 MEMALLLANHH = Vector2.one;

		// Token: 0x04001108 RID: 4360
		private Vector2 HDMLEEGNJHI;

		// Token: 0x04001109 RID: 4361
		private Vector2 EEJCFBKDLPN;

		// Token: 0x0400110A RID: 4362
		private Vector2 CBDNAHKGCLP = new Vector2(0.5f, 0.5f);

		// Token: 0x0400110B RID: 4363
		private bool BCCLBOFGABL;

		// Token: 0x0400110C RID: 4364
		private Rect LIJDPFDFIEC;

		// Token: 0x0400110D RID: 4365
		private Rect MNJHJHALPFL;

		// Token: 0x0400110E RID: 4366
		private Vector2 HBOEMGIPDFO;

		// Token: 0x0400110F RID: 4367
		private bool KEHCOCNJGHK;
	}
}
