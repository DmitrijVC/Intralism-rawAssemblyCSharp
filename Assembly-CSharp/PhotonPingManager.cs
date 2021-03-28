using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200031B RID: 795
public class PhotonPingManager
{
	// Token: 0x0600B5A3 RID: 46499 RVA: 0x0042CA94 File Offset: 0x0042AC94
	public Region CPIJHGIHFIA()
	{
		Region result = null;
		int num = -127;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("CameraFilterPack/Drawing_Crosshatch" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5A4 RID: 46500 RVA: 0x0042CB28 File Offset: 0x0042AD28
	public IEnumerator NBFPMBGKCMI(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		PhotonPing photonPing;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		float num = 0f;
		int num2 = 0;
		string text = LPCNAHJGAFK.HostAndPort;
		int num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		int num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (int i = 0; i < PhotonPingManager.Attempts; i++)
		{
			bool flag = false;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			int num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5A5 RID: 46501 RVA: 0x0042CB4C File Offset: 0x0042AD4C
	public IEnumerator FHHDJCPNGIN(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5A6 RID: 46502 RVA: 0x0042CB70 File Offset: 0x0042AD70
	public IEnumerator JFDEKPDPCHA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5A7 RID: 46503 RVA: 0x0042CB92 File Offset: 0x0042AD92
	public bool IIHOBCPFMKL()
	{
		return this.LAONIGHJPPD == 0;
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x0600B5A8 RID: 46504 RVA: 0x0042CB92 File Offset: 0x0042AD92
	public bool Done
	{
		get
		{
			return this.LAONIGHJPPD == 0;
		}
	}

	// Token: 0x0600B5A9 RID: 46505 RVA: 0x0042CBA0 File Offset: 0x0042ADA0
	public static string EAICGEHOBJG(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			foreach (IPAddress ipaddress in hostAddresses)
			{
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("ERROR: Make sure your mod contains at leats one file!"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("ResetSpeed" + ex.Source + "_Value2" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5AA RID: 46506 RVA: 0x0042CC68 File Offset: 0x0042AE68
	public IEnumerator AAGHAIHLDIO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5AB RID: 46507 RVA: 0x0042CC8C File Offset: 0x0042AE8C
	public IEnumerator AAHGEGBEAHG(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5AC RID: 46508 RVA: 0x0042CCB0 File Offset: 0x0042AEB0
	public Region JLPHEDADGMD()
	{
		Region result = null;
		int num = -139;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("open" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5AD RID: 46509 RVA: 0x0042CD44 File Offset: 0x0042AF44
	public Region DDFFPPECOAA()
	{
		Region result = null;
		int num = 59;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("_Saturation" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5AE RID: 46510 RVA: 0x0042CDD8 File Offset: 0x0042AFD8
	public IEnumerator EPELHCLFNEK(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5AF RID: 46511 RVA: 0x0042CDFA File Offset: 0x0042AFFA
	public bool PMKLFOJMBKA()
	{
		return this.LAONIGHJPPD == 1;
	}

	// Token: 0x0600B5B0 RID: 46512 RVA: 0x0042CE08 File Offset: 0x0042B008
	public IEnumerator MCEMKLGEEBO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5B1 RID: 46513 RVA: 0x0042CDFA File Offset: 0x0042AFFA
	public bool BDBENNCJCGE()
	{
		return this.LAONIGHJPPD == 1;
	}

	// Token: 0x0600B5B2 RID: 46514 RVA: 0x0042CDFA File Offset: 0x0042AFFA
	public bool DMBEPHNHMHB()
	{
		return this.LAONIGHJPPD == 1;
	}

	// Token: 0x0600B5B3 RID: 46515 RVA: 0x0042CE2C File Offset: 0x0042B02C
	public static string CPJNNIFJPMC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("0,1,false"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("_Val3" + ex.Source + "_Value2" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5B4 RID: 46516 RVA: 0x0042CEF4 File Offset: 0x0042B0F4
	public IEnumerator FGAEIKABKNO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5B5 RID: 46517 RVA: 0x0042CF18 File Offset: 0x0042B118
	public Region NFBJHHENDCG()
	{
		Region result = null;
		int num = 178;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.ILANOBPPIBF())
		{
			UnityEngine.Debug.Log("GlassesColor2" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5B6 RID: 46518 RVA: 0x0042CFAC File Offset: 0x0042B1AC
	public static string FFKNLHJKFIM(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i++)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("Offline or in OfflineMode. No VitalStats available."))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("CameraFilterPack_AAA_BloodOnScreen1" + ex.Source + "_Intensity" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5B7 RID: 46519 RVA: 0x0042D074 File Offset: 0x0042B274
	public IEnumerator IJIAAMFLGLL(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5B8 RID: 46520 RVA: 0x0042D098 File Offset: 0x0042B298
	public IEnumerator FJOFJMFCCOJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5B9 RID: 46521 RVA: 0x0042CB92 File Offset: 0x0042AD92
	public bool BOFENDOCGOJ()
	{
		return this.LAONIGHJPPD == 0;
	}

	// Token: 0x0600B5BA RID: 46522 RVA: 0x0042D0BC File Offset: 0x0042B2BC
	public static string GPCLGBNNMFO(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains(" registered."))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("settings.disablestoryboard" + ex.Source + "BitsData" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5BB RID: 46523 RVA: 0x0042D184 File Offset: 0x0042B384
	public static string LDIFPCKBMBC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress ipaddress in hostAddresses)
			{
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("_Value2"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("maps." + ex.Source + "skin." + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5BC RID: 46524 RVA: 0x0042D24C File Offset: 0x0042B44C
	public IEnumerator DEKCJCBJCPA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5BD RID: 46525 RVA: 0x0042D270 File Offset: 0x0042B470
	public IEnumerator KBNFDPGCDBJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5BE RID: 46526 RVA: 0x0042D294 File Offset: 0x0042B494
	public static string MJFAIPIAHAM(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[1].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("CameraFilterPack/TV_PlanetMars"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("y" + ex.Source + "_TimeX" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5BF RID: 46527 RVA: 0x0042D35C File Offset: 0x0042B55C
	public Region ENHDLNKECPF()
	{
		Region result = null;
		int num = 128;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log("_RGB" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5C0 RID: 46528 RVA: 0x0042D3F0 File Offset: 0x0042B5F0
	public IEnumerator EIPLJCBOBPA(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C1 RID: 46529 RVA: 0x0042D414 File Offset: 0x0042B614
	public Region NJFAIHPONKD()
	{
		Region result = null;
		int num = 124;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.GBEHEEIMNDO())
		{
			UnityEngine.Debug.Log(" : " + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x0600B5C2 RID: 46530 RVA: 0x0042D4A8 File Offset: 0x0042B6A8
	public static string ResolveHost(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress ipaddress in hostAddresses)
			{
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains(":"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("Exception caught! " + ex.Source + " Message: " + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5C3 RID: 46531 RVA: 0x0042D570 File Offset: 0x0042B770
	public IEnumerator JHCFCNGNLMB(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C4 RID: 46532 RVA: 0x0042D594 File Offset: 0x0042B794
	public static string IMOLKLDMGFN(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("_MainTex"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("Fill Area" + ex.Source + "[LocalizationService] All languages: " + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5C5 RID: 46533 RVA: 0x0042D65C File Offset: 0x0042B85C
	public IEnumerator FAIHGNPBNHO(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C6 RID: 46534 RVA: 0x0042D680 File Offset: 0x0042B880
	public IEnumerator PingSocket(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C7 RID: 46535 RVA: 0x0042D6A4 File Offset: 0x0042B8A4
	public IEnumerator MGIILGNOEIB(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C8 RID: 46536 RVA: 0x0042D6C8 File Offset: 0x0042B8C8
	public IEnumerator NPIDOHABGBI(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5C9 RID: 46537 RVA: 0x0042D6EC File Offset: 0x0042B8EC
	public static string EBAAOAHBNDA(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[0].ToString();
			}
			foreach (IPAddress ipaddress in hostAddresses)
			{
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("_Value"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("76561198041679481" + ex.Source + "Scrollbar" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5CA RID: 46538 RVA: 0x0042D7B4 File Offset: 0x0042B9B4
	public IEnumerator JFIKCFLOIEJ(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5CB RID: 46539 RVA: 0x0042D7D8 File Offset: 0x0042B9D8
	public IEnumerator IGKIIGGLPIF(Region LPCNAHJGAFK)
	{
		LPCNAHJGAFK.Ping = PhotonPingManager.Attempts * PhotonPingManager.MaxMilliseconsPerPing;
		this.LAONIGHJPPD++;
		if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeDynamic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeDynamic()");
			photonPing = new PingNativeDynamic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingNativeStatic))
		{
			UnityEngine.Debug.Log("Using constructor for new PingNativeStatic()");
			photonPing = new PingNativeStatic();
		}
		else if (PhotonHandler.LEILCLLNGGH == typeof(PingMono))
		{
			photonPing = new PingMono();
		}
		else
		{
			photonPing = (PhotonPing)Activator.CreateInstance(PhotonHandler.LEILCLLNGGH);
		}
		num = 0f;
		num2 = 0;
		text = LPCNAHJGAFK.HostAndPort;
		num3 = text.LastIndexOf(':');
		if (num3 > 1)
		{
			text = text.Substring(0, num3);
		}
		num4 = text.IndexOf("wss://");
		if (num4 > -1)
		{
			text = text.Substring(num4 + "wss://".Length);
		}
		text = PhotonPingManager.ResolveHost(text);
		for (i = 0; i < PhotonPingManager.Attempts; i++)
		{
			flag = false;
			stopwatch = new Stopwatch();
			stopwatch.Start();
			try
			{
				photonPing.StartPing(text);
			}
			catch (Exception arg)
			{
				UnityEngine.Debug.Log("catched: " + arg);
				this.LAONIGHJPPD--;
				break;
			}
			while (!photonPing.Done())
			{
				if (stopwatch.ElapsedMilliseconds >= (long)PhotonPingManager.MaxMilliseconsPerPing)
				{
					flag = true;
					break;
				}
				yield return 0;
			}
			num5 = (int)stopwatch.ElapsedMilliseconds;
			if (!PhotonPingManager.IgnoreInitialAttempt || i != 0)
			{
				if (photonPing.Successful && !flag)
				{
					num += (float)num5;
					num2++;
					LPCNAHJGAFK.Ping = (int)(num / (float)num2);
				}
			}
			yield return new WaitForSeconds(0.1f);
		}
		photonPing.Dispose();
		this.LAONIGHJPPD--;
		yield return null;
		yield break;
	}

	// Token: 0x0600B5CD RID: 46541 RVA: 0x0042CB92 File Offset: 0x0042AD92
	public bool GMACBIJPBFB()
	{
		return this.LAONIGHJPPD == 0;
	}

	// Token: 0x0600B5CE RID: 46542 RVA: 0x0042D814 File Offset: 0x0042BA14
	public Region FNMKAPINHCA()
	{
		Region result = null;
		int num = -64;
		foreach (Region region in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			UnityEngine.Debug.Log("USE_UV_BASED_REPROJECTION" + region);
			if (region.Ping != 0 && region.Ping < num)
			{
				num = region.Ping;
				result = region;
			}
		}
		return result;
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x0600B5CF RID: 46543 RVA: 0x0042D8A8 File Offset: 0x0042BAA8
	public Region BestRegion
	{
		get
		{
			Region result = null;
			int num = int.MaxValue;
			foreach (Region region in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
			{
				UnityEngine.Debug.Log("BestRegion checks region: " + region);
				if (region.Ping != 0 && region.Ping < num)
				{
					num = region.Ping;
					result = region;
				}
			}
			return result;
		}
	}

	// Token: 0x0600B5D0 RID: 46544 RVA: 0x0042D93C File Offset: 0x0042BB3C
	public static string FMPAOKDMAAC(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 0)
			{
				return hostAddresses[1].ToString();
			}
			foreach (IPAddress ipaddress in hostAddresses)
			{
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("CameraFilterPack/BlurTiltShift_V"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("workshop." + ex.Source + "_TapLow" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5D1 RID: 46545 RVA: 0x0042DA04 File Offset: 0x0042BC04
	public static string PFKKPPHFLDK(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 1; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("Event Received"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("ZoomSpeed" + ex.Source + "_Saturation" + ex.Message);
		}
		return text;
	}

	// Token: 0x0600B5D2 RID: 46546 RVA: 0x0042DACC File Offset: 0x0042BCCC
	public static string GBMJMBGHMGE(string DIBNLGMIJMN)
	{
		string text = string.Empty;
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(DIBNLGMIJMN);
			if (hostAddresses.Length == 1)
			{
				return hostAddresses[0].ToString();
			}
			for (int i = 0; i < hostAddresses.Length; i += 0)
			{
				IPAddress ipaddress = hostAddresses[i];
				if (ipaddress != null)
				{
					if (ipaddress.ToString().Contains("Player"))
					{
						return ipaddress.ToString();
					}
					if (string.IsNullOrEmpty(text))
					{
						text = hostAddresses.ToString();
					}
				}
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log("_Near" + ex.Source + "CameraFilterPack/Light_Rainbow2" + ex.Message);
		}
		return text;
	}

	// Token: 0x04001560 RID: 5472
	public bool UseNative;

	// Token: 0x04001561 RID: 5473
	public static int Attempts = 5;

	// Token: 0x04001562 RID: 5474
	public static bool IgnoreInitialAttempt = true;

	// Token: 0x04001563 RID: 5475
	public static int MaxMilliseconsPerPing = 800;

	// Token: 0x04001564 RID: 5476
	private const string FGFMFHNMJOA = "wss://";

	// Token: 0x04001565 RID: 5477
	private int LAONIGHJPPD;
}
