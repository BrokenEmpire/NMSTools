using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace NMSTools.Framework.Primitives
{
	[JsonObject]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector2 : IEquatable<Vector2>
	{
		public double X;
		public double Y;

		public Vector2(double x, double y)
		{
			X = x;
			Y = y;
		}

		public Vector2(Vector3 vector)
		{
			X = vector.X;
			Y = vector.Y;
		}

		public double this[int index]
		{
			get
			{
                return index switch
                {
                    0 => X,
                    1 => Y,
                    _ => 0,
                };
            }
			set
			{
				switch (index)
				{
					case 0:
						X = value;
						break;

					case 1:
						Y = value;
						break;

					default:
						throw new Exception();
				}
			}
		}

		public static Vector2 operator +(Vector2 left, Vector2 right)
		{
			left.X += right.X;
			left.Y += right.Y;
			return left;
		}

		public static Vector2 operator -(Vector2 left, Vector2 right)
		{
			left.X -= right.X;
			left.Y -= right.Y;
			return left;
		}

		public static Vector2 operator -(Vector2 vec)
		{
			vec.X = -vec.X;
			vec.Y = -vec.Y;
			return vec;
		}

		public static Vector2 operator *(Vector2 vec, double f)
		{
			vec.X *= f;
			vec.Y *= f;
			return vec;
		}

		public static Vector2 operator *(double f, Vector2 vec)
		{
			vec.X *= f;
			vec.Y *= f;
			return vec;
		}

		public static Vector2 operator /(Vector2 vec, double f)
		{
			double mult = 1.0 / f;
			vec.X *= mult;
			vec.Y *= mult;
			return vec;
		}

		public static Vector2 operator /(double f, Vector2 vec)
		{
			vec.X = f / vec.X;
			vec.Y = f / vec.Y;
			return vec;
		}

        public static bool operator ==(Vector2 left, Vector2 right)
			=> left.Equals(right);

        public static bool operator !=(Vector2 left, Vector2 right)
			=> !left.Equals(right);

        public override string ToString()
			=> string.Format("{0:g18},{1:g18}", X, Y);

        public override int GetHashCode()
			=> new { X, Y }.GetHashCode();

        public override bool Equals(object obj)
			=> obj is Vector2 v && Equals(v);

		public bool Equals(Vector2 other) 
			=> X == other.X && 
			   Y == other.Y;

        public bool Equals(Vector2 other, double errorRange) 
			=> (X < other.X + errorRange && X > other.X - errorRange) &&
               (Y < other.Y + errorRange && Y > other.Y - errorRange);
    }
}
