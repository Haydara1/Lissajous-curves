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

    static public int Radius = 50;

    static private int AngularVelocity = 5;

    static private double Time = 0;

    static void Main(string[] args)
    {
        A = 1;
        B = 1;

        Width = 6;

        Raylib.InitWindow(Width, Width, "Lissajous Curves");
        Raylib.SetTargetFPS(24);
        

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            DrawCircles();
            DrawMovingPoints();

            Raylib.EndDrawing();

            Time += 0.01;
        }

        Raylib.CloseWindow();
    }

    static void DrawCircles()
    {
        for (int i = 0; i < Width / 120; i++)
        {
            Raylib.DrawCircleLines(i * 120 + 60, 60, Radius, Color.WHITE);
            Raylib.DrawCircleLines(60, i * 120 + 60, Radius, Color.WHITE);
        }
    }

    static void DrawMovingPoints()
    {
        for (int i = 0; i < Width; i += 120)
        {
            double AngVelCng = Math.Max(i / 120, 0.5);

            Raylib.DrawCircle((int)(i + 60 + Radius * Math.Cos(AngularVelocity * AngVelCng * Time)), 
                (int)(60 + Radius * Math.Sin(AngularVelocity * AngVelCng * Time)), 5, Color.YELLOW);

            Raylib.DrawCircle((int)(60 + Radius * Math.Cos(AngularVelocity * AngVelCng * Time)),
                (int)(i + 60 + Radius * Math.Sin(AngularVelocity * AngVelCng * Time)), 5, Color.YELLOW);
        }
    }

}