namespace Lissajous_curves;

using Raylib_cs;

unsafe public struct ReferenceCircle
{
    public int Radius;
    public int PosX;
    public int PosY;
    public double AngularVelocity;
    public double* Time;

    public ReferenceCircle(int radius, int posX, int posY, double angularVelocity, double* time)
    {
        Radius = radius;
        PosX = posX;
        PosY = posY;
        AngularVelocity = angularVelocity;
        Time = time;
        Update();
    }
     
    public void Update()
    {
        Raylib.DrawCircleLines(PosX, PosY, Radius, Color.WHITE);
        Raylib.DrawCircle((int)(PosX + Radius * Math.Cos(AngularVelocity * *Time)),
                (int)(PosY + Radius * Math.Sin(AngularVelocity * *Time)), 5, Color.YELLOW);
    }

}
