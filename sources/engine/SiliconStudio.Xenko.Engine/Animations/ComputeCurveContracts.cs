﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Xenko.Animations
{
    #region Vector4
    /// <summary>
    /// Sampler container for Vector4 data type
    /// </summary>
    [DataContract("ComputeCurveSamplerVector4")]
    [Display("Sampler Vector4")]
    public class ComputeCurveSamplerVector4 : ComputeCurveSampler<Vector4>
    {
        public ComputeCurveSamplerVector4()
        {
            curve = new ComputeAnimationCurveVector4();
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector4 value1, ref Vector4 value2, float t, out Vector4 result)
        {
            Interpolator.Vector4.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Constant Vector4 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeConstCurveVector4")]
    [Display("Constant")]
    public class ComputeConstCurveVector4 : ComputeConstCurve<Vector4> { }

    /// <summary>
    /// Constant Vector4 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeAnimationCurveVector4")]
    [Display("Animation")]
    public class ComputeAnimationCurveVector4 : ComputeAnimationCurve<Vector4>
    {
        /// <inheritdoc/>
        public override void Cubic(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float t, out Vector4 result)
        {
            Interpolator.Vector4.Cubic(ref value1, ref value2, ref value3, ref value4, t, out result);
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector4 value1, ref Vector4 value2, float t, out Vector4 result)
        {
            Interpolator.Vector4.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Binary operator Vector4 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeBinaryCurveVector4")]
    [Display("Binary Operation")]
    public class ComputeBinaryCurveVector4 : ComputeBinaryCurve<Vector4>
    {
        /// <inheritdoc/>
        protected override Vector4 Add(Vector4 a, Vector4 b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        protected override Vector4 Subtract(Vector4 a, Vector4 b)
        {
            return a - b;
        }

        /// <inheritdoc/>
        protected override Vector4 Multiply(Vector4 a, Vector4 b)
        {
            return a * b;
        }
    }

    #endregion

    #region Vector3
    /// <summary>
    /// Sampler container for Vector3 data type
    /// </summary>
    [DataContract("ComputeCurveSamplerVector3")]
    [Display("Sampler Vector3")]
    public class ComputeCurveSamplerVector3 : ComputeCurveSampler<Vector3>
    {
        public ComputeCurveSamplerVector3()
        {
            curve = new ComputeAnimationCurveVector3();
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector3 value1, ref Vector3 value2, float t, out Vector3 result)
        {
            Interpolator.Vector3.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Constant Vector3 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeConstCurveVector3")]
    [Display("Constant")]
    public class ComputeConstCurveVector3 : ComputeConstCurve<Vector3> { }

    /// <summary>
    /// Constant Vector3 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeAnimationCurveVector3")]
    [Display("Animation")]
    public class ComputeAnimationCurveVector3 : ComputeAnimationCurve<Vector3>
    {
        /// <inheritdoc/>
        public override void Cubic(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float t, out Vector3 result)
        {
            Interpolator.Vector3.Cubic(ref value1, ref value2, ref value3, ref value4, t, out result);
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector3 value1, ref Vector3 value2, float t, out Vector3 result)
        {
            Interpolator.Vector3.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Binary operator Vector3 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeBinaryCurveVector3")]
    [Display("Binary Operation")]
    public class ComputeBinaryCurveVector3 : ComputeBinaryCurve<Vector3>
    {
        /// <inheritdoc/>
        protected override Vector3 Add(Vector3 a, Vector3 b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        protected override Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return a - b;
        }

        /// <inheritdoc/>
        protected override Vector3 Multiply(Vector3 a, Vector3 b)
        {
            return a * b;
        }
    }

    #endregion

    #region Vector2
    /// <summary>
    /// Sampler container for Vector2 data type
    /// </summary>
    [DataContract("ComputeCurveSamplerVector2")]
    [Display("Sampler Vector2")]
    public class ComputeCurveSamplerVector2 : ComputeCurveSampler<Vector2>
    {
        public ComputeCurveSamplerVector2()
        {
            curve = new ComputeAnimationCurveVector2();
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector2 value1, ref Vector2 value2, float t, out Vector2 result)
        {
            Interpolator.Vector2.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Constant Vector2 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeConstCurveVector2")]
    [Display("Constant")]
    public class ComputeConstCurveVector2 : ComputeConstCurve<Vector2> { }

    /// <summary>
    /// Constant Vector2 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeAnimationCurveVector2")]
    [Display("Animation")]
    public class ComputeAnimationCurveVector2 : ComputeAnimationCurve<Vector2>
    {
        /// <inheritdoc/>
        public override void Cubic(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float t, out Vector2 result)
        {
            Interpolator.Vector2.Cubic(ref value1, ref value2, ref value3, ref value4, t, out result);
        }

        /// <inheritdoc/>
        public override void Linear(ref Vector2 value1, ref Vector2 value2, float t, out Vector2 result)
        {
            Interpolator.Vector2.Linear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Binary operator Vector2 value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeBinaryCurveVector2")]
    [Display("Binary Operation")]
    public class ComputeBinaryCurveVector2 : ComputeBinaryCurve<Vector2>
    {
        /// <inheritdoc/>
        protected override Vector2 Add(Vector2 a, Vector2 b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        protected override Vector2 Subtract(Vector2 a, Vector2 b)
        {
            return a - b;
        }

        /// <inheritdoc/>
        protected override Vector2 Multiply(Vector2 a, Vector2 b)
        {
            return a * b;
        }
    }

    #endregion

    #region Float
    /// <summary>
    /// Sampler container for float data type
    /// </summary>
    [DataContract("ComputeCurveSamplerFloat")]
    [Display("Sampler Float")]
    public class ComputeCurveSamplerFloat : ComputeCurveSampler<float>
    {
        public ComputeCurveSamplerFloat()
        {
            curve = new ComputeAnimationCurveFloat();
        }

        /// <inheritdoc/>
        public override void Linear(ref float value1, ref float value2, float t, out float result)
        {
            result = value1 + (value2 - value1) * t;
        }
    }

    /// <summary>
    /// Constant float value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeConstCurveFloat")]
    [Display("Constant")]
    public class ComputeConstCurveFloat : ComputeConstCurve<float> { }

    /// <summary>
    /// Binary operator float value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeBinaryCurveFloat")]
    [Display("Binary Operation")]
    public class ComputeBinaryCurveFloat : ComputeBinaryCurve<float>
    {
        /// <inheritdoc/>
        protected override float Add(float a, float b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        protected override float Subtract(float a, float b)
        {
            return a - b;
        }

        /// <inheritdoc/>
        protected override float Multiply(float a, float b)
        {
            return a*b;
        }
    }

    /// <summary>
    /// Animation of a float value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeAnimationCurveFloat")]
    [Display("Animation")]
    public class ComputeAnimationCurveFloat : ComputeAnimationCurve<float>
    {
        /// <inheritdoc/>
        public override void Cubic(ref float value1, ref float value2, ref float value3, ref float value4, float t, out float result)
        {
            result = Interpolator.Cubic(value1, value2, value3, value4, t);
        }

        /// <inheritdoc/>
        public override void Linear(ref float value1, ref float value2, float t, out float result)
        {
            result = Interpolator.Linear(value1, value2, t);
        }
    }

    #endregion

    #region Quaternion
    /// <summary>
    /// Sampler container for Quaternion data type
    /// </summary>
    [DataContract("ComputeCurveSamplerQuaternion")]
    [Display("Sampler Quaternion")]
    public class ComputeCurveSamplerQuaternion : ComputeCurveSampler<Quaternion>
    {
        public ComputeCurveSamplerQuaternion()
        {
            curve = new ComputeAnimationCurveQuaternion();
        }

        /// <inheritdoc/>
        public override void Linear(ref Quaternion value1, ref Quaternion value2, float t, out Quaternion result)
        {
            Interpolator.Quaternion.SphericalLinear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Constant Quaternion value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeConstCurveQuaternion")]
    [Display("Constant")]
    public class ComputeConstCurveQuaternion : ComputeConstCurve<Quaternion> { }

    /// <summary>
    /// Constant Quaternion value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeAnimationCurveQuaternion")]
    [Display("Animation")]
    public class ComputeAnimationCurveQuaternion : ComputeAnimationCurve<Quaternion>
    {
        /// <inheritdoc/>
        public override void Cubic(ref Quaternion value1, ref Quaternion value2, ref Quaternion value3, ref Quaternion value4, float t, out Quaternion result)
        {
            Interpolator.Quaternion.Cubic(ref value1, ref value2, ref value3, ref value4, t, out result);
        }

        /// <inheritdoc/>
        public override void Linear(ref Quaternion value1, ref Quaternion value2, float t, out Quaternion result)
        {
            Interpolator.Quaternion.SphericalLinear(ref value1, ref value2, t, out result);
        }
    }

    /// <summary>
    /// Binary operator Quaternion value for the IComputeCurve interface
    /// </summary>
    [DataContract("ComputeBinaryCurveQuaternion")]
    [Display("Binary Operation")]
    public class ComputeBinaryCurveQuaternion : ComputeBinaryCurve<Quaternion>
    {
        /// <inheritdoc/>
        protected override Quaternion Add(Quaternion a, Quaternion b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        protected override Quaternion Subtract(Quaternion a, Quaternion b)
        {
            return a - b;
        }

        /// <inheritdoc/>
        protected override Quaternion Multiply(Quaternion a, Quaternion b)
        {
            return a * b;
        }
    }

    #endregion

}