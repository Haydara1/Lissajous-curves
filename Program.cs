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


    static void Main(string[] args)
    {
        A = 1;
        B = 1;

        Raylib.InitWindow(1080, 720, "Lissajous Curves");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}