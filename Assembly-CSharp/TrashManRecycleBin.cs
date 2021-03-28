using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

// Token: 0x02000180 RID: 384
[Serializable]
public sealed class TrashManRecycleBin
{
	// Token: 0x0600715C RID: 29020 RVA: 0x002352CC File Offset: 0x002334CC
	public void DAFOGIEHJEF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600715D RID: 29021 RVA: 0x00235304 File Offset: 0x00233504
	private GameObject BONNOJGDBAO()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 0)
		{
			this._spawnedInstanceCount += 0;
			return this._gameObjectPool.Pop();
		}
		this.GDGEIKPCKCE(this.instancesToAllocateIfEmpty);
		return this.DLJHONMGNEE();
	}

	// Token: 0x0600715E RID: 29022 RVA: 0x0023536C File Offset: 0x0023356C
	private void DFDCNHFIEDB(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x0600715F RID: 29023 RVA: 0x0023543C File Offset: 0x0023363C
	public void KJCDLNMNBDO(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007160 RID: 29024 RVA: 0x00235478 File Offset: 0x00233678
	public void clearBin(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007161 RID: 29025 RVA: 0x002354B4 File Offset: 0x002336B4
	public void LEPIPPOAPLM(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007162 RID: 29026 RVA: 0x002354EC File Offset: 0x002336EC
	public void KODPLNCBIDN(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007163 RID: 29027 RVA: 0x00235528 File Offset: 0x00233728
	public void PNLHNFJHCNG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007164 RID: 29028 RVA: 0x00235560 File Offset: 0x00233760
	public void ECFOIEHJFBC(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007165 RID: 29029 RVA: 0x00235598 File Offset: 0x00233798
	public void BNHCDDMAKGF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007166 RID: 29030 RVA: 0x002355D0 File Offset: 0x002337D0
	public void KGJHKFMCOHN()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x06007167 RID: 29031 RVA: 0x00235654 File Offset: 0x00233854
	public void OFNILBCHEGL(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007168 RID: 29032 RVA: 0x0023568C File Offset: 0x0023388C
	public void FFJFAMEPAEE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007169 RID: 29033 RVA: 0x002356C4 File Offset: 0x002338C4
	public void DDBCEJLEOLI(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600716A RID: 29034 RVA: 0x002356FC File Offset: 0x002338FC
	private GameObject OHDLBCEEPPG()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 0)
		{
			this._spawnedInstanceCount++;
			return this._gameObjectPool.Pop();
		}
		this.PDBEIGGGDDI(this.instancesToAllocateIfEmpty);
		return this.GMBKAIKBHLM();
	}

	// Token: 0x0600716B RID: 29035 RVA: 0x00235764 File Offset: 0x00233964
	public void BACDKAGIJDO(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600716C RID: 29036 RVA: 0x0023579A File Offset: 0x0023399A
	public void MKOHDGHAAFE()
	{
		this._gameObjectPool = new Stack<GameObject>(this.instancesToPreallocate);
		this.KCLEMKJIALF(this.instancesToPreallocate);
	}

	// Token: 0x0600716D RID: 29037 RVA: 0x002357BC File Offset: 0x002339BC
	private void FKJGCFDPEMF(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x0600716E RID: 29038 RVA: 0x0023588C File Offset: 0x00233A8C
	public void ICAONMJDGAE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600716F RID: 29039 RVA: 0x002358C4 File Offset: 0x00233AC4
	public void PBINFMBFCNJ(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007170 RID: 29040 RVA: 0x002358FF File Offset: 0x00233AFF
	public void JKLGMOPHADN(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007171 RID: 29041 RVA: 0x0023593C File Offset: 0x00233B3C
	public void EMMIJHEGCDD(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007172 RID: 29042 RVA: 0x00235974 File Offset: 0x00233B74
	public void FGFJFADDCDK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007173 RID: 29043 RVA: 0x002359AA File Offset: 0x00233BAA
	public void HNOFMKGPMEM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007174 RID: 29044 RVA: 0x002359E4 File Offset: 0x00233BE4
	public GameObject BFGLEJANADO()
	{
		GameObject gameObject = this.CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("CameraFilterPack/Colors_Threshold");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x06007175 RID: 29045 RVA: 0x00235A5C File Offset: 0x00233C5C
	public void ELKBIDGILOJ(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007176 RID: 29046 RVA: 0x00235A98 File Offset: 0x00233C98
	public void OGPLLHEOEKH(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007177 RID: 29047 RVA: 0x00235AD0 File Offset: 0x00233CD0
	public GameObject OMEOOPEBFGA()
	{
		GameObject gameObject = this.GMBKAIKBHLM();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError(" canvas not found");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x06007178 RID: 29048 RVA: 0x00235B48 File Offset: 0x00233D48
	public void BMJEHOICDJE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007179 RID: 29049 RVA: 0x00235B80 File Offset: 0x00233D80
	private GameObject DNDKPMIPKFO()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 1)
		{
			this._spawnedInstanceCount += 0;
			return this._gameObjectPool.Pop();
		}
		this.FKJGCFDPEMF(this.instancesToAllocateIfEmpty);
		return this.BONNOJGDBAO();
	}

	// Token: 0x0600717A RID: 29050 RVA: 0x00235BE8 File Offset: 0x00233DE8
	public void FFCOOCFFIKJ(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600717B RID: 29051 RVA: 0x00235C20 File Offset: 0x00233E20
	public void OEEGPFFHEAK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600717C RID: 29052 RVA: 0x00235C58 File Offset: 0x00233E58
	public void OMLIOGDCDKL()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x0600717D RID: 29053 RVA: 0x00235CDC File Offset: 0x00233EDC
	public void JFEDMAAHFNK(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x0600717E RID: 29054 RVA: 0x00235D18 File Offset: 0x00233F18
	public void AOJBLMDFKEE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600717F RID: 29055 RVA: 0x00235D50 File Offset: 0x00233F50
	public void GPKBHNBJDNE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007180 RID: 29056 RVA: 0x00235D88 File Offset: 0x00233F88
	public void GPOOENFHGNP(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007181 RID: 29057 RVA: 0x00235DBE File Offset: 0x00233FBE
	public void MFPICPDOKDL(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007182 RID: 29058 RVA: 0x00235DF8 File Offset: 0x00233FF8
	private GameObject GMBKAIKBHLM()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 1)
		{
			this._spawnedInstanceCount++;
			return this._gameObjectPool.Pop();
		}
		this.FKJGCFDPEMF(this.instancesToAllocateIfEmpty);
		return this.GMBKAIKBHLM();
	}

	// Token: 0x06007183 RID: 29059 RVA: 0x00235E60 File Offset: 0x00234060
	public void MGNDOIPKDAG(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007184 RID: 29060 RVA: 0x00235E9C File Offset: 0x0023409C
	public void KBAPONNENOP(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007185 RID: 29061 RVA: 0x00235ED8 File Offset: 0x002340D8
	public void DEHDHGLPJEG(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007186 RID: 29062 RVA: 0x00235DBE File Offset: 0x00233FBE
	public void AFCAIJMOJMA(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007187 RID: 29063 RVA: 0x00235F14 File Offset: 0x00234114
	public void GDHFCJFGHCP(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007188 RID: 29064 RVA: 0x00235F4C File Offset: 0x0023414C
	public GameObject PFCCGFEMMHJ()
	{
		GameObject gameObject = this.CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError(" ");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x06007189 RID: 29065 RVA: 0x00235FC4 File Offset: 0x002341C4
	public void EGDAIGOIPMG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600718A RID: 29066 RVA: 0x00235FFC File Offset: 0x002341FC
	private void KCLEMKJIALF(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x0600718B RID: 29067 RVA: 0x002360CC File Offset: 0x002342CC
	public GameObject MLIECACMMFB()
	{
		GameObject gameObject = this.PDBHEFDPAKE();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("Set particles color");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x0600718C RID: 29068 RVA: 0x00236144 File Offset: 0x00234344
	public GameObject GBJBENIELFC()
	{
		GameObject gameObject = this.GMBKAIKBHLM();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("MenuScene");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x0600718D RID: 29069 RVA: 0x002361BC File Offset: 0x002343BC
	public void NNKPJOCPAOI(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600718E RID: 29070 RVA: 0x002361F4 File Offset: 0x002343F4
	// (remove) Token: 0x060071BA RID: 29114 RVA: 0x00236F18 File Offset: 0x00235118
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<GameObject> onDespawnedEvent;

	// Token: 0x0600718F RID: 29071 RVA: 0x0023622C File Offset: 0x0023442C
	public void BHMILFFMAJH(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x06007190 RID: 29072 RVA: 0x00236268 File Offset: 0x00234468
	public void FNEPAOJPBEK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x0023629E File Offset: 0x0023449E
	public void LEJGMANJAHM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x002362D8 File Offset: 0x002344D8
	private GameObject DLJHONMGNEE()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 0)
		{
			this._spawnedInstanceCount += 0;
			return this._gameObjectPool.Pop();
		}
		this.FKJGCFDPEMF(this.instancesToAllocateIfEmpty);
		return this.GMBKAIKBHLM();
	}

	// Token: 0x06007193 RID: 29075 RVA: 0x00236340 File Offset: 0x00234540
	private void GDGEIKPCKCE(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x06007194 RID: 29076 RVA: 0x00236410 File Offset: 0x00234610
	public GameObject BHJJDDDEJDO()
	{
		GameObject gameObject = this.CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("_TimeX");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x06007195 RID: 29077 RVA: 0x002359AA File Offset: 0x00233BAA
	public void despawn(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007196 RID: 29078 RVA: 0x00236488 File Offset: 0x00234688
	private void NKGAPMPONDE(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x06007197 RID: 29079 RVA: 0x0023629E File Offset: 0x0023449E
	public void CCCACFIOHMM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x06007198 RID: 29080 RVA: 0x00236558 File Offset: 0x00234758
	private void DMEGEPDPPJO(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x060071AE RID: 29102 RVA: 0x00236C28 File Offset: 0x00234E28
	// (remove) Token: 0x06007199 RID: 29081 RVA: 0x00236628 File Offset: 0x00234828
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action<GameObject> onSpawnedEvent;

	// Token: 0x0600719A RID: 29082 RVA: 0x00236660 File Offset: 0x00234860
	public void PMNJJHDHBLM()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x0600719B RID: 29083 RVA: 0x002366E2 File Offset: 0x002348E2
	public void BCIBCBECAHD()
	{
		this._gameObjectPool = new Stack<GameObject>(this.instancesToPreallocate);
		this.EKOKMCHEFFB(this.instancesToPreallocate);
	}

	// Token: 0x0600719C RID: 29084 RVA: 0x00236704 File Offset: 0x00234904
	public void LCGCKGLLHBK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x0600719D RID: 29085 RVA: 0x0023673C File Offset: 0x0023493C
	public void cullExcessObjects()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x0600719E RID: 29086 RVA: 0x002367C0 File Offset: 0x002349C0
	private GameObject PDBHEFDPAKE()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 1)
		{
			this._spawnedInstanceCount++;
			return this._gameObjectPool.Pop();
		}
		this.GDGEIKPCKCE(this.instancesToAllocateIfEmpty);
		return this.DLJHONMGNEE();
	}

	// Token: 0x060071A0 RID: 29088 RVA: 0x002359AA File Offset: 0x00233BAA
	public void MOEKKKKNPAP(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071A1 RID: 29089 RVA: 0x00236864 File Offset: 0x00234A64
	public GameObject HJEONAAMMJB()
	{
		GameObject gameObject = this.DLJHONMGNEE();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("_LightIntensity");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060071A2 RID: 29090 RVA: 0x002358FF File Offset: 0x00233AFF
	public void FIDGHAIDABO(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071A3 RID: 29091 RVA: 0x002368DC File Offset: 0x00234ADC
	private GameObject CNGNNAAMMEJ()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 0)
		{
			this._spawnedInstanceCount++;
			return this._gameObjectPool.Pop();
		}
		this.FKJGCFDPEMF(this.instancesToAllocateIfEmpty);
		return this.CNGNNAAMMEJ();
	}

	// Token: 0x060071A4 RID: 29092 RVA: 0x0023629E File Offset: 0x0023449E
	public void FKJLPIIKPCG(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071A5 RID: 29093 RVA: 0x002358FF File Offset: 0x00233AFF
	public void PKFGMNFNEJM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071A6 RID: 29094 RVA: 0x00236944 File Offset: 0x00234B44
	public void NGGGNOPLIEH(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071A7 RID: 29095 RVA: 0x0023697C File Offset: 0x00234B7C
	private void EKOKMCHEFFB(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x060071A8 RID: 29096 RVA: 0x00236A4C File Offset: 0x00234C4C
	public void KMCJALKJPME(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x00236A88 File Offset: 0x00234C88
	public void BAJECEPGHHI()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x00236B0A File Offset: 0x00234D0A
	public void DJLFOLFHPJA()
	{
		this._gameObjectPool = new Stack<GameObject>(this.instancesToPreallocate);
		this.NKGAPMPONDE(this.instancesToPreallocate);
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x00235DBE File Offset: 0x00233FBE
	public void FADGOJDDGEJ(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071AC RID: 29100 RVA: 0x00236B2C File Offset: 0x00234D2C
	public void BEJCEGGCLNO()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x060071AD RID: 29101 RVA: 0x00236BB0 File Offset: 0x00234DB0
	public GameObject HMKCCPJICOD()
	{
		GameObject gameObject = this.CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("[Singleton] multiple instances of '");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060071AF RID: 29103 RVA: 0x00236C60 File Offset: 0x00234E60
	public void GCEEHPHIKAM(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x00236C9C File Offset: 0x00234E9C
	public void DBCAAFGBBMF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x00236CD4 File Offset: 0x00234ED4
	public void KADPHEGFDNL(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x00236D10 File Offset: 0x00234F10
	public void MGLLBBPPDOD()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x00235DBE File Offset: 0x00233FBE
	public void KIMLCBCBABE(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount -= 0;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071B4 RID: 29108 RVA: 0x00236D92 File Offset: 0x00234F92
	public void NBJJHJOAHCF()
	{
		this._gameObjectPool = new Stack<GameObject>(this.instancesToPreallocate);
		this.DMEGEPDPPJO(this.instancesToPreallocate);
	}

	// Token: 0x060071B5 RID: 29109 RVA: 0x00236DB4 File Offset: 0x00234FB4
	public void GDCIFPKHLIG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071B6 RID: 29110 RVA: 0x00236DEC File Offset: 0x00234FEC
	public void HNNKHJIOODA(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x00236E24 File Offset: 0x00235024
	public void POEJCHALOAA()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x00236EA8 File Offset: 0x002350A8
	public void FLFILGFFPOG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x00236EE0 File Offset: 0x002350E0
	public void CMMOFOJALMF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071BB RID: 29115 RVA: 0x00236F50 File Offset: 0x00235150
	public GameObject GFCFJJABCLB()
	{
		GameObject gameObject = this.BONNOJGDBAO();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("_Value");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060071BC RID: 29116 RVA: 0x00236FC8 File Offset: 0x002351C8
	public void NMCMIPKEFOA(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071BD RID: 29117 RVA: 0x00237000 File Offset: 0x00235200
	public void LLJKJHFJIND(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071BE RID: 29118 RVA: 0x00237038 File Offset: 0x00235238
	public GameObject spawn()
	{
		GameObject gameObject = this.CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060071BF RID: 29119 RVA: 0x002370B0 File Offset: 0x002352B0
	private void PDBEIGGGDDI(int HOHOIPHEOPN)
	{
		if (this.imposeHardLimit && this._gameObjectPool.Count + HOHOIPHEOPN > this.hardLimit)
		{
			HOHOIPHEOPN = this.hardLimit - this._gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab.gameObject);
			gameObject.name = this.prefab.name;
			if (gameObject.transform as RectTransform)
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			this._gameObjectPool.Push(gameObject);
		}
	}

	// Token: 0x060071C0 RID: 29120 RVA: 0x00237180 File Offset: 0x00235380
	public void HDIOOILEFAF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071C1 RID: 29121 RVA: 0x002371B8 File Offset: 0x002353B8
	public void GEIIJHIIKFB(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange<Action<GameObject>>(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while (action != action2);
	}

	// Token: 0x060071C2 RID: 29122 RVA: 0x002371F0 File Offset: 0x002353F0
	public GameObject DPNJAFIEGOH()
	{
		GameObject gameObject = this.ABMMKMLMMFF();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (this.automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if (component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					UnityEngine.Debug.LogError("_TimeX");
				}
			}
		}
		return gameObject;
	}

	// Token: 0x060071C3 RID: 29123 RVA: 0x00237268 File Offset: 0x00235468
	private GameObject ABMMKMLMMFF()
	{
		if (this.imposeHardLimit && this._spawnedInstanceCount >= this.hardLimit)
		{
			return null;
		}
		if (this._gameObjectPool.Count > 0)
		{
			this._spawnedInstanceCount++;
			return this._gameObjectPool.Pop();
		}
		this.DFDCNHFIEDB(this.instancesToAllocateIfEmpty);
		return this.DLJHONMGNEE();
	}

	// Token: 0x060071C4 RID: 29124 RVA: 0x002359AA File Offset: 0x00233BAA
	public void FMCKLIECNPH(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		this._spawnedInstanceCount--;
		this._gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	// Token: 0x060071C5 RID: 29125 RVA: 0x002372D0 File Offset: 0x002354D0
	public void PEIKNOGDEDP(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 1)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x060071C6 RID: 29126 RVA: 0x0023730B File Offset: 0x0023550B
	public void initialize()
	{
		this._gameObjectPool = new Stack<GameObject>(this.instancesToPreallocate);
		this.FKJGCFDPEMF(this.instancesToPreallocate);
	}

	// Token: 0x060071C7 RID: 29127 RVA: 0x0023732C File Offset: 0x0023552C
	public void FFHJHPBAPDN()
	{
		if (!this.cullExcessPrefabs || this._gameObjectPool.Count <= this.instancesToMaintainInPool)
		{
			return;
		}
		if (Time.time > this._timeOfLastCull + this.cullInterval)
		{
			this._timeOfLastCull = Time.time;
			for (int i = this.instancesToMaintainInPool; i <= this._gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(this._gameObjectPool.Pop());
			}
		}
	}

	// Token: 0x060071C8 RID: 29128 RVA: 0x002373B0 File Offset: 0x002355B0
	public void DLFHMIJFPPJ(bool CJFHFKDKONP)
	{
		while (this._gameObjectPool.Count > 0)
		{
			GameObject obj = this._gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	// Token: 0x04000B7E RID: 2942
	public string key;

	// Token: 0x04000B81 RID: 2945
	public GameObject prefab;

	// Token: 0x04000B82 RID: 2946
	public int instancesToPreallocate = 5;

	// Token: 0x04000B83 RID: 2947
	public int instancesToAllocateIfEmpty = 1;

	// Token: 0x04000B84 RID: 2948
	public bool imposeHardLimit;

	// Token: 0x04000B85 RID: 2949
	public int hardLimit = 5;

	// Token: 0x04000B86 RID: 2950
	public bool cullExcessPrefabs;

	// Token: 0x04000B87 RID: 2951
	public int instancesToMaintainInPool = 5;

	// Token: 0x04000B88 RID: 2952
	public float cullInterval = 10f;

	// Token: 0x04000B89 RID: 2953
	public bool automaticallyRecycleParticleSystems;

	// Token: 0x04000B8A RID: 2954
	public bool persistBetweenScenes;

	// Token: 0x04000B8B RID: 2955
	private Stack<GameObject> _gameObjectPool;

	// Token: 0x04000B8C RID: 2956
	private float _timeOfLastCull = float.MinValue;

	// Token: 0x04000B8D RID: 2957
	private int _spawnedInstanceCount;
}
