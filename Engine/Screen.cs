using System.Numerics;

namespace Maze.Engine
{
    public class Screen
    {
        public Vector3 CameraPosition { get; set; }
        public Vector3 CameraForward { get; set; }
        public Vector3 CameraUp { get; set; }
        public Vector3 CameraRight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public float FocalDistance { get; set; }

        public Screen(Vector3 cameraPosition, Vector3 cameraForward, Vector3 cameraUp, Vector3 cameraRight, int height, int widht, float focalDistance)
        {
            CameraPosition = cameraPosition;
            CameraForward = cameraForward;
            CameraUp = cameraUp;
            CameraRight = cameraRight;
            Height = height;
            Width = widht;
            FocalDistance = focalDistance;
        }

    }
}