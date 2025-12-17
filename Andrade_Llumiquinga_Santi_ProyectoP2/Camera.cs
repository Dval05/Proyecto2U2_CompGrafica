using System;
using OpenTK;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public enum CameraMode { Orbital, Libre, Fija }

    public class Camera
    {
        public CameraMode Mode { get; set; } = CameraMode.Orbital;
        public Vector3 Eye { get; private set; }
        public Vector3 Target { get; private set; } = Vector3.Zero;
        public Vector3 Up { get; private set; } = Vector3.UnitY;

        // Orbital
        public float Radius { get; set; } = 15f;
        public float AngleX { get; set; } = 0.6f;
        public float AngleY { get; set; } = 0.4f;

        // Libre
        public Vector3 FreePosition { get; set; } = new Vector3(0, 5, 15);

        public Matrix4 GetViewMatrix()
        {
            UpdateCameraPosition();
            return Matrix4.LookAt(Eye, Target, Up);
        }

        private void UpdateCameraPosition()
        {
            switch (Mode)
            {
                case CameraMode.Fija:
                    Eye = new Vector3(15, 15, 15);
                    Target = Vector3.Zero;
                    break;
                case CameraMode.Orbital:
                    float x = Radius * (float)Math.Sin(AngleX) * (float)Math.Cos(AngleY);
                    float y = Radius * (float)Math.Sin(AngleY);
                    float z = Radius * (float)Math.Cos(AngleX) * (float)Math.Cos(AngleY);
                    Eye = new Vector3(x, y, z);
                    Target = Vector3.Zero;
                    break;
                case CameraMode.Libre:
                    Eye = FreePosition;
                    Target = FreePosition + new Vector3(0, 0, -1);
                    break;
            }
        }

        public void HandleMouseDrag(float deltaX, float deltaY)
        {
            if (Mode == CameraMode.Orbital) { AngleX += deltaX * 0.01f; AngleY += deltaY * 0.01f; }
            else if (Mode == CameraMode.Libre) { FreePosition -= new Vector3(deltaX * 0.05f, deltaY * 0.05f, 0); }
        }

        public void Zoom(float delta)
        {
            if (Mode == CameraMode.Orbital) { Radius -= delta * 0.02f; if (Radius < 2f) Radius = 2f; }
            else if (Mode == CameraMode.Libre) { FreePosition += new Vector3(0, 0, -delta * 0.05f); }
        }

        /// <summary>
        /// Restablece la cámara a sus valores iniciales
        /// </summary>
        public void Reset()
        {
            Radius = 15f;
            AngleX = 0.6f;
            AngleY = 0.4f;
            FreePosition = new Vector3(0, 5, 15);
            Target = Vector3.Zero;
        }
    }
}