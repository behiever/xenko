﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Paradox.Graphics.Buffer;


#line 4 "D:\Code\Paradox\sources\shaders\Skybox\SkyboxShader.pdxfx"
namespace SiliconStudio.Paradox.Effects.Skybox
{

    #line 6
    internal static partial class ShaderMixins
    {
        internal partial class SkyboxShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 8
                context.Mixin(mixin, "ImageEffectShader");

                #line 9
                context.Mixin(mixin, "AlbedoFlatShading");

                {

                    #line 10
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                    #line 10
                    context.Mixin(__subMixin, "CubemapSkybox", TexturingKeys.TextureCube0);
                    mixin.Mixin.AddComposition("albedoDiffuse", __subMixin.Mixin);
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
            };
            public ParameterKey[] Keys
            {
                get
                {
                    return __keys__;
                }
            }
            private readonly string[] __mixins__ = new string[]
            {
                "AlbedoFlatShading",
                "CubemapSkybox",
                "ImageEffectShader",
            };
            public string[] Mixins
            {
                get
                {
                    return __mixins__;
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("SkyboxShader", new SkyboxShader());
            }
        }
    }
}
