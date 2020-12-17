using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMSTools.Framework.Extensions
{
	using Primitives;

    public static class V3Extensions
	{
		#region Dot

		/// <summary>
		/// Calculate the dot (scalar) product of two vectors
		/// </summary>
		/// <param name="left">First operand</param>
		/// <param name="right">Second operand</param>
		/// <returns>The dot product of the two inputs</returns>
		public static double Dot(this Vector3 left, Vector3 right)
		{
			return left.X * right.X + left.Y * right.Y + left.Z * right.Z;
		}

		/// <summary>
		/// Calculate the dot (scalar) product of two vectors
		/// </summary>
		/// <param name="left">First operand</param>
		/// <param name="right">Second operand</param>
		/// <param name="result">The dot product of the two inputs</param>
		public static void Dot(this Vector3 left, ref Vector3 right, out double result)
		{
			result = left.X * right.X + left.Y * right.Y + left.Z * right.Z;
		}

		#endregion Dot

		#region Cross

		/// <summary>
		/// Calculate the cross (vector) product of two vectors
		/// </summary>
		/// <param name="left">First operand</param>
		/// <param name="right">Second operand</param>
		/// <returns>The cross product of the two inputs</returns>
		public static Vector3 Cross(this Vector3 left, Vector3 right)
		{
			Vector3 result;
			left.Cross(ref right, out result);
			return result;
		}

		/// <summary>
		/// Calculate the cross (vector) product of two vectors
		/// </summary>
		/// <param name="left">First operand</param>
		/// <param name="right">Second operand</param>
		/// <returns>The cross product of the two inputs</returns>
		/// <param name="result">The cross product of the two inputs</param>
		public static void Cross(this Vector3 left, ref Vector3 right, out Vector3 result)
		{
			result = new Vector3(left.Y * right.Z - left.Z * right.Y,
				left.Z * right.X - left.X * right.Z,
				left.X * right.Y - left.Y * right.X);
		}

		#endregion Cross

		#region Transform

		/// <summary>Transform a direction vector by the given Matrix
		/// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
		/// </summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <returns>The transformed vector</returns>
		public static Vector3 TransformVector(this Vector3 vec, Matrix4X4 mat)
		{
			return new Vector3(
				vec.Dot(new Vector3(mat.Column0)),
				vec.Dot(new Vector3(mat.Column1)),
				vec.Dot(new Vector3(mat.Column2)));
		}

		/// <summary>Transform a direction vector by the given Matrix
		/// Assumes the matrix has a bottom row of (0,0,0,1), that is the translation part is ignored.
		/// </summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <param name="result">The transformed vector</param>
		public static void TransformVector(this Vector3 vec, ref Matrix4X4 mat, out Vector3 result)
		{
			result.X = vec.X * mat.Row0.X +
					   vec.Y * mat.Row1.X +
					   vec.Z * mat.Row2.X;

			result.Y = vec.X * mat.Row0.Y +
					   vec.Y * mat.Row1.Y +
					   vec.Z * mat.Row2.Y;

			result.Z = vec.X * mat.Row0.Z +
					   vec.Y * mat.Row1.Z +
					   vec.Z * mat.Row2.Z;
		}

		/// This calculates the inverse of the given matrix, use TransformNormalInverse if you
		/// already have the inverse to avoid this extra calculation
		/// <param name="normal">The normal to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <returns>The transformed normal</returns>
		public static Vector3 TransformNormal(this Vector3 normal, Matrix4X4 mat)
		{
			Vector3 result;
			TransformNormal(normal, ref mat, out result);
			return result;
		}

		/// <summary>Transform a Normal by the given Matrix</summary>
		/// <remarks>
		/// This calculates the inverse of the given matrix, use TransformNormal if you have
		/// a point on the plane (fastest) or TransformNormalInverse if you
		/// have the inverse but not a point on the plane - to avoid this extra calculation
		/// </remarks>
		/// <param name="normal">The normal to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <param name="result">The transformed normal</param>
		public static void TransformNormal(this Vector3 normal, ref Matrix4X4 mat, out Vector3 result)
		{
			Matrix4X4 Inverse = Matrix4X4.Invert(mat);
			TransformNormalInverse(normal, ref Inverse, out result);
		}

		/// <summary>Transform a Normal by the (transpose of the) given Matrix</summary>
		/// <remarks>
		/// This version doesn't calculate the inverse matrix.
		/// Use this version if you already have the inverse of the desired transform to hand
		/// </remarks>
		/// <param name="normal">The normal to transform</param>
		/// <param name="invMat">The inverse of the desired transformation</param>
		/// <returns>The transformed normal</returns>
		public static Vector3 TransformNormalInverse(this Vector3 normal, Matrix4X4 invMat)
		{
			return new Vector3(
				normal.Dot(new Vector3(invMat.Row0)),
				normal.Dot(new Vector3(invMat.Row1)),
				normal.Dot(new Vector3(invMat.Row2)));
		}

		/// <summary>Transform a Normal by the (transpose of the) given Matrix</summary>
		/// <remarks>
		/// This version doesn't calculate the inverse matrix.
		/// Use this version if you already have the inverse of the desired transform to hand
		/// </remarks>
		/// <param name="normal">The normal to transform</param>
		/// <param name="invMat">The inverse of the desired transformation</param>
		/// <param name="result">The transformed normal</param>
		public static void TransformNormalInverse(this Vector3 normal, ref Matrix4X4 invMat, out Vector3 result)
		{
			result.X = normal.X * invMat.Row0.X +
					   normal.Y * invMat.Row0.Y +
					   normal.Z * invMat.Row0.Z;

			result.Y = normal.X * invMat.Row1.X +
					   normal.Y * invMat.Row1.Y +
					   normal.Z * invMat.Row1.Z;

			result.Z = normal.X * invMat.Row2.X +
					   normal.Y * invMat.Row2.Y +
					   normal.Z * invMat.Row2.Z;
		}

		/// <summary>Transform a Position by the given Matrix</summary>
		/// <param name="pos">The position to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <returns>The transformed position</returns>
		public static Vector3 TransformPosition(this Vector3 pos, Matrix4X4 mat)
		{
			return new Vector3(
				pos.Dot(new Vector3(mat.Column0)) + mat.Row3.X,
				pos.Dot(new Vector3(mat.Column1)) + mat.Row3.Y,
				pos.Dot(new Vector3(mat.Column2)) + mat.Row3.Z);
		}

		/// <summary>Transform a Position by the given Matrix</summary>
		/// <param name="pos">The position to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <param name="result">The transformed position</param>
		public static void TransformPosition(this Vector3 pos, ref Matrix4X4 mat, out Vector3 result)
		{
			result.X = pos.X * mat.Row0.X +
					   pos.Y * mat.Row1.X +
					   pos.Z * mat.Row2.X +
					   mat.Row3.X;

			result.Y = pos.X * mat.Row0.Y +
					   pos.Y * mat.Row1.Y +
					   pos.Z * mat.Row2.Y +
					   mat.Row3.Y;

			result.Z = pos.X * mat.Row0.Z +
					   pos.Y * mat.Row1.Z +
					   pos.Z * mat.Row2.Z +
					   mat.Row3.Z;
		}

		/// <summary>
		/// Transform all the vectors in the array by the given Matrix.
		/// </summary>
		/// <param name="boundsVerts"></param>
		/// <param name="rotationQuaternion"></param>
		public static void Transform(this Vector3[] vecArray, Matrix4X4 mat)
		{
			for (int i = 0; i < vecArray.Length; i++)
			{
				vecArray[i] = Transform(vecArray[i], mat);
			}
		}

		/// <summary>Transform a Vector by the given Matrix</summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <returns>The transformed vector</returns>
		public static Vector3 Transform(this Vector3 vec, Matrix4X4 mat)
		{
			return new Vector3(
				vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X + mat.Row3.X,
				vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y + mat.Row3.Y,
				vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z + mat.Row3.Z);
		}

		/// <summary>Transform a Vector by the given Matrix</summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <param name="result">The transformed vector</param>
		public static void Transform(this Vector3 vec, ref Matrix4X4 mat, out Vector3 result)
		{
			result = new Vector3(
				vec.X * mat.Row0.X + vec.Y * mat.Row1.X + vec.Z * mat.Row2.X + mat.Row3.X,
				vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y + vec.Z * mat.Row2.Y + mat.Row3.Y,
				vec.X * mat.Row0.Z + vec.Y * mat.Row1.Z + vec.Z * mat.Row2.Z + mat.Row3.Z);
		}

		/// <summary>
		/// Transforms a vector by a quaternion rotation.
		/// </summary>
		/// <param name="vec">The vector to transform.</param>
		/// <param name="quat">The quaternion to rotate the vector by.</param>
		/// <returns>The result of the operation.</returns>
		public static Vector3 Transform(this Vector3 vec, Quaternion quat)
		{
			Vector3 result;
			Transform(vec, ref quat, out result);
			return result;
		}

		/// <summary>
		/// Transforms a vector by a quaternion rotation.
		/// </summary>
		/// <param name="vec">The vector to transform.</param>
		/// <param name="quat">The quaternion to rotate the vector by.</param>
		/// <param name="result">The result of the operation.</param>
		public static void Transform(this Vector3 vec, ref Quaternion quat, out Vector3 result)
		{
			// Since vec.W == 0, we can optimize quat * vec * quat^-1 as follows:
			// vec + 2.0 * cross(quat.xyz, cross(quat.xyz, vec) + quat.w * vec)
			Vector3 xyz = quat.Xyz, temp, temp2;
			xyz.Cross(ref vec, out temp);
			Vector3.Multiply(ref vec, quat.W, out temp2);
			Vector3.Add(ref temp, ref temp2, out temp);
			xyz.Cross(ref temp, out temp);
			Vector3.Multiply(ref temp, 2, out temp);
			Vector3.Add(ref vec, ref temp, out result);
		}

		/// <summary>
		/// Transform all the vectors in the array by the quaternion rotation.
		/// </summary>
		/// <param name="boundsVerts"></param>
		/// <param name="rotationQuaternion"></param>
		public static void Transform(this Vector3[] vecArray, Quaternion rotationQuaternion)
		{
			for (int i = 0; i < vecArray.Length; i++)
			{
				vecArray[i] = Transform(vecArray[i], rotationQuaternion);
			}
		}

		/// <summary>
		/// Transform a Vector3d by the given Matrix, and project the resulting Vector4 back to a Vector3
		/// </summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <returns>The transformed vector</returns>
		public static Vector3 TransformPerspective(this Vector3 vec, Matrix4X4 mat)
		{
			Vector3 result;
			TransformPerspective(vec, ref mat, out result);
			return result;
		}

		/// <summary>Transform a Vector3d by the given Matrix, and project the resulting Vector4d back to a Vector3d</summary>
		/// <param name="vec">The vector to transform</param>
		/// <param name="mat">The desired transformation</param>
		/// <param name="result">The transformed vector</param>
		public static void TransformPerspective(this Vector3 vec, ref Matrix4X4 mat, out Vector3 result)
		{
			Vector4 v = new Vector4(vec);
			Vector4.Transform(v, ref mat, out v);
			result.X = v.X / v.W;
			result.Y = v.Y / v.W;
			result.Z = v.Z / v.W;
		}

		#endregion Transform
	}
}
