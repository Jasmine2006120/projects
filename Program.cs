using SplashKitSDK;
using static SplashKitSDK.SplashKit;

class Program
{
    static void Main()
    {
        Window window = new Window("Chitkara Logo", 600, 400);
        while (!window.CloseRequested)
        {
            ProcessEvents();
            ClearScreen(Color.White);
            SplashKit.FillRectangle(Color.Red, 100, 50, 300, 300);
            SplashKit.FillRectangle(Color.White, 160, 230, 60, 60);
            SplashKit.FillRectangle(Color.White, 160, 180, 100, 25);
            SplashKit.FillRectangle(Color.White, 260, 180, 25, 110);
            SplashKit.FillRectangle(Color.White, 160, 120, 170, 25);
            SplashKit.FillRectangle(Color.White, 320, 120, 25, 170);
            RefreshScreen(60);
        }
    }
}
