using System;
using System.Collections.Generic;

namespace NMSTools.Framework.Extensions
{
    using Primitives;

    public static class V2Extensions
	{
		public static double PolygonLength(this List<Vector2> polygon, bool isClosed = true)
		{
			var length = 0.0;
			if (polygon.Count > 1)
			{
				var previousPoint = polygon[0];
				if (isClosed)
				{
					previousPoint = polygon[polygon.Count - 1];
				}

				for (int i = isClosed ? 0 : 1; i < polygon.Count; i++)
				{
					var currentPoint = polygon[i];
					length += (previousPoint - currentPoint).Length;
					previousPoint = currentPoint;
				}
			}

			return length;
		}

		public static double LengthTo(this List<Vector2> polygon, int index, bool isClosed = true)
		{
			var length = 0.0;
			index = Math.Max(0, Math.Min(polygon.Count - 1, index));
			for (int i = 1; i <= index; i++)
			{
				length += (polygon[i] - polygon[i - 1]).Length;
			}

			return length;
		}

		/// <summary>
		/// Get the position of a point that is lengthFromStart distance around the perimeter.
		/// </summary>
		/// <param name="polygon">The polygon to find the position on</param>
		/// <param name="lengthFromStart">The distance around the perimeter form the start</param>
		/// <param name="closed">The polygon loops back on itself. There is a segment between the
		/// last and the first point, if they are not the same</param>
		/// <returns>The position on the perimeter</returns>
		public static Vector2 GetPositionAt(this List<Vector2> polygon, double lengthFromStart, bool closed = true)
		{
			var totalLength = polygon.PolygonLength();
			if (lengthFromStart > totalLength)
			{
				if (closed)
				{
					var ratio = lengthFromStart / totalLength;
					var times = (int)ratio;
					var remainder = ratio - times;
					lengthFromStart = remainder * totalLength;
				}
				else
				{
					return polygon[polygon.Count - 1];
				}
			}
			else if (lengthFromStart <= 0)
			{
				if (closed)
				{
					var ratio = lengthFromStart / totalLength;
					var times = (int)ratio;
					var remainder = ratio - times;
					lengthFromStart = (1 + remainder) * totalLength;
				}
				else
				{
					return polygon[0];
				}
			}

			var position = new Vector2();
			var length = 0.0;
			if (polygon.Count > 1)
			{
				position = polygon[0];
				var currentPoint = polygon[0];

				int polygonCount = polygon.Count;
				for (int i = 1; i < (closed ? polygonCount + 1 : polygonCount); i++)
				{
					var nextPoint = polygon[(polygonCount + i) % polygonCount];
					var segmentLength = (nextPoint - currentPoint).Length;
					if (length + segmentLength > lengthFromStart)
					{
						// return the distance along this segment
						var distanceAlongThisSegment = lengthFromStart - length;
						var delteFromCurrent = (nextPoint - currentPoint) * distanceAlongThisSegment / segmentLength;
						return currentPoint + delteFromCurrent;
					}

					position = nextPoint;

					length += segmentLength;
					currentPoint = nextPoint;
				}
			}

			return position;
		}

		public static double GetTurnAmount(this Vector2 currentPoint, Vector2 prevPoint, Vector2 nextPoint)
		{
			if (prevPoint != currentPoint
				&& currentPoint != nextPoint
				&& nextPoint != prevPoint)
			{
				prevPoint = currentPoint - prevPoint;
				nextPoint -= currentPoint;

				double prevAngle = Math.Atan2(prevPoint.Y, prevPoint.X);
				Vector2 rotatedPrev = prevPoint.GetRotated(-prevAngle);

				// undo the rotation
				nextPoint = nextPoint.GetRotated(-prevAngle);
				double angle = Math.Atan2(nextPoint.Y, nextPoint.X);

				return angle;
			}

			return 0;
		}

	}
}
