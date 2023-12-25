using SharpGDI;

GDI.InitContext(0, 0, 800, 600);
            
GDI.Begin();
GDI.DrawRectangle(0, 0, 100, 200, GDI.FromRgb(255, 255, 255));
GDI.PrintText("Hello World!", 10, 100, 100, 10, GDI.FromRgb(255, 0, 0));
        
GDI.ReleaseContext();