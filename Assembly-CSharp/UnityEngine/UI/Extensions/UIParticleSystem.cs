using System;
using UnityEngine.Sprites;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200026F RID: 623
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Effects/Extensions/UI Particle System")]
	[RequireComponent(typeof(ParticleSystem))]
	[RequireComponent(typeof(CanvasRenderer))]
	public class UIParticleSystem : MaskableGraphic
	{
		// Token: 0x060095CC RID: 38348 RVA: 0x003539D4 File Offset: 0x00351BD4
		private void Update()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, false);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095CD RID: 38349 RVA: 0x003539D4 File Offset: 0x00351BD4
		private void KKLMPKLKAEM()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, false);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void FJHFOBHJEHL()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture NDBACHFEANJ()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x00353A74 File Offset: 0x00351C74
		protected virtual void IAFFGPGHHKI(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1065f;
				float f = num + 746f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1995f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)7)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 498f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1894f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1450f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[6].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[4].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x00353FA4 File Offset: 0x003521A4
		protected virtual void GPPLMDLHPLL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1283f;
				float f = num + 1839f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 964f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)4)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1807f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 71f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1345f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[7].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x003544D2 File Offset: 0x003526D2
		protected virtual void FIABIKEIEKH()
		{
			base.Awake();
			if (!this.EFJAMHIHFHO())
			{
				base.enabled = false;
			}
		}

		// Token: 0x060095D4 RID: 38356 RVA: 0x003544EC File Offset: 0x003526EC
		private void PNLKFANNOKO()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture OMBDDJHNIGD()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x00354510 File Offset: 0x00352710
		protected virtual void HPBGFHAOCEB(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 986f;
				float f = num + 1547f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1239f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Shape)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1257f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1397f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 982f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[7].position = a + b + b2;
					this.PIHAOPOLJHA[4].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture FBMPAOGNEMF()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x00354A40 File Offset: 0x00352C40
		protected bool JCJFJDCJCGA()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_TimeX"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("ScrollPanel"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(544f, 1445f, 1798f, 527f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1165f / (float)this.GAOAIDNGCBB.numTilesX, 376f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture LMHOHFGANGL()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x00354C1C File Offset: 0x00352E1C
		protected virtual void PKHOCKPIJBP(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 252f;
				float f = num + 427f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 636f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Shape)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 8f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 315f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1180f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[0].position = a + b + b2;
					this.PIHAOPOLJHA[6].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x0035514A File Offset: 0x0035334A
		protected virtual void IKGFIOIADLN()
		{
			base.Awake();
			if (!this.ALIACDAODAH())
			{
				base.enabled = true;
			}
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x00355164 File Offset: 0x00353364
		protected virtual void FAAJAMIGJNK()
		{
			base.Awake();
			if (!this.MMEIGKDIJAH())
			{
				base.enabled = true;
			}
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x00355180 File Offset: 0x00353380
		protected virtual void DGIHGBBIMDP(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1429f;
				float f = num + 215f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1087f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)5)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1823f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1277f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[6].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 299f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[1].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture EFOLMNOHOAE()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x003556B0 File Offset: 0x003538B0
		protected bool KBIOOOHNPMB()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_TimeX"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find(","));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(70f, 1267f, 14f, 700f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1037f / (float)this.GAOAIDNGCBB.numTilesX, 1307f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x0035588C File Offset: 0x00353A8C
		protected virtual void ELJGNALAHNN(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1184f;
				float f = num + 646f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 160f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)8)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 769f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1468f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[8] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1748f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[2].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095E1 RID: 38369 RVA: 0x00355DBC File Offset: 0x00353FBC
		protected virtual void HBKIJLJHKIF(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 743f;
				float f = num + 1516f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1363f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)8)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 720f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 945f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[8] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 132f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[4].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[0].position = a + b + b2;
					this.PIHAOPOLJHA[2].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x003562EC File Offset: 0x003544EC
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 0.0174532924f;
				float f = num + 1.57079637f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 0.5f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Shape)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 0f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[2].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void GFACKFCEIBC()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x0035681C File Offset: 0x00354A1C
		protected bool JLGNNANJGDB()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("View ({3}){0} on {1} {2}"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("player.watermelon"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(835f, 792f, 662f, 258f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(48f / (float)this.GAOAIDNGCBB.numTilesX, 620f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x060095E5 RID: 38373 RVA: 0x003569F8 File Offset: 0x00354BF8
		protected bool DDEKPGECKCD()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_MainTex"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("UI/Particles/Hidden"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(0f, 0f, 1f, 1f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1f / (float)this.GAOAIDNGCBB.numTilesX, 1f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00356BD3 File Offset: 0x00354DD3
		protected virtual void HCCMANDFEPL()
		{
			base.Awake();
			if (!this.ALIACDAODAH())
			{
				base.enabled = false;
			}
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00356BF0 File Offset: 0x00354DF0
		protected virtual void OCGJOFMAJNP(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1233f;
				float f = num + 18f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1636f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)6)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 302f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 875f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[8] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[6].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 467f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[8].position = a + b + b2;
					this.PIHAOPOLJHA[6].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture IDGAKLPPDIE()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00357120 File Offset: 0x00355320
		protected bool CAKEDMMEHDE()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("Image_"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("22x3"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1283f, 1258f, 225f, 1645f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1120f / (float)this.GAOAIDNGCBB.numTilesX, 905f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x003572FC File Offset: 0x003554FC
		protected virtual void IENODDBLJMC(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1286f;
				float f = num + 606f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 416f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Hierarchy)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1513f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1481f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 209f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[7].position = a + b + b2;
					this.PIHAOPOLJHA[2].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x0035782C File Offset: 0x00355A2C
		protected virtual void JPLOELKLMOC(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 816f;
				float f = num + 1960f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1543f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)3)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1261f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 470f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1258f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[0].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00357D5C File Offset: 0x00355F5C
		protected bool OFGPCMMJPII()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("GhostPosX"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_Value2"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(549f, 1003f, 1977f, 1616f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(984f / (float)this.GAOAIDNGCBB.numTilesX, 1774f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00357F38 File Offset: 0x00356138
		protected bool FEHKOCBOJOK()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("BadgeImage"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_Far"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1404f, 581f, 431f, 1271f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(579f / (float)this.GAOAIDNGCBB.numTilesX, 416f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture GGEBMOCFDJD()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00358113 File Offset: 0x00356313
		protected virtual void CNDGDDLEFJF()
		{
			base.Awake();
			if (!this.BDHFPLHOMKD())
			{
				base.enabled = false;
			}
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void LLJLDLLNFBH()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture GABKHFKNCPP()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x00358130 File Offset: 0x00356330
		protected virtual void BLPGPOFOGJL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1666f;
				float f = num + 515f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 969f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)6)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 591f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 618f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[8].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 20f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x0035865E File Offset: 0x0035685E
		protected virtual void FMAFBLKAJDF()
		{
			base.Awake();
			if (!this.DABMFABDIJP())
			{
				base.enabled = true;
			}
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x00358678 File Offset: 0x00356878
		protected virtual void CIAHIJIOFIE()
		{
			base.Awake();
			if (!this.CHDGEHMPCMH())
			{
				base.enabled = false;
			}
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00358694 File Offset: 0x00356894
		protected bool OEAOAHNJEIE()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_ScreenResolution"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("SaveGameName is null or empty!"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1017f, 787f, 1456f, 193f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(692f / (float)this.GAOAIDNGCBB.numTilesX, 1102f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060095F6 RID: 38390 RVA: 0x00353A3B File Offset: 0x00351C3B
		public override Texture mainTexture
		{
			get
			{
				if (this.particleTexture)
				{
					return this.particleTexture;
				}
				if (this.particleSprite)
				{
					return this.particleSprite.texture;
				}
				return null;
			}
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x0035886F File Offset: 0x00356A6F
		private void HCIPECAOGIA()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, false);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x003544EC File Offset: 0x003526EC
		private void MANDOGNJJBD()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture LHBMGHAEEAM()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x00358893 File Offset: 0x00356A93
		protected virtual void JHPKLGGMCBL()
		{
			base.Awake();
			if (!this.OEAOAHNJEIE())
			{
				base.enabled = false;
			}
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x003588B0 File Offset: 0x00356AB0
		protected virtual void HLACFEJLMPL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 836f;
				float f = num + 1605f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 992f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)7)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 314f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1176f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1572f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[1].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x00358DE0 File Offset: 0x00356FE0
		protected bool ALIACDAODAH()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("Set camera (or player) distance. Base player distance - 14"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_Value3"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1331f, 1223f, 1033f, 592f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1796f / (float)this.GAOAIDNGCBB.numTilesX, 493f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x060095FD RID: 38397 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture GELCOHCBDBK()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x060095FE RID: 38398 RVA: 0x00358FBC File Offset: 0x003571BC
		protected virtual void LHGFMLDJBBA(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 974f;
				float f = num + 245f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1161f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)5)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1393f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1697f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1845f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[4].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x060095FF RID: 38399 RVA: 0x003544EC File Offset: 0x003526EC
		private void HIKKPDACJGI()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x003594EA File Offset: 0x003576EA
		protected virtual void LHMDCEDONEE()
		{
			base.Awake();
			if (!this.DDKDNFAPLON())
			{
				base.enabled = true;
			}
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x00359504 File Offset: 0x00357704
		protected virtual void KBCDHKFCNJC(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 244f;
				float f = num + 537f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 865f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)7)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1907f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 0f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[8].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1806f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[8].position = a + b + b2;
					this.PIHAOPOLJHA[0].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture GJPBGEJGBNE()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009603 RID: 38403 RVA: 0x00359A34 File Offset: 0x00357C34
		protected virtual void BIJJHMPJEOD(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1279f;
				float f = num + 336f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 370f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)3)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1051f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 695f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1285f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[3].position = a + b + b2;
					this.PIHAOPOLJHA[6].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x00359F64 File Offset: 0x00358164
		protected bool EFJAMHIHFHO()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages."))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_ScreenResolution"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(383f, 1471f, 786f, 1130f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1341f / (float)this.GAOAIDNGCBB.numTilesX, 1466f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x003544EC File Offset: 0x003526EC
		private void PFNFPINPCMH()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x0035A140 File Offset: 0x00358340
		protected virtual void BGFIIGNIFKN(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 856f;
				float f = num + 688f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1692f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)8)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1183f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1393f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 321f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[4].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x0035A670 File Offset: 0x00358870
		protected virtual void LIACOLFKOND(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1694f;
				float f = num + 1320f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 82f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)5)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 835f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1586f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 648f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[7].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x0035ABA0 File Offset: 0x00358DA0
		protected bool BIONLGHBFNO()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("CameraFilterPack_TV_Arcade1"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("threshold"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(943f, 291f, 1635f, 1835f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(326f / (float)this.GAOAIDNGCBB.numTilesX, 256f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void FBMDHDBELEK()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture LLDONMDHAOK()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x0035AD7C File Offset: 0x00358F7C
		protected bool ANDGEMECLDG()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty(".lastCheckpoint.checkpointsUsed"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("LevelNameText"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1201f, 1065f, 1680f, 1622f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(253f / (float)this.GAOAIDNGCBB.numTilesX, 1037f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x0035AF58 File Offset: 0x00359158
		protected virtual void COLNNFKCCDE(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1591f;
				float f = num + 1931f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 767f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)5)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1497f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 683f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[6].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1059f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[7].position = a + b + b2;
					this.PIHAOPOLJHA[1].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x0035886F File Offset: 0x00356A6F
		private void MBLDJEFBLFL()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, false);
				this.SetAllDirty();
			}
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x0035B488 File Offset: 0x00359688
		protected virtual void KPMGIMDDHJL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1303f;
				float f = num + 1590f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1160f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Shape)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1161f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 749f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[5].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 906f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[4].position = a + b + b2;
					this.PIHAOPOLJHA[0].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x0035B9B6 File Offset: 0x00359BB6
		protected virtual void CCDNJPNLGBN()
		{
			base.Awake();
			if (!this.JCJFJDCJCGA())
			{
				base.enabled = true;
			}
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x0035B9D0 File Offset: 0x00359BD0
		protected bool LDLPCEKMKOA()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("s"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("Can't SendMove. Turn is finished by this player."));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1127f, 1581f, 1898f, 1111f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1608f / (float)this.GAOAIDNGCBB.numTilesX, 323f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x0035B9B6 File Offset: 0x00359BB6
		protected virtual void NCBGPIKDFIA()
		{
			base.Awake();
			if (!this.JCJFJDCJCGA())
			{
				base.enabled = true;
			}
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x0035BBAC File Offset: 0x00359DAC
		protected bool CHDGEHMPCMH()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("X"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("float,0"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1268f, 1554f, 1254f, 733f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1381f / (float)this.GAOAIDNGCBB.numTilesX, 880f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x06009613 RID: 38419 RVA: 0x0035BD88 File Offset: 0x00359F88
		protected virtual void NMLIHIMJGAK(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1453f;
				float f = num + 1749f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 424f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Local)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1748f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1737f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 212f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[2].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x0035C2B8 File Offset: 0x0035A4B8
		protected virtual void GOJHELPNECG(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 202f;
				float f = num + 1678f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1851f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)7)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 369f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 321f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1547f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[4].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void EHJJFJCKGAJ()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x0035C7E8 File Offset: 0x0035A9E8
		protected virtual void FHDBCGNMJMG(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1841f;
				float f = num + 1232f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 720f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Shape)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 458f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1355f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[6].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 475f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[6].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[1].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void ODCJJFBJJNF()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x003539F8 File Offset: 0x00351BF8
		private void LCHBFNIPBHB()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x0035CD18 File Offset: 0x0035AF18
		protected bool BBEOAMEDMOJ()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("received</b>\n#reason: "))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("LevelNameInputField"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1240f, 522f, 824f, 1126f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(673f / (float)this.GAOAIDNGCBB.numTilesX, 736f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x0600961A RID: 38426 RVA: 0x0035CEF4 File Offset: 0x0035B0F4
		protected bool HFDIGALPAHD()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("mapselector.filter.rateduponly"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_ScreenResolution"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1288f, 812f, 1968f, 473f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1803f / (float)this.GAOAIDNGCBB.numTilesX, 1477f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x0600961B RID: 38427 RVA: 0x0035D0D0 File Offset: 0x0035B2D0
		protected bool MPDAMDDPPAJ()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_ProjInfo"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_ScreenResolution"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(369f, 1728f, 781f, 1568f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(765f / (float)this.GAOAIDNGCBB.numTilesX, 1704f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x0600961C RID: 38428 RVA: 0x0035D2AC File Offset: 0x0035B4AC
		protected virtual void GJPKMJHNHAJ(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1350f;
				float f = num + 1696f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 806f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)8)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1653f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 509f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[6].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[4] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 520f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[3].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x0035D7DC File Offset: 0x0035B9DC
		protected virtual void MGKBAMLHFBH(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1188f;
				float f = num + 523f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 839f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)3)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1170f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1667f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[3].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 448f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[8].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[4].position = a + b + b2;
					this.PIHAOPOLJHA[8].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600961E RID: 38430 RVA: 0x0035DD0C File Offset: 0x0035BF0C
		protected bool DDKDNFAPLON()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("set id"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("Children"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(153f, 1970f, 108f, 1624f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1715f / (float)this.GAOAIDNGCBB.numTilesX, 1104f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x0600961F RID: 38431 RVA: 0x0035DEE8 File Offset: 0x0035C0E8
		protected virtual void APCGBHEOCLK(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1963f;
				float f = num + 171f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 229f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)8)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 924f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 526f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[5].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 859f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[4].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[0].position = a + b + b2;
					this.PIHAOPOLJHA[4].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009620 RID: 38432 RVA: 0x0035E418 File Offset: 0x0035C618
		protected virtual void IMFJKPIHDLB(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 112f;
				float f = num + 1454f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1573f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)4)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1736f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 401f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[8].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1084f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[7].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009621 RID: 38433 RVA: 0x0035E948 File Offset: 0x0035CB48
		protected virtual void HJFGAKFDGEH(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 322f;
				float f = num + 130f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1041f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Hierarchy)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1484f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 641f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 340f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[6].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture OKJDPJABCEC()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x0035EE78 File Offset: 0x0035D078
		protected bool GBDIEJEECOK()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("[PlayerController] "))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("maps."));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(601f, 298f, 109f, 491f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1349f / (float)this.GAOAIDNGCBB.numTilesX, 453f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x06009624 RID: 38436 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture DOIHFDEHKGN()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009625 RID: 38437 RVA: 0x0035F054 File Offset: 0x0035D254
		protected bool KPFCINLODFE()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("Noise & Grain effect failing as noise texture is not assigned. please assign."))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("SetSatelliteEmission"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(394f, 18f, 1131f, 268f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(317f / (float)this.GAOAIDNGCBB.numTilesX, 1547f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture NBNKGCNMKCD()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture JJGBKLECGEP()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x003544EC File Offset: 0x003526EC
		private void LJIHHJOAJCN()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x003544EC File Offset: 0x003526EC
		private void KCDOMIJBFLL()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x003544D2 File Offset: 0x003526D2
		protected virtual void KPOIJEKDFBE()
		{
			base.Awake();
			if (!this.EFJAMHIHFHO())
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600962B RID: 38443 RVA: 0x0035F230 File Offset: 0x0035D430
		protected virtual void PIGECIBLGEB(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 0; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 342f;
				float f = num + 941f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1153f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)3)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 722f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1422f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[2] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[7].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[6].color = currentColor;
				this.PIHAOPOLJHA[4].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1922f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[2].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[8].position = a + b + b2;
					this.PIHAOPOLJHA[1].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0035F760 File Offset: 0x0035D960
		protected bool DAFFOLPDLNO()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("_Value2"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("_TimeX"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(276f, 1347f, 389f, 1199f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(775f / (float)this.GAOAIDNGCBB.numTilesX, 622f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return true;
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x0035F93C File Offset: 0x0035DB3C
		protected virtual void DKCDDHDGCJD(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 733f;
				float f = num + 1349f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 203f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Local)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 67f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1039f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[3] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[5] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[5].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1108f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[4].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[1].position = a + b + b2;
					this.PIHAOPOLJHA[3].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600962E RID: 38446 RVA: 0x0035FE6C File Offset: 0x0035E06C
		protected bool MMEIGKDIJAH()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty(".sav"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("st"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(1206f, 1326f, 432f, 43f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1957f / (float)this.GAOAIDNGCBB.numTilesX, 941f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture LPCDOIABBLO()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x003544EC File Offset: 0x003526EC
		private void LBPCODPOJAH()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, false, true);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture MGHBGAAGIHF()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x00360048 File Offset: 0x0035E248
		protected virtual void HHIAADJKLCF(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1550f;
				float f = num + 372f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1460f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)5)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1266f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1805f);
					int num4 = 0;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[8] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 794f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[4].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[0].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x0035B9B6 File Offset: 0x00359BB6
		protected virtual void EIFCCFBJKOO()
		{
			base.Awake();
			if (!this.JCJFJDCJCGA())
			{
				base.enabled = true;
			}
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x00360578 File Offset: 0x0035E778
		protected virtual void OMHONNNEMEL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1245f;
				float f = num + 998f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1678f;
				if (this.DLJAMJDIMID.scalingMode == ParticleSystemScalingMode.Local)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 661f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1760f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.WholeSheet)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[1] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[8] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[2].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[8].color = currentColor;
				this.PIHAOPOLJHA[5].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 1882f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[0].position = a - b + b2;
					this.PIHAOPOLJHA[1].position = a + b + b2;
					this.PIHAOPOLJHA[5].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x00360AA8 File Offset: 0x0035ECA8
		protected bool OPDAFHEJEPL()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("<b>"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("[MapEditor] Importing map: "));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(162f, 746f, 1394f, 1987f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(393f / (float)this.GAOAIDNGCBB.numTilesX, 1700f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture PNPONHLFPFK()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x00360C84 File Offset: 0x0035EE84
		protected bool BDHFPLHOMKD()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return true;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("settings.volume.game"))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("maps."));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Hierarchy;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(106f, 139f, 1205f, 621f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 0;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(1447f / (float)this.GAOAIDNGCBB.numTilesX, 1003f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x0035886F File Offset: 0x00356A6F
		private void IBHACCEEFFI()
		{
			if (Application.isPlaying)
			{
				this.DLJAMJDIMID.Simulate(Time.unscaledDeltaTime, true, false);
				this.SetAllDirty();
			}
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x00360E60 File Offset: 0x0035F060
		protected virtual void NEKICIJPFBM(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i += 0)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1698f;
				float f = num + 1495f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 1908f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)4)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 1842f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 1016f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[1].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[7].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 714f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[0].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[5].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[6].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[0].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[6].position = a + b + b2;
					this.PIHAOPOLJHA[4].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x00361390 File Offset: 0x0035F590
		protected bool DABMFABDIJP()
		{
			if (this.ADDDADEEHGM == null)
			{
				this.ADDDADEEHGM = base.transform;
			}
			if (this.DLJAMJDIMID == null)
			{
				this.DLJAMJDIMID = base.GetComponent<ParticleSystem>();
				if (this.DLJAMJDIMID == null)
				{
					return false;
				}
				ParticleSystemRenderer particleSystemRenderer = this.DLJAMJDIMID.GetComponent<ParticleSystemRenderer>();
				if (particleSystemRenderer == null)
				{
					particleSystemRenderer = this.DLJAMJDIMID.gameObject.AddComponent<ParticleSystemRenderer>();
				}
				Material sharedMaterial = particleSystemRenderer.sharedMaterial;
				if (sharedMaterial && sharedMaterial.HasProperty("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: "))
				{
					this.particleTexture = sharedMaterial.mainTexture;
				}
				Material material = new Material(Shader.Find("cmd.exe"));
				if (Application.isPlaying)
				{
					particleSystemRenderer.material = material;
				}
				this.DLJAMJDIMID.scalingMode = ParticleSystemScalingMode.Local;
				this.GPFIEGMDELG = null;
			}
			if (this.GPFIEGMDELG == null)
			{
				this.GPFIEGMDELG = new ParticleSystem.Particle[this.DLJAMJDIMID.maxParticles];
			}
			if (this.particleTexture)
			{
				this.NKIDJHBLIHI = new Vector4(539f, 120f, 90f, 389f);
			}
			else if (this.particleSprite)
			{
				this.NKIDJHBLIHI = DataUtility.GetOuterUV(this.particleSprite);
			}
			this.GAOAIDNGCBB = this.DLJAMJDIMID.textureSheetAnimation;
			this.NEFOHBJAELD = 1;
			this.PKKGHACGGJI = Vector2.zero;
			if (this.GAOAIDNGCBB.enabled)
			{
				this.NEFOHBJAELD = this.GAOAIDNGCBB.numTilesX * this.GAOAIDNGCBB.numTilesY;
				this.PKKGHACGGJI = new Vector2(369f / (float)this.GAOAIDNGCBB.numTilesX, 594f / (float)this.GAOAIDNGCBB.numTilesY);
			}
			return false;
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x0036156C File Offset: 0x0035F76C
		protected virtual void DJGFNIEFIIA(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			if (!base.gameObject.activeInHierarchy)
			{
				return;
			}
			int particles = this.DLJAMJDIMID.GetParticles(this.GPFIEGMDELG);
			for (int i = 1; i < particles; i++)
			{
				ParticleSystem.Particle particle = this.GPFIEGMDELG[i];
				Vector2 a = (this.DLJAMJDIMID.simulationSpace != ParticleSystemSimulationSpace.Local) ? this.ADDDADEEHGM.InverseTransformPoint(particle.position) : particle.position;
				float num = -particle.rotation * 1967f;
				float f = num + 1081f;
				Color32 currentColor = particle.GetCurrentColor(this.DLJAMJDIMID);
				float num2 = particle.GetCurrentSize(this.DLJAMJDIMID) * 842f;
				if (this.DLJAMJDIMID.scalingMode == (ParticleSystemScalingMode)3)
				{
					a /= base.canvas.scaleFactor;
				}
				Vector4 nkidjhblihi = this.NKIDJHBLIHI;
				if (this.GAOAIDNGCBB.enabled)
				{
					float num3 = 288f - particle.remainingLifetime / particle.startLifetime;
					num3 = Mathf.Repeat(num3 * (float)this.GAOAIDNGCBB.cycleCount, 361f);
					int num4 = 1;
					ParticleSystemAnimationType animation = this.GAOAIDNGCBB.animation;
					if (animation != ParticleSystemAnimationType.WholeSheet)
					{
						if (animation == ParticleSystemAnimationType.SingleRow)
						{
							num4 = Mathf.FloorToInt(num3 * (float)this.GAOAIDNGCBB.numTilesX);
							int rowIndex = this.GAOAIDNGCBB.rowIndex;
							num4 += rowIndex * this.GAOAIDNGCBB.numTilesX;
						}
					}
					else
					{
						num4 = Mathf.FloorToInt(num3 * (float)this.NEFOHBJAELD);
					}
					num4 %= this.NEFOHBJAELD;
					nkidjhblihi.x = (float)(num4 % this.GAOAIDNGCBB.numTilesX) * this.PKKGHACGGJI.x;
					nkidjhblihi.y = (float)Mathf.FloorToInt((float)(num4 / this.GAOAIDNGCBB.numTilesX)) * this.PKKGHACGGJI.y;
					nkidjhblihi.z = nkidjhblihi.x + this.PKKGHACGGJI.x;
					nkidjhblihi.w = nkidjhblihi.y + this.PKKGHACGGJI.y;
				}
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[0].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.y);
				this.PIHAOPOLJHA[0] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[0].color = currentColor;
				this.PIHAOPOLJHA[1].uv0 = new Vector2(nkidjhblihi.x, nkidjhblihi.w);
				this.PIHAOPOLJHA[6] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[2].color = currentColor;
				this.PIHAOPOLJHA[3].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.w);
				this.PIHAOPOLJHA[7] = UIVertex.simpleVert;
				this.PIHAOPOLJHA[4].color = currentColor;
				this.PIHAOPOLJHA[8].uv0 = new Vector2(nkidjhblihi.z, nkidjhblihi.y);
				if (num == 752f)
				{
					Vector2 vector = new Vector2(a.x - num2, a.y - num2);
					Vector2 vector2 = new Vector2(a.x + num2, a.y + num2);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector.x, vector2.y);
					this.PIHAOPOLJHA[1].position = new Vector2(vector2.x, vector2.y);
					this.PIHAOPOLJHA[7].position = new Vector2(vector2.x, vector.y);
				}
				else
				{
					Vector2 b = new Vector2(Mathf.Cos(num), Mathf.Sin(num)) * num2;
					Vector2 b2 = new Vector2(Mathf.Cos(f), Mathf.Sin(f)) * num2;
					this.PIHAOPOLJHA[1].position = a - b - b2;
					this.PIHAOPOLJHA[1].position = a - b + b2;
					this.PIHAOPOLJHA[5].position = a + b + b2;
					this.PIHAOPOLJHA[7].position = a + b - b2;
				}
				CBFPMKACAHH.AddUIVertexQuad(this.PIHAOPOLJHA);
			}
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x00353A3B File Offset: 0x00351C3B
		public virtual Texture NGHCKMEJMKN()
		{
			if (this.particleTexture)
			{
				return this.particleTexture;
			}
			if (this.particleSprite)
			{
				return this.particleSprite.texture;
			}
			return null;
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x00361A9A File Offset: 0x0035FC9A
		protected override void Awake()
		{
			base.Awake();
			if (!this.DDEKPGECKCD())
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x00358113 File Offset: 0x00356313
		protected virtual void EMANBHKAONB()
		{
			base.Awake();
			if (!this.BDHFPLHOMKD())
			{
				base.enabled = false;
			}
		}

		// Token: 0x04001112 RID: 4370
		public Texture particleTexture;

		// Token: 0x04001113 RID: 4371
		public Sprite particleSprite;

		// Token: 0x04001114 RID: 4372
		private Transform ADDDADEEHGM;

		// Token: 0x04001115 RID: 4373
		private ParticleSystem DLJAMJDIMID;

		// Token: 0x04001116 RID: 4374
		private ParticleSystem.Particle[] GPFIEGMDELG;

		// Token: 0x04001117 RID: 4375
		private UIVertex[] PIHAOPOLJHA = new UIVertex[4];

		// Token: 0x04001118 RID: 4376
		private Vector4 NKIDJHBLIHI = Vector4.zero;

		// Token: 0x04001119 RID: 4377
		private ParticleSystem.TextureSheetAnimationModule GAOAIDNGCBB;

		// Token: 0x0400111A RID: 4378
		private int NEFOHBJAELD;

		// Token: 0x0400111B RID: 4379
		private Vector2 PKKGHACGGJI;
	}
}
