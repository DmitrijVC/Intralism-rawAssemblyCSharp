using System;
using Photon;
using UnityEngine;

// Token: 0x02000348 RID: 840
[RequireComponent(typeof(PhotonView))]
public class MoveByKeys : Photon.MonoBehaviour
{
	// Token: 0x0600BD82 RID: 48514 RVA: 0x0044E526 File Offset: 0x0044C726
	public void ODBNMPGBCGO()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD83 RID: 48515 RVA: 0x0044E526 File Offset: 0x0044C726
	public void ANCKKLFPGDI()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD84 RID: 48516 RVA: 0x0044E526 File Offset: 0x0044C726
	public void NNCCPEBIAKH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD85 RID: 48517 RVA: 0x0044E526 File Offset: 0x0044C726
	public void CIPKEPDELJB()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD86 RID: 48518 RVA: 0x0044E554 File Offset: 0x0044C754
	public void LBBBICDEPHA()
	{
		if (!base.ACPGHFHDCIP().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value4") < 147f || Input.GetAxisRaw("shader.frost") > 1187f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("useSrcAlphaAsMask");
		}
		if (this.KNCGPFGKKAB <= 1453f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Greater))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("  |  ") < 1144f || Input.GetAxisRaw("DifficultyBG") > 529f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("float,0.5");
		}
	}

	// Token: 0x0600BD87 RID: 48519 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DBLILJGKGHJ()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD88 RID: 48520 RVA: 0x0044E526 File Offset: 0x0044C726
	public void JKFDDNMPOJH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD89 RID: 48521 RVA: 0x0044E6FC File Offset: 0x0044C8FC
	public void MFGNBDFHAHK()
	{
		if (!base.GMAHNPNHMFK().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("OK") < 1905f || Input.GetAxisRaw("Beat Detected") > 156f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("RoomDescriptionText");
		}
		if (this.KNCGPFGKKAB <= 268f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Semicolon))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("inventory.selected.") < 978f || Input.GetAxisRaw("Vertical") > 484f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_DistortionSize");
		}
	}

	// Token: 0x0600BD8A RID: 48522 RVA: 0x0044E8A4 File Offset: 0x0044CAA4
	public void NLPKBAECHMO()
	{
		if (!base.GMAHNPNHMFK().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("r") < 1780f || Input.GetAxisRaw("0x") > 190f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("stretchWidth");
		}
		if (this.KNCGPFGKKAB <= 95f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Quote))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw(".png") < 735f || Input.GetAxisRaw("settings.shaders.bloomintencity") > 505f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("\t");
		}
	}

	// Token: 0x0600BD8B RID: 48523 RVA: 0x0044E526 File Offset: 0x0044C726
	public void ILCFPCIPENO()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD8C RID: 48524 RVA: 0x0044E526 File Offset: 0x0044C726
	public void NBGIMIDICKE()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD8D RID: 48525 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DBEMDAJDDDA()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD8E RID: 48526 RVA: 0x0044EA4C File Offset: 0x0044CC4C
	public void FEONBLOKEBF()
	{
		if (!base.CIACEFBNDDJ().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("\" for viewID ") < 117f || Input.GetAxisRaw("menu.selectedplaymode") > 1585f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("#ok");
		}
		if (this.KNCGPFGKKAB <= 1629f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.M))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("#91CCFF") < 1091f || Input.GetAxisRaw("_Value3") > 1928f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Jazz");
		}
	}

	// Token: 0x0600BD8F RID: 48527 RVA: 0x0044E526 File Offset: 0x0044C726
	public void LIBGAKMKHJJ()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD90 RID: 48528 RVA: 0x0044EBF4 File Offset: 0x0044CDF4
	public void GLFLNGNKCDN()
	{
		if (!base.JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.") < 904f || Input.GetAxisRaw("_Value") > 1483f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("0,1,false");
		}
		if (this.KNCGPFGKKAB <= 1727f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)21))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("_Value") < 1031f || Input.GetAxisRaw("Object ID. Case-Sensitive") > 724f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("SpectatingUserInfo");
		}
	}

	// Token: 0x0600BD91 RID: 48529 RVA: 0x0044E526 File Offset: 0x0044C726
	public void NCNPAKFAFOE()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD92 RID: 48530 RVA: 0x0044E526 File Offset: 0x0044C726
	public void HDMDKOKOOJC()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD93 RID: 48531 RVA: 0x0044ED9C File Offset: 0x0044CF9C
	public void JBPFBKMLGAD()
	{
		if (!base.FFIPLLNKGEN().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1736f || Input.GetAxisRaw(") but there is no recycle bin setup for it. Falling back to Instantiate") > 599f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		}
		if (this.KNCGPFGKKAB <= 1215f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)10))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("EnableRankedNotificationsToggle") < 1258f || Input.GetAxisRaw("_PositionY") > 1748f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(" not exist");
		}
	}

	// Token: 0x0600BD94 RID: 48532 RVA: 0x0044EF44 File Offset: 0x0044D144
	public void DFCAEFFNGEH()
	{
		if (!base.OELHGNKAMEG().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value3") < 1087f || Input.GetAxisRaw("_ScreenResolution") > 458f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("ConnectToMaster() disabled the offline mode. No longer offline.");
		}
		if (this.KNCGPFGKKAB <= 1799f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-28)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Glasses_On") < 1822f || Input.GetAxisRaw("_NoiseTex") > 206f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_PositionX");
		}
	}

	// Token: 0x0600BD95 RID: 48533 RVA: 0x0044F0EC File Offset: 0x0044D2EC
	public void LFLAGHIJCCN()
	{
		if (!base.EDIJKHEMPAD().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("music") < 1268f || Input.GetAxisRaw("_MaxSteps") > 552f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("[MapEditor] Loaded music file: ");
		}
		if (this.KNCGPFGKKAB <= 1312f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)10))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("settings.crosshairopacity") < 1773f || Input.GetAxisRaw("settings.shaders") > 777f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	// Token: 0x0600BD96 RID: 48534 RVA: 0x0044F294 File Offset: 0x0044D494
	public void JOHEGKAGALG()
	{
		if (!base.AAMNKPHHHCI().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1432f || Input.GetAxisRaw("_TimeX") > 1361f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])");
		}
		if (this.KNCGPFGKKAB <= 1546f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-53)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("itemid") < 395f || Input.GetAxisRaw("_Value2") > 479f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	// Token: 0x0600BD97 RID: 48535 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DKGBFNCOAEO()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD98 RID: 48536 RVA: 0x0044F43C File Offset: 0x0044D63C
	public void FACPCHPGPGN()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_Value") < 481f || Input.GetAxisRaw(" Remote called.") > 1212f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(".lastCheckpoint.lives");
		}
		if (this.KNCGPFGKKAB <= 1646f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-30)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("OK") < 304f || Input.GetAxisRaw("_Near") > 695f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("sfxVolume");
		}
	}

	// Token: 0x0600BD99 RID: 48537 RVA: 0x0044F5E4 File Offset: 0x0044D7E4
	public void EMKDDJHINBH()
	{
		if (!base.OELHGNKAMEG().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("</color>") < 950f || Input.GetAxisRaw("Set Trail Zoom (player camera move forward effect). Base value - 1.5") > 1316f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_EmissionColor");
		}
		if (this.KNCGPFGKKAB <= 1030f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)72))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("Internal LUT") < 61f || Input.GetAxisRaw("). ") > 1476f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Value3");
		}
	}

	// Token: 0x0600BD9A RID: 48538 RVA: 0x0044E526 File Offset: 0x0044C726
	public void MGMAOBPPOBJ()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD9B RID: 48539 RVA: 0x0044E526 File Offset: 0x0044C726
	public void KCCIEMBMOBA()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BD9C RID: 48540 RVA: 0x0044F78C File Offset: 0x0044D98C
	public void EKGDBEJAGPM()
	{
		if (!base.EOOCGIFFKBG().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("Fake") < 1001f || Input.GetAxisRaw("SetSunMinSize") > 1514f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_ScreenResolution");
		}
		if (this.KNCGPFGKKAB <= 1798f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)3))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw(" while connecting to: ") < 295f || Input.GetAxisRaw("ERROR: Preview file must be <1MB!") > 1229f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Distortion");
		}
	}

	// Token: 0x0600BD9D RID: 48541 RVA: 0x0044F934 File Offset: 0x0044DB34
	public void MIGFKFBOBDK()
	{
		if (!base.ACPGHFHDCIP().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw(".completed") < 487f || Input.GetAxisRaw("BadgeImage") > 1857f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Color_Convert_Normal");
		}
		if (this.KNCGPFGKKAB <= 1877f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-96)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("_Distortion") < 82f || Input.GetAxisRaw("Default UI Material") > 422f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("JoinButton");
		}
	}

	// Token: 0x0600BD9E RID: 48542 RVA: 0x0044FADC File Offset: 0x0044DCDC
	public void OPAMLNBLCHJ()
	{
		if (!base.GMAHNPNHMFK().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("Set satellite trail width") < 1740f || Input.GetAxisRaw("_TimeX") > 1765f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Submit");
		}
		if (this.KNCGPFGKKAB <= 730f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-91)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Glitch_Mozaic") < 1949f || Input.GetAxisRaw("CompletedLevel") > 1906f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/TV_Artefact");
		}
	}

	// Token: 0x0600BD9F RID: 48543 RVA: 0x0044E526 File Offset: 0x0044C726
	public void PKLOBJHKFEO()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDA0 RID: 48544 RVA: 0x0044FC84 File Offset: 0x0044DE84
	public void EKENDPKLMFN()
	{
		if (!base.JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_DistortionLevel") < 1275f || Input.GetAxisRaw(".ogg") > 1235f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("StopSounds");
		}
		if (this.KNCGPFGKKAB <= 745f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)87))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("Clear Environment") < 1400f || Input.GetAxisRaw("/icon") > 1341f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("\n");
		}
	}

	// Token: 0x0600BDA1 RID: 48545 RVA: 0x0044E526 File Offset: 0x0044C726
	public void FHGKIOOMMOH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDA2 RID: 48546 RVA: 0x0044E526 File Offset: 0x0044C726
	public void PMPKMGKAAJH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDA3 RID: 48547 RVA: 0x0044E526 File Offset: 0x0044C726
	public void FIKFJDFELIP()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDA4 RID: 48548 RVA: 0x0044FE2C File Offset: 0x0044E02C
	public void GGLOGIGAJCA()
	{
		if (!base.IBKCMBIGOEJ().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("maps.") < 1139f || Input.GetAxisRaw("Hidden/LensAberrations") > 555f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(". Prefab must have a PhotonView component.");
		}
		if (this.KNCGPFGKKAB <= 1096f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)5))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("_Value4") < 1707f || Input.GetAxisRaw("_Value") > 421f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Colorisation");
		}
	}

	// Token: 0x0600BDA5 RID: 48549 RVA: 0x0044E526 File Offset: 0x0044C726
	public void Start()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDA6 RID: 48550 RVA: 0x0044FFD4 File Offset: 0x0044E1D4
	public void OBPFNGKAOLD()
	{
		if (!base.FFIPLLNKGEN().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("/") < 940f || Input.GetAxisRaw("Missing shader in ") > 592f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/FX_Plasma");
		}
		if (this.KNCGPFGKKAB <= 304f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-74)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("Received your NickName from server. Updating local value to: {0}") < 26f || Input.GetAxisRaw("_Fade") > 1219f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Data/Skins/");
		}
	}

	// Token: 0x0600BDA7 RID: 48551 RVA: 0x0045017C File Offset: 0x0044E37C
	public void NNHFKFEMONK()
	{
		if (!base.CIACEFBNDDJ().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("CameraFilterPack_eyes_vision_2") < 1205f || Input.GetAxisRaw(" from: ") > 476f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_MainTex2");
		}
		if (this.KNCGPFGKKAB <= 270f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-48)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("MAPS NOT FOUND") < 240f || Input.GetAxisRaw("OnClick") > 372f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_UserLutTex");
		}
	}

	// Token: 0x0600BDA8 RID: 48552 RVA: 0x00450324 File Offset: 0x0044E524
	public void CCMPJCKFHIN()
	{
		if (!base.BLMHOKPIMOD().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value2") < 1685f || Input.GetAxisRaw("CameraFilterPack/Film_Grain") > 1886f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(":");
		}
		if (this.KNCGPFGKKAB <= 543f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Semicolon))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("s") < 839f || Input.GetAxisRaw("CameraFilterPack/Blend2Camera_HardLight") > 1872f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("\nv.");
		}
	}

	// Token: 0x0600BDA9 RID: 48553 RVA: 0x0044E526 File Offset: 0x0044C726
	public void IDJKNBDKHBD()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAA RID: 48554 RVA: 0x0044E526 File Offset: 0x0044C726
	public void PDHKMDBNGGN()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAB RID: 48555 RVA: 0x0044E526 File Offset: 0x0044C726
	public void FNCDAPDOBBI()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAC RID: 48556 RVA: 0x0044E526 File Offset: 0x0044C726
	public void PAKPHKPDKGE()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAD RID: 48557 RVA: 0x0044E526 File Offset: 0x0044C726
	public void KNBJBNDGCIJ()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAE RID: 48558 RVA: 0x0044E526 File Offset: 0x0044C726
	public void EFJDNLGNACH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDAF RID: 48559 RVA: 0x004504CC File Offset: 0x0044E6CC
	public void ENDMKGLNGPG()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_MainTex2") < 1199f || Input.GetAxisRaw("RPC can't be sent to target PhotonPlayer being null! Did not send \"") > 744f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("RequestForPickupItems");
		}
		if (this.KNCGPFGKKAB <= 1431f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Comma))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("y") < 1283f || Input.GetAxisRaw("_Value1") > 1065f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("OxOD.lastPath");
		}
	}

	// Token: 0x0600BDB0 RID: 48560 RVA: 0x0044E526 File Offset: 0x0044C726
	public void BGDPIHMAACO()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDB1 RID: 48561 RVA: 0x00450674 File Offset: 0x0044E874
	public void MAPJKNBGKFG()
	{
		if (!base.OELHGNKAMEG().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1799f || Input.GetAxisRaw("shader.sunny") > 1412f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("settings_bindings_controller_type");
		}
		if (this.KNCGPFGKKAB <= 1442f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Tab))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("[PlayerController] ") < 1969f || Input.GetAxisRaw("skin.") > 1421f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("0");
		}
	}

	// Token: 0x0600BDB2 RID: 48562 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DAHFFNNIGML()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDB3 RID: 48563 RVA: 0x0045081C File Offset: 0x0044EA1C
	public void LMCGIOCFGMH()
	{
		if (!base.AAMNKPHHHCI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value") < 727f || Input.GetAxisRaw("Object ID. Case-Sensitive") > 1717f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("[PlayerController] ");
		}
		if (this.KNCGPFGKKAB <= 1695f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-100)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw(".") < 637f || Input.GetAxisRaw("_ScreenResolution") > 232f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Horizontal");
		}
	}

	// Token: 0x0600BDB4 RID: 48564 RVA: 0x004509C4 File Offset: 0x0044EBC4
	public void HEPPILHCKJC()
	{
		if (!base.JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("Mouse") < 223f || Input.GetAxisRaw("Result for ") > 1347f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_ScreenResolution");
		}
		if (this.KNCGPFGKKAB <= 1583f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.I))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("[EditorEvent] Exception: ") < 1463f || Input.GetAxisRaw("Exit to menu?") > 1482f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Visualize");
		}
	}

	// Token: 0x0600BDB5 RID: 48565 RVA: 0x00450B6C File Offset: 0x0044ED6C
	public void IFMMDLHMDOB()
	{
		if (!base.GBMJAPGLMGB().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("[EMPTY]") < 1885f || Input.GetAxisRaw("???") > 51f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(",");
		}
		if (this.KNCGPFGKKAB <= 1374f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Y))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}") < 1864f || Input.GetAxisRaw("settings.hitvariation") > 1923f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		}
	}

	// Token: 0x0600BDB6 RID: 48566 RVA: 0x00450D14 File Offset: 0x0044EF14
	public void GCJNCABKDHI()
	{
		if (!base.IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("ResetSpeed") < 1104f || Input.GetAxisRaw("menu.enableselectormusic") > 1091f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw(",");
		}
		if (this.KNCGPFGKKAB <= 946f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-6)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("_ScreenResolution") < 115f || Input.GetAxisRaw("float,2") > 991f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Value5");
		}
	}

	// Token: 0x0600BDB7 RID: 48567 RVA: 0x00450EBC File Offset: 0x0044F0BC
	public void PMBBMCDEHBG()
	{
		if (!base.EDIJKHEMPAD().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("_BlurRadius") < 1169f || Input.GetAxisRaw("_Value2") > 666f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Blend2Camera_LinearBurn");
		}
		if (this.KNCGPFGKKAB <= 1123f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Z))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("\" on viewID ") < 1620f || Input.GetAxisRaw("_ScreenResolution") > 1445f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("mapselector.orderby");
		}
	}

	// Token: 0x0600BDB8 RID: 48568 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DLBODOFAJGM()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDB9 RID: 48569 RVA: 0x00451064 File Offset: 0x0044F264
	public void MFMILEABJBO()
	{
		if (!base.EOOCGIFFKBG().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("SetSatelliteRadius") < 70f || Input.GetAxisRaw(".g") > 1625f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("HandsCountSlider");
		}
		if (this.KNCGPFGKKAB <= 1957f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Ampersand))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("ControllerLeftY") < 1502f || Input.GetAxisRaw("#activechallenges") > 1864f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Edge_Edge_filter");
		}
	}

	// Token: 0x0600BDBA RID: 48570 RVA: 0x0044E526 File Offset: 0x0044C726
	public void BEBNOKFLJPH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDBC RID: 48572 RVA: 0x0044E526 File Offset: 0x0044C726
	public void DIPDEHOOBPG()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDBD RID: 48573 RVA: 0x0044E526 File Offset: 0x0044C726
	public void MJEFMIPLFAB()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDBE RID: 48574 RVA: 0x00451234 File Offset: 0x0044F434
	public void APMCMFKPPNE()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_Linecount") < 1909f || Input.GetAxisRaw("grid") > 1315f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_AdaptationMax");
		}
		if (this.KNCGPFGKKAB <= 203f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)14))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("#done") < 1488f || Input.GetAxisRaw("0.00") > 1631f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Blue_R");
		}
	}

	// Token: 0x0600BDBF RID: 48575 RVA: 0x0044E526 File Offset: 0x0044C726
	public void MMOKKAPFGAK()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDC0 RID: 48576 RVA: 0x0044E526 File Offset: 0x0044C726
	public void FLKEJJEGCFA()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDC1 RID: 48577 RVA: 0x0044E526 File Offset: 0x0044C726
	public void KOJKBFDNGDK()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDC2 RID: 48578 RVA: 0x004513DC File Offset: 0x0044F5DC
	public void FixedUpdate()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("Horizontal") < -0.1f || Input.GetAxisRaw("Horizontal") > 0.1f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Horizontal");
		}
		if (this.KNCGPFGKKAB <= 0f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Space))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("Vertical") < -0.1f || Input.GetAxisRaw("Vertical") > 0.1f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Vertical");
		}
	}

	// Token: 0x0600BDC3 RID: 48579 RVA: 0x0044E526 File Offset: 0x0044C726
	public void JHANGPCOCIG()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDC4 RID: 48580 RVA: 0x00451584 File Offset: 0x0044F784
	public void HGNJDPGPCEL()
	{
		if (!base.GBHNDHLAJLI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("Connection error: ") < 905f || Input.GetAxisRaw("_Linecount") > 1458f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("time");
		}
		if (this.KNCGPFGKKAB <= 710f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.DoubleQuote))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Atmosphere_Rain") < 449f || Input.GetAxisRaw("Please attach component to a Graphical UI component") > 884f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Distortion");
		}
	}

	// Token: 0x0600BDC5 RID: 48581 RVA: 0x0045172C File Offset: 0x0044F92C
	public void LGOHDOFFKIB()
	{
		if (!base.OELHGNKAMEG().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("0") < 1616f || Input.GetAxisRaw("Bad parameters for delete! Use <key>") > 374f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("UsernameText");
		}
		if (this.KNCGPFGKKAB <= 562f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)84))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("_Intensity") < 520f || Input.GetAxisRaw("CameraFilterPack/Blend2Camera_LinearLight") > 1717f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Bad parameters for getbool! Use <key> <value>");
		}
	}

	// Token: 0x0600BDC6 RID: 48582 RVA: 0x004518D4 File Offset: 0x0044FAD4
	public void ADIHLKFGDPL()
	{
		if (!base.AAMNKPHHHCI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw(".sav") < 1917f || Input.GetAxisRaw("Up") > 1420f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Film_Grain");
		}
		if (this.KNCGPFGKKAB <= 1690f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Q))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("ViewMenu") < 1642f || Input.GetAxisRaw("Crosshair2") > 592f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Can't execute Disconnect() while not connected. Nothing changed. State: {0}");
		}
	}

	// Token: 0x0600BDC7 RID: 48583 RVA: 0x00451A7C File Offset: 0x0044FC7C
	public void HBLIJHPIGBF()
	{
		if (!base.IBKCMBIGOEJ().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("ResetButton") < 1812f || Input.GetAxisRaw("MapEnd") > 1116f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_Far");
		}
		if (this.KNCGPFGKKAB <= 519f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-34)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw(" has no method \"") < 570f || Input.GetAxisRaw("L1") > 1512f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("/icon");
		}
	}

	// Token: 0x0600BDC8 RID: 48584 RVA: 0x0044E526 File Offset: 0x0044C726
	public void COIJKMKIEAK()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDC9 RID: 48585 RVA: 0x00451C24 File Offset: 0x0044FE24
	public void OKFECANLIHE()
	{
		if (!base.EDIJKHEMPAD().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("SetTrailZoomSpeed") < 1015f || Input.GetAxisRaw("#,0") > 786f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("RoomPlayersCountText");
		}
		if (this.KNCGPFGKKAB <= 598f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey(KeyCode.Exclaim))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("EventData0DropDownList") < 513f || Input.GetAxisRaw("_MatrixColor") > 199f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("LevelProgressBar");
		}
	}

	// Token: 0x0600BDCA RID: 48586 RVA: 0x00451DCC File Offset: 0x0044FFCC
	public void ECKBEJEAKEE()
	{
		if (!base.GBMJAPGLMGB().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("FrostCanvas") < 1310f || Input.GetAxisRaw("_ScreenSize") > 1291f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("???");
		}
		if (this.KNCGPFGKKAB <= 801f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-64)))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("LogStats") < 1713f || Input.GetAxisRaw("Right Stick Click") > 222f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("Joystick1Button8");
		}
	}

	// Token: 0x0600BDCB RID: 48587 RVA: 0x0044E526 File Offset: 0x0044C726
	public void KMCPMOGKDEH()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDCC RID: 48588 RVA: 0x0044E526 File Offset: 0x0044C726
	public void NNFMIAFHMJM()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDCD RID: 48589 RVA: 0x00451F74 File Offset: 0x00450174
	public void HKKIBBNMNDD()
	{
		if (!base.FFIPLLNKGEN().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("ArcsNoHitsoundTimeDelaySlider") < 643f || Input.GetAxisRaw("The given 2D texture ") > 1023f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("EventData0DropDownList");
		}
		if (this.KNCGPFGKKAB <= 227f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)14))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("#close") < 44f || Input.GetAxisRaw("EditMenu") > 1351f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("DPADHOR");
		}
	}

	// Token: 0x0600BDCE RID: 48590 RVA: 0x0044E526 File Offset: 0x0044C726
	public void HMPGIFBJFIK()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDCF RID: 48591 RVA: 0x0044E526 File Offset: 0x0044C726
	public void GPNAOAKCMHC()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDD0 RID: 48592 RVA: 0x0045211C File Offset: 0x0045031C
	public void FNALDLBGCJA()
	{
		if (!base.JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw(" has been disabled as it's not supported on the current platform.") < 789f || Input.GetAxisRaw("2hands") > 399f)
		{
			base.transform.position += Vector3.right * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Edge_Sobel");
		}
		if (this.KNCGPFGKKAB <= 751f)
		{
			if ((this.AELEPMINKFF != null || this.NHHFOFMNODM != null) && Input.GetKey((KeyCode)71))
			{
				this.KNCGPFGKKAB = this.JumpTimeout;
				Vector2 vector = Vector2.up * this.JumpForce;
				if (this.NHHFOFMNODM != null)
				{
					this.NHHFOFMNODM.AddForce(vector);
				}
				else if (this.AELEPMINKFF != null)
				{
					this.AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			this.KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!this.FPDMMJNCMED && (Input.GetAxisRaw("Copy from ") < 506f || Input.GetAxisRaw("_ScreenResolution") > 1109f))
		{
			base.transform.position += Vector3.forward * (this.Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	// Token: 0x0600BDD1 RID: 48593 RVA: 0x0044E526 File Offset: 0x0044C726
	public void KIMMMCJFMAB()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDD2 RID: 48594 RVA: 0x0044E526 File Offset: 0x0044C726
	public void IMCKJCHKMKB()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BDD3 RID: 48595 RVA: 0x0044E526 File Offset: 0x0044C726
	public void JOPCCCCHNLI()
	{
		this.FPDMMJNCMED = (base.GetComponent<SpriteRenderer>() != null);
		this.NHHFOFMNODM = base.GetComponent<Rigidbody2D>();
		this.AELEPMINKFF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x04001642 RID: 5698
	public float Speed = 10f;

	// Token: 0x04001643 RID: 5699
	public float JumpForce = 200f;

	// Token: 0x04001644 RID: 5700
	public float JumpTimeout = 0.5f;

	// Token: 0x04001645 RID: 5701
	private bool FPDMMJNCMED;

	// Token: 0x04001646 RID: 5702
	private float KNCGPFGKKAB;

	// Token: 0x04001647 RID: 5703
	private Rigidbody AELEPMINKFF;

	// Token: 0x04001648 RID: 5704
	private Rigidbody2D NHHFOFMNODM;
}
