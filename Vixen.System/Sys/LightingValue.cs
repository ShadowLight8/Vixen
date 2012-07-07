﻿using System.Drawing;

namespace Vixen.Sys {
	public struct LightingValue {
		public LightingValue(Color color, double intensity) {
			Color = color;
			Intensity = intensity;
		}

		public Color Color;
		/// <summary>
		/// Percentage value between 0 and 1.
		/// </summary>
		public double Intensity;

		public Color GetIntensityAffectedColor() {
			return Color.FromArgb(0xff, (int)(Color.R * Intensity), (int)(Color.G * Intensity), (int)(Color.B * Intensity));
		}
	}
}