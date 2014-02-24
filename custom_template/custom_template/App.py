import wpf

from System.Windows import *
import clr


clr.AddReference("PresentationFramework")
clr.AddReference("PresentationCore")
clr.AddReference("windowsbase")

class App(Application):
    def __init__(self):
        wpf.LoadComponent(self, 'App.xaml')

    def trail(self):
        pass


  