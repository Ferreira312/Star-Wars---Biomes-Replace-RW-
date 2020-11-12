using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld.Planet;
using RimWorld;

namespace StarWarsBiomes
{
	public class BiomeWorker_Bespin : BiomeWorker
	{
		public override float GetScore(Tile tile, int tileID)
		{
			if (tile.WaterCovered)
            {
                return -100f;
            }
			if (tile.temperature < -10f)
			{
				return 0f;
			}
			//if (tile.elevation < -1)
            //{
            //    return -100;
            //}
			if (tile.rainfall < 340f)
			{
				return 0f;
			}
			return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
		}
	}
}