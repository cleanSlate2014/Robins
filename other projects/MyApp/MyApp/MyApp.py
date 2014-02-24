import wpf
import clr


from System.Windows import Application, Window
from Window1 import *
clr.AddReferenceToFile("Window1.xaml")

class MyWindow(Application):
    def __init__(self):
        wpf.LoadComponent(self, 'MyApp.xaml')
        

    def AppStartup(self,sender,args):
        Application.Run(Window1())

    
   
        
    

if __name__ == '__main__':
    Window1()
    Application.Run(MyWindow())

