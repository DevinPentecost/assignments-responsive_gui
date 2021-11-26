﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ResponsiveGui.Models
{
	public class EntryManager
	{
		private const int Entries = 100 * 1000;
		private const double Delay = 0.001;
		private const double Variance = 0.0005;
		private static readonly Random Rng = new();

		public static async IAsyncEnumerator<Guid> GetEntries()
		{
			for (var i = 0; i < Entries; i++)
			{
				var delay = Delay + (Rng.NextDouble() * Variance - Variance / 2);
				await Task.Delay(TimeSpan.FromSeconds(delay));

				yield return new Guid();
			}
		}
	}
}