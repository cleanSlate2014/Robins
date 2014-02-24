from System import *
from System.Windows import *
from System.Windows.Controls import *
from System.Windows.Data import *
from System.Windows.Documents import *
from System.Windows.Media import *
from System.Windows.Navigation import *
from System.Windows.Shapes import *

import wpf

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'Window1.xaml')
    





