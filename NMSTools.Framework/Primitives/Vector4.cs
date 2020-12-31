using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace NMSTools.Framework.Primitives
{
	[JsonObject]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector4 : IEquatable<Vector4>
	{
		public double X;
		public double Y;
		public double Z;
		public double W;

		public Vector4(double x, double y, double z, double w)
		{
			X = x;
			Y = y;
			Z = z;
			W = w;
		}

		public Vector4(Vector2 v)
		{
			X = v.X;
			Y = v.Y;
			Z = 0.0f;
			W = 0.0f;
		}

		public Vector4(Vector3 v)
		{
			X = v.X;
			Y = v.Y;
			Z = v.Z;
			W = 0.0f;
		}

		public Vector4(Vector3 v, double w)
		{
			X = v.X;
			Y = v.Y;
			Z = v.Z;
			this.W = w;
		}

		public Vector4(Vector4 v)
		{
			X = v.X;
			Y = v.Y;
			Z = v.Z;
			W = v.W;
		}

		public double this[int index]
		{
			get
			{
                return index switch
                {
                    0 => X,
                    1 => Y,
                    2 => Z,
                    3 => W,
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

					case 2:
						Z = value;
						break;

					case 3:
						W = value;
						break;

					default:
						throw new Exception();
				}
			}
		}

		public static Vector4 operator +(Vector4 left, Vector4 right)
		{
			left.X += right.X;
			left.Y += right.Y;
			left.Z += right.Z;
			left.W += right.W;
			return left;
		}

		public static Vector4 operator -(Vector4 left, Vector4 right)
		{
			left.X -= right.X;
			left.Y -= right.Y;
			left.Z -= right.Z;
			left.W -= right.W;
			return left;
		}

		public static Vector4 operator -(Vector4 vec)
		{
			vec.X = -vec.X;
			vec.Y = -vec.Y;
			vec.Z = -vec.Z;
			vec.W = -vec.W;
			return vec;
		}

		public static Vector4 operator *(Vector4 vec, double scale)
		{
			vec.X *= scale;
			vec.Y *= scale;
			vec.Z *= scale;
			vec.W *= scale;
			return vec;
		}

		public static Vector4 operator *(double scale, Vector4 vec)
		{
			vec.X *= scale;
			vec.Y *= scale;
			vec.Z *= scale;
			vec.W *= scale;
			return vec;
		}

		public static Vector4 operator /(Vector4 vec, double scale)
		{
			double mult = 1 / scale;
			vec.X *= mult;
			vec.Y *= mult;
			vec.Z *= mult;
			vec.W *= mult;
			return vec;
		}

        public static bool operator ==(Vector4 left, Vector4 right)
			=> left.Equals(right);

        public static bool operator !=(Vector4 left, Vector4 right)
			=> !left.Equals(right);

        public override string ToString()
			=> string.Format("{0:g18},{1:g18},{2:g18},{3:g18}", X, Y, Z, W);

        public override int GetHashCode()
			=> new { X, Y, Z, W }.GetHashCode();

        public override bool Equals(object obj)
			=> obj is Vector4 v && Equals(v);

		public bool Equals(Vector4 other)
			=> X == other.X && 
			   Y == other.Y && 
			   Z == other.Z && 
			   W == other.W;

		public bool Equals(Vector4 OtherVector, double ErrorValue) 
			=> (X < OtherVector.X + ErrorValue && X > OtherVector.X - ErrorValue) &&
               (Y < OtherVector.Y + ErrorValue && Y > OtherVector.Y - ErrorValue) &&
               (Z < OtherVector.Z + ErrorValue && Z > OtherVector.Z - ErrorValue) &&
               (W < OtherVector.W + ErrorValue && W > OtherVector.W - ErrorValue);

    }
}
