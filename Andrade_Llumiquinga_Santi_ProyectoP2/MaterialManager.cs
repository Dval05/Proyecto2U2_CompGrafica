using System;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    /// <summary>
    /// Gestor avanzado de materiales con propiedades visuales diferenciadas
    /// </summary>
    public class MaterialManager
    {
        public static void ApplyMaterial(MaterialType material, Color baseColor, bool useTexture = false)
        {
            // Color base del material
            float r = baseColor.R / 255f;
            float g = baseColor.G / 255f;
            float b = baseColor.B / 255f;

            switch (material)
            {
                case MaterialType.Plastico:
                    ApplyPlasticMaterial(r, g, b);
                    break;

                case MaterialType.Metal:
                    ApplyMetalMaterial(r, g, b);
                    break;

                case MaterialType.Oro:
                    ApplyGoldMaterial();
                    break;

                case MaterialType.Goma:
                    ApplyRubberMaterial(r, g, b);
                    break;

                case MaterialType.Neon:
                    ApplyNeonMaterial(r, g, b);
                    break;

                case MaterialType.Cristal:
                    ApplyCrystalMaterial(r, g, b);
                    break;

                case MaterialType.Madera:
                    ApplyWoodMaterial();
                    break;

                case MaterialType.Piedra:
                    ApplyStoneMaterial();
                    break;
            }
        }

        private static void ApplyPlasticMaterial(float r, float g, float b)
        {
            // IMPORTANTE: Habilitar ColorMaterial para usar el color del usuario
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            
            // Establecer el color actual de OpenGL (necesario para ColorMaterial)
            GL.Color3(r, g, b);
            
            // Plástico: color vibrante con brillo medio
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { r * 0.3f, g * 0.3f, b * 0.3f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { r, g, b, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.7f, 0.7f, 0.7f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 32.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        private static void ApplyMetalMaterial(float r, float g, float b)
        {
            // IMPORTANTE: Habilitar ColorMaterial para usar el color del usuario
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            
            // Establecer el color actual de OpenGL (necesario para ColorMaterial)
            GL.Color3(r, g, b);
            
            // Metal: muy brillante, reflectante con tinte metálico
            float metalTint = 0.8f;
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { r * 0.4f, g * 0.4f, b * 0.4f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { r * metalTint, g * metalTint, b * metalTint, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 1f, 1f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 128.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        private static void ApplyGoldMaterial()
        {
            // IMPORTANTE: Deshabilitar ColorMaterial para que use las propiedades del material
            GL.Disable(EnableCap.ColorMaterial);
            
            // Oro: color dorado característico con alto brillo
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { 0.24725f, 0.1995f, 0.0745f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { 0.75164f, 0.60648f, 0.22648f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.628281f, 0.555802f, 0.366065f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 51.2f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        private static void ApplyRubberMaterial(float r, float g, float b)
        {
            // IMPORTANTE: Habilitar ColorMaterial para usar el color del usuario
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            
            // Establecer el color actual de OpenGL (necesario para ColorMaterial)
            GL.Color3(r, g, b);
            
            // Goma: mate, sin brillo, absorbe luz
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { r * 0.4f, g * 0.4f, b * 0.4f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { r * 0.8f, g * 0.8f, b * 0.8f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.05f, 0.05f, 0.05f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 2.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        private static void ApplyNeonMaterial(float r, float g, float b)
        {
            // IMPORTANTE: Habilitar ColorMaterial para usar el color del usuario
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            
            // Establecer el color actual de OpenGL (necesario para ColorMaterial)
            GL.Color3(r, g, b);
            
            // Neón: emite luz propia, muy brillante
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { r * 0.5f, g * 0.5f, b * 0.5f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { r, g, b, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 1f, 1f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 96.0f);
            // ¡La emisión hace que brille!
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { r * 0.6f, g * 0.6f, b * 0.6f, 1f });
        }

        private static void ApplyCrystalMaterial(float r, float g, float b)
        {
            // IMPORTANTE: Habilitar ColorMaterial para usar el color del usuario
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);
            
            // Establecer el color actual de OpenGL (necesario para ColorMaterial)
            GL.Color4(r, g, b, 0.6f); // Con transparencia para cristal
            
            // Cristal: translúcido, muy brillante con tinte de color
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { r * 0.2f, g * 0.2f, b * 0.2f, 0.6f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { r * 0.5f, g * 0.5f, b * 0.5f, 0.6f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 1f, 1f, 0.8f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 100.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { r * 0.1f, g * 0.1f, b * 0.1f, 1f });

            // Habilitar transparencia
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        }

        private static void ApplyWoodMaterial()
        {
            // IMPORTANTE: Deshabilitar ColorMaterial para que use las propiedades del material
            GL.Disable(EnableCap.ColorMaterial);
            
            // Madera: tonos marrones con bajo brillo
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { 0.3f, 0.2f, 0.1f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { 0.6f, 0.4f, 0.2f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.2f, 0.2f, 0.2f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 10.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        private static void ApplyStoneMaterial()
        {
            // IMPORTANTE: Deshabilitar ColorMaterial para que use las propiedades del material
            GL.Disable(EnableCap.ColorMaterial);
            
            // Piedra: gris con textura rugosa
            GL.Material(MaterialFace.Front, MaterialParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Diffuse, new float[] { 0.5f, 0.5f, 0.5f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0.1f, 0.1f, 0.1f, 1f });
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 5.0f);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        public static string GetMaterialDescription(MaterialType material)
        {
            switch (material)
            {
                case MaterialType.Plastico:
                    return "Plástico - Superficie lisa con brillo medio";
                case MaterialType.Metal:
                    return "Metal - Altamente reflectante y brillante";
                case MaterialType.Oro:
                    return "Oro - Material precioso con brillo dorado (color fijo)";
                case MaterialType.Goma:
                    return "Goma - Superficie mate sin reflejos";
                case MaterialType.Neon:
                    return "Neón - Emite luz propia, muy brillante";
                case MaterialType.Cristal:
                    return "Cristal - Translúcido con alto brillo";
                case MaterialType.Madera:
                    return "Madera - Textura natural orgánica (color fijo)";
                case MaterialType.Piedra:
                    return "Piedra - Superficie rugosa mineral (color fijo)";
                default:
                    return "Material desconocido";
            }
        }
    }
}