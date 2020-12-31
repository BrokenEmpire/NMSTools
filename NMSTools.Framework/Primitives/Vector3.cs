using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace NMSTools.Framework.Primitives
{
	[JsonObject]
	[StructLayout(LayoutKind.Sequential)]
	public struct Vector3 : IEquatable<Vector3>
	{
		public double X;
		public double Y;
		public double Z;

		public Vector3(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public Vector3(Vector2 v, double z = 0)
		{
			X = v.X;
			Y = v.Y;
			Z = z;
		}

		public Vector3(Vector3 v)
		{
			X = v.X;
			Y = v.Y;
			Z = v.Z;
		}

		public Vector3(double[] doubleArray)
		{
			X = doubleArray[0];
			Y = doubleArray[1];
			Z = doubleArray[2];
		}

		public Vector3(Vector4 v)
		{
			X = v.X;
			Y = v.Y;
			Z = v.Z;
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

					default:
						throw new Exception();
				}
			}
		}

	
		public static Vector3 operator +(Vector3 left, Vector3 right)
		{
			left.X += right.X;
			left.Y += right.Y;
			left.Z += right.Z;
			return left;
		}

		public static Vector3 operator -(Vector3 left, Vector3 right)
		{
			left.X -= right.X;
			left.Y -= right.Y;
			left.Z -= right.Z;
			return left;
		}

		public static Vector3 operator -(Vector3 vec)
		{
			vec.X = -vec.X;
			vec.Y = -vec.Y;
			vec.Z = -vec.Z;
			return vec;
		}

		public static Vector3 operator *(Vector3 vecA, Vector3 vecB)
		{
			vecA.X *= vecB.X;
			vecA.Y *= vecB.Y;
			vecA.Z *= vecB.Z;
			return vecA;
		}

		public static Vector3 operator *(Vector3 vec, double scale)
		{
			vec.X *= scale;
			vec.Y *= scale;
			vec.Z *= scale;
			return vec;
		}

		public static Vector3 operator *(double scale, Vector3 vec)
		{
			vec.X *= scale;
			vec.Y *= scale;
			vec.Z *= scale;
			return vec;
		}

        public static Vector3 operator /(double numerator, Vector3 vec)
			=> new Vector3((numerator / vec.X), (numerator / vec.Y), (numerator / vec.Z));

        public static Vector3 operator /(Vector3 vec, double scale)
		{
			double mult = 1 / scale;
			vec.X *= mult;
			vec.Y *= mult;
			vec.Z *= mult;
			return vec;
		}

        public static bool operator ==(Vector3 left, Vector3 right) 
			=> left.Equals(right);

        public static bool operator !=(Vector3 left, Vector3 right) 
			=> !left.Equals(right);

        public override string ToString() 
			=> string.Format("{0:g3},{1:g3},{2:g3}", X, Y, Z);

		public override int GetHashCode() 
			=> new { X, Y, Z }.GetHashCode();

        public override bool Equals(object obj)
			=> obj is Vector3 v && Equals(v);

		public bool Equals(Vector3 other)
			=> X == other.X &&
			   Y == other.Y &&
			   Z == other.Z;

		public bool Equals(Vector3 OtherVector, double ErrorValue) 
			=> (X < OtherVector.X + ErrorValue && X > OtherVector.X - ErrorValue) &&
               (Y < OtherVector.Y + ErrorValue && Y > OtherVector.Y - ErrorValue) &&
               (Z < OtherVector.Z + ErrorValue && Z > OtherVector.Z - ErrorValue);
	}
}
