using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public enum LightingMode
    {
        Dia,        // Luz brillante desde arriba
        Noche,      // Luz tenue azulada
        Atardecer,  // Luz cálida naranja
        Estudio     // Múltiples luces para resaltar detalles
    }

    /// <summary>
    /// Sistema avanzado de iluminación con múltiples modos y configuraciones
    /// </summary>
    public class LightingSystem
    {
        public LightingMode Mode { get; set; } = LightingMode.Dia;
        public float Intensity { get; set; } = 1.0f;
        public bool EnableShadows { get; set; } = false;

        private float _time = 0f;

        public void Setup()
        {
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse);

            // Normalización automática de normales
            GL.Enable(EnableCap.Normalize);
        }

        public void Update(float deltaTime = 0.016f)
        {
            _time += deltaTime;
            ApplyLightingMode();
        }

        private void ApplyLightingMode()
        {
            float intensity = Intensity;

            switch (Mode)
            {
                case LightingMode.Dia:
                    ApplyDaylightMode(intensity);
                    break;

                case LightingMode.Noche:
                    ApplyNightMode(intensity);
                    break;

                case LightingMode.Atardecer:
                    ApplySunsetMode(intensity);
                    break;

                case LightingMode.Estudio:
                    ApplyStudioMode(intensity);
                    break;
            }
        }

        private void ApplyDaylightMode(float intensity)
        {
            // Luz principal: Sol desde arriba
            GL.Light(LightName.Light0, LightParameter.Position, new float[] { 15f, 20f, 10f, 1f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] {
                1.0f * intensity,
                0.98f * intensity,
                0.9f * intensity,
                1f
            });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 1f, 1f, 1f, 1f });

            // Luz secundaria: Luz de relleno suave
            GL.Light(LightName.Light1, LightParameter.Position, new float[] { -10f, 10f, -10f, 1f });
            GL.Light(LightName.Light1, LightParameter.Ambient, new float[] { 0.1f, 0.1f, 0.1f, 1f });
            GL.Light(LightName.Light1, LightParameter.Diffuse, new float[] {
                0.3f * intensity,
                0.3f * intensity,
                0.35f * intensity,
                1f
            });
            GL.Light(LightName.Light1, LightParameter.Specular, new float[] { 0.2f, 0.2f, 0.2f, 1f });

            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);
        }

        private void ApplyNightMode(float intensity)
        {
            // Luz principal: Luna (azulada y tenue)
            GL.Light(LightName.Light0, LightParameter.Position, new float[] { -5f, 15f, 5f, 1f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.05f, 0.05f, 0.1f, 1f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] {
                0.3f * intensity,
                0.35f * intensity,
                0.5f * intensity,
                1f
            });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 0.4f, 0.4f, 0.6f, 1f });

            // Luz secundaria: Luz ambiente muy tenue
            GL.Light(LightName.Light1, LightParameter.Position, new float[] { 0f, 5f, 0f, 1f });
            GL.Light(LightName.Light1, LightParameter.Ambient, new float[] { 0.02f, 0.02f, 0.05f, 1f });
            GL.Light(LightName.Light1, LightParameter.Diffuse, new float[] {
                0.1f * intensity,
                0.1f * intensity,
                0.15f * intensity,
                1f
            });

            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);
        }

        private void ApplySunsetMode(float intensity)
        {
            // Luz principal: Sol del atardecer (naranja/rojo)
            GL.Light(LightName.Light0, LightParameter.Position, new float[] { 20f, 5f, 0f, 1f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.2f, 0.1f, 0.05f, 1f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] {
                1.0f * intensity,
                0.5f * intensity,
                0.2f * intensity,
                1f
            });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 1f, 0.6f, 0.3f, 1f });

            // Luz secundaria: Reflejo del cielo (violeta)
            GL.Light(LightName.Light1, LightParameter.Position, new float[] { -15f, 10f, 5f, 1f });
            GL.Light(LightName.Light1, LightParameter.Ambient, new float[] { 0.1f, 0.05f, 0.15f, 1f });
            GL.Light(LightName.Light1, LightParameter.Diffuse, new float[] {
                0.4f * intensity,
                0.2f * intensity,
                0.6f * intensity,
                1f
            });

            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);
        }

        private void ApplyStudioMode(float intensity)
        {
            // Luz principal: Luz frontal intensa
            GL.Light(LightName.Light0, LightParameter.Position, new float[] { 0f, 15f, 15f, 1f });
            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] {
                1.0f * intensity,
                1.0f * intensity,
                1.0f * intensity,
                1f
            });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 1f, 1f, 1f, 1f });

            // Luz secundaria: Luz de relleno lateral
            GL.Light(LightName.Light1, LightParameter.Position, new float[] { -15f, 5f, 0f, 1f });
            GL.Light(LightName.Light1, LightParameter.Ambient, new float[] { 0.2f, 0.2f, 0.2f, 1f });
            GL.Light(LightName.Light1, LightParameter.Diffuse, new float[] {
                0.6f * intensity,
                0.6f * intensity,
                0.6f * intensity,
                1f
            });
            GL.Light(LightName.Light1, LightParameter.Specular, new float[] { 0.5f, 0.5f, 0.5f, 1f });

            GL.Enable(EnableCap.Light0);
            GL.Enable(EnableCap.Light1);
        }

        public void Cleanup()
        {
            GL.Disable(EnableCap.Light0);
            GL.Disable(EnableCap.Light1);
            GL.Disable(EnableCap.Lighting);
        }

        public string GetModeDescription()
        {
            switch (Mode)
            {
                case LightingMode.Dia:
                    return "Día - Iluminación solar brillante";
                case LightingMode.Noche:
                    return "Noche - Luz lunar tenue y azulada";
                case LightingMode.Atardecer:
                    return "Atardecer - Tonos cálidos naranjas";
                case LightingMode.Estudio:
                    return "Estudio - Iluminación profesional múltiple";
                default:
                    return "Modo desconocido";
            }
        }
    }
}