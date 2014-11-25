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


#line 3 "D:\Code\Paradox\sources\shaders\DefaultForwardEffect.pdxfx"
using SiliconStudio.Paradox.Effects.Data;

#line 4
using SiliconStudio.Paradox.Effects;

#line 5
using SiliconStudio.Paradox.Engine;

#line 6
using SiliconStudio.Paradox.DataModel;

#line 8
namespace DefaultForward
{

    #line 10
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxLightingTypeShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 14
                if (context.GetParam(MaterialParameters.LightingType) == MaterialLightingType.DiffusePixel)
                {

                    #line 16
                    context.Mixin(mixin, "ShadingDiffusePerPixel");
                }

                #line 18
                else 
#line 18
                if (context.GetParam(MaterialParameters.LightingType) == MaterialLightingType.DiffuseVertex)
                {

                    #line 20
                    context.Mixin(mixin, "ShadingDiffusePerVertex");
                }

                #line 22
                else 
#line 22
                if (context.GetParam(MaterialParameters.LightingType) == MaterialLightingType.DiffuseSpecularPixel)
                {

                    #line 24
                    context.Mixin(mixin, "ShadingDiffuseSpecularPerPixel");
                }

                #line 26
                else 
#line 26
                if (context.GetParam(MaterialParameters.LightingType) == MaterialLightingType.DiffuseVertexSpecularPixel)
                {

                    #line 28
                    context.Mixin(mixin, "ShadingDiffusePerVertexSpecularPerPixel");
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                MaterialParameters.LightingType,
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
                "ShadingDiffusePerPixel",
                "ShadingDiffusePerVertex",
                "ShadingDiffusePerVertexSpecularPerPixel",
                "ShadingDiffuseSpecularPerPixel",
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
                ShaderMixinManager.Register("ParadoxLightingTypeShader", new ParadoxLightingTypeShader());
            }
        }
    }

    #line 32
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxPointLightsShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 37
                mixin.Mixin.AddMacro("LIGHTING_MAX_LIGHT_COUNT", context.GetParam(LightingKeys.MaxPointLights));

                #line 41
                context.Mixin(mixin, "ParadoxLightingTypeShader");

                #line 42
                context.Mixin(mixin, "PointShading");

                #line 43
                context.Mixin(mixin, "ShadingEyeNormalVS");
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                LightingKeys.MaxPointLights,
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
                "ParadoxLightingTypeShader",
                "PointShading",
                "ShadingEyeNormalVS",
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
                ShaderMixinManager.Register("ParadoxPointLightsShader", new ParadoxPointLightsShader());
            }
        }
    }

    #line 46
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxSpotLightsShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 51
                mixin.Mixin.AddMacro("LIGHTING_MAX_LIGHT_COUNT", context.GetParam(LightingKeys.MaxSpotLights));

                #line 55
                context.Mixin(mixin, "ParadoxLightingTypeShader");

                #line 56
                context.Mixin(mixin, "SpotShading");

                #line 57
                context.Mixin(mixin, "ShadingEyeNormalVS");
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                LightingKeys.MaxSpotLights,
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
                "ParadoxLightingTypeShader",
                "ShadingEyeNormalVS",
                "SpotShading",
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
                ShaderMixinManager.Register("ParadoxSpotLightsShader", new ParadoxSpotLightsShader());
            }
        }
    }

    #line 60
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxDirectionalLightsShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 66
                mixin.Mixin.AddMacro("LIGHTING_MAX_LIGHT_COUNT", context.GetParam(LightingKeys.MaxDirectionalLights));

                #line 70
                context.Mixin(mixin, "ParadoxLightingTypeShader");

                #line 71
                context.Mixin(mixin, "DirectionalShading");

                #line 72
                context.Mixin(mixin, "ShadingEyeNormalVS");
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                LightingKeys.MaxDirectionalLights,
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
                "DirectionalShading",
                "ParadoxLightingTypeShader",
                "ShadingEyeNormalVS",
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
                ShaderMixinManager.Register("ParadoxDirectionalLightsShader", new ParadoxDirectionalLightsShader());
            }
        }
    }

    #line 75
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxDirectionalShadowLightsShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 82
                mixin.Mixin.AddMacro("LIGHTING_MAX_LIGHT_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount));

                #line 85
                context.Mixin(mixin, "ParadoxLightingTypeShader");

                #line 86
                context.Mixin(mixin, "ShadingPerPixelShadow");

                #line 87
                context.Mixin(mixin, "DirectionalShading");

                #line 88
                context.Mixin(mixin, "ShadingEyeNormalVS");

                #line 91
                context.Mixin(mixin, "ForwardShadowMapBase");

                #line 92
                context.Mixin(mixin, "ShadowMapCascadeBase");

                #line 94
                mixin.Mixin.AddMacro("SHADOWMAP_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount));

                #line 95
                mixin.Mixin.AddMacro("SHADOWMAP_CASCADE_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCascadeCount));

                #line 96
                mixin.Mixin.AddMacro("SHADOWMAP_TOTAL_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount) * context.GetParam(ShadowMapParameters.ShadowMapCascadeCount));

                #line 99
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.Nearest)

                    #line 100
                    context.Mixin(mixin, "ShadowMapFilterDefault");

                #line 101
                else 
#line 101
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.PercentageCloserFiltering)

                    #line 102
                    context.Mixin(mixin, "ShadowMapFilterPcf");

                #line 103
                else 
#line 103
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.Variance)

                    #line 104
                    context.Mixin(mixin, "ShadowMapFilterVsm");
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                ShadowMapParameters.FilterType,
                ShadowMapParameters.ShadowMapCascadeCount,
                ShadowMapParameters.ShadowMapCount,
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
                "DirectionalShading",
                "ForwardShadowMapBase",
                "ParadoxLightingTypeShader",
                "ShadingEyeNormalVS",
                "ShadingPerPixelShadow",
                "ShadowMapCascadeBase",
                "ShadowMapFilterDefault",
                "ShadowMapFilterPcf",
                "ShadowMapFilterVsm",
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
                ShaderMixinManager.Register("ParadoxDirectionalShadowLightsShader", new ParadoxDirectionalShadowLightsShader());
            }
        }
    }

    #line 107
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxSpotShadowLightsShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 114
                mixin.Mixin.AddMacro("LIGHTING_MAX_LIGHT_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount));

                #line 117
                context.Mixin(mixin, "ParadoxLightingTypeShader");

                #line 118
                context.Mixin(mixin, "ShadingPerPixelShadow");

                #line 119
                context.Mixin(mixin, "SpotShading");

                #line 120
                context.Mixin(mixin, "ShadingEyeNormalVS");

                #line 123
                context.Mixin(mixin, "ForwardShadowMapBase");

                #line 124
                context.Mixin(mixin, "ShadowMapCascadeBase");

                #line 126
                mixin.Mixin.AddMacro("SHADOWMAP_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount));

                #line 127
                mixin.Mixin.AddMacro("SHADOWMAP_CASCADE_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCascadeCount));

                #line 128
                mixin.Mixin.AddMacro("SHADOWMAP_TOTAL_COUNT", context.GetParam(ShadowMapParameters.ShadowMapCount) * context.GetParam(ShadowMapParameters.ShadowMapCascadeCount));

                #line 131
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.Nearest)

                    #line 132
                    context.Mixin(mixin, "ShadowMapFilterDefault");

                #line 133
                else 
#line 133
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.PercentageCloserFiltering)

                    #line 134
                    context.Mixin(mixin, "ShadowMapFilterPcf");

                #line 135
                else 
#line 135
                if (context.GetParam(ShadowMapParameters.FilterType) == ShadowMapFilterType.Variance)

                    #line 136
                    context.Mixin(mixin, "ShadowMapFilterVsm");
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                ShadowMapParameters.FilterType,
                ShadowMapParameters.ShadowMapCascadeCount,
                ShadowMapParameters.ShadowMapCount,
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
                "ForwardShadowMapBase",
                "ParadoxLightingTypeShader",
                "ShadingEyeNormalVS",
                "ShadingPerPixelShadow",
                "ShadowMapCascadeBase",
                "ShadowMapFilterDefault",
                "ShadowMapFilterPcf",
                "ShadowMapFilterVsm",
                "SpotShading",
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
                ShaderMixinManager.Register("ParadoxSpotShadowLightsShader", new ParadoxSpotShadowLightsShader());
            }
        }
    }

    #line 139
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxDiffuseForward  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 145
                context.Mixin(mixin, "BRDFDiffuseBase");

                #line 146
                context.Mixin(mixin, "BRDFSpecularBase");

                #line 148
                if (context.GetParam(MaterialParameters.AlbedoDiffuse) != null)
                {

                    #line 150
                    context.Mixin(mixin, "AlbedoDiffuseBase");

                    {

                        #line 151
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 151
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.AlbedoDiffuse));
                        mixin.Mixin.AddComposition("albedoDiffuse", __subMixin.Mixin);
                    }

                    #line 153
                    if (context.GetParam(LightingKeys.MaxDirectionalLights) > 0 || context.GetParam(LightingKeys.MaxSpotLights) > 0 || context.GetParam(LightingKeys.MaxPointLights) > 0 || (context.GetParam(LightingKeys.ReceiveShadows) && context.GetParam(ShadowMapParameters.ShadowMaps) != null && context.GetParam(ShadowMapParameters.ShadowMaps).Length > 0))
                    {

                        #line 155
                        if (context.GetParam(LightingKeys.MaxDirectionalLights) > 0 || context.GetParam(LightingKeys.MaxSpotLights) > 0 || context.GetParam(LightingKeys.MaxPointLights) > 0)
                        {

                            #line 157
                            context.Mixin(mixin, "GroupShadingBase");

                            #line 159
                            if (context.GetParam(LightingKeys.MaxDirectionalLights) > 0)

                                {

                                    #line 160
                                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                    #line 160
                                    context.Mixin(__subMixin, "ParadoxDirectionalLightsShader");
                                    mixin.Mixin.AddCompositionToArray("ShadingGroups", __subMixin.Mixin);
                                }

                            #line 161
                            if (context.GetParam(LightingKeys.MaxSpotLights) > 0)

                                {

                                    #line 162
                                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                    #line 162
                                    context.Mixin(__subMixin, "ParadoxSpotLightsShader");
                                    mixin.Mixin.AddCompositionToArray("ShadingGroups", __subMixin.Mixin);
                                }

                            #line 163
                            if (context.GetParam(LightingKeys.MaxPointLights) > 0)

                                {

                                    #line 164
                                    var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                    #line 164
                                    context.Mixin(__subMixin, "ParadoxPointLightsShader");
                                    mixin.Mixin.AddCompositionToArray("ShadingGroups", __subMixin.Mixin);
                                }
                        }

                        #line 166
                        if (context.GetParam(LightingKeys.ReceiveShadows) && context.GetParam(ShadowMapParameters.ShadowMaps) != null && context.GetParam(ShadowMapParameters.ShadowMaps).Length > 0)
                        {

                            #line 168
                            context.Mixin(mixin, "ShadowMapReceiver");

                            #line 169
                            foreach(var ____1 in context.GetParam(ShadowMapParameters.ShadowMaps))

                            {

                                #line 169
                                context.PushParameters(____1);

                                #line 171
                                if (context.GetParam(ShadowMapParameters.LightType) == LightType.Directional)

                                    {

                                        #line 172
                                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                        #line 172
                                        context.Mixin(__subMixin, "ParadoxDirectionalShadowLightsShader");
                                        mixin.Mixin.AddCompositionToArray("shadows", __subMixin.Mixin);
                                    }

                                #line 173
                                else 
#line 173
                                if (context.GetParam(ShadowMapParameters.LightType) == LightType.Spot)

                                    {

                                        #line 174
                                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                        #line 174
                                        context.Mixin(__subMixin, "ParadoxSpotShadowLightsShader");
                                        mixin.Mixin.AddCompositionToArray("shadows", __subMixin.Mixin);
                                    }

                                #line 169
                                context.PopParameters();
                            }
                        }

                        #line 178
                        if (context.GetParam(MaterialParameters.DiffuseModel) == MaterialDiffuseModel.None || context.GetParam(MaterialParameters.DiffuseModel) == MaterialDiffuseModel.Lambert)
                        {

                            {

                                #line 180
                                var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                #line 180
                                context.Mixin(__subMixin, "ComputeBRDFDiffuseLambert");
                                mixin.Mixin.AddComposition("DiffuseLighting", __subMixin.Mixin);
                            }
                        }

                        #line 182
                        else 
#line 182
                        if (context.GetParam(MaterialParameters.DiffuseModel) == MaterialDiffuseModel.OrenNayar)
                        {

                            {

                                #line 184
                                var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                                #line 184
                                context.Mixin(__subMixin, "ComputeBRDFDiffuseOrenNayar");
                                mixin.Mixin.AddComposition("DiffuseLighting", __subMixin.Mixin);
                            }
                        }
                    }

                    #line 188
                    else
                    {

                        #line 189
                        context.Mixin(mixin, "AlbedoFlatShading");
                    }
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                LightingKeys.MaxDirectionalLights,
                LightingKeys.MaxPointLights,
                LightingKeys.MaxSpotLights,
                LightingKeys.ReceiveShadows,
                MaterialParameters.AlbedoDiffuse,
                MaterialParameters.DiffuseModel,
                ShadowMapParameters.LightType,
                ShadowMapParameters.ShadowMaps,
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
                "AlbedoDiffuseBase",
                "AlbedoFlatShading",
                "BRDFDiffuseBase",
                "BRDFSpecularBase",
                "ComputeBRDFDiffuseLambert",
                "ComputeBRDFDiffuseOrenNayar",
                "GroupShadingBase",
                "ParadoxDirectionalLightsShader",
                "ParadoxDirectionalShadowLightsShader",
                "ParadoxPointLightsShader",
                "ParadoxSpotLightsShader",
                "ParadoxSpotShadowLightsShader",
                "ShadowMapReceiver",
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
                ShaderMixinManager.Register("ParadoxDiffuseForward", new ParadoxDiffuseForward());
            }
        }
    }

    #line 194
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxSpecularLighting  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 198
                if (context.GetParam(MaterialParameters.SpecularModel) == MaterialSpecularModel.None || context.GetParam(MaterialParameters.SpecularModel) == MaterialSpecularModel.Phong)
                {

                    #line 200
                    context.Mixin(mixin, "ComputeBRDFColorSpecularPhong");
                }

                #line 202
                else 
#line 202
                if (context.GetParam(MaterialParameters.SpecularModel) == MaterialSpecularModel.BlinnPhong)
                {

                    #line 204
                    context.Mixin(mixin, "ComputeBRDFColorSpecularBlinnPhong");
                }

                #line 206
                else 
#line 206
                if (context.GetParam(MaterialParameters.SpecularModel) == MaterialSpecularModel.CookTorrance)
                {

                    #line 208
                    context.Mixin(mixin, "ComputeBRDFColorSpecularCookTorrance");
                }

                #line 213
                if (context.GetParam(MaterialParameters.SpecularPowerMap) != null)
                {

                    #line 215
                    context.Mixin(mixin, "SpecularPower");

                    {

                        #line 216
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 216
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.SpecularPowerMap));
                        mixin.Mixin.AddComposition("SpecularPowerMap", __subMixin.Mixin);
                    }
                }

                #line 219
                if (context.GetParam(MaterialParameters.SpecularIntensityMap) != null)
                {

                    {

                        #line 221
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 221
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.SpecularIntensityMap));
                        mixin.Mixin.AddComposition("SpecularIntensityMap", __subMixin.Mixin);
                    }
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                MaterialParameters.SpecularIntensityMap,
                MaterialParameters.SpecularModel,
                MaterialParameters.SpecularPowerMap,
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
                "ComputeBRDFColorSpecularBlinnPhong",
                "ComputeBRDFColorSpecularCookTorrance",
                "ComputeBRDFColorSpecularPhong",
                "SpecularPower",
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
                ShaderMixinManager.Register("ParadoxSpecularLighting", new ParadoxSpecularLighting());
            }
        }
    }

    #line 225
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxSpecularForward  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 230
                context.Mixin(mixin, "BRDFDiffuseBase");

                #line 231
                context.Mixin(mixin, "BRDFSpecularBase");

                #line 233
                if (context.GetParam(MaterialParameters.AlbedoSpecular) != null)
                {

                    #line 235
                    context.Mixin(mixin, "AlbedoSpecularBase");

                    {

                        #line 236
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 236
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.AlbedoSpecular));
                        mixin.Mixin.AddComposition("albedoSpecular", __subMixin.Mixin);
                    }

                    {

                        #line 237
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 237
                        context.Mixin(__subMixin, "ParadoxSpecularLighting");
                        mixin.Mixin.AddComposition("SpecularLighting", __subMixin.Mixin);
                    }
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                MaterialParameters.AlbedoSpecular,
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
                "AlbedoSpecularBase",
                "BRDFDiffuseBase",
                "BRDFSpecularBase",
                "ParadoxSpecularLighting",
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
                ShaderMixinManager.Register("ParadoxSpecularForward", new ParadoxSpecularForward());
            }
        }
    }

    #line 241
    internal static partial class ShaderMixins
    {
        internal partial class ParadoxDefaultForwardShader  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 245
                context.Mixin(mixin, "ParadoxBaseShader");

                #line 247
                context.Mixin(mixin, "ParadoxSkinning");

                #line 249
                context.Mixin(mixin, "ParadoxShadowCast");

                #line 251
                context.Mixin(mixin, "ParadoxDiffuseForward");

                #line 252
                context.Mixin(mixin, "ParadoxSpecularForward");

                #line 254
                if (context.GetParam(MaterialParameters.AmbientMap) != null)
                {

                    #line 256
                    context.Mixin(mixin, "AmbientMapShading");

                    {

                        #line 257
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 257
                        context.Mixin(__subMixin, context.GetParam(MaterialParameters.AmbientMap));
                        mixin.Mixin.AddComposition("AmbientMap", __subMixin.Mixin);
                    }
                }

                #line 260
                if (context.GetParam(MaterialParameters.UseTransparentMask))
                {

                    #line 262
                    context.Mixin(mixin, "TransparentShading");

                    #line 263
                    context.Mixin(mixin, "DiscardTransparentThreshold", context.GetParam(MaterialParameters.AlphaDiscardThreshold));
                }

                #line 265
                else 
#line 265
                if (context.GetParam(MaterialParameters.UseTransparent))
                {

                    #line 267
                    context.Mixin(mixin, "TransparentShading");

                    #line 268
                    context.Mixin(mixin, "DiscardTransparent");
                }
            }
            private readonly ParameterKey[] __keys__ = new ParameterKey[]
            {
                MaterialParameters.AlphaDiscardThreshold,
                MaterialParameters.AmbientMap,
                MaterialParameters.UseTransparent,
                MaterialParameters.UseTransparentMask,
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
                "AmbientMapShading",
                "DiscardTransparent",
                "DiscardTransparentThreshold",
                "ParadoxBaseShader",
                "ParadoxDiffuseForward",
                "ParadoxShadowCast",
                "ParadoxSkinning",
                "ParadoxSpecularForward",
                "TransparentShading",
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
                ShaderMixinManager.Register("ParadoxDefaultForwardShader", new ParadoxDefaultForwardShader());
            }
        }
    }
}
