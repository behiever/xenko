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


#line 3 "D:\Code\Paradox\sources\engine\SiliconStudio.Paradox.Shaders.Tests\GameAssets\Compiler\ToGlslEffect.pdxfx"
namespace Test
{

    #line 5
    internal static partial class ShaderMixins
    {
        internal partial class ToGlslEffect  : IShaderMixinBuilderExtended
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 7
                context.Mixin(mixin, "ToGlslShader");
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
                "ToGlslShader",
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
                ShaderMixinManager.Register("ToGlslEffect", new ToGlslEffect());
            }
        }
    }
}
