using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Andrade_Llumiquinga_Santi_ProyectoP2
{
    public enum ShapeType { Cubo, Esfera, Cilindro, Cono, Piramide, Torus, Octaedro }
    public enum MaterialType { Plastico, Metal, Oro, Goma, Neon, Cristal, Madera, Piedra }

    /// <summary>
    /// Clase mejorada para representar figuras 3D con materiales avanzados
    /// </summary>
    public class Figure3D
    {
        // Propiedades de la figura
        public ShapeType Type { get; set; }
        public MaterialType Material { get; set; } = MaterialType.Plastico;
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }
        public Color Color { get; set; }
        public bool IsWireframe { get; set; } = false;

        // Animación
        private float _animationTime = 0f;

        public Figure3D()
        {
            Position = Vector3.Zero;
            Rotation = Vector3.Zero;
            Scale = Vector3.One;
            Color = Color.DodgerBlue;
            Type = ShapeType.Cubo;
        }

        public void Update(float deltaTime)
        {
            _animationTime += deltaTime;
        }

        public void Draw()
        {
            GL.PushMatrix();

            // Aplicar transformaciones
            GL.Translate(Position);
            GL.Rotate(Rotation.X, 1, 0, 0);
            GL.Rotate(Rotation.Y, 0, 1, 0);
            GL.Rotate(Rotation.Z, 0, 0, 1);
            GL.Scale(Scale);

            // Aplicar material usando el MaterialManager
            MaterialManager.ApplyMaterial(Material, Color);

            // Modo wireframe si está activado
            if (IsWireframe)
            {
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                GL.LineWidth(2.0f);
            }
            else
            {
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            }

            // Dibujar la geometría
            DrawGeometry();

            // Restaurar modo de polígono
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.Disable(EnableCap.Blend);

            GL.PopMatrix();
        }

        private void DrawGeometry()
        {
            switch (Type)
            {
                case ShapeType.Cubo:
                    DrawCube();
                    break;
                case ShapeType.Piramide:
                    DrawPyramid();
                    break;
                case ShapeType.Esfera:
                    DrawSphere(1.0f, 50, 50);
                    break;
                case ShapeType.Cilindro:
                    DrawCylinder(0.5f, 1.0f, 50);
                    break;
                case ShapeType.Cono:
                    DrawCone(0.5f, 1.0f, 50);
                    break;
                case ShapeType.Torus:
                    DrawTorus(0.3f, 0.7f, 30, 30);
                    break;
                case ShapeType.Octaedro:
                    DrawOctahedron();
                    break;
            }
        }

        /// <summary>
        /// Dibuja una cuadrícula en el plano XZ
        /// </summary>
        public static void DrawGrid(int size, bool darkMode = false)
        {
            GL.Disable(EnableCap.Lighting);
            GL.LineWidth(1.0f);

            // Color de la cuadrícula según el modo
            Color gridColor = darkMode ? Color.FromArgb(60, 60, 70) : Color.FromArgb(220, 220, 220);

            GL.Begin(PrimitiveType.Lines);
            GL.Color3(gridColor);
            for (int i = -size; i <= size; i++)
            {
                GL.Vertex3(-size, 0, i);
                GL.Vertex3(size, 0, i);
                GL.Vertex3(i, 0, -size);
                GL.Vertex3(i, 0, size);
            }
            GL.End();

            // Ejes principales (X=Rojo, Y=Verde, Z=Azul)
            GL.LineWidth(3.0f);
            GL.Begin(PrimitiveType.Lines);

            // Eje X (Rojo)
            GL.Color3(Color.FromArgb(255, 80, 80));
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(size, 0, 0);

            // Eje Y (Verde)
            GL.Color3(Color.FromArgb(80, 255, 80));
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, size, 0);

            // Eje Z (Azul)
            GL.Color3(Color.FromArgb(80, 80, 255));
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, size);

            GL.End();
            GL.Enable(EnableCap.Lighting);
        }

        // ===== GEOMETRÍAS =====

        private void DrawCube()
        {
            GL.Begin(PrimitiveType.Quads);

            // Frente
            GL.Normal3(0, 0, 1);
            GL.Vertex3(-1, -1, 1); GL.Vertex3(1, -1, 1);
            GL.Vertex3(1, 1, 1); GL.Vertex3(-1, 1, 1);

            // Atrás
            GL.Normal3(0, 0, -1);
            GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, 1, -1);
            GL.Vertex3(1, 1, -1); GL.Vertex3(1, -1, -1);

            // Arriba
            GL.Normal3(0, 1, 0);
            GL.Vertex3(-1, 1, -1); GL.Vertex3(-1, 1, 1);
            GL.Vertex3(1, 1, 1); GL.Vertex3(1, 1, -1);

            // Abajo
            GL.Normal3(0, -1, 0);
            GL.Vertex3(-1, -1, -1); GL.Vertex3(1, -1, -1);
            GL.Vertex3(1, -1, 1); GL.Vertex3(-1, -1, 1);

            // Derecha
            GL.Normal3(1, 0, 0);
            GL.Vertex3(1, -1, -1); GL.Vertex3(1, 1, -1);
            GL.Vertex3(1, 1, 1); GL.Vertex3(1, -1, 1);

            // Izquierda
            GL.Normal3(-1, 0, 0);
            GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, -1, 1);
            GL.Vertex3(-1, 1, 1); GL.Vertex3(-1, 1, -1);

            GL.End();
        }

        private void DrawPyramid()
        {
            GL.Begin(PrimitiveType.Triangles);

            // Cara frontal
            GL.Normal3(0, 0.5, 0.5);
            GL.Vertex3(0, 1, 0); GL.Vertex3(-1, -1, 1); GL.Vertex3(1, -1, 1);

            // Cara derecha
            GL.Normal3(0.5, 0.5, 0);
            GL.Vertex3(0, 1, 0); GL.Vertex3(1, -1, 1); GL.Vertex3(1, -1, -1);

            // Cara trasera
            GL.Normal3(0, 0.5, -0.5);
            GL.Vertex3(0, 1, 0); GL.Vertex3(1, -1, -1); GL.Vertex3(-1, -1, -1);

            // Cara izquierda
            GL.Normal3(-0.5, 0.5, 0);
            GL.Vertex3(0, 1, 0); GL.Vertex3(-1, -1, -1); GL.Vertex3(-1, -1, 1);

            GL.End();

            // Base
            GL.Begin(PrimitiveType.Quads);
            GL.Normal3(0, -1, 0);
            GL.Vertex3(-1, -1, 1); GL.Vertex3(-1, -1, -1);
            GL.Vertex3(1, -1, -1); GL.Vertex3(1, -1, 1);
            GL.End();
        }

        private void DrawSphere(float radius, int slices, int stacks)
        {
            for (int i = 0; i < stacks; i++)
            {
                double lat0 = Math.PI * (-0.5 + (double)i / stacks);
                double z0 = Math.Sin(lat0);
                double zr0 = Math.Cos(lat0);

                double lat1 = Math.PI * (-0.5 + (double)(i + 1) / stacks);
                double z1 = Math.Sin(lat1);
                double zr1 = Math.Cos(lat1);

                GL.Begin(PrimitiveType.QuadStrip);
                for (int j = 0; j <= slices; j++)
                {
                    double lng = 2 * Math.PI * (double)j / slices;
                    double x = Math.Cos(lng);
                    double y = Math.Sin(lng);

                    GL.Normal3(x * zr0, y * zr0, z0);
                    GL.Vertex3(radius * x * zr0, radius * y * zr0, radius * z0);

                    GL.Normal3(x * zr1, y * zr1, z1);
                    GL.Vertex3(radius * x * zr1, radius * y * zr1, radius * z1);
                }
                GL.End();
            }
        }

        private void DrawCylinder(float radius, float height, int segments)
        {
            float yTop = height / 2;
            float yBot = -height / 2;

            // Cuerpo del cilindro
            GL.Begin(PrimitiveType.QuadStrip);
            for (int i = 0; i <= segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = (float)Math.Cos(angle) * radius;
                float z = (float)Math.Sin(angle) * radius;

                GL.Normal3(x, 0, z);
                GL.Vertex3(x, yTop, z);
                GL.Vertex3(x, yBot, z);
            }
            GL.End();

            // Tapa superior
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Normal3(0, 1, 0);
            GL.Vertex3(0, yTop, 0);
            for (int i = 0; i <= segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = (float)Math.Cos(angle) * radius;
                float z = (float)Math.Sin(angle) * radius;
                GL.Vertex3(x, yTop, z);
            }
            GL.End();

            // Tapa inferior
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Normal3(0, -1, 0);
            GL.Vertex3(0, yBot, 0);
            for (int i = segments; i >= 0; i--)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = (float)Math.Cos(angle) * radius;
                float z = (float)Math.Sin(angle) * radius;
                GL.Vertex3(x, yBot, z);
            }
            GL.End();
        }

        private void DrawCone(float radius, float height, int segments)
        {
            float yBot = -height / 2;
            float yTop = height / 2;

            // Cuerpo del cono
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Normal3(0, 1, 0);
            GL.Vertex3(0, yTop, 0);
            for (int i = 0; i <= segments; i++)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = (float)Math.Cos(angle) * radius;
                float z = (float)Math.Sin(angle) * radius;
                GL.Normal3(x, 0.5f, z);
                GL.Vertex3(x, yBot, z);
            }
            GL.End();

            // Base del cono
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Normal3(0, -1, 0);
            GL.Vertex3(0, yBot, 0);
            for (int i = segments; i >= 0; i--)
            {
                double angle = 2 * Math.PI * i / segments;
                float x = (float)Math.Cos(angle) * radius;
                float z = (float)Math.Sin(angle) * radius;
                GL.Vertex3(x, yBot, z);
            }
            GL.End();
        }

        private void DrawTorus(float innerRadius, float outerRadius, int sides, int rings)
        {
            for (int i = 0; i < rings; i++)
            {
                GL.Begin(PrimitiveType.QuadStrip);
                for (int j = 0; j <= sides; j++)
                {
                    for (int k = 0; k <= 1; k++)
                    {
                        double s = (i + k) % rings + 0.5;
                        double t = j % sides;

                        double x = (outerRadius + innerRadius * Math.Cos(s * 2 * Math.PI / rings)) * Math.Cos(t * 2 * Math.PI / sides);
                        double y = (outerRadius + innerRadius * Math.Cos(s * 2 * Math.PI / rings)) * Math.Sin(t * 2 * Math.PI / sides);
                        double z = innerRadius * Math.Sin(s * 2 * Math.PI / rings);

                        double nx = Math.Cos(s * 2 * Math.PI / rings) * Math.Cos(t * 2 * Math.PI / sides);
                        double ny = Math.Cos(s * 2 * Math.PI / rings) * Math.Sin(t * 2 * Math.PI / sides);
                        double nz = Math.Sin(s * 2 * Math.PI / rings);

                        GL.Normal3(nx, ny, nz);
                        GL.Vertex3(x, y, z);
                    }
                }
                GL.End();
            }
        }

        private void DrawOctahedron()
        {
            // Vértices del octaedro
            float[][] vertices = new float[][] {
                new float[] { 1, 0, 0 },   // 0
                new float[] { -1, 0, 0 },  // 1
                new float[] { 0, 1, 0 },   // 2
                new float[] { 0, -1, 0 },  // 3
                new float[] { 0, 0, 1 },   // 4
                new float[] { 0, 0, -1 }   // 5
            };

            GL.Begin(PrimitiveType.Triangles);

            // Mitad superior
            DrawTriangle(vertices[4], vertices[2], vertices[0]);
            DrawTriangle(vertices[0], vertices[2], vertices[5]);
            DrawTriangle(vertices[5], vertices[2], vertices[1]);
            DrawTriangle(vertices[1], vertices[2], vertices[4]);

            // Mitad inferior
            DrawTriangle(vertices[4], vertices[0], vertices[3]);
            DrawTriangle(vertices[0], vertices[5], vertices[3]);
            DrawTriangle(vertices[5], vertices[1], vertices[3]);
            DrawTriangle(vertices[1], vertices[4], vertices[3]);

            GL.End();
        }

        private void DrawTriangle(float[] v1, float[] v2, float[] v3)
        {
            // Calcular normal
            float[] edge1 = new float[] { v2[0] - v1[0], v2[1] - v1[1], v2[2] - v1[2] };
            float[] edge2 = new float[] { v3[0] - v1[0], v3[1] - v1[1], v3[2] - v1[2] };
            float[] normal = new float[] {
                edge1[1] * edge2[2] - edge1[2] * edge2[1],
                edge1[2] * edge2[0] - edge1[0] * edge2[2],
                edge1[0] * edge2[1] - edge1[1] * edge2[0]
            };

            GL.Normal3(normal[0], normal[1], normal[2]);
            GL.Vertex3(v1[0], v1[1], v1[2]);
            GL.Vertex3(v2[0], v2[1], v2[2]);
            GL.Vertex3(v3[0], v3[1], v3[2]);
        }
    }
}