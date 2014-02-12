import wpf

from System.Windows import Window

class Window2(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'Window2.xaml')
