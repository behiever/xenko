﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using SiliconStudio.Core;
using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Xenko.Particles.Initializers
{
    [DataContract("Initial3DRotationSeed")]
    [Display("Initial 3D Orientation")]
    public class Initial3DRotationSeed : ParticleInitializer
    {
        public Initial3DRotationSeed()
        {
            RequiredFields.Add(ParticleFields.Quaternion);
            RequiredFields.Add(ParticleFields.RandomSeed);

            DisplayParticleRotation = true;
        }

        /// <inheritdoc />
        public unsafe override void Initialize(ParticlePool pool, int startIdx, int endIdx, int maxCapacity)
        {
            if (!pool.FieldExists(ParticleFields.Quaternion) || !pool.FieldExists(ParticleFields.RandomSeed))
                return;

            var rotField = pool.GetField(ParticleFields.Quaternion);
            var rndField = pool.GetField(ParticleFields.RandomSeed);

            var i = startIdx;
            while (i != endIdx)
            {
                var particle = pool.FromIndex(i);
                var randSeed = particle.Get(rndField);

                var randomRotation = Quaternion.Slerp(RotationQuaternionMin, RotationQuaternionMax, randSeed.GetFloat(RandomOffset.Offset1A + SeedOffset));
                
                // Results in errors ("small" quaternion) when interpolation -90 to +90 degree rotations, so we have to normalize it
                randomRotation.Normalize();
            
                (*((Quaternion*)particle[rotField])) = randomRotation * WorldRotation;

                i = (i + 1) % maxCapacity;
            }
        }

        /// <summary>
        /// The seed offset used to match or separate random values
        /// </summary>
        /// <userdoc>
        /// The seed offset used to match or separate random values
        /// </userdoc>
        [DataMember(8)]
        [Display("Random Seed")]
        public uint SeedOffset { get; set; } = 0;

        /// <summary>
        /// The first orientation to interpolate from
        /// </summary>
        /// <userdoc>
        /// The first orientation to interpolate from
        /// </userdoc>
        [DataMember(30)]
        [Display("Orientation A")]
        public Quaternion RotationQuaternionMin { get; set; } = new Quaternion(0, 0, 0, 1);

        /// <summary>
        /// The second orientation to interpolate to
        /// </summary>
        /// <userdoc>
        /// The second orientation to interpolate to
        /// </userdoc>
        [DataMember(40)]
        [Display("Orientation B")]
        public Quaternion RotationQuaternionMax { get; set; } = new Quaternion(0, 0, 0, 1);
        
    }
}
