namespace Lissajous_curves;

using Raylib_cs;

unsafe public struct ReferenceCircle
{
    public int Radius;
    public int PosX;
    public int PosY;
    public double AngularVelocity;
    public double* Time;
    public bool Removable;

    public ReferenceCircle(int radius, int posX, int posY, double angularVelocity, double* time, bool removable = true)
    {
        Radius = radius;
        PosX = posX;
        PosY = posY;
        AngularVelocity = angularVelocity;
        Time = time;
        Removable = removable;
        Update();
    }
     
    public (int x, int y) Update()
    {
        int X = (int)(PosX + Radius * Math.Cos(AngularVelocity * *Time));
        int Y = (int)(PosY + Radius * Math.Sin(AngularVelocity * *Time));

        Raylib.DrawCircleLines(PosX, PosY, Radius, Color.WHITE);

        if(Removable)
            Raylib.DrawCircle( X, Y, 5, Color.YELLOW);

        return (X, Y);
    }

}
