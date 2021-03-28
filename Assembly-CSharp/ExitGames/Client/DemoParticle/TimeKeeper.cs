using System;

namespace ExitGames.Client.DemoParticle
{
	// Token: 0x02000366 RID: 870
	public class TimeKeeper
	{
		// Token: 0x0600C2CE RID: 49870 RVA: 0x0046DFF5 File Offset: 0x0046C1F5
		public TimeKeeper(int interval)
		{
			this.IsEnabled = true;
			this.Interval = interval;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600C2CF RID: 49871 RVA: 0x0046E016 File Offset: 0x0046C216
		// (set) Token: 0x0600C2D0 RID: 49872 RVA: 0x0046E01E File Offset: 0x0046C21E
		public int Interval { get; set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600C2D1 RID: 49873 RVA: 0x0046E027 File Offset: 0x0046C227
		// (set) Token: 0x0600C2D2 RID: 49874 RVA: 0x0046E02F File Offset: 0x0046C22F
		public bool IsEnabled { get; set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600C2D3 RID: 49875 RVA: 0x0046E038 File Offset: 0x0046C238
		// (set) Token: 0x0600C2D4 RID: 49876 RVA: 0x0046E06A File Offset: 0x0046C26A
		public bool ShouldExecute
		{
			get
			{
				return this.IsEnabled && (this.shouldExecute || Environment.TickCount - this.lastExecutionTime > this.Interval);
			}
			set
			{
				this.shouldExecute = value;
			}
		}

		// Token: 0x0600C2D5 RID: 49877 RVA: 0x0046E073 File Offset: 0x0046C273
		public void Reset()
		{
			this.shouldExecute = false;
			this.lastExecutionTime = Environment.TickCount;
		}

		// Token: 0x0400168C RID: 5772
		private int lastExecutionTime = Environment.TickCount;

		// Token: 0x0400168D RID: 5773
		private bool shouldExecute;
	}
}
