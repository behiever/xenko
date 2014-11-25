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


#line 3 "D:\Code\Paradox\sources\engine\SiliconStudio.Paradox.Engine.Tests\Default.pdxfx"
using SiliconStudio.Paradox.Effects.Data;

#line 5
namespace Test
{

    #line 8
    internal static partial class ShaderMixins
    {
        internal partial class GBufferShaderPass  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 11
                context.CloneProperties();

                #line 11
                mixin.Mixin.CloneFrom(mixin.Parent.Mixin);

                #line 12
                context.Mixin(mixin, "GBuffer");

                #line 13
                context.Mixin(mixin, "NormalVSStream");
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
                "GBuffer",
                "NormalVSStream",
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
                ShaderMixinManager.Register("GBufferShaderPass", new GBufferShaderPass());
            }
        }
    }

    #line 17
    internal static partial class ShaderMixins
    {
        internal partial class GBufferPlugin  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                {

                    #line 19
                    var __subMixin = new ShaderMixinSourceTree() { Name = "GBufferShaderPass", Parent = mixin };
                    mixin.Children.Add(__subMixin);

                    #line 19
                    context.BeginChild(__subMixin);

                    #line 19
                    context.Mixin(__subMixin, "GBufferShaderPass");

                    #line 19
                    context.EndChild();
                }

                #line 22
                context.RemoveMixin(mixin, "PositionVSStream");

                #line 23
                context.RemoveMixin(mixin, "NormalVSStream");

                #line 24
                context.RemoveMixin(mixin, "SpecularPowerPerMesh");

                #line 27
                context.Mixin(mixin, "NormalVSGBuffer");

                #line 28
                context.Mixin(mixin, "PositionVSGBuffer");

                #line 29
                context.Mixin(mixin, "SpecularPowerGBuffer");
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
                "GBufferShaderPass",
                "NormalVSGBuffer",
                "NormalVSStream",
                "PositionVSGBuffer",
                "PositionVSStream",
                "SpecularPowerGBuffer",
                "SpecularPowerPerMesh",
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
                ShaderMixinManager.Register("GBufferPlugin", new GBufferPlugin());
            }
        }
    }

    #line 32
    internal static partial class ShaderMixins
    {
        internal partial class LightPrepassEffect  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 34
                context.Mixin(mixin, "LightPrepass");

                #line 35
                context.Mixin(mixin, "PositionVSGBuffer");

                #line 36
                context.Mixin(mixin, "NormalVSGBuffer");

                #line 37
                context.Mixin(mixin, "SpecularPowerGBuffer");

                {

                    #line 38
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                    #line 38
                    context.Mixin(__subMixin, "ComputeBRDFColorFresnel");
                    mixin.Mixin.AddComposition("DiffuseColor", __subMixin.Mixin);
                }

                {

                    #line 39
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                    #line 39
                    context.Mixin(__subMixin, "ComputeBRDFDiffuseLambert");
                    mixin.Mixin.AddComposition("DiffuseLighting", __subMixin.Mixin);
                }

                {

                    #line 40
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                    #line 40
                    context.Mixin(__subMixin, "ComputeBRDFColor");
                    mixin.Mixin.AddComposition("SpecularColor", __subMixin.Mixin);
                }

                {

                    #line 41
                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                    #line 41
                    context.Mixin(__subMixin, "ComputeBRDFColorSpecularBlinnPhong");
                    mixin.Mixin.AddComposition("SpecularLighting", __subMixin.Mixin);
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
                "ComputeBRDFColor",
                "ComputeBRDFColorFresnel",
                "ComputeBRDFColorSpecularBlinnPhong",
                "ComputeBRDFDiffuseLambert",
                "LightPrepass",
                "NormalVSGBuffer",
                "PositionVSGBuffer",
                "SpecularPowerGBuffer",
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
                ShaderMixinManager.Register("LightPrepassEffect", new LightPrepassEffect());
            }
        }
    }

    #line 44
    internal static partial class ShaderMixins
    {
        internal partial class Default  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 50
                context.Mixin(mixin, "ShaderBase");

                #line 51
                context.Mixin(mixin, "TransformationWAndVP");

                #line 52
                context.Mixin(mixin, "BRDFDiffuseBase");

                #line 53
                context.Mixin(mixin, "BRDFSpecularBase");

                #line 54
                context.Mixin(mixin, "AlbedoFlatShading");

                #line 56
                if (context.GetParam(MaterialParameters.AlbedoDiffuse) != null)
                {

                    {

                        #line 58
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 58
                        context.Mixin(__subMixin, "ComputeBRDFDiffuseLambert");
                        mixin.Mixin.AddComposition("DiffuseColor", __subMixin.Mixin);
                    }

                    {

                        #line 59
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 59
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.AlbedoDiffuse));
                        mixin.Mixin.AddComposition("albedoDiffuse", __subMixin.Mixin);
                    }
                }

                #line 62
                if (context.GetParam(MaterialParameters.AlbedoSpecular) != null)
                {

                    {

                        #line 64
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 64
                        context.Mixin(__subMixin, "ComputeBRDFColorSpecularBlinnPhong");
                        mixin.Mixin.AddComposition("SpecularColor", __subMixin.Mixin);
                    }

                    {

                        #line 65
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 65
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.AlbedoSpecular));
                        mixin.Mixin.AddComposition("albedoSpecular", __subMixin.Mixin);
                    }
                }

                #line 68
                if (context.GetParam(MaterialParameters.HasSkinningPosition))
                {

                    #line 70
                    if (context.GetParam(MaterialParameters.SkinningBones) > context.GetParam(MaterialParameters.SkinningMaxBones))
                    {

                        #line 73
                        context.SetParam(MaterialParameters.SkinningMaxBones, context.GetParam(MaterialParameters.SkinningBones));
                    }

                    #line 75
                    mixin.Mixin.AddMacro("SkinningMaxBones", context.GetParam(MaterialParameters.SkinningMaxBones));

                    #line 76
                    context.Mixin(mixin, "TransformationSkinning");
                }

                #line 81
                if (context.GetParam(RenderingParameters.UseDeferred) && !context.GetParam(RenderingParameters.UseTransparent))
                {

                    #line 83
                    context.Mixin(mixin, "GBufferPlugin");

                    #line 84
                    context.Mixin(mixin, "LightDeferredShading");
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                MaterialParameters.AlbedoDiffuse,
                MaterialParameters.AlbedoSpecular,
                MaterialParameters.HasSkinningPosition,
                MaterialParameters.SkinningBones,
                MaterialParameters.SkinningMaxBones,
                RenderingParameters.UseDeferred,
                RenderingParameters.UseTransparent,
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
                "BRDFDiffuseBase",
                "BRDFSpecularBase",
                "ComputeBRDFColorSpecularBlinnPhong",
                "ComputeBRDFDiffuseLambert",
                "GBufferPlugin",
                "LightDeferredShading",
                "ShaderBase",
                "TransformationSkinning",
                "TransformationWAndVP",
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
                ShaderMixinManager.Register("Default", new Default());
            }
        }
    }
}
