using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public enum ShapeType { Cubo, Esfera, Cilindro, Cono, Piramide }
    public enum MaterialType { Plastico, Metal, Oro, Goma, Neon }

    public class Figure3D
    {
        public ShapeType Type { get; set; }
        public MaterialType Material { get; set; } = MaterialType.Plastico;

        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }
        public Color Color { get; set; }
        public bool IsWireframe { get; set; } = false;

        public Figure3D()
        {
            Position = Vector3.Zero;
            Rotation = Vector3.Zero;
            Scale = Vector3.One;
            Color = Color.CornflowerBlue;
            Type = ShapeType.Cubo;
        }

        public void Draw()
        {
            GL.PushMatrix();

            // Transformaciones
            GL.Translate(Position);
            GL.Rotate(Rotation.X, 1, 0, 0);
            GL.Rotate(Rotation.Y, 0, 1, 0);
            GL.Rotate(Rotation.Z, 0, 0, 1);
            GL.Scale(Scale);

            // Aplicar Material Avanzado
            ApplyMaterialEffect();

            // Modo Malla
            if (IsWireframe) GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            else GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            // Dibujar
            switch (Type)
            {
                case ShapeType.Cubo: DrawCube(); break;
                case ShapeType.Piramide: DrawPyramid(); break;
                case ShapeType.Esfera: DrawSphere(1.0f, 40, 40); break; // Más suave para que la luz se vea mejor
                case ShapeType.Cilindro: DrawCylinder(0.5f, 1.0f, 40); break;
                case ShapeType.Cono: DrawCone(0.5f, 1.0f, 40); break;
            }

            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.PopMatrix();
        }

        private void ApplyMaterialEffect()
        {
            // Propiedades base
            GL.Material(MaterialFace.Front, MaterialParameter.AmbientAndDiffuse, Color);

            switch (Material)
            {
                case MaterialType.Plastico: // Brillo estándar
                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 1f, 1f, 1f });
                    GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 30.0f);
                    break;
                case MaterialType.Metal: // Muy brillante y concentrado
                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 1f, 1f, 1f });
                    GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 100.0f);
                    break;
                case MaterialType.Oro: // Reflejo amarillo
                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 1f, 0.8f, 0f, 1f });
                    GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 80.0f);
                    break;
                case MaterialType.Goma: // Sin brillo (Mate)
                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, new float[] { 0f, 0f, 0f, 1f });
                    GL.Material(MaterialFace.Front, MaterialParameter.Shininess, 0.0f);
                    break;
                case MaterialType.Neon: // Emite luz propia
                    GL.Material(MaterialFace.Front, MaterialParameter.Emission, Color);
                    break;
            }

            if (Material != MaterialType.Neon)
                GL.Material(MaterialFace.Front, MaterialParameter.Emission, new float[] { 0, 0, 0, 1 });
        }

        public static void DrawGrid(int size)
        {
            GL.Disable(EnableCap.Lighting);
            GL.LineWidth(1.0f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.FromArgb(220, 220, 220));
            for (int i = -size; i <= size; i++)
            {
                GL.Vertex3(-size, 0, i); GL.Vertex3(size, 0, i);
                GL.Vertex3(i, 0, -size); GL.Vertex3(i, 0, size);
            }
            GL.End();

            // Ejes Principales más gruesos
            GL.LineWidth(3.0f);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red); GL.Vertex3(0, 0, 0); GL.Vertex3(size, 0, 0);
            GL.Color3(Color.Green); GL.Vertex3(0, 0, 0); GL.Vertex3(0, size, 0);
            GL.Color3(Color.Blue); GL.Vertex3(0, 0, 0); GL.Vertex3(0, 0, size);
            GL.End();
            GL.Enable(EnableCap.Lighting);
        }

        // --- Geometría ---
        private void DrawCube()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Normal3(0, 0, 1); GL.Vertex3(-1, -1, 1); GL.Vertex3(1, -1, 1); GL.Vertex3(1, 1, 1); GL.Vertex3(-1, 1, 1);
            GL.Normal3(0, 0, -1); GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, 1, -1); GL.Vertex3(1, 1, -1); GL.Vertex3(1, -1, -1);
            GL.Normal3(0, 1, 0); GL.Vertex3(-1, 1, -1); GL.Vertex3(-1, 1, 1); GL.Vertex3(1, 1, 1); GL.Vertex3(1, 1, -1);
            GL.Normal3(0, -1, 0); GL.Vertex3(-1, -1, -1); GL.Vertex3(1, -1, -1); GL.Vertex3(1, -1, 1); GL.Vertex3(-1, -1, 1);
            GL.Normal3(1, 0, 0); GL.Vertex3(1, -1, -1); GL.Vertex3(1, 1, -1); GL.Vertex3(1, 1, 1); GL.Vertex3(1, -1, 1);
            GL.Normal3(-1, 0, 0); GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, -1, 1); GL.Vertex3(-1, 1, 1); GL.Vertex3(-1, 1, -1);
            GL.End();
        }
        private void DrawPyramid()
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Normal3(0, 0.5, 0.5); GL.Vertex3(0, 1, 0); GL.Vertex3(-1, -1, 1); GL.Vertex3(1, -1, 1);
            GL.Normal3(0.5, 0.5, 0); GL.Vertex3(0, 1, 0); GL.Vertex3(1, -1, 1); GL.Vertex3(1, -1, -1);
            GL.Normal3(0, 0.5, -0.5); GL.Vertex3(0, 1, 0); GL.Vertex3(1, -1, -1); GL.Vertex3(-1, -1, -1);
            GL.Normal3(-0.5, 0.5, 0); GL.Vertex3(0, 1, 0); GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, -1, 1);
            GL.End();
            GL.Begin(PrimitiveType.Quads); GL.Normal3(0, -1, 0); GL.Vertex3(-1, -1, 1); GL.Vertex3(-1, -1, -1); GL.Vertex3(1, -1, -1); GL.Vertex3(1, -1, 1); GL.End();
        }
        private void DrawSphere(float r, int sl, int st)
        {
            for (int i = 0; i < st; i++)
            {
                double lat0 = Math.PI * (-0.5 + (double)i / st), z0 = Math.Sin(lat0), zr0 = Math.Cos(lat0);
                double lat1 = Math.PI * (-0.5 + (double)(i + 1) / st), z1 = Math.Sin(lat1), zr1 = Math.Cos(lat1);
                GL.Begin(PrimitiveType.QuadStrip);
                for (int j = 0; j <= sl; j++)
                {
                    double lng = 2 * Math.PI * (double)(j - 1) / sl, x = Math.Cos(lng), y = Math.Sin(lng);
                    GL.Normal3(x * zr0, y * zr0, z0); GL.Vertex3(r * x * zr0, r * y * zr0, r * z0);
                    GL.Normal3(x * zr1, y * zr1, z1); GL.Vertex3(r * x * zr1, r * y * zr1, r * z1);
                }
                GL.End();
            }
        }
        private void DrawCylinder(float r, float h, int seg)
        {
            float yTop = h / 2, yBot = -h / 2; GL.Begin(PrimitiveType.QuadStrip);
            for (int i = 0; i <= seg; i++)
            {
                double a = 2 * Math.PI * i / seg; float x = (float)Math.Cos(a) * r, z = (float)Math.Sin(a) * r;
                GL.Normal3(x, 0, z); GL.Vertex3(x, yTop, z); GL.Vertex3(x, yBot, z);
            }
            GL.End();
        }
        private void DrawCone(float r, float h, int seg)
        {
            float yBot = -h / 2; GL.Begin(PrimitiveType.TriangleFan); GL.Vertex3(0, h / 2, 0);
            for (int i = 0; i <= seg; i++)
            {
                double a = 2 * Math.PI * i / seg; float x = (float)Math.Cos(a) * r, z = (float)Math.Sin(a) * r;
                GL.Normal3(x, 0.5f, z); GL.Vertex3(x, yBot, z);
            }
            GL.End();
        }
    }
}