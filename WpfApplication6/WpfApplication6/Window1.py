import wpf
import clr
clr.AddReference("System")
from System.Windows import Window

class Window1(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'Window1.xaml')
