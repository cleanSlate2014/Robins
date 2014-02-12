import wpf
import clr
clr.AddReference("System")
clr.AddReference("System.Windows")
clr.AddReference("PresentationCore")
clr.AddReference("System.Drawing")

from System.Windows import *
from System.Windows.Media import *
from System.Drawing import *
from System.Windows.Media import *

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'WpfApplication5.xaml')

    

    
    def TextBlock_MouseLeftButtonDown(self, sender, e):
        self.close.Fill = Brushes.Black
        self.Close()
        
    
    def TextBlock_MouseLeftButtonDown1(self, sender, e):
        self.mywindow.WindowState = self.mywindow.WindowState.Minimized
    
    def close_IsMouseDirectlyOverChanged(self, sender, e):
        pass
    
    def TextBlock_MouseEnter(self, sender, e):
        #Defigning an event for hover color change on minimize button
        #self.minimize.Fill = Brushes.
        pass
    
       

if __name__ == '__main__':
    Application().Run(MyWindow())
