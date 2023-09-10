namespace Lissajous_curves;

using Raylib_cs;


internal class Program
{
    static private int a;

    static public int A
    {
        get { return a; }
        set { a = value; }
    }

    static private int b;

    static public int B
    {
        get { return b; }
        set { b = value; }
    }

    static private int width;

    static public int Width
    {
        get { return width; }
        set { width = value * 120; }
    }

    static private int AngularVelocity = 10;

    static void Main(string[] args)
    {
        A = 1;
        B = 1;

        Width = 6;

        Raylib.InitWindow(Width, Width, "Lissajous Curves");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            DrawCircles();
            DrawMovingPoints();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }

    static void DrawCircles()
    {
        for (int i = 0; i < Width / 120; i++)
        {
            Raylib.DrawCircleLines(i * 120 + 60, 60, 50, Color.WHITE);
            Raylib.DrawCircleLines(60, i * 120 + 60, 50, Color.WHITE);
        }
    }

    static void DrawMovingPoints()
    {
           
    }

}