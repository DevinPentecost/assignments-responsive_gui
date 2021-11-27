using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResponsiveGui.Models
{
	public static class EntryManager
	{
		private const int Entries = 100 * 1000;
		private const double Delay = 0.001;
		private const double Variance = 0.0005;
		private static readonly Random Rng = new();

		public static async IAsyncEnumerable<Guid> GetEntries()
		{
			for (var i = 0; i < Entries; i++)
			{
				var delay = Delay + (Rng.NextDouble() * Variance - Variance / 2);
				await Task.Delay(TimeSpan.FromSeconds(delay));

				yield return Guid.NewGuid();
			}
		}
	}
}