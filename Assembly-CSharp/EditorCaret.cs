using System;
using UnityEngine;

// Token: 0x020003B0 RID: 944
public class EditorCaret : MonoBehaviour
{
	// Token: 0x0600D3E8 RID: 54248 RVA: 0x004BC768 File Offset: 0x004BA968
	private void AGMJDGHLBMN()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 422f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1191f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 14), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 0 : -40), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -36), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -109), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3E9 RID: 54249 RVA: 0x004BC9E0 File Offset: 0x004BABE0
	private void IDIIELPAMCJ()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1728f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 741f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 7 : -37), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : -27), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 23), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 0 : 20), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3EA RID: 54250 RVA: 0x004BCC58 File Offset: 0x004BAE58
	private void BGFJOEPFOPM()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 49f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1719f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 80), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -116), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -7), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : -83), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3EB RID: 54251 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void JILOMOBDPIA()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3EC RID: 54252 RVA: 0x004BCEF0 File Offset: 0x004BB0F0
	private void FABKIGNFECE()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1673f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 312f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 16), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -123), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -98), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -26), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3ED RID: 54253 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void FEHCNJLLJMP()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3EE RID: 54254 RVA: 0x004BD168 File Offset: 0x004BB368
	private void JAAJECBCCFM()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 326f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1681f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -96), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : -106), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -104), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 77), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3EF RID: 54255 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void KLILJHJNICK()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3F0 RID: 54256 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void NNCCPEBIAKH()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3F1 RID: 54257 RVA: 0x004BD3E0 File Offset: 0x004BB5E0
	private void GHILDCBCDJI()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1968f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1163f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 63), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 0 : 110), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 57), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -9), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F2 RID: 54258 RVA: 0x004BD658 File Offset: 0x004BB858
	private void LEAHIBJDMBI()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 297f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 971f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : -115), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 114), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -24), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : -72), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F3 RID: 54259 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void KIMMMCJFMAB()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3F4 RID: 54260 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void Start()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3F5 RID: 54261 RVA: 0x004BD8D0 File Offset: 0x004BBAD0
	private void ONMGIPAILOH()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 294f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1624f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 72), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 8 : -21), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 69), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : -102), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F6 RID: 54262 RVA: 0x004BDB48 File Offset: 0x004BBD48
	private void Update()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 0f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -2), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -2), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -2), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -2), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F7 RID: 54263 RVA: 0x004BDDC0 File Offset: 0x004BBFC0
	private void AAPKBNDHBLI()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1979f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1000f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -3), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : -46), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 0 : -44), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 116), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F8 RID: 54264 RVA: 0x004BE038 File Offset: 0x004BC238
	private void JOACBIEHHCE()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 710f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1302f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : 44), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -30), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : 53), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -16), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3F9 RID: 54265 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void NCNPAKFAFOE()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3FB RID: 54267 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void NBGIMIDICKE()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3FC RID: 54268 RVA: 0x004BE2D8 File Offset: 0x004BC4D8
	private void AIJGAJIOJDJ()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 1360f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 607f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : -126), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : 97), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -92), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : -128), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3FD RID: 54269 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void CCLNNLCOPBL()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D3FE RID: 54270 RVA: 0x004BE550 File Offset: 0x004BC750
	private void MFMIODIAKNI()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 720f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 259f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 19), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : -69), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -58), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -16), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D3FF RID: 54271 RVA: 0x004BE7C8 File Offset: 0x004BC9C8
	private void KCDOMIJBFLL()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 991f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 378f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 22), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -1), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : 63), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 0 : 22), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D400 RID: 54272 RVA: 0x004BEA40 File Offset: 0x004BCC40
	private void NKLIHNJCHOG()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 224f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 853f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : 52), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : -22), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 3 : 125), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 2 : -57), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0600D401 RID: 54273 RVA: 0x004BCED0 File Offset: 0x004BB0D0
	private void KDMANOEMOCA()
	{
		this.LBFPCCEFBBL = Singleton<MapEditor>.Instance;
		this.CPCNODILEAE = base.transform.localScale;
	}

	// Token: 0x0600D402 RID: 54274 RVA: 0x004BECB8 File Offset: 0x004BCEB8
	private void LLJLDLLNFBH()
	{
		if (this.useScale)
		{
			base.transform.localScale = new Vector3(Camera.main.orthographicSize / 51f * this.scaleSize, this.CPCNODILEAE.y, this.CPCNODILEAE.z);
		}
		if (this.lerpSpeed > 1231f)
		{
			float num = Mathf.Lerp(base.transform.position.x, this.LBFPCCEFBBL.currentTime, Time.deltaTime * this.lerpSpeed);
			if (this.moveOnlyWhenPlaying)
			{
				if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying)
				{
					if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
					{
						base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 5 : -94), Time.deltaTime * this.lerpSpeed), this.z);
					}
					else
					{
						base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 6 : -75), this.z), Time.deltaTime * this.lerpSpeed);
					}
				}
			}
			else if (this.LBFPCCEFBBL.audioSampler.audioSources[this.asourceid].isPlaying && this.forcePosition)
			{
				base.transform.position = new Vector3(num, Mathf.Lerp(base.transform.position.y, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 1 : -58), Time.deltaTime * this.lerpSpeed), this.z);
			}
			else
			{
				base.transform.position = Vector3.Lerp(base.transform.position, new Vector3(num, (float)((this.LBFPCCEFBBL.currentEventsCanvasId != 0) ? 4 : -92), this.z), Time.deltaTime * this.lerpSpeed);
			}
		}
	}

	// Token: 0x0400183A RID: 6202
	private MapEditor LBFPCCEFBBL;

	// Token: 0x0400183B RID: 6203
	private Vector3 CPCNODILEAE;

	// Token: 0x0400183C RID: 6204
	public float z;

	// Token: 0x0400183D RID: 6205
	public float lerpSpeed = 5f;

	// Token: 0x0400183E RID: 6206
	public int asourceid;

	// Token: 0x0400183F RID: 6207
	public bool moveOnlyWhenPlaying;

	// Token: 0x04001840 RID: 6208
	public bool forcePosition;

	// Token: 0x04001841 RID: 6209
	public bool useScale = true;

	// Token: 0x04001842 RID: 6210
	public float scaleSize = 1f;

	// Token: 0x04001843 RID: 6211
	private float CGCGPJAEDII;
}
