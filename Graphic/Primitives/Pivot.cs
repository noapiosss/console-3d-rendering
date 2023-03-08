using System.Numerics;
using maze.Graphic.Extensions;

namespace maze.Graphic.Primitives
{
    public class Pivot
    {
        public Vector3 Center { get; protected set; }
        public Vector3 Forward { get; protected set; }
        public Vector3 Up { get; protected set; }
        public Vector3 Right { get; protected set; }

        public Pivot(Vector3 center, Vector3 forward, Vector3 up, Vector3 right)
        {
            Center = center;
            Forward = forward;
            Up = up;
            Right = right;
        }

        public Matrix4x4 LocalCoordsMatrix => new
        (
            Right.X, Up.X, Forward.X, 0,
            Right.Y, Up.Y, Forward.Y, 0,
            Right.Z, Up.Z, Forward.Z, 0,
            0, 0, 0, 0
        );

        public Matrix4x4 GlobalCoordsMatrix => new
        (
            Right.X, Right.Y, Right.Z, 0,
            Up.X, Up.Y, Up.Z, 0,
            Forward.X, Forward.Y, Forward.Z, 0,
            0, 0, 0, 0
        );

        public Vector3 ToLocalCoords(Vector3 global)
        {
            return Vector3.Transform(global - Center, LocalCoordsMatrix);
        }

        public Vector3 ToGlobalCoords(Vector3 local)
        {
            return Vector3.Transform(local, GlobalCoordsMatrix) + Center;
        }

        public void Move(Vector3 v)
        {
            Center += v;
        }

        public void Rotate(Vector3 axis, float angle)
        {
            Right = Right.RotateAround(axis, angle);
            Up = Up.RotateAround(axis, angle);
            Forward = Forward.RotateAround(axis, angle);
        }
    }
}