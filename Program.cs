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

    unsafe static void Main(string[] args)
    {
        A = 1;
        B = 1;

        Width = 6;

        Raylib.InitWindow(Width, Width, "Lissajous Curves");
        Raylib.SetTargetFPS(24);

        Console.Clear();

        double Time = 0;
        double* TmPtr = &Time;

        ReferenceCircle[] referenceCircles = new ReferenceCircle[]
        {
            new ReferenceCircle(Radius, 60, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 180, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 300, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 420, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 540, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 660, 60, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 60, 180, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 60, 300, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 60, 420, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 60, 540, AngularVelocity, TmPtr),
            new ReferenceCircle(Radius, 60, 660, AngularVelocity, TmPtr),

        };


        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            foreach (ReferenceCircle referenceCircle in referenceCircles)
                referenceCircle.Update();

            Raylib.EndDrawing();

            Time += 0.01;
        }

        Raylib.CloseWindow();
    }

}