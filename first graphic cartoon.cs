using SplashKitSDK;

using static SplashKitSDK.SplashKit;

class Program
{
    public static void Main()
    {
        Window window = new Window("Cute Bunny", 800, 600);

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);
            SplashKit.FillCircle(Color.Yellow, 400, 300, 100); 
            SplashKit.FillCircle(Color.Black, 380, 280, 10);
            SplashKit.FillCircle(Color.Black, 420, 280, 10);
            SplashKit.FillEllipse(Color.Pink, 370, 330, 40, 30);
            SplashKit.FillCircle(Color.Black, 350, 210, 30);
            SplashKit.FillCircle(Color.Black, 440, 210, 30);
            SplashKit.FillCircle(Color.Yellow, 400, 500, 100);
            SplashKit.FillCircle(Color.Black, 400, 500, 50);


            

           
            
            SplashKit.RefreshScreen(60);
        }
    }
}

